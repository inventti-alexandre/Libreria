namespace LaPaz.Win.Forms.OrdenesPagos
{
    partial class FrmAgregarPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnAgregar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.CbxChequeBanco = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtMonto = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TabsFormaPago = new Telerik.WinControls.UI.RadPageView();
            this.TabEfectivo = new Telerik.WinControls.UI.RadPageViewPage();
            this.PnlPagoAnterior = new Telerik.WinControls.UI.RadPanel();
            this.ChkCajaAnterior = new Telerik.WinControls.UI.RadCheckBox();
            this.LbProgramarPago = new Telerik.WinControls.UI.RadLabel();
            this.DtpFecha = new Telerik.WinControls.UI.RadDateTimePicker();
            this.TabTransferencia = new Telerik.WinControls.UI.RadPageViewPage();
            this.TxtNumeroTransferencia = new Telerik.WinControls.UI.RadTextBox();
            this.CbxCuentasTransferencia = new LaPaz.Win.Forms.Util.UcFiltroCuentas();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TabDeposito = new Telerik.WinControls.UI.RadPageViewPage();
            this.CbxDepositoBanco = new LaPaz.Win.Forms.Util.UcFiltroCuentas();
            this.TxtDepositoNumero = new Telerik.WinControls.UI.RadTextBox();
            this.TabCheque = new Telerik.WinControls.UI.RadPageViewPage();
            this.TxtChequeNumero = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxChequeBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabsFormaPago)).BeginInit();
            this.TabsFormaPago.SuspendLayout();
            this.TabEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPagoAnterior)).BeginInit();
            this.PnlPagoAnterior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCajaAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbProgramarPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha)).BeginInit();
            this.TabTransferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.TabDeposito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepositoNumero)).BeginInit();
            this.TabCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChequeNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(174, 212);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 30);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.ThemeName = "TelerikMetroBlue";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(280, 212);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(3, 21);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 24);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Banco:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // CbxChequeBanco
            // 
            this.CbxChequeBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxChequeBanco.DropDownAnimationEnabled = true;
            this.CbxChequeBanco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxChequeBanco.Location = new System.Drawing.Point(69, 21);
            this.CbxChequeBanco.MaxDropDownItems = 0;
            this.CbxChequeBanco.Name = "CbxChequeBanco";
            this.CbxChequeBanco.ShowImageInEditorArea = true;
            this.CbxChequeBanco.Size = new System.Drawing.Size(252, 27);
            this.CbxChequeBanco.TabIndex = 4;
            this.CbxChequeBanco.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(2, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 24);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Número:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(3, 20);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 24);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Cuenta:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel9.Location = new System.Drawing.Point(3, 65);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 24);
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Número:";
            this.metroLabel9.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(12, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 24);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Monto:";
            // 
            // TxtMonto
            // 
            this.TxtMonto.AceptaNegativos = false;
            this.TxtMonto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(69, 23);
            this.TxtMonto.MaxLength = 10;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(203, 26);
            this.TxtMonto.TabIndex = 1;
            this.TxtMonto.TabStop = false;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMonto.ThemeName = "TelerikMetroBlue";
            this.TxtMonto.Leave += new System.EventHandler(this.TxtMonto_Leave);
            // 
            // TabsFormaPago
            // 
            this.TabsFormaPago.Controls.Add(this.TabEfectivo);
            this.TabsFormaPago.Controls.Add(this.TabTransferencia);
            this.TabsFormaPago.Controls.Add(this.TabDeposito);
            this.TabsFormaPago.Controls.Add(this.TabCheque);
            this.TabsFormaPago.Location = new System.Drawing.Point(12, 65);
            this.TabsFormaPago.Name = "TabsFormaPago";
            this.TabsFormaPago.SelectedPage = this.TabTransferencia;
            this.TabsFormaPago.Size = new System.Drawing.Size(368, 134);
            this.TabsFormaPago.TabIndex = 35;
            this.TabsFormaPago.Text = "radPageView1";
            this.TabsFormaPago.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.TabsFormaPago.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // TabEfectivo
            // 
            this.TabEfectivo.Controls.Add(this.PnlPagoAnterior);
            this.TabEfectivo.Controls.Add(this.LbProgramarPago);
            this.TabEfectivo.Controls.Add(this.DtpFecha);
            this.TabEfectivo.Location = new System.Drawing.Point(5, 31);
            this.TabEfectivo.Name = "TabEfectivo";
            this.TabEfectivo.Size = new System.Drawing.Size(358, 98);
            this.TabEfectivo.Text = "Efectivo";
            // 
            // PnlPagoAnterior
            // 
            this.PnlPagoAnterior.Controls.Add(this.ChkCajaAnterior);
            this.PnlPagoAnterior.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlPagoAnterior.Location = new System.Drawing.Point(3, 60);
            this.PnlPagoAnterior.Name = "PnlPagoAnterior";
            this.PnlPagoAnterior.Size = new System.Drawing.Size(211, 35);
            this.PnlPagoAnterior.TabIndex = 39;
            // 
            // ChkCajaAnterior
            // 
            this.ChkCajaAnterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChkCajaAnterior.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCajaAnterior.Location = new System.Drawing.Point(7, 6);
            this.ChkCajaAnterior.Name = "ChkCajaAnterior";
            this.ChkCajaAnterior.Size = new System.Drawing.Size(195, 24);
            this.ChkCajaAnterior.TabIndex = 0;
            this.ChkCajaAnterior.Text = "Efectivo con caja anterior";
            this.ChkCajaAnterior.ThemeName = "TelerikMetroBlue";
            this.ChkCajaAnterior.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckbCajaAnterior_ToggleStateChanged);
            // 
            // LbProgramarPago
            // 
            this.LbProgramarPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProgramarPago.Location = new System.Drawing.Point(3, 14);
            this.LbProgramarPago.Name = "LbProgramarPago";
            this.LbProgramarPago.Size = new System.Drawing.Size(117, 24);
            this.LbProgramarPago.TabIndex = 37;
            this.LbProgramarPago.Text = "Programar para:";
            this.LbProgramarPago.ThemeName = "TelerikMetroBlue";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(126, 14);
            this.DtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFecha.MinDate = new System.DateTime(((long)(0)));
            this.DtpFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.NullableValue = null;
            this.DtpFecha.NullDate = new System.DateTime(((long)(0)));
            // 
            // 
            // 
            this.DtpFecha.RootElement.MinSize = new System.Drawing.Size(0, 29);
            this.DtpFecha.Size = new System.Drawing.Size(100, 29);
            this.DtpFecha.TabIndex = 36;
            this.DtpFecha.TabStop = false;
            this.DtpFecha.ThemeName = "TelerikMetroBlue";
            this.DtpFecha.Value = new System.DateTime(((long)(0)));
            // 
            // TabTransferencia
            // 
            this.TabTransferencia.Controls.Add(this.TxtNumeroTransferencia);
            this.TabTransferencia.Controls.Add(this.CbxCuentasTransferencia);
            this.TabTransferencia.Controls.Add(this.radLabel2);
            this.TabTransferencia.Controls.Add(this.radLabel5);
            this.TabTransferencia.Location = new System.Drawing.Point(5, 31);
            this.TabTransferencia.Name = "TabTransferencia";
            this.TabTransferencia.Size = new System.Drawing.Size(358, 98);
            this.TabTransferencia.Text = "Transferencia";
            // 
            // TxtNumeroTransferencia
            // 
            this.TxtNumeroTransferencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroTransferencia.Location = new System.Drawing.Point(70, 60);
            this.TxtNumeroTransferencia.MaxLength = 30;
            this.TxtNumeroTransferencia.Name = "TxtNumeroTransferencia";
            this.TxtNumeroTransferencia.Size = new System.Drawing.Size(252, 26);
            this.TxtNumeroTransferencia.TabIndex = 111;
            this.TxtNumeroTransferencia.TabStop = false;
            this.TxtNumeroTransferencia.ThemeName = "TelerikMetroBlue";
            // 
            // CbxCuentasTransferencia
            // 
            this.CbxCuentasTransferencia.Id = null;
            this.CbxCuentasTransferencia.Location = new System.Drawing.Point(70, 18);
            this.CbxCuentasTransferencia.Name = "CbxCuentasTransferencia";
            this.CbxCuentasTransferencia.Size = new System.Drawing.Size(252, 27);
            this.CbxCuentasTransferencia.TabIndex = 105;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(3, 19);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(59, 24);
            this.radLabel2.TabIndex = 110;
            this.radLabel2.Text = "Cuenta:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(3, 61);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(67, 24);
            this.radLabel5.TabIndex = 108;
            this.radLabel5.Text = "Número:";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // TabDeposito
            // 
            this.TabDeposito.Controls.Add(this.CbxDepositoBanco);
            this.TabDeposito.Controls.Add(this.TxtDepositoNumero);
            this.TabDeposito.Controls.Add(this.metroLabel7);
            this.TabDeposito.Controls.Add(this.metroLabel9);
            this.TabDeposito.Location = new System.Drawing.Point(5, 31);
            this.TabDeposito.Name = "TabDeposito";
            this.TabDeposito.Size = new System.Drawing.Size(358, 98);
            this.TabDeposito.Text = "Depósito";
            // 
            // CbxDepositoBanco
            // 
            this.CbxDepositoBanco.Id = null;
            this.CbxDepositoBanco.Location = new System.Drawing.Point(70, 19);
            this.CbxDepositoBanco.Name = "CbxDepositoBanco";
            this.CbxDepositoBanco.Size = new System.Drawing.Size(252, 27);
            this.CbxDepositoBanco.TabIndex = 106;
            // 
            // TxtDepositoNumero
            // 
            this.TxtDepositoNumero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepositoNumero.Location = new System.Drawing.Point(70, 64);
            this.TxtDepositoNumero.MaxLength = 30;
            this.TxtDepositoNumero.Name = "TxtDepositoNumero";
            this.TxtDepositoNumero.Size = new System.Drawing.Size(252, 26);
            this.TxtDepositoNumero.TabIndex = 35;
            this.TxtDepositoNumero.TabStop = false;
            this.TxtDepositoNumero.ThemeName = "TelerikMetroBlue";
            // 
            // TabCheque
            // 
            this.TabCheque.Controls.Add(this.TxtChequeNumero);
            this.TabCheque.Controls.Add(this.metroLabel6);
            this.TabCheque.Controls.Add(this.CbxChequeBanco);
            this.TabCheque.Controls.Add(this.metroLabel4);
            this.TabCheque.Location = new System.Drawing.Point(5, 31);
            this.TabCheque.Name = "TabCheque";
            this.TabCheque.Size = new System.Drawing.Size(358, 98);
            this.TabCheque.Text = "Cheque";
            // 
            // TxtChequeNumero
            // 
            this.TxtChequeNumero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChequeNumero.Location = new System.Drawing.Point(69, 65);
            this.TxtChequeNumero.MaxLength = 30;
            this.TxtChequeNumero.Name = "TxtChequeNumero";
            this.TxtChequeNumero.Size = new System.Drawing.Size(252, 26);
            this.TxtChequeNumero.TabIndex = 29;
            this.TxtChequeNumero.TabStop = false;
            this.TxtChequeNumero.ThemeName = "TelerikMetroBlue";
            // 
            // FrmAgregarPago
            // 
            this.ClientSize = new System.Drawing.Size(390, 248);
            this.Controls.Add(this.TabsFormaPago);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarPago";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Pago";
            this.Load += new System.EventHandler(this.FrmAgregarPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxChequeBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabsFormaPago)).EndInit();
            this.TabsFormaPago.ResumeLayout(false);
            this.TabEfectivo.ResumeLayout(false);
            this.TabEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPagoAnterior)).EndInit();
            this.PnlPagoAnterior.ResumeLayout(false);
            this.PnlPagoAnterior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCajaAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbProgramarPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha)).EndInit();
            this.TabTransferencia.ResumeLayout(false);
            this.TabTransferencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.TabDeposito.ResumeLayout(false);
            this.TabDeposito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepositoNumero)).EndInit();
            this.TabCheque.ResumeLayout(false);
            this.TabCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChequeNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnAgregar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadDropDownList CbxChequeBanco;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadLabel metroLabel9;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtMonto;
        private Telerik.WinControls.UI.RadPageView TabsFormaPago;
        private Telerik.WinControls.UI.RadPageViewPage TabEfectivo;
        private Telerik.WinControls.UI.RadPageViewPage TabCheque;
        private Telerik.WinControls.UI.RadPageViewPage TabDeposito;
        private Telerik.WinControls.UI.RadPageViewPage TabTransferencia;
        private Util.UcFiltroCuentas CbxCuentasTransferencia;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel LbProgramarPago;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFecha;
        private Telerik.WinControls.UI.RadTextBox TxtNumeroTransferencia;
        private Telerik.WinControls.UI.RadTextBox TxtDepositoNumero;
        private Telerik.WinControls.UI.RadTextBox TxtChequeNumero;
        private Util.UcFiltroCuentas CbxDepositoBanco;
        private Telerik.WinControls.UI.RadPanel PnlPagoAnterior;
        private Telerik.WinControls.UI.RadCheckBox ChkCajaAnterior;
    }
}