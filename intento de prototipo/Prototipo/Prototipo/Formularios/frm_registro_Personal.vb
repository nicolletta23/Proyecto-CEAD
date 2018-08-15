Public Class frm_registro_Personal
    Public genero As String
    Private Sub frm_registro_Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbodepartamento.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Not Me.textidentidad.Text.Length = 13 Then
                MsgBox("Debe incluir un numero de identidad correcto!!", MsgBoxStyle.Exclamation)
            ElseIf Me.textprimernombre.Text.Length < 3
                MsgBox("Debe agregar al menos un nombre!", MsgBoxStyle.Exclamation)
            ElseIf Me.textprimerapellido.Text.Length < 3
                MsgBox("Debe agregar al menos un apellido!", MsgBoxStyle.Exclamation)
            ElseIf Me.cbodepartamento.SelectedIndex = 0
                MsgBox("Debe seleccionar un departamento!", MsgBoxStyle.Exclamation)
            ElseIf Not Me.texttelefono.Text.Length = 8
                MsgBox("Agregue un numero de telefono valido!", MsgBoxStyle.Exclamation)
            Else
                'AQUI LLAMO AL METODO
                insertapersonal(Me.textprimernombre.Text, Me.textsegundoapellido.Text, Me.textprimerapellido.Text, Me.textsegundoapellido.Text, Me.texttelefono.Text, Me.textemail.Text, Me.textidentidad.Text, genero, Me.cboestadocivil.Text, Me.cbodepartamento.SelectedIndex, Me.rtbdireccion.Text)
                Me.limpiar()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub radfemenino_CheckedChanged(sender As Object, e As EventArgs) Handles radfemenino.CheckedChanged
        If Me.radfemenino.Checked = True Then
            genero = "F"

        End If
    End Sub

    Private Sub radmasculino_CheckedChanged(sender As Object, e As EventArgs) Handles radmasculino.CheckedChanged
        If Me.radmasculino.Checked = True Then
            genero = "M"
        Else
            genero = "F"
        End If
    End Sub

    Public Sub limpiar()
        Me.textprimernombre.Clear()
        Me.textsegundonombre.Clear()
        Me.textprimerapellido.Clear()
        Me.textsegundoapellido.Clear()
        Me.textidentidad.Clear()
        Me.texttelefono.Clear()
        Me.textemail.Clear()
        Me.radfemenino.Checked = False
        Me.radmasculino.Checked = False
        Me.cbodepartamento.SelectedIndex = 0
        Me.cboestadocivil.SelectedIndex = 0
        Me.rtbdireccion.Clear()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.limpiar()

    End Sub
End Class