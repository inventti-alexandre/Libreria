namespace LaPaz.Win.Forms.Ventas
{
    partial class UcTitulosVenta
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.GrillaTitulos = new Telerik.WinControls.UI.RadGridView();
            this.Eliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.BtnAgregarTitulo = new Telerik.WinControls.UI.RadButton();
            this.deleteColumn1 = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.btnAgregarPresupuesto = new Telerik.WinControls.UI.RadButton();
            this.lblCantidad = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaTitulos
            // 
            this.GrillaTitulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaTitulos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaTitulos.Location = new System.Drawing.Point(4, 43);
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
            gridViewTextBoxColumn1.FieldName = "Cod";
            gridViewTextBoxColumn1.HeaderText = "Código";
            gridViewTextBoxColumn1.MaxWidth = 140;
            gridViewTextBoxColumn1.MinWidth = 140;
            gridViewTextBoxColumn1.Name = "Codigo";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 140;
            gridViewTextBoxColumn2.FieldName = "TituloNombre";
            gridViewTextBoxColumn2.HeaderText = "Titulo";
            gridViewTextBoxColumn2.MaxWidth = 500;
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 146;
            gridViewTextBoxColumn3.FieldName = "PrecioBase";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Precio";
            gridViewTextBoxColumn3.MaxWidth = 70;
            gridViewTextBoxColumn3.MinWidth = 70;
            gridViewTextBoxColumn3.Name = "PrecioVenta";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 70;
            gridViewTextBoxColumn4.FieldName = "Cantidad";
            gridViewTextBoxColumn4.HeaderText = "Cantidad";
            gridViewTextBoxColumn4.MaxWidth = 70;
            gridViewTextBoxColumn4.MinWidth = 70;
            gridViewTextBoxColumn4.Name = "Cantidad";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 70;
            gridViewTextBoxColumn5.FieldName = "Descuento";
            gridViewTextBoxColumn5.HeaderText = "Descuento";
            gridViewTextBoxColumn5.MaxWidth = 80;
            gridViewTextBoxColumn5.MinWidth = 80;
            gridViewTextBoxColumn5.Name = "Descuento";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 80;
            gridViewTextBoxColumn6.FieldName = "SubTotal";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "SubTotal";
            gridViewTextBoxColumn6.MaxWidth = 70;
            gridViewTextBoxColumn6.MinWidth = 70;
            gridViewTextBoxColumn6.Name = "SubTotal";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 70;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Eliminar";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "Editar";
            gridViewCommandColumn2.Width = 30;
            gridViewTextBoxColumn7.FieldName = "PrecioBase";
            gridViewTextBoxColumn7.HeaderText = "Base";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "column1";
            gridViewTextBoxColumn7.Width = 31;
            this.GrillaTitulos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewTextBoxColumn7});
            this.GrillaTitulos.MasterTemplate.EnableGrouping = false;
            this.GrillaTitulos.Name = "GrillaTitulos";
            this.GrillaTitulos.ReadOnly = true;
            this.GrillaTitulos.Size = new System.Drawing.Size(651, 155);
            this.GrillaTitulos.TabIndex = 40;
            this.GrillaTitulos.ThemeName = "TelerikMetroBlue";
            this.GrillaTitulos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaTitulos_CommandCellClick);
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
            // BtnAgregarTitulo
            // 
            this.BtnAgregarTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarTitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAgregarTitulo.Location = new System.Drawing.Point(555, 5);
            this.BtnAgregarTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregarTitulo.Name = "BtnAgregarTitulo";
            this.BtnAgregarTitulo.Size = new System.Drawing.Size(100, 28);
            this.BtnAgregarTitulo.TabIndex = 41;
            this.BtnAgregarTitulo.Text = "Agregar";
            this.BtnAgregarTitulo.ThemeName = "TelerikMetroBlue";
            this.BtnAgregarTitulo.Click += new System.EventHandler(this.BtnAgregarTitulo_Click);
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
            // btnAgregarPresupuesto
            // 
            this.btnAgregarPresupuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPresupuesto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAgregarPresupuesto.Location = new System.Drawing.Point(447, 5);
            this.btnAgregarPresupuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarPresupuesto.Name = "btnAgregarPresupuesto";
            this.btnAgregarPresupuesto.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarPresupuesto.TabIndex = 42;
            this.btnAgregarPresupuesto.Text = "Agregar";
            this.btnAgregarPresupuesto.ThemeName = "TelerikMetroBlue";
            this.btnAgregarPresupuesto.Visible = false;
            this.btnAgregarPresupuesto.Click += new System.EventHandler(this.btnAgregarPresupuesto_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(21, 206);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(148, 24);
            this.lblCantidad.TabIndex = 43;
            this.lblCantidad.Text = "Cantidad de libros: 0";
            this.lblCantidad.ThemeName = "TelerikMetroBlue";
            // 
            // UcTitulosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAgregarPresupuesto);
            this.Controls.Add(this.BtnAgregarTitulo);
            this.Controls.Add(this.GrillaTitulos);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcTitulosVenta";
            this.Size = new System.Drawing.Size(667, 236);
            this.Load += new System.EventHandler(this.UcTitulosVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrillaTitulos;
        private Telerik.WinControls.UI.RadButton BtnAgregarTitulo;
        private Controls.DeleteCell.DeleteColumn deleteColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoPago;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descripcion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PrecioVenta;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cantidad;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descuento;
        private Telerik.WinControls.UI.GridViewTextBoxColumn SubTotal;
        private Controls.DeleteCell.DeleteColumn Eliminar;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton btnAgregarPresupuesto;
        private Telerik.WinControls.UI.RadLabel lblCantidad;
    }
}
