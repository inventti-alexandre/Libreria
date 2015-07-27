using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class FrmDevolucionConsignaciones : FormBase
    {
        private readonly IConsignacionNegocio _consignacionNegocio;
        private Proveedor Proveedor { get; set; }
        private decimal _total;

        public FrmDevolucionConsignaciones(IFormFactory formFactory, ILaPazUow uow, IConsignacionNegocio consignacionNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            _consignacionNegocio = consignacionNegocio;

            InitializeComponent();
        }

        public async Task RefrescarListado()
        {
            Proveedor = Uow.Proveedores.Obtener(p => p.Id == ucFiltrosConsignaciones.ProveedorId);

            flpContainer.Controls.Clear();
            var resultados = _consignacionNegocio.ConsignacionesParaDevolver(
            ucFiltrosConsignaciones.ProveedorId,
            ucFiltrosConsignaciones.Desde,
            ucFiltrosConsignaciones.Hasta.AddDays(1));

            if (resultados.Any())
            {
                var agrupados = resultados.GroupBy(x => x.Editorial);

                foreach (var grupo in agrupados)
                {
                    var item = new UcConsignacionesDevolucionPorEditorial(grupo.Key, grupo.ToList());
                    flpContainer.Controls.Add(item);
                }
                chxImprimir.Enabled = true;
                BtnGuardar.Enabled = true;
                BtnImprimir.Enabled = true;
                pnlAcciones.Visible = true;
            }
            else
            {
                chxImprimir.Enabled = false;
                BtnGuardar.Enabled = false;
                BtnImprimir.Enabled = false;
                pnlAcciones.Visible = false;
            }
            
        }


        private void FrmRendicionConsignaciones_Load(object sender, EventArgs e)
        {
            ucFiltrosConsignaciones.Filtered += Filtered;
            ucFiltrosConsignaciones.Cleaned += SeLimpioLosFiltros;
        }

        private void SeLimpioLosFiltros(object sender, EventArgs e)
        {
            chxImprimir.Enabled = false;
            BtnGuardar.Enabled = false;
            BtnImprimir.Enabled = false;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //TODO: hago toda la lógica de Guardar los malditos datos

            var listado = ObtenerListado();

            GuardarCambios(listado);
        }

        private List<ConsignacionesParaDevolver> ObtenerListado()
        {
            var listado = new List<ConsignacionesParaDevolver>();
            foreach (UcConsignacionesDevolucionPorEditorial usercontrol in flpContainer.Controls)
            {
                listado.AddRange(usercontrol.ObtenerListado());
            }
            return listado.Where(t => t.CantidadADevolver > 0).ToList();
        }

        private void GuardarCambios(List<ConsignacionesParaDevolver> listado)
        {
            if (listado.Sum(x => x.CantidadADevolver) > 0)
            {
                //Primero descuento para cada título, la cantidad a rendir distribuida en
                //todas sus lineas de TitulosConsignacionesVendidas
                var provId = ucFiltrosConsignaciones.ProveedorId;
                var desde = ucFiltrosConsignaciones.Desde;
                var hasta = ucFiltrosConsignaciones.Hasta.AddDays(1);

                var originales = Uow.TitulosConsignaciones.Listado()
                                    .Where(tc => (provId == null || provId == tc.ProveedorId)
                                      && desde < tc.FechaAlta && hasta > tc.FechaAlta && tc.CntCn > tc.CntDev + tc.CntVn)
                                    .OrderBy(x => x.FechaAlta).ToList();

                foreach (var titulo in listado)
                {
                    var cantADevolver = titulo.CantidadADevolver;
                    var consignaciones = originales.Where(tc => tc.TituloId == titulo.TituloId).ToList();

                    var i = 0;
                    while (cantADevolver > 0)
                    {
                        var consignacion = consignaciones.ElementAt(i);
                        var devolver = cantADevolver > consignacion.CntCn - consignacion.CntDev - consignacion.CntVn
                                         ? consignacion.CntCn - consignacion.CntVn - consignacion.CntDev
                                         : cantADevolver;

                        consignacion.CntDev += devolver;
                        Uow.TitulosConsignaciones.Modificar(consignacion);
                        cantADevolver -= Convert.ToInt32(devolver);
                        i++;
                    }
                }

                //Ahora guardo la tabla ConsignacionRendida
                var consignacionDevuelta = new TitulosConsignacionesDevuelta()
                                              {
                                                  FechaAlta = DateTime.Now,
                                                  LCN = CalcularLCN(),
                                                  Observaciones = TxtObservaciones.Text,
                                                  OperadorAltaId = Context.OperadorActual.Id,
                                                  ProveedorId = Proveedor.Id,
                                                  SucursalAltaId = Context.SucursalActual.Id
                                              };

                foreach (var t in listado)
                {
                    var detalle = new TitulosConsignacionesDevueltasDetalle()
                                      {
                                          Cantidad = t.CantidadADevolver,
                                          TituloConsignacionDevueltaId = consignacionDevuelta.Id,
                                          TituloId = t.TituloId.GetValueOrDefault()
                                      };
                    Uow.TitulosConsignacionesDevueltasDetalles.Agregar(detalle);
                }
                Uow.TitulosConsignacionesDevueltas.Agregar(consignacionDevuelta);

                Uow.Commit();

                if (chxImprimir.Checked)
                {
                    using (var popup = new FrmReporteConsignacionesDevueltas(Uow, listado,
                        ucFiltrosConsignaciones.ProveedorId.GetValueOrDefault(),
                        ucFiltrosConsignaciones.Desde, ucFiltrosConsignaciones.Hasta))
                    {
                        popup.ShowDialog();
                    }
                }

                ReiniciarVentana();
            }
            else
            {
                MessageBox.Show("No hay consignaciones por devolver");
            }
        }

        private string CalcularLCN()
        {
            var ultimoPresupuesto = Uow.TitulosConsignacionesDevueltas.Listado().Where(p => p.SucursalAltaId == Context.SucursalActual.Id)
                .OrderByDescending(p => p.FechaAlta).Take(1).FirstOrDefault();
            int lcnNuevo = 0;

            if (ultimoPresupuesto != null)
            {
                var lcn = ultimoPresupuesto.LCN.Substring(5);
                lcnNuevo = int.TryParse(lcn, out lcnNuevo) ? lcnNuevo : 0;
            }
            lcnNuevo += 1;

            return "X" + "0001" + lcnNuevo.ToString().PadLeft(8, '0');

        }

        private void ReiniciarVentana()
        {
            ucFiltrosConsignaciones.ReiniciarFiltros();
            flpContainer.Controls.Clear();
            chxImprimir.Enabled = false;
            BtnGuardar.Enabled = false;
            BtnImprimir.Enabled = false;
            pnlAcciones.Visible = false;
            TxtObservaciones.Text = string.Empty;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            var listado = ObtenerListado();

            if (listado.Sum(x => x.CantidadADevolver) > 0)
            {
                using (var popup = new FrmReporteConsignacionesDevueltas(Uow, listado,
                                ucFiltrosConsignaciones.ProveedorId.GetValueOrDefault(),
                                ucFiltrosConsignaciones.Desde, ucFiltrosConsignaciones.Hasta))
                {
                    popup.ShowDialog(); 
                }
            }
        }
    }
}
