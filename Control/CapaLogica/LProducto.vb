

Imports MySql.Data.MySqlClient


Public Class LProducto

    Public Function insertarProducto(id As Integer, desc As String, marc As String, lot As Integer, fecha As Date, stk As Integer, idUs As Integer)

        Dim dc As New DProductos(0, desc, marc, lot, fecha, stk, idUs)

        If dc.insertarProducto(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function




    Public Function eliminarProducto(id As Integer, desc As String, marc As String, lot As Integer, fecha As DateTime, stk As Integer, idus As Integer)

        Dim dc As New DProductos(id, desc, marc, lot, fecha, stk, idus)

        If dc.EliminarProducto(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function modificarProducto(id As Integer, desc As String, marc As String, lot As Integer, fecha As DateTime, stk As Integer, idus As Integer)

        Dim dc As New DProductos(id, desc, marc, lot, fecha, stk, idus)

        If dc.modificarProducto(dc) = True Then
            Return True
        Else
            Return False

        End If
    End Function


End Class


