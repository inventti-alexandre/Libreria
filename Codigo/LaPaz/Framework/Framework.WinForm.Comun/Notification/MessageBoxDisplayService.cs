using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Framework.WinForm.Comun.Notification
{
    public class MessageBoxDisplayService : IMessageBoxDisplayService
    {
        public MessageBoxDisplayService()
        {
            
        }

        public void Show(string message, string title)
        {
            this.Show(Form.ActiveForm, message, title);
        }

        public void Show(IWin32Window owner, string message, string title)
        {
            RadMessageBox.Instance.ThemeName = "TelerikMetroBlue";
            RadMessageBox.Instance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadMessageBox.Show(owner, message,title);
        }

        public void ShowError(string message)
        {
            var msjerror = new MensajeGenerico
            {
                Mensaje = message,
                Tipo = TipoMensajeGenerico.Error,
                Titulo = "Error"
            };
            using (var form = new FrmMensajeGenerico(msjerror))
            {
                form.ShowDialog(); 
            }
        }

        public void ShowWarning(string message)
        {
            var msjWarning = new MensajeGenerico
            {
                Mensaje = message,
                Tipo = TipoMensajeGenerico.Advertencia,
                Titulo = "Advertencia"
            };
            using (var form = new FrmMensajeGenerico(msjWarning))
            {
                form.ShowDialog();
            }
        }

        public void ShowSuccess(string message)
        {
            var msjsuccess = new MensajeGenerico
            {
                Mensaje = message,
                Tipo = TipoMensajeGenerico.Exito,
                Titulo = "Éxito"
            };
            using (var form = new FrmMensajeGenerico(msjsuccess))
            {
                form.ShowDialog();
            }
        }

        public void ShowConfirmationDialog(string message, string title, Action okAction)
        {
            RadMessageBox.Instance.ThemeName = "TelerikMetroBlue";
            RadMessageBox.Instance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            var result = RadMessageBox.Show(Form.ActiveForm, message, title, MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                if (okAction != null)
                {
                    okAction();
                }
            }
        }

        public void ShowInfo(string message)
        {
            var msjInfo = new MensajeGenerico
            {
                Mensaje = message,
                Tipo = TipoMensajeGenerico.Info,
                Titulo = "Información"
            };
            using (var form = new FrmMensajeGenerico(msjInfo))
            {
                form.ShowDialog();
            }
        }
    }
}
