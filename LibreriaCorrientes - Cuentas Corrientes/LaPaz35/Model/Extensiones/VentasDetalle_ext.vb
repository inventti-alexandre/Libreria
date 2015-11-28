Imports System.Data.SqlClient
Partial Public Class VentasDetalle

#Region "Propiedades/Entidades"
    Private _Titulo As Titulos
    Public Property v_Titulo() As Titulos
        Get
            _Titulo = New Titulos
            If Me.TituloId <> System.Guid.Empty Then
                _Titulo = _Titulo.FillListById(Me.TituloId, clsVariableSesion.Instancia.getConn).First
            End If
            Return _Titulo
        End Get
        Set(ByVal value As Titulos)
            _Titulo = value
        End Set
    End Property
#End Region

#Region "Propiedades de Vista"

    Public ReadOnly Property v_TituloNombre As String
        Get
            If Me.TituloId <> System.Guid.Empty Then
                Return Me.v_Titulo.NombreTitulo
            End If

            Return ""
        End Get
    End Property

#End Region

#Region "Funciones"

    Public Function FillListByVenta(ByRef venta As Guid, ByRef _Conexion As SqlConnection) As List(Of VentasDetalle)
        Using exe As New SqlCommand
            Dim Lista As New List(Of VentasDetalle)
            With exe
                .CommandText = "SELECT * from VentasDetalle vd WHERE vd.ventaid = @venta"
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

    Public Sub CargarLista(ByRef Dt As DataTable, ByRef Lista As List(Of VentasDetalle))
        If Dt.Rows.Count > 0 Then
            For Each Fila As DataRow In Dt.Rows
                Dim c As New VentasDetalle
                c.CargarFila(Fila, c)
                Lista.Add(c)
            Next
        End If
    End Sub

    Public Sub CargarFila(ByRef Fila As DataRow, ByRef c As VentasDetalle)
        If Fila.Item("id") IsNot DBNull.Value Then c.Id = Fila.Item("id") Else c.Id = System.Guid.Empty
        If Fila.Item("TituloId") IsNot DBNull.Value Then c.TituloId = Fila.Item("TituloId") Else c.TituloId = System.Guid.Empty
        If Fila.Item("Precio") IsNot DBNull.Value Then c.Precio = Fila.Item("Precio") Else c.Precio = 0
        If Fila.Item("CantidadPropia") IsNot DBNull.Value Then c.CantidadPropia = Fila.Item("CantidadPropia") Else c.CantidadPropia = 0
    End Sub

#End Region

End Class
