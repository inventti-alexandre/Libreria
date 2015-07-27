namespace LaPaz.Win.Forms.OrdenesPagos
{
    partial class FrmCrearEditarTipoGasto
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
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.CkdBienDeUso = new Telerik.WinControls.UI.RadCheckBox();
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.TxtAbreviatura = new Telerik.WinControls.UI.RadTextBox();
            this.TxtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkdBienDeUso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAbreviatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(12, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 24);
            this.metroLabel4.TabIndex = 103;
            this.metroLabel4.Text = "Nombre:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(298, 193);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 61);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(90, 24);
            this.radLabel2.TabIndex = 100;
            this.radLabel2.Text = "Abreviatura:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(411, 193);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(12, 103);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(90, 24);
            this.radLabel5.TabIndex = 92;
            this.radLabel5.Text = "Descripción:";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // CkdBienDeUso
            // 
            this.CkdBienDeUso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkdBienDeUso.Location = new System.Drawing.Point(13, 144);
            this.CkdBienDeUso.Name = "CkdBienDeUso";
            this.CkdBienDeUso.Size = new System.Drawing.Size(104, 24);
            this.CkdBienDeUso.TabIndex = 4;
            this.CkdBienDeUso.Text = "Bien de uso";
            this.CkdBienDeUso.ThemeName = "TelerikMetroBlue";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(102, 19);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(358, 26);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.ThemeName = "TelerikMetroBlue";
            // 
            // TxtAbreviatura
            // 
            this.TxtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAbreviatura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAbreviatura.Location = new System.Drawing.Point(102, 61);
            this.TxtAbreviatura.MaxLength = 10;
            this.TxtAbreviatura.Name = "TxtAbreviatura";
            this.TxtAbreviatura.Size = new System.Drawing.Size(186, 26);
            this.TxtAbreviatura.TabIndex = 2;
            this.TxtAbreviatura.TabStop = false;
            this.TxtAbreviatura.ThemeName = "TelerikMetroBlue";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(102, 103);
            this.TxtDescripcion.MaxLength = 50;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(358, 26);
            this.TxtDescripcion.TabIndex = 3;
            this.TxtDescripcion.TabStop = false;
            this.TxtDescripcion.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCrearEditarTipoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 232);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtAbreviatura);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CkdBienDeUso);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.radLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearEditarTipoGasto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Tipo de Gasto";
            this.Load += new System.EventHandler(this.FrmCrearEditarDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkdBienDeUso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAbreviatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadCheckBox CkdBienDeUso;
        private Telerik.WinControls.UI.RadTextBox TxtNombre;
        private Telerik.WinControls.UI.RadTextBox TxtAbreviatura;
        private Telerik.WinControls.UI.RadTextBox TxtDescripcion;
    }
}