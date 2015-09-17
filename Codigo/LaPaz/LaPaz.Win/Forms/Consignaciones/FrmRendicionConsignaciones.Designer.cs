using LaPaz.Win.Forms.Autores;

namespace LaPaz.Win.Forms.Consignaciones
{
    partial class FrmRendicionConsignaciones
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.BtnImprimir = new Telerik.WinControls.UI.RadButton();
            this.lblObservaciones = new Telerik.WinControls.UI.RadLabel();
            this.TxtObservaciones = new Telerik.WinControls.UI.RadTextBox();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.chxImprimir = new System.Windows.Forms.CheckBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.ucFiltrosConsignaciones = new LaPaz.Win.Forms.Consignaciones.UcFiltrosConsignaciones();
            this.scrlPanel = new Telerik.WinControls.UI.RadScrollablePanel();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrlPanel)).BeginInit();
            this.scrlPanel.PanelContainer.SuspendLayout();
            this.scrlPanel.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.scrlPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1300, 820);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlAcciones);
            this.panel1.Controls.Add(this.ucFiltrosConsignaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 92);
            this.panel1.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.BtnImprimir);
            this.pnlAcciones.Controls.Add(this.lblObservaciones);
            this.pnlAcciones.Controls.Add(this.TxtObservaciones);
            this.pnlAcciones.Controls.Add(this.BtnGuardar);
            this.pnlAcciones.Controls.Add(this.chxImprimir);
            this.pnlAcciones.Controls.Add(this.lblTotalValue);
            this.pnlAcciones.Controls.Add(this.lblTotal1);
            this.pnlAcciones.Location = new System.Drawing.Point(640, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(647, 100);
            this.pnlAcciones.TabIndex = 97;
            this.pnlAcciones.Visible = false;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(380, 35);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(88, 29);
            this.BtnImprimir.TabIndex = 8;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.ThemeName = "TelerikMetroBlue";
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(16, 9);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(110, 24);
            this.lblObservaciones.TabIndex = 95;
            this.lblObservaciones.Text = "Observaciones:";
            this.lblObservaciones.ThemeName = "TelerikMetroBlue";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObservaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(16, 35);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            // 
            // 
            // 
            this.TxtObservaciones.RootElement.StretchVertically = true;
            this.TxtObservaciones.Size = new System.Drawing.Size(233, 45);
            this.TxtObservaciones.TabIndex = 96;
            this.TxtObservaciones.TabStop = false;
            this.TxtObservaciones.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(272, 35);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 29);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // chxImprimir
            // 
            this.chxImprimir.AutoSize = true;
            this.chxImprimir.Enabled = false;
            this.chxImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chxImprimir.Location = new System.Drawing.Point(272, 65);
            this.chxImprimir.Name = "chxImprimir";
            this.chxImprimir.Size = new System.Drawing.Size(72, 19);
            this.chxImprimir.TabIndex = 7;
            this.chxImprimir.Text = "Imprimir";
            this.chxImprimir.UseVisualStyleBackColor = true;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(393, 9);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(56, 25);
            this.lblTotalValue.TabIndex = 9;
            this.lblTotalValue.Text = "$500";
            this.lblTotalValue.Visible = false;
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(267, 9);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(129, 25);
            this.lblTotal1.TabIndex = 8;
            this.lblTotal1.Text = "Total General:";
            this.lblTotal1.Visible = false;
            // 
            // ucFiltrosConsignaciones
            // 
            this.ucFiltrosConsignaciones.Desde = new System.DateTime(2015, 8, 17, 10, 57, 54, 589);
            this.ucFiltrosConsignaciones.Hasta = new System.DateTime(2015, 9, 17, 10, 57, 54, 582);
            this.ucFiltrosConsignaciones.Location = new System.Drawing.Point(0, 0);
            this.ucFiltrosConsignaciones.Name = "ucFiltrosConsignaciones";
            this.ucFiltrosConsignaciones.ProveedorId = null;
            this.ucFiltrosConsignaciones.Size = new System.Drawing.Size(634, 92);
            this.ucFiltrosConsignaciones.TabIndex = 1;
            // 
            // scrlPanel
            // 
            this.scrlPanel.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.scrlPanel.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.scrlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrlPanel.Location = new System.Drawing.Point(0, 0);
            this.scrlPanel.Name = "scrlPanel";
            this.scrlPanel.Padding = new System.Windows.Forms.Padding(1);
            // 
            // scrlPanel.PanelContainer
            // 
            this.scrlPanel.PanelContainer.AutoScroll = true;
            this.scrlPanel.PanelContainer.Controls.Add(this.flpContainer);
            this.scrlPanel.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrlPanel.PanelContainer.Location = new System.Drawing.Point(1, 1);
            this.scrlPanel.PanelContainer.Name = "PanelContainer";
            this.scrlPanel.PanelContainer.Size = new System.Drawing.Size(1298, 716);
            this.scrlPanel.PanelContainer.TabIndex = 0;
            // 
            // 
            // 
            this.scrlPanel.RootElement.Padding = new System.Windows.Forms.Padding(1);
            this.scrlPanel.Size = new System.Drawing.Size(1300, 718);
            this.scrlPanel.TabIndex = 0;
            this.scrlPanel.Text = "radScrollablePanel1";
            // 
            // flpContainer
            // 
            this.flpContainer.AutoScroll = true;
            this.flpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainer.Location = new System.Drawing.Point(0, 0);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(1298, 716);
            this.flpContainer.TabIndex = 0;
            this.flpContainer.WrapContents = false;
            // 
            // FrmRendicionConsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRendicionConsignaciones";
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
            this.panel1.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            this.scrlPanel.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scrlPanel)).EndInit();
            this.scrlPanel.ResumeLayout(false);
            this.scrlPanel.PerformLayout();
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
        private Telerik.WinControls.UI.RadScrollablePanel scrlPanel;
        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.Panel panel1;
        private UcFiltrosConsignaciones ucFiltrosConsignaciones;
        private System.Windows.Forms.CheckBox chxImprimir;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal1;
        private Telerik.WinControls.UI.RadTextBox TxtObservaciones;
        private Telerik.WinControls.UI.RadLabel lblObservaciones;
        private System.Windows.Forms.Panel pnlAcciones;
        private Telerik.WinControls.UI.RadButton BtnImprimir;
    }
}