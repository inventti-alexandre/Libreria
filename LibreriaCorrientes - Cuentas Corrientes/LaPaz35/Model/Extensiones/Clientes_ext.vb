Imports System.Data.SqlClient

Partial Public Class Clientes
#Region "Funciones"

    Public Function FillList(ByRef _Conexion As SqlConnection) As List(Of Clientes)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Clientes)
            With exe
                .CommandText = "SELECT * from clientes"
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

    Public Function FillListByCliente(ByVal cliente_cuit As String, ByRef _Conexion As SqlConnection) As List(Of Clientes)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Clientes)
            With exe
                .CommandText = "SELECT * FROM clientes c" & vbCrLf
                .CommandText &= "WHERE Activo=1 and c.cuit like '%' +  @cliente_cuit OR c.denominacion like '%' +  @cliente_cuit + '%'  "
                .Parameters.AddWithValue("@cliente_cuit", cliente_cuit)
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

    Public Function FillListById(ByVal id As Guid, ByRef _Conexion As SqlConnection) As List(Of Clientes)
        Using exe As New SqlCommand
            Dim Lista As New List(Of Clientes)
            With exe
                .CommandText = "SELECT * FROM clientes c" & vbCrLf
                .CommandText &= "WHERE c.id = @id  "
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Clientes))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Clientes
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Clientes)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("Denominacion") IsNot DBNull.Value Then c.Denominacion = Fila.Item("Denominacion") Else c.Denominacion = ""
        If Fila.Item("Cuit") IsNot DBNull.Value Then c.Cuit = Fila.Item("Cuit") Else c.Cuit = ""
        If Fila.Item("Telefono") IsNot DBNull.Value Then c.Telefono = Fila.Item("Telefono") Else c.Telefono = ""
        If Fila.Item("Comentarios") IsNot DBNull.Value Then c.Comentarios = Fila.Item("Comentarios") Else c.Comentarios = ""
        If Fila.Item("Domicilio") IsNot DBNull.Value Then c.Domicilio = Fila.Item("Domicilio") Else c.Domicilio = ""
        If Fila.Item("Mail") IsNot DBNull.Value Then c.Mail = Fila.Item("Mail") Else c.Mail = ""
        If Fila.Item("MandarMail") IsNot DBNull.Value Then c.MandarMail = Fila.Item("MandarMail") Else c.MandarMail = False
        If Fila.Item("Llamar") IsNot DBNull.Value Then c.Llamar = Fila.Item("Llamar") Else c.Llamar = False
    End Sub

    Public Function FillClienteByID(ByVal Id As Guid, ByRef _Conexion As SqlConnection) As List(Of Clientes)
        'Dim sqlParam As New SqlParameter
        Using exe As New SqlCommand
            Dim Lista As New List(Of Clientes)
            With exe
                .CommandText = "SELECT * from Clientes WHERE Id=@Id"
                .Parameters.AddWithValue("@Id", Id)
                '.CommandText = "SELECT * from Clientes WHERE ClienteId=@ClienteId"
                '.Parameters.AddWithValue("@ClienteId", ClienteId)
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
                cmd.CommandText = "INSERT INTO Clientes (Id,FechaAlta,FechaModificacion,Mail,Telefono,MandarMail,Llamar) VALUES (@ClienteId,@FechaAlta,@FechaModificacion,@Mail,@Telefono,@MandarMail,@Llamar)"

                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
                sqlParam.Value = FechaAlta

                sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
                sqlParam.Value = FechaModificacion

               sqlParam = cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100)
                sqlParam.Value = Mail

                sqlParam = cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 100)
                sqlParam.Value = Telefono

                sqlParam = cmd.Parameters.Add("@MandarMail", SqlDbType.Bit)
                sqlParam.Value = MandarMail

                sqlParam = cmd.Parameters.Add("@Llamar", SqlDbType.Bit)
                sqlParam.Value = Llamar

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
                cmd.CommandText = "UPDATE Clientes SET FechaModificacion=@FechaModificacion, Mail=@Mail, Telefono=@Telefono, MandarMail=@MandarMail, Llamar=@Llamar  WHERE Id=@Id"

                sqlParam = cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier)
                sqlParam.Value = Id

                sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
                sqlParam.Value = FechaModificacion

                sqlParam = cmd.Parameters.Add("@Mail", SqlDbType.NVarChar, 100)
                sqlParam.Value = Mail

                sqlParam = cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 100)
                sqlParam.Value = Telefono

                sqlParam = cmd.Parameters.Add("@MandarMail", SqlDbType.Bit)
                sqlParam.Value = MandarMail

                sqlParam = cmd.Parameters.Add("@Llamar", SqlDbType.Bit)
                sqlParam.Value = Llamar

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

    Public Function FillClienteConMail(ByRef _Conexion As SqlConnection) As DataTable
        'Dim sqlParam As New SqlParameter
        Using exe As New SqlCommand
            'Dim Lista As New List(Of String)
            Dim ta As New SqlDataAdapter(exe), dt As New DataTable
            With exe
                .CommandText = "lpu_sp_FiltroParaMail"
                .CommandType = CommandType.StoredProcedure
                .Connection = _Conexion
                '.ExecuteNonQuery()
                ta.Fill(dt)
                'CargarListaMail(dt, Lista)
            End With
            Return dt
        End Using
    End Function

#End Region
End Class
