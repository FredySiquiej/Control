Public Class frmValidacionIngreso
    Dim datos As New DataSet
    Dim cmbUs As Integer
    Dim hoy As DateTime = DateTime.Now



    Private Sub frmValidacionIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUsuario()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try

            Dim lc As New LUsuarios()
            lc.validarUsuario(0, cmbUsuarios.Text, "a", txtContrasena.Text)


        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Sub listarUsuario()
        Try
            Dim func As New DUsuarios
            datos = func.ListarUsuario


            cmbUsuarios.DataSource = datos.Tables("USUARIOS")
            cmbUsuarios.DisplayMember = "NOMBRES"
            cmbUs = CStr(cmbUsuarios.SelectedValue)


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cmbUsuarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUsuarios.SelectedValueChanged
        cmbUsuarios.ValueMember = "idUsuario"
        cmbUs = CStr(cmbUsuarios.SelectedValue)

    End Sub
End Class