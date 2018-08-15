<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registro_Personal
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
        Me.textidentidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textsegundoapellido = New System.Windows.Forms.TextBox()
        Me.textsegundonombre = New System.Windows.Forms.TextBox()
        Me.textprimerapellido = New System.Windows.Forms.TextBox()
        Me.textprimernombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.texttelefono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textemail = New System.Windows.Forms.TextBox()
        Me.rtbdireccion = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radmasculino = New System.Windows.Forms.RadioButton()
        Me.radfemenino = New System.Windows.Forms.RadioButton()
        Me.cboestadocivil = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbodepartamento = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textidentidad
        '
        Me.textidentidad.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textidentidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textidentidad.Location = New System.Drawing.Point(202, 168)
        Me.textidentidad.Name = "textidentidad"
        Me.textidentidad.Size = New System.Drawing.Size(177, 20)
        Me.textidentidad.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Número de Identidad:"
        '
        'textsegundoapellido
        '
        Me.textsegundoapellido.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textsegundoapellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textsegundoapellido.Location = New System.Drawing.Point(455, 115)
        Me.textsegundoapellido.Name = "textsegundoapellido"
        Me.textsegundoapellido.Size = New System.Drawing.Size(148, 20)
        Me.textsegundoapellido.TabIndex = 48
        '
        'textsegundonombre
        '
        Me.textsegundonombre.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textsegundonombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textsegundonombre.Location = New System.Drawing.Point(455, 68)
        Me.textsegundonombre.Name = "textsegundonombre"
        Me.textsegundonombre.Size = New System.Drawing.Size(148, 20)
        Me.textsegundonombre.TabIndex = 47
        '
        'textprimerapellido
        '
        Me.textprimerapellido.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textprimerapellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textprimerapellido.Location = New System.Drawing.Point(168, 110)
        Me.textprimerapellido.Name = "textprimerapellido"
        Me.textprimerapellido.Size = New System.Drawing.Size(148, 20)
        Me.textprimerapellido.TabIndex = 46
        '
        'textprimernombre
        '
        Me.textprimernombre.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textprimernombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textprimernombre.Location = New System.Drawing.Point(168, 68)
        Me.textprimernombre.Name = "textprimernombre"
        Me.textprimernombre.Size = New System.Drawing.Size(148, 20)
        Me.textprimernombre.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Segundo Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Primer Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Segundo Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Primer Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(152, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Formulario de Registro de Personal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(57, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Telefono:"
        '
        'texttelefono
        '
        Me.texttelefono.BackColor = System.Drawing.Color.DarkTurquoise
        Me.texttelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.texttelefono.Location = New System.Drawing.Point(139, 203)
        Me.texttelefono.Name = "texttelefono"
        Me.texttelefono.Size = New System.Drawing.Size(150, 20)
        Me.texttelefono.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(329, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Email"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textemail
        '
        Me.textemail.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textemail.Location = New System.Drawing.Point(391, 208)
        Me.textemail.Name = "textemail"
        Me.textemail.Size = New System.Drawing.Size(212, 20)
        Me.textemail.TabIndex = 56
        '
        'rtbdireccion
        '
        Me.rtbdireccion.Location = New System.Drawing.Point(139, 390)
        Me.rtbdireccion.Name = "rtbdireccion"
        Me.rtbdireccion.Size = New System.Drawing.Size(435, 70)
        Me.rtbdireccion.TabIndex = 58
        Me.rtbdireccion.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(57, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 15)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Estado civil:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radmasculino)
        Me.GroupBox1.Controls.Add(Me.radfemenino)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 67)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero"
        '
        'radmasculino
        '
        Me.radmasculino.AutoSize = True
        Me.radmasculino.Location = New System.Drawing.Point(131, 28)
        Me.radmasculino.Name = "radmasculino"
        Me.radmasculino.Size = New System.Drawing.Size(73, 17)
        Me.radmasculino.TabIndex = 1
        Me.radmasculino.TabStop = True
        Me.radmasculino.Text = "Masculino"
        Me.radmasculino.UseVisualStyleBackColor = True
        '
        'radfemenino
        '
        Me.radfemenino.AutoSize = True
        Me.radfemenino.Location = New System.Drawing.Point(19, 28)
        Me.radfemenino.Name = "radfemenino"
        Me.radfemenino.Size = New System.Drawing.Size(71, 17)
        Me.radfemenino.TabIndex = 0
        Me.radfemenino.TabStop = True
        Me.radfemenino.Text = "Femenino"
        Me.radfemenino.UseVisualStyleBackColor = True
        '
        'cboestadocivil
        '
        Me.cboestadocivil.FormattingEnabled = True
        Me.cboestadocivil.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado", "Union Libre"})
        Me.cboestadocivil.Location = New System.Drawing.Point(156, 340)
        Me.cboestadocivil.Name = "cboestadocivil"
        Me.cboestadocivil.Size = New System.Drawing.Size(121, 21)
        Me.cboestadocivil.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(329, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 15)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Departamento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbodepartamento
        '
        Me.cbodepartamento.FormattingEnabled = True
        Me.cbodepartamento.Items.AddRange(New Object() {"Seleccione...", "Direccion", "Administracion", "Docencia"})
        Me.cbodepartamento.Location = New System.Drawing.Point(455, 271)
        Me.cbodepartamento.Name = "cbodepartamento"
        Me.cbodepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbodepartamento.TabIndex = 63
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(178, 489)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 29)
        Me.btnAgregar.TabIndex = 64
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(313, 489)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 29)
        Me.btnCancelar.TabIndex = 65
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frm_registro_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(712, 539)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cbodepartamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboestadocivil)
        Me.Controls.Add(Me.rtbdireccion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.textemail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.texttelefono)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.textidentidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textsegundoapellido)
        Me.Controls.Add(Me.textsegundonombre)
        Me.Controls.Add(Me.textprimerapellido)
        Me.Controls.Add(Me.textprimernombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_registro_Personal"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textidentidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textsegundoapellido As TextBox
    Friend WithEvents textsegundonombre As TextBox
    Friend WithEvents textprimerapellido As TextBox
    Friend WithEvents textprimernombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents texttelefono As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents textemail As TextBox
    Friend WithEvents rtbdireccion As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radmasculino As RadioButton
    Friend WithEvents radfemenino As RadioButton
    Friend WithEvents cboestadocivil As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbodepartamento As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
End Class
