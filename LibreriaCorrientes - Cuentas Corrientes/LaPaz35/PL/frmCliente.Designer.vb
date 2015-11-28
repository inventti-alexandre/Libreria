<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDNi = New System.Windows.Forms.TextBox()
        Me.pnlCuenta = New System.Windows.Forms.Panel()
        Me.btnCajaMovimiento = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvCajaMovimientos = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvRecibosDetalle = New System.Windows.Forms.DataGridView()
        Me.btnDetallerecibo = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.dgvRecibos = New System.Windows.Forms.DataGridView()
        Me.btnCuotas = New System.Windows.Forms.Button()
        Me.ntnMovimientoPorVenta = New System.Windows.Forms.Button()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.cmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmIdComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDetalleCtCte = New System.Windows.Forms.Button()
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
        Me.dgvClienteCuentasCorriente = New System.Windows.Forms.DataGridView()
        Me.cccid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cccPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCliente = New System.Windows.Forms.Label()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCuenta.SuspendLayout()
        CType(Me.dgvCajaMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecibosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClienteCuentasCorriente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(288, 11)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Denominacion, Me.Cuit})
        Me.dgvClientes.Location = New System.Drawing.Point(369, 11)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(670, 95)
        Me.dgvClientes.TabIndex = 1
        Me.dgvClientes.Visible = False
        '
        'Id
        '
        Me.Id.DataPropertyName = "id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Denominacion
        '
        Me.Denominacion.DataPropertyName = "denominacion"
        Me.Denominacion.HeaderText = "Denominacion"
        Me.Denominacion.Name = "Denominacion"
        '
        'Cuit
        '
        Me.Cuit.DataPropertyName = "cuit"
        Me.Cuit.HeaderText = "Cuit"
        Me.Cuit.Name = "Cuit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente:"
        '
        'txtDNi
        '
        Me.txtDNi.Location = New System.Drawing.Point(84, 14)
        Me.txtDNi.Name = "txtDNi"
        Me.txtDNi.Size = New System.Drawing.Size(198, 20)
        Me.txtDNi.TabIndex = 4
        '
        'pnlCuenta
        '
        Me.pnlCuenta.Controls.Add(Me.btnCajaMovimiento)
        Me.pnlCuenta.Controls.Add(Me.Label7)
        Me.pnlCuenta.Controls.Add(Me.dgvCajaMovimientos)
        Me.pnlCuenta.Controls.Add(Me.Label6)
        Me.pnlCuenta.Controls.Add(Me.Label5)
        Me.pnlCuenta.Controls.Add(Me.Label4)
        Me.pnlCuenta.Controls.Add(Me.Label3)
        Me.pnlCuenta.Controls.Add(Me.Label2)
        Me.pnlCuenta.Controls.Add(Me.dgvRecibosDetalle)
        Me.pnlCuenta.Controls.Add(Me.btnDetallerecibo)
        Me.pnlCuenta.Controls.Add(Me.btnPagos)
        Me.pnlCuenta.Controls.Add(Me.dgvRecibos)
        Me.pnlCuenta.Controls.Add(Me.btnCuotas)
        Me.pnlCuenta.Controls.Add(Me.ntnMovimientoPorVenta)
        Me.pnlCuenta.Controls.Add(Me.dgvMovimientos)
        Me.pnlCuenta.Controls.Add(Me.btnDetalleCtCte)
        Me.pnlCuenta.Controls.Add(Me.dgvVentas)
        Me.pnlCuenta.Controls.Add(Me.dgvClienteCuentasCorriente)
        Me.pnlCuenta.Controls.Add(Me.lblCliente)
        Me.pnlCuenta.Location = New System.Drawing.Point(12, 112)
        Me.pnlCuenta.Name = "pnlCuenta"
        Me.pnlCuenta.Size = New System.Drawing.Size(1063, 768)
        Me.pnlCuenta.TabIndex = 5
        Me.pnlCuenta.Visible = False
        '
        'btnCajaMovimiento
        '
        Me.btnCajaMovimiento.Location = New System.Drawing.Point(979, 246)
        Me.btnCajaMovimiento.Name = "btnCajaMovimiento"
        Me.btnCajaMovimiento.Size = New System.Drawing.Size(75, 43)
        Me.btnCajaMovimiento.TabIndex = 18
        Me.btnCajaMovimiento.Text = "Ver Caja MOvimiento"
        Me.btnCajaMovimiento.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(927, 443)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "CajaMovimiento"
        '
        'dgvCajaMovimientos
        '
        Me.dgvCajaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCajaMovimientos.Location = New System.Drawing.Point(17, 462)
        Me.dgvCajaMovimientos.Name = "dgvCajaMovimientos"
        Me.dgvCajaMovimientos.Size = New System.Drawing.Size(953, 106)
        Me.dgvCajaMovimientos.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(924, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Detalles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(918, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Recibos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(872, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ClienteMovimientos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(924, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(850, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ClientesCuentaCorriente"
        '
        'dgvRecibosDetalle
        '
        Me.dgvRecibosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecibosDetalle.Location = New System.Drawing.Point(17, 369)
        Me.dgvRecibosDetalle.Name = "dgvRecibosDetalle"
        Me.dgvRecibosDetalle.Size = New System.Drawing.Size(953, 77)
        Me.dgvRecibosDetalle.TabIndex = 10
        '
        'btnDetallerecibo
        '
        Me.btnDetallerecibo.Location = New System.Drawing.Point(976, 295)
        Me.btnDetallerecibo.Name = "btnDetallerecibo"
        Me.btnDetallerecibo.Size = New System.Drawing.Size(75, 23)
        Me.btnDetallerecibo.TabIndex = 9
        Me.btnDetallerecibo.Text = "Ver Detalle"
        Me.btnDetallerecibo.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Location = New System.Drawing.Point(976, 216)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(75, 23)
        Me.btnPagos.TabIndex = 8
        Me.btnPagos.Text = "Ver Recibos"
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'dgvRecibos
        '
        Me.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecibos.Location = New System.Drawing.Point(17, 295)
        Me.dgvRecibos.Name = "dgvRecibos"
        Me.dgvRecibos.Size = New System.Drawing.Size(953, 68)
        Me.dgvRecibos.TabIndex = 7
        '
        'btnCuotas
        '
        Me.btnCuotas.Location = New System.Drawing.Point(979, 141)
        Me.btnCuotas.Name = "btnCuotas"
        Me.btnCuotas.Size = New System.Drawing.Size(75, 23)
        Me.btnCuotas.TabIndex = 6
        Me.btnCuotas.Text = "Ver Cuotas"
        Me.btnCuotas.UseVisualStyleBackColor = True
        '
        'ntnMovimientoPorVenta
        '
        Me.ntnMovimientoPorVenta.Location = New System.Drawing.Point(976, 98)
        Me.ntnMovimientoPorVenta.Name = "ntnMovimientoPorVenta"
        Me.ntnMovimientoPorVenta.Size = New System.Drawing.Size(75, 37)
        Me.ntnMovimientoPorVenta.TabIndex = 5
        Me.ntnMovimientoPorVenta.Text = "Ver Movimientos"
        Me.ntnMovimientoPorVenta.UseVisualStyleBackColor = True
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmConcepto, Me.cmDebe, Me.cmHaber, Me.cmObservaciones, Me.cmIdComprobante, Me.Fecha})
        Me.dgvMovimientos.Location = New System.Drawing.Point(17, 200)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.Size = New System.Drawing.Size(953, 89)
        Me.dgvMovimientos.TabIndex = 4
        '
        'cmConcepto
        '
        Me.cmConcepto.DataPropertyName = "concepto"
        Me.cmConcepto.HeaderText = "Concepto"
        Me.cmConcepto.Name = "cmConcepto"
        '
        'cmDebe
        '
        Me.cmDebe.DataPropertyName = "debe"
        Me.cmDebe.HeaderText = "Debe"
        Me.cmDebe.Name = "cmDebe"
        '
        'cmHaber
        '
        Me.cmHaber.DataPropertyName = "haber"
        Me.cmHaber.HeaderText = "Haber"
        Me.cmHaber.Name = "cmHaber"
        '
        'cmObservaciones
        '
        Me.cmObservaciones.DataPropertyName = "observaciones"
        Me.cmObservaciones.HeaderText = "Observaciones"
        Me.cmObservaciones.Name = "cmObservaciones"
        '
        'cmIdComprobante
        '
        Me.cmIdComprobante.DataPropertyName = "idcomprobante"
        Me.cmIdComprobante.HeaderText = "IdComprobante"
        Me.cmIdComprobante.Name = "cmIdComprobante"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "FechaGeneracion"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'btnDetalleCtCte
        '
        Me.btnDetalleCtCte.Location = New System.Drawing.Point(976, 31)
        Me.btnDetalleCtCte.Name = "btnDetalleCtCte"
        Me.btnDetalleCtCte.Size = New System.Drawing.Size(75, 23)
        Me.btnDetalleCtCte.TabIndex = 3
        Me.btnDetalleCtCte.Text = "Ver Venta"
        Me.btnDetalleCtCte.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vid, Me.vcomprobante, Me.cfechacom, Me.vcondventa, Me.FechaVen, Me.vConcepto, Me.vImporteNeto, Me.vImporteSena, Me.vfechaup, Me.vTotalPagado, Me.vcomprobanteid})
        Me.dgvVentas.Location = New System.Drawing.Point(17, 98)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(953, 96)
        Me.dgvVentas.TabIndex = 2
        '
        'vid
        '
        Me.vid.DataPropertyName = "id"
        Me.vid.HeaderText = "Id"
        Me.vid.Name = "vid"
        '
        'vcomprobante
        '
        Me.vcomprobante.DataPropertyName = "numerocomprobante"
        Me.vcomprobante.HeaderText = "NumeroComprobante"
        Me.vcomprobante.Name = "vcomprobante"
        '
        'cfechacom
        '
        Me.cfechacom.DataPropertyName = "fechacomprobante"
        Me.cfechacom.HeaderText = "FechaComprobante"
        Me.cfechacom.Name = "cfechacom"
        '
        'vcondventa
        '
        Me.vcondventa.DataPropertyName = "v_condicionVenta"
        Me.vcondventa.HeaderText = "Condicion de Venta"
        Me.vcondventa.Name = "vcondventa"
        '
        'FechaVen
        '
        Me.FechaVen.DataPropertyName = "FechaVencimiento"
        Me.FechaVen.HeaderText = "FechaVencimiento"
        Me.FechaVen.Name = "FechaVen"
        '
        'vConcepto
        '
        Me.vConcepto.DataPropertyName = "Concepto"
        Me.vConcepto.HeaderText = "Concepto"
        Me.vConcepto.Name = "vConcepto"
        '
        'vImporteNeto
        '
        Me.vImporteNeto.DataPropertyName = "ImporteNeto"
        Me.vImporteNeto.HeaderText = "Importe Neto"
        Me.vImporteNeto.Name = "vImporteNeto"
        '
        'vImporteSena
        '
        Me.vImporteSena.DataPropertyName = "ImporteSena"
        Me.vImporteSena.HeaderText = "Importe Seña"
        Me.vImporteSena.Name = "vImporteSena"
        '
        'vfechaup
        '
        Me.vfechaup.DataPropertyName = "FechaUltimoPago"
        Me.vfechaup.HeaderText = "FechaUltimoPago"
        Me.vfechaup.Name = "vfechaup"
        '
        'vTotalPagado
        '
        Me.vTotalPagado.DataPropertyName = "TotalPagado"
        Me.vTotalPagado.HeaderText = "Total Pagado"
        Me.vTotalPagado.Name = "vTotalPagado"
        '
        'vcomprobanteid
        '
        Me.vcomprobanteid.DataPropertyName = "comprobanteId"
        Me.vcomprobanteid.HeaderText = "ComprobanteID"
        Me.vcomprobanteid.Name = "vcomprobanteid"
        '
        'dgvClienteCuentasCorriente
        '
        Me.dgvClienteCuentasCorriente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClienteCuentasCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClienteCuentasCorriente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cccid, Me.cccFechaVencimiento, Me.cccCuota, Me.cccImporte, Me.cccPagado})
        Me.dgvClienteCuentasCorriente.Location = New System.Drawing.Point(17, 16)
        Me.dgvClienteCuentasCorriente.Name = "dgvClienteCuentasCorriente"
        Me.dgvClienteCuentasCorriente.RowHeadersVisible = False
        Me.dgvClienteCuentasCorriente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClienteCuentasCorriente.Size = New System.Drawing.Size(953, 76)
        Me.dgvClienteCuentasCorriente.TabIndex = 1
        '
        'cccid
        '
        Me.cccid.DataPropertyName = "id"
        Me.cccid.HeaderText = "Id"
        Me.cccid.Name = "cccid"
        Me.cccid.Visible = False
        '
        'cccFechaVencimiento
        '
        Me.cccFechaVencimiento.DataPropertyName = "FechaVencimiento"
        Me.cccFechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.cccFechaVencimiento.Name = "cccFechaVencimiento"
        '
        'cccCuota
        '
        Me.cccCuota.DataPropertyName = "Cuota"
        Me.cccCuota.HeaderText = "Cuota"
        Me.cccCuota.Name = "cccCuota"
        '
        'cccImporte
        '
        Me.cccImporte.DataPropertyName = "Importe"
        Me.cccImporte.HeaderText = "Importe"
        Me.cccImporte.Name = "cccImporte"
        '
        'cccPagado
        '
        Me.cccPagado.DataPropertyName = "Pagado"
        Me.cccPagado.HeaderText = "Pagado"
        Me.cccPagado.Name = "cccPagado"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(14, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 750)
        Me.Controls.Add(Me.pnlCuenta)
        Me.Controls.Add(Me.txtDNi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "frmCliente"
        Me.Text = "Form1"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCuenta.ResumeLayout(False)
        Me.pnlCuenta.PerformLayout()
        CType(Me.dgvCajaMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecibosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClienteCuentasCorriente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDNi As System.Windows.Forms.TextBox
    Friend WithEvents pnlCuenta As System.Windows.Forms.Panel
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents dgvClienteCuentasCorriente As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
    Friend WithEvents cccid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccCuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cccPagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDetalleCtCte As System.Windows.Forms.Button
    Friend WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
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
    Friend WithEvents ntnMovimientoPorVenta As System.Windows.Forms.Button
    Friend WithEvents btnCuotas As System.Windows.Forms.Button
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents dgvRecibos As System.Windows.Forms.DataGridView
    Friend WithEvents btnDetallerecibo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvRecibosDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents cmConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmDebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmHaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmIdComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCajaMovimiento As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvCajaMovimientos As System.Windows.Forms.DataGridView

End Class
