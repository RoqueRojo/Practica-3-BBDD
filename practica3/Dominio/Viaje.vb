Public Class Viaje
    Public Property fechaViaje As Date
    Public Property trenViaje As Tren
    Public Property productoTransportado As Producto
    Public Property toneladasTransportadas As Integer
    Public ReadOnly Property vDAO As ViajeDAO

    Public Sub New()
        Me.vDAO = New ViajeDAO()
    End Sub
    Public Sub New(fechaViaje As Date, matriculaTren As String, idProductoTransportado As Integer)
        Me.vDAO = New ViajeDAO
        Me.fechaViaje = fechaViaje
        Me.trenViaje = New Tren(matriculaTren)
        Me.productoTransportado = New Producto(idProductoTransportado)
    End Sub
    Public Sub leerTodosViajes(ruta As String)
        Me.vDAO.leerTodos(ruta)
    End Sub
    Public Sub leerViaje()
        Me.vDAO.leer(Me)
    End Sub
    Public Function comprobarDisponibilidadFechaViaje()
        Return Me.vDAO.comprobarDisponibilidadFecha(Me)
    End Function
    Public Function insertarViaje() As Integer
        Return Me.vDAO.insertar(Me)
    End Function
    Public Function actualizarViaje(viajeModificado As Viaje) As Integer
        Return Me.vDAO.actualizar(Me, viajeModificado)
    End Function
    Public Function borrarViaje() As Integer
        Return Me.vDAO.borrar(Me)
    End Function
    'Consulta 1
    Public Function contarNumeroViajes(fechaInicio As Date, fechaFin As Date, matricula As String) As Integer
        Return vDAO.contarNumeroViajes(fechaInicio, fechaFin, matricula)
    End Function
    Public Sub listarProductoViaje(fechaInicio As Date, fechaFin As Date, matricula As String)
        vDAO.listarProductosEntreDosFechas(fechaInicio, fechaFin, matricula)
    End Sub
    'Consulta 4
    Public Sub viajeMayorBeneficio()
        vDAO.mayorBeneficio()
    End Sub

End Class
