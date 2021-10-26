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
        Me.txtUsuarios = New System.Windows.Forms.Button()
        Me.txtInventario = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDepartamentos = New System.Windows.Forms.Button()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'txtUsuarios
        '
        Me.txtUsuarios.Location = New System.Drawing.Point(132, 81)
        Me.txtUsuarios.Name = "txtUsuarios"
        Me.txtUsuarios.Size = New System.Drawing.Size(163, 94)
        Me.txtUsuarios.TabIndex = 0
        Me.txtUsuarios.Text = "GestionUsuarios"
        Me.txtUsuarios.UseVisualStyleBackColor = True
        '
        'txtInventario
        '
        Me.txtInventario.Location = New System.Drawing.Point(432, 81)
        Me.txtInventario.Name = "txtInventario"
        Me.txtInventario.Size = New System.Drawing.Size(163, 94)
        Me.txtInventario.TabIndex = 1
        Me.txtInventario.Text = "Gestionar Productos"
        Me.txtInventario.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(132, 234)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(163, 101)
        Me.btnIngreso.TabIndex = 2
        Me.btnIngreso.Text = "Ingreso a Bodega"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 101)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pedidos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDepartamentos
        '
        Me.btnDepartamentos.Location = New System.Drawing.Point(132, 374)
        Me.btnDepartamentos.Name = "btnDepartamentos"
        Me.btnDepartamentos.Size = New System.Drawing.Size(163, 101)
        Me.btnDepartamentos.TabIndex = 4
        Me.btnDepartamentos.Text = "Gestion Departamentos"
        Me.btnDepartamentos.UseVisualStyleBackColor = True
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(432, 374)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(163, 101)
        Me.btnSolicitar.TabIndex = 5
        Me.btnSolicitar.Text = "Solicitar Stock"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(678, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 101)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Devolucion por Defectuoso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 598)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSolicitar)
        Me.Controls.Add(Me.btnDepartamentos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.txtInventario)
        Me.Controls.Add(Me.txtUsuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsuarios As Button
    Friend WithEvents txtInventario As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDepartamentos As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
