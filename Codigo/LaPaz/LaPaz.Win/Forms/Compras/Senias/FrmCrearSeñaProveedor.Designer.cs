namespace LaPaz.Win.Forms.Compras
{
    partial class FrmCrearSeñaProveedor
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
            this.UcBuscadorProveedor = new LaPaz.Win.Forms.Compras.UcBuscadorProveedor();
            this.UcTotalesSeña = new LaPaz.Win.Forms.Compras.UcTotalesSeña();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.ChkCajaAnterior = new Telerik.WinControls.UI.RadCheckBox();
            this.TabSeñas = new Telerik.WinControls.UI.RadPageView();
            this.TabSeñasNueva = new Telerik.WinControls.UI.RadPageViewPage();
            this.TabSeñasHistorial = new Telerik.WinControls.UI.RadPageViewPage();
            this.GridSeñas = new Telerik.WinControls.UI.RadGridView();
            this.UcProveedorDetalle = new LaPaz.Win.Forms.Proveedores.UcProveedorDetalle();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCajaAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabSeñas)).BeginInit();
            this.TabSeñas.SuspendLayout();
            this.TabSeñasNueva.SuspendLayout();
            this.TabSeñasHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UcBuscadorProveedor
            // 
            this.UcBuscadorProveedor.Location = new System.Drawing.Point(16, 12);
            this.UcBuscadorProveedor.Name = "UcBuscadorProveedor";
            this.UcBuscadorProveedor.Size = new System.Drawing.Size(387, 44);
            this.UcBuscadorProveedor.TabIndex = 0;
            // 
            // UcTotalesSeña
            // 
            this.UcTotalesSeña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcTotalesSeña.Location = new System.Drawing.Point(0, 0);
            this.UcTotalesSeña.Name = "UcTotalesSeña";
            this.UcTotalesSeña.Size = new System.Drawing.Size(870, 359);
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
            this.BtnGuardar.Location = new System.Drawing.Point(733, 575);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 29);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(814, 575);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 29);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ChkCajaAnterior
            // 
            this.ChkCajaAnterior.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCajaAnterior.Location = new System.Drawing.Point(524, 577);
            this.ChkCajaAnterior.Name = "ChkCajaAnterior";
            this.ChkCajaAnterior.Size = new System.Drawing.Size(195, 24);
            this.ChkCajaAnterior.TabIndex = 0;
            this.ChkCajaAnterior.Text = "Efectivo con caja anterior";
            this.ChkCajaAnterior.ThemeName = "TelerikMetroBlue";
            // 
            // TabSeñas
            // 
            this.TabSeñas.Controls.Add(this.TabSeñasNueva);
            this.TabSeñas.Controls.Add(this.TabSeñasHistorial);
            this.TabSeñas.Location = new System.Drawing.Point(8, 176);
            this.TabSeñas.Name = "TabSeñas";
            this.TabSeñas.SelectedPage = this.TabSeñasNueva;
            this.TabSeñas.Size = new System.Drawing.Size(880, 395);
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
            this.TabSeñasNueva.Size = new System.Drawing.Size(870, 359);
            this.TabSeñasNueva.Text = "Nueva Seña";
            // 
            // TabSeñasHistorial
            // 
            this.TabSeñasHistorial.Controls.Add(this.GridSeñas);
            this.TabSeñasHistorial.Location = new System.Drawing.Point(5, 31);
            this.TabSeñasHistorial.Name = "TabSeñasHistorial";
            this.TabSeñasHistorial.Size = new System.Drawing.Size(870, 359);
            this.TabSeñasHistorial.Text = "Historial";
            // 
            // GridSeñas
            // 
            this.GridSeñas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSeñas.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.GridSeñas.MasterTemplate.AllowAddNewRow = false;
            this.GridSeñas.MasterTemplate.AllowColumnReorder = false;
            this.GridSeñas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn1.HeaderText = "Fecha";
            gridViewTextBoxColumn1.MaxWidth = 150;
            gridViewTextBoxColumn1.MinWidth = 150;
            gridViewTextBoxColumn1.Name = "Fecha";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "Importe";
            gridViewTextBoxColumn2.FormatString = "{0:c2}";
            gridViewTextBoxColumn2.HeaderText = "Importe";
            gridViewTextBoxColumn2.MaxWidth = 150;
            gridViewTextBoxColumn2.MinWidth = 150;
            gridViewTextBoxColumn2.Name = "Importe";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 150;
            this.GridSeñas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.GridSeñas.MasterTemplate.EnableGrouping = false;
            this.GridSeñas.Name = "GridSeñas";
            this.GridSeñas.ReadOnly = true;
            this.GridSeñas.Size = new System.Drawing.Size(870, 359);
            this.GridSeñas.TabIndex = 0;
            this.GridSeñas.ThemeName = "TelerikMetroBlue";
            // 
            // UcProveedorDetalle
            // 
            this.UcProveedorDetalle.Cuit = "";
            this.UcProveedorDetalle.Denominacion = "";
            this.UcProveedorDetalle.Domicilio = "";
            this.UcProveedorDetalle.Localidad = "";
            this.UcProveedorDetalle.Location = new System.Drawing.Point(16, 50);
            this.UcProveedorDetalle.Name = "UcProveedorDetalle";
            this.UcProveedorDetalle.Provincia = "";
            this.UcProveedorDetalle.Size = new System.Drawing.Size(849, 120);
            this.UcProveedorDetalle.TabIndex = 41;
            // 
            // FrmCrearSeñaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 780);
            this.Controls.Add(this.ChkCajaAnterior);
            this.Controls.Add(this.UcProveedorDetalle);
            this.Controls.Add(this.TabSeñas);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.UcBuscadorProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearSeñaProveedor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Crear seña a proveedor";
            this.Load += new System.EventHandler(this.FrmCrearSeñaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCajaAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabSeñas)).EndInit();
            this.TabSeñas.ResumeLayout(false);
            this.TabSeñasNueva.ResumeLayout(false);
            this.TabSeñasHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcBuscadorProveedor UcBuscadorProveedor;
        private UcTotalesSeña UcTotalesSeña;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadCheckBox ChkCajaAnterior;
        private Telerik.WinControls.UI.RadPageView TabSeñas;
        private Telerik.WinControls.UI.RadPageViewPage TabSeñasNueva;
        private Telerik.WinControls.UI.RadPageViewPage TabSeñasHistorial;
        private Telerik.WinControls.UI.RadGridView GridSeñas;
        private LaPaz.Win.Forms.Proveedores.UcProveedorDetalle UcProveedorDetalle;

    }
}
