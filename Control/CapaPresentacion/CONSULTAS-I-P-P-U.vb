﻿Public Class frmCONSULTAS_I_P_P_U

    Dim dt As New DataTable
    Dim datos As New DataSet
    Public cmbUs As Integer
    Dim hoy As DateTime = DateTime.Now

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        frmConsultas.Show()
        Me.Close()


    End Sub

    Sub Mostrar()
        Try
            Dim func As New DIngresar
            dt = func.ConsulaporUsuario(cmbUs)


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Sub listarUsuario()
        Try
            Dim func As New DPedidos
            datos = func.ListarUsuario


            cmbUsuario.DataSource = datos.Tables("USUARIOS")
            cmbUsuario.DisplayMember = "nombres"
            cmbUs = CStr(cmbUsuario.SelectedValue)



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub












    Private Sub frmCONSULTAS_I_P_P_U_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUsuario()
        cmbUsuario.SelectedIndex = -1

    End Sub

    Private Sub cmbUsuario_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedValueChanged
        cmbUsuario.ValueMember = "idUsuario"
        cmbUs = CStr(cmbUsuario.SelectedValue)
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Mostrar()
    End Sub
End Class