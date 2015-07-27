using System.Windows.Forms;

namespace LaPaz.Win.Forms.Libros
{
    partial class FrmActualizarStockLibro
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
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtStockConsignadoMigracion = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtStockPropioMigracion = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtStockPropio = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtStockConsignado = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.metroLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.BtnEditar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockConsignadoMigracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockPropioMigracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockPropio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockConsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(283, 242);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(177, 242);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(24, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 24);
            this.metroLabel3.TabIndex = 68;
            this.metroLabel3.Text = "Stock Propio:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(24, 186);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 24);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Stock Consignado 8:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtStockConsignadoMigracion
            // 
            this.TxtStockConsignadoMigracion.Enabled = false;
            this.TxtStockConsignadoMigracion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockConsignadoMigracion.Location = new System.Drawing.Point(177, 185);
            this.TxtStockConsignadoMigracion.MaxLength = 17;
            this.TxtStockConsignadoMigracion.Name = "TxtStockConsignadoMigracion";
            this.TxtStockConsignadoMigracion.Size = new System.Drawing.Size(205, 26);
            this.TxtStockConsignadoMigracion.TabIndex = 7;
            this.TxtStockConsignadoMigracion.TabStop = false;
            this.TxtStockConsignadoMigracion.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(24, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 24);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "Stock Propio 8:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtStockPropioMigracion
            // 
            this.TxtStockPropioMigracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStockPropioMigracion.Enabled = false;
            this.TxtStockPropioMigracion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockPropioMigracion.Location = new System.Drawing.Point(177, 141);
            this.TxtStockPropioMigracion.MaxLength = 15;
            this.TxtStockPropioMigracion.Name = "TxtStockPropioMigracion";
            this.TxtStockPropioMigracion.Size = new System.Drawing.Size(205, 26);
            this.TxtStockPropioMigracion.TabIndex = 2;
            this.TxtStockPropioMigracion.TabStop = false;
            this.TxtStockPropioMigracion.ThemeName = "TelerikMetroBlue";
            // 
            // TxtStockPropio
            // 
            this.TxtStockPropio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStockPropio.Enabled = false;
            this.TxtStockPropio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockPropio.Location = new System.Drawing.Point(177, 56);
            this.TxtStockPropio.MaxLength = 50;
            this.TxtStockPropio.Name = "TxtStockPropio";
            this.TxtStockPropio.Size = new System.Drawing.Size(205, 26);
            this.TxtStockPropio.TabIndex = 0;
            this.TxtStockPropio.TabStop = false;
            this.TxtStockPropio.ThemeName = "TelerikMetroBlue";
            // 
            // TxtStockConsignado
            // 
            this.TxtStockConsignado.Enabled = false;
            this.TxtStockConsignado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockConsignado.Location = new System.Drawing.Point(177, 99);
            this.TxtStockConsignado.MaxLength = 50;
            this.TxtStockConsignado.Name = "TxtStockConsignado";
            this.TxtStockConsignado.Size = new System.Drawing.Size(205, 26);
            this.TxtStockConsignado.TabIndex = 1;
            this.TxtStockConsignado.TabStop = false;
            this.TxtStockConsignado.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel10.Location = new System.Drawing.Point(24, 100);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(134, 24);
            this.metroLabel10.TabIndex = 83;
            this.metroLabel10.Text = "Stock Consignado:";
            this.metroLabel10.ThemeName = "TelerikMetroBlue";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(24, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 30);
            this.BtnEditar.TabIndex = 13;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.ThemeName = "TelerikMetroBlue";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmActualizarStockLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(418, 302);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtStockConsignadoMigracion);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtStockPropioMigracion);
            this.Controls.Add(this.TxtStockPropio);
            this.Controls.Add(this.TxtStockConsignado);
            this.Controls.Add(this.metroLabel10);
            this.Name = "FrmActualizarStockLibro";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Agregar Nuevo Libro";
            this.Load += new System.EventHandler(this.FrmActualizarStockLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockConsignadoMigracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockPropioMigracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockPropio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStockConsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtStockConsignadoMigracion;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtStockPropioMigracion;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtStockPropio;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtStockConsignado;
        private Telerik.WinControls.UI.RadLabel metroLabel10;
        private Telerik.WinControls.UI.RadButton BtnEditar;
    }
}