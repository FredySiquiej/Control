Imports MySql.Data.MySqlClient

Public Class LDepartamento

    Public Function insertarDepartamento(id As Integer, des As String, jef As String, tel As Integer)

        Dim dc As New DDepartamento(0, des, jef, tel)

        If dc.insertarDepartamento(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function



    Public Function modificarDepartamento(id As Integer, des As String, jef As String, tel As Integer)

        Dim dc As New DDepartamento(id, des, jef, tel)

        If dc.modificarDepartamento(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function eliminarDepartamento(id As Integer, des As String, jef As String, tel As Integer)

        Dim dc As New DDepartamento(id, des, jef, tel)

        If dc.EliminarDepartamento(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function
End Class
