Imports System.Data.SqlClient
Partial Public Class ClientesMovimiento

#Region "Propiedades/Entidades"

    Private _ComprobanteTipo As TiposComprobantes
    Public Property TipoComprobanteEntidad() As TiposComprobantes
        Get
            Try

           
            _ComprobanteTipo = New TiposComprobantes
            If Me.IdTipoComprobante <> 0 Then
                _ComprobanteTipo = _ComprobanteTipo.FillListById(Me.IdTipoComprobante, clsVariableSesion.Instancia.getConn).First
            End If
                Return _ComprobanteTipo
            Catch ex As Exception
                Return _ComprobanteTipo
            End Try
        End Get
        Set(ByVal value As TiposComprobantes)
            _ComprobanteTipo = value
        End Set
    End Property

    Private _Factura As RecibosDetalle
    Public Property Factura() As String
        Get
            Try
                _Factura = New RecibosDetalle
                If Me.IdTipoComprobante = 3 Then
                    Return _Factura.RecuperarFactura(Me.IdComprobante, clsVariableSesion.Instancia.getConn)
                Else
                    Return 0
                End If

            Catch ex As Exception
                Return ""
            End Try
        End Get
        Set(ByVal value As String)
            _Factura = New RecibosDetalle
        End Set
    End Property

    Private _reciboNumero As String
    Public Property ReciboNumero() As String
        Get
            If _reciboNumero Is Nothing Then
                _reciboNumero = ""
            End If
            Return _reciboNumero
        End Get
        Set(ByVal value As String)
            _reciboNumero = value
        End Set
    End Property


    Private _reciboFactura As String
    Public Property ReciboFactura() As String
        Get
            If _reciboFactura Is Nothing Then
                _reciboFactura = ""
            End If
            Return _reciboFactura
        End Get
        Set(ByVal value As String)
            _reciboFactura = value
        End Set
    End Property


#End Region

#Region "Propiedades de Vista"

    Public ReadOnly Property v_TipoComprobante As String
        Get
            Try

        
            If Me.IdTipoComprobante <> 0 Then
                Return Me.TipoComprobanteEntidad.Nombre
            End If

                Return ""
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    Public ReadOnly Property v_Factura As String
        Get
            Try

                If Me.IdTipoComprobante <> 3 Then
                    Return Factura
                End If

                Return ""
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property
#End Region

#Region "Funciones"
    Public Sub New()
        With Me
            .Id = 0
            .IdCliente = System.Guid.Empty
            .IdTipoComprobante = 0
            .IdComprobante = System.Guid.Empty
            .Concepto = ""
            .Debe = 0
            .Haber = 0
            .Observaciones = ""
            .FechaGeneracion = "1900/01/01 00:00:00"
            .OperadorAltaId = System.Guid.Empty
            .FechaAlta = "1900/01/01 00:00:00"
            .SucursalAltaId = 0
            .FechaModificacion = "1900/01/01 00:00:00"
            .SucursalModificacionId = 0
            .OperadorModificacionId = System.Guid.Empty

        End With
    End Sub

    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of ClientesMovimiento)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesMovimiento)
            With exe
                .CommandText = "SELECT * from clientesMovimiento"
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

    Public Function FillListByCliente(ByVal id As Guid, ByRef _Conexion As SqlConnection) As List(Of ClientesMovimiento)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesMovimiento)
            With exe
                '.CommandText = "select cm1.Id,IdCliente,IdTipoComprobante,IdComprobante,cm1.Concepto,Debe,Haber, Observaciones,FechaGeneracion,cm1.FechaAlta,r.Numero as NumeroRecibo ,  null as NumeroFactura from ClientesMovimiento as cm1 INNER JOIN Recibos as r ON cm1.IdComprobante = r.Id where IdComprobante  in(select ReciboId from RecibosDetalle where ClienteCuentaCorrienteId in (select id from ClientesCuentasCorriente where VentaId in (select id from Ventas where ClienteId=@id))) UNIon  Select cm.[Id],[IdCliente],[IdTipoComprobante],[IdComprobante],cm.[Concepto],[Debe],[Haber],[Observaciones] ,[FechaGeneracion],cm.[FechaAlta],'' as NumeroRecibo, v.NumeroComprobante as NumeroFactura from Clientesmovimiento as cm inner join  Ventas as v on  cm.IdComprobante= v.Id  where v.ClienteId=@id  order by cm1.fechaalta DESC"
                .CommandText = "select cm1.Id,IdCliente,IdTipoComprobante,IdComprobante,cm1.Concepto,Debe,Haber, Observaciones,FechaGeneracion,cm1.FechaAlta,r.Numero as NumeroRecibo ,  null as NumeroFactura from ClientesMovimiento as cm1 INNER JOIN Recibos as r ON cm1.IdComprobante = r.Id where IdCliente=@id  UNIon  Select cm.[Id],[IdCliente],[IdTipoComprobante],[IdComprobante],cm.[Concepto],[Debe],[Haber],[Observaciones] ,[FechaGeneracion],cm.[FechaAlta],'' as NumeroRecibo, v.NumeroComprobante as NumeroFactura from Clientesmovimiento as cm inner join  Ventas as v on  cm.IdComprobante= v.Id  where v.ClienteId=@id   order by cm1.fechaalta DESC"
                .Parameters.AddWithValue("@id", id)
                .Connection = _Conexion
                Dim Ta As New SqlDataAdapter(exe), Dt As New DataTable
                Ta.Fill(Dt)
                CargarLista2(Dt, Lista)

                Dt.Dispose()
                Ta.Dispose()
            End With
            Return Lista
        End Using
    End Function


    Public Function FillListByVenta(ByVal venta As Guid, ByRef _Conexion As SqlConnection) As List(Of ClientesMovimiento)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesMovimiento)
            With exe
                .CommandText = "select * from ClientesMovimiento where IdComprobante in(select ReciboId from RecibosDetalle where ClienteCuentaCorrienteId in (select id from ClientesCuentasCorriente where VentaId= @venta)) or IdComprobante = @venta"
                .Parameters.AddWithValue("@venta", venta)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of ClientesMovimiento))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New ClientesMovimiento
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As ClientesMovimiento)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = 0
        If Fila.Item("Concepto") IsNot DBNull.Value Then c.Concepto = Fila.Item("Concepto") Else c.Concepto = ""
        If Fila.Item("Debe") IsNot DBNull.Value Then c.Debe = Fila.Item("Debe") Else c.Debe = 0
        If Fila.Item("Haber") IsNot DBNull.Value Then c.Haber = Fila.Item("Haber") Else c.Haber = 0
        If Fila.Item("Observaciones") IsNot DBNull.Value Then c.Observaciones = Fila.Item("Observaciones") Else c.Observaciones = ""
        If Fila.Item("IdComprobante") IsNot DBNull.Value Then c.IdComprobante = Fila.Item("IdComprobante") Else c.IdComprobante = System.Guid.Empty
        If Fila.Item("FechaGeneracion") IsNot DBNull.Value Then c.FechaGeneracion = Fila.Item("FechaGeneracion") Else c.FechaGeneracion = System.DateTime.MinValue
        If Fila.Item("IdTipoComprobante") IsNot DBNull.Value Then c.IdTipoComprobante = Fila.Item("IdTipoComprobante") Else c.IdTipoComprobante = 0
        
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
                cmd.CommandText = "INSERT INTO ClientesMovimiento (IdCliente,IdTipoComprobante, IdComprobante,Concepto,Debe, Haber, Observaciones, FechaGeneracion, FechaAlta, SucursalAltaId, OperadorAltaid) VALUES (@IdCliente,@IdTipoComprobante, @IdComprobante,@Concepto,@Debe, @Haber, @Observaciones, @FechaGeneracion, @FechaAlta, @SucursalAltaId, @OperadorAltaid)"

                sqlParam = cmd.Parameters.Add("@IdCliente", SqlDbType.UniqueIdentifier)
                sqlParam.Value = IdCliente

                sqlParam = cmd.Parameters.Add("@IdTipoComprobante", SqlDbType.Int)
                sqlParam.Value = IdTipoComprobante

                sqlParam = cmd.Parameters.Add("@IdComprobante", SqlDbType.UniqueIdentifier)
                sqlParam.Value = IdComprobante

                sqlParam = cmd.Parameters.Add("@Concepto", SqlDbType.NVarChar, 50)
                sqlParam.Value = Concepto

                sqlParam = cmd.Parameters.Add("@Debe", SqlDbType.Money)
                sqlParam.Value = Debe

                sqlParam = cmd.Parameters.Add("@Haber", SqlDbType.Money)
                sqlParam.Value = Haber

                sqlParam = cmd.Parameters.Add("@Observaciones", SqlDbType.NVarChar, 100)
                sqlParam.Value = Observaciones

                sqlParam = cmd.Parameters.Add("@FechaGeneracion", SqlDbType.DateTime)
                sqlParam.Value = FechaGeneracion

                sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
                sqlParam.Value = FechaAlta

                sqlParam = cmd.Parameters.Add("@SucursalAltaId", SqlDbType.Int)
                sqlParam.Value = SucursalAltaId

                sqlParam = cmd.Parameters.Add("@OperadorAltaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = OperadorAltaId


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

    Public Sub CargarLista2(ByRef Dt As DataTable, ByRef Lista As List(Of ClientesMovimiento))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New ClientesMovimiento
                c.CargarFila2(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila2(ByRef Fila As DataRow, ByRef c As ClientesMovimiento)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = 0
        If Fila.Item("Concepto") IsNot DBNull.Value Then c.Concepto = Fila.Item("Concepto") Else c.Concepto = ""
        If Fila.Item("Debe") IsNot DBNull.Value Then c.Debe = Fila.Item("Debe") Else c.Debe = 0
        If Fila.Item("Haber") IsNot DBNull.Value Then c.Haber = Fila.Item("Haber") Else c.Haber = 0
        If Fila.Item("Observaciones") IsNot DBNull.Value Then c.Observaciones = Fila.Item("Observaciones") Else c.Observaciones = ""
        If Fila.Item("IdComprobante") IsNot DBNull.Value Then c.IdComprobante = Fila.Item("IdComprobante") Else c.IdComprobante = System.Guid.Empty
        If Fila.Item("FechaGeneracion") IsNot DBNull.Value Then c.FechaGeneracion = Fila.Item("FechaGeneracion") Else c.FechaGeneracion = System.DateTime.MinValue
        If Fila.Item("IdTipoComprobante") IsNot DBNull.Value Then c.IdTipoComprobante = Fila.Item("IdTipoComprobante") Else c.IdTipoComprobante = 0
        If Fila.Item("NumeroFactura") IsNot DBNull.Value Then c.ReciboFactura = Fila.Item("NumeroFactura") Else c.ReciboFactura = ""
        If Fila.Item("NumeroRecibo") IsNot DBNull.Value Then c.ReciboNumero = Fila.Item("NumeroRecibo") Else c.ReciboNumero = ""
    End Sub

#End Region

End Class
