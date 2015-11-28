Imports System.Data.SqlClient

Partial Public Class OperadorSucursal


#Region "Propiedades de vista"

    Private _vOperador As Operadores
    Public Property Operador As Operadores
        Get
            _vOperador = New Operadores
            If Me.OperadorId <> System.Guid.Empty Then
                _vOperador.Usuario = _vOperador.FillListById(Me.OperadorId, clsVariableSesion.Instancia.getConn).First.Usuario
            End If
            Return _vOperador
        End Get
        Set(ByVal Value As Operadores)
            _vOperador = Value
        End Set
    End Property


    Public ReadOnly Property vOperador As String
        Get
            If Me.OperadorId <> System.Guid.Empty Then
                Return Me.Operador.Usuario
            End If
            Return ""
        End Get
    End Property
#End Region

#Region "Funciones"


    Public Function FillListBySucursal(ByVal sucursalId As Integer, ByRef _Conexion As SqlConnection) As List(Of OperadorSucursal)
        Using exe As New SqlCommand
            Dim Lista As New List(Of OperadorSucursal)
            With exe
                .CommandText = "SELECT * FROM OperadorSucursal os" & vbCrLf
                '.CommandText &= "WHERE os.sucursalid=@sucursalId AND os.Activo is null "
                .CommandText &= "WHERE os.sucursalid=@sucursalId "
                .Parameters.AddWithValue("@sucursalId", sucursalId)
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
    Public Function FillListByOperadorId(ByVal Operadorid As Guid, ByRef _Conexion As SqlConnection) As List(Of OperadorSucursal)
        Using exe As New SqlCommand
            Dim Lista As New List(Of OperadorSucursal)
            With exe
                .CommandText = "SELECT * FROM OperadorSucursal os" & vbCrLf
                '.CommandText &= "WHERE os.sucursalid=@sucursalId AND os.Activo is null "
                .CommandText &= "WHERE os.Operadorid=@Operadorid "
                .Parameters.AddWithValue("@Operadorid", Operadorid)
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
    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of OperadorSucursal))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New OperadorSucursal
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As OperadorSucursal)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("OperadorId") IsNot DBNull.Value Then c.OperadorId = Fila.Item("OperadorId") Else c.OperadorId = System.Guid.Empty
        If Fila.Item("SucursalId") IsNot DBNull.Value Then c.SucursalId = Fila.Item("SucursalId") Else c.SucursalId = 0
    End Sub

#End Region

End Class
