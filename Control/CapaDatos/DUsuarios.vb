Imports MySql.Data.MySqlClient

Public Class DUsuarios
    Inherits Conexion

    Private idUsuario As Integer
    Private nombres As String
    Private usuario As String
    Private contrasena As String

    Private cmd As MySqlCommand


    Public Sub New(nom As String, us As String, con As Integer)
        nombres = nom
        usuario = us
        contrasena = con


    End Sub


    Public Sub New()

    End Sub


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

            Dim sql As String = "INSERT INTO USUARIOS(NOMBRES,USUARIO,CONTRASENA) VALUES('" & dc.nombreUsuario & "','" & dc.usuarioAsignado & "','" & dc.contrasenaUsuario & "')"


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






End Class
