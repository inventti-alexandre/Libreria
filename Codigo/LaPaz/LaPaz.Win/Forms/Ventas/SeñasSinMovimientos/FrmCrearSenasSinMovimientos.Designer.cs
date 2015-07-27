namespace LaPaz.Win.Forms.Ventas.SeñasSinMovimientos
{
    partial class FrmCrearSenasSinMovimientos
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.TabSeñas = new Telerik.WinControls.UI.RadPageView();
            this.TabSeñasNueva = new Telerik.WinControls.UI.RadPageViewPage();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.ucTotalesSeña = new LaPaz.Win.Forms.Compras.UcTotalesSeña();
            this.TabSeñasHistorial = new Telerik.WinControls.UI.RadPageViewPage();
            this.GridSeñas = new Telerik.WinControls.UI.RadGridView();
            this.LblCliente = new Telerik.WinControls.UI.RadLabel();
            this.ucBuscadorClienteSimple = new LaPaz.Win.Forms.Ventas.SeñasSinMovimientos.UcBuscadorClienteSimple();
            this.pnlBuscador = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.TxtCliente = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDni = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox4 = new Telerik.WinControls.UI.RadTextBox();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.TxtSenias = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox6 = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCreditos = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.pnlMontoSenia = new System.Windows.Forms.Panel();
            this.TxtMonto = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TabSeñas)).BeginInit();
            this.TabSeñas.SuspendLayout();
            this.TabSeñasNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            this.TabSeñasHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBuscador)).BeginInit();
            this.pnlBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).BeginInit();
            this.TxtDni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenias)).BeginInit();
            this.TxtSenias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.pnlMontoSenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TabSeñas
            // 
            this.TabSeñas.Controls.Add(this.TabSeñasNueva);
            this.TabSeñas.Controls.Add(this.TabSeñasHistorial);
            this.TabSeñas.Location = new System.Drawing.Point(14, 50);
            this.TabSeñas.Name = "TabSeñas";
            this.TabSeñas.SelectedPage = this.TabSeñasNueva;
            this.TabSeñas.Size = new System.Drawing.Size(692, 338);
            this.TabSeñas.TabIndex = 0;
            this.TabSeñas.Text = "radPageView1";
            this.TabSeñas.ThemeName = "TelerikMetroBlue";
            this.TabSeñas.SelectedPageChanged += new System.EventHandler(this.TabSeñas_SelectedPageChanged);
            // 
            // TabSeñasNueva
            // 
            this.TabSeñasNueva.Controls.Add(this.BtnGuardar);
            this.TabSeñasNueva.Controls.Add(this.ucTotalesSeña);
            this.TabSeñasNueva.Location = new System.Drawing.Point(5, 31);
            this.TabSeñasNueva.Name = "TabSeñasNueva";
            this.TabSeñasNueva.Size = new System.Drawing.Size(682, 302);
            this.TabSeñasNueva.Text = "Nueva Seña";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(559, 269);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(103, 29);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // ucTotalesSeña
            // 
            this.ucTotalesSeña.Location = new System.Drawing.Point(3, 3);
            this.ucTotalesSeña.Name = "ucTotalesSeña";
            this.ucTotalesSeña.Size = new System.Drawing.Size(659, 260);
            this.ucTotalesSeña.TabIndex = 6;
            this.ucTotalesSeña.TotalPagar = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // TabSeñasHistorial
            // 
            this.TabSeñasHistorial.Controls.Add(this.GridSeñas);
            this.TabSeñasHistorial.Location = new System.Drawing.Point(5, 31);
            this.TabSeñasHistorial.Name = "TabSeñasHistorial";
            this.TabSeñasHistorial.Size = new System.Drawing.Size(682, 300);
            this.TabSeñasHistorial.Text = "Historial";
            // 
            // GridSeñas
            // 
            this.GridSeñas.Location = new System.Drawing.Point(0, 3);
            // 
            // 
            // 
            this.GridSeñas.MasterTemplate.AllowAddNewRow = false;
            this.GridSeñas.MasterTemplate.AllowColumnReorder = false;
            this.GridSeñas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Fecha";
            gridViewTextBoxColumn1.MaxWidth = 100;
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "Fecha";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "Concepto";
            gridViewTextBoxColumn2.HeaderText = "Concepto";
            gridViewTextBoxColumn2.Name = "Concepto";
            gridViewTextBoxColumn2.Width = 232;
            gridViewTextBoxColumn3.FieldName = "Importe";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Importe";
            gridViewTextBoxColumn3.MaxWidth = 100;
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "Importe";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "ImpOcupado";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Utilizado";
            gridViewTextBoxColumn4.MaxWidth = 100;
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "Utilizado";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "FechaAnulacion";
            gridViewTextBoxColumn5.HeaderText = "Fecha Anulacion";
            gridViewTextBoxColumn5.MaxWidth = 100;
            gridViewTextBoxColumn5.MinWidth = 100;
            gridViewTextBoxColumn5.Name = "FechaAnulacion";
            gridViewTextBoxColumn5.Width = 100;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Eliminar";
            gridViewCommandColumn1.Width = 30;
            this.GridSeñas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            this.GridSeñas.MasterTemplate.EnableGrouping = false;
            this.GridSeñas.Name = "GridSeñas";
            this.GridSeñas.ReadOnly = true;
            this.GridSeñas.Size = new System.Drawing.Size(679, 231);
            this.GridSeñas.TabIndex = 0;
            this.GridSeñas.ThemeName = "TelerikMetroBlue";
            this.GridSeñas.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridSeñas_CommandCellClick);
            // 
            // LblCliente
            // 
            this.LblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(8, 6);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(149, 25);
            this.LblCliente.TabIndex = 2;
            this.LblCliente.Text = "Nombre y Apellido:";
            this.LblCliente.ThemeName = "TelerikMetroBlue";
            // 
            // ucBuscadorClienteSimple
            // 
            this.ucBuscadorClienteSimple.Location = new System.Drawing.Point(100, 2);
            this.ucBuscadorClienteSimple.Name = "ucBuscadorClienteSimple";
            this.ucBuscadorClienteSimple.Size = new System.Drawing.Size(540, 38);
            this.ucBuscadorClienteSimple.TabIndex = 1;
            // 
            // pnlBuscador
            // 
            this.pnlBuscador.Controls.Add(this.radPanel2);
            this.pnlBuscador.Controls.Add(this.ucBuscadorClienteSimple);
            this.pnlBuscador.Location = new System.Drawing.Point(12, 12);
            this.pnlBuscador.Name = "pnlBuscador";
            this.pnlBuscador.Size = new System.Drawing.Size(728, 41);
            this.pnlBuscador.TabIndex = 3;
            // 
            // radPanel2
            // 
            this.radPanel2.Location = new System.Drawing.Point(0, 144);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(704, 96);
            this.radPanel2.TabIndex = 4;
            this.radPanel2.Text = "radPanel2";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Enabled = false;
            this.TxtCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(164, 5);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(295, 26);
            this.TxtCliente.TabIndex = 3;
            this.TxtCliente.TabStop = false;
            this.TxtCliente.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(8, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(40, 25);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "DNI:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtDni
            // 
            this.TxtDni.Controls.Add(this.radTextBox4);
            this.TxtDni.Enabled = false;
            this.TxtDni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDni.Location = new System.Drawing.Point(164, 36);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(295, 26);
            this.TxtDni.TabIndex = 5;
            this.TxtDni.TabStop = false;
            this.TxtDni.ThemeName = "TelerikMetroBlue";
            // 
            // radTextBox4
            // 
            this.radTextBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox4.Location = new System.Drawing.Point(107, 29);
            this.radTextBox4.Name = "radTextBox4";
            this.radTextBox4.Size = new System.Drawing.Size(295, 26);
            this.radTextBox4.TabIndex = 9;
            this.radTextBox4.TabStop = false;
            this.radTextBox4.ThemeName = "TelerikMetroBlue";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.TxtSenias);
            this.radPanel3.Controls.Add(this.TxtCreditos);
            this.radPanel3.Controls.Add(this.TxtDni);
            this.radPanel3.Controls.Add(this.radLabel3);
            this.radPanel3.Controls.Add(this.radLabel2);
            this.radPanel3.Controls.Add(this.LblCliente);
            this.radPanel3.Controls.Add(this.TxtCliente);
            this.radPanel3.Controls.Add(this.radLabel1);
            this.radPanel3.Location = new System.Drawing.Point(12, 54);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(728, 133);
            this.radPanel3.TabIndex = 4;
            // 
            // TxtSenias
            // 
            this.TxtSenias.Controls.Add(this.radTextBox6);
            this.TxtSenias.Enabled = false;
            this.TxtSenias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenias.Location = new System.Drawing.Point(164, 67);
            this.TxtSenias.Name = "TxtSenias";
            this.TxtSenias.Size = new System.Drawing.Size(295, 26);
            this.TxtSenias.TabIndex = 10;
            this.TxtSenias.TabStop = false;
            this.TxtSenias.ThemeName = "TelerikMetroBlue";
            // 
            // radTextBox6
            // 
            this.radTextBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox6.Location = new System.Drawing.Point(107, 29);
            this.radTextBox6.Name = "radTextBox6";
            this.radTextBox6.Size = new System.Drawing.Size(295, 26);
            this.radTextBox6.TabIndex = 9;
            this.radTextBox6.TabStop = false;
            this.radTextBox6.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCreditos
            // 
            this.TxtCreditos.Enabled = false;
            this.TxtCreditos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCreditos.Location = new System.Drawing.Point(164, 98);
            this.TxtCreditos.Name = "TxtCreditos";
            this.TxtCreditos.Size = new System.Drawing.Size(295, 26);
            this.TxtCreditos.TabIndex = 8;
            this.TxtCreditos.TabStop = false;
            this.TxtCreditos.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(8, 99);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(129, 25);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Creditos a Favor:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(8, 68);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 25);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Señas:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.pnlMontoSenia);
            this.radPanel1.Controls.Add(this.TabSeñas);
            this.radPanel1.Location = new System.Drawing.Point(12, 188);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(728, 404);
            this.radPanel1.TabIndex = 5;
            // 
            // pnlMontoSenia
            // 
            this.pnlMontoSenia.Controls.Add(this.radLabel5);
            this.pnlMontoSenia.Controls.Add(this.TxtMonto);
            this.pnlMontoSenia.Controls.Add(this.radButton1);
            this.pnlMontoSenia.Controls.Add(this.radLabel4);
            this.pnlMontoSenia.Location = new System.Drawing.Point(8, 5);
            this.pnlMontoSenia.Name = "pnlMontoSenia";
            this.pnlMontoSenia.Size = new System.Drawing.Size(558, 39);
            this.pnlMontoSenia.TabIndex = 8;
            // 
            // TxtMonto
            // 
            this.TxtMonto.AceptaNegativos = false;
            this.TxtMonto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(69, 8);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(128, 25);
            this.TxtMonto.TabIndex = 2;
            this.TxtMonto.TabStop = false;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMonto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMonto_KeyUp);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(204, 6);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(111, 27);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Aceptar";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(3, 8);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(60, 25);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Monto:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.ForeColor = System.Drawing.Color.SteelBlue;
            this.radLabel5.Location = new System.Drawing.Point(321, 8);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(198, 25);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "Cargar señas ya existentes";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCrearSenasSinMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 712);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.pnlBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearSenasSinMovimientos";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmCrearSenas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabSeñas)).EndInit();
            this.TabSeñas.ResumeLayout(false);
            this.TabSeñasNueva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            this.TabSeñasHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSeñas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBuscador)).EndInit();
            this.pnlBuscador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).EndInit();
            this.TxtDni.ResumeLayout(false);
            this.TxtDni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenias)).EndInit();
            this.TxtSenias.ResumeLayout(false);
            this.TxtSenias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.pnlMontoSenia.ResumeLayout(false);
            this.pnlMontoSenia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView TabSeñas;
        private Telerik.WinControls.UI.RadPageViewPage TabSeñasNueva;
        private Telerik.WinControls.UI.RadPageViewPage TabSeñasHistorial;
        private UcBuscadorClienteSimple ucBuscadorClienteSimple;
        private Telerik.WinControls.UI.RadLabel LblCliente;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadGridView GridSeñas;
        private Compras.UcTotalesSeña ucTotalesSeña;
        private Telerik.WinControls.UI.RadPanel pnlBuscador;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadTextBox TxtCliente;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtDni;
        private Telerik.WinControls.UI.RadTextBox radTextBox4;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadTextBox TxtSenias;
        private Telerik.WinControls.UI.RadTextBox radTextBox6;
        private Telerik.WinControls.UI.RadTextBox TxtCreditos;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtMonto;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Panel pnlMontoSenia;
        private Telerik.WinControls.UI.RadLabel radLabel5;
    }
}