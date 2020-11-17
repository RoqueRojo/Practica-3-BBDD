Public Class TipoTren
    Public Property idTipoTren As Integer
    Public Property descripcionTipoTren As String
    Public Property capacidadMax As Integer

    Public ReadOnly TipoTDAO As TipoTrenDAO

    Public Sub New()
        Me.TipoTDAO = New TipoTrenDAO()
    End Sub
    Public Sub New(idTipoTren As Integer)
        Me.TipoTDAO = New TipoTrenDAO
        Me.idTipoTren = idTipoTren
    End Sub
    Public Sub leerTodosTiposTren(ruta As String)
        Me.TipoTDAO.leerTodos(ruta)
    End Sub

    Public Sub leerTipoTren()
        Me.TipoTDAO.leer(Me)
    End Sub
    Public Sub ObtenerIdTipoTren()
        Me.TipoTDAO.obtenerId(Me)
    End Sub
    Public Function insertarTipoTren() As Integer
        Return TipoTDAO.insertar(Me)
    End Function
    Public Function actualizarTipoTren() As Integer
        Return TipoTDAO.actualizar(Me)
    End Function
    Public Function borrarTipoTren() As Integer
        Return TipoTDAO.borrar(Me)
    End Function
    'Consulta 2
    Public Sub rankingTipoTren(fechaInicio As Date, fechaFin As Date)
        Me.TipoTDAO.contarViajesTipoTren(fechaInicio, fechaFin)
    End Sub
End Class
