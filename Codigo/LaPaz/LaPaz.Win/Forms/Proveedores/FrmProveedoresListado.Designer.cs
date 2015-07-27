using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Proveedores
{
    partial class FrmProveedoresListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresPager = new Framework.WinForm.Controls.MetroPager();
            this.UcFiltrosProveedores = new LaPaz.Win.Forms.Proveedores.UcFiltrosProveedores();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearProveedor = new Telerik.WinControls.UI.RadButton();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.GridProveedores = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores.MasterTemplate)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.GridProveedores);
            this.splitContainer1.Size = new System.Drawing.Size(1394, 824);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ProveedoresPager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UcFiltrosProveedores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ProveedoresPager
            // 
            this.ProveedoresPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProveedoresPager.CurrentPage = 1;
            this.ProveedoresPager.Location = new System.Drawing.Point(1013, 178);
            this.ProveedoresPager.Name = "ProveedoresPager";
            this.ProveedoresPager.PageSize = 50;
            this.ProveedoresPager.PageTotal = 1;
            this.ProveedoresPager.RefreshAction = null;
            this.ProveedoresPager.RefreshActionAsync = null;
            this.ProveedoresPager.Size = new System.Drawing.Size(378, 39);
            this.ProveedoresPager.TabIndex = 10;
            // 
            // UcFiltrosProveedores
            // 
            this.UcFiltrosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UcFiltrosProveedores.Cuenta = null;
            this.UcFiltrosProveedores.Cuit = "";
            this.UcFiltrosProveedores.Denominacion = "";
            this.UcFiltrosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcFiltrosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UcFiltrosProveedores.LocalidadId = null;
            this.UcFiltrosProveedores.Location = new System.Drawing.Point(3, 43);
            this.UcFiltrosProveedores.Name = "UcFiltrosProveedores";
            this.UcFiltrosProveedores.ProvinciaId = null;
            this.UcFiltrosProveedores.Size = new System.Drawing.Size(1388, 129);
            this.UcFiltrosProveedores.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearProveedor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucProgressSpinner1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1388, 34);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // BtnCrearProveedor
            // 
            this.BtnCrearProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearProveedor.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearProveedor.Name = "BtnCrearProveedor";
            this.BtnCrearProveedor.Size = new System.Drawing.Size(75, 28);
            this.BtnCrearProveedor.TabIndex = 10;
            this.BtnCrearProveedor.Text = "Crear";
            this.BtnCrearProveedor.ThemeName = "TelerikMetroBlue";
            this.BtnCrearProveedor.Click += new System.EventHandler(this.BtnCrearProveedor_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCrearProveedor.GetChildAt(0))).Text = "Crear";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnCrearProveedor.GetChildAt(0).GetChildAt(2))).StretchHorizontally = true;
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucProgressSpinner1.Location = new System.Drawing.Point(1223, 3);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(162, 27);
            this.ucProgressSpinner1.TabIndex = 11;
            // 
            // GridProveedores
            // 
            this.GridProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProveedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridProveedores.Location = new System.Drawing.Point(0, 0);
            this.GridProveedores.Margin = new System.Windows.Forms.Padding(5);
            // 
            // GridProveedores
            // 
            this.GridProveedores.MasterTemplate.AllowAddNewRow = false;
            this.GridProveedores.MasterTemplate.AllowColumnReorder = false;
            this.GridProveedores.MasterTemplate.AllowDeleteRow = false;
            this.GridProveedores.MasterTemplate.AllowDragToGroup = false;
            this.GridProveedores.MasterTemplate.AllowEditRow = false;
            this.GridProveedores.MasterTemplate.AllowRowResize = false;
            this.GridProveedores.MasterTemplate.AutoGenerateColumns = false;
            this.GridProveedores.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 29;
            gridViewTextBoxColumn2.FieldName = "Cuenta";
            gridViewTextBoxColumn2.HeaderText = "Cuenta";
            gridViewTextBoxColumn2.Name = "Cuenta";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 226;
            gridViewTextBoxColumn3.FieldName = "Denominacion";
            gridViewTextBoxColumn3.HeaderText = "Denominación";
            gridViewTextBoxColumn3.Name = "Denominacion";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 300;
            gridViewTextBoxColumn4.FieldName = "Domicilio";
            gridViewTextBoxColumn4.HeaderText = "Domicilio";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Domicilio";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 202;
            gridViewTextBoxColumn5.FieldName = "Telefono";
            gridViewTextBoxColumn5.HeaderText = "Teléfono";
            gridViewTextBoxColumn5.Name = "Telefono";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 262;
            gridViewTextBoxColumn6.FieldName = "Celular";
            gridViewTextBoxColumn6.HeaderText = "Celular";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "Celular";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 113;
            gridViewTextBoxColumn7.FieldName = "Contacto";
            gridViewTextBoxColumn7.HeaderText = "Contacto";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Contacto";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 157;
            gridViewTextBoxColumn8.FieldName = "Cuit";
            gridViewTextBoxColumn8.HeaderText = "Cuit";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Cuit";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 56;
            gridViewTextBoxColumn9.FieldName = "ProvinciaNombre";
            gridViewTextBoxColumn9.HeaderText = "Provincia";
            gridViewTextBoxColumn9.Name = "ProvinciaNombre";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 201;
            gridViewTextBoxColumn10.FieldName = "LocalidadNombre";
            gridViewTextBoxColumn10.HeaderText = "Localidad";
            gridViewTextBoxColumn10.Name = "LocalidadNombre";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.Width = 300;
            gridViewTextBoxColumn11.FieldName = "CondicionCompraNombre";
            gridViewTextBoxColumn11.HeaderText = "Condición Compra";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "CondicionCompraNombre";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.Width = 148;
            gridViewTextBoxColumn12.FieldName = "PorcentajeDescuento";
            gridViewTextBoxColumn12.HeaderText = "% Desc.";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "PorcentajeDescuento";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.Width = 219;
            gridViewTextBoxColumn13.FieldName = "BancoNombre";
            gridViewTextBoxColumn13.HeaderText = "Banco";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "BancoNombre";
            gridViewTextBoxColumn13.ReadOnly = true;
            gridViewTextBoxColumn13.Width = 75;
            gridViewTextBoxColumn14.FieldName = "CBU";
            gridViewTextBoxColumn14.HeaderText = "CBU";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "CBU";
            gridViewTextBoxColumn14.ReadOnly = true;
            gridViewTextBoxColumn14.Width = 57;
            gridViewTextBoxColumn15.FieldName = "EmailPedido";
            gridViewTextBoxColumn15.HeaderText = "Email Pedido";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "EmailPedido";
            gridViewTextBoxColumn15.ReadOnly = true;
            gridViewTextBoxColumn15.Width = 232;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "ColumnaDetalle";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "ColumnaEditar";
            gridViewCommandColumn2.Width = 30;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "ColumnaEliminar";
            gridViewCommandColumn3.Width = 30;
            this.GridProveedores.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.GridProveedores.MasterTemplate.EnableGrouping = false;
            this.GridProveedores.Name = "GridProveedores";
            this.GridProveedores.ReadOnly = true;
            this.GridProveedores.Size = new System.Drawing.Size(1394, 600);
            this.GridProveedores.TabIndex = 8;
            this.GridProveedores.ThemeName = "TelerikMetroBlue";
            this.GridProveedores.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridProveedores_CommandCellClick);
            // 
            // FrmProveedoresListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 824);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProveedoresListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedoresListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.GridViewTextBoxColumn provinciaIdDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn sucursalAltaIdDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Id;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuenta;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Denominacion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Domicilio;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Telefono;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Celular;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Contacto;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuit;
        private Telerik.WinControls.UI.GridViewTextBoxColumn ProvinciaNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn LocalidadNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn CondicionCompraNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PorcentajeDescuento;
        private Telerik.WinControls.UI.GridViewTextBoxColumn BancoNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn CBU;
        private Telerik.WinControls.UI.GridViewTextBoxColumn EmailPedido;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Framework.WinForm.Controls.MetroPager ProveedoresPager;
        private UcFiltrosProveedores UcFiltrosProveedores;
        private RadGridView GridProveedores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RadButton BtnCrearProveedor;
        private Util.UcProgressSpinner ucProgressSpinner1;
    }
}