namespace LaPaz.Win.Forms.Reportes
{
    partial class FrmMultiRanking
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            this.ClienteDetalle = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.ClienteEditar = new LaPaz.Win.Controls.EditCell.EditColumn();
            this.ClienteEliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.detailsColumn1 = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.CbxTipoRanking = new Telerik.WinControls.UI.RadDropDownList();
            this.DtpFechaFin = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.DtpFechaInicio = new Telerik.WinControls.UI.RadDateTimePicker();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCantidadFilas = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.CbxColumnas = new Telerik.WinControls.UI.RadDropDownList();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.GridProveedores = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxTipoRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidadFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteDetalle
            // 
            this.ClienteDetalle.FillWeight = 31.2983F;
            this.ClienteDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteDetalle.HeaderText = "";
            this.ClienteDetalle.Name = "ClienteDetalle";
            this.ClienteDetalle.ReadOnly = true;
            this.ClienteDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteDetalle.ToolTipText = "Detalle";
            this.ClienteDetalle.Width = 27;
            // 
            // ClienteEditar
            // 
            this.ClienteEditar.FillWeight = 34.15069F;
            this.ClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteEditar.HeaderText = "";
            this.ClienteEditar.Name = "ClienteEditar";
            this.ClienteEditar.ReadOnly = true;
            this.ClienteEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteEditar.ToolTipText = "Editar";
            this.ClienteEditar.Width = 29;
            // 
            // ClienteEliminar
            // 
            this.ClienteEliminar.FillWeight = 36.90251F;
            this.ClienteEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteEliminar.HeaderText = "";
            this.ClienteEliminar.Name = "ClienteEliminar";
            this.ClienteEliminar.ReadOnly = true;
            this.ClienteEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteEliminar.ToolTipText = "Eliminar";
            this.ClienteEliminar.Width = 31;
            // 
            // detailsColumn1
            // 
            this.detailsColumn1.HeaderText = "";
            this.detailsColumn1.Name = "detailsColumn1";
            this.detailsColumn1.ReadOnly = true;
            this.detailsColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsColumn1.Width = 30;
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
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1271, 1035);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.radLabel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBuscar, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.CbxTipoRanking, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DtpFechaFin, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.DtpFechaInicio, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtCantidadFilas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CbxColumnas, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel5, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.GridProveedores, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1271, 130);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(319, 50);
            this.radLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(89, 29);
            this.radLabel4.TabIndex = 45;
            this.radLabel4.Text = "Columna:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(4, 7);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(50, 29);
            this.radLabel2.TabIndex = 45;
            this.radLabel2.Text = "Tipo:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(678, 90);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(151, 36);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Generar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CbxTipoRanking
            // 
            this.CbxTipoRanking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbxTipoRanking.DropDownAnimationEnabled = true;
            this.CbxTipoRanking.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CbxTipoRanking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "CLIENTES";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "TITULOS";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "EDITORIALES";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "PROVEEDORES";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "TEMAS";
            radListDataItem5.TextWrap = true;
            this.CbxTipoRanking.Items.Add(radListDataItem1);
            this.CbxTipoRanking.Items.Add(radListDataItem2);
            this.CbxTipoRanking.Items.Add(radListDataItem3);
            this.CbxTipoRanking.Items.Add(radListDataItem4);
            this.CbxTipoRanking.Items.Add(radListDataItem5);
            this.CbxTipoRanking.Location = new System.Drawing.Point(62, 5);
            this.CbxTipoRanking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxTipoRanking.MaxDropDownItems = 0;
            this.CbxTipoRanking.Name = "CbxTipoRanking";
            this.CbxTipoRanking.ShowImageInEditorArea = true;
            this.CbxTipoRanking.Size = new System.Drawing.Size(249, 32);
            this.CbxTipoRanking.TabIndex = 47;
            this.CbxTipoRanking.ThemeName = "TelerikMetroBlue";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(678, 4);
            this.DtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechaFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaFin.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.NullableValue = null;
            this.DtpFechaFin.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaFin.Size = new System.Drawing.Size(173, 34);
            this.DtpFechaFin.TabIndex = 2;
            this.DtpFechaFin.TabStop = false;
            this.DtpFechaFin.ThemeName = "TelerikMetroBlue";
            this.DtpFechaFin.Value = new System.DateTime(((long)(0)));
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(609, 7);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(61, 29);
            this.radLabel1.TabIndex = 46;
            this.radLabel1.Text = "Hasta:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(416, 4);
            this.DtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaInicio.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.NullableValue = null;
            this.DtpFechaInicio.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaInicio.Size = new System.Drawing.Size(173, 34);
            this.DtpFechaInicio.TabIndex = 1;
            this.DtpFechaInicio.TabStop = false;
            this.DtpFechaInicio.ThemeName = "TelerikMetroBlue";
            this.DtpFechaInicio.Value = new System.DateTime(((long)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(319, 7);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 29);
            this.metroLabel1.TabIndex = 44;
            this.metroLabel1.Text = "Desde:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(4, 50);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(50, 29);
            this.radLabel3.TabIndex = 48;
            this.radLabel3.Text = "Filas:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCantidadFilas
            // 
            this.TxtCantidadFilas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCantidadFilas.Location = new System.Drawing.Point(62, 47);
            this.TxtCantidadFilas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCantidadFilas.MaxLength = 3;
            this.TxtCantidadFilas.Name = "TxtCantidadFilas";
            this.TxtCantidadFilas.Size = new System.Drawing.Size(133, 38);
            this.TxtCantidadFilas.TabIndex = 49;
            this.TxtCantidadFilas.TabStop = false;
            this.TxtCantidadFilas.Text = "10";
            this.TxtCantidadFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantidadFilas.ThemeName = "TelerikMetroBlue";
            // 
            // CbxColumnas
            // 
            this.CbxColumnas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbxColumnas.DropDownAnimationEnabled = true;
            this.CbxColumnas.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CbxColumnas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem6.Text = "PRECIOS";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "CANTIDADES";
            radListDataItem7.TextWrap = true;
            this.CbxColumnas.Items.Add(radListDataItem6);
            this.CbxColumnas.Items.Add(radListDataItem7);
            this.CbxColumnas.Location = new System.Drawing.Point(416, 48);
            this.CbxColumnas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxColumnas.MaxDropDownItems = 0;
            this.CbxColumnas.Name = "CbxColumnas";
            this.CbxColumnas.ShowImageInEditorArea = true;
            this.CbxColumnas.Size = new System.Drawing.Size(185, 32);
            this.CbxColumnas.TabIndex = 50;
            this.CbxColumnas.ThemeName = "TelerikMetroBlue";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1271, 925);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(858, 3);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(107, 31);
            this.radLabel5.TabIndex = 51;
            this.radLabel5.Text = "Proveedor:";
            // 
            // GridProveedores
            // 
            this.GridProveedores.DropDownAnimationEnabled = true;
            this.GridProveedores.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridProveedores.Location = new System.Drawing.Point(971, 3);
            this.GridProveedores.MaxDropDownItems = 0;
            this.GridProveedores.Name = "GridProveedores";
            this.GridProveedores.ShowImageInEditorArea = true;
            this.GridProveedores.Size = new System.Drawing.Size(203, 31);
            this.GridProveedores.TabIndex = 52;
            this.GridProveedores.ThemeName = "TelerikMetroBlue";
            // 
            // FrmMultiRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 1035);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMultiRanking";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.FrmClientesPorTitulo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxTipoRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidadFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn2;
        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn3;
        private Controls.DetailCell.DetailsColumn detailsColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Id;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Denominacion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoDocumentoDi;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuit;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Telefono;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Celular;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Domicilio;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Mail;
        private Controls.DetailCell.DetailsColumn ClienteDetalle;
        private Controls.EditCell.EditColumn ClienteEditar;
        private Controls.DeleteCell.DeleteColumn ClienteEliminar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaFin;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaInicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList CbxTipoRanking;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCantidadFilas;
        private Telerik.WinControls.UI.RadDropDownList CbxColumnas;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList GridProveedores;
    }
}