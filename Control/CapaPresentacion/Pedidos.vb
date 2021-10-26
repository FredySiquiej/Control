Public Class frmPedidos
    Dim dt As New DataTable
    Dim datos As New DataSet
    Dim cmbProd As Integer
    Dim cmbDepto As Integer
    Dim hoy As DateTime = DateTime.Now

    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProducto()
        listarDepartamento()
        txtFecha.Text = hoy
        Mostrar()
        cmbProducto.SelectedIndex = -1
        cmbDepartamento.SelectedIndex = -1





    End Sub


    Sub Mostrar()
        Try
            Dim func As New DPedidos
            dt = func.ConsultaPedido


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
            Dim func As New DPedidos
            datos = func.ListarProducto


            cmbProducto.DataSource = datos.Tables("PRODUCTOS")
            cmbProducto.DisplayMember = "descripcion"
            cmbProd = CStr(cmbProducto.SelectedValue)



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

    Private Sub cmbProducto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedValueChanged
        cmbProducto.ValueMember = "idproducto"
        cmbProd = CStr(cmbProducto.SelectedValue)
        lblprod.Text = cmbProd
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu.Show()
        Me.Hide()

    End Sub

    Private Sub cmbDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedValueChanged
        cmbDepartamento.ValueMember = "idDepartamento"
        cmbDepto = CStr(cmbDepartamento.SelectedValue)
        lblDepto.Text = cmbDepto
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        txtId.Text = DataGridView1.Item(0, i).Value()
        cmbProducto.Text = DataGridView1.Item(1, i).Value()
        txtCantidad.Text = DataGridView1.Item(2, i).Value()
        txtFecha.Text = DataGridView1.Item(3, i).Value()
        txtIdUsuario.Text = DataGridView1.Item(4, i).Value()
        cmbDepartamento.Text = DataGridView1.Item(5, i).Value()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim pregunta As String
        pregunta = MsgBox("Esta Seguro de continuar", vbYesNo + vbQuestion, "EXCELeINFO")

        If pregunta = vbYes Then


            Try

                Dim lc As New LPedidos()
                txtFecha.Text = hoy
                lc.insertarPedido(0, cmbProd, txtCantidad.Text, txtFecha.Text, txtIdUsuario.Text, cmbDepto)
                Mostrar()
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("corregir informacion")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Para realizar modificaciones comuniquese con el ADMINISTRADOR")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim lc As New LPedidos()
            lc.eliminarPedido(txtId.Text, 1, 1, DateTime.Now, 1, 1)
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub
End Class