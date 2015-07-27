namespace LaPaz.Win.Forms.LotesDeFacturas
{
    partial class FrmCrearEditarLote
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.TxtTipo = new Telerik.WinControls.UI.RadTextBox();
            this.TxtActual = new Telerik.WinControls.UI.RadTextBox();
            this.TxtHasta = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDesde = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.ddlEstados = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ddlEstados);
            this.radPanel1.Controls.Add(this.radLabel5);
            this.radPanel1.Controls.Add(this.TxtTipo);
            this.radPanel1.Controls.Add(this.TxtActual);
            this.radPanel1.Controls.Add(this.TxtHasta);
            this.radPanel1.Controls.Add(this.radLabel4);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.TxtDesde);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Font = new System.Drawing.Font("Vani", 8.25F);
            this.radPanel1.Location = new System.Drawing.Point(21, 21);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(311, 284);
            this.radPanel1.TabIndex = 0;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Enabled = false;
            this.TxtTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipo.Location = new System.Drawing.Point(138, 33);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(100, 26);
            this.TxtTipo.TabIndex = 8;
            this.TxtTipo.TabStop = false;
            this.TxtTipo.Text = "C";
            this.TxtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTipo.ThemeName = "TelerikMetroBlue";
            // 
            // TxtActual
            // 
            this.TxtActual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtActual.Location = new System.Drawing.Point(138, 153);
            this.TxtActual.Name = "TxtActual";
            this.TxtActual.Size = new System.Drawing.Size(100, 26);
            this.TxtActual.TabIndex = 7;
            this.TxtActual.TabStop = false;
            this.TxtActual.ThemeName = "TelerikMetroBlue";
            // 
            // TxtHasta
            // 
            this.TxtHasta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHasta.Location = new System.Drawing.Point(138, 113);
            this.TxtHasta.Name = "TxtHasta";
            this.TxtHasta.Size = new System.Drawing.Size(100, 26);
            this.TxtHasta.TabIndex = 6;
            this.TxtHasta.TabStop = false;
            this.TxtHasta.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(28, 33);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(41, 24);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Tipo:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(28, 153);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(84, 24);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Nro Actual:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(28, 113);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 24);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Nro Hasta:";
            // 
            // TxtDesde
            // 
            this.TxtDesde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesde.Location = new System.Drawing.Point(138, 77);
            this.TxtDesde.Name = "TxtDesde";
            this.TxtDesde.Size = new System.Drawing.Size(100, 26);
            this.TxtDesde.TabIndex = 1;
            this.TxtDesde.TabStop = false;
            this.TxtDesde.ThemeName = "TelerikMetroBlue";
            this.TxtDesde.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDesde_KeyUp);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(28, 73);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(84, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nro Desde:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(232, 311);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(28, 193);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(56, 24);
            this.radLabel5.TabIndex = 9;
            this.radLabel5.Text = "Estado:";
            // 
            // ddlEstados
            // 
            this.ddlEstados.DropDownAnimationEnabled = true;
            this.ddlEstados.Location = new System.Drawing.Point(138, 193);
            this.ddlEstados.MaxDropDownItems = 0;
            this.ddlEstados.Name = "ddlEstados";
            this.ddlEstados.ShowImageInEditorArea = true;
            this.ddlEstados.Size = new System.Drawing.Size(106, 20);
            this.ddlEstados.TabIndex = 10;
            // 
            // FrmCrearEditarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 353);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmCrearEditarLote";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmCrearEditarLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadTextBox TxtActual;
        private Telerik.WinControls.UI.RadTextBox TxtHasta;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtDesde;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtTipo;
        private Telerik.WinControls.UI.RadDropDownList ddlEstados;
        private Telerik.WinControls.UI.RadLabel radLabel5;
    }
}