using LaPaz.Win.Forms.Libros;

namespace LaPaz.Win.Forms.Reportes
{
    partial class FrmReporteLibrosListado
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CbxProveedor = new LaPaz.Win.Forms.Util.UcFiltroProveedor();
            this.CbxTema = new LaPaz.Win.Forms.Util.UcFiltroTemas();
            this.CbxOchoDeMarzo = new LaPaz.Win.Forms.Util.UcFiltroSiNo();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.UcFiltroEditorial = new LaPaz.Win.Forms.Util.UcFiltroEditorial();
            this.TxtAutor = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.UcConStock = new LaPaz.Win.Forms.Util.UcFiltroSiNo();
            this.TxtCodigoBarra = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodigo2 = new Telerik.WinControls.UI.RadTextBox();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.lblAutor = new Telerik.WinControls.UI.RadLabel();
            this.TxtTitulo = new Telerik.WinControls.UI.RadTextBox();
            this.TxtIsbn = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.TxtCodigo1 = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CbxProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.CbxTema);
            this.splitContainer1.Panel1.Controls.Add(this.CbxOchoDeMarzo);
            this.splitContainer1.Panel1.Controls.Add(this.radLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.radLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.UcFiltroEditorial);
            this.splitContainer1.Panel1.Controls.Add(this.TxtAutor);
            this.splitContainer1.Panel1.Controls.Add(this.radLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.UcConStock);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCodigoBarra);
            this.splitContainer1.Panel1.Controls.Add(this.radLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCodigo2);
            this.splitContainer1.Panel1.Controls.Add(this.ucProgressSpinner1);
            this.splitContainer1.Panel1.Controls.Add(this.lblAutor);
            this.splitContainer1.Panel1.Controls.Add(this.TxtTitulo);
            this.splitContainer1.Panel1.Controls.Add(this.TxtIsbn);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCodigo1);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1356, 780);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 9;
            // 
            // CbxProveedor
            // 
            this.CbxProveedor.EsGasto = false;
            this.CbxProveedor.Location = new System.Drawing.Point(401, 89);
            this.CbxProveedor.Name = "CbxProveedor";
            this.CbxProveedor.ProveedorId = null;
            this.CbxProveedor.Size = new System.Drawing.Size(210, 27);
            this.CbxProveedor.TabIndex = 77;
            // 
            // CbxTema
            // 
            this.CbxTema.Location = new System.Drawing.Point(676, 55);
            this.CbxTema.Name = "CbxTema";
            this.CbxTema.Size = new System.Drawing.Size(210, 27);
            this.CbxTema.TabIndex = 76;
            this.CbxTema.TemaId = null;
            // 
            // CbxOchoDeMarzo
            // 
            this.CbxOchoDeMarzo.Location = new System.Drawing.Point(1038, 55);
            this.CbxOchoDeMarzo.Name = "CbxOchoDeMarzo";
            this.CbxOchoDeMarzo.Size = new System.Drawing.Size(153, 27);
            this.CbxOchoDeMarzo.TabIndex = 61;
            this.CbxOchoDeMarzo.Value = null;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(904, 57);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(130, 24);
            this.radLabel4.TabIndex = 72;
            this.radLabel4.Text = "Stock 8 de Marzo:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 88);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(67, 24);
            this.radLabel3.TabIndex = 71;
            this.radLabel3.Text = "Editorial:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // UcFiltroEditorial
            // 
            this.UcFiltroEditorial.EditorialId = null;
            this.UcFiltroEditorial.Location = new System.Drawing.Point(79, 87);
            this.UcFiltroEditorial.Name = "UcFiltroEditorial";
            this.UcFiltroEditorial.Size = new System.Drawing.Size(210, 27);
            this.UcFiltroEditorial.TabIndex = 58;
            // 
            // TxtAutor
            // 
            this.TxtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(401, 55);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(210, 26);
            this.TxtAutor.TabIndex = 56;
            this.TxtAutor.TabStop = false;
            this.TxtAutor.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(904, 25);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 24);
            this.radLabel2.TabIndex = 75;
            this.radLabel2.Text = "C/Stock:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // UcConStock
            // 
            this.UcConStock.Location = new System.Drawing.Point(1038, 17);
            this.UcConStock.Name = "UcConStock";
            this.UcConStock.Size = new System.Drawing.Size(153, 27);
            this.UcConStock.TabIndex = 60;
            this.UcConStock.Value = null;
            // 
            // TxtCodigoBarra
            // 
            this.TxtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoBarra.Location = new System.Drawing.Point(401, 20);
            this.TxtCodigoBarra.MaxLength = 50;
            this.TxtCodigoBarra.Name = "TxtCodigoBarra";
            this.TxtCodigoBarra.Size = new System.Drawing.Size(210, 26);
            this.TxtCodigoBarra.TabIndex = 53;
            this.TxtCodigoBarra.TabStop = false;
            this.TxtCodigoBarra.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(310, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(81, 24);
            this.radLabel1.TabIndex = 74;
            this.radLabel1.Text = "Cod. Barra:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigo2
            // 
            this.TxtCodigo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo2.Location = new System.Drawing.Point(136, 20);
            this.TxtCodigo2.MaxLength = 13;
            this.TxtCodigo2.Name = "TxtCodigo2";
            this.TxtCodigo2.Size = new System.Drawing.Size(153, 26);
            this.TxtCodigo2.TabIndex = 63;
            this.TxtCodigo2.TabStop = false;
            this.TxtCodigo2.ThemeName = "TelerikMetroBlue";
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProgressSpinner1.Location = new System.Drawing.Point(998, 88);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 73;
            // 
            // lblAutor
            // 
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(310, 57);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(49, 24);
            this.lblAutor.TabIndex = 70;
            this.lblAutor.Text = "Autor:";
            this.lblAutor.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(79, 55);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(210, 26);
            this.TxtTitulo.TabIndex = 55;
            this.TxtTitulo.TabStop = false;
            this.TxtTitulo.ThemeName = "TelerikMetroBlue";
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIsbn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsbn.Location = new System.Drawing.Point(676, 20);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(210, 26);
            this.TxtIsbn.TabIndex = 54;
            this.TxtIsbn.TabStop = false;
            this.TxtIsbn.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(626, 56);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 24);
            this.metroLabel5.TabIndex = 69;
            this.metroLabel5.Text = "Tema:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(310, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 24);
            this.metroLabel4.TabIndex = 68;
            this.metroLabel4.Text = "Proveedor:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(12, 53);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 24);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Título:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(626, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 24);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "ISBN:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(12, 129);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 64;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCodigo1
            // 
            this.TxtCodigo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo1.Location = new System.Drawing.Point(79, 20);
            this.TxtCodigo1.MaxLength = 4;
            this.TxtCodigo1.Name = "TxtCodigo1";
            this.TxtCodigo1.Size = new System.Drawing.Size(51, 26);
            this.TxtCodigo1.TabIndex = 62;
            this.TxtCodigo1.TabStop = false;
            this.TxtCodigo1.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(12, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 24);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Código:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1356, 606);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // FrmReporteLibrosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 780);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteLibrosListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reporte de Libros";
            this.Load += new System.EventHandler(this.FrmLibrosListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Util.UcFiltroSiNo CbxOchoDeMarzo;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Util.UcFiltroEditorial UcFiltroEditorial;
        private Telerik.WinControls.UI.RadTextBox TxtAutor;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Util.UcFiltroSiNo UcConStock;
        private Telerik.WinControls.UI.RadTextBox TxtCodigoBarra;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtCodigo2;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private Telerik.WinControls.UI.RadLabel lblAutor;
        private Telerik.WinControls.UI.RadTextBox TxtTitulo;
        private Telerik.WinControls.UI.RadTextBox TxtIsbn;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadTextBox TxtCodigo1;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Util.UcFiltroTemas CbxTema;
        private Util.UcFiltroProveedor CbxProveedor;
    }
}