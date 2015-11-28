Imports System.Data.SqlClient
Partial Public Class CuentasMovimientos
    Public Sub New()
        With Me
            .Id = 0
            .CuentaId = 0
            .TipoMovimientoId = 0
            .FechaMovimiento = "1900/01/01 00:00:00"
            .TipoComprobanteId = 0
            .ComprobanteId = Guid.Empty
            .NroMovimiento = 1
            .FechaCobro = "1900/01/01 00:00:00"
            .Descripcion = ""
            .Credito = 0
            .TipoCarga = 0
            .CajaId = Guid.Empty
            .MonedaId = 0
            .EstadoMovimientoCuentaId = 0
            
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
                cmd.CommandText = "INSERT INTO CuentasMovimientos (CuentaId, TipoMovimientoId, FechaMovimiento, TipoComprobanteId, ComprobanteId,NroMovimiento, FechaCobro, Descripcion, Credito, TipoCarga, CajaId, MonedaId,EstadoMovimientoCuentaId, OperadorAltaId, FechaAlta, SucursalAltaId) VALUES (@CuentaId, @TipoMovimientoId, @FechaMovimiento, @TipoComprobanteId, @ComprobanteId, @NroMovimiento, @FechaCobro, @Descripcion, @Credito, @TipoCarga, @CajaId, @MonedaId,@EstadoMovimientoCuentaId, @OperadorAltaId, @FechaAlta, @SucursalAltaId)"

                sqlParam = cmd.Parameters.Add("@CuentaId", SqlDbType.Int)
                sqlParam.Value = CuentaId

                sqlParam = cmd.Parameters.Add("@TipoMovimientoId", SqlDbType.Int)
                sqlParam.Value = TipoMovimientoId

                sqlParam = cmd.Parameters.Add("@FechaMovimiento", SqlDbType.DateTime)
                sqlParam.Value = FechaMovimiento

                sqlParam = cmd.Parameters.Add("@TipoComprobanteId", SqlDbType.Int)
                sqlParam.Value = TipoComprobanteId

                sqlParam = cmd.Parameters.Add("@ComprobanteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ComprobanteId

                sqlParam = cmd.Parameters.Add("@NroMovimiento", SqlDbType.Int)
                sqlParam.Value = NroMovimiento

                sqlParam = cmd.Parameters.Add("@FechaCobro", SqlDbType.DateTime)
                sqlParam.Value = FechaCobro

                sqlParam = cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50)
                sqlParam.Value = Descripcion

                sqlParam = cmd.Parameters.Add("@Credito", SqlDbType.Real)
                sqlParam.Value = Credito

                sqlParam = cmd.Parameters.Add("@TipoCarga", SqlDbType.Int)
                sqlParam.Value = TipoCarga

                sqlParam = cmd.Parameters.Add("@CajaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = CajaId

                sqlParam = cmd.Parameters.Add("@MonedaId", SqlDbType.Int)
                sqlParam.Value = MonedaId

                sqlParam = cmd.Parameters.Add("@EstadoMovimientoCuentaId", SqlDbType.Int)
                sqlParam.Value = EstadoMovimientoCuentaId

                sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
                sqlParam.Value = FechaAlta

                sqlParam = cmd.Parameters.Add("@OperadorAltaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = OperadorAltaId

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

End Class
