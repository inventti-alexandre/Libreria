Imports System.Data.SqlClient
Partial Public Class CondicionesVenta

    Public Function FillListByID(ByVal id As Integer, ByRef _Conexion As SqlConnection) As List(Of CondicionesVenta)
        Using exe As New SqlCommand
            Dim Lista As New List(Of CondicionesVenta)
            With exe
                .CommandText = "SELECT * FROM CondicionesVenta cv" & vbCrLf
                .CommandText &= "WHERE cv.id=@id  "
                .Parameters.AddWithValue("@id", id)
                .Connection = _Conexion
                Dim Ta As New SqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)

                Dt.Dispose()
                Ta.Dispose()
            End With
            Return Lista
        End Using
    End Function

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of CondicionesVenta))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New CondicionesVenta
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As CondicionesVenta)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = 0
        If Fila.Item("Nombre") IsNot DBNull.Value Then c.Nombre = Fila.Item("Nombre") Else c.Nombre = ""
    End Sub
End Class
