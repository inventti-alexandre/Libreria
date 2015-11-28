Imports System.Data.SqlClient
Partial Public Class ClientesCuentasCorrienteUsers
#Region "Propiedades/Entidades"
    Private _Ventas As Ventas
    Public Property v_Ventas() As Ventas
        Get
            _Ventas = New Ventas
            If Me.VentaId <> System.Guid.Empty Then
                _Ventas = _Ventas.FillListById(Me.VentaId, clsVariableSesion.Instancia.getConn).First
            End If
            Return _Ventas
        End Get
        Set(ByVal value As Ventas)
            _Ventas = value
        End Set
    End Property
#End Region

#Region "Propiedades de Vista"

    Public ReadOnly Property v_ComprobanteVenta As Integer
        Get
            If Me.VentaId <> System.Guid.Empty Then
                Return Me.v_Ventas.NumeroComprobante
            End If

            Return 0
        End Get
    End Property

    Public ReadOnly Property v_ImporteVenta As Integer
        Get
            If Me.VentaId <> System.Guid.Empty Then
                Return Me.v_Ventas.ImporteNeto
            End If

            Return 0
        End Get
    End Property

    Public ReadOnly Property v_SeniaVenta As Integer
        Get
            If Me.VentaId <> System.Guid.Empty Then
                Return Me.v_Ventas.ImporteSena
            End If

            Return 0
        End Get
    End Property
#End Region

#Region "Funciones"

    Public Sub New()
        With Me
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

    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of ClientesCuentasCorrienteUsers)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesCuentasCorrienteUsers)
            With exe
                .CommandText = "SELECT * from ClientesCuentasCorriente"
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

    Public Function Count(ByRef _Conexion As SqlConnection) As Integer
        Using exe As New SqlCommand
            With exe
                .CommandText = "SELECT COUNT (*) from ClientesCuentasCorriente"
                .Connection = _Conexion
                Dim ta As New SqlDataAdapter(exe), dt As New DataTable
                ta.Fill(dt)
                dt.Dispose()
                ta.Dispose()
            End With
            Return exe.ExecuteScalar
        End Using
    End Function

    Public Function FillListByCliente(ByRef cliente As Guid, ByRef _Conexion As SqlConnection) As List(Of ClientesCuentasCorrienteUsers)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesCuentasCorrienteUsers)
            With exe
                '.CommandText = "SELECT * from ClientesCuentasCorriente cc WHERE cc.clienteid = @cliente ORDER BY FechaAlta, FechaVencimiento"
                .CommandText = "SELECT * from ClientesCuentasCorriente cc WHERE cc.clienteid = @cliente AND cc.Pagado< cc.importe ORDER BY FechaAlta, FechaVencimiento"
                .Parameters.AddWithValue("@cliente", cliente)
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

    Public Function FillListByClienteTodas(ByRef cliente As Guid, ByRef _Conexion As SqlConnection) As List(Of ClientesCuentasCorrienteUsers)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesCuentasCorrienteUsers)
            With exe
                '.CommandText = "SELECT * from ClientesCuentasCorriente cc WHERE cc.clienteid = @cliente ORDER BY FechaAlta, FechaVencimiento"
                .CommandText = "SELECT * from ClientesCuentasCorriente cc WHERE cc.clienteid = @cliente ORDER BY FechaAlta, FechaVencimiento"
                .Parameters.AddWithValue("@cliente", cliente)
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

    Public Function FillListByVenta(ByRef venta As Guid, ByRef _Conexion As SqlConnection) As List(Of ClientesCuentasCorrienteUsers)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesCuentasCorrienteUsers)
            With exe
                .CommandText = "SELECT * from ClientesCuentasCorriente cc WHERE cc.ventaid = @venta order by cc.Cuota "
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

    Public Function FillListById(ByRef Id As Guid, ByRef _Conexion As SqlConnection) As List(Of ClientesCuentasCorrienteUsers)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ClientesCuentasCorrienteUsers)
            With exe
                .CommandText = "SELECT * from ClientesCuentasCorriente cc WHERE cc.id = @id"
                .Parameters.AddWithValue("@id", Id)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of ClientesCuentasCorrienteUsers))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New ClientesCuentasCorrienteUsers
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As ClientesCuentasCorrienteUsers)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("ClienteId") IsNot DBNull.Value Then c.ClienteId = Fila.Item("ClienteId") Else c.ClienteId = System.Guid.Empty
        If Fila.Item("FechaVencimiento") IsNot DBNull.Value Then c.FechaVencimiento = Fila.Item("FechaVencimiento") Else c.FechaVencimiento = System.DateTime.MinValue
        If Fila.Item("Cuota") IsNot DBNull.Value Then c.Cuota = Fila.Item("Cuota") Else c.Cuota = 0
        If Fila.Item("Importe") IsNot DBNull.Value Then c.Importe = Fila.Item("Importe") Else c.Importe = 0
        If Fila.Item("Pagado") IsNot DBNull.Value Then c.Pagado = Fila.Item("Pagado") Else c.Pagado = 0
        If Fila.Item("VentaId") IsNot DBNull.Value Then c.VentaId = Fila.Item("VentaId") Else c.VentaId = System.Guid.Empty
        If Fila.Item("Fecha") IsNot DBNull.Value Then c.Fecha = Fila.Item("Fecha") Else c.Fecha = System.DateTime.MinValue
        If Fila.Item("FechaUltimoPago") IsNot DBNull.Value Then c.FechaUltimoPago = Fila.Item("FechaUltimoPago") Else c.FechaUltimoPago = System.DateTime.MinValue
    End Sub

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
                cmd.CommandText = "UPDATE ClientesCuentasCorriente SET FechaUltimoPago=@FechaUltimoPago, Pagado=@Pagado, Observaciones=@Observaciones, FechaModificacion=@FechaModificacion, SucursalModificacionId=@SucursalModificacionId, OperadorModificacionId=@OperadorModificacionId  WHERE id=@id"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime)
                sqlParam.Value = FechaUltimoPago

                sqlParam = cmd.Parameters.Add("@Pagado", SqlDbType.Real)
                sqlParam.Value = Pagado

                sqlParam = cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 255)
                sqlParam.Value = Observaciones

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



    Public Function InsertUpdate(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As Boolean
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
                cmd.CommandText = "IF EXISTS (SELECT * FROM ClientesCuentasCorriente WHERE id=@id) UPDATE ClientesCuentasCorriente SET FechaUltimoPago=@FechaUltimoPago, Pagado=@Pagado, Observaciones=@Observaciones, FechaModificacion=@FechaModificacion, SucursalModificacionId=@SucursalModificacionId, OperadorModificacionId=@OperadorModificacionId  WHERE id=@id Else  INSERT INTO  ClientesCuentasCorriente (id, ventaid, clienteid,cuota,fecha, fechavencimiento, fechaultimopago, importe, pagado, fechageneracion, observaciones, fechaalta, sucursalaltaid, operadoraltaid, fechamodificacion, sucursalmodificacionid, operadormodificacionid) VALUES (@id, @ventaid, @clienteid, @cuota, @fecha, @fechavencimiento, @fechaultimopago, @importe, @pagado, @fechageneracion, @observaciones, @fechaalta, @sucursalaltaid, @operadoraltaid, @fechamodificacion, @sucursalmodificacionid, @operadormodificacionid)"
                'cmd.CommandText = "INSERT INTO ClientesCuentasCorriente (id, ventaid, clienteid,cuota,fecha, fechavencimiento, fechaultimopago, importe, pagado, fechageneracion, observaciones, fechaalta, sucursalaltaid, operadoraltaid, fechamodificacion, sucursalmodificacionid, operadormodificacionid) VALUES (@id, @ventaid, @clienteid, @cuota, @fecha, @fechavencimiento, @fechaultimopago, @importe, @pagado, @fechageneracion, @observaciones, @fechaalta, @sucursalaltaid, @operadoraltaid, @fechamodificacion, @sucursalmodificacionid, @operadormodificacionid)" & vbCrLf _
                '& "ON DUPLICATE KEY UPDATE ClientesCuentasCorriente SET FechaUltimoPago=@FechaUltimoPago, Pagado=@Pagado, Observaciones=@Observaciones, FechaModificacion=@FechaModificacion, SucursalModificacionId=@SucursalModificacionId, OperadorModificacionId=@OperadorModificacionId  WHERE id=@id"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@VentaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = VentaId

                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                sqlParam = cmd.Parameters.Add("@Cuota", SqlDbType.TinyInt)
                sqlParam.Value = Cuota

                sqlParam = cmd.Parameters.Add("@Fecha", SqlDbType.DateTime)
                sqlParam.Value = Fecha

                sqlParam = cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime)
                sqlParam.Value = FechaVencimiento

                sqlParam = cmd.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime)
                sqlParam.Value = FechaUltimoPago

                sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Real)
                sqlParam.Value = Importe

                sqlParam = cmd.Parameters.Add("@Pagado", SqlDbType.Real)
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

    Public Function InsertUpdateBack(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As Boolean
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
                cmd.CommandText = "IF NOT EXISTS (SELECT * FROM ClientesCuentasCorriente WHERE id=@id) INSERT INTO  ClientesCuentasCorriente (id, ventaid, clienteid,cuota,fecha, fechavencimiento, fechaultimopago, importe, pagado, fechageneracion, observaciones, fechaalta, sucursalaltaid, operadoraltaid, fechamodificacion, sucursalmodificacionid, operadormodificacionid) VALUES (@id, @ventaid, @clienteid, @cuota, @fecha, @fechavencimiento, @fechaultimopago, @importe, @pagado, @fechageneracion, @observaciones, @fechaalta, @sucursalaltaid, @operadoraltaid, @fechamodificacion, @sucursalmodificacionid, @operadormodificacionid)"
                'cmd.CommandText = "INSERT INTO ClientesCuentasCorriente (id, ventaid, clienteid,cuota,fecha, fechavencimiento, fechaultimopago, importe, pagado, fechageneracion, observaciones, fechaalta, sucursalaltaid, operadoraltaid, fechamodificacion, sucursalmodificacionid, operadormodificacionid) VALUES (@id, @ventaid, @clienteid, @cuota, @fecha, @fechavencimiento, @fechaultimopago, @importe, @pagado, @fechageneracion, @observaciones, @fechaalta, @sucursalaltaid, @operadoraltaid, @fechamodificacion, @sucursalmodificacionid, @operadormodificacionid)" & vbCrLf _
                '& "ON DUPLICATE KEY UPDATE ClientesCuentasCorriente SET FechaUltimoPago=@FechaUltimoPago, Pagado=@Pagado, Observaciones=@Observaciones, FechaModificacion=@FechaModificacion, SucursalModificacionId=@SucursalModificacionId, OperadorModificacionId=@OperadorModificacionId  WHERE id=@id"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@VentaId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = VentaId

                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                sqlParam = cmd.Parameters.Add("@Cuota", SqlDbType.TinyInt)
                sqlParam.Value = Cuota

                sqlParam = cmd.Parameters.Add("@Fecha", SqlDbType.DateTime)
                sqlParam.Value = Fecha

                sqlParam = cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime)
                sqlParam.Value = FechaVencimiento

                sqlParam = cmd.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime)
                sqlParam.Value = FechaUltimoPago

                sqlParam = cmd.Parameters.Add("@Importe", SqlDbType.Real)
                sqlParam.Value = Importe

                sqlParam = cmd.Parameters.Add("@Pagado", SqlDbType.Real)
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
