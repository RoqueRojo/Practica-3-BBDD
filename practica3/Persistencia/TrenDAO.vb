Public Class TrenDAO
    Public ReadOnly Property trenes As Collection

    Sub New()
        trenes = New Collection
    End Sub
    Public Sub leerTodos(ruta As String)
        Dim t As Tren
        Dim col, aux As Collection 'aux una linea
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Trenes ORDER BY Matricula")
        For Each aux In col
            t = New Tren(aux(1).ToString)
            t.tipoTren.idTipoTren = Convert.ToInt32(aux(2).ToString)
            Me.trenes.Add(t)
        Next
    End Sub

    Public Sub leer(ByRef t As Tren)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM trenes WHERE matricula='" & t.matricula & "';")
        For Each aux In col
            t.tipoTren.idTipoTren = Convert.ToInt32(aux(2).ToString)
        Next
    End Sub
    Public Function insertar(ByVal t As Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Trenes VALUES ('" & t.matricula & "', " & t.tipoTren.idTipoTren & ");")
    End Function
    Public Function actualizar(ByVal t As Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Trenes SET TipoTren=" & t.tipoTren.idTipoTren & " WHERE Matricula='" & t.matricula & "';")
    End Function
    Public Function borrar(ByVal t As Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Trenes WHERE Matricula='" & t.matricula & "';")
    End Function
End Class
