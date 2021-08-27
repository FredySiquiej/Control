Imports MySql.Data.MySqlClient


Public Class Form1


    Protected conexion As New MySqlConnection("server=localhost;database=inventario;user=root;password='admin'")

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click


        Try
            conexion.Open()
            MsgBox("la conexion ha sido exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        End Try
    End Sub
End Class
