namespace LaPaz.Win.Forms.Ventas
{
    partial class UcFiltrosVentas
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
            this.TxtTexto = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.LbCuenta = new Telerik.WinControls.UI.RadLabel();
            this.TxtNumeroComprobante = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.UcFiltroLetraComprobante = new LaPaz.Win.Forms.Util.UcFiltroLetraComprobante();
            this.UcFiltroTiposComprobantes = new LaPaz.Win.Forms.Util.UcFiltroTiposComprobantes();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTexto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroComprobante)).BeginInit();
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
            // TxtTexto
            // 
            this.TxtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTexto.Location = new System.Drawing.Point(146, 11);
            this.TxtTexto.MaxLength = 80;
            this.TxtTexto.Name = "TxtTexto";
            this.TxtTexto.Size = new System.Drawing.Size(277, 26);
            this.TxtTexto.TabIndex = 25;
            this.TxtTexto.TabStop = false;
            this.TxtTexto.ThemeName = "TelerikMetroBlue";
            this.TxtTexto.TextChanged += new System.EventHandler(this.TxtTexto_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(8, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 24);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Cliente:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(441, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(139, 24);
            this.radLabel1.TabIndex = 27;
            this.radLabel1.Text = "Tipo Comprobante:";
            this.radLabel1.Visible = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(441, 42);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(143, 24);
            this.radLabel2.TabIndex = 28;
            this.radLabel2.Text = "Letra Comprobante:";
            this.radLabel2.Visible = false;
            // 
            // LbCuenta
            // 
            this.LbCuenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCuenta.Location = new System.Drawing.Point(4, 46);
            this.LbCuenta.Name = "LbCuenta";
            this.LbCuenta.Size = new System.Drawing.Size(135, 24);
            this.LbCuenta.TabIndex = 53;
            this.LbCuenta.Text = "Nro Comprobante:";
            // 
            // TxtNumeroComprobante
            // 
            this.TxtNumeroComprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumeroComprobante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroComprobante.Location = new System.Drawing.Point(146, 43);
            this.TxtNumeroComprobante.Name = "TxtNumeroComprobante";
            this.TxtNumeroComprobante.Size = new System.Drawing.Size(277, 26);
            this.TxtNumeroComprobante.TabIndex = 54;
            this.TxtNumeroComprobante.TabStop = false;
            this.TxtNumeroComprobante.ThemeName = "TelerikMetroBlue";
            // 
            // UcFiltroLetraComprobante
            // 
            this.UcFiltroLetraComprobante.Letra = "";
            this.UcFiltroLetraComprobante.Location = new System.Drawing.Point(599, 40);
            this.UcFiltroLetraComprobante.Name = "UcFiltroLetraComprobante";
            this.UcFiltroLetraComprobante.Size = new System.Drawing.Size(257, 27);
            this.UcFiltroLetraComprobante.TabIndex = 36;
            this.UcFiltroLetraComprobante.Visible = false;
            // 
            // UcFiltroTiposComprobantes
            // 
            this.UcFiltroTiposComprobantes.Location = new System.Drawing.Point(587, 9);
            this.UcFiltroTiposComprobantes.Name = "UcFiltroTiposComprobantes";
            this.UcFiltroTiposComprobantes.Size = new System.Drawing.Size(277, 27);
            this.UcFiltroTiposComprobantes.TabIndex = 35;
            this.UcFiltroTiposComprobantes.Visible = false;
            // 
            // UcFiltrosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtNumeroComprobante);
            this.Controls.Add(this.LbCuenta);
            this.Controls.Add(this.UcFiltroLetraComprobante);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.UcFiltroTiposComprobantes);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.BtnLimpiarFiltros);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtTexto);
            this.Name = "UcFiltrosVentas";
            this.Size = new System.Drawing.Size(968, 129);
            this.Load += new System.EventHandler(this.UcFiltrosVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTexto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroComprobante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnLimpiarFiltros;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadTextBox TxtTexto;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Util.UcFiltroTiposComprobantes UcFiltroTiposComprobantes;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Util.UcFiltroLetraComprobante UcFiltroLetraComprobante;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtNumeroComprobante;
        private Telerik.WinControls.UI.RadLabel LbCuenta;
    }
}
