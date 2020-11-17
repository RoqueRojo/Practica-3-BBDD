Public Class CotizacionDAO
    Public ReadOnly Property cotizaciones As Collection
    Sub New()
        cotizaciones = New Collection
    End Sub
    Public Sub leerTodos(ruta As String)
        Dim c As Cotizacion
        Dim col, aux As Collection 'aux una linea
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM COTIZACIONES ORDER BY Fecha")
        For Each aux In col
            c = New Cotizacion(Convert.ToInt32(aux(1).ToString), Convert.ToDateTime(aux(2).ToString))
            c.eurosPorTonelada = Convert.ToDouble(aux(3).ToString)
            Me.cotizaciones.Add(c)
        Next
    End Sub
    Public Sub leer(ByRef c As Cotizacion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM COTIZACIONES WHERE Producto=" & c.producto.idProducto & ", fecha=#" & Format(c.fecha, "yyyy/MM/dd") & "#;")
        For Each aux In col
            c.eurosPorTonelada = Convert.ToDouble(aux(3).ToString)
        Next
    End Sub
    Public Function insertar(ByVal c As Cotizacion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Cotizaciones VALUES (" & c.producto.idProducto & ", #" & Format(c.fecha, "yyyy/MM/dd") & "#, '" & c.eurosPorTonelada & "');")
    End Function
    Public Function actualizar(ByVal c As Cotizacion, ByVal cotizacionModificada As Cotizacion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Cotizaciones SET Producto=" & cotizacionModificada.producto.idProducto & ", fecha=#" & Format(cotizacionModificada.fecha, "yyyy/MM/dd") & "#, EurosPorTonelada='" & cotizacionModificada.eurosPorTonelada & "' WHERE Producto=" & c.producto.idProducto & " AND fecha= #" & Format(c.fecha, "yyyy/MM/dd") & "#; ")
    End Function
    Public Function borrar(ByVal c As Cotizacion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Cotizaciones WHERE Producto =" & c.producto.idProducto & " AND fecha= #" & Format(c.fecha, "yyyy/MM/dd") & "#;")
    End Function

End Class
