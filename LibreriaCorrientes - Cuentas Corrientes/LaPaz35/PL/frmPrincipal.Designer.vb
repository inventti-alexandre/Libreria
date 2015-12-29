<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.CobroDeCuentasCorrientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfomeClientesDeudoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeudasFiltroMontoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeudasFiltrosFechaMontoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeCuotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaCorrienteResguardoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvioDeMailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarBDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerMail = New System.Windows.Forms.Timer(Me.components)
        Me.bgwMail = New System.ComponentModel.BackgroundWorker()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMenu
        '
        Me.msMenu.AutoSize = False
        Me.msMenu.BackColor = System.Drawing.Color.White
        Me.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.msMenu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CobroDeCuentasCorrientesToolStripMenuItem, Me.InformesToolStripMenuItem, Me.ReImprimirToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem, Me.IniciarSesiónToolStripMenuItem, Me.ActualizarBDToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.msMenu.Size = New System.Drawing.Size(1256, 67)
        Me.msMenu.TabIndex = 1
        Me.msMenu.Text = "MenuStrip1"
        '
        'CobroDeCuentasCorrientesToolStripMenuItem
        '
        Me.CobroDeCuentasCorrientesToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.CobroDeCuentasCorrientesToolStripMenuItem.CheckOnClick = True
        Me.CobroDeCuentasCorrientesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CobroDeCuentasCorrientesToolStripMenuItem.Enabled = False
        Me.CobroDeCuentasCorrientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CobroDeCuentasCorrientesToolStripMenuItem.Name = "CobroDeCuentasCorrientesToolStripMenuItem"
        Me.CobroDeCuentasCorrientesToolStripMenuItem.Size = New System.Drawing.Size(264, 63)
        Me.CobroDeCuentasCorrientesToolStripMenuItem.Text = "Cobro de Cuentas Corrientes"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfomeClientesDeudoresToolStripMenuItem, Me.ListadoDeudasFiltroMontoToolStripMenuItem, Me.ListadoDeudasFiltrosFechaMontoToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(96, 63)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'InfomeClientesDeudoresToolStripMenuItem
        '
        Me.InfomeClientesDeudoresToolStripMenuItem.Name = "InfomeClientesDeudoresToolStripMenuItem"
        Me.InfomeClientesDeudoresToolStripMenuItem.Size = New System.Drawing.Size(401, 28)
        Me.InfomeClientesDeudoresToolStripMenuItem.Text = "Listado Deudas - Filtro Fecha"
        '
        'ListadoDeudasFiltroMontoToolStripMenuItem
        '
        Me.ListadoDeudasFiltroMontoToolStripMenuItem.Name = "ListadoDeudasFiltroMontoToolStripMenuItem"
        Me.ListadoDeudasFiltroMontoToolStripMenuItem.Size = New System.Drawing.Size(401, 28)
        Me.ListadoDeudasFiltroMontoToolStripMenuItem.Text = "Listado Deudas - Filtro Monto"
        '
        'ListadoDeudasFiltrosFechaMontoToolStripMenuItem
        '
        Me.ListadoDeudasFiltrosFechaMontoToolStripMenuItem.Name = "ListadoDeudasFiltrosFechaMontoToolStripMenuItem"
        Me.ListadoDeudasFiltrosFechaMontoToolStripMenuItem.Size = New System.Drawing.Size(401, 28)
        Me.ListadoDeudasFiltrosFechaMontoToolStripMenuItem.Text = "Listado Deudas - Filtros Fecha  Monto"
        '
        'ReImprimirToolStripMenuItem
        '
        Me.ReImprimirToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.ReImprimirToolStripMenuItem.Name = "ReImprimirToolStripMenuItem"
        Me.ReImprimirToolStripMenuItem.Size = New System.Drawing.Size(115, 63)
        Me.ReImprimirToolStripMenuItem.Text = "ReImprimir"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.AdministraciónToolStripMenuItem.CheckOnClick = True
        Me.AdministraciónToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeCuotasToolStripMenuItem1, Me.NuevoUsuarioToolStripMenuItem1, Me.CuentaCorrienteResguardoToolStripMenuItem, Me.EnvioDeMailsToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Enabled = False
        Me.AdministraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(149, 63)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'GestiónDeCuotasToolStripMenuItem1
        '
        Me.GestiónDeCuotasToolStripMenuItem1.Name = "GestiónDeCuotasToolStripMenuItem1"
        Me.GestiónDeCuotasToolStripMenuItem1.Size = New System.Drawing.Size(323, 28)
        Me.GestiónDeCuotasToolStripMenuItem1.Text = "Gestión de Cuotas"
        '
        'NuevoUsuarioToolStripMenuItem1
        '
        Me.NuevoUsuarioToolStripMenuItem1.Name = "NuevoUsuarioToolStripMenuItem1"
        Me.NuevoUsuarioToolStripMenuItem1.Size = New System.Drawing.Size(323, 28)
        Me.NuevoUsuarioToolStripMenuItem1.Text = "Nuevo Usuario"
        '
        'CuentaCorrienteResguardoToolStripMenuItem
        '
        Me.CuentaCorrienteResguardoToolStripMenuItem.Name = "CuentaCorrienteResguardoToolStripMenuItem"
        Me.CuentaCorrienteResguardoToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.CuentaCorrienteResguardoToolStripMenuItem.Text = "Cuenta Corriente Resguardo"
        Me.CuentaCorrienteResguardoToolStripMenuItem.Visible = False
        '
        'EnvioDeMailsToolStripMenuItem
        '
        Me.EnvioDeMailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarToolStripMenuItem, Me.HistorialToolStripMenuItem})
        Me.EnvioDeMailsToolStripMenuItem.Name = "EnvioDeMailsToolStripMenuItem"
        Me.EnvioDeMailsToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.EnvioDeMailsToolStripMenuItem.Text = "Envio de Mails"
        '
        'EnviarToolStripMenuItem
        '
        Me.EnviarToolStripMenuItem.Name = "EnviarToolStripMenuItem"
        Me.EnviarToolStripMenuItem.Size = New System.Drawing.Size(156, 28)
        Me.EnviarToolStripMenuItem.Text = "Enviar"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(156, 28)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.CerrarSesiónToolStripMenuItem.Enabled = False
        Me.CerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(133, 63)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.CambiarContraseñaToolStripMenuItem.Enabled = False
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(193, 63)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña"
        '
        'IniciarSesiónToolStripMenuItem
        '
        Me.IniciarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.IniciarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.IniciarSesiónToolStripMenuItem.Name = "IniciarSesiónToolStripMenuItem"
        Me.IniciarSesiónToolStripMenuItem.Size = New System.Drawing.Size(132, 63)
        Me.IniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión"
        '
        'ActualizarBDToolStripMenuItem
        '
        Me.ActualizarBDToolStripMenuItem.Enabled = False
        Me.ActualizarBDToolStripMenuItem.Name = "ActualizarBDToolStripMenuItem"
        Me.ActualizarBDToolStripMenuItem.Size = New System.Drawing.Size(133, 63)
        Me.ActualizarBDToolStripMenuItem.Text = "Actualizar BD"
        Me.ActualizarBDToolStripMenuItem.Visible = False
        '
        'TimerMail
        '
        Me.TimerMail.Enabled = True
        Me.TimerMail.Interval = 300000
        '
        'bgwMail
        '
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1256, 557)
        Me.Controls.Add(Me.msMenu)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmPrincipal"
        Me.Text = "Gestión Cuentas Corrientes - Librería de Corrientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents CobroDeCuentasCorrientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeCuotasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarBDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaCorrienteResguardoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfomeClientesDeudoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeudasFiltroMontoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeudasFiltrosFechaMontoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnvioDeMailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerMail As System.Windows.Forms.Timer
    Friend WithEvents bgwMail As System.ComponentModel.BackgroundWorker
    Friend WithEvents EnviarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
