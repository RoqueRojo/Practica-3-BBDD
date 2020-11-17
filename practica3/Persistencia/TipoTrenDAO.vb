Public Class TipoTrenDAO

    Public ReadOnly resultado As Collection
    Public Sub New()
        resultado = New Collection
    End Sub

    Public Sub leerTodos(ruta As String)
        Dim tt As TipoTren
        Dim col, aux As Collection 'aux una linea
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM tipos_tren ORDER BY IdTipoTren")
        For Each aux In col
            tt = New TipoTren(Convert.ToInt32(aux(1).ToString))
            tt.descripcionTipoTren = aux(2).ToString
            tt.capacidadMax = (Convert.ToInt32(aux(3).ToString))
            Me.resultado.Add(tt)
        Next
    End Sub
    Public Sub leer(ByRef tt As TipoTren)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM tipos_tren WHERE IdTipoTren=" & tt.idTipoTren & ";")
        For Each aux In col
            tt.descripcionTipoTren = aux(2).ToString
            tt.capacidadMax = Convert.ToInt32(aux(3).ToString())
        Next
    End Sub
    Public Sub obtenerId(ByRef tt As TipoTren)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT MAX(idTipoTren) As Total FROM tipos_tren;")
        For Each aux In col
            tt.idTipoTren = Convert.ToInt32(aux(1).ToString)
        Next
    End Sub
    Public Function insertar(ByVal tt As TipoTren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO tipos_tren (DescTipoTren,CapacidadMax) VALUES ('" & tt.descripcionTipoTren & "'," & tt.capacidadMax & ");")
    End Function
    Public Function actualizar(ByVal tt As TipoTren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE tipos_tren SET DescTipoTren='" & tt.descripcionTipoTren & "', CapacidadMax=" & tt.capacidadMax & " WHERE idTipoTren=" & tt.idTipoTren & ";")
    End Function
    Public Function borrar(ByVal tt As TipoTren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM tipos_tren WHERE idTipoTren =" & tt.idTipoTren & ";")
    End Function
    'Consulta 2
    Public Sub contarViajesTipoTren(ByRef fechaInicio As Date, ByRef fechaFin As Date)
        Dim col As Collection : Dim aux As Collection
        Dim item As ListViewItem
        col = AgenteBD.ObtenerAgente.Leer("SELECT TIPOS_TREN.DescTipoTren, Count(TIPOS_TREN.IdTipoTren) AS CuentaDeIdTipoTren FROM(TIPOS_TREN INNER JOIN TRENES On TIPOS_TREN.IdTipoTren = TRENES.TipoTren) INNER JOIN VIAJES On TRENES.Matricula = VIAJES.Tren WHERE(((VIAJES.FechaViaje) >= #" & Format(fechaInicio, "yyyy/MM/dd") & "# And (VIAJES.FechaViaje) <= #" & Format(fechaFin, "yyyy/MM/dd") & "#)) GROUP BY TIPOS_TREN.DescTipoTren ORDER BY Count(TIPOS_TREN.IdTipoTren) DESC;")
        For Each aux In col
            item = New ListViewItem(aux(1).ToString)
            item.SubItems.Add(aux(2).ToString)
            resultado.Add(item)
        Next
    End Sub

End Class
