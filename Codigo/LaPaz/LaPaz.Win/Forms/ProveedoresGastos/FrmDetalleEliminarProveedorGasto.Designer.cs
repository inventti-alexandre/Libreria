namespace LaPaz.Win.Forms.ProveedoresGastos
{
    partial class FrmDetalleEliminarProveedorGasto
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
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnEliminar = new Telerik.WinControls.UI.RadButton();
            this.TxtLocalidad = new Telerik.WinControls.UI.RadTextBox();
            this.TxtProvincia = new Telerik.WinControls.UI.RadTextBox();
            this.TxtTipoDocumento = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCuit = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.TxtContacto = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCelular = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTelefono = new Telerik.WinControls.UI.RadTextBox();
            this.TxtDenominacion = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDomicilio = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDenominacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(729, 213);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(623, 213);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 26;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.ThemeName = "TelerikMetroBlue";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtLocalidad
            // 
            this.TxtLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLocalidad.Enabled = false;
            this.TxtLocalidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocalidad.Location = new System.Drawing.Point(552, 149);
            this.TxtLocalidad.MaxLength = 100;
            this.TxtLocalidad.Name = "TxtLocalidad";
            this.TxtLocalidad.Size = new System.Drawing.Size(277, 26);
            this.TxtLocalidad.TabIndex = 78;
            this.TxtLocalidad.TabStop = false;
            this.TxtLocalidad.ThemeName = "TelerikMetroBlue";
            // 
            // TxtProvincia
            // 
            this.TxtProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProvincia.Enabled = false;
            this.TxtProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProvincia.Location = new System.Drawing.Point(552, 110);
            this.TxtProvincia.MaxLength = 100;
            this.TxtProvincia.Name = "TxtProvincia";
            this.TxtProvincia.Size = new System.Drawing.Size(277, 26);
            this.TxtProvincia.TabIndex = 79;
            this.TxtProvincia.TabStop = false;
            this.TxtProvincia.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTipoDocumento
            // 
            this.TxtTipoDocumento.Enabled = false;
            this.TxtTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoDocumento.Location = new System.Drawing.Point(552, 67);
            this.TxtTipoDocumento.MaxLength = 11;
            this.TxtTipoDocumento.Name = "TxtTipoDocumento";
            this.TxtTipoDocumento.Size = new System.Drawing.Size(75, 26);
            this.TxtTipoDocumento.TabIndex = 83;
            this.TxtTipoDocumento.TabStop = false;
            this.TxtTipoDocumento.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCuit
            // 
            this.TxtCuit.Enabled = false;
            this.TxtCuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuit.Location = new System.Drawing.Point(633, 67);
            this.TxtCuit.MaxLength = 11;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(194, 26);
            this.TxtCuit.TabIndex = 82;
            this.TxtCuit.TabStop = false;
            this.TxtCuit.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(441, 68);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 24);
            this.metroLabel7.TabIndex = 89;
            this.metroLabel7.Text = "Tipo Doc:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // TxtContacto
            // 
            this.TxtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtContacto.Enabled = false;
            this.TxtContacto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContacto.Location = new System.Drawing.Point(550, 25);
            this.TxtContacto.MaxLength = 50;
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(277, 26);
            this.TxtContacto.TabIndex = 81;
            this.TxtContacto.TabStop = false;
            this.TxtContacto.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel8.Location = new System.Drawing.Point(441, 110);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(73, 24);
            this.metroLabel8.TabIndex = 90;
            this.metroLabel8.Text = "Provincia:";
            this.metroLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(441, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 24);
            this.metroLabel6.TabIndex = 88;
            this.metroLabel6.Text = "Contacto:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Enabled = false;
            this.TxtCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(140, 152);
            this.TxtCelular.MaxLength = 20;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(277, 26);
            this.TxtCelular.TabIndex = 80;
            this.TxtCelular.TabStop = false;
            this.TxtCelular.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel9.Location = new System.Drawing.Point(441, 152);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(76, 24);
            this.metroLabel9.TabIndex = 91;
            this.metroLabel9.Text = "Localidad:";
            this.metroLabel9.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(31, 153);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 24);
            this.metroLabel5.TabIndex = 87;
            this.metroLabel5.Text = "Celular:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(31, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 24);
            this.metroLabel2.TabIndex = 84;
            this.metroLabel2.Text = "Denominación:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Enabled = false;
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(140, 110);
            this.TxtTelefono.MaxLength = 40;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(277, 26);
            this.TxtTelefono.TabIndex = 77;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.ThemeName = "TelerikMetroBlue";
            // 
            // TxtDenominacion
            // 
            this.TxtDenominacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDenominacion.Enabled = false;
            this.TxtDenominacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDenominacion.Location = new System.Drawing.Point(140, 26);
            this.TxtDenominacion.MaxLength = 80;
            this.TxtDenominacion.Name = "TxtDenominacion";
            this.TxtDenominacion.Size = new System.Drawing.Size(277, 26);
            this.TxtDenominacion.TabIndex = 75;
            this.TxtDenominacion.TabStop = false;
            this.TxtDenominacion.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(31, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 24);
            this.metroLabel4.TabIndex = 86;
            this.metroLabel4.Text = "Teléfono:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(31, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 24);
            this.metroLabel3.TabIndex = 85;
            this.metroLabel3.Text = "Domicilio:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDomicilio.Enabled = false;
            this.TxtDomicilio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilio.Location = new System.Drawing.Point(140, 68);
            this.TxtDomicilio.MaxLength = 100;
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(277, 26);
            this.TxtDomicilio.TabIndex = 76;
            this.TxtDomicilio.TabStop = false;
            this.TxtDomicilio.ThemeName = "TelerikMetroBlue";
            // 
            // FrmDetalleEliminarProveedorGasto
            // 
            this.AcceptButton = this.BtnEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(865, 267);
            this.Controls.Add(this.TxtLocalidad);
            this.Controls.Add(this.TxtProvincia);
            this.Controls.Add(this.TxtTipoDocumento);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.TxtContacto);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDenominacion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalleEliminarProveedorGasto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FrmDetalleEliminarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDenominacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadButton BtnEliminar;
        private Telerik.WinControls.UI.RadTextBox TxtLocalidad;
        private Telerik.WinControls.UI.RadTextBox TxtProvincia;
        private Telerik.WinControls.UI.RadTextBox TxtTipoDocumento;
        private Telerik.WinControls.UI.RadTextBox TxtCuit;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadTextBox TxtContacto;
        private Telerik.WinControls.UI.RadLabel metroLabel8;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadTextBox TxtCelular;
        private Telerik.WinControls.UI.RadLabel metroLabel9;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtTelefono;
        private Telerik.WinControls.UI.RadTextBox TxtDenominacion;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtDomicilio;
    }
}