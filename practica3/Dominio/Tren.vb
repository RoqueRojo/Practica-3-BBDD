Public Class Tren
    Public Property matricula As String
    Public Property tipoTren As TipoTren

    Public ReadOnly Property tDAO As TrenDAO

    Public Sub New()
        Me.tDAO = New TrenDAO
    End Sub
    Public Sub New(matricula As String)
        Me.tDAO = New TrenDAO
        Me.matricula = matricula
        Me.tipoTren = New TipoTren
    End Sub
    Public Sub leerTodosTrenes(ruta As String)
        Me.tDAO.leerTodos(ruta)
    End Sub
    Public Sub leerTren()
        Me.tDAO.leer(Me)
    End Sub
    Public Function insertarTren() As Integer
        Return Me.tDAO.insertar(Me)
    End Function

    Public Function actualizarTren() As Integer
        Return Me.tDAO.actualizar(Me)
    End Function

    Public Function borrarTren() As Integer
        Return Me.tDAO.borrar(Me)
    End Function

End Class
