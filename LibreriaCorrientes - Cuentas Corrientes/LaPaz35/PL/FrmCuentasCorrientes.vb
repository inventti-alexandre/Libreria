Public Class FrmCuentasCorrientes
    Dim cls As New clsCtaCte
    Dim clsUser As New clsUsuariosUsers
    Dim bgsClientesCuentasCorriente, bgsClientes, bgsCajasMovimientos, bgsDetalleVenta, bgsMovimientos, bgsRecibosDetalle, bgsDetallePagos, bgsComentariosClientes, bgsMovimientosTodos As New BindingSource
    Dim deudaCliente As Decimal = 0
    Dim DeudaAnterior As Decimal = 0
    Dim SaldoAnterior As Decimal = 0
    Dim SaldoOk As Boolean


#Region "Inicializar"
    Private Sub CuentasCorrientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        Me.WindowState = FormWindowState.Maximized
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.DataSource = bgsClientes

        dgvClienteCuentasCorriente.DataSource = bgsClientesCuentasCorriente
        dgvClienteCuentasCorriente.AutoGenerateColumns = False

        dgvDetalleVenta.DataSource = bgsDetalleVenta
        dgvDetalleVenta.AutoGenerateColumns = False
       
        dgvMovimientos.DataSource = bgsMovimientos
        dgvMovimientos.AutoGenerateColumns = False

        dgvDetallePago.DataSource = bgsDetallePagos
        dgvDetallePago.AutoGenerateColumns = False

        dgvRecibosDetalle.DataSource = bgsRecibosDetalle
        dgvRecibosDetalle.AutoGenerateColumns = False

        dgvCajaMovimientos.DataSource = bgsCajasMovimientos
        dgvCajaMovimientos.AutoGenerateColumns = False

        dgvComentarios.DataSource = bgsComentariosClientes
        dgvComentarios.AutoGenerateColumns = False

        dgvTodos.DataSource = bgsMovimientosTodos
        dgvTodos.AutoGenerateColumns = False

        If clsVariableSesion.Instancia.Rol.id = 1 Then
            cmsComentarios.Enabled = True
        End If

        SaldoOk = True
    End Sub
#End Region

#Region "Funciones"

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
            BuscarEstadoCuenta(cls.Lstcliente.First.Id)
            VerMovimientosCliente()
            BuscarSaldo()
        End If
        bgsClientes.DataSource = cls.Lstcliente
    End Sub
#End Region

#Region "ClientesCuentasCorriente"
    Private Sub BuscarEstadoCuenta(ByVal cliente As Guid)

        cls.FillListCCCByCliente(cliente)
        bgsClientesCuentasCorriente.DataSource = cls.LstClienteCuentasCorriente

        If cls.LstClienteCuentasCorriente.Count = 0 Then
            Dim frm As New frmMensajes("El cliente " & cls.Lstcliente.First.Denominacion & " no presenta deudas, ni cuotas por pagar.")
            frm.ShowDialog()
        End If
        PintarCalcularCuotas()
        pnlVenta.Visible = True
        tabInfo.Visible = True
        BuscarComentarios()


    End Sub

    Private Sub PintarCalcularCuotas()
        deudaCliente = 0
        Dim deudaVencida As Decimal = 0

        pnlCuenta.Visible = True

        lblCliente.Text = "Cliente: " + cls.Lstcliente.First.Denominacion
        If cls.Lstcliente.First.Comentarios <> "" Then
            lblComentario.Text = "Cometarios: " & cls.Lstcliente.First.Comentarios
            lblComentario.Visible = True
        Else
            lblComentario.Text = ""
            lblComentario.Visible = False
        End If

        For Each r As DataGridViewRow In dgvClienteCuentasCorriente.Rows
            Dim clientecuentacorriente As New ClientesCuentasCorriente
            clientecuentacorriente = CType(r.DataBoundItem, ClientesCuentasCorriente)
            Try
                If clientecuentacorriente.FechaVencimiento <= Date.Now Then
                    r.Cells(0).Style.BackColor = Color.DarkOrange
                    r.Cells(1).Style.BackColor = Color.DarkOrange
                    r.Cells(2).Style.BackColor = Color.DarkOrange
                    r.Cells(3).Style.BackColor = Color.DarkOrange
                    r.Cells(4).Style.BackColor = Color.DarkOrange
                    r.Cells(5).Style.BackColor = Color.DarkOrange
                    r.Cells(6).Style.BackColor = Color.DarkOrange
                    r.Cells(7).Style.BackColor = Color.DarkOrange
                    'r.Cells(8).Style.BackColor = Color.DarkOrange
                    deudaVencida += clientecuentacorriente.Importe - clientecuentacorriente.Pagado
                End If

                deudaCliente += clientecuentacorriente.Importe - clientecuentacorriente.Pagado
            Catch ex As Exception

            End Try
        Next
        lblDeuda.Text = "Deuda Total: " + deudaCliente.ToString
        lblDeudaVencida.Text = "Deuda Vencida: " + deudaVencida.ToString
        dgvClienteCuentasCorriente.CurrentCell = Nothing
    End Sub


    Private Sub CalcularTotal()
        Dim total As Decimal = 0
        For Each r As DataGridViewRow In dgvClienteCuentasCorriente.Rows
            If r.Cells("PAgar").Value = True Then
                total = CType(r.DataBoundItem, ClientesCuentasCorriente).Importe - CType(r.DataBoundItem, ClientesCuentasCorriente).Pagado + total
            End If
        Next
        If total >= 0 Then
            lblTotal.Text = "Total a pagar: " + Decimal.Round(total, 2).ToString
        End If
    End Sub
#End Region

#Region "Venta"
    Private Sub VerVenta(ByVal venta As Guid)
        pnlVenta.Visible = True
        cls.FillVentasById(venta)
        Try

            lblFechaCompra.Text = "Fecha de Compra: " + cls.LstVentas.First.FechaComprobante
            lblTotalCompra.Text = "Total Compra: $" + cls.LstVentas.First.ImporteNeto.ToString
            lblSeniaCompra.Text = "Seña: $" + cls.LstVentas.First.ImporteSena.ToString

            cls.FillVentasDetalleByVenta(venta)
            bgsDetalleVenta.DataSource = cls.LstVentaDetalle

        Catch ex As Exception

        End Try

        pnlVenta.Visible = True
    End Sub


#End Region

#Region "DetalleVenta"
    Private Sub VerRecibosDetalleVenta()
        If dgvClienteCuentasCorriente.CurrentRow IsNot Nothing Then
            cls.FillRecibosDetalleByVenta(CType(dgvClienteCuentasCorriente.CurrentRow.DataBoundItem, ClientesCuentasCorriente).VentaId)
            bgsRecibosDetalle.DataSource = cls.LstReciboDetalle
        End If
    End Sub
#End Region

#Region "CajaMovimientos"
    Private Sub VerCajaMovimiento()
        If dgvClienteCuentasCorriente.CurrentRow IsNot Nothing Then
            cls.FillCajasMovimientosByComprobante(CType(dgvClienteCuentasCorriente.CurrentRow.DataBoundItem, ClientesCuentasCorriente).VentaId)
            bgsCajasMovimientos.DataSource = cls.LstCajasMovimientos
        End If
    End Sub
#End Region

#Region "ClientesMovimientos"
    Private Sub VerClientesMovimientos()
        If dgvClienteCuentasCorriente.CurrentRow IsNot Nothing Then
            cls.FillClienteMovimientoByVenta(CType(dgvClienteCuentasCorriente.CurrentRow.DataBoundItem, ClientesCuentasCorriente).VentaId)
            bgsMovimientos.DataSource = cls.LstClienteMovimiento
            dgvCajaMovimientos.Visible = True
            dgvRecibosDetalle.Visible = True
        End If
    End Sub
   Private Sub VerMovimientosCliente()
        cls.FillClienteMovimientoByCliente(cls.Lstcliente.First.Id)
        bgsMovimientosTodos.DataSource = cls.LstClienteMovimiento

    End Sub
#End Region

#Region "DetalleRecibo"
    Private Sub VerDetalleRecibo()
        If dgvRecibosDetalle.CurrentRow IsNot Nothing Then
            cls.FillReciboDetalleById(CType(dgvRecibosDetalle.CurrentRow.DataBoundItem, RecibosDetalle).ReciboId)
            bgsDetallePagos.DataSource = cls.LstReciboDetalle
            If cls.LstReciboDetalle.Count = 0 Then
                dgvDetallePago.Visible = False
            Else
                dgvDetallePago.Visible = True
                bgsDetallePagos.DataSource = cls.LstReciboDetalle
            End If
        End If
    End Sub
#End Region

#Region "Pagar/Cobrar Cuotas"
    Private Sub PagarCuotas()
        Dim cuotas As New List(Of ClientesCuentasCorriente)
        For Each r As DataGridViewRow In dgvClienteCuentasCorriente.Rows
            If r.Cells(PAgar.Name).Value = True Then
                cuotas.Add(CType(r.DataBoundItem, ClientesCuentasCorriente))
            Else
            End If
        Next
        If cuotas.Count > 0 Then
            Dim frm As New FrmCuota(cuotas)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                VaciarControles()
                BuscarEstadoCuenta(cls.Lstcliente.First.Id)
                '  Saldo
                'If SaldoOk Then
                ActualizarSaldo()
                'Else
                '    ActualizarSaldoErroneo()
                'End If
            Else
                BuscarEstadoCuenta(cls.Lstcliente.First.Id)
                CalcularTotal()
            End If

        End If
    End Sub
#End Region

#Region "Comentarios"

    Private Sub BuscarComentarios()
        clsUser.FillComentariosClientesByCliente(cls.Lstcliente.First.Id)
      bgsComentariosClientes.DataSource = clsUser.LstComCliente

    End Sub

    Private Sub btnNuevoComentario_Click(sender As Object, e As EventArgs) Handles btnNuevoComentario.Click
        'NuevoComentario
        If txtBoxComentario.Text <> "" Then
            NuevoComentario(txtBoxComentario.Text)
            txtBoxComentario.Text = ""
        End If
    End Sub

    Public Sub NuevoComentario(ByRef comentario As String)
        clsUser.Comentario = New Comentarios
        With clsUser.Comentario
            .id = System.Guid.NewGuid
            .comentario = comentario & "; Operador: " & clsVariableSesion.Instancia.Usuario.vOperador

        End With
        'NuevoComentarioCliente
        clsUser.ComCliente = New ComentariosClientes
        With clsUser.ComCliente
            .Cliente = cls.Lstcliente.First.Id
            .Comentario = clsUser.Comentario.id
            .baja = 0
            .Fecha = DateTime.Now
        End With
        Try
            clsUser.IniciarTrnUsers()
            clsUser.InsertComentario()
            clsUser.InsertComentarioCliente()
            clsUser.gettrnUsers.Commit()
            BuscarComentarios()
        Catch ex As Exception
            clsUser.gettrnUsers.Rollback()
            MessageBox.Show(ex.Message & "3")
        End Try
    End Sub

    Private Sub txtBoxComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoxComentario.KeyDown
        'If e.KeyValue = Keys.Enter Then
        '    btnNuevoComentario_Click(Nothing, Nothing)
        'End If
    End Sub



    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If clsVariableSesion.Instancia.Rol.id = 1 Then
            If dgvComentarios.CurrentRow IsNot Nothing Then
                clsUser.ComCliente = CType(dgvComentarios.CurrentRow.DataBoundItem, ComentariosClientes)
                txtBoxComentario.Text = clsUser.ComCliente.v_Comentario
                btnNuevoComentario.Visible = False
                btnModificar.Visible = True
            End If
        Else
            Dim frm As New frmMensajes("No tiene los permisos necesarios")
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvComentarios.CurrentRow IsNot Nothing Then

            clsUser.FillComentarioById(clsUser.ComCliente.Comentario)
            clsUser.Comentario = clsUser.LstComentarios.First
            With clsUser.Comentario
                .comentario = txtBoxComentario.Text
            End With

            Try
                clsUser.IniciarTrnUsers()
                clsUser.GuardarComentario()
                clsUser.gettrnUsers.Commit()
                Dim frm As New frmMensajes("Comentario modificado exitosamente")
                frm.ShowDialog()
                BuscarComentarios()
                txtBoxComentario.Text = ""
                btnModificar.Visible = False
                btnNuevoComentario.Visible = True
            Catch ex As Exception
                clsUser.gettrnUsers.Rollback()
                MessageBox.Show(ex.Message & "1")
            End Try
        End If
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        If clsVariableSesion.Instancia.Rol.id = 1 Then

            If dgvComentarios.CurrentRow IsNot Nothing Then

                Dim frm As New frmConfirmacion("¿Desea eliminar el comentario seleccionado?")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    clsUser.FillComentariosClientesByComentario(CType(dgvComentarios.CurrentRow.DataBoundItem, ComentariosClientes).Comentario)
                    clsUser.ComCliente = clsUser.LstComCliente.First
                    With clsUser.ComCliente
                        .baja = 1
                        .Fecha = DateAndTime.Now
                    End With

                    Try
                        clsUser.IniciarTrnUsers()
                        clsUser.GuardarComentarioCliente()
                        clsUser.gettrnUsers.Commit()
                        Dim frm2 As New frmMensajes("Comentario eliminado exitosamente")
                        frm2.ShowDialog()
                        BuscarComentarios()
                        'txtBoxComentario.Text = ""
                    Catch ex As Exception
                        clsUser.gettrnUsers.Rollback()
                        MessageBox.Show(ex.Message & "2")
                    End Try
                End If
            End If

        Else
            Dim frm As New frmMensajes("No tiene los permisos necesarios")
            frm.ShowDialog()
        End If
    End Sub
#End Region

#Region "ClienteUsr"
    Public Sub BuscarSaldo()
        clsUser.FillClienteById(cls.Lstcliente.First.Id)
        '    'Primera vez, busco el saldo inicial, y la cantidad de cuotas
        '    If clsUser.Cliente.ClienteId = Guid.Empty Then
        '        If NuevoSaldo() Then
        '            Dim frm As New frmMensajes("Se actualizó el saldo del cliente al valor de deuda actual: " & deudaCliente.ToString & ". Controlar con el último comentario")
        '            frm.ShowDialog()
        '            txtSaldo.Text = deudaCliente
        '        End If
        '        'El cliente ya tiene su saldo, lo comparo con su deuda, si don distintos, comparo la cantidad de cuotas,
        '        ' si las cuotas son distintas, se trata de una nueva compra, Actualiza el saldo
        '        'si la cantidad de cuotas es la misma, hay un error, informo.

        '    ElseIf clsUser.Cliente.Saldo <> deudaCliente Then
        '        'Busco la cantidad de cuotas del cliente
        '        cls.FillListCCCByClienteTodas(cls.Lstcliente.First.Id)

        '        If cls.LstClienteCuentasCorriente.Count <> clsUser.Cliente.Cuotas Then
        '            ' MsgBox("nuevas Cuotas, ActualizarSaldo saldo")
        '            ActualizarSaldo()
        '        Else
        '            'MsgBox("Error en Cuotas, NoActualizarSaldo saldo")

        '            'Controlo la existencia de un comentario indicando el error
        '            Dim comentario As String = "Saldo : " & clsUser.Cliente.Saldo.ToString("N2") & ", Deuda: " & deudaCliente & ". La deuda de cuotas del cliente no coincide con el saldo registrado del cliente"
        '            Dim comentarioAnterior = clsUser.LstComCliente.First.v_Comentario

        '            Dim MyString2() As String = Split(comentarioAnterior, ";")
        '            'MsgBox(MyString2(0))
        '            'MsgBox(MyString2(1))

        '            If (comentario) <> MyString2(0) Then
        '                NuevoComentario(comentario)
        '            End If

        '            'Informo el error
        '            Dim frm As New frmMensajes("La deuda de cuotas del cliente no coincide con el saldo registrado del cliente")
        '            SaldoOk = False
        '            DeudaAnterior = deudaCliente
        '            SaldoAnterior = clsUser.Cliente.Saldo
        '            txtSaldo.Text = clsUser.Cliente.Saldo.ToString("N2")
        '            frm.ShowDialog()
        '        End If
        '    Else
        '        txtSaldo.Text = clsUser.Cliente.Saldo.ToString("N2")
        '    End If
        'Cargo la Pestaña de Datos del cliente

        If Not (clsUser.Cliente Is Nothing) Then
            txtEmail.Text = clsUser.Cliente.Mail
            txtTeléfono.Text = clsUser.Cliente.Telefono
            ckbMail.Checked = clsUser.Cliente.MandarMail
            ckbLlamar.Checked = clsUser.Cliente.Llamar
        Else
            txtEmail.Text = ""
            txtTeléfono.Text = ""
            ckbMail.Checked = False
            ckbLlamar.Checked = False
        End If
    End Sub

    'Public Function NuevoSaldo() As Boolean
    '    'Busco la cantidad de cuotas del cliente
    '    cls.FillListCCCByClienteTodas(cls.Lstcliente.First.Id)
    '    With clsUser.Cliente
    '        .ClienteId = cls.Lstcliente.First.Id
    '        .Saldo = deudaCliente
    '        .FechaModificacion = Now
    '        .FechaAlta = Now
    '        .Cuotas = cls.LstClienteCuentasCorriente.Count
    '        Try
    '            clsUser.IniciarTrnUsers()
    '            clsUser.NuevoSaldo(clsUser.Cliente)
    '            clsUser.gettrnUsers.Commit()
    '            NuevoComentario("Saldo actualizado a la fecha: " & Date.Now & ". $" & deudaCliente.ToString)
    '            Return True
    '        Catch ex As Exception
    '            clsUser.gettrnUsers.Rollback()
    '            MessageBox.Show(ex.Message & "3")
    '            Return False
    '        End Try
    '    End With
    'End Function

    'Public Function ActualizarSaldoErroneo() As Boolean

    '    Dim diferencia = DeudaAnterior - deudaCliente
    '    With clsUser.Cliente
    '        .ClienteId = cls.Lstcliente.First.Id
    '        .Saldo = clsUser.Cliente.Saldo - diferencia
    '        .FechaModificacion = Now
    '        Try
    '            clsUser.IniciarTrnUsers()
    '            clsUser.ActualizarSaldo(clsUser.Cliente)
    '            clsUser.gettrnUsers.Commit()
    '            NuevoComentario("Saldo actualizado a la fecha: " & Date.Now & ". Saldo: $" & clsUser.Cliente.Saldo.ToString("N2") & ". Diferencia con Deuda: $ " & deudaCliente)
    '            txtSaldo.Text = clsUser.Cliente.Saldo
    '            Return True
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message & "3")
    '            Return False
    '        End Try
    '    End With
    'End Function

    Public Function ActualizarSaldo() As Boolean
        'With clsUser.Cliente
        '    .Saldo = deudaCliente
        '    .FechaModificacion = Now
        '    .Cuotas = cls.LstClienteCuentasCorriente.Count
        '    Try
        '        clsUser.IniciarTrnUsers()
        '        clsUser.ActualizarSaldo(clsUser.Cliente)
        '        clsUser.gettrnUsers.Commit()
        NuevoComentario("Saldo actualizado a la fecha: " & Date.Now & ". $" & deudaCliente.ToString)
        txtSaldo.Text = deudaCliente
        'Return True
        '    Catch ex As Exception
        '    clsUser.gettrnUsers.Rollback()
        '    MessageBox.Show(ex.Message & "3")
        '    Return False
        'End Try
        'End With
    End Function
#End Region

#End Region

#Region "Controles"

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        VaciarControles()
        SaldoOk = True
        If txtDNi.Text <> "" Then
            BuscarCliente(Trim(txtDNi.Text))
        End If

    End Sub
#Region "cmsClienteCuentaCorriente"
    Private Sub VerVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerVentaToolStripMenuItem.Click
        If dgvClienteCuentasCorriente.CurrentRow IsNot Nothing Then
            Dim ventaid As Guid = CType(dgvClienteCuentasCorriente.CurrentRow.DataBoundItem, ClientesCuentasCorriente).VentaId
            tabInfo.Visible = True
            VerVenta(ventaid)
            VerRecibosDetalleVenta()
            VerCajaMovimiento()
            VerClientesMovimientos()
        End If
    End Sub

#End Region


    Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        BuscarCliente(CType(dgvClientes.CurrentRow.DataBoundItem, Clientes).Cuit)
        pnlCliente.Visible = False
    End Sub

    Private Sub VerDetalleDeReciboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerDetalleDeReciboToolStripMenuItem.Click
        VerDetalleRecibo()
    End Sub

    Private Sub VaciarControles()
        pnlCuenta.Visible = False
        tabInfo.Visible = False
        cbxTodo.CheckState = False
    End Sub

    Private Sub btnMovimientosCliente_Click(sender As Object, e As EventArgs) Handles btnMovimientosCliente.Click
        VerMovimientosCliente()
        tabInfo.SelectedIndex = 5
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        PagarCuotas()
    End Sub


    Private Sub dgvClienteCuentasCorriente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClienteCuentasCorriente.CellContentClick
        If e.ColumnIndex = 8 Then
            CalcularTotal()
        End If
    End Sub

    Private Sub dgvClienteCuentasCorriente_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvClienteCuentasCorriente.CurrentCellDirtyStateChanged
        If dgvClienteCuentasCorriente.IsCurrentCellDirty Then
            dgvClienteCuentasCorriente.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub txtDNi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNi.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cbxTodo_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTodo.CheckedChanged
        If dgvClienteCuentasCorriente.Rows.Count > 0 Then
            If cbxTodo.Checked = True Then
                For Each r As DataGridViewRow In dgvClienteCuentasCorriente.Rows
                    r.Cells("PAgar").Value = True
                Next
            Else
                For Each r As DataGridViewRow In dgvClienteCuentasCorriente.Rows
                    r.Cells("PAgar").Value = False
                Next
            End If
            CalcularTotal()
        End If
    End Sub

    Private Sub dgvClienteCuentasCorriente_DoubleClick(sender As Object, e As EventArgs) Handles dgvClienteCuentasCorriente.DoubleClick
        VerVentaToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub VerDetalleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerDetalleToolStripMenuItem.Click
        Dim reciboid As New Guid
        reciboid = CType(dgvTodos.CurrentRow.DataBoundItem, ClientesMovimiento).IdComprobante

        Dim frm As New frmDetalleRecibo(reciboid)
        frm.ShowDialog()
    End Sub

    Private Sub btnResguardo_Click(sender As Object, e As EventArgs) Handles btnResguardo.Click
        'Dim frm As New frmAdministrarCuotasusers(cls.Lstcliente.First.Cuit)
        'frm.WindowState = FormWindowState.Normal
        'frm.ShowDialog()
    End Sub
#End Region



    Private Sub btnGuardarDatosCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarDatosCliente.Click
        If Not (clsUser.Cliente Is Nothing) Then
            If txtEmail.Text <> "" Then
                clsUser.Cliente.Mail = Trim(txtEmail.Text)
            End If
            ' clsUser.Cliente.Email = txtEmail.Text
            clsUser.Cliente.Telefono = txtTeléfono.Text
            clsUser.Cliente.MandarMail = ckbMail.CheckState
            clsUser.Cliente.Llamar = ckbLlamar.CheckState
            clsUser.Cliente.FechaModificacion = DateTime.Now

            Try
                clsUser.IniciarTrnUsers()
                clsUser.ActualizarSaldo(clsUser.Cliente)
                clsUser.gettrnUsers.Commit()
                Dim frm As New frmMensajes("Datos guardados correctamente.")
                frm.ShowDialog()
                ' NuevoComentario("Saldo actualizado a la fecha: " & Date.Now & ". $" & deudaCliente.ToString)
                ' txtSaldo.Text = deudaCliente
                ' Return True
            Catch ex As Exception
                clsUser.gettrnUsers.Rollback()
                MessageBox.Show(ex.Message & "DatosCliente")
                '  Return False
            End Try
        Else
            clsUser.Cliente = New Clientes()
        End If
    End Sub
End Class