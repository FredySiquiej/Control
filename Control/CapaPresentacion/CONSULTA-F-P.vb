Public Class FRMCONSULTA_F_P

    Dim dt As New DataTable


    Private Sub CONSULTA_F_P_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Sub Mostrar()
        Try
            Dim func As New DPedidos()


            dt = func.ConsulaFormulario(txtFormulario.Text)


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mostrar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsultas.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtFormulario.Text = ""
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub
End Class