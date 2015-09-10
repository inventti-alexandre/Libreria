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
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;

namespace LaPaz.Win.Forms.Ventas.AnulacionFacturas
{
    public partial class FrmAnulacionFactura : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private IList<VentaDetalleDto> _ventaDetalleDto = new List<VentaDetalleDto>();
        private Venta _venta = new Venta();
        private string _lcn;

        public FrmAnulacionFactura(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                             IFormRegistry formRegistry)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
            this.Text = "Anular";
            this.GrillaLineasFactura.CellFormatting += this.Grilla_CellFormatting;
            this.GrillaLineasFactura.Columns["PrecioUnitario"].FormatString = "{0:N2}";
            this.GrillaLineasFactura.Columns["Precio"].FormatString = "{0:N2}";

        }

        public event EventHandler AccionRealizada;

        private void ucBuscadorFactura1_Load(object sender, EventArgs e)
        {
            this.ucBuscadorFactura.BuscarFinished += UcBuscadorFacturaOnBuscarFinished;
        }

        private void UcBuscadorFacturaOnBuscarFinished(object sender, List<VentaDetalleDto> ventaDetalles)
        {
            if (ventaDetalles != null)
            {
                _ventaDetalleDto = ventaDetalles;
                var ventaId = ventaDetalles.First().VentaId;
                _venta = Uow.Ventas.Obtener(v => v.Id == ventaId, v => v.Cliente);

                ActualizarDetalleFactura(ventaDetalles);
                CargarDatosFactura();
            }
            else
            {
                Limpiar();
                _messageBoxDisplayService.ShowSuccess("No se encontró factura con ese número");
            }

        }

        #region Métodos

        private void ActualizarDetalleFactura(List<VentaDetalleDto> ventaDetalles)
        {
            GrillaLineasFactura.DataSource = ventaDetalles;
            GrillaLineasFactura.Refresh();
        }

        private void CargarDatosFactura()
        {
            TxtCliente.Text = _venta.Cliente.Denominacion;
            TxtConcepto.Text = _venta.Concepto;
            TxtFecha.Text = String.Format("{0:dd MMMM yyyy}", _venta.FechaComprobante);
            TxtImporte.Text = _venta.ImporteNeto.ToString("N2");
        }

        private void Limpiar()
        {
            _ventaDetalleDto.Clear();
            GrillaLineasFactura.DataSource = _ventaDetalleDto;
            TxtCliente.Text = "";
            TxtConcepto.Text = "";
            TxtFecha.Text = "";
            TxtImporte.Text = "";
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_venta.EstadoVentaId == EstadoVentaEnum.Anulada)
            {
                _messageBoxDisplayService.ShowWarning("Factura ya anulada");
                return;
            }

            var operador = this.ObtenerOperadorAdministrador();

            if (operador == null)
            {
                return;
            }

            if (!this.EsOperadorAdmin)
            {
                //Guardamos el operador que autorizo la operacion.
                _venta.OperadorAutoriza = operador.Id;    
            }

            //Anular la Venta
            _venta.EstadoVentaId = EstadoVentaEnum.Anulada;
            _venta.FechaModificacion = _clock.Now;
            _venta.OperadorModificacionId = Context.OperadorActual.Id;
            _venta.SucursalModificacionId = Context.SucursalActual.Id;

            Uow.Ventas.Modificar(_venta);

            //devolver el stock
            foreach (VentaDetalleDto ventaDetalleDto in _ventaDetalleDto)
            {
                var tituloStock =
                    Uow.TitulosStock.Obtener(
                        ts => ts.TituloId == ventaDetalleDto.TituloId && ts.SucursalId == Context.SucursalActual.Id);

                tituloStock.StkPr += ventaDetalleDto.CantidadPropia;
                tituloStock.StkCn += ventaDetalleDto.CantidadConsig;
                tituloStock.FechaModificacion = _clock.Now;
                tituloStock.OperadorModificacionId = Context.OperadorActual.Id;
                tituloStock.SucursalModificacionId = Context.SucursalActual.Id;

                Uow.TitulosStock.Modificar(tituloStock);
            }

            //Devovler caja
            Caja caja = this.Context.CajaActual;
            if (caja.Ingresos == null)
                caja.Ingresos = 0;
            caja.Ingresos -= (float?)_venta.TotalPagado;
            if (caja.Saldo == null)
                caja.Saldo = 0;
            caja.Saldo -= (float?)_venta.TotalPagado;
            caja.FechaModificacion = _clock.Now;
            caja.SucursalModificacionId = Context.SucursalActual.Id;//Sucursal del operador
            caja.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador

            Uow.Cajas.Modificar(caja);

            //CajaMovimiento
            var cajaMovimientoAnterior = Uow.CajaMovimientos.Obtener(c => c.ComprobanteId == _venta.Id);

            CajaMovimiento cajaMovimiento = new CajaMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = caja.Id;
            if (_venta.CondicionVentaId == CondicionVentaEnum.CuentaCorriente)
                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulaciónFacCtaCte;
            else
                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulaciónFacContado;

            cajaMovimiento.TipoComprobante = TipoComprobanteEnum.FacturaAnulada;
            cajaMovimiento.ComprobanteId = _venta.Id;
            cajaMovimiento.Senia = cajaMovimientoAnterior.Senia;
            cajaMovimiento.Importe = cajaMovimientoAnterior.Importe;
            cajaMovimiento.ImpFac = cajaMovimientoAnterior.ImpFac;
            cajaMovimiento.Recargo = cajaMovimientoAnterior.Recargo;
            cajaMovimiento.Efectivo = cajaMovimientoAnterior.Efectivo;
            cajaMovimiento.Tarjeta = cajaMovimientoAnterior.Tarjeta;
            cajaMovimiento.Cheque = cajaMovimientoAnterior.Cheque;
            cajaMovimiento.Deposito = cajaMovimientoAnterior.Deposito;

            cajaMovimiento.PcAlta = Environment.MachineName;
            cajaMovimiento.SucursalAltaId = _venta.SucursalAltaId;
            cajaMovimiento.OperadorAltaId = _venta.OperadorAltaId;
            cajaMovimiento.FechaAlta = _clock.Now;

            cajaMovimiento.SucursalModificacionId = Context.SucursalActual.Id;//Sucursal del operador
            cajaMovimiento.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador
            cajaMovimiento.FechaModificacion = _clock.Now;

            Uow.CajaMovimientos.Agregar(cajaMovimiento);

            //MovimientoCliente
            ClientesMovimiento clientesMovimiento = new ClientesMovimiento();
            clientesMovimiento.IdCliente = _venta.ClienteId;
            clientesMovimiento.IdTipoComprobante = (int)TipoComprobanteEnum.FacturaAnulada;
            clientesMovimiento.IdComprobante = _venta.Id;
            clientesMovimiento.Concepto = TipoComprobanteEnum.FacturaAnulada.ToString();
            clientesMovimiento.Debe = _venta.TotalPagado;
            clientesMovimiento.FechaGeneracion = _clock.Now;
            clientesMovimiento.FechaAlta = _clock.Now;
            clientesMovimiento.SucursalAltaId = Context.SucursalActual.Id;//Sucursal del operador
            clientesMovimiento.OperadorAltaId = (Context.OperadorActual.Id);//Id el operador

            Uow.ClientesMovimientos.Agregar(clientesMovimiento);

            //Actulizar señas de cliente
            var monto = cajaMovimientoAnterior.Senia;
            if (monto > 0 && monto != null)
            {
                int sucursal = 1;
                ClienteMontoFavor clienteMontoFavor = new ClienteMontoFavor();
                clienteMontoFavor.Id = Guid.NewGuid();
                clienteMontoFavor.ClienteId = _venta.ClienteId;
                clienteMontoFavor.FechaComprobante = _clock.Now;
                clienteMontoFavor.TipoComprobanteId = TipoComprobanteEnum.SeñaCliente;
                clienteMontoFavor.LCN = "R" + sucursal.ToString().PadLeft(4, '0') + CalcularLCN().PadLeft(8, '0');
                clienteMontoFavor.Concepto = "Seña " + clienteMontoFavor.LCN;
                clienteMontoFavor.Importe = monto;
                clienteMontoFavor.ImpOcupado = 0;
                clienteMontoFavor.Observaciones = TipoComprobanteEnum.SeñaCliente.ToString() + "Por anulación de factura";
                clienteMontoFavor.FechaAlta = _clock.Now;
                clienteMontoFavor.OperadorAltaId = Context.OperadorActual.Id;
                clienteMontoFavor.SucursalAltaId = Context.SucursalActual.Id;

                Uow.ClientesMontosFavor.Agregar(clienteMontoFavor);

            }

            //si la venta fue en CuentaCorriente, Anular las cuotas
            if (_venta.CondicionVentaId==CondicionVentaEnum.CuentaCorriente)
            {
                var cuotas = Uow.ClientesCuentasCorrientes.Listado().Where(cc => cc.VentaId == _venta.Id);
                foreach (ClienteCuentaCorriente cuota in cuotas)
                {
                    cuota.Pagado = cuota.Importe;
                    cuota.Observaciones = "Venta Anulada";
                    cuota.FechaModificacion = _clock.Now;
                    cuota.OperadorModificacionId = Context.OperadorActual.Id;
                    cuota.SucursalModificacionId = Context.SucursalActual.Id;

                    Uow.ClientesCuentasCorrientes.Modificar(cuota);
                }
            }

            //Si la venta fue con tarjeta, setear en 0 el estado del movimiento
            if (cajaMovimientoAnterior.Tarjeta!= null)
            {
                var tarjetamovimiento =
                    Uow.TarjetasMovimientos.Obtener(t => t.CajaMovimientoId == cajaMovimientoAnterior.Id);

                if (tarjetamovimiento != null)
                {
                    tarjetamovimiento.Estado = 0;
                    tarjetamovimiento.FechaModificacion = _clock.Now;
                    tarjetamovimiento.OperadorModificacionId = Context.OperadorActual.Id;
                    tarjetamovimiento.SucursalModificacionId = Context.SucursalActual.Id;

                    Uow.TarjetasMovimientos.Modificar(tarjetamovimiento);
                }
                
            }

            //si la venta fue con deposito, setear la columna debito=credito para que se anule
            if (cajaMovimientoAnterior.Deposito != null)
            {
                var cuentaMovimiento =
                    Uow.CuentasMovimientos.Obtener(t => t.ComprobanteId == _venta.Id);

                if (cuentaMovimiento != null)
                {
                    cuentaMovimiento.Debito = cuentaMovimiento.Credito;
                    cuentaMovimiento.FechaModificacion = _clock.Now;
                    cuentaMovimiento.OperadorModificacionId = Context.OperadorActual.Id;
                    cuentaMovimiento.SucursalModificacionId = Context.SucursalActual.Id;

                    Uow.CuentasMovimientos.Modificar(cuentaMovimiento);
                }

            }

            //si la venta fue con Cheque, setear estadocheque=1
            if (cajaMovimientoAnterior.Cheque != null)
            {
                var chequeTercero =
                    Uow.ChequesTercero.Obtener(t => t.CajaMovimientoId == cajaMovimientoAnterior.Id);

                if (chequeTercero != null)
                {
                    chequeTercero.EstadoChequeId = 1;
                    chequeTercero.FechaModificacion = _clock.Now;
                    chequeTercero.OperadorModificacionId = Context.OperadorActual.Id;
                    chequeTercero.SucursalModificacionId = Context.SucursalActual.Id;

                    Uow.ChequesTercero.Modificar(chequeTercero);
                }

            }


            Uow.Commit();
            _messageBoxDisplayService.ShowSuccess("Factura anulada correctamente");

            //this.Close();
            OnAccionTerminada();
        }

        private void OnAccionTerminada()
        {
            if (AccionRealizada != null)
            {
                AccionRealizada(this, new EventArgs());
            }
        }
        private string CalcularLCN()
        {
            var ultimoLCN = Uow.ClientesMontosFavor.Listado().Where(c => c.SucursalAltaId == Context.SucursalActual.Id).OrderByDescending(c => c.FechaAlta).First().LCN;

            int lcn;
            int proximolcn = int.TryParse(ultimoLCN.Substring(5), out lcn) ? lcn : 0;
            return (proximolcn + 1).ToString();

        }

        private void FrmAnulacionFactura_Load(object sender, EventArgs e)
        {
            this.GrillaLineasFactura.Columns["PrecioUnitario"].FormatString = "{0:N2}";
            this.GrillaLineasFactura.Columns["Precio"].FormatString = "{0:N2}";
        }
    }
}
