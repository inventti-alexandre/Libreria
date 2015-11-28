<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRecibo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvDetalleRecibo = New System.Windows.Forms.DataGridView()
        Me.FechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblIntereses = New System.Windows.Forms.Label()
        CType(Me.dgvDetalleRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetalleRecibo
        '
        Me.dgvDetalleRecibo.AllowUserToAddRows = False
        Me.dgvDetalleRecibo.AllowUserToDeleteRows = False
        Me.dgvDetalleRecibo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleRecibo.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvDetalleRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleRecibo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaFactura, Me.Cuota, Me.PagoRecibo})
        Me.dgvDetalleRecibo.Location = New System.Drawing.Point(14, 14)
        Me.dgvDetalleRecibo.Name = "dgvDetalleRecibo"
        Me.dgvDetalleRecibo.ReadOnly = True
        Me.dgvDetalleRecibo.RowHeadersVisible = False
        Me.dgvDetalleRecibo.Size = New System.Drawing.Size(528, 127)
        Me.dgvDetalleRecibo.TabIndex = 0
        '
        'FechaFactura
        '
        Me.FechaFactura.DataPropertyName = "v_ccc_fechacompra"
        Me.FechaFactura.HeaderText = "Fecha de la Compra"
        Me.FechaFactura.Name = "FechaFactura"
        Me.FechaFactura.ReadOnly = True
        '
        'Cuota
        '
        Me.Cuota.DataPropertyName = "v_ccc_cuota"
        Me.Cuota.HeaderText = "Nro Cuota"
        Me.Cuota.Name = "Cuota"
        Me.Cuota.ReadOnly = True
        '
        'PagoRecibo
        '
        Me.PagoRecibo.DataPropertyName = "importe"
        Me.PagoRecibo.HeaderText = "Pago"
        Me.PagoRecibo.Name = "PagoRecibo"
        Me.PagoRecibo.ReadOnly = True
        '
        'lblIntereses
        '
        Me.lblIntereses.AutoSize = True
        Me.lblIntereses.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntereses.Location = New System.Drawing.Point(12, 157)
        Me.lblIntereses.Name = "lblIntereses"
        Me.lblIntereses.Size = New System.Drawing.Size(156, 19)
        Me.lblIntereses.TabIndex = 2
        Me.lblIntereses.Text = "Intereses cobrados = 0"
        '
        'frmDetalleRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(556, 252)
        Me.Controls.Add(Me.lblIntereses)
        Me.Controls.Add(Me.dgvDetalleRecibo)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDetalleRecibo"
        Me.Text = "frmDetalleRecibo"
        CType(Me.dgvDetalleRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetalleRecibo As System.Windows.Forms.DataGridView
    Friend WithEvents FechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagoRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblIntereses As System.Windows.Forms.Label
End Class
