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

namespace LaPaz.Win.Forms.Autores
{
    public partial class FrmDetalleEliminarAutor : EditFormBase
    {
        private List<Autor> Autores;
        private readonly int _autorId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Autor _autor;

        private BackgroundWorker bw = new BackgroundWorker();

        public FrmDetalleEliminarAutor(ILaPazUow uow, IMessageBoxDisplayService messageBoxDisplayService, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;
            _messageBoxDisplayService = messageBoxDisplayService;
            _autorId = id;
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
                    this.Text = Resources.LabelDetalleAutor;
                    BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarAutor;
                    BtnEliminar.Visible = true;
                    break;
            }
        }

        private void CargarAutor(int autorId)
        {
            if (autorId == 0)
            {
                _autor = new Autor();
                //Default values.
            }
            else
            {
                _autor = Uow.Autores.Obtener(a => a.Id == autorId);
                this.Nombre = _autor.Nombre;
            }
            
        }
        
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var autor = Uow.Autores.Obtener(a => a.Id == _autorId);

            var titulos = Uow.Titulos.Listado().Where(t => t.AutorId == autor.Id).ToList();

            if (titulos.Any())
            {
                _messageBoxDisplayService.Show(Resources.ErrorMessageEditorialConTitulos,Resources.LabelAutores);
                return;
            }

            Uow.Autores.Eliminar(autor);
            Uow.Commit();
        }

        private void FrmDetalleEliminarAutor_Load(object sender, EventArgs e)
        {
            CargarAutor(_autorId);
        }

        #endregion

    }
}
