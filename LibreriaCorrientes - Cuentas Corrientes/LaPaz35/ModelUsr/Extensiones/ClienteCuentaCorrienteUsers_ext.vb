Imports System.Data.SqlClient

Partial Public Class ClientesCuentasCorrienteBackupUsers

#Region "Funciones"

    Public Sub New()
        With Me
            autonumerico = 0

            .Id = System.Guid.Empty
            .VentaId = System.Guid.Empty
            .ClienteId = System.Guid.Empty
            .Cuota = 0
            .Fecha = "1900/01/01 00:00:00"
            .FechaVencimiento = "1900/01/01 00:00:00"
            .FechaUltimoPago = "1900/01/01 00:00:00"
            .Importe = 0
            .Pagado = 0
            .FechaGeneracion = "1900/01/01 00:00:00"

            .Observaciones = ""
            .FechaAlta = "1900/01/01 00:00:00"
            .SucursalAltaId = 0
            .OperadorAltaId = System.Guid.Empty

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
                cmd.CommandText = "INSERT INTO ClientesCuentasCorrienteBackup (Id, VentaId, ClienteId, Cuota, Fecha, FechaVencimiento, FechaUltimoPago, Importe, Pagado, FechaGeneracion, Observaciones, FechaAlta, SucursalAltaId, OperadorAltaId, FechaModificacion, SucursalModificacionId, OperadorModificacionId) VALUES (@Id, @VentaId, @ClienteId, @Cuota, @Fecha, @FechaVencimiento, @FechaUltimoPago, @Importe, @Pagado, @FechaGeneracion, @Observaciones, @FechaAlta, @SucursalAltaId, @OperadorAltaId, @FechaModificacion, @SucursalModificacionId, @OperadorModificacionId)"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@VentaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = VentaId

                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                sqlParam = cmd.Parameters.Add("@Cuota", SqlDbType.Int)
                sqlParam.Value = Cuota

                sqlParam = cmd.Parameters.Add("@Fecha", SqlDbType.DateTime)
                sqlParam.Value = Fecha

                sqlParam = cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime)
                sqlParam.Value = FechaVencimiento

                sqlParam = cmd.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime)
                sqlParam.Value = FechaUltimoPago

                sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Money)
                sqlParam.Value = Importe

                sqlParam = cmd.Parameters.Add("@Pagado", SqlDbType.Money)
                sqlParam.Value = Pagado

                sqlParam = cmd.Parameters.Add("@FechaGeneracion", SqlDbType.DateTime)
                sqlParam.Value = FechaGeneracion

                sqlParam = cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 255)
                sqlParam.Value = Observaciones

                sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
                sqlParam.Value = FechaAlta

                sqlParam = cmd.Parameters.Add("@SucursalAltaId", SqlDbType.Int)
                sqlParam.Value = SucursalAltaId

                sqlParam = cmd.Parameters.Add("@OperadorAltaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = OperadorAltaId

                sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
                sqlParam.Value = FechaModificacion

                sqlParam = cmd.Parameters.Add("@SucursalModificacionId", SqlDbType.Int)
                sqlParam.Value = SucursalModificacionId

                sqlParam = cmd.Parameters.Add("@OperadorModificacionId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = OperadorModificacionId

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
