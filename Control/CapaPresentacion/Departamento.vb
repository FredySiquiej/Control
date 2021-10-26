
Public Class frmDepartamento
    Dim dt As New DataTable


    Private Sub Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu.Show()
        Me.Hide()


    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Try

            Dim lc As New LDepartamento()

            lc.insertarDepartamento(0, txtDescripcion.Text, txtJefe.Text, txtTelefono.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub




    Sub Mostrar()
        Try
            Dim func As New DDepartamento
            dt = func.ConsultaDepartamento


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

            Dim lc As New LDepartamento()
            lc.modificarDepartamento(txtId.Text, txtDescripcion.Text, txtJefe.Text, txtTelefono.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        txtId.Text = DataGridView1.Item(0, i).Value()
        txtDescripcion.Text = DataGridView1.Item(1, i).Value()
        txtJefe.Text = DataGridView1.Item(2, i).Value()
        txtTelefono.Text = DataGridView1.Item(3, i).Value()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim lc As New LDepartamento()
            lc.eliminarDepartamento(txtId.Text, "a", "a", 1)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Sub
End Class