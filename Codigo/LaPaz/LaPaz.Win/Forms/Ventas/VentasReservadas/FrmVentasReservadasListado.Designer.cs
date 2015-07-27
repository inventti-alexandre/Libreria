namespace LaPaz.Win.Forms.Ventas.VentasReservadas
{
    partial class FrmVentasReservadasListado
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.GrillaFacturasReservadas = new Telerik.WinControls.UI.RadGridView();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.FacturaPager = new Framework.WinForm.Controls.MetroPager();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFacturasReservadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFacturasReservadas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaFacturasReservadas
            // 
            this.GrillaFacturasReservadas.Location = new System.Drawing.Point(12, 136);
            // 
            // GrillaFacturasReservadas
            // 
            this.GrillaFacturasReservadas.MasterTemplate.AllowAddNewRow = false;
            this.GrillaFacturasReservadas.MasterTemplate.AllowColumnReorder = false;
            this.GrillaFacturasReservadas.MasterTemplate.AllowDeleteRow = false;
            this.GrillaFacturasReservadas.MasterTemplate.AllowDragToGroup = false;
            this.GrillaFacturasReservadas.MasterTemplate.AllowEditRow = false;
            this.GrillaFacturasReservadas.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaFacturasReservadas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "NroReserva";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "NroReserva";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "NroReserva";
            gridViewTextBoxColumn1.Width = 276;
            gridViewTextBoxColumn2.FieldName = "LCN";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nro Factura";
            gridViewTextBoxColumn2.Name = "LCN";
            gridViewTextBoxColumn2.Width = 374;
            gridViewTextBoxColumn3.FieldName = "FechaAlta";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Fecha";
            gridViewTextBoxColumn3.Name = "FechaAlta";
            gridViewTextBoxColumn3.Width = 320;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "ColumnaEditar";
            gridViewCommandColumn1.Width = 30;
            this.GrillaFacturasReservadas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.GrillaFacturasReservadas.MasterTemplate.EnableGrouping = false;
            this.GrillaFacturasReservadas.Name = "GrillaFacturasReservadas";
            this.GrillaFacturasReservadas.ReadOnly = true;
            this.GrillaFacturasReservadas.Size = new System.Drawing.Size(744, 395);
            this.GrillaFacturasReservadas.TabIndex = 0;
            this.GrillaFacturasReservadas.Text = "GrillaFacturasReservadas";
            this.GrillaFacturasReservadas.ThemeName = "TelerikMetroBlue";
            this.GrillaFacturasReservadas.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaFacturasReservadas_CommandCellClick);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Location = new System.Drawing.Point(751, 12);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 1;
            // 
            // FacturaPager
            // 
            this.FacturaPager.CurrentPage = 1;
            this.FacturaPager.Location = new System.Drawing.Point(370, 88);
            this.FacturaPager.Name = "FacturaPager";
            this.FacturaPager.PageSize = 50;
            this.FacturaPager.PageTotal = 1;
            this.FacturaPager.RefreshAction = null;
            this.FacturaPager.RefreshActionAsync = null;
            this.FacturaPager.Size = new System.Drawing.Size(386, 42);
            this.FacturaPager.TabIndex = 2;
            // 
            // FrmVentasReservadasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 579);
            this.Controls.Add(this.FacturaPager);
            this.Controls.Add(this.ucProgressSpinner1);
            this.Controls.Add(this.GrillaFacturasReservadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentasReservadasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ventas reservadas";
            this.Load += new System.EventHandler(this.FrmVentasReservadasListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFacturasReservadas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFacturasReservadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrillaFacturasReservadas;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private Framework.WinForm.Controls.MetroPager FacturaPager;
    }
}