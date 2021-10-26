Public Class frmPeticiones
    Dim dt As New DataTable
    Dim hoy As DateTime = DateTime.Now



    Private Sub frmPeticiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        txtFecha.Text = hoy
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try

            Dim lc As New LPeticiones()

            lc.insertarPeticiones(0, txtDescripcion.Text, Date.Now, "Pendiente", txtidUsuario.Text)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Mostrar()
        Try
            Dim func As New DPeticiones
            dt = func.ConsultaPeticiones


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        Try

            Dim lc As New LPeticiones()
            lc.modificarPeticiones(txtId.Text, txtDescripcion.Text, Date.Now, txtEstado.Text, txtidUsuario.Text)
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
        txtFecha.Text = DataGridView1.Item(2, i).Value()
        txtEstado.Text = DataGridView1.Item(3, i).Value()
        txtidUsuario.Text = DataGridView1.Item(4, i).Value()

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

        Try

            Dim lc As New LPeticiones()
            lc.eliminarPeticiones(txtId.Text, "a", Date.Now, "a", 1)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu.Show()
        Me.Hide()

    End Sub
End Class