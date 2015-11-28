<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientosCliente
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
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.idTipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmIdComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimientos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTipoComprobante, Me.Fecha, Me.NumeroRecibo, Me.Factura, Me.cmDebe, Me.cmHaber, Me.cmObservaciones, Me.cmConcepto, Me.cmIdComprobante})
        Me.dgvMovimientos.Location = New System.Drawing.Point(7, 59)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.ReadOnly = True
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.Size = New System.Drawing.Size(1228, 447)
        Me.dgvMovimientos.TabIndex = 19
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(3, 7)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(60, 18)
        Me.lblCliente.TabIndex = 20
        Me.lblCliente.Text = "Cliente: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Controls.Add(Me.dgvMovimientos)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(14, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1275, 543)
        Me.Panel1.TabIndex = 21
        '
        'idTipoComprobante
        '
        Me.idTipoComprobante.DataPropertyName = "v_TipoComprobante"
        Me.idTipoComprobante.HeaderText = "Tipo de Comprobante"
        Me.idTipoComprobante.Name = "idTipoComprobante"
        Me.idTipoComprobante.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "FechaGeneracion"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'NumeroRecibo
        '
        Me.NumeroRecibo.DataPropertyName = "ReciboNumero"
        Me.NumeroRecibo.HeaderText = "Recibo"
        Me.NumeroRecibo.Name = "NumeroRecibo"
        Me.NumeroRecibo.ReadOnly = True
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "ReciboFactura"
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        '
        'cmDebe
        '
        Me.cmDebe.DataPropertyName = "debe"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.cmDebe.DefaultCellStyle = DataGridViewCellStyle1
        Me.cmDebe.HeaderText = "Debe"
        Me.cmDebe.Name = "cmDebe"
        Me.cmDebe.ReadOnly = True
        '
        'cmHaber
        '
        Me.cmHaber.DataPropertyName = "haber"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmHaber.DefaultCellStyle = DataGridViewCellStyle2
        Me.cmHaber.HeaderText = "Haber"
        Me.cmHaber.Name = "cmHaber"
        Me.cmHaber.ReadOnly = True
        '
        'cmObservaciones
        '
        Me.cmObservaciones.DataPropertyName = "observaciones"
        Me.cmObservaciones.HeaderText = "Observaciones"
        Me.cmObservaciones.Name = "cmObservaciones"
        Me.cmObservaciones.ReadOnly = True
        '
        'cmConcepto
        '
        Me.cmConcepto.DataPropertyName = "concepto"
        Me.cmConcepto.HeaderText = "Concepto"
        Me.cmConcepto.Name = "cmConcepto"
        Me.cmConcepto.ReadOnly = True
        Me.cmConcepto.Visible = False
        '
        'cmIdComprobante
        '
        Me.cmIdComprobante.DataPropertyName = "idcomprobante"
        Me.cmIdComprobante.HeaderText = "IdComprobante"
        Me.cmIdComprobante.Name = "cmIdComprobante"
        Me.cmIdComprobante.ReadOnly = True
        Me.cmIdComprobante.Visible = False
        '
        'frmMovimientosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 542)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMovimientosCliente"
        Me.Text = "Movimientos del Cliente"
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents idTipoComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmDebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmHaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmIdComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
