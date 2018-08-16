<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.ck_visualizador = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.textclave = New System.Windows.Forms.TextBox()
        Me.textusuario = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ck_visualizador
        '
        Me.ck_visualizador.AutoSize = True
        Me.ck_visualizador.BackColor = System.Drawing.Color.Transparent
        Me.ck_visualizador.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ck_visualizador.Location = New System.Drawing.Point(308, 58)
        Me.ck_visualizador.Name = "ck_visualizador"
        Me.ck_visualizador.Size = New System.Drawing.Size(117, 17)
        Me.ck_visualizador.TabIndex = 34
        Me.ck_visualizador.Text = "Mostrar contraseña"
        Me.ck_visualizador.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.DarkBlue
        Me.Cancel.Location = New System.Drawing.Point(261, 262)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(93, 37)
        Me.Cancel.TabIndex = 33
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.YellowGreen
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.DarkBlue
        Me.OK.Location = New System.Drawing.Point(125, 262)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(93, 37)
        Me.OK.TabIndex = 32
        Me.OK.Text = "&Aceptar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'textclave
        '
        Me.textclave.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textclave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textclave.Location = New System.Drawing.Point(308, 32)
        Me.textclave.Name = "textclave"
        Me.textclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textclave.Size = New System.Drawing.Size(131, 20)
        Me.textclave.TabIndex = 31
        '
        'textusuario
        '
        Me.textusuario.BackColor = System.Drawing.Color.DarkTurquoise
        Me.textusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.textusuario.Location = New System.Drawing.Point(308, 9)
        Me.textusuario.Name = "textusuario"
        Me.textusuario.Size = New System.Drawing.Size(131, 20)
        Me.textusuario.TabIndex = 29
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PasswordLabel.Location = New System.Drawing.Point(207, 32)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(131, 23)
        Me.PasswordLabel.TabIndex = 30
        Me.PasswordLabel.Text = "Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.UsernameLabel.Location = New System.Drawing.Point(207, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(131, 23)
        Me.UsernameLabel.TabIndex = 28
        Me.UsernameLabel.Text = "Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(167, 315)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(154, 17)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "  Recordar Contraseña"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(127, 127)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 36
        Me.LogoPictureBox.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Prototipo.My.Resources.Resources.academia
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(472, 353)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ck_visualizador)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.textclave)
        Me.Controls.Add(Me.textusuario)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "frm_login"
        Me.Text = "LOGIN"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ck_visualizador As CheckBox
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents textclave As TextBox
    Friend WithEvents textusuario As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LogoPictureBox As PictureBox
End Class
