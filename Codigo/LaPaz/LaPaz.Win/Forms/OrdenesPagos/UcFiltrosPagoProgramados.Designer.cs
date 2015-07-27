namespace LaPaz.Win.Forms.OrdenesPagos
{
    partial class UcFiltrosPagoProgramados
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
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.BtnLimpiarFiltros = new Telerik.WinControls.UI.RadButton();
            this.ucFiltroDesdeHasta1 = new LaPaz.Win.Forms.Util.UcFiltroDesdeHasta();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.CbxSiNo = new LaPaz.Win.Forms.Util.UcFiltroSiNo();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(155, 99);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 35;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiarFiltros
            // 
            this.BtnLimpiarFiltros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarFiltros.Location = new System.Drawing.Point(14, 99);
            this.BtnLimpiarFiltros.Name = "BtnLimpiarFiltros";
            this.BtnLimpiarFiltros.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiarFiltros.TabIndex = 36;
            this.BtnLimpiarFiltros.Text = "Limpiar Filtros";
            this.BtnLimpiarFiltros.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
            // 
            // ucFiltroDesdeHasta1
            // 
            this.ucFiltroDesdeHasta1.Desde = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.ucFiltroDesdeHasta1.Hasta = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.ucFiltroDesdeHasta1.Location = new System.Drawing.Point(14, 19);
            this.ucFiltroDesdeHasta1.Name = "ucFiltroDesdeHasta1";
            this.ucFiltroDesdeHasta1.Size = new System.Drawing.Size(356, 27);
            this.ucFiltroDesdeHasta1.TabIndex = 37;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(414, 19);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(69, 21);
            this.radLabel1.TabIndex = 38;
            this.radLabel1.Text = "Anulado:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // CbxSiNo
            // 
            this.CbxSiNo.Location = new System.Drawing.Point(483, 16);
            this.CbxSiNo.Name = "CbxSiNo";
            this.CbxSiNo.Size = new System.Drawing.Size(122, 27);
            this.CbxSiNo.TabIndex = 39;
            this.CbxSiNo.Value = null;
            // 
            // UcFiltrosPagoProgramados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbxSiNo);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.ucFiltroDesdeHasta1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnLimpiarFiltros);
            this.Name = "UcFiltrosPagoProgramados";
            this.Size = new System.Drawing.Size(628, 140);
            this.Load += new System.EventHandler(this.UcFiltrosOrdenesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadButton BtnLimpiarFiltros;
        private Util.UcFiltroDesdeHasta ucFiltroDesdeHasta1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Util.UcFiltroSiNo CbxSiNo;

    }
}
