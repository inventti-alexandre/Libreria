namespace LaPaz.Win.Forms.Editorial
{
    partial class FrmEditorialListado
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
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditorialDetalle = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.EditorialEditar = new LaPaz.Win.Controls.EditCell.EditColumn();
            this.EditorialEliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.detailsColumn1 = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EditorialesPager = new Framework.WinForm.Controls.MetroPager();
            this.UcFiltrosEditoriales = new LaPaz.Win.Forms.Editorial.UcFiltrosEditorial();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearEditorial = new Telerik.WinControls.UI.RadButton();
            this.dgvEditoriales = new Telerik.WinControls.UI.RadGridView();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.editorialBindingSource.DataSource = typeof(LaPaz.Entidades.Editorial);
            // 
            // EditorialDetalle
            // 
            this.EditorialDetalle.FillWeight = 31.2983F;
            this.EditorialDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorialDetalle.HeaderText = "";
            this.EditorialDetalle.Name = "EditorialDetalle";
            this.EditorialDetalle.ReadOnly = true;
            this.EditorialDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditorialDetalle.ToolTipText = "Detalle";
            this.EditorialDetalle.Width = 27;
            // 
            // EditorialEditar
            // 
            this.EditorialEditar.FillWeight = 34.15069F;
            this.EditorialEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorialEditar.HeaderText = "";
            this.EditorialEditar.Name = "EditorialEditar";
            this.EditorialEditar.ReadOnly = true;
            this.EditorialEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditorialEditar.ToolTipText = "Editar";
            this.EditorialEditar.Width = 29;
            // 
            // EditorialEliminar
            // 
            this.EditorialEliminar.FillWeight = 36.90251F;
            this.EditorialEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorialEliminar.HeaderText = "";
            this.EditorialEliminar.Name = "EditorialEliminar";
            this.EditorialEliminar.ReadOnly = true;
            this.EditorialEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditorialEliminar.ToolTipText = "Eliminar";
            this.EditorialEliminar.Width = 31;
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvEditoriales);
            this.splitContainer1.Size = new System.Drawing.Size(1174, 769);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.EditorialesPager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UcFiltrosEditoriales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1174, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EditorialesPager
            // 
            this.EditorialesPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditorialesPager.CurrentPage = 1;
            this.EditorialesPager.Location = new System.Drawing.Point(790, 178);
            this.EditorialesPager.Margin = new System.Windows.Forms.Padding(94, 3, 3, 3);
            this.EditorialesPager.Name = "EditorialesPager";
            this.EditorialesPager.PageSize = 50;
            this.EditorialesPager.PageTotal = 1;
            this.EditorialesPager.RefreshAction = null;
            this.EditorialesPager.RefreshActionAsync = null;
            this.EditorialesPager.Size = new System.Drawing.Size(381, 39);
            this.EditorialesPager.TabIndex = 11;
            // 
            // UcFiltrosClientes
            // 
            this.UcFiltrosEditoriales.Nombre = "";
            this.UcFiltrosEditoriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcFiltrosEditoriales.Location = new System.Drawing.Point(3, 43);
            this.UcFiltrosEditoriales.Name = "UcFiltrosEditoriales";
            this.UcFiltrosEditoriales.Size = new System.Drawing.Size(1168, 129);
            this.UcFiltrosEditoriales.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearEditorial, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucProgressSpinner1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1168, 34);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // BtnCrearEditorial
            // 
            this.BtnCrearEditorial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearEditorial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearEditorial.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearEditorial.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.BtnCrearEditorial.Name = "BtnCrearEditorial";
            this.BtnCrearEditorial.Size = new System.Drawing.Size(75, 28);
            this.BtnCrearEditorial.TabIndex = 14;
            this.BtnCrearEditorial.Text = "Crear";
            this.BtnCrearEditorial.ThemeName = "TelerikMetroBlue";
            this.BtnCrearEditorial.Click += new System.EventHandler(this.BtnCrearEditorial_Click);
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEditoriales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEditoriales.Location = new System.Drawing.Point(0, 0);
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.MasterTemplate.AllowAddNewRow = false;
            this.dgvEditoriales.MasterTemplate.AllowColumnChooser = false;
            this.dgvEditoriales.MasterTemplate.AllowColumnReorder = false;
            this.dgvEditoriales.MasterTemplate.AllowDeleteRow = false;
            this.dgvEditoriales.MasterTemplate.AllowDragToGroup = false;
            this.dgvEditoriales.MasterTemplate.AutoGenerateColumns = false;
            this.dgvEditoriales.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.FieldName = "Nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "Nombre";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 204;
            gridViewTextBoxColumn3.FieldName = "TE1";
            gridViewTextBoxColumn3.HeaderText = "Teléfono";
            gridViewTextBoxColumn3.Name = "Telefono";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 135;
            gridViewTextBoxColumn4.FieldName = "TE2";
            gridViewTextBoxColumn4.HeaderText = "Tel. Alternativo";
            gridViewTextBoxColumn4.Name = "TelefonoAlt";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 135;
            gridViewTextBoxColumn5.FieldName = "Domicilio";
            gridViewTextBoxColumn5.HeaderText = "Domicilio";
            gridViewTextBoxColumn5.Name = "Domicilio";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 204;
            gridViewTextBoxColumn6.FieldName = "Email";
            gridViewTextBoxColumn6.HeaderText = "Email";
            gridViewTextBoxColumn6.Name = "Email";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 118;
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
            this.dgvEditoriales.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.dgvEditoriales.MasterTemplate.EnableGrouping = false;
            filterDescriptor1.IsFilterEditor = true;
            filterDescriptor1.PropertyName = "Nombre";
            this.dgvEditoriales.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor1});
            this.dgvEditoriales.Name = "dgvEditoriales";
            this.dgvEditoriales.ReadOnly = true;
            this.dgvEditoriales.Size = new System.Drawing.Size(1174, 545);
            this.dgvEditoriales.TabIndex = 12;
            this.dgvEditoriales.ThemeName = "TelerikMetroBlue";
            this.dgvEditoriales.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgvClientes_CommandCellClick);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucProgressSpinner1.Location = new System.Drawing.Point(1003, 3);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(162, 27);
            this.ucProgressSpinner1.TabIndex = 15;
            // 
            // FrmEditorialListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 769);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditorialListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.FrmEditorialListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource editorialBindingSource;
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
        private Controls.DetailCell.DetailsColumn EditorialDetalle;
        private Controls.EditCell.EditColumn EditorialEditar;
        private Controls.DeleteCell.DeleteColumn EditorialEliminar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Framework.WinForm.Controls.MetroPager EditorialesPager;
        private UcFiltrosEditorial UcFiltrosEditoriales;
        private Telerik.WinControls.UI.RadGridView dgvEditoriales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearEditorial;
        private Util.UcProgressSpinner ucProgressSpinner1;
    }
}