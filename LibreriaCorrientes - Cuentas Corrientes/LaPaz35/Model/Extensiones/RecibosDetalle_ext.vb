Imports System.Data.SqlClient
Partial Public Class RecibosDetalle

#Region "Propiedades/Entidades"

    Private _Recibo As Recibos
    Public Property ReciboProp() As Recibos
        Get
            _Recibo = New Recibos
            If Me.ReciboId <> System.Guid.Empty Then
                _Recibo = _Recibo.FillListById(Me.ReciboId, clsVariableSesion.Instancia.getConn).First
            End If
            Return _Recibo
        End Get
        Set(ByVal value As Recibos)
            _Recibo = value
        End Set
    End Property

    'Private _ClienteCuentaCorriente As ClientesCuentasCorriente
    'Public Property ClienteCtaCte() As ClientesCuentasCorriente
    '    Get
    '        _ClienteCuentaCorriente = New ClientesCuentasCorriente
    '        If Me.ClienteCuentaCorrienteId <> System.Guid.Empty Then
    '            _ClienteCuentaCorriente = _ClienteCuentaCorriente.FillListById(Me.ClienteCuentaCorrienteId, clsVariableSesion.Instancia.getConn).First
    '        End If
    '        Return _ClienteCuentaCorriente
    '    End Get
    '    Set(ByVal value As ClientesCuentasCorriente)
    '        _ClienteCuentaCorriente = value
    '    End Set
    'End Property

    'Private _CajaMovimiento As CajasMovimientos
    'Public Property CajaMovimiento() As CajasMovimientos
    '    Get
    '        _CajaMovimiento = New CajasMovimientos
    '        If Me.ReciboId <> System.Guid.Empty Then
    '            _CajaMovimiento = _CajaMovimiento.FillListByComprobante(Me.ReciboId, clsVariableSesion.Instancia.getConn).First
    '        End If
    '        Return _CajaMovimiento
    '    End Get
    '    Set(ByVal value As CajasMovimientos)
    '        _CajaMovimiento = value
    '    End Set
    'End Property

#End Region

#Region "Propiedades de Vista"
    Private _v_ReciboTipo As String
    Public Property v_ReciboTipo As String
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                Dim tipo As New TiposComprobantes
                tipo.Nombre = tipo.FillListById(Me.ReciboProp.Tipo, clsVariableSesion.Instancia.getConn).First.Nombre
                _v_ReciboTipo = tipo.Nombre
                Return _v_ReciboTipo
            End If
            Return ""
        End Get
        Set(ByVal value As String)
            _v_ReciboTipo = value
        End Set
    End Property

    Private _v_ReciboNumero As String
    Public Property v_ReciboNumero As String
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                _v_ReciboNumero = Me.ReciboProp.Numero
                Return _v_ReciboNumero
            End If
            Return ""
        End Get
        Set(ByVal value As String)
            _v_ReciboNumero = value
        End Set

    End Property

    Private _v_ReciboTotal As Decimal
    Public Property v_ReciboTotal As Decimal
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                _v_ReciboTotal = Me.ReciboProp.Total
                Return _v_ReciboTotal
            End If

            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_ReciboTotal = value
        End Set
    End Property

    Private _v_CCC_Cuota As Decimal
    Public Property v_CCC_Cuota As Decimal
        Get
            If Me.ClienteCuentaCorrienteId <> System.Guid.Empty Then
                '_v_CCC_Cuota = Me.ClienteCtaCte.Cuota
                Return _v_CCC_Cuota
            End If
            Return 0
        End Get

        Set(ByVal value As Decimal)
            _v_CCC_Cuota = value
        End Set
    End Property

    Private _v_CCC_Pagado As Decimal
    Public Property v_CCC_Pagado As Decimal
        Get
            If Me.ClienteCuentaCorrienteId <> System.Guid.Empty Then
                '    _v_CCC_Pagado = Me.ClienteCtaCte.Pagado
                Return _v_CCC_Pagado
            End If
            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_CCC_Pagado = value
        End Set
    End Property

    Private _v_CCC_FechaCompra As Date
    Public Property v_CCC_FechaCompra As Date
        Get
            If Me.ClienteCuentaCorrienteId <> System.Guid.Empty Then
                '    _v_CCC_FechaCompra = Me.ClienteCtaCte.Fecha
                Return _v_CCC_FechaCompra
            End If
            Return System.DateTime.MinValue
        End Get
        Set(ByVal value As Date)
            _v_CCC_FechaCompra = value
        End Set
    End Property

    Private _v_ComprobanteImpFac As Decimal
    Public Property v_ComprobanteImpFac As Decimal
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                ' _v_ComprobanteImpFac = Me.CajaMovimiento.ImpFac
                Return _v_ComprobanteImpFac
            End If
            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_ComprobanteImpFac = value
        End Set
    End Property

    Private _v_ComprobanteEfectivo As Decimal
    Public Property v_ComprobanteEfectivo As Decimal
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                '  _v_ComprobanteEfectivo = Me.CajaMovimiento.Efectivo
                Return _v_ComprobanteEfectivo
            End If

            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_ComprobanteEfectivo = value
        End Set
    End Property

    Private _v_ComprobanteTarjeta As Decimal
    Public Property v_ComprobanteTarjeta As Decimal
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                '   _v_ComprobanteTarjeta = Me.CajaMovimiento.Tarjeta
                Return _v_ComprobanteTarjeta
            End If

            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_ComprobanteTarjeta = value
        End Set
    End Property

    Private _v_ComprobanteRecargo As Decimal
    Public Property v_ComprobanteRecargo As Decimal
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                ' _v_ComprobanteRecargo = Me.CajaMovimiento.Recargo
                Return _v_ComprobanteRecargo
            End If

            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_ComprobanteRecargo = value
        End Set
    End Property

    Private _v_ComprobanteCheque As Decimal
    Public Property v_ComprobanteCheque As Decimal
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                '    _v_ComprobanteCheque = Me.CajaMovimiento.Cheque
                Return _v_ComprobanteCheque
            End If

            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_ComprobanteCheque = value
        End Set
    End Property

    Private _v_ComprobanteSenia As Decimal
    Public Property v_ComprobanteSenia As Decimal
        Get
            If Me.ReciboId <> System.Guid.Empty Then
                '   _v_ComprobanteSenia = Me.CajaMovimiento.Senia
                Return _v_ComprobanteSenia
            End If

            Return 0
        End Get
        Set(ByVal value As Decimal)
            _v_ComprobanteSenia = value
        End Set
    End Property

#End Region

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

    Public Function RecuperarFactura(ByVal ReciboId As Guid, ByRef _Conexion As SqlConnection) As String
        Using exe As New SqlCommand
            Dim Lista As New List(Of Integer)
            Dim Facturas As String = ""
            With exe
                .CommandText = "select v.NumeroComprobante from ventas as v where v.Id in (select ccc.VentaId from ClientesCuentasCorriente as ccc where ccc.id in (select rd.ClienteCuentaCorrienteId from RecibosDetalle as rd where ReciboId=@ReciboId))"
                .Parameters.AddWithValue("@reciboid", ReciboId)
                .Connection = _Conexion
                Dim ta As New SqlDataAdapter(exe), dt As New DataTable
                ta.Fill(dt)

                If dt.Rows.Count > 0 Then

                    For Each Fila As DataRow In dt.Rows
                        Dim c As New Integer
                        If Fila.Item(0) <> 0 Then c = Fila.Item(0)
                        Facturas = Facturas & c.ToString & ", "
                    Next
                End If

                dt.Dispose()
                ta.Dispose()
            End With
            Return Facturas
        End Using
    End Function

    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of RecibosDetalle)
        Using exe As New SqlCommand
            Dim Lista As New List(Of RecibosDetalle)
            With exe
                .CommandText = "SELECT * from RecibosDetalle"
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

    Public Function FillListByReciboId(ByRef Reciboid As Guid, ByRef _Conexion As SqlConnection) As List(Of RecibosDetalle)
        Using exe As New SqlCommand
            Dim Lista As New List(Of RecibosDetalle)
            With exe
                '.CommandText = "SELECT * from RecibosDetalle rd WHERE rd.Reciboid = @reciboid"
                .CommandText = "select rd.Id, rd.ReciboId, rd.ClienteCuentaCorrienteId, rd.Importe, rd.FechaAlta, cm.Id as CajaMovimientoId , cm.TipoMovimientoCajaId, cm.TipoComprobante, cm.ComprobanteId, cm.Senia as v_ComprobanteSenia, cm.Recargo as v_ComprobanteRecargo, cm.ImpFac as v_ComprobanteImpFac, cm.Efectivo as v_ComprobanteEfectivo, cm.Tarjeta as v_ComprobanteTarjeta, cm.Cheque as v_ComprobanteCheque, ccc.Cuota as v_CCC_Cuota, ccc.Pagado as v_CCC_Pagado, ccc.FechaAlta as v_CCC_FechaCompra from RecibosDetalle rd, CajasMovimientos cm, ClientesCuentasCorriente ccc  where rd.Reciboid = @reciboId AND (rd.ReciboId = cm.ComprobanteId) and (rd.ClienteCuentaCorrienteId=ccc.Id) "
                .Parameters.AddWithValue("@reciboid", Reciboid)
                .Connection = _Conexion
                Dim ta As New SqlDataAdapter(exe), dt As New DataTable
                ta.Fill(dt)
                CargarLista2(dt, Lista)
                dt.Dispose()
                ta.Dispose()
            End With
            Return Lista
        End Using
    End Function

    Public Function FillListByIdCCC(ByRef idccc As Guid, ByRef _Conexion As SqlConnection) As List(Of RecibosDetalle)
        Using exe As New SqlCommand
            Dim Lista As New List(Of RecibosDetalle)
            With exe
                .CommandText = "SELECT * from RecibosDetalle rd WHERE rd.clienteCuentaCorrienteId = @idccc"
                .Parameters.AddWithValue("@idccc", idccc)
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

    Public Function FillListByVenta(ByRef venta As Guid, ByRef _Conexion As SqlConnection) As List(Of RecibosDetalle)
        Using exe As New SqlCommand
            Dim Lista As New List(Of RecibosDetalle)
            With exe
                .CommandText = "select * from RecibosDetalle rd where rd.ClienteCuentaCorrienteId in(select id from ClientesCuentasCorriente ccc where ccc.VentaId=@venta)"
                .Parameters.AddWithValue("@venta", venta)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of RecibosDetalle))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New RecibosDetalle
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As RecibosDetalle)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("ReciboId") IsNot DBNull.Value Then c.ReciboId = Fila.Item("ReciboId") Else c.ReciboId = System.Guid.Empty
        If Fila.Item("ClienteCuentaCorrienteId") IsNot DBNull.Value Then c.ClienteCuentaCorrienteId = Fila.Item("ClienteCuentaCorrienteId") Else c.ClienteCuentaCorrienteId = System.Guid.Empty
        If Fila.Item("Importe") IsNot DBNull.Value Then c.Importe = Fila.Item("Importe") Else c.Importe = 0
        If Fila.Item("FechaAlta") IsNot DBNull.Value Then c.FechaAlta = Fila.Item("FechaAlta") Else c.FechaAlta = System.DateTime.MinValue

    End Sub

    Public Function FillListByVenta2(ByRef venta As Guid, ByRef _Conexion As SqlConnection) As List(Of RecibosDetalle)
        Using exe As New SqlCommand
            Dim Lista As New List(Of RecibosDetalle)
            With exe
                .CommandText = "select rd.Id, rd.ReciboId, rd.ClienteCuentaCorrienteId, rd.Importe, rd.FechaAlta, cm.Id as CajaMovimientoId , cm.TipoMovimientoCajaId, cm.TipoComprobante, cm.ComprobanteId, cm.Senia as v_ComprobanteSenia, cm.Recargo as v_ComprobanteRecargo, cm.ImpFac as v_ComprobanteImpFac, cm.Efectivo as v_ComprobanteEfectivo, cm.Tarjeta as v_ComprobanteTarjeta, cm.Cheque as v_ComprobanteCheque, ccc.Cuota as v_CCC_Cuota, ccc.Pagado as v_CCC_Pagado, ccc.FechaAlta as v_CCC_FechaCompra from RecibosDetalle rd, CajasMovimientos cm, ClientesCuentasCorriente ccc where (rd.ReciboId = cm.ComprobanteId) and (rd.ClienteCuentaCorrienteId=ccc.Id) AND rd.ClienteCuentaCorrienteId in(select id from ClientesCuentasCorriente ccc where ccc.VentaId=@venta)"
                .Parameters.AddWithValue("@venta", venta)
                .Connection = _Conexion
                Dim ta As New SqlDataAdapter(exe), dt As New DataTable
                ta.Fill(dt)
                CargarLista2(dt, Lista)
                dt.Dispose()
                ta.Dispose()
            End With
            Return Lista
        End Using
    End Function

    Public Sub CargarLista2(ByRef Dt As DataTable, ByRef Lista As List(Of RecibosDetalle))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New RecibosDetalle
                c.CargarFila2(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila2(ByRef Fila As DataRow, ByRef c As RecibosDetalle)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("ReciboId") IsNot DBNull.Value Then c.ReciboId = Fila.Item("ReciboId") Else c.ReciboId = System.Guid.Empty
        If Fila.Item("ClienteCuentaCorrienteId") IsNot DBNull.Value Then c.ClienteCuentaCorrienteId = Fila.Item("ClienteCuentaCorrienteId") Else c.ClienteCuentaCorrienteId = System.Guid.Empty
        If Fila.Item("Importe") IsNot DBNull.Value Then c.Importe = Fila.Item("Importe") Else c.Importe = 0
        If Fila.Item("FechaAlta") IsNot DBNull.Value Then c.FechaAlta = Fila.Item("FechaAlta") Else c.FechaAlta = System.DateTime.MinValue

        If Fila.Item("v_CCC_Cuota") IsNot DBNull.Value Then c.v_CCC_Cuota = Fila.Item("v_CCC_Cuota") Else c.v_CCC_Cuota = 0
        If Fila.Item("v_CCC_Pagado") IsNot DBNull.Value Then c.v_CCC_Pagado = Fila.Item("v_CCC_Pagado") Else c.v_CCC_Pagado = 0
        If Fila.Item("v_CCC_FechaCompra") IsNot DBNull.Value Then c.v_CCC_FechaCompra = Fila.Item("v_CCC_FechaCompra") Else c.v_CCC_FechaCompra = System.DateTime.MinValue
        If Fila.Item("v_ComprobanteImpFac") IsNot DBNull.Value Then c.v_ComprobanteImpFac = Fila.Item("v_ComprobanteImpFac") Else c.v_ComprobanteImpFac = 0
        If Fila.Item("v_ComprobanteEfectivo") IsNot DBNull.Value Then c.v_ComprobanteEfectivo = Fila.Item("v_ComprobanteEfectivo") Else c.v_ComprobanteEfectivo = 0
        If Fila.Item("v_ComprobanteTarjeta") IsNot DBNull.Value Then c.v_ComprobanteTarjeta = Fila.Item("v_ComprobanteTarjeta") Else c.v_ComprobanteTarjeta = 0
        If Fila.Item("v_ComprobanteCheque") IsNot DBNull.Value Then c.v_ComprobanteCheque = Fila.Item("v_ComprobanteCheque") Else c.v_ComprobanteCheque = 0
        If Fila.Item("v_ComprobanteSenia") IsNot DBNull.Value Then c.v_ComprobanteSenia = Fila.Item("v_ComprobanteSenia") Else c.v_ComprobanteSenia = 0
        If Fila.Item("v_ComprobanteRecargo") IsNot DBNull.Value Then c.v_ComprobanteRecargo = Fila.Item("v_ComprobanteRecargo") Else c.v_ComprobanteRecargo = 0


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
    '            cmd.CommandText = "INSERT INTO RecibosDetalle (Id,ReciboId,ClienteCuentaCorrienteId, Importe, OperadorAltaId, FechaAlta, SucursalAltaId, FechaModificacion, SucursalModificacionId, OperadorModificacionId) VALUES (@Id,@ReciboId,@ClienteCuentaCorrienteId, @Importe, @OperadorAltaId, @FechaAlta, @SucursalAltaId, @FechaModificacion, @SucursalModificacionId, @OperadorModificacionId)"

    '            sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
    '            'Id = System.Guid.NewGuid
    '            sqlParam.Value = Id

    '            sqlParam = cmd.Parameters.Add("@ReciboId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = ReciboId

    '            sqlParam = cmd.Parameters.Add("@ClienteCuentaCorrienteId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = ClienteCuentaCorrienteId

    '            sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Money)
    '            sqlParam.Value = Importe

    '            sqlParam = cmd.Parameters.Add("@OperadorAltaId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = OperadorAltaId

    '            sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
    '            sqlParam.Value = FechaAlta

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
