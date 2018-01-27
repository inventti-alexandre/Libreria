using LaPaz.Datos.Interfaces;
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
        private int _reservaId;
        public FrmComentario(int id, ILaPazUow uow)
        {
            Uow = uow;
            _reservaId = id;
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

        private void FrmComentario_Load(object sender, EventArgs e)
        {
            if (_reservaId != 0)
            {
                Comentario = Uow.VentasReservadas.Listado().Where(r => r.NroReserva == _reservaId && r.SucReserva == Context.SucursalActual.Id).FirstOrDefault().Comentario;
            }
        }
    }
}
