Public Class MDI

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ModalidadesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModalidadesToolStripMenuItem1.Click
        My.Forms.frm_Modalidad.Show()
    End Sub

    Private Sub ClasesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClasesToolStripMenuItem1.Click
        My.Forms.frm_Clases.Show()
    End Sub

    Private Sub SeccionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SeccionesToolStripMenuItem1.Click
        My.Forms.frm_Secciones.Show()
    End Sub

    Private Sub RegistroPersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroPersonalToolStripMenuItem.Click
        My.Forms.frm_registro_Personal.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles lbl_Admin.Click
        My.Forms.frm_Parametros.Show()

    End Sub

    Private Sub RegistroAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroAlumnosToolStripMenuItem.Click
        My.Forms.frm_registro_alumnos.Show()

    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        My.Forms.frm_registro_usuarios.Show()

    End Sub

    Private Sub PlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillaToolStripMenuItem.Click
        My.Forms.planilla.Show()
    End Sub

    Private Sub CobroMensualidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobroMensualidadToolStripMenuItem.Click
        My.Forms.cobro_mensualidad.Show()
    End Sub

    Private Sub CobroMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobroMatriculaToolStripMenuItem.Click
        My.Forms.cobro_matricula.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click_1(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Application.Exit()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class