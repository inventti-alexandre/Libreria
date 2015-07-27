using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Cuentas
{
    public partial class FrmCrearEditarCuenta : EditFormBase
    {
        private List<Cuenta> _cuentas;
        private readonly int _cuentaId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Cuenta _cuenta;

        public FrmCrearEditarCuenta(ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _cuentaId = id;
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

        public string Descripcion
        {
            get { return TxtDescripcion.Text; }
            set { TxtDescripcion.Text = value; }
        }

        public string Titular
        {
            get { return TxtTitular.Text; }
            set { TxtTitular.Text = value; }
        }

        public int? BancoPropioId
        {
            get { return CbxBancoPropio.Id; }
            set { CbxBancoPropio.Id = value ?? 0; }
        }

        public int? TipoCuentaId
        {
            get { return CbxTipoCuenta.TipoCuentaId; }
            set { CbxTipoCuenta.TipoCuentaId = value ?? 0; }
        }

        public DateTime FechaApertura
        {
            get { return DtpFechaApertura.Value; }
            set { DtpFechaApertura.Value = value; }
        }
        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearCuenta;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarCuenta;
                    break;
            }
        }

        private void FrmCrearEditarAutor_Load(object sender, EventArgs e)
        {
            CargarCuenta(_cuentaId);
        }

        private void CargarCuenta(int cuentaId)
        {
            if (cuentaId == 0)
            {
                _cuenta = new Cuenta();
            }
            else
            {
                _cuenta = Uow.Cuentas.Obtener(c => c.Id == cuentaId);
                this.Nombre = _cuenta.Nombre;
                this.Descripcion = _cuenta.Descripcion;
                this.Titular = _cuenta.Titular;
                this.BancoPropioId = _cuenta.BancoPropioId;
                this.TipoCuentaId = _cuenta.TipoCuentaId;
                this.FechaApertura = _cuenta.FechaApertura;
            }
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerCuentaDesdeForm();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCuenta();
        }

        private void GuardarCuenta()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var cuenta = ObtenerCuentaDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Cuentas.Agregar(cuenta);
                }
                else
                {
                    Uow.Cuentas.Modificar(cuenta);
                }
                Uow.Commit();
            }
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtNombre, "Nombre");
            this.ValidarControl(TxtTitular, "Titular");
            this.ValidarControl(CbxBancoPropio, "BancoPropioId");
            this.ValidarControl(CbxTipoCuenta, "TipoCuentaId");
            this.ValidarControl(DtpFechaApertura, "FechaApertura");
        }

        private Cuenta ObtenerCuentaDesdeForm()
        {
            _cuenta.Nombre = this.Nombre;
            _cuenta.Descripcion = this.Descripcion;
            _cuenta.Titular = this.Titular;
            _cuenta.BancoPropioId = this.BancoPropioId;
            _cuenta.TipoCuentaId = (int)this.TipoCuentaId;
            _cuenta.FechaApertura = this.FechaApertura;
            _cuenta.Activo = true;

            //Fechas.
            _cuenta.FechaAlta = _cuentaId == 0 ? _clock.Now : _cuenta.FechaAlta;
            _cuenta.FechaModificacion = _cuentaId == 0 ? (DateTime?)null : _clock.Now;

            _cuenta.SucursalAltaId = _cuentaId == 0
                ? Context.SucursalActual.Id
                : _cuenta.SucursalAltaId;

            _cuenta.SucursalModificacionId = _cuentaId == 0
                ? Context.SucursalActual.Id
                : _cuenta.SucursalModificacionId;

            _cuenta.OperadorAltaId = _cuentaId == 0
                ? Context.OperadorActual.Id
                : _cuenta.OperadorAltaId;

            _cuenta.OperadorModificacionId = _cuentaId == 0
                ? Context.OperadorActual.Id
                : _cuenta.OperadorModificacionId;

            return _cuenta;
        }

        #endregion
    }
}
