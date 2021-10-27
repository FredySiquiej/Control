<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultas
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
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(203, 63)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(167, 87)
        Me.btnProducto.TabIndex = 0
        Me.btnProducto.Text = "&Cantidad en Stock"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 87)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Pedidos Por Departamento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(203, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 87)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Ingresos Productos por Usuario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(464, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 87)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Peticiones en Estado Pendiente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(12, 340)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(122, 60)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "&Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnProducto)
        Me.Name = "frmConsultas"
        Me.Text = "Consultas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProducto As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnRegresar As Button
End Class
