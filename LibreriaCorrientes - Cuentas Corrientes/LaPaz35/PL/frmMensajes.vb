Public Class frmMensajes
    Public Sub New(ByVal mensaje As String, Optional ByVal posicion As System.Drawing.Point = Nothing)
        InitializeComponent()
        lblMensaje.Text = mensaje
        If posicion <> Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            Dim izq As Integer = 0
            If Me.Parent IsNot Nothing Then izq = Me.Parent.Left
            Me.Left = IIf(izq > posicion.X - Me.Width, izq, posicion.X - Me.Width)
            Me.Top = posicion.Y

        Else
            Me.StartPosition = FormStartPosition.CenterScreen
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Return
    End Sub
End Class