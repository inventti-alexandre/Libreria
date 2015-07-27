using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Libros
{
    partial class UcFiltrosLibros
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
            this.CbxTema = new Telerik.WinControls.UI.RadDropDownList();
            this.CbxProveedor = new Telerik.WinControls.UI.RadDropDownList();
            this.TxtTitulo = new Telerik.WinControls.UI.RadTextBox();
            this.TxtIsbn = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.TxtCodigo1 = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodigo2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodigoBarra = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtAutor = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.CbxOchoDeMarzo = new LaPaz.Win.Forms.Util.UcFiltroSiNo();
            this.UcFiltroEditorial = new LaPaz.Win.Forms.Util.UcFiltroEditorial();
            this.UcConStock = new LaPaz.Win.Forms.Util.UcFiltroSiNo();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.CkbEliminados = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkbEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(303, 49);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(49, 24);
            this.lblAutor.TabIndex = 47;
            this.lblAutor.Text = "Autor:";
            this.lblAutor.ThemeName = "TelerikMetroBlue";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(5, 121);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar Filtros";
            this.BtnLimpiar.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // CbxTema
            // 
            this.CbxTema.AutoCompleteDisplayMember = "Nombre";
            this.CbxTema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxTema.DisplayMember = "Nombre";
            this.CbxTema.DropDownAnimationEnabled = true;
            this.CbxTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTema.Location = new System.Drawing.Point(669, 47);
            this.CbxTema.MaxDropDownItems = 0;
            this.CbxTema.Name = "CbxTema";
            this.CbxTema.ShowImageInEditorArea = true;
            this.CbxTema.Size = new System.Drawing.Size(210, 25);
            this.CbxTema.TabIndex = 5;
            this.CbxTema.ThemeName = "TelerikMetroBlue";
            this.CbxTema.SelectedValueChanged += new System.EventHandler(this.CbxTema_SelectedValueChanged);
            // 
            // CbxProveedor
            // 
            this.CbxProveedor.AutoCompleteDisplayMember = "Nombre";
            this.CbxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxProveedor.DisplayMember = "Nombre";
            this.CbxProveedor.DropDownAnimationEnabled = true;
            this.CbxProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProveedor.Location = new System.Drawing.Point(394, 82);
            this.CbxProveedor.MaxDropDownItems = 0;
            this.CbxProveedor.Name = "CbxProveedor";
            this.CbxProveedor.ShowImageInEditorArea = true;
            this.CbxProveedor.Size = new System.Drawing.Size(210, 25);
            this.CbxProveedor.TabIndex = 7;
            this.CbxProveedor.ThemeName = "TelerikMetroBlue";
            this.CbxProveedor.SelectedValueChanged += new System.EventHandler(this.CbxAutor_SelectedValueChanged);
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(72, 47);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(210, 25);
            this.TxtTitulo.TabIndex = 3;
            this.TxtTitulo.TabStop = false;
            this.TxtTitulo.ThemeName = "TelerikMetroBlue";
            this.TxtTitulo.TextChanged += new System.EventHandler(this.TxtTitulo_TextChanged);
            this.TxtTitulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTitulo_KeyUp);
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIsbn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsbn.Location = new System.Drawing.Point(669, 12);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(210, 25);
            this.TxtIsbn.TabIndex = 2;
            this.TxtIsbn.TabStop = false;
            this.TxtIsbn.ThemeName = "TelerikMetroBlue";
            this.TxtIsbn.TextChanged += new System.EventHandler(this.TxtIsbn_TextChanged);
            this.TxtIsbn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIsbn_KeyUp);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(619, 48);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 24);
            this.metroLabel5.TabIndex = 41;
            this.metroLabel5.Text = "Tema:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(303, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 24);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Proveedor:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(5, 45);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 24);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Título:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(619, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 24);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "ISBN:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(124, 121);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCodigo1
            // 
            this.TxtCodigo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo1.Location = new System.Drawing.Point(72, 12);
            this.TxtCodigo1.MaxLength = 4;
            this.TxtCodigo1.Name = "TxtCodigo1";
            this.TxtCodigo1.Size = new System.Drawing.Size(51, 25);
            this.TxtCodigo1.TabIndex = 10;
            this.TxtCodigo1.TabStop = false;
            this.TxtCodigo1.ThemeName = "TelerikMetroBlue";
            this.TxtCodigo1.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            this.TxtCodigo1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo1_KeyUp);
            this.TxtCodigo1.Leave += new System.EventHandler(this.TxtCodigo1_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(5, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 24);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Código:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigo2
            // 
            this.TxtCodigo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo2.Location = new System.Drawing.Point(129, 12);
            this.TxtCodigo2.MaxLength = 13;
            this.TxtCodigo2.Name = "TxtCodigo2";
            this.TxtCodigo2.Size = new System.Drawing.Size(153, 25);
            this.TxtCodigo2.TabIndex = 11;
            this.TxtCodigo2.TabStop = false;
            this.TxtCodigo2.ThemeName = "TelerikMetroBlue";
            this.TxtCodigo2.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            this.TxtCodigo2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo2_KeyUp);
            this.TxtCodigo2.Leave += new System.EventHandler(this.TxtCodigo2_Leave);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(303, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(81, 24);
            this.radLabel1.TabIndex = 51;
            this.radLabel1.Text = "Cod. Barra:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigoBarra
            // 
            this.TxtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoBarra.Location = new System.Drawing.Point(394, 12);
            this.TxtCodigoBarra.MaxLength = 50;
            this.TxtCodigoBarra.Name = "TxtCodigoBarra";
            this.TxtCodigoBarra.Size = new System.Drawing.Size(210, 25);
            this.TxtCodigoBarra.TabIndex = 1;
            this.TxtCodigoBarra.TabStop = false;
            this.TxtCodigoBarra.ThemeName = "TelerikMetroBlue";
            this.TxtCodigoBarra.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            this.TxtCodigoBarra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoBarra_KeyUp);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(897, 17);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 24);
            this.radLabel2.TabIndex = 52;
            this.radLabel2.Text = "C/Stock:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtAutor
            // 
            this.TxtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(394, 47);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(210, 25);
            this.TxtAutor.TabIndex = 4;
            this.TxtAutor.TabStop = false;
            this.TxtAutor.ThemeName = "TelerikMetroBlue";
            this.TxtAutor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAutor_KeyUp);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(5, 80);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(67, 24);
            this.radLabel3.TabIndex = 48;
            this.radLabel3.Text = "Editorial:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(897, 49);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(130, 24);
            this.radLabel4.TabIndex = 48;
            this.radLabel4.Text = "Stock 8 de Marzo:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // CbxOchoDeMarzo
            // 
            this.CbxOchoDeMarzo.Location = new System.Drawing.Point(1031, 47);
            this.CbxOchoDeMarzo.Name = "CbxOchoDeMarzo";
            this.CbxOchoDeMarzo.Size = new System.Drawing.Size(153, 27);
            this.CbxOchoDeMarzo.TabIndex = 9;
            this.CbxOchoDeMarzo.Value = null;
            // 
            // UcFiltroEditorial
            // 
            this.UcFiltroEditorial.EditorialId = null;
            this.UcFiltroEditorial.Location = new System.Drawing.Point(72, 79);
            this.UcFiltroEditorial.Name = "UcFiltroEditorial";
            this.UcFiltroEditorial.Size = new System.Drawing.Size(210, 27);
            this.UcFiltroEditorial.TabIndex = 6;
            // 
            // UcConStock
            // 
            this.UcConStock.Location = new System.Drawing.Point(1031, 9);
            this.UcConStock.Name = "UcConStock";
            this.UcConStock.Size = new System.Drawing.Size(153, 27);
            this.UcConStock.TabIndex = 8;
            this.UcConStock.Value = null;
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProgressSpinner1.Location = new System.Drawing.Point(967, 80);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 49;
            // 
            // ckbEliminados
            // 
            this.CkbEliminados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CkbEliminados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbEliminados.Location = new System.Drawing.Point(619, 82);
            this.CkbEliminados.Name = "ckbEliminados";
            this.CkbEliminados.Size = new System.Drawing.Size(95, 24);
            this.CkbEliminados.TabIndex = 59;
            this.CkbEliminados.Text = "Eliminados";
            this.CkbEliminados.ThemeName = "TelerikMetroBlue";
            this.CkbEliminados.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckbEliminados_ToggleStateChanged);
            // 
            // UcFiltrosLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CkbEliminados);
            this.Controls.Add(this.CbxOchoDeMarzo);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.UcFiltroEditorial);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.UcConStock);
            this.Controls.Add(this.TxtCodigoBarra);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtCodigo2);
            this.Controls.Add(this.ucProgressSpinner1);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.CbxTema);
            this.Controls.Add(this.CbxProveedor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtCodigo1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UcFiltrosLibros";
            this.Size = new System.Drawing.Size(1191, 157);
            this.Load += new System.EventHandler(this.UcFiltrosLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkbEliminados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblAutor;
        private Telerik.WinControls.UI.RadButton BtnLimpiar;
        private Telerik.WinControls.UI.RadDropDownList CbxTema;
        private Telerik.WinControls.UI.RadDropDownList CbxProveedor;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtTitulo;
        private Telerik.WinControls.UI.RadTextBox TxtIsbn;
        private Telerik.WinControls.UI.RadTextBox TxtCodigo1;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private Util.UcFiltroSiNo UcConStock;
        private RadLabel radLabel1;
        private RadTextBox TxtCodigo2;
        private RadTextBox TxtCodigoBarra;
        private RadLabel radLabel2;
        private RadTextBox TxtAutor;
        private Util.UcFiltroEditorial UcFiltroEditorial;
        private RadLabel radLabel3;
        private RadLabel radLabel4;
        private Util.UcFiltroSiNo CbxOchoDeMarzo;
        public RadCheckBox CkbEliminados;
    }
}
