using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.WinForm.Comun.Notification;
using LaPaz.Entidades;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Helpers
{
    class ClipboardHelper
    {
        public static void SetPortapapeles(KeyEventArgs e, RadGridView grid)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (grid.SelectedRows.Count > 0)
                {
                    var titulo = grid.SelectedRows.FirstOrDefault().DataBoundItem as TituloDto;
                    if (titulo == null)
                        return;

                    Clipboard.SetText(string.Format("{0};{1};{2}", titulo.NombreTitulo, titulo.AutorNombre, titulo.EditorialNombre));
                    MessageBoxDisplayService _messageBoxDisplayServic = new MessageBoxDisplayService();
                    _messageBoxDisplayServic.ShowSuccess("Se copió al Portapapeles");
                }
            }
        }
    }
}
