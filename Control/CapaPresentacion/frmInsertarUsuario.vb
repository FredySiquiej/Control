Public Class frmInsertarUsuario
    Dim dt As New DataTable
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Try

            Dim lc As New LUsuarios()
            lc.insertarUsuario(0, txtNombre.Text, txtUsuario.Text, txtContrasena.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim lc As New LUsuarios()
            lc.eliminarUsuario(txtId.Text, "a", "a", "1")
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmInsertarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()

    End Sub

    Sub Mostrar()
        Try
            Dim func As New DUsuarios
            dt = func.ConsultaUsuario


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            Dim lc As New LUsuarios()
            lc.modificarUsuario(txtId.Text, txtNombre.Text, txtUsuario.Text, txtContrasena.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try



    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        txtId.Text = DataGridView1.Item(0, i).Value()
        txtNombre.Text = DataGridView1.Item(1, i).Value()
        txtUsuario.Text = DataGridView1.Item(2, i).Value()
        txtContrasena.Text = DataGridView1.Item(3, i).Value()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Hide()

    End Sub
End Class