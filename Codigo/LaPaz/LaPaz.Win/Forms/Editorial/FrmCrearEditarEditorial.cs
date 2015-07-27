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

namespace LaPaz.Win.Forms.Editorial
{
    public partial class FrmCrearEditarEditorial : EditFormBase
    {
        private readonly int _editorialId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Entidades.Editorial _editorial;
        
        private BackgroundWorker bw = new BackgroundWorker();


        public FrmCrearEditarEditorial(IFormFactory formFactory, ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            _editorialId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);
        }

        #region Eventos
        public event EventHandler<Entidades.Editorial> EditorialAgregado;
        #endregion

        #region Propiedades
        
        public int  Id { get; set; }

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
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

        public string TelefonoAlternativo
        {
            get { return txtTelefonoAlt.Text.Trim(); }
            set { txtTelefonoAlt.Text = value; }
        }

        public string Mail
        {
            get { return txtMail.Text; }
            set { txtMail.Text = value; }
        }

        public string Contacto
        {
            get { return TxtContacto.Text; }
            set { TxtContacto.Text = value; }
        }
        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearEditorial;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarEditorial;
                    break;
            }
        }

        private void FrmCrearEditorial_Load(object sender, EventArgs e)
        {
            CargarEditorial(_editorialId);
        }

        private void CargarEditorial(int editorialId)
        {
            if (editorialId == 0)
            {
                _editorial = new Entidades.Editorial();
                return;
                //Default values.
            }
            else
            {
                _editorial = Uow.Editoriales.Obtener(e => e.Id == editorialId);
            }

            this.Nombre = _editorial.Nombre;
            this.Domicilio = _editorial.Domicilio;
            this.Telefono = _editorial.TE1;
            this.TelefonoAlternativo = _editorial.TE2;
            this.Mail = _editorial.Email;
            this.Contacto = _editorial.Contacto;

        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditarEditorial();
        }

        private void CrearEditarEditorial()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var editorial = ObtenerEditorialDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Editoriales.Agregar(editorial);
                }
                else
                {
                    Uow.Editoriales.Modificar(editorial);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnEditorialAgregado(editorial);
                }
            }
        }

        private void OnEditorialAgregado(Entidades.Editorial editorial)
        {
            if (EditorialAgregado != null)
            {
                EditorialAgregado(this, editorial);
            }
        }

        private Entidades.Editorial ObtenerEditorialDesdeForm()
        {
            _editorial.Nombre = Nombre;
            _editorial.Domicilio = Domicilio;
            _editorial.TE1= Telefono;
            _editorial.TE2 = TelefonoAlternativo;
            _editorial.Email = Mail;
            _editorial.Contacto = Contacto;
            _editorial.Activo = true;
            //Fechas.
            _editorial.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _editorial.FechaAlta;
            _editorial.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            _editorial.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? Context.SucursalActual.Id
                                          : _editorial.SucursalAltaId;

            _editorial.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _editorial.SucursalModificacionId;

            _editorial.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? Context.OperadorActual.Id
                                          : _editorial.OperadorAltaId;

            _editorial.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _editorial.OperadorModificacionId;
            
            return _editorial;
       }

        protected override object ObtenerEntidad()
        {
            return ObtenerEditorialDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(txtNombre, "Nombre");
            this.ValidarControl(txtMail, "Email");
         }

        #endregion
    }
}
