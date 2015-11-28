Imports System.Data.SqlClient
Partial Public Class RecibosDetalleUsers


#Region "Funciones"

    Public Sub New()
        With Me
            .Id = System.Guid.Empty
            .ReciboId = System.Guid.Empty
            .ClienteCuentaCorrienteId = System.Guid.Empty
            .Importe = 0
            .OperadorAltaId = System.Guid.Empty
            .FechaAlta = "1900/01/01 00:00:00"
            .SucursalAltaId = 0
            .FechaModificacion = "1900/01/01 00:00:00"
            .SucursalModificacionId = 0
            .OperadorModificacionId = System.Guid.Empty

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
                cmd.CommandText = "INSERT INTO RecibosDetalle (Id,ReciboId,ClienteCuentaCorrienteId, Importe, OperadorAltaId, FechaAlta, SucursalAltaId) VALUES (@Id,@ReciboId,@ClienteCuentaCorrienteId, @Importe, @OperadorAltaId, @FechaAlta, @SucursalAltaId)"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@ReciboId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ReciboId

                sqlParam = cmd.Parameters.Add("@ClienteCuentaCorrienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteCuentaCorrienteId

                sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Money)
                sqlParam.Value = Importe

                sqlParam = cmd.Parameters.Add("@OperadorAltaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = OperadorAltaId

                sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
                sqlParam.Value = FechaAlta

                sqlParam = cmd.Parameters.Add("@SucursalAltaId", SqlDbType.Int)
                sqlParam.Value = SucursalAltaId

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
