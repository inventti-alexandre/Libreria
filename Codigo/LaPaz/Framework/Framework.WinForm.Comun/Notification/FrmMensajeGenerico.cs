using System;
using System.Drawing;
using System.Windows.Forms;
using Framework.WinForm.Comun.Resources;

namespace Framework.WinForm.Comun.Notification
{
    public partial class FrmMensajeGenerico : Form
    {
        public MensajeGenerico Mensaje { get; set; }

        public FrmMensajeGenerico(MensajeGenerico mensaje)
        {
            InitializeComponent();
            Mensaje = mensaje;
        }

        private void FrmMensajeGenerico_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Mensaje.Tipo)
                {
                    case TipoMensajeGenerico.Advertencia :
                        picImagen.Image = Resource.Warning;
                        this.Icon = Icon.FromHandle(Resource.Warning.GetHicon());
                        break;
                    case TipoMensajeGenerico.Error:
                        picImagen.Image = Resource.Error;
                        this.Icon = Icon.FromHandle(Resource.Error.GetHicon());
                        break;
                    case TipoMensajeGenerico.Info:
                        picImagen.Image = Resource.Information;
                        this.Icon = Icon.FromHandle(Resource.Information.GetHicon());
                        break;
                    default:
                        picImagen.Image = Resource.Check;
                        this.Icon = Icon.FromHandle(Resource.Check.GetHicon());
                        break;
                }

                lblTitulo.Text = Mensaje.Titulo;
                lblMensaje.Text = Mensaje.Mensaje;

                var alturaBotones = 75 + lblMensaje.Size.Height;
                btnAceptar.Location = new Point(btnAceptar.Location.X, alturaBotones);
                this.Height = alturaBotones + 40;

                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
