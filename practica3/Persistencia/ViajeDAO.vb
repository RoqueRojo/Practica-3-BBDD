Public Class ViajeDAO

    Public ReadOnly Property resultado As Collection

    Sub New()
        resultado = New Collection
    End Sub

    Public Sub leerTodos(ruta As String)
        Dim v As Viaje
        Dim col, aux As Collection 'aux una linea
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Viajes ORDER BY fechaViaje")
        For Each aux In col
            v = New Viaje(Convert.ToDateTime(aux(1).ToString), aux(2).ToString, Convert.ToInt32(aux(3)))
            v.toneladasTransportadas = Convert.ToInt32(aux(4).ToString)
            Me.resultado.Add(v)
        Next
    End Sub

    Public Sub leer(ByRef v As Viaje)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Viajes WHERE fechaViaje=#" & Format(v.fechaViaje, "yyyy/MM/dd") & "# AND tren = '" & v.trenViaje.matricula & "' AND producto=" & v.productoTransportado.idProducto & ";")
        For Each aux In col
            v.toneladasTransportadas = Convert.ToInt32(aux(4).ToString)
        Next
    End Sub

    Public Function comprobarDisponibilidadFecha(v As Viaje) As Boolean
        Return AgenteBD.ObtenerAgente.Leer("SELECT FechaViaje, Tren FROM Viajes WHERE (FechaViaje=#" & Format(v.fechaViaje, "yyyy/MM/dd") & "# AND Tren='" & v.trenViaje.matricula & "');").Count = 0
    End Function

    Public Function insertar(ByVal v As Viaje) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Viajes VALUES (#" & Format(v.fechaViaje, "yyyy/MM/dd") & "#,'" & v.trenViaje.matricula & "', " & v.productoTransportado.idProducto & "," & v.toneladasTransportadas & ");")
    End Function

    Public Function actualizar(ByVal v As Viaje, ByVal viajeModificado As Viaje) As Integer

        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Viajes SET FechaViaje= #" & Format(viajeModificado.fechaViaje, "yyyy/MM/dd") & "#, Tren= '" & viajeModificado.trenViaje.matricula & "', producto = " & viajeModificado.productoTransportado.idProducto & ", ToneladasTransportadas=" & viajeModificado.toneladasTransportadas & " WHERE fechaViaje=#" & Format(v.fechaViaje, "yyyy/MM/dd") & "# AND tren = '" & v.trenViaje.matricula & "' AND producto=" & v.productoTransportado.idProducto & ";")
    End Function

    Public Function borrar(ByVal v As Viaje) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Viajes WHERE fechaViaje=#" & Format(v.fechaViaje, "yyyy/MM/dd") & "# AND tren = '" & v.trenViaje.matricula & "' AND producto=" & v.productoTransportado.idProducto & ";")
    End Function
    'Consulta 1
    Public Function contarNumeroViajes(ByRef fechaInicio As Date, ByRef fechaFin As Date, ByRef matriculaTren As String) As Integer
        Dim col As Collection : Dim aux As Collection : Dim numeroViajes As Integer
        col = AgenteBD.ObtenerAgente.Leer("SELECT Count(VIAJES.FechaViaje) AS CuentaDeFechaViaje FROM VIAJES WHERE (((VIAJES.Tren)='" & matriculaTren & "') AND ((VIAJES.FechaViaje)>= #" & Format(fechaInicio, "yyyy/MM/dd") & "# And (VIAJES.FechaViaje)<= #" & Format(fechaFin, "yyyy/MM/dd") & "#));")
        For Each aux In col
            numeroViajes = aux(1)
        Next
        Return numeroViajes
    End Function
    Public Sub listarProductosEntreDosFechas(ByRef fechaInicio As Date, ByRef fechaFin As Date, ByRef matriculaTren As String)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT DISTINCT PRODUCTOS.DescripProducto From PRODUCTOS INNER Join VIAJES On PRODUCTOS.IdProducto = VIAJES.Producto Where (((VIAJES.Tren) = '" & matriculaTren & "') And ((VIAJES.FechaViaje) >= #" & Format(fechaInicio, "yyyy/MM/dd") & "# And (VIAJES.FechaViaje) <=#" & Format(fechaFin, "yyyy/MM/dd") & "#));")
        For Each aux In col
            resultado.Add(aux(1))
        Next
    End Sub
    'Consulta 4
    Public Sub mayorBeneficio()
        Dim col As Collection : Dim aux As Collection
        Dim Item As ListViewItem
        col = AgenteBD.ObtenerAgente.Leer("SELECT Consulta2.FechaViaje, Consulta2.Tren, TIPOS_TREN.DescTipoTren, Consulta2.DescripProducto, Consulta2.FechaCot, Consulta2.EurosPorTonelada, Consulta2.Cantidad, Consulta2.Beneficio
        FROM (SELECT Consulta1.FechaViaje, Consulta1.Tren, Consulta1.FechaCot, Consulta1.Cantidad, COTIZACIONES.EurosPorTonelada, PRODUCTOS.DescripProducto, [EurosPorTonelada]*[Cantidad] AS Beneficio
        FROM (COTIZACIONES INNER JOIN (SELECT VIAJES.FechaViaje, VIAJES.Tren, Max(COTIZACIONES.Fecha) AS FechaCot, PRODUCTOS.IdProducto, First(VIAJES.ToneladasTransportadas) AS Cantidad FROM (PRODUCTOS INNER JOIN COTIZACIONES ON PRODUCTOS.IdProducto = COTIZACIONES.Producto) INNER JOIN VIAJES ON PRODUCTOS.IdProducto = VIAJES.Producto GROUP BY VIAJES.FechaViaje, VIAJES.Tren, PRODUCTOS.IdProducto)  AS Consulta1 ON (COTIZACIONES.Fecha = Consulta1.FechaCot) AND (COTIZACIONES.Producto = Consulta1.IdProducto)) INNER JOIN PRODUCTOS ON Consulta1.IdProducto = PRODUCTOS.IdProducto
        WHERE (((Consulta1.FechaViaje)>=[Consulta1].[FechaCot]))) as Consulta2 INNER JOIN (TIPOS_TREN INNER JOIN TRENES ON TIPOS_TREN.IdTipoTren = TRENES.TipoTren) ON Consulta2.Tren = TRENES.Matricula
        WHERE (((Consulta2.Beneficio)=(SELECT MAX(BENEFICIO) FROM (SELECT Consulta1.FechaViaje, Consulta1.Tren, Consulta1.FechaCot, Consulta1.Cantidad, COTIZACIONES.EurosPorTonelada, PRODUCTOS.DescripProducto, [EurosPorTonelada]*[Cantidad] AS Beneficio
        FROM (COTIZACIONES INNER JOIN (SELECT VIAJES.FechaViaje, VIAJES.Tren, Max(COTIZACIONES.Fecha) AS FechaCot, PRODUCTOS.IdProducto, First(VIAJES.ToneladasTransportadas) AS Cantidad FROM (PRODUCTOS INNER JOIN COTIZACIONES ON PRODUCTOS.IdProducto = COTIZACIONES.Producto) INNER JOIN VIAJES ON PRODUCTOS.IdProducto = VIAJES.Producto GROUP BY VIAJES.FechaViaje, VIAJES.Tren, PRODUCTOS.IdProducto)  AS Consulta1 ON (COTIZACIONES.Fecha = Consulta1.FechaCot) AND (COTIZACIONES.Producto = Consulta1.IdProducto)) INNER JOIN PRODUCTOS ON Consulta1.IdProducto = PRODUCTOS.IdProducto
        WHERE (((Consulta1.FechaViaje)>=[Consulta1].[FechaCot]))))));")
        For Each aux In col
            Item = New ListViewItem(CDate(aux(1)))
            Item.SubItems.Add(aux(2).ToString)
            Item.SubItems.Add(aux(3).ToString)
            Item.SubItems.Add(aux(4).ToString)
            Item.SubItems.Add(CDate(aux(5)))
            Item.SubItems.Add(Convert.ToInt32(aux(6)))
            Item.SubItems.Add(Convert.ToDouble(aux(7)))
            Item.SubItems.Add(Convert.ToDouble(aux(8)))
            resultado.Add(Item)
        Next
    End Sub
End Class
