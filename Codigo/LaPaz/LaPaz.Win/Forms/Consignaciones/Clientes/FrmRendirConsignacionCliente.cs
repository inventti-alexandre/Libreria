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
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Interfaces;
using LaPaz.Negocio.Response;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Forms.Util;
using LaPaz.Win.Properties;
using LaPaz.Win.Helpers;
using LaPaz.Win.Reportes;
using LaPaz.Win.Forms.Autenticacion;
using Telerik.WinControls.UI;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Entidades.Dto;

namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
   public partial class FrmRendirConsignacionCliente : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IVentaNegocio _ventaNegocio;
        private readonly IClienteNegocio _clienteNegocio;
        private readonly IRemitosVentaDetalleNegocio _remitoDetalleNegocio;
        private readonly IRemitosVentaNegocio _remitoNegocio;
        private Cliente _cliente;
        private Venta _venta;
        private int _id;
        private readonly ActionFormMode _formMode;
        
        public FrmRendirConsignacionCliente(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                             IVentaNegocio ventaNegocio,
                             IClienteNegocio clienteNegocio,
                             IRemitosVentaDetalleNegocio remitoDetalleNegocio,
                             IRemitosVentaNegocio remitoNegocio,
                             IFormRegistry formRegistry, int id, ActionFormMode mode)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _ventaNegocio = ventaNegocio;
            _clienteNegocio = clienteNegocio;
            _remitoDetalleNegocio = remitoDetalleNegocio;
            _remitoNegocio = remitoNegocio;

            _venta = new Venta();
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
                    this.Text = "Nueva rendición de cliente";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Nueva rendición de cliente - Reserva: " + _id;
                    BtnRecargarNroFactura.Enabled = false;
                    BtnReservarFactura.Enabled = false;
                    break;
            }
        }

        private void FrmRendirConsignacionCliente_Load(object sender, EventArgs e)
        {
            this.TxtFecha.Text = _clock.Now.ToShortDateString();
            this.UcBuscadorConsignacion.BuscarConsignacionFinished += UcBuscadorConsignacionOnBuscarFinished;
            this.UcBuscadorConsignacion.BuscarClienteFinished += UcBuscadorClienteOnBuscarFinished;
            this.UcBuscadorConsignacion.FormaPagoChanged += UcBuscadorClienteOnFormaPagoChanged;
            this.UcTitulosConsignacionVenta.RemitoTitulosChanged += UcTitulosVentaOnVentaTitulosChanged;

            this.UcTotalesVenta.TotalAPagarChanged += UcTitulosVentaOnTotalAPagarChanged;
            this.UcTotalesVenta.DescuentoChanged += UcTitulosVentaOnDescuentoChanged;
            this.UcTotalesVenta.RecargoChanged += UcTotalesVentaOnRecargoChanged;
            this.UcTotalesVenta.TotalChanged += UcTotalesVentaOnTotalChanged;
            this.UcTotalesVenta.PagosChanged += UcTotalesVentaOnPagosChanged;
            this.UcTotalesVenta.FaltaPagarChanged += UcTotalesVentaOnFaltaPagarChanged;

            this.UcCuentaCorrienteInfo.AnticipoChanged += UcCuentaCorrienteInfoOnAnticipoChanged;
            this.UcCuentaCorrienteInfo.CuotasChanged += UcCuentaCorrienteInfoOnCuotasChanged;
            this.UcClienteDetalle.ClienteEdited += UcClienteDetalleOnClienteEdited;



            if (_formMode == ActionFormMode.Create)
            {
                TxtNroFactura.Text = _ventaNegocio.SiguienteNumeroFactura(Context.OperadorActual.Id).ToString();
            }
            if (_formMode == ActionFormMode.Edit)
            {
                TxtNroFactura.Text = _id.ToString();
            }
            UcBuscadorConsignacion.Foco();
        }

        private void UcTotalesVentaOnPagosChanged(object sender, decimal? monto)
        {

        }

        private void UcTotalesVentaOnRecargoChanged(object sender, int? e)
        {
           UcTitulosConsignacionVenta.ActualizarRecargo(UcTotalesVenta.Recargo);
        }

        private void UcTotalesVentaOnTotalChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void UcTitulosVentaOnDescuentoChanged(object sender, int? e)
        {
            UcTitulosConsignacionVenta.ActualizarDescuento(UcTotalesVenta.Descuento);
        }

        private void UcCuentaCorrienteInfoOnCuotasChanged(object sender, EventArgs e)
        {
            //UcTitulosConsignacionVenta.GenerarPagoCuotas(UcCuentaCorrienteInfo.Adeuda);
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
            UcTotalesVenta.Pagos.Clear();
            UcTotalesVenta.RefrescarPagos();

            if (UcBuscadorConsignacion.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente)
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

        private void UcTitulosVentaOnVentaTitulosChanged(object sender, IList<RemitosVentaDetalleDto> remitoTitulos)
        {
            if (UcTitulosConsignacionVenta.Titulos.Count == 0)
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
            var subTotal = UcTitulosConsignacionVenta.CalcularSubTotal();
            UcTotalesVenta.SubTotal = subTotal;

            UcTotalesVenta.TotalPagar = UcTotalesVenta.SubTotal.GetValueOrDefault() - UcTotalesVenta.Senas.GetValueOrDefault() -
                         UcTotalesVenta.CreditosDevolucion.GetValueOrDefault();
            // UcTotalesVenta.TotalPagar -= UcTotalesVenta.TotalPagar * UcTotalesVenta.Descuento.GetValueOrDefault() / 100;

            UcTotalesVenta.FaltaPagar = UcTotalesVenta.TotalPagar - UcTotalesVenta.TotalPagos();

            if (UcTotalesVenta.TotalPagar > 0)
            {
                if (UcBuscadorConsignacion.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente)
                    UcTotalesVenta.GenerarPagoAutoNuevo(UcTotalesVenta.TotalPagar - UcCuentaCorrienteInfo.Anticipo, FormaPago.CuentaCorriente);
                else
                    UcTotalesVenta.GenerarPagoAutoNuevo(UcTotalesVenta.TotalPagar, FormaPago.Efectivo);
            }
            else
            {
                UcTotalesVenta.Pagos.Clear();
            }

        }

        private void UcBuscadorConsignacionOnBuscarFinished(object sender, List<RemitosVenta> remitos)
        {
            if (remitos.Any())
            {
                if (remitos.Count == 1)
                {
                    ActualizarCliente(remitos[0].ClienteConsignado);

                }

                UcTitulosConsignacionVenta.Titulos = _remitoDetalleNegocio.ListadoByRemitoVentaId(remitos[0].Id.ToString());
                UcTitulosConsignacionVenta.RefrescarTitulos();
            }
            else
            {
                _messageBoxDisplayService.ShowWarning(Resources.ErrorBuscarConsignacionVacio);
            }
        }

        private void UcBuscadorClienteOnBuscarFinished(object sender, List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                if (clientes.Count == 1)
                {
                    ActualizarCliente(clientes.Single());
                    SeleccionarRemitos();
                }
                else
                {
                    //Mas de uno encontrado.
                    using (var seleccionarCliente = new FrmSeleccionarCliente(clientes))
                    {
                        seleccionarCliente.ClienteSelected += (o, cliente) =>
                        {
                            _cliente = cliente;
                            ActualizarCliente(cliente);
                            seleccionarCliente.Close();
                        };

                        seleccionarCliente.ShowDialog();
                        if (_cliente != null)
                        {
                            SeleccionarRemitos();
                        }
                    }
                }
            }
            else
            {
                CrearCliente();
            }
        }

        private void SeleccionarRemitos()
        {
            //Mas de uno encontrado.
            var remitosList = _remitoNegocio.GetByClienteId(_cliente.Id);
            if (remitosList.Any())
            {
                if (remitosList.Count > 1)
                {
                    using (var seleccionarConsignacion = new FrmSeleccionarConsignacion(remitosList))
                    {
                        seleccionarConsignacion.ConsignacionSelected += (o, consignacion) =>
                        {
                            UcTitulosConsignacionVenta.Titulos = _remitoDetalleNegocio.ListadoByRemitoVentaId(consignacion.Id.ToString());
                            UcTitulosConsignacionVenta.RefrescarTitulos();
                            seleccionarConsignacion.Close();
                        };

                        seleccionarConsignacion.ShowDialog();
                    }
                }
                else
                {
                    UcTitulosConsignacionVenta.Titulos = _remitoDetalleNegocio.ListadoByRemitoVentaId(remitosList[0].Id.ToString());
                    UcTitulosConsignacionVenta.RefrescarTitulos();
                }
            }
        }

        private void UcClienteDetalleOnClienteEdited(object sender, Cliente cliente)
        {
            var clienteEdited = Uow.Clientes.Obtener(c => c.Id == cliente.Id, c => c.Localidad, c => c.Provincia, c => c.CondicionesVenta);
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

            //UcTotalesVenta.Senas = 0;
            //UcTotalesVenta.CreditosDevolucion = 0;
            UcTotalesVenta.SenasDisp = _ventaNegocio.SenaAFavorCliente(_cliente.Id);
            UcTotalesVenta.CreditosDevolucionDisp = _ventaNegocio.CreditosPorDevolucion(_cliente.Id);

            // UcTotalesVenta.ActualizarMontosAFavor(UcTotalesVenta.Senas, UcTotalesVenta.CreditosDevolucion);
            UcTotalesVenta.ActualizarMontosAFavor(UcTotalesVenta.SenasDisp, UcTotalesVenta.CreditosDevolucionDisp);
            UcTotalesVenta.Senas = 0;
            UcTotalesVenta.CreditosDevolucion = 0;

            UcBuscadorConsignacion.ActualizarFormaPago(_cliente);
        }

        private void CrearCliente()
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create))
            {
                int i = 0;
                if (int.TryParse(UcBuscadorConsignacion.Cuit, out i))
                    formCrearCliente.SetearDni(UcBuscadorConsignacion.Cuit);

                formCrearCliente.ClienteAgregado += (sender, cliente) =>
                {
                    ActualizarCliente(cliente);
                    formCrearCliente.Close();
                };

                formCrearCliente.ShowDialog();
            }
        }

        private void BtnRendirConsignacion_Click(object sender, EventArgs e)
        {
          
            if (UcTotalesVenta.TotalPagar <= 0)
            {
                _messageBoxDisplayService.ShowError("Debe seleccionar libros a facturar");
                return;
            }

            if (_cliente == null)
            {
                _messageBoxDisplayService.ShowError(Resources.ErrorMessageSeleccionarCliente);
                return;
            }

            if (!UcTitulosConsignacionVenta.Titulos.Any())
            {
                _messageBoxDisplayService.ShowError(Resources.ErrorMessageVentaSinLibros);
                return;
            }

            if (!UcTotalesVenta.Validar())
            {
                return;
            }

            if (UcBuscadorConsignacion.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente &&
                UcTotalesVenta.SubTotal.HasValue &&
                UcTotalesVenta.SubTotal.Value > 0 && 
                UcTotalesVenta.SubTotal.Value <= UcTotalesVenta.Descuento.GetValueOrDefault())
            {
                _messageBoxDisplayService.ShowError("El descuento no puede superar al importe total de la venta");
                return;
            }

            if (UcBuscadorConsignacion.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente
                    && UcCuentaCorrienteInfo.Cuotas == null)
            {
                _messageBoxDisplayService.ShowError("Debe indicar la cantidad de cuotas del plan");
                return;
            }

            if (UcTitulosConsignacionVenta.Titulos.Count > Context.SucursalActual.MaximoNroLineasPorVenta)
            {
                _messageBoxDisplayService.ShowError("Se ha superado el límite máximo de líneas por venta.");
                return;
            }


            //Ahora calculo el porcentaje de descuento para ver si no supera el maximo permitido
            //var porcentaje = (UcTotalesVenta.Descuento.GetValueOrDefault() * 100) / UcTotalesVenta.SubTotal.Value;
            var porcentaje = UcTotalesVenta.Descuento.GetValueOrDefault();
            var porcentajeNoAutorizado = porcentaje > Context.SucursalActual.MaximoPorcentajeDescuento;

            var importeNoAutorizado = UcTotalesVenta.SubTotal.Value >= Context.SucursalActual.MaximoImporteVenta;
            if (UcBuscadorConsignacion.CondicionVentaSeleccionada == CondicionVentaEnum.Contado)
                importeNoAutorizado = false;


            if (porcentajeNoAutorizado || importeNoAutorizado)
            {
                using (var login = FormFactory.Create<FrmLogin>())
                {
                    login.RolesAceptados = new List<string>() { "Admin", "SuperAdmin" };
                    login.CambiarIdentity = false;
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        //_messageBoxDisplayService.ShowError(Resources.ErrorMessageVentaSinLibros);
                        return;
                    }
                }
            }

            //Vuelto
            if (ChkVuelto.IsChecked)
            {
                decimal? efectivo = 0;
                foreach (VentaPago pago in this.UcTotalesVenta.Pagos)
                {
                    if (pago.TipoPago == FormaPago.Efectivo)
                        efectivo = pago.Importe;
                }

                using (var frmVuelto = new FrmVuelto())
                {
                    frmVuelto.APagar = efectivo;
                    frmVuelto.Paga = efectivo;
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
            RendirConsignacionClienteData consignacionData = new RendirConsignacionClienteData();

            //consignacionData.EsVentaReservada = false;
            consignacionData.EsVentaReservada = _formMode == ActionFormMode.Edit;
            consignacionData.OperadorId = Context.OperadorActual.Id;
            consignacionData.SucursalId = Context.SucursalActual.Id;
            consignacionData.NumeroComprobante = _id;
            consignacionData.ClienteId = _cliente.Id;

            consignacionData.TipoComprobanteSeleccionado = UcBuscadorConsignacion.TipoComprobanteSeleccionado;
            consignacionData.CondicionVentaSeleccionada = UcBuscadorConsignacion.CondicionVentaSeleccionada;
            consignacionData.TipoCajaMovimientoSeleccionado = UcBuscadorConsignacion.TipoCajaMovimientoSeleccionado;

            consignacionData.TotalPagar = UcTotalesVenta.TotalPagar;
            consignacionData.Senas = UcTotalesVenta.Senas;
            consignacionData.CreditosDevolucion = UcTotalesVenta.CreditosDevolucion;

            UcTitulosConsignacionVenta.ActualizarInfo();
            consignacionData.RemitosVentaDetalle = UcTitulosConsignacionVenta.Titulos;

            consignacionData.CajaActualId = Context.CajaActual.Id;
            consignacionData.Anticipo = UcCuentaCorrienteInfo.Anticipo;
            //consignacionData.SubTotal = UcCuentaCorrienteInfo.SubTotal;
            consignacionData.SubTotal = UcTotalesVenta.SubTotal;

            consignacionData.Pagos = UcTotalesVenta.Pagos;
            consignacionData.Cuotas = UcCuentaCorrienteInfo.Cuotas;
            consignacionData.Montocuota = UcCuentaCorrienteInfo.Montocuota;
            consignacionData.VencimientoCuota = UcCuentaCorrienteInfo.Vencimiento;
            consignacionData.PcAlta = Environment.MachineName;

            CrearVentaResponse ventaResponse;

            try
            {
                ventaResponse = _ventaNegocio.CrearVentaRendicionConsignacionCliente(consignacionData);
            }
            catch (ApplicationException ex)
            {
                _messageBoxDisplayService.ShowError(ex.Message);
                return;
            }

            //if (ventaResponse.Comprobantes.Count != 0)
            //{
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

              //  _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessVentaExitosa);

                if (ChkImprimir.Checked)
                {
                    DirectPrint print = new DirectPrint(Uow);
                    print.Descripcion = ventaResponse.FacturaInfo.Descripcion;
                    print.FormaPago = ventaResponse.FacturaInfo.FormaPago;
                    print.Recargo = UcTotalesVenta.Recargo.ToString();
                    print.GenerarFactura(ventaResponse.VentaId);
                }

                using (var crearVenta = FormFactory.Create<FrmFacturaVenta>(ventaResponse.VentaId))
                {
                    crearVenta._descripcion = ventaResponse.FacturaInfo.Descripcion;
                    crearVenta._formaPago = ventaResponse.FacturaInfo.FormaPago;
                    crearVenta._recargo = UcTotalesVenta.Recargo.ToString();

                    crearVenta.ShowDialog();
                }

                OnVentaRealizada();
            //}
            //else
            //{
                _messageBoxDisplayService.ShowSuccess(Resources.MessageDevolucionExitosa);
            //}

            var pageTab = this.Parent as RadPageViewPage;
            if (pageTab != null)
            {
                pageTab.Dispose();
            };

            if (_formMode == ActionFormMode.Edit)
            {
                this.Close();
            }
        }
       
        private void BtnReservarFactura_Click(object sender, EventArgs e)
        {
            ReservarFacturaData reservarFacturaData = new ReservarFacturaData();
            reservarFacturaData.OperadorActualId = Context.OperadorActual.Id;
            reservarFacturaData.SucursalActualId = Context.SucursalActual.Id;

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
                TxtNroFactura.Text = ventaNegocio.SiguienteNumeroFactura(Context.OperadorActual.Id).ToString();
            }
        }

        private void FrmCrearVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                //UcTitulosVenta.BtnAgregarTitulo_Click(null, null);
            }

            if (e.KeyCode == Keys.F9)
            {
                UcTotalesVenta.BtnAgregarPago_Click(null, null);
            }

            if (e.KeyCode == Keys.F3)
            {
                UcBuscadorConsignacion.Foco();
            }
        }

    }
}
