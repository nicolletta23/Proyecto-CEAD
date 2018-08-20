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
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(791, 545)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(100, 27)
        Me.btn_eliminar.TabIndex = 35
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(430, 390)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(100, 27)
        Me.btn_modificar.TabIndex = 34
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(145, 390)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(100, 27)
        Me.btn_agregar.TabIndex = 33
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'cb_periodo
        '
        Me.cb_periodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_periodo.FormattingEnabled = True
        Me.cb_periodo.Location = New System.Drawing.Point(163, 48)
        Me.cb_periodo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cb_periodo.Name = "cb_periodo"
        Me.cb_periodo.Size = New System.Drawing.Size(160, 23)
        Me.cb_periodo.TabIndex = 32
        '
        'txt_idseccion
        '
        Me.txt_idseccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_idseccion.Location = New System.Drawing.Point(163, 90)
        Me.txt_idseccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_idseccion.Name = "txt_idseccion"
        Me.txt_idseccion.Size = New System.Drawing.Size(160, 21)
        Me.txt_idseccion.TabIndex = 31
        '
        'txt_seccion
        '
        Me.txt_seccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_seccion.Location = New System.Drawing.Point(163, 130)
        Me.txt_seccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_seccion.Name = "txt_seccion"
        Me.txt_seccion.Size = New System.Drawing.Size(160, 21)
        Me.txt_seccion.TabIndex = 30
        '
        'txt_hora
        '
        Me.txt_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_hora.Location = New System.Drawing.Point(430, 129)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(160, 21)
        Me.txt_hora.TabIndex = 29
        '
        'cb_maestro
        '
        Me.cb_maestro.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_maestro.FormattingEnabled = True
        Me.cb_maestro.Location = New System.Drawing.Point(163, 168)
        Me.cb_maestro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cb_maestro.Name = "cb_maestro"
        Me.cb_maestro.Size = New System.Drawing.Size(160, 23)
        Me.cb_maestro.TabIndex = 27
        '
        'cb_clase
        '
        Me.cb_clase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_clase.FormattingEnabled = True
        Me.cb_clase.Location = New System.Drawing.Point(430, 48)
        Me.cb_clase.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cb_clase.Name = "cb_clase"
        Me.cb_clase.Size = New System.Drawing.Size(160, 23)
        Me.cb_clase.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(14, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Periodo Academico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(117, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Hora"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 201)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 183)
        Me.DataGridView1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(387, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Aula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(363, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Maestro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(97, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Seccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(124, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(379, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Clase"
        '
        'txt_aula
        '
        Me.txt_aula.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_aula.Location = New System.Drawing.Point(430, 93)
        Me.txt_aula.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_aula.Name = "txt_aula"
        Me.txt_aula.Size = New System.Drawing.Size(160, 21)
        Me.txt_aula.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(159, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 24)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Formulario de Registro Secciones"
        '
        'frm_Secciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(644, 441)
        Me.Controls.Add(Me.Label8)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_Secciones"
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
    Friend WithEvents Label8 As Label
End Class
