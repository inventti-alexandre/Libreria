Imports System.Data.SqlClient

Partial Public Class Comentarios
    Public Function FillListByID(ByRef Id As Guid, ByRef _Conexion As SqlConnection) As List(Of Comentarios)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Comentarios)
            With exe
                .CommandText = "SELECT * FROM Comentarios where id=@id"
                .Parameters.AddWithValue("@id", Id)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Comentarios))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Comentarios
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Comentarios)
        If Fila.Item("id") IsNot DBNull.Value Then c.id = Fila.Item("id") Else c.id = System.Guid.Empty
        If Fila.Item("Comentario") IsNot DBNull.Value Then c.comentario = Fila.Item("Comentario") Else c.comentario = ""
    End Sub

    Public Function Insert(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As Boolean
        Dim sqlParam As New SqlParameter
        Dim transaction As SqlTransaction
        Using cmd As New SqlCommand
            If _Conexion Is Nothing Then
                _Conexion.Open()
            End If
            If _tran Is Nothing Then
                transaction = _Conexion.BeginTransaction()
            Else
                transaction = _tran
            End If
            cmd.Transaction = transaction
            cmd.Connection = _Conexion
            Try
                cmd.CommandText = "INSERT INTO Comentarios (Id, comentario) VALUES (@id,@comentario)"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 255)
                sqlParam.Value = comentario

                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try

            Return True

        End Using
    End Function

    Public Function Update(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As Boolean
        Dim sqlParam As New SqlParameter
        Dim transaction As SqlTransaction
        Using cmd As New SqlCommand
            If _Conexion Is Nothing Then
                _Conexion.Open()
            End If
            If _tran Is Nothing Then
                transaction = _Conexion.BeginTransaction()
            Else
                transaction = _tran
            End If
            cmd.Transaction = transaction
            cmd.Connection = _Conexion
            Try
                cmd.CommandText = "UPDATE Comentarios SET comentario=@comentario  WHERE id=@id"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 255)
                sqlParam.Value = comentario

               
                cmd.ExecuteNonQuery()
                If _tran Is Nothing Then
                    transaction.Commit()
                End If
            Catch ex As Exception
                If _tran Is Nothing Then
                    transaction.Rollback()
                End If
                Throw New Exception(ex.Message)
            End Try
            Return True
        End Using
    End Function

End Class
