Imports MySql.Data.MySqlClient

Public Class LDevoluciones

    Public Function insertarDefectuoso(id As Integer, idPed As Integer, desc As String, cant As Integer, fecha As DateTime, idUs As Integer)

        Dim dc As New DDevoluciones(0, idPed, desc, cant, fecha, idUs)

        If dc.insertarDefectuoso(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function


    Public Function eliminarDefectuoso(id As Integer, idPed As Integer, desc As String, cant As Integer, fecha As DateTime, idUs As Integer)

        Dim dc As New DDevoluciones(id, idPed, desc, cant, fecha, idUs)

        If dc.EliminarDefectuoso(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function modificarDefectuoso(id As Integer, idPed As Integer, desc As String, cant As Integer, fecha As DateTime, idUs As Integer)

        Dim dc As New DDevoluciones(id, idPed, desc, cant, fecha, idUs)

        If dc.modificarDefectuoso(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function











End Class
