using System;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Win.Enums;

namespace LaPaz.Win.Forms.Operadores
{
    public partial class FrmDetalleOperador : FormBase
    {
        public FrmDetalleOperador()
        {
            InitializeComponent();
        }

        #region Propiedades

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

        #endregion

        private void FrmDetalleOperador_Load(object sender, EventArgs e)
        {
            CargarOperador();
        }

        private void CargarOperador()
        {
            var operador = Context.OperadorActual;

            if (operador.Personal != null)
            {
                this.ApellidoNombre = operador.Personal.Nombre;
                this.Domicilio = operador.Personal.Domicilio;
                this.Telefono = operador.Personal.Telefono;
                this.Celular = operador.Personal.Celular;
                this.Provincia = operador.Personal.Provincia != null ? operador.Personal.Provincia.Nombre : string.Empty;
                this.Localidad = operador.Personal.Localidad != null ? operador.Personal.Localidad.Nombre : string.Empty;
                this.Cuit = operador.Personal.Cuit;
            }
        }
    }
}
