Imports MySql.Data.MySqlClient

Public Class LPedidos

    Public Function insertarPedido(id As Integer, idProd As Integer, cant As Integer, fecha As DateTime, idUs As Integer, idDep As Integer)

        Dim dc As New DPedidos(0, idProd, cant, fecha, idUs, idDep)

        If dc.insertarPedido(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function




    Public Function eliminarPedido(id As Integer, idProd As Integer, cant As Integer, fecha As DateTime, idUs As Integer, idDep As Integer)

        Dim dc As New DPedidos(id, idProd, cant, fecha, idUs, idDep)

        If dc.EliminarPedido(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function modificarPedido(id As Integer, idProd As Integer, cant As Integer, fecha As DateTime, idUs As Integer, idDep As Integer)

        Dim dc As New DPedidos(id, idProd, cant, fecha, idUs, idDep)

        If dc.EliminarPedido(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function


End Class
