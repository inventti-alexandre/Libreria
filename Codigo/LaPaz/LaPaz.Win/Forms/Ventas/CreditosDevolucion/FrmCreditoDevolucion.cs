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
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Ventas.CreditosDevolucion
{
    public partial class FrmCreditoDevolucion : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private IList<VentaDetalleDevolucion> _devuletos = new List<VentaDetalleDevolucion>();
        private IList<VentaDetalleDto> _ventaDetalleDto = new List<VentaDetalleDto>();
        private Venta _venta = new Venta();
        private Guid _notaCreditoId;
        private string _lcn;
        private Guid? _operadorIdAutoriza;
        private CondicionVentaEnum? _tipoVenta;

        public FrmCreditoDevolucion(IClock clock,
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
            this.Text = "Devolución";
            this.GrillaLineasFactura.CellFormatting += this.Grilla_CellFormatting;
            this.GrillaLineasFactura.Columns["PrecioUnitario"].FormatString = "{0:N2}";
            this.GrillaLineasFactura.Columns["Precio"].FormatString = "{0:N2}";
            this.GrillaDevueltos.Columns["Importe"].FormatString = "{0:N2}";
            this.GrillaDevueltos.Columns["PrecioUnitario"].FormatString = "{0:N2}";
        }

        private void FrmCreditoDevolucion_Load(object sender, EventArgs e)
        {
            this.ucBuscadorFactura.BuscarFinished += UcBuscadorFacturaOnBuscarFinished;
        }

        #region Propiedades
        public IList<VentaDetalleDevolucion> Devuletos
        {
            get { return _devuletos; }
        }

        public decimal? Total
        {
            get
            {
                decimal total;
                return decimal.TryParse(TxtTotal.Text, out total) ? total : (decimal?)null;
            }
            set
            {
                TxtTotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }
        #endregion

        private void UcBuscadorFacturaOnBuscarFinished(object sender, List<VentaDetalleDto> ventaDetalles)
        {
            if (ventaDetalles != null)
            {
                _ventaDetalleDto = ventaDetalles;
                var ventaId = ventaDetalles.First().VentaId;
                _venta = Uow.Ventas.Obtener(v => v.Id == ventaId, v => v.Cliente);

                ActualizarDetalleFactura(ventaDetalles);
                Devuletos.Clear();
                GrillaDevueltos.DataSource = Devuletos;
                Total = 0;
                CargarDatosFactura();
            }
            else
            {
                Limpiar();
                _messageBoxDisplayService.ShowError("No se encontró factura con ese número");
            }

        }

        private void Limpiar()
        {
            Devuletos.Clear();
            GrillaDevueltos.DataSource = Devuletos;
            _ventaDetalleDto.Clear();
            GrillaLineasFactura.DataSource = _ventaDetalleDto;
            TxtCliente.Text = "";
            TxtConcepto.Text = "";
            TxtFecha.Text = "";
            TxtImporte.Text = "";
            Total = 0;
        }

        private void CargarDatosFactura()
        {
            TxtCliente.Text = _venta.Cliente.Denominacion;
            TxtConcepto.Text = _venta.Concepto;
            TxtFecha.Text = String.Format("{0:dd MMMM yyyy}", _venta.FechaComprobante);
            TxtImporte.Text = _venta.ImporteNeto.ToString("N2");
            _tipoVenta = _venta.CondicionVentaId;
        }

        private void ActualizarDetalleFactura(List<VentaDetalleDto> ventaDetalles)
        {
            GrillaLineasFactura.DataSource = ventaDetalles;
            GrillaLineasFactura.Refresh();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var operador = this.ObtenerOperadorAdministrador();

            if (operador == null)
            {
                return;
            }

            _operadorIdAutoriza = !this.EsOperadorAdmin ? (Guid?) operador.Id : null;

            _venta.OperadorAutoriza = _operadorIdAutoriza;

            if (RbtnCredito.IsChecked)
            {
                GenerarClienteMontoFavor();

              

                ActualizarVentasDetalle(_notaCreditoId);

                Uow.Commit();

                _messageBoxDisplayService.ShowSuccess("Devolución generada con éxito");

                var crearComprobante = FormFactory.Create<FrmComprobante>();
                crearComprobante._concepto = "Crédito por devolución";
                crearComprobante._LCN = _lcn;
                crearComprobante._formaPago = FormaPagoDescripcion();

                var conv = new Conversion();
                crearComprobante._montoTexto = conv.enletras(Total.ToString());
                
                crearComprobante.Show();
            }

            if (RbtnEgreso.IsChecked)
            {
                //Guardar Gasto??
                ActualizarVentasDetalle(null);

                ActualizarCaja();

                Uow.Commit();

                _messageBoxDisplayService.ShowSuccess("Devolución generada con éxito");

            }

            //var pageTab = this.Parent as RadPageViewPage;
            //if (pageTab != null)
            //{
            //    pageTab.Dispose();
            //};
            Limpiar();

        }

        public string FormaPagoDescripcion()
        {
            string formaDePago = string.Empty;
            //var cajaMovimiento = Uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == _venta.Id);
            var cajaMovimiento = Uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == _notaCreditoId);
            if (cajaMovimiento.Efectivo != null)
                formaDePago += "Efectivo $" + cajaMovimiento.Efectivo.Value.ToString("n2") + ". ";
            if (cajaMovimiento.Tarjeta != null)
                formaDePago += "Tarjeta $" + cajaMovimiento.Tarjeta.Value.ToString("N2") + ". ";
            if (cajaMovimiento.Deposito != null)
                formaDePago += "Deposito $" + cajaMovimiento.Deposito.Value.ToString("n2") + ". ";
            if (cajaMovimiento.Cheque != null)
                formaDePago += "Cheque $" + cajaMovimiento.Cheque.Value.ToString("n2") + ". ";


            return formaDePago;
        }

        private void ActualizarCaja()
        {
            //ActualizarCaja y CajaMovimiento
            Caja caja = this.Context.CajaActual;
            if (caja.Egresos == null)
                caja.Egresos = 0;
            caja.Egresos += (float?)Total;
            caja.Saldo -= (float?)Total;
            caja.FechaModificacion = _clock.Now;
            caja.SucursalModificacionId = Context.SucursalActual.Id;//Sucursal del operador
            caja.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador

            Uow.Cajas.Modificar(caja);

            CajaMovimiento cajaMovimiento = new CajaMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = caja.Id;
            cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.NotaCredito;
            cajaMovimiento.TipoComprobante = TipoComprobanteEnum.NotaCrédito;
            cajaMovimiento.ComprobanteId = _venta.Id;
            cajaMovimiento.Importe = Total;
            cajaMovimiento.ImpFac = Total;
            cajaMovimiento.Efectivo = Total;
            cajaMovimiento.FechaAlta = _clock.Now;
            cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
            cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;

            Uow.CajaMovimientos.Agregar(cajaMovimiento);
        }

        private void ActualizarVentasDetalle(Guid? notacreditoId)
        {
            foreach (VentaDetalleDevolucion devuleto in Devuletos)
            {
                var ventaDetalleId = devuleto.Id;
                var ventaDetalle = Uow.VentasDetalle.Obtener(vd => vd.Id == ventaDetalleId);

                ventaDetalle.CantidadAuditada -= devuleto.CantidadTotal;
                //ventaDetalle.CantidadPropia -= devuleto.CantidadPropia;
                //ventaDetalle.CantidadConsig -= devuleto.CantidadConsignada;

                if (notacreditoId != null)
                    ventaDetalle.IdNotaDeVenta = notacreditoId;

                Uow.VentasDetalle.Modificar(ventaDetalle);

                ActualizarStock(devuleto);
            }
        }

        private void ActualizarStock(VentaDetalleDevolucion devuleto)
        {
            var tituloId = devuleto.TituloId;
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == tituloId && t.SucursalId == this.Context.SucursalActual.Id);

            tituloStock.StkPr += devuleto.CantidadPropia;
            tituloStock.StkCn += devuleto.CantidadConsignada;
            Uow.TitulosStock.Modificar(tituloStock);
        }

        private void GenerarClienteMontoFavor()
        {
            //TODO:Agregar el numero de sucursal a la tabla el mismo no coincide con el id.
            int numeroDeSucursal = Context.SucursalActual.SucursalNumero ?? 1;// 1;
            
            ClienteMontoFavor clienteMontoFavor = new ClienteMontoFavor();

            clienteMontoFavor.Id = Guid.NewGuid();
            _notaCreditoId = clienteMontoFavor.Id;
            clienteMontoFavor.OperadorAutoriza = _operadorIdAutoriza;
            clienteMontoFavor.ClienteId = _venta.ClienteId;
            clienteMontoFavor.FechaComprobante = _clock.Now;
            clienteMontoFavor.TipoComprobanteId = TipoComprobanteEnum.NotaCrédito;
            clienteMontoFavor.LCN = "R" + numeroDeSucursal.ToString().PadLeft(4, '0') + CalcularLCN().PadLeft(8, '0');
            _lcn = clienteMontoFavor.LCN;
            clienteMontoFavor.Concepto = "Nota de crédito " + clienteMontoFavor.LCN;
            clienteMontoFavor.Importe = Total;
            clienteMontoFavor.ImpOcupado = 0;
            clienteMontoFavor.Observaciones = TipoComprobanteEnum.NotaCrédito.ToString();
            clienteMontoFavor.FechaAlta = _clock.Now;
            clienteMontoFavor.OperadorAltaId = Context.OperadorActual.Id;
            clienteMontoFavor.SucursalAltaId = Context.SucursalActual.Id;

            Uow.ClientesMontosFavor.Agregar(clienteMontoFavor);

            foreach (VentaDetalleDevolucion devuleto in Devuletos)
            {
                ClientesMontosFavorDetalle clientesMontosAfavorDetalle = new ClientesMontosFavorDetalle();
                clientesMontosAfavorDetalle.Id = Guid.NewGuid();
                clientesMontosAfavorDetalle.ClientesMontosFavorId = clienteMontoFavor.Id;
                clientesMontosAfavorDetalle.TitulosId = devuleto.TituloId;
                clientesMontosAfavorDetalle.CantidadPropia = devuleto.CantidadPropia;
                clientesMontosAfavorDetalle.CantidadConsig = devuleto.CantidadConsignada;
                clientesMontosAfavorDetalle.FechaAlta = _clock.Now;
                clientesMontosAfavorDetalle.SucursalAltaId = Context.SucursalActual.Id;
                clientesMontosAfavorDetalle.OperadorAltaId = Context.OperadorActual.Id;

                Uow.ClientesMontosFavorDetalles.Agregar(clientesMontosAfavorDetalle);
            }

            var cajaMovimientoAnterior = Uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == _venta.Id);
            var montoDevolucion = Total;

            CajaMovimiento cajaMovimiento = new CajaMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = this.Context.CajaActual.Id;
            cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.CreditoFavorPorNc;
            cajaMovimiento.TipoComprobante = TipoComprobanteEnum.NotaCrédito;
            cajaMovimiento.ComprobanteId = clienteMontoFavor.Id;
            cajaMovimiento.Importe = Total;
            cajaMovimiento.ImpFac = Total;
            cajaMovimiento.Efectivo = cajaMovimientoAnterior.Efectivo >= montoDevolucion ? montoDevolucion : cajaMovimientoAnterior.Efectivo;
            montoDevolucion -= cajaMovimiento.Efectivo;
            if (montoDevolucion > 0)
            {
                cajaMovimiento.Tarjeta = (cajaMovimientoAnterior.Tarjeta >= montoDevolucion) ? montoDevolucion : cajaMovimientoAnterior.Tarjeta;
                montoDevolucion -= cajaMovimiento.Tarjeta;
            }
            if (montoDevolucion > 0)
            {
                cajaMovimiento.Cheque = (cajaMovimientoAnterior.Cheque >= montoDevolucion ? montoDevolucion : cajaMovimientoAnterior.Cheque);
                montoDevolucion -= cajaMovimiento.Cheque;
            }
            if (montoDevolucion > 0)
            {
                cajaMovimiento.Deposito = (cajaMovimientoAnterior.Deposito >= montoDevolucion ? montoDevolucion : cajaMovimientoAnterior.Deposito);
                montoDevolucion -= cajaMovimiento.Deposito;
            }
            if (montoDevolucion > 0)
            {
                cajaMovimiento.Transferencia = (cajaMovimientoAnterior.Transferencia >= montoDevolucion ? montoDevolucion : cajaMovimientoAnterior.Transferencia);
                montoDevolucion -= cajaMovimiento.Transferencia;
            }
            cajaMovimiento.FechaAlta = _clock.Now;
            cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
            cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;

            Uow.CajaMovimientos.Agregar(cajaMovimiento);
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

        }

        private void GrillaLineasFactura_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GrillaLineasFactura.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var ventaDetalle = selectedRow.DataBoundItem as VentaDetalleDto;

            if (ventaDetalle == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDevolver":
                    Devolver(ventaDetalle);
                    break;

            }
        }


        private void Devolver(VentaDetalleDto ventaDetalle)
        {
            if (ventaDetalle.CantidadAuditada > 0)
            {
                VentaDetalleDto devolucion = new VentaDetalleDto();
                devolucion.Id = ventaDetalle.Id;
                devolucion.TituloId = ventaDetalle.TituloId;
                devolucion.TituloNombreTitulo = ventaDetalle.TituloNombreTitulo;
                devolucion.CantidadAuditada = ventaDetalle.CantidadAuditada;
                devolucion.CantidadPropia = ventaDetalle.CantidadPropia;
                devolucion.CantidadConsig = ventaDetalle.CantidadConsig;
                devolucion.PrecioBase = ventaDetalle.PrecioBase;
                devolucion.Descuento = ventaDetalle.Descuento;

                ventaDetalle.CantidadAuditada -= 1;



                if (ventaDetalle.CantidadConsig > 0)
                {
                    devolucion.CantidadConsig = 1;
                    devolucion.CantidadPropia = 0;
                    ventaDetalle.CantidadConsig -= 1;
                }
                else
                {
                    if (ventaDetalle.CantidadPropia > 0)
                    {
                        devolucion.CantidadPropia = 1;
                        devolucion.CantidadConsig = 0;
                        ventaDetalle.CantidadPropia -= 1;
                    }
                }
                GrillaLineasFactura.DataSource = _ventaDetalleDto.ToList();
                GrillaLineasFactura.Update();
                GrillaLineasFactura.Refresh();
                GenerarDevolucion(devolucion);
                //MessageBox.Show("1 paso" + devolucion.Precio);
            }
        }

        private void GenerarDevolucion(VentaDetalleDto ventaDetalle)
        {
            if (ventaDetalle.Descuento == null)
                ventaDetalle.Descuento = 0;

            foreach (var devuleto in Devuletos)
            {

                if (devuleto.TituloId == ventaDetalle.TituloId)
                {
                    devuleto.CantidadTotal += 1;
                    devuleto.CantidadPropia = devuleto.CantidadPropia + ventaDetalle.CantidadPropia;
                    devuleto.CantidadConsignada = devuleto.CantidadConsignada + ventaDetalle.CantidadConsig;
                    devuleto.Importe = (ventaDetalle.PrecioBase - (ventaDetalle.PrecioBase * ventaDetalle.Descuento / 100)) * devuleto.CantidadTotal; ;
                    GrillaDevueltos.DataSource = Devuletos.ToList();

                    GrillaDevueltos.DataSource = Devuletos.ToList();
                    CalcularTotal();
                    return;

                }

            }

            VentaDetalleDevolucion ventaDetalleDevolucion = new VentaDetalleDevolucion();
            ventaDetalleDevolucion.Id = ventaDetalle.Id;
            ventaDetalleDevolucion.TituloId = ventaDetalle.TituloId;
            ventaDetalleDevolucion.NombreTitulo = ventaDetalle.TituloNombreTitulo;
            ventaDetalleDevolucion.CantidadTotal = 1;
            ventaDetalleDevolucion.CantidadPropia = ventaDetalle.CantidadPropia;
            ventaDetalleDevolucion.CantidadConsignada = ventaDetalle.CantidadConsig;
            ventaDetalleDevolucion.PrecioUnitario = ventaDetalle.PrecioBase - (ventaDetalle.PrecioBase * ventaDetalle.Descuento / 100);
            ventaDetalleDevolucion.Importe = ventaDetalleDevolucion.PrecioUnitario * ventaDetalleDevolucion.CantidadTotal;

            Devuletos.Add(ventaDetalleDevolucion);
            GrillaDevueltos.DataSource = Devuletos.ToList();
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            Total = Devuletos.ToList().Sum(p => p.Importe);
            // MessageBox.Show("total" + Total.ToString());
        }

        private void GrillaDevueltos_CellClick_1(object sender, GridViewCellEventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GrillaDevueltos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var ventaDetalleDevolucion = selectedRow.DataBoundItem as VentaDetalleDevolucion;

            if (ventaDetalleDevolucion == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaEliminar":
                    EliminarDevolucion(ventaDetalleDevolucion);
                    break;
            }
        }

        private void EliminarDevolucion(VentaDetalleDevolucion ventaDetalleDevolucion)
        {
            var titulo = ventaDetalleDevolucion.TituloId;
            var ventaDetalleId = ventaDetalleDevolucion.Id;

            Devuletos.Remove(ventaDetalleDevolucion);
            GrillaDevueltos.DataSource = Devuletos.ToList();
            CalcularTotal();

            foreach (VentaDetalleDto ventaDetalleDto in _ventaDetalleDto)
            {
                if (ventaDetalleDto.TituloId == titulo)
                {
                    var ventaDetalleOrig = Uow.VentasDetalle.Obtener(vd => vd.TituloId == titulo && vd.Id == ventaDetalleId);
                    ventaDetalleDto.CantidadAuditada = ventaDetalleOrig.CantidadAuditada;
                    ventaDetalleDto.CantidadPropia = ventaDetalleOrig.CantidadPropia;
                    ventaDetalleDto.CantidadConsig = ventaDetalleOrig.CantidadConsig;

                    GrillaLineasFactura.DataSource = _ventaDetalleDto.ToList();
                    GrillaLineasFactura.Update();
                    GrillaLineasFactura.Refresh();
                }
            }
        }



    }
}
