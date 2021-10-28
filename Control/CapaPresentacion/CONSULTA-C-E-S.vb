Public Class frmCONSULTA_C_E_S
    Dim dt As New DataTable
    Dim datos As New DataSet
    Public cmbProd As Integer
    Dim hoy As DateTime = DateTime.Now

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsultas.Show()
        Me.Close()


    End Sub

    Sub Mostrar()
        Try
            Dim func As New DProductos
            dt = func.ConsulaStock(cmbProd)


            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub listarProducto()
        Try
            Dim func As New DIngresar
            datos = func.ListarProducto


            cmbProducto.DataSource = datos.Tables("PRODUCTOS")
            cmbProducto.DisplayMember = "descripcion"
            cmbProd = CStr(cmbProducto.SelectedValue)


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub frmCONSULTA_C_E_S_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProducto()

        cmbProducto.SelectedIndex = -1
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        cmbProducto.ValueMember = "idproducto"
        cmbProd = CStr(cmbProducto.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Mostrar()

    End Sub
End Class