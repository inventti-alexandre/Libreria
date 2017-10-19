namespace LaPaz.Win.Forms.Consignaciones
{
    partial class FrmActualizarConsignaciones
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnActualizar = new Telerik.WinControls.UI.RadButton();
            this.BtnListado = new Telerik.WinControls.UI.RadButton();
            this.GridMovimientos = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMovimientos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BtnActualizar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnListado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GridMovimientos, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(3, 73);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(300, 49);
            this.BtnActualizar.TabIndex = 0;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.ThemeName = "TelerikMetroBlue";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnListado
            // 
            this.BtnListado.Location = new System.Drawing.Point(3, 3);
            this.BtnListado.Name = "BtnListado";
            this.BtnListado.Size = new System.Drawing.Size(300, 50);
            this.BtnListado.TabIndex = 1;
            this.BtnListado.Text = "Ver Movimientos";
            this.BtnListado.ThemeName = "TelerikMetroBlue";
            this.BtnListado.Click += new System.EventHandler(this.BtnListado_Click);
            // 
            // GridMovimientos
            // 
            this.GridMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMovimientos.Location = new System.Drawing.Point(3, 143);
            // 
            // GridMovimientos
            // 
            this.GridMovimientos.MasterTemplate.AllowAddNewRow = false;
            this.GridMovimientos.MasterTemplate.AllowColumnReorder = false;
            this.GridMovimientos.MasterTemplate.AllowDragToGroup = false;
            this.GridMovimientos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Fecha";
            gridViewTextBoxColumn1.HeaderText = "Fecha";
            gridViewTextBoxColumn1.Name = "Fecha";
            gridViewTextBoxColumn1.Width = 224;
            gridViewTextBoxColumn2.FieldName = "VentasLCN";
            gridViewTextBoxColumn2.HeaderText = "Nro Venta";
            gridViewTextBoxColumn2.Name = "LCN";
            gridViewTextBoxColumn2.Width = 224;
            gridViewTextBoxColumn3.FieldName = "TitulosNombreTitulo";
            gridViewTextBoxColumn3.HeaderText = "Titulo";
            gridViewTextBoxColumn3.Name = "Titulo";
            gridViewTextBoxColumn3.Width = 224;
            gridViewTextBoxColumn4.FieldName = "CntMinCn";
            gridViewTextBoxColumn4.HeaderText = "Consigando";
            gridViewTextBoxColumn4.Name = "CntMinCn";
            gridViewTextBoxColumn4.Width = 224;
            gridViewTextBoxColumn5.FieldName = "CntMinPr";
            gridViewTextBoxColumn5.HeaderText = "Propio";
            gridViewTextBoxColumn5.Name = "CntMinPr";
            gridViewTextBoxColumn5.Width = 224;
            this.GridMovimientos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.GridMovimientos.Name = "GridMovimientos";
            this.GridMovimientos.ReadOnly = true;
            this.GridMovimientos.Size = new System.Drawing.Size(1138, 326);
            this.GridMovimientos.TabIndex = 0;
            this.GridMovimientos.Text = "radGridView1";
            this.GridMovimientos.ThemeName = "TelerikMetroBlue";
            // 
            // FrmActualizarConsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmActualizarConsignaciones";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmActualizarConsignaciones";
            this.Load += new System.EventHandler(this.FrmActualizarConsignaciones_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMovimientos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView GridMovimientos;
        private Telerik.WinControls.UI.RadButton BtnActualizar;
        private Telerik.WinControls.UI.RadButton BtnListado;
    }
}