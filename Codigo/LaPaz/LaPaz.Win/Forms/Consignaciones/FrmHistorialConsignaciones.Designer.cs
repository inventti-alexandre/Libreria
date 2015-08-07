using LaPaz.Win.Forms.Autores;

namespace LaPaz.Win.Forms.Consignaciones
{
    partial class FrmHistorialConsignaciones
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
            this.UcConsignacionesProveedorListado = new LaPaz.Win.Forms.Consignaciones.UcConsignacionesProveedorListado();
            this.HistorialConsignacionesPager = new Framework.WinForm.Controls.MetroPager();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucFiltrosConsignaciones = new LaPaz.Win.Forms.Consignaciones.UcFiltrosConsignaciones();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UcConsignacionesProveedorListado
            // 
            this.UcConsignacionesProveedorListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcConsignacionesProveedorListado.Location = new System.Drawing.Point(0, 0);
            this.UcConsignacionesProveedorListado.Name = "UcConsignacionesProveedorListado";
            this.UcConsignacionesProveedorListado.Size = new System.Drawing.Size(1366, 776);
            this.UcConsignacionesProveedorListado.TabIndex = 1;
            // 
            // HistorialConsignacionesPager
            // 
            this.HistorialConsignacionesPager.CurrentPage = 1;
            this.HistorialConsignacionesPager.Dock = System.Windows.Forms.DockStyle.Right;
            this.HistorialConsignacionesPager.Location = new System.Drawing.Point(985, 94);
            this.HistorialConsignacionesPager.Name = "HistorialConsignacionesPager";
            this.HistorialConsignacionesPager.PageSize = 50;
            this.HistorialConsignacionesPager.PageTotal = 1;
            this.HistorialConsignacionesPager.RefreshAction = null;
            this.HistorialConsignacionesPager.RefreshActionAsync = null;
            this.HistorialConsignacionesPager.Size = new System.Drawing.Size(378, 44);
            this.HistorialConsignacionesPager.TabIndex = 15;
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
            this.splitContainer1.Panel2.Controls.Add(this.UcConsignacionesProveedorListado);
            this.splitContainer1.Size = new System.Drawing.Size(1366, 920);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 9;
            // 
            // ucFiltrosConsignaciones
            // 
            this.ucFiltrosConsignaciones.Desde = new System.DateTime(2015, 7, 7, 19, 17, 55, 260);
            this.ucFiltrosConsignaciones.Hasta = new System.DateTime(2015, 8, 7, 19, 17, 55, 258);
            this.ucFiltrosConsignaciones.Location = new System.Drawing.Point(3, 3);
            this.ucFiltrosConsignaciones.Name = "ucFiltrosConsignaciones";
            this.ucFiltrosConsignaciones.ProveedorId = null;
            this.ucFiltrosConsignaciones.Size = new System.Drawing.Size(757, 85);
            this.ucFiltrosConsignaciones.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucFiltrosConsignaciones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HistorialConsignacionesPager, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FrmHistorialConsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 920);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorialConsignaciones";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Rendir Consignaciones";
            this.Load += new System.EventHandler(this.FrmRendicionConsignaciones_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private UcConsignacionesProveedorListado UcConsignacionesProveedorListado;
        private UcFiltrosConsignaciones ucFiltrosConsignaciones;
        private Framework.WinForm.Controls.MetroPager HistorialConsignacionesPager;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}