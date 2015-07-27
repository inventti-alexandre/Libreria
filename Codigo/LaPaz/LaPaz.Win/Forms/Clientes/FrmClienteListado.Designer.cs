namespace LaPaz.Win.Forms.Clientes
{
    partial class FrmClienteListado
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor1 = new Telerik.WinControls.Data.FilterDescriptor();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteDetalle = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.ClienteEditar = new LaPaz.Win.Controls.EditCell.EditColumn();
            this.ClienteEliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.detailsColumn1 = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientesPager = new Framework.WinForm.Controls.MetroPager();
            this.UcFiltrosClientes = new LaPaz.Win.Forms.Clientes.UcFiltrosClientes();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearCliente = new Telerik.WinControls.UI.RadButton();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.dgvClientes = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(LaPaz.Entidades.Cliente);
            // 
            // ClienteDetalle
            // 
            this.ClienteDetalle.FillWeight = 31.2983F;
            this.ClienteDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteDetalle.HeaderText = "";
            this.ClienteDetalle.Name = "ClienteDetalle";
            this.ClienteDetalle.ReadOnly = true;
            this.ClienteDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteDetalle.ToolTipText = "Detalle";
            this.ClienteDetalle.Width = 27;
            // 
            // ClienteEditar
            // 
            this.ClienteEditar.FillWeight = 34.15069F;
            this.ClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteEditar.HeaderText = "";
            this.ClienteEditar.Name = "ClienteEditar";
            this.ClienteEditar.ReadOnly = true;
            this.ClienteEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteEditar.ToolTipText = "Editar";
            this.ClienteEditar.Width = 29;
            // 
            // ClienteEliminar
            // 
            this.ClienteEliminar.FillWeight = 36.90251F;
            this.ClienteEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteEliminar.HeaderText = "";
            this.ClienteEliminar.Name = "ClienteEliminar";
            this.ClienteEliminar.ReadOnly = true;
            this.ClienteEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteEliminar.ToolTipText = "Eliminar";
            this.ClienteEliminar.Width = 31;
            // 
            // detailsColumn1
            // 
            this.detailsColumn1.HeaderText = "";
            this.detailsColumn1.Name = "detailsColumn1";
            this.detailsColumn1.ReadOnly = true;
            this.detailsColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsColumn1.Width = 30;
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvClientes);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 788);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ClientesPager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UcFiltrosClientes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClientesPager
            // 
            this.ClientesPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClientesPager.CurrentPage = 1;
            this.ClientesPager.Location = new System.Drawing.Point(798, 178);
            this.ClientesPager.Margin = new System.Windows.Forms.Padding(94, 3, 3, 3);
            this.ClientesPager.Name = "ClientesPager";
            this.ClientesPager.PageSize = 50;
            this.ClientesPager.PageTotal = 1;
            this.ClientesPager.RefreshAction = null;
            this.ClientesPager.RefreshActionAsync = null;
            this.ClientesPager.Size = new System.Drawing.Size(381, 39);
            this.ClientesPager.TabIndex = 11;
            // 
            // UcFiltrosClientes
            // 
            this.UcFiltrosClientes.Cuit = "";
            this.UcFiltrosClientes.Denominacion = "";
            this.UcFiltrosClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcFiltrosClientes.Location = new System.Drawing.Point(3, 43);
            this.UcFiltrosClientes.Name = "UcFiltrosClientes";
            this.UcFiltrosClientes.Size = new System.Drawing.Size(1176, 129);
            this.UcFiltrosClientes.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearCliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucProgressSpinner1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1176, 34);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCliente.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearCliente.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(75, 28);
            this.BtnCrearCliente.TabIndex = 14;
            this.BtnCrearCliente.Text = "Crear";
            this.BtnCrearCliente.ThemeName = "TelerikMetroBlue";
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucProgressSpinner1.Location = new System.Drawing.Point(1011, 3);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(162, 27);
            this.ucProgressSpinner1.TabIndex = 15;
            // 
            // dgvClientes
            // 
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            // 
            // dgvClientes
            // 
            this.dgvClientes.MasterTemplate.AllowAddNewRow = false;
            this.dgvClientes.MasterTemplate.AllowColumnChooser = false;
            this.dgvClientes.MasterTemplate.AllowColumnReorder = false;
            this.dgvClientes.MasterTemplate.AllowDeleteRow = false;
            this.dgvClientes.MasterTemplate.AllowDragToGroup = false;
            this.dgvClientes.MasterTemplate.AutoGenerateColumns = false;
            this.dgvClientes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.FieldName = "Denominacion";
            gridViewTextBoxColumn2.HeaderText = "Apellido, Nombre";
            gridViewTextBoxColumn2.Name = "Denominacion";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 206;
            gridViewTextBoxColumn3.FieldName = "TiposDocumentosIdentidadNombre";
            gridViewTextBoxColumn3.HeaderText = "Tipo Doc.";
            gridViewTextBoxColumn3.Name = "TipoDocumentoDi";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 140;
            gridViewTextBoxColumn4.FieldName = "Cuit";
            gridViewTextBoxColumn4.HeaderText = "Numero";
            gridViewTextBoxColumn4.Name = "Cuit";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 137;
            gridViewTextBoxColumn5.FieldName = "Telefono";
            gridViewTextBoxColumn5.HeaderText = "Teléfono";
            gridViewTextBoxColumn5.Name = "Telefono";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 136;
            gridViewTextBoxColumn6.FieldName = "Celular";
            gridViewTextBoxColumn6.HeaderText = "Celular";
            gridViewTextBoxColumn6.Name = "Celular";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 136;
            gridViewTextBoxColumn7.FieldName = "Domicilio";
            gridViewTextBoxColumn7.HeaderText = "Domicilio";
            gridViewTextBoxColumn7.Name = "Domicilio";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 206;
            gridViewTextBoxColumn8.FieldName = "mail";
            gridViewTextBoxColumn8.HeaderText = "Email";
            gridViewTextBoxColumn8.Name = "Mail";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 118;
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
            gridViewCommandColumn3.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "ColumnaEliminar";
            gridViewCommandColumn3.Width = 30;
            this.dgvClientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.dgvClientes.MasterTemplate.EnableGrouping = false;
            filterDescriptor1.IsFilterEditor = true;
            filterDescriptor1.PropertyName = "CUIT";
            this.dgvClientes.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor1});
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(1182, 564);
            this.dgvClientes.TabIndex = 12;
            this.dgvClientes.ThemeName = "TelerikMetroBlue";
            this.dgvClientes.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgvClientes_CommandCellClick);
            // 
            // FrmClienteListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 788);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClienteListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClienteListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn2;
        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn3;
        private Controls.DetailCell.DetailsColumn detailsColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Id;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Denominacion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoDocumentoDi;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuit;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Telefono;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Celular;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Domicilio;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Mail;
        private Controls.DetailCell.DetailsColumn ClienteDetalle;
        private Controls.EditCell.EditColumn ClienteEditar;
        private Controls.DeleteCell.DeleteColumn ClienteEliminar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Framework.WinForm.Controls.MetroPager ClientesPager;
        private UcFiltrosClientes UcFiltrosClientes;
        private Telerik.WinControls.UI.RadGridView dgvClientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearCliente;
        private Util.UcProgressSpinner ucProgressSpinner1;
    }
}