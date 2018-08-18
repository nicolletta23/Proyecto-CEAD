<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro_usuarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbonombreusuario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboroll = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textingreseusuario = New System.Windows.Forms.TextBox()
        Me.textcontraseña = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textconfirmecontraseña = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.cbopersonal = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario"
        '
        'cbonombreusuario
        '
        Me.cbonombreusuario.FormattingEnabled = True
        Me.cbonombreusuario.Location = New System.Drawing.Point(182, 40)
        Me.cbonombreusuario.Name = "cbonombreusuario"
        Me.cbonombreusuario.Size = New System.Drawing.Size(202, 21)
        Me.cbonombreusuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Roll"
        '
        'cboroll
        '
        Me.cboroll.FormattingEnabled = True
        Me.cboroll.Items.AddRange(New Object() {"seleccione un roll", "Director", "Administrador", "Docente"})
        Me.cboroll.Location = New System.Drawing.Point(182, 93)
        Me.cboroll.Name = "cboroll"
        Me.cboroll.Size = New System.Drawing.Size(202, 21)
        Me.cboroll.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingrese contraseña:"
        '
        'textingreseusuario
        '
        Me.textingreseusuario.Location = New System.Drawing.Point(191, 146)
        Me.textingreseusuario.Name = "textingreseusuario"
        Me.textingreseusuario.Size = New System.Drawing.Size(140, 20)
        Me.textingreseusuario.TabIndex = 6
        '
        'textcontraseña
        '
        Me.textcontraseña.Location = New System.Drawing.Point(191, 194)
        Me.textcontraseña.Name = "textcontraseña"
        Me.textcontraseña.Size = New System.Drawing.Size(140, 20)
        Me.textcontraseña.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Confirme contraseña:"
        '
        'textconfirmecontraseña
        '
        Me.textconfirmecontraseña.Location = New System.Drawing.Point(191, 228)
        Me.textconfirmecontraseña.Name = "textconfirmecontraseña"
        Me.textconfirmecontraseña.Size = New System.Drawing.Size(140, 20)
        Me.textconfirmecontraseña.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(61, 297)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(164, 297)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 11
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(345, 297)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 13
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'cbopersonal
        '
        Me.cbopersonal.FormattingEnabled = True
        Me.cbopersonal.Location = New System.Drawing.Point(182, 67)
        Me.cbopersonal.Name = "cbopersonal"
        Me.cbopersonal.Size = New System.Drawing.Size(202, 21)
        Me.cbopersonal.TabIndex = 14
        '
        'frm_registro_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 354)
        Me.Controls.Add(Me.cbopersonal)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.textconfirmecontraseña)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textcontraseña)
        Me.Controls.Add(Me.textingreseusuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboroll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbonombreusuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_registro_usuarios"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbonombreusuario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboroll As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents textingreseusuario As TextBox
    Friend WithEvents textcontraseña As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textconfirmecontraseña As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents cbopersonal As ComboBox
End Class
