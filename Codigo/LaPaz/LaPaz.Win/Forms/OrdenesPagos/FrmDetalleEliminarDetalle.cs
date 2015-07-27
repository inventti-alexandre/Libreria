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
    public partial class FrmDetalleEliminarDetalle : EditFormBase
    {
        private Guid _pagoId;
        private Guid _ordenPagoId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private OrdenesPagoDetalle _ordenPagoDetalle;
        private OrdenesPago _ordenPago;
        private bool _esEfectivo = false;
        
        public FrmDetalleEliminarDetalle(IFormFactory formFactory, ILaPazUow uow, IClock clock, Guid id, ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            _pagoId = id;
            _clock = clock;
            _formMode = mode;
            
            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetallePago;
                    BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarPago;
                    break;
            }
        }

        #region Propiedades

        public OrdenesPago OrdenPago
        {
            get { return _ordenPago; }
            set { _ordenPago = value; }
        }

        public Guid? OrdenPagoId
        {
            set { _ordenPagoId = value ?? Guid.Empty; }
        }

        public DateTime FechaPago
        {
            get { return DtpFechaPago.Value; }
            set { DtpFechaPago.Value = value; }
        }

        public decimal ImportePagado
        {
            get { return TxtImportePagado.Value ?? 0; }
            set { TxtImportePagado.Text = value.ToString(); }
        }

       public decimal? Efectivo
        {
            get { return TxtEfectivo.Value ?? 0; }
            set { TxtEfectivo.Text = value.ToString(); }
        }
      
        #endregion

        #region Metodos

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var orden = Uow.OrdenesPagos.Obtener(o => o.Id == _ordenPagoId);
            orden.ImportePagado -= _ordenPagoDetalle.ImportePagado;
            Uow.OrdenesPagos.Modificar(orden);
            _ordenPagoDetalle.FechaAnulacion = _clock.Now;
            Uow.OrdenesPagosDetalle.Modificar(_ordenPagoDetalle);
            AgregarMovimientos();
            Uow.Commit();
            BtnEliminar.DialogResult = DialogResult.OK;
        }

        private void FrmCrearEditarDetalle_Load(object sender, EventArgs e)
        {
            CargarPago();
        }

        private void CargarPago()
        {
            _ordenPagoDetalle = Uow.OrdenesPagosDetalle.Obtener(o => o.Id == _pagoId);
            this.Efectivo = _ordenPagoDetalle.Efectivo * -1;
            this.ImportePagado = _ordenPagoDetalle.ImportePagado.HasValue ? _ordenPagoDetalle.ImportePagado.Value * -1 : 0;
            this.FechaPago = _ordenPagoDetalle.FechaPago ?? DateTime.Today;
            _ordenPagoDetalle.FechaAnulacion = _clock.Now;
            _esEfectivo = _ordenPagoDetalle.Efectivo.HasValue;
        }

        private void AgregarMovimientos()
        {
            var movimiento = new CajaMovimiento();
            movimiento.Id = Guid.NewGuid();
            movimiento.Importe = _ordenPagoDetalle.ImportePagado;
            movimiento.ComprobanteId = _ordenPagoId;
            movimiento.TipoComprobante = TipoComprobanteEnum.OrdenPago;
            movimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulaciónOrdenPago;
            Caja caja = this.Context.CajaActual;
            movimiento.CajaId = caja.Id;
            if (_esEfectivo)
            {
                movimiento.Efectivo = _ordenPagoDetalle.ImportePagado;
                caja.Egresos -= (float)(_ordenPagoDetalle.ImportePagado ?? 0);
                caja.Saldo += (float)(_ordenPagoDetalle.ImportePagado ?? 0);
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

        #endregion
    }
}
