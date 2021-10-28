Public Class frmGestionarProductos
    Dim dt As New DataTable
    Dim hoy As DateTime = DateTime.Now

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Try

            Dim lc As New LProducto()

            lc.insertarProducto(0, txtDescripcion.Text, txtMarca.Text, txtLote.Text, Date.Now, txtStock.Text, txtUsuario.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub


    Sub Mostrar()
        Try
            Dim func As New DProductos
            dt = func.ConsultaProducto


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim lc As New LProducto()
            lc.eliminarProducto(txtId.Text, "a", "a", "1", DateTime.Now, "0", "1")
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub frmGestionarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        txtFechaIngreso.Text = hoy
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        txtId.Text = DataGridView1.Item(0, i).Value()
        txtDescripcion.Text = DataGridView1.Item(1, i).Value()
        txtMarca.Text = DataGridView1.Item(2, i).Value()
        txtLote.Text = DataGridView1.Item(3, i).Value()
        txtFechaIngreso.Text = DataGridView1.Item(4, i).Value()
        txtStock.Text = DataGridView1.Item(5, i).Value()
        txtUsuario.Text = DataGridView1.Item(6, i).Value()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            Dim lc As New LProducto()
            lc.modificarProducto(txtId.Text, txtDescripcion.Text, txtMarca.Text, txtLote.Text, txtFechaIngreso.Text, txtStock.Text, txtUsuario.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        frmMenu.Show()
        Me.Close()







    End Sub
End Class
