Public Class frmResolverEstadoPendiente
    Dim dt As New DataTable
    Dim hoy As DateTime = DateTime.Now



    Sub Mostrar()
        Dim estado As String

        estado = "Pendiente"
        Try
            Dim func As New DPeticiones
            dt = func.ConsultaEstadosPendietes(estado)


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub ResolverEstadoPendiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        txtFecha.Text = hoy

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Dim estado As String
        estado = "Realizado"
        Try

            Dim lc As New LPeticiones()
            lc.modificarPeticiones(txtId.Text, txtDescripcion.Text, Date.Now, estado, txtidUsuario.Text)
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

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmCONSULTA_P_E_E_P.Show()
        Me.Close()

    End Sub
End Class