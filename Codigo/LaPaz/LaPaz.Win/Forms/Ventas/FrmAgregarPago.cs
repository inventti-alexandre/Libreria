using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;
using LaPaz.Win.Enums;
using Telerik.WinControls;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class FrmAgregarPago : EditFormBase
    {
        private readonly IClock _clock;
        private readonly ActionFormMode? _formMode;

        public FrmAgregarPago(ILaPazUow uow, IClock clock, ActionFormMode? mode)
        {
            Uow = uow;

            _clock = clock;
            _formMode = mode;
            InitializeComponent();
        }

        public event EventHandler<VentaPago> PagoAgregado;

        #region Propiedades

        public bool PermitirPagoEfectivo
        {
            set
            {
                TabEfectivo.Item.Visibility = value ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                if (TabEfectivo.Item.IsSelected)
                {
                    this.TabsFormaPago.SelectedPage = TabTarjeta;
                }
            }
        }

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

        public int? TarjetaId
        {
            get { return (int?)(((int)CbxTarjeta.SelectedValue) != 0 ? CbxTarjeta.SelectedValue : null); }
            set { CbxTarjeta.SelectedValue = value ?? 0; }
        }

        public string CuponNumero
        {
            get { return TxtCuponNumero.Text; }
            set { TxtCuponNumero.Text = value; }
        }

        public int Interes
        {
            get
            {
                int interes;
                return int.TryParse(TxtInteres.Text, out interes) ? interes : 0;
            }
            set
            {
                TxtInteres.Text = value.ToString();
            }
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
            get { return (int?)(((int)CbxDepositoBanco.SelectedValue) != 0 ? CbxDepositoBanco.SelectedValue : null); }
            set { CbxDepositoBanco.SelectedValue = value; }
        }

        public DateTime? ChequeFechaCobro
        {
            get { return DtpChequeFechaCobro.Value; }
            set { DtpChequeFechaCobro.Value = value ?? _clock.Now; }
        }

        public DateTime DepositoFecha
        {
            get { return DtpDepositoFecha.Value; }
            set { DtpDepositoFecha.Value = value; }
        }

        public int? CuentaTransferencia
        {
            get { return (int?)(((int)CbxCuentasTransferencia.Id) != 0 ? CbxCuentasTransferencia.Id : null); }
            set { CbxCuentasTransferencia.Id = value ?? 0; }
        }

        public string NumeroTransferencia
        {
            get { return TxtNumeroTransferencia.Text; }
            set { TxtNumeroTransferencia.Text = value; }
        }

        public DateTime TransferenciaFecha
        {
            get { return DtpTransferencia.Value; }
            set { DtpTransferencia.Value = value; }
        }

        #endregion

        #region Metodos

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            VentaPago pago = ObtenerPago();

            var esValido = this.ValidarForm();

            if (esValido)
            {
                OnPagoAgregado(pago);
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerPago();
        }

        protected override void ValidarControles()
        {
            //validate controles necesarios en el formulario.
            this.ValidarControl(TxtMonto, "Importe");
            this.ValidarControl(CbxTarjeta, "TarjetaId");
            this.ValidarControl(CbxChequeBanco, "BancoId");
            this.ValidarControl(CbxDepositoBanco, "BancoId");
            this.ValidarControl(TxtCuponNumero, "Numero");
            this.ValidarControl(TxtChequeNumero, "Numero");
            this.ValidarControl(TxtDepositoNumero, "Numero");
            this.ValidarControl(CbxDepositoBanco, "CuentaId");
        }

        private VentaPago ObtenerPago()
        {
            VentaPago ventaPago = new VentaPago();

            if (TabsFormaPago.SelectedPage == this.TabEfectivo)
            {
                ventaPago.Importe = this.Importe;
                if (ChkCajaAnterior.Checked)
                {
                    ventaPago.TipoPago = FormaPago.EfectivoCajaAnterior;
                    ventaPago.Descripcion = "Caja Anterior";
                }
                else
                    ventaPago.TipoPago = FormaPago.Efectivo;

            }

            if (TabsFormaPago.SelectedPage == this.TabTarjeta)
            {
                var ventaPagoTarjeta = new VentaPagoTarjeta();
                ventaPagoTarjeta.Interes = Interes;
                //ventaPagoTarjeta.Importe = Importe;
                var interes = Importe * Interes/100;
                ventaPagoTarjeta.Intereses = interes;
                ventaPagoTarjeta.Importe = Importe + interes;
                ventaPagoTarjeta.TipoPago = FormaPago.Tarjeta;
                ventaPagoTarjeta.TarjetaId = TarjetaId;
                ventaPagoTarjeta.CuponNumero = CuponNumero;
                ventaPagoTarjeta.Descripcion = CbxTarjeta.Text + " - " + CuponNumero;
                
                ventaPago = ventaPagoTarjeta;
            }

            if (TabsFormaPago.SelectedPage == this.TabCheque)
            {
                var ventaPagoCheque = new VentaPagoCheque();
                ventaPagoCheque.Importe = Importe;
                ventaPagoCheque.TipoPago = FormaPago.Cheque;
                ventaPagoCheque.FechaCobro = this.ChequeFechaCobro;
                ventaPagoCheque.BancoId = this.ChequeBancoId;
                ventaPagoCheque.Numero = ChequeNumero;
                ventaPagoCheque.Descripcion = CbxChequeBanco.Text + " - " + ChequeNumero;
                ventaPago = ventaPagoCheque;
            }

            if (TabsFormaPago.SelectedPage == this.TabDeposito)
            {
                VentaPagoDeposito ventaPagoDeposito = new VentaPagoDeposito();
                ventaPagoDeposito.Importe = Importe;
                ventaPagoDeposito.TipoPago = FormaPago.Deposito;
                ventaPagoDeposito.Fecha = DepositoFecha;
                ventaPagoDeposito.CuentaId = DepositoCuentaId;
                ventaPagoDeposito.Numero = DepositoNumero;
                ventaPagoDeposito.Descripcion = CbxDepositoBanco.Text + " - " + DepositoNumero;
                ventaPago = ventaPagoDeposito;
            }
            if (TabsFormaPago.SelectedPage == this.TabTransferencia)
            {
                VentaPagoTransferencia ventaPagoTransferencia = new VentaPagoTransferencia();
                ventaPagoTransferencia.Importe = Importe;
                ventaPagoTransferencia.TipoPago = FormaPago.Transferencia;
                ventaPagoTransferencia.Fecha = TransferenciaFecha;
                ventaPagoTransferencia.CuentaId = CuentaTransferencia;
                ventaPagoTransferencia.Numero = NumeroTransferencia;
                ventaPagoTransferencia.Descripcion = CbxCuentasTransferencia.Texto;
                ventaPago = ventaPagoTransferencia;
            }

            return ventaPago;
        }

        private void OnPagoAgregado(VentaPago pago)
        {
            if (PagoAgregado != null)
            {
                PagoAgregado(this, pago);
            }
        }

        private void FrmAgregarPago_Load(object sender, EventArgs e)
        {
            if (_formMode == ActionFormMode.Create)
            {
                //Ventas, no se muestra transferencia ni pago con caja anterior

                PnlPagoAnterior.Visible = false;
                ChkCajaAnterior.Checked = false;
                TabsFormaPago.Pages.ElementAt(4).Enabled = false;
            }
            else if ((_formMode == ActionFormMode.Edit))
            {
                //Compras y señas a proveedores, se muestra transferencia

                PnlPagoAnterior.Visible = true;
                ChkCajaAnterior.Checked = false;
                //TabsFormaPago.Pages.ElementAt(1).Enabled = false;

            }
            CargarCombos();

            ChequeFechaCobro = _clock.Now;
            DepositoFecha = _clock.Now;
            TransferenciaFecha = _clock.Now;

            TxtMonto.Focus();
        }

        private void CargarCombos()
        {
            var bancos = Uow.Bancos.Listado().OrderBy(p => p.Nombre).ToList();
            bancos.Insert(0, new Banco() { Id = 0, Nombre = "SELECCIONE BANCO" });

            CbxChequeBanco.DisplayMember = "Nombre";
            CbxChequeBanco.ValueMember = "Id";
            CbxChequeBanco.DataSource = bancos;

            var cuentas = Uow.Cuentas.Listado().Where(c => c.Activo).OrderBy(c => c.Nombre).ToList();
            cuentas.Insert(0, new Cuenta() { Id = 0, Nombre = "SELECCIONE CUENTA" });
            CbxDepositoBanco.DisplayMember = "Nombre";
            CbxDepositoBanco.ValueMember = "Id";
            CbxDepositoBanco.DataSource = cuentas;

            var tarjetas = Uow.Tarjetas.Listado().OrderBy(p => p.Nombre).ToList();
            tarjetas.Insert(0, new Tarjeta() { Id = 0, Nombre = "SELECCIONE TARJETA" });

            CbxTarjeta.DisplayMember = "Nombre";
            CbxTarjeta.ValueMember = "Id";
            CbxTarjeta.DataSource = tarjetas;
        }

        #endregion

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {
            TxtSubTotal.Text = (Importe + (Importe*Interes/100)).ToString();
        }

        private void TxtInteres_TextChanged(object sender, EventArgs e)
        {
            TxtSubTotal.Text = (Importe + (Importe * Interes / 100)).ToString();
        }
    }
}
