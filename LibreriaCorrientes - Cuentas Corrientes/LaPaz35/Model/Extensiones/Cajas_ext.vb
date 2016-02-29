Imports System.Data.SqlClient
Partial Public Class Cajas


    Public Function FillListUltimaCaja(ByRef _Conexion As SqlConnection) As List(Of Cajas)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Cajas)
            With exe
                .CommandText = "SELECT TOP 1 * from Cajas where SucursalId=27 and FCierre is null order by Fecha desc"
                '.Parameters.AddWithValue("@venta", venta)
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
    Public Function FillListUltimaCaja(ByRef _Conexion As SqlConnection, operadorId As Guid) As List(Of Cajas)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Cajas)
            With exe
                .CommandText = "SELECT TOP 1 * from Cajas where SucursalId=27 and FCierre is null and operadorId = @operadorId"
                '.Parameters.AddWithValue("@venta", venta)
                .Parameters.AddWithValue("@operadorId", operadorId)

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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Cajas))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Cajas
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Cajas)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("SucursalId") IsNot DBNull.Value Then c.SucursalId = Fila.Item("SucursalId") Else c.SucursalId = 0
        If Fila.Item("OperadorId") IsNot DBNull.Value Then c.OperadorId = Fila.Item("OperadorId") Else c.OperadorId = System.Guid.Empty
        If Fila.Item("Fecha") IsNot DBNull.Value Then c.Fecha = Fila.Item("Fecha") Else c.Fecha = System.DateTime.MinValue
        If Fila.Item("FCierre") IsNot DBNull.Value Then c.FCierre = Fila.Item("FCierre") Else c.FCierre = System.DateTime.MinValue
        If Fila.Item("Inicio") IsNot DBNull.Value Then c.Inicio = Fila.Item("Inicio") Else c.Inicio = 0
        If Fila.Item("Egresos") IsNot DBNull.Value Then c.Egresos = Fila.Item("Egresos") Else c.Egresos = 0
        If Fila.Item("Ingresos") IsNot DBNull.Value Then c.Ingresos = Fila.Item("Ingresos") Else c.Ingresos = 0
        If Fila.Item("Saldo") IsNot DBNull.Value Then c.Saldo = Fila.Item("Saldo") Else c.Saldo = 0
        If Fila.Item("Cheques") IsNot DBNull.Value Then c.Cheques = Fila.Item("Cheques") Else c.Cheques = 0
        If Fila.Item("PcAlta") IsNot DBNull.Value Then c.PcAlta = Fila.Item("PcAlta") Else c.PcAlta = ""
        If Fila.Item("FechaAlta") IsNot DBNull.Value Then c.FechaAlta = Fila.Item("FechaAlta") Else c.FechaAlta = DateTime.MinValue
        If Fila.Item("OperadorAltaId") IsNot DBNull.Value Then c.OperadorAltaId = Fila.Item("OperadorAltaId") Else c.OperadorAltaId = System.Guid.Empty
        If Fila.Item("SucursalAltaId") IsNot DBNull.Value Then c.SucursalAltaId = Fila.Item("SucursalAltaId") Else c.SucursalAltaId = 0
        If Fila.Item("FechaModificacion") IsNot DBNull.Value Then c.FechaModificacion = Fila.Item("FechaModificacion") Else c.FechaModificacion = DateTime.MinValue
        If Fila.Item("OperadorModificacionId") IsNot DBNull.Value Then c.OperadorModificacionId = Fila.Item("OperadorModificacionId") Else c.OperadorModificacionId = System.Guid.Empty
        If Fila.Item("SucursalModificacionId") IsNot DBNull.Value Then c.SucursalModificacionId = Fila.Item("SucursalModificacionId") Else c.SucursalModificacionId = 0

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
                cmd.CommandText = "UPDATE Cajas SET Ingresos=@Ingresos WHERE id=@id"

                sqlParam = cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@Ingresos", SqlDbType.Real)
                sqlParam.Value = Ingresos

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
