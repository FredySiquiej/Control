Public Class frmCONSULTA_P_E_E_P


    Dim dt As New DataTable
    Dim datos As New DataSet
    Public cmbDepto As Integer
    Dim hoy As DateTime = DateTime.Now

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsultas.Show()
        Me.Close()


    End Sub

    Sub Mostrar(estado As String)
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



    Private Sub frmCONSULTA_P_E_E_P_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmbEstado.Items.Add("Pendiente")
        cmbEstado.Items.Add("Realizado")

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim aux As String
        If cmbEstado.SelectedIndex = 0 Then
            aux = "Pendiente"
        Else
            aux = "Realizado"

        End If


        Mostrar(aux)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmResolverEstadoPendiente.Show()
        Me.Close()




    End Sub
End Class