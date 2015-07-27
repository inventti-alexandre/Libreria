using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Properties;
using LaPaz.Entidades.Enums;
namespace LaPaz.Win.Forms.Cuentas
{
    public partial class UcFiltrosCuentas : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosCuentas()
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

        public string Nombre
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; }
        }

        public string Titular
        {
            get { return TxtTitular.Text; }
            set { TxtTitular.Text = value; }
        }

        public int? BancoPropioId
        {
            get { return CbxBancoPropio.Id; }
        }

        public int? TipoCuentaId
        {
            get { return CbxTipoCuenta.TipoCuentaId; }
        }
        #endregion

        #region Metodos

        private void UcFiltrosOrdenesPago_Load(object sender, EventArgs e)
        {
            //Fix para diseñador.
            if (Uow == null) return;

            CbxBancoPropio.SeleccionarFinished += OnFiltered;
            CbxTipoCuenta.SeleccionarFinished += OnFiltered;

            CbxBancoPropio.CargarBancosPropios();
            CbxTipoCuenta.CargarTiposCuentas();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered(sender, e);
        }

        private void TxtTitular_TextChanged(object sender, EventArgs e)
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

            TxtNombre.Text = string.Empty;
            TxtTitular.Text = string.Empty;
            CbxBancoPropio.Reset();
            CbxTipoCuenta.Reset();

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
       
        #endregion
    }
}
