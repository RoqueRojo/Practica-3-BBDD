Public Class ProductoDAO
    Public ReadOnly Property resultado As Collection

    Sub New()
        resultado = New Collection
    End Sub

    Public Sub leerTodos(ruta As String)
        Dim p As Producto
        Dim col, aux As Collection 'aux una linea
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Productos ORDER BY IdProducto")
        For Each aux In col
            p = New Producto(Convert.ToInt32(aux(1).ToString))
            p.descripcionProducto = aux(2).ToString
            Me.resultado.Add(p)
        Next
    End Sub
    Public Sub leer(ByRef p As Producto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Productos WHERE IdProducto=" & p.idProducto & ";")
        For Each aux In col
            p.descripcionProducto = aux(2).ToString
        Next
    End Sub
    Public Sub obtenerId(ByRef p As Producto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT MAX(idProducto) As Total FROM Productos;")
        For Each aux In col
            p.idProducto = Convert.ToInt32(aux(1).ToString)
        Next
    End Sub
    Public Function insertar(ByVal p As Producto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Productos (descripProducto) VALUES ('" & p.descripcionProducto & "');")
    End Function
    Public Function actualizar(ByVal p As Producto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Productos SET DescripProducto='" & p.descripcionProducto & "' WHERE IdProducto=" & p.idProducto & ";")
    End Function
    Public Function Borrar(ByVal p As Producto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Productos WHERE IdProducto =" & p.idProducto & ";")
    End Function
    'Consulta 3
    Public Sub contarProductosViaje(ByRef fechaInicio As Date, ByRef fechaFin As Date)
        Dim col As Collection : Dim aux As Collection
        Dim Item As ListViewItem
        col = AgenteBD.ObtenerAgente.Leer("SELECT PRODUCTOS.DescripProducto, Count(PRODUCTOS.IdProducto) AS CuentaDeIdProducto FROM PRODUCTOS INNER JOIN VIAJES ON PRODUCTOS.IdProducto = VIAJES.Producto WHERE (((VIAJES.FechaViaje)>= #" & fechaInicio & "# And (VIAJES.FechaViaje)<= #" & fechaFin & "#)) GROUP BY PRODUCTOS.DescripProducto ORDER BY Count(PRODUCTOS.IdProducto) DESC;")
        For Each aux In col
            Item = New ListViewItem(aux(1).ToString)
            Item.SubItems.Add(aux(2).ToString)
            resultado.Add(Item)
        Next
    End Sub
End Class
