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
        Me.RegistroAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialAcademicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionAcademicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModalidadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeccionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeCobrosYPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobroMensualidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobroMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Admin = New System.Windows.Forms.ToolStripLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsb_registro = New System.Windows.Forms.ToolStripButton()
        Me.tsb_guardar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_pagar = New System.Windows.Forms.ToolStripButton()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.lbl_Admin, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.GestionAcademicaToolStripMenuItem, Me.GestionDePersonalToolStripMenuItem, Me.GestionDeCobrosYPagoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripDropDownButton1.Text = "Menu Principal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroAlumnosToolStripMenuItem, Me.HistorialAcademicoToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(215, 22)
        Me.ToolStripMenuItem1.Text = "Gestion de Alumnos"
        '
        'RegistroAlumnosToolStripMenuItem
        '
        Me.RegistroAlumnosToolStripMenuItem.Name = "RegistroAlumnosToolStripMenuItem"
        Me.RegistroAlumnosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RegistroAlumnosToolStripMenuItem.Text = "Registro Alumnos"
        '
        'HistorialAcademicoToolStripMenuItem
        '
        Me.HistorialAcademicoToolStripMenuItem.Name = "HistorialAcademicoToolStripMenuItem"
        Me.HistorialAcademicoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HistorialAcademicoToolStripMenuItem.Text = "Historial Academico"
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
        Me.ModalidadesToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ModalidadesToolStripMenuItem1.Text = "Modalidades"
        '
        'ClasesToolStripMenuItem1
        '
        Me.ClasesToolStripMenuItem1.Name = "ClasesToolStripMenuItem1"
        Me.ClasesToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ClasesToolStripMenuItem1.Text = "Clases"
        '
        'SeccionesToolStripMenuItem1
        '
        Me.SeccionesToolStripMenuItem1.Name = "SeccionesToolStripMenuItem1"
        Me.SeccionesToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.SeccionesToolStripMenuItem1.Text = "Secciones"
        '
        'GestionDePersonalToolStripMenuItem
        '
        Me.GestionDePersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroPersonalToolStripMenuItem, Me.UsuarioToolStripMenuItem})
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
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'GestionDeCobrosYPagoToolStripMenuItem
        '
        Me.GestionDeCobrosYPagoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanillaToolStripMenuItem, Me.CobroMensualidadToolStripMenuItem, Me.CobroMatriculaToolStripMenuItem})
        Me.GestionDeCobrosYPagoToolStripMenuItem.Name = "GestionDeCobrosYPagoToolStripMenuItem"
        Me.GestionDeCobrosYPagoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.GestionDeCobrosYPagoToolStripMenuItem.Text = "Gestion de Cobros y Pagos"
        '
        'PlanillaToolStripMenuItem
        '
        Me.PlanillaToolStripMenuItem.Name = "PlanillaToolStripMenuItem"
        Me.PlanillaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PlanillaToolStripMenuItem.Text = "Planilla"
        '
        'CobroMensualidadToolStripMenuItem
        '
        Me.CobroMensualidadToolStripMenuItem.Name = "CobroMensualidadToolStripMenuItem"
        Me.CobroMensualidadToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CobroMensualidadToolStripMenuItem.Text = "Cobro Mensualidad"
        '
        'CobroMatriculaToolStripMenuItem
        '
        Me.CobroMatriculaToolStripMenuItem.Name = "CobroMatriculaToolStripMenuItem"
        Me.CobroMatriculaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CobroMatriculaToolStripMenuItem.Text = "Cobro Matricula"
        '
        'lbl_Admin
        '
        Me.lbl_Admin.Name = "lbl_Admin"
        Me.lbl_Admin.Size = New System.Drawing.Size(88, 22)
        Me.lbl_Admin.Text = "Administracion"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_registro, Me.tsb_guardar, Me.tsb_eliminar, Me.tsb_pagar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1016, 27)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsb_registro
        '
        Me.tsb_registro.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.tsb_registro.Image = CType(resources.GetObject("tsb_registro.Image"), System.Drawing.Image)
        Me.tsb_registro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_registro.Name = "tsb_registro"
        Me.tsb_registro.Size = New System.Drawing.Size(112, 24)
        Me.tsb_registro.Text = "Registro Nuevo"
        '
        'tsb_guardar
        '
        Me.tsb_guardar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.tsb_guardar.Image = CType(resources.GetObject("tsb_guardar.Image"), System.Drawing.Image)
        Me.tsb_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_guardar.Name = "tsb_guardar"
        Me.tsb_guardar.Size = New System.Drawing.Size(73, 24)
        Me.tsb_guardar.Text = "Guardar"
        '
        'tsb_eliminar
        '
        Me.tsb_eliminar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.tsb_eliminar.Image = CType(resources.GetObject("tsb_eliminar.Image"), System.Drawing.Image)
        Me.tsb_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_eliminar.Name = "tsb_eliminar"
        Me.tsb_eliminar.Size = New System.Drawing.Size(74, 24)
        Me.tsb_eliminar.Text = "Eliminar"
        '
        'tsb_pagar
        '
        Me.tsb_pagar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsb_pagar.Image = CType(resources.GetObject("tsb_pagar.Image"), System.Drawing.Image)
        Me.tsb_pagar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_pagar.Name = "tsb_pagar"
        Me.tsb_pagar.Size = New System.Drawing.Size(82, 24)
        Me.tsb_pagar.Text = "Modificar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "Salir"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Prototipo.My.Resources.Resources.ceadma
        Me.ClientSize = New System.Drawing.Size(1016, 596)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDI"
        Me.Text = "Academia de Musica CEAD"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents RegistroAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialAcademicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobroMensualidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobroMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsb_registro As ToolStripButton
    Friend WithEvents tsb_guardar As ToolStripButton
    Friend WithEvents tsb_eliminar As ToolStripButton
    Friend WithEvents tsb_pagar As ToolStripButton
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
