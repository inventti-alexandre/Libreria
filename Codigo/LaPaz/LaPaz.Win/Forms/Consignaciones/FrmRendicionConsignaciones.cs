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
    public partial class FrmRendicionConsignaciones : FormBase
    {
        private readonly IConsignacionNegocio _consignacionNegocio;
        private Proveedor Proveedor { get; set; }
        private decimal _total;
        private int _cantidad;

        public FrmRendicionConsignaciones(IFormFactory formFactory, ILaPazUow uow, IConsignacionNegocio consignacionNegocio)
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
            //var resultados = _consignacionNegocio.VentasSinRendir(
            //    ucFiltrosConsignaciones.ProveedorId,
            //    ucFiltrosConsignaciones.Desde,
            //    ucFiltrosConsignaciones.Hasta.AddDays(1));

            var inicio = ucFiltrosConsignaciones.Desde.Date;
            var fin = ucFiltrosConsignaciones.Hasta.Date.AddDays(1);

            var resultados = _consignacionNegocio.VentasSinRendir(
              ucFiltrosConsignaciones.ProveedorId,
              inicio,
              fin,
              Context.SucursalActual.Id);

            if (resultados.Any())
            {
                var agrupados = resultados.GroupBy(x => x.Editorial);

                foreach (var grupo in agrupados)
                {
                    var descuento = Proveedor.PorcentajeDescuento;
                    var item = new UcConsignacionesPorEditorial(grupo.Key, grupo.ToList(), descuento);
                    item.GridDatabound += ItemOnGridDatabound;
                    flpContainer.Controls.Add(item);
                }
                chxImprimir.Enabled = true;
                BtnGuardar.Enabled = true;
                BtnImprimir.Enabled = true;
                pnlAcciones.Visible = true;
                ActualizarTotal();
            }
            else
            {
                chxImprimir.Enabled = false;
                BtnGuardar.Enabled = false;
                BtnImprimir.Enabled = false;
                pnlAcciones.Visible = false;
            }
        }

        private void ItemOnGridDatabound(object sender, EventArgs eventArgs)
        {
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            var listado = ObtenerListado();
            lblTotal1.Visible = true;
            lblTotalValue.Visible = true;
            lblObservaciones.Visible = true;
            TxtObservaciones.Visible = true;
            _total = listado.Sum(x => x.TotalARendir);
            _cantidad = listado.Sum(x => x.CantidadARendir);
            lblTotalValue.Text = String.Format("${0}", _total.ToString("N2"));
            lblTotalCantidad.Text = _cantidad.ToString();
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

        private List<ConsignacionSinRendir> ObtenerListado()
        {
            var listado = new List<ConsignacionSinRendir>();
            foreach (UcConsignacionesPorEditorial usercontrol in flpContainer.Controls)
            {
                listado.AddRange(usercontrol.ObtenerListado());
            }
            return listado.Where(t => t.CantidadARendir > 0).ToList();
        }

        private void GuardarCambios(List<ConsignacionSinRendir> listado)
        {
            if (listado.Sum(x => x.CantidadARendir) > 0)
            {
                //Primero descuento para cada título, la cantidad a rendir distribuida en
                //todas sus lineas de TitulosConsignacionesVendidas
                var provId = ucFiltrosConsignaciones.ProveedorId;
                //var desde = ucFiltrosConsignaciones.Desde.AddDays(-1);
                //var hasta = ucFiltrosConsignaciones.Hasta.AddDays(1);

                var desde = ucFiltrosConsignaciones.Desde.Date;
                var hasta = ucFiltrosConsignaciones.Hasta.AddDays(1);

                var originales = Uow.TitulosConsignacionesVendidas.Listado()
                                    .Where(tcv => (provId == null || provId == tcv.ProveedorId)
                                      && (desde) < tcv.FechaAlta && hasta > tcv.FechaAlta && tcv.CntCn > tcv.CntPag)
                                    .OrderBy(x => x.FechaAlta).ToList();

                foreach (var titulo in listado)
                {
                    var cantARendir = titulo.CantidadARendir;
                    var consignacionesVendidas = originales.Where(tcv => tcv.TituloId == titulo.TituloId).ToList();

                    var i = 0;
                    while (cantARendir > 0)
                    {
                        var consignacion = consignacionesVendidas.ElementAt(i);
                        var rendir = cantARendir > consignacion.CntCn - consignacion.CntPag
                                         ? consignacion.CntCn - consignacion.CntPag
                                         : cantARendir;

                        consignacion.CntPag += rendir;
                        Uow.TitulosConsignacionesVendidas.Modificar(consignacion);
                        cantARendir -= Convert.ToInt32(rendir);
                        i++;
                    }
                }

                //Ahora guardo la tabla ConsignacionRendida
                var consignacionRendida = new TituloConsignacionRendida()
                                              {
                                                  FechaAlta = DateTime.Now,
                                                  Id = Guid.NewGuid(),
                                                  Importe = _total,
                                                  LCN = CalcularLCN(),
                                                  Observaciones = TxtObservaciones.Text,
                                                  OperadorAltaId = Context.OperadorActual.Id,
                                                  ProveedorId = Proveedor.Id,
                                                  SucursalAltaId = Context.SucursalActual.Id,
                                                  TipoConsignacionId = 2,
                                                  FechaConsignacion = DateTime.Now //TODO ELIMINAR O NO
                                              };

                foreach (var t in listado)
                {
                    var detalle = new TituloConsignacionRendidasDetalle()
                                      {
                                          Id = Guid.NewGuid(),
                                          Cantidad = t.CantidadARendir,
                                          Importe = t.TotalARendir,
                                          PorcentajeDescuento = t.Descuento.GetValueOrDefault(),
                                          PrecioCompra = t.PrecioCompraCalculado,
                                          PrecioVenta = t.PrecioVentaTitulo.GetValueOrDefault(),
                                          TituloConsignacionRendidaId = consignacionRendida.Id,
                                          TituloId = t.TituloId.GetValueOrDefault()
                                      };
                    Uow.TitulosConsignacionesRendidasDetalle.Agregar(detalle);
                }
                Uow.TitulosConsignacionesRendidas.Agregar(consignacionRendida);

                Uow.Commit();

                if (chxImprimir.Checked)
                {
                    using (var popup = new FrmReporteConsignaciones(Uow, listado,
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
                MessageBox.Show("No hay consignaciones por rendir");
            }
        }

        private string CalcularLCN()
        {
            var ultimoPresupuesto = Uow.TitulosConsignacionesRendidas.Listado().Where(p => p.SucursalAltaId == Context.SucursalActual.Id)
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
            lblTotalValue.Text = string.Empty;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            var listado = ObtenerListado();

            if (listado.Sum(x => x.CantidadARendir) > 0)
            {
                using (var popup = new FrmReporteConsignaciones(Uow, listado,
                    ucFiltrosConsignaciones.ProveedorId.GetValueOrDefault(),
                    ucFiltrosConsignaciones.Desde, ucFiltrosConsignaciones.Hasta))
                {
                    popup.ShowDialog();
                }
            }
        }

        private void ucFiltrosConsignaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
