using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Temas
{
    public partial class FrmDetalleEliminarTema : EditFormBase
    {
        private readonly int _temaId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Tema _tema;

        private BackgroundWorker bw = new BackgroundWorker();

        public FrmDetalleEliminarTema(ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _temaId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);

        }

        #region Propiedades
        public string Nombre
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; }
        }
        
        #endregion

        #region Metodos
        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleTema;
                    BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarTema;
                    BtnEliminar.Visible = true;
                    break;
            }
        }

        private void CargarTema(int temaId)
        {
            if (temaId == 0)
            {
                _tema = new Tema();
                //Default values.
            }
            else
            {
                _tema = Uow.Temas.Obtener(t => t.Id == temaId);
                this.Nombre = _tema.Nombre;
            }
            
        }
        
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var tema = Uow.Temas.Obtener(t => t.Id == _temaId);
            Uow.Temas.Eliminar(tema);
            Uow.Commit();
        }

        private void FrmDetalleEliminarTema_Load(object sender, EventArgs e)
        {
            CargarTema(_temaId);
        }

        #endregion


    }
}
