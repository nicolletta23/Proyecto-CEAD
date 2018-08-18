
Imports System.Data
Imports System.Data.SqlClient
Module admin_conexion
    Public conexion As SqlConnection
    Public cadenaconexion As String
    Public adapterusuarios As SqlDataAdapter
    Public builderusuarios As SqlCommandBuilder
    Public tablausuarios As DataTable
    Public dataCead As DataSet


    Public idusuario As String
    Public nombreusuario As String

    Public adapterpersonal As SqlDataAdapter
    Public builderpersonal As SqlCommandBuilder
    Public tablapersonal As DataTable



    Public Sub conectar(ByVal H As String, ByVal BD As String)
        Try
            'cadena de conexion de Nicolle
            cadenaconexion = "SERVER = " & H & "; INITIAL CATALOG = " & BD & "; INTEGRATED SECURITY = TRUE "
            conexion = New SqlConnection

            dataCead = New DataSet


            conexion.ConnectionString = cadenaconexion
            conexion.Open()
            MsgBox("USTED SE HA CONECTADO A LA BD", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub


    Public Function accede_usuario(ByVal Usuario As String, ByVal Psw As String) As Boolean
        Try
            adapterusuarios = New SqlDataAdapter("Select * from Usuarios", conexion)
            adapterusuarios.Fill(dataCead, "Usuarios")
            adapterusuarios.FillSchema(dataCead.Tables("Usuarios"), SchemaType.Source)

            builderusuarios = New SqlCommandBuilder(adapterusuarios)
            tablausuarios = dataCead.Tables("Usuarios")

            For Each fila As DataRow In tablausuarios.Rows
                If fila("Usuario") = Usuario And fila("Contraseña") = Psw Then
                    nombreusuario = fila("Usuario")
                    Return True
                End If

            Next
            Return False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Exit Function
    End Function


    Public Sub carga_personal()
        Try
            ' Dim cadena As String = "select id_Empleado, PrimerNombre + ' ' + SegundoNombre +' ' + PrimerApellido + ' ' + [Segundo Apellido] as nombrecompleto from Personal;"
            Dim cadena As String = "select id_Empleado, PrimerNombre + ' ' + SegundoNombre +' ' + PrimerApellido + ' ' + [Segundo Apellido] as nombrecompleto from Personal where not exists (select Id_personal from Usuarios where personal.Id_Empleado=Usuarios.Id_personal);"
            adapterpersonal = New SqlDataAdapter(cadena, conexion)
            tablapersonal = New DataTable("Personal")
            adapterpersonal.Fill(tablapersonal)


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


End Module
