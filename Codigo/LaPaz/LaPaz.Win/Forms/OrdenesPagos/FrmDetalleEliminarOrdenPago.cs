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
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.ProveedoresBancos;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using LaPaz.Negocio.Interfaces;

namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class FrmDetalleEliminarOrdenPago : FormBase
    {
        private Guid _ordenId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private List<OrdenesPagoDetalle> _ordenesPagoDetalles;
        private OrdenesPago _ordenPago;
        private IOrdenPagoService _ordenPagoService;
        private ICajaNegocio _cajaNegocio;

        public FrmDetalleEliminarOrdenPago(IFormFactory formFactory, ILaPazUow uow, IClock clock, Guid id, ActionFormMode mode, IMessageBoxDisplayService messageBoxDisplayService, ICajaNegocio cajaNegocio)
        {
            Uow = uow;
            FormFactory = formFactory;
            _ordenId = id;
            _clock = clock;
            _formMode = mode;
            _messageBoxDisplayService = messageBoxDisplayService;
            _cajaNegocio = cajaNegocio;

            _ordenPagoService = new OrdenPagoService(uow, this.Context, clock, cajaNegocio);

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleOrdenDePago;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarOrdenDePago;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        private void FrmCrearEditarOrdenPago_Load(object sender, EventArgs e)
        {
            CargarOrdenPago();
            _ordenesPagoDetalles = new List<OrdenesPagoDetalle>();
        }

        #region Propiedades

        public string Concepto
        {
            get { return TxtConcepto.Text; }
            set { TxtConcepto.Text = value; }
        }

        public string Fecha
        {
            get { return TxtFecha.Text; }
            set { TxtFecha.Text = value; }
        }

        public string FechaImputacion
        {
            get { return TxtFechaImputacion.Text; }
            set { TxtFechaImputacion.Text = value; }
        }

        public string SucursalId
        {
            get { return TxtSucursalGasto.Text; }
            set { TxtSucursalGasto.Text = value; }
        }

        public string ProveedorId
        {
            get { return TxtProveedor.Text; }
            set { TxtProveedor.Text = value; }
        }

        public string CentroCostoId
        {
            get { return TxtCentroCosto.Text; }
            set { TxtCentroCosto.Text = value; }
        }

        public string TipoComprobanteId
        {
            get { return TxtTipoComprobante.Text; }
            set { TxtTipoComprobante.Text = value; }
        }

        public string LetraComprobante
        {
            get { return TxtLetraComprobante.Text; }
            set { TxtLetraComprobante.Text = value; }
        }

        public string NroComprobante
        {
            get { return TxtNroComprobante2.Text; }
            set { TxtNroComprobante2.Text = value; }
        }

        public string TipoGastoId
        {
            get { return TxtTipoGasto.Text; }
            set { TxtTipoGasto.Text = value; }
        }

        public string SucursalGastoId
        {
            get { return TxtSucursalGasto.Text; }
            set { TxtSucursalGasto.Text = value; }
        }

        public string ImporteDebe
        {
            get { return TxtImporteDebe.Text; }
            set { TxtImporteDebe.Text = value; }
        }

        public string Importe
        {
            get { return TxtSubTotal.Text; }
            set { TxtSubTotal.Text = value; }
        }

        public string Recargo
        {
            get { return TxtRecargo.Text; }
            set { TxtRecargo.Text = value; }
        }

        public string SubTotal
        {
            get { return TxtImporte.Text; }
            set { TxtImporte.Text = value; }
        }

        public bool RegistraIVA
        {
            get { return ckdRegistraIVA.Checked; }
            set { ckdRegistraIVA.Checked = value; }
        }

        #endregion

        private void CargarOrdenPago()
        {
            _ordenPago = Uow.OrdenesPagos.Obtener(o => o.Id == _ordenId, o => o.Sucursal, o => o.SucursalGasto,
                                                  o => o.Proveedor, o => o.TiposComprobante, o => o.TiposGasto,
                                                  o => o.CentrosCosto, o => o.OrdenesPagoDetalles);

            var now = _clock.Now;

            this.Importe = _ordenPago.Importe.ToString("N2");
            this.ImporteDebe = (_ordenPago.Importe - _ordenPago.ImportePagado ?? 0).ToString("N2");
            this.Recargo = (_ordenPago.Recargo ?? 0).ToString("N2");
            this.SubTotal = _ordenPago.SubTotal.ToString("N2");
            this.Concepto = _ordenPago.Concepto;
            this.Fecha = _ordenPago.Fecha == DateTime.MinValue ? now.ToShortDateString() : _ordenPago.Fecha.ToShortDateString();
            this.FechaImputacion = _ordenPago.FechaImputacion != null
                                       ? _ordenPago.FechaImputacion.Value.ToShortDateString()
                                       : _clock.Now.ToShortDateString();
            this.SucursalId = _ordenPago.Sucursal.Nombre;
            this.SucursalGastoId = _ordenPago.SucursalGasto.Nombre;
            this.ProveedorId = _ordenPago.Proveedor.Denominacion;
            this.NroComprobante = _ordenPago.NumeroComprobante;
            this.LetraComprobante = _ordenPago.LetraComprobante;
            this.TipoComprobanteId = _ordenPago.TiposComprobante.Nombre;
            this.TipoGastoId = _ordenPago.TiposGasto.Nombre;
            this.CentroCostoId = _ordenPago.CentrosCosto.Nombre;
            this.RegistraIVA = _ordenPago.RegistraIVACompra ?? false;

            GridPagos.DataSource = _ordenPago.OrdenesPagoDetalles.Select(d => _ordenPagoService.ObtenerFormaPago(_ordenPago, d));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _ordenPagoService.EliminarOrdenPago(_ordenId);
        }
    }
}

