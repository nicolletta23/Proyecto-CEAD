Public Class frm_Clases
    Dim duracion As Decimal
    Private Sub frm_Clases_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = My.Forms.MDI 'Hace hijo el formulario

        CARGAR_CB("SELECT Id_Modalidad, DescripModalidad from MODALIDADES WHERE Id_Modalidad is NOT NULL") 'Carga el CB
        cb_modalidad.DataSource = cargadocumento
        cb_modalidad.DisplayMember = "DescripModalidad"
        cb_modalidad.ValueMember = "Id_Modalidad"
        cb_modalidad.Text = Nothing

        cb_duracion.Items.Add("1 hora")
        cb_duracion.Items.Add("1 hora 30 minutos")
        cb_duracion.Text = Nothing

    End Sub
    Private Sub cb_modalidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_modalidad.SelectionChangeCommitted
        value_modalidad = cb_modalidad.SelectedValue
    End Sub

    Private Sub cb_duracion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_duracion.SelectedIndexChanged
        Dim value_duracion As Decimal
        value_duracion = cb_duracion.SelectedIndex
        If value_duracion = 0 Then
            duracion = 1
        ElseIf value_duracion = 1 Then
            duracion = 1.5
        End If
    End Sub
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Try

            Dim cdm As New SqlClient.SqlCommand
            cdm = New SqlClient.SqlCommand("INSERT into CLASES(DescripClase, Duracion, Id_Modalidad)" _
            & " Values ( '" & txt_clase.Text & "', " & duracion & " , " & value_modalidad & ") ", conexion)
            cdm.ExecuteNonQuery()
            MsgBox("Usted ha ingresado un nuevo registro exitosamente", MsgBoxStyle.Information)

            'Cargar_DGV("SELECT * from FORMAPAGO", table2) 'Carga el DGV

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txt_idclase.Text = Nothing
        txt_clase.Text = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class