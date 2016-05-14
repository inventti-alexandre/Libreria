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
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Autenticacion;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using LaPaz.Win.Infrastructure.Forms;

namespace LaPaz.Win.Forms.Senias
{
    public partial class FrmCrearSenia : FormBase, IForm
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly ActionFormMode _formMode;

        private IVentaNegocio _ventaNegocio;
        private IClienteNegocio _clienteNegocio;
        private readonly IComprobanteNegocio _comprobanteNegocio;
        private Cliente _cliente;
        private Guid _clienteId;

        public FrmCrearSenia(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                             IUowFactory uowFactory,
                             IVentaNegocio ventaNegocio,
                             IClienteNegocio clienteNegocio,
                             IComprobanteNegocio comprobanteNegocio,
                             IFormRegistry formRegistry, Guid id, ActionFormMode mode)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;
            UowFactory = uowFactory;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _clienteId = id;
            _cliente = new Cliente();
            _ventaNegocio = ventaNegocio;
            _clienteNegocio = clienteNegocio;
            _comprobanteNegocio = comprobanteNegocio;
            _formMode = mode;

            InitializeComponent();
            InicializarPaginador();
        }

        #region Propiedades

        public decimal? Monto
        {
            get
            {
                decimal monto;
                return decimal.TryParse(TxtMonto.Text, out monto) ? monto : (decimal?)0;
            }
            set
            {
                TxtMonto.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public bool HasUnsavedChanges
        {
            get { return this._cliente != null && this.UcTotalesSenia.Pagos.Any(); }
        }

        #endregion

        #region Metodos
        private void FrmCrearSenas_Load(object sender, EventArgs e)
        {
            this.ucBuscadorClienteSimple.BuscarFinished += UcBuscadorClienteOnBuscarFinished;
            this.UcTotalesSenia.TotalAPagarChanged += UcTotalesSeñaOnTotalAPagarChanged;
            this.GridSeñas.CellFormatting += this.Grilla_CellFormatting;

            this.GridSeñas.Columns["Fecha"].DataType = typeof(DateTime);
            this.GridSeñas.Columns["Fecha"].FormatString = "{0: dd/M/yyyy}";
            this.GridSeñas.Columns["FechaAnulacion"].DataType = typeof(DateTime);
            this.GridSeñas.Columns["FechaAnulacion"].FormatString = "{0: dd/M/yyyy}";
            this.GridSeñas.Columns["Importe"].FormatString = "{0:N2}";
            this.GridSeñas.Columns["Utilizado"].FormatString = "{0:N2}";
            this.GridSeñas.Columns["Disponible"].DataType = typeof(decimal);
            this.GridSeñas.Columns["Disponible"].FormatString = "{0:N2}";

            if (_clienteId != Guid.Empty)
            {
                _cliente = Uow.Clientes.Obtener(c => c.Id == _clienteId);
                ActualizarCliente(_cliente);
                pnlBuscador.Visible = false;
            }
            else
            {
                ToggleHabilitarControles(false);
            }
        }

        private void InicializarPaginador()
        {
            ClientesSeniasPager.RefreshActionAsync = RefrescarHistorial;
        }

        protected override void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name == "Eliminar")
            {
                var senia = e.Row.DataBoundItem as ClienteMontoFavor;
                if (senia != null)
                {
                    e.CellElement.Enabled = !senia.FechaAnulacion.HasValue;
                    var commandCell = e.CellElement as GridCommandCellElement;
                    if (commandCell != null)
                    {
                        e.CellElement.ToolTipText = Resources.LabelAnularSenia;
                    }
                }
            }

            if (e.Column.Name == "Imprimir")
            {
                var commandCell = e.CellElement as GridCommandCellElement;
                if (commandCell != null)
                {
                    e.CellElement.ToolTipText = Resources.LabelImprimir;
                }
            }

            base.Grilla_CellFormatting(sender, e);
        }

        private void UcTotalesSeñaOnTotalAPagarChanged(object sender, decimal? e)
        {
            if (UcTotalesSenia.TotalPagar != 0 && UcTotalesSenia.TotalPagar != Monto)
            {
                UcTotalesSenia.EliminarPagoEfectivo();
                if (UcTotalesSenia.TotalPagar != Monto)
                {
                    if (Monto - UcTotalesSenia.TotalPagar > 0)
                        UcTotalesSenia.GenerarPagoAutoNuevo(Monto - UcTotalesSenia.TotalPagar, FormaPago.Efectivo);
                }
            }
        }

        private void UcBuscadorClienteOnBuscarFinished(object sender, List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                if (clientes.Count == 1)
                {
                    ActualizarCliente(clientes.Single());

                    ToggleHabilitarControles(true);
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

                            ToggleHabilitarControles(true);
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Monto != UcTotalesSenia.TotalPagar)
            {
                _messageBoxDisplayService.ShowError("Los montos no coinciden");
                return;
            }

            if (this.UcTotalesSenia.Pagos.Count == 0)
            {
                _messageBoxDisplayService.ShowError("Debe agregar una seña.");
                return;
            }

            Guid operadorAutoriza = Guid.Empty;

            if (_formMode == ActionFormMode.Edit)
            {

                //////Autorizacion para sin movimiento
                var operador = this.ObtenerOperadorAdministrador();

                if (operador == null)
                {
                    return;
                }

                if (!this.EsOperadorAdmin)
                {
                    //Guardamos el operador que autorizo la operacion.
                    operadorAutoriza = operador.Id;
                }

            }

            //TODO: Reemplzar el numero cuando se agrege la columna a sucursal.
            int numeroDeSucursal = Context.SucursalActual.SucursalNumero ?? 1;

            ClienteMontoFavor clienteMontoFavor = new ClienteMontoFavor();
            clienteMontoFavor.Id = Guid.NewGuid();
            clienteMontoFavor.ClienteId = _cliente.Id;
            clienteMontoFavor.FechaComprobante = _clock.Now;
            clienteMontoFavor.TipoComprobanteId = TipoComprobanteEnum.SeñaCliente;
            clienteMontoFavor.LCN = "R" + numeroDeSucursal.ToString().PadLeft(4, '0') + CalcularLCN().PadLeft(8, '0');
            clienteMontoFavor.Concepto = "Seña " + clienteMontoFavor.LCN;
            clienteMontoFavor.Importe = UcTotalesSenia.TotalPagar;
            clienteMontoFavor.ImpOcupado = 0;
            clienteMontoFavor.Observaciones = TipoComprobanteEnum.SeñaCliente.ToString();
            clienteMontoFavor.FechaAlta = _clock.Now;
            clienteMontoFavor.OperadorAltaId = Context.OperadorActual.Id;
            clienteMontoFavor.SucursalAltaId = Context.SucursalActual.Id;
            if (operadorAutoriza != Guid.Empty)
                clienteMontoFavor.OperadorAutoriza = operadorAutoriza;

            Uow.ClientesMontosFavor.Agregar(clienteMontoFavor);

            //Si el Form=Editar significa que es SinGuardar los movimientos de caja
            if (_formMode == ActionFormMode.Create)
            {
                //ActualizarCaja y CajaMovimiento
                Caja caja = this.Context.CajaActual;
                if (caja.Egresos == null)
                    caja.Egresos = 0;
                caja.Ingresos += (float?)UcTotalesSenia.TotalPagar;
                caja.Saldo += (float?)UcTotalesSenia.TotalPagar;
                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = Context.SucursalActual.Id;//Sucursal del operador
                caja.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador

                Uow.Cajas.Modificar(caja);

                CajaMovimiento cajaMovimiento = new CajaMovimiento();
                cajaMovimiento.Id = Guid.NewGuid();
                cajaMovimiento.CajaId = caja.Id;
                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.SeñaCliente;
                cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaCliente;
                cajaMovimiento.ComprobanteId = clienteMontoFavor.Id;
                cajaMovimiento.Importe = UcTotalesSenia.TotalPagar;
                cajaMovimiento.FechaAlta = _clock.Now;
                cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;
                cajaMovimiento.PcAlta = Environment.MachineName;
                //tipos de pagos
                foreach (VentaPago pago in UcTotalesSenia.Pagos)
                {
                    switch (pago.TipoPago)
                    {
                        case FormaPago.Efectivo:
                            cajaMovimiento.Efectivo = pago.Importe;
                            break;
                        case FormaPago.Tarjeta:
                            var pagoTarjeta = pago as VentaPagoTarjeta;
                            if (cajaMovimiento.Tarjeta == null)
                                cajaMovimiento.Tarjeta = 0;

                            cajaMovimiento.Tarjeta += pago.Importe;
                            //GUARDAR TARJETA MOVIMIENTO 
                            TarjetasMovimiento tarjetasMovimiento = new TarjetasMovimiento();
                            tarjetasMovimiento.CajaMovimientoId = cajaMovimiento.Id;
                            tarjetasMovimiento.TarjetaId = pagoTarjeta.TarjetaId ?? 0;
                            tarjetasMovimiento.LoteCupon = pagoTarjeta.CuponNumero;
                            tarjetasMovimiento.Fecha = _clock.Now;
                            tarjetasMovimiento.Importe = (float)pago.Importe;
                            tarjetasMovimiento.Estado = 1; // No se 
                            tarjetasMovimiento.FechaAlta = _clock.Now;
                            tarjetasMovimiento.SucursalAltaId = Context.SucursalActual.Id; //Sucursal del operador
                            tarjetasMovimiento.OperadorAltaId = (Context.OperadorActual.Id); //Id el operador

                            Uow.TarjetasMovimientos.Agregar(tarjetasMovimiento);
                            break;
                        case FormaPago.Cheque:
                            var pagoCheque = pago as VentaPagoCheque;

                            if (cajaMovimiento.Cheque == null)
                                cajaMovimiento.Cheque = 0;

                            cajaMovimiento.Cheque += pago.Importe;

                            ChequesTercero chequesTercero = new ChequesTercero();
                            chequesTercero.Id = Guid.NewGuid();
                            chequesTercero.CajaMovimientoId = cajaMovimiento.Id;
                            chequesTercero.BancoId = pagoCheque.BancoId ?? 0;
                            chequesTercero.NroCheque = pagoCheque.Numero;
                            chequesTercero.Fecha = _clock.Now;
                            chequesTercero.FechaCobro = _clock.Now;
                            chequesTercero.Importe = (float)pago.Importe;
                            chequesTercero.FechaAlta = _clock.Now;
                            chequesTercero.SucursalAltaId = Context.SucursalActual.Id;
                            chequesTercero.OperadorAltaId = (Context.OperadorActual.Id);

                            Uow.ChequesTerceros.Agregar(chequesTercero);
                            break;
                        case FormaPago.Deposito:
                            var pagoDeposito = pago as VentaPagoDeposito;
                            if (cajaMovimiento.Deposito == null)
                                cajaMovimiento.Deposito = 0;

                            //Guardar Cuentas Movimientos
                            cajaMovimiento.Deposito += pago.Importe;

                            CuentasMovimiento cuentasMovimiento = new CuentasMovimiento();
                            cuentasMovimiento.CuentaId = pagoDeposito.CuentaId ?? 0;
                            cuentasMovimiento.TipoMovimientoId = 2; //Deposito
                            cuentasMovimiento.FechaMovimiento = pagoDeposito.Fecha;
                            cuentasMovimiento.EstadoMovimientoCuentaId = 0;
                            cuentasMovimiento.TipoComprobanteId = TipoComprobanteEnum.SeñaCliente;
                            cuentasMovimiento.ComprobanteId = clienteMontoFavor.Id;
                            cuentasMovimiento.MonedaId = 0;
                            cuentasMovimiento.CondicionVentaId = CondicionVentaEnum.Contado;
                            cuentasMovimiento.NroMovimiento = pagoDeposito.Numero;
                            cuentasMovimiento.Descripcion = "DEPOSITO NRO " + pagoDeposito.Numero.ToString();
                            cuentasMovimiento.FechaCobro = _clock.Now;
                            cuentasMovimiento.Debito = 0;
                            cuentasMovimiento.Credito = pago.Importe;
                            cuentasMovimiento.TipoCarga = 2;
                            cuentasMovimiento.CajaId = caja.Id;
                            cuentasMovimiento.FechaAlta = _clock.Now;
                            cuentasMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                            cuentasMovimiento.SucursalAltaId = Context.SucursalActual.Id;

                            Uow.CuentasMovimientos.Agregar(cuentasMovimiento);
                            break;

                    }
                }

                Uow.CajaMovimientos.Agregar(cajaMovimiento);
            }

            Uow.Commit();

            _messageBoxDisplayService.ShowSuccess("Seña generada con éxito");

            //Si el Form=Editar significa que es SinGuardar los movimientos de caja
            if (_formMode == ActionFormMode.Create)
            {
                ImprimirComprobante(clienteMontoFavor, UcTotalesSenia.FormasDePagosParaComprobante);
            }

            RefrescarUow();

            RefrescarHistorial();

            Limpiar();
        }

        private void ImprimirComprobante(ClienteMontoFavor clienteMontoFavor, string formaPagoComprobante)
        {
            using (var crearSenia = FormFactory.Create<FrmComprobante>())
            {
                crearSenia._concepto = clienteMontoFavor.Concepto;// "Seña de Cliente";
                crearSenia._LCN = clienteMontoFavor.LCN;
                crearSenia._formaPago = formaPagoComprobante;

                var conv = new Conversion();

                var monto = clienteMontoFavor.Importe - clienteMontoFavor.ImpOcupado;

                crearSenia._montoTexto = conv.enletras(monto.ToString());// conv.enletras(UcTotalesSenia.TotalPagar.ToString());
                crearSenia.ShowDialog();
            }
        }

        private void GridSeñas_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridSeñas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var senia = selectedRow.DataBoundItem as ClienteMontoFavor;

            if (senia == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Eliminar":
                    _messageBoxDisplayService.ShowConfirmationDialog(
                        Resources.MensajeConfirmarAnularSenia,
                        Resources.TituloConfirmarAnularSenia,
                        () => Anular(senia));
                    break;
                case "Imprimir":
                    var formaPago = _comprobanteNegocio.FormaDePagoReimpresion(senia.Id);
                    ImprimirComprobante(senia, formaPago);
                    break;
            }
        }

        private void TabSeñas_SelectedPageChanged(object sender, EventArgs e)
        {
            if (TabSeñas.SelectedPage == TabSeñasHistorial)
                pnlMontoSenia.Visible = false;
            else
            {
                pnlMontoSenia.Visible = true;
            }
        }

        private void TxtMonto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UcTotalesSenia.GenerarPagoAutoNuevo(Monto, FormaPago.Efectivo);
        }

        private void BtnAgregarMontoAuto_Click(object sender, EventArgs e)
        {
            UcTotalesSenia.GenerarPagoAutoNuevo(Monto, FormaPago.Efectivo);
        }

        private void LnkEditarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_cliente == null)
            {
                return;
            }

            EditarCliente(_cliente);
        }

        protected override void RefrescarUow()
        {
            base.RefrescarUow();

            _clienteNegocio.Dispose();
            _clienteNegocio = new ClienteNegocio(Uow, _clock, UowFactory);

            _ventaNegocio.Dispose();
            _ventaNegocio = new VentaNegocio(Uow, _clock, UowFactory);
        }

        private void CrearCliente()
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create))
            {
                int i = 0;
                if (int.TryParse(ucBuscadorClienteSimple.Cuit, out i))
                    formCrearCliente.SetearDni(ucBuscadorClienteSimple.Cuit);

                formCrearCliente.ClienteAgregado += (sender, cliente) =>
                {
                    ActualizarCliente(cliente);
                    formCrearCliente.Close();
                };

                formCrearCliente.ShowDialog();
            }
        }

        private void ActualizarCliente(Cliente cliente)
        {
            _cliente = cliente;
            TxtCliente.Text = cliente.Denominacion;
            TxtDni.Text = cliente.Cuit.TrimStart('0');
            TxtSenias.Text = _ventaNegocio.SenaAFavorCliente(_cliente.Id, Context.SucursalActual.Id).ToString("N2");
            TxtCreditos.Text = _ventaNegocio.CreditosPorDevolucion(_cliente.Id, Context.SucursalActual.Id).ToString("N2");
            TxtTelefono.Text = cliente.Telefono;
            RefrescarHistorial();
            LnkEditarCliente.Enabled = true;
        }

        private async Task<int> RefrescarHistorial()
        {
            var currentPage = ClientesSeniasPager.CurrentPage;
            var pageSize = ClientesSeniasPager.PageSize;
            int pageTotal = 0;

            var senias = await
                         Task.Run(
                             () =>
                             _clienteNegocio.Senias("FechaAlta", "DESC", _cliente.Id, Context.SucursalActual.Id, currentPage, pageSize, out pageTotal));

            ClientesSeniasPager.UpdateState(pageTotal);

            GridSeñas.DataSource = senias.ToList();

            GridSeñas.Refresh();

            return pageTotal;
        }

        private void Limpiar()
        {
            UcTotalesSenia.Pagos.Clear();
            UcTotalesSenia.RefrescarPagos();

            TxtMonto.Text = String.Empty;
        }

        private string CalcularLCN()
        {
            var ultimoLCN = Uow.ClientesMontosFavor.Listado().Where(p => p.SucursalAltaId == Context.SucursalActual.Id).OrderByDescending(p => p.FechaAlta).Take(1).FirstOrDefault();

            int lcnNuevo = 0;

            if (ultimoLCN != null)
            {
                var lcn = ultimoLCN.LCN.Substring(5);
                lcnNuevo = int.TryParse(lcn, out lcnNuevo) ? lcnNuevo : 0;
            }

            lcnNuevo += 1;

            return (lcnNuevo.ToString());
            //return "X" + "0001" + lcnNuevo.ToString().PadLeft(8, '0');

        }

        private void Anular(ClienteMontoFavor senia)
        {
            //Utiliar toda la seña
            //if (senia.TipoComprobanteId == TipoComprobanteEnum.SeñaCliente)
            //{
            var operador = this.ObtenerOperadorAdministrador();

            if (operador == null)
            {
                return;
            }

            if (!this.EsOperadorAdmin)
            {
                //Guardamos el operador que autorizo la operacion.
                senia.OperadorAutoriza = operador.Id;
            }

            var diferencia = senia.Importe - senia.ImpOcupado;
            if (diferencia == 0)
                return;
                
               
            Uow.ClientesMontosFavor.Modificar(senia);

            var cajaMovimientoAnterior = Uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == senia.Id);
            
            if (cajaMovimientoAnterior == null)
            {
                //notas de credito no generan caja movimiento?

            }
                if ((cajaMovimientoAnterior.Tarjeta != null || cajaMovimientoAnterior.Tarjeta == 0 ) ||
                    (cajaMovimientoAnterior.Cheque != null || cajaMovimientoAnterior.Cheque == 0) ||
                    (cajaMovimientoAnterior.Deposito != null || cajaMovimientoAnterior.Deposito == 0))
                {

                    decimal? devolucion = 0;
                    if (diferencia > ((cajaMovimientoAnterior.Tarjeta ?? 0) + (cajaMovimientoAnterior.Cheque ?? 0) + (cajaMovimientoAnterior.Deposito ?? 0) + (cajaMovimientoAnterior.Transferencia ?? 0))) 
                    {
                        devolucion = diferencia - ((cajaMovimientoAnterior.Tarjeta ?? 0) + (cajaMovimientoAnterior.Cheque ?? 0) + (cajaMovimientoAnterior.Deposito ?? 0) + (cajaMovimientoAnterior.Transferencia ?? 0));
                        
                        //Actualizacion seña
                        using (var crearComprobante = FormFactory.Create<FrmComprobante>())
                        {
                            _messageBoxDisplayService.ShowWarning("Solo se puede devolver un monto en efectivo de: $" + devolucion.Value.ToString("N2"));
                            
                            crearComprobante._concepto = "Actualizacion de seña";
                            crearComprobante._LCN = senia.LCN;
                            var conv = new Conversion();
                            crearComprobante._montoTexto = conv.enletras((diferencia - devolucion).ToString());
                            crearComprobante._montoActualizado = (diferencia - devolucion);
                           
                            var formapago = "";
                            if (cajaMovimientoAnterior.Tarjeta > 0)
                                formapago += "Tarjeta ";
                           if (cajaMovimientoAnterior.Cheque > 0)
                                formapago += "Cheque ";
                           if (cajaMovimientoAnterior.Deposito > 0)
                                formapago += "Deposito ";
                           if (cajaMovimientoAnterior.Transferencia > 0)
                               formapago += "Transferencia ";
                           
                            crearComprobante._formaPago = formapago + (diferencia - devolucion).ToString() ;

                            crearComprobante.ShowDialog();
                        }
                        diferencia = devolucion;
                    }
                    else 
                    {
                        _messageBoxDisplayService.ShowError("No se puede anular una seña que no fue generada en efectivo");
                        return;
                        //devolucion = diferencia;
                        //anular seña
                    }
                }

            senia.ImpOcupado += diferencia; //senia.Importe;
            if (senia.ImpOcupado == senia.Importe)
                senia.FechaAnulacion = _clock.Now;
            senia.FechaModificacion = _clock.Now;
            senia.OperadorModificacionId = Context.OperadorActual.Id;
            senia.SucursalModificacionId = Context.SucursalActual.Id;


                //generar cajamovimientno
                Caja caja = this.Context.CajaActual;
                if (caja.Ingresos == null)
                    caja.Ingresos = 0;
                caja.Egresos += (float?)diferencia;
                if (caja.Saldo == null)
                    caja.Saldo = 0;
                caja.Saldo -= (float?)diferencia;
                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = Context.SucursalActual.Id;
                caja.OperadorModificacionId = (Context.OperadorActual.Id);

                Uow.Cajas.Modificar(caja);

                if (senia.TipoComprobanteId == TipoComprobanteEnum.SeñaCliente)
                {
                    //var cajaMovimientoAnterior = Uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == senia.Id);
                    //cajaMovimientoAnterior = Uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == senia.Id);

                    CajaMovimiento cajaMovimiento = new CajaMovimiento();
                    cajaMovimiento.Id = Guid.NewGuid();
                    cajaMovimiento.CajaId = caja.Id;
                    cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulaciónSeña;
                    cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaCliente;
                    cajaMovimiento.ComprobanteId = senia.Id;
                    cajaMovimiento.Senia = 0;
                    cajaMovimiento.Importe = diferencia;
                    
                   // cajaMovimiento.Efectivo = cajaMovimientoAnterior.Efectivo;
                    cajaMovimiento.Efectivo = diferencia;
                    //cajaMovimiento.Tarjeta = cajaMovimientoAnterior.Tarjeta;
                    //cajaMovimiento.Cheque = cajaMovimientoAnterior.Cheque;
                    //cajaMovimiento.Deposito = cajaMovimientoAnterior.Deposito;
                    cajaMovimiento.ImpFac = 0;
                    cajaMovimiento.PcAlta = Environment.MachineName;
                    cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id; //cajaMovimientoAnterior.SucursalAltaId;
                    cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id; //cajaMovimientoAnterior.OperadorAltaId;
                    cajaMovimiento.FechaAlta = _clock.Now;
                    cajaMovimiento.SucursalModificacionId = Context.SucursalActual.Id;
                    cajaMovimiento.OperadorModificacionId = (Context.OperadorActual.Id);
                    cajaMovimiento.FechaModificacion = _clock.Now;
                    Uow.CajaMovimientos.Agregar(cajaMovimiento);
                }
                else if (senia.TipoComprobanteId == TipoComprobanteEnum.NotaCrédito)
                {
                    CajaMovimiento cajaMovimiento = new CajaMovimiento();
                    cajaMovimiento.Id = Guid.NewGuid();
                    cajaMovimiento.CajaId = caja.Id;
                    cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulaciónSeña;
                    cajaMovimiento.TipoComprobante = TipoComprobanteEnum.NotaCrédito;
                    cajaMovimiento.ComprobanteId = senia.Id;
                    cajaMovimiento.Senia = 0;
                    cajaMovimiento.Importe = diferencia;
                    cajaMovimiento.Efectivo = diferencia;
                    //cajaMovimiento.Tarjeta = cajaMovimientoAnterior.Tarjeta;
                    //cajaMovimiento.Cheque = cajaMovimientoAnterior.Cheque;
                    //cajaMovimiento.Deposito = cajaMovimientoAnterior.Deposito;
                    cajaMovimiento.ImpFac = 0;
                    cajaMovimiento.PcAlta = Environment.MachineName;
                    cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id; //cajaMovimientoAnterior.SucursalAltaId;
                    cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id; //cajaMovimientoAnterior.OperadorAltaId;
                    cajaMovimiento.FechaAlta = _clock.Now;
                    cajaMovimiento.SucursalModificacionId = Context.SucursalActual.Id;
                    cajaMovimiento.OperadorModificacionId = (Context.OperadorActual.Id);
                    cajaMovimiento.FechaModificacion = _clock.Now;
                    Uow.CajaMovimientos.Agregar(cajaMovimiento);
                }
                //Generaregreso??
                Uow.Commit();

                _messageBoxDisplayService.ShowSuccess("Anulación de seña exitosa");

                RefrescarUow();

                RefrescarHistorial();                
           
        }

        private void EditarCliente(Cliente cliente)
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(cliente.Id, ActionFormMode.Edit))
            {
                if (formCrearCliente.ShowDialog() == DialogResult.OK)
                {
                    _cliente = Uow.Clientes.Obtener(c => c.Id == _cliente.Id);
                    ActualizarCliente(_cliente);
                }
            }
        }

        private void ToggleHabilitarControles(bool enable)
        {
            PanelPagos.Enabled = enable;
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarHistorial();
        }
        #endregion
    }
}
