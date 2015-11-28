Imports System.Data.SqlClient

Partial Public Class Operadores

#Region "Funciones"

    Public Function FillListById(ByRef Id As Guid, ByRef _Conexion As SqlConnection) As List(Of Operadores)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Operadores)
            With exe
                .CommandText = "SELECT * from Operadores o WHERE o.id = @Id"
                .Parameters.AddWithValue("@Id", Id)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Operadores))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Operadores
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Operadores)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("Usuario") IsNot DBNull.Value Then c.Usuario = Fila.Item("Usuario") Else c.Usuario = ""
        If Fila.Item("PersonalId") IsNot DBNull.Value Then c.PersonalId = Fila.Item("PersonalId") Else c.PersonalId = System.Guid.Empty
    End Sub

#End Region
End Class
