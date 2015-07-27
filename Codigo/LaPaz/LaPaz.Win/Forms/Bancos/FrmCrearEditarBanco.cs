using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Bancos
{
    public partial class FrmCrearEditarBanco : EditFormBase
    {
        private readonly int _bancoId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Banco _banco;
        

        public FrmCrearEditarBanco(ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _bancoId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);
        }

        #region Eventos
        public event EventHandler<Banco> BancoAgregado;
        #endregion

        #region Propiedades

        public int Id { get; set; }
        
        public string Nombre
        {
            get { return txtNombre.Text.Trim(); }
            set { txtNombre.Text = value; }
        }

        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearBanco;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarBanco;
                    break;
            }
        }

        private void FrmCrearBanco_Load(object sender, EventArgs e)
        {
            CargarBanco(_bancoId);
        }

        private void CargarBanco(int bancoId)
        {
            _banco = bancoId == 0 ? new Banco() : Uow.Bancos.Obtener(c => c.Id == bancoId);

            this.Nombre = _banco.Nombre;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditarBanco();
        }

        private void CrearEditarBanco()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var existe = Uow.Bancos.Listado().FirstOrDefault(b => b.Id != _bancoId && b.Nombre == Nombre) != null;
                if (existe)
                {
                    this.FormErrorProvider.SetError(txtNombre, "Ya existe un banco con el mismo nombre");
                    DialogResult = DialogResult.None;
                }
                else
                {
                    var banco = ObtenerBancoDesdeForm();
                    if (_formMode == ActionFormMode.Create)
                    {
                        Uow.Bancos.Agregar(banco);
                    }
                    else
                    {
                        Uow.Bancos.Modificar(banco);
                    }

                    Uow.Commit();

                    if (_formMode == ActionFormMode.Create)
                    {
                        OnBancoAgregado(banco);
                    }
                }
            }
        }

        private void OnBancoAgregado(Banco banco)
        {
            if (BancoAgregado != null)
            {
                BancoAgregado(this, banco);
            }
        }

        private Banco ObtenerBancoDesdeForm()
        {
            _banco.Id = _bancoId;
            _banco.Nombre = Nombre;

            //Fechas.
            _banco.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _banco.FechaAlta;
            _banco.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            _banco.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? this.Context.SucursalActual.SucursalAltaId
                                          : _banco.SucursalAltaId;

            _banco.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _banco.SucursalModificacionId;

            _banco.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? this.Context.OperadorActual.Id
                                          : _banco.OperadorAltaId;

            _banco.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _banco.OperadorModificacionId;
            return _banco;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerBancoDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(txtNombre, "Nombre");
         }

        #endregion
    }
}
