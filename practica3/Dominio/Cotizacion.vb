Public Class Cotizacion
    Public Property producto As Producto
    Public Property fecha As Date
    Public Property eurosPorTonelada As Double
    Public ReadOnly Property cotDAO As CotizacionDAO
    Public Sub New()
        Me.cotDAO = New CotizacionDAO
    End Sub
    Public Sub New(idProducto As Integer, fecha As Date)
        Me.cotDAO = New CotizacionDAO
        Me.producto = New Producto(idProducto)
        Me.fecha = fecha
    End Sub
    Public Sub leerTodasCotizaciones(ruta As String)
        Me.cotDAO.leerTodos(ruta)
    End Sub

    Public Sub leerCotizacion()
        Me.cotDAO.leer(Me)
    End Sub

    Public Function insertarCotizacion() As Integer
        Return cotDAO.insertar(Me)
    End Function

    Public Function actualizarCotizacion(cotizacionModificada As Cotizacion) As Integer
        Return cotDAO.actualizar(Me, cotizacionModificada)
    End Function

    Public Function borrarCotizacion() As Integer
        Return cotDAO.borrar(Me)
    End Function

End Class
