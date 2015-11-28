Public Class frmMovimientosCliente
    Dim gCliente As New Clientes
    Dim bgsMovimientos As New BindingSource
    Dim cls As New clsCtaCte


    Public Sub New(ByRef cliente As Clientes)
        InitializeComponent()
        gCliente = cliente
        VerMovimientosClienteByCliente(gCliente)
    End Sub

    Private Sub VerMovimientosClienteByCliente(ByRef cliente As Clientes)
        If cliente.Id <> System.Guid.Empty Then
            cls.FillClienteMovimientoByCliente(cliente.Id)
            bgsMovimientos.DataSource = cls.LstClienteMovimiento
            lblCliente.Text = "Historial de Movimientos de: " + cliente.Denominacion
        End If
    End Sub

    Private Sub frmMovimientosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMovimientos.AutoGenerateColumns = False
        dgvMovimientos.DataSource = bgsMovimientos
    End Sub
End Class