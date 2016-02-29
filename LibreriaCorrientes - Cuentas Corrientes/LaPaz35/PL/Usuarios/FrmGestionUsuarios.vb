Public Class FrmGestionUsuarios
    Dim clsOperadores As New clsUsuariosLaPaz
    Dim clsUsuarios As New clsUsuariosUsers

    Private Sub FrmGestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos
    End Sub

    Private Sub CargarCombos()
        ' Cargar Operadores
        clsOperadores.FillListOperadorSucursalBySuc(27)
        With cbxUsuariosLaPaz
            .DisplayMember = "vOperador"
            .ValueMember = "OperadorId"
        End With
        cbxUsuariosLaPaz.DataSource = clsOperadores.LstOperadoresSucursal

        ' Cargar Roles
        clsUsuarios.FillListRoles()
        With cbxFunciones
            .DisplayMember = "rol"
            .ValueMember = "id"
        End With
        cbxFunciones.DataSource = clsUsuarios.LstRoles

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GenerarUsuario()
    End Sub

    Public Sub GenerarUsuario()
        clsUsuarios.User = New users
        With clsUsuarios.User
            .usuario = cbxUsuariosLaPaz.Text
            .password = txtContrasenia.Text
            .rol = cbxFunciones.SelectedValue
            .lapazUser = cbxUsuariosLaPaz.SelectedValue
            clsOperadores.FillListOperadorSucursalByOperador(.lapazUser)
            .Sucursal = clsOperadores.LstOperadoresSucursal.First.SucursalId
        End With

        Try
            clsUsuarios.IniciarTrnUsers()
            clsUsuarios.GuardarUser()
            clsUsuarios.gettrnUsers.Commit()

            MsgBox("Usuario Creado Correctamente")

        Catch ex As Exception
            clsUsuarios.gettrnUsers.Rollback()
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class