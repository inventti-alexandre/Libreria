using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.ProveedoresBancos;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Temas
{
    public partial class FrmCrearEditarTema : EditFormBase
    {
        private int _temaId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Tema _tema;

        public FrmCrearEditarTema(IFormFactory formFactory, ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            _temaId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();

            InicializarForm(mode);

            this.GridSubTemas.CellFormatting += this.Grilla_CellFormatting;
        }

        #region Propiedades

        public Tema Tema
        {
            get { return _tema; }
        }

        public string Nombre
        {
            get
            {
                return TxtNombre.Text;
            }
            set
            {
                TxtNombre.Text = value;
            }
        }

        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearTema;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarTema;
                    break;
            }
        }

        private void FrmCrearEditarTema_Load(object sender, EventArgs e)
        {
            CargarTema(_temaId);
            radPageView1.SelectedPage = PageTema;

            if (_formMode == ActionFormMode.Create)
            {
                PageSubTema.Enabled = false;
                BtnGuardar.Text = "Continuar";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var tema = ObtenerTemaDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Temas.Agregar(tema);
                }
                else
                {
                    Uow.Temas.Modificar(tema);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    BtnGuardar.Visible = false;
                    BtnCancelar.Text = "Cerrar";
                    PageTema.Enabled = false;
                    PageSubTema.Enabled = true;
                    radPageView1.SelectedPage = PageSubTema;
                    DialogResult = DialogResult.None;
                    _temaId = tema.Id;

                    BtnCancelar.DialogResult = DialogResult.OK;
                }
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
                CargarSubTemas();
            }
        }

        private void CargarSubTemas()
        {
            var repo = new EFRepository<SubTema>();
            var subTemas = repo.Listado().Where(st => st.TemaId == _temaId).ToList();
            GridSubTemas.DataSource = subTemas;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerTemaDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtNombre, "Nombre");
        }

        private Tema ObtenerTemaDesdeForm()
        {
            _tema.Nombre = Nombre;

            //Fechas.
            _tema.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _tema.FechaAlta;
            _tema.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            _tema.SucursalAltaId = _formMode == ActionFormMode.Create
                ? this.Context.SucursalActual.Id
                : _tema.SucursalAltaId;

            _tema.SucursalModificacionId = _formMode == ActionFormMode.Create
                ? (int?)null
                : this.Context.SucursalActual.Id;

            _tema.OperadorAltaId = _formMode == ActionFormMode.Create
                ? this.Context.OperadorActual.Id
                : _tema.OperadorAltaId;

            _tema.OperadorModificacionId = _formMode == ActionFormMode.Create
                ? (Guid?)null
                : this.Context.OperadorActual.Id;

            return _tema;
        }

        #endregion

        private void GridSubTemas_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridSubTemas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var subTema = selectedRow.DataBoundItem as SubTema;

            if (subTema == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    DetalleSubTema(subTema.Id);
                    break;
                case "ColumnaEditar":
                    EditarSubTema(subTema.Id);
                    break;
                case "ColumnaEliminar":
                    EliminarSubTema(subTema.Id);
                    break;
            }
        }

        private void DetalleSubTema(int subTemaId)
        {
            using (var formDetalle = FormFactory.Create<FrmDetalleEliminarSubTema>(subTemaId, ActionFormMode.Detail))
            {
                var result = formDetalle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formDetalle.Close();
                    CargarSubTemas();
                }
            }
        }

        private void EditarSubTema(int _subTemaId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarSubTema>(_subTemaId, ActionFormMode.Edit))
            {
                formCrear.TemaId = _tema.Id;
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    CargarSubTemas();
                }
            }
        }

        private void EliminarSubTema(int subTemaId)
        {
            using (var formEliminar = FormFactory.Create<FrmDetalleEliminarSubTema>(subTemaId, ActionFormMode.Delete))
            {
                var result = formEliminar.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formEliminar.Close();
                    CargarSubTemas();
                } 
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CrearSubTema();
        }

        private void CrearSubTema()
        {
            using (var frm = new FrmCrearEditarSubTema(Uow, _clock, 0, ActionFormMode.Create))
            {
                frm.TemaId = _tema.Id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarSubTemas();
                } 
            }
        }
    }
}
