Public Class frmMenu

    Dim datos As New DataSet
    Dim cmbUs As Integer
    Dim hoy As DateTime = DateTime.Now


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        frmInsertarUsuario.Show()
        Me.Hide()


    End Sub

    Private Sub txtInventario_Click(sender As Object, e As EventArgs) Handles btnGestionarProductos.Click
        frmGestionarProductos.Show()
        Me.Hide()




    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Ingreso.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPedidos.Click
        frmPedidos.Show()
        Me.Hide()

    End Sub

    Private Sub btnDepartamentos_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        frmDepartamento.Show()
        Me.Hide()

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        frmSolicitarStock.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDevoluciones.Click
        frmDevoluciones.Show()
        Me.Hide()

    End Sub



    Private Sub btnPeticiones_Click(sender As Object, e As EventArgs) Handles btnPeticiones.Click
        frmPeticiones.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmValidacionIngreso.Show()
        Me.Hide()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        frmValidacionIngreso.Show()
        frmValidacionIngreso.cmbUsuarios.SelectedIndex = -1
        frmValidacionIngreso.txtContrasena.Text = ""

        Me.Hide()




    End Sub
End Class