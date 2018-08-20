<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Clases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Clases))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_modalidad = New System.Windows.Forms.ComboBox()
        Me.txt_clase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_duracion = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.Label()
        Me.txt_idclase = New System.Windows.Forms.TextBox()
        Me.Clases = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(34, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modalidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(61, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clase"
        '
        'cb_modalidad
        '
        Me.cb_modalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_modalidad.FormattingEnabled = True
        Me.cb_modalidad.Location = New System.Drawing.Point(120, 65)
        Me.cb_modalidad.Name = "cb_modalidad"
        Me.cb_modalidad.Size = New System.Drawing.Size(243, 21)
        Me.cb_modalidad.TabIndex = 2
        '
        'txt_clase
        '
        Me.txt_clase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_clase.Location = New System.Drawing.Point(120, 98)
        Me.txt_clase.Name = "txt_clase"
        Me.txt_clase.Size = New System.Drawing.Size(243, 20)
        Me.txt_clase.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(38, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Duracion"
        '
        'cb_duracion
        '
        Me.cb_duracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_duracion.FormattingEnabled = True
        Me.cb_duracion.Location = New System.Drawing.Point(120, 134)
        Me.cb_duracion.Name = "cb_duracion"
        Me.cb_duracion.Size = New System.Drawing.Size(121, 21)
        Me.cb_duracion.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(614, 196)
        Me.DataGridView1.TabIndex = 6
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(37, 397)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 7
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(288, 397)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 8
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(573, 397)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ID.Location = New System.Drawing.Point(78, 33)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(24, 18)
        Me.ID.TabIndex = 10
        Me.ID.Text = "ID"
        '
        'txt_idclase
        '
        Me.txt_idclase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_idclase.Location = New System.Drawing.Point(120, 31)
        Me.txt_idclase.Name = "txt_idclase"
        Me.txt_idclase.Size = New System.Drawing.Size(100, 20)
        Me.txt_idclase.TabIndex = 11
        '
        'Clases
        '
        Me.Clases.AutoSize = True
        Me.Clases.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clases.Location = New System.Drawing.Point(324, 9)
        Me.Clases.Name = "Clases"
        Me.Clases.Size = New System.Drawing.Size(61, 19)
        Me.Clases.TabIndex = 12
        Me.Clases.Text = "Clases"
        '
        'frm_Clases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(682, 443)
        Me.Controls.Add(Me.Clases)
        Me.Controls.Add(Me.txt_idclase)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb_duracion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_clase)
        Me.Controls.Add(Me.cb_modalidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Clases"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_modalidad As ComboBox
    Friend WithEvents txt_clase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_duracion As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents ID As Label
    Friend WithEvents txt_idclase As TextBox
    Friend WithEvents Clases As Label
End Class
