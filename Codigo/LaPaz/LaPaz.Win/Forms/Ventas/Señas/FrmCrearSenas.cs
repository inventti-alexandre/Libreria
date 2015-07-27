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
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Autenticacion;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Ventas.Señas
{
    public partial class FrmCrearSenas : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IVentaNegocio _ventaNegocio;
        private Cliente _cliente;
        private Guid _clienteId;
        private readonly ActionFormMode _formMode;


        public FrmCrearSenas(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                        IVentaNegocio ventaNegocio,
                             IFormRegistry formRegistry, Guid id, ActionFormMode mode)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _clienteId = id;
            _cliente = new Cliente();
            _ventaNegocio = ventaNegocio;
            _formMode = mode;
            InitializeComponent();
            this.Text = "Señas";
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

        #endregion


        private void FrmCrearSenas_Load(object sender, EventArgs e)
        {
            this.ucBuscadorClienteSimple.BuscarFinished += UcBuscadorClienteOnBuscarFinished;
            this.ucTotalesSeña.TotalAPagarChanged += UcTotalesSeñaOnTotalAPagarChanged;


            this.GridSeñas.CellFormatting += this.Grilla_CellFormatting;
            this.GridSeñas.Columns["Fecha"].DataType = typeof(DateTime);
            this.GridSeñas.Columns["Fecha"].FormatString = "{0: dd/M/yyyy}";
            this.GridSeñas.Columns["FechaAnulacion"].DataType = typeof(DateTime);
            this.GridSeñas.Columns["FechaAnulacion"].FormatString = "{0: dd/M/yyyy}";
            this.GridSeñas.Columns["Importe"].FormatString = "{0:N2}";
            this.GridSeñas.Columns["Utilizado"].FormatString = "{0:N2}";
            if (_clienteId != Guid.Empty)
            {
                _cliente = Uow.Clientes.Obtener(c => c.Id == _clienteId);
                ActualizarCliente(_cliente);
                pnlBuscador.Visible = false;
            }

        }

        private void UcTotalesSeñaOnTotalAPagarChanged(object sender, decimal? e)
        {
            if (ucTotalesSeña.TotalPagar != 0 && ucTotalesSeña.TotalPagar != Monto)
            {
                ucTotalesSeña.EliminarPagoEfectivo();
                if (ucTotalesSeña.TotalPagar != Monto)
                {
                    if (Monto - ucTotalesSeña.TotalPagar > 0)
                        ucTotalesSeña.GenerarPagoAutoNuevo(Monto - ucTotalesSeña.TotalPagar, FormaPago.Efectivo);
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
                }
                else
                {
                    //Mas de uno encontrado.
                    var seleccionarCliente = new FrmSeleccionarCliente(clientes);

                    seleccionarCliente.ClienteSelected += (o, cliente) =>
                    {
                        ActualizarCliente(cliente);
                        seleccionarCliente.Close();
                    };

                    seleccionarCliente.ShowDialog();
                }
            }
            else
            {
                CrearCliente();
            }
        }

        private void CrearCliente()
        {
            var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create);

            formCrearCliente.ClienteAgregado += (sender, cliente) =>
            {
                ActualizarCliente(cliente);
                formCrearCliente.Close();
            };

            formCrearCliente.ShowDialog();
        }

        private void ActualizarCliente(Cliente cliente)
        {
            _cliente = cliente;
            TxtCliente.Text = cliente.Denominacion;
            TxtDni.Text = cliente.Cuit.TrimStart('0');
            TxtSenias.Text = _ventaNegocio.SenaAFavorCliente(_cliente.Id).ToString("N2");
            TxtCreditos.Text = _ventaNegocio.CreditosPorDevolucion(_cliente.Id).ToString("N2");
            TxtTelefono.Text = cliente.Telefono;
            BuscarHistorial();
            LnkEditarCliente.Enabled = true;
        }

        private void BuscarHistorial()
        {
            var señas = Uow.ClientesMontosFavor.Listado().Where(c => c.ClienteId == _cliente.Id && (c.TipoComprobanteId == TipoComprobanteEnum.SeñaCliente || c.TipoComprobanteId == TipoComprobanteEnum.NotaCrédito)).OrderByDescending(c => c.FechaAlta);

            GridSeñas.DataSource = señas.ToList();
            GridSeñas.Refresh();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Monto != ucTotalesSeña.TotalPagar)
            {
                _messageBoxDisplayService.ShowError("Los montos no coinciden");
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
            ////////////////////////////////




            //TODO: Reemplzar el numero cuando se agrege la columna a sucursal.
            int numeroDeSucursal = 1;

            ClienteMontoFavor clienteMontoFavor = new ClienteMontoFavor();
            clienteMontoFavor.Id = Guid.NewGuid();
            clienteMontoFavor.ClienteId = _cliente.Id;
            clienteMontoFavor.FechaComprobante = _clock.Now;
            clienteMontoFavor.TipoComprobanteId = TipoComprobanteEnum.SeñaCliente;
            clienteMontoFavor.LCN = "R" + numeroDeSucursal.ToString().PadLeft(4, '0') + CalcularLCN().PadLeft(8, '0');
            clienteMontoFavor.Concepto = "Seña " + clienteMontoFavor.LCN;
            clienteMontoFavor.Importe = ucTotalesSeña.TotalPagar;
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
                caja.Ingresos += (float?)ucTotalesSeña.TotalPagar;
                caja.Saldo += (float?)ucTotalesSeña.TotalPagar;
                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = 2;//Sucursal del operador
                caja.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador

                Uow.Cajas.Modificar(caja);

                CajaMovimiento cajaMovimiento = new CajaMovimiento();
                cajaMovimiento.Id = Guid.NewGuid();
                cajaMovimiento.CajaId = caja.Id;
                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.SeñaCliente;
                cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaCliente;
                cajaMovimiento.ComprobanteId = clienteMontoFavor.Id;
                cajaMovimiento.Importe = ucTotalesSeña.TotalPagar;
                cajaMovimiento.FechaAlta = _clock.Now;
                cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;
                cajaMovimiento.PcAlta = Environment.MachineName;
                //tipos de pagos
                foreach (VentaPago pago in ucTotalesSeña.Pagos)
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
                            cuentasMovimiento.CuentaId = pagoDeposito.CuentaId;
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
                var crearSenia = FormFactory.Create<FrmComprobante>();
                crearSenia._concepto = "Seña de Cliente";
                crearSenia._LCN = clienteMontoFavor.LCN;
                var conv = new Conversion();

                crearSenia._montoTexto = conv.enletras(ucTotalesSeña.TotalPagar.ToString());
                //crearSenia._montoTexto = "cien";
                crearSenia.Show();
            }

            BuscarHistorial();
            Limpiar();
        }

        private void Limpiar()
        {
            ucTotalesSeña.Pagos.Clear();
            ucTotalesSeña.RefrescarPagos();
        }
        
        private string CalcularLCN()
        {
            var ultimoLCN = Uow.ClientesMontosFavor.Listado().Where(c => c.SucursalAltaId == Context.SucursalActual.Id).OrderByDescending(c => c.FechaAlta).First().LCN;

            int lcn;
            int proximolcn = int.TryParse(ultimoLCN.Substring(5), out lcn) ? lcn : 0;
            return (proximolcn + 1).ToString();

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
                    Anular(senia);
                    break;
            }
        }

        private void Anular(ClienteMontoFavor senia)
        {
            //Utiliar toda la seña
            if (senia.TipoComprobanteId == TipoComprobanteEnum.SeñaCliente)
            {

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

                senia.ImpOcupado = senia.Importe;
                senia.FechaAnulacion = _clock.Now;
                senia.FechaModificacion = _clock.Now;
                senia.OperadorModificacionId = Context.OperadorActual.Id;
                senia.SucursalModificacionId = Context.SucursalActual.Id;

                Uow.ClientesMontosFavor.Modificar(senia);
                //generar cajamovimientno
                Caja caja = this.Context.CajaActual;
                if (caja.Ingresos == null)
                    caja.Ingresos = 0;
                caja.Egresos += (float?)diferencia;
                if (caja.Saldo == null)
                    caja.Saldo = 0;
                caja.Saldo -= (float?)diferencia;
                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = Context.SucursalActual.Id;//Sucursal del operador
                caja.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador

                Uow.Cajas.Modificar(caja);

                CajaMovimiento cajaMovimiento = new CajaMovimiento();
                cajaMovimiento.Id = Guid.NewGuid();
                cajaMovimiento.CajaId = caja.Id;
                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulaciónSeña;
                cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaCliente;
                cajaMovimiento.ComprobanteId = senia.Id;
                cajaMovimiento.Senia = 0;
                cajaMovimiento.Importe = diferencia;
                cajaMovimiento.ImpFac = 0;
                cajaMovimiento.PcAlta = Environment.MachineName;
                cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;//Sucursal del operador
                cajaMovimiento.OperadorAltaId = (Context.OperadorActual.Id);//Id el operador
                cajaMovimiento.FechaAlta = _clock.Now;
                Uow.CajaMovimientos.Agregar(cajaMovimiento);

                //Generaregreso??
                Uow.Commit();
                _messageBoxDisplayService.ShowSuccess("Anulación de seña exitosa");

                BuscarHistorial();
            }
            else
            {
                _messageBoxDisplayService.ShowError("No puede anular una nota de crédito");
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
                ucTotalesSeña.GenerarPagoAutoNuevo(Monto, FormaPago.Efectivo);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ucTotalesSeña.GenerarPagoAutoNuevo(Monto, FormaPago.Efectivo);
        }

        private void LnkEditarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_cliente == null)
            {
                return;
            }

            EditarCliente(_cliente);
        }

        private void EditarCliente(Cliente cliente)
        {
            var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(cliente.Id, ActionFormMode.Edit);
            if (formCrearCliente.ShowDialog() == DialogResult.OK)
            {
                _cliente = Uow.Clientes.Obtener(c => c.Id == _cliente.Id);
                ActualizarCliente(_cliente);
            }
        }

    }
}
