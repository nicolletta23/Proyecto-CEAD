﻿Public Class frm_login
    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONEXION DE NICOLLE
        'conectar("WIN", "CEAD")

        'CONEXION DE LAS DEMAS
        'conectar("AQUI DEBEN PONER NOMBRE DE SU SERVIDOR", "CEAD")
        conectar("LASTE", "CEAD")
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If Me.textusuario.Text.Length <= 0 Then
            MsgBox("Debe agregar un usuario!", MsgBoxStyle.Exclamation)
        ElseIf Me.textclave.Text.Length <= 0
            MsgBox("Debe ingresar una contraseña!", MsgBoxStyle.Exclamation)
        Else
            Dim U, P As String
            U = Me.textusuario.Text
            P = Me.textclave.Text

            If accede_usuario(U, P) = True Then
                My.Forms.MDI.Show()
            Else
                MsgBox("Usuario no existe!", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        Me.textusuario.Clear()
        Me.textclave.Clear()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.frm_cambio_contraseña.Show()
    End Sub
End Class

