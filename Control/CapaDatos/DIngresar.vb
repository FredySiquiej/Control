
Imports MySql.Data.MySqlClient

Public Class DIngresar
    Inherits Conexion

    Private idIngresos As Integer
    Private idProducto As Integer
    Private cantidad As Integer
    Private fecha_Ingreso As DateTime
    Private idUsuario As Integer

    Private cmd As MySqlCommand


    Public Sub New(idIn As Integer, idPro As Integer, cant As Integer, fecha As DateTime, idUs As Integer)
        idIngresos = idIn
        idProducto = idPro
        cantidad = cant
        fecha_Ingreso = fecha
        idUsuario = idUs

    End Sub


    Public Sub New()

    End Sub

    Public Property idIngresoProducto As Integer

        Get
            Return idIngresos
        End Get
        Set(value As Integer)
            idIngresos = value
        End Set
    End Property

    Public Property idProductoIngres As Integer

        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property

    Public Property cantidadIngres As Integer

        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property


    Public Property fechaIngres As DateTime

        Get
            Return fecha_Ingreso
        End Get
        Set(value As DateTime)
            fecha_Ingreso = value
        End Set
    End Property

    Public Property idUsuarioIngres As Integer

        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property


    Public Function ingresarStock(dc As DIngresar) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO INGRESOS(IDPRODUCTO,CANTIDAD,FECHA_INGRESO,IDUSUARIO) VALUES('" & dc.idProductoIngres & "','" & dc.cantidadIngres & "',now(),'" & dc.idUsuarioIngres & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("Se ha agregado el producto a Stock Exitosamente!!")
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


    Public Function ListarProducto() As DataSet
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet

        Try
            conectar()

            Dim sql As String = "SELECT * FROM PRODUCTOS "



            adaptador = New MySqlDataAdapter(sql, con)
            datos = New DataSet
            datos.Tables.Add("PRODUCTOS")
            adaptador.Fill(datos.Tables("PRODUCTOS"))
            Return datos


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectar()

        End Try

    End Function


    Public Function ListarUsuario() As DataSet
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet

        Try
            conectar()

            Dim sql As String = "SELECT * FROM USUARIOS "



            adaptador = New MySqlDataAdapter(sql, con)
            datos = New DataSet
            datos.Tables.Add("USUARIOS")
            adaptador.Fill(datos.Tables("USUARIOS"))
            Return datos


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectar()

        End Try

    End Function



    Public Function ConsultaProducto() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT INGRESOS.idIngresos, PRODUCTOS.descripcion, INGRESOS.cantidad, INGRESOS.fecha_Ingreso, INGRESOS.idUsuario, USUARIOS.nombres FROM INGRESOS  INNER JOIN PRODUCTOS   on PRODUCTOS.idProducto = INGRESOS.idProducto INNER JOIN USUARIOS on  USUARIOS.idUsuario = INGRESOS.idUsuario"



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


    Public Function ConsulaporUsuario(idu As Integer) As DataTable

        Try
            conectar()
            Dim dc As DIngresar = New DIngresar
            dc.idUsuarioIngres = idu
            Dim sql As String = "SELECT INGRESOS.idingresos, PRODUCTOS.DESCRIPCION, PRODUCTOS.marca ,PRODUCTOS.lote,INGRESOS.cantidad, INGRESOS.fecha_ingreso,USUARIOS.nombres  FROM INGRESOS INNER JOIN PRODUCTOS ON PRODUCTOS.idProducto= INGRESOS.idProducto INNER JOIN USUARIOS on USUARIOS.idUsuario=INGRESOS.idUsuario where INGRESOS.idUsuario= '" & dc.idUsuarioIngres & "'"



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




    Public Function EliminarIngreso(dc As DIngresar) As Boolean

        Try
            conectar()

            Dim sql As String = "delete from INGRESOS where INGRESOS.idIngresos = '" & dc.idIngresoProducto & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El Ingreso se ha Eliminado Exitosamente Notifique al administrador!")
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

End Class
