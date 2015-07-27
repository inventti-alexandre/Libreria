using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using LaPaz.Win.Enums;
using Framework.WinForm.Comun.Notification;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class FrmAgregarPago : EditFormBase
    {
        private readonly IClock _clock;
        private OrdenesPago _ordenPago;

        public event EventHandler<DetalleFormaPago> PagoAgregado;

        public FrmAgregarPago(ILaPazUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;

            InitializeComponent();

        }

        #region Propiedades

        public decimal? Importe
        {
            get
            {
                decimal importe;
                return decimal.TryParse(TxtMonto.Text, out importe) ? importe : (decimal?)null;
            }
            set
            {
                TxtMonto.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? CuentaId
        {
            get { return (int?)(((int)CbxCuentasTransferencia.Id) != 0 ? CbxCuentasTransferencia.Id : null); }
            set { CbxCuentasTransferencia.Id = value ?? 0; }
        }

        public string NumeroTransferencia
        {
            get { return TxtNumeroTransferencia.Text; }
            set { TxtNumeroTransferencia.Text = value; }
        }

        public string ChequeNumero
        {
            get { return TxtChequeNumero.Text; }
            set { TxtChequeNumero.Text = value; }
        }

        public string DepositoNumero
        {
            get { return TxtDepositoNumero.Text; }
            set { TxtDepositoNumero.Text = value; }
        }

        public int? ChequeBancoId
        {
            get { return (int?)(((int)CbxChequeBanco.SelectedValue) != 0 ? CbxChequeBanco.SelectedValue : null); }
            set { CbxChequeBanco.SelectedValue = value ?? 0; }
        }

        public int? DepositoCuentaId
        {
            get { return (int?)(((int)CbxDepositoBanco.Id) != 0 ? CbxDepositoBanco.Id : null); }
            set { CbxDepositoBanco.Id = value ?? 0; }
        }

        public DateTime? ChequeFecha
        {
            get { return DtpFecha.Value; }
            set { DtpFecha.Value = value ?? _clock.Now; }
        }

        public DateTime DepositoFecha
        {
            get { return DtpFecha.Value; }
            set { DtpFecha.Value = value; }
        }

        public OrdenesPago OrdenPago
        {
            get { return _ordenPago; }
            set { _ordenPago = value; }
        }

        #endregion

        #region Metodos

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var pago = ObtenerPagoDesdeForm();
            var esValido = this.ValidarForm();


            if (esValido)
            {
                if (Importe <= 0)
                {
                    this.FormErrorProvider.SetError(TxtMonto, "El Importe debe ser mayor a 0");
                    esValido = false;
                }
            }

            if (esValido)
            {
                OnPagoAgregado(pago);
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private DetalleFormaPago ObtenerPagoDesdeForm()
        {
            DetalleFormaPago pago = new DetalleFormaPago();

            if (TabsFormaPago.SelectedPage == this.TabEfectivo)
            {
                var pagoEfectivo = new PagoEfectivo();
                pagoEfectivo.Importe = this.Importe;
                pagoEfectivo.TipoPago = FormaPago.Efectivo;
                pagoEfectivo.Fecha = ChkCajaAnterior.Checked ? _clock.Now : DtpFecha.Value;
                pagoEfectivo.CajaAnterior = ChkCajaAnterior.Checked;
                pago = pagoEfectivo;
            }

            if (TabsFormaPago.SelectedPage == this.TabTransferencia)
            {
                var pagoTransferencia = new PagoTransferencia();
                pagoTransferencia.Importe = Importe;
                pagoTransferencia.TipoPago = FormaPago.Transferencia;
                pagoTransferencia.CuentaId = CuentaId;
                pagoTransferencia.Fecha = _clock.Now;
                pagoTransferencia.Numero = NumeroTransferencia;
                pagoTransferencia.Descripcion = CbxCuentasTransferencia.Texto + " - " + NumeroTransferencia;
                pago = pagoTransferencia;
            }

            if (TabsFormaPago.SelectedPage == this.TabCheque)
            {
                var pagoCheque = new PagoCheque();
                pagoCheque.Importe = Importe;
                pagoCheque.TipoPago = FormaPago.Cheque;
                pagoCheque.Fecha = _clock.Now;
                pagoCheque.BancoId = this.ChequeBancoId;
                pagoCheque.Numero = ChequeNumero;
                pagoCheque.Descripcion = CbxChequeBanco.Text + " - " + ChequeNumero;
                pago = pagoCheque;
            }

            if (TabsFormaPago.SelectedPage == this.TabDeposito)
            {
                var pagoDeposito = new PagoDeposito();
                pagoDeposito.Importe = Importe;
                pagoDeposito.TipoPago = FormaPago.Deposito;
                pagoDeposito.Fecha = _clock.Now;
                pagoDeposito.DepositoCuentaId = this.DepositoCuentaId;
                pagoDeposito.Numero = DepositoNumero;
                pagoDeposito.Descripcion = CbxDepositoBanco.Text + " - " + DepositoNumero;
                pago = pagoDeposito;
            }

            return pago;
        }

        protected override void ValidarControles()
        {
            //validate controles necesarios en el formulario.
            this.ValidarControl(TxtMonto, "Importe");
            this.ValidarControl(CbxCuentasTransferencia, "CuentaId");
            this.ValidarControl(CbxChequeBanco, "BancoId");
            this.ValidarControl(CbxDepositoBanco, "DepositoCuentaId");
            this.ValidarControl(TxtNumeroTransferencia, "Numero");
            this.ValidarControl(TxtChequeNumero, "Numero");
            this.ValidarControl(TxtDepositoNumero, "Numero");
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerPagoDesdeForm();
        }

        private void FrmAgregarPago_Load(object sender, EventArgs e)
        {
            DtpFecha.MinDate = _clock.Now;
            DtpFecha.Value = _clock.Now;
            CargarCombos();
            TxtMonto.Focus();
        }

        private void OnPagoAgregado(DetalleFormaPago pago)
        {
            if (PagoAgregado != null)
            {
                PagoAgregado(this, pago);
            }
        }

        private void CargarCombos()
        {
            var bancos = Uow.Bancos.Listado().OrderBy(p => p.Nombre).ToList();
            bancos.Insert(0, new Banco() { Id = 0, Nombre = "SELECCIONE BANCO" });

            CbxChequeBanco.DisplayMember = "Nombre";
            CbxChequeBanco.ValueMember = "Id";
            CbxChequeBanco.DataSource = bancos;

            CbxDepositoBanco.CargarCuenta();
            CbxCuentasTransferencia.CargarCuenta();
        }

        private void ckbCajaAnterior_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            DtpFecha.Enabled = !ChkCajaAnterior.Checked;
            LbProgramarPago.Enabled = !ChkCajaAnterior.Checked;
        }

        #endregion

        private void TxtMonto_Leave(object sender, EventArgs e)
        {

        }
    }
}
