namespace LaPaz.Win.Forms.Proveedores
{
    partial class UcFiltrosProveedores
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLimpiarFiltros = new Telerik.WinControls.UI.RadButton();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.CbxLocalidad = new Telerik.WinControls.UI.RadDropDownList();
            this.CbxProvincia = new Telerik.WinControls.UI.RadDropDownList();
            this.LbCuit = new Telerik.WinControls.UI.RadLabel();
            this.TxtDenominacion = new Telerik.WinControls.UI.RadTextBox();
            this.LbProvincia = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.LbCuenta = new Telerik.WinControls.UI.RadLabel();
            this.TxtCuit = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCuenta = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDenominacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiarFiltros
            // 
            this.BtnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarFiltros.Location = new System.Drawing.Point(5, 93);
            this.BtnLimpiarFiltros.Name = "BtnLimpiarFiltros";
            this.BtnLimpiarFiltros.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiarFiltros.TabIndex = 34;
            this.BtnLimpiarFiltros.Text = "Limpiar Filtros";
            this.BtnLimpiarFiltros.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(124, 93);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 33;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CbxLocalidad
            // 
            this.CbxLocalidad.AutoCompleteDisplayMember = "Nombre";
            this.CbxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxLocalidad.DisplayMember = "Nombre";
            this.CbxLocalidad.DropDownAnimationEnabled = true;
            this.CbxLocalidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxLocalidad.Location = new System.Drawing.Point(743, 11);
            this.CbxLocalidad.MaxDropDownItems = 0;
            this.CbxLocalidad.Name = "CbxLocalidad";
            this.CbxLocalidad.ShowImageInEditorArea = true;
            this.CbxLocalidad.Size = new System.Drawing.Size(210, 27);
            this.CbxLocalidad.TabIndex = 29;
            this.CbxLocalidad.ThemeName = "TelerikMetroBlue";
            this.CbxLocalidad.SelectedValueChanged += new System.EventHandler(this.CbxLocalidad_SelectedValueChanged);
            // 
            // CbxProvincia
            // 
            this.CbxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxProvincia.DropDownAnimationEnabled = true;
            this.CbxProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProvincia.Location = new System.Drawing.Point(435, 53);
            this.CbxProvincia.MaxDropDownItems = 0;
            this.CbxProvincia.Name = "CbxProvincia";
            this.CbxProvincia.ShowImageInEditorArea = true;
            this.CbxProvincia.Size = new System.Drawing.Size(210, 27);
            this.CbxProvincia.TabIndex = 28;
            this.CbxProvincia.ThemeName = "TelerikMetroBlue";
            this.CbxProvincia.SelectedValueChanged += new System.EventHandler(this.CbxProvincia_SelectedValueChanged);
            // 
            // LbCuit
            // 
            this.LbCuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCuit.Location = new System.Drawing.Point(5, 54);
            this.LbCuit.Name = "LbCuit";
            this.LbCuit.Size = new System.Drawing.Size(43, 24);
            this.LbCuit.TabIndex = 30;
            this.LbCuit.Text = "CUIT:";
            // 
            // TxtDenominacion
            // 
            this.TxtDenominacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDenominacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDenominacion.Location = new System.Drawing.Point(435, 12);
            this.TxtDenominacion.MaxLength = 80;
            this.TxtDenominacion.Name = "TxtDenominacion";
            this.TxtDenominacion.Size = new System.Drawing.Size(210, 26);
            this.TxtDenominacion.TabIndex = 25;
            this.TxtDenominacion.TabStop = false;
            this.TxtDenominacion.ThemeName = "TelerikMetroBlue";
            this.TxtDenominacion.TextChanged += new System.EventHandler(this.TxtDenominacion_TextChanged);
            // 
            // LbProvincia
            // 
            this.LbProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProvincia.Location = new System.Drawing.Point(319, 54);
            this.LbProvincia.Name = "LbProvincia";
            this.LbProvincia.Size = new System.Drawing.Size(73, 24);
            this.LbProvincia.TabIndex = 31;
            this.LbProvincia.Text = "Provincia:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(319, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 24);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Denominación:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel9.Location = new System.Drawing.Point(662, 15);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(76, 24);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "Localidad:";
            // 
            // LbCuenta
            // 
            this.LbCuenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCuenta.Location = new System.Drawing.Point(5, 15);
            this.LbCuenta.Name = "LbCuenta";
            this.LbCuenta.Size = new System.Drawing.Size(59, 24);
            this.LbCuenta.TabIndex = 24;
            this.LbCuenta.Text = "Cuenta:";
            // 
            // TxtCuit
            // 
            this.TxtCuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuit.Location = new System.Drawing.Point(91, 53);
            this.TxtCuit.MaxLength = 11;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(210, 26);
            this.TxtCuit.TabIndex = 27;
            this.TxtCuit.TabStop = false;
            this.TxtCuit.ThemeName = "TelerikMetroBlue";
            this.TxtCuit.TextChanged += new System.EventHandler(this.TxtCuit_TextChanged);
            // 
            // TxtCuenta
            // 
            this.TxtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCuenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuenta.Location = new System.Drawing.Point(91, 12);
            this.TxtCuenta.Name = "TxtCuenta";
            this.TxtCuenta.Size = new System.Drawing.Size(210, 26);
            this.TxtCuenta.TabIndex = 52;
            this.TxtCuenta.TabStop = false;
            this.TxtCuenta.ThemeName = "TelerikMetroBlue";
            this.TxtCuenta.TextChanged += new System.EventHandler(this.TxtCuenta_TextChanged);
            // 
            // UcFiltrosProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtCuenta);
            this.Controls.Add(this.BtnLimpiarFiltros);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LbCuenta);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.LbProvincia);
            this.Controls.Add(this.TxtDenominacion);
            this.Controls.Add(this.LbCuit);
            this.Controls.Add(this.CbxProvincia);
            this.Controls.Add(this.CbxLocalidad);
            this.Name = "UcFiltrosProveedores";
            this.Size = new System.Drawing.Size(968, 129);
            this.Load += new System.EventHandler(this.UcFiltrosProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDenominacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnLimpiarFiltros;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadDropDownList CbxLocalidad;
        private Telerik.WinControls.UI.RadDropDownList CbxProvincia;
        private Telerik.WinControls.UI.RadLabel LbCuit;
        private Telerik.WinControls.UI.RadTextBox TxtDenominacion;
        private Telerik.WinControls.UI.RadLabel LbProvincia;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel9;
        private Telerik.WinControls.UI.RadLabel LbCuenta;
        private Telerik.WinControls.UI.RadTextBox TxtCuit;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCuenta;
    }
}
