using LaPaz.Win.Forms.Compras;

namespace LaPaz.Win.Forms.Senias
{
    partial class FrmCrearSeniaProveedor
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.UcBuscadorProveedor = new LaPaz.Win.Forms.Compras.UcBuscadorProveedor();
            this.UcTotalesSeña = new LaPaz.Win.Forms.Senias.UcTotalesSenia();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.TabSeñas = new Telerik.WinControls.UI.RadPageView();
            this.TabSeñasNueva = new Telerik.WinControls.UI.RadPageViewPage();
            this.TabSeñasHistorial = new Telerik.WinControls.UI.RadPageViewPage();
            this.ProveedorSeniasPager = new Framework.WinForm.Controls.MetroPager();
            this.GridSenias = new Telerik.WinControls.UI.RadGridView();
            this.UcProveedorDetalle = new LaPaz.Win.Forms.Proveedores.UcProveedorDetalle();
            this.PanelPagos = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabSeñas)).BeginInit();
            this.TabSeñas.SuspendLayout();
            this.TabSeñasNueva.SuspendLayout();
            this.TabSeñasHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSenias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSenias.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelPagos)).BeginInit();
            this.PanelPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UcBuscadorProveedor
            // 
            this.UcBuscadorProveedor.Location = new System.Drawing.Point(3, 3);
            this.UcBuscadorProveedor.Name = "UcBuscadorProveedor";
            this.UcBuscadorProveedor.Size = new System.Drawing.Size(748, 41);
            this.UcBuscadorProveedor.TabIndex = 0;
            // 
            // UcTotalesSeña
            // 
            this.UcTotalesSeña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcTotalesSeña.Location = new System.Drawing.Point(0, 0);
            this.UcTotalesSeña.Name = "UcTotalesSeña";
            this.UcTotalesSeña.Size = new System.Drawing.Size(910, 296);
            this.UcTotalesSeña.TabIndex = 1;
            this.UcTotalesSeña.TotalPagar = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(853, 355);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 29);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TabSeñas
            // 
            this.TabSeñas.Controls.Add(this.TabSeñasNueva);
            this.TabSeñas.Controls.Add(this.TabSeñasHistorial);
            this.TabSeñas.Location = new System.Drawing.Point(8, 10);
            this.TabSeñas.Name = "TabSeñas";
            this.TabSeñas.SelectedPage = this.TabSeñasNueva;
            this.TabSeñas.Size = new System.Drawing.Size(920, 332);
            this.TabSeñas.TabIndex = 40;
            this.TabSeñas.Text = "radPageView1";
            this.TabSeñas.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.TabSeñas.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // TabSeñasNueva
            // 
            this.TabSeñasNueva.Controls.Add(this.UcTotalesSeña);
            this.TabSeñasNueva.Location = new System.Drawing.Point(5, 31);
            this.TabSeñasNueva.Name = "TabSeñasNueva";
            this.TabSeñasNueva.Size = new System.Drawing.Size(910, 296);
            this.TabSeñasNueva.Text = "Nueva Seña";
            // 
            // TabSeñasHistorial
            // 
            this.TabSeñasHistorial.Controls.Add(this.ProveedorSeniasPager);
            this.TabSeñasHistorial.Controls.Add(this.GridSenias);
            this.TabSeñasHistorial.Location = new System.Drawing.Point(5, 31);
            this.TabSeñasHistorial.Name = "TabSeñasHistorial";
            this.TabSeñasHistorial.Size = new System.Drawing.Size(910, 296);
            this.TabSeñasHistorial.Text = "Historial";
            // 
            // ProveedorSeniasPager
            // 
            this.ProveedorSeniasPager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProveedorSeniasPager.CurrentPage = 1;
            this.ProveedorSeniasPager.Location = new System.Drawing.Point(523, 0);
            this.ProveedorSeniasPager.Name = "ProveedorSeniasPager";
            this.ProveedorSeniasPager.PageSize = 50;
            this.ProveedorSeniasPager.PageTotal = 1;
            this.ProveedorSeniasPager.RefreshAction = null;
            this.ProveedorSeniasPager.RefreshActionAsync = null;
            this.ProveedorSeniasPager.Size = new System.Drawing.Size(378, 39);
            this.ProveedorSeniasPager.TabIndex = 11;
            // 
            // GridSenias
            // 
            this.GridSenias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridSenias.Location = new System.Drawing.Point(6, 45);
            // 
            // GridSenias
            // 
            this.GridSenias.MasterTemplate.AllowAddNewRow = false;
            this.GridSenias.MasterTemplate.AllowColumnReorder = false;
            this.GridSenias.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn6.FieldName = "FechaAlta";
            gridViewTextBoxColumn6.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn6.HeaderText = "Fecha";
            gridViewTextBoxColumn6.MaxWidth = 150;
            gridViewTextBoxColumn6.MinWidth = 150;
            gridViewTextBoxColumn6.Name = "Fecha";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.FieldName = "Importe";
            gridViewTextBoxColumn7.FormatString = "{0:c2}";
            gridViewTextBoxColumn7.HeaderText = "Importe";
            gridViewTextBoxColumn7.Name = "Importe";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Width = 363;
            gridViewTextBoxColumn8.Expression = "";
            gridViewTextBoxColumn8.FieldName = "ImporteUsado";
            gridViewTextBoxColumn8.HeaderText = "Utilizado";
            gridViewTextBoxColumn8.MaxWidth = 100;
            gridViewTextBoxColumn8.Name = "Utilizado";
            gridViewTextBoxColumn8.Width = 95;
            gridViewTextBoxColumn9.Expression = "Importe - Utilizado ";
            gridViewTextBoxColumn9.HeaderText = "Disponible";
            gridViewTextBoxColumn9.MaxWidth = 100;
            gridViewTextBoxColumn9.Name = "Disponible";
            gridViewTextBoxColumn9.Width = 100;
            gridViewTextBoxColumn10.FieldName = "FechaAnulacion";
            gridViewTextBoxColumn10.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn10.HeaderText = "Fecha Anulación";
            gridViewTextBoxColumn10.MaxWidth = 120;
            gridViewTextBoxColumn10.MinWidth = 120;
            gridViewTextBoxColumn10.Name = "FechaAnulacion";
            gridViewTextBoxColumn10.Width = 120;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "Eliminar";
            gridViewCommandColumn3.Width = 30;
            gridViewCommandColumn4.HeaderText = "";
            gridViewCommandColumn4.Image = global::LaPaz.Win.Properties.Resources.Pagar;
            gridViewCommandColumn4.MaxWidth = 30;
            gridViewCommandColumn4.MinWidth = 30;
            gridViewCommandColumn4.Name = "Anular";
            gridViewCommandColumn4.Width = 30;
            this.GridSenias.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewCommandColumn3,
            gridViewCommandColumn4});
            this.GridSenias.MasterTemplate.EnableGrouping = false;
            this.GridSenias.Name = "GridSenias";
            this.GridSenias.ReadOnly = true;
            this.GridSenias.Size = new System.Drawing.Size(904, 248);
            this.GridSenias.TabIndex = 0;
            this.GridSenias.ThemeName = "TelerikMetroBlue";
            this.GridSenias.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridSenias_CommandCellClick);
            // 
            // UcProveedorDetalle
            // 
            this.UcProveedorDetalle.Cuit = "";
            this.UcProveedorDetalle.Denominacion = "";
            this.UcProveedorDetalle.Disponible = null;
            this.UcProveedorDetalle.Domicilio = "";
            this.UcProveedorDetalle.Localidad = "";
            this.UcProveedorDetalle.Location = new System.Drawing.Point(3, 3);
            this.UcProveedorDetalle.Name = "UcProveedorDetalle";
            this.UcProveedorDetalle.Provincia = "";
            this.UcProveedorDetalle.Size = new System.Drawing.Size(760, 120);
            this.UcProveedorDetalle.TabIndex = 41;
            // 
            // PanelPagos
            // 
            this.PanelPagos.Controls.Add(this.TabSeñas);
            this.PanelPagos.Controls.Add(this.BtnGuardar);
            this.PanelPagos.Location = new System.Drawing.Point(13, 196);
            this.PanelPagos.Name = "PanelPagos";
            this.PanelPagos.Size = new System.Drawing.Size(942, 397);
            this.PanelPagos.TabIndex = 42;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.UcProveedorDetalle);
            this.radPanel2.Location = new System.Drawing.Point(13, 65);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(942, 125);
            this.radPanel2.TabIndex = 43;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.UcBuscadorProveedor);
            this.radPanel3.Location = new System.Drawing.Point(12, 12);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(943, 47);
            this.radPanel3.TabIndex = 44;
            // 
            // FrmCrearSeniaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 731);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.PanelPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearSeniaProveedor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Señas a Proveedor";
            this.Load += new System.EventHandler(this.FrmCrearSeniaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabSeñas)).EndInit();
            this.TabSeñas.ResumeLayout(false);
            this.TabSeñasNueva.ResumeLayout(false);
            this.TabSeñasHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSenias.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSenias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelPagos)).EndInit();
            this.PanelPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcBuscadorProveedor UcBuscadorProveedor;
        private UcTotalesSenia UcTotalesSeña;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadPageView TabSeñas;
        private Telerik.WinControls.UI.RadPageViewPage TabSeñasNueva;
        private Telerik.WinControls.UI.RadPageViewPage TabSeñasHistorial;
        private Telerik.WinControls.UI.RadGridView GridSenias;
        private LaPaz.Win.Forms.Proveedores.UcProveedorDetalle UcProveedorDetalle;
        private Telerik.WinControls.UI.RadPanel PanelPagos;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Framework.WinForm.Controls.MetroPager ProveedorSeniasPager;
    }
}
