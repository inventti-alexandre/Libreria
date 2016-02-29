Imports System.Data.SqlClient
Partial Public Class TarjetasMovimientos

    Public Sub New()
        With Me
            .Id = 0
            .CajaMovimientoId = System.Guid.Empty
            .TarjetaId = 0
            .BancoId = vbNull
            .TarjetaLiquidacionId = System.Guid.Empty
            .LoteCupon = ""
            .Fecha = "1900/01/01 00:00:00"
            .Importe = 0
            .Estado = 1
            .NroInt = 0

            .FechaAlta = "1900/01/01 00:00:00"
            .SucursalAltaId = 0
            .OperadorAltaId = System.Guid.Empty

            .FechaModificacion = "1900/01/01 00:00:00"
            .SucursalModificacionId = 0
            .OperadorModificacionId = System.Guid.Empty

        End With
    End Sub

    Public Function FillListUltimoInt(ByRef _Conexion As SqlConnection) As List(Of TarjetasMovimientos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of TarjetasMovimientos)
            With exe
                .CommandText = "SELECT Top 1 id, nroint, SucursalAltaId from TarjetasMovimientos where SucursalAltaId=27 order by NroInt DESC"
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of TarjetasMovimientos))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New TarjetasMovimientos
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As TarjetasMovimientos)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = 0
        If Fila.Item("NroInt") IsNot DBNull.Value Then c.NroInt = Fila.Item("NroInt") Else c.NroInt = 0
        If Fila.Item("SucursalAltaId") IsNot DBNull.Value Then c.SucursalAltaId = Fila.Item("SucursalAltaId") Else c.SucursalAltaId = 0
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
                cmd.CommandText = "INSERT INTO TarjetasMovimientos (CajaMovimientoId, TarjetaId, BancoId,  LoteCupon, Fecha, Importe, Estado, NroInt, FechaAlta, OperadorAltaId, SucursalAltaId) VALUES (@CajaMovimientoId, @TarjetaId, @BancoId, @LoteCupon, @Fecha, @Importe, @Estado, @NroInt, @FechaAlta, @OperadorAltaId, @SucursalAltaId)"

                sqlParam = cmd.Parameters.Add("@CajaMovimientoId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = CajaMovimientoId

                sqlParam = cmd.Parameters.Add("@TarjetaId", SqlDbType.Int)
                sqlParam.Value = TarjetaId

                sqlParam = cmd.Parameters.Add("@BancoId", SqlDbType.Int)
                sqlParam.Value = BancoId

                'sqlParam = cmd.Parameters.Add("@TarjetaLiquidacionId", SqlDbType.UniqueIdentifier)
                'sqlParam.Value = TarjetaLiquidacionId

                sqlParam = cmd.Parameters.Add("@LoteCupon", SqlDbType.NVarChar, 15)
                sqlParam.Value = LoteCupon

                sqlParam = cmd.Parameters.Add("@Fecha", SqlDbType.DateTime)
                sqlParam.Value = Fecha

                sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Real)
                sqlParam.Value = Importe

                sqlParam = cmd.Parameters.Add("@Estado", SqlDbType.TinyInt)
                sqlParam.Value = Estado

                sqlParam = cmd.Parameters.Add("@NroInt", SqlDbType.Int)
                sqlParam.Value = NroInt

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

End Class
