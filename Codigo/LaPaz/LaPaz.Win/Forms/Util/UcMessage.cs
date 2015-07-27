using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.WinForm.Comun.Notification;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcMessage : UserControlBase
    {
        private TipoMensajeGenerico _tipoMensaje;

        public UcMessage()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return LbMessage.Text; }
            set { LbMessage.Text = value; }
        }

        public TipoMensajeGenerico TipoMensaje
        {
            get { return _tipoMensaje; }
            set
            {
                if (_tipoMensaje != value)
                {
                    _tipoMensaje = value;

                    switch (_tipoMensaje)
                    {
                        case TipoMensajeGenerico.Exito:
                            PnMessage.BackColor = Color.FromArgb(255, 143, 188,0);
                            break;
                        case TipoMensajeGenerico.Error:
                            PnMessage.BackColor = Color.Red;
                            break;
                        case TipoMensajeGenerico.Advertencia:
                            PnMessage.BackColor = Color.FromArgb(255, 244, 152, 31);
                            break;
                    }
                }
            }
        }
    }
}
