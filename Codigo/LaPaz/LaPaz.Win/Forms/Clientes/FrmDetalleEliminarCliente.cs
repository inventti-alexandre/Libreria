using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Senias;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Clientes
{
    public partial class FrmDetalleEliminarCliente : FormBase
    {
        private readonly Guid _clienteId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IClienteNegocio _clienteNegocio;

        public FrmDetalleEliminarCliente(ILaPazUow uow,
                                         IClienteNegocio clienteNegocio,
                                         IMessageBoxDisplayService messageBoxDisplayService,
                                         Guid id, ActionFormMode mode, IFormFactory formFactory)
        {
            FormFactory = formFactory;
            Uow = uow;

            _messageBoxDisplayService = messageBoxDisplayService;
            _clienteId = id;
            _clienteNegocio = clienteNegocio;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleCliente;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarCliente;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

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
            get { return txtCelular.Text; }
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

        public string Provincia
        {
            get { return txtProvincia.Text; }
            set { txtProvincia.Text = value; }
        }

        public string Localidad
        {
            get { return txtLocalidad.Text; }
            set { txtLocalidad.Text = value; }
        }

        public string TipoDocumento
        {
            get { return txtTipoDni.Text; }
            set { txtTipoDni.Text = value; }
        }

        public string Especialidad
        {
            get { return txtEspecialidad.Text; }
            set { txtEspecialidad.Text = value; }
        }

        public string Profesion
        {
            get { return txtProfesion.Text; }
            set { txtProfesion.Text = value; }
        }

        public string CondicionVentaId
        {
            get { return txtCondicion.Text; }
            set { txtCondicion.Text = value; }
        }

        public string EstadoCliente
        {
            get { return txtCondicion.Text; }
            set { txtCondicion.Text = value; }
        }
        #endregion

        private void FrmDetalleEliminarCliente_Load(object sender, EventArgs e)
        {
            CargarCliente(_clienteId);
        }

        private void CargarCliente(Guid clienteId)
        {
            Cliente cliente = Uow.Clientes.Obtener(c => c.Id == clienteId, c => c.Provincia,
                                                    c => c.Localidad, c => c.Profesion, c => c.Especialidad,
                                                    c => c.CondicionesVenta, c => c.EstadosCliente,
                                                    c => c.TiposDocumentosIdentidad);

            this.ApellidoNombre = cliente.Denominacion;
            this.Domicilio = cliente.Domicilio;
            this.Telefono = cliente.Telefono;
            this.Celular = cliente.Celular;
            this.Mail = cliente.Mail;
            this.Provincia = cliente.Provincia != null ? cliente.Provincia.Nombre : string.Empty;
            this.Localidad = cliente.Localidad != null ? cliente.Localidad.Nombre : string.Empty;
            this.Profesion = cliente.Profesion != null ? cliente.Profesion.Nombre : string.Empty;
            this.Especialidad = cliente.Especialidad != null ? cliente.Especialidad.Nombre : string.Empty;
            this.TipoDocumento = cliente.TiposDocumentosIdentidad != null ? cliente.TiposDocumentosIdentidad.Nombre : string.Empty;
            this.Cuit = cliente.Cuit;
            this.EstadoCliente = cliente.EstadosCliente != null ? cliente.EstadosCliente.Nombre : string.Empty;
            this.CondicionVentaId = cliente.CondicionesVenta != null ? cliente.CondicionesVenta.Nombre : string.Empty;
            this.MandarMail = cliente.MandarMail;
            this.Llamar = cliente.Llamar;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var tieneDeuda = _clienteNegocio.DeudaTotal(_clienteId, null) > 0;

            if (tieneDeuda)
            {
                _messageBoxDisplayService.Show(Resources.ErrorMessageClienteConDeuda, Resources.LabelClientes);
                return;
            }

            var cliente = Uow.Clientes.Obtener(p => p.Id == _clienteId);

            cliente.Activo = false;

            Uow.Clientes.Modificar(cliente);

            Uow.Commit();
        }

        private void btnSenas_Click(object sender, EventArgs e)
        {
            using (var pantalla = FormFactory.Create<FrmCrearSenia>(_clienteId, ActionFormMode.Create))
            {
                pantalla.FormBorderStyle = FormBorderStyle.FixedSingle;
                pantalla.ShowDialog();
            }
        }
    }
}
