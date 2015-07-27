﻿namespace LaPaz.Win.Forms.Compras
{
    partial class FrmComprasListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.ucFiltrosCompras = new LaPaz.Win.Forms.Compras.UcFiltrosCompras();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.pnlCompras = new Telerik.WinControls.UI.RadPanel();
            this.ComprasPager = new Framework.WinForm.Controls.MetroPager();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.GridCompras = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCompras)).BeginInit();
            this.pnlCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucFiltrosCompras
            // 
            this.ucFiltrosCompras.FechaHasta = new System.DateTime(2015, 2, 4, 17, 33, 8, 710);
            this.ucFiltrosCompras.FechaInicio = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.ucFiltrosCompras.Location = new System.Drawing.Point(10, 6);
            this.ucFiltrosCompras.Name = "ucFiltrosCompras";
            this.ucFiltrosCompras.NroComprobante = "";
            this.ucFiltrosCompras.ProveedorId = null;
            this.ucFiltrosCompras.Size = new System.Drawing.Size(786, 88);
            this.ucFiltrosCompras.TabIndex = 0;
            this.ucFiltrosCompras.TipoId = null;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucFiltrosCompras);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(800, 100);
            this.radPanel1.TabIndex = 1;
            // 
            // pnlCompras
            // 
            this.pnlCompras.Controls.Add(this.ComprasPager);
            this.pnlCompras.Controls.Add(this.ucProgressSpinner1);
            this.pnlCompras.Controls.Add(this.GridCompras);
            this.pnlCompras.Location = new System.Drawing.Point(12, 118);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(800, 389);
            this.pnlCompras.TabIndex = 2;
            // 
            // ComprasPager
            // 
            this.ComprasPager.CurrentPage = 1;
            this.ComprasPager.Location = new System.Drawing.Point(397, 3);
            this.ComprasPager.Name = "ComprasPager";
            this.ComprasPager.PageSize = 50;
            this.ComprasPager.PageTotal = 1;
            this.ComprasPager.RefreshAction = null;
            this.ComprasPager.RefreshActionAsync = null;
            this.ComprasPager.Size = new System.Drawing.Size(386, 42);
            this.ComprasPager.TabIndex = 2;
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Location = new System.Drawing.Point(90, 14);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 1;
            // 
            // GridCompras
            // 
            this.GridCompras.AllowDrop = true;
            this.GridCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCompras.AutoScroll = true;
            this.GridCompras.Location = new System.Drawing.Point(10, 51);
            // 
            // GridCompras
            // 
            this.GridCompras.MasterTemplate.AllowAddNewRow = false;
            this.GridCompras.MasterTemplate.AllowColumnReorder = false;
            this.GridCompras.MasterTemplate.AllowDeleteRow = false;
            this.GridCompras.MasterTemplate.AllowDragToGroup = false;
            this.GridCompras.MasterTemplate.AllowEditRow = false;
            this.GridCompras.MasterTemplate.AllowRowResize = false;
            this.GridCompras.MasterTemplate.AutoGenerateColumns = false;
            this.GridCompras.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProveedorDenominacion";
            gridViewTextBoxColumn1.HeaderText = "Proveedor";
            gridViewTextBoxColumn1.Name = "Proveedor";
            gridViewTextBoxColumn1.Width = 401;
            gridViewTextBoxColumn2.FieldName = "TipoComprobanteId";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Tipo";
            gridViewTextBoxColumn2.Name = "TipoComprobanteId";
            gridViewTextBoxColumn2.Width = 143;
            gridViewTextBoxColumn3.FieldName = "FechaAlta";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Fecha";
            gridViewTextBoxColumn3.Name = "FechaAlta";
            gridViewTextBoxColumn3.Width = 98;
            gridViewTextBoxColumn4.FieldName = "LCN";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "LCN";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "LCN";
            gridViewTextBoxColumn4.Width = 116;
            gridViewTextBoxColumn5.FieldName = "ImporteNeto";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Importe";
            gridViewTextBoxColumn5.Name = "ImporteNeto";
            gridViewTextBoxColumn5.Width = 83;
            gridViewTextBoxColumn6.FieldName = "FechaVencimiento";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Vencimiento";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "FechaVencimiento";
            gridViewTextBoxColumn6.Width = 328;
            gridViewCommandColumn1.FormatString = "";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Detalle";
            gridViewCommandColumn1.Width = 30;
            this.GridCompras.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1});
            this.GridCompras.Name = "GridCompras";
            this.GridCompras.ReadOnly = true;
            this.GridCompras.Size = new System.Drawing.Size(773, 324);
            this.GridCompras.TabIndex = 0;
            this.GridCompras.ThemeName = "TelerikMetroBlue";
            this.GridCompras.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridCompras_CommandCellClick);
            // 
            // FrmComprasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 824);
            this.Controls.Add(this.pnlCompras);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmComprasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.FrmListadoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCompras)).EndInit();
            this.pnlCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcFiltrosCompras ucFiltrosCompras;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel pnlCompras;
        private Telerik.WinControls.UI.RadGridView GridCompras;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private Framework.WinForm.Controls.MetroPager ComprasPager;
    }
}