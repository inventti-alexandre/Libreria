Imports System.Data.SqlClient
Partial Public Class ChequesTerceros
    Public Sub New()
        With Me
            .Id = System.Guid.Empty
            .CajaMovimientoId = System.Guid.Empty
            .BancoId = 0
            .NroCheque = ""
            .Fecha = "1900/01/01 00:00:00"
            .FechaCobro = "1900/01/01 00:00:00"
            .Importe = 0
            .sTipo = 0
            .sSuc = 0
            .sId = System.Guid.Empty
            .sFecha = "1900/01/01 00:00:00"
            .sComprob = ""
            .snSec = 0
            .EstadoChequeId = 0
            .OrdenPagoDetalleId = System.Guid.Empty

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
                cmd.CommandText = "INSERT INTO ChequesTerceros (id, CajaMovimientoId, BancoId, NroCheque, Fecha, FechaCobro, Importe, FechaAlta, OperadorAltaId, SucursalAltaId) VALUES (@id, @CajaMovimientoId, @BancoId, @NroCheque, @Fecha, @FechaCobro, @Importe, @FechaAlta, @OperadorAltaId, @SucursalAltaId)"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@CajaMovimientoId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = CajaMovimientoId

                sqlParam = cmd.Parameters.Add("@BancoId", SqlDbType.Int)
                sqlParam.Value = BancoId

                sqlParam = cmd.Parameters.Add("@NroCheque", SqlDbType.NVarChar, 15)
                sqlParam.Value = NroCheque

                sqlParam = cmd.Parameters.Add("@Fecha", SqlDbType.DateTime)
                sqlParam.Value = Fecha

                sqlParam = cmd.Parameters.Add("@FechaCobro", SqlDbType.DateTime)
                sqlParam.Value = FechaCobro

                sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Real)
                sqlParam.Value = Importe

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

    'Public Function Insert(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As Boolean
    '    Dim sqlParam As New SqlParameter
    '    Dim transaction As SqlTransaction
    '    Using cmd As New SqlCommand
    '        If _Conexion Is Nothing Then
    '            _Conexion.Open()
    '        End If
    '        If _tran Is Nothing Then
    '            transaction = _Conexion.BeginTransaction()
    '        Else
    '            transaction = _tran
    '        End If
    '        cmd.Transaction = transaction
    '        cmd.Connection = _Conexion
    '        Try
    '            cmd.CommandText = "INSERT INTO ChequesTerceros (id, CajaMovimientoId, BancoId, NroCheque, Fecha, FechaCobro, Importe, sTipo, sSuc, sid, sFecha, sComprob, snSec, EstadoChequeId, OrdenPagoDetalleId, FechaAlta, OperadorAltaId, SucursalAltaId, FechaModificacion, OperadorModificacionId, SucursalModificacionId) VALUES (@id, @CajaMovimientoId, @BancoId, @NroCheque, @Fecha, @FechaCobro, @Importe, @sTipo, @sSuc, @sid, @sFecha, @sComprob, @snSec, @EstadoChequeId, @OrdenPagoDetalleId, @FechaAlta, @OperadorAltaId, @SucursalAltaId, @FechaModificacion, @OperadorModificacionId, @SucursalModificacionId)"

    '            sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
    '            'Id = System.Guid.NewGuid
    '            sqlParam.Value = Id

    '            sqlParam = cmd.Parameters.Add("@CajaMovimientoId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = CajaMovimientoId

    '            sqlParam = cmd.Parameters.Add("@BancoId", SqlDbType.Int)
    '            sqlParam.Value = BancoId

    '            sqlParam = cmd.Parameters.Add("@NroCheque", SqlDbType.NVarChar, 15)
    '            sqlParam.Value = NroCheque

    '            sqlParam = cmd.Parameters.Add("@Fecha", SqlDbType.DateTime)
    '            sqlParam.Value = Fecha

    '            sqlParam = cmd.Parameters.Add("@FechaCobro", SqlDbType.DateTime)
    '            sqlParam.Value = FechaCobro

    '            sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Real)
    '            sqlParam.Value = Importe

    '            sqlParam = cmd.Parameters.Add("@sTipo", SqlDbType.Int)
    '            sqlParam.Value = sTipo

    '            sqlParam = cmd.Parameters.Add("@sSuc", SqlDbType.Int)
    '            sqlParam.Value = sSuc

    '            sqlParam = cmd.Parameters.Add("@sId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = sId

    '            sqlParam = cmd.Parameters.Add("@sFecha", SqlDbType.DateTime)
    '            sqlParam.Value = sFecha

    '            sqlParam = cmd.Parameters.Add("@sComprob", SqlDbType.NVarChar, 20)
    '            sqlParam.Value = sComprob

    '            sqlParam = cmd.Parameters.Add("@snSec", SqlDbType.Int)
    '            sqlParam.Value = snSec

    '            sqlParam = cmd.Parameters.Add("@EstadoChequeId", SqlDbType.Int)
    '            sqlParam.Value = EstadoChequeId

    '            sqlParam = cmd.Parameters.Add("@OrdenPagoDetalleId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = OrdenPagoDetalleId

    '            sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
    '            sqlParam.Value = FechaAlta

    '            sqlParam = cmd.Parameters.Add("@OperadorAltaId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = OperadorAltaId

    '            sqlParam = cmd.Parameters.Add("@SucursalAltaId", SqlDbType.Int)
    '            sqlParam.Value = SucursalAltaId

    '            sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
    '            sqlParam.Value = FechaModificacion

    '            sqlParam = cmd.Parameters.Add("@SucursalModificacionId", SqlDbType.Int)
    '            sqlParam.Value = SucursalModificacionId

    '            sqlParam = cmd.Parameters.Add("@OperadorModificacionId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = OperadorModificacionId

    '            cmd.ExecuteNonQuery()
    '            If _tran Is Nothing Then
    '                transaction.Commit()
    '            End If
    '        Catch ex As Exception
    '            If _tran Is Nothing Then
    '                transaction.Rollback()
    '            End If
    '            Throw New Exception(ex.Message)
    '        End Try

    '        Return True
    '    End Using
    'End Function

End Class
