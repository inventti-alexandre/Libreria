Imports System.Data.SqlClient

Partial Public Class rolesCtaCte

#Region "Funciones"


    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of rolesCtaCte)
        Using exe As New SqlCommand
            Dim Lista As New List(Of rolesCtaCte)
            With exe
                .CommandText = "SELECT * FROM RolesCtaCte"
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of rolesCtaCte))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New rolesCtaCte
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As rolesCtaCte)
        If Fila.Item("id") IsNot DBNull.Value Then c.id = Fila.Item("id") Else c.id = 0
        If Fila.Item("rol") IsNot DBNull.Value Then c.rol = Fila.Item("rol") Else c.rol = ""
    End Sub

#End Region

End Class
