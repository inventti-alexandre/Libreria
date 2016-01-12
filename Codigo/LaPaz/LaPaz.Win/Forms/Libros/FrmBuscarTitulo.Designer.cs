namespace LaPaz.Win.Forms.Libros
{
    partial class FrmBuscarTitulo
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.UcFiltrosLibros = new LaPaz.Win.Forms.Libros.UcFiltrosLibros();
            this.GridLibros = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros.MasterTemplate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UcFiltrosLibros
            // 
            this.UcFiltrosLibros.Activos = true;
            this.UcFiltrosLibros.AutorNombre = "";
            this.UcFiltrosLibros.BtnBuscarTexto = "Buscar";
            this.UcFiltrosLibros.CodigoBarra = "";
            this.UcFiltrosLibros.CodigoLibroCompleto = null;
            this.UcFiltrosLibros.CodigoProveedor = null;
            this.UcFiltrosLibros.ConStock = null;
            this.UcFiltrosLibros.EditorialId = null;
            this.UcFiltrosLibros.ISBN = "";
            this.UcFiltrosLibros.Location = new System.Drawing.Point(12, 13);
            this.UcFiltrosLibros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UcFiltrosLibros.Name = "UcFiltrosLibros";
            this.UcFiltrosLibros.NombreTitulo = "";
            this.UcFiltrosLibros.OchoDeMarzo = null;
            this.UcFiltrosLibros.ProveedorId = null;
            this.UcFiltrosLibros.Size = new System.Drawing.Size(1592, 201);
            this.UcFiltrosLibros.TabIndex = 0;
            this.UcFiltrosLibros.TemaId = null;
            // 
            // GridLibros
            // 
            this.GridLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLibros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridLibros.Location = new System.Drawing.Point(4, 11);
            this.GridLibros.Margin = new System.Windows.Forms.Padding(4);
            // 
            // GridLibros
            // 
            this.GridLibros.MasterTemplate.AutoGenerateColumns = false;
            this.GridLibros.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 136;
            gridViewTextBoxColumn2.FieldName = "Cod";
            gridViewTextBoxColumn2.HeaderText = "Código";
            gridViewTextBoxColumn2.Name = "Codigo";
            gridViewTextBoxColumn2.Width = 185;
            gridViewTextBoxColumn3.FieldName = "NombreTitulo";
            gridViewTextBoxColumn3.HeaderText = "Título";
            gridViewTextBoxColumn3.Name = "NombreTitulo";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 382;
            gridViewTextBoxColumn4.FieldName = "AutorNombre";
            gridViewTextBoxColumn4.HeaderText = "Autor";
            gridViewTextBoxColumn4.Name = "AutorNombre";
            gridViewTextBoxColumn4.Width = 183;
            gridViewTextBoxColumn5.FieldName = "EditorialNombre";
            gridViewTextBoxColumn5.HeaderText = "Editorial";
            gridViewTextBoxColumn5.Name = "EditorialNombre";
            gridViewTextBoxColumn5.Width = 164;
            gridViewTextBoxColumn6.FieldName = "PrecioVentaTitulo";
            gridViewTextBoxColumn6.FormatString = "{0:c2}";
            gridViewTextBoxColumn6.HeaderText = "Precio";
            gridViewTextBoxColumn6.Name = "PrecioVentaTitulo";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 166;
            gridViewTextBoxColumn7.FieldName = "TituloStockStkPr";
            gridViewTextBoxColumn7.HeaderText = "St. Pr.";
            gridViewTextBoxColumn7.MaxWidth = 40;
            gridViewTextBoxColumn7.MinWidth = 40;
            gridViewTextBoxColumn7.Name = "StockPropio";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 40;
            gridViewTextBoxColumn8.FieldName = "TituloStockStkCn";
            gridViewTextBoxColumn8.HeaderText = "St. Cn.";
            gridViewTextBoxColumn8.MaxWidth = 40;
            gridViewTextBoxColumn8.MinWidth = 40;
            gridViewTextBoxColumn8.Name = "StockConsignado";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 40;
            gridViewTextBoxColumn9.FieldName = "TituloStockStkPrViejo";
            gridViewTextBoxColumn9.HeaderText = "PR 8";
            gridViewTextBoxColumn9.MaxWidth = 40;
            gridViewTextBoxColumn9.MinWidth = 40;
            gridViewTextBoxColumn9.Name = "StockPropioViejo";
            gridViewTextBoxColumn9.Width = 40;
            gridViewTextBoxColumn10.FieldName = "TituloStockStkCnViejo";
            gridViewTextBoxColumn10.HeaderText = "CN 8";
            gridViewTextBoxColumn10.MaxWidth = 40;
            gridViewTextBoxColumn10.MinWidth = 40;
            gridViewTextBoxColumn10.Name = "StockConsignadoViejo";
            gridViewTextBoxColumn10.Width = 40;
            gridViewCommandColumn1.HeaderText = "Seleccionar";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Add_New_blue;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Seleccionar";
            gridViewCommandColumn1.Width = 30;
            this.GridLibros.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewCommandColumn1});
            this.GridLibros.MasterTemplate.EnableGrouping = false;
            this.GridLibros.Name = "GridLibros";
            this.GridLibros.ReadOnly = true;
            this.GridLibros.Size = new System.Drawing.Size(1283, 461);
            this.GridLibros.TabIndex = 13;
            this.GridLibros.ThemeName = "TelerikMetroBlue";
            this.GridLibros.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridLibros_CommandCellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GridLibros, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 245);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1291, 476);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // FrmBuscarTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 733);
            this.Controls.Add(this.UcFiltrosLibros);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmBuscarTitulo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Seleccionar Titulo";
            this.Load += new System.EventHandler(this.FrmBuscarTitulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcFiltrosLibros UcFiltrosLibros;
        private Telerik.WinControls.UI.RadGridView GridLibros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}