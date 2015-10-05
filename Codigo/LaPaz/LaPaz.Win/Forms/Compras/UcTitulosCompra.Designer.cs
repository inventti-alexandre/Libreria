namespace LaPaz.Win.Forms.Compras
{
    partial class UcTitulosCompra
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
            this.BtnAgregarTitulo = new Telerik.WinControls.UI.RadButton();
            this.GrillaTitulos = new Telerik.WinControls.UI.RadGridView();
            this.lblCantidad = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarTitulo
            // 
            this.BtnAgregarTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarTitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAgregarTitulo.Location = new System.Drawing.Point(756, 9);
            this.BtnAgregarTitulo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAgregarTitulo.Name = "BtnAgregarTitulo";
            this.BtnAgregarTitulo.Size = new System.Drawing.Size(133, 34);
            this.BtnAgregarTitulo.TabIndex = 43;
            this.BtnAgregarTitulo.Text = "Agregar";
            this.BtnAgregarTitulo.ThemeName = "TelerikMetroBlue";
            this.BtnAgregarTitulo.Click += new System.EventHandler(this.BtnAgregarTitulo_Click);
            // 
            // GrillaTitulos
            // 
            this.GrillaTitulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaTitulos.AutoScroll = true;
            this.GrillaTitulos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaTitulos.Location = new System.Drawing.Point(0, 55);
            this.GrillaTitulos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "Codigo";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 135;
            gridViewTextBoxColumn2.FieldName = "TituloNombre";
            gridViewTextBoxColumn2.HeaderText = "Titulo";
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 135;
            gridViewTextBoxColumn3.FieldName = "PrecioBase";
            gridViewTextBoxColumn3.HeaderText = "Precio de Compra";
            gridViewTextBoxColumn3.Name = "PrecioCompra";
            gridViewTextBoxColumn3.Width = 124;
            gridViewTextBoxColumn4.FieldName = "PrecioVenta";
            gridViewTextBoxColumn4.HeaderText = "Precio";
            gridViewTextBoxColumn4.Name = "PrecioVenta";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 135;
            gridViewTextBoxColumn5.FieldName = "CantidadCompra";
            gridViewTextBoxColumn5.HeaderText = "Cantidad";
            gridViewTextBoxColumn5.Name = "Cantidad";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 135;
            gridViewTextBoxColumn6.FieldName = "SubTotal";
            gridViewTextBoxColumn6.HeaderText = "SubTotal";
            gridViewTextBoxColumn6.Name = "SubTotal";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 150;
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
            this.GrillaTitulos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.GrillaTitulos.MasterTemplate.EnableGrouping = false;
            this.GrillaTitulos.Name = "GrillaTitulos";
            this.GrillaTitulos.Size = new System.Drawing.Size(889, 182);
            this.GrillaTitulos.TabIndex = 42;
            this.GrillaTitulos.ThemeName = "TelerikMetroBlue";
            this.GrillaTitulos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaTitulos_CommandCellClick);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(28, 254);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(184, 29);
            this.lblCantidad.TabIndex = 44;
            this.lblCantidad.Text = "Cantidad de libros: 0";
            this.lblCantidad.ThemeName = "TelerikMetroBlue";
            // 
            // UcTitulosCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.BtnAgregarTitulo);
            this.Controls.Add(this.GrillaTitulos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcTitulosCompra";
            this.Size = new System.Drawing.Size(889, 290);
            this.Load += new System.EventHandler(this.UcTitulosCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnAgregarTitulo;
        private Telerik.WinControls.UI.RadGridView GrillaTitulos;
        private Telerik.WinControls.UI.RadLabel lblCantidad;
    }
}
