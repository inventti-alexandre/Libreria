<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlcuotas = New System.Windows.Forms.Panel()
        Me.dgvCuotasAPagar = New System.Windows.Forms.DataGridView()
        Me.FechaVEncimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblApagar = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.pnlMetodosPago = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlEfectivo = New System.Windows.Forms.Panel()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.btnAceptarEfectivo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pnlTarjetas = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCupon = New System.Windows.Forms.TextBox()
        Me.btnAceptarTarjeta = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxTarjeta = New System.Windows.Forms.ComboBox()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.pnlCheque = New System.Windows.Forms.Panel()
        Me.dtpFechaCheque = New System.Windows.Forms.DateTimePicker()
        Me.txtChequeNro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxBancos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.btnAceptarCheque = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFechadeposito = New System.Windows.Forms.DateTimePicker()
        Me.txtDepositoNro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxBancoDeposito = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.btnAceptarDeposito = New System.Windows.Forms.Button()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.Medio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarjetaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarjetaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCupon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsPagos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pnlPagos = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRestante = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlcuotas.SuspendLayout()
        CType(Me.dgvCuotasAPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMetodosPago.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlEfectivo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnlTarjetas.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.pnlCheque.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPagos.SuspendLayout()
        Me.pnlPagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlcuotas
        '
        Me.pnlcuotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcuotas.Controls.Add(Me.dgvCuotasAPagar)
        Me.pnlcuotas.Controls.Add(Me.lblApagar)
        Me.pnlcuotas.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlcuotas.Location = New System.Drawing.Point(13, 44)
        Me.pnlcuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlcuotas.Name = "pnlcuotas"
        Me.pnlcuotas.Size = New System.Drawing.Size(1202, 188)
        Me.pnlcuotas.TabIndex = 0
        '
        'dgvCuotasAPagar
        '
        Me.dgvCuotasAPagar.AllowUserToAddRows = False
        Me.dgvCuotasAPagar.AllowUserToDeleteRows = False
        Me.dgvCuotasAPagar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCuotasAPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCuotasAPagar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvCuotasAPagar.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvCuotasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuotasAPagar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaVEncimiento, Me.Cuota, Me.Importe, Me.Pagado, Me.Pago, Me.Recargo, Me.Total, Me.id})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuotasAPagar.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCuotasAPagar.Location = New System.Drawing.Point(4, 4)
        Me.dgvCuotasAPagar.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCuotasAPagar.Name = "dgvCuotasAPagar"
        Me.dgvCuotasAPagar.RowHeadersVisible = False
        Me.dgvCuotasAPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCuotasAPagar.Size = New System.Drawing.Size(1173, 149)
        Me.dgvCuotasAPagar.TabIndex = 0
        '
        'FechaVEncimiento
        '
        Me.FechaVEncimiento.DataPropertyName = "FechaVencimiento"
        Me.FechaVEncimiento.HeaderText = "Vencimiento"
        Me.FechaVEncimiento.Name = "FechaVEncimiento"
        Me.FechaVEncimiento.ReadOnly = True
        '
        'Cuota
        '
        Me.Cuota.DataPropertyName = "Cuota"
        Me.Cuota.HeaderText = "Cuota"
        Me.Cuota.Name = "Cuota"
        Me.Cuota.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle1
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Pagado
        '
        Me.Pagado.DataPropertyName = "Apagar"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Pagado.HeaderText = "A pagar"
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        '
        'Pago
        '
        Me.Pago.DataPropertyName = "Pagado"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Pago.DefaultCellStyle = DataGridViewCellStyle3
        Me.Pago.HeaderText = "Pago"
        Me.Pago.Name = "Pago"
        '
        'Recargo
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Recargo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Recargo.HeaderText = "Recargo"
        Me.Recargo.Name = "Recargo"
        '
        'Total
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle5
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'lblApagar
        '
        Me.lblApagar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApagar.AutoSize = True
        Me.lblApagar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApagar.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblApagar.Location = New System.Drawing.Point(1044, 157)
        Me.lblApagar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApagar.Name = "lblApagar"
        Me.lblApagar.Size = New System.Drawing.Size(120, 19)
        Me.lblApagar.TabIndex = 2
        Me.lblApagar.Text = "TOTAL A PAGAR: "
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(13, 21)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(63, 19)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente: "
        '
        'pnlMetodosPago
        '
        Me.pnlMetodosPago.Controls.Add(Me.Label3)
        Me.pnlMetodosPago.Controls.Add(Me.TabControl1)
        Me.pnlMetodosPago.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMetodosPago.Location = New System.Drawing.Point(13, 240)
        Me.pnlMetodosPago.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMetodosPago.Name = "pnlMetodosPago"
        Me.pnlMetodosPago.Size = New System.Drawing.Size(353, 268)
        Me.pnlMetodosPago.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Seleccione los métodos de pago"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(3, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(336, 232)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlEfectivo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(328, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Efectivo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlEfectivo
        '
        Me.pnlEfectivo.Controls.Add(Me.txtEfectivo)
        Me.pnlEfectivo.Controls.Add(Me.btnAceptarEfectivo)
        Me.pnlEfectivo.Controls.Add(Me.Label1)
        Me.pnlEfectivo.Location = New System.Drawing.Point(7, 4)
        Me.pnlEfectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlEfectivo.Name = "pnlEfectivo"
        Me.pnlEfectivo.Size = New System.Drawing.Size(230, 118)
        Me.pnlEfectivo.TabIndex = 16
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(86, 20)
        Me.txtEfectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(132, 27)
        Me.txtEfectivo.TabIndex = 0
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAceptarEfectivo
        '
        Me.btnAceptarEfectivo.AccessibleDescription = ""
        Me.btnAceptarEfectivo.AutoSize = True
        Me.btnAceptarEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAceptarEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptarEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEfectivo.ForeColor = System.Drawing.Color.White
        Me.btnAceptarEfectivo.Location = New System.Drawing.Point(120, 55)
        Me.btnAceptarEfectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptarEfectivo.Name = "btnAceptarEfectivo"
        Me.btnAceptarEfectivo.Size = New System.Drawing.Size(98, 42)
        Me.btnAceptarEfectivo.TabIndex = 1
        Me.btnAceptarEfectivo.Text = "Agregar"
        Me.btnAceptarEfectivo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pnlTarjetas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(328, 200)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tarjeta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pnlTarjetas
        '
        Me.pnlTarjetas.Controls.Add(Me.Label6)
        Me.pnlTarjetas.Controls.Add(Me.txtCupon)
        Me.pnlTarjetas.Controls.Add(Me.btnAceptarTarjeta)
        Me.pnlTarjetas.Controls.Add(Me.Label5)
        Me.pnlTarjetas.Controls.Add(Me.Label4)
        Me.pnlTarjetas.Controls.Add(Me.cbxTarjeta)
        Me.pnlTarjetas.Controls.Add(Me.txtTarjeta)
        Me.pnlTarjetas.Location = New System.Drawing.Point(0, 4)
        Me.pnlTarjetas.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTarjetas.Name = "pnlTarjetas"
        Me.pnlTarjetas.Size = New System.Drawing.Size(295, 171)
        Me.pnlTarjetas.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Monto:"
        '
        'txtCupon
        '
        Me.txtCupon.Location = New System.Drawing.Point(120, 81)
        Me.txtCupon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCupon.Name = "txtCupon"
        Me.txtCupon.Size = New System.Drawing.Size(160, 27)
        Me.txtCupon.TabIndex = 3
        '
        'btnAceptarTarjeta
        '
        Me.btnAceptarTarjeta.AccessibleDescription = ""
        Me.btnAceptarTarjeta.AutoSize = True
        Me.btnAceptarTarjeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAceptarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarTarjeta.ForeColor = System.Drawing.Color.White
        Me.btnAceptarTarjeta.Location = New System.Drawing.Point(182, 117)
        Me.btnAceptarTarjeta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptarTarjeta.Name = "btnAceptarTarjeta"
        Me.btnAceptarTarjeta.Size = New System.Drawing.Size(98, 42)
        Me.btnAceptarTarjeta.TabIndex = 4
        Me.btnAceptarTarjeta.Text = "Agregar"
        Me.btnAceptarTarjeta.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Cupon Nro: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Elija la tarjeta: "
        '
        'cbxTarjeta
        '
        Me.cbxTarjeta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxTarjeta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTarjeta.FormattingEnabled = True
        Me.cbxTarjeta.Location = New System.Drawing.Point(120, 46)
        Me.cbxTarjeta.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxTarjeta.Name = "cbxTarjeta"
        Me.cbxTarjeta.Size = New System.Drawing.Size(160, 27)
        Me.cbxTarjeta.TabIndex = 2
        '
        'txtTarjeta
        '
        Me.txtTarjeta.Location = New System.Drawing.Point(120, 12)
        Me.txtTarjeta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(160, 27)
        Me.txtTarjeta.TabIndex = 1
        Me.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.pnlCheque)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(328, 200)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cheque"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'pnlCheque
        '
        Me.pnlCheque.Controls.Add(Me.dtpFechaCheque)
        Me.pnlCheque.Controls.Add(Me.txtChequeNro)
        Me.pnlCheque.Controls.Add(Me.Label10)
        Me.pnlCheque.Controls.Add(Me.Label9)
        Me.pnlCheque.Controls.Add(Me.cbxBancos)
        Me.pnlCheque.Controls.Add(Me.Label8)
        Me.pnlCheque.Controls.Add(Me.Label7)
        Me.pnlCheque.Controls.Add(Me.txtCheque)
        Me.pnlCheque.Controls.Add(Me.btnAceptarCheque)
        Me.pnlCheque.Location = New System.Drawing.Point(4, 4)
        Me.pnlCheque.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCheque.Name = "pnlCheque"
        Me.pnlCheque.Size = New System.Drawing.Size(315, 182)
        Me.pnlCheque.TabIndex = 15
        '
        'dtpFechaCheque
        '
        Me.dtpFechaCheque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCheque.Location = New System.Drawing.Point(118, 96)
        Me.dtpFechaCheque.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaCheque.Name = "dtpFechaCheque"
        Me.dtpFechaCheque.Size = New System.Drawing.Size(189, 27)
        Me.dtpFechaCheque.TabIndex = 3
        '
        'txtChequeNro
        '
        Me.txtChequeNro.Location = New System.Drawing.Point(118, 65)
        Me.txtChequeNro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChequeNro.Name = "txtChequeNro"
        Me.txtChequeNro.Size = New System.Drawing.Size(189, 27)
        Me.txtChequeNro.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 102)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fecha de Cobro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 68)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Numero:"
        '
        'cbxBancos
        '
        Me.cbxBancos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxBancos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxBancos.FormattingEnabled = True
        Me.cbxBancos.Location = New System.Drawing.Point(118, 36)
        Me.cbxBancos.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxBancos.Name = "cbxBancos"
        Me.cbxBancos.Size = New System.Drawing.Size(189, 27)
        Me.cbxBancos.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 39)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Banco:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Monto:"
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(118, 7)
        Me.txtCheque.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(189, 27)
        Me.txtCheque.TabIndex = 0
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAceptarCheque
        '
        Me.btnAceptarCheque.AccessibleDescription = ""
        Me.btnAceptarCheque.AutoSize = True
        Me.btnAceptarCheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAceptarCheque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptarCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarCheque.ForeColor = System.Drawing.Color.White
        Me.btnAceptarCheque.Location = New System.Drawing.Point(209, 131)
        Me.btnAceptarCheque.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptarCheque.Name = "btnAceptarCheque"
        Me.btnAceptarCheque.Size = New System.Drawing.Size(98, 42)
        Me.btnAceptarCheque.TabIndex = 4
        Me.btnAceptarCheque.Text = "Agregar"
        Me.btnAceptarCheque.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(328, 200)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Depósito"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpFechadeposito)
        Me.Panel1.Controls.Add(Me.txtDepositoNro)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cbxBancoDeposito)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtDeposito)
        Me.Panel1.Controls.Add(Me.btnAceptarDeposito)
        Me.Panel1.Location = New System.Drawing.Point(7, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 182)
        Me.Panel1.TabIndex = 16
        '
        'dtpFechadeposito
        '
        Me.dtpFechadeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechadeposito.Location = New System.Drawing.Point(118, 96)
        Me.dtpFechadeposito.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechadeposito.Name = "dtpFechadeposito"
        Me.dtpFechadeposito.Size = New System.Drawing.Size(189, 27)
        Me.dtpFechadeposito.TabIndex = 3
        '
        'txtDepositoNro
        '
        Me.txtDepositoNro.Location = New System.Drawing.Point(118, 65)
        Me.txtDepositoNro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepositoNro.Name = "txtDepositoNro"
        Me.txtDepositoNro.Size = New System.Drawing.Size(189, 27)
        Me.txtDepositoNro.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(67, 104)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 19)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Fecha:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 68)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Numero:"
        '
        'cbxBancoDeposito
        '
        Me.cbxBancoDeposito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxBancoDeposito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxBancoDeposito.FormattingEnabled = True
        Me.cbxBancoDeposito.Location = New System.Drawing.Point(118, 36)
        Me.cbxBancoDeposito.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxBancoDeposito.Name = "cbxBancoDeposito"
        Me.cbxBancoDeposito.Size = New System.Drawing.Size(189, 27)
        Me.cbxBancoDeposito.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(65, 39)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 19)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Cuenta:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(63, 10)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 19)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Monto:"
        '
        'txtDeposito
        '
        Me.txtDeposito.Location = New System.Drawing.Point(118, 7)
        Me.txtDeposito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(189, 27)
        Me.txtDeposito.TabIndex = 0
        Me.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAceptarDeposito
        '
        Me.btnAceptarDeposito.AccessibleDescription = ""
        Me.btnAceptarDeposito.AutoSize = True
        Me.btnAceptarDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAceptarDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarDeposito.ForeColor = System.Drawing.Color.White
        Me.btnAceptarDeposito.Location = New System.Drawing.Point(209, 131)
        Me.btnAceptarDeposito.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptarDeposito.Name = "btnAceptarDeposito"
        Me.btnAceptarDeposito.Size = New System.Drawing.Size(98, 42)
        Me.btnAceptarDeposito.TabIndex = 4
        Me.btnAceptarDeposito.Text = "Agregar"
        Me.btnAceptarDeposito.UseVisualStyleBackColor = False
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Medio, Me.ImportePago, Me.TarjetaId, Me.TarjetaNombre, Me.NroCupon, Me.BancoId, Me.BancoNombre, Me.NroCheque, Me.FechaCheque})
        Me.dgvPagos.ContextMenuStrip = Me.cmsPagos
        Me.dgvPagos.Location = New System.Drawing.Point(7, 23)
        Me.dgvPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.RowHeadersVisible = False
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(800, 193)
        Me.dgvPagos.TabIndex = 11
        '
        'Medio
        '
        Me.Medio.HeaderText = "Medio de Pago"
        Me.Medio.Name = "Medio"
        Me.Medio.ReadOnly = True
        '
        'ImportePago
        '
        Me.ImportePago.HeaderText = "Importe"
        Me.ImportePago.Name = "ImportePago"
        Me.ImportePago.ReadOnly = True
        '
        'TarjetaId
        '
        Me.TarjetaId.HeaderText = "TarjetaId"
        Me.TarjetaId.Name = "TarjetaId"
        Me.TarjetaId.ReadOnly = True
        Me.TarjetaId.Visible = False
        '
        'TarjetaNombre
        '
        Me.TarjetaNombre.HeaderText = "Tarjeta"
        Me.TarjetaNombre.Name = "TarjetaNombre"
        Me.TarjetaNombre.ReadOnly = True
        '
        'NroCupon
        '
        Me.NroCupon.HeaderText = "NroCupon"
        Me.NroCupon.Name = "NroCupon"
        Me.NroCupon.ReadOnly = True
        '
        'BancoId
        '
        Me.BancoId.HeaderText = "BancoId"
        Me.BancoId.Name = "BancoId"
        Me.BancoId.ReadOnly = True
        Me.BancoId.Visible = False
        '
        'BancoNombre
        '
        Me.BancoNombre.HeaderText = "Banco"
        Me.BancoNombre.Name = "BancoNombre"
        Me.BancoNombre.ReadOnly = True
        '
        'NroCheque
        '
        Me.NroCheque.HeaderText = "ChequeNro"
        Me.NroCheque.Name = "NroCheque"
        Me.NroCheque.ReadOnly = True
        '
        'FechaCheque
        '
        Me.FechaCheque.HeaderText = "Fecha Cobro"
        Me.FechaCheque.Name = "FechaCheque"
        Me.FechaCheque.ReadOnly = True
        '
        'cmsPagos
        '
        Me.cmsPagos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.cmsPagos.Name = "cmsPagos"
        Me.cmsPagos.Size = New System.Drawing.Size(153, 48)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTotal.Location = New System.Drawing.Point(615, 220)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(109, 19)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total pagado: 0"
        '
        'pnlPagos
        '
        Me.pnlPagos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPagos.Controls.Add(Me.Label2)
        Me.pnlPagos.Controls.Add(Me.lblRestante)
        Me.pnlPagos.Controls.Add(Me.dgvPagos)
        Me.pnlPagos.Controls.Add(Me.lblTotal)
        Me.pnlPagos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPagos.Location = New System.Drawing.Point(383, 240)
        Me.pnlPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPagos.Name = "pnlPagos"
        Me.pnlPagos.Size = New System.Drawing.Size(832, 268)
        Me.pnlPagos.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Pagos ingresados"
        '
        'lblRestante
        '
        Me.lblRestante.AutoSize = True
        Me.lblRestante.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestante.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRestante.Location = New System.Drawing.Point(657, 239)
        Me.lblRestante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRestante.Name = "lblRestante"
        Me.lblRestante.Size = New System.Drawing.Size(57, 19)
        Me.lblRestante.TabIndex = 13
        Me.lblRestante.Text = "Falta: 0"
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(1111, 516)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 41)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'FrmCuota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1231, 561)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pnlMetodosPago)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.pnlcuotas)
        Me.Controls.Add(Me.pnlPagos)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCuota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Pago"
        Me.pnlcuotas.ResumeLayout(False)
        Me.pnlcuotas.PerformLayout()
        CType(Me.dgvCuotasAPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMetodosPago.ResumeLayout(False)
        Me.pnlMetodosPago.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlEfectivo.ResumeLayout(False)
        Me.pnlEfectivo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.pnlTarjetas.ResumeLayout(False)
        Me.pnlTarjetas.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.pnlCheque.ResumeLayout(False)
        Me.pnlCheque.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPagos.ResumeLayout(False)
        Me.pnlPagos.ResumeLayout(False)
        Me.pnlPagos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlcuotas As System.Windows.Forms.Panel
    Friend WithEvents dgvCuotasAPagar As System.Windows.Forms.DataGridView
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblApagar As System.Windows.Forms.Label
    Friend WithEvents pnlMetodosPago As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTarjetas As System.Windows.Forms.Panel
    Friend WithEvents txtTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents txtCupon As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxTarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents dgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptarEfectivo As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnAceptarCheque As System.Windows.Forms.Button
    Friend WithEvents btnAceptarTarjeta As System.Windows.Forms.Button
    Friend WithEvents pnlPagos As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRestante As System.Windows.Forms.Label
    Friend WithEvents pnlCheque As System.Windows.Forms.Panel
    Friend WithEvents dtpFechaCheque As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtChequeNro As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cmsPagos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlEfectivo As System.Windows.Forms.Panel
    Friend WithEvents Medio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImportePago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarjetaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarjetaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCupon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FechaVEncimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpFechadeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDepositoNro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbxBancoDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDeposito As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarDeposito As System.Windows.Forms.Button
End Class
