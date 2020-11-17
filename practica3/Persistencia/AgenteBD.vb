Public Class AgenteBD

    Private Shared _instancia As AgenteBD
    Private Shared conexion As OleDb.OleDbConnection
    Private Const cadenaConexionBase As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared cadenaConexion As String

    Private Sub New()
        AgenteBD.conexion = New OleDb.OleDbConnection(AgenteBD.cadenaConexion)
        AgenteBD.conexion.Open()
    End Sub

    Public Shared Function ObtenerAgente() As AgenteBD
        If AgenteBD._instancia Is Nothing Then
            AgenteBD._instancia = New AgenteBD
        End If
        Return AgenteBD._instancia
    End Function

    Public Shared Function ObtenerAgente(ruta As String) As AgenteBD
        AgenteBD.cadenaConexion = AgenteBD.cadenaConexionBase & ruta
        Return AgenteBD.ObtenerAgente
    End Function

    Public Function Leer(sql As String) As Collection
        Dim result As New Collection
        Dim fila As Collection
        Dim i As Integer
        Dim reader As OleDb.OleDbDataReader 'Almacena toda la información de la consulta'
        Dim com As New OleDb.OleDbCommand(sql, AgenteBD.conexion)
        Conectar()
        reader = com.ExecuteReader
        While reader.Read
            fila = New Collection
            For i = 0 To reader.FieldCount - 1
                fila.Add(reader(i).ToString) 'i número de columnas de las cuales queremos leer un valor'
            Next
            result.Add(fila)
        End While
        Desconectar()
        Return result
    End Function

    Public Function Modificar(sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, AgenteBD.conexion)
        Dim result As Integer
        Conectar()
        result = com.ExecuteNonQuery 'Devuelve el número de filas afectadas'
        Desconectar()
        Return result
    End Function

    Private Sub Conectar()
        If AgenteBD.conexion.State = ConnectionState.Closed Then
            AgenteBD.conexion.Open()
        End If
    End Sub

    Private Sub Desconectar()
        If AgenteBD.conexion.State = ConnectionState.Open Then
            AgenteBD.conexion.Close()
        End If
    End Sub

End Class
