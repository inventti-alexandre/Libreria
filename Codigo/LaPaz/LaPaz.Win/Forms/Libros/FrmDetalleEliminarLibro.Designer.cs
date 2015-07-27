using System.Windows.Forms;

namespace LaPaz.Win.Forms.Libros
{
    partial class FrmDetalleEliminarLibro
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
            this.BtnEliminar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtAutor = new Telerik.WinControls.UI.RadTextBox();
            this.TxtSubTema = new Telerik.WinControls.UI.RadTextBox();
            this.TxtTema = new Telerik.WinControls.UI.RadTextBox();
            this.TxtEditorial = new Telerik.WinControls.UI.RadTextBox();
            this.TxtProveedor = new Telerik.WinControls.UI.RadTextBox();
            this.TxtComentario = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel19 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodigoBarra = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPrecioCompra = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPrecioVenta = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTitulo = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtIsbn = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodigo = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(529, 412);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 28;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.ThemeName = "TelerikMetroBlue";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(633, 412);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtAutor
            // 
            this.TxtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAutor.Enabled = false;
            this.TxtAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(528, 164);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(205, 26);
            this.TxtAutor.TabIndex = 88;
            this.TxtAutor.TabStop = false;
            this.TxtAutor.ThemeName = "TelerikMetroBlue";
            // 
            // TxtSubTema
            // 
            this.TxtSubTema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSubTema.Enabled = false;
            this.TxtSubTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubTema.Location = new System.Drawing.Point(528, 213);
            this.TxtSubTema.Name = "TxtSubTema";
            this.TxtSubTema.Size = new System.Drawing.Size(205, 26);
            this.TxtSubTema.TabIndex = 87;
            this.TxtSubTema.TabStop = false;
            this.TxtSubTema.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTema
            // 
            this.TxtTema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTema.Enabled = false;
            this.TxtTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTema.Location = new System.Drawing.Point(125, 213);
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.Size = new System.Drawing.Size(205, 26);
            this.TxtTema.TabIndex = 86;
            this.TxtTema.TabStop = false;
            this.TxtTema.ThemeName = "TelerikMetroBlue";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEditorial.Enabled = false;
            this.TxtEditorial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditorial.Location = new System.Drawing.Point(125, 164);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(205, 26);
            this.TxtEditorial.TabIndex = 85;
            this.TxtEditorial.TabStop = false;
            this.TxtEditorial.ThemeName = "TelerikMetroBlue";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProveedor.Enabled = false;
            this.TxtProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.Location = new System.Drawing.Point(528, 114);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(205, 26);
            this.TxtProveedor.TabIndex = 84;
            this.TxtProveedor.TabStop = false;
            this.TxtProveedor.ThemeName = "TelerikMetroBlue";
            // 
            // TxtComentario
            // 
            this.TxtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComentario.Enabled = false;
            this.TxtComentario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComentario.Location = new System.Drawing.Point(121, 311);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            // 
            // 
            // 
            this.TxtComentario.RootElement.StretchVertically = true;
            this.TxtComentario.Size = new System.Drawing.Size(612, 84);
            this.TxtComentario.TabIndex = 74;
            this.TxtComentario.TabStop = false;
            this.TxtComentario.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel19
            // 
            this.metroLabel19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel19.Location = new System.Drawing.Point(24, 312);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(91, 24);
            this.metroLabel19.TabIndex = 83;
            this.metroLabel19.Text = "Comentario:";
            this.metroLabel19.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigoBarra
            // 
            this.TxtCodigoBarra.Enabled = false;
            this.TxtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoBarra.Location = new System.Drawing.Point(528, 65);
            this.TxtCodigoBarra.Name = "TxtCodigoBarra";
            this.TxtCodigoBarra.Size = new System.Drawing.Size(205, 26);
            this.TxtCodigoBarra.TabIndex = 68;
            this.TxtCodigoBarra.TabStop = false;
            this.TxtCodigoBarra.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel10.Location = new System.Drawing.Point(409, 66);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(122, 24);
            this.metroLabel10.TabIndex = 82;
            this.metroLabel10.Text = "Código de barra:";
            this.metroLabel10.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Enabled = false;
            this.TxtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioCompra.Location = new System.Drawing.Point(528, 262);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(205, 26);
            this.TxtPrecioCompra.TabIndex = 73;
            this.TxtPrecioCompra.TabStop = false;
            this.TxtPrecioCompra.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel9.Location = new System.Drawing.Point(409, 263);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(111, 24);
            this.metroLabel9.TabIndex = 81;
            this.metroLabel9.Text = "Precio Compra:";
            this.metroLabel9.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Enabled = false;
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(125, 262);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(205, 26);
            this.TxtPrecioVenta.TabIndex = 72;
            this.TxtPrecioVenta.TabStop = false;
            this.TxtPrecioVenta.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel8.Location = new System.Drawing.Point(24, 263);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 24);
            this.metroLabel8.TabIndex = 80;
            this.metroLabel8.Text = "Precio Venta:";
            this.metroLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(409, 214);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 24);
            this.metroLabel7.TabIndex = 79;
            this.metroLabel7.Text = "Subtema:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(24, 214);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 24);
            this.metroLabel6.TabIndex = 78;
            this.metroLabel6.Text = "Tema:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(24, 165);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 24);
            this.metroLabel5.TabIndex = 77;
            this.metroLabel5.Text = "Editorial:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(409, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 24);
            this.metroLabel4.TabIndex = 76;
            this.metroLabel4.Text = "Autor:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel11.Location = new System.Drawing.Point(409, 115);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(81, 24);
            this.metroLabel11.TabIndex = 75;
            this.metroLabel11.Text = "Proveedor:";
            this.metroLabel11.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTitulo.Enabled = false;
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(125, 17);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(608, 26);
            this.TxtTitulo.TabIndex = 65;
            this.TxtTitulo.TabStop = false;
            this.TxtTitulo.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(24, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 24);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Título:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIsbn.Enabled = false;
            this.TxtIsbn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsbn.Location = new System.Drawing.Point(125, 115);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(205, 26);
            this.TxtIsbn.TabIndex = 70;
            this.TxtIsbn.TabStop = false;
            this.TxtIsbn.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(24, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 24);
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "ISBN:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(125, 66);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(205, 26);
            this.TxtCodigo.TabIndex = 67;
            this.TxtCodigo.TabStop = false;
            this.TxtCodigo.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(24, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 24);
            this.metroLabel1.TabIndex = 66;
            this.metroLabel1.Text = "Código:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // FrmDetalleEliminarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(761, 457);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtSubTema);
            this.Controls.Add(this.TxtTema);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.TxtCodigoBarra);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.TxtPrecioCompra);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.Name = "FrmDetalleEliminarLibro";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.FrmCrearEditarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnEliminar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadTextBox TxtAutor;
        private Telerik.WinControls.UI.RadTextBox TxtSubTema;
        private Telerik.WinControls.UI.RadTextBox TxtTema;
        private Telerik.WinControls.UI.RadTextBox TxtEditorial;
        private Telerik.WinControls.UI.RadTextBox TxtProveedor;
        private Telerik.WinControls.UI.RadTextBox TxtComentario;
        private Telerik.WinControls.UI.RadLabel metroLabel19;
        private Telerik.WinControls.UI.RadTextBox TxtCodigoBarra;
        private Telerik.WinControls.UI.RadLabel metroLabel10;
        private Telerik.WinControls.UI.RadTextBox TxtPrecioCompra;
        private Telerik.WinControls.UI.RadLabel metroLabel9;
        private Telerik.WinControls.UI.RadTextBox TxtPrecioVenta;
        private Telerik.WinControls.UI.RadLabel metroLabel8;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel11;
        private Telerik.WinControls.UI.RadTextBox TxtTitulo;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtIsbn;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtCodigo;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
    }
}