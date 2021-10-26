Imports MySql.Data.MySqlClient


Public Class LIngresar
    Public Function ingresarStock(idIn As Integer, idPro As Integer, cant As Integer, fecha As DateTime, idUs As Integer)

        Dim dc As New DIngresar(idIn, idPro, cant, fecha, idUs)

        If dc.ingresarStock(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function eliminarIngreso(idIn As Integer, idPro As Integer, cant As Integer, fecha As DateTime, idUs As Integer)

        Dim dc As New DIngresar(idIn, idPro, cant, fecha, idUs)

        If dc.EliminarIngreso(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function





End Class
