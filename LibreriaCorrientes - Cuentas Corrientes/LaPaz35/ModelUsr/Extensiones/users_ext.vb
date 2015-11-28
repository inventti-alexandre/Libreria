Imports System.Data.SqlClient

Partial Public Class users

#Region "Funciones"


    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of users)
        Using exe As New SqlCommand
            Dim Lista As New List(Of users)
            With exe
                .CommandText = "SELECT id, usuario, CONVERT(NVARCHAR(MAX),DECRYPTBYPASSPHRASE('ap_sys_47',password)) AS password, rol, lapazuser, sucursal FROM Users"
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

    Public Function FillListById(ByRef id As Integer, ByRef _Conexion As SqlConnection) As List(Of users)
        Using exe As New SqlCommand
            Dim Lista As New List(Of users)
            With exe
                .CommandText = "SELECT id, usuario, CONVERT(NVARCHAR(MAX),DECRYPTBYPASSPHRASE('ap_sys_47',password)) AS password, rol, lapazuser, sucursal FROM Users where id=@id"
                .Parameters.AddWithValue("@id", id)
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


    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of users))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New users
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As users)
        If Fila.Item("id") IsNot DBNull.Value Then c.id = Fila.Item("id") Else c.id = 0
        If Fila.Item("usuario") IsNot DBNull.Value Then c.usuario = Fila.Item("usuario") Else c.usuario = ""
        If Fila.Item("password") IsNot DBNull.Value Then c.password = Fila.Item("password") Else c.password = ""
        If Fila.Item("rol") IsNot DBNull.Value Then c.rol = Fila.Item("rol") Else c.rol = 0
        If Fila.Item("lapazUser") IsNot DBNull.Value Then c.lapazUser = Fila.Item("lapazUser") Else c.lapazUser = System.Guid.Empty
        If Fila.Item("Sucursal") IsNot DBNull.Value Then c.Sucursal = Fila.Item("Sucursal") Else c.Sucursal = 0
    End Sub

#End Region

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
                cmd.CommandText = "INSERT INTO Users (usuario, password, rol, LaPazUser, sucursal) VALUES (@usuario, ENCRYPTBYPASSPHRASE('ap_sys_47',@password), @rol, @lapazUser, @sucursal)"

                sqlParam = cmd.Parameters.Add("@usuario", SqlDbType.NVarChar, 50)
                sqlParam.Value = usuario

                sqlParam = cmd.Parameters.Add("@password", SqlDbType.NVarChar, 255)
                sqlParam.Value = password

                sqlParam = cmd.Parameters.Add("@rol", SqlDbType.Int)
                sqlParam.Value = rol

                sqlParam = cmd.Parameters.Add("@lapazUser", SqlDbType.UniqueIdentifier)
                sqlParam.Value = lapazUser

                sqlParam = cmd.Parameters.Add("@Sucursal", SqlDbType.Int)
                sqlParam.Value = Sucursal

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
                cmd.CommandText = "Update Users SET password= ENCRYPTBYPASSPHRASE('ap_sys_47',@password) where id=@id"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.Int)
                sqlParam.Value = id


                sqlParam = cmd.Parameters.Add("@password", SqlDbType.NVarChar, 255)
                sqlParam.Value = password


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
