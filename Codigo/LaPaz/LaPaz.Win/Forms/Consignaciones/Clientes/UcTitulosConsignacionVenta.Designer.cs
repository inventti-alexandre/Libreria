namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    partial class UcTitulosConsignacionVenta
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

        #region Component Designer generated code

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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.Eliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.deleteColumn1 = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.lblCantidad = new Telerik.WinControls.UI.RadLabel();
            this.GrillaTitulos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 25F;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 30;
            // 
            // deleteColumn1
            // 
            this.deleteColumn1.FillWeight = 25F;
            this.deleteColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteColumn1.HeaderText = "";
            this.deleteColumn1.Name = "deleteColumn1";
            this.deleteColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn1.Width = 18;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = false;
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(0, 212);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(823, 24);
            this.lblCantidad.TabIndex = 43;
            this.lblCantidad.Text = "Cantidad de libros: 0";
            this.lblCantidad.ThemeName = "TelerikMetroBlue";
            // 
            // GrillaTitulos
            // 
            this.GrillaTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaTitulos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaTitulos.Location = new System.Drawing.Point(0, 0);
            this.GrillaTitulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // GrillaTitulos
            // 
            this.GrillaTitulos.MasterTemplate.AllowAddNewRow = false;
            this.GrillaTitulos.MasterTemplate.AllowColumnReorder = false;
            this.GrillaTitulos.MasterTemplate.AllowDeleteRow = false;
            this.GrillaTitulos.MasterTemplate.AllowDragToGroup = false;
            this.GrillaTitulos.MasterTemplate.AllowEditRow = false;
            this.GrillaTitulos.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaTitulos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TituloCod";
            gridViewTextBoxColumn1.HeaderText = "Código";
            gridViewTextBoxColumn1.MaxWidth = 120;
            gridViewTextBoxColumn1.MinWidth = 120;
            gridViewTextBoxColumn1.Name = "Codigo";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 120;
            gridViewTextBoxColumn2.FieldName = "TituloNombreTitulo";
            gridViewTextBoxColumn2.HeaderText = "Titulo";
            gridViewTextBoxColumn2.MaxWidth = 500;
            gridViewTextBoxColumn2.MinWidth = 150;
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 195;
            gridViewTextBoxColumn3.FieldName = "Cantidad";
            gridViewTextBoxColumn3.HeaderText = "Cantidad";
            gridViewTextBoxColumn3.MaxWidth = 65;
            gridViewTextBoxColumn3.MinWidth = 65;
            gridViewTextBoxColumn3.Name = "Cantidad";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 65;
            gridViewTextBoxColumn4.FieldName = "CntVendida";
            gridViewTextBoxColumn4.HeaderText = "Rendida";
            gridViewTextBoxColumn4.MaxWidth = 65;
            gridViewTextBoxColumn4.MinWidth = 65;
            gridViewTextBoxColumn4.Name = "CntVendida";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 65;
            gridViewTextBoxColumn5.FieldName = "CntDevuelta";
            gridViewTextBoxColumn5.HeaderText = "Devuelta";
            gridViewTextBoxColumn5.MaxWidth = 65;
            gridViewTextBoxColumn5.MinWidth = 65;
            gridViewTextBoxColumn5.Name = "CntDevuelta";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 65;
            gridViewTextBoxColumn6.FieldName = "PrecioVenta";
            gridViewTextBoxColumn6.FormatString = "{0:N2}";
            gridViewTextBoxColumn6.HeaderText = "Precio";
            gridViewTextBoxColumn6.MaxWidth = 60;
            gridViewTextBoxColumn6.MinWidth = 60;
            gridViewTextBoxColumn6.Name = "PrecioBase";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 60;
            gridViewTextBoxColumn7.FieldName = "TituloPrecioVentaTitulo";
            gridViewTextBoxColumn7.FormatString = "{0:N2}";
            gridViewTextBoxColumn7.HeaderText = "Pr. Actual";
            gridViewTextBoxColumn7.MaxWidth = 70;
            gridViewTextBoxColumn7.MinWidth = 70;
            gridViewTextBoxColumn7.Name = "PrecioActual";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Width = 70;
            gridViewTextBoxColumn8.FieldName = "PrecioFinal";
            gridViewTextBoxColumn8.FormatString = "{0:N2}";
            gridViewTextBoxColumn8.HeaderText = "Pr. Final";
            gridViewTextBoxColumn8.MaxWidth = 60;
            gridViewTextBoxColumn8.MinWidth = 60;
            gridViewTextBoxColumn8.Name = "PrecioFinal";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn8.Width = 60;
            gridViewTextBoxColumn9.FieldName = "SubTotal";
            gridViewTextBoxColumn9.FormatString = "{0:N2}";
            gridViewTextBoxColumn9.HeaderText = "SubTotal";
            gridViewTextBoxColumn9.MaxWidth = 70;
            gridViewTextBoxColumn9.MinWidth = 70;
            gridViewTextBoxColumn9.Name = "SubTotal";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Width = 70;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.MaxWidth = 40;
            gridViewCommandColumn1.MinWidth = 40;
            gridViewCommandColumn1.Name = "Editar";
            gridViewCommandColumn1.Width = 40;
            this.GrillaTitulos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewCommandColumn1});
            this.GrillaTitulos.MasterTemplate.EnableGrouping = false;
            this.GrillaTitulos.Name = "GrillaTitulos";
            this.GrillaTitulos.ReadOnly = true;
            this.GrillaTitulos.Size = new System.Drawing.Size(823, 212);
            this.GrillaTitulos.TabIndex = 45;
            this.GrillaTitulos.ThemeName = "TelerikMetroBlue";
            this.GrillaTitulos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaTitulos_CommandCellClick);
            // 
            // UcTitulosConsignacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrillaTitulos);
            this.Controls.Add(this.lblCantidad);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcTitulosConsignacionVenta";
            this.Size = new System.Drawing.Size(823, 236);
            this.Load += new System.EventHandler(this.UcTitulosVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DeleteCell.DeleteColumn deleteColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoPago;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descripcion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PrecioVenta;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cantidad;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descuento;
        private Telerik.WinControls.UI.GridViewTextBoxColumn SubTotal;
        private Controls.DeleteCell.DeleteColumn Eliminar;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadLabel lblCantidad;
        private Telerik.WinControls.UI.RadGridView GrillaTitulos;
    }
}
