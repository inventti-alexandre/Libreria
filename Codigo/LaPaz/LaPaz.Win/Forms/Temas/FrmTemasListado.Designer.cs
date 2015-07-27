using LaPaz.Win.Forms.Autores;

namespace LaPaz.Win.Forms.Temas
{
    partial class FrmTemasListado
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearTema = new Telerik.WinControls.UI.RadButton();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.ucFiltrosTemas = new LaPaz.Win.Forms.Autores.UcFiltrosAutores();
            this.TemasPager = new Framework.WinForm.Controls.MetroPager();
            this.GridTemas = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTemas.MasterTemplate)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.GridTemas);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 694);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucFiltrosTemas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TemasPager, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearTema, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucProgressSpinner1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1039, 34);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // BtnCrearTema
            // 
            this.BtnCrearTema.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearTema.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnCrearTema.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearTema.Name = "BtnCrearTema";
            this.BtnCrearTema.Size = new System.Drawing.Size(75, 28);
            this.BtnCrearTema.TabIndex = 16;
            this.BtnCrearTema.Text = "Crear";
            this.BtnCrearTema.ThemeName = "TelerikMetroBlue";
            this.BtnCrearTema.Click += new System.EventHandler(this.BtnCrearTema_Click);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucProgressSpinner1.Location = new System.Drawing.Point(874, 3);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(162, 27);
            this.ucProgressSpinner1.TabIndex = 17;
            // 
            // ucFiltrosTemas
            // 
            this.ucFiltrosTemas.Location = new System.Drawing.Point(3, 43);
            this.ucFiltrosTemas.Name = "ucFiltrosTemas";
            this.ucFiltrosTemas.Nombre = "";
            this.ucFiltrosTemas.Size = new System.Drawing.Size(852, 96);
            this.ucFiltrosTemas.TabIndex = 18;
            // 
            // TemasPager
            // 
            this.TemasPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TemasPager.CurrentPage = 1;
            this.TemasPager.Location = new System.Drawing.Point(664, 151);
            this.TemasPager.Name = "TemasPager";
            this.TemasPager.PageSize = 50;
            this.TemasPager.PageTotal = 1;
            this.TemasPager.RefreshAction = null;
            this.TemasPager.RefreshActionAsync = null;
            this.TemasPager.Size = new System.Drawing.Size(378, 39);
            this.TemasPager.TabIndex = 14;
            // 
            // GridTemas
            // 
            this.GridTemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTemas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTemas.Location = new System.Drawing.Point(0, 0);
            // 
            // GridTemas
            // 
            this.GridTemas.MasterTemplate.AutoGenerateColumns = false;
            this.GridTemas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 136;
            gridViewTextBoxColumn2.FieldName = "Nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "NombreTitulo";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 936;
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
            this.GridTemas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.GridTemas.MasterTemplate.EnableGrouping = false;
            this.GridTemas.Name = "GridTemas";
            this.GridTemas.ReadOnly = true;
            this.GridTemas.Size = new System.Drawing.Size(1045, 490);
            this.GridTemas.TabIndex = 12;
            this.GridTemas.ThemeName = "TelerikMetroBlue";
            this.GridTemas.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridTemas_CommandCellClick);
            // 
            // FrmTemasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 694);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTemasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Temas";
            this.Load += new System.EventHandler(this.FrmTemasListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTemas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTemas)).EndInit();
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
        private Framework.WinForm.Controls.MetroPager TemasPager;
        private Telerik.WinControls.UI.RadGridView GridTemas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearTema;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private UcFiltrosAutores ucFiltrosTemas;
    }
}