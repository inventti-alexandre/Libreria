Public Class FrmContraseña
    Dim clsUsuarios As New clsUsuariosUsers

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CambiarContraseña()
    End Sub


    Private Sub CambiarContraseña()
        clsUsuarios.FillUserById(clsVariableSesionUsers.Instancia.Usuario.id)
        If clsUsuarios.LstUsers.First.password = txtActual.Text Then
            '   MsgBox("contraseña correcta")
            If txtNueva.Text = txtNueva2.Text Then
                clsUsuarios.User = clsUsuarios.LstUsers.First
                clsUsuarios.User.password = txtNueva.Text

                Try
                    clsUsuarios.IniciarTrnUsers()
                    clsUsuarios.Actualizaruser()
                    clsUsuarios.gettrnUsers.Commit()

                    Dim frm As New frmMensajes("Contraseña cambiada correctamente")
                    frm.ShowDialog()
                    Me.Close()
                Catch ex As Exception
                    clsUsuarios.gettrnUsers.Rollback()
                    MessageBox.Show(ex.Message)
                End Try
            Else
                Dim frm As New frmMensajes("Las nuevas contraseñas ingresadas no coinciden")
                frm.ShowDialog()
            End If
        Else
            Dim frm As New frmMensajes("La contraseña actual no es correcta")
            frm.ShowDialog()
        End If
    End Sub
End Class