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
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Compras
{
    public partial class FrmCrearCompra : FormBase
    {
        #region InitializeComponents
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Proveedor _proveedor;
        private readonly ICompraNegocio _compranegocio;
        private int _tipoConsignacion = 1; //Consignacion proveedor

        public FrmCrearCompra(IClock clock,
                                IFormFactory formFactory,
                                IMessageBoxDisplayService messageBoxDisplayService,
                                ILaPazUow uow
                               )
        {
            FormFactory = formFactory;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            Uow = uow;
            //_compranegocio = compraNegocio;

            InitializeComponent();
        }
        #endregion

        public event EventHandler CompraRealizada;

        #region Properties

        private Guid _id;
        private String _lcn;
        private Enum _tipoComprobante;
        private int _puntoVenta;
        private string _concepto;
        private decimal _importeNeto;
        private decimal _importeIva;
        private int _estadoCompra;
        private Guid _remitoID;
        public Guid? Id { get { return _id; } }
        public string Lcn { get { return _lcn; } }
        public Enum TipoComprobante { get { return _tipoComprobante; } }

        public string LetraComprobante
        {
            get { return DdlFacturaTipo.SelectedItem.Text; }
            set { DdlFacturaTipo.SelectedItem.Text = value; }
        }

        public int PuntoVenta
        {
            get { return _puntoVenta; }
            set { _puntoVenta = value; }
        }

        public string NumeroComprobante
        {
            get { return (TxtRemito2.Text); }
            set { TxtRemito2.Text = value; }
        }

        public DateTime FechaComprobante
        {
            get { return (DtpFechaEmision.Value); }
            set { DtpFechaEmision.Value = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return (DtpFechaVencimiento.Value); }
            set { DtpFechaVencimiento.Value = value; }
        }

        public string Concepto { get { return _concepto; } }

        public decimal? ImporteNeto { get { return _importeNeto; } }
        public decimal? ImporteIva { get { return _importeIva; } }

        public string Observaciones
        {
            get { return TxtObservaciones.Text; }
            set { TxtObservaciones.Text = value; }
        }

        public int EstadoCompra
        {
            get { return _estadoCompra; }
            set { _estadoCompra = value; }
        }

        #endregion

        #region Methods
        private void FrmCrearCompra_Load(object sender, EventArgs e)
        {
            this.ucBuscadorProveedor.SeleccionarFinished += ucBuscadorProveedorOnSeleccionarFinished;
            this.ucTitulosCompra.CompraTitulosChanged += ucTitulosCompraOnCompraTitulosChanged;
            this.ucTipoCompra.TipoCompraChanged += UcTipoCompraOnChanged;
            this.ucTotalesCompraSeña1.FaltaPagarChanged += UcTotalesCompraSeñaOnFaltaPagarChanged;
            this.ucTotalesCompraSeña1.SeñaChanged += ucTotalesCompraSeñaOnSeñaChanged;
            this.ucCuentaCorrienteCompra.AnticipoChanged += UcCuentaCorrienteInfoOnAnticipoChanged;
            ucTotalesCompraSeña1.Senas = 0;
            ucTotalesCompraSeña1.Creditos = 0;
            DtpFechaEmision.Value = _clock.Now;
            //Deshabilito los controles
            DeshabilitarEdicion();
        }

        private void ucTotalesCompraSeñaOnSeñaChanged(object sender, EventArgs e)
        {
            if (ucCuentaCorrienteCompra.Visible == true)
                ucCuentaCorrienteCompra.Anticipo = ucTotalesCompraSeña1.Senas + ucTotalesCompraSeña1.Creditos;
            ActualizarMontos();
        }

        private void UcCuentaCorrienteInfoOnAnticipoChanged(object sender, decimal? e)
        {
            ucTotalesCompraSeña1.GenerarPagoAutoNuevo(ucCuentaCorrienteCompra.Adeuda, FormaPago.CuentaCorriente);
        }

        private void UcTotalesCompraSeñaOnFaltaPagarChanged(object sender, decimal? e)
        {
            if (ucTotalesCompraSeña1.FaltaPagar != 0)
            {
                ucTotalesCompraSeña1.EliminarPagoEfectivo();
                if (ucTotalesCompraSeña1.FaltaPagar > 0)
                {
                    ucTotalesCompraSeña1.GenerarPagoAnticipoNuevo(ucTotalesCompraSeña1.FaltaPagar, FormaPago.Efectivo);
                }
            }

           
        }

        private void UcTipoCompraOnChanged(object sender, Entidades.Enums.TipoComprobanteEnum e)
        {
            HabilitarEdicion();
            if(_proveedor !=null)
                ActualizarProveedor(_proveedor);
        }

        private void DeshabilitarEdicion()
        {
            DdlFacturaTipo.SelectedIndex = 0;
            RpFactura.Enabled = false;
            RpFecha.Enabled = false;
            RpProveedor.Enabled = false;
            RpRemito.Enabled = false;

            RpFechaVencimiento.Enabled = false;
            RpFechaVencimiento.Visible = false;
            DtpFechaVencimiento.Value = _clock.Now;

            ucBuscadorProveedor.Enabled = false;
            ucTitulosCompra.Enabled = false;
            RpObservaciones.Enabled = false;

            ucCuentaCorrienteCompra.Enabled = false;
            ucCuentaCorrienteCompra.Visible = false;

            ucTotalesCompraSeña1.Enabled = false;
        }

        private void HabilitarEdicion()
        {
            //habilito los controles comunes
            RpFecha.Enabled = true;
            RpProveedor.Enabled = true;
            RpRemito.Enabled = true;

            RpFechaVencimiento.Enabled = false;
            RpFechaVencimiento.Visible = false;

            ucBuscadorProveedor.Enabled = true;
            ucTitulosCompra.Enabled = true;

            ucTotalesCompraSeña1.Enabled = true;
        
            //vacío los textboxs
            TxtRemito1.Text = "0";
            TxtRemito2.Text = "0";
            TxtFactura1.Text = "0";
            TxtFactura2.Text = "0";

            RpObservaciones.Enabled = true;

            switch (ucTipoCompra.TipoComprobanteSeleccionado)
            {
                //habilito controles propios
                case Entidades.Enums.TipoComprobanteEnum.FacCpraContado:
                    {
                        ucTotalesCompraSeña1.Enabled = true;
                        ucTotalesCompraSeña1.Visible = true;
                        
                        RpFactura.Enabled = true;
                        RpFactura.Visible = true;
                        TxtRemito1.Focus();
                        ucCuentaCorrienteCompra.Enabled = false;
                        ucCuentaCorrienteCompra.Visible = false;
                        break;
                    }
                case Entidades.Enums.TipoComprobanteEnum.FacCpraCtaCte:
                    {
                        ucTotalesCompraSeña1.Pagos.Clear();
                        ucTotalesCompraSeña1.RefrescarPagos();

                        ucTotalesCompraSeña1.Enabled = true;
                        ucTotalesCompraSeña1.Visible = true;
                        
                        RpFactura.Enabled = true;
                        RpFactura.Visible = true;
                        ucCuentaCorrienteCompra.Enabled = true;
                        ucCuentaCorrienteCompra.Visible = true;
                        ucCuentaCorrienteCompra.Anticipo = 0;
                        //ucCuentaCorrienteCompra.Cuotas = 1;
                        TxtRemito1.Focus();
                        break;
                    }
                case Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor:
                    {
                        RpFactura.Enabled = false;
                        RpFactura.Visible = false;
                        RpFechaVencimiento.Visible = true;
                        RpFechaVencimiento.Enabled = true;
                        TxtRemito1.Text = "0000";
                        TxtRemito2.Focus();
                        ucCuentaCorrienteCompra.Enabled = false;
                        ucCuentaCorrienteCompra.Visible = false;
                        
                        ucTotalesCompraSeña1.Enabled = false;
                      
                        break;
                    }
                case Entidades.Enums.TipoComprobanteEnum.IngresosProducción:
                    {
                        ucTotalesCompraSeña1.Enabled = true;
                        ucTotalesCompraSeña1.Visible = true;
                      
                        RpFactura.Visible = false;
                        RpFactura.Enabled = false;
                        RpRemito.Enabled = false;
                        //Traigo el último numero de comprobante y luego lo incremento en uno para armar el nro de comprobante actual
                        var _compra = Uow.Compras.Listado().Where(c => c.TipoComprobanteId == Entidades.Enums.TipoComprobanteEnum.IngresosProducción &&
                                                                            c.PuntoVenta != 0).OrderByDescending(c => c.FechaAlta).Take(1).ToList();
                        TxtRemito1.Text = "0000";
                        if (_compra.Count() > 0)
                          TxtRemito2.Text = Convert.ToString((Convert.ToInt16(_compra.FirstOrDefault().NumeroComprobante) + 1));

                        ucBuscadorProveedor.Focus();
                        ucCuentaCorrienteCompra.Enabled = false;
                        ucCuentaCorrienteCompra.Visible = false;
                        break;
                    }
                case Entidades.Enums.TipoComprobanteEnum.RemitosAnulacConsigVend:
                    {
                        ucCuentaCorrienteCompra.Enabled = false;
                        ucCuentaCorrienteCompra.Enabled = false;
                        ucCuentaCorrienteCompra.Visible = false;
                        break;
                    }
            }
        }


        private void ucTitulosCompraOnCompraTitulosChanged(object sender, IList<Model.CompraTitulo> e)
        {
            ActualizarMontos();
            if (ucTitulosCompra.Titulos.Count == 0)
            {
              if (ucTotalesCompraSeña1.Pagos.Count>0)
                {
                    ucTotalesCompraSeña1.SubTotal = 0;
                    ucTotalesCompraSeña1.TotalPagar = 0;
                    
                    ucTotalesCompraSeña1.Pagos.Clear();
                    ucTotalesCompraSeña1.RefrescarPagos();
                    ucTotalesCompraSeña1.SubTotal = 0;
                    ucTotalesCompraSeña1.TotalPagar = 0;
                  
                }

                ActualizarMontos();
            }
            else
            {
                ucTotalesCompraSeña1.SubTotal = 0;
                ucTotalesCompraSeña1.TotalPagar = 0;
                ActualizarMontos();
            }
        }

        private void ActualizarMontos()
        {
            ucCuentaCorrienteCompra.Total = this.ucTitulosCompra.CalcularSubTotal();
            ucCuentaCorrienteCompra.Adeuda = this.ucTitulosCompra.CalcularSubTotal() - ucTotalesCompraSeña1.Senas - ucTotalesCompraSeña1.Creditos;
            ucTotalesCompraSeña1.SubTotal = this.ucTitulosCompra.CalcularSubTotal();

            if (ucTotalesCompraSeña1.TotalPagar > 0)
            {
                if (ucTipoCompra.TipoComprobanteSeleccionado == TipoComprobanteEnum.FacCpraCtaCte)
                {
                    ucTotalesCompraSeña1.GenerarPagoAutoNuevo(ucTotalesCompraSeña1.TotalPagar, FormaPago.CuentaCorriente);
                    
                }
                
                else
                    ucTotalesCompraSeña1.GenerarPagoAutoNuevo(ucTotalesCompraSeña1.TotalPagar, FormaPago.Efectivo);
            }
            else
            {
                ucTotalesCompraSeña1.Pagos.Clear();
            }

        }

        private void ucBuscadorProveedorOnSeleccionarFinished(object sender, Proveedor proveedor)
        {
            ActualizarProveedor(proveedor);
            ActualizarMontos();
        }

        public decimal SeñaAFavorProveedor(Guid proveedorId)
        {
            var proveedoresMontosFavor = Uow.ProveedoresSenias.Listado()
                                       .Where(ps => ps.ProveedorId == proveedorId
                                                   && ps.ImporteUsado < ps.Importe
                                                   && ps.SucursalAltaId==Context.SucursalActual.Id)
                                       .ToList();
            return proveedoresMontosFavor.Where(ps=> ps.SucursalAltaId==Context.SucursalActual.Id).Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteUsado.GetValueOrDefault()
                );
        }

        private decimal? CreditoAFavorProveedor(Guid proveedorId)
        {
            var proveedoresCreditoFavor = Uow.ProveedoresMontosFavor.Listado()
                                      .Where(pmf => pmf.ProveedorId == proveedorId
                                                  && pmf.ImporteOcupado < pmf.Importe)
                                      .ToList();
            return proveedoresCreditoFavor.Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteOcupado.GetValueOrDefault());
        }

        private void ActualizarProveedor(Proveedor proveedor)
        {
            if (proveedor != null)
            {
                _proveedor = proveedor;
                ucTitulosCompra.ActualizarProveedorId(_proveedor.Id);


                if (ucTipoCompra.TipoComprobanteSeleccionado != TipoComprobanteEnum.RemitosConsignacProveedor)
                {
                    ucTotalesCompraSeña1.SenasDisp = SeñaAFavorProveedor(_proveedor.Id);
                    ucTotalesCompraSeña1.CreditosDisp = CreditoAFavorProveedor(_proveedor.Id);
                    ucTotalesCompraSeña1.ActualizarMontosAFavor(ucTotalesCompraSeña1.SenasDisp);
                }
                else
                {
                    ucTotalesCompraSeña1.SenasDisp = 0;
                    ucTotalesCompraSeña1.CreditosDisp = 0;
                    ucTotalesCompraSeña1.ActualizarMontosAFavor(0);
                }
            }

    }

        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (_proveedor == null)
            {
                return;
            }
            if (!ucTitulosCompra.Titulos.Any())
            {
                _messageBoxDisplayService.ShowError("Debe seleccionar al menos un libro para la compra.");
                return;
            }

            if (!ucTotalesCompraSeña1.Validar())
            {
                return;
            }

            if (ucTipoCompra.TipoComprobanteSeleccionado== Entidades.Enums.TipoComprobanteEnum.FacCpraContado)
            {
                if(TxtRemito1.Text==""||TxtRemito2.Text==""||TxtFactura1.Text==""||TxtFactura2.Text=="")
                    return;
            }

            if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraCtaCte)
            {
                if (TxtRemito1.Text == "" || TxtRemito2.Text == "" || TxtFactura1.Text == "" || TxtFactura2.Text == "" || ucCuentaCorrienteCompra.Cuotas == null)
                    return;
            }

            if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor)
            {
                  if (TxtRemito1.Text == "" || TxtRemito2.Text == "" || DtpFechaVencimiento.Value.Date<_clock.Now.Date)
                      return;
            }

            //Acumulamos los pagos
            decimal? efectivo = 0;
            decimal? efectivoCajaAnterior = 0;
            decimal? tarjeta = 0;
            decimal? cheque = 0;
            decimal? deposito = 0;
            decimal? transferencia = 0;

            foreach (var pago in ucTotalesCompraSeña1.Pagos)
            {
                switch (pago.TipoPago)
                {
                    case FormaPago.Efectivo:
                        efectivo += pago.Importe;
                        break;

                    case FormaPago.EfectivoCajaAnterior:
                        efectivoCajaAnterior += pago.Importe;
                        break;

                    case FormaPago.Tarjeta:
                        tarjeta += pago.Importe;
                        break;

                    case FormaPago.Cheque:
                        cheque += pago.Importe;
                        break;

                    case FormaPago.Deposito:
                        deposito += pago.Importe;
                        break;

                    case FormaPago.Transferencia:
                        transferencia += pago.Importe;
                        break;
                }
            }


            //Pedimos autorización para caja anterior
            if (efectivoCajaAnterior > 0)
            {
                Guid operadorAutoriza = Guid.Empty;

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

            //Compras
            Guid _idCompra = Guid.NewGuid();
            string _lcn = "";
            PuntoVenta = 1;
            Compra compraNueva = new Compra();

            switch (ucTipoCompra.TipoComprobanteSeleccionado)
            {
                case Entidades.Enums.TipoComprobanteEnum.FacCpraContado:
                    EstadoCompra = 1;
                    break;

                case Entidades.Enums.TipoComprobanteEnum.FacCpraCtaCte:
                    EstadoCompra = 1;
                    break;

                case Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor:
                    compraNueva.FechaVencimiento = DtpFechaVencimiento.Value;
                    NumeroComprobante = (Convert.ToInt32(TxtRemito2.Text)).ToString();

                    LetraComprobante = "X";
                    EstadoCompra = 1;
                    break;

                case Entidades.Enums.TipoComprobanteEnum.IngresosProducción:
                    NumeroComprobante = (Convert.ToInt16(TxtRemito2.Text)).ToString();
                    DdlFacturaTipo.Enabled = true;
                    DdlFacturaTipo.Visible = true;
                    LetraComprobante = "X";
                    EstadoCompra = 1;
                    break;

                case Entidades.Enums.TipoComprobanteEnum.RemitosAnulacConsigVend:
                    EstadoCompra = 2;
                    break;
            }

            //controlo cuantos ceros me faltan para armar el lcn y los agrego en la variable ceros
            string _ceros = "";
            for (int i = 0; i < (13 - (NumeroComprobante.Count() + 3 + PuntoVenta.ToString().Count())); i++)
            {
                _ceros += "0";
            }

            _lcn += LetraComprobante + "00" + PuntoVenta + _ceros + NumeroComprobante;
            NumeroComprobante = TxtRemito1.Text + TxtRemito2.Text;

            //compraNueva.
            compraNueva.Id = _idCompra;
            compraNueva.LCN = _lcn;
            compraNueva.TipoComprobanteId = ucTipoCompra.TipoComprobanteSeleccionado;
            compraNueva.ProveedorId = _proveedor.Id;
            compraNueva.LetraComprobante = LetraComprobante;
            compraNueva.PuntoVenta = PuntoVenta;
            compraNueva.NumeroComprobante = NumeroComprobante;
            compraNueva.FechaComprobante = DtpFechaEmision.Value;
            compraNueva.Concepto = ucTipoCompra.TipoComprobanteSeleccionado.ToString();
            compraNueva.ImporteNeto = ucTitulosCompra.CalcularSubTotal();
            compraNueva.Observaciones = Observaciones;
            compraNueva.EstadoCompraId = EstadoCompra;
            compraNueva.OperadorAltaId = (Context.OperadorActual.Id);
            compraNueva.SucursalAltaId = Context.SucursalActual.Id;
            compraNueva.FechaAlta = _clock.Now;
            Uow.Compras.Agregar(compraNueva);

            //FacturaCompra.
            FacturasCompra facturaCompra = new FacturasCompra();
            facturaCompra.Id = Guid.NewGuid();
            facturaCompra.CompraId = _idCompra;
            facturaCompra.TipoComprobante = ucTipoCompra.TipoComprobanteSeleccionado;
            facturaCompra.ProveedorId = _proveedor.Id;
            facturaCompra.LCN = _lcn;
            facturaCompra.PuntoVenta = 1;
            facturaCompra.NumeroComprobante = NumeroComprobante;
            facturaCompra.Concepto = ucTipoCompra.TipoComprobanteSeleccionado.ToString();
            facturaCompra.FechaComprobante = _clock.Now;
            if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraConsigCliente)
                facturaCompra.FechaVencimiento = DtpFechaEmision.Value;
            facturaCompra.ImporteNeto = ucTotalesCompraSeña1.SubTotal;
            facturaCompra.ImporteIVA = ucTotalesCompraSeña1.SubTotal;
            facturaCompra.EstadoId = 0;
            facturaCompra.FechaAlta = _clock.Now;
            facturaCompra.SucursalAltaId = Context.SucursalActual.Id;
            facturaCompra.OperadorAltaId = Context.OperadorActual.Id;
            Uow.FacturasCompras.Agregar(facturaCompra);

            //Remito
            if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraContado || 
                ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraCtaCte ||
                ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraConsigCliente)
            {
            RemitosCompra remitoCompra = new RemitosCompra();
            remitoCompra.Id = Guid.NewGuid();
            _remitoID = remitoCompra.Id;
            remitoCompra.CompraId = _idCompra;
            //remitoCompra.TipoComprobante = ucTipoCompra.TipoComprobanteSeleccionado;
            remitoCompra.ProveedorId = _proveedor.Id;
            remitoCompra.LCN = _lcn;
            remitoCompra.PuntoVenta = 1;
            remitoCompra.NumeroComprobante = NumeroComprobante;
            remitoCompra.Concepto = ucTipoCompra.TipoComprobanteSeleccionado.ToString();
            remitoCompra.FechaComprobante = DtpFechaEmision.Value;
            if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraConsigCliente)
                remitoCompra.FechaVencimiento = DtpFechaVencimiento.Value;
            remitoCompra.ImporteNeto = ucTotalesCompraSeña1.SubTotal;
            remitoCompra.ImporteIVA = ucTotalesCompraSeña1.SubTotal;
            remitoCompra.Observaciones = Observaciones;
            remitoCompra.EstadoId = EstadoCompra;
            remitoCompra.FechaAlta = _clock.Now;
            remitoCompra.SucursalAltaId = Context.SucursalActual.Id;
            remitoCompra.OperadorAltaId = Context.SucursalActual.OperadorAltaId;
            Uow.RemitosCompra.Agregar(remitoCompra);
            }
           
            
            //TitulosStock. & Compra detalle
            foreach (var titulo in ucTitulosCompra.Titulos)
            {
                var tituloStock =
                Uow.TitulosStock.Obtener(ts => ts.TituloId == titulo.TituloId && ts.SucursalId == Context.SucursalActual.Id);

                //Compra detalle
                ComprasDetalle compraDetalle = new ComprasDetalle();
                compraDetalle.CompraId = _idCompra;
                compraDetalle.Id = Guid.NewGuid();
                compraDetalle.TituloId = titulo.TituloId;
                if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor)
                {
                    compraDetalle.CntCn = titulo.CantidadCompra;
                    compraDetalle.CntPr = 0;
                }
                else
                {
                    compraDetalle.CntPr = titulo.CantidadCompra;
                    compraDetalle.CntCn = 0;
                }
                compraDetalle.PrecioCompra = titulo.PrecioBase;
                compraDetalle.PrecioVenta = titulo.PrecioVenta;
                compraDetalle.FechaAlta = _clock.Now;
                compraDetalle.SucursalAltaId = Context.SucursalActual.Id;
                compraDetalle.OperadorAltaId = Context.OperadorActual.Id;
                compraDetalle.FechaModificacion = _clock.Now;
                compraDetalle.SucursalModificacionId = Context.SucursalActual.Id;
                compraDetalle.OperadorModificacionId = Context.OperadorActual.Id;
                Uow.ComprasDetalles.Agregar(compraDetalle);

                //Aumentar stock
                //deacuerdo al tipo de compra modificar el stock propio o en consigancion
                if (tituloStock == null)
                {
                    TituloStock tituloStockNuevo = new TituloStock();
                    tituloStockNuevo.TituloId = titulo.TituloId;
                    tituloStockNuevo.SucursalId = Context.SucursalActual.Id;
                    if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor)
                    {
                        tituloStockNuevo.StkPr = 0;
                        tituloStockNuevo.StkCn = titulo.CantidadCompra;
                    }
                    else
                    {
                        tituloStockNuevo.StkPr = titulo.CantidadCompra;
                        tituloStockNuevo.StkCn = 0;
                    }

                    tituloStockNuevo.FechaAlta = _clock.Now;
                    tituloStockNuevo.OperadorAltaId = (Context.OperadorActual.Id);
                    tituloStockNuevo.SucursalAltaId = Context.SucursalActual.Id;
                    Uow.TitulosStock.Agregar(tituloStockNuevo);
                }
                else
                {
                    //Aumento el stock propio o consignado de acuerdo a la opcion seleccionada.
                    if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor)
                    {
                        if (tituloStock.StkCn == null)
                            tituloStock.StkCn = titulo.CantidadCompra;
                        else
                            tituloStock.StkCn += titulo.CantidadCompra;
                    }
                    else
                        if (tituloStock.StkPr == null)
                            tituloStock.StkPr = titulo.CantidadCompra;
                        else
                            tituloStock.StkPr += titulo.CantidadCompra;

                    tituloStock.FechaModificacion = _clock.Now;
                    tituloStock.OperadorModificacionId = (Context.OperadorActual.Id);
                    tituloStock.SucursalModificacionId = Context.SucursalActual.Id;
                    Uow.TitulosStock.Modificar(tituloStock);
                }

                //FacturasCompraDetalle.
                FacturasComprasDetalle facturasComprasDetalle = new FacturasComprasDetalle();
                facturasComprasDetalle.Id = Guid.NewGuid();
                facturasComprasDetalle.FacturaCompraId = facturaCompra.Id;
                facturasComprasDetalle.TituloId = titulo.TituloId;

                if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor)
                {
                    facturasComprasDetalle.CntCn = titulo.CantidadCompra;
                    facturasComprasDetalle.CntPr = 0;
                }
                else
                {
                    facturasComprasDetalle.CntPr = titulo.CantidadCompra;
                    facturasComprasDetalle.CntCn = 0;
                }

                facturasComprasDetalle.PrecioCompra = titulo.PrecioBase;
                facturasComprasDetalle.PrecioVenta = titulo.PrecioVenta;
                facturasComprasDetalle.FechaAlta = _clock.Now;
                facturasComprasDetalle.SucursalAltaId = Context.SucursalActual.Id;
                facturasComprasDetalle.OperadorAltaId = (Context.OperadorActual.Id);
                
                Uow.FacturasComprasDetalles.Agregar(facturasComprasDetalle);

                if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor)
                {
                    //(TitulosConsiganciones).
                    TitulosConsignacion tituloConsignacion = new TitulosConsignacion();
                    tituloConsignacion.Id = Guid.NewGuid();
                    tituloConsignacion.TituloId = titulo.TituloId;
                    tituloConsignacion.ClienteId = Guid.Empty;
                    tituloConsignacion.ProveedorId = _proveedor.Id;
                    tituloConsignacion.TipoConsignacion = _tipoConsignacion;
                    tituloConsignacion.CntPr = 0;
                    tituloConsignacion.CntCn = titulo.CantidadCompra.GetValueOrDefault();
                    tituloConsignacion.CntVn = 0;
                    tituloConsignacion.FechaAlta = _clock.Now;
                    tituloConsignacion.SucursalAltaId = Context.SucursalActual.Id;
                    tituloConsignacion.OperadorAltaId = Context.OperadorActual.Id;
                    
                    Uow.TitulosConsignaciones.Agregar(tituloConsignacion);
                }
                //Remito Detalle
                if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraContado || 
                    ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraCtaCte ||
                    ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraConsigCliente)
                {
                    RemitosCompraDetalle remitoCompraDetalle = new RemitosCompraDetalle();
                    remitoCompraDetalle.Id = Guid.NewGuid();
                    remitoCompraDetalle.RemitoCompraId = _remitoID;
                    remitoCompraDetalle.TituloId = titulo.TituloId;
                    if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraConsigCliente)
                        remitoCompraDetalle.CntCn = titulo.CantidadCompra;
                    else
                        remitoCompraDetalle.CntPr = titulo.CantidadCompra;
                    remitoCompraDetalle.PrecioCompra = titulo.PrecioBase;
                    remitoCompraDetalle.PrecioVenta = titulo.PrecioVenta;
                    remitoCompraDetalle.FechaAlta = _clock.Now;
                    remitoCompraDetalle.SucursalAltaId = Context.SucursalActual.Id;
                    remitoCompraDetalle.OperadorAltaId = Context.OperadorActual.Id;
                    Uow.RemitosCompraDetalle.Agregar(remitoCompraDetalle);
                }
            }

            //Cuenta corriente
            if (ucTipoCompra.TipoComprobanteSeleccionado == Entidades.Enums.TipoComprobanteEnum.FacCpraCtaCte)
            {
                //Guardo toda la cuenta corriente
                var cuotas = ucCuentaCorrienteCompra.Cuotas;
                for (int i = 1; i <= cuotas; i++)
                {
                    ProveedoresCuentasCorriente proveedoresCuentaCorriente = new ProveedoresCuentasCorriente();
                    proveedoresCuentaCorriente.Id = Guid.NewGuid();
                    proveedoresCuentaCorriente.CompraId = _idCompra;
                    proveedoresCuentaCorriente.ProveedorId = _proveedor.Id;
                    proveedoresCuentaCorriente.Cuota = i;
                    proveedoresCuentaCorriente.Fecha = _clock.Now;
                    DateTime venc = ucCuentaCorrienteCompra.Vencimiento;
                    proveedoresCuentaCorriente.FechaVencimiento = venc.AddMonths(i - 1);
                    proveedoresCuentaCorriente.Importe = Convert.ToDecimal(ucCuentaCorrienteCompra.Montocuota);
                    proveedoresCuentaCorriente.Pagado = 0;
                    proveedoresCuentaCorriente.Observaciones = "";
                    proveedoresCuentaCorriente.FechaAlta = _clock.Now;
                    proveedoresCuentaCorriente.SucursalAltaId = Context.SucursalActual.Id;
                    proveedoresCuentaCorriente.OperadorAltaId = Context.OperadorActual.Id;
                    proveedoresCuentaCorriente.FechaModificacion = _clock.Now;
                    proveedoresCuentaCorriente.SucursalModificacionId = Context.SucursalActual.Id;
                    proveedoresCuentaCorriente.OperadorModificacionId = Context.OperadorActual.Id;
                    Uow.ProveedoresCuentasCorrientes.Agregar(proveedoresCuentaCorriente);
                }
            }

            #region Guardamos caja en contado
            
            //Guardamos la caja
            if (ucTipoCompra.TipoComprobanteSeleccionado == TipoComprobanteEnum.FacCpraContado)
            {
                Caja caja = this.Context.CajaActual;
                
                switch (ucTipoCompra.TipoComprobanteSeleccionado)
                {

                    case TipoComprobanteEnum.FacCpraContado:


                        //descontar de la caja
                        if (caja.Egresos == null)
                            caja.Egresos = 0;

                        caja.Egresos += (float?) efectivo;

                        if (caja.Saldo == null)
                            caja.Saldo = 0;
                        caja.Saldo -= (float?) ucTotalesCompraSeña1.SubTotal;

                        caja.FechaModificacion = _clock.Now;
                        caja.SucursalModificacionId = Context.SucursalActual.Id;
                        caja.OperadorModificacionId = (Context.OperadorActual.Id);

                        //aca descontamos las señas en el caso de que se utilicen. 
                        var _seña = UsoDeSeña();
                        var _credito = UsoDeCredito();

                       

                        if (efectivo > 0)
                        {
                            CajaMovimiento cajaMovimiento = new CajaMovimiento();
                            cajaMovimiento.Id = Guid.NewGuid();
                            cajaMovimiento.CajaId = caja.Id;
                            
                            cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.PagoProveedores;

                            cajaMovimiento.ComprobanteId = compraNueva.Id;
                            cajaMovimiento.Importe = efectivo;
                            cajaMovimiento.ImpFac = (decimal?)ucTotalesCompraSeña1.SubTotal;
                            cajaMovimiento.Efectivo = efectivo;

                            cajaMovimiento.Senia = _seña + _credito;
                            if (_seña > 0)
                            {
                               // cajaMovimiento.Senia = _seña;
                                _seña = 0;
                            }

                            if (_credito > 0)
                            {
                                //cajaMovimiento.Senia += _credito;
                                _credito = 0;
                            }


                            cajaMovimiento.FechaAlta = _clock.Now;

                            cajaMovimiento.PcAlta = System.Environment.MachineName;
                            cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                            cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;

                            cajaMovimiento.TipoComprobante = TipoComprobanteEnum.FacCpraContado;
                            Uow.CajaMovimientos.Agregar(cajaMovimiento);
                        }

                        if (tarjeta > 0 || deposito > 0 || cheque > 0 || efectivoCajaAnterior >0 || transferencia>0)
                        {
                            CajaMovimiento cajaMovimientoAnterior = new CajaMovimiento();
                            cajaMovimientoAnterior.Id = Guid.NewGuid();
                            cajaMovimientoAnterior.CajaId = caja.Id;

                            cajaMovimientoAnterior.TipoMovimientoCajaId =
                                TipoMovimientoCajaEnum.PagoProveedorCajaAnterior;
                            cajaMovimientoAnterior.ComprobanteId = compraNueva.Id;
                            cajaMovimientoAnterior.Importe = tarjeta+deposito+cheque+efectivoCajaAnterior+transferencia;
                            cajaMovimientoAnterior.ImpFac = (decimal?)ucTotalesCompraSeña1.SubTotal;
                            cajaMovimientoAnterior.FechaAlta = _clock.Now;
                            cajaMovimientoAnterior.FechaModificacion = _clock.Now;
                            cajaMovimientoAnterior.PcAlta = System.Environment.MachineName;
                            cajaMovimientoAnterior.OperadorAltaId = Context.OperadorActual.Id;
                            cajaMovimientoAnterior.SucursalAltaId = Context.SucursalActual.Id;
                            cajaMovimientoAnterior.OperadorModificacionId = Context.OperadorActual.Id;
                            cajaMovimientoAnterior.SucursalModificacionId = Context.SucursalActual.Id;
                            cajaMovimientoAnterior.TipoComprobante = TipoComprobanteEnum.FacCpraContado;
                            cajaMovimientoAnterior.Efectivo = efectivoCajaAnterior;
                            cajaMovimientoAnterior.Tarjeta = tarjeta;
                            cajaMovimientoAnterior.Deposito = deposito;
                            cajaMovimientoAnterior.Cheque = cheque;
                            cajaMovimientoAnterior.Transferencia = transferencia;

                            cajaMovimientoAnterior.Senia = _seña + _credito;
                          
                            //if (_seña > 0)
                            //{
                            //    cajaMovimientoAnterior.Senia = _seña;
                            //}

                          
                            Uow.CajaMovimientos.Agregar(cajaMovimientoAnterior);

                            //Guardamos el movimiento del depósito
                             foreach (var pago in ucTotalesCompraSeña1.Pagos)
                            {
                                switch (pago.TipoPago)
                                {
                                    case FormaPago.Cheque:
                                       // HACER ALGO
                                        break;

                                    case FormaPago.Deposito:
                                        var pagoDeposito = pago as VentaPagoDeposito;
                                        
                                        CuentasMovimiento cuentasMovimiento = new CuentasMovimiento();
                                        cuentasMovimiento.CuentaId = pagoDeposito.CuentaId ?? 0;
                                        cuentasMovimiento.TipoMovimientoId = 1;//Deposito a proveedor
                                        cuentasMovimiento.FechaMovimiento = pagoDeposito.Fecha;
                                        cuentasMovimiento.EstadoMovimientoCuentaId = 0;
                                        cuentasMovimiento.TipoComprobanteId = ucTipoCompra.TipoComprobanteSeleccionado;
                                        cuentasMovimiento.ComprobanteId = compraNueva.Id;
                                        cuentasMovimiento.MonedaId = 0;
                                        cuentasMovimiento.NroMovimiento = pagoDeposito.Numero;
                                        cuentasMovimiento.Descripcion = "DEPOSITO NRO " + pagoDeposito.Numero.ToString();
                                        cuentasMovimiento.FechaCobro = _clock.Now;
                                        cuentasMovimiento.Debito = pago.Importe;
                                        cuentasMovimiento.Credito = 0;
                                        cuentasMovimiento.TipoCarga = 1;
                                        cuentasMovimiento.CajaId = caja.Id;
                                        cuentasMovimiento.FechaAlta = _clock.Now;
                                        cuentasMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                                        cuentasMovimiento.SucursalAltaId = Context.SucursalActual.Id;

                                        Uow.CuentasMovimientos.Agregar(cuentasMovimiento);
                                        break;

                                    case FormaPago.Transferencia:
                                        var pagoTransferencia = pago as VentaPagoTransferencia;
                                        
                                        CuentasMovimiento cuentasMovimientoTransferecia = new CuentasMovimiento();
                                        cuentasMovimientoTransferecia.CuentaId = pagoTransferencia.CuentaId ?? 0;
                                        cuentasMovimientoTransferecia.TipoMovimientoId = 1;//Deposito a proveedor
                                        cuentasMovimientoTransferecia.FechaMovimiento = pagoTransferencia.Fecha;
                                        cuentasMovimientoTransferecia.EstadoMovimientoCuentaId = 0;
                                        cuentasMovimientoTransferecia.TipoComprobanteId = ucTipoCompra.TipoComprobanteSeleccionado;
                                        cuentasMovimientoTransferecia.ComprobanteId = compraNueva.Id;
                                        cuentasMovimientoTransferecia.MonedaId = 0;
                                        cuentasMovimientoTransferecia.NroMovimiento = pagoTransferencia.Numero;
                                        cuentasMovimientoTransferecia.Descripcion = "TRANSFERENCIA NRO " + pagoTransferencia.Numero.ToString();
                                        cuentasMovimientoTransferecia.FechaCobro = _clock.Now;
                                        cuentasMovimientoTransferecia.Debito = pago.Importe;
                                        cuentasMovimientoTransferecia.Credito = 0;
                                        cuentasMovimientoTransferecia.TipoCarga = 1;
                                        cuentasMovimientoTransferecia.CajaId = caja.Id;
                                        cuentasMovimientoTransferecia.FechaAlta = _clock.Now;
                                        cuentasMovimientoTransferecia.OperadorAltaId = Context.OperadorActual.Id;
                                        cuentasMovimientoTransferecia.SucursalAltaId = Context.SucursalActual.Id;

                                        Uow.CuentasMovimientos.Agregar(cuentasMovimientoTransferecia);
                                        break;
                                }
                            }
                           
                        }
                        break;
                }
                Uow.Cajas.Modificar(caja);
            }
            #endregion

            #region "Guardar cuenta corriente"
            if (ucTipoCompra.TipoComprobanteSeleccionado == TipoComprobanteEnum.FacCpraCtaCte)
            {
                //aca descontamos las señas en el caso de que se utilicen. 
               var _seña =  UsoDeSeña();
               var _credito = UsoDeCredito();

               Caja caja = this.Context.CajaActual;

               CajaMovimiento cajaMovimiento = new CajaMovimiento();
               cajaMovimiento.Id = Guid.NewGuid();
               cajaMovimiento.CajaId = caja.Id;

               cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.PagoProveedores;
               cajaMovimiento.TipoComprobante = ucTipoCompra.TipoComprobanteSeleccionado;
               cajaMovimiento.ComprobanteId = compraNueva.Id;

               cajaMovimiento.Senia = _seña + _credito;
                          

               //if (_seña > 0)
               //{
               //    cajaMovimiento.Senia = _seña;
               //}

               cajaMovimiento.ImpFac = (decimal?)ucTotalesCompraSeña1.SubTotal;

               cajaMovimiento.PcAlta = System.Environment.MachineName;
               cajaMovimiento.FechaAlta = _clock.Now;
               cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
               cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;
               Uow.CajaMovimientos.Agregar(cajaMovimiento);
            }
            #endregion

            Uow.Commit();

            _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessCompraExitosa);

            OnCompraRealizada();
        }

        private decimal? UsoDeSeña()
        {
            decimal? _seña = (decimal?) ucTotalesCompraSeña1.Senas;
            if (_seña > 0)
            {
                var monto = _seña;

                var proveedoresSenias =
                    Uow.ProveedoresSenias.Listado().Where((ps => ps.ProveedorId == _proveedor.Id
                                                                 && ps.ImporteUsado < ps.Importe)).OrderBy(
                                                                     p => p.FechaAlta).ToList();

                foreach (ProveedorSenia proveedorSenias in proveedoresSenias)
                {
                    if (monto != null)
                    {
                        if (monto > 0)
                        {
                            if ((proveedorSenias.Importe - proveedorSenias.ImporteUsado) >= monto)
                            {
                                proveedorSenias.ImporteUsado += monto;
                                monto = 0;
                            }
                            else
                            {
                                monto -= (proveedorSenias.Importe - proveedorSenias.ImporteUsado);
                                proveedorSenias.ImporteUsado = proveedorSenias.Importe;
                            }
                            Uow.ProveedoresSenias.Modificar(proveedorSenias);
                        }
                    }
                }
            }
            return _seña;
        }

        private decimal? UsoDeCredito()
        {
            decimal? Credito = (decimal?)ucTotalesCompraSeña1.Creditos;
            if (Credito > 0)
            {
                var monto = Credito;

                var proveedoresMontoFavor =
                    Uow.ProveedoresMontosFavor.Listado().Where((ps => ps.ProveedorId == _proveedor.Id
                                                                 && ps.ImporteOcupado < ps.Importe)).OrderBy(
                                                                     p => p.FechaAlta).ToList();

                foreach (ProveedoresMontosFavor proveedorCredito in proveedoresMontoFavor)
                {
                    if (monto != null)
                    {
                        if (monto > 0)
                        {
                            if ((proveedorCredito.Importe - proveedorCredito.ImporteOcupado) >= monto)
                            {
                                proveedorCredito.ImporteOcupado += monto;
                                monto = 0;
                            }
                            else
                            {
                                monto -= (proveedorCredito.Importe - proveedorCredito.ImporteOcupado);
                                proveedorCredito.ImporteOcupado = proveedorCredito.Importe;
                            }
                            Uow.ProveedoresMontosFavor.Modificar(proveedorCredito);
                        }
                    }
                }
            }
            return Credito;
        }

        private void OnCompraRealizada()
        {
            if (CompraRealizada != null)
            {
                CompraRealizada(this, new EventArgs());
            }
        }

        private void TxtRemito1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtRemito1.Text))
                return;

            if (TxtRemito1.Text.Length == 4)
            {
                TxtRemito2.Focus();
                TxtRemito2.SelectAll();
            }
        }

        private void TxtFactura1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFactura1.Text))
                return;

            if (TxtFactura1.Text.Length == 4)
            {
                TxtFactura2.Focus();
                TxtFactura2.SelectAll();
            }
        }
        #endregion

       


    }
}
