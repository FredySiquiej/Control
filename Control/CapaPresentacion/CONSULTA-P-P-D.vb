Public Class frmCONSULTA_P_P_D

    Dim dt As New DataTable
    Dim datos As New DataSet
    Public cmbDepto As Integer
    Dim hoy As DateTime = DateTime.Now

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsultas.Show()
        Me.Close()


    End Sub

    Sub Mostrar()
        Try
            Dim func As New DPedidos
            dt = func.ConsulaporDepto(cmbDepto)


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub listarDepartamento()
        Try
            Dim func As New DPedidos
            datos = func.ListarDepartamento


            cmbDepartamento.DataSource = datos.Tables("DEPARTAMENTO")
            cmbDepartamento.DisplayMember = "descripcion"
            cmbDepto = CStr(cmbDepartamento.SelectedValue)



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub frmCONSULTA_P_P_D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarDepartamento()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Mostrar()
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        cmbDepartamento.ValueMember = "idDepartamento"
        cmbDepto = CStr(cmbDepartamento.SelectedValue)

    End Sub
End Class