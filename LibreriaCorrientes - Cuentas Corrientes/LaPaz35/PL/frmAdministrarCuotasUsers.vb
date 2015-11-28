Public Class frmAdministrarCuotasusers
    Dim cls As New clsCtaCte
    Dim clsUsers As New clsUsuariosUsers
    Dim bgsClientes, bgsClientesCuentasCorriente, bgsVentas As New BindingSource


#Region "Inicializar"
    Private Sub frmAdministrarCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        dgvClienteCuentasCorriente.AutoGenerateColumns = False
        dgvClienteCuentasCorriente.DataSource = bgsClientesCuentasCorriente

        dgvClientes.AutoGenerateColumns = False
        dgvClientes.DataSource = bgsClientes
        If dgvClienteCuentasCorriente.RowCount > 0 Then
            PintarCalcularCuotas()
        End If

    End Sub

    Public Sub New(ByVal cliente As String)

        ' This call is required by the designer.
        InitializeComponent()
        BuscarCliente(cliente)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        VaciarControles()
        If txtDNi.Text <> "" Then
            BuscarCliente(Trim(txtDNi.Text))
        End If
    End Sub

    Private Sub VaciarControles()
        pnlCuenta.Visible = False
    End Sub



#Region "Cliente"
    Private Sub BuscarCliente(ByVal cliente As String)
        cls.FillByCliente(cliente)
        If cls.Lstcliente.Count > 1 Then
            dgvClientes.Visible = True

        ElseIf cls.Lstcliente.Count = 1 Then
            dgvClientes.Visible = False
            lblCliente.Text = "cliente: " + cls.Lstcliente.First.Denominacion
            'No tengo guardadas las ventas, solo puedo mostrar el estado de todas las cuotas
            BuscarCuotas(cls.Lstcliente.First.Id)
            PintarCalcularCuotas()

        End If
        bgsClientes.DataSource = cls.Lstcliente
        PintarCalcularCuotas()
    End Sub
#End Region



#Region "ClientesCuentasCorriente"


    Private Sub BuscarCuotas(ByVal cliente As Guid)
        clsUsers.FillListCCCByClienteTodas(cliente)
        bgsClientesCuentasCorriente.DataSource = clsUsers.LstClientesCuentasCorrientesUser
        pnlCuenta.Visible = True
        ' PintarCalcularCuotas()
    End Sub


    Private Sub PintarCalcularCuotas()
        Dim deudaCliente As Decimal = 0
        Dim deudaVencida As Decimal = 0

        '  pnlCuenta.Visible = True

        lblCliente.Text = "Cliente: " + cls.Lstcliente.First.Denominacion
        For Each r As DataGridViewRow In dgvClienteCuentasCorriente.Rows
            Dim clientecuentacorrienteUser As New ClientesCuentasCorrienteUsers
            clientecuentacorrienteUser = CType(r.DataBoundItem, ClientesCuentasCorrienteUsers)
            Try
                If clientecuentacorrienteUser.FechaVencimiento <= Date.Now And clientecuentacorrienteUser.Pagado < clientecuentacorrienteUser.Importe Then
                    r.Cells(0).Style.BackColor = Color.DarkOrange
                    r.Cells(1).Style.BackColor = Color.DarkOrange
                    r.Cells(2).Style.BackColor = Color.DarkOrange
                    r.Cells(3).Style.BackColor = Color.DarkOrange
                    r.Cells(4).Style.BackColor = Color.DarkOrange
                    r.Cells(5).Style.BackColor = Color.DarkOrange
                    r.Cells(6).Style.BackColor = Color.DarkOrange
                    r.Cells(7).Style.BackColor = Color.DarkOrange
                    r.Cells(8).Style.BackColor = Color.DarkOrange
                    deudaVencida += clientecuentacorrienteUser.Importe - clientecuentacorrienteUser.Pagado
                End If

                deudaCliente += clientecuentacorrienteUser.Importe - clientecuentacorrienteUser.Pagado
            Catch ex As Exception

            End Try
        Next
        lblDeuda.Text = "Deuda Total: " + deudaCliente.ToString
        lblDeudaVencida.Text = "Deuda Vencida: " + deudaVencida.ToString
        dgvClienteCuentasCorriente.CurrentCell = Nothing
    End Sub
#End Region

    'Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
    '    BuscarCliente(CType(dgvClientes.CurrentRow.DataBoundItem, Clientes).Cuit)
    '    dgvClientes.Visible = False
    'End Sub

    Private Sub txtDNi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNi.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PintarCalcularCuotas()
    End Sub
End Class