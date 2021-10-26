Imports MySql.Data.MySqlClient
Public Class DPeticiones


    Inherits Conexion

    Private idPeticiones As Integer
    Private descripcion As String
    Private fechaPeticion As DateTime
    Private Estado As String
    Private usuario As Integer

    Private cmd As MySqlCommand


    Public Sub New(id As Integer, desc As String, fecha As Date, est As String, us As Integer)
        idPeticiones = id
        descripcion = desc
        fechaPeticion = fecha
        Estado = est
        usuario = us


    End Sub

    Public Sub New()

    End Sub


    Public Property idPeti As Integer

        Get
            Return idPeticiones
        End Get
        Set(value As Integer)
            idPeticiones = value
        End Set
    End Property

    Public Property descripcionPeticiones As String

        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property


    Public Property fecPeticiones As Date

        Get
            Return fechaPeticion
        End Get
        Set(value As Date)
            fechaPeticion = value
        End Set
    End Property

    Public Property estadoPeticiones As String

        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property

    Public Property usuarioPeticiones As Integer

        Get
            Return usuario
        End Get
        Set(value As Integer)
            usuario = value
        End Set
    End Property




    Public Function insertarPeticiones(dc As DPeticiones) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO PETICIONES(DESCRIPCION,FECHAPETICION,ESTADO,IDUSUARIO) VALUES('" & dc.descripcionPeticiones & "',now(),'" & dc.estadoPeticiones & "', '" & dc.usuarioPeticiones & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La peticion  se ha ingresado exitosamente!!")
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



    Public Function EliminarPeticiones(dc As DPeticiones) As Boolean

        Try
            conectar()

            Dim sql As String = "delete from PETICIONES where PETICIONES.idPeticiones = '" & dc.idPeti & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La peticion se ha Eliminado Exitosamente !")
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



    Public Function modificarPeticiones(dc As DPeticiones) As Boolean

        Try
            conectar()

            Dim sql As String = "UPDATE PETICIONES SET DESCRIPCION='" & dc.descripcionPeticiones & "', FECHAPETICION = now() , ESTADO='" & dc.estadoPeticiones & "' ,IDUSUARIO='" & dc.usuarioPeticiones & "'  WHERE idPeticiones = '" & dc.idPeti & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El producto se ha MODIFICADO exitosamente !")
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


    Public Function ConsultaPeticiones() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT * FROM PETICIONES "



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





End Class
