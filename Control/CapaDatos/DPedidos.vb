Imports MySql.Data.MySqlClient


Public Class DPedidos

    Inherits Conexion

    Private idPedido As Integer
    Private idProducto As Integer
    Private cantidad As Integer
    Private fechaPedido As DateTime
    Private idUsuario As Integer
    Private idDepartamento As Integer


    Private cmd As MySqlCommand


    Public Sub New(id As Integer, idProd As Integer, cant As Integer, fecha As DateTime, idUs As Integer, idDepto As Integer)
        idPedido = id
        idProducto = idProd
        cantidad = cant
        fechaPedido = fecha
        idUsuario = idUs
        idDepartamento = idDepto


    End Sub


    Public Sub New()

    End Sub




    Public Property idPed As Integer

        Get
            Return idPedido
        End Get
        Set(value As Integer)
            idPedido = value
        End Set
    End Property


    Public Property idProductoPedido As Integer

        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property


    Public Property cantidadPedido As Integer

        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property


    Public Property fecPedido As DateTime

        Get
            Return fechaPedido
        End Get
        Set(value As DateTime)
            fechaPedido = value
        End Set
    End Property


    Public Property idUsuarioPedido As Integer

        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property



    Public Property idDeptoPedido As Integer

        Get
            Return idDepartamento
        End Get
        Set(value As Integer)
            idDepartamento = value
        End Set
    End Property

    Public Function insertarPedido(dc As DPedidos) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO PEDIDOS(IDPRODUCTO,CANTIDAD,FECHA_PEDIDO,IDUSUARIO,IDDEPTO) VALUES('" & dc.idProductoPedido & "','" & dc.cantidadPedido & "',NOW(),'" & dc.idUsuarioPedido & "','" & dc.idDeptoPedido & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("el PEDIDO se ha ingresado exitosamente")
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



    Public Function EliminarPedido(dc As DPedidos) As Boolean

        Try
            conectar()

            Dim sql As String = "delete from PEDIDOS where PEDIDOS.idPedidos = '" & dc.idPed & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El PEDIDO se ha Eliminado Exitosamente !")
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





    Public Function ConsultaPedido() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT PEDIDOS.idPedidos, PRODUCTOS.descripcion, PEDIDOS.cantidad, PEDIDOS.fecha_pedido, PEDIDOS.idUsuario, USUARIOS.nombres, DEPARTAMENTO.descripcion FROM PEDIDOS INNER JOIN PRODUCTOS ON PRODUCTOS.idProducto = PEDIDOS.idProducto INNER JOIN USUARIOS on USUARIOS.idUsuario = PEDIDOS.idUsuario INNER JOIN DEPARTAMENTO ON DEPARTAMENTO.idDepartamento = PEDIDOS.idDepto "



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




    Public Function modificarPedidos(dc As DPedidos) As Boolean

        Try
            conectar()

            Dim sql As String = "UPDATE PEDIDOS SET IDPRODUCTO='" & dc.idProductoPedido & "', CANTIDAD='" & dc.cantidadPedido & "',fECHA_PEDIDO= '" & dc.fechaPedido & "',IDUSUARIO='" & dc.idUsuarioPedido & "', IDDEPTO='" & dc.idDeptoPedido & "' WHERE idPedidos = '" & dc.idPed & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El PEDIDO se ha MODIFICADO exitosamente !")
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




    Public Function ListarDepartamento() As DataSet
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet

        Try
            conectar()

            Dim sql As String = "SELECT * FROM DEPARTAMENTO "



            adaptador = New MySqlDataAdapter(sql, con)
            datos = New DataSet
            datos.Tables.Add("DEPARTAMENTO")
            adaptador.Fill(datos.Tables("DEPARTAMENTO"))
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


    Public Function ConsulaporDepto(id As Integer) As DataTable

        Try
            conectar()
            Dim dc As DPedidos = New DPedidos
            dc.idDepartamento = frmCONSULTA_P_P_D.cmbDepto
            Dim sql As String = "SELECT PEDIDOS.idPedidos, PRODUCTOS.DESCRIPCION, PRODUCTOS.marca ,PRODUCTOS.lote,PEDIDOS.cantidad, PEDIDOS.fecha_pedido,USUARIOS.nombres, DEPARTAMENTO.DESCRIPCION  FROM PEDIDOS INNER JOIN PRODUCTOS ON PRODUCTOS.idProducto= PEDIDOS.idProducto INNER JOIN USUARIOS on USUARIOS.idUsuario=PEDIDOS.idUsuario INNER JOIN DEPARTAMENTO ON DEPARTAMENTO.idDepartamento=PEDIDOS.idDepto where idDepto= '" & dc.idDeptoPedido & "'"



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
            Dim dc As DPedidos = New DPedidos
            dc.idUsuarioPedido = idu
            Dim sql As String = "SELECT PEDIDOS.idPedidos, PRODUCTOS.DESCRIPCION, PRODUCTOS.marca ,PRODUCTOS.lote,PEDIDOS.cantidad, PEDIDOS.fecha_pedido,USUARIOS.nombres, DEPARTAMENTO.DESCRIPCION  FROM PEDIDOS INNER JOIN PRODUCTOS ON PRODUCTOS.idProducto= PEDIDOS.idProducto INNER JOIN USUARIOS on USUARIOS.idUsuario=PEDIDOS.idUsuario INNER JOIN DEPARTAMENTO ON DEPARTAMENTO.idDepartamento=PEDIDOS.idDepto where PEDIDOS.idUsuario= '" & dc.idUsuarioPedido & "'"



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
