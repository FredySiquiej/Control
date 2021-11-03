<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblprod = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lblFormulario = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(115, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        Me.Label1.Visible = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(218, 73)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 1
        Me.txtId.Visible = False
        '
        'lblprod
        '
        Me.lblprod.AutoSize = True
        Me.lblprod.Location = New System.Drawing.Point(418, 127)
        Me.lblprod.Name = "lblprod"
        Me.lblprod.Size = New System.Drawing.Size(0, 17)
        Me.lblprod.TabIndex = 20
        Me.lblprod.Visible = False
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(218, 124)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(180, 24)
        Me.cmbProducto.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Producto"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(218, 227)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Cantidad"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(869, 12)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(242, 22)
        Me.txtFecha.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(768, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Fecha Pedido"
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.Location = New System.Drawing.Point(218, 286)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtIdUsuario.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "idUsuario"
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Location = New System.Drawing.Point(418, 342)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(0, 17)
        Me.lblDepto.TabIndex = 29
        Me.lblDepto.Visible = False
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(218, 171)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(180, 24)
        Me.cmbDepartamento.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Departamento"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(528, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(820, 298)
        Me.DataGridView1.TabIndex = 30
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(678, 610)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(140, 49)
        Me.btnCrear.TabIndex = 31
        Me.btnCrear.Text = "&Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(947, 404)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 49)
        Me.btnModificar.TabIndex = 32
        Me.btnModificar.Text = "&Nuevo"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1153, 459)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 49)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(21, 482)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(140, 49)
        Me.btnRegresar.TabIndex = 34
        Me.btnRegresar.Text = "&Regresar a menu"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(187, 482)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(140, 49)
        Me.btnSolicitar.TabIndex = 35
        Me.btnSolicitar.Text = "&Solicitar Stock"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 60)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Carrito"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(432, 610)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 37
        Me.DataGridView2.Visible = False
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.Location = New System.Drawing.Point(538, 17)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(51, 17)
        Me.lblFormulario.TabIndex = 38
        Me.lblFormulario.Text = "Label6"
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(784, 404)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(140, 49)
        Me.btnCargar.TabIndex = 39
        Me.btnCargar.Text = "&Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1153, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 49)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "&Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.lblFormulario)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSolicitar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblprod)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPedidos"
        Me.Text = "Pedidos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblprod As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDepto As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents lblFormulario As Label
    Friend WithEvents btnCargar As Button
    Friend WithEvents Button2 As Button
End Class
