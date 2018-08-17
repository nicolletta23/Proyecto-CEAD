Public Class MDI

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar("WIN", "CEAD")
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
End Class