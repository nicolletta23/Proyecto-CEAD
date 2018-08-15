Imports System.ComponentModel

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

    Private Sub frm_principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub frm_principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.frm_login.textusuario.Clear()
        My.Forms.frm_login.textclave.Clear()

    End Sub
End Class