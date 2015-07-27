using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.ProveedoresGastos
{
    public partial class FrmCrearEditarProveedorGasto : EditFormBase
    {
        private Guid _proveedorId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Proveedor _proveedor;

        public FrmCrearEditarProveedorGasto(IFormFactory formFactory, ILaPazUow uow, IClock clock, Guid id, ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            _proveedorId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();

            InicializarForm(mode);
        }

        #region Propiedades

        public Proveedor Proveedor
        {
            get { return _proveedor; }
        }

        public string Denominacion
        {
            get { return TxtDenominacion.Text; }
            set { TxtDenominacion.Text = value; }
        }

        public string Domicilio
        {
            get { return TxtDomicilio.Text; }
            set { TxtDomicilio.Text = value; }
        }

        public string Telefono
        {
            get { return TxtTelefono.Text; }
            set { TxtTelefono.Text = value; }
        }

        public string Celular
        {
            get { return TxtCelular.Text; }
            set { TxtCelular.Text = value; }
        }

        public string Contacto
        {
            get { return TxtContacto.Text; }
            set { TxtContacto.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        public int? ProvinciaId
        {
            get { return (int?) CbxProvincia.SelectedValue; }
            set { CbxProvincia.SelectedValue = value ?? 0; }
        }

        public int? LocalidadId
        {
            get { return (int?)CbxLocalidad.SelectedValue; }
            set { CbxLocalidad.SelectedValue = value ?? 0; }
        }

        public DateTime FechaAlta { get; set; }

        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearProveedorGasto;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarProveedorGasto;
                    break;
            }
        }

        private void FrmCrearEditarProveedorGasto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarProveedor(_proveedorId);
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
                var proveedor = ObtenerProveedorDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Proveedores.Agregar(proveedor);
                }
                else
                {
                    Uow.Proveedores.Modificar(proveedor);
                }
                
                Uow.Commit();
            }
        }

        private void CbxProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarLocalidades();
        }

        private void CargarCombos()
        {
            var provincias = Uow.Provincias.Listado().OrderBy(p => p.Nombre).ToList();
            provincias.Insert(0, new Provincia() { Id = 0, Nombre = Resources.ComboBoxOptionSeleccionarProvincia });

            CbxProvincia.DisplayMember = "Nombre";
            CbxProvincia.ValueMember = "Id";
            CbxProvincia.DataSource = provincias;

            var tiposDocumento =  Uow.TiposDocumentosIdentidad.Listado().OrderBy(d => d.Nombre).ToList();
            tiposDocumento.Insert(0, new TiposDocumentosIdentidad() { Id = 0, Nombre = "" });
            CbxTipoDocumento.DisplayMember = "Nombre";
            CbxTipoDocumento.ValueMember = "Id";
            CbxTipoDocumento.DataSource = tiposDocumento;
        }

        private void CargarLocalidades()
        {
            var localidades = Uow.Localidades.Listado().Where(l => l.ProvinciaId == this.ProvinciaId).ToList();
            localidades.Insert(0, new Localidad() { Id = 0, Nombre = Resources.ComboBoxOptionSeleccinarLocalidad });

            CbxLocalidad.DisplayMember = "Nombre";
            CbxLocalidad.ValueMember = "Id";
            this.CbxLocalidad.DataSource = localidades;
        }

        private void CargarProveedor(Guid proveedorId)
        {
            if (proveedorId == default(Guid))
            {
                _proveedor = new Proveedor();
            }
            else
            {
                _proveedor = Uow.Proveedores.Obtener(p => p.Id == proveedorId);
            }

            this.Denominacion = _proveedor.Denominacion;
            this.Domicilio = _proveedor.Domicilio;
            this.Telefono = _proveedor.Telefono;
            this.Celular = _proveedor.Celular;
            this.Contacto = _proveedor.Contacto;
            this.Cuit = _proveedor.Cuit;
            this.ProvinciaId = _proveedor.ProvinciaId;
            this.LocalidadId = _proveedor.LocalidadId;
            this.CbxTipoDocumento.SelectedValue = _proveedor.TipoDocumento;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerProveedorDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtDenominacion, "Denominacion");
            this.ValidarControl(TxtDomicilio, "Domicilio");
            this.ValidarControl(TxtTelefono, "Telefono");
            this.ValidarControl(TxtCelular, "Celular");
            this.ValidarControl(TxtContacto, "Contacto");
            this.ValidarControl(TxtCuit, "Cuit");
            this.ValidarControl(CbxProvincia, "ProvinciaId");
            this.ValidarControl(CbxTipoDocumento, "TipoDocumento");
            this.ValidarControl(CbxLocalidad, "LocalidadId");
        }

        private Proveedor ObtenerProveedorDesdeForm()
        {
            _proveedor.Activo = _proveedorId == default(Guid) || _proveedor.Activo;
            _proveedor.Id = _proveedorId == default(Guid) ? Guid.NewGuid() : _proveedorId;
            _proveedor.Denominacion = this.TxtDenominacion.Text;
            _proveedor.Domicilio = this.TxtDomicilio.Text;
            _proveedor.Telefono = this.TxtTelefono.Text;
            _proveedor.Celular = this.TxtCelular.Text;
            _proveedor.Contacto = this.TxtContacto.Text;
            _proveedor.Cuit = this.TxtCuit.Text;
            _proveedor.ProvinciaId = (int?)this.CbxProvincia.SelectedValue;
            _proveedor.LocalidadId = (int?)this.CbxLocalidad.SelectedValue;
            _proveedor.TipoDocumento = (int?) this.CbxTipoDocumento.SelectedValue;
            _proveedor.EmailPedido = _proveedor.EmailPedido == string.Empty ? null : _proveedor.EmailPedido;

            _proveedor.Gto = true;
            
            //Fechas.
            _proveedor.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _proveedor.FechaAlta;
            _proveedor.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            //Propiedades no editables
            _proveedor.CondicionCompraId = _proveedor.CondicionCompraId;
            _proveedor.PorcentajeDescuento = _proveedor.PorcentajeDescuento;
            _proveedor.Password = _proveedor.Password;
            _proveedor.ProveerdorBcoId = _proveedor.ProveerdorBcoId;
            _proveedor.CBU = _proveedor.CBU;
            _proveedor.GrupoProveedorId = 1;// _proveedor.GrupoProveedorId;
            _proveedor.PaginaWeb = _proveedor.PaginaWeb;

            _proveedor.SucursalAltaId = _formMode == ActionFormMode.Create
                ? this.Context.SucursalActual.Id
                : _proveedor.SucursalAltaId;

            _proveedor.SucursalModificacionId = _formMode == ActionFormMode.Create
                ? (int?)null
                : this.Context.SucursalActual.Id;

            _proveedor.OperadorAltaId = _formMode == ActionFormMode.Create
                ? this.Context.OperadorActual.Id
                : _proveedor.OperadorAltaId;

            _proveedor.OperadorModificacionId = _formMode == ActionFormMode.Create
                ? (Guid?)null
                : this.Context.OperadorActual.Id;

            return _proveedor;
        }

        #endregion
    }
}
