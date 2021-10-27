<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuAdministrador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnGestionarProductos = New System.Windows.Forms.Button()
        Me.txtUsuarios = New System.Windows.Forms.Button()
        Me.btnDepartamentos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsultas
        '
        Me.btnConsultas.Location = New System.Drawing.Point(418, 250)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(163, 101)
        Me.btnConsultas.TabIndex = 13
        Me.btnConsultas.Text = "&Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnGestionarProductos
        '
        Me.btnGestionarProductos.Location = New System.Drawing.Point(418, 100)
        Me.btnGestionarProductos.Name = "btnGestionarProductos"
        Me.btnGestionarProductos.Size = New System.Drawing.Size(163, 94)
        Me.btnGestionarProductos.TabIndex = 11
        Me.btnGestionarProductos.Text = "Gestionar Productos"
        Me.btnGestionarProductos.UseVisualStyleBackColor = True
        '
        'txtUsuarios
        '
        Me.txtUsuarios.Location = New System.Drawing.Point(219, 100)
        Me.txtUsuarios.Name = "txtUsuarios"
        Me.txtUsuarios.Size = New System.Drawing.Size(163, 94)
        Me.txtUsuarios.TabIndex = 10
        Me.txtUsuarios.Text = "GestionUsuarios"
        Me.txtUsuarios.UseVisualStyleBackColor = True
        '
        'btnDepartamentos
        '
        Me.btnDepartamentos.Location = New System.Drawing.Point(219, 250)
        Me.btnDepartamentos.Name = "btnDepartamentos"
        Me.btnDepartamentos.Size = New System.Drawing.Size(163, 101)
        Me.btnDepartamentos.TabIndex = 12
        Me.btnDepartamentos.Text = "Gestion Departamentos"
        Me.btnDepartamentos.UseVisualStyleBackColor = True
        '
        'frmMenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.btnGestionarProductos)
        Me.Controls.Add(Me.txtUsuarios)
        Me.Controls.Add(Me.btnDepartamentos)
        Me.Name = "frmMenuAdministrador"
        Me.Text = "menuAdministrador"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnGestionarProductos As Button
    Friend WithEvents txtUsuarios As Button
    Friend WithEvents btnDepartamentos As Button
End Class
