Public Class frmDevoluciones
    Dim dt As New DataTable
    Dim hoy As DateTime = DateTime.Now

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmPedidos.Show()

        Me.Hide()

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Try

            Dim lc As New LDevoluciones()

            lc.insertarDefectuoso(0, txtIdPedido.Text, txtDescripcion.Text, txtCantidad.Text, Date.Now, txtIdUsuario.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub


    Sub Mostrar()
        Try
            Dim func As New DDevoluciones
            dt = func.ConsultaDefectuoso


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

            Dim lc As New LDevoluciones()
            lc.modificarDefectuoso(txtId.Text, txtIdPedido.Text, txtDescripcion.Text, txtCantidad.Text, txtFecha.Text, txtIdUsuario.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            Dim lc As New LDevoluciones()
            lc.eliminarDefectuoso(txtId.Text, 1, "a", 1, DateTime.Now, 1)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub frmDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        txtFecha.Text = hoy
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        txtId.Text = DataGridView1.Item(0, i).Value()
        txtIdPedido.Text = DataGridView1.Item(1, i).Value()
        txtDescripcion.Text = DataGridView1.Item(2, i).Value()
        txtCantidad.Text = DataGridView1.Item(3, i).Value()
        txtFecha.Text = DataGridView1.Item(4, i).Value()
        txtIdUsuario.Text = DataGridView1.Item(5, i).Value()

    End Sub
End Class