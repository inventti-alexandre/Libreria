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
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Temas
{
    public partial class FrmDetalleEliminarSubTema : EditFormBase
    {
        private readonly int _subTemaId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private SubTema _subTema;

        private BackgroundWorker bw = new BackgroundWorker();

        public FrmDetalleEliminarSubTema(ILaPazUow uow, IClock clock, IMessageBoxDisplayService messageBoxDisplayService, int id, ActionFormMode mode)
        {
            Uow = uow;

            _subTemaId = id;
            _clock = clock;
            _formMode = mode;
            _messageBoxDisplayService = messageBoxDisplayService;

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
                    this.Text = Resources.LabelDetalleSubTema;
                    BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarSubTema;
                    BtnEliminar.Visible = true;
                    break;
            }
        }

        private void CargarTema(int subTemaId)
        {
            if (subTemaId == 0)
            {
                _subTema = new SubTema();
                //Default values.
            }
            else
            {
                _subTema = Uow.SubTemas.Obtener(t => t.Id == subTemaId);
                this.Nombre = _subTema.Nombre;
            }
            
        }
        
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            var subTema = Uow.SubTemas.Obtener(st => st.Id == _subTemaId);

            var titulos = Uow.Titulos.Listado().Where(t => t.SubtemaId == _subTemaId).ToList();

            if (titulos.Any())
            {
                _messageBoxDisplayService.Show(Resources.ErrorMessageSubTemasConTitulos, Resources.LabelSubTemas);
                return;
            }

            Uow.SubTemas.Eliminar(subTema);
            Uow.Commit();
        }

        private void FrmDetalleEliminarTema_Load(object sender, EventArgs e)
        {
            CargarTema(_subTemaId);
        }

        #endregion


    }
}
