
Imports MySql.Data.MySqlClient

Public Class LUsuarios

    Public Function insertarUsuario(nom As String, us As String, con As String)

        Dim dc As New DUsuarios(nom, us, con)

        If dc.insertarUsuario(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function


End Class
