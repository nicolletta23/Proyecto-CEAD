<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_registro_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro_usuarios))
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(61, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario"
        '
        'cbonombreusuario
        '
        Me.cbonombreusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbonombreusuario.FormattingEnabled = True
        Me.cbonombreusuario.Location = New System.Drawing.Point(190, 81)
        Me.cbonombreusuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbonombreusuario.Name = "cbonombreusuario"
        Me.cbonombreusuario.Size = New System.Drawing.Size(301, 24)
        Me.cbonombreusuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(146, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Roll"
        '
        'cboroll
        '
        Me.cboroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboroll.FormattingEnabled = True
        Me.cboroll.Items.AddRange(New Object() {"seleccione un roll", "Director", "Administrador", "Docente"})
        Me.cboroll.Location = New System.Drawing.Point(192, 121)
        Me.cboroll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboroll.Name = "cboroll"
        Me.cboroll.Size = New System.Drawing.Size(301, 24)
        Me.cboroll.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(63, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(39, 189)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingrese contraseña:"
        '
        'textingreseusuario
        '
        Me.textingreseusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.textingreseusuario.Location = New System.Drawing.Point(192, 153)
        Me.textingreseusuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textingreseusuario.Name = "textingreseusuario"
        Me.textingreseusuario.Size = New System.Drawing.Size(208, 22)
        Me.textingreseusuario.TabIndex = 6
        '
        'textcontraseña
        '
        Me.textcontraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.textcontraseña.Location = New System.Drawing.Point(192, 183)
        Me.textcontraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textcontraseña.Name = "textcontraseña"
        Me.textcontraseña.Size = New System.Drawing.Size(208, 22)
        Me.textcontraseña.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(30, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Confirme contraseña:"
        '
        'textconfirmecontraseña
        '
        Me.textconfirmecontraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.textconfirmecontraseña.Location = New System.Drawing.Point(192, 213)
        Me.textconfirmecontraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textconfirmecontraseña.Name = "textconfirmecontraseña"
        Me.textconfirmecontraseña.Size = New System.Drawing.Size(208, 22)
        Me.textconfirmecontraseña.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(33, 286)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 28)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(192, 286)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(112, 28)
        Me.btnmodificar.TabIndex = 11
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(353, 286)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(112, 28)
        Me.btnlimpiar.TabIndex = 13
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(119, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(301, 24)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Formulario de Registro Usuario"
        '
        'frm_registro_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(537, 338)
        Me.Controls.Add(Me.Label6)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_registro_usuarios"
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
    Friend WithEvents Label6 As Label
End Class
