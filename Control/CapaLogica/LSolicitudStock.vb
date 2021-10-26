Imports MySql.Data.MySqlClient
Public Class LSolicitudStock


    Public Function insertarSolicitudStock(idSol As Integer, idPro As Integer, cant As Integer, desc As String, fecha As DateTime, idUs As Integer)

        Dim dc As New DSolicitarStock(idSol, idPro, cant, desc, fecha, idUs)

        If dc.insertarSolicitudStock(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function eliminarSolicitudStock(idSol As Integer, idPro As Integer, cant As Integer, desc As String, fecha As DateTime, idUs As Integer)

        Dim dc As New DSolicitarStock(idSol, idPro, cant, desc, fecha, idUs)

        If dc.EliminarSolicitudStock(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function


    Public Function modificarSolicitudStock(idSol As Integer, idPro As Integer, cant As Integer, desc As String, fecha As DateTime, idUs As Integer)

        Dim dc As New DSolicitarStock(idSol, idPro, cant, desc, fecha, idUs)

        If dc.modificarSolicitudStock(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function




End Class
