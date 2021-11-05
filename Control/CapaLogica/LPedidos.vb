Imports MySql.Data.MySqlClient

Public Class LPedidos

    Public Function insertarPedido(id As Integer, idform As Integer, idProd As Integer, cant As Integer, fecha As DateTime, idUs As Integer, idDep As Integer)

        Dim dc As New DPedidos(0, idform, idProd, cant, Now(), idUs, idDep)

        If dc.insertarPedido(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function




    Public Function eliminarPedido(id As Integer, idform As Integer, idProd As Integer, cant As Integer, fecha As DateTime, idUs As Integer, idDep As Integer)

        Dim dc As New DPedidos(id, idform, idProd, cant, fecha, idUs, idDep)

        If dc.EliminarPedido(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function modificarPedido(id As Integer, idform As Integer, idProd As Integer, cant As Integer, fecha As DateTime, idUs As Integer, idDep As Integer)

        Dim dc As New DPedidos(id, idform, idProd, cant, fecha, idUs, idDep)

        If dc.EliminarPedido(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function
End Class
