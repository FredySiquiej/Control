
Imports MySql.Data.MySqlClient

Public Class LUsuarios

    Public Function insertarUsuario(id As Integer, nom As String, us As String, con As String)

        Dim dc As New DUsuarios(0, nom, us, con)

        If dc.insertarUsuario(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function




    Public Function eliminarUsuario(id As Integer, nom As String, us As String, con As String)

        Dim dc As New DUsuarios(id, nom, us, con)

        If dc.EliminarUsuario(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function


    Public Function ConsultaUsuario()

        Dim dc As New DUsuarios()


    End Function



    Public Function modificarUsuario(id As Integer, nom As String, us As String, con As String)

        Dim dc As New DUsuarios(id, nom, us, con)

        If dc.modificarUsuario(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function



End Class
