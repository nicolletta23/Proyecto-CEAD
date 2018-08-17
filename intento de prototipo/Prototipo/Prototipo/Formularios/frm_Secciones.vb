Public Class frm_Secciones
    Private Sub frm_Secciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.MDI 'Hace hijo el formulario

        CARGAR_CB("SELECT Id_Empleado, PrimerNombre + ' ' + PrimerApellido as NombreCompleto from PERSONAL WHERE Id_Empleado is NOT NULL") 'Carga el CB
        cb_maestro.DataSource = cargadocumento
        cb_maestro.DisplayMember = "NombreCompleto"
        cb_maestro.ValueMember = "Id_Empleado"
        cb_maestro.Text = Nothing



    End Sub
End Class