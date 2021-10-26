Imports MySql.Data.MySqlClient

Public Class DUsuarios
    Inherits Conexion
    Public mn As String
    Private idUsuario As Integer
    Private nombres As String
    Private usuario As String
    Private contrasena As Integer

    Private cmd As MySqlCommand


    Public Sub New(id As Integer, nom As String, us As String, con As Integer)
        idUsuario = id
        nombres = nom
        usuario = us
        contrasena = con


    End Sub


    Public Sub New()

    End Sub


    Public Property idUs As String

        Get
            Return idUsuario
        End Get
        Set(value As String)
            idUsuario = value
        End Set
    End Property


    Public Property nombreUsuario As String

        Get
            Return nombres
        End Get
        Set(value As String)
            nombres = value
        End Set
    End Property


    Public Property usuarioAsignado As String

        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property


    Public Property contrasenaUsuario As Integer

        Get
            Return contrasena
        End Get
        Set(value As Integer)
            contrasena = value
        End Set
    End Property





    Public Function insertarUsuario(dc As DUsuarios) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO USUARIOS(NOMBRES,USUARIO,CONTRASENA) VALUES('" & dc.nombreUsuario & "','" & dc.usuarioAsignado & "','" & dc.contrasena & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("el usuario se ha ingresado exitosamente")
                Return True

            Else
                Return False

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()

        End Try

    End Function










    Public Function EliminarUsuario(dc As DUsuarios) As Boolean

    Try
        conectar()

            Dim sql As String = "delete from USUARIOS where USUARIOS.idUsuario = '" & dc.idUsuario & "' "



            cmd = New MySqlCommand(sql, con)

        If cmd.ExecuteNonQuery() Then

                MsgBox("El usuario se ha Eliminado Exitosamente !")
                Return True

        Else
            Return False

        End If



    Catch ex As Exception
        MsgBox(ex.Message)
        Return False

    Finally
        desconectar()

    End Try

End Function





    Public Function ConsultaUsuario() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT * FROM USUARIOS "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt


            Else
                Return Nothing

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectar()

        End Try

    End Function




    Public Function modificarUsuario(dc As DUsuarios) As Boolean

        Try
            conectar()

            Dim sql As String = "UPDATE USUARIOS SET NOMBRES='" & dc.nombreUsuario & "', USUARIO='" & dc.usuarioAsignado & "',CONTRASENA='" & dc.contrasenaUsuario & "' WHERE idUsuario = '" & dc.idUs & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El usuario se ha MODIFICADO exitosamente !")
                Return True

            Else
                Return False

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()

        End Try

    End Function





    Public Function ListarUsuario() As DataSet
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet

        Try
            conectar()

            Dim sql As String = "SELECT * FROM USUARIOS "



            adaptador = New MySqlDataAdapter(sql, con)
            datos = New DataSet
            datos.Tables.Add("USUARIOS")
            adaptador.Fill(datos.Tables("USUARIOS"))
            Return datos


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectar()

        End Try

    End Function




    Public Function validacionUsuario(dc As DUsuarios) As Boolean

        Try
            conectar()

            Dim sql As String = "SELECT  * FROM USUARIOS WHERE NOMBRES='" & dc.nombreUsuario & "' AND CONTRASENA='" & dc.contrasenaUsuario & "'  "

            Dim r As MySqlDataReader








            cmd = New MySqlCommand(sql, con)
            cmd.CommandText = sql

            r = cmd.ExecuteReader






            If r.HasRows <> False Then
                If dc.usuarioAsignado = 2 Then
                    r.Read()
                    MsgBox("Bienvenido " + dc.nombreUsuario)
                    frmMenu.Show()
                    frmMenu.btnGestionarProductos.Visible = False
                    frmMenu.btnConsultas.Visible = False
                    frmMenu.btnDepartamentos.Visible = False
                    frmMenu.btnGestionUsuarios.Visible = False


                    mn = 2



                Else
                    MsgBox("Bienvenido " + dc.nombreUsuario)
                    frmMenu.Show()
                    frmMenu.btnDevoluciones.Visible = False
                    frmMenu.btnIngresar.Visible = False
                    frmMenu.btnPedidos.Visible = False
                    frmMenu.btnPeticiones.Visible = False
                    frmMenu.btnSolicitar.Visible = False

                    mn = 1

                End If

            Else

                MsgBox("La contraseña o el usuario no son validos, intente de nuevo")

            End If




            Return True



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()

        End Try

    End Function



End Class
