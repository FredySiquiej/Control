<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONSULTA_P_E_E_P
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
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(1015, 14)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(94, 32)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(549, 67)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 32)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(213, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(306, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(114, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(966, 293)
        Me.DataGridView1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1015, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCONSULTA_P_E_E_P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmCONSULTA_P_E_E_P"
        Me.Text = "CONSULTA_P_E_E_P"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
End Class
