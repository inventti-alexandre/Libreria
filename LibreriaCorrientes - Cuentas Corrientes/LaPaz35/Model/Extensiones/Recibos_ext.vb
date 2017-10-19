Imports System.Data.SqlClient
Partial Public Class Recibos
    Public Sub New()
        With Me
            .Id = System.Guid.Empty
            .SucursalCompId = 0
            .Tipo = 0
            .PuntoVenta = 0
            .Numero = ""
            .FechaAnulacion = "1900/01/01 00:00:00"
            .FechaPago = "1900/01/01 00:00:00"
            .Total = 0
            .CobradorId = 0
            .OperadorAuId = System.Guid.Empty
            .OperadorAltaId = System.Guid.Empty
            .FechaAlta = "1900/01/01 00:00:00"
            .SucursalAltaId = 0
            .FechaModificacion = "1900/01/01 00:00:00"
            .SucursalModificacionId = 0
            .OperadorModificacionId = System.Guid.Empty

        End With
    End Sub

    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of Recibos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Recibos)
            With exe
                .CommandText = "SELECT * from Recibos"
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

    Public Function FillListByCliente(ByRef _Conexion As SqlConnection, ByVal Id As Guid) As List(Of Recibos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Recibos)
            With exe
                .CommandText = "SELECT r.* FROM Recibos r INNER JOIN ClientesMovimiento cm ON cm.idcomprobante=r.id WHERE cm.IdCliente=@Id  ORDER BY fechaAlta DESC "
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

    Public Function FillListUltimoNumeroComprobante(ByRef _Conexion As SqlConnection) As List(Of Recibos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Recibos)
            With exe
                .CommandText = "SELECT Top 1 * from Recibos where sucursalCompId=2 order by Numero DESC"
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

    Public Function FillListById(ByRef Id As Guid, ByRef _Conexion As SqlConnection) As List(Of Recibos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Recibos)
            With exe
                .CommandText = "SELECT * from Recibos r WHERE r.id = @id"
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

    Public Function FillListByComprobante(ByRef comprobante As Guid, ByRef _Conexion As SqlConnection) As List(Of Recibos)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Recibos)
            With exe
                .CommandText = "SELECT * from Recibos r WHERE r.id = @comprobante"
                .Parameters.AddWithValue("@comprobante", comprobante)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Recibos))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Recibos
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Recibos)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("Numero") IsNot DBNull.Value Then c.Numero = Fila.Item("Numero") Else c.Numero = ""
        If Fila.Item("FechaPago") IsNot DBNull.Value Then c.FechaPago = Fila.Item("FechaPago") Else c.FechaPago = System.DateTime.MinValue
        If Fila.Item("Total") IsNot DBNull.Value Then c.Total = Fila.Item("Total") Else c.Total = 0
        If Fila.Item("Tipo") IsNot DBNull.Value Then c.Tipo = Fila.Item("Tipo") Else c.Tipo = 0
    End Sub

    'Public Function Insert(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As System.Guid
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
    '            cmd.CommandText = "INSERT INTO Recibos (Id,SucursalCompId,Tipo, PuntoVenta,Numero,FechaPago, Total, CobradorId, OperadorAuId, OperadorAltaId, FechaAlta, SucursalAltaId, FechaModificacion, SucursalModificacionId, OperadorModificacionId) VALUES (@id,@SucursalCompId,@Tipo, @PuntoVenta,@Numero, @FechaPago, @Total, @CobradorId, @OperadorAuId, @OperadorAltaId, @FechaAlta, @SucursalAltaId, @FechaModificacion, @SucursalModificacionId, @OperadorModificacionId)"

    '            sqlParam = cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier)
    '            'Id = System.Guid.NewGuid
    '            sqlParam.Value = Id

    '            sqlParam = cmd.Parameters.Add("@SucursalCompId", SqlDbType.Int)
    '            sqlParam.Value = SucursalCompId

    '            'sqlParam = cmd.Parameters.Add("@Tipo", "Tipo", SqlDbType.Char, 1)
    '            sqlParam = cmd.Parameters.Add("@Tipo", SqlDbType.Int)
    '            sqlParam.Value = Tipo

    '            sqlParam = cmd.Parameters.Add("@PuntoVenta", SqlDbType.Int)
    '            sqlParam.Value = PuntoVenta

    '            sqlParam = cmd.Parameters.Add("@Numero", SqlDbType.Char, 14)
    '            sqlParam.Value = Numero

    '            'sqlParam = cmd.Parameters.Add("@FechaAnulacion", SqlDbType.DateTime)
    '            'sqlParam.Value = FechaAnulacion

    '            sqlParam = cmd.Parameters.Add("@FechaPago", SqlDbType.DateTime)
    '            sqlParam.Value = FechaPago

    '            sqlParam = cmd.Parameters.Add("@Total", SqlDbType.Money)
    '            sqlParam.Value = Total

    '            sqlParam = cmd.Parameters.Add("@CobradorId", SqlDbType.Int)
    '            sqlParam.Value = CobradorId

    '            sqlParam = cmd.Parameters.Add("@OperadorAuId", SqlDbType.UniqueIdentifier)
    '            sqlParam.Value = OperadorAuId

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

    '        Return Id
    '        'Me.entidad_id = cmd.LastInsertedId
    '        'Return cmd.LastInsertedId

    '    End Using
    'End Function

    Public Function Insert(ByRef _Conexion As SqlConnection, Optional ByRef _tran As SqlTransaction = Nothing) As System.Guid
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
                cmd.CommandText = "INSERT INTO Recibos (Id,SucursalCompId,Tipo, PuntoVenta,Numero,FechaPago, Total, OperadorAltaId, FechaAlta, SucursalAltaId) VALUES (@id,@SucursalCompId,@Tipo, @PuntoVenta,@Numero, @FechaPago, @Total, @OperadorAltaId, @FechaAlta, @SucursalAltaId)"

                sqlParam = cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@SucursalCompId", SqlDbType.Int)
                sqlParam.Value = SucursalCompId

                sqlParam = cmd.Parameters.Add("@Tipo", SqlDbType.Int)
                sqlParam.Value = Tipo

                sqlParam = cmd.Parameters.Add("@PuntoVenta", SqlDbType.Int)
                sqlParam.Value = PuntoVenta

                sqlParam = cmd.Parameters.Add("@Numero", SqlDbType.Char, 14)
                sqlParam.Value = Numero

                sqlParam = cmd.Parameters.Add("@FechaPago", SqlDbType.DateTime)
                sqlParam.Value = FechaPago

                sqlParam = cmd.Parameters.Add("@Total", SqlDbType.Money)
                sqlParam.Value = Total

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

            Return Id

        End Using
    End Function

End Class
