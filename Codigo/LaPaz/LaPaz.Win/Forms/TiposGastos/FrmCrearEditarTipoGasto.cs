using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.ProveedoresBancos;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;


namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class FrmCrearEditarTipoGasto : EditFormBase
    {
        private int _tipoGastoId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private TiposGasto _tipoGasto;

        public event EventHandler<TiposGasto> CargaFinished;

        public FrmCrearEditarTipoGasto(IFormFactory formFactory, ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            _tipoGastoId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
        }

        #region Propiedades

        public string Nombre
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; }
        }

        public string Abreviatura
        {
            get { return TxtAbreviatura.Text; }
            set { TxtAbreviatura.Text = value; }
        }

        public string Descripcion
        {
            get { return TxtDescripcion.Text; }
            set { TxtDescripcion.Text = value; }
        }

        public bool BienDeUso
        {
            get { return CkdBienDeUso.Checked; }
            set { CkdBienDeUso.Checked = value; }
        }
        #endregion

        #region Metodos
        protected override object ObtenerEntidad()
        {
            return ObtenerTipoGastoDesdeForm();
        }

        private TiposGasto ObtenerTipoGastoDesdeForm()
        {
            _tipoGasto.Id = _tipoGastoId;
            _tipoGasto.Nombre = TxtNombre.Text;
            _tipoGasto.Abreviatura= TxtAbreviatura.Text;
            _tipoGasto.Descripcion = TxtDescripcion.Text;
            _tipoGasto.BienDeUso= CkdBienDeUso.Checked;

            //Fechas.
            _tipoGasto.FechaAlta = _tipoGastoId == 0 ? _clock.Now : _tipoGasto.FechaAlta;
            _tipoGasto.FechaModificacion = _tipoGastoId == 0 ? (DateTime?)null : _clock.Now;

            _tipoGasto.SucursalAltaId = _tipoGastoId == 0
                ? Context.SucursalActual.Id
                : _tipoGasto.SucursalAltaId;

            _tipoGasto.SucursalModificacionId = _tipoGastoId == 0
                ? null
                : _tipoGasto.SucursalModificacionId;

            _tipoGasto.OperadorAltaId = _tipoGastoId == 0
                ? Context.OperadorActual.Id
                : _tipoGasto.OperadorAltaId;

            _tipoGasto.OperadorModificacionId = _tipoGastoId == 0
                ? null
                : _tipoGasto.OperadorModificacionId;

            return _tipoGasto;
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtNombre, "Nombre");
            this.ValidarControl(TxtAbreviatura, "Abreviatura");
            this.ValidarControl(TxtDescripcion, "Descripcion");
            
        }
        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var tipoGasto = ObtenerTipoGastoDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    Uow.TiposGastos.Agregar(tipoGasto);
                }
                else
                {
                    Uow.TiposGastos.Modificar(tipoGasto);
                }

                Uow.Commit();

                if (CargaFinished != null)
                    CargaFinished(this, tipoGasto);

                BtnCancelar.DialogResult = DialogResult.OK;
            }
           
        }

        private void FrmCrearEditarDetalle_Load(object sender, EventArgs e)
        {
            CargarTipoGasto();
        }

        private void CargarTipoGasto()
        {
            if (_tipoGastoId == 0)
            {
                this.Text = "Crear Tipo de Gasto";
                _tipoGasto = new TiposGasto();
                //Default values.
            }
            else
            {
                this.Text = "Editar Tipo de Gasto";
                _tipoGasto = Uow.TiposGastos.Obtener(t => t.Id == _tipoGastoId);
            }

            this.Nombre = _tipoGasto.Nombre;
            this.Abreviatura= _tipoGasto.Abreviatura;
            this.Descripcion= _tipoGasto.Descripcion;
            this.BienDeUso= _tipoGasto.BienDeUso??false;
        }
    }
}
