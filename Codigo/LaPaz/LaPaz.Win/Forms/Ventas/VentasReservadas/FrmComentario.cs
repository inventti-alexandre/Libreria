using LaPaz.Win.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Ventas.VentasReservadas
{
    public partial class FrmComentario : FormBase
    {
        public FrmComentario()
        {
            InitializeComponent();
        }

        #region Property
        public string Comentario 
        {
            get
            { return TxtComentario.Text;}
            set
            { TxtComentario.Text = value; } 
        }
        #endregion
        public event EventHandler<string> ComentarioAgregado;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            OnComentarioAgregado(Comentario);
        }

        private void OnComentarioAgregado(string comentario)
        {
            if (ComentarioAgregado != null)
            {
                ComentarioAgregado(this, comentario);
            }
        }
    }
}
