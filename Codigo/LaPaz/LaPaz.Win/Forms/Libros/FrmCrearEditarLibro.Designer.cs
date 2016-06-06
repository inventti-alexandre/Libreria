using System.Windows.Forms;

namespace LaPaz.Win.Forms.Libros
{
    partial class FrmCrearEditarLibro
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
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.CbxProveedor = new LaPaz.Win.Forms.Util.UcFiltroProveedor();
            this.BtnAddSubtema = new Telerik.WinControls.UI.RadButton();
            this.BtnAddTema = new Telerik.WinControls.UI.RadButton();
            this.BtnAddAutor = new Telerik.WinControls.UI.RadButton();
            this.BtnAddProveedor = new Telerik.WinControls.UI.RadButton();
            this.BtnAddEditoria = new Telerik.WinControls.UI.RadButton();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.CbxProveedorCodigo = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.CbxSubTema = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodigo = new Telerik.WinControls.UI.RadTextBox();
            this.CbxTema = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.TxtIsbn = new Telerik.WinControls.UI.RadTextBox();
            this.TxtComentario = new Telerik.WinControls.UI.RadTextBox();
            this.TxtTitulo = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel19 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodigoBarra = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPrecioCompra = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPrecioVenta = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.metroLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.CbxAutor = new LaPaz.Win.Forms.Util.UcFiltroAutor();
            this.CbxEditorial = new LaPaz.Win.Forms.Util.UcFiltroEditorial();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddSubtema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddEditoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProveedorCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxSubTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(635, 412);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // CbxProveedor
            // 
            this.CbxProveedor.Enabled = false;
            this.CbxProveedor.EsGasto = false;
            this.CbxProveedor.Location = new System.Drawing.Point(142, 145);
            this.CbxProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.CbxProveedor.Name = "CbxProveedor";
            this.CbxProveedor.ProveedorId = null;
            this.CbxProveedor.Size = new System.Drawing.Size(205, 27);
            this.CbxProveedor.TabIndex = 3;
            this.CbxProveedor.SeleccionarFinished += new System.EventHandler<LaPaz.Entidades.Proveedor>(this.CbxProveedor_SeleccionarFinished);
            // 
            // BtnAddSubtema
            // 
            this.BtnAddSubtema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddSubtema.Image = global::LaPaz.Win.Properties.Resources.Add_New_blue;
            this.BtnAddSubtema.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddSubtema.Location = new System.Drawing.Point(740, 186);
            this.BtnAddSubtema.Name = "BtnAddSubtema";
            this.BtnAddSubtema.Size = new System.Drawing.Size(26, 25);
            this.BtnAddSubtema.TabIndex = 19;
            this.BtnAddSubtema.ThemeName = "TelerikMetroBlue";
            this.BtnAddSubtema.Click += new System.EventHandler(this.BtnAddSubtema_Click);
            // 
            // BtnAddTema
            // 
            this.BtnAddTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTema.Image = global::LaPaz.Win.Properties.Resources.Add_New_blue;
            this.BtnAddTema.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddTema.Location = new System.Drawing.Point(740, 143);
            this.BtnAddTema.Name = "BtnAddTema";
            this.BtnAddTema.Size = new System.Drawing.Size(26, 25);
            this.BtnAddTema.TabIndex = 18;
            this.BtnAddTema.ThemeName = "TelerikMetroBlue";
            this.BtnAddTema.Click += new System.EventHandler(this.BtnAddTema_Click);
            // 
            // BtnAddAutor
            // 
            this.BtnAddAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAutor.Image = global::LaPaz.Win.Properties.Resources.Add_New_blue;
            this.BtnAddAutor.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddAutor.Location = new System.Drawing.Point(740, 100);
            this.BtnAddAutor.Name = "BtnAddAutor";
            this.BtnAddAutor.Size = new System.Drawing.Size(26, 25);
            this.BtnAddAutor.TabIndex = 17;
            this.BtnAddAutor.ThemeName = "TelerikMetroBlue";
            this.BtnAddAutor.Click += new System.EventHandler(this.BtnAddAutor_Click);
            // 
            // BtnAddProveedor
            // 
            this.BtnAddProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProveedor.Image = global::LaPaz.Win.Properties.Resources.Add_New_blue;
            this.BtnAddProveedor.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddProveedor.Location = new System.Drawing.Point(353, 145);
            this.BtnAddProveedor.Name = "BtnAddProveedor";
            this.BtnAddProveedor.Size = new System.Drawing.Size(26, 25);
            this.BtnAddProveedor.TabIndex = 15;
            this.BtnAddProveedor.ThemeName = "TelerikMetroBlue";
            this.BtnAddProveedor.Click += new System.EventHandler(this.BtnAddProveedor_Click);
            // 
            // BtnAddEditoria
            // 
            this.BtnAddEditoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEditoria.Image = global::LaPaz.Win.Properties.Resources.Add_New_blue;
            this.BtnAddEditoria.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddEditoria.Location = new System.Drawing.Point(353, 186);
            this.BtnAddEditoria.Name = "BtnAddEditoria";
            this.BtnAddEditoria.Size = new System.Drawing.Size(26, 25);
            this.BtnAddEditoria.TabIndex = 16;
            this.BtnAddEditoria.ThemeName = "TelerikMetroBlue";
            this.BtnAddEditoria.Click += new System.EventHandler(this.BtnAddEditoria_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(529, 412);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CbxProveedorCodigo
            // 
            this.CbxProveedorCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxProveedorCodigo.DropDownAnimationEnabled = true;
            this.CbxProveedorCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProveedorCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.CbxProveedorCodigo.Location = new System.Drawing.Point(529, 272);
            this.CbxProveedorCodigo.MaxDropDownItems = 15;
            this.CbxProveedorCodigo.Name = "CbxProveedorCodigo";
            this.CbxProveedorCodigo.ShowImageInEditorArea = true;
            this.CbxProveedorCodigo.Size = new System.Drawing.Size(205, 32);
            this.CbxProveedorCodigo.TabIndex = 11;
            this.CbxProveedorCodigo.ThemeName = "TelerikMetroBlue";
            this.CbxProveedorCodigo.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(24, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 29);
            this.metroLabel3.TabIndex = 68;
            this.metroLabel3.Text = "Título:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // CbxSubTema
            // 
            this.CbxSubTema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxSubTema.DropDownAnimationEnabled = true;
            this.CbxSubTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSubTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.CbxSubTema.Location = new System.Drawing.Point(529, 185);
            this.CbxSubTema.MaxDropDownItems = 15;
            this.CbxSubTema.Name = "CbxSubTema";
            this.CbxSubTema.ShowImageInEditorArea = true;
            this.CbxSubTema.Size = new System.Drawing.Size(205, 32);
            this.CbxSubTema.TabIndex = 10;
            this.CbxSubTema.ThemeName = "TelerikMetroBlue";
            this.CbxSubTema.Enter += new System.EventHandler(this.CbxSubTema_Enter_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(412, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 29);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Código:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(527, 59);
            this.TxtCodigo.MaxLength = 17;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(205, 31);
            this.TxtCodigo.TabIndex = 7;
            this.TxtCodigo.TabStop = false;
            this.TxtCodigo.ThemeName = "TelerikMetroBlue";
            // 
            // CbxTema
            // 
            this.CbxTema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxTema.DropDownAnimationEnabled = true;
            this.CbxTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.CbxTema.Location = new System.Drawing.Point(529, 143);
            this.CbxTema.MaxDropDownItems = 15;
            this.CbxTema.Name = "CbxTema";
            this.CbxTema.ShowImageInEditorArea = true;
            this.CbxTema.Size = new System.Drawing.Size(205, 32);
            this.CbxTema.TabIndex = 9;
            this.CbxTema.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(24, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 29);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "ISBN:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel12.Location = new System.Drawing.Point(412, 272);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(75, 29);
            this.metroLabel12.TabIndex = 85;
            this.metroLabel12.Text = "Código:";
            this.metroLabel12.ThemeName = "TelerikMetroBlue";
            this.metroLabel12.Visible = false;
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIsbn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsbn.Location = new System.Drawing.Point(142, 102);
            this.TxtIsbn.MaxLength = 15;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(205, 31);
            this.TxtIsbn.TabIndex = 2;
            this.TxtIsbn.TabStop = false;
            this.TxtIsbn.ThemeName = "TelerikMetroBlue";
            // 
            // TxtComentario
            // 
            this.TxtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComentario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComentario.Location = new System.Drawing.Point(142, 315);
            this.TxtComentario.MaxLength = 100;
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            // 
            // 
            // 
            this.TxtComentario.RootElement.StretchVertically = true;
            this.TxtComentario.Size = new System.Drawing.Size(596, 84);
            this.TxtComentario.TabIndex = 12;
            this.TxtComentario.TabStop = false;
            this.TxtComentario.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(142, 17);
            this.TxtTitulo.MaxLength = 50;
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(590, 31);
            this.TxtTitulo.TabIndex = 0;
            this.TxtTitulo.TabStop = false;
            this.TxtTitulo.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel19
            // 
            this.metroLabel19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel19.Location = new System.Drawing.Point(24, 315);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(113, 29);
            this.metroLabel19.TabIndex = 84;
            this.metroLabel19.Text = "Comentario:";
            this.metroLabel19.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel11.Location = new System.Drawing.Point(24, 145);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(101, 29);
            this.metroLabel11.TabIndex = 76;
            this.metroLabel11.Text = "Proveedor:";
            this.metroLabel11.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigoBarra
            // 
            this.TxtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoBarra.Location = new System.Drawing.Point(142, 60);
            this.TxtCodigoBarra.MaxLength = 13;
            this.TxtCodigoBarra.Name = "TxtCodigoBarra";
            this.TxtCodigoBarra.Size = new System.Drawing.Size(205, 31);
            this.TxtCodigoBarra.TabIndex = 1;
            this.TxtCodigoBarra.TabStop = false;
            this.TxtCodigoBarra.ThemeName = "TelerikMetroBlue";
            this.TxtCodigoBarra.TextChanged += new System.EventHandler(this.TxtCodigoBarra_TextChanged);
            this.TxtCodigoBarra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoBarra_KeyUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(412, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 29);
            this.metroLabel4.TabIndex = 77;
            this.metroLabel4.Text = "Autor:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel10.Location = new System.Drawing.Point(24, 61);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(151, 29);
            this.metroLabel10.TabIndex = 83;
            this.metroLabel10.Text = "Código de barra:";
            this.metroLabel10.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(24, 186);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 29);
            this.metroLabel5.TabIndex = 78;
            this.metroLabel5.Text = "Editorial:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.AceptaNegativos = false;
            this.TxtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioCompra.Location = new System.Drawing.Point(142, 230);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(205, 31);
            this.TxtPrecioCompra.TabIndex = 5;
            this.TxtPrecioCompra.TabStop = false;
            this.TxtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioCompra.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(412, 144);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 29);
            this.metroLabel6.TabIndex = 79;
            this.metroLabel6.Text = "Tema:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel9.Location = new System.Drawing.Point(24, 230);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(139, 29);
            this.metroLabel9.TabIndex = 82;
            this.metroLabel9.Text = "Precio Compra:";
            this.metroLabel9.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(412, 188);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(89, 29);
            this.metroLabel7.TabIndex = 80;
            this.metroLabel7.Text = "Subtema:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.AceptaNegativos = false;
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(142, 272);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(205, 31);
            this.TxtPrecioVenta.TabIndex = 6;
            this.TxtPrecioVenta.TabStop = false;
            this.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioVenta.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel8.Location = new System.Drawing.Point(24, 273);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(120, 29);
            this.metroLabel8.TabIndex = 81;
            this.metroLabel8.Text = "Precio Venta:";
            this.metroLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // CbxAutor
            // 
            this.CbxAutor.AutorId = null;
            this.CbxAutor.Location = new System.Drawing.Point(529, 99);
            this.CbxAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxAutor.Name = "CbxAutor";
            this.CbxAutor.Size = new System.Drawing.Size(205, 27);
            this.CbxAutor.TabIndex = 8;
            // 
            // CbxEditorial
            // 
            this.CbxEditorial.EditorialId = null;
            this.CbxEditorial.Location = new System.Drawing.Point(142, 185);
            this.CbxEditorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxEditorial.Name = "CbxEditorial";
            this.CbxEditorial.Size = new System.Drawing.Size(205, 27);
            this.CbxEditorial.TabIndex = 4;
            // 
            // FrmCrearEditarLibro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.CbxEditorial);
            this.Controls.Add(this.CbxAutor);
            this.Controls.Add(this.CbxProveedor);
            this.Controls.Add(this.BtnAddSubtema);
            this.Controls.Add(this.BtnAddTema);
            this.Controls.Add(this.BtnAddAutor);
            this.Controls.Add(this.BtnAddProveedor);
            this.Controls.Add(this.BtnAddEditoria);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CbxProveedorCodigo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.CbxSubTema);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.CbxTema);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.TxtCodigoBarra);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.TxtPrecioCompra);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.metroLabel8);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCrearEditarLibro";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Agregar Nuevo Libro";
            this.Load += new System.EventHandler(this.FrmCrearEditarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddSubtema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddEditoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxProveedorCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxSubTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadDropDownList CbxProveedorCodigo;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadDropDownList CbxSubTema;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtCodigo;
        private Telerik.WinControls.UI.RadDropDownList CbxTema;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel12;
        private Telerik.WinControls.UI.RadTextBox TxtIsbn;
        private Telerik.WinControls.UI.RadTextBox TxtComentario;
        private Telerik.WinControls.UI.RadTextBox TxtTitulo;
        private Telerik.WinControls.UI.RadLabel metroLabel19;
        private Telerik.WinControls.UI.RadLabel metroLabel11;
        private Telerik.WinControls.UI.RadTextBox TxtCodigoBarra;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel10;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtPrecioCompra;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadLabel metroLabel9;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtPrecioVenta;
        private Telerik.WinControls.UI.RadLabel metroLabel8;
        private Telerik.WinControls.UI.RadButton BtnAddEditoria;
        private Telerik.WinControls.UI.RadButton BtnAddProveedor;
        private Telerik.WinControls.UI.RadButton BtnAddAutor;
        private Telerik.WinControls.UI.RadButton BtnAddTema;
        private Telerik.WinControls.UI.RadButton BtnAddSubtema;
        private Util.UcFiltroProveedor CbxProveedor;
        private Util.UcFiltroAutor CbxAutor;
        private Util.UcFiltroEditorial CbxEditorial;
    }
}