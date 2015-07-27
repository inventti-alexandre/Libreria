using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Autores
{
    public partial class FrmCrearEditarAutor : EditFormBase
    {
        private List<Autor> _autores;
        private readonly int _autorId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Autor _autor;

        public FrmCrearEditarAutor(ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _autorId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();

            InicializarForm(mode);
        }

        #region Propiedades

        public Autor Autor
        {
            get { return _autor; }
        }

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
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearAutor;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarAutor;
                    break;
            }
        }

        private void FrmCrearEditarAutor_Load(object sender, EventArgs e)
        {
            CargarAutor(_autorId);
        }

        private void CargarAutor(int autorId)
        {
            if (autorId == 0)
            {
                _autor = new Autor();
            }
            else
            {
                _autor = Uow.Autores.Obtener(a => a.Id == autorId);
                this.Nombre = _autor.Nombre;
            }
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerAutorDesdeForm();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAutor();
        }

        private void GuardarAutor()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var autor = ObtenerAutorDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Autores.Agregar(autor);
                }
                else
                {
                    Uow.Autores.Modificar(autor);
                }
                Uow.Commit();
            }

        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtNombre, "Nombre");
        }

        private Autor ObtenerAutorDesdeForm()
        {
            _autor.Id = _autorId == 0 ? Uow.Autores.Listado().OrderBy(a => a.Id).ToList().Last().Id + 1 : _autorId;
            _autor.Nombre = this.Nombre;

            //Fechas.
            _autor.FechaAlta = _autorId == 0 ? _clock.Now : _autor.FechaAlta;
            _autor.FechaModificacion = _autorId == 0 ? (DateTime?)null : _clock.Now;

            _autor.SucursalAltaId = _autorId == 0
                ? Context.SucursalActual.Id
                : _autor.SucursalAltaId;

            _autor.SucursalModificacionId = _autorId == 0
                ? Context.SucursalActual.Id
                : _autor.SucursalModificacionId;

            _autor.OperadorAltaId = _autorId == 0
                ? Context.OperadorActual.Id
                : _autor.OperadorAltaId;

            _autor.OperadorModificacionId = _autorId == 0
                ? Context.OperadorActual.Id
                : _autor.OperadorModificacionId;

            return _autor;
        }

        #endregion
    }
}
