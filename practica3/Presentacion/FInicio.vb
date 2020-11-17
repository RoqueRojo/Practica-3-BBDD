Imports practica3.FGeneral
Public Class FInicio
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Me.ofdRuta.InitialDirectory = Application.StartupPath
        If (Me.ofdRuta.ShowDialog() = DialogResult.OK) Then
            Me.txtRuta.Text = Me.ofdRuta.FileName ' en la caja de texto poner la ruta del fichero
            Me.btnConectar.Enabled = True
        End If

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim t As Tren = New Tren
        Dim p As Producto = New Producto
        Dim tt As TipoTren = New TipoTren
        Dim c As Cotizacion = New Cotizacion
        Dim v As Viaje = New Viaje

        Try
            'leemos todos los datos existentes
            t.leerTodosTrenes(Me.ofdRuta.FileName)
            p.leerTodosProductos(Me.ofdRuta.FileName)
            tt.leerTodosTiposTren(Me.ofdRuta.FileName)
            c.leerTodasCotizaciones(Me.ofdRuta.FileName)
            v.leerTodosViajes(Me.ofdRuta.FileName)
            MessageBox.Show("¿Qué hay de nuevo viejo? Te has conectado correctamente.")
            FGeneral.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Debes seleccionar primero una base de datos. Íntentalo otra vez.")
            Exit Sub
        End Try



    End Sub


End Class