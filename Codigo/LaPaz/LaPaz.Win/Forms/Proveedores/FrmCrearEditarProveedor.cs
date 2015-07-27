using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.ProveedoresBancos;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Proveedores
{
    public partial class FrmCrearEditarProveedor : EditFormBase
    {
        private Guid _proveedorId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Proveedor _proveedor;

        public FrmCrearEditarProveedor(IFormFactory formFactory, ILaPazUow uow, IClock clock, Guid id,ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            _proveedorId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();

            InicializarForm(mode);

            this.GridBancos.CellFormatting += this.Grilla_CellFormatting;
        }

        #region Propiedades

        public Proveedor Proveedor
        {
            get { return _proveedor; }
        }

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

        public string EmailPedido
        {
            get { return TxtEmailPedido.Text; }
            set { TxtEmailPedido.Text = value; }
        }

        
        public string Comentarios
        {
            get { return TxtComentarios.Text; }
            set { TxtComentarios.Text = value; }
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
                    this.Text = Resources.LabelCrearProveedor;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarProveedor;
                    break;
            }
        }

        private void FrmCrearEditarProveedor_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarProveedor(_proveedorId);
            radPageView1.SelectedPage = PageGeneral;
            
            if (_formMode == ActionFormMode.Create)
            {
                PageBancos.Enabled = false;
                BtnGuardar.Text = "Continuar";
            }
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

                if (_formMode == ActionFormMode.Create)
                {
                    BtnGuardar.Visible = false;
                    BtnCancelar.Text = "Cerrar";
                    PageGeneral.Enabled = false;
                    PageBancos.Enabled = true;
                    radPageView1.SelectedPage = PageBancos;
                    DialogResult = DialogResult.None;
                    _proveedorId = proveedor.Id;

                    BtnCancelar.DialogResult = DialogResult.OK;
                }
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

            var condicionesCompras = Uow.CondicionesCompra.Listado().OrderBy(d => d.Nombre).ToList();
            condicionesCompras.Insert(0, new CondicionCompra() { Id = 0, Nombre = Resources.ComboBoxOptionSeleccionarCondicionCompra });
            CbxCondicionCompra.DisplayMember = "Nombre";
            CbxCondicionCompra.ValueMember = "Id";
            CbxCondicionCompra.DataSource = condicionesCompras;
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
                //Default values.
            }
            else
            {
                _proveedor = Uow.Proveedores.Obtener(p => p.Id == proveedorId);

                CargarBancos();

            }

            this.Cuenta = _proveedor.Cuenta;
            this.Denominacion = _proveedor.Denominacion;
            this.Domicilio = _proveedor.Domicilio;
            this.Telefono = _proveedor.Telefono;
            this.Celular = _proveedor.Celular;
            this.Contacto = _proveedor.Contacto;
            this.Cuit = _proveedor.Cuit;
            this.ProvinciaId = _proveedor.ProvinciaId;
            this.LocalidadId = _proveedor.LocalidadId;
            this.EmailPedido = _proveedor.EmailPedido;
            this.Comentarios = _proveedor.Comentarios;
            this.CbxTipoDocumento.SelectedValue = _proveedor.TipoDocumento;
            this.TxtPaginaWeb.Text = _proveedor.PaginaWeb;
            this.TxtDescuento.Text = _proveedor.PorcentajeDescuento == null
                                         ? "0"
                                         : _proveedor.PorcentajeDescuento.GetValueOrDefault().ToString("N2");
            this.CbxCondicionCompra.SelectedValue = _proveedor.CondicionCompraId;
        }

        private void CargarBancos()
        {
            var repo = new EFRepository<ProveedorBanco>();
            var bancos = repo.Listado(pb => pb.Banco).Where(pb => pb.ProveedorId == _proveedorId).ToList();
            var list = bancos.Select(AutoMapper.Mapper.Map<ProveedorBancoDto>).ToList();
            GridBancos.DataSource = list;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerProveedorDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtCuenta, "Cuenta");
            this.ValidarControl(TxtDenominacion, "Denominacion");
            this.ValidarControl(TxtDomicilio, "Domicilio");
            this.ValidarControl(TxtTelefono, "Telefono");
            this.ValidarControl(TxtCelular, "Celular");
            this.ValidarControl(TxtContacto, "Contacto");
            this.ValidarControl(TxtCuit, "Cuit");
            this.ValidarControl(CbxProvincia, "ProvinciaId");
            this.ValidarControl(CbxTipoDocumento, "TipoDocumento");
            this.ValidarControl(CbxLocalidad, "LocalidadId");
            this.ValidarControl(TxtEmailPedido, "EmailPedido");
            this.ValidarControl(TxtComentarios, "Comentarios");
            this.ValidarControl(TxtPaginaWeb, "PaginaWeb");
            this.ValidarControl(TxtDescuento, "PorcentajeDescuento");
            this.ValidarControl(CbxCondicionCompra, "CondicionCompraId");
        }

        private Proveedor ObtenerProveedorDesdeForm()
        {
            int cuenta;
            _proveedor.Activo = _proveedorId == default(Guid) || _proveedor.Activo;
            _proveedor.Id = _proveedorId == default(Guid) ? Guid.NewGuid() : _proveedorId;
            _proveedor.Cuenta = int.TryParse(this.TxtCuenta.Text, out cuenta) ? cuenta : (int?)null;
            _proveedor.Denominacion = this.TxtDenominacion.Text;
            _proveedor.Domicilio = this.TxtDomicilio.Text;
            _proveedor.Telefono = this.TxtTelefono.Text;
            _proveedor.Celular = this.TxtCelular.Text;
            _proveedor.Contacto = this.TxtContacto.Text;
            _proveedor.Cuit = this.TxtCuit.Text;
            _proveedor.ProvinciaId = (int?)this.CbxProvincia.SelectedValue;
            _proveedor.LocalidadId = (int?)this.CbxLocalidad.SelectedValue;
            _proveedor.EmailPedido = this.TxtEmailPedido.Text;
            _proveedor.Comentarios = this.TxtComentarios.Text;
            _proveedor.TipoDocumento = (int?) this.CbxTipoDocumento.SelectedValue;

            _proveedor.Gto = false;
            
            //Fechas.
            _proveedor.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _proveedor.FechaAlta;
            _proveedor.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            //Propiedades no editables
            _proveedor.CondicionCompraId = _proveedor.CondicionCompraId;


            _proveedor.PorcentajeDescuento =  string.IsNullOrEmpty(this.TxtDescuento.Text)? 0: decimal.Parse(TxtDescuento.Text);
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

            _proveedor.CondicionCompraId = (int?)CbxCondicionCompra.SelectedValue;
            _proveedor.PaginaWeb = TxtPaginaWeb.Text;
            _proveedor.PorcentajeDescuento = string.IsNullOrEmpty(TxtDescuento.Text) ? (decimal?) null : Convert.ToDecimal(TxtDescuento.Text);

            return _proveedor;
        }

        #endregion

        private void GridBancos_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridBancos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var proveedorBanco = selectedRow.DataBoundItem as ProveedorBancoDto;

            if (proveedorBanco == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    DetalleBanco(proveedorBanco.Id);
                    break;
                case "ColumnaEditar":
                    EditarBanco(proveedorBanco.Id);
                    break;
                case "ColumnaEliminar":
                    EliminarBanco(proveedorBanco.Id);
                    break;
            }
        }

        private void DetalleBanco(Guid proveedorBancoId)
        {
            using (var formDetalle = FormFactory.Create<FrmDetalleEliminarProveedorBanco>(proveedorBancoId,
                    ActionFormMode.Detail))
            {
                var result = formDetalle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formDetalle.Close();
                    CargarBancos();
                }
            }
        }

        private void EditarBanco(Guid proveedorBancoId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarProveedorBanco>(proveedorBancoId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    CargarBancos();
                }
            }
        }

        private void EliminarBanco(Guid proveedorBancoId)
        {
            using (var formEliminar = FormFactory.Create<FrmDetalleEliminarProveedorBanco>(proveedorBancoId,
                    ActionFormMode.Delete))
            {
                var result = formEliminar.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formEliminar.Close();
                    CargarBancos();
                }
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CrearProveedorBanco();
        }

        private void CrearProveedorBanco()
        {
            using (var frm = new FrmCrearEditarProveedorBanco(Uow, _clock, _proveedorId, ActionFormMode.Create))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarBancos();
                }
            } 
        }
    }
}
