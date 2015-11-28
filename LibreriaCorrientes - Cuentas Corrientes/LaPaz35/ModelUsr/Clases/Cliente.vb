Public Class Cliente
    Public Property ClienteId As System.Guid
    Public Property Saldo As Decimal
    Public Property FechaAlta As Nullable(Of Date)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property Cuotas As Integer
    Public Property Email As String
    Public Property Telefono As String
    Public Property MandarMail As Boolean
    Public Property Llamar As Boolean
End Class
