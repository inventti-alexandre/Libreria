Imports System.Data.SqlClient

Partial Public Class CajasMovimientos

#Region "Propiedades/Entidades"
    Private _TipoCajaMovimiento As TiposMovimientosCajas
    Public Property TipoCajaMovimiento() As TiposMovimientosCajas
        Get
            _TipoCajaMovimiento = New TiposMovimientosCajas
            If Me.TipoMovimientoCajaId <> 0 Then
                _TipoCajaMovimiento = _TipoCajaMovimiento.FillListById(Me.TipoMovimientoCajaId, clsVariableSesion.Instancia.getConn).First
            End If
            Return _TipoCajaMovimiento
        End Get
        Set(ByVal value As TiposMovimientosCajas)
            _TipoCajaMovimiento = value
        End Set
    End Property

    Private _ComprobanteTipo As TiposComprobantes
    Public Property TipoComprobanteEntidad() As TiposComprobantes
        Get
            _ComprobanteTipo = New TiposComprobantes
            If Me.TipoComprobante <> 0 Then
                _ComprobanteTipo = _ComprobanteTipo.FillListById(Me.TipoComprobante, clsVariableSesion.Instancia.getConn).First
            End If
            Return _ComprobanteTipo
        End Get
        Set(ByVal value As TiposComprobantes)
            _ComprobanteTipo = value
        End Set
    End Property

#End Region

#Region "Propiedades de Vista"

    Public ReadOnly Property v_TipoMovimientoCaja As String
        Get
            If Me.TipoMovimientoCajaId <> 0 Then
                Return Me.TipoCajaMovimiento.Nombre
            End If

            Return ""
        End Get
    End Property

    Public ReadOnly Property v_TipoComprobante As String
        Get
            If Me.TipoComprobante <> 0 Then
                Return Me.TipoComprobanteEntidad.Nombre
            End If

            Return ""
        End Get
    End Property

#End Region

#Region "Funciones"

    Public Sub New()
        With Me
            .Id = System.Guid.Empty
            .CajaId = System.Guid.Empty
            .TipoMovimientoCajaId = 0
            .TipoComprobante = 0
            .ComprobanteId = System.Guid.Empty
            .Senia = 0
            .Recargo = 0
            .Importe = 0
            .ImpFac = 0
            .Efectivo = 0
            .Tarjeta = 0
            .Cheque = 0
            .Bono = 0
            .fpcBono = ""
            .Deposito = 0
            .CajaIdAnt = ""
            .CompIdAnt = ""
            .CompLcnAnt = ""
            .FacturaReservadas = 0
            .PcAlta = ""
            .FechaAlta = "1900/01/01 00:00:00"
            .OperadorAltaId = System.Guid.Empty
            .SucursalAltaId = 0
            .FechaModificacion = "1900/01/01 00:00:00"
            .SucursalModificacionId = 0
            .OperadorModificacionId = System.Guid.Empty

        End With
    End Sub
    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of CajasMovimientos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of CajasMovimientos)
            With exe
                .CommandText = "SELECT * from CajasMovimientos"
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

   Public Function FillListByComprobante(ByVal comprobante As Guid, ByRef _Conexion As SqlConnection) As List(Of CajasMovimientos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of CajasMovimientos)
            Try

            
            With exe
                .CommandText = "select * from CajasMovimientos where ComprobanteId in(select ReciboId from RecibosDetalle where ClienteCuentaCorrienteId in (select id from ClientesCuentasCorriente where VentaId= @comprobante)) or ComprobanteId = @comprobante order by fechaalta DESC"
                .Parameters.AddWithValue("@comprobante", comprobante)
                .Connection = _Conexion
                Dim Ta As New SqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista(Dt, Lista)

                Dt.Dispose()
                Ta.Dispose()
                End With
            Catch ex As Exception

            End Try
            Return Lista
        End Using
    End Function

    Public Function FillListByIdComprobante(ByVal comprobante As Guid, ByRef _Conexion As SqlConnection) As List(Of CajasMovimientos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of CajasMovimientos)
            Try


                With exe
                    .CommandText = "select * from CajasMovimientos where ComprobanteId = @comprobante order by fechaalta DESC"
                    .Parameters.AddWithValue("@comprobante", comprobante)
                    .Connection = _Conexion
                    Dim Ta As New SqlDataAdapter(exe), Dt As New DataTable
                    Ta.Fill(Dt)
                    CargarLista(Dt, Lista)

                    Dt.Dispose()
                    Ta.Dispose()
                End With
            Catch ex As Exception

            End Try
            Return Lista
        End Using
    End Function

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of CajasMovimientos))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New CajasMovimientos
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As CajasMovimientos)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("CajaId") IsNot DBNull.Value Then c.CajaId = Fila.Item("CajaId") Else c.CajaId = System.Guid.Empty
        If Fila.Item("TipoMovimientoCajaId") IsNot DBNull.Value Then c.TipoMovimientoCajaId = Fila.Item("TipoMovimientoCajaId") Else c.TipoMovimientoCajaId = 0
        If Fila.Item("TipoComprobante") IsNot DBNull.Value Then c.TipoComprobante = Fila.Item("TipoComprobante") Else c.TipoComprobante = 0
        If Fila.Item("ComprobanteId") IsNot DBNull.Value Then c.ComprobanteId = Fila.Item("ComprobanteId") Else c.ComprobanteId = System.Guid.Empty
        If Fila.Item("Senia") IsNot DBNull.Value Then c.Senia = Fila.Item("Senia") Else c.Senia = 0
        If Fila.Item("Recargo") IsNot DBNull.Value Then c.Recargo = Fila.Item("Recargo") Else c.Recargo = 0
        If Fila.Item("Importe") IsNot DBNull.Value Then c.Importe = Fila.Item("Importe") Else c.Importe = 0
        If Fila.Item("ImpFac") IsNot DBNull.Value Then c.ImpFac = Fila.Item("ImpFac") Else c.ImpFac = 0
        If Fila.Item("Efectivo") IsNot DBNull.Value Then c.Efectivo = Fila.Item("Efectivo") Else c.Efectivo = 0
        If Fila.Item("Tarjeta") IsNot DBNull.Value Then c.Tarjeta = Fila.Item("Tarjeta") Else c.Tarjeta = 0
        If Fila.Item("Cheque") IsNot DBNull.Value Then c.Cheque = Fila.Item("Cheque") Else c.Cheque = 0
        If Fila.Item("Deposito") IsNot DBNull.Value Then c.Senia = Fila.Item("Deposito") Else c.Deposito = 0
        If Fila.Item("FechaAlta") IsNot DBNull.Value Then c.FechaAlta = Fila.Item("FechaAlta") Else c.FechaAlta = System.DateTime.MinValue
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
                cmd.CommandText = "INSERT INTO CajasMovimientos (Id, CajaId,TipoMovimientoCajaId, TipoComprobante,ComprobanteId,Senia, Recargo, Importe, ImpFac, Efectivo, Tarjeta, Cheque, Bono, fpcbono, Deposito, PcAlta, FechaAlta, OperadorAltaid, SucursalAltaId) VALUES (@id,@CajaId,@TipoMovimientoCajaId, @TipoComprobante,@ComprobanteId,@Senia, @Recargo, @Importe, @ImpFac, @Efectivo, @Tarjeta, @Cheque, @Bono, @fpcbono, @Deposito, @PcAlta, @FechaAlta, @OperadorAltaid, @SucursalAltaId)"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@CajaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = CajaId

                sqlParam = cmd.Parameters.Add("@TipoMovimientoCajaId", SqlDbType.Int)
                sqlParam.Value = TipoMovimientoCajaId

                sqlParam = cmd.Parameters.Add("@TipoComprobante", SqlDbType.Int)
                sqlParam.Value = TipoComprobante

                sqlParam = cmd.Parameters.Add("@ComprobanteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ComprobanteId

                sqlParam = cmd.Parameters.Add("@Senia", SqlDbType.Money)
                sqlParam.Value = Senia

                sqlParam = cmd.Parameters.Add("@Recargo", SqlDbType.Money)
                sqlParam.Value = Recargo

                sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Money)
                sqlParam.Value = Importe

                sqlParam = cmd.Parameters.Add("@ImpFac", SqlDbType.Money)
                sqlParam.Value = ImpFac

                sqlParam = cmd.Parameters.Add("@Efectivo", SqlDbType.Money)
                sqlParam.Value = Efectivo

                sqlParam = cmd.Parameters.Add("@Tarjeta", SqlDbType.Money)
                sqlParam.Value = Tarjeta

                sqlParam = cmd.Parameters.Add("@Cheque", SqlDbType.Money)
                sqlParam.Value = Cheque

                sqlParam = cmd.Parameters.Add("@Bono", SqlDbType.Money)
                sqlParam.Value = Bono

                sqlParam = cmd.Parameters.Add("@fpcBono", SqlDbType.NVarChar, 20)
                sqlParam.Value = fpcBono

                sqlParam = cmd.Parameters.Add("@Deposito", SqlDbType.Money)
                sqlParam.Value = Deposito

                sqlParam = cmd.Parameters.Add("@PcAlta", SqlDbType.NVarChar, 20)
                sqlParam.Value = PcAlta

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
    '            cmd.CommandText = "INSERT INTO CajasMovimientos (Id, CajaId,TipoMovimientoCajaId, TipoComprobante,ComprobanteId,Senia, Recargo, Importe, ImpFac, Efectivo, Tarjeta, Cheque, Bono, fpcbono, Deposito, CajaIdAnt, CompIdAnt, CompLcnAnt, FacturaReservadas, PcAlta, FechaAlta, OperadorAltaid, SucursalAltaId, FechaModificacion, SucursalModificacionId, OperadorModificacionId) VALUES (@id,@CajaId,@TipoMovimientoCajaId, @TipoComprobante,@ComprobanteId,@Senia, @Recargo, @Importe, @ImpFac, @Efectivo, @Tarjeta, @Cheque, @Bono, @fpcbono, @Deposito, @CajaIdAnt, @CompIdAnt, @CompLcnAnt, @FacturaReservadas, @PcAlta, @FechaAlta, @OperadorAltaid, @SucursalAltaId, @FechaModificacion, @SucursalModificacionId, @OperadorModificacionId)"

    '            sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
    '            'Id = System.Guid.NewGuid
    '            sqlParam.Value = Id

    '            sqlParam = cmd.Parameters.Add("@CajaId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = CajaId

    '            sqlParam = cmd.Parameters.Add("@TipoMovimientoCajaId", SqlDbType.Int)
    '            sqlParam.Value = TipoMovimientoCajaId

    '            sqlParam = cmd.Parameters.Add("@TipoComprobante", SqlDbType.Int)
    '            sqlParam.Value = TipoComprobante

    '            sqlParam = cmd.Parameters.Add("@ComprobanteId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = ComprobanteId

    '            sqlParam = cmd.Parameters.Add("@Senia", SqlDbType.Money)
    '            sqlParam.Value = Senia

    '            sqlParam = cmd.Parameters.Add("@Recargo", SqlDbType.Money)
    '            sqlParam.Value = Recargo

    '            sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Money)
    '            sqlParam.Value = Importe

    '            sqlParam = cmd.Parameters.Add("@ImpFac", SqlDbType.Money)
    '            sqlParam.Value = ImpFac

    '            sqlParam = cmd.Parameters.Add("@Efectivo", SqlDbType.Money)
    '            sqlParam.Value = Efectivo

    '            sqlParam = cmd.Parameters.Add("@Tarjeta", SqlDbType.Money)
    '            sqlParam.Value = Tarjeta

    '            sqlParam = cmd.Parameters.Add("@Cheque", SqlDbType.Money)
    '            sqlParam.Value = Cheque

    '            sqlParam = cmd.Parameters.Add("@Bono", SqlDbType.Money)
    '            sqlParam.Value = Bono

    '            sqlParam = cmd.Parameters.Add("@fpcBono", SqlDbType.NVarChar, 20)
    '            sqlParam.Value = fpcBono

    '            sqlParam = cmd.Parameters.Add("@Deposito", SqlDbType.Money)
    '            sqlParam.Value = Deposito

    '            sqlParam = cmd.Parameters.Add("@CajaIdAnt", SqlDbType.NChar, 20)
    '            sqlParam.Value = CajaIdAnt

    '            sqlParam = cmd.Parameters.Add("@CompIdAnt", SqlDbType.NChar, 20)
    '            sqlParam.Value = CompIdAnt

    '            sqlParam = cmd.Parameters.Add("@CompLcnAnt", SqlDbType.NChar, 20)
    '            sqlParam.Value = CompLcnAnt

    '            sqlParam = cmd.Parameters.Add("@FacturaReservadas", SqlDbType.Int)
    '            sqlParam.Value = FacturaReservadas

    '            sqlParam = cmd.Parameters.Add("@PcAlta", SqlDbType.NVarChar, 20)
    '            sqlParam.Value = PcAlta

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
    '        'Me.entidad_id = cmd.LastInsertedId
    '        'Return cmd.LastInsertedId

    '    End Using
    'End Function
#End Region
   
End Class
