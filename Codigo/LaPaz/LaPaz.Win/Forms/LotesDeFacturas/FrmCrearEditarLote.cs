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
using LaPaz.Entidades.Enums;
using LaPaz.Win.Enums;

namespace LaPaz.Win.Forms.LotesDeFacturas
{
    public partial class FrmCrearEditarLote : EditFormBase
    {
        private int _nroLote;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private LoteFactura _loteFactura;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;


        public FrmCrearEditarLote(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService, ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            _messageBoxDisplayService = messageBoxDisplayService;
            _nroLote = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();

            InicializarForm(mode);

        }

        #region "Metodos"
        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nuevo Lote";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar Lote";
                    break;
            }
        }

        private void FrmCrearEditarLote_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarLote(_nroLote);
        }

        private void CargarEstados()
        {
            ddlEstados.DisplayMember = "Nombre";
            ddlEstados.ValueMember = "Id";

            var estados = Uow.EstadosLotesFactura.Listado().ToList();
            ddlEstados.DataSource = estados;
        }

        private void CargarLote(int _nroLote)
        {
            if (_nroLote == default(int))
            {
                _loteFactura = new LoteFactura();
                _loteFactura.Tipo = "C";
                //NroActual = 0;
                TxtActual.Enabled = false;
                return;
            }
            else
            {
                _loteFactura = Uow.LotesFacturas.Obtener(l => l.NroLote == _nroLote);
            }

            NroDesde = _loteFactura.NroDesde;
            NroHasta = _loteFactura.NroHasta;
            NroActual = _loteFactura.NroActual;
            Tipo = _loteFactura.Tipo;
            EstadoId =_loteFactura.Estado;
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
                LoteFactura lote = ObtenerLoteDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    if (ValidarNumeroLote() == false)
                    {
                        _messageBoxDisplayService.ShowWarning("Lote No válido");
                        this.DialogResult=DialogResult.None;
                        return;
                    }
                    

                    _loteFactura.NroActual -= 1;
                    Uow.LotesFacturas.Agregar(lote);
                }
                else
                {
                    Uow.LotesFacturas.Modificar(lote);
                }

                Uow.Commit();

            }
        }

        private bool ValidarNumeroLote()
        {

            //var loteDesde1 = Uow.LotesFacturas.Listado().Where((l => l.NroDesde <= NroDesde && l.NroHasta >= NroDesde && l.PtoVenta == 1)).ToList();

            //var loteHasta1 = Uow.LotesFacturas.Listado().Where(l => l.NroHasta <= NroHasta && l.NroHasta >= NroHasta && l.PtoVenta == 1).ToList();

            var loteDesde1 = Uow.LotesFacturas.Listado().Where((l => l.NroDesde <= NroDesde && l.NroHasta >= NroDesde && l.PtoVenta == Context.SucursalActual.SucursalNumero)).ToList();

            var loteHasta1 = Uow.LotesFacturas.Listado().Where(l => l.NroHasta <= NroHasta && l.NroHasta >= NroHasta && l.PtoVenta == Context.SucursalActual.SucursalNumero).ToList();

            if ((loteDesde1.Count > 0 ) || (loteHasta1.Count > 0 ))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private LoteFactura ObtenerLoteDesdeForm()
        {
            _loteFactura.NroDesde = NroDesde;
            _loteFactura.NroHasta = NroHasta;
           _loteFactura.NroActual = NroActual;
            _loteFactura.Tipo = "C";
            _loteFactura.Estado = EstadoId;
            _loteFactura.OperadorLote = Context.OperadorActual.Id;
            _loteFactura.PtoVenta = 1;
            _loteFactura.SucursalLote = Context.SucursalActual.Id;

            //Fechas.
            _loteFactura.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _loteFactura.FechaAlta;
            _loteFactura.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            _loteFactura.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? Context.SucursalActual.Id
                                          : _loteFactura.SucursalAltaId;

            _loteFactura.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _loteFactura.SucursalModificacionId;

            _loteFactura.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? Context.OperadorActual.Id
                                          : _loteFactura.OperadorAltaId;

            _loteFactura.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _loteFactura.OperadorModificacionId;

            return _loteFactura;
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtDesde, "NroDesde");
            this.ValidarControl(TxtHasta, "NroHasta");
            this.ValidarControl(TxtActual, "NroActual");
            this.ValidarControl(TxtTipo, "Tipo");
        }
        protected override object ObtenerEntidad()
        {
            return ObtenerLoteDesdeForm();
        }
        #endregion

        #region Propiedades
        
        public EstadoLoteEnum EstadoId
        {
            get { return (EstadoLoteEnum)ddlEstados.SelectedValue; }
            set { ddlEstados.SelectedValue = value ; }
        }

        public int NroDesde
        {
            get
            {
                int desde;
                return int.TryParse(TxtDesde.Text, out desde) ?desde : 0;
            }
            set { TxtDesde.Text= value.ToString(); }
        }

        public int NroHasta
        {
            get
            {
                int hasta;
                return int.TryParse(TxtHasta.Text, out hasta) ? hasta : 0;
            }
            set { TxtHasta.Text = value.ToString(); }
        }

        public int? NroActual
        {
            get
            {
                int actual;
                return int.TryParse(TxtActual.Text, out actual) ? actual : 0;
            }
            set { TxtActual.Text = value.ToString(); }
        }

        public string Tipo
        {
            get
            {
               return TxtTipo.Text;
            }
            set { TxtTipo.Text = value; }
        }

        #endregion

        private void TxtDesde_KeyUp(object sender, KeyEventArgs e)
        {
            if (_formMode == ActionFormMode.Create)
            {
                    NroActual = NroDesde;
            }
         }

       


    }
}
