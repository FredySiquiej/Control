Imports MySql.Data.MySqlClient

Public Class DDevoluciones


    Inherits Conexion

    Private idDefectuoso As Integer
    Private idPedido As Integer
    Private descripcion As String
    Private cantidad As Integer
    Private fechaDevolucion As DateTime
    Private idUsuario As Integer

    Private cmd As MySqlCommand


    Public Sub New(id As Integer, idPed As Integer, desc As String, cant As Integer, fecha As Date, idUs As Integer)
        idDefectuoso = id
        idPedido = idPed
        descripcion = desc
        cantidad = cant
        fechaDevolucion = fecha
        idUsuario = idUs

    End Sub

    Public Sub New()

        End Sub

    Public Property idDefec As Integer

        Get
            Return idDefectuoso
        End Get
        Set(value As Integer)
            idDefectuoso = value
        End Set
    End Property

    Public Property idPedidoDefectuoso As Integer

        Get
            Return idPedido
        End Get
        Set(value As Integer)
            idPedido = value
        End Set
    End Property

    Public Property descripcionDefectuoso As String

        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property cantidadDefectuoso As Integer

        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property

    Public Property fechaDevolucionDefectuoso As DateTime

        Get
            Return fechaDevolucion
        End Get
        Set(value As DateTime)
            fechaDevolucion = value
        End Set
    End Property

    Public Property idusuarioDefectuoso As Integer

        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property



    Public Function insertarDefectuoso(dc As DDevoluciones) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO DEVOLUCIONES(IDPEDIDO,DESCRIPCION,CANTIDAD,FECHADEVOLUCION,IDUSUARIO) VALUES('" & dc.idPedidoDefectuoso & "','" & dc.descripcionDefectuoso & "','" & dc.cantidadDefectuoso & "', now(),'" & dc.idusuarioDefectuoso & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La Devolucion se ha ingresado exitosamente!!")
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



    Public Function EliminarDefectuoso(dc As DDevoluciones) As Boolean

        Try
            conectar()

            Dim sql As String = "delete from DEVOLUCIONES where DEVOLUCIONES.idDefectuoso = '" & dc.idDefec & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La Devolucion se ha Eliminado Exitosamente !")
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


    Public Function modificarDefectuoso(dc As DDevoluciones) As Boolean

        Try
            conectar()

            Dim sql As String = "UPDATE DEVOLUCIONES SET IDPEDIDO='" & dc.idPedidoDefectuoso & "', DESCRIPCION='" & dc.descripcionDefectuoso & "',CANTIDAD='" & dc.cantidadDefectuoso & "' ,FECHADEVOLUCION= NOW(),IDUSUARIO='" & dc.idusuarioDefectuoso & "'  WHERE idDefectuoso = '" & dc.idDefec & "' "



            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                MsgBox("La Devolucion se ha MODIFICADO exitosamente !")
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



    Public Function ConsultaDefectuoso() As DataTable

        Try
            conectar()

            Dim sql As String = "SELECT * FROM DEVOLUCIONES "



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
