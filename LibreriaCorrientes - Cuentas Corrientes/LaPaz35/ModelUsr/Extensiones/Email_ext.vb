Imports System.Data.SqlClient
Partial Public Class Email
#Region "Funciones"

    Public Sub New()
        With Me
            .ClienteId = System.Guid.Empty
            .FechaEmail = "1900/01/01 00:00:00"
            .Email = ""
            .Saldo = 0
            .FechaVencimiento = "1900/01/01 00:00:00"
        End With
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
                cmd.CommandText = "INSERT INTO Email (ClienteId, FechaEmail, Email, Saldo,FechaVencimiento) VALUES (@ClienteId, @FechaEmail, @Email, @Saldo,@FechaVencimiento)"

                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                sqlParam = cmd.Parameters.Add("@FechaEmail", SqlDbType.DateTime)
                sqlParam.Value = FechaEmail

                sqlParam = cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100)
                sqlParam.Value = Email

                sqlParam = cmd.Parameters.Add("@Saldo", SqlDbType.Money)
                sqlParam.Value = Saldo

                sqlParam = cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime)
                sqlParam.Value = FechaVencimiento

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
#End Region
End Class
