Imports System.Data.SqlClient

Partial Public Class Ventas
    Private _CondicionVenta As CondicionesVenta
    Public Property CondicionVenta As CondicionesVenta
        Get
            ' If Me._CondicionVenta Is Nothing Then
            _CondicionVenta = New CondicionesVenta
            If Me.CondicionVentaId > 0 Then
                _CondicionVenta.Nombre = _CondicionVenta.FillListByID(Me.CondicionVentaId, clsVariableSesion.Instancia.getConn).First.Nombre
            End If
            ' End If
            Return _CondicionVenta
        End Get
        Set(ByVal Value As CondicionesVenta)
            _CondicionVenta = Value
        End Set
    End Property

#Region "Propiedades de vista"
    Public ReadOnly Property v_CondicionVenta As String
        Get
            If Me.CondicionVentaId > 0 Then
                Return Me.CondicionVenta.Nombre
            End If

            Return ""
        End Get
    End Property
#End Region

#Region "Funciones"
    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of Ventas)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Ventas)
            With exe
                .CommandText = "SELECT * from Ventas"
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

    Public Function FillListByCliente(ByRef cliente As Guid, ByRef _Conexion As SqlConnection) As List(Of Ventas)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Ventas)
            With exe
                .CommandText = "SELECT * from Ventas v WHERE v.clienteid = @cliente order by FechaAlta DESC"
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

    Public Function FillListById(ByRef Id As Guid, ByRef _Conexion As SqlConnection) As List(Of Ventas)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Ventas)
            With exe
                .CommandText = "SELECT * from Ventas v WHERE v.id = @Id"
                .Parameters.AddWithValue("@Id", Id)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Ventas))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Ventas
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Ventas)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("ComprobanteId") IsNot DBNull.Value Then c.ComprobanteId = Fila.Item("ComprobanteId") Else c.ComprobanteId = 0
        If Fila.Item("ClienteId") IsNot DBNull.Value Then c.ClienteId = Fila.Item("ClienteId") Else c.ClienteId = System.Guid.Empty
        If Fila.Item("PuntoVenta") IsNot DBNull.Value Then c.PuntoVenta = Fila.Item("PuntoVenta") Else c.PuntoVenta = 0
        If Fila.Item("NumeroComprobante") IsNot DBNull.Value Then c.NumeroComprobante = Fila.Item("NumeroComprobante") Else c.NumeroComprobante = ""
        If Fila.Item("FechaComprobante") IsNot DBNull.Value Then c.FechaComprobante = Fila.Item("FechaComprobante") Else c.FechaComprobante = System.DateTime.MinValue
        If Fila.Item("FechaVencimiento") IsNot DBNull.Value Then c.FechaVencimiento = Fila.Item("FechaVencimiento") Else c.FechaVencimiento = System.DateTime.MinValue
        If Fila.Item("FechaUltimoPago") IsNot DBNull.Value Then c.FechaUltimoPago = Fila.Item("FechaUltimoPago") Else c.FechaUltimoPago = System.DateTime.MinValue
        If Fila.Item("CondicionVentaId") IsNot DBNull.Value Then c.CondicionVentaId = Fila.Item("CondicionVentaId") Else c.CondicionVentaId = 0
        If Fila.Item("Concepto") IsNot DBNull.Value Then c.Concepto = Fila.Item("Concepto") Else c.Concepto = ""
        If Fila.Item("ImporteNeto") IsNot DBNull.Value Then c.ImporteNeto = Fila.Item("ImporteNeto") Else c.ImporteNeto = 0
        If Fila.Item("ImporteSena") IsNot DBNull.Value Then c.ImporteSena = Fila.Item("ImporteSena") Else c.ImporteSena = 0
        If Fila.Item("TotalPagado") IsNot DBNull.Value Then c.TotalPagado = Fila.Item("TotalPagado") Else c.TotalPagado = 0
        If Fila.Item("ComprobanteId") IsNot DBNull.Value Then c.ComprobanteId = Fila.Item("ComprobanteId") Else c.ComprobanteId = 0
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

                cmd.CommandText = "UPDATE Ventas SET FechaUltimoPago=@FechaUltimoPago, TotalPagado=@TotalPagado  WHERE id=@id"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime)
                sqlParam.Value = FechaUltimoPago

                sqlParam = cmd.Parameters.Add("@TotalPagado", SqlDbType.Real)
                sqlParam.Value = TotalPagado

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

    'Public Function Update(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As Boolean
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

    '            cmd.CommandText = "UPDATE Ventas SET   ComprobanteId=@ComprobanteId, ClienteId=@ClienteId, PuntoVenta=@PuntoVenta, NumeroComprobante=@NumeroComprobante, FechaVencimiento=@FechaVencimiento, CondicionVentaId=@CondicionVentaId, Concepto=@Concepto, ImporteNeto=@ImporteNeto, ImporteIva=@ImporteIva , ImporteSena=@ImporteSena, FechaUltimoPago=@FechaUltimoPago, TotalPagado=@TotalPagado  WHERE id=@id"
    '            sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = Id

    '            sqlParam = cmd.Parameters.Add("@ComprobanteId", SqlDbType.Int)
    '            sqlParam.Value = ComprobanteId

    '            sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = ClienteId

    '            sqlParam = cmd.Parameters.Add("@PuntoVenta", SqlDbType.Int)
    '            sqlParam.Value = PuntoVenta

    '            sqlParam = cmd.Parameters.Add("@NumeroComprobante", SqlDbType.Int)
    '            sqlParam.Value = NumeroComprobante

    '            sqlParam = cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime)
    '            sqlParam.Value = FechaVencimiento

    '            sqlParam = cmd.Parameters.Add("@CondicionVentaId", SqlDbType.Int)
    '            sqlParam.Value = CondicionVentaId

    '            sqlParam = cmd.Parameters.Add("@Concepto", SqlDbType.NVarChar, 50)
    '            sqlParam.Value = Concepto

    '            sqlParam = cmd.Parameters.Add("@ImporteNeto", SqlDbType.Real)
    '            sqlParam.Value = ImporteNeto

    '            sqlParam = cmd.Parameters.Add("@ImporteIva", SqlDbType.Real)
    '            sqlParam.Value = ImporteIva

    '            sqlParam = cmd.Parameters.Add("@ImporteSena", SqlDbType.Real)
    '            sqlParam.Value = ImporteSena

    '            sqlParam = cmd.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime)
    '            sqlParam.Value = FechaUltimoPago

    '            sqlParam = cmd.Parameters.Add("@TotalPagado", SqlDbType.Real)
    '            sqlParam.Value = TotalPagado

    '            'sqlParam = cmd.Parameters.Add("@EstadoVentaId", SqlDbType.Int)
    '            'sqlParam.Value = EstadoVentaId

    '            'sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
    '            'sqlParam.Value = FechaAlta

    '            'sqlParam = cmd.Parameters.Add("@SucursalAltaId", SqlDbType.Int)
    '            'sqlParam.Value = SucursalAltaId

    '            'sqlParam = cmd.Parameters.Add("@OperadorAltaId", SqlDbType.UniqueIdentifier)
    '            'sqlParam.Value = OperadorAltaId

    '            'sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
    '            'sqlParam.Value = FechaModificacion

    '            'sqlParam = cmd.Parameters.Add("@SucursalModificacionId", SqlDbType.Int)
    '            'sqlParam.Value = SucursalModificacionId

    '            'sqlParam = cmd.Parameters.Add("@OperadorModificacionId", SqlDbType.UniqueIdentifier)
    '            'sqlParam.Value = OperadorModificacionId

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
#End Region
   

End Class
