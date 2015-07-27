using System.Windows.Forms;

namespace LaPaz.Win.Forms.Clientes
{
    partial class FrmCrearEditarCliente
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
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.EpvCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxTipoDocumento = new Telerik.WinControls.UI.RadDropDownList();
            this.cbxTipo = new Telerik.WinControls.UI.RadDropDownList();
            this.cbxCondicionVenta = new Telerik.WinControls.UI.RadDropDownList();
            this.cbxEspecialidad = new Telerik.WinControls.UI.RadDropDownList();
            this.cbxProfesion = new Telerik.WinControls.UI.RadDropDownList();
            this.cbxLocalidad = new Telerik.WinControls.UI.RadDropDownList();
            this.ckbLlamar = new Telerik.WinControls.UI.RadCheckBox();
            this.ckbMail = new Telerik.WinControls.UI.RadCheckBox();
            this.txtMail = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.cbxProvincia = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.txtCelular = new Telerik.WinControls.UI.RadTextBox();
            this.txtTelefono = new Telerik.WinControls.UI.RadTextBox();
            this.txtDomicilio = new Telerik.WinControls.UI.RadTextBox();
            this.txtDni = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtApellidoNombre = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtComentarios = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCondicionVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEspecialidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProfesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbLlamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(792, 359);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 40;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(679, 359);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 41;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // EpvCliente
            // 
            this.EpvCliente.ContainerControl = this;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipoDocumento.DropDownAnimationEnabled = true;
            this.cbxTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxTipoDocumento.Location = new System.Drawing.Point(161, 58);
            this.cbxTipoDocumento.MaxDropDownItems = 15;
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.ShowImageInEditorArea = true;
            this.cbxTipoDocumento.Size = new System.Drawing.Size(61, 27);
            this.cbxTipoDocumento.TabIndex = 2;
            this.cbxTipoDocumento.ThemeName = "TelerikMetroBlue";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipo.DropDownAnimationEnabled = true;
            this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxTipo.Location = new System.Drawing.Point(612, 227);
            this.cbxTipo.MaxDropDownItems = 15;
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.ShowImageInEditorArea = true;
            this.cbxTipo.Size = new System.Drawing.Size(277, 27);
            this.cbxTipo.TabIndex = 15;
            this.cbxTipo.ThemeName = "TelerikMetroBlue";
            // 
            // cbxCondicionVenta
            // 
            this.cbxCondicionVenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCondicionVenta.DropDownAnimationEnabled = true;
            this.cbxCondicionVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCondicionVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxCondicionVenta.Location = new System.Drawing.Point(612, 185);
            this.cbxCondicionVenta.MaxDropDownItems = 15;
            this.cbxCondicionVenta.Name = "cbxCondicionVenta";
            this.cbxCondicionVenta.ShowImageInEditorArea = true;
            this.cbxCondicionVenta.Size = new System.Drawing.Size(277, 27);
            this.cbxCondicionVenta.TabIndex = 14;
            this.cbxCondicionVenta.ThemeName = "TelerikMetroBlue";
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEspecialidad.DropDownAnimationEnabled = true;
            this.cbxEspecialidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxEspecialidad.Location = new System.Drawing.Point(612, 143);
            this.cbxEspecialidad.MaxDropDownItems = 15;
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.ShowImageInEditorArea = true;
            this.cbxEspecialidad.Size = new System.Drawing.Size(277, 27);
            this.cbxEspecialidad.TabIndex = 13;
            this.cbxEspecialidad.ThemeName = "TelerikMetroBlue";
            // 
            // cbxProfesion
            // 
            this.cbxProfesion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProfesion.DropDownAnimationEnabled = true;
            this.cbxProfesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProfesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxProfesion.Location = new System.Drawing.Point(612, 101);
            this.cbxProfesion.MaxDropDownItems = 15;
            this.cbxProfesion.Name = "cbxProfesion";
            this.cbxProfesion.ShowImageInEditorArea = true;
            this.cbxProfesion.Size = new System.Drawing.Size(277, 27);
            this.cbxProfesion.TabIndex = 12;
            this.cbxProfesion.ThemeName = "TelerikMetroBlue";
            this.cbxProfesion.SelectedValueChanged += new System.EventHandler(this.cbxProfesion_SelectedValueChanged);
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLocalidad.DropDownAnimationEnabled = true;
            this.cbxLocalidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxLocalidad.Location = new System.Drawing.Point(612, 59);
            this.cbxLocalidad.MaxDropDownItems = 15;
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.ShowImageInEditorArea = true;
            this.cbxLocalidad.Size = new System.Drawing.Size(277, 27);
            this.cbxLocalidad.TabIndex = 11;
            this.cbxLocalidad.ThemeName = "TelerikMetroBlue";
            // 
            // ckbLlamar
            // 
            this.ckbLlamar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLlamar.Location = new System.Drawing.Point(328, 268);
            this.ckbLlamar.Name = "ckbLlamar";
            this.ckbLlamar.Size = new System.Drawing.Size(70, 24);
            this.ckbLlamar.TabIndex = 9;
            this.ckbLlamar.Text = "Llamar";
            this.ckbLlamar.ThemeName = "TelerikMetroBlue";
            // 
            // ckbMail
            // 
            this.ckbMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMail.Location = new System.Drawing.Point(161, 268);
            this.ckbMail.Name = "ckbMail";
            this.ckbMail.Size = new System.Drawing.Size(106, 24);
            this.ckbMail.TabIndex = 8;
            this.ckbMail.Text = "Enviar Email";
            this.ckbMail.ThemeName = "TelerikMetroBlue";
            // 
            // txtMail
            // 
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(161, 223);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(277, 26);
            this.txtMail.TabIndex = 7;
            this.txtMail.TabStop = false;
            this.txtMail.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel13.Location = new System.Drawing.Point(24, 228);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(47, 24);
            this.metroLabel13.TabIndex = 92;
            this.metroLabel13.Text = "Email:";
            this.metroLabel13.ThemeName = "TelerikMetroBlue";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProvincia.DropDownAnimationEnabled = true;
            this.cbxProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxProvincia.Location = new System.Drawing.Point(612, 17);
            this.cbxProvincia.MaxDropDownItems = 15;
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.ShowImageInEditorArea = true;
            this.cbxProvincia.Size = new System.Drawing.Size(277, 27);
            this.cbxProvincia.TabIndex = 10;
            this.cbxProvincia.ThemeName = "TelerikMetroBlue";
            this.cbxProvincia.SelectedValueChanged += new System.EventHandler(this.cbxProvincia_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(461, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 24);
            this.metroLabel2.TabIndex = 91;
            this.metroLabel2.Text = "Especialidad:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel12.Location = new System.Drawing.Point(24, 60);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(125, 24);
            this.metroLabel12.TabIndex = 90;
            this.metroLabel12.Text = "Tipo Documento:";
            this.metroLabel12.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel11.Location = new System.Drawing.Point(461, 102);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 24);
            this.metroLabel11.TabIndex = 89;
            this.metroLabel11.Text = "Profesión:";
            this.metroLabel11.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel10.Location = new System.Drawing.Point(461, 228);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(114, 24);
            this.metroLabel10.TabIndex = 88;
            this.metroLabel10.Text = "Tipo de Cliente:";
            this.metroLabel10.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel9.Location = new System.Drawing.Point(461, 186);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(145, 24);
            this.metroLabel9.TabIndex = 87;
            this.metroLabel9.Text = "Condición de Venta:";
            this.metroLabel9.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel8.Location = new System.Drawing.Point(461, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 24);
            this.metroLabel8.TabIndex = 86;
            this.metroLabel8.Text = "Localidad:";
            this.metroLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(161, 182);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(277, 26);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.TabStop = false;
            this.txtCelular.ThemeName = "TelerikMetroBlue";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(161, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(277, 26);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.ThemeName = "TelerikMetroBlue";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(161, 100);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(277, 26);
            this.txtDomicilio.TabIndex = 4;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.ThemeName = "TelerikMetroBlue";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(228, 58);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(210, 26);
            this.txtDni.TabIndex = 3;
            this.txtDni.TabStop = false;
            this.txtDni.ThemeName = "TelerikMetroBlue";
            this.txtDni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(461, 18);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 24);
            this.metroLabel7.TabIndex = 85;
            this.metroLabel7.Text = "Provincia:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(24, 186);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 24);
            this.metroLabel6.TabIndex = 84;
            this.metroLabel6.Text = "Celular:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(24, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 24);
            this.metroLabel5.TabIndex = 83;
            this.metroLabel5.Text = "Teléfono:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(24, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 24);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Domicilio:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoNombre.Location = new System.Drawing.Point(161, 17);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(277, 26);
            this.txtApellidoNombre.TabIndex = 1;
            this.txtApellidoNombre.TabStop = false;
            this.txtApellidoNombre.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(24, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 24);
            this.metroLabel1.TabIndex = 80;
            this.metroLabel1.Text = "Apellido, Nombre:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(24, 298);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(97, 24);
            this.radLabel1.TabIndex = 93;
            this.radLabel1.Text = "Comentarios:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtComentarios
            // 
            this.TxtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComentarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComentarios.Location = new System.Drawing.Point(151, 298);
            this.TxtComentarios.Multiline = true;
            this.TxtComentarios.Name = "TxtComentarios";
            // 
            // 
            // 
            this.TxtComentarios.RootElement.StretchVertically = true;
            this.TxtComentarios.Size = new System.Drawing.Size(455, 91);
            this.TxtComentarios.TabIndex = 94;
            this.TxtComentarios.TabStop = false;
            this.TxtComentarios.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCrearEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 418);
            this.Controls.Add(this.TxtComentarios);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cbxTipoDocumento);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxCondicionVenta);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.cbxProfesion);
            this.Controls.Add(this.cbxLocalidad);
            this.Controls.Add(this.ckbLlamar);
            this.Controls.Add(this.ckbMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.MaximizeBox = false;
            this.Name = "FrmCrearEditarCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCrearCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCondicionVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEspecialidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProfesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbLlamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private ErrorProvider EpvCliente;
        private Telerik.WinControls.UI.RadDropDownList cbxTipoDocumento;
        private Telerik.WinControls.UI.RadDropDownList cbxTipo;
        private Telerik.WinControls.UI.RadDropDownList cbxCondicionVenta;
        private Telerik.WinControls.UI.RadDropDownList cbxEspecialidad;
        private Telerik.WinControls.UI.RadDropDownList cbxProfesion;
        private Telerik.WinControls.UI.RadDropDownList cbxLocalidad;
        private Telerik.WinControls.UI.RadCheckBox ckbLlamar;
        private Telerik.WinControls.UI.RadCheckBox ckbMail;
        private Telerik.WinControls.UI.RadTextBox txtMail;
        private Telerik.WinControls.UI.RadLabel metroLabel13;
        private Telerik.WinControls.UI.RadDropDownList cbxProvincia;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel12;
        private Telerik.WinControls.UI.RadLabel metroLabel11;
        private Telerik.WinControls.UI.RadLabel metroLabel10;
        private Telerik.WinControls.UI.RadLabel metroLabel9;
        private Telerik.WinControls.UI.RadLabel metroLabel8;
        private Telerik.WinControls.UI.RadTextBox txtCelular;
        private Telerik.WinControls.UI.RadTextBox txtTelefono;
        private Telerik.WinControls.UI.RadTextBox txtDomicilio;
        private Telerik.WinControls.UI.RadTextBox txtDni;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadTextBox txtApellidoNombre;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtComentarios;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}