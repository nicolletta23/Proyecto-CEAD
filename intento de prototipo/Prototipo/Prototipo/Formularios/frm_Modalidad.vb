Public Class frm_Modalidad

    Private Sub frm_Modalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = My.Forms.MDI 'Hace hijo el formulario


    End Sub


    Public Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try

            Dim cdm As New SqlClient.SqlCommand
            cdm = New SqlClient.SqlCommand("INSERT into MODALIDADES(DescripModalidad)" _
            & "Values ( '" & txt_mod.Text & "' ) ", conexion)
            cdm.ExecuteNonQuery()
            MsgBox("Usted ha ingresado un nuevo registro exitosamente", MsgBoxStyle.Information)

            'Cargar_DGV("SELECT * from FORMAPAGO", table2) 'Carga el DGV

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txt_idmod.Text = Nothing
        txt_mod.Text = Nothing
    End Sub
End Class