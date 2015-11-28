Public Class frmCliente
    Dim bgsClientes, bgsClientesCuentasCorriente, bgsVentas, bgsMovimientos, bgsRecibos, bgsRecibosDetalle, bgsCajasMovimientos As New BindingSource
    Dim cls As New clsCtaCte
#Region "Inicializar"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'clsVariableSesion.DbDomain = "USUARIO-PC\SQLEXPRESS"
            'clsVariableSesion.Db = "lapaz"
            'clsVariableSesion.DbUser = "USUARIO-PC\Usuario"
            'clsVariableSesion.DbPass = ""
            clsVariableSesion.Instancia.getConn.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar a la base de datos, ¿desea configurar nuevamente?")
            MsgBox(ex.Message)
        End Try
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.DataSource = bgsClientes

        dgvClienteCuentasCorriente.DataSource = bgsClientesCuentasCorriente
        dgvClienteCuentasCorriente.AutoGenerateColumns = False

        dgvVentas.DataSource = bgsVentas
        dgvVentas.AutoGenerateColumns = False

        dgvMovimientos.DataSource = bgsMovimientos
        dgvMovimientos.AutoGenerateColumns = False

        dgvRecibos.DataSource = bgsRecibos


        dgvRecibosDetalle.DataSource = bgsRecibosDetalle


        dgvCajaMovimientos.DataSource = bgsCajasMovimientos

    End Sub
#End Region

#Region "Funciones"

    Private Sub BuscarCliente(ByVal cliente As String)
        cls.FillByCliente(cliente)
        If cls.Lstcliente.Count > 1 Then
            dgvClientes.Visible = True
        ElseIf cls.Lstcliente.Count = 1 Then
            dgvClientes.Visible = False
            pnlCuenta.Visible = True
            lblCliente.Text = "Cliente: " + cls.Lstcliente.First.Denominacion
            BuscarEstadoCuenta(cls.Lstcliente.First.Id)
            BuscarMovimientos(cls.Lstcliente.First.Id)
            VerDetalleRecibo()
        End If
        bgsClientes.DataSource = cls.Lstcliente
    End Sub

    Private Sub BuscarEstadoCuenta(ByVal cliente As Guid)
        cls.FillListCCCByCliente(cliente)
        bgsClientesCuentasCorriente.DataSource = cls.LstClienteCuentasCorriente

        cls.FillVentasByCte(cliente)
        bgsVentas.DataSource = cls.LstVentas
    End Sub

    Private Sub VerVenta(ByVal venta As Guid)

        cls.FillVentasById(venta)
        bgsVentas.DataSource = cls.LstVentas
    End Sub

    Private Sub BuscarMovimientos(ByVal cliente As Guid)
        cls.FillClienteMovimientoByCliente(cliente)
        bgsMovimientos.DataSource = cls.LstClienteMovimiento
    End Sub

    Private Sub VerMovimientos()
        If dgvVentas.CurrentRow IsNot Nothing Then
            cls.FillClienteMovimientoByVenta(CType(dgvVentas.CurrentRow.DataBoundItem, Ventas).Id)
            bgsMovimientos.DataSource = cls.LstClienteMovimiento
        End If
    End Sub

    Private Sub VerCuotas()
        If dgvVentas.CurrentRow IsNot Nothing Then
            cls.FillListCCCByVenta(CType(dgvVentas.CurrentRow.DataBoundItem, Ventas).Id)
            bgsClientesCuentasCorriente.DataSource = cls.LstClienteCuentasCorriente
        End If
    End Sub
    

    Private Sub VerPagos()
        If dgvMovimientos.CurrentRow IsNot Nothing Then
            cls.FillRecibosByComprobante(CType(dgvMovimientos.CurrentRow.DataBoundItem, ClientesMovimiento).IdComprobante)
            bgsRecibos.DataSource = cls.LstRecibos
        End If
    End Sub

    Private Sub VerDetalleRecibo()
        If dgvRecibos.CurrentRow IsNot Nothing Then
            cls.FillReciboDetalleById(CType(dgvRecibos.CurrentRow.DataBoundItem, Recibos).Id)
            bgsRecibosDetalle.DataSource = cls.LstReciboDetalle
        Else
            If cls.LstClienteCuentasCorriente.Count <> 0 Then
                cls.FillReciboDetalleByCliente(cls.LstClienteCuentasCorriente.First.Id)
                bgsRecibosDetalle.DataSource = cls.LstReciboDetalle
            End If
        End If
    End Sub

    Private Sub VerCajaMovimiento()
        If dgvVentas.CurrentRow IsNot Nothing Then
            cls.FillCajasMovimientosByComprobante(CType(dgvVentas.CurrentRow.DataBoundItem, Ventas).Id)
            bgsCajasMovimientos.DataSource = cls.LstCajasMovimientos
        End If
    End Sub

    Private Sub PagarCuota()
        If MessageBox.Show("¿Desea pagar la cuota?", "Cuota", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MsgBox("pagar")
        Else
            MsgBox("No pagar")
        End If
    End Sub

    
#End Region


#Region "Manejo de controles"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtDNi.Text <> "" Then
            BuscarCliente(Trim(txtDNi.Text))
        End If
    End Sub

    Private Sub txtDNi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNi.KeyDown
        If e.KeyValue = Keys.Enter Then
            BuscarCliente(Trim(txtDNi.Text))
        End If
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        BuscarCliente(CType(dgvClientes.CurrentRow.DataBoundItem, Clientes).Cuit)
    End Sub

    Private Sub dgvClienteCuentasCorriente_DoubleClick(sender As Object, e As EventArgs) Handles dgvClienteCuentasCorriente.DoubleClick
        PagarCuota()
    End Sub

    Private Sub btnDetalleCtCte_Click(sender As Object, e As EventArgs) Handles btnDetalleCtCte.Click
        Dim ventaid As Guid = CType(dgvClienteCuentasCorriente.CurrentRow.DataBoundItem, ClientesCuentasCorriente).VentaId
        VerVenta(ventaid)
    End Sub

    Private Sub ntnMovimientoPorVenta_Click(sender As Object, e As EventArgs) Handles ntnMovimientoPorVenta.Click
        VerMovimientos()
    End Sub
    Private Sub btnCuotas_Click(sender As Object, e As EventArgs) Handles btnCuotas.Click
        vercuotas()
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        VerPagos()
    End Sub
    Private Sub btnDetallerecibo_Click(sender As Object, e As EventArgs) Handles btnDetallerecibo.Click
        VerDetalleRecibo()
    End Sub
    Private Sub btnCajaMovimiento_Click(sender As Object, e As EventArgs) Handles btnCajaMovimiento.Click
        VerCajaMovimiento()
    End Sub
#End Region

    
    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub
    Private Sub txtDNi_TextChanged(sender As Object, e As EventArgs) Handles txtDNi.TextChanged

    End Sub
End Class
