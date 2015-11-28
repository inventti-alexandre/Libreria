<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrarCuotasusers
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlBuscarCliente = New System.Windows.Forms.Panel()
        Me.txtDNi = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlCuenta = New System.Windows.Forms.Panel()
        Me.lblDeudaVencida = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvClienteCuentasCorriente = New System.Windows.Forms.DataGridView()
        Me.cccFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComporbantedevVneta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impoeteVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importeSenia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAgar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ventaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBuscarCliente.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCuenta.SuspendLayout()
        CType(Me.dgvClienteCuentasCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBuscarCliente
        '
        Me.pnlBuscarCliente.Controls.Add(Me.txtDNi)
        Me.pnlBuscarCliente.Controls.Add(Me.btnBuscar)
        Me.pnlBuscarCliente.Controls.Add(Me.Label1)
        Me.pnlBuscarCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBuscarCliente.Location = New System.Drawing.Point(286, 24)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Denominacion, Me.Cuit})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.pnlCuenta.Controls.Add(Me.lblDeudaVencida)
        Me.pnlCuenta.Controls.Add(Me.lblDeuda)
        Me.pnlCuenta.Controls.Add(Me.lblCliente)
        Me.pnlCuenta.Controls.Add(Me.Label3)
        Me.pnlCuenta.Controls.Add(Me.dgvClienteCuentasCorriente)
        Me.pnlCuenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCuenta.Location = New System.Drawing.Point(12, 70)
        Me.pnlCuenta.Name = "pnlCuenta"
        Me.pnlCuenta.Size = New System.Drawing.Size(1102, 518)
        Me.pnlCuenta.TabIndex = 8
        Me.pnlCuenta.Visible = False
        '
        'lblDeudaVencida
        '
        Me.lblDeudaVencida.AutoSize = True
        Me.lblDeudaVencida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblDeudaVencida.Location = New System.Drawing.Point(5, 66)
        Me.lblDeudaVencida.Name = "lblDeudaVencida"
        Me.lblDeudaVencida.Size = New System.Drawing.Size(60, 19)
        Me.lblDeudaVencida.TabIndex = 13
        Me.lblDeudaVencida.Text = "Vencida"
        '
        'lblDeuda
        '
        Me.lblDeuda.AutoSize = True
        Me.lblDeuda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblDeuda.Location = New System.Drawing.Point(5, 37)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(51, 19)
        Me.lblDeuda.TabIndex = 12
        Me.lblDeuda.Text = "Deuda"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(87, 7)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(0, 19)
        Me.lblCliente.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cuotas del "
        '
        'dgvClienteCuentasCorriente
        '
        Me.dgvClienteCuentasCorriente.AllowUserToAddRows = False
        Me.dgvClienteCuentasCorriente.AllowUserToDeleteRows = False
        Me.dgvClienteCuentasCorriente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClienteCuentasCorriente.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvClienteCuentasCorriente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClienteCuentasCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClienteCuentasCorriente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cccFechaVencimiento, Me.FechaVenta, Me.ComporbantedevVneta, Me.impoeteVenta, Me.importeSenia, Me.cccCuota, Me.cccImporte, Me.cccPagado, Me.FechaPago, Me.PAgar, Me.ventaid, Me.ClienteId})
        Me.dgvClienteCuentasCorriente.Location = New System.Drawing.Point(9, 88)
        Me.dgvClienteCuentasCorriente.Name = "dgvClienteCuentasCorriente"
        Me.dgvClienteCuentasCorriente.ReadOnly = True
        Me.dgvClienteCuentasCorriente.RowHeadersVisible = False
        Me.dgvClienteCuentasCorriente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClienteCuentasCorriente.Size = New System.Drawing.Size(1079, 391)
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
        Me.impoeteVenta.ReadOnly = True
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
        Me.cccPagado.ReadOnly = True
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "FechaUltimoPago"
        Me.FechaPago.HeaderText = "Fecha de Pago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
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
        'frmAdministrarCuotasusers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1150, 588)
        Me.Controls.Add(Me.pnlCuenta)
        Me.Controls.Add(Me.pnlBuscarCliente)
        Me.Controls.Add(Me.dgvClientes)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmAdministrarCuotasusers"
        Me.Text = "Corregir Estado de Cuenta - Libreria de La Paz"
        Me.pnlBuscarCliente.ResumeLayout(False)
        Me.pnlBuscarCliente.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCuenta.ResumeLayout(False)
        Me.pnlCuenta.PerformLayout()
        CType(Me.dgvClienteCuentasCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBuscarCliente As System.Windows.Forms.Panel
    Friend WithEvents txtDNi As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCuenta As System.Windows.Forms.Panel
    Friend WithEvents dgvClienteCuentasCorriente As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents cccFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComporbantedevVneta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impoeteVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importeSenia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccCuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccPagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAgar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ventaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDeudaVencida As System.Windows.Forms.Label
    Friend WithEvents lblDeuda As System.Windows.Forms.Label
End Class
