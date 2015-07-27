namespace LaPaz.Win.Forms.Cuentas
{
    partial class FrmCuentasListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearAutor = new Telerik.WinControls.UI.RadButton();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.CuentasPager = new Framework.WinForm.Controls.MetroPager();
            this.ucFiltrosCuentas = new LaPaz.Win.Forms.Cuentas.UcFiltrosCuentas();
            this.GridCuentas = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuentas.MasterTemplate)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridCuentas);
            this.splitContainer1.Size = new System.Drawing.Size(1093, 788);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CuentasPager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucFiltrosCuentas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 230);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearAutor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucProgressSpinner1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1087, 34);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // BtnCrearAutor
            // 
            this.BtnCrearAutor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearAutor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnCrearAutor.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearAutor.Name = "BtnCrearAutor";
            this.BtnCrearAutor.Size = new System.Drawing.Size(75, 28);
            this.BtnCrearAutor.TabIndex = 16;
            this.BtnCrearAutor.Text = "Crear";
            this.BtnCrearAutor.ThemeName = "TelerikMetroBlue";
            this.BtnCrearAutor.Click += new System.EventHandler(this.BtnCrearAutor_Click);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucProgressSpinner1.Location = new System.Drawing.Point(922, 3);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(162, 27);
            this.ucProgressSpinner1.TabIndex = 17;
            // 
            // CuentasPager
            // 
            this.CuentasPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CuentasPager.CurrentPage = 1;
            this.CuentasPager.Location = new System.Drawing.Point(712, 188);
            this.CuentasPager.Name = "CuentasPager";
            this.CuentasPager.PageSize = 50;
            this.CuentasPager.PageTotal = 1;
            this.CuentasPager.RefreshAction = null;
            this.CuentasPager.RefreshActionAsync = null;
            this.CuentasPager.Size = new System.Drawing.Size(378, 39);
            this.CuentasPager.TabIndex = 14;
            // 
            // ucFiltrosCuentas
            // 
            this.ucFiltrosCuentas.Location = new System.Drawing.Point(3, 43);
            this.ucFiltrosCuentas.Name = "ucFiltrosCuentas";
            this.ucFiltrosCuentas.Nombre = "";
            this.ucFiltrosCuentas.Size = new System.Drawing.Size(943, 139);
            this.ucFiltrosCuentas.TabIndex = 18;
            this.ucFiltrosCuentas.Titular = "";
            // 
            // GridCuentas
            // 
            this.GridCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCuentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridCuentas.Location = new System.Drawing.Point(0, 0);
            // 
            // GridCuentas
            // 
            this.GridCuentas.MasterTemplate.AutoGenerateColumns = false;
            this.GridCuentas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 136;
            gridViewTextBoxColumn2.FieldName = "Nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "Nombre";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 219;
            gridViewTextBoxColumn3.FieldName = "Descripcion";
            gridViewTextBoxColumn3.HeaderText = "Descripción";
            gridViewTextBoxColumn3.Name = "Descripcion";
            gridViewTextBoxColumn3.Width = 211;
            gridViewTextBoxColumn4.FieldName = "TiposCuentaNombre";
            gridViewTextBoxColumn4.HeaderText = "Tipo Cuenta";
            gridViewTextBoxColumn4.Name = "TipoCuenta";
            gridViewTextBoxColumn4.Width = 175;
            gridViewTextBoxColumn5.FieldName = "BancosPropioNombre";
            gridViewTextBoxColumn5.HeaderText = "Banco";
            gridViewTextBoxColumn5.Name = "BancoPropio";
            gridViewTextBoxColumn5.Width = 211;
            gridViewTextBoxColumn6.FieldName = "Titular";
            gridViewTextBoxColumn6.HeaderText = "Titular";
            gridViewTextBoxColumn6.Name = "Titular";
            gridViewTextBoxColumn6.Width = 78;
            gridViewTextBoxColumn7.FieldName = "FechaApertura";
            gridViewTextBoxColumn7.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn7.HeaderText = "Fecha";
            gridViewTextBoxColumn7.Name = "FechaApertura";
            gridViewTextBoxColumn7.Width = 95;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "ColumnaDetalle";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "ColumnaEditar";
            gridViewCommandColumn2.Width = 30;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewCommandColumn3.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "ColumnaEliminar";
            gridViewCommandColumn3.Width = 30;
            this.GridCuentas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.GridCuentas.MasterTemplate.EnableGrouping = false;
            this.GridCuentas.Name = "GridCuentas";
            this.GridCuentas.ReadOnly = true;
            this.GridCuentas.Size = new System.Drawing.Size(1093, 554);
            this.GridCuentas.TabIndex = 12;
            this.GridCuentas.ThemeName = "TelerikMetroBlue";
            this.GridCuentas.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridCuentas_CommandCellClick);
            // 
            // FrmCuentasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 788);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCuentasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FrmCuentasListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuentas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.GridViewTextBoxColumn Id;
        private Telerik.WinControls.UI.GridViewTextBoxColumn NombreTitulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn ISBN;
        private Telerik.WinControls.UI.GridViewTextBoxColumn ProveedorDenominacion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TemaNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PrecioVentaTitulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PrecioCompraTitulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn StockPropio;
        private Telerik.WinControls.UI.GridViewTextBoxColumn StockConsignado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Framework.WinForm.Controls.MetroPager CuentasPager;
        private Telerik.WinControls.UI.RadGridView GridCuentas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearAutor;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private UcFiltrosCuentas ucFiltrosCuentas;
    }
}