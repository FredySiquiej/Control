Imports MySql.Data.MySqlClient


Public Class Conexion
    ' Protected con As New MySqlConnection("server=localhost;database=inventario;user=root;password='admin'")
    Protected con As New MySqlConnection("server=www.db4free.net;Port=3306;database=prinventarios;user=grupo2analisis;password='grupo2analisis'")

    Public Function conectar() As Boolean

        Try
            con.Open()
            Return True


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False



        End Try




    End Function

    Public Sub desconectar()

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
