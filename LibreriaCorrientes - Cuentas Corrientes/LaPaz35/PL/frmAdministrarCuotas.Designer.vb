<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrarCuotas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlBuscarCliente = New System.Windows.Forms.Panel()
        Me.txtDNi = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlCuenta = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvClienteCuentasCorriente = New System.Windows.Forms.DataGridView()
        Me.cccFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComporbantedevVneta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impoeteVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importeSenia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAgar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ventaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.pnlVenta = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.vid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcomprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfechacom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcondventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vImporteNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vImporteSena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfechaup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vTotalPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcomprobanteid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSaldo = New System.Windows.Forms.Panel()
        Me.btnSaldo = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlBuscarCliente.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCuenta.SuspendLayout()
        CType(Me.dgvClienteCuentasCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVenta.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSaldo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBuscarCliente
        '
        Me.pnlBuscarCliente.Controls.Add(Me.txtDNi)
        Me.pnlBuscarCliente.Controls.Add(Me.btnBuscar)
        Me.pnlBuscarCliente.Controls.Add(Me.Label1)
        Me.pnlBuscarCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBuscarCliente.Location = New System.Drawing.Point(289, 12)
        Me.pnlBuscarCliente.Name = "pnlBuscarCliente"
        Me.pnlBuscarCliente.Size = New System.Drawing.Size(468, 40)
        Me.pnlBuscarCliente.TabIndex = 2
        '
        'txtDNi
        '
        Me.txtDNi.Location = New System.Drawing.Point(84, 6)
        Me.txtDNi.Name = "txtDNi"
        Me.txtDNi.Size = New System.Drawing.Size(198, 27)
        Me.txtDNi.TabIndex = 0
        Me.txtDNi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSize = True
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(288, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(157, 36)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente: "
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Denominacion, Me.Cuit})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.Location = New System.Drawing.Point(378, 18)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(715, 148)
        Me.dgvClientes.TabIndex = 3
        Me.dgvClientes.Visible = False
        '
        'Id
        '
        Me.Id.DataPropertyName = "id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Denominacion
        '
        Me.Denominacion.DataPropertyName = "denominacion"
        Me.Denominacion.HeaderText = "Denominacion"
        Me.Denominacion.Name = "Denominacion"
        Me.Denominacion.ReadOnly = True
        '
        'Cuit
        '
        Me.Cuit.DataPropertyName = "cuit"
        Me.Cuit.HeaderText = "Cuit"
        Me.Cuit.Name = "Cuit"
        Me.Cuit.ReadOnly = True
        '
        'pnlCuenta
        '
        Me.pnlCuenta.Controls.Add(Me.Label3)
        Me.pnlCuenta.Controls.Add(Me.btnGuardar)
        Me.pnlCuenta.Controls.Add(Me.dgvClienteCuentasCorriente)
        Me.pnlCuenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCuenta.Location = New System.Drawing.Point(5, 301)
        Me.pnlCuenta.Name = "pnlCuenta"
        Me.pnlCuenta.Size = New System.Drawing.Size(1102, 275)
        Me.pnlCuenta.TabIndex = 8
        Me.pnlCuenta.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cuotas de la venta"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(931, 224)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(157, 36)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'dgvClienteCuentasCorriente
        '
        Me.dgvClienteCuentasCorriente.AllowUserToAddRows = False
        Me.dgvClienteCuentasCorriente.AllowUserToDeleteRows = False
        Me.dgvClienteCuentasCorriente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClienteCuentasCorriente.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvClienteCuentasCorriente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClienteCuentasCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClienteCuentasCorriente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cccFechaVencimiento, Me.FechaVenta, Me.ComporbantedevVneta, Me.impoeteVenta, Me.importeSenia, Me.cccCuota, Me.cccImporte, Me.cccPagado, Me.PAgar, Me.ventaid, Me.ClienteId})
        Me.dgvClienteCuentasCorriente.Location = New System.Drawing.Point(9, 29)
        Me.dgvClienteCuentasCorriente.Name = "dgvClienteCuentasCorriente"
        Me.dgvClienteCuentasCorriente.RowHeadersVisible = False
        Me.dgvClienteCuentasCorriente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClienteCuentasCorriente.Size = New System.Drawing.Size(1079, 189)
        Me.dgvClienteCuentasCorriente.TabIndex = 0
        '
        'cccFechaVencimiento
        '
        Me.cccFechaVencimiento.DataPropertyName = "FechaVencimiento"
        Me.cccFechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.cccFechaVencimiento.Name = "cccFechaVencimiento"
        Me.cccFechaVencimiento.ReadOnly = True
        '
        'FechaVenta
        '
        Me.FechaVenta.DataPropertyName = "Fecha"
        Me.FechaVenta.HeaderText = "Fecha de Compra"
        Me.FechaVenta.Name = "FechaVenta"
        Me.FechaVenta.ReadOnly = True
        '
        'ComporbantedevVneta
        '
        Me.ComporbantedevVneta.DataPropertyName = "v_ComprobanteVenta"
        Me.ComporbantedevVneta.HeaderText = "Numero de Comprobante"
        Me.ComporbantedevVneta.Name = "ComporbantedevVneta"
        Me.ComporbantedevVneta.ReadOnly = True
        '
        'impoeteVenta
        '
        Me.impoeteVenta.DataPropertyName = "v_ImporteVenta"
        Me.impoeteVenta.HeaderText = "Total Venta"
        Me.impoeteVenta.Name = "impoeteVenta"
        '
        'importeSenia
        '
        Me.importeSenia.DataPropertyName = "v_SeniaVenta"
        Me.importeSenia.HeaderText = "Seña"
        Me.importeSenia.Name = "importeSenia"
        Me.importeSenia.ReadOnly = True
        Me.importeSenia.Visible = False
        '
        'cccCuota
        '
        Me.cccCuota.DataPropertyName = "Cuota"
        Me.cccCuota.HeaderText = "Cuota"
        Me.cccCuota.Name = "cccCuota"
        Me.cccCuota.ReadOnly = True
        '
        'cccImporte
        '
        Me.cccImporte.DataPropertyName = "Importe"
        Me.cccImporte.HeaderText = "Importe"
        Me.cccImporte.Name = "cccImporte"
        Me.cccImporte.ReadOnly = True
        '
        'cccPagado
        '
        Me.cccPagado.DataPropertyName = "pagado"
        Me.cccPagado.HeaderText = "Pagado"
        Me.cccPagado.Name = "cccPagado"
        '
        'PAgar
        '
        Me.PAgar.HeaderText = "Pagar"
        Me.PAgar.Name = "PAgar"
        Me.PAgar.ReadOnly = True
        Me.PAgar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PAgar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PAgar.Visible = False
        '
        'ventaid
        '
        Me.ventaid.DataPropertyName = "VentaId"
        Me.ventaid.HeaderText = "VentaId"
        Me.ventaid.Name = "ventaid"
        Me.ventaid.ReadOnly = True
        Me.ventaid.Visible = False
        '
        'ClienteId
        '
        Me.ClienteId.DataPropertyName = "clienteid"
        Me.ClienteId.HeaderText = "ClienteId"
        Me.ClienteId.Name = "ClienteId"
        Me.ClienteId.ReadOnly = True
        Me.ClienteId.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(74, 9)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(61, 19)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "cliente: "
        '
        'pnlVenta
        '
        Me.pnlVenta.BackColor = System.Drawing.Color.Transparent
        Me.pnlVenta.Controls.Add(Me.lblCliente)
        Me.pnlVenta.Controls.Add(Me.Label4)
        Me.pnlVenta.Controls.Add(Me.Label2)
        Me.pnlVenta.Controls.Add(Me.dgvVentas)
        Me.pnlVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlVenta.Location = New System.Drawing.Point(5, 95)
        Me.pnlVenta.Name = "pnlVenta"
        Me.pnlVenta.Size = New System.Drawing.Size(1104, 210)
        Me.pnlVenta.TabIndex = 9
        Me.pnlVenta.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Doble Clik para ver las cuotas del plan."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ventas del "
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vid, Me.vcomprobante, Me.cfechacom, Me.vcondventa, Me.FechaVen, Me.vConcepto, Me.vImporteNeto, Me.vImporteSena, Me.vfechaup, Me.vTotalPagado, Me.vcomprobanteid})
        Me.dgvVentas.Location = New System.Drawing.Point(9, 30)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(1080, 142)
        Me.dgvVentas.TabIndex = 3
        '
        'vid
        '
        Me.vid.DataPropertyName = "id"
        Me.vid.HeaderText = "Id"
        Me.vid.Name = "vid"
        Me.vid.ReadOnly = True
        Me.vid.Visible = False
        '
        'vcomprobante
        '
        Me.vcomprobante.DataPropertyName = "numerocomprobante"
        Me.vcomprobante.HeaderText = "Numero Factura"
        Me.vcomprobante.Name = "vcomprobante"
        Me.vcomprobante.ReadOnly = True
        '
        'cfechacom
        '
        Me.cfechacom.DataPropertyName = "fechacomprobante"
        Me.cfechacom.HeaderText = "Fecha Compra"
        Me.cfechacom.Name = "cfechacom"
        Me.cfechacom.ReadOnly = True
        '
        'vcondventa
        '
        Me.vcondventa.DataPropertyName = "v_condicionVenta"
        Me.vcondventa.HeaderText = "Condicion de Venta"
        Me.vcondventa.Name = "vcondventa"
        Me.vcondventa.ReadOnly = True
        '
        'FechaVen
        '
        Me.FechaVen.DataPropertyName = "FechaVencimiento"
        Me.FechaVen.HeaderText = "FechaVencimiento"
        Me.FechaVen.Name = "FechaVen"
        Me.FechaVen.ReadOnly = True
        Me.FechaVen.Visible = False
        '
        'vConcepto
        '
        Me.vConcepto.DataPropertyName = "Concepto"
        Me.vConcepto.HeaderText = "Concepto"
        Me.vConcepto.Name = "vConcepto"
        Me.vConcepto.ReadOnly = True
        '
        'vImporteNeto
        '
        Me.vImporteNeto.DataPropertyName = "ImporteNeto"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.vImporteNeto.DefaultCellStyle = DataGridViewCellStyle3
        Me.vImporteNeto.HeaderText = "Importe Neto"
        Me.vImporteNeto.Name = "vImporteNeto"
        Me.vImporteNeto.ReadOnly = True
        '
        'vImporteSena
        '
        Me.vImporteSena.DataPropertyName = "ImporteSena"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.vImporteSena.DefaultCellStyle = DataGridViewCellStyle4
        Me.vImporteSena.HeaderText = "Importe Seña"
        Me.vImporteSena.Name = "vImporteSena"
        Me.vImporteSena.ReadOnly = True
        '
        'vfechaup
        '
        Me.vfechaup.DataPropertyName = "FechaUltimoPago"
        Me.vfechaup.HeaderText = "FechaUltimoPago"
        Me.vfechaup.Name = "vfechaup"
        Me.vfechaup.ReadOnly = True
        Me.vfechaup.Visible = False
        '
        'vTotalPagado
        '
        Me.vTotalPagado.DataPropertyName = "TotalPagado"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "4"
        Me.vTotalPagado.DefaultCellStyle = DataGridViewCellStyle5
        Me.vTotalPagado.HeaderText = "Total Pagado"
        Me.vTotalPagado.Name = "vTotalPagado"
        Me.vTotalPagado.ReadOnly = True
        '
        'vcomprobanteid
        '
        Me.vcomprobanteid.DataPropertyName = "comprobanteId"
        Me.vcomprobanteid.HeaderText = "ComprobanteID"
        Me.vcomprobanteid.Name = "vcomprobanteid"
        Me.vcomprobanteid.ReadOnly = True
        Me.vcomprobanteid.Visible = False
        '
        'pnlSaldo
        '
        Me.pnlSaldo.Controls.Add(Me.btnSaldo)
        Me.pnlSaldo.Controls.Add(Me.txtSaldo)
        Me.pnlSaldo.Controls.Add(Me.Label8)
        Me.pnlSaldo.Location = New System.Drawing.Point(5, 49)
        Me.pnlSaldo.Name = "pnlSaldo"
        Me.pnlSaldo.Size = New System.Drawing.Size(367, 40)
        Me.pnlSaldo.TabIndex = 10
        Me.pnlSaldo.Visible = False
        '
        'btnSaldo
        '
        Me.btnSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldo.ForeColor = System.Drawing.Color.White
        Me.btnSaldo.Location = New System.Drawing.Point(214, 5)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(112, 27)
        Me.btnSaldo.TabIndex = 18
        Me.btnSaldo.Text = "Guardar"
        Me.btnSaldo.UseVisualStyleBackColor = False
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(90, 9)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label8.Location = New System.Drawing.Point(15, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Saldo:"
        '
        'frmAdministrarCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1150, 588)
        Me.Controls.Add(Me.pnlSaldo)
        Me.Controls.Add(Me.pnlVenta)
        Me.Controls.Add(Me.pnlCuenta)
        Me.Controls.Add(Me.pnlBuscarCliente)
        Me.Controls.Add(Me.dgvClientes)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmAdministrarCuotas"
        Me.Text = "Corregir Estado de Cuenta - Libreria de La Paz"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlBuscarCliente.ResumeLayout(False)
        Me.pnlBuscarCliente.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCuenta.ResumeLayout(False)
        Me.pnlCuenta.PerformLayout()
        CType(Me.dgvClienteCuentasCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVenta.ResumeLayout(False)
        Me.pnlVenta.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSaldo.ResumeLayout(False)
        Me.pnlSaldo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBuscarCliente As System.Windows.Forms.Panel
    Friend WithEvents txtDNi As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCuenta As System.Windows.Forms.Panel
    Friend WithEvents dgvClienteCuentasCorriente As System.Windows.Forms.DataGridView
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents pnlVenta As System.Windows.Forms.Panel
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cccFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComporbantedevVneta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impoeteVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importeSenia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccCuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccPagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAgar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ventaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcomprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfechacom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcondventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vImporteNeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vImporteSena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfechaup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vTotalPagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcomprobanteid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlSaldo As System.Windows.Forms.Panel
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSaldo As System.Windows.Forms.Button
End Class
