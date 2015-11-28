Imports System.Data.SqlClient

Partial Public Class ComentariosClientes
#Region "Propiedades/Entidades"
    Private _comentarioUsers As Comentarios
    Public Property v_ComentariosUsers() As Comentarios
        Get
            _comentarioUsers = New Comentarios
            If Me.Comentario <> System.Guid.Empty Then
                _comentarioUsers = _comentarioUsers.FillListByID(Me.Comentario, clsVariableSesionUsers.Instancia.getConn).First
            End If
            Return _comentarioUsers
        End Get
        Set(ByVal value As Comentarios)
            _comentarioUsers = value
        End Set
    End Property
#End Region

    Public ReadOnly Property v_Comentario As String
        Get
            If Me.Comentario <> System.Guid.Empty Then
                Return Me.v_ComentariosUsers.comentario
            End If

            Return 0
        End Get
    End Property

    Public Function FillListByCliente(ByRef Cliente As Guid, ByRef _Conexion As SqlConnection) As List(Of ComentariosClientes)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ComentariosClientes)
            With exe
                .CommandText = "SELECT * FROM ComentariosClientes where Cliente=@Cliente and baja=0 order by Fecha DESC"
                .Parameters.AddWithValue("@Cliente", Cliente)
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
    Public Function FillUltimoByCliente(ByRef Cliente As Guid, ByRef _Conexion As SqlConnection) As List(Of ComentariosClientes)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ComentariosClientes)
            With exe
                .CommandText = "SELECT TOP 1 * FROM ComentariosClientes where Cliente=@Cliente and baja=0 order by Fecha DESC"
                .Parameters.AddWithValue("@Cliente", Cliente)
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

    Public Function FillListByComentario(ByRef comentario As Guid, ByRef _Conexion As SqlConnection) As List(Of ComentariosClientes)
        Using exe As New SqlCommand
            Dim Lista As New List(Of ComentariosClientes)
            With exe
                .CommandText = "SELECT * FROM ComentariosClientes where comentario=@comentario order by Fecha DESC"
                .Parameters.AddWithValue("@comentario", comentario)
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of ComentariosClientes))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New ComentariosClientes
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As ComentariosClientes)
        If Fila.Item("Cliente") IsNot DBNull.Value Then c.Cliente = Fila.Item("Cliente") Else c.Cliente = System.Guid.Empty
        If Fila.Item("Comentario") IsNot DBNull.Value Then c.Comentario = Fila.Item("Comentario") Else c.Comentario = System.Guid.Empty
        If Fila.Item("baja") IsNot DBNull.Value Then c.baja = Fila.Item("baja") Else c.baja = 0
        If Fila.Item("Fecha") IsNot DBNull.Value Then c.Fecha = Fila.Item("Fecha") Else c.Fecha = System.DateTime.MinValue
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
                cmd.CommandText = "INSERT INTO ComentariosClientes (Cliente, Comentario, baja, Fecha) VALUES (@Cliente, @Comentario, @baja, @Fecha)"

                sqlParam = cmd.Parameters.Add("@Cliente", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Cliente

                sqlParam = cmd.Parameters.Add("@Comentario", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Comentario

                sqlParam = cmd.Parameters.Add("@baja", SqlDbType.Bit)
                sqlParam.Value = baja

                sqlParam = cmd.Parameters.Add("@Fecha", SqlDbType.DateTime)
                sqlParam.Value = Fecha

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
                cmd.CommandText = "UPDATE ComentariosClientes SET baja=@baja, fecha=@fecha  WHERE comentario=@comentario"

                sqlParam = cmd.Parameters.Add("@comentario", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Comentario

                sqlParam = cmd.Parameters.Add("@baja", SqlDbType.Bit)
                sqlParam.Value = baja

                sqlParam = cmd.Parameters.Add("@fecha", SqlDbType.DateTime)
                sqlParam.Value = Fecha


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
