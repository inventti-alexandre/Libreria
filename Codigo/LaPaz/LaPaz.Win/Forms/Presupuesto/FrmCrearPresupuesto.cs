using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;
using LaPaz.Win.Presupuesto;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class FrmCrearPresupuesto : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IClienteNegocio _clienteNegocio;
        private Cliente _cliente;
        private Presupuestos _presupuesto;
        private readonly ActionFormMode _formMode;

        public FrmCrearPresupuesto(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                             IClienteNegocio clienteNegocio,
                             IFormRegistry formRegistry)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _clienteNegocio = clienteNegocio;
            _presupuesto = new Presupuestos();

            InitializeComponent();

            this.Text = Resources.LabelPresupuesto;
        }

        public event EventHandler PresupuestoRealizado;

        private void FrmCrearPresupuesto_Load(object sender, EventArgs e)
        {
            this.UcBuscadorCliente.OcultarModosPago();
            this.UcTitulosVenta.HabilitarPresupuesto();

            this.TxtFecha.Text = _clock.Now.ToShortDateString();
            this.TxtNroPresupuesto.Text = CalcularLCN();

            this.UcBuscadorCliente.BuscarFinished += UcBuscadorClienteOnBuscarFinished;
            this.UcTitulosVenta.VentaTitulosChanged += UcTitulosVentaOnVentaTitulosChanged;
            this.UcClienteDetalle.ClienteEdited += UcClienteDetalleOnClienteEdited;
            this.UcTotalesPresupuesto.DescuentoChanged += UcTotalesPresupuestoOnDescuentoChanged;
            this.UcTotalesPresupuesto.RecargoChanged += UcTotalesPresupuestoOnRecargoChanged;

        }

        private string CalcularLCN()
        {
            var ultimoPresupuesto = Uow.Presupuesto.Listado().Where(p => p.SucursalAltaId == Context.SucursalActual.Id)
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

        private void UcTotalesPresupuestoOnDescuentoChanged(object sender, int? e)
        {
            UcTitulosVenta.ActualizarDescuento(UcTotalesPresupuesto.Descuento);
            UcTotalesPresupuesto.SubTotal = UcTitulosVenta.CalcularSubTotal();
            UcTotalesPresupuesto.TotalPagar = UcTotalesPresupuesto.SubTotal;
        }

        private void UcTotalesPresupuestoOnRecargoChanged(object sender, int? e)
        {
            UcTitulosVenta.ActualizarRecargo(UcTotalesPresupuesto.Recargo);
            UcTotalesPresupuesto.SubTotal = UcTitulosVenta.CalcularSubTotal();
            UcTotalesPresupuesto.TotalPagar = UcTotalesPresupuesto.SubTotal;
        }

        private void UcTitulosVentaOnVentaTitulosChanged(object sender, IList<VentaTitulo> ventaTitulos)
        {
            if (UcTitulosVenta.Titulos.Count == 0)
            {
                // UcTotalesPresupuesto.LimpiarPagos();
                UcTotalesPresupuesto.SubTotal = 0;
                ActualizarTotal();
            }
            else
                ActualizarTotal();

        }

        private void UcClienteDetalleOnClienteEdited(object sender, Cliente cliente)
        {
            var clienteEdited = Uow.Clientes.Obtener(c => c.Id == cliente.Id, c => c.Localidad, c => c.Provincia, c => c.CondicionesVenta);
            ActualizarCliente(clienteEdited);
        }

        private void UcBuscadorClienteOnBuscarFinished(object sender, List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                if (clientes.Count == 1)
                {
                    ActualizarCliente(clientes.Single());
                }
                else
                {
                    //Mas de uno encontrado.
                    using (var seleccionarCliente = new FrmSeleccionarCliente(clientes))
                    {
                        seleccionarCliente.ClienteSelected += (o, cliente) =>
                        {
                            ActualizarCliente(cliente);
                            seleccionarCliente.Close();
                        };

                        seleccionarCliente.ShowDialog();
                    }
                }

            }
            else
            {
                CrearCliente();
            }
        }

        private void ActualizarCliente(Cliente cliente)
        {
            if (!cliente.Activo ?? true)
            {
                _messageBoxDisplayService.Show(this, string.Format(Resources.MensajeClienteInactivo, cliente.Denominacion, cliente.Cuit), Resources.LabelPresupuesto);
                return;
            }

            _cliente = cliente;

            var deudaTotal = _clienteNegocio.DeudaTotal(_cliente.Id, this.Context.SucursalActual.Id);
            var deudaVencida = _clienteNegocio.DeudaVencida(_cliente.Id, this.Context.SucursalActual.Id);

            UcClienteDetalle.ActualizarCliente(_cliente, deudaTotal, deudaVencida);
            UcBuscadorCliente.ActualizarFormaPago(_cliente);
        }

        private void CrearCliente()
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create))
            {
                formCrearCliente.ClienteAgregado += (sender, cliente) =>
                {
                    ActualizarCliente(cliente);
                    formCrearCliente.Close();
                };

                formCrearCliente.ShowDialog();
            }
        }

        private void ActualizarTotal()
        {
            var subTotal = UcTitulosVenta.CalcularSubTotal();
            UcTotalesPresupuesto.SubTotal = subTotal;

            UcTotalesPresupuesto.TotalPagar = UcTotalesPresupuesto.SubTotal.GetValueOrDefault();
        }

        private void BtnPresupuestar_Click(object sender, EventArgs e)
        {
            if (_cliente == null)
            {
                _messageBoxDisplayService.ShowError(Resources.ErrorMessageSeleccionarCliente);
                return;
            }

            if (!UcTitulosVenta.Titulos.Any())
            {
                _messageBoxDisplayService.ShowError(Resources.ErrorMessageVentaSinLibros);
                return;
            }


            RealizarPresupuesto();

            OnPresupuestoRealizado();
        }

        private void OnPresupuestoRealizado()
        {
            if (PresupuestoRealizado != null)
            {
                PresupuestoRealizado(this, new EventArgs());
            }
        }

        private void RealizarPresupuesto()
        {
            _presupuesto.Id = Guid.NewGuid();
            _presupuesto.Fecha = _clock.Now;
            _presupuesto.Concepto = "PRESUPUESTO DE LIBROS";
            _presupuesto.LCN = TxtNroPresupuesto.Text;
            _presupuesto.ClienteId = _cliente.Id;
            _presupuesto.Descuento = UcTotalesPresupuesto.Descuento;
            _presupuesto.Total = UcTotalesPresupuesto.TotalPagar;
            _presupuesto.FechaAlta = _clock.Now;
            _presupuesto.SucursalAltaId = Context.SucursalActual.Id;
            _presupuesto.OperadorAltaId = Context.OperadorActual.Id;

            Uow.Presupuesto.Agregar(_presupuesto);

            //VENTA DETALLE
            foreach (var titulo in UcTitulosVenta.Titulos.OrderBy(t => t.TituloNombre))
            {
                PresupuestosDetalle presupuestoDetalle = new PresupuestosDetalle();

                presupuestoDetalle.Id = Guid.NewGuid();
                presupuestoDetalle.PresupuestoId = _presupuesto.Id;
                presupuestoDetalle.TituloId = titulo.TituloId;
                presupuestoDetalle.Cantidad = titulo.Cantidad;
                presupuestoDetalle.Precio = titulo.SubTotal;
                presupuestoDetalle.FechaAlta = _clock.Now;
                presupuestoDetalle.SucursalAltaId = Context.SucursalActual.Id;
                presupuestoDetalle.OperadorAltaId = (Context.OperadorActual.Id);

                Uow.PresupuestoDetalle.Agregar(presupuestoDetalle);
            }

            Uow.Commit();

            _messageBoxDisplayService.ShowSuccess("Presupuesto Generado.");

            using (var crearPresupuesto = FormFactory.Create<FrmComprobantePresupuesto>(_presupuesto.Id))
            {
                crearPresupuesto._descripcion = "";
                crearPresupuesto._formaPago = "";
                crearPresupuesto._recargo = "";
                crearPresupuesto.ShowDialog();
            }
        }

        private void FrmCrearPresupuesto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                UcTitulosVenta.BtnAgregarTitulo_Click(null, null);
            }

            if (e.KeyCode == Keys.F3)
            {
                UcBuscadorCliente.Foco();
            }
        }
    }
}
