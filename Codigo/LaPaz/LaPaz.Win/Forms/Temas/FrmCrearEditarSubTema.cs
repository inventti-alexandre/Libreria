using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Temas
{
    public partial class FrmCrearEditarSubTema : EditFormBase
    {
        private readonly int _subTemaId;
        private int _temaId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private SubTema _subTema;

        public FrmCrearEditarSubTema(ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _subTemaId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();

            InicializarForm(mode);
        }

        #region Propiedades

        public int TemaId
        {
            get { return _temaId; }
            set { _temaId = value; }
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
                    this.Text = Resources.LabelCrearSubTema;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarSubTema;
                    break;
            }
        }

        private void CargarSubTema(int subTemaId)
        {
            if (_subTemaId == 0)
            {
                _subTema = new SubTema();
            }
            else
            {
                _subTema = Uow.SubTemas.Obtener(t => t.Id == subTemaId);
                this.Nombre = _subTema.Nombre;
            }
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerSubTemaDesdeForm();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTema();
        }

        private void GuardarTema()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var existe = Uow.SubTemas.Listado().FirstOrDefault(t => t.Id != _subTemaId && t.Nombre == Nombre) != null;
                if (existe)
                {
                    this.FormErrorProvider.SetError(TxtNombre, "Ya existe un sub tema con el mismo nombre");
                    DialogResult = DialogResult.None;
                }
                else
                {
                    var tema = ObtenerSubTemaDesdeForm();

                    if (_formMode == ActionFormMode.Create)
                    {
                        Uow.SubTemas.Agregar(tema);
                    }
                    else
                    {
                        Uow.SubTemas.Modificar(tema);
                    }
                    Uow.Commit();
                }
            }

        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtNombre, "Nombre");
        }

        private SubTema ObtenerSubTemaDesdeForm()
        {
            _subTema.TemaId = _subTemaId == 0? _temaId : _subTema.TemaId;
            _subTema.Nombre = this.Nombre;

            //Fechas.
            _subTema.FechaAlta = _subTemaId == 0 ? _clock.Now : _subTema.FechaAlta;
            _subTema.FechaModificacion = _subTemaId == 0 ? (DateTime?)null : _clock.Now;

            _subTema.SucursalAltaId = _subTemaId == 0
                ? Context.SucursalActual.Id
                : _subTema.SucursalAltaId;

            _subTema.SucursalModificacionId = _subTemaId == 0
                ? null
                : _subTema.SucursalModificacionId;

            _subTema.OperadorAltaId = _subTemaId == 0
                ? Context.OperadorActual.Id
                : _subTema.OperadorAltaId;

            _subTema.OperadorModificacionId = _subTemaId == 0
                ? null
                : _subTema.OperadorModificacionId;

            return _subTema;
        }

        private void FrmCrearEditarTema_Load(object sender, EventArgs e)
        {
            CargarSubTema(_subTemaId);
        }

        #endregion
    }
}
