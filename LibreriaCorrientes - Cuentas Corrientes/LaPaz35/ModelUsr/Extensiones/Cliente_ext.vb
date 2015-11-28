Imports System.Data.SqlClient
Partial Public Class Cliente
#Region "Funciones"

    Public Sub New()
        With Me
            .ClienteId = System.Guid.Empty
            .Saldo = 0
            .FechaAlta = "1900/01/01 00:00:00"
            .FechaModificacion = "1900/01/01 00:00:00"
            .Cuotas = 0
            .Email = ""
            .Telefono = ""
            .MandarMail = False
            .Llamar = False
        End With
    End Sub

    Public Function SaldoCliente(ByVal ClienteId As Guid, ByRef _Conexion As SqlConnection) As Double
        Dim sqlParam As New SqlParameter
        Using exe As New SqlCommand
            With exe
                .CommandText = "SELECT Saldo from Cliente WHERE ClienteId=@ClienteId"
                .Connection = _Conexion

                sqlParam = exe.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                Dim ta As New SqlDataAdapter(exe), dt As New DataTable
                ta.Fill(dt)
                dt.Dispose()
                ta.Dispose()
            End With
            Return exe.ExecuteScalar
        End Using
    End Function

    Public Function FillClienteByID(ByVal ClienteId As Guid, ByRef _Conexion As SqlConnection) As List(Of Cliente)
        'Dim sqlParam As New SqlParameter
        Using exe As New SqlCommand
            Dim Lista As New List(Of Cliente)
            With exe
                .CommandText = "SELECT * from Cliente WHERE ClienteId=@ClienteId"
                .Parameters.AddWithValue("@ClienteId", ClienteId)
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

    'Public Function FillClienteConMail(ByRef _Conexion As SqlConnection) As List(Of Cliente)
    '    'Dim sqlParam As New SqlParameter
    '    Using exe As New SqlCommand
    '        Dim Lista As New List(Of Cliente)
    '        With exe
    '            .CommandText = "lpu_sp_FiltroParaMail"
    '            .CommandType = CommandType.StoredProcedure
    '            '.Parameters.AddWithValue("@ClienteId", ClienteId)
    '            .Connection = _Conexion
    '            '.ExecuteNonQuery()
    '            Dim ta As New SqlDataAdapter(exe), dt As New DataTable
    '            ta.Fill(dt)
    '            CargarLista(dt, Lista)
    '            'dt.Dispose()
    '            'ta.Dispose()
    '        End With
    '        Return Lista
    '    End Using
    'End Function
    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of Cliente))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New Cliente
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As Cliente)
        If Fila.Item("ClienteId") IsNot DBNull.Value Then c.ClienteId = Fila.Item("ClienteId") Else c.ClienteId = System.Guid.Empty
        If Fila.Item("Saldo") IsNot DBNull.Value Then c.Saldo = Fila.Item("Saldo") Else c.Saldo = 0
        If Fila.Item("FechaAlta") IsNot DBNull.Value Then c.FechaAlta = Fila.Item("FechaAlta") Else c.FechaAlta = System.DateTime.MinValue
        If Fila.Item("FechaModificacion") IsNot DBNull.Value Then c.FechaModificacion = Fila.Item("FechaModificacion") Else c.FechaModificacion = System.DateTime.MinValue
        If Fila.Item("Cuotas") IsNot DBNull.Value Then c.Cuotas = Fila.Item("Cuotas") Else c.Cuotas = 0
        If Fila.Item("Email") IsNot DBNull.Value Then c.Email = Fila.Item("Email") Else c.Email = ""
        If Fila.Item("Telefono") IsNot DBNull.Value Then c.Telefono = Fila.Item("Telefono") Else c.Telefono = ""
        If Fila.Item("MandarMail") IsNot DBNull.Value Then c.MandarMail = Fila.Item("MandarMail") Else c.MandarMail = False
        If Fila.Item("Llamar") IsNot DBNull.Value Then c.Llamar = Fila.Item("Llamar") Else c.Llamar = False

    End Sub

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
                cmd.CommandText = "INSERT INTO Cliente (ClienteId, Saldo, FechaAlta, FechaModificacion,Cuotas,Email,Telefono,MandarMail,Llamar) VALUES (@ClienteId, @Saldo, @FechaAlta, @FechaModificacion,@Cuotas,@Email,@Telefono,@MandarMail,@Llamar)"

                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                sqlParam = cmd.Parameters.Add("@Saldo", SqlDbType.Money)
                sqlParam.Value = Saldo

                sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
                sqlParam.Value = FechaAlta

                sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
                sqlParam.Value = FechaModificacion

                sqlParam = cmd.Parameters.Add("@Cuotas", SqlDbType.Int)
                sqlParam.Value = Cuotas

                sqlParam = cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100)
                sqlParam.Value = Email

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
                cmd.CommandText = "UPDATE Cliente SET FechaModificacion=@FechaModificacion, Saldo=@Saldo, Cuotas=@Cuotas, Email=@Email, Telefono=@Telefono, MandarMail=@MandarMail, Llamar=@Llamar  WHERE Clienteid=@clienteId"

                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                sqlParam = cmd.Parameters.Add("@Saldo", SqlDbType.Money)
                sqlParam.Value = Saldo

                sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
                sqlParam.Value = FechaModificacion

                sqlParam = cmd.Parameters.Add("@Cuotas", SqlDbType.Int)
                sqlParam.Value = Cuotas

                sqlParam = cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100)
                sqlParam.Value = Email

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
                cmd.CommandText = "INSERT INTO Cliente (ClienteId,Saldo,FechaAlta,FechaModificacion,Cuotas,Email,Telefono,MandarMail,Llamar) VALUES (@ClienteId,@Saldo,@FechaAlta,@FechaModificacion,@Cuotas,@Email,@Telefono,@MandarMail,@Llamar)"
               
                sqlParam = cmd.Parameters.Add("@ClienteId", SqlDbType.UniqueIdentifier)
                sqlParam.Value = ClienteId

                sqlParam = cmd.Parameters.Add("@Saldo", SqlDbType.Money)
                sqlParam.Value = Saldo

                sqlParam = cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime)
                sqlParam.Value = FechaAlta

                sqlParam = cmd.Parameters.Add("@FechaModificacion", SqlDbType.DateTime)
                sqlParam.Value = FechaModificacion

                sqlParam = cmd.Parameters.Add("@Cuotas", SqlDbType.Int)
                sqlParam.Value = Cuotas

                sqlParam = cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100)
                sqlParam.Value = Email

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
#End Region
End Class
