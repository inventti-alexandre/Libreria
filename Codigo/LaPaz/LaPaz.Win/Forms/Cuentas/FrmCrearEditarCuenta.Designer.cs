using System.Windows.Forms;

namespace LaPaz.Win.Forms.Cuentas
{
    partial class FrmCrearEditarCuenta
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
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CbxBancoPropio = new LaPaz.Win.Forms.Util.UcFiltroBancoPropio();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.DtpFechaApertura = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTitular = new Telerik.WinControls.UI.RadTextBox();
            this.CbxTipoCuenta = new LaPaz.Win.Forms.Util.UcFiltroTipoCuenta();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaApertura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(332, 334);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(438, 334);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(148, 26);
            this.TxtNombre.MaxLength = 30;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(350, 26);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(12, 27);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 24);
            this.metroLabel3.TabIndex = 68;
            this.metroLabel3.Text = "Nombre:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 69);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(90, 24);
            this.radLabel1.TabIndex = 70;
            this.radLabel1.Text = "Descripción:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(148, 68);
            this.TxtDescripcion.MaxLength = 50;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(350, 26);
            this.TxtDescripcion.TabIndex = 2;
            this.TxtDescripcion.TabStop = false;
            this.TxtDescripcion.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 111);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(52, 24);
            this.radLabel2.TabIndex = 71;
            this.radLabel2.Text = "Banco:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // CbxBancoPropio
            // 
            this.CbxBancoPropio.Id = null;
            this.CbxBancoPropio.Location = new System.Drawing.Point(148, 110);
            this.CbxBancoPropio.Name = "CbxBancoPropio";
            this.CbxBancoPropio.Size = new System.Drawing.Size(277, 27);
            this.CbxBancoPropio.TabIndex = 3;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(12, 237);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(136, 24);
            this.radLabel4.TabIndex = 72;
            this.radLabel4.Text = "Fecha de Apertura:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // DtpFechaApertura
            // 
            this.DtpFechaApertura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaApertura.Location = new System.Drawing.Point(148, 235);
            this.DtpFechaApertura.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaApertura.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaApertura.Name = "DtpFechaApertura";
            this.DtpFechaApertura.NullableValue = new System.DateTime(2015, 1, 24, 11, 29, 42, 746);
            this.DtpFechaApertura.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaApertura.Size = new System.Drawing.Size(102, 29);
            this.DtpFechaApertura.TabIndex = 6;
            this.DtpFechaApertura.TabStop = false;
            this.DtpFechaApertura.Text = "24/01/2015";
            this.DtpFechaApertura.ThemeName = "TelerikMetroBlue";
            this.DtpFechaApertura.Value = new System.DateTime(2015, 1, 24, 11, 29, 42, 746);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(12, 195);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(54, 24);
            this.radLabel5.TabIndex = 77;
            this.radLabel5.Text = "Titular:";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTitular
            // 
            this.TxtTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTitular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitular.Location = new System.Drawing.Point(148, 194);
            this.TxtTitular.MaxLength = 50;
            this.TxtTitular.Name = "TxtTitular";
            this.TxtTitular.Size = new System.Drawing.Size(350, 26);
            this.TxtTitular.TabIndex = 5;
            this.TxtTitular.TabStop = false;
            this.TxtTitular.ThemeName = "TelerikMetroBlue";
            // 
            // CbxTipoCuenta
            // 
            this.CbxTipoCuenta.Location = new System.Drawing.Point(148, 152);
            this.CbxTipoCuenta.Name = "CbxTipoCuenta";
            this.CbxTipoCuenta.Size = new System.Drawing.Size(277, 27);
            this.CbxTipoCuenta.TabIndex = 4;
            this.CbxTipoCuenta.TipoCuentaId = null;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(12, 153);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(115, 24);
            this.radLabel6.TabIndex = 72;
            this.radLabel6.Text = "Tipo de Cuenta:";
            this.radLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCrearEditarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(550, 376);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.CbxTipoCuenta);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.TxtTitular);
            this.Controls.Add(this.DtpFechaApertura);
            this.Controls.Add(this.CbxBancoPropio);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearEditarCuenta";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Agregar Nueva Cuenta";
            this.Load += new System.EventHandler(this.FrmCrearEditarAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaApertura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtDescripcion;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Util.UcFiltroBancoPropio CbxBancoPropio;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaApertura;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox TxtTitular;
        private Util.UcFiltroTipoCuenta CbxTipoCuenta;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}