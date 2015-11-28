Public Class Email
    Public Property Id As Integer
    Public Property ClienteId As System.Guid
    Public Property FechaEmail As Nullable(Of Date)
    Public Property Email As String
    Public Property Saldo As Decimal
    Public Property FechaVencimiento As Nullable(Of Date)
End Class
