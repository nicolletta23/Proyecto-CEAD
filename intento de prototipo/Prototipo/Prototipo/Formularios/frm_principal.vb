Public Class frm_principal
    Private Sub btnRegPersonal_Click(sender As Object, e As EventArgs) Handles btnRegPersonal.Click
        My.Forms.frm_registro_Personal.Show()

    End Sub

    Private Sub btnRegAlumno_Click(sender As Object, e As EventArgs) Handles btnRegAlumno.Click
        My.Forms.frm_registro_alumnos.Show()

    End Sub

    Private Sub btnMatricula_Click(sender As Object, e As EventArgs) Handles btnMatricula.Click
        My.Forms.frm_Matricula.Show()

    End Sub

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblfecha.Text = Date.Now
        Me.lblusuario.Text = nombreusuario

    End Sub
End Class