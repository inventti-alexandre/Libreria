Namespace PL.Mails
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEnvioMail
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
            Me.btnEnviar = New System.Windows.Forms.Button()
            Me.dgvMails = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            CType(Me.dgvMails, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnEnviar
            '
            Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.btnEnviar.FlatAppearance.BorderSize = 0
            Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEnviar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEnviar.ForeColor = System.Drawing.Color.White
            Me.btnEnviar.Location = New System.Drawing.Point(782, 329)
            Me.btnEnviar.Name = "btnEnviar"
            Me.btnEnviar.Size = New System.Drawing.Size(119, 29)
            Me.btnEnviar.TabIndex = 0
            Me.btnEnviar.Text = "Enviar"
            Me.btnEnviar.UseVisualStyleBackColor = False
            '
            'dgvMails
            '
            Me.dgvMails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvMails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMails.Location = New System.Drawing.Point(16, 58)
            Me.dgvMails.Name = "dgvMails"
            Me.dgvMails.Size = New System.Drawing.Size(885, 253)
            Me.dgvMails.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(13, 31)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(315, 15)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Listado de mails a enviar el día de la fecha"
            '
            'frmEnvioMail
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(913, 370)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dgvMails)
            Me.Controls.Add(Me.btnEnviar)
            Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "frmEnvioMail"
            Me.Text = "Envio de Mails"
            CType(Me.dgvMails, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnEnviar As System.Windows.Forms.Button
        Friend WithEvents dgvMails As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace