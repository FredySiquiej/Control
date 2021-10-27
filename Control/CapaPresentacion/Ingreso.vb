Public Class Ingreso
    Dim dt As New DataTable
    Dim datos As New DataSet
    Dim cmbProd As Integer
    Dim hoy As DateTime = DateTime.Now
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim pregunta As String
        pregunta = MsgBox("Esta Seguro de continuar, no podra modificar la informacion", vbYesNo + vbQuestion, "EXCELeINFO")

        If pregunta = vbYes Then


            Try

                Dim lc As New LIngresar()
                txtFechaIngreso.Text = hoy
                lc.ingresarStock(0, cmbProd, txtCantidad.Text, txtFechaIngreso.Text, txtUsuario.Text)

                Mostrar()
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("corregir informacion")
        End If
    End Sub

    Sub Mostrar()
        Try
            Dim func As New DIngresar
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

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProducto()
        Mostrar()
        txtFechaIngreso.Text = hoy
        cmbProducto.SelectedIndex = -1
        Dim auxx As DUsuarios = New DUsuarios
        txtUsuario.Text = Val(auxx.idValid)

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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim lc As New LIngresar()
            lc.eliminarIngreso(txtId.Text, "1", "1", DateTime.Now, "1")
            Mostrar()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        txtId.Text = DataGridView1.Item(0, i).Value()
        cmbProducto.Text = DataGridView1.Item(1, i).Value()
        txtCantidad.Text = DataGridView1.Item(2, i).Value()
        txtFechaIngreso.Text = DataGridView1.Item(3, i).Value()
        txtUsuario.Text = DataGridView1.Item(4, i).Value()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Para realizar modificaciones comuniquese con el ADMINISTRADOR")
    End Sub


End Class