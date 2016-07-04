Public Class FrmCuota

    Dim cls As New clsCtaCte
    Dim clsUser As New clsUsuariosUsers
    Dim bgsCuotasAPagar As New BindingSource
    Dim ListaCuotas As New List(Of ClientesCuentasCorriente)
    Dim TotalPagado As Decimal = 0
    Dim APagar As Decimal = 0
    Dim RecargoTotal As Double = 0
    Dim TotalTarjeta As Double = 0
    Dim TotalCheque As Double = 0
    Dim TotalDeposito As Double = 0
    Dim TotalEfectivo As Double = 0
    Dim ConceptoRecibo As String = "Pago de: "

#Region "Inicializar"

    Public Sub New(ByVal cuotas As List(Of ClientesCuentasCorriente))
        InitializeComponent()
        ListaCuotas = cuotas

        bgsCuotasAPagar.DataSource = ListaCuotas
    End Sub

    Private Sub FrmCuota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCuotasAPagar.AutoGenerateColumns = False
        dgvCuotasAPagar.DataSource = bgsCuotasAPagar

        cls.FillClienteById(ListaCuotas.First.ClienteId)
        lblCliente.Text = "Cliente: " + cls.Lstcliente.First.Denominacion
        For Each r As DataGridViewRow In dgvCuotasAPagar.Rows
            '3= pagado/Apagar
            dgvCuotasAPagar.Item(3, r.Index).Value = CType(r.DataBoundItem, ClientesCuentasCorriente).Importe - CType(r.DataBoundItem, ClientesCuentasCorriente).Pagado
            '4= pago
            dgvCuotasAPagar.Item(4, r.Index).Value = dgvCuotasAPagar.Item(3, r.Index).Value
            r.Cells("Pago").Style.BackColor = Color.White
            r.Cells("Recargo").Style.BackColor = Color.White
            '6= total
            dgvCuotasAPagar.Item(6, r.Index).Value = dgvCuotasAPagar.Item(3, r.Index).Value
        Next

        CalcularTotal()
        HabilitarMetodosPago()
    End Sub
#End Region

#Region "Cuotas"
    Private Sub dgvCuotasAPagar_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuotasAPagar.CellEndEdit
        For Each r As DataGridViewRow In dgvCuotasAPagar.Rows
            'total = a pagar + recargo
            Dim totalLinea As Double = 0
            totalLinea = dgvCuotasAPagar.Item(4, r.Index).Value + dgvCuotasAPagar.Item(5, r.Index).Value
            dgvCuotasAPagar.Item(6, r.Index).Value = totalLinea

            If dgvCuotasAPagar.Item(4, r.Index).Value > dgvCuotasAPagar.Item(3, r.Index).Value Then
                Dim frm As New frmMensajes("El monto ingresado supera el monto adeudado")
                frm.ShowDialog()
            End If
        Next
        CalcularTotal()
    End Sub

    Public Sub CalcularTotal()
        APagar = 0
        RecargoTotal = 0
        For Each r As DataGridViewRow In dgvCuotasAPagar.Rows
            APagar = APagar + dgvCuotasAPagar.Item(6, r.Index).Value
            APagar = Decimal.Round(APagar, 2)
            RecargoTotal = RecargoTotal + dgvCuotasAPagar.Item(5, r.Index).Value
        Next
        lblApagar.Text = "TOTAL A PAGAR: " & APagar
        If TotalPagado <> 0 Then
            lblRestante.Text = "Falta: " & (APagar - TotalPagado)
        End If
    End Sub
#End Region

#Region "Pagos"

#Region "HabilitarMetodosdePago"

    Private Sub HabilitarMetodosPago()
        'Efectivo
        txtEfectivo.Text = ""
        txtEfectivo.Focus()

        'Tarjetas
        txtTarjeta.Text = ""
        cls.FillListTarjetas()
        With cbxTarjeta
            .DisplayMember = "Nombre"
            .ValueMember = "id"
        End With
        cbxTarjeta.DataSource = cls.LstTarjetas
        cbxTarjeta.SelectedValue = ""

        'Cheques
        txtCheque.Text = ""
        cls.FillListBancos()
        With cbxBancos
            .DisplayMember = "NombreCorto"
            .ValueMember = "id"
        End With
        cbxBancos.DataSource = cls.LstBancos
        txtCheque.Focus()
        cbxBancos.SelectedValue = ""


        'Deposito
        txtDeposito.Text = ""
        cls.FillListCuentas()
        With cbxBancoDeposito
            .DisplayMember = "Descripcion"
            .ValueMember = "id"
        End With
        cbxBancoDeposito.DataSource = cls.LstCuentas
        txtDeposito.Focus()
        cbxBancoDeposito.SelectedValue = ""

    End Sub

#End Region


#Region "Generar pago Metodos de pago"
    Private Sub btnAceptarPago_Click(sender As Object, e As EventArgs) Handles btnAceptarEfectivo.Click
        Dim nuevo As Boolean = False
        If txtEfectivo.Text <> "" Then
            If txtEfectivo.Text <> 0 Then
                If dgvPagos.Rows.Count > 0 Then
                    For Each r As DataGridViewRow In dgvPagos.Rows
                        If Not (nuevo) Then
                            If r.Cells("Medio").Value.ToString = "Efectivo" Then
                                'sumar los montos
                                Dim importe As Double = r.Cells("ImportePago").Value
                                importe = importe + txtEfectivo.Text
                                r.Cells("ImportePago").Value = importe
                            Else
                                dgvPagos.Rows.Add("Efectivo", txtEfectivo.Text)
                                nuevo = True
                            End If
                        End If

                    Next
                Else
                    dgvPagos.Rows.Add("Efectivo", txtEfectivo.Text)
                End If
                txtEfectivo.Text = ""
                CalcularTotalPagos()
            End If
        End If
    End Sub

    Private Sub btnAceptarTarjeta_Click(sender As Object, e As EventArgs) Handles btnAceptarTarjeta.Click
        If txtTarjeta.Text <> "" Then
            If txtTarjeta.Text <> 0 Then

                dgvPagos.Rows.Add("Tarjeta", txtTarjeta.Text, cbxTarjeta.SelectedValue, cbxTarjeta.Text, txtCupon.Text)
                txtTarjeta.Text = ""
                cbxTarjeta.SelectedValue = ""
                txtCupon.Text = ""
                CalcularTotalPagos()

            End If
        End If
    End Sub

    Private Sub btnAceptarCheque_Click(sender As Object, e As EventArgs) Handles btnAceptarCheque.Click
        If txtCheque.Text <> "" Then
            If txtCheque.Text <> 0 Then

                dgvPagos.Rows.Add("Cheque", txtCheque.Text, "", "", "", cbxBancos.SelectedValue, cbxBancos.Text, txtChequeNro.Text, dtpFechaCheque.Text)
                txtCheque.Text = ""
                cbxBancos.SelectedValue = ""
                txtChequeNro.Text = ""
                dtpFechaCheque.Value = Now
                CalcularTotalPagos()

            End If

        End If
    End Sub

    Private Sub btnAceptarDeposito_Click(sender As Object, e As EventArgs) Handles btnAceptarDeposito.Click
        If txtDeposito.Text <> "" Then
            If txtDeposito.Text <> 0 Then
                dgvPagos.Rows.Add("Depósito", txtDeposito.Text, "", "", "", cbxBancoDeposito.SelectedValue, cbxBancoDeposito.Text, txtDepositoNro.Text, dtpFechadeposito.Text)
                txtDeposito.Text = ""
                cbxBancoDeposito.SelectedValue = ""
                txtDepositoNro.Text = ""
                dtpFechadeposito.Value = Now
                CalcularTotalPagos()

            End If

        End If
    End Sub

    Private Sub CalcularTotalPagos()
        TotalPagado = 0
        TotalEfectivo = 0
        TotalTarjeta = 0
        TotalCheque = 0
        TotalDeposito = 0
        For Each r As DataGridViewRow In dgvPagos.Rows
            TotalPagado = TotalPagado + r.Cells("ImportePago").Value
            If r.Cells("Medio").Value = "Efectivo" Then
                TotalEfectivo = TotalEfectivo + r.Cells("ImportePago").Value
            ElseIf r.Cells("Medio").Value = "Tarjeta" Then
                TotalTarjeta = TotalTarjeta + r.Cells("ImportePago").Value
            ElseIf r.Cells("Medio").Value = "Cheque" Then
                TotalCheque = TotalCheque + r.Cells("ImportePago").Value
            ElseIf r.Cells("Medio").Value = "Depósito" Then
                TotalDeposito = TotalDeposito + r.Cells("ImportePago").Value
            End If
        Next
        lblTotal.Text = "Total pagado: " & TotalPagado
        lblRestante.Text = "Falta: " & (APagar - TotalPagado)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        TotalPagado = TotalPagado - dgvPagos.CurrentRow.Cells(1).Value
        lblTotal.Text = "Total pagado: " & TotalPagado
        lblRestante.Text = "Falta: " & (APagar - TotalPagado)
        dgvPagos.Rows.Remove(dgvPagos.CurrentRow)
        CalcularTotalPagos()
    End Sub
#End Region



#End Region

#Region "Guardar"
    'Controlar la existencia de caja antes de todo!!

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If APagar - TotalPagado = 0 Then
            GuardarPago()
        ElseIf APagar - TotalPagado > 0 Then
            Dim frm As New frmMensajes("No se ha completado el monto de pago")
            frm.ShowDialog()
        Else
            Dim frm As New frmMensajes("El valor ingresado supera el monto de pago")
            frm.ShowDialog()
        End If

    End Sub

    Private Sub GuardarPago()
        cls.Caja = New Cajas
        cls.FillUltimaCaja(clsVariableSesion.Instancia.Usuario.OperadorId)
        If cls.LstCajas.Count > 0 Then
            GuardarRecibo()
            GuardarReciboDetalle()
            GuardarClienteMovimiento()
            GuardarCaja()
            GuardarCajaMovimiento()
            GuardarClienteCuentaCorriente()
            GuardarVenta()
            GuardarMovimientoTarjeta()
            GuardarMovimientoCheque()
            GuardarMovimientoCuenta()
            'TransaccionGuardado()
            GenerarRecibo()
            Dim frm As New frmMensajes("Se ha guardado el pago de forma correcta")
            frm.ShowDialog()
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            Dim frm As New frmMensajes("No se encuentra Caja de su Operador para generar la operacion")
            frm.ShowDialog()
            DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        Me.Close()
    End Sub

    Private Sub GuardarRecibo()
        'Generar Recibo su id= ComprobanteId
        cls.Recibo = New Recibos
        With cls.Recibo
            .Id = System.Guid.NewGuid
            .SucursalCompId = clsVariableSesion.Instancia.Usuario.SucursalId
            .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId
            .Tipo = 3
            .PuntoVenta = clsVariableSesion.Instancia.Usuario.SucursalId

            ' DETERMINO EL NUMERO DE COMPROBANTE O RECIBO
            cls.FillUltimoNumeroRecibo()
            Dim numeroRecibo As String = cls.LstRecibos.First.Numero
            Dim MyChar() As Char = {"C"}
            Dim NuevoRecibo As String = numeroRecibo.TrimStart(MyChar)
            .Numero = "C000" & NuevoRecibo + 1
            .FechaPago = DateTime.Now
            .Total = APagar

            .OperadorAltaId = clsVariableSesion.Instancia.Usuario.OperadorId
            .FechaAlta = DateTime.Now
            .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId

        End With
        Try
            cls.IniciarTrn()
            cls.GuardarRecibo()
            cls.gettrn.Commit()

        Catch ex As Exception
            cls.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarReciboDetalle()

        If cls.Recibo.Id <> System.Guid.Empty Then
            ' si se guardo el recibo genero el detalle del recibo, una linea por cada cuota a pagar
            '    For Each CuotaAPagar As ClientesCuentasCorriente In ListaCuotas
            For Each r As DataGridViewRow In dgvCuotasAPagar.Rows
                cls.RecibosDetalle = New RecibosDetalle
                With cls.RecibosDetalle
                    .Id = System.Guid.NewGuid
                    .ReciboId = cls.Recibo.Id
                    .ClienteCuentaCorrienteId = dgvCuotasAPagar.Item(7, r.Index).Value
                    .Importe = CType(dgvCuotasAPagar.Item(4, r.Index).Value, Double)
                    '''''SUMAR RECARGO????
                    '.ClienteCuentaCorrienteId = CuotaAPagar.Id
                    '.Importe = CuotaAPagar.Pagado
                    .OperadorAltaId = clsVariableSesion.Instancia.Usuario.OperadorId
                    .FechaAlta = DateTime.Now
                    .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId

                End With
                Try
                    cls.IniciarTrn()
                    cls.GuardarReciboDetalle()
                    cls.gettrn.Commit()

                Catch ex As Exception
                    cls.gettrn.Rollback()
                    MessageBox.Show(ex.Message)
                End Try

                'Try
                '    clsUser.ReciboDetalle = New RecibosDetalleUsers
                '    With clsUser.ReciboDetalle
                '        .Id = cls.RecibosDetalle.Id
                '        .ReciboId = cls.RecibosDetalle.ReciboId
                '        .ClienteCuentaCorrienteId = cls.RecibosDetalle.ClienteCuentaCorrienteId
                '        .Importe = cls.RecibosDetalle.Importe
                '        .OperadorAltaId = cls.RecibosDetalle.OperadorAltaId
                '        .SucursalAltaId = cls.RecibosDetalle.SucursalAltaId

                '    End With
                '    clsUser.IniciarTrnUsers()
                '    clsUser.GuardarReciboDetalle()
                '    clsUser.gettrnUsers.Commit()

                'Catch ex As Exception
                '    cls.gettrn.Rollback()
                '    MessageBox.Show(ex.Message)
                'End Try
            Next
        End If
    End Sub

    Private Sub GuardarClienteMovimiento()
        cls.ClienteMovimiento = New ClientesMovimiento
        With cls.ClienteMovimiento
            .IdCliente = ListaCuotas.First.ClienteId
            .IdTipoComprobante = 3
            .IdComprobante = cls.Recibo.Id
            .Haber = APagar - RecargoTotal
            .Observaciones = "Pago de Cuota"
            .FechaGeneracion = DateTime.Now
            .FechaAlta = DateAndTime.Now
            .OperadorAltaId = clsVariableSesion.Instancia.Usuario.OperadorId
            .FechaAlta = DateTime.Now
            .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId

        End With
        Try
            cls.IniciarTrn()
            cls.GuardarClienteMovimiento()
            cls.gettrn.Commit()

        Catch ex As Exception
            cls.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarCaja()
        cls.Caja = New Cajas
        cls.FillUltimaCaja(clsVariableSesion.Instancia.Usuario.OperadorId)
        cls.Caja = cls.LstCajas.First
        With cls.Caja
            .Ingresos = .Ingresos + APagar
            .Saldo = .Saldo + APagar
            .FechaModificacion = DateAndTime.Now
            .SucursalModificacionId = clsVariableSesion.Instancia.Usuario.SucursalId
            .OperadorModificacionId = clsVariableSesion.Instancia.Usuario.OperadorId
        End With
        Try
            cls.IniciarTrn()
            cls.GuardarCaja()
            cls.gettrn.Commit()

        Catch ex As Exception
            cls.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarCajaMovimiento()

        cls.CajaMovimiento = New CajasMovimientos
        With cls.CajaMovimiento
            .Id = System.Guid.NewGuid
            .CajaId = cls.Caja.Id
            .TipoMovimientoCajaId = 3
            .TipoComprobante = 3
            .ComprobanteId = cls.Recibo.Id
            .Senia = 0
            .Recargo = RecargoTotal
            .Importe = APagar
            .ImpFac = APagar
            .Efectivo = TotalEfectivo
            .Tarjeta = TotalTarjeta
            .Cheque = TotalCheque
            .Deposito = TotalDeposito

            .OperadorAltaId = clsVariableSesion.Instancia.Usuario.OperadorId
            .FechaAlta = DateTime.Now
            .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId

        End With
        Try
            cls.IniciarTrn()
            cls.GuardarCajaMovimiento()
            cls.gettrn.Commit()

        Catch ex As Exception
            cls.gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarClienteCuentaCorriente()
        For Each r As DataGridViewRow In dgvCuotasAPagar.Rows
            '/////GUARDA LA CUOTA EN LA BASE DE DATOS ORIGINAL
            cls.ClienteCuentasCorriente = New ClientesCuentasCorriente
            cls.FillListCCCById(dgvCuotasAPagar.Item(7, r.Index).Value)
            cls.ClienteCuentasCorriente = cls.LstClienteCuentasCorriente.First
            With cls.ClienteCuentasCorriente
                .Pagado = .Pagado + CType(dgvCuotasAPagar.Item(4, r.Index).Value, Double)
                Dim pago As Decimal = CType(r.Cells("Total").Value, Double)
                pago = Decimal.Round(pago, 2)
                .FechaUltimoPago = DateTime.Now
                .Observaciones = cls.Recibo.Numero

                .FechaModificacion = DateTime.Now
                .SucursalModificacionId = clsVariableSesion.Instancia.Usuario.SucursalId
                .OperadorModificacionId = clsVariableSesion.Instancia.Usuario.OperadorId

                ConceptoRecibo = ConceptoRecibo & vbCrLf & "$" & pago & " de la cuota: " & .Cuota & " de Factura Nro: " & .v_ComprobanteVenta
            End With

            Try
                cls.IniciarTrn()
                cls.GuardarClienteCuentaCorriente()
                cls.gettrn.Commit()

            Catch ex As Exception
                cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try

            ''/// GUARDA LA CUOTA EN LA BASE DE DATOS DE RESPALDO TABLA AUTOINCREMENTAL
            'Try
            '    clsUser.CCC = New ClientesCuentasCorrienteBackupUsers
            '    With clsUser.CCC
            '        .Id = cls.ClienteCuentasCorriente.Id
            '        .VentaId = cls.ClienteCuentasCorriente.VentaId
            '        .ClienteId = cls.ClienteCuentasCorriente.ClienteId
            '        .Cuota = cls.ClienteCuentasCorriente.Cuota
            '        .Fecha = cls.ClienteCuentasCorriente.Fecha
            '        .FechaVencimiento = cls.ClienteCuentasCorriente.FechaVencimiento
            '        .FechaUltimoPago = cls.ClienteCuentasCorriente.FechaUltimoPago
            '        .Importe = cls.ClienteCuentasCorriente.Importe
            '        .Pagado = cls.ClienteCuentasCorriente.Pagado
            '        .FechaGeneracion = DateAndTime.Now
            '        .Observaciones = cls.ClienteCuentasCorriente.Observaciones
            '        .FechaAlta = cls.ClienteCuentasCorriente.FechaAlta
            '        .SucursalAltaId = cls.ClienteCuentasCorriente.SucursalAltaId
            '        .OperadorAltaId = cls.ClienteCuentasCorriente.OperadorAltaId
            '        .FechaModificacion = cls.ClienteCuentasCorriente.FechaModificacion
            '        .SucursalModificacionId = cls.ClienteCuentasCorriente.SucursalModificacionId
            '        .OperadorModificacionId = cls.ClienteCuentasCorriente.OperadorModificacionId
            '    End With

            '    clsUser.IniciarTrnUsers()
            '    clsUser.GuardarClienteCuentaCorrienteBackup()
            '    clsUser.gettrnUsers.Commit()

            'Catch ex As Exception
            '    clsUser.gettrnUsers.Rollback()
            '    MessageBox.Show(ex.Message)
            'End Try

            '///GUARDA LA CUOTA EN LA BASE DE DATOS DE RESPALDO EN LA TABLA CUOTAS

            'clsUser.FillListCCCById(dgvCuotasAPagar.Item(7, r.Index).Value)

            ''PREGUNTO SI LA CUOTA YA ESTA GUARDADA EN MI RESPALDO
            'If clsUser.LstClientesCuentasCorrientesUser.Count < 1 Then
            '    clsUser.clientescuentacorrienteUsers = New ClientesCuentasCorrienteUsers
            'Else
            '    clsUser.clientescuentacorrienteUsers = clsUser.LstClientesCuentasCorrientesUser.First
            'End If

            'With clsUser.clientescuentacorrienteUsers

            '    .Id = cls.ClienteCuentasCorriente.Id
            '    .VentaId = cls.ClienteCuentasCorriente.VentaId
            '    .ClienteId = cls.ClienteCuentasCorriente.ClienteId
            '    .Cuota = cls.ClienteCuentasCorriente.Cuota
            '    .Fecha = cls.ClienteCuentasCorriente.Fecha
            '    .FechaVencimiento = cls.ClienteCuentasCorriente.FechaVencimiento
            '    .FechaUltimoPago = cls.ClienteCuentasCorriente.FechaUltimoPago
            '    .Importe = cls.ClienteCuentasCorriente.Importe
            '    .Pagado = cls.ClienteCuentasCorriente.Pagado
            '    .FechaGeneracion = DateAndTime.Now
            '    .Observaciones = cls.ClienteCuentasCorriente.Observaciones
            '    .FechaAlta = cls.ClienteCuentasCorriente.FechaAlta
            '    .SucursalAltaId = cls.ClienteCuentasCorriente.SucursalAltaId
            '    .OperadorAltaId = cls.ClienteCuentasCorriente.OperadorAltaId
            '    .FechaModificacion = cls.ClienteCuentasCorriente.FechaModificacion
            '    .SucursalModificacionId = cls.ClienteCuentasCorriente.SucursalModificacionId
            '    .OperadorModificacionId = cls.ClienteCuentasCorriente.OperadorModificacionId


            '    Dim pago As Decimal = CType(r.Cells("Total").Value, Double)
            '    pago = Decimal.Round(pago, 2)
            '    '.FechaUltimoPago = DateTime.Now
            '    '.Observaciones = cls.Recibo.Numero

            '    '.FechaModificacion = DateTime.Now
            '    '.SucursalModificacionId = clsVariableSesion.Instancia.Usuario.SucursalId
            '    '.OperadorModificacionId = clsVariableSesion.Instancia.Usuario.OperadorId

            'End With

            'Try
            '    clsUser.IniciarTrnUsers()
            '    'clsUser.GuardarClienteCuentaCorriente()
            '    clsUser.gettrnUsers.Commit()

            'Catch ex As Exception
            '    clsUser.gettrnUsers.Rollback()
            '    MessageBox.Show(ex.Message)
            'End Try
        Next
    End Sub

    Private Sub GuardarVenta()
        For Each r As DataGridViewRow In dgvCuotasAPagar.Rows
            cls.FillVentasById(CType(r.DataBoundItem, ClientesCuentasCorriente).VentaId)
            ''''agregar control de lista.count
            If cls.LstVentas.Count > 0 Then
                cls.Venta = cls.LstVentas.First
                With cls.Venta
                    .TotalPagado = .TotalPagado + CType(r.Cells("Pago").Value, Double)
                    .FechaUltimoPago = DateAndTime.Now

                    .FechaModificacion = DateTime.Now
                    .SucursalModificacionId = clsVariableSesion.Instancia.Usuario.SucursalId
                    .OperadorModificacionId = clsVariableSesion.Instancia.Usuario.OperadorId

                End With
                Try
                    cls.IniciarTrn()
                    cls.GuardarVenta()
                    cls.gettrn.Commit()

                Catch ex As Exception
                    cls.gettrn.Rollback()
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Next


    End Sub

    Private Sub GuardarMovimientoTarjeta()
        If TotalTarjeta <> 0 Then
            For Each r As DataGridViewRow In dgvPagos.Rows
                If r.Cells("Medio").Value = "Tarjeta" Then
                    cls.TarjetasMov = New TarjetasMovimientos
                    With cls.TarjetasMov
                        .CajaMovimientoId = cls.Caja.Id
                        .TarjetaId = r.Cells("TarjetaId").Value
                        .LoteCupon = r.Cells("NroCupon").Value
                        .Fecha = DateTime.Now
                        .Importe = r.Cells("ImportePago").Value
                        .CajaMovimientoId = cls.CajaMovimiento.Id
                        ' DETERMINO EL NUMERO DE Interno
                        cls.FillListUltimoIntTarjeta()
                        Dim NroInt = 0

                        If (cls.LstTarjetasMov.Count > 0) Then

                            NroInt = cls.LstTarjetasMov.First.NroInt

                        Else
                            'Dim NroInt As Integer = 0
                        End If

                        .NroInt = NroInt + 1

                        .OperadorAltaId = clsVariableSesion.Instancia.Usuario.OperadorId
                        .FechaAlta = DateTime.Now
                        .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId

                    End With
                    Try
                        cls.IniciarTrn()
                        cls.GuardarTarjetaMov()
                        cls.gettrn.Commit()

                    Catch ex As Exception
                        cls.gettrn.Rollback()
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Next

        End If
    End Sub

    Private Sub GuardarMovimientoCheque()
        If TotalCheque <> 0 Then
            For Each r As DataGridViewRow In dgvPagos.Rows
                If r.Cells("Medio").Value = "Cheque" Then
                    cls.Cheque = New ChequesTerceros
                    With cls.Cheque
                        .Id = System.Guid.NewGuid
                        .CajaMovimientoId = cls.Caja.Id
                        .BancoId = r.Cells("BancoId").Value
                        .NroCheque = r.Cells("NroCheque").Value
                        .Fecha = DateTime.Now
                        .FechaCobro = r.Cells("FechaCheque").Value.ToString
                        .Importe = CType(r.Cells("ImportePago").Value, Double)
                        .OperadorAltaId = clsVariableSesion.Instancia.Usuario.OperadorId
                        .FechaAlta = DateTime.Now
                        .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId

                    End With
                    Try
                        cls.IniciarTrn()
                        cls.GuardarCheque()
                        cls.gettrn.Commit()

                    Catch ex As Exception
                        cls.gettrn.Rollback()
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Next

        End If
    End Sub

    Private Sub GuardarMovimientoCuenta()
        If TotalDeposito <> 0 Then
            For Each r As DataGridViewRow In dgvPagos.Rows
                If r.Cells("Medio").Value = "Depósito" Then
                    cls.Depostio = New CuentasMovimientos()
                    With cls.Depostio
                        .CuentaId = r.Cells("BancoId").Value
                        .TipoMovimientoId = 2
                        .FechaMovimiento = Date.Now
                        .TipoComprobanteId = 3
                        .ComprobanteId = cls.Recibo.Id
                        .NroMovimiento = r.Cells("NroCheque").Value
                        .FechaCobro = r.Cells("FechaCheque").Value.ToString
                        .Descripcion = "DEP.BANC.AUTOMAT."
                        .Credito = CType(r.Cells("ImportePago").Value, Double)
                        .TipoCarga = 2
                        .CajaId = cls.Caja.Id
                        .MonedaId = 0
                        .EstadoMovimientoCuentaId = 0
                        .OperadorAltaId = clsVariableSesion.Instancia.Usuario.OperadorId
                        .FechaAlta = DateTime.Now
                        .SucursalAltaId = clsVariableSesion.Instancia.Usuario.SucursalId

                    End With
                    Try
                        cls.IniciarTrn()
                        cls.GuardarDeposito()
                        cls.gettrn.Commit()

                    Catch ex As Exception
                        cls.gettrn.Rollback()
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Next

        End If
    End Sub

#End Region

#Region "PrepararRecibo"
    Public Sub GenerarRecibo()
        Dim ReciboNro As String = cls.Recibo.Numero
        cls.FillClienteById(cls.ClienteMovimiento.IdCliente)
        Dim ClienteNombre As String = cls.Lstcliente.First.Denominacion
        Dim ClienteDomicilio As String = cls.Lstcliente.First.Domicilio

        'Dim dni As Integer = CInt(cls.Lstcliente.First.Cuit)
        Dim dni As Long = CType(cls.Lstcliente.First.Cuit, Long)
        Dim ClienteDni As String = dni.ToString

        Dim MontoTexto As String = ConvertirMonto(TotalPagado)

        Dim MetodoPago As String = "Forma de pago: "

        For Each r As DataGridViewRow In dgvPagos.Rows
            MetodoPago = MetodoPago & r.Cells("Medio").Value.ToString()
            If r.Cells("NroCupon").Value <> "" Then
                MetodoPago = MetodoPago & " " & r.Cells("TarjetaNombre").Value & " cupon nro: " & r.Cells("NroCupon").Value
            End If

            MetodoPago = MetodoPago & ". "
        Next

        For Each r As DataGridViewRow In dgvCuotasAPagar.Rows
            cls.ClienteCuentasCorriente = New ClientesCuentasCorriente
            cls.FillListCCCById(dgvCuotasAPagar.Item(7, r.Index).Value)
            cls.ClienteCuentasCorriente = cls.LstClienteCuentasCorriente.First


        Next

        Dim Total As Decimal = Decimal.Round(TotalPagado, 2)


        Dim frm As New FrmReciboPago(ReciboNro, ClienteNombre, ClienteDomicilio, ClienteDni, MontoTexto, ConceptoRecibo, Total, MetodoPago)
        frm.ShowDialog()
    End Sub

    Private Function ConvertirMonto(ByVal Monto As Double) As String
        Dim clsConvertidor As New ClsConvertidorALetras
        Dim montoTexto As String = clsConvertidor.Letras(Monto)

        Return montoTexto
    End Function
#End Region


    Private Sub FrmCuota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'DialogResult = Windows.Forms.DialogResult.OK
    End Sub


#Region "Cambiar Punto por coma"

    Private Sub RestringirCaracteres(ByRef e As KeyPressEventArgs)

        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
            If e.KeyChar = "."c Then
                ' si se pulsa en el punto se convertirá en coma
                e.Handled = True
                SendKeys.Send(",")
            End If
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectivo.KeyPress, txtTarjeta.KeyPress, txtCheque.KeyPress
        RestringirCaracteres(e)
    End Sub

    Private Sub dgvCuotasAPagar_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCuotasAPagar.EditingControlShowing

        Dim dText As DataGridViewTextBoxEditingControl = DirectCast(e.Control, DataGridViewTextBoxEditingControl)

        RemoveHandler dText.KeyPress, AddressOf dText_KeyPress
        AddHandler dText.KeyPress, AddressOf dText_KeyPress


    End Sub

    Private Sub dText_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        RestringirCaracteres(e)

    End Sub

#End Region


    Private Sub txtEfectivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEfectivo.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnAceptarPago_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtTarjeta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTarjeta.KeyDown, txtCupon.KeyDown, cbxTarjeta.KeyDown
        If txtTarjeta.Text <> "" And txtCupon.Text <> "" And cbxTarjeta.SelectedValue <> 0 Then
            If e.KeyValue = Keys.Enter Then
                btnAceptarTarjeta_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub txtCheque_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCheque.KeyDown, cbxBancos.KeyDown, txtChequeNro.KeyDown, dtpFechaCheque.KeyDown
        If txtCheque.Text <> "" And txtChequeNro.Text <> "" And cbxBancos.SelectedValue <> 0 Then
            If e.KeyValue = Keys.Enter Then
                btnAceptarCheque_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub txtDeposito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeposito.KeyPress
        RestringirCaracteres(e)
    End Sub
End Class