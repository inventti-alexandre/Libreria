namespace LaPaz.Win.Forms.Compras
{
    partial class UcCompraDetalle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.GridCompraDetalle = new Telerik.WinControls.UI.RadGridView();
            this.ListadoPager = new Framework.WinForm.Controls.MetroPager();
            this.ucProgressSpinner = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCompraDetalle
            // 
            this.GridCompraDetalle.AllowDrop = true;
            this.GridCompraDetalle.Location = new System.Drawing.Point(21, 53);
            // 
            // GridCompraDetalle
            // 
            this.GridCompraDetalle.MasterTemplate.AllowAddNewRow = false;
            this.GridCompraDetalle.MasterTemplate.AllowColumnReorder = false;
            this.GridCompraDetalle.MasterTemplate.AllowDeleteRow = false;
            this.GridCompraDetalle.MasterTemplate.AllowDragToGroup = false;
            this.GridCompraDetalle.MasterTemplate.AllowEditRow = false;
            this.GridCompraDetalle.MasterTemplate.AllowRowResize = false;
            this.GridCompraDetalle.MasterTemplate.AutoGenerateColumns = false;
            this.GridCompraDetalle.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn16.Expression = "";
            gridViewTextBoxColumn16.FieldName = "TituloNombreTitulo";
            gridViewTextBoxColumn16.HeaderText = "Titulo";
            gridViewTextBoxColumn16.Name = "Titulo";
            gridViewTextBoxColumn16.Width = 291;
            gridViewTextBoxColumn17.FieldName = "CntPr";
            gridViewTextBoxColumn17.HeaderText = "Propia";
            gridViewTextBoxColumn17.Name = "Propia";
            gridViewTextBoxColumn17.Width = 99;
            gridViewTextBoxColumn18.FieldName = "CntCn";
            gridViewTextBoxColumn18.HeaderText = "Consignada";
            gridViewTextBoxColumn18.Name = "Consignada";
            gridViewTextBoxColumn18.Width = 99;
            gridViewTextBoxColumn19.FieldName = "PrecioCompra";
            gridViewTextBoxColumn19.HeaderText = "PrecioCompra";
            gridViewTextBoxColumn19.Name = "PrecioCompra";
            gridViewTextBoxColumn19.Width = 99;
            gridViewTextBoxColumn20.FieldName = "PrecioVenta";
            gridViewTextBoxColumn20.HeaderText = "PrecioVenta";
            gridViewTextBoxColumn20.Name = "PrecioVenta";
            gridViewTextBoxColumn20.Width = 123;
            this.GridCompraDetalle.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20});
            this.GridCompraDetalle.Name = "GridCompraDetalle";
            this.GridCompraDetalle.ReadOnly = true;
            this.GridCompraDetalle.Size = new System.Drawing.Size(729, 287);
            this.GridCompraDetalle.TabIndex = 1;
            this.GridCompraDetalle.Text = "radGridView1";
            this.GridCompraDetalle.ThemeName = "TelerikMetroBlue";
            // 
            // ListadoPager
            // 
            this.ListadoPager.CurrentPage = 1;
            this.ListadoPager.Location = new System.Drawing.Point(364, 5);
            this.ListadoPager.Name = "ListadoPager";
            this.ListadoPager.PageSize = 50;
            this.ListadoPager.PageTotal = 1;
            this.ListadoPager.RefreshAction = null;
            this.ListadoPager.RefreshActionAsync = null;
            this.ListadoPager.Size = new System.Drawing.Size(386, 42);
            this.ListadoPager.TabIndex = 2;
            // 
            // ucProgressSpinner
            // 
            this.ucProgressSpinner.Location = new System.Drawing.Point(204, 20);
            this.ucProgressSpinner.Name = "ucProgressSpinner";
            this.ucProgressSpinner.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner.TabIndex = 3;
            // 
            // UcCompraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucProgressSpinner);
            this.Controls.Add(this.ListadoPager);
            this.Controls.Add(this.GridCompraDetalle);
            this.Name = "UcCompraDetalle";
            this.Size = new System.Drawing.Size(772, 356);
            this.Load += new System.EventHandler(this.UcCompraDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GridCompraDetalle;
        private Framework.WinForm.Controls.MetroPager ListadoPager;
        private Util.UcProgressSpinner ucProgressSpinner;
    }
}
