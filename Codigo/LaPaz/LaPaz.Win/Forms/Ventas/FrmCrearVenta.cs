using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Attributes;
using Framework.Comun.Utility;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Forms.Util;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using LaPaz.Win.Helpers;
using LaPaz.Win.Reportes;
using LaPaz.Win.Forms.Autenticacion;
using Telerik.WinControls.UI;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Response;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class FrmCrearVenta : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IVentaNegocio _ventaNegocio;
        private readonly IClienteNegocio _clienteNegocio;
        private readonly DirectPrint _directPrint;
        private Cliente _cliente;
        private int _id;
        private readonly ActionFormMode _formMode;

        public FrmCrearVenta(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                             IVentaNegocio ventaNegocio,
                             IClienteNegocio clienteNegocio,
                             IFormRegistry formRegistry, 
                             DirectPrint directPrint,
                             int id, 
                             ActionFormMode mode)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _ventaNegocio = ventaNegocio;
            _clienteNegocio = clienteNegocio;
            _directPrint = directPrint;
            _id = id;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);
        }

        public event EventHandler VentaRealizada;

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nueva venta";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Reserva" + _id;
                    BtnRecargarNroFactura.Enabled = false;
                    BtnReservarFactura.Enabled = false;
                    break;
            }
        }

        private void FrmCrearVenta_Load(object sender, EventArgs e)
        {
            this.TxtFecha.Text = _clock.Now.ToShortDateString();
            this.UcBuscadorCliente.BuscarFinished += UcBuscadorClienteOnBuscarFinished;
            this.UcBuscadorCliente.FormaPagoChanged += UcBuscadorClienteOnFormaPagoChanged;
            this.UcTitulosVenta.VentaTitulosChanged += UcTitulosVentaOnVentaTitulosChanged;

            this.UcTotalesVenta.TotalAPagarChanged += UcTitulosVentaOnTotalAPagarChanged;
            this.UcTotalesVenta.DescuentoChanged += UcTitulosVentaOnDescuentoChanged;
            this.UcTotalesVenta.RecargoChanged += UcTotalesVentaOnRecargoChanged;
            this.UcTotalesVenta.TotalChanged += UcTotalesVentaOnTotalChanged;
            this.UcTotalesVenta.FaltaPagarChanged += UcTotalesVentaOnFaltaPagarChanged;

            this.UcCuentaCorrienteInfo.AnticipoChanged += UcCuentaCorrienteInfoOnAnticipoChanged;
            this.UcClienteDetalle.ClienteEdited += UcClienteDetalleOnClienteEdited;

            if (_formMode == ActionFormMode.Create)
            {
                TxtNroFactura.Text = _ventaNegocio.SiguienteNumeroFactura(Context.OperadorActual.Id, Context.SucursalActual.Id).ToString();
            }
            if (_formMode == ActionFormMode.Edit)
            {
                TxtNroFactura.Text = _id.ToString();
            }

            UcBuscadorCliente.Foco();
        }

        private void UcTotalesVentaOnRecargoChanged(object sender, int? e)
        {
            UcTitulosVenta.ActualizarRecargo(UcTotalesVenta.Recargo);
        }

        private void UcTotalesVentaOnTotalChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void UcTitulosVentaOnDescuentoChanged(object sender, int? e)
        {
            UcTitulosVenta.ActualizarDescuento(UcTotalesVenta.Descuento);
        }

        private void UcCuentaCorrienteInfoOnAnticipoChanged(object sender, decimal? e)
        {
            UcTotalesVenta.GenerarPagoAutoNuevo(UcCuentaCorrienteInfo.Adeuda, FormaPago.CuentaCorriente);
        }

        private void UcTitulosVentaOnTotalAPagarChanged(object sender, decimal? e)
        {
            UcCuentaCorrienteInfo.Adeuda = UcTotalesVenta.TotalPagar - UcCuentaCorrienteInfo.Anticipo;
            UcCuentaCorrienteInfo.Total = UcTotalesVenta.TotalPagar;
        }

        private void UcTotalesVentaOnFaltaPagarChanged(object sender, decimal? e)
        {
            if (UcTotalesVenta.FaltaPagar != 0)
            {
                UcTotalesVenta.EliminarPagoEfectivo();
                if (UcTotalesVenta.FaltaPagar > 0)
                {
                    UcTotalesVenta.GenerarPagoAnticipoNuevo(UcTotalesVenta.FaltaPagar, FormaPago.Efectivo);
                }

            }
        }

        private void UcBuscadorClienteOnFormaPagoChanged(object sender, FormaPago e)
        {
            if (_cliente == null)
            {
                return;
            }

            UcTotalesVenta.Pagos.Clear();

            UcTotalesVenta.RefrescarPagos();

            if (UcBuscadorCliente.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente)
            {
                RPCtaccte.Visible = true;
                UcCuentaCorrienteInfo.Anticipo = 0;
            }
            else
            {
                RPCtaccte.Visible = false;
            }

            ActualizarTotal();
        }

        private void UcTitulosVentaOnVentaTitulosChanged(object sender, IList<VentaTitulo> ventaTitulos)
        {
            if (UcTitulosVenta.Titulos.Count == 0)
            {
                UcTotalesVenta.LimpiarPagos();
                UcTotalesVenta.SubTotal = 0;
                ActualizarTotal();
            }
            else
                ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            var subTotal = UcTitulosVenta.CalcularSubTotal();
            UcTotalesVenta.SubTotal = subTotal;

            UcTotalesVenta.TotalPagar = UcTotalesVenta.SubTotal.GetValueOrDefault() - UcTotalesVenta.Senas.GetValueOrDefault() -
                         UcTotalesVenta.CreditosDevolucion.GetValueOrDefault();
            // UcTotalesVenta.TotalPagar -= UcTotalesVenta.TotalPagar * UcTotalesVenta.Descuento.GetValueOrDefault() / 100;

            UcTotalesVenta.FaltaPagar = UcTotalesVenta.TotalPagar - UcTotalesVenta.TotalPagos();

            if (UcTotalesVenta.TotalPagar > 0)
            {
                if (UcBuscadorCliente.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente)
                    UcTotalesVenta.GenerarPagoAutoNuevo(UcTotalesVenta.TotalPagar - UcCuentaCorrienteInfo.Anticipo, FormaPago.CuentaCorriente);
                else
                    UcTotalesVenta.GenerarPagoAutoNuevo(UcTotalesVenta.TotalPagar, FormaPago.Efectivo);
            }
            else
            {
                UcTotalesVenta.Pagos.Clear();
            }
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

                if (this.UcTitulosVenta.CalcularSubTotal() > 0)
                {
                    // GenerarAutoPago();
                }
            }
            else
            {
                CrearCliente();
            }
        }

        private void UcClienteDetalleOnClienteEdited(object sender, Cliente cliente)
        {
            var clienteEdited = _clienteNegocio.ObtenerPorId(cliente.Id);
            ActualizarCliente(clienteEdited);
        }

        private void ActualizarCliente(Cliente cliente)
        {
            if (!cliente.Activo ?? true)
            {
                _messageBoxDisplayService.Show(this, string.Format(Resources.MensajeClienteInactivo, cliente.Denominacion, cliente.Cuit), Resources.LabelVentas);
                return;
            }

            _cliente = cliente;

            var deudaTotal = _clienteNegocio.DeudaTotal(_cliente.Id, this.Context.SucursalActual.Id);
            var deudaVencida = _clienteNegocio.DeudaVencida(_cliente.Id, this.Context.SucursalActual.Id);

            UcClienteDetalle.ActualizarCliente(_cliente, deudaTotal, deudaVencida);
            UcCuentaCorrienteInfo.ActualizarInfoCuentaCorriente(_cliente);

            UcTotalesVenta.SenasDisp = _ventaNegocio.SenaAFavorCliente(_cliente.Id, Context.SucursalActual.Id);
            UcTotalesVenta.CreditosDevolucionDisp = _ventaNegocio.CreditosPorDevolucion(_cliente.Id, Context.SucursalActual.Id);

            UcTotalesVenta.ActualizarMontosAFavor(UcTotalesVenta.SenasDisp, UcTotalesVenta.CreditosDevolucionDisp);
            UcTotalesVenta.Senas = 0;
            UcTotalesVenta.CreditosDevolucion = 0;

            UcBuscadorCliente.ActualizarFormaPago(_cliente);
        }

        private void CrearCliente()
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create))
            {
                int i = 0;
                if (int.TryParse(UcBuscadorCliente.Cuit, out i))
                    formCrearCliente.SetearDni(UcBuscadorCliente.Cuit);


                formCrearCliente.ClienteAgregado += (sender, cliente) =>
                {
                    ActualizarCliente(cliente);
                    formCrearCliente.Close();
                };

                formCrearCliente.ShowDialog();
            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
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

            if (!UcTotalesVenta.Validar())
            {
                return;
            }

            if (UcBuscadorCliente.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente
                    && UcTotalesVenta.SubTotal.Value <= UcTotalesVenta.Descuento.GetValueOrDefault())
            {
                _messageBoxDisplayService.ShowError("El descuento no puede superar al importe total de la venta");
                return;
            }

            if (UcBuscadorCliente.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente
                    && UcCuentaCorrienteInfo.Cuotas == null)
            {
                _messageBoxDisplayService.ShowError("Debe indicar la cantidad de cuotas del plan");
                return;
            }

            if (UcTitulosVenta.Titulos.Count > Context.SucursalActual.MaximoNroLineasPorVenta)
            {
                _messageBoxDisplayService.ShowError("Se ha superado el límite máximo de líneas por venta.");
                return;
            }

            //Ahora calculo el porcentaje de descuento para ver si no supera el maximo permitido
            //var porcentaje = (UcTotalesVenta.Descuento.GetValueOrDefault() * 100) / UcTotalesVenta.SubTotal.Value;
            var porcentaje = UcTotalesVenta.Descuento.GetValueOrDefault();
            var porcentajeNoAutorizado = porcentaje > Context.SucursalActual.MaximoPorcentajeDescuento;

            var importeNoAutorizado = UcTotalesVenta.SubTotal.Value >= Context.SucursalActual.MaximoImporteVenta;
            if (UcBuscadorCliente.CondicionVentaSeleccionada == CondicionVentaEnum.Contado)
                importeNoAutorizado = false;


            if (porcentajeNoAutorizado || importeNoAutorizado)
            {
                var operador = this.ObtenerOperadorAdministrador();
                if (operador == null)
                {
                    return;
                }
            }

            //Vuelto
            if (ChkVuelto.IsChecked && UcTotalesVenta.HayPagoEnEfectivo)
            {
                using (var frmVuelto = new FrmVuelto())
                {
                    frmVuelto.APagar = UcTotalesVenta.TotalEnEfectivo;
                    frmVuelto.Paga = UcTotalesVenta.TotalEnEfectivo;
                    frmVuelto.ShowDialog();
                }
            }

            RealizarVenta();
        }

        private void OnVentaRealizada()
        {
            if (VentaRealizada != null)
            {
                VentaRealizada(this, new EventArgs());
            }
        }

        private void RealizarVenta()
        {
            CrearVentaData ventaData = new CrearVentaData();

            ventaData.EsVentaReservada = _formMode == ActionFormMode.Edit;
            ventaData.OperadorId = Context.OperadorActual.Id;
            ventaData.SucursalId = Context.SucursalActual.Id;
            ventaData.NumeroComprobante = _id;
            ventaData.ClienteId = _cliente.Id;

            ventaData.TipoComprobanteSeleccionado = UcBuscadorCliente.TipoComprobanteSeleccionado;
            ventaData.CondicionVentaSeleccionada = UcBuscadorCliente.CondicionVentaSeleccionada;
            ventaData.TipoCajaMovimientoSeleccionado = UcBuscadorCliente.TipoCajaMovimientoSeleccionado;

            ventaData.TotalPagar = UcTotalesVenta.TotalPagar;
            ventaData.Senas = UcTotalesVenta.Senas;
            ventaData.CreditosDevolucion = UcTotalesVenta.CreditosDevolucion;

            ventaData.Titulos = UcTitulosVenta.Titulos;

            ventaData.CajaActualId = Context.CajaActual.Id;
            ventaData.Anticipo = UcCuentaCorrienteInfo.Anticipo;
            //ventaData.SubTotal = UcCuentaCorrienteInfo.SubTotal;
            ventaData.SubTotal = UcTotalesVenta.SubTotal;

            ventaData.Pagos = UcTotalesVenta.Pagos;
            ventaData.Cuotas = UcCuentaCorrienteInfo.Cuotas;
            ventaData.Montocuota = UcCuentaCorrienteInfo.Montocuota;
            ventaData.VencimientoCuota = UcCuentaCorrienteInfo.Vencimiento;
            ventaData.PcAlta = Environment.MachineName;
            ventaData.PuntoVenta = Context.SucursalActual.SucursalNumero ?? 1;
            CrearVentaResponse ventaResponse;

            try
            {
                ventaResponse = _ventaNegocio.CrearVenta(ventaData);
            }
            catch (ApplicationException ex)
            {
                _messageBoxDisplayService.ShowError(ex.Message);
                return;
            }

            foreach (var comprobante in ventaResponse.Comprobantes)
            {
                using (var crearComprobante = FormFactory.Create<FrmComprobante>())
                {
                    crearComprobante._concepto = comprobante.Concepto;
                    crearComprobante._LCN = comprobante.LCN;
                    var conv = new Conversion();
                    crearComprobante._montoTexto = conv.enletras((comprobante.Importe - comprobante.ImpOcupado).ToString());
                    crearComprobante._montoActualizado = (comprobante.Importe - comprobante.ImpOcupado);
                    crearComprobante.ShowDialog();
                }
            }

            _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessVentaExitosa);

            if (ChkImprimir.Checked)
            {
                _directPrint.Descripcion = ventaResponse.FacturaInfo.Descripcion;
                _directPrint.FormaPago = ventaResponse.FacturaInfo.FormaPago;
                _directPrint.Recargo = UcTotalesVenta.Recargo.ToString();
                _directPrint.GenerarFactura(ventaResponse.VentaId);
            }

            using (var crearVenta = FormFactory.Create<FrmFacturaVenta>(ventaResponse.VentaId))
            {
                crearVenta._descripcion = ventaResponse.FacturaInfo.Descripcion;
                crearVenta._formaPago = ventaResponse.FacturaInfo.FormaPago;
                crearVenta._recargo = UcTotalesVenta.Recargo.ToString();

                crearVenta.ShowDialog();
            }

            OnVentaRealizada();

            if (_formMode == ActionFormMode.Edit)
            {
                this.Close();
            }

            //LimpiarFormularioVenta();
        }

        //private void LimpiarFormularioVenta()
        //{
        //    UcBuscadorCliente.LimpiarControles();
        //    UcClienteDetalle.LimpiarControles();
        //    UcCuentaCorrienteInfo.LimpiarControles();
        //    UcTitulosVenta.LimpiarControles();
        //    UcTotalesVenta.LimpiarControles();
        //}

        private void BtnReservarFactura_Click(object sender, EventArgs e)
        {
            ReservarFacturaData reservarFacturaData = new ReservarFacturaData();
            reservarFacturaData.OperadorActualId = Context.OperadorActual.Id;
            reservarFacturaData.SucursalActualId = Context.SucursalActual.Id;
            reservarFacturaData.PuntoVenta = Context.SucursalActual.SucursalNumero ??1;
            _ventaNegocio.ReservarFactura(reservarFacturaData);

            _messageBoxDisplayService.ShowSuccess("Factura reservada");

            ActualizarNroFactura();
        }

        private void BtnRecargarNroFactura_Click(object sender, EventArgs e)
        {
            ActualizarNroFactura();
        }

        private void ActualizarNroFactura()
        {
            using (var ventaNegocio = Ioc.Container.Get<IVentaNegocio>())
            {
                TxtNroFactura.Text = ventaNegocio.SiguienteNumeroFactura(Context.OperadorActual.Id, Context.SucursalActual.Id).ToString();
            }
        }

        private void FrmCrearVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                UcTitulosVenta.BtnAgregarTitulo_Click(null, null);
            }

            if (e.KeyCode == Keys.F9)
            {
                UcTotalesVenta.BtnAgregarPago_Click(null, null);
            }

            if (e.KeyCode == Keys.F3)
            {
                UcBuscadorCliente.Foco();
            }
        }
    }
}
