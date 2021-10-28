Imports MySql.Data.MySqlClient

Public Class DProductos

    Inherits Conexion

    Private idProducto As Integer
    Private descripcion As String
    Private marca As String
    Private lote As String
    Private fechaIngreso As Date
    Private Stock As Integer
    Private idUsuario As Integer

    Private cmd As MySqlCommand


    Public Sub New(id As Integer, desc As String, mar As String, lot As String, fecha As Date, stk As Integer, idUs As Integer)
        idProducto = id
        descripcion = desc
        marca = mar
        lote = lot
        fechaIngreso = fecha
        Stock = stk
        idUsuario = idUs

    End Sub

    Public Sub New()

    End Sub


    Public Property idProd As Integer

        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property

    Public Property descripcionProducto As String

        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property


    Public Property marcaProducto As String

        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    Public Property loteProducto As Integer

        Get
            Return lote
        End Get
        Set(value As Integer)
            lote = value
        End Set
    End Property

    Public Property fechaIngresoProducto As Date

        Get
            Return fechaIngreso
        End Get
        Set(value As Date)
            fechaIngreso = value
        End Set
    End Property

    Public Property stockProducto As Integer

        Get
            Return Stock
        End Get
        Set(value As Integer)
            Stock = value
        End Set
    End Property

    Public Property idUsuarioProducto As Integer

        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property


    Public Function insertarProducto(dc As DProductos) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO PRODUCTOS(DESCRIPCION,MARCA,LOTE,FECHA_REGISTRO,STOCK,IDUSUARIO) VALUES('" & dc.descripcionProducto & "','" & dc.marcaProducto & "','" & dc.loteProducto & "', now(),'" & dc.stockProducto & "','" & dc.idUsuarioProducto & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El producto se ha ingresado exitosamente!!")
                Return True

            Else
                Return False

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()

        End Try

    End Function














    Public Function EliminarProducto(dc As DProductos) As Boolean

        Try
            conectar()

            Dim sql As String = "delete from PRODUCTOS where PRODUCTOS.idProducto = '" & dc.idProd & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El Producto se ha Eliminado Exitosamente !")
                Return True

            Else
                Return False

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()

        End Try

    End Function

    Public Function modificarProducto(dc As DProductos) As Boolean

        Try
            conectar()

            Dim sql As String = "UPDATE PRODUCTOS SET DESCRIPCION='" & dc.descripcionProducto & "', MARCA='" & dc.marcaProducto & "',LOTE='" & dc.loteProducto & "' ,STOCK='" & dc.stockProducto & "',IDUSUARIO='" & dc.idUsuarioProducto & "'  WHERE idProducto = '" & dc.idProd & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El producto se ha MODIFICADO exitosamente !")
                Return True

            Else
                Return False

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()

        End Try

    End Function






    Public Function ConsultaProducto() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT * FROM PRODUCTOS "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt


            Else
                Return Nothing

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectar()

        End Try

    End Function


    Public Function ConsulaStock(id As Integer) As DataTable

        Try
            conectar()
            Dim dc As DProductos = New DProductos
            dc.idProd = frmCONSULTA_C_E_S.cmbProd
            Dim sql As String = "SELECT PRODUCTOS.descripcion,PRODUCTOS.marca, PRODUCTOS.STOCK FROM PRODUCTOS where idProducto= '" & dc.idProd & "'"



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt


            Else
                Return Nothing

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectar()

        End Try

    End Function




End Class


