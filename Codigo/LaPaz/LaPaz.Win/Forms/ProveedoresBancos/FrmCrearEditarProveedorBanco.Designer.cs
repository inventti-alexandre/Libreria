using System.Windows.Forms;

namespace LaPaz.Win.Forms.ProveedoresBancos
{
    partial class FrmCrearEditarProveedorBanco
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
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.EpvProveedorBanco = new System.Windows.Forms.ErrorProvider(this.components);
            this.CbxBanco = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCuentaCorriente = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.metroLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCajaAhorro = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtCbu = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtTitular = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvProveedorBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuentaCorriente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCajaAhorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(774, 139);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(661, 139);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // EpvProveedorBanco
            // 
            this.EpvProveedorBanco.ContainerControl = this;
            // 
            // CbxBanco
            // 
            this.CbxBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxBanco.DropDownAnimationEnabled = true;
            this.CbxBanco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.CbxBanco.Location = new System.Drawing.Point(147, 18);
            this.CbxBanco.MaxDropDownItems = 15;
            this.CbxBanco.Name = "CbxBanco";
            this.CbxBanco.ShowImageInEditorArea = true;
            this.CbxBanco.Size = new System.Drawing.Size(277, 27);
            this.CbxBanco.TabIndex = 1;
            this.CbxBanco.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel8.Location = new System.Drawing.Point(24, 104);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 24);
            this.metroLabel8.TabIndex = 86;
            this.metroLabel8.Text = "C.B.U.:";
            this.metroLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(461, 58);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(127, 24);
            this.metroLabel7.TabIndex = 85;
            this.metroLabel7.Text = "Cuenta Corriente:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(24, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 24);
            this.metroLabel1.TabIndex = 80;
            this.metroLabel1.Text = "Banco:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCuentaCorriente
            // 
            this.TxtCuentaCorriente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCuentaCorriente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuentaCorriente.Location = new System.Drawing.Point(598, 58);
            this.TxtCuentaCorriente.MaxLength = 20;
            this.TxtCuentaCorriente.Name = "TxtCuentaCorriente";
            this.TxtCuentaCorriente.Size = new System.Drawing.Size(277, 26);
            this.TxtCuentaCorriente.TabIndex = 5;
            this.TxtCuentaCorriente.TabStop = false;
            this.TxtCuentaCorriente.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel12.Location = new System.Drawing.Point(24, 60);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(113, 24);
            this.metroLabel12.TabIndex = 90;
            this.metroLabel12.Text = "Caja de Ahorro:";
            this.metroLabel12.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCajaAhorro
            // 
            this.TxtCajaAhorro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCajaAhorro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCajaAhorro.Location = new System.Drawing.Point(147, 60);
            this.TxtCajaAhorro.MaxLength = 20;
            this.TxtCajaAhorro.Name = "TxtCajaAhorro";
            this.TxtCajaAhorro.Size = new System.Drawing.Size(277, 26);
            this.TxtCajaAhorro.TabIndex = 2;
            this.TxtCajaAhorro.TabStop = false;
            this.TxtCajaAhorro.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCbu
            // 
            this.TxtCbu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCbu.Location = new System.Drawing.Point(147, 102);
            this.TxtCbu.MaxLength = 22;
            this.TxtCbu.Name = "TxtCbu";
            this.TxtCbu.Size = new System.Drawing.Size(277, 26);
            this.TxtCbu.TabIndex = 3;
            this.TxtCbu.TabStop = false;
            this.TxtCbu.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTitular
            // 
            this.TxtTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTitular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitular.Location = new System.Drawing.Point(598, 16);
            this.TxtTitular.MaxLength = 50;
            this.TxtTitular.Name = "TxtTitular";
            this.TxtTitular.Size = new System.Drawing.Size(277, 26);
            this.TxtTitular.TabIndex = 4;
            this.TxtTitular.TabStop = false;
            this.TxtTitular.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(461, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 24);
            this.radLabel1.TabIndex = 97;
            this.radLabel1.Text = "Titular:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCrearEditarProveedorBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 193);
            this.Controls.Add(this.TxtTitular);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtCbu);
            this.Controls.Add(this.TxtCajaAhorro);
            this.Controls.Add(this.TxtCuentaCorriente);
            this.Controls.Add(this.CbxBanco);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.MaximizeBox = false;
            this.Name = "FrmCrearEditarProveedorBanco";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Proveedor Banco";
            this.Load += new System.EventHandler(this.FrmCrearProveedorBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvProveedorBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuentaCorriente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCajaAhorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCbu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private ErrorProvider EpvProveedorBanco;
        private Telerik.WinControls.UI.RadDropDownList CbxBanco;
        private Telerik.WinControls.UI.RadLabel metroLabel8;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCbu;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCajaAhorro;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCuentaCorriente;
        private Telerik.WinControls.UI.RadLabel metroLabel12;
        private Telerik.WinControls.UI.RadTextBox TxtTitular;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}