using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Proveedores
{
    public partial class UcFiltrosProveedores : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosProveedores()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        private TipoProveedor _tipoProveedor;

        #endregion

        #region Propiedades

        public int? Cuenta
        {
            get
            {
                int cuenta;
                return int.TryParse(TxtCuenta.Text, out cuenta) ? cuenta : (int?)null;
            }
            set
            {
                TxtCuenta.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public string Denominacion
        {
            get { return TxtDenominacion.Text; }
            set { TxtDenominacion.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        public int? ProvinciaId
        {
            get { return (int?)(CbxProvincia.SelectedIndex != 0 ? CbxProvincia.SelectedValue : null); }
            set { CbxProvincia.SelectedValue = value ?? 0; }
        }

        public int? LocalidadId
        {
            get { return (int?)(CbxLocalidad.SelectedIndex != 0 ? CbxLocalidad.SelectedValue : null); }
            set { CbxLocalidad.SelectedValue = value ?? 0; }
        }

        public TipoProveedor TipoProveedor
        {
            get { return _tipoProveedor; }
            set
            {
                if (value != TipoProveedor.Gastos)
                {
                    TxtCuenta.Show();
                    LbCuenta.Show();
                }
                else
                {
                    TxtCuenta.Hide();
                    LbCuenta.Hide();

                    CbxProvincia.Location = TxtCuit.Location;
                    LbProvincia.Location = LbCuit.Location;

                    TxtCuit.Location = TxtCuenta.Location;
                    LbCuit.Location = LbCuenta.Location;
                }
                
                _tipoProveedor = value;
            }
        }

        #endregion

        #region Metodos

        private void UcFiltrosProveedores_Load(object sender, EventArgs e)
        {
            //Fix para diseñador.
            if (Uow == null) return;

            CargarProvincias();
        }

        private void CargarProvincias()
        {
            var provincias = Uow.Provincias.Listado().OrderBy(p => p.Nombre).ToList();
            provincias.Insert(0, new Provincia() { Id = 0, Nombre = Resources.ComboBoxOptionSeleccionarProvincia });

            CbxProvincia.DisplayMember = "Nombre";
            CbxProvincia.ValueMember = "Id";
            CbxProvincia.DataSource = provincias;
        }

        private void CargarLocalidades()
        {
            var localidades = Uow.Localidades.Listado().Where(l => l.ProvinciaId == this.ProvinciaId).ToList();
            localidades.Insert(0, new Localidad() { Id = 0, Nombre = Resources.ComboBoxOptionSeleccinarLocalidad });

            CbxLocalidad.DisplayMember = "Nombre";
            CbxLocalidad.ValueMember = "Id";
            this.CbxLocalidad.DataSource = localidades;
        }

        private void CbxProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarLocalidades();

            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void TxtCuenta_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void TxtCuit_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void TxtDenominacion_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void CbxLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;

            TxtCuenta.Text = string.Empty;
            TxtCuit.Text = string.Empty;
            TxtDenominacion.Text = string.Empty;
            CbxProvincia.SelectedIndex = 0;
            CbxLocalidad.SelectedIndex = 0;

            _limpiandoFiltros = false;

            OnFiltered();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
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
