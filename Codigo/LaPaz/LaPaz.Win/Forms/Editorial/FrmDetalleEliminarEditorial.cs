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
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Senias;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Editorial
{
    public partial class FrmDetalleEliminarEditorial : FormBase
    {
        private readonly int _editorialId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmDetalleEliminarEditorial(ILaPazUow uow, IMessageBoxDisplayService messageBoxDisplayService, int id, ActionFormMode mode, IFormFactory formFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
            _messageBoxDisplayService = messageBoxDisplayService;
            _editorialId = id;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleEditorial;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarEditorial;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        #region Propiedades

        public int Id { get; set; }

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

        private void FrmDetalleEliminarEditorial_Load(object sender, EventArgs e)
        {
            CargarEditorial(_editorialId);
        }

        private void CargarEditorial(int editorialId)
        {
            Entidades.Editorial editorial = Uow.Editoriales.Obtener(e => e.Id == editorialId);

            this.Nombre = editorial.Nombre;
            this.Domicilio = editorial.Domicilio;
            this.Telefono = editorial.TE1;
            this.TelefonoAlternativo = editorial.TE2;
            this.Mail = editorial.Email;
            this.Contacto = editorial.Contacto;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var editorial = Uow.Editoriales.Obtener(ed => ed.Id == _editorialId);

            var titulos = Uow.Titulos.Listado().Where(t => t.EditorialId == _editorialId).ToList();

            if (titulos.Any())
            {
                _messageBoxDisplayService.Show(Resources.ErrorMessageEditorialConTitulos,Resources.LabelEditoriales);
                return;
            }

            editorial.Activo = false;
            Uow.Editoriales.Modificar(editorial);
            Uow.Commit();
        }
        
    }
}
