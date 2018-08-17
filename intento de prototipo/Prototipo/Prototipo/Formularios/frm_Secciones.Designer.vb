<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Secciones
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
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.cb_periodo = New System.Windows.Forms.ComboBox()
        Me.txt_idseccion = New System.Windows.Forms.TextBox()
        Me.txt_seccion = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.cb_maestro = New System.Windows.Forms.ComboBox()
        Me.cb_clase = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_aula = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(593, 472)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 35
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(328, 472)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 34
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(101, 472)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 33
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'cb_periodo
        '
        Me.cb_periodo.FormattingEnabled = True
        Me.cb_periodo.Location = New System.Drawing.Point(210, 8)
        Me.cb_periodo.Name = "cb_periodo"
        Me.cb_periodo.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo.TabIndex = 32
        '
        'txt_idseccion
        '
        Me.txt_idseccion.Location = New System.Drawing.Point(210, 65)
        Me.txt_idseccion.Name = "txt_idseccion"
        Me.txt_idseccion.Size = New System.Drawing.Size(100, 20)
        Me.txt_idseccion.TabIndex = 31
        '
        'txt_seccion
        '
        Me.txt_seccion.Location = New System.Drawing.Point(210, 109)
        Me.txt_seccion.Name = "txt_seccion"
        Me.txt_seccion.Size = New System.Drawing.Size(121, 20)
        Me.txt_seccion.TabIndex = 30
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(210, 230)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(100, 20)
        Me.txt_hora.TabIndex = 29
        '
        'cb_maestro
        '
        Me.cb_maestro.FormattingEnabled = True
        Me.cb_maestro.Location = New System.Drawing.Point(210, 151)
        Me.cb_maestro.Name = "cb_maestro"
        Me.cb_maestro.Size = New System.Drawing.Size(121, 21)
        Me.cb_maestro.TabIndex = 27
        '
        'cb_clase
        '
        Me.cb_clase.FormattingEnabled = True
        Me.cb_clase.Location = New System.Drawing.Point(457, 8)
        Me.cb_clase.Name = "cb_clase"
        Me.cb_clase.Size = New System.Drawing.Size(121, 21)
        Me.cb_clase.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(98, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Periodo Academico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Hora"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(101, 273)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(567, 159)
        Me.DataGridView1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Aula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Maestro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Seccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(402, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Clase"
        '
        'txt_aula
        '
        Me.txt_aula.Location = New System.Drawing.Point(210, 189)
        Me.txt_aula.Name = "txt_aula"
        Me.txt_aula.Size = New System.Drawing.Size(100, 20)
        Me.txt_aula.TabIndex = 36
        '
        'frm_Secciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 529)
        Me.Controls.Add(Me.txt_aula)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.cb_periodo)
        Me.Controls.Add(Me.txt_idseccion)
        Me.Controls.Add(Me.txt_seccion)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.cb_maestro)
        Me.Controls.Add(Me.cb_clase)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Secciones"
        Me.Text = "frm_Secciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents cb_periodo As ComboBox
    Friend WithEvents txt_idseccion As TextBox
    Friend WithEvents txt_seccion As TextBox
    Friend WithEvents txt_hora As TextBox
    Friend WithEvents cb_maestro As ComboBox
    Friend WithEvents cb_clase As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_aula As TextBox
End Class
