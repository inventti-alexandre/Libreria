Imports CorrientesCtaCte.PL.Mails

Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clsVariableSesion.Instancia.getConn.Open()
            clsVariableSesionUsers.Instancia.getConn.Open()
            '  ActualizarBaseDatos()

            Dim frm As New frmLogin
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                HabilitarMenu()
            End If
            ' bgwBaseDatos.RunWorkerAsync()
        Catch ex As Exception
            Dim frm As New frmMensajes("No se pudo conectar a la base de datos")
            frm.ShowDialog()

            'MsgBox(ex.Message)
        End Try
        'EnviodeMail()
    End Sub

    Private Sub HabilitarMenu()
        If clsVariableSesion.Instancia.Rol.id = 1 Then
            CobroDeCuentasCorrientesToolStripMenuItem.Enabled = True
            AdministraciónToolStripMenuItem.Enabled = True
        ElseIf clsVariableSesion.Instancia.Rol.id = 2 Then
            CobroDeCuentasCorrientesToolStripMenuItem.Enabled = True
        End If
        CerrarSesiónToolStripMenuItem.Enabled = True
        CambiarContraseñaToolStripMenuItem.Enabled = True
        IniciarSesiónToolStripMenuItem.Enabled = False
    End Sub
    Private Sub CobroDeCuentasCorrientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobroDeCuentasCorrientesToolStripMenuItem.Click
        Dim frmCtaCte As New FrmCuentasCorrientes
        frmCtaCte.MdiParent = Me
        frmCtaCte.Show()
    End Sub

    Private Sub GestiónDeCuotasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónDeCuotasToolStripMenuItem1.Click
        Dim frm As New frmAdministrarCuotas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem1.Click
        Dim frmUsuarios As New FrmGestionUsuarios
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        clsVariableSesion.Instancia.getConn.Close()
        clsVariableSesionUsers.Instancia.getConn.Close()

        CobroDeCuentasCorrientesToolStripMenuItem.Enabled = False
        AdministraciónToolStripMenuItem.Enabled = False
        CerrarSesiónToolStripMenuItem.Enabled = False
        IniciarSesiónToolStripMenuItem.Enabled = True
        CambiarContraseñaToolStripMenuItem.Enabled = False

    End Sub

    Private Sub IniciarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesiónToolStripMenuItem.Click
        clsVariableSesion.Instancia.getConn.Open()
        clsVariableSesionUsers.Instancia.getConn.Open()

        Dim frm As New frmLogin
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            HabilitarMenu()
        End If

    End Sub

    'Private Sub ActualizarBaseDatos()
    '    Dim cls As New clsCtaCte
    '    Dim clsUser As New clsUsuariosUsers

    '    Dim cuotasclientes As Integer = cls.ContarClienteCuentaCorriente
    '    Dim cuotasback As Integer = clsUser.ContarClienteCuentaCorriente

    '    If cuotasclientes > cuotasback Then

    '        cls.FillUltimos(cuotasclientes - cuotasback)

    '        For Each cuota As ClientesCuentasCorriente In cls.LstClienteCuentasCorriente
    '            clsUser.clientescuentacorrienteUsers = New ClientesCuentasCorrienteUsers
    '            With clsUser.clientescuentacorrienteUsers

    '                .Id = cuota.Id
    '                .VentaId = cuota.VentaId
    '                .ClienteId = cuota.ClienteId
    '                .Cuota = cuota.Cuota
    '                .Fecha = cuota.Fecha
    '                .FechaVencimiento = cuota.FechaVencimiento
    '                .FechaUltimoPago = cuota.FechaUltimoPago
    '                .Importe = cuota.Importe
    '                .Pagado = cuota.Pagado
    '                .FechaGeneracion = cuota.FechaGeneracion
    '                .Observaciones = cuota.Observaciones
    '                .FechaAlta = cuota.FechaAlta
    '                .SucursalAltaId = cuota.SucursalAltaId
    '                .OperadorAltaId = cuota.OperadorAltaId
    '                .FechaModificacion = cuota.FechaModificacion
    '                .SucursalModificacionId = cuota.SucursalModificacionId
    '                .OperadorModificacionId = cuota.OperadorModificacionId

    '            End With

    '            Try
    '                clsUser.IniciarTrnUsers()
    '                clsUser.GuardarClienteCuentaCorrienteBack()
    '                clsUser.gettrnUsers.Commit()

    '            Catch ex As Exception
    '                clsUser.gettrnUsers.Rollback()
    '                MessageBox.Show(ex.Message)
    '            End Try
    '        Next
    '        '  MsgBox("actualizadook")
    '    Else
    '        ' MsgBox("actualizado")
    '    End If
    'End Sub

    Private Sub ActualizarBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarBDToolStripMenuItem.Click
        'ActualizarBaseDatos()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        Dim frm As New FrmContraseña
        frm.ShowDialog()
    End Sub

    Private Sub CuentaCorrienteResguardoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaCorrienteResguardoToolStripMenuItem.Click
        'Dim frm As New frmAdministrarCuotasusers
        'frm.ShowDialog()
    End Sub

    Private Sub InfomeClientesDeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfomeClientesDeudoresToolStripMenuItem.Click
        Dim frm As New FrmInfClientesDeudoresFiltros
        frm.ShowDialog()
    End Sub

    Private Sub ListadoDeudasFiltroMontoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeudasFiltroMontoToolStripMenuItem.Click
        Dim frm As New FrmInformeDeudasPorMonto
        frm.ShowDialog()
    End Sub

    Private Sub ListadoDeudasFiltrosFechaMontoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeudasFiltrosFechaMontoToolStripMenuItem.Click
        Dim frm As New FrmInformeDeudasPorFechaMonto
        frm.ShowDialog()
    End Sub

   Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        Dim frm As New FrmMailsEnviados()
        frm.Show()
    End Sub

    Private Sub EnviarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarToolStripMenuItem.Click
        Dim frm As New frmEnvioMail
        frm.Show()
    End Sub

    Private Sub TimerMail_Tick(sender As Object, e As EventArgs) Handles TimerMail.Tick
        If Now().ToShortTimeString() > "10:00:00" And Now().ToShortTimeString() < "10:59:00" Then
            EnviodeMailPrueba()
            bgwMail.RunWorkerAsync()
        End If

    End Sub
#Region "Mail Backgorund"
    Private Sub bgwMail_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwMail.DoWork
        EnviodeMail()
    End Sub

    Private Sub EnviodeMail()
        'Dim frm As New frmEnvioMail
        'frm.Show()
        Dim cls As New EnvioMail
        cls.Enviar()
    End Sub
    Private Sub EnviodeMailPrueba()
        'Dim frm As New frmEnvioMail
        'frm.Show()
        Dim cls As New EnvioMail
        'cls.EnviarPrueba()
    End Sub
#End Region

    
    Private Sub ReImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReImprimirToolStripMenuItem.Click
        Dim frm As New FrmReimpresionRecibos
        frm.Show()
    End Sub
End Class