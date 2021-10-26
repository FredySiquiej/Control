Imports MySql.Data.MySqlClient

Public Class LPeticiones

    Public Function insertarPeticiones(id As Integer, desc As String, fec As DateTime, est As String, us As Integer)

        Dim dc As New DPeticiones(0, desc, fec, est, us)

        If dc.insertarPeticiones(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function




    Public Function eliminarPeticiones(id As Integer, desc As String, fec As DateTime, est As String, us As Integer)

        Dim dc As New DPeticiones(id, desc, fec, est, us)

        If dc.EliminarPeticiones(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function






    Public Function modificarPeticiones(id As Integer, desc As String, fec As DateTime, est As String, us As Integer)

        Dim dc As New DPeticiones(id, desc, fec, est, us)

        If dc.modificarPeticiones(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function






End Class
