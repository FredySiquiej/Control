Imports MySql.Data.MySqlClient


Public Class DDepartamento

    Inherits Conexion

    Private idDepartamento As Integer
    Private Descripcion As String
    Private jefeInmediato As String
    Private telefono As String

    Private cmd As MySqlCommand


    Public Sub New(id As Integer, des As String, jef As String, tel As Integer)
        idDepartamento = id
        Descripcion = des
        jefeInmediato = jef
        telefono = tel


    End Sub


    Public Sub New()

    End Sub



    Public Property idDepto As String

        Get
            Return idDepartamento
        End Get
        Set(value As String)
            idDepartamento = value
        End Set
    End Property


    Public Property descripcionDepto As String

        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property


    Public Property JefeDepto As String

        Get
            Return jefeInmediato
        End Get
        Set(value As String)
            jefeInmediato = value
        End Set
    End Property



    Public Property telefonoDepto As Integer

        Get
            Return telefono
        End Get
        Set(value As Integer)
            telefono = value
        End Set
    End Property





    Public Function insertarDepartamento(dc As DDepartamento) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO DEPARTAMENTO(DESCRIPCION,JEFEINMEDIATO,TELEFONO) VALUES('" & dc.descripcionDepto & "','" & dc.JefeDepto & "','" & dc.telefonoDepto & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("el Departamento se ha ingresado exitosamente")
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







    Public Function ConsultaDepartamento() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT * FROM DEPARTAMENTO "



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



    Public Function modificarDepartamento(dc As DDepartamento) As Boolean

        Try
            conectar()

            Dim sql As String = "UPDATE DEPARTAMENTO SET DESCRIPCION='" & dc.descripcionDepto & "', JEFEINMEDIATO='" & dc.jefeInmediato & "',TELEFONO='" & dc.telefonoDepto & "' WHERE idDepartamento = '" & dc.idDepto & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El DEPARTAMENTO se ha MODIFICADO exitosamente !")
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



    Public Function EliminarDepartamento(dc As DDepartamento) As Boolean

        Try
            conectar()

            Dim sql As String = "delete from DEPARTAMENTO where DEPARTAMENTO.idDepartamento = '" & dc.idDepto & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El DEPARTAMENTO se ha Eliminado Exitosamente !")
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
