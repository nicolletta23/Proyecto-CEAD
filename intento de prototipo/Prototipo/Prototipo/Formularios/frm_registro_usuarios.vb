Public Class frm_registro_usuarios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.textingreseusuario.Text.Length > 0 Then
            If Me.cboroll.SelectedIndex = 0 Then
                MsgBox("Tiene que seleccionar un ROll!!", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                inserta_usuario(Me.cbonombreusuario.SelectedValue, Me.textingreseusuario.Text, Me.textcontraseña.Text, Me.cboroll.SelectedIndex)
                Me.btnlimpiar.PerformClick()

            End If

        Else
            MsgBox("Debe agregar un nombre de usuario!!", MsgBoxStyle.Exclamation)
            Me.textingreseusuario.Focus()

        End If
    End Sub

    Private Sub frm_registro_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_empleados()
        Me.cbopersonal.Visible = False
        Me.cbonombreusuario.SelectedIndex = 0
        Me.cboroll.SelectedIndex = 0
        Me.btnAgregar.Enabled = False


    End Sub

    Public Sub Cargar_empleados()
        Try
            carga_personal()

            ' MsgBox(tablapersonal.Rows().Count)

            If tablapersonal.Rows.Count = 0 Then
                '  MsgBox("aqui entra!")
                Me.cbonombreusuario.Items.Add("No hay empleados")
            Else
                Me.cbonombreusuario.DataSource = tablapersonal
                Me.cbonombreusuario.DisplayMember = "nombrecompleto"
                Me.cbonombreusuario.ValueMember = "Id_Empleado"
            End If


            'With Me.cbonombreusuario
            '    If tablapersonal Is Nothing Then
            '        .DataSource = Nothing
            '        .Items.Add("No hay empleados nuevos!!")
            '    Else
            '        .DataSource = tablapersonal
            '        .DisplayMember = "nombrecompleto"
            '        .ValueMember = "Id_Empleado"
            '    End If
            'End With
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub textconfirmecontraseña_TextChanged(sender As Object, e As EventArgs) Handles textconfirmecontraseña.TextChanged
        If Me.textconfirmecontraseña.Text.Length > 1 And Me.textconfirmecontraseña.Text = Me.textcontraseña.Text Then
            Me.btnAgregar.Enabled = True
        Else
            Me.btnAgregar.Enabled = False


        End If
    End Sub

    Private Sub cboroll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboroll.SelectedIndexChanged

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Me.textingreseusuario.Clear()
        Me.textcontraseña.Clear()
        Me.textconfirmecontraseña.Clear()
        Me.cbonombreusuario.SelectedIndex = 0
        Me.cboroll.SelectedIndex = 0


    End Sub

    Private Sub cbonombreusuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbonombreusuario.SelectedIndexChanged

    End Sub
End Class