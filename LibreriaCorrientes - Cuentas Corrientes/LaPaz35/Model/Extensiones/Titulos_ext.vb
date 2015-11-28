Imports System.Data.SqlClient
Partial Public Class Titulos

#Region "Funciones"

    Public Function FillListById(ByRef id As Guid, ByRef _Conexion As SqlConnection) As List(Of Titulos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Titulos)
            With exe
                .CommandText = "SELECT * from Titulos t WHERE t.id = @id"
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Titulos))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Titulos
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Titulos)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("NombreTitulo") IsNot DBNull.Value Then c.NombreTitulo = Fila.Item("NombreTitulo") Else c.NombreTitulo = ""
    End Sub

#End Region


End Class
