Public Class Producto
    Public Property idProducto As Integer
    Public Property descripcionProducto As String
    Public ReadOnly Property pDAO As ProductoDAO

    Public Sub New()
        Me.pDAO = New ProductoDAO
    End Sub

    Public Sub New(idProducto As Integer)
        Me.pDAO = New ProductoDAO
        Me.idProducto = idProducto
    End Sub

    Public Sub leerTodosProductos(ruta As String)
        Me.pDAO.leerTodos(ruta)
    End Sub

    Public Sub leerProducto()
        Me.pDAO.leer(Me)
    End Sub
    Public Sub obtenerIdProducto()
        Me.pDAO.obtenerId(Me)
    End Sub
    Public Function insertarProducto() As Integer
        Return pDAO.insertar(Me)
    End Function

    Public Function actualizarProducto() As Integer
        Return pDAO.actualizar(Me)
    End Function

    Public Function borrarProducto() As Integer
        Return pDAO.Borrar(Me)
    End Function
    'Consulta 3
    Public Sub rankingProducto(fechaInicio As Date, fechaFin As Date)
        pDAO.contarProductosViaje(fechaInicio, fechaFin)

    End Sub

End Class
