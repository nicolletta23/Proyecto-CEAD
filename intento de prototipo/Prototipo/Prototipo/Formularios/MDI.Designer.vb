<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionAcademicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModalidadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeccionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeCobrosYPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbl_Admin = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.lbl_Admin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1213, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.GestionAcademicaToolStripMenuItem, Me.GestionDePersonalToolStripMenuItem, Me.GestionDeCobrosYPagoToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripDropDownButton1.Text = "Menu Principal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(215, 22)
        Me.ToolStripMenuItem1.Text = "Gestion de Alumnos"
        '
        'GestionAcademicaToolStripMenuItem
        '
        Me.GestionAcademicaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModalidadesToolStripMenuItem1, Me.ClasesToolStripMenuItem1, Me.SeccionesToolStripMenuItem1})
        Me.GestionAcademicaToolStripMenuItem.Name = "GestionAcademicaToolStripMenuItem"
        Me.GestionAcademicaToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.GestionAcademicaToolStripMenuItem.Text = "Gestion Academica"
        '
        'ModalidadesToolStripMenuItem1
        '
        Me.ModalidadesToolStripMenuItem1.Name = "ModalidadesToolStripMenuItem1"
        Me.ModalidadesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ModalidadesToolStripMenuItem1.Text = "Modalidades"
        '
        'ClasesToolStripMenuItem1
        '
        Me.ClasesToolStripMenuItem1.Name = "ClasesToolStripMenuItem1"
        Me.ClasesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClasesToolStripMenuItem1.Text = "Clases"
        '
        'SeccionesToolStripMenuItem1
        '
        Me.SeccionesToolStripMenuItem1.Name = "SeccionesToolStripMenuItem1"
        Me.SeccionesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SeccionesToolStripMenuItem1.Text = "Secciones"
        '
        'GestionDePersonalToolStripMenuItem
        '
        Me.GestionDePersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroPersonalToolStripMenuItem})
        Me.GestionDePersonalToolStripMenuItem.Name = "GestionDePersonalToolStripMenuItem"
        Me.GestionDePersonalToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.GestionDePersonalToolStripMenuItem.Text = "Gestion de Personal"
        '
        'RegistroPersonalToolStripMenuItem
        '
        Me.RegistroPersonalToolStripMenuItem.Name = "RegistroPersonalToolStripMenuItem"
        Me.RegistroPersonalToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RegistroPersonalToolStripMenuItem.Text = "Registro Personal"
        '
        'GestionDeCobrosYPagoToolStripMenuItem
        '
        Me.GestionDeCobrosYPagoToolStripMenuItem.Name = "GestionDeCobrosYPagoToolStripMenuItem"
        Me.GestionDeCobrosYPagoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.GestionDeCobrosYPagoToolStripMenuItem.Text = "Gestion de Cobros y Pagos"
        '
        'lbl_Admin
        '
        Me.lbl_Admin.Name = "lbl_Admin"
        Me.lbl_Admin.Size = New System.Drawing.Size(88, 22)
        Me.lbl_Admin.Text = "Administracion"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1213, 710)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDI"
        Me.Text = "MDI"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionAcademicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModalidadesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClasesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SeccionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDePersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeCobrosYPagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroPersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_Admin As ToolStripLabel
End Class
