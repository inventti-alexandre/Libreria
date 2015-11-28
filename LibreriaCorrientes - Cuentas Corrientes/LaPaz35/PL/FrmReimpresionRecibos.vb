Public Class FrmReimpresionRecibos
    Dim cls As New clsCtaCte
    Dim clsUser As New clsUsuariosUsers
    Dim bgsClientes, bgsrecibos As New BindingSource

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtDNi.Text <> "" Then
            BuscarCliente(Trim(txtDNi.Text))
        End If
    End Sub
#Region "Cliente"
    Private Sub BuscarCliente(ByVal cliente As String)
        cls = New clsCtaCte()
        clsUser = New clsUsuariosUsers()
        cls.FillByCliente(cliente)
        If cls.Lstcliente.Count = 0 Then
            Dim frm As New frmMensajes("No se ha encontrado ningún cliente.")
            frm.ShowDialog()
            txtDNi.Text = ""
            txtDNi.Focus()
            pnlCliente.Visible = False
        ElseIf cls.Lstcliente.Count > 1 Then
            pnlCliente.Visible = True
        ElseIf cls.Lstcliente.Count = 1 Then
            pnlCliente.Visible = False
            BuscarRecibos(cls.Lstcliente.First.Id)
            'VerMovimientosCliente()
            'BuscarSaldo()
        End If
        bgsClientes.DataSource = cls.Lstcliente
    End Sub
#End Region

#Region "Recibos"
    Private Sub BuscarRecibos(ByVal cliente As Guid)

        cls.FillListRecibosByCliente(cliente)
        bgsrecibos.DataSource = cls.LstRecibos

        'If cls.LstClienteCuentasCorriente.Count = 0 Then
        '    Dim frm As New frmMensajes("El cliente " & cls.Lstcliente.First.Denominacion & " no presenta deudas, ni cuotas por pagar.")
        '    frm.ShowDialog()
        'End If
        ' PintarCalcularCuotas()
        'pnlVenta.Visible = True
        ' TabInfo.Visible = True
        ' BuscarComentarios()


    End Sub

#End Region

    Private Sub FrmReimpresionRecibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.DataSource = bgsClientes

        dgvRecibos.AutoGenerateColumns = False
        dgvRecibos.DataSource = bgsrecibos
    End Sub

    Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        BuscarCliente(CType(dgvClientes.CurrentRow.DataBoundItem, Clientes).Cuit)
        pnlCliente.Visible = False
    End Sub

    Private Sub dgvRecibos_DoubleClick(sender As Object, e As EventArgs) Handles dgvRecibos.DoubleClick
        GenerarRecibo()
    End Sub

#Region "PrepararRecibo"
    Public Sub GenerarRecibo()
        cls.Recibo = CType(dgvRecibos.CurrentRow.DataBoundItem, Recibos)
        Dim ReciboNro As String = cls.Recibo.Numero
        cls.FillClienteById(cls.Lstcliente.First.Id)
        Dim ClienteNombre As String = cls.Lstcliente.First.Denominacion
        Dim ClienteDomicilio As String = cls.Lstcliente.First.Domicilio

        'Dim dni As Integer = CInt(cls.Lstcliente.First.Cuit)
        Dim dni As Long = CType(cls.Lstcliente.First.Cuit, Long)
        Dim ClienteDni As String = dni.ToString

        Dim MontoTexto As String = ConvertirMonto(cls.Recibo.Total)

        Dim MetodoPago As String = "Forma de pago: "
        cls.FillCajasMovimientosByIdComprobante(cls.Recibo.Id)

        For Each cajasMovimiento As CajasMovimientos In cls.LstCajasMovimientos
            If (cajasMovimiento.Efectivo > 0) Then
                MetodoPago = MetodoPago & "Efectivo "
            End If
            If (cajasMovimiento.Tarjeta > 0) Then
                MetodoPago = MetodoPago & "Tarjeta "
            End If
            If (cajasMovimiento.Cheque > 0) Then
                MetodoPago = MetodoPago & "Cheque "
            End If
            If (cajasMovimiento.Deposito > 0) Then
                MetodoPago = MetodoPago & "Deposito"
            End If

            MetodoPago = MetodoPago & ". "
        Next
        '    If r.Cells("NroCupon").Value <> "" Then
        '        MetodoPago = MetodoPago & " " & r.Cells("TarjetaNombre").Value & " cupon nro: " & r.Cells("NroCupon").Value

        Dim ConceptoRecibo As String = "Pago de: "

        cls.FillReciboDetalleById(cls.Recibo.Id)
        For Each recibosDetalle As RecibosDetalle In cls.LstReciboDetalle

            cls.ClienteCuentasCorriente = New ClientesCuentasCorriente
            cls.FillListCCCById(recibosDetalle.ClienteCuentaCorrienteId)
            cls.ClienteCuentasCorriente = cls.LstClienteCuentasCorriente.First

            Dim importe As Decimal = recibosDetalle.Importe
            ConceptoRecibo = ConceptoRecibo & vbCrLf & "$" & Decimal.Round(importe, 2) & " de la cuota: " & cls.ClienteCuentasCorriente.Cuota & " de Factura Nro: " & cls.ClienteCuentasCorriente.v_ComprobanteVenta
        Next

        Dim subtotal As Decimal = cls.Recibo.Total
        Dim Total As Decimal = Decimal.Round(subtotal, 2)

        Dim frm As New FrmReciboPago(ReciboNro, ClienteNombre, ClienteDomicilio, ClienteDni, MontoTexto, ConceptoRecibo, Total, MetodoPago)
        frm.ShowDialog()
    End Sub

    Private Function ConvertirMonto(ByVal Monto As Double) As String
        Dim clsConvertidor As New ClsConvertidorALetras
        Dim montoTexto As String = clsConvertidor.Letras(Monto)

        Return montoTexto
    End Function
#End Region

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        GenerarRecibo()
    End Sub
End Class