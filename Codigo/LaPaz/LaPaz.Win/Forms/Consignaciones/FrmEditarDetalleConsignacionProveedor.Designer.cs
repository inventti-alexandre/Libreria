namespace LaPaz.Win.Forms.Consignaciones
{
    partial class FrmEditarDetalleConsignacionProveedor
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.LblNuevoImporte = new Telerik.WinControls.UI.RadLabel();
            this.GridConsignacionTitulos = new Telerik.WinControls.UI.RadGridView();
            this.TxtNuevoImporte = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtObservaciones = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtImporteActual = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtProveedor = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPagado = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtLcn = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtFechaConsignacion = new Telerik.WinControls.UI.RadTextBox();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.LblNuevoImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignacionTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignacionTitulos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNuevoImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporteActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLcn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFechaConsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNuevoImporte
            // 
            this.LblNuevoImporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevoImporte.Location = new System.Drawing.Point(423, 97);
            this.LblNuevoImporte.Name = "LblNuevoImporte";
            this.LblNuevoImporte.Size = new System.Drawing.Size(114, 24);
            this.LblNuevoImporte.TabIndex = 69;
            this.LblNuevoImporte.Text = "Nuevo Importe:";
            this.LblNuevoImporte.ThemeName = "TelerikMetroBlue";
            // 
            // GridConsignacionTitulos
            // 
            this.GridConsignacionTitulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridConsignacionTitulos.Location = new System.Drawing.Point(12, 269);
            // 
            // GridConsignacionTitulos
            // 
            this.GridConsignacionTitulos.MasterTemplate.AllowAddNewRow = false;
            this.GridConsignacionTitulos.MasterTemplate.AllowDeleteRow = false;
            this.GridConsignacionTitulos.MasterTemplate.AllowDragToGroup = false;
            this.GridConsignacionTitulos.MasterTemplate.AutoGenerateColumns = false;
            this.GridConsignacionTitulos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TituloNombre";
            gridViewTextBoxColumn1.HeaderText = "Título";
            gridViewTextBoxColumn1.MinWidth = 200;
            gridViewTextBoxColumn1.Name = "TituloNombre";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 248;
            gridViewTextBoxColumn2.FieldName = "TituloAutor";
            gridViewTextBoxColumn2.HeaderText = "Autor";
            gridViewTextBoxColumn2.MinWidth = 120;
            gridViewTextBoxColumn2.Name = "TituloAutor";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "TituloCodigo";
            gridViewTextBoxColumn3.HeaderText = "Cod";
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "TituloCodigo";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 100;
            gridViewDecimalColumn1.FieldName = "PrecioCompra";
            gridViewDecimalColumn1.FormatString = "{0:c}";
            gridViewDecimalColumn1.HeaderText = "Precio Compra";
            gridViewDecimalColumn1.MinWidth = 120;
            gridViewDecimalColumn1.Name = "PrecioCompra";
            gridViewDecimalColumn1.Width = 120;
            gridViewTextBoxColumn4.FieldName = "PrecioVenta";
            gridViewTextBoxColumn4.FormatString = "{0:c}";
            gridViewTextBoxColumn4.HeaderText = "Precio Venta";
            gridViewTextBoxColumn4.MinWidth = 120;
            gridViewTextBoxColumn4.Name = "PrecioVenta";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 120;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Cantidad";
            gridViewTextBoxColumn5.HeaderText = "Cant Rend.";
            gridViewTextBoxColumn5.MinWidth = 85;
            gridViewTextBoxColumn5.Name = "Cantidad";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 90;
            gridViewTextBoxColumn6.FieldName = "Importe";
            gridViewTextBoxColumn6.FormatString = "{0:c}";
            gridViewTextBoxColumn6.HeaderText = "Importe";
            gridViewTextBoxColumn6.MinWidth = 120;
            gridViewTextBoxColumn6.Name = "Importe";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 120;
            this.GridConsignacionTitulos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.GridConsignacionTitulos.MasterTemplate.EnableGrouping = false;
            this.GridConsignacionTitulos.Name = "GridConsignacionTitulos";
            this.GridConsignacionTitulos.Size = new System.Drawing.Size(934, 269);
            this.GridConsignacionTitulos.TabIndex = 70;
            this.GridConsignacionTitulos.ThemeName = "TelerikMetroBlue";
            this.GridConsignacionTitulos.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GridConsignacionTitulos_CellValueChanged);
            // 
            // TxtNuevoImporte
            // 
            this.TxtNuevoImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNuevoImporte.Enabled = false;
            this.TxtNuevoImporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNuevoImporte.Location = new System.Drawing.Point(541, 96);
            this.TxtNuevoImporte.Name = "TxtNuevoImporte";
            this.TxtNuevoImporte.Size = new System.Drawing.Size(277, 26);
            this.TxtNuevoImporte.TabIndex = 68;
            this.TxtNuevoImporte.TabStop = false;
            this.TxtNuevoImporte.ThemeName = "TelerikMetroBlue";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObservaciones.Enabled = false;
            this.TxtObservaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(123, 142);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            // 
            // 
            // 
            this.TxtObservaciones.RootElement.StretchVertically = true;
            this.TxtObservaciones.Size = new System.Drawing.Size(695, 100);
            this.TxtObservaciones.TabIndex = 16;
            this.TxtObservaciones.TabStop = false;
            this.TxtObservaciones.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(423, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(65, 24);
            this.radLabel1.TabIndex = 67;
            this.radLabel1.Text = "Importe:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(12, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 24);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Proveedor:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtImporteActual
            // 
            this.TxtImporteActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtImporteActual.Enabled = false;
            this.TxtImporteActual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporteActual.Location = new System.Drawing.Point(541, 12);
            this.TxtImporteActual.Name = "TxtImporteActual";
            this.TxtImporteActual.Size = new System.Drawing.Size(277, 26);
            this.TxtImporteActual.TabIndex = 64;
            this.TxtImporteActual.TabStop = false;
            this.TxtImporteActual.ThemeName = "TelerikMetroBlue";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProveedor.Enabled = false;
            this.TxtProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.Location = new System.Drawing.Point(121, 11);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(277, 26);
            this.TxtProveedor.TabIndex = 58;
            this.TxtProveedor.TabStop = false;
            this.TxtProveedor.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(423, 55);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(62, 24);
            this.radLabel2.TabIndex = 68;
            this.radLabel2.Text = "Pagado:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(12, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 24);
            this.metroLabel2.TabIndex = 62;
            this.metroLabel2.Text = "LCN:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPagado
            // 
            this.TxtPagado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPagado.Enabled = false;
            this.TxtPagado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPagado.Location = new System.Drawing.Point(541, 54);
            this.TxtPagado.MaxLength = 80;
            this.TxtPagado.Name = "TxtPagado";
            this.TxtPagado.Size = new System.Drawing.Size(277, 26);
            this.TxtPagado.TabIndex = 65;
            this.TxtPagado.TabStop = false;
            this.TxtPagado.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 142);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(110, 24);
            this.radLabel3.TabIndex = 69;
            this.radLabel3.Text = "Observaciones:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // TxtLcn
            // 
            this.TxtLcn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLcn.Enabled = false;
            this.TxtLcn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLcn.Location = new System.Drawing.Point(121, 53);
            this.TxtLcn.MaxLength = 80;
            this.TxtLcn.Name = "TxtLcn";
            this.TxtLcn.Size = new System.Drawing.Size(277, 26);
            this.TxtLcn.TabIndex = 59;
            this.TxtLcn.TabStop = false;
            this.TxtLcn.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(12, 96);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 24);
            this.metroLabel3.TabIndex = 63;
            this.metroLabel3.Text = "Fecha Consig.:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // TxtFechaConsignacion
            // 
            this.TxtFechaConsignacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFechaConsignacion.Enabled = false;
            this.TxtFechaConsignacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaConsignacion.Location = new System.Drawing.Point(121, 95);
            this.TxtFechaConsignacion.MaxLength = 100;
            this.TxtFechaConsignacion.Name = "TxtFechaConsignacion";
            this.TxtFechaConsignacion.Size = new System.Drawing.Size(277, 26);
            this.TxtFechaConsignacion.TabIndex = 60;
            this.TxtFechaConsignacion.TabStop = false;
            this.TxtFechaConsignacion.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(730, 553);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 18;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(843, 553);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // FrmEditarDetalleConsignacionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 595);
            this.Controls.Add(this.LblNuevoImporte);
            this.Controls.Add(this.GridConsignacionTitulos);
            this.Controls.Add(this.TxtNuevoImporte);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtImporteActual);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtPagado);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.TxtLcn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtFechaConsignacion);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEditarDetalleConsignacionProveedor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Consignación Proveedor";
            this.Load += new System.EventHandler(this.FrmEditarDetalleConsignacionProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LblNuevoImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignacionTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignacionTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNuevoImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporteActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLcn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFechaConsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtProveedor;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtLcn;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtFechaConsignacion;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtImporteActual;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtPagado;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtObservaciones;
        private Telerik.WinControls.UI.RadGridView GridConsignacionTitulos;
        private Telerik.WinControls.UI.RadLabel LblNuevoImporte;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtNuevoImporte;
    }
}