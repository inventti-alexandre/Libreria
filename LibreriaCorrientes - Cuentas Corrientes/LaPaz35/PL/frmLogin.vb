Public Class frmLogin
    Dim clsUsuarios As New clsUsuariosUsers

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargarcombos()
    End Sub

    Private Sub Cargarcombos()
        ' Cargar users
        clsUsuarios.FillListUsers()
        With cbxUsuarios
            .DisplayMember = "usuario"
            .ValueMember = "id"
        End With
        cbxUsuarios.DataSource = clsUsuarios.LstUsers
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If cbxUsuarios.SelectedValue <> 0 Then
            clsUsuarios.FillUserById(cbxUsuarios.SelectedValue)
            If clsUsuarios.LstUsers.Count > 0 Then
                If clsUsuarios.LstUsers.First.password = txtContrasenia.Text Then

                    clsVariableSesion.Instancia.Usuario.OperadorId = clsUsuarios.LstUsers.First.lapazUser
                    clsVariableSesion.Instancia.Usuario.SucursalId = clsUsuarios.LstUsers.First.Sucursal
                    clsVariableSesion.Instancia.Rol.id = clsUsuarios.LstUsers.First.rol

                    clsVariableSesionUsers.Instancia.Usuario.id = cbxUsuarios.SelectedValue

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Dim frm As New frmMensajes("Los datos ingresados no son correctos, vuelva a intentarlo")
                    frm.ShowDialog()
                    txtContrasenia.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub txtContrasenia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasenia.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnIngresar_Click(Nothing, Nothing)
        End If
    End Sub
End Class