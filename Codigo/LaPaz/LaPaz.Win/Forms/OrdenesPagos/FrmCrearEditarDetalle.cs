using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.ProveedoresBancos;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;


namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class FrmCrearEditarDetalle : EditFormBase
    {
        private Guid _pagoId;
        private Guid _ordenPagoId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private OrdenesPagoDetalle _ordenPagoDetalle;
        private OrdenesPago _ordenPago;
        private bool _esEfectivo = false;

        public event EventHandler<OrdenesPagoDetalle> CargaFinished;

        public FrmCrearEditarDetalle(IFormFactory formFactory, ILaPazUow uow, IClock clock, Guid id, ActionFormMode mode, IMessageBoxDisplayService messageBoxDisplayService)
        {
            Uow = uow;
            FormFactory = formFactory;
            _pagoId = id;
            _clock = clock;
            _formMode = mode;
            _messageBoxDisplayService = messageBoxDisplayService;


            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearPago;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarPago;
                    BtnGuardar.Text = "Pagar";
                    break;
            }
        }

        #region Propiedades

        public OrdenesPago OrdenPago
        {
            get { return _ordenPago; }
            set { _ordenPago = value; }
        }

        public Guid OrdenPagoId
        {
            set { _ordenPagoId = value; }
        }

        public DateTime FechaPago
        {
            get { return DtpFechaPago.Value; }
            set { DtpFechaPago.Value = value; }
        }

        public decimal ImportePagado
        {
            get
            {
                return (FechaPago == DateTime.Today)? TxtImportePagado.Value ?? 0 : 0;
            }
            set { TxtImportePagado.Text = value.ToString(); }
        }

        public decimal? Efectivo
        {
            get { return TxtEfectivo.Value ?? 0; }
            set { TxtEfectivo.Text = value.ToString(); }
        }

        #endregion

        #region Metodos
        protected override object ObtenerEntidad()
        {
            return ObtenerPagoDesdeForm();
        }

        private OrdenesPagoDetalle ObtenerPagoDesdeForm()
        {
            _ordenPagoDetalle.Id = _pagoId == default(Guid) ? Guid.NewGuid() : _pagoId;
            _ordenPagoDetalle.OrdenPagoId = _ordenPagoId;
            _ordenPagoDetalle.FechaPago = DtpFechaPago.Value;
            _ordenPagoDetalle.Efectivo = this.Efectivo;
            _ordenPagoDetalle.ImportePagado = ImportePagado;;
            _esEfectivo = (_ordenPagoDetalle.Efectivo != null || _ordenPagoDetalle.Efectivo != 0);
            var orden = Uow.OrdenesPagos.Obtener(o => o.Id == _ordenPagoId, o => o.OrdenesPagoDetalles);
            _ordenPagoDetalle.NumeroLinea = orden.OrdenesPagoDetalles.Count + 1;
            //Fechas.
            _ordenPagoDetalle.FechaAlta = _pagoId == default(Guid) ? _clock.Now : _ordenPagoDetalle.FechaAlta;
            _ordenPagoDetalle.FechaModificacion = _pagoId == default(Guid) ? (DateTime?)null : _clock.Now;

            _ordenPagoDetalle.SucursalAltaId = _pagoId == default(Guid)
                ? Context.SucursalActual.Id
                : _ordenPagoDetalle.SucursalAltaId;

            _ordenPagoDetalle.SucursalModificacionId = _pagoId == default(Guid)
                ? null
                : _ordenPagoDetalle.SucursalModificacionId;

            _ordenPagoDetalle.OperadorAltaId = _pagoId == default(Guid)
                ? Context.OperadorActual.Id
                : _ordenPagoDetalle.OperadorAltaId;

            _ordenPagoDetalle.OperadorModificacionId = _pagoId == default(Guid)
                ? null
                : _ordenPagoDetalle.OperadorModificacionId;

            return _ordenPagoDetalle;
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                _messageBoxDisplayService.ShowWarning("Se debe completar algùn campo con el monto a pagar.");
            }
            else
            {
                var pago = ObtenerPagoDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    Uow.OrdenesPagosDetalle.Agregar(pago);
                    if(pago.FechaPago == DateTime.Today && _esEfectivo)
                    {
                        var orden = Uow.OrdenesPagos.Obtener(o => o.Id == _ordenPagoId);
                        orden.ImportePagado += pago.ImportePagado;
                        Uow.OrdenesPagos.Modificar(orden);
                        AgregarMovimientos();
                    }
                }
                else
                {
                    Uow.OrdenesPagosDetalle.Modificar(pago);
                }
               
                Uow.Commit();
               
                BtnCancelar.DialogResult = DialogResult.OK;
            }
        }

        private void AgregarMovimientos()
        {
            var movimiento = new CajaMovimiento();
            movimiento.Id = Guid.NewGuid();
            movimiento.Importe = _ordenPagoDetalle.ImportePagado;
            movimiento.ComprobanteId = _ordenPagoId;
            movimiento.TipoComprobante = TipoComprobanteEnum.OrdenPago;
            movimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.PagoGastos;
            Caja caja = this.Context.CajaActual;
            movimiento.CajaId = caja.Id;
            if(_esEfectivo)
            {
                movimiento.Efectivo = _ordenPagoDetalle.ImportePagado;
                caja.Egresos += (float) (_ordenPagoDetalle.ImportePagado??0);
                caja.Saldo -= (float) (_ordenPagoDetalle.ImportePagado??0);
                caja.FechaModificacion = _pagoId == default(Guid) ? (DateTime?)null : _clock.Now;
                caja.SucursalModificacionId = _pagoId == default(Guid)
               ? null
               : caja.SucursalModificacionId;
                caja.OperadorModificacionId = _pagoId == default(Guid)
                ? null
                : caja.OperadorModificacionId;
                Uow.Cajas.Modificar(caja);
            }
            else
            {
                movimiento.Cheque = _ordenPagoDetalle.ImportePagado;
            }

            movimiento.FechaAlta = _pagoId == default(Guid) ? _clock.Now : _ordenPagoDetalle.FechaAlta;
            movimiento.FechaModificacion = _pagoId == default(Guid) ? (DateTime?)null : _clock.Now;

            movimiento.SucursalAltaId = _pagoId == default(Guid)
                ? Context.SucursalActual.Id
                : movimiento.SucursalAltaId;

            movimiento.SucursalModificacionId = _pagoId == default(Guid)
                ? null
                : movimiento.SucursalModificacionId;

            movimiento.OperadorAltaId = _pagoId == default(Guid)
                ? Context.OperadorActual.Id
                : movimiento.OperadorAltaId;

            movimiento.OperadorModificacionId = _pagoId == default(Guid)
                ? null
                : movimiento.OperadorModificacionId;

            Uow.CajaMovimientos.Agregar(movimiento);
        }

        private bool Validar()
        {
            bool result = !(!TxtEfectivo.IsDecimal() && !TxtImportePagado.IsDecimal());

            return result;
        }

        private void FrmCrearEditarDetalle_Load(object sender, EventArgs e)
        {
            DtpFechaPago.MinDate = DateTime.Today;
            CargarPago();
        }

        private void CargarPago()
        {
            if (_pagoId == default(Guid))
            {
                _ordenPagoDetalle = new OrdenesPagoDetalle();
                //Default values.
            }
            else
            {
                _ordenPagoDetalle = Uow.OrdenesPagosDetalle.Obtener(o => o.Id == _pagoId);
                this.Efectivo = _ordenPagoDetalle.Efectivo;
                this.ImportePagado = _ordenPagoDetalle.ImportePagado ?? 0;
                _esEfectivo = (_ordenPagoDetalle.Efectivo != null || _ordenPagoDetalle.Efectivo != 0);

            }

            this.FechaPago = _ordenPagoDetalle.FechaPago ?? DateTime.Today;
        }

        #region TextBox

        private void TxtEfectivo_Validated(object sender, EventArgs e)
        {
            CalcularImporte(Efectivo.Value, false);
        }

        private void CalcularImporte(decimal importe, bool conDescuento)
        {
            if (!conDescuento)
            {
                ImportePagado = importe;
            }
        }

        #endregion
    }
}
