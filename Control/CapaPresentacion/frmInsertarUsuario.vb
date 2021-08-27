Public Class frmInsertarUsuario
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Try

            Dim lc As New LUsuarios()
            lc.insertarUsuario(txtNombre.Text, txtUsuario.Text, txtContrasena.Text)

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try


    End Sub
End Class