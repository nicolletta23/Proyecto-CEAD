Imports System.Data
Imports System.Data.SqlClient
Module Modulo
    Public value_modalidad As Integer
    Public cargadocumento As DataTable

    Public Sub insertapersonal(ByVal PN As String, ByVal SN As String, ByVal PA As String, ByVal SA As String, ByVal T As String, ByVal E As String, ByVal C As String, ByVal G As String, ByVal EC As String, ByVal D As Integer, ByVal DIR As String)
        Try
            Dim comando As New SqlCommand

            comando.CommandType = CommandType.Text
            comando.CommandText = "insert into Personal(PrimerNombre, SegundoNombre, PrimerApellido,[Segundo Apellido], Telefono, Email,Cedula, genero, EstadoCivil, Id_Departamentos) values('" & PN & "', '" & SN & "', '" & PA & "', '" & SA & "', " & T & " , '" & E & "', " & C & ", '" & G & "', '" & EC & "'," & D & ");"
            comando.Connection = conexion

            comando.ExecuteNonQuery()
            MsgBox("Personal agregado Exitosamente!!!", MsgBoxStyle.Information)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Public Sub CARGAR_CB(ByVal SQL_Select As String)

        Dim sqldocumento As New SqlClient.SqlCommand(SQL_Select, conexion)
        Dim select_tabla As New SqlClient.SqlDataAdapter(sqldocumento)
        cargadocumento = New DataTable
        select_tabla.Fill(cargadocumento)

    End Sub
End Module
