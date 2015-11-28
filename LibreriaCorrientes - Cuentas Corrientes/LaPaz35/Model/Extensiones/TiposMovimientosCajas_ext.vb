Imports System.Data.SqlClient
Partial Public Class TiposMovimientosCajas

    Public Function FillListById(ByRef id As Integer, ByRef _Conexion As SqlConnection) As List(Of TiposMovimientosCajas)
        Using exe As New SqlCommand
            Dim Lista As New List(Of TiposMovimientosCajas)
            With exe
                .CommandText = "SELECT * from TiposMovimientosCajas tm WHERE tm.id = @id"
                .Parameters.AddWithValue("@id", id)
                .Connection = _Conexion
                Dim ta As New SqlDataAdapter(exe), dt As New DataTable
                ta.Fill(dt)
                CargarLista(dt, Lista)
                dt.Dispose()
                ta.Dispose()
            End With
            Return Lista
        End Using
    End Function
    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of TiposMovimientosCajas))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New TiposMovimientosCajas
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As TiposMovimientosCajas)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = 0
        If Fila.Item("Nombre") IsNot DBNull.Value Then c.Nombre = Fila.Item("Nombre") Else c.Nombre = ""
        If Fila.Item("Abreviatura") IsNot DBNull.Value Then c.Abreviatura = Fila.Item("Abreviatura") Else c.Abreviatura = ""
    End Sub


End Class
