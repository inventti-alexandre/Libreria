using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Proveedores;
using LaPaz.Win.Forms.ProveedoresGastos;
using LaPaz.Win.Helpers;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using LaPaz.Win.Model;
using LaPaz.Win.Extensiones;
using LaPaz.Win.Forms.Autenticacion;

namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class FrmCrearEditarOrdenPago : EditFormBase
    {
        private Guid _ordenId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private IMessageBoxDisplayService _IMessageBoxDisplayService;
        private OrdenesPago _ordenPago;
        private IList<DetalleFormaPago> _pagos = new List<DetalleFormaPago>();
        private bool _solicitaAutorizacion;
        private Caja _cajaActual;
        private DetalleFormaPago _pagoFijo;

        public event EventHandler<decimal?> TotalAPagarChanged;
        public event EventHandler<decimal?> FaltaPagarChanged;
        public event EventHandler<int?> RecargoChanged;
        public event EventHandler TotalChanged;
        public event EventHandler<decimal?> PagosChanged;

        public FrmCrearEditarOrdenPago(IFormFactory formFactory,
                                       ILaPazUow uow,
                                       IClock clock,
                                       Guid id,
                                       ActionFormMode mode,
                                       IMessageBoxDisplayService messageBoxDisplayService)
        {
            Uow = uow;
            FormFactory = formFactory;

            _ordenId = id;
            _clock = clock;
            _formMode = mode;
            _IMessageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
            InicializarForm(mode);

            this.GridPagos.CellFormatting += this.Grilla_CellFormatting;
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearOrdenDePago;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarOrdenDePago;
                    break;
            }
        }

        private void FrmCrearEditarOrdenPago_Load(object sender, EventArgs e)
        {
            DtpFecha.MinDate = _clock.Now;
            DtpFechaImputacion.Value = _clock.Now;
            CbxCentroCosto.CargarCentroCosto();
            CbxProveedor.CargarProveedores(true);
            CbxSucursal.CargarSucursal();
            CbxSucursalGasto.CargarSucursal();
            CbxTipoGastos.CargarTiposGasto();
            CbxTipoComprobante.CargarTiposComprobantes();
            CbxLetraComprobante.CargarLetrasComprobantes();
            //CbxTipoGastos.SeleccionarFinished += SetConcepto;
            CargarOrdenPago();
        }

        #region Propiedades

        public decimal? PagoFijoEfectivo
        {
            get { return _pagoFijo.Importe ?? 0; }
            set { _pagoFijo.Importe = value; }
        }

        public string Concepto
        {
            get { return TxtConcepto.Text; }
            set { TxtConcepto.Text = value; }
        }

        public DateTime Fecha
        {
            get { return DtpFecha.Value; }
            set { DtpFecha.Value = value; }
        }

        public DateTime FechaImputacion
        {
            get { return DtpFechaImputacion.Value; }
            set { DtpFechaImputacion.Value = value; }
        }

        public int? SucursalId
        {
            get { return (int?)CbxSucursal.SucursalId; }
            set { CbxSucursal.SucursalId = value ?? 0; }
        }

        public Guid? ProveedorId
        {
            get { return (Guid?)CbxProveedor.ProveedorId; }
            set { CbxProveedor.ProveedorId = value ?? Guid.Empty; }
        }

        public int? CentroCostoId
        {
            get { return (int?)CbxCentroCosto.CentrosCostoId; }
            set { CbxCentroCosto.CentrosCostoId = value ?? 0; }
        }

        public TipoComprobanteEnum? TipoComprobanteId
        {
            get { return CbxTipoComprobante.TipoComprobanteId(); }
            set { CbxTipoComprobante.Set(value ?? 0); }
        }

        public string LetraComprobante
        {
            get { return CbxLetraComprobante.Letra; }
            set { CbxLetraComprobante.Letra = value; }
        }

        public string NroComprobante
        {
            get
            {
                char pad = '0';
                return string.Format("{0}{1}", TxtNroComprobante1.Text.PadLeft(4, pad), TxtNroComprobante2.Text.PadLeft(9, pad));
            }
            set
            {
                TxtNroComprobante1.Text = value.Substring(0, 4);
                TxtNroComprobante2.Text = value.Substring(4, 9);
            }
        }

        public int? TipoGastoId
        {
            get { return (int?)CbxTipoGastos.TipoGastoId; }
            set { CbxTipoGastos.TipoGastoId = value ?? 0; }
        }

        public int? SucursalGastoId
        {
            get { return (int?)CbxSucursalGasto.SucursalId; }
            set { CbxSucursalGasto.SucursalId = value ?? 0; }
        }

        public decimal? ImporteDebe
        {
            get { return TxtImporteDebe.Value; }
            set { TxtImporteDebe.Text = String.Format("{0:0.##}", (value ?? 0)); }
        }

        public decimal? Importe
        {
            get { return TxtImporte.Value; }
            set { TxtImporte.Text = String.Format("{0:0.##}", (value ?? 0)); }
        }

        public decimal? Recargo
        {
            get { return TxtRecargo.Value ?? 0; }
            set { TxtRecargo.Text = String.Format("{0:0.##}", (value ?? 0)); }
        }

        public decimal? SubTotal
        {
            get { return TxtSubTotal.Value; }
            set { TxtSubTotal.Text = String.Format("{0:0.##}", (value ?? 0)); }
        }

        public bool RegistraIVA
        {
            get { return ckdRegistraIVA.Checked; }
            set { ckdRegistraIVA.Checked = value; }
        }

        private Guid? operadorAutoriza;
        public Guid? OperadorAutoriza
        {
            get { return (Guid?)operadorAutoriza; }
            set { operadorAutoriza = value ?? Guid.Empty; }
        }

        #endregion

        #region Metodos

        private bool LoginComoAdmin()
        {
            //////Autorizacion para sin movimiento
            var operador = this.ObtenerOperadorAdministrador();

            if (operador == null)
            {
                return false;
            }

            if (!this.EsOperadorAdmin)
            {
                //Guardamos el operador que autorizo la operacion.
                operadorAutoriza = operador.Id;
            }

            return true;
        }

        private void CargarOrdenPago()
        {
            if (_ordenId == default(Guid))
            {
                _ordenPago = new OrdenesPago();
                this.Text = Resources.LabelCrearOrdenDePago;
                this.Fecha = DateTime.Today;
                this.FechaImputacion = DateTime.Today;
                CbxSucursal.SucursalId = Context.SucursalActual.Id;
                CbxSucursalGasto.SucursalId = Context.SucursalActual.Id;
                CbxCentroCosto.CentrosCostoId = Context.SucursalActual.Id;
                //Default values.
            }
            else
            {
                this.Text = Resources.LabelEditarOrdenDePago;
                BtnGuardar.Text = "Guardar";
                _ordenPago = Uow.OrdenesPagos.Obtener(o => o.Id == _ordenId, o => o.OrdenesPagoDetalles);

                TxtImporte.Enabled = false;
                TxtRecargo.Enabled = false;
                TxtSubTotal.Enabled = false;

                this.SubTotal = _ordenPago.SubTotal;
                this.Importe = _ordenPago.Importe;
                this.ImporteDebe = _ordenPago.Importe - (_ordenPago.ImportePagado ?? 0);
                this.Recargo = _ordenPago.Recargo;
                this.Concepto = _ordenPago.Concepto;
                this.SucursalId = _ordenPago.SucursalId;
                this.SucursalGastoId = _ordenPago.SucursalGastoId;
                this.ProveedorId = _ordenPago.ProveedorId;
                this.NroComprobante = _ordenPago.NumeroComprobante;
                this.LetraComprobante = _ordenPago.LetraComprobante;
                this.TipoComprobanteId = _ordenPago.TipoComprobanteId;
                this.TipoGastoId = _ordenPago.TipoGastoId;
                this.CentroCostoId = _ordenPago.CentroCostoId;
                this.RegistraIVA = _ordenPago.RegistraIVACompra ?? false;
                this.Fecha = _ordenPago.Fecha == DateTime.MinValue ? DateTime.Today : _ordenPago.Fecha;
                this.FechaImputacion = _ordenPago.FechaImputacion ?? DateTime.Today;

                ToggleHabilitarBotonGuardar();

                CargarOrdenPagoDetalle();
            }

        }

        private void ToggleHabilitarBotonGuardar()
        {
            if (ImporteDebe == 0 && this._formMode == ActionFormMode.Edit)
            {
                BtnGuardar.Enabled = false;
            }
            else
            {
                BtnGuardar.Enabled = true;
            }
        }

        private void CargarOrdenPagoDetalle()
        {
            _pagos = new List<DetalleFormaPago>();

            var detalleLista = _ordenPago.OrdenesPagoDetalles.Where(d => !d.FechaAnulacion.HasValue).ToList();

            foreach (var ordenesPagoDetalle in detalleLista)
            {
                DetalleFormaPago pago = new DetalleFormaPago();

                if (ordenesPagoDetalle.Efectivo.HasValue && ordenesPagoDetalle.Efectivo > 0)
                {
                    var pagoEfectivo = new PagoEfectivo();
                    pagoEfectivo.Id = ordenesPagoDetalle.Id;
                    pagoEfectivo.Importe = ordenesPagoDetalle.Efectivo;
                    pagoEfectivo.TipoPago = FormaPago.Efectivo;
                    pagoEfectivo.Descripcion = ordenesPagoDetalle.Descripcion;
                    pagoEfectivo.Fecha = ordenesPagoDetalle.FechaPago;
                    pago = pagoEfectivo;
                }

                if (ordenesPagoDetalle.Cheques.HasValue && ordenesPagoDetalle.Cheques > 0)
                {
                    var pagoCheque = new PagoCheque();
                    pagoCheque.Id = ordenesPagoDetalle.Id;
                    pagoCheque.Importe = ordenesPagoDetalle.Cheques;
                    pagoCheque.TipoPago = FormaPago.Cheque;
                    pagoCheque.Descripcion = ordenesPagoDetalle.Descripcion;
                    pagoCheque.Fecha = ordenesPagoDetalle.FechaPago;
                    pago = pagoCheque;
                }

                if (ordenesPagoDetalle.DepositoEfectivo.HasValue && ordenesPagoDetalle.DepositoEfectivo > 0)
                {
                    var pagoDeposito = new PagoDeposito();
                    var cuentaMov =
                        Uow.CuentasMovimientos.Obtener(
                            c =>
                            c.ComprobanteId == _ordenPago.Id && c.Descripcion.Contains(ordenesPagoDetalle.Descripcion));
                    pagoDeposito.Id = ordenesPagoDetalle.Id;
                    pagoDeposito.DepositoCuentaId = cuentaMov.CuentaId;
                    pagoDeposito.Importe = ordenesPagoDetalle.DepositoEfectivo;
                    pagoDeposito.TipoPago = FormaPago.Deposito;
                    pagoDeposito.Descripcion = ordenesPagoDetalle.Descripcion;
                    pagoDeposito.Fecha = ordenesPagoDetalle.FechaPago;
                    pago = pagoDeposito;
                }

                if (ordenesPagoDetalle.Transferencia.HasValue && ordenesPagoDetalle.Transferencia > 0)
                {
                    var pagoTransferencia = new PagoTransferencia();
                    var cuentaMov =
                        Uow.CuentasMovimientos.Obtener(
                            c =>
                            c.ComprobanteId == _ordenPago.Id && c.Descripcion.Contains(ordenesPagoDetalle.Descripcion));
                    pagoTransferencia.Id = ordenesPagoDetalle.Id;
                    pagoTransferencia.CuentaId = cuentaMov.CuentaId;
                    pagoTransferencia.Importe = ordenesPagoDetalle.Transferencia;
                    pagoTransferencia.TipoPago = FormaPago.Transferencia;
                    pagoTransferencia.Descripcion = ordenesPagoDetalle.Descripcion;
                    pagoTransferencia.Fecha = ordenesPagoDetalle.FechaPago;
                    pago = pagoTransferencia;
                }

                pago.PuedeEliminar = ordenesPagoDetalle.PuedeEliminar();

                _pagos.Add(pago);
            }

            GridPagos.DataSource = _pagos.ToList();
        }

        protected override void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            base.Grilla_CellFormatting(sender, e);

            if (e.Column.Name == "Eliminar")
            {
                var orden = e.Row.DataBoundItem as DetalleFormaPago;
                if (orden != null)
                {
                    e.CellElement.Enabled = orden.PuedeEliminar;
                }
            }
        }

        private void TxtSubTotal_Validated(object sender, EventArgs e)
        {
            Importe = SubTotal + Recargo;
            //ImporteDebe = SubTotal + Recargo;
            RefrescarPagos();
        }

        private void TxtRecargo_Validated(object sender, EventArgs e)
        {
            Importe = SubTotal + Recargo;
            //ImporteDebe = SubTotal + Recargo;
            RefrescarPagos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                foreach (var pago in _pagos)
                {
                    if (pago.TipoPago == FormaPago.Efectivo)
                    {
                        var pagoEfec = pago as PagoEfectivo;
                        if (pagoEfec.CajaAnterior)
                            _solicitaAutorizacion = true;
                    }
                }

                if (_solicitaAutorizacion)
                {
                    if (LoginComoAdmin())
                        GuardarOrdenPago();
                }
                else
                {
                    GuardarOrdenPago();
                }
            }
        }

        private void GuardarOrdenPago()
        {
            //Obtenemos una instancia comun de la caja actual.
            _cajaActual = Context.CajaActual;

            var orden = ObtenerOrdenPagoDesdeForm();

            Caja caja = this.Context.CajaActual;

            if (_formMode == ActionFormMode.Create)
            {
                ActualizarOrdenPagoDetalle();
                Uow.OrdenesPagos.Agregar(orden);
            }
            else
            {
                ActualizarOrdenPagoDetalle();
                Uow.OrdenesPagos.Modificar(orden);
            }

            Uow.Commit();

            _ordenId = _ordenPago.Id;

            this.DialogResult = DialogResult.OK;
        }

        private void ActualizarOrdenPagoDetalle()
        {
            int linea = 1;
            foreach (var pago in _pagos)
            {
                if (pago.IsDeleted)
                {
                    var detalle = Uow.OrdenesPagosDetalle.Obtener(d => d.Id == pago.Id);
                    detalle.InvertirImportes();
                    AgregarMovimientos(detalle, pago);

                    if (pago.TipoPago == FormaPago.Transferencia || pago.TipoPago == FormaPago.Deposito)
                    {
                        pago.Importe = -pago.Importe;
                        AgregarCuentaMovimiento(pago);
                    }

                    detalle.FechaAnulacion = _clock.Now;
                    Uow.OrdenesPagosDetalle.Modificar(detalle);
                }
                else
                {
                    var detalle = ObtenerDetalle(pago);
                    detalle.NumeroLinea = linea;

                    if (pago.Id == Guid.Empty)
                    {
                        AgregarMovimientos(detalle, pago);
                        if (pago.TipoPago == FormaPago.Transferencia || pago.TipoPago == FormaPago.Deposito)
                        {
                            AgregarCuentaMovimiento(pago);
                        }

                        Uow.OrdenesPagosDetalle.Agregar(detalle);
                    }
                    else
                    {
                        Uow.OrdenesPagosDetalle.Modificar(detalle);
                    }

                    linea++;
                }
            }
        }

        protected override bool ValidarForm()
        {
            var esValido = true;
            if (CbxTipoComprobante.TipoComprobanteId() == null)
            {
                esValido = false;
                this.FormErrorProvider.SetError(CbxTipoComprobante, "Debe ingresar un tipo de comprobante");
            }
            if (esValido)
                return base.ValidarForm();

            return false;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerOrdenPagoDesdeForm();
        }

        private OrdenesPago ObtenerOrdenPagoDesdeForm()
        {
            _ordenPago.Id = _ordenId == default(Guid) ? Guid.NewGuid() : _ordenId;
            _ordenPago.Concepto = TxtConcepto.Text;
            _ordenPago.CentroCostoId = (int?)CbxCentroCosto.CentrosCostoId;
            _ordenPago.Fecha = _clock.Now;
            _ordenPago.FechaImputacion = DtpFechaImputacion.Value;
            _ordenPago.Importe = Importe ?? 0;
            _ordenPago.ImportePagado = Importe - ImporteDebe;
            _ordenPago.Recargo = Recargo;
            _ordenPago.SubTotal = SubTotal ?? 0;
            _ordenPago.SucursalGastoId = (int?)CbxSucursalGasto.SucursalId;
            _ordenPago.TipoGastoId = (int?)CbxTipoGastos.TipoGastoId;
            _ordenPago.TipoComprobanteId = (TipoComprobanteEnum)CbxTipoComprobante.TipoComprobanteId();
            _ordenPago.LCN = _ordenId == default(Guid) ? GenerarLCN() : _ordenPago.LCN;
            _ordenPago.NumeroComprobante = NroComprobante;
            _ordenPago.LetraComprobante = CbxLetraComprobante.Letra;
            _ordenPago.ProveedorId = CbxProveedor.ProveedorId ?? Guid.Empty;
            _ordenPago.SucursalId = CbxSucursal.SucursalId ?? 0;

            //Fechas.
            _ordenPago.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _ordenPago.FechaAlta;
            _ordenPago.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;


            _ordenPago.SucursalAltaId = _formMode == ActionFormMode.Create
                ? Context.SucursalActual.Id
                : _ordenPago.SucursalAltaId;

            _ordenPago.SucursalModificacionId = _formMode == ActionFormMode.Create
                ? null
                : _ordenPago.SucursalModificacionId;

            _ordenPago.OperadorAltaId = _formMode == ActionFormMode.Create
                ? Context.OperadorActual.Id
                : _ordenPago.OperadorAltaId;

            _ordenPago.OperadorModificacionId = _formMode == ActionFormMode.Create
                ? null
                : _ordenPago.OperadorModificacionId;

            return _ordenPago;
        }

        private string GenerarLCN()
        {
            string lcn = "";
            lcn = String.Format("{0}{1}", CbxLetraComprobante.Letra.ToUpper(), LCNGasto.Generar(Uow, CbxSucursal.SucursalId ?? 0));

            return lcn;
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtSubTotal, "Importe");
            this.ValidarControl(TxtImporteDebe, "ImportePagado");
            this.ValidarControl(TxtRecargo, "Recargo");
            this.ValidarControl(TxtImporte, "SubTotal");
            this.ValidarControl(TxtConcepto, "Concepto");
            this.ValidarControl(TxtNroComprobante2, "NumeroComprobante");
            this.ValidarControl(CbxTipoComprobante, "TipoComprobanteId");
            this.ValidarControl(CbxCentroCosto, "CentroCostoId");
            this.ValidarControl(CbxLetraComprobante, "LetraComprobante");
            this.ValidarControl(CbxProveedor, "ProveedorId");
            this.ValidarControl(CbxSucursal, "SucursalId");
            this.ValidarControl(CbxSucursalGasto, "SucursalGastoId");
            this.ValidarControl(CbxTipoGastos, "TipoGastoId");
        }

        private void EliminarPago(DetalleFormaPago pago)
        {
            if (pago.Id != Guid.Empty)
            {
                pago.IsDeleted = true;
            }
            else
            {
                _pagos.Remove(pago);
            }

            RefrescarPagos();
        }

        private void AgregarMovimientos(OrdenesPagoDetalle pago, DetalleFormaPago vPago)
        {
            var movimiento = new CajaMovimiento();
            movimiento.Id = Guid.NewGuid();
            movimiento.Importe = pago.ImportePagado;
            movimiento.ComprobanteId = _ordenPago.Id;
            movimiento.TipoComprobante = TipoComprobanteEnum.OrdenPago;
            movimiento.TipoMovimientoCajaId = vPago.IsDeleted ? TipoMovimientoCajaEnum.AnulaciónOrdenPago : TipoMovimientoCajaEnum.PagoGastos;
            movimiento.PcAlta = Environment.MachineName;

            movimiento.CajaId = _cajaActual.Id;

            if (pago.Efectivo.HasValue && pago.Efectivo != 0)
            {
                //Si ImportePagado <> 0 => Pago Normal en Efectivo
                //Si ImportePagado = 0 => Pago Programado
                if (pago.ImportePagado.HasValue && pago.ImportePagado != 0)
                {
                    movimiento.Efectivo = pago.Efectivo;

                    var pagoEfec = vPago as PagoEfectivo;

                    if (pagoEfec.CajaAnterior)
                    {
                        ActualizarCajaAnterior(pagoEfec, _cajaActual, movimiento);
                    }
                    else
                    {
                        ActualizarCajaActual(pago, _cajaActual);
                    }

                    Uow.Cajas.Modificar(_cajaActual);
                }
            }

            if (pago.Cheques.HasValue && pago.Cheques != 0)
            {
                movimiento.Cheque = pago.ImportePagado;
            }

            if (pago.DepositoEfectivo.HasValue && pago.DepositoEfectivo != 0)
            {
                movimiento.Deposito = pago.ImportePagado;
            }

            if (pago.Transferencia.HasValue && pago.Transferencia != 0)
            {
                movimiento.Transferencia = pago.ImportePagado;
            }

            movimiento.FechaAlta = pago.Id == default(Guid) ? _clock.Now : pago.FechaAlta;
            movimiento.SucursalAltaId = Context.SucursalActual.Id;
            movimiento.OperadorAltaId = Context.OperadorActual.Id;

            Uow.CajaMovimientos.Agregar(movimiento);
        }

        private void ActualizarCajaActual(OrdenesPagoDetalle pago, Caja caja)
        {
            caja.Egresos += (float)(pago.Efectivo ?? 0);
            caja.Saldo -= (float)(pago.Efectivo ?? 0);
            caja.FechaModificacion = pago.Id == default(Guid) ? (DateTime?)null : _clock.Now;
            caja.SucursalModificacionId = pago.Id == default(Guid)
                                              ? (int?)null
                                              : Context.SucursalActual.Id;
            caja.OperadorModificacionId = pago.Id == default(Guid)
                                              ? (Guid?)null
                                              : Context.OperadorActual.Id;
        }

        private void ActualizarCajaAnterior(PagoEfectivo pagoEfec, Caja caja, CajaMovimiento cajaMovimiento)
        {
            cajaMovimiento.CajaId = caja.Id;
            cajaMovimiento.TipoComprobante = TipoComprobanteEnum.OrdenPago;
            cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.DepositoConCajaAnterior;
            cajaMovimiento.ComprobanteId = _ordenPago.Id;
            cajaMovimiento.Importe = pagoEfec.Importe;

            if (cajaMovimiento.Efectivo == null)
                cajaMovimiento.Efectivo = 0;

            cajaMovimiento.Efectivo = pagoEfec.Importe;

            if (caja.Saldo == null)
                caja.Saldo = 0;

            //Pago Efectivo para Caja Anterior solo se Modifica el Saldo Acumulado
            caja.Saldo -= (float?)pagoEfec.Importe;
        }

        #region TiposGasto

        private void BtnAgregarTipoGasto_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarTipoGasto>(0, ActionFormMode.Create))
            {
                formCrear.CargaFinished += RefrescarCbxTiposGasto;
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                }
            }
        }

        private void RefrescarCbxTiposGasto(object sender, TiposGasto tipo)
        {
            CbxTipoGastos.CargarTiposGasto();
            CbxTipoGastos.TipoGastoId = tipo.Id;
            SetConcepto(sender, tipo);
        }

        private void SetConcepto(object sender, TiposGasto tipo)
        {
            TxtConcepto.Text = tipo != null
                                   ? (tipo.Descripcion ?? TxtConcepto.Text)
                                   : TxtConcepto.Text;
        }

        #endregion

        #region Proveedor

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarProveedorGasto>(Guid.Empty, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefrescarCbxProveedor(formCrear.Proveedor.Id);
                    formCrear.Close();
                }
            }
        }

        private void RefrescarCbxProveedor(Guid proveedorId)
        {
            CbxProveedor.CargarProveedores(true);
            CbxProveedor.ProveedorId = proveedorId;
        }

        #endregion

        private OrdenesPagoDetalle ObtenerDetalle(DetalleFormaPago pago)
        {
            OrdenesPagoDetalle _ordenPagoDetalle;
            if (pago.Id == Guid.Empty)
            {
                _ordenPagoDetalle = new OrdenesPagoDetalle();
                _ordenPagoDetalle.Id = Guid.NewGuid();
                _ordenPagoDetalle.OrdenPagoId = _ordenPago.Id;
            }
            else
            {
                _ordenPagoDetalle = _ordenPago.OrdenesPagoDetalles.FirstOrDefault(d => d.Id == pago.Id);
            }

            //La caja siempre esta abierta.
            var cajaActual = this.Context.CajaActual;

            _ordenPagoDetalle.CajaId = cajaActual.Id;
            _ordenPagoDetalle.OperadorAutorizaId = operadorAutoriza;
            _ordenPagoDetalle.Descripcion = pago.Descripcion;
            //Fechas.
            _ordenPagoDetalle.FechaAlta = _clock.Now;

            _ordenPagoDetalle.SucursalAltaId = Context.SucursalActual.Id;

            _ordenPagoDetalle.OperadorAltaId = Context.OperadorActual.Id;

            switch (pago.TipoPago)
            {
                case FormaPago.Transferencia:
                    _ordenPagoDetalle.FechaPago = _clock.Now;
                    _ordenPagoDetalle.Transferencia = pago.Importe;
                    _ordenPagoDetalle.ImportePagado = pago.Importe;
                    break;
                case FormaPago.Cheque:
                    _ordenPagoDetalle.FechaPago = _clock.Now;
                    _ordenPagoDetalle.Cheques = pago.Importe;
                    _ordenPagoDetalle.ImportePagado = pago.Importe;
                    break;
                case FormaPago.Deposito:
                    _ordenPagoDetalle.FechaPago = _clock.Now;
                    _ordenPagoDetalle.DepositoEfectivo = pago.Importe;
                    _ordenPagoDetalle.ImportePagado = pago.Importe;
                    break;
                case FormaPago.Efectivo:
                    _ordenPagoDetalle.FechaPago = DtpFecha.Value;
                    _ordenPagoDetalle.Efectivo = pago.Importe;
                    //Si FechaPago > hoy => Pago PRogramado con Importe PAgado = 0
                    _ordenPagoDetalle.ImportePagado = (pago.Fecha.Value.Date == _clock.Now.Date) ? pago.Importe : 0;
                    break;
            }

            return _ordenPagoDetalle;
        }

        private void AgregarCuentaMovimiento(DetalleFormaPago pago)
        {
            var movimiento = new CuentasMovimiento();

            movimiento.ComprobanteId = _ordenPago.Id;

            switch (pago.TipoPago)
            {
                case FormaPago.Transferencia:
                    var pagoTrans = pago as PagoTransferencia;
                    movimiento.Debito = pagoTrans.Importe;
                    movimiento.NroMovimiento = pagoTrans.Numero;
                    movimiento.CuentaId = (int)pagoTrans.CuentaId;
                    movimiento.FechaMovimiento = _clock.Now;
                    movimiento.Descripcion = pagoTrans.Descripcion;
                    movimiento.TipoComprobanteId = TipoComprobanteEnum.OrdenPago;
                    movimiento.TipoMovimientoId = (int)TipoMovimientoBancarioEnum.TransferenciaBancariaOrdenPago;
                    break;
                case FormaPago.Deposito:
                    var pagoDeposito = pago as PagoDeposito;
                    movimiento.Debito = pagoDeposito.Importe;
                    movimiento.NroMovimiento = pagoDeposito.Numero;
                    movimiento.CuentaId = (int)pagoDeposito.DepositoCuentaId;
                    movimiento.FechaMovimiento = _clock.Now;
                    movimiento.Descripcion = pagoDeposito.Descripcion;
                    movimiento.TipoComprobanteId = TipoComprobanteEnum.OrdenPago;
                    movimiento.TipoMovimientoId = (int)TipoMovimientoBancarioEnum.DepositoEfectivo;
                    break;
            }

            Caja caja = this.Context.CajaActual;

            movimiento.CajaId = caja.Id;
            movimiento.FechaAlta = _clock.Now;
            movimiento.SucursalAltaId = Context.SucursalActual.Id;
            movimiento.OperadorAltaId = Context.OperadorActual.Id;

            Uow.CuentasMovimientos.Agregar(movimiento);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (var formAgregarPago = FormFactory.Create<FrmAgregarPago>())
            {
                formAgregarPago.Importe = ImporteDebe;
                formAgregarPago.PagoAgregado += (o, pago) =>
                {
                    _pagos.Add(pago);
                    ActualizarPagoEfectivoFijo();
                    if (Importe < TotalPagos() || PagoFijoEfectivo < 0)
                    {
                        _pagos.Remove(pago);
                        _IMessageBoxDisplayService.ShowError("La suma de los pagos no debe superar el importe total de la orden de pago.");
                    }

                    RefrescarPagos();

                    formAgregarPago.Close();
                };

                formAgregarPago.ShowDialog();
            }
        }

        public void RefrescarPagos()
        {
            ActualizarPagoEfectivoFijo();
            GridPagos.DataSource = _pagos.Where(p => !p.IsDeleted).ToList();
            BtnAgregar.Enabled = _pagos.Count != 0;
        }

        private void ActualizarPagoEfectivoFijo()
        {
            if (_pagos.Count == 0)
            {
                var _pago = new PagoEfectivo { TipoPago = FormaPago.Efectivo, EsFijo = true, Importe = Importe, Fecha = _clock.Now};
                ImporteDebe = 0;
                _pagoFijo = _pago;
                _pagos.Add(_pagoFijo);
            }
            else
            {
                _pagoFijo = _pagos.FirstOrDefault(p => p.EsFijo);
                if (_pagoFijo != null && PagoFijoEfectivo != 0)
                {
                    PagoFijoEfectivo = Importe - this._pagos.Where(p => !p.IsDeleted && !p.EsFijo).Sum(p => p.Importe ?? 0);
                    if (PagoFijoEfectivo == 0)
                    {
                        _pagos.Remove(_pagoFijo);
                    }
                }
                else
                {
                    var total = TotalPagos();
                    ImporteDebe = Importe - total;
                }
            }
        }

        public decimal TotalPagos()
        {
            return this._pagos.Where(p => !p.IsDeleted).Sum(p => p.Importe ?? 0);
        }

        private void GridPagos_CommandCellClick(object sender, EventArgs e)
        {
            var selectedRow = GridPagos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
            {
                return;
            }

            var pago = selectedRow.DataBoundItem as DetalleFormaPago;

            if (pago == null)
                return;

            EliminarPago(pago);
            ToggleHabilitarBotonGuardar();
        }
        #endregion
    }
}

