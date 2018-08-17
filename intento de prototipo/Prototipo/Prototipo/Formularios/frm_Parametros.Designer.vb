<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Parametros
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Genero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(81, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Estado Civil"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(81, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Observaciones de Calificaciones"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(81, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 42)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Periodo  Academico"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(400, 149)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 45)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Estado de Pago"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(400, 93)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 50)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Roles"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(400, 40)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(142, 47)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Estatus"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(400, 200)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(142, 39)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Departamentos"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(245, 301)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(160, 39)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Duracion de Clases"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'frm_Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 497)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_Parametros"
        Me.Text = "Administracion de Parametros"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
