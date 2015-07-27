using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Compras
{
    partial class UcFiltrosCompras
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
            this.lblAutor = new Telerik.WinControls.UI.RadLabel();
            this.BtnLimpiar = new Telerik.WinControls.UI.RadButton();
            this.CbxProveedor = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.TxtNroCompra = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.cbxTipo = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpDesde = new Telerik.WinControls.UI.RadDateTimePicker();
            this.DtpHasta = new Telerik.WinControls.UI.RadDateTimePicker();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.lblAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(541, 3);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(37, 24);
            this.lblAutor.TabIndex = 47;
            this.lblAutor.Text = "Nro:";
            this.lblAutor.ThemeName = "TelerikMetroBlue";
            this.lblAutor.Visible = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(541, 33);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiar.TabIndex = 46;
            this.BtnLimpiar.Text = "Limpiar Filtros";
            this.BtnLimpiar.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // CbxProveedor
            // 
            this.CbxProveedor.AutoCompleteDisplayMember = "Nombre";
            this.CbxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxProveedor.DisplayMember = "Nombre";
            this.CbxProveedor.DropDownAnimationEnabled = true;
            this.CbxProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProveedor.Location = new System.Drawing.Point(87, 11);
            this.CbxProveedor.MaxDropDownItems = 0;
            this.CbxProveedor.Name = "CbxProveedor";
            this.CbxProveedor.ShowImageInEditorArea = true;
            this.CbxProveedor.Size = new System.Drawing.Size(210, 27);
            this.CbxProveedor.TabIndex = 9;
            this.CbxProveedor.ThemeName = "TelerikMetroBlue";
            this.CbxProveedor.SelectedValueChanged += new System.EventHandler(this.CbxProveedor_SelectedValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(5, 12);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 24);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Proveedor:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(660, 33);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 37;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtNroCompra
            // 
            this.TxtNroCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCompra.Location = new System.Drawing.Point(584, 3);
            this.TxtNroCompra.Name = "TxtNroCompra";
            this.TxtNroCompra.Size = new System.Drawing.Size(210, 26);
            this.TxtNroCompra.TabIndex = 3;
            this.TxtNroCompra.TabStop = false;
            this.TxtNroCompra.ThemeName = "TelerikMetroBlue";
            this.TxtNroCompra.Visible = false;
            this.TxtNroCompra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAutor_KeyUp);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(5, 46);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(41, 24);
            this.radLabel3.TabIndex = 48;
            this.radLabel3.Text = "Tipo:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteDisplayMember = "Nombre";
            this.cbxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipo.DisplayMember = "Nombre";
            this.cbxTipo.DropDownAnimationEnabled = true;
            this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.Location = new System.Drawing.Point(89, 46);
            this.cbxTipo.MaxDropDownItems = 0;
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.ShowImageInEditorArea = true;
            this.cbxTipo.Size = new System.Drawing.Size(210, 27);
            this.cbxTipo.TabIndex = 50;
            this.cbxTipo.ThemeName = "TelerikMetroBlue";
            this.cbxTipo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxTipo_KeyUp);
            this.cbxTipo.SelectedValueChanged += new System.EventHandler(this.cbxTipo_SelectedValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(324, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(53, 24);
            this.radLabel1.TabIndex = 51;
            this.radLabel1.Text = "Desde:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(328, 49);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(49, 24);
            this.radLabel2.TabIndex = 52;
            this.radLabel2.Text = "Hasta:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(383, 12);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.NullableValue = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.dtpDesde.NullDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Size = new System.Drawing.Size(144, 26);
            this.dtpDesde.TabIndex = 53;
            this.dtpDesde.TabStop = false;
            this.dtpDesde.Text = "19/01/2015";
            this.dtpDesde.ThemeName = "TelerikMetroBlue";
            this.dtpDesde.Value = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            // 
            // DtpHasta
            // 
            this.DtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHasta.Location = new System.Drawing.Point(383, 46);
            this.DtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpHasta.MinDate = new System.DateTime(((long)(0)));
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.NullableValue = new System.DateTime(2015, 2, 4, 17, 33, 8, 710);
            this.DtpHasta.NullDate = new System.DateTime(((long)(0)));
            this.DtpHasta.Size = new System.Drawing.Size(144, 26);
            this.DtpHasta.TabIndex = 54;
            this.DtpHasta.TabStop = false;
            this.DtpHasta.Text = "04/02/2015";
            this.DtpHasta.ThemeName = "TelerikMetroBlue";
            this.DtpHasta.Value = new System.DateTime(2015, 2, 4, 17, 33, 8, 710);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Location = new System.Drawing.Point(619, 68);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 55;
            // 
            // UcFiltrosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucProgressSpinner1);
            this.Controls.Add(this.DtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.TxtNroCompra);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.CbxProveedor);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.BtnBuscar);
            this.Name = "UcFiltrosCompras";
            this.Size = new System.Drawing.Size(815, 99);
            this.Load += new System.EventHandler(this.UcFiltrosLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblAutor;
        private Telerik.WinControls.UI.RadButton BtnLimpiar;
        private Telerik.WinControls.UI.RadDropDownList CbxProveedor;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private RadTextBox TxtNroCompra;
        private RadLabel radLabel3;
        private RadDropDownList cbxTipo;
        private RadLabel radLabel1;
        private RadLabel radLabel2;
        private RadDateTimePicker dtpDesde;
        private RadDateTimePicker DtpHasta;
        private Util.UcProgressSpinner ucProgressSpinner1;
    }
}
