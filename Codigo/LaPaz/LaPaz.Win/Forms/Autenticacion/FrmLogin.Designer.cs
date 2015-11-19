namespace LaPaz.Win.Forms.Autenticacion
{
    partial class FrmLogin
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
                _authenticationService.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnIngresar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.UcSucursales = new LaPaz.Win.Forms.Util.UcFiltroSucursal();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CbxUsuario = new LaPaz.Win.Forms.Util.UcUsuariosLogin();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaPaz.Win.Properties.Resources.Login_01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(139, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 24);
            this.metroLabel1.TabIndex = 82;
            this.metroLabel1.Text = "Usuario:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(207, 50);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(220, 26);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(139, 52);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 24);
            this.radLabel1.TabIndex = 84;
            this.radLabel1.Text = "Clave:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnIngresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(210, 130);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(100, 30);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.ThemeName = "TelerikMetroBlue";
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(323, 130);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // UcSucursales
            // 
            this.UcSucursales.Location = new System.Drawing.Point(207, 86);
            this.UcSucursales.Name = "UcSucursales";
            this.UcSucursales.Size = new System.Drawing.Size(220, 27);
            this.UcSucursales.SucursalId = null;
            this.UcSucursales.TabIndex = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(139, 89);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(67, 24);
            this.radLabel2.TabIndex = 85;
            this.radLabel2.Text = "Sucursal:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.Location = new System.Drawing.Point(207, 14);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.OperadorId = null;
            this.CbxUsuario.Size = new System.Drawing.Size(220, 27);
            this.CbxUsuario.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(457, 171);
            this.Controls.Add(this.CbxUsuario);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.UcSucursales);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtPassword;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton BtnIngresar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Util.UcFiltroSucursal UcSucursales;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Util.UcUsuariosLogin CbxUsuario;
    }
}