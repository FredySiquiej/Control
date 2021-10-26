Imports MySql.Data.MySqlClient

Public Class DSolicitarStock

    Inherits Conexion

    Private idSolicitud As Integer
    Private idProducto As Integer
    Private cantidad As Integer
    Private Descripcion As String
    Private FechaSolicitud As DateTime
    Private idUsuario As Integer


    Private cmd As MySqlCommand


    Public Sub New(id As Integer, IdProd As Integer, cant As Integer, desc As String, fec As DateTime, idUs As Integer)
        idSolicitud = id
        idProducto = IdProd
        cantidad = cant
        Descripcion = desc
        FechaSolicitud = fec
        idUsuario = idUs


    End Sub


    Public Sub New()

    End Sub


    Public Property idSolicitudStock As Integer

        Get
            Return idSolicitud
        End Get
        Set(value As Integer)
            idSolicitud = value
        End Set
    End Property

    Public Property idProductoStock As Integer

        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property

    Public Property cantidadSolicitudStock As Integer

        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property

    Public Property descripcionSolicitudStock As String

        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property


    Public Property fechaSolicitudStock As DateTime

        Get
            Return FechaSolicitud
        End Get
        Set(value As DateTime)
            FechaSolicitud = value
        End Set
    End Property


    Public Property idUsuarioStock As Integer

        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property



    Public Function insertarSolicitudStock(dc As DSolicitarStock) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO SOLICITUD_STOCK(IDPRODUCTO,CANTIDAD,DESCRIPCION,FECHASOLICITUD,IDUSUARIO) VALUES('" & dc.idProductoStock & "','" & dc.cantidadSolicitudStock & "','" & dc.descripcionSolicitudStock & "',NOW(),'" & dc.idUsuarioStock & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La  Solicitud se ha ingresado exitosamente")
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



    Public Function EliminarSolicitudStock(dc As DSolicitarStock) As Boolean

        Try
            conectar()

            Dim sql As String = "delete from SOLICITUD_STOCK where SOLICITUD_STOCK.IDSOLICITUD = '" & dc.idSolicitudStock & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La Solicitud se ha Eliminado Exitosamente !")
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




    Public Function ConsultaSolicitud() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT * FROM SOLICITUD_STOCK "



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




    Public Function modificarSolicitudStock(dc As DSolicitarStock) As Boolean

        Try
            conectar()

            Dim sql As String = "UPDATE SOLICITUD_STOCK SET IDPRODUCTO='" & dc.idProductoStock & "', CANTIDAD='" & dc.cantidadSolicitudStock & "',DESCRIPCION='" & dc.descripcionSolicitudStock & "' ,FECHASOLICITUD = NOW() ,IDUSUARIO='" & dc.idUsuarioStock & "' WHERE idSolicitud = '" & dc.idSolicitudStock & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La solicitud se ha MODIFICADO exitosamente !")
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


End Class
