using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Clientes
{
    public partial class FrmCrearEditarCliente : EditFormBase
    {
        private readonly Guid _clienteId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Cliente _cliente;

        private BackgroundWorker bw = new BackgroundWorker();


        public FrmCrearEditarCliente(ILaPazUow uow, IClock clock, Guid id, ActionFormMode mode)
        {
            Uow = uow;

            _clienteId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);
        }

        #region Eventos
        public event EventHandler<Cliente> ClienteAgregado;
        #endregion

        #region Propiedades

        public Guid Id { get; set; }

        public string ApellidoNombre
        {
            get { return txtApellidoNombre.Text; }
            set { txtApellidoNombre.Text = value; }
        }

        public string Cuit
        {
            get { return txtDni.Text; }
            set { txtDni.Text = value; }
        }

        public string Domicilio
        {
            get { return txtDomicilio.Text; }
            set { txtDomicilio.Text = value; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public string Celular
        {
            get { return txtCelular.Text.Trim(); }
            set { txtCelular.Text = value; }
        }

        public string Mail
        {
            get { return txtMail.Text; }
            set { txtMail.Text = value; }
        }

        public bool? Llamar
        {
            get { return ckbLlamar.Checked; }
            set { ckbLlamar.Checked = value ?? false; }
        }

        public bool? MandarMail
        {
            get { return ckbMail.Checked; }
            set { ckbMail.Checked = value ?? false; }
        }

        public int? ProvinciaId
        {
            get { return (int?)cbxProvincia.SelectedValue; }
            set { cbxProvincia.SelectedValue = value ?? 0; }
        }

        public int? LocalidadId
        {
            get { return (int?)cbxLocalidad.SelectedValue; }
            set { cbxLocalidad.SelectedValue = value ?? 0; }
        }

        public int? TipoDocumentoId
        {
            get { return (int?)cbxTipoDocumento.SelectedValue; }
            set { cbxTipoDocumento.SelectedValue = value ?? 0; }
        }

        public int? EspecialidadId
        {
            get { return (int?)cbxEspecialidad.SelectedValue; }
            set { cbxEspecialidad.SelectedValue = value ?? 0; }
        }

        public int? ProfesionId
        {
            get { return (int?)cbxProfesion.SelectedValue; }
            set { cbxProfesion.SelectedValue = value ?? 0; }
        }

        public CondicionVentaEnum? CondicionVentaId
        {
            get { return (CondicionVentaEnum)cbxCondicionVenta.SelectedValue; }
            set { cbxCondicionVenta.SelectedValue = value ?? 0; }
        }

        public EstadoCliente? EstadoClienteId
        {
            get { return (EstadoCliente)cbxTipo.SelectedValue; }
            set { cbxTipo.SelectedValue = value ?? 0; }
        }

        public string Comentarios
        {
            get { return TxtComentarios.Text; }
            set { TxtComentarios.Text = value; }
        }

        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearCliente;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarCliente;
                    break;
            }
        }

        private void FrmCrearCliente_Load(object sender, EventArgs e)
        {
            DefinirCombos();
            CargarCombos();
            CargarCliente(_clienteId);
        }

        private void CargarCliente(Guid clienteId)
        {
            if (clienteId == default(Guid))
            {
                _cliente = new Cliente();
                return;
                //Default values.
            }
            else
            {
                _cliente = Uow.Clientes.Obtener(c => c.Id == clienteId);
            }

            this.ApellidoNombre = _cliente.Denominacion;
            this.Domicilio = _cliente.Domicilio;
            this.Telefono = _cliente.Telefono;
            this.Celular = _cliente.Celular;
            this.Mail = _cliente.Mail;
            this.ProvinciaId = _cliente.ProvinciaId;
            this.LocalidadId = _cliente.LocalidadId;
            this.ProfesionId = _cliente.ProfesionId;
            this.EspecialidadId = _cliente.EspecialidadId;
            this.TipoDocumentoId = _cliente.TipoDocumentoId;
            this.Cuit = _cliente.Cuit;
            this.EstadoClienteId = (EstadoCliente?)_cliente.EstadoClienteId ?? EstadoCliente.Activo;
            this.CondicionVentaId = _cliente.CondicionVentaId;
            this.MandarMail = _cliente.MandarMail;
            this.Llamar = _cliente.Llamar;
            this.Comentarios = _cliente.Comentarios;
        }

        private void DefinirCombos()
        {
            //Provincia
            cbxProvincia.DisplayMember = "Nombre";
            cbxProvincia.ValueMember = "Id";

            //Profesion
            cbxProfesion.DisplayMember = "Nombre";
            cbxProfesion.ValueMember = "Id";

            //Condiciones Venta
            cbxCondicionVenta.DisplayMember = "Nombre";
            cbxCondicionVenta.ValueMember = "Id";

            cbxTipo.DisplayMember = "Nombre";
            cbxTipo.ValueMember = "Id";

            cbxTipoDocumento.DisplayMember = "Nombre";
            cbxTipoDocumento.ValueMember = "Id";

            cbxLocalidad.DisplayMember = "Nombre";
            cbxLocalidad.ValueMember = "Id";

        }

        private void CargarCombos()
        {

            var provincias = Uow.Provincias.Listado().OrderBy(p => p.Nombre).ToList();
            //provincias.Insert(0, new Provincia() { Id = 0, Nombre = "SELECCIONE PROVINCIA" });
            cbxProvincia.DataSource = provincias;
           
            

            var profesiones = Uow.Profesiones.Listado().OrderBy(p => p.Nombre).ToList();
            profesiones.Insert(0, new Profesion() { Id = 0, Nombre = "SELECCIONE PROFESION" });

            cbxProfesion.DataSource = profesiones;

            var condicionesVenta = Uow.CondicionesVenta.Listado().Where(c => c.Id == CondicionVentaEnum.CuentaCorriente || c.Id == CondicionVentaEnum.Contado).ToList();
            condicionesVenta.Insert(0, new CondicionesVenta() { Id = 0, Nombre = "SELECCIONE CONDICION" });
            cbxCondicionVenta.DataSource = condicionesVenta;

            var estadosClientes =
                Uow.EstadosClientes.Listado()
                    .Where(e => e.Id == EstadoCliente.Activo || e.Id == EstadoCliente.Afectado || e.Id == EstadoCliente.Atrasado || e.Id == EstadoCliente.EstudioJuridico)
                    .OrderBy(e => e.Nombre).ToList();
            estadosClientes.Insert(0, new EstadosCliente() { Id = 0, Nombre = "SELECCIONE ESTADO" });
            cbxTipo.DataSource = estadosClientes;

            var tiposDocumentos = Uow.TiposDocumentosIdentidad.Listado().ToList();
            //  tiposDocumentos.Insert(0, new TiposDocumentosIdentidad(){ Id = 0, Nombre = "SELECCIONE" });
            cbxTipoDocumento.DataSource = tiposDocumentos;
            cbxTipoDocumento.SelectedValue = 2;

            ProvinciaId = 3;
            CondicionVentaId = CondicionVentaEnum.Contado;
            EstadoClienteId= EstadoCliente.Activo;
            // 
        }

        private void CargarLocalidad(int? provinciaId)
        {
            var localidades = Uow.Localidades.Listado().Where(l => l.ProvinciaId == provinciaId).ToList();
            //localidades.Insert(0, new Localidad() { Id = 0, Nombre = "SELECCIONE LOCALIDAD" });

            cbxLocalidad.DataSource = localidades;
        }

        private void CargarEspecialidad(int? profesionId)
        {
            var especialidades = Uow.Especialidades.Listado().Where(e => e.ProfesionId == profesionId).ToList();
            especialidades.Insert(0, new Especialidad() { Id = 0, Nombre = "SELECCIONE ESPECIALIDAD" });
            cbxEspecialidad.DisplayMember = "Nombre";
            cbxEspecialidad.ValueMember = "Id";
            cbxEspecialidad.DataSource = especialidades;
        }

       private void cbxProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarLocalidad((int?)cbxProvincia.SelectedValue);
        }

        private void cbxProfesion_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarEspecialidad((int?)cbxProfesion.SelectedValue);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditarCliente();
        }

        private void CrearEditarCliente()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var cliente = ObtenerClienteDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Clientes.Agregar(cliente);
                }
                else
                {
                    Uow.Clientes.Modificar(cliente);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnClienteAgregado(cliente);
                }
            }
        }

        private void OnClienteAgregado(Cliente cliente)
        {
            if (ClienteAgregado != null)
            {
                ClienteAgregado(this, cliente);
            }
        }

        private Cliente ObtenerClienteDesdeForm()
        {
            _cliente.Id = _clienteId == default(Guid) ? Guid.NewGuid() : _clienteId;
            _cliente.Denominacion = ApellidoNombre;
            _cliente.Domicilio = Domicilio;
            _cliente.Telefono = Telefono;
            _cliente.Celular = Celular;
            _cliente.Mail = Mail;
            _cliente.ProvinciaId = ProvinciaId;
            _cliente.LocalidadId = LocalidadId;
            _cliente.ProfesionId = ProfesionId;
            _cliente.EspecialidadId = EspecialidadId;
            _cliente.TipoDocumentoId = TipoDocumentoId;
            _cliente.Cuit = Cuit.PadLeft(11,'0');
            _cliente.EstadoClienteId =  (EstadoCliente)EstadoClienteId;
            _cliente.CondicionVentaId = CondicionVentaId;
            _cliente.MandarMail = MandarMail;
            _cliente.Llamar = Llamar;
            _cliente.Comentarios = Comentarios;
            //Fechas.
            _cliente.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _cliente.FechaAlta;
            _cliente.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            _cliente.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? Context.SucursalActual.Id
                                          : _cliente.SucursalAltaId;

            _cliente.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _cliente.SucursalModificacionId;

            _cliente.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? Context.OperadorActual.Id
                                          : _cliente.OperadorAltaId;

            _cliente.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _cliente.OperadorModificacionId;
            _cliente.Activo = true;

            return _cliente;
       }

        protected override object ObtenerEntidad()
        {
            return ObtenerClienteDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(txtApellidoNombre, "Denominacion");
            this.ValidarControl(txtDni, "Cuit");
            this.ValidarControl(txtDomicilio, "Domicilio");
            this.ValidarControl(txtCelular, "Celular");
            this.ValidarControl(txtMail, "Mail");
            this.ValidarControl(cbxCondicionVenta, "CondicionVentaId");
         }

        public void SetearDni(string dni)
        {
            Cuit = dni;
        }


        #endregion

        private void txtDni_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
