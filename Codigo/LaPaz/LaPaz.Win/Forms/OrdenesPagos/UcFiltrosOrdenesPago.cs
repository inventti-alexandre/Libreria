using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Properties;
using LaPaz.Entidades.Enums;
namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class UcFiltrosOrdenesPago : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosOrdenesPago()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        #endregion

        #region Propiedades

        public string Concepto
        {
            get { return TxtConcepto.Text; }
            set { TxtConcepto.Text = value; }
        }

        public string NroComprobante
        {
            get { return TxtNroComprobante.Text; }
            set { TxtNroComprobante.Text = value; }
        }

        public Guid? ProveedorId
        {
            get { return CbxProveedor.ProveedorId; }
        }

        public int? SucursalId
        {
            get { return CbxSucursalGasto.SucursalId; }
        }

        public int? CentroGastoId
        {
            get { return CbxCentroCosto.CentrosCostoId; }
        }

        public int? TipoGastoId
        {
            get { return CbxTipoGasto.TipoGastoId; }
        }

        public TipoComprobanteEnum? TipoComprobanteId
        {
            get { return CbxTipoComprobante.TipoComprobanteId() ?? (TipoComprobanteEnum?)null; }
        }

        public bool Pendiente
        {
            get { return ckbPendientes.Checked; }
        }

        #endregion

        #region Metodos

        private void UcFiltrosOrdenesPago_Load(object sender, EventArgs e)
        {
            //Fix para diseñador.
            if (Uow == null) return;

            CbxSucursalGasto.SucursalId = Context.SucursalActual.Id;
            
            CbxCentroCosto.SeleccionarFinished += OnFiltered;
            CbxSucursalGasto.SeleccionarFinished += OnFiltered;
            CbxTipoComprobante.SeleccionarFinished += OnFiltered;
            CbxTipoGasto.SeleccionarFinished += OnFiltered;
            CbxProveedor.SeleccionarFinished += OnFiltered;

            CbxCentroCosto.CargarCentroCosto();
            CbxTipoGasto.CargarTiposGasto();
            CbxSucursalGasto.CargarSucursal();
            CbxProveedor.CargarProveedores(true);
            CbxTipoComprobante.CargarTiposComprobantes();
        }

        private void TxtConcepto_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered(sender, e);
        }

        private void TxtNroComprobante_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered(sender, e);
        }

        private void OnFiltered(object sender, object eventArgs)
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;

            TxtConcepto.Text = string.Empty;
            TxtNroComprobante.Text = string.Empty;
            CbxCentroCosto.Reset();
            CbxProveedor.Reset();
            CbxTipoGasto.Reset();
            CbxSucursalGasto.Reset();
            CbxTipoComprobante.Reset();
            ckbPendientes.Checked = false;

            _limpiandoFiltros = false;

            OnFiltered(sender, e);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered(sender, e);
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                Uow.Dispose();
            }
            base.Dispose(disposing);
        }

        private void ckbPendientes_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }
        #endregion


    }
}
