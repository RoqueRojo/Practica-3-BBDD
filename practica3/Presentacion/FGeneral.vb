
Public Class FGeneral
    'Parte necesaria para poder añadir una acción al botón de cerrar'
    Private m_iMessage As Integer
    Private Shared WM_QUERYENDSESSION As Integer = &H11 'logoff
    Private Shared WM_FORMCONTROLMENU As Integer = 16 'cerrar form con el control menú

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        m_iMessage = m.Msg
        MyBase.WndProc(m)
    End Sub
    'Metodo creado para simplificar codigo repetitivo de añadir una cotizacion al listview
    Private Sub añadirCotizacionListView(idProducto As Integer, descripcion As String, fecha As Date, euros As Double)
        Dim Item As New ListViewItem(idProducto)
        Item.SubItems.Add(descripcion)
        Item.SubItems.Add(fecha)
        Item.SubItems.Add(euros)
        lstCotizaciones.Items.Add(Item)
    End Sub
    'Metodo creado para simplificar codigo repetitivo de añadir un viaje al listview
    Private Sub añadirViajeListView(idProducto As Integer, fecha As Date, matriculaTren As String, productoTransportado As String, toneladasTransportadas As Integer)
        Dim Item As New ListViewItem(idProducto)
        Item.SubItems.Add(fecha)
        Item.SubItems.Add(matriculaTren)
        Item.SubItems.Add(productoTransportado)
        Item.SubItems.Add(toneladasTransportadas)
        lstViajes.Items.Add(Item)
    End Sub
    'Metodo creado para simplificar codigo repetitivo de añadir del CB
    Public Sub añadirTrenesCB(matricula As String)
        cbMatriculaTren.Items.Add(matricula)
        cbConsulta1.Items.Add(matricula)
    End Sub
    'Metodo creado para simplificar codigo repetitivo de borrar del CB
    Public Sub borrarTrenesCB(matricula As String)
        cbMatriculaTren.Items.Remove(matricula)
        cbConsulta1.Items.Remove(matricula)
    End Sub

    Private Sub btnEmpezars_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        Dim t As Tren = New Tren
        Dim p As Producto = New Producto
        Dim tt As TipoTren = New TipoTren
        Dim c As Cotizacion = New Cotizacion
        Dim v As Viaje = New Viaje

        'leemos todos los datos existentes
        t.leerTodosTrenes(Me.ofdRuta.FileName)
        p.leerTodosProductos(Me.ofdRuta.FileName)
        tt.leerTodosTiposTren(Me.ofdRuta.FileName)
        c.leerTodasCotizaciones(Me.ofdRuta.FileName)
        v.leerTodosViajes(Me.ofdRuta.FileName)

        'Creacion DataTable para los listbox
        Dim dataTableProducto As New DataTable
        dataTableProducto.Columns.Add("id", GetType(String))
        dataTableProducto.Columns.Add("descripcion", GetType(String))
        lstProductos.DisplayMember = "descripcion" 'lo que se muestra
        lstProductos.ValueMember = "id" 'lo que te devuelve para tener el id
        cbProducto.DisplayMember = "descripcion"
        cbProducto.ValueMember = "id"
        cbProductoTransportado.DisplayMember = "descripcion"
        cbProductoTransportado.ValueMember = "id"

        Dim dataTableTiposTrenes As New DataTable
        dataTableTiposTrenes.Columns.Add("idTipoTren", GetType(String))
        dataTableTiposTrenes.Columns.Add("descripcion", GetType(String))
        dataTableTiposTrenes.Columns.Add("capacidadMax", GetType(String))
        lstTiposTrenes.DisplayMember = "descripcion"
        lstTiposTrenes.ValueMember = "idTipoTren"
        cbTipoTren.DisplayMember = "descripcion"
        cbTipoTren.ValueMember = "idTipoTren"

        Dim dataTableTrenes As New DataTable
        dataTableTrenes.Columns.Add("matricula", GetType(String))
        dataTableTrenes.Columns.Add("idTipoTren", GetType(String))
        lstTrenes.DisplayMember = "matricula"
        lstTrenes.ValueMember = "idTipoTren"
        'Cargar Datos listbox
        For Each pr As Producto In p.pDAO.resultado
            dataTableProducto.Rows.Add(pr.idProducto, pr.descripcionProducto)
        Next
        cbProducto.DataSource = dataTableProducto
        cbProductoTransportado.DataSource = dataTableProducto
        lstProductos.DataSource = dataTableProducto
        lstProductos.ClearSelected()

        For Each tTren As TipoTren In tt.TipoTDAO.resultado
            dataTableTiposTrenes.Rows.Add(tTren.idTipoTren, tTren.descripcionTipoTren, tTren.capacidadMax)
        Next
        lstTiposTrenes.DataSource = dataTableTiposTrenes
        cbTipoTren.DataSource = dataTableTiposTrenes
        lstTiposTrenes.ClearSelected()

        For Each tr As Tren In t.tDAO.trenes
            dataTableTrenes.Rows.Add(tr.matricula, tr.tipoTren.idTipoTren)
            añadirTrenesCB(tr.matricula)
        Next
        lstTrenes.DataSource = dataTableTrenes

        lstTrenes.ClearSelected()

        'Cargar datos ListView
        Dim pro As Producto 'obtener descripcion
        For Each cc As Cotizacion In c.cotDAO.cotizaciones
            pro = New Producto(cc.producto.idProducto)
            pro.leerProducto()
            añadirCotizacionListView(cc.producto.idProducto, pro.descripcionProducto, cc.fecha, cc.eurosPorTonelada)
        Next

        For Each viaje As Viaje In v.vDAO.resultado
            pro = New Producto(viaje.productoTransportado.idProducto)
            pro.leerProducto()
            añadirViajeListView(viaje.productoTransportado.idProducto, viaje.fechaViaje, viaje.trenViaje.matricula, pro.descripcionProducto, viaje.toneladasTransportadas)
        Next
        'Beep beep e imagenes
        My.Computer.Audio.Play(My.Resources.btnempezar, AudioPlayMode.Background)
        btnEmpezar.Visible = False
        lblproveedor.Visible = False
        imghauling.Visible = True
        'Habilitamos el tabControler una vez damos a empezar
        TabGeneral.Enabled = True


    End Sub

    'Añadir
    Private Sub bntAnadirProducto_Click(sender As Object, e As EventArgs) Handles bntAnadirProducto.Click
        Dim pro As Producto
        If Me.txtDescripcion.Text <> String.Empty Then
            pro = New Producto()
            pro.descripcionProducto = Me.txtDescripcion.Text
            Try
                If pro.insertarProducto() <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim datos As DataTable = CType(lstProductos.DataSource, DataTable)
                pro.obtenerIdProducto()
                datos.Rows.Add(pro.idProducto, pro.descripcionProducto)
                cbProducto.DataSource = datos
                cbProductoTransportado.DataSource = datos
                lstProductos.DataSource = datos

                MessageBox.Show(pro.descripcionProducto.ToString & " Insertado correctamente")

                bntAnadirProducto.Enabled = True
                bntBorrarProducto.Enabled = False
                bntModificarProducto.Enabled = False
                bntLimpiarProducto.Enabled = False
                lstProductos.ClearSelected()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntAnadirTT_Click(sender As Object, e As EventArgs) Handles bntAnadirTT.Click
        Dim tt As TipoTren
        If Me.txtDescripcionTT.Text <> String.Empty And Me.txtCapacidadMax.Text <> String.Empty Then
            tt = New TipoTren()
            tt.descripcionTipoTren = Me.txtDescripcionTT.Text
            If Not (IsNumeric(Me.txtCapacidadMax.Text)) Then
                MessageBox.Show("El valor introducido no es numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            tt.capacidadMax = CInt(Me.txtCapacidadMax.Text)
            Try
                If tt.insertarTipoTren <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim datos As DataTable = CType(lstTiposTrenes.DataSource, DataTable)
                tt.ObtenerIdTipoTren()
                datos.Rows.Add(tt.idTipoTren, tt.descripcionTipoTren, tt.capacidadMax)
                cbTipoTren.DataSource = datos
                lstTiposTrenes.DataSource = datos
                MessageBox.Show(tt.descripcionTipoTren.ToString & " Insertado correctamente")
                bntAnadirTT.Enabled = True
                bntBorrarTT.Enabled = False
                bntModificarTT.Enabled = False
                bntLimpiarTT.Enabled = False
                lstTiposTrenes.ClearSelected()
                bntLimpiarTT.PerformClick()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntAnadirTren_Click(sender As Object, e As EventArgs) Handles bntAnadirTren.Click
        Dim t As Tren
        If Me.cbTipoTren.SelectedValue <> Nothing And Me.txtMatricula.Text <> String.Empty Then
            t = New Tren(Me.txtMatricula.Text)
            't.matricula = Me.txtMatricula.Text
            t.tipoTren.idTipoTren = CInt(Me.cbTipoTren.SelectedValue)
            Try
                If t.insertarTren <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim datos As DataTable = CType(lstTrenes.DataSource, DataTable)
                datos.Rows.Add(t.matricula, t.tipoTren.idTipoTren)
                añadirTrenesCB(t.matricula)
                lstTrenes.DataSource = datos
                MessageBox.Show(t.matricula.ToString & " Insertado correctamente")
                bntAnadirTren.Enabled = True
                bntBorrarTren.Enabled = False
                bntModificarTren.Enabled = False
                bntLimpiarTren.Enabled = False
                lstTrenes.ClearSelected()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntAnadirCotizacion_Click(sender As Object, e As EventArgs) Handles bntAnadirCotizacion.Click
        Dim c As Cotizacion
        If Me.cbProducto.SelectedValue IsNot Nothing And Me.dtpFecha.Text <> String.Empty And Me.txtEurosPorTonelada.Text <> String.Empty Then
            c = New Cotizacion(CInt(Me.cbProducto.SelectedValue), CDate(Me.dtpFecha.Text))
            If Not (IsNumeric(Me.txtEurosPorTonelada.Text)) Then
                MessageBox.Show("No se ha introducido un valor numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            c.eurosPorTonelada = Convert.ToDouble(Replace(Me.txtEurosPorTonelada.Text, ".", ","))
            Try
                If c.insertarCotizacion <> 1 Then
                    MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                añadirCotizacionListView(c.producto.idProducto, cbProducto.SelectedItem(1), c.fecha, c.eurosPorTonelada)
                MessageBox.Show("Cotización De " & cbProducto.SelectedItem(1).ToString & " en la fecha: " & c.fecha & " añadida correctamente.")
                bntAnadirCotizacion.Enabled = True
                bntBorrarCotizacion.Enabled = False
                bntModificarCotizacion.Enabled = False
                bntLimpiarCotizacion.Enabled = False
                lstCotizaciones.SelectedIndices.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntAnadirViaje_Click(sender As Object, e As EventArgs) Handles bntAnadirViaje.Click
        Dim v As Viaje
        If Me.cbProductoTransportado.SelectedValue IsNot Nothing And Me.dtpFechaViaje.Text <> String.Empty And Me.txtToneladasTransportadas.Text <> String.Empty And Me.cbMatriculaTren.SelectedItem IsNot Nothing Then
            v = New Viaje(CDate(Me.dtpFechaViaje.Text), cbMatriculaTren.SelectedItem.ToString, CInt(Me.cbProductoTransportado.SelectedValue))
            v.trenViaje.leerTren()
            v.trenViaje.tipoTren.leerTipoTren()
            'Comprobamos si esta disponible el tren en esta fecha
            If (v.comprobarDisponibilidadFechaViaje = False) Then
                MessageBox.Show("Error este tren ya ha realizado un viaje en esta fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Comrobamos que el valor de las toneladas sea numerico
            If Not (IsNumeric(Me.txtToneladasTransportadas.Text)) Then
                MessageBox.Show("No se ha introducido un valor numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Comprobamos que el valor introducido en el campo de toneladas sea un entero.
            If (Replace(Me.txtToneladasTransportadas.Text, ".", ",") Mod 1) Then
                MessageBox.Show("Error el numero de toneladas transportadas no es un entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Comprobamos si la capacidad del tren permite crear el viaje
            If (v.trenViaje.tipoTren.capacidadMax < Me.txtToneladasTransportadas.Text) Then
                MessageBox.Show("Error el tren" & v.trenViaje.matricula & "que ha seleccionado no dispone de capacidad suficiente para transportar" & Me.txtToneladasTransportadas.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            v.toneladasTransportadas = CInt(Me.txtToneladasTransportadas.Text)

                Try
                    If v.insertarViaje <> 1 Then
                        MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    añadirViajeListView(v.productoTransportado.idProducto, v.fechaViaje, v.trenViaje.matricula, cbProductoTransportado.SelectedItem(1), v.toneladasTransportadas)
                    MessageBox.Show("Viaje insertado correctamente")

                    bntAnadirViaje.Enabled = True
                    bntBorrarViaje.Enabled = False
                    bntModificarViaje.Enabled = False
                    bntLimpiarViaje.Enabled = False
                    lstViajes.SelectedIndices.Clear()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
            bntLimpiarViaje.PerformClick()

    End Sub
    'Modificar
    Private Sub bntModificarProducto_Click(sender As Object, e As EventArgs) Handles bntModificarProducto.Click
        Dim p As Producto = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.txtDescripcion.Text <> String.Empty And lstProductos.SelectedItem IsNot Nothing Then
            p = New Producto(Convert.ToInt32(lstProductos.SelectedValue)) 'devuelve el id seleccionado
            p.descripcionProducto = Me.txtDescripcion.Text
            Try
                If p.actualizarProducto() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim datos As DataTable = CType(lstProductos.DataSource, DataTable) 'actualizar la lista en tiempo real, sacando el row y volviendolo a meter cargado
                datos.Rows(lstProductos.SelectedIndex).Item(1) = txtDescripcion.Text
                lstProductos.DataSource = datos
                MessageBox.Show(p.descripcionProducto.ToString & " Actualizado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntModificarTT_Click(sender As Object, e As EventArgs) Handles bntModificarTT.Click
        Dim tt As TipoTren = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.txtDescripcionTT.Text <> String.Empty And Me.txtCapacidadMax.Text <> String.Empty And lstTiposTrenes.SelectedItem IsNot Nothing Then
            tt = New TipoTren(Convert.ToInt32(lstTiposTrenes.SelectedValue)) 'devuelve el id seleccionado
            tt.descripcionTipoTren = Me.txtDescripcionTT.Text
            If Not (IsNumeric(Me.txtCapacidadMax.Text)) Then
                MessageBox.Show("El valor introducido no es numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            tt.capacidadMax = Convert.ToInt32(Me.txtCapacidadMax.Text)
            Try
                If tt.actualizarTipoTren() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim datos As DataTable = CType(lstTiposTrenes.DataSource, DataTable) 'actualizar la lista en tiempo real, sacando el row y volviendolo a meter cargado
                datos.Rows(lstTiposTrenes.SelectedIndex).Item(1) = txtDescripcionTT.Text
                datos.Rows(lstTiposTrenes.SelectedIndex).Item(2) = tt.capacidadMax
                lstTiposTrenes.DataSource = datos
                MessageBox.Show(tt.descripcionTipoTren.ToString & " Actualizado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntModificarTren_Click(sender As Object, e As EventArgs) Handles bntModificarTren.Click
        Dim t As Tren = Nothing 'INICIALIZADA VARIABLE POR WARNING
        If Me.cbTipoTren.SelectedValue IsNot Nothing And lstTrenes.SelectedItem IsNot Nothing Then
            t = New Tren(lstTrenes.SelectedItem(0))
            t.tipoTren.idTipoTren = CInt(Me.cbTipoTren.SelectedValue)
            Try
                If t.actualizarTren() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim datos As DataTable = CType(lstTrenes.DataSource, DataTable) 'actualizar la lista en tiempo real, sacando el row y volviendolo a meter cargado
                datos.Rows(lstTrenes.SelectedIndex).Item(1) = Me.cbTipoTren.SelectedValue
                lstTrenes.DataSource = datos
                MessageBox.Show(t.matricula.ToString & " Actualizado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntModificarCotizacion_Click(sender As Object, e As EventArgs) Handles bntModificarCotizacion.Click
        Dim c As Cotizacion
        If Me.txtEurosPorTonelada.Text <> Nothing And lstCotizaciones.SelectedIndices.Count = 1 Then 'para asegurarnos que han cambiado y seleccionado algun elemento para que no haya problemas al cambiar los datos
            Dim cotizacionNueva As Cotizacion = New Cotizacion(CInt(Me.cbProducto.SelectedValue), CDate(Me.dtpFecha.Text)) 'Cotizacion que vamos a crear nueva, con lo que obtnemos de los txt.
            c = New Cotizacion(CInt(lstCotizaciones.FocusedItem.SubItems(0).Text), CDate(lstCotizaciones.FocusedItem.SubItems(2).Text)) ' cotizacion seleccionada que vamos a cambiar.
            If Not (IsNumeric(Me.txtEurosPorTonelada.Text)) Then
                MessageBox.Show("No ha introducido un valor Numerico en los Euros por Tonelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            cotizacionNueva.eurosPorTonelada = Convert.ToDouble(Replace(Me.txtEurosPorTonelada.Text, ".", ","))
            Try
                If c.actualizarCotizacion(cotizacionNueva) <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                lstCotizaciones.FocusedItem.SubItems(0).Text = cotizacionNueva.producto.idProducto.ToString 'Actualizamos el valor de idproducto en la listview
                lstCotizaciones.FocusedItem.SubItems(1).Text = cbProducto.Text 'Actualizamos el valor del producto en la listview
                lstCotizaciones.FocusedItem.SubItems(2).Text = cotizacionNueva.fecha 'Actualizamos el valor de fecha en la listview
                lstCotizaciones.FocusedItem.SubItems(3).Text = cotizacionNueva.eurosPorTonelada.ToString 'Actualizamos el valor de €/T en la listview
                bntLimpiarCotizacion.PerformClick()
                MessageBox.Show("La cotización del producto: " & Me.cbProducto.Text & " en la fecha: " & c.fecha & " ha sido actualizada correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bntModificarViaje_Click(sender As Object, e As EventArgs) Handles bntModificarViaje.Click
        Dim v As Viaje

        If Me.txtToneladasTransportadas.Text <> Nothing And lstViajes.SelectedIndices.Count = 1 Then 'asegurarnos de que hay un item selecionado y el campo no esta vacio
            'Obtenemos la capacidad maxima del tren para saber si puede realizar el viaje deseado
            Dim viajeModificado As Viaje = New Viaje(Convert.ToDateTime(Me.dtpFechaViaje.Text), Convert.ToString(Me.cbMatriculaTren.SelectedItem), Convert.ToInt32(cbProductoTransportado.SelectedValue))
            viajeModificado.trenViaje.leerTren()
            viajeModificado.trenViaje.tipoTren.leerTipoTren()

            v = New Viaje(CDate(lstViajes.FocusedItem.SubItems(1).Text), lstViajes.FocusedItem.SubItems(2).Text, Convert.ToInt32(lstViajes.FocusedItem.SubItems(0).Text))
            'Comprobamos que el valor de toneladas sea un numeo.
            If Not (IsNumeric(Me.txtToneladasTransportadas.Text)) Then
                MessageBox.Show("No ha introducido un valor numerico en el campo de toneladas transportadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Comprobamos que el valor introducido en el campo de toneladas sea un entero.
            If (Replace(Me.txtToneladasTransportadas.Text, ".", ",") Mod 1) Then
                MessageBox.Show("Error el numero de toneladas transportadas no es un entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            viajeModificado.toneladasTransportadas = Convert.ToInt32(Me.txtToneladasTransportadas.Text)
            'Comprobamos si el tren es capaz de llevar las toneladas.
            If (viajeModificado.toneladasTransportadas > viajeModificado.trenViaje.tipoTren.capacidadMax) Then
                MessageBox.Show("Error el tren con matricula: " & viajeModificado.trenViaje.matricula & " no dispone de capacidad suficiente para transportar " & viajeModificado.toneladasTransportadas & " toneladas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try

                If v.actualizarViaje(viajeModificado) <> 1 Then

                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("El viaje con fecha: " & v.fechaViaje & " con el tren: " & v.trenViaje.matricula & " y el producto: " & v.productoTransportado.idProducto & " ha sido modificado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question)
                lstViajes.FocusedItem.SubItems(0).Text = viajeModificado.productoTransportado.idProducto.ToString
                lstViajes.FocusedItem.SubItems(1).Text = viajeModificado.fechaViaje
                lstViajes.FocusedItem.SubItems(2).Text = viajeModificado.trenViaje.matricula.ToString
                lstViajes.FocusedItem.SubItems(3).Text = cbProductoTransportado.Text
                lstViajes.FocusedItem.SubItems(4).Text = viajeModificado.toneladasTransportadas.ToString 'Actualizamos el valor de toneladas transportadas
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    'Borrar
    Private Sub bntBorrarProducto_Click(sender As Object, e As EventArgs) Handles bntBorrarProducto.Click
        Dim pro As Producto = Nothing
        If Me.txtDescripcion.Text <> String.Empty And lstProductos.SelectedItem IsNot Nothing Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.txtDescripcion.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                pro = New Producto(lstProductos.SelectedItem(0))
                Try
                    If pro.borrarProducto() > 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    MessageBox.Show(Me.txtDescripcion.Text & " Eliminado correctamente") 'si pongo pro.descripda error por que se borra xd
                    Dim datos As DataTable = CType(lstProductos.DataSource, DataTable) 'actualizar la lista en tiempo real, sacando el row y volviendolo a meter cargado
                    datos.Rows.RemoveAt(lstProductos.SelectedIndex)
                    cbProducto.Items.Remove(Convert.ToInt32(Me.txtIdProducto.Text))
                    cbProductoTransportado.Items.Remove(Convert.ToInt32(Me.txtIdProducto.Text))
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
        bntLimpiarProducto.PerformClick()
    End Sub
    Private Sub bntBorrarTT_Click(sender As Object, e As EventArgs) Handles bntBorrarTT.Click
        Dim tt As TipoTren = Nothing
        If lstTiposTrenes.SelectedItem IsNot Nothing Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.txtDescripcionTT.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                tt = New TipoTren(lstTiposTrenes.SelectedItem(0))
                Try
                    If tt.borrarTipoTren() > 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    MessageBox.Show(Me.txtDescripcionTT.Text & " Eliminado correctamente") 'si pongo pro.descripda error por que se borra xd
                    Dim datos As DataTable = CType(lstTiposTrenes.DataSource, DataTable) 'actualizar la lista en tiempo real, sacando el row y volviendolo a meter cargado
                    datos.Rows.RemoveAt(lstTiposTrenes.SelectedIndex)
                    cbTipoTren.DataSource = datos
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
        bntLimpiarTT.PerformClick()
    End Sub
    Private Sub bntBorrarTren_Click(sender As Object, e As EventArgs) Handles bntBorrarTren.Click
        Dim t As Tren = Nothing
        If lstTrenes.SelectedItem IsNot Nothing Then
            If MessageBox.Show("Estas seguro de que quieres eliminar " & Me.txtMatricula.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                t = New Tren(lstTrenes.SelectedItem(0))
                Try
                    If t.borrarTren() > 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    MessageBox.Show(lstTrenes.SelectedItem(0) & " Eliminado correctamente") 'si pongo pro.descripda error por que se borra xd
                    borrarTrenesCB(lstTrenes.SelectedItem(0))
                    Dim datos As DataTable = CType(lstTrenes.DataSource, DataTable) 'actualizar la lista en tiempo real, sacando el row y volviendolo a meter cargado
                    datos.Rows.RemoveAt(lstTrenes.SelectedIndex)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
        bntLimpiarTren.PerformClick()
    End Sub
    Private Sub bntBorrarCotizacion_Click(sender As Object, e As EventArgs) Handles bntBorrarCotizacion.Click
        Dim c As Cotizacion = Nothing
        If Me.cbProducto.SelectedValue IsNot Nothing And Me.dtpFecha.Text IsNot Nothing And lstCotizaciones.FocusedItem IsNot Nothing Then 'Si el indice y la fecha no son null
            If MessageBox.Show("Estas seguro de que quieres eliminar la cotizacion del producto: " & Me.cbProducto.Text & " en la fecha: " & Me.dtpFecha.Text, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                c = New Cotizacion(Me.cbProducto.SelectedValue, Me.dtpFecha.Text)
                Try
                    If c.borrarCotizacion() > 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    MessageBox.Show("Se ha eliminado la cotizacion correctamente")
                    lstCotizaciones.Items.Remove(lstCotizaciones.SelectedItems(0))
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
        bntLimpiarCotizacion.PerformClick()
    End Sub

    Private Sub bntBorrarViaje_Click(sender As Object, e As EventArgs) Handles bntBorrarViaje.Click
        Dim v As Viaje = Nothing
        If Me.cbProductoTransportado.SelectedValue <> Nothing And Me.dtpFechaViaje.Text <> Nothing And Me.cbMatriculaTren.SelectedItem <> Nothing Then 'Si el indice y la fecha no son null
            If MessageBox.Show("Estas seguro de que quieres eliminar el viaje que lleva: " & Me.cbProductoTransportado.Text & " en la fecha: " & Me.dtpFechaViaje.Text & " con el tren: " & Me.cbMatriculaTren.SelectedItem.ToString, "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                v = New Viaje(Convert.ToDateTime(Me.dtpFechaViaje.Text), Me.cbMatriculaTren.Text, Me.cbProductoTransportado.SelectedValue)
                Try
                    If v.borrarViaje > 1 Then
                        MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    MessageBox.Show(" Eliminado correctamente")
                    lstViajes.Items.Remove(lstViajes.SelectedItems(0))
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
        bntLimpiarViaje.PerformClick()
    End Sub

    'Limpiar
    Private Sub bntLimpiarProducto_Click(sender As Object, e As EventArgs) Handles bntLimpiarProducto.Click
        Me.txtDescripcion.Text = String.Empty
        Me.txtIdProducto.Text = String.Empty
        bntAnadirProducto.Enabled = True
        bntBorrarProducto.Enabled = False
        bntModificarProducto.Enabled = False
        bntLimpiarProducto.Enabled = False
        lstProductos.ClearSelected()
    End Sub
    Private Sub bntLimpiarTT_Click(sender As Object, e As EventArgs) Handles bntLimpiarTT.Click
        Me.txtDescripcionTT.Text = String.Empty
        Me.txtCapacidadMax.Text = String.Empty
        Me.txtIdTipoTren.Text = String.Empty
        bntAnadirTT.Enabled = True
        bntBorrarTT.Enabled = False
        bntModificarTT.Enabled = False
        bntLimpiarTT.Enabled = False
        lstTiposTrenes.ClearSelected()
    End Sub
    Private Sub bntLimpiarTren_Click(sender As Object, e As EventArgs) Handles bntLimpiarTren.Click
        Me.txtMatricula.Text = String.Empty
        Me.txtMatricula.Enabled = True
        Me.cbTipoTren.SelectedItem = Nothing
        bntAnadirTren.Enabled = True
        bntBorrarTren.Enabled = False
        bntModificarTren.Enabled = False
        bntLimpiarTren.Enabled = False
        lstTrenes.ClearSelected()
    End Sub
    Private Sub bntLimpiarCotizacion_Click(sender As Object, e As EventArgs) Handles bntLimpiarCotizacion.Click
        Me.cbProducto.SelectedItem = Nothing
        Me.cbProducto.Enabled = True
        Me.dtpFecha.Text = "01/01/2020"
        Me.dtpFecha.Enabled = True
        Me.txtEurosPorTonelada.Text = String.Empty
        bntAnadirCotizacion.Enabled = True
        bntBorrarCotizacion.Enabled = False
        bntModificarCotizacion.Enabled = False
        bntLimpiarCotizacion.Enabled = False
        lstCotizaciones.SelectedIndices.Clear()
    End Sub
    Private Sub bntLimpiarViaje_Click(sender As Object, e As EventArgs) Handles bntLimpiarViaje.Click
        Me.cbProductoTransportado.Text = String.Empty
        Me.cbMatriculaTren.SelectedItem = Nothing
        Me.cbMatriculaTren.Enabled = True
        Me.cbProductoTransportado.Enabled = True
        Me.dtpFechaViaje.Text = "01/01/2020"
        Me.dtpFechaViaje.Enabled = True
        Me.txtToneladasTransportadas.Text = String.Empty
        bntAnadirViaje.Enabled = True
        bntBorrarViaje.Enabled = False
        bntModificarViaje.Enabled = False
        bntLimpiarViaje.Enabled = False
        lstViajes.SelectedIndices.Clear()
    End Sub
    Private Sub bntLimpiarConsulta1_Click(sender As Object, e As EventArgs) Handles bntLimpiarConsulta1.Click
        lstConsulta1.Visible = False
        lblNumeroViajes.Visible = False
        lblListaConsulta1.Visible = False
        cbConsulta1.SelectedItem = Nothing
        dtpFechaInicioConsulta1.Text = "01/01/2020"
        dtpFechaFinConsulta1.Text = "01/01/2020"
    End Sub
    Private Sub bntLimpiarConsulta2_Click(sender As Object, e As EventArgs) Handles bntLimpiarConsulta2.Click
        lstConsulta2.Visible = False
        lstConsulta3.Visible = False
        lblRankingConsulta2.Visible = False
        lblRankingConsulta3.Visible = False
        dtpFechaInicioConsulta23.Text = "01/01/2020"
        dtpFechaFinConsulta23.Text = "01/01/2020"
    End Sub
    Private Sub btnLimpiarConsulta4_Click(sender As Object, e As EventArgs) Handles btnLimpiarConsulta4.Click
        lstConsulta4.Visible = False
        lblConsulta4.Visible = False
    End Sub
    'IndexChanged
    Private Sub lstTiposTrenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTiposTrenes.SelectedIndexChanged
        If Not Me.lstTiposTrenes.SelectedItem Is Nothing Then
            Try
                Me.txtIdTipoTren.Text = lstTiposTrenes.SelectedItem(0)
                Me.txtDescripcionTT.Text = lstTiposTrenes.SelectedItem(1)
                Me.txtCapacidadMax.Text = lstTiposTrenes.SelectedItem(2)
                bntAnadirTT.Enabled = False
                bntBorrarTT.Enabled = True
                bntModificarTT.Enabled = True
                bntLimpiarTT.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub lstProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductos.SelectedIndexChanged
        If Not Me.lstProductos.SelectedItem Is Nothing Then
            Try
                Me.txtIdProducto.Text = lstProductos.SelectedItem(0)
                Me.txtDescripcion.Text = lstProductos.SelectedItem(1) '0-> id 1 descripcion
                bntAnadirProducto.Enabled = False
                bntBorrarProducto.Enabled = True
                bntModificarProducto.Enabled = True
                bntLimpiarProducto.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub lstTrenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrenes.SelectedIndexChanged
        If Not Me.lstTrenes.SelectedItem Is Nothing Then
            Try
                Me.txtMatricula.Text = lstTrenes.SelectedItem(0) 'Matricula
                Me.cbTipoTren.SelectedValue = lstTrenes.SelectedItem(1).ToString 'Tipo Tren
                bntAnadirTren.Enabled = False
                bntBorrarTren.Enabled = True
                bntModificarTren.Enabled = True
                bntLimpiarTren.Enabled = True
                Me.txtMatricula.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If
    End Sub
    Private Sub lstCotizaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCotizaciones.SelectedIndexChanged
        If Not Me.lstCotizaciones.FocusedItem Is Nothing Then
            Try
                Me.cbProducto.Text = lstCotizaciones.FocusedItem.SubItems(1).Text
                Me.dtpFecha.Text = lstCotizaciones.FocusedItem.SubItems(2).Text
                Me.txtEurosPorTonelada.Text = lstCotizaciones.FocusedItem.SubItems(3).Text
                bntAnadirCotizacion.Enabled = False
                bntBorrarCotizacion.Enabled = True

                bntModificarCotizacion.Enabled = True
                bntLimpiarCotizacion.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub lstViajes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViajes.SelectedIndexChanged
        If Not Me.lstViajes.FocusedItem Is Nothing Then
            Try
                Me.dtpFechaViaje.Text = lstViajes.FocusedItem.SubItems(1).Text
                Me.cbMatriculaTren.Text = lstViajes.FocusedItem.SubItems(2).Text
                Me.cbProductoTransportado.Text = lstViajes.FocusedItem.SubItems(3).Text
                Me.txtToneladasTransportadas.Text = lstViajes.FocusedItem.SubItems(4).Text


                bntAnadirViaje.Enabled = False
                bntBorrarViaje.Enabled = True
                bntModificarViaje.Enabled = True
                bntLimpiarViaje.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    'Consultas
    Private Sub bntConsulta1_Click(sender As Object, e As EventArgs) Handles bntConsulta1.Click
        If (cbConsulta1.SelectedItem IsNot Nothing) Then
            lstConsulta1.Items.Clear()
            Dim v As New Viaje()

            lblNumeroViajes.Text = "El tren con matricula: " & cbConsulta1.SelectedItem.ToString & " ha realizado un total de: " & v.contarNumeroViajes(CDate(dtpFechaInicioConsulta1.Text), CDate(dtpFechaFinConsulta1.Text), cbConsulta1.SelectedItem.ToString) & " viajes" & vbCrLf & "entre las fechas: " & dtpFechaInicioConsulta1.Text & " y " & dtpFechaFinConsulta1.Text
            lblNumeroViajes.Visible = True
            v.listarProductoViaje(CDate(dtpFechaInicioConsulta1.Text), CDate(dtpFechaFinConsulta1.Text), cbConsulta1.SelectedItem.ToString)
            For Each descripPro As String In v.vDAO.resultado
                lstConsulta1.Items.Add(descripPro)
            Next
            lstConsulta1.Visible = True
            lblListaConsulta1.Visible = True
        End If
    End Sub

    Private Sub bntConsulta2_Click(sender As Object, e As EventArgs) Handles bntConsulta2.Click
        lstConsulta2.Items.Clear()
        Dim tt As New TipoTren()
        tt.rankingTipoTren(CDate(dtpFechaInicioConsulta23.Text), CDate(dtpFechaFinConsulta23.Text))
        For Each item As ListViewItem In tt.TipoTDAO.resultado
            lstConsulta2.Items.Add(item)
        Next
        lstConsulta2.Visible = True
        lblRankingConsulta2.Visible = True
    End Sub

    Private Sub bntConsulta3_Click(sender As Object, e As EventArgs) Handles bntConsulta3.Click
        lstConsulta3.Items.Clear()
        Dim p As New Producto()
        p.rankingProducto(CDate(dtpFechaInicioConsulta23.Text), CDate(dtpFechaFinConsulta23.Text))
        For Each item As ListViewItem In p.pDAO.resultado
            lstConsulta3.Items.Add(item)
        Next
        lstConsulta3.Visible = True
        lblRankingConsulta3.Visible = True
    End Sub

    Private Sub bntConsulta4_Click(sender As Object, e As EventArgs) Handles bntConsulta4.Click
        lstConsulta4.Items.Clear()
        Dim v As New Viaje
        v.viajeMayorBeneficio()
        For Each elemento As ListViewItem In v.vDAO.resultado
            lstConsulta4.Items.Add(elemento)
        Next
        If Not (lstConsulta4.Items.Count = 0) Then
            lblConsulta4.Text = "El viaje que más beneficio aporta es realizado en la fecha: " & lstConsulta4.Items(0).SubItems(0).Text & " obteniendo un beneficio de: " & lstConsulta4.Items(0).SubItems(7).Text & "€"
            lblConsulta4.Visible = True
            lstConsulta4.Visible = True
        Else
            lstConsulta4.Visible = False
            lblConsulta4.Visible = True
            lblConsulta4.Text = "Ups, parece que ha habido un error, no existen cotizaciones de ningun producto que coincidan con la fecha del viaje"
        End If
        btnLimpiarConsulta4.Enabled = True
    End Sub
    'Cerrar Formulario
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If m_iMessage = WM_FORMCONTROLMENU Then
            'eso es todo amigos
            My.Computer.Audio.Play(My.Resources.bugsbunny, AudioPlayMode.Background)
            MessageBox.Show("Gracias por confiar en nosotros. Esperamos verte pronto.")
            End
        End If
    End Sub

End Class
