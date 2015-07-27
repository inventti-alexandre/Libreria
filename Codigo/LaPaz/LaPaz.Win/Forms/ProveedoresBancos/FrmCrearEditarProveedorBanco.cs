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
using LaPaz.Datos.Repositorio;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.ProveedoresBancos
{
    public partial class FrmCrearEditarProveedorBanco : EditFormBase
    {
        private readonly Guid _proveedorBancoId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Entidades.ProveedorBanco _proveedorBanco;

        private BackgroundWorker bw = new BackgroundWorker();

        //Cuando se edita => id = ProveedorBancoId
        //Cuando se crea => id = ProveedorId

        public FrmCrearEditarProveedorBanco(ILaPazUow uow, IClock clock, Guid id, ActionFormMode mode)
        {
            Uow = uow;

            _clock = clock;
            _formMode = mode;
            
            if (mode == ActionFormMode.Edit)
            {
                _proveedorBancoId = id;
            }
            else
            {
                ProveedorId = id;
            }

            InitializeComponent();
            InicializarForm(mode);
        }

        #region Eventos
        public event EventHandler<ProveedorBanco> ProveedorBancoAgregado;
        #endregion

        #region Propiedades

        public Guid Id { get; set; }

        public Guid ProveedorId { get; set; }

        public int? BancoId
        {
            get { return (int?) CbxBanco.SelectedValue; }
            set { CbxBanco.SelectedValue = value; }
        }

        public string Titular
        {
            get { return TxtTitular.Text; }
            set { TxtTitular.Text = value; }
        }

        public string CuentaCorriente
        {
            get { return TxtCuentaCorriente.Text; }
            set { TxtCuentaCorriente.Text = value; }
        }

        public string CajaAhorro
        {
            get { return TxtCajaAhorro.Text; }
            set { TxtCajaAhorro.Text = value; }
        }

        public string Cbu
        {
            get { return TxtCbu.Text; }
            set { TxtCbu.Text = value; }
        }

        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Crear Proveedor Banco";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar Proveedor Banco";
                    break;
            }
        }

        private void FrmCrearProveedorBanco_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarProveedorBanco(_proveedorBancoId);
        }

        private void CargarProveedorBanco(Guid proveedorBancoId)
        {
            _proveedorBanco = proveedorBancoId == default(Guid) 
                                                        ? new ProveedorBanco() 
                                                        : Uow.ProveedoresBancos.Obtener(c => c.Id == proveedorBancoId);

            this.BancoId = _proveedorBanco.BancoId;
            this.Titular = _proveedorBanco.Titular;
            this.CuentaCorriente = _proveedorBanco.CtaCte;
            this.CajaAhorro = _proveedorBanco.CajaAhorro;
            this.Cbu = _proveedorBanco.CBU;
            if (ProveedorId ==  default (Guid))
                ProveedorId = _proveedorBanco.ProveedorId;
            
        }

        private void CargarCombos()
        {
            CbxBanco.DisplayMember = "Nombre";
            CbxBanco.ValueMember = "Id";
            var bancos = Uow.Bancos.Listado().OrderBy(p => p.Nombre).ToList();
            bancos.Insert(0, new Banco() { Id = 0, Nombre = "SELECCIONE BANCO" });
            CbxBanco.DataSource = bancos;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditarProveedorBanco();
        }

        private void CrearEditarProveedorBanco()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var proveedorBanco = ObtenerProveedorBancoDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    Uow.ProveedoresBancos.Agregar(proveedorBanco);
                }
                else
                {
                    Uow.ProveedoresBancos.Modificar(proveedorBanco);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnProveedorBancoAgregado(proveedorBanco);
                }
            }
        }

        private void OnProveedorBancoAgregado(ProveedorBanco proevedorBanco)
        {
            if (ProveedorBancoAgregado != null)
            {
                ProveedorBancoAgregado(this, proevedorBanco);
            }
        }

        private ProveedorBanco ObtenerProveedorBancoDesdeForm()
        {
            _proveedorBanco.Id = _proveedorBancoId == default(Guid) ? Guid.NewGuid() : _proveedorBancoId;
            _proveedorBanco.BancoId = BancoId;
            _proveedorBanco.Titular = Titular;
            _proveedorBanco.CtaCte = CuentaCorriente;
            _proveedorBanco.CajaAhorro = CajaAhorro;
            _proveedorBanco.CBU = Cbu;
            _proveedorBanco.ProveedorId = ProveedorId;

            //Fechas.
            _proveedorBanco.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _proveedorBanco.FechaAlta;
            _proveedorBanco.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            _proveedorBanco.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? 2
                                          : _proveedorBanco.SucursalAltaId;

            _proveedorBanco.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _proveedorBanco.SucursalModificacionId;

            _proveedorBanco.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? Guid.Parse("D233B407-906F-470F-9CB2-34CDDAF15DDE")
                                          : _proveedorBanco.OperadorAltaId;

            _proveedorBanco.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _proveedorBanco.OperadorModificacionId;

            return _proveedorBanco;
       }

        protected override object ObtenerEntidad()
        {
            return ObtenerProveedorBancoDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(CbxBanco, "BancoId");
            this.ValidarControl(TxtTitular, "Titular");
            this.ValidarControl(TxtCuentaCorriente, "CtaCte");
            this.ValidarControl(TxtCajaAhorro, "CajaAhorro");
            this.ValidarControl(TxtCbu, "CBU");
         }

        #endregion
       
    }
}
