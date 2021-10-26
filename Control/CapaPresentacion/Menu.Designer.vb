<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.btnGestionUsuarios = New System.Windows.Forms.Button()
        Me.btnGestionarProductos = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.btnDepartamentos = New System.Windows.Forms.Button()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.btnDevoluciones = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnPeticiones = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGestionUsuarios
        '
        Me.btnGestionUsuarios.Location = New System.Drawing.Point(853, 103)
        Me.btnGestionUsuarios.Name = "btnGestionUsuarios"
        Me.btnGestionUsuarios.Size = New System.Drawing.Size(163, 94)
        Me.btnGestionUsuarios.TabIndex = 0
        Me.btnGestionUsuarios.Text = "GestionUsuarios"
        Me.btnGestionUsuarios.UseVisualStyleBackColor = True
        '
        'btnGestionarProductos
        '
        Me.btnGestionarProductos.Location = New System.Drawing.Point(1052, 103)
        Me.btnGestionarProductos.Name = "btnGestionarProductos"
        Me.btnGestionarProductos.Size = New System.Drawing.Size(163, 94)
        Me.btnGestionarProductos.TabIndex = 1
        Me.btnGestionarProductos.Text = "Gestionar Productos"
        Me.btnGestionarProductos.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(391, 100)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(163, 101)
        Me.btnIngreso.TabIndex = 2
        Me.btnIngreso.Text = "Ingresar Productos"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnPedidos
        '
        Me.btnPedidos.Location = New System.Drawing.Point(639, 100)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(163, 101)
        Me.btnPedidos.TabIndex = 3
        Me.btnPedidos.Text = "Hacer Pedidos"
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'btnDepartamentos
        '
        Me.btnDepartamentos.Location = New System.Drawing.Point(853, 253)
        Me.btnDepartamentos.Name = "btnDepartamentos"
        Me.btnDepartamentos.Size = New System.Drawing.Size(163, 101)
        Me.btnDepartamentos.TabIndex = 4
        Me.btnDepartamentos.Text = "Gestion Departamentos"
        Me.btnDepartamentos.UseVisualStyleBackColor = True
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(391, 253)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(163, 101)
        Me.btnSolicitar.TabIndex = 5
        Me.btnSolicitar.Text = "Solicitar Stock"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'btnDevoluciones
        '
        Me.btnDevoluciones.Location = New System.Drawing.Point(639, 253)
        Me.btnDevoluciones.Name = "btnDevoluciones"
        Me.btnDevoluciones.Size = New System.Drawing.Size(163, 101)
        Me.btnDevoluciones.TabIndex = 6
        Me.btnDevoluciones.Text = "Devolucion por Defectuoso"
        Me.btnDevoluciones.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.btnConsultas)
        Me.GroupBox1.Controls.Add(Me.btnGestionarProductos)
        Me.GroupBox1.Controls.Add(Me.btnDevoluciones)
        Me.GroupBox1.Controls.Add(Me.btnPeticiones)
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.btnGestionUsuarios)
        Me.GroupBox1.Controls.Add(Me.btnIngreso)
        Me.GroupBox1.Controls.Add(Me.btnPedidos)
        Me.GroupBox1.Controls.Add(Me.btnDepartamentos)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1243, 598)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnConsultas
        '
        Me.btnConsultas.Location = New System.Drawing.Point(1052, 253)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(163, 101)
        Me.btnConsultas.TabIndex = 9
        Me.btnConsultas.Text = "&Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnPeticiones
        '
        Me.btnPeticiones.Location = New System.Drawing.Point(100, 203)
        Me.btnPeticiones.Name = "btnPeticiones"
        Me.btnPeticiones.Size = New System.Drawing.Size(163, 101)
        Me.btnPeticiones.TabIndex = 8
        Me.btnPeticiones.Text = "Peticiones a Administrador"
        Me.btnPeticiones.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 600)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGestionUsuarios As Button
    Friend WithEvents btnGestionarProductos As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnPedidos As Button
    Friend WithEvents btnDepartamentos As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents btnDevoluciones As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPeticiones As Button
    Friend WithEvents btnConsultas As Button
End Class
