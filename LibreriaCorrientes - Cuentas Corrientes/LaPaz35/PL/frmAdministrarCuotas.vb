Public Class frmAdministrarCuotas
    Dim cls As New clsCtaCte
    Dim clsUsers As New clsUsuariosUsers
    Dim bgsClientes, bgsClientesCuentasCorriente, bgsVentas As New BindingSource
    Dim _deudaCliente As Decimal = 0

    Private Sub frmAdministrarCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try
        '    clsVariableSesion.Instancia.getConn.Open()
        '    MsgBox("Conectado")
        'Catch ex As Exception
        '    MessageBox.Show("No se pudo conectar a la base de datos, ¿desea configurar nuevamente?")
        '    MsgBox(ex.Message)
        'End Try
        Me.WindowState = FormWindowState.Maximized

        dgvClienteCuentasCorriente.AutoGenerateColumns = False
        dgvClienteCuentasCorriente.DataSource = bgsClientesCuentasCorriente

        dgvClientes.AutoGenerateColumns = False
        dgvClientes.DataSource = bgsClientes

        dgvVentas.AutoGenerateColumns = False
        dgvVentas.DataSource = bgsVentas
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        VaciarControles()
        If txtDNi.Text <> "" Then
            BuscarCliente(Trim(txtDNi.Text))
        End If
    End Sub

    Private Sub VaciarControles()
        pnlCuenta.Visible = False
        pnlVenta.Visible = False
        '  pnlSaldo.Visible = False
    End Sub

#Region "Cliente"
    Private Sub BuscarCliente(ByVal cliente As String)
        cls.FillByCliente(cliente)
        If cls.Lstcliente.Count > 1 Then
            dgvClientes.Visible = True
            dgvClientes.Top = pnlVenta.Top
            dgvClientes.Left = pnlVenta.Left

        ElseIf cls.Lstcliente.Count = 1 Then
            dgvClientes.Visible = False
            lblCliente.Text = "cliente: " + cls.Lstcliente.First.Denominacion
            BuscarVentas(cls.Lstcliente.First.Id)
            PintarCalcularCuotas()
            BuscarEstadoCuenta(cls.Lstcliente.First.Id)
            ' pnlSaldo.Visible = True
            'BuscarSaldo()

        End If
        bgsClientes.DataSource = cls.Lstcliente
    End Sub

    Private Sub BuscarEstadoCuenta(ByVal cliente As Guid)

        cls.FillListCCCByCliente(cliente)
        bgsClientesCuentasCorriente.DataSource = cls.LstClienteCuentasCorriente
    End Sub
#End Region

#Region "Venta"

    
    Private Sub BuscarVentas(ByVal cliente As Guid)
        pnlVenta.Visible = True
        cls.FillVentasByCte(cliente)
        bgsVentas.DataSource = cls.LstVentas
    End Sub
#End Region

#Region "Cliente"
    'Public Sub BuscarSaldo()
    '    clsUsers.FillClienteById(cls.Lstcliente.First.Id)
    '    'Dim saldo As Double = clsUser.BuscarSaldo().ToString

    '    If clsUsers.Cliente.ClienteId = Guid.Empty Then
    '        txtSaldo.Text = 0
    '    Else
    '        txtSaldo.Text = clsUsers.Cliente.Saldo.ToString("N2")
    '    End If
    'End Sub

    Private Sub btnSaldo_Click(sender As Object, e As EventArgs) Handles btnSaldo.Click
        'If clsUsers.Cliente.ClienteId = Guid.Empty Then
        '    'Nuevo "Cliente"
        '    NuevoSaldo()
        'Else
        '    ActualizarSaldo()
        'End If
        'Dim frm As New frmMensajes("Saldo del Cliente actualizado correctamente")
        'frm.ShowDialog()
    End Sub

    'Public Function NuevoSaldo() As Boolean
    '    With clsUsers.Cliente
    '        .ClienteId = cls.Lstcliente.First.Id
    '        .Saldo = txtSaldo.Text
    '        .FechaModificacion = DateAndTime.Now
    '        .FechaAlta = Now
    '        Try
    '            clsUsers.IniciarTrnUsers()
    '            clsUsers.NuevoSaldo(clsUsers.Cliente)
    '            clsUsers.gettrnUsers.Commit()
    '            NuevoComentario("Saldo actualizado a la fecha: " & Date.Now & ". $" & txtSaldo.Text.ToString("N2"))
    '            Return True
    '        Catch ex As Exception
    '            clsUsers.gettrnUsers.Rollback()
    '            MessageBox.Show(ex.Message & "3")
    '            Return False
    '        End Try
    '    End With
    'End Function

    'Public Function ActualizarSaldo() As Boolean
    '    With clsUsers.Cliente
    '        ' .ClienteId = cls.Cliente.Id
    '        .Saldo = txtSaldo.Text
    '        .FechaModificacion = Now
    '        Try
    '            clsUsers.IniciarTrnUsers()
    '            clsUsers.ActualizarSaldo(clsUsers.Cliente)
    '            clsUsers.gettrnUsers.Commit()
    '            NuevoComentario("Saldo actualizado a la fecha: " & Date.Now & ". $" & txtSaldo.Text.ToString())
    '            txtSaldo.Text = txtSaldo.Text
    '            Dim frm As New frmMensajes("Saldo actualizado correctamente.")
    '            Return True
    '        Catch ex As Exception
    '            clsUsers.gettrnUsers.Rollback()
    '            MessageBox.Show(ex.Message & "3")
    '            Return False
    '        End Try
    '    End With
    'End Function


    Public Sub NuevoComentario(ByRef comentario As String)
        clsUsers.Comentario = New Comentarios
        With clsUsers.Comentario
            .id = System.Guid.NewGuid
            .comentario = comentario & ". Operador: " & clsVariableSesion.Instancia.Usuario.vOperador
        End With
        'NuevoComentarioCliente
        clsUsers.ComCliente = New ComentariosClientes
        With clsUsers.ComCliente
            .Cliente = cls.Lstcliente.First.Id
            .Comentario = clsUsers.Comentario.id
            .baja = 0
            .Fecha = DateTime.Now
        End With
        Try
            clsUsers.IniciarTrnUsers()
            clsUsers.InsertComentario()
            clsUsers.InsertComentarioCliente()
            clsUsers.gettrnUsers.Commit()
            'BuscarComentarios()
        Catch ex As Exception
            clsUsers.gettrnUsers.Rollback()
            MessageBox.Show(ex.Message & "3")
        End Try
    End Sub
#End Region
   

#Region "ClientesCuentasCorriente"

   

    Private Sub BuscarCuotasVenta(ByVal venta As Guid)
        cls.FillListCCCByVenta(venta)
        bgsClientesCuentasCorriente.DataSource = cls.LstClienteCuentasCorriente
        pnlCuenta.Visible = True
    End Sub

    Private Sub PintarCalcularCuotas()
        Dim deudaCliente As Decimal = 0
        '_deudaCliente = 0
        Dim deudaVencida As Decimal = 0
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
                    r.Cells(8).Style.BackColor = Color.DarkOrange
                    deudaVencida += clientecuentacorriente.Importe - clientecuentacorriente.Pagado
                End If

                deudaCliente += clientecuentacorriente.Importe - clientecuentacorriente.Pagado
                '_deudaCliente = deudaCliente
            Catch ex As Exception

            End Try
        Next
       
        dgvClienteCuentasCorriente.CurrentCell = Nothing
    End Sub

#End Region

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        For Each r As DataGridViewRow In dgvClienteCuentasCorriente.Rows
            'Guardo en Tabla original

            cls.ClienteCuentasCorriente = CType(r.DataBoundItem, ClientesCuentasCorriente)

            With cls.ClienteCuentasCorriente
                Dim valor As Decimal = r.Cells("cccPagado").Value
                .Pagado = valor
            End With

            Try
                cls.IniciarTrn()
                cls.GuardarClienteCuentaCorriente()
                cls.gettrn.Commit()
                
            Catch ex As Exception
                cls.gettrn.Rollback()
                MessageBox.Show(ex.Message)
            End Try

           
        Next
        CalcularNuevaDeuda(cls.ClienteCuentasCorriente.ClienteId)

        'NuevoComentario("Cuota actualizada. Fecha: " & Date.Now & ".")
        NuevoComentario("Cuota actualizada. Fecha: " & Date.Now & ". $" & _deudaCliente.ToString)
        Dim frm As New frmMensajes("Se han guardado los datos de manera correcta. Nuevo Saldo: " & _deudaCliente.ToString)
        frm.ShowDialog()
        dgvVentas_DoubleClick(Nothing, Nothing)
        pnlCuenta.Visible = False

        
    End Sub

    Private Sub CalcularNuevaDeuda(ByVal cliente As Guid)
        _deudaCliente = 0

        cls.FillListCCCByCliente(Cliente)
        bgsClientesCuentasCorriente.DataSource = cls.LstClienteCuentasCorriente

        For Each clientesCuentasCorriente As ClientesCuentasCorriente In cls.LstClienteCuentasCorriente
            _deudaCliente += clientesCuentasCorriente.Importe - clientesCuentasCorriente.Pagado
        Next

       End Sub

    Private Sub dgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick
        If dgvVentas.CurrentRow IsNot Nothing Then
            BuscarCuotasVenta(CType(dgvVentas.CurrentRow.DataBoundItem, Ventas).Id)
        End If
    End Sub

    Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        BuscarCliente(CType(dgvClientes.CurrentRow.DataBoundItem, Clientes).Cuit)
        dgvClientes.Visible = False
    End Sub

    Private Sub txtDNi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNi.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dgvClienteCuentasCorriente_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvClienteCuentasCorriente.EditingControlShowing
        Dim dText As DataGridViewTextBoxEditingControl = DirectCast(e.Control, DataGridViewTextBoxEditingControl)

        RemoveHandler dText.KeyPress, AddressOf dText_KeyPress
        AddHandler dText.KeyPress, AddressOf dText_KeyPress
    End Sub

    Private Sub dText_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        RestringirCaracteres(e)

    End Sub
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

  
    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        RestringirCaracteres(e)
    End Sub
End Class