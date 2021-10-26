Public Class frmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtUsuarios.Click
        frmInsertarUsuario.Show()
        Me.Hide()


    End Sub

    Private Sub txtInventario_Click(sender As Object, e As EventArgs) Handles txtInventario.Click
        frmGestionarProductos.Show()
        Me.Hide()




    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Ingreso.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmDevoluciones.Show()
        Me.Hide()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnPeticiones_Click(sender As Object, e As EventArgs) Handles btnPeticiones.Click
        frmPeticiones.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmValidacionIngreso.Show()
        Me.Hide()

    End Sub
End Class