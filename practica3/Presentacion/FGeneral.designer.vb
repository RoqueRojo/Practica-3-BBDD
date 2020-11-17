<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FGeneral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FGeneral))
        Me.btnEmpezar = New System.Windows.Forms.Button()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.tabTren = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbTipoTren = New System.Windows.Forms.ComboBox()
        Me.lblTipoTren = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.bntLimpiarTren = New System.Windows.Forms.Button()
        Me.bntBorrarTren = New System.Windows.Forms.Button()
        Me.bntModificarTren = New System.Windows.Forms.Button()
        Me.bntAnadirTren = New System.Windows.Forms.Button()
        Me.lblTrenes = New System.Windows.Forms.Label()
        Me.lstTrenes = New System.Windows.Forms.ListBox()
        Me.tabTipoTren = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblCapacidadMax = New System.Windows.Forms.Label()
        Me.lblIdTT = New System.Windows.Forms.Label()
        Me.lblDescripcionTT = New System.Windows.Forms.Label()
        Me.txtCapacidadMax = New System.Windows.Forms.TextBox()
        Me.txtDescripcionTT = New System.Windows.Forms.TextBox()
        Me.txtIdTipoTren = New System.Windows.Forms.TextBox()
        Me.bntModificarTT = New System.Windows.Forms.Button()
        Me.bntBorrarTT = New System.Windows.Forms.Button()
        Me.bntLimpiarTT = New System.Windows.Forms.Button()
        Me.bntAnadirTT = New System.Windows.Forms.Button()
        Me.lblTiposTrenes = New System.Windows.Forms.Label()
        Me.lstTiposTrenes = New System.Windows.Forms.ListBox()
        Me.tabProductos = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.lblIdProducto = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.bntBorrarProducto = New System.Windows.Forms.Button()
        Me.bntLimpiarProducto = New System.Windows.Forms.Button()
        Me.bntModificarProducto = New System.Windows.Forms.Button()
        Me.bntAnadirProducto = New System.Windows.Forms.Button()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.tabCotizaciones = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lstCotizaciones = New System.Windows.Forms.ListView()
        Me.idProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Euros = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.lblEurosPorTonelada = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtEurosPorTonelada = New System.Windows.Forms.TextBox()
        Me.bntModificarCotizacion = New System.Windows.Forms.Button()
        Me.bntLimpiarCotizacion = New System.Windows.Forms.Button()
        Me.bntBorrarCotizacion = New System.Windows.Forms.Button()
        Me.bntAnadirCotizacion = New System.Windows.Forms.Button()
        Me.lblCotizaciones = New System.Windows.Forms.Label()
        Me.tabViajes = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtToneladasTransportadas = New System.Windows.Forms.TextBox()
        Me.lblToneladasTransportadas = New System.Windows.Forms.Label()
        Me.cbMatriculaTren = New System.Windows.Forms.ComboBox()
        Me.dtpFechaViaje = New System.Windows.Forms.DateTimePicker()
        Me.cbProductoTransportado = New System.Windows.Forms.ComboBox()
        Me.lblMatriculaViaje = New System.Windows.Forms.Label()
        Me.lblFechaViaje = New System.Windows.Forms.Label()
        Me.lblProductoTransportado = New System.Windows.Forms.Label()
        Me.bntModificarViaje = New System.Windows.Forms.Button()
        Me.bntLimpiarViaje = New System.Windows.Forms.Button()
        Me.bntBorrarViaje = New System.Windows.Forms.Button()
        Me.bntAnadirViaje = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lstViajes = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fechaViaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.matricula = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductoT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Toneladas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabConsulta1 = New System.Windows.Forms.TabPage()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.lblListaConsulta1 = New System.Windows.Forms.Label()
        Me.lblNumeroViajes = New System.Windows.Forms.Label()
        Me.bntLimpiarConsulta1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.cbConsulta1 = New System.Windows.Forms.ComboBox()
        Me.lstConsulta1 = New System.Windows.Forms.ListBox()
        Me.dtpFechaInicioConsulta1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinConsulta1 = New System.Windows.Forms.DateTimePicker()
        Me.bntConsulta1 = New System.Windows.Forms.Button()
        Me.tabConsulta23 = New System.Windows.Forms.TabPage()
        Me.lstConsulta3 = New System.Windows.Forms.ListView()
        Me.nProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstConsulta2 = New System.Windows.Forms.ListView()
        Me.tipoTren = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.viajes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.lblRankingConsulta3 = New System.Windows.Forms.Label()
        Me.lblRankingConsulta2 = New System.Windows.Forms.Label()
        Me.bntLimpiarConsulta2 = New System.Windows.Forms.Button()
        Me.bntConsulta3 = New System.Windows.Forms.Button()
        Me.dtpFechaFinConsulta23 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinConsulta23 = New System.Windows.Forms.Label()
        Me.bntConsulta2 = New System.Windows.Forms.Button()
        Me.lblFechaInicioConsulta23 = New System.Windows.Forms.Label()
        Me.dtpFechaInicioConsulta23 = New System.Windows.Forms.DateTimePicker()
        Me.tabConsulta4 = New System.Windows.Forms.TabPage()
        Me.btnLimpiarConsulta4 = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.lblConsulta4 = New System.Windows.Forms.Label()
        Me.lstConsulta4 = New System.Windows.Forms.ListView()
        Me.FechaConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MatriculaConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductoConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotizacionConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EurosConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToneladasConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BeneficioConsulta4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bntConsulta4 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcomponentes = New System.Windows.Forms.Label()
        Me.lblIsabel = New System.Windows.Forms.Label()
        Me.lblRoque = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.lblsubtitulo = New System.Windows.Forms.Label()
        Me.imghauling = New System.Windows.Forms.PictureBox()
        Me.TabGeneral.SuspendLayout()
        Me.tabTren.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTipoTren.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProductos.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCotizaciones.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabViajes.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsulta1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsulta23.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsulta4.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imghauling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmpezar
        '
        Me.btnEmpezar.BackColor = System.Drawing.Color.IndianRed
        Me.btnEmpezar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpezar.Location = New System.Drawing.Point(106, 430)
        Me.btnEmpezar.Name = "btnEmpezar"
        Me.btnEmpezar.Size = New System.Drawing.Size(148, 46)
        Me.btnEmpezar.TabIndex = 2
        Me.btnEmpezar.Text = "Empezar"
        Me.btnEmpezar.UseVisualStyleBackColor = False
        '
        'ofdRuta
        '
        Me.ofdRuta.FileName = "OpenFileDialog1"
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.tabTren)
        Me.TabGeneral.Controls.Add(Me.tabTipoTren)
        Me.TabGeneral.Controls.Add(Me.tabProductos)
        Me.TabGeneral.Controls.Add(Me.tabCotizaciones)
        Me.TabGeneral.Controls.Add(Me.tabViajes)
        Me.TabGeneral.Controls.Add(Me.tabConsulta1)
        Me.TabGeneral.Controls.Add(Me.tabConsulta23)
        Me.TabGeneral.Controls.Add(Me.tabConsulta4)
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Enabled = False
        Me.TabGeneral.Location = New System.Drawing.Point(14, 13)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1032, 343)
        Me.TabGeneral.TabIndex = 3
        '
        'tabTren
        '
        Me.tabTren.BackColor = System.Drawing.Color.LightGray
        Me.tabTren.Controls.Add(Me.PictureBox1)
        Me.tabTren.Controls.Add(Me.cbTipoTren)
        Me.tabTren.Controls.Add(Me.lblTipoTren)
        Me.tabTren.Controls.Add(Me.lblMatricula)
        Me.tabTren.Controls.Add(Me.txtMatricula)
        Me.tabTren.Controls.Add(Me.bntLimpiarTren)
        Me.tabTren.Controls.Add(Me.bntBorrarTren)
        Me.tabTren.Controls.Add(Me.bntModificarTren)
        Me.tabTren.Controls.Add(Me.bntAnadirTren)
        Me.tabTren.Controls.Add(Me.lblTrenes)
        Me.tabTren.Controls.Add(Me.lstTrenes)
        Me.tabTren.Location = New System.Drawing.Point(4, 30)
        Me.tabTren.Name = "tabTren"
        Me.tabTren.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTren.Size = New System.Drawing.Size(1024, 309)
        Me.tabTren.TabIndex = 0
        Me.tabTren.Text = "Trenes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.practica3.My.Resources.Resources.tren
        Me.PictureBox1.Location = New System.Drawing.Point(596, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'cbTipoTren
        '
        Me.cbTipoTren.FormattingEnabled = True
        Me.cbTipoTren.Location = New System.Drawing.Point(303, 135)
        Me.cbTipoTren.Name = "cbTipoTren"
        Me.cbTipoTren.Size = New System.Drawing.Size(190, 29)
        Me.cbTipoTren.TabIndex = 10
        '
        'lblTipoTren
        '
        Me.lblTipoTren.AutoSize = True
        Me.lblTipoTren.Location = New System.Drawing.Point(183, 135)
        Me.lblTipoTren.Name = "lblTipoTren"
        Me.lblTipoTren.Size = New System.Drawing.Size(130, 21)
        Me.lblTipoTren.TabIndex = 9
        Me.lblTipoTren.Text = "Tipo de Tren:"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(207, 95)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(100, 21)
        Me.lblMatricula.TabIndex = 8
        Me.lblMatricula.Text = "Matricula:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(303, 95)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(190, 30)
        Me.txtMatricula.TabIndex = 6
        '
        'bntLimpiarTren
        '
        Me.bntLimpiarTren.BackColor = System.Drawing.Color.IndianRed
        Me.bntLimpiarTren.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiarTren.Location = New System.Drawing.Point(197, 250)
        Me.bntLimpiarTren.Name = "bntLimpiarTren"
        Me.bntLimpiarTren.Size = New System.Drawing.Size(130, 38)
        Me.bntLimpiarTren.TabIndex = 5
        Me.bntLimpiarTren.Text = "Limpiar"
        Me.bntLimpiarTren.UseVisualStyleBackColor = False
        '
        'bntBorrarTren
        '
        Me.bntBorrarTren.BackColor = System.Drawing.Color.IndianRed
        Me.bntBorrarTren.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntBorrarTren.Location = New System.Drawing.Point(363, 250)
        Me.bntBorrarTren.Name = "bntBorrarTren"
        Me.bntBorrarTren.Size = New System.Drawing.Size(130, 38)
        Me.bntBorrarTren.TabIndex = 4
        Me.bntBorrarTren.Text = "Borrar"
        Me.bntBorrarTren.UseVisualStyleBackColor = False
        '
        'bntModificarTren
        '
        Me.bntModificarTren.BackColor = System.Drawing.Color.IndianRed
        Me.bntModificarTren.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarTren.Location = New System.Drawing.Point(363, 184)
        Me.bntModificarTren.Name = "bntModificarTren"
        Me.bntModificarTren.Size = New System.Drawing.Size(130, 38)
        Me.bntModificarTren.TabIndex = 3
        Me.bntModificarTren.Text = "Modificar"
        Me.bntModificarTren.UseVisualStyleBackColor = False
        '
        'bntAnadirTren
        '
        Me.bntAnadirTren.BackColor = System.Drawing.Color.IndianRed
        Me.bntAnadirTren.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAnadirTren.Location = New System.Drawing.Point(197, 184)
        Me.bntAnadirTren.Name = "bntAnadirTren"
        Me.bntAnadirTren.Size = New System.Drawing.Size(130, 38)
        Me.bntAnadirTren.TabIndex = 2
        Me.bntAnadirTren.Text = "Añadir"
        Me.bntAnadirTren.UseVisualStyleBackColor = False
        '
        'lblTrenes
        '
        Me.lblTrenes.AutoSize = True
        Me.lblTrenes.Location = New System.Drawing.Point(24, 17)
        Me.lblTrenes.Name = "lblTrenes"
        Me.lblTrenes.Size = New System.Drawing.Size(71, 21)
        Me.lblTrenes.TabIndex = 1
        Me.lblTrenes.Text = "Trenes"
        '
        'lstTrenes
        '
        Me.lstTrenes.FormattingEnabled = True
        Me.lstTrenes.ItemHeight = 21
        Me.lstTrenes.Location = New System.Drawing.Point(27, 46)
        Me.lstTrenes.Name = "lstTrenes"
        Me.lstTrenes.Size = New System.Drawing.Size(134, 214)
        Me.lstTrenes.TabIndex = 0
        '
        'tabTipoTren
        '
        Me.tabTipoTren.BackColor = System.Drawing.Color.LightGray
        Me.tabTipoTren.Controls.Add(Me.PictureBox4)
        Me.tabTipoTren.Controls.Add(Me.lblCapacidadMax)
        Me.tabTipoTren.Controls.Add(Me.lblIdTT)
        Me.tabTipoTren.Controls.Add(Me.lblDescripcionTT)
        Me.tabTipoTren.Controls.Add(Me.txtCapacidadMax)
        Me.tabTipoTren.Controls.Add(Me.txtDescripcionTT)
        Me.tabTipoTren.Controls.Add(Me.txtIdTipoTren)
        Me.tabTipoTren.Controls.Add(Me.bntModificarTT)
        Me.tabTipoTren.Controls.Add(Me.bntBorrarTT)
        Me.tabTipoTren.Controls.Add(Me.bntLimpiarTT)
        Me.tabTipoTren.Controls.Add(Me.bntAnadirTT)
        Me.tabTipoTren.Controls.Add(Me.lblTiposTrenes)
        Me.tabTipoTren.Controls.Add(Me.lstTiposTrenes)
        Me.tabTipoTren.Location = New System.Drawing.Point(4, 30)
        Me.tabTipoTren.Name = "tabTipoTren"
        Me.tabTipoTren.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTipoTren.Size = New System.Drawing.Size(1024, 309)
        Me.tabTipoTren.TabIndex = 1
        Me.tabTipoTren.Text = "Tipos Trenes"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.practica3.My.Resources.Resources.tren2
        Me.PictureBox4.Location = New System.Drawing.Point(595, 51)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(335, 238)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'lblCapacidadMax
        '
        Me.lblCapacidadMax.AutoSize = True
        Me.lblCapacidadMax.Location = New System.Drawing.Point(234, 136)
        Me.lblCapacidadMax.Name = "lblCapacidadMax"
        Me.lblCapacidadMax.Size = New System.Drawing.Size(112, 21)
        Me.lblCapacidadMax.TabIndex = 11
        Me.lblCapacidadMax.Text = "Capacidad:"
        '
        'lblIdTT
        '
        Me.lblIdTT.AutoSize = True
        Me.lblIdTT.Location = New System.Drawing.Point(286, 51)
        Me.lblIdTT.Name = "lblIdTT"
        Me.lblIdTT.Size = New System.Drawing.Size(36, 21)
        Me.lblIdTT.TabIndex = 10
        Me.lblIdTT.Text = "ID:"
        '
        'lblDescripcionTT
        '
        Me.lblDescripcionTT.AutoSize = True
        Me.lblDescripcionTT.Location = New System.Drawing.Point(226, 98)
        Me.lblDescripcionTT.Name = "lblDescripcionTT"
        Me.lblDescripcionTT.Size = New System.Drawing.Size(124, 21)
        Me.lblDescripcionTT.TabIndex = 9
        Me.lblDescripcionTT.Text = "Descripcion:"
        '
        'txtCapacidadMax
        '
        Me.txtCapacidadMax.Location = New System.Drawing.Point(333, 133)
        Me.txtCapacidadMax.Name = "txtCapacidadMax"
        Me.txtCapacidadMax.Size = New System.Drawing.Size(161, 30)
        Me.txtCapacidadMax.TabIndex = 8
        '
        'txtDescripcionTT
        '
        Me.txtDescripcionTT.Location = New System.Drawing.Point(333, 93)
        Me.txtDescripcionTT.Name = "txtDescripcionTT"
        Me.txtDescripcionTT.Size = New System.Drawing.Size(161, 30)
        Me.txtDescripcionTT.TabIndex = 7
        '
        'txtIdTipoTren
        '
        Me.txtIdTipoTren.Enabled = False
        Me.txtIdTipoTren.Location = New System.Drawing.Point(333, 51)
        Me.txtIdTipoTren.Name = "txtIdTipoTren"
        Me.txtIdTipoTren.Size = New System.Drawing.Size(161, 30)
        Me.txtIdTipoTren.TabIndex = 6
        '
        'bntModificarTT
        '
        Me.bntModificarTT.BackColor = System.Drawing.Color.IndianRed
        Me.bntModificarTT.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarTT.Location = New System.Drawing.Point(364, 193)
        Me.bntModificarTT.Name = "bntModificarTT"
        Me.bntModificarTT.Size = New System.Drawing.Size(130, 38)
        Me.bntModificarTT.TabIndex = 5
        Me.bntModificarTT.Text = "Modificar"
        Me.bntModificarTT.UseVisualStyleBackColor = False
        '
        'bntBorrarTT
        '
        Me.bntBorrarTT.BackColor = System.Drawing.Color.IndianRed
        Me.bntBorrarTT.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntBorrarTT.Location = New System.Drawing.Point(364, 251)
        Me.bntBorrarTT.Name = "bntBorrarTT"
        Me.bntBorrarTT.Size = New System.Drawing.Size(130, 38)
        Me.bntBorrarTT.TabIndex = 4
        Me.bntBorrarTT.Text = "Borrar"
        Me.bntBorrarTT.UseVisualStyleBackColor = False
        '
        'bntLimpiarTT
        '
        Me.bntLimpiarTT.BackColor = System.Drawing.Color.IndianRed
        Me.bntLimpiarTT.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiarTT.Location = New System.Drawing.Point(221, 251)
        Me.bntLimpiarTT.Name = "bntLimpiarTT"
        Me.bntLimpiarTT.Size = New System.Drawing.Size(130, 38)
        Me.bntLimpiarTT.TabIndex = 3
        Me.bntLimpiarTT.Text = "Limpiar"
        Me.bntLimpiarTT.UseVisualStyleBackColor = False
        '
        'bntAnadirTT
        '
        Me.bntAnadirTT.BackColor = System.Drawing.Color.IndianRed
        Me.bntAnadirTT.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAnadirTT.Location = New System.Drawing.Point(221, 193)
        Me.bntAnadirTT.Name = "bntAnadirTT"
        Me.bntAnadirTT.Size = New System.Drawing.Size(130, 38)
        Me.bntAnadirTT.TabIndex = 2
        Me.bntAnadirTT.Text = "Añadir"
        Me.bntAnadirTT.UseVisualStyleBackColor = False
        '
        'lblTiposTrenes
        '
        Me.lblTiposTrenes.AutoSize = True
        Me.lblTiposTrenes.Location = New System.Drawing.Point(36, 18)
        Me.lblTiposTrenes.Name = "lblTiposTrenes"
        Me.lblTiposTrenes.Size = New System.Drawing.Size(105, 21)
        Me.lblTiposTrenes.TabIndex = 1
        Me.lblTiposTrenes.Text = "Tipos Tren"
        '
        'lstTiposTrenes
        '
        Me.lstTiposTrenes.FormattingEnabled = True
        Me.lstTiposTrenes.ItemHeight = 21
        Me.lstTiposTrenes.Location = New System.Drawing.Point(39, 47)
        Me.lstTiposTrenes.Name = "lstTiposTrenes"
        Me.lstTiposTrenes.Size = New System.Drawing.Size(134, 214)
        Me.lstTiposTrenes.TabIndex = 0
        '
        'tabProductos
        '
        Me.tabProductos.BackColor = System.Drawing.Color.LightGray
        Me.tabProductos.Controls.Add(Me.PictureBox5)
        Me.tabProductos.Controls.Add(Me.txtIdProducto)
        Me.tabProductos.Controls.Add(Me.lblIdProducto)
        Me.tabProductos.Controls.Add(Me.lblDescripcion)
        Me.tabProductos.Controls.Add(Me.txtDescripcion)
        Me.tabProductos.Controls.Add(Me.bntBorrarProducto)
        Me.tabProductos.Controls.Add(Me.bntLimpiarProducto)
        Me.tabProductos.Controls.Add(Me.bntModificarProducto)
        Me.tabProductos.Controls.Add(Me.bntAnadirProducto)
        Me.tabProductos.Controls.Add(Me.lblProductos)
        Me.tabProductos.Controls.Add(Me.lstProductos)
        Me.tabProductos.Location = New System.Drawing.Point(4, 30)
        Me.tabProductos.Name = "tabProductos"
        Me.tabProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProductos.Size = New System.Drawing.Size(1024, 309)
        Me.tabProductos.TabIndex = 2
        Me.tabProductos.Text = "Productos"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.practica3.My.Resources.Resources.catalogo1
        Me.PictureBox5.Location = New System.Drawing.Point(646, 68)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(284, 204)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(380, 68)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(181, 30)
        Me.txtIdProducto.TabIndex = 9
        '
        'lblIdProducto
        '
        Me.lblIdProducto.AutoSize = True
        Me.lblIdProducto.Location = New System.Drawing.Point(274, 70)
        Me.lblIdProducto.Name = "lblIdProducto"
        Me.lblIdProducto.Size = New System.Drawing.Size(121, 21)
        Me.lblIdProducto.TabIndex = 8
        Me.lblIdProducto.Text = "ID Producto:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(274, 99)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(100, 25)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(380, 99)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 30)
        Me.txtDescripcion.TabIndex = 6
        '
        'bntBorrarProducto
        '
        Me.bntBorrarProducto.BackColor = System.Drawing.Color.IndianRed
        Me.bntBorrarProducto.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntBorrarProducto.Location = New System.Drawing.Point(443, 234)
        Me.bntBorrarProducto.Name = "bntBorrarProducto"
        Me.bntBorrarProducto.Size = New System.Drawing.Size(130, 38)
        Me.bntBorrarProducto.TabIndex = 5
        Me.bntBorrarProducto.Text = "Borrar"
        Me.bntBorrarProducto.UseVisualStyleBackColor = False
        '
        'bntLimpiarProducto
        '
        Me.bntLimpiarProducto.BackColor = System.Drawing.Color.IndianRed
        Me.bntLimpiarProducto.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiarProducto.Location = New System.Drawing.Point(277, 234)
        Me.bntLimpiarProducto.Name = "bntLimpiarProducto"
        Me.bntLimpiarProducto.Size = New System.Drawing.Size(130, 38)
        Me.bntLimpiarProducto.TabIndex = 4
        Me.bntLimpiarProducto.Text = "Limpiar"
        Me.bntLimpiarProducto.UseVisualStyleBackColor = False
        '
        'bntModificarProducto
        '
        Me.bntModificarProducto.BackColor = System.Drawing.Color.IndianRed
        Me.bntModificarProducto.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarProducto.Location = New System.Drawing.Point(443, 168)
        Me.bntModificarProducto.Name = "bntModificarProducto"
        Me.bntModificarProducto.Size = New System.Drawing.Size(130, 38)
        Me.bntModificarProducto.TabIndex = 3
        Me.bntModificarProducto.Text = "Modificar"
        Me.bntModificarProducto.UseVisualStyleBackColor = False
        '
        'bntAnadirProducto
        '
        Me.bntAnadirProducto.BackColor = System.Drawing.Color.IndianRed
        Me.bntAnadirProducto.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAnadirProducto.Location = New System.Drawing.Point(276, 168)
        Me.bntAnadirProducto.Name = "bntAnadirProducto"
        Me.bntAnadirProducto.Size = New System.Drawing.Size(130, 38)
        Me.bntAnadirProducto.TabIndex = 2
        Me.bntAnadirProducto.Text = "Añadir"
        Me.bntAnadirProducto.UseVisualStyleBackColor = False
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(24, 10)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(99, 21)
        Me.lblProductos.TabIndex = 1
        Me.lblProductos.Text = "Productos"
        '
        'lstProductos
        '
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.ItemHeight = 21
        Me.lstProductos.Location = New System.Drawing.Point(27, 47)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(190, 193)
        Me.lstProductos.TabIndex = 0
        '
        'tabCotizaciones
        '
        Me.tabCotizaciones.BackColor = System.Drawing.Color.LightGray
        Me.tabCotizaciones.Controls.Add(Me.PictureBox6)
        Me.tabCotizaciones.Controls.Add(Me.lstCotizaciones)
        Me.tabCotizaciones.Controls.Add(Me.dtpFecha)
        Me.tabCotizaciones.Controls.Add(Me.cbProducto)
        Me.tabCotizaciones.Controls.Add(Me.lblEurosPorTonelada)
        Me.tabCotizaciones.Controls.Add(Me.lblFecha)
        Me.tabCotizaciones.Controls.Add(Me.lblProducto)
        Me.tabCotizaciones.Controls.Add(Me.txtEurosPorTonelada)
        Me.tabCotizaciones.Controls.Add(Me.bntModificarCotizacion)
        Me.tabCotizaciones.Controls.Add(Me.bntLimpiarCotizacion)
        Me.tabCotizaciones.Controls.Add(Me.bntBorrarCotizacion)
        Me.tabCotizaciones.Controls.Add(Me.bntAnadirCotizacion)
        Me.tabCotizaciones.Controls.Add(Me.lblCotizaciones)
        Me.tabCotizaciones.Location = New System.Drawing.Point(4, 30)
        Me.tabCotizaciones.Name = "tabCotizaciones"
        Me.tabCotizaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCotizaciones.Size = New System.Drawing.Size(1024, 309)
        Me.tabCotizaciones.TabIndex = 3
        Me.tabCotizaciones.Text = "Cotizaciones"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.practica3.My.Resources.Resources.f86a954f550c45a3af14a2b645732022
        Me.PictureBox6.Location = New System.Drawing.Point(765, 43)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(166, 246)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'lstCotizaciones
        '
        Me.lstCotizaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idProducto, Me.Producto, Me.Fecha, Me.Euros})
        Me.lstCotizaciones.FullRowSelect = True
        Me.lstCotizaciones.HideSelection = False
        Me.lstCotizaciones.Location = New System.Drawing.Point(40, 43)
        Me.lstCotizaciones.MultiSelect = False
        Me.lstCotizaciones.Name = "lstCotizaciones"
        Me.lstCotizaciones.Size = New System.Drawing.Size(311, 246)
        Me.lstCotizaciones.TabIndex = 14
        Me.lstCotizaciones.UseCompatibleStateImageBehavior = False
        Me.lstCotizaciones.View = System.Windows.Forms.View.Details
        '
        'idProducto
        '
        Me.idProducto.Text = "id"
        Me.idProducto.Width = 0
        '
        'Producto
        '
        Me.Producto.Text = "Producto"
        Me.Producto.Width = 90
        '
        'Fecha
        '
        Me.Fecha.Text = "Fecha"
        Me.Fecha.Width = 113
        '
        'Euros
        '
        Me.Euros.Text = "€/Tonelada"
        Me.Euros.Width = 100
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(503, 84)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(193, 30)
        Me.dtpFecha.TabIndex = 13
        Me.dtpFecha.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(503, 45)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(193, 29)
        Me.cbProducto.TabIndex = 12
        '
        'lblEurosPorTonelada
        '
        Me.lblEurosPorTonelada.AutoSize = True
        Me.lblEurosPorTonelada.Location = New System.Drawing.Point(438, 132)
        Me.lblEurosPorTonelada.Name = "lblEurosPorTonelada"
        Me.lblEurosPorTonelada.Size = New System.Drawing.Size(45, 21)
        Me.lblEurosPorTonelada.TabIndex = 11
        Me.lblEurosPorTonelada.Text = "€/T:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(419, 84)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(68, 21)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Fecha:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(398, 45)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(96, 21)
        Me.lblProducto.TabIndex = 9
        Me.lblProducto.Text = "Producto:"
        '
        'txtEurosPorTonelada
        '
        Me.txtEurosPorTonelada.Location = New System.Drawing.Point(503, 128)
        Me.txtEurosPorTonelada.Name = "txtEurosPorTonelada"
        Me.txtEurosPorTonelada.Size = New System.Drawing.Size(193, 30)
        Me.txtEurosPorTonelada.TabIndex = 7
        '
        'bntModificarCotizacion
        '
        Me.bntModificarCotizacion.BackColor = System.Drawing.Color.IndianRed
        Me.bntModificarCotizacion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarCotizacion.Location = New System.Drawing.Point(566, 190)
        Me.bntModificarCotizacion.Name = "bntModificarCotizacion"
        Me.bntModificarCotizacion.Size = New System.Drawing.Size(130, 38)
        Me.bntModificarCotizacion.TabIndex = 5
        Me.bntModificarCotizacion.Text = "Modificar"
        Me.bntModificarCotizacion.UseVisualStyleBackColor = False
        '
        'bntLimpiarCotizacion
        '
        Me.bntLimpiarCotizacion.BackColor = System.Drawing.Color.IndianRed
        Me.bntLimpiarCotizacion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiarCotizacion.Location = New System.Drawing.Point(401, 251)
        Me.bntLimpiarCotizacion.Name = "bntLimpiarCotizacion"
        Me.bntLimpiarCotizacion.Size = New System.Drawing.Size(130, 38)
        Me.bntLimpiarCotizacion.TabIndex = 4
        Me.bntLimpiarCotizacion.Text = "Limpiar"
        Me.bntLimpiarCotizacion.UseVisualStyleBackColor = False
        '
        'bntBorrarCotizacion
        '
        Me.bntBorrarCotizacion.BackColor = System.Drawing.Color.IndianRed
        Me.bntBorrarCotizacion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntBorrarCotizacion.Location = New System.Drawing.Point(566, 251)
        Me.bntBorrarCotizacion.Name = "bntBorrarCotizacion"
        Me.bntBorrarCotizacion.Size = New System.Drawing.Size(130, 38)
        Me.bntBorrarCotizacion.TabIndex = 3
        Me.bntBorrarCotizacion.Text = "Borrar"
        Me.bntBorrarCotizacion.UseVisualStyleBackColor = False
        '
        'bntAnadirCotizacion
        '
        Me.bntAnadirCotizacion.BackColor = System.Drawing.Color.IndianRed
        Me.bntAnadirCotizacion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAnadirCotizacion.Location = New System.Drawing.Point(401, 190)
        Me.bntAnadirCotizacion.Name = "bntAnadirCotizacion"
        Me.bntAnadirCotizacion.Size = New System.Drawing.Size(130, 38)
        Me.bntAnadirCotizacion.TabIndex = 2
        Me.bntAnadirCotizacion.Text = "Añadir"
        Me.bntAnadirCotizacion.UseVisualStyleBackColor = False
        '
        'lblCotizaciones
        '
        Me.lblCotizaciones.AutoSize = True
        Me.lblCotizaciones.Location = New System.Drawing.Point(37, 13)
        Me.lblCotizaciones.Name = "lblCotizaciones"
        Me.lblCotizaciones.Size = New System.Drawing.Size(124, 21)
        Me.lblCotizaciones.TabIndex = 1
        Me.lblCotizaciones.Text = "Cotizaciones"
        '
        'tabViajes
        '
        Me.tabViajes.BackColor = System.Drawing.Color.LightGray
        Me.tabViajes.Controls.Add(Me.Label1)
        Me.tabViajes.Controls.Add(Me.txtToneladasTransportadas)
        Me.tabViajes.Controls.Add(Me.lblToneladasTransportadas)
        Me.tabViajes.Controls.Add(Me.cbMatriculaTren)
        Me.tabViajes.Controls.Add(Me.dtpFechaViaje)
        Me.tabViajes.Controls.Add(Me.cbProductoTransportado)
        Me.tabViajes.Controls.Add(Me.lblMatriculaViaje)
        Me.tabViajes.Controls.Add(Me.lblFechaViaje)
        Me.tabViajes.Controls.Add(Me.lblProductoTransportado)
        Me.tabViajes.Controls.Add(Me.bntModificarViaje)
        Me.tabViajes.Controls.Add(Me.bntLimpiarViaje)
        Me.tabViajes.Controls.Add(Me.bntBorrarViaje)
        Me.tabViajes.Controls.Add(Me.bntAnadirViaje)
        Me.tabViajes.Controls.Add(Me.PictureBox7)
        Me.tabViajes.Controls.Add(Me.lstViajes)
        Me.tabViajes.Location = New System.Drawing.Point(4, 30)
        Me.tabViajes.Name = "tabViajes"
        Me.tabViajes.Size = New System.Drawing.Size(1024, 309)
        Me.tabViajes.TabIndex = 4
        Me.tabViajes.Text = "Viajes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Viajes"
        '
        'txtToneladasTransportadas
        '
        Me.txtToneladasTransportadas.Location = New System.Drawing.Point(529, 139)
        Me.txtToneladasTransportadas.Name = "txtToneladasTransportadas"
        Me.txtToneladasTransportadas.Size = New System.Drawing.Size(193, 30)
        Me.txtToneladasTransportadas.TabIndex = 26
        '
        'lblToneladasTransportadas
        '
        Me.lblToneladasTransportadas.AutoSize = True
        Me.lblToneladasTransportadas.Location = New System.Drawing.Point(437, 139)
        Me.lblToneladasTransportadas.Name = "lblToneladasTransportadas"
        Me.lblToneladasTransportadas.Size = New System.Drawing.Size(107, 21)
        Me.lblToneladasTransportadas.TabIndex = 25
        Me.lblToneladasTransportadas.Text = "Toneladas:"
        '
        'cbMatriculaTren
        '
        Me.cbMatriculaTren.FormattingEnabled = True
        Me.cbMatriculaTren.Location = New System.Drawing.Point(529, 60)
        Me.cbMatriculaTren.Name = "cbMatriculaTren"
        Me.cbMatriculaTren.Size = New System.Drawing.Size(193, 29)
        Me.cbMatriculaTren.TabIndex = 24
        '
        'dtpFechaViaje
        '
        Me.dtpFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaViaje.Location = New System.Drawing.Point(529, 20)
        Me.dtpFechaViaje.Name = "dtpFechaViaje"
        Me.dtpFechaViaje.Size = New System.Drawing.Size(193, 30)
        Me.dtpFechaViaje.TabIndex = 23
        Me.dtpFechaViaje.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'cbProductoTransportado
        '
        Me.cbProductoTransportado.FormattingEnabled = True
        Me.cbProductoTransportado.Location = New System.Drawing.Point(529, 100)
        Me.cbProductoTransportado.Name = "cbProductoTransportado"
        Me.cbProductoTransportado.Size = New System.Drawing.Size(193, 29)
        Me.cbProductoTransportado.TabIndex = 22
        '
        'lblMatriculaViaje
        '
        Me.lblMatriculaViaje.AutoSize = True
        Me.lblMatriculaViaje.Location = New System.Drawing.Point(434, 63)
        Me.lblMatriculaViaje.Name = "lblMatriculaViaje"
        Me.lblMatriculaViaje.Size = New System.Drawing.Size(100, 21)
        Me.lblMatriculaViaje.TabIndex = 21
        Me.lblMatriculaViaje.Text = "Matricula:"
        '
        'lblFechaViaje
        '
        Me.lblFechaViaje.AutoSize = True
        Me.lblFechaViaje.Location = New System.Drawing.Point(434, 26)
        Me.lblFechaViaje.Name = "lblFechaViaje"
        Me.lblFechaViaje.Size = New System.Drawing.Size(68, 21)
        Me.lblFechaViaje.TabIndex = 20
        Me.lblFechaViaje.Text = "Fecha:"
        '
        'lblProductoTransportado
        '
        Me.lblProductoTransportado.AutoSize = True
        Me.lblProductoTransportado.Location = New System.Drawing.Point(437, 103)
        Me.lblProductoTransportado.Name = "lblProductoTransportado"
        Me.lblProductoTransportado.Size = New System.Drawing.Size(96, 21)
        Me.lblProductoTransportado.TabIndex = 19
        Me.lblProductoTransportado.Text = "Producto:"
        '
        'bntModificarViaje
        '
        Me.bntModificarViaje.BackColor = System.Drawing.Color.IndianRed
        Me.bntModificarViaje.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarViaje.Location = New System.Drawing.Point(592, 184)
        Me.bntModificarViaje.Name = "bntModificarViaje"
        Me.bntModificarViaje.Size = New System.Drawing.Size(130, 38)
        Me.bntModificarViaje.TabIndex = 17
        Me.bntModificarViaje.Text = "Modificar"
        Me.bntModificarViaje.UseVisualStyleBackColor = False
        '
        'bntLimpiarViaje
        '
        Me.bntLimpiarViaje.BackColor = System.Drawing.Color.IndianRed
        Me.bntLimpiarViaje.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiarViaje.Location = New System.Drawing.Point(440, 242)
        Me.bntLimpiarViaje.Name = "bntLimpiarViaje"
        Me.bntLimpiarViaje.Size = New System.Drawing.Size(130, 38)
        Me.bntLimpiarViaje.TabIndex = 16
        Me.bntLimpiarViaje.Text = "Limpiar"
        Me.bntLimpiarViaje.UseVisualStyleBackColor = False
        '
        'bntBorrarViaje
        '
        Me.bntBorrarViaje.BackColor = System.Drawing.Color.IndianRed
        Me.bntBorrarViaje.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntBorrarViaje.Location = New System.Drawing.Point(592, 242)
        Me.bntBorrarViaje.Name = "bntBorrarViaje"
        Me.bntBorrarViaje.Size = New System.Drawing.Size(130, 38)
        Me.bntBorrarViaje.TabIndex = 15
        Me.bntBorrarViaje.Text = "Borrar"
        Me.bntBorrarViaje.UseVisualStyleBackColor = False
        '
        'bntAnadirViaje
        '
        Me.bntAnadirViaje.BackColor = System.Drawing.Color.IndianRed
        Me.bntAnadirViaje.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAnadirViaje.Location = New System.Drawing.Point(440, 184)
        Me.bntAnadirViaje.Name = "bntAnadirViaje"
        Me.bntAnadirViaje.Size = New System.Drawing.Size(130, 38)
        Me.bntAnadirViaje.TabIndex = 14
        Me.bntAnadirViaje.Text = "Añadir"
        Me.bntAnadirViaje.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.practica3.My.Resources.Resources._812LdAPLxYL__AC_SL1500_
        Me.PictureBox7.Location = New System.Drawing.Point(759, 20)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(186, 262)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 27
        Me.PictureBox7.TabStop = False
        '
        'lstViajes
        '
        Me.lstViajes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.fechaViaje, Me.matricula, Me.ProductoT, Me.Toneladas})
        Me.lstViajes.FullRowSelect = True
        Me.lstViajes.HideSelection = False
        Me.lstViajes.Location = New System.Drawing.Point(27, 41)
        Me.lstViajes.MultiSelect = False
        Me.lstViajes.Name = "lstViajes"
        Me.lstViajes.Size = New System.Drawing.Size(383, 239)
        Me.lstViajes.TabIndex = 0
        Me.lstViajes.UseCompatibleStateImageBehavior = False
        Me.lstViajes.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "id"
        Me.id.Width = 0
        '
        'fechaViaje
        '
        Me.fechaViaje.Text = "Fecha"
        Me.fechaViaje.Width = 115
        '
        'matricula
        '
        Me.matricula.Text = "Matricula"
        Me.matricula.Width = 96
        '
        'ProductoT
        '
        Me.ProductoT.Text = "Producto"
        Me.ProductoT.Width = 80
        '
        'Toneladas
        '
        Me.Toneladas.Text = "Toneladas"
        Me.Toneladas.Width = 90
        '
        'tabConsulta1
        '
        Me.tabConsulta1.BackColor = System.Drawing.Color.LightGray
        Me.tabConsulta1.Controls.Add(Me.PictureBox8)
        Me.tabConsulta1.Controls.Add(Me.lblListaConsulta1)
        Me.tabConsulta1.Controls.Add(Me.lblNumeroViajes)
        Me.tabConsulta1.Controls.Add(Me.bntLimpiarConsulta1)
        Me.tabConsulta1.Controls.Add(Me.Label3)
        Me.tabConsulta1.Controls.Add(Me.lblFechaFin)
        Me.tabConsulta1.Controls.Add(Me.lblFechaInicio)
        Me.tabConsulta1.Controls.Add(Me.cbConsulta1)
        Me.tabConsulta1.Controls.Add(Me.lstConsulta1)
        Me.tabConsulta1.Controls.Add(Me.dtpFechaInicioConsulta1)
        Me.tabConsulta1.Controls.Add(Me.dtpFechaFinConsulta1)
        Me.tabConsulta1.Controls.Add(Me.bntConsulta1)
        Me.tabConsulta1.Location = New System.Drawing.Point(4, 30)
        Me.tabConsulta1.Name = "tabConsulta1"
        Me.tabConsulta1.Size = New System.Drawing.Size(1024, 309)
        Me.tabConsulta1.TabIndex = 5
        Me.tabConsulta1.Text = "Consulta 1"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.practica3.My.Resources.Resources.list_640px
        Me.PictureBox8.Location = New System.Drawing.Point(679, 73)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(271, 208)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'lblListaConsulta1
        '
        Me.lblListaConsulta1.AutoSize = True
        Me.lblListaConsulta1.Location = New System.Drawing.Point(347, 73)
        Me.lblListaConsulta1.Name = "lblListaConsulta1"
        Me.lblListaConsulta1.Size = New System.Drawing.Size(354, 21)
        Me.lblListaConsulta1.TabIndex = 10
        Me.lblListaConsulta1.Text = "La lista de productos transportados es:"
        Me.lblListaConsulta1.Visible = False
        '
        'lblNumeroViajes
        '
        Me.lblNumeroViajes.AutoSize = True
        Me.lblNumeroViajes.Location = New System.Drawing.Point(346, 38)
        Me.lblNumeroViajes.Name = "lblNumeroViajes"
        Me.lblNumeroViajes.Size = New System.Drawing.Size(69, 21)
        Me.lblNumeroViajes.TabIndex = 9
        Me.lblNumeroViajes.Text = "Label1"
        Me.lblNumeroViajes.Visible = False
        '
        'bntLimpiarConsulta1
        '
        Me.bntLimpiarConsulta1.BackColor = System.Drawing.Color.IndianRed
        Me.bntLimpiarConsulta1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiarConsulta1.Location = New System.Drawing.Point(102, 243)
        Me.bntLimpiarConsulta1.Name = "bntLimpiarConsulta1"
        Me.bntLimpiarConsulta1.Size = New System.Drawing.Size(185, 38)
        Me.bntLimpiarConsulta1.TabIndex = 8
        Me.bntLimpiarConsulta1.Text = "Limpiar"
        Me.bntLimpiarConsulta1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tren:"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(52, 73)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(100, 21)
        Me.lblFechaFin.TabIndex = 6
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(39, 38)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(123, 21)
        Me.lblFechaInicio.TabIndex = 5
        Me.lblFechaInicio.Text = "Fecha Inicio:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbConsulta1
        '
        Me.cbConsulta1.FormattingEnabled = True
        Me.cbConsulta1.Location = New System.Drawing.Point(142, 110)
        Me.cbConsulta1.Name = "cbConsulta1"
        Me.cbConsulta1.Size = New System.Drawing.Size(145, 29)
        Me.cbConsulta1.TabIndex = 4
        '
        'lstConsulta1
        '
        Me.lstConsulta1.FormattingEnabled = True
        Me.lstConsulta1.ItemHeight = 21
        Me.lstConsulta1.Location = New System.Drawing.Point(350, 107)
        Me.lstConsulta1.Name = "lstConsulta1"
        Me.lstConsulta1.Size = New System.Drawing.Size(277, 151)
        Me.lstConsulta1.TabIndex = 3
        Me.lstConsulta1.Visible = False
        '
        'dtpFechaInicioConsulta1
        '
        Me.dtpFechaInicioConsulta1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicioConsulta1.Location = New System.Drawing.Point(142, 38)
        Me.dtpFechaInicioConsulta1.Name = "dtpFechaInicioConsulta1"
        Me.dtpFechaInicioConsulta1.Size = New System.Drawing.Size(145, 30)
        Me.dtpFechaInicioConsulta1.TabIndex = 2
        Me.dtpFechaInicioConsulta1.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'dtpFechaFinConsulta1
        '
        Me.dtpFechaFinConsulta1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinConsulta1.Location = New System.Drawing.Point(142, 73)
        Me.dtpFechaFinConsulta1.Name = "dtpFechaFinConsulta1"
        Me.dtpFechaFinConsulta1.Size = New System.Drawing.Size(145, 30)
        Me.dtpFechaFinConsulta1.TabIndex = 1
        Me.dtpFechaFinConsulta1.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'bntConsulta1
        '
        Me.bntConsulta1.BackColor = System.Drawing.Color.IndianRed
        Me.bntConsulta1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntConsulta1.Location = New System.Drawing.Point(102, 176)
        Me.bntConsulta1.Name = "bntConsulta1"
        Me.bntConsulta1.Size = New System.Drawing.Size(185, 38)
        Me.bntConsulta1.TabIndex = 0
        Me.bntConsulta1.Text = "Realizar Consulta"
        Me.bntConsulta1.UseVisualStyleBackColor = False
        '
        'tabConsulta23
        '
        Me.tabConsulta23.BackColor = System.Drawing.Color.LightGray
        Me.tabConsulta23.Controls.Add(Me.lstConsulta3)
        Me.tabConsulta23.Controls.Add(Me.lstConsulta2)
        Me.tabConsulta23.Controls.Add(Me.PictureBox9)
        Me.tabConsulta23.Controls.Add(Me.lblRankingConsulta3)
        Me.tabConsulta23.Controls.Add(Me.lblRankingConsulta2)
        Me.tabConsulta23.Controls.Add(Me.bntLimpiarConsulta2)
        Me.tabConsulta23.Controls.Add(Me.bntConsulta3)
        Me.tabConsulta23.Controls.Add(Me.dtpFechaFinConsulta23)
        Me.tabConsulta23.Controls.Add(Me.lblFechaFinConsulta23)
        Me.tabConsulta23.Controls.Add(Me.bntConsulta2)
        Me.tabConsulta23.Controls.Add(Me.lblFechaInicioConsulta23)
        Me.tabConsulta23.Controls.Add(Me.dtpFechaInicioConsulta23)
        Me.tabConsulta23.Location = New System.Drawing.Point(4, 30)
        Me.tabConsulta23.Name = "tabConsulta23"
        Me.tabConsulta23.Size = New System.Drawing.Size(1024, 309)
        Me.tabConsulta23.TabIndex = 6
        Me.tabConsulta23.Text = "Consulta 2 y 3"
        '
        'lstConsulta3
        '
        Me.lstConsulta3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nProducto, Me.cantidad})
        Me.lstConsulta3.HideSelection = False
        Me.lstConsulta3.Location = New System.Drawing.Point(753, 59)
        Me.lstConsulta3.MultiSelect = False
        Me.lstConsulta3.Name = "lstConsulta3"
        Me.lstConsulta3.Size = New System.Drawing.Size(193, 202)
        Me.lstConsulta3.TabIndex = 13
        Me.lstConsulta3.UseCompatibleStateImageBehavior = False
        Me.lstConsulta3.View = System.Windows.Forms.View.Details
        Me.lstConsulta3.Visible = False
        '
        'nProducto
        '
        Me.nProducto.Text = "Producto"
        Me.nProducto.Width = 114
        '
        'cantidad
        '
        Me.cantidad.Text = "Viajes"
        Me.cantidad.Width = 83
        '
        'lstConsulta2
        '
        Me.lstConsulta2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tipoTren, Me.viajes})
        Me.lstConsulta2.HideSelection = False
        Me.lstConsulta2.Location = New System.Drawing.Point(326, 59)
        Me.lstConsulta2.MultiSelect = False
        Me.lstConsulta2.Name = "lstConsulta2"
        Me.lstConsulta2.Size = New System.Drawing.Size(193, 202)
        Me.lstConsulta2.TabIndex = 12
        Me.lstConsulta2.UseCompatibleStateImageBehavior = False
        Me.lstConsulta2.View = System.Windows.Forms.View.Details
        Me.lstConsulta2.Visible = False
        '
        'tipoTren
        '
        Me.tipoTren.Text = "Nombre"
        Me.tipoTren.Width = 107
        '
        'viajes
        '
        Me.viajes.Text = "Viajes"
        Me.viajes.Width = 83
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.practica3.My.Resources.Resources._3acdac0786ff283071d07756d03a7517
        Me.PictureBox9.Location = New System.Drawing.Point(548, 42)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(183, 244)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        '
        'lblRankingConsulta3
        '
        Me.lblRankingConsulta3.AutoSize = True
        Me.lblRankingConsulta3.Location = New System.Drawing.Point(764, 26)
        Me.lblRankingConsulta3.Name = "lblRankingConsulta3"
        Me.lblRankingConsulta3.Size = New System.Drawing.Size(182, 21)
        Me.lblRankingConsulta3.TabIndex = 10
        Me.lblRankingConsulta3.Text = "Ranking Productos:"
        Me.lblRankingConsulta3.Visible = False
        '
        'lblRankingConsulta2
        '
        Me.lblRankingConsulta2.AutoSize = True
        Me.lblRankingConsulta2.Location = New System.Drawing.Point(352, 26)
        Me.lblRankingConsulta2.Name = "lblRankingConsulta2"
        Me.lblRankingConsulta2.Size = New System.Drawing.Size(179, 21)
        Me.lblRankingConsulta2.TabIndex = 8
        Me.lblRankingConsulta2.Text = "Ranking Tipo Tren:"
        Me.lblRankingConsulta2.Visible = False
        '
        'bntLimpiarConsulta2
        '
        Me.bntLimpiarConsulta2.BackColor = System.Drawing.Color.IndianRed
        Me.bntLimpiarConsulta2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiarConsulta2.Location = New System.Drawing.Point(42, 233)
        Me.bntLimpiarConsulta2.Name = "bntLimpiarConsulta2"
        Me.bntLimpiarConsulta2.Size = New System.Drawing.Size(249, 38)
        Me.bntLimpiarConsulta2.TabIndex = 7
        Me.bntLimpiarConsulta2.Text = "Limpiar"
        Me.bntLimpiarConsulta2.UseVisualStyleBackColor = False
        '
        'bntConsulta3
        '
        Me.bntConsulta3.BackColor = System.Drawing.Color.IndianRed
        Me.bntConsulta3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntConsulta3.Location = New System.Drawing.Point(42, 190)
        Me.bntConsulta3.Name = "bntConsulta3"
        Me.bntConsulta3.Size = New System.Drawing.Size(249, 38)
        Me.bntConsulta3.TabIndex = 6
        Me.bntConsulta3.Text = "Ranking Productos"
        Me.bntConsulta3.UseVisualStyleBackColor = False
        '
        'dtpFechaFinConsulta23
        '
        Me.dtpFechaFinConsulta23.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinConsulta23.Location = New System.Drawing.Point(129, 94)
        Me.dtpFechaFinConsulta23.Name = "dtpFechaFinConsulta23"
        Me.dtpFechaFinConsulta23.Size = New System.Drawing.Size(162, 30)
        Me.dtpFechaFinConsulta23.TabIndex = 5
        Me.dtpFechaFinConsulta23.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'lblFechaFinConsulta23
        '
        Me.lblFechaFinConsulta23.AutoSize = True
        Me.lblFechaFinConsulta23.Location = New System.Drawing.Point(39, 94)
        Me.lblFechaFinConsulta23.Name = "lblFechaFinConsulta23"
        Me.lblFechaFinConsulta23.Size = New System.Drawing.Size(100, 21)
        Me.lblFechaFinConsulta23.TabIndex = 4
        Me.lblFechaFinConsulta23.Text = "Fecha Fin:"
        '
        'bntConsulta2
        '
        Me.bntConsulta2.BackColor = System.Drawing.Color.IndianRed
        Me.bntConsulta2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntConsulta2.Location = New System.Drawing.Point(42, 144)
        Me.bntConsulta2.Name = "bntConsulta2"
        Me.bntConsulta2.Size = New System.Drawing.Size(249, 38)
        Me.bntConsulta2.TabIndex = 3
        Me.bntConsulta2.Text = "Ranking Tipo Tren"
        Me.bntConsulta2.UseVisualStyleBackColor = False
        '
        'lblFechaInicioConsulta23
        '
        Me.lblFechaInicioConsulta23.AutoSize = True
        Me.lblFechaInicioConsulta23.Location = New System.Drawing.Point(24, 42)
        Me.lblFechaInicioConsulta23.Name = "lblFechaInicioConsulta23"
        Me.lblFechaInicioConsulta23.Size = New System.Drawing.Size(123, 21)
        Me.lblFechaInicioConsulta23.TabIndex = 2
        Me.lblFechaInicioConsulta23.Text = "Fecha Inicio:"
        '
        'dtpFechaInicioConsulta23
        '
        Me.dtpFechaInicioConsulta23.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicioConsulta23.Location = New System.Drawing.Point(129, 42)
        Me.dtpFechaInicioConsulta23.Name = "dtpFechaInicioConsulta23"
        Me.dtpFechaInicioConsulta23.Size = New System.Drawing.Size(162, 30)
        Me.dtpFechaInicioConsulta23.TabIndex = 0
        Me.dtpFechaInicioConsulta23.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'tabConsulta4
        '
        Me.tabConsulta4.BackColor = System.Drawing.Color.LightGray
        Me.tabConsulta4.Controls.Add(Me.btnLimpiarConsulta4)
        Me.tabConsulta4.Controls.Add(Me.PictureBox10)
        Me.tabConsulta4.Controls.Add(Me.lblConsulta4)
        Me.tabConsulta4.Controls.Add(Me.lstConsulta4)
        Me.tabConsulta4.Controls.Add(Me.bntConsulta4)
        Me.tabConsulta4.Location = New System.Drawing.Point(4, 30)
        Me.tabConsulta4.Name = "tabConsulta4"
        Me.tabConsulta4.Size = New System.Drawing.Size(1024, 309)
        Me.tabConsulta4.TabIndex = 7
        Me.tabConsulta4.Text = "Consulta 4"
        '
        'btnLimpiarConsulta4
        '
        Me.btnLimpiarConsulta4.BackColor = System.Drawing.Color.IndianRed
        Me.btnLimpiarConsulta4.Enabled = False
        Me.btnLimpiarConsulta4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarConsulta4.Location = New System.Drawing.Point(472, 258)
        Me.btnLimpiarConsulta4.Name = "btnLimpiarConsulta4"
        Me.btnLimpiarConsulta4.Size = New System.Drawing.Size(249, 38)
        Me.btnLimpiarConsulta4.TabIndex = 4
        Me.btnLimpiarConsulta4.Text = "Limpiar "
        Me.btnLimpiarConsulta4.UseVisualStyleBackColor = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.practica3.My.Resources.Resources.CoyoteVSAcme_Correcaminos
        Me.PictureBox10.Location = New System.Drawing.Point(775, 29)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(229, 190)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 3
        Me.PictureBox10.TabStop = False
        '
        'lblConsulta4
        '
        Me.lblConsulta4.Location = New System.Drawing.Point(23, 212)
        Me.lblConsulta4.Name = "lblConsulta4"
        Me.lblConsulta4.Size = New System.Drawing.Size(624, 43)
        Me.lblConsulta4.TabIndex = 2
        Me.lblConsulta4.Text = "Label1"
        Me.lblConsulta4.Visible = False
        '
        'lstConsulta4
        '
        Me.lstConsulta4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FechaConsulta4, Me.MatriculaConsulta4, Me.TipoConsulta4, Me.ProductoConsulta4, Me.cotizacionConsulta4, Me.EurosConsulta4, Me.ToneladasConsulta4, Me.BeneficioConsulta4})
        Me.lstConsulta4.HideSelection = False
        Me.lstConsulta4.Location = New System.Drawing.Point(16, 29)
        Me.lstConsulta4.Name = "lstConsulta4"
        Me.lstConsulta4.Size = New System.Drawing.Size(753, 169)
        Me.lstConsulta4.TabIndex = 1
        Me.lstConsulta4.UseCompatibleStateImageBehavior = False
        Me.lstConsulta4.View = System.Windows.Forms.View.Details
        Me.lstConsulta4.Visible = False
        '
        'FechaConsulta4
        '
        Me.FechaConsulta4.Text = "Fecha"
        Me.FechaConsulta4.Width = 107
        '
        'MatriculaConsulta4
        '
        Me.MatriculaConsulta4.Text = "Matricula"
        Me.MatriculaConsulta4.Width = 97
        '
        'TipoConsulta4
        '
        Me.TipoConsulta4.Text = "Tipo Tren"
        Me.TipoConsulta4.Width = 115
        '
        'ProductoConsulta4
        '
        Me.ProductoConsulta4.Text = "Producto"
        Me.ProductoConsulta4.Width = 92
        '
        'cotizacionConsulta4
        '
        Me.cotizacionConsulta4.Text = "Cotizacion"
        Me.cotizacionConsulta4.Width = 116
        '
        'EurosConsulta4
        '
        Me.EurosConsulta4.Text = "€/T"
        Me.EurosConsulta4.Width = 53
        '
        'ToneladasConsulta4
        '
        Me.ToneladasConsulta4.Text = "Toneladas"
        Me.ToneladasConsulta4.Width = 105
        '
        'BeneficioConsulta4
        '
        Me.BeneficioConsulta4.Text = "Beneficio"
        Me.BeneficioConsulta4.Width = 96
        '
        'bntConsulta4
        '
        Me.bntConsulta4.BackColor = System.Drawing.Color.IndianRed
        Me.bntConsulta4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntConsulta4.Location = New System.Drawing.Point(217, 258)
        Me.bntConsulta4.Name = "bntConsulta4"
        Me.bntConsulta4.Size = New System.Drawing.Size(249, 38)
        Me.bntConsulta4.TabIndex = 0
        Me.bntConsulta4.Text = "Viaje Mayor Beneficio"
        Me.bntConsulta4.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lblcomponentes)
        Me.TabPage1.Controls.Add(Me.lblIsabel)
        Me.TabPage1.Controls.Add(Me.lblRoque)
        Me.TabPage1.Controls.Add(Me.PictureBox12)
        Me.TabPage1.Controls.Add(Me.PictureBox11)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1024, 309)
        Me.TabPage1.TabIndex = 8
        Me.TabPage1.Text = "Información"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(583, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Javier Verdugo Lara"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(527, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 33)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Profesor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(580, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bases de Datos (Laboratorio)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(527, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Asignatura:"
        '
        'lblcomponentes
        '
        Me.lblcomponentes.AutoSize = True
        Me.lblcomponentes.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomponentes.Location = New System.Drawing.Point(21, 21)
        Me.lblcomponentes.Name = "lblcomponentes"
        Me.lblcomponentes.Size = New System.Drawing.Size(208, 33)
        Me.lblcomponentes.TabIndex = 4
        Me.lblcomponentes.Text = "Componentes:"
        '
        'lblIsabel
        '
        Me.lblIsabel.AutoSize = True
        Me.lblIsabel.Location = New System.Drawing.Point(269, 247)
        Me.lblIsabel.Name = "lblIsabel"
        Me.lblIsabel.Size = New System.Drawing.Size(204, 21)
        Me.lblIsabel.TabIndex = 1
        Me.lblIsabel.Text = "Isabel Diezma Molero"
        '
        'lblRoque
        '
        Me.lblRoque.AutoSize = True
        Me.lblRoque.Location = New System.Drawing.Point(61, 247)
        Me.lblRoque.Name = "lblRoque"
        Me.lblRoque.Size = New System.Drawing.Size(174, 21)
        Me.lblRoque.TabIndex = 0
        Me.lblRoque.Text = "Roque Rojo Bacete"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.practica3.My.Resources.Resources.índice
        Me.PictureBox12.Location = New System.Drawing.Point(532, 247)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(200, 50)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 6
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.practica3.My.Resources.Resources.banner_uclm
        Me.PictureBox11.Location = New System.Drawing.Point(765, 247)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(183, 50)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 5
        Me.PictureBox11.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.practica3.My.Resources.Resources.Wile__E__Coyote_Smiling_26499
        Me.PictureBox3.Location = New System.Drawing.Point(54, 70)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(161, 145)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.practica3.My.Resources.Resources.correcaminos
        Me.PictureBox2.Location = New System.Drawing.Point(272, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 145)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedor.Location = New System.Drawing.Point(14, 385)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(440, 24)
        Me.lblproveedor.TabIndex = 4
        Me.lblproveedor.Text = "¿Estás listo para elegirnos como proveedor?"
        '
        'lblsubtitulo
        '
        Me.lblsubtitulo.AutoSize = True
        Me.lblsubtitulo.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtitulo.Location = New System.Drawing.Point(779, 483)
        Me.lblsubtitulo.Name = "lblsubtitulo"
        Me.lblsubtitulo.Size = New System.Drawing.Size(267, 29)
        Me.lblsubtitulo.TabIndex = 5
        Me.lblsubtitulo.Text = "Práctica 3 BBDD 2020"
        '
        'imghauling
        '
        Me.imghauling.Image = Global.practica3.My.Resources.Resources.Captura1
        Me.imghauling.Location = New System.Drawing.Point(18, 370)
        Me.imghauling.Name = "imghauling"
        Me.imghauling.Size = New System.Drawing.Size(482, 133)
        Me.imghauling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imghauling.TabIndex = 6
        Me.imghauling.TabStop = False
        Me.imghauling.Visible = False
        '
        'FGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 515)
        Me.Controls.Add(Me.imghauling)
        Me.Controls.Add(Me.lblsubtitulo)
        Me.Controls.Add(Me.lblproveedor)
        Me.Controls.Add(Me.TabGeneral)
        Me.Controls.Add(Me.btnEmpezar)
        Me.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acme Corporation S.A"
        Me.TabGeneral.ResumeLayout(False)
        Me.tabTren.ResumeLayout(False)
        Me.tabTren.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTipoTren.ResumeLayout(False)
        Me.tabTipoTren.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProductos.ResumeLayout(False)
        Me.tabProductos.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCotizaciones.ResumeLayout(False)
        Me.tabCotizaciones.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabViajes.ResumeLayout(False)
        Me.tabViajes.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsulta1.ResumeLayout(False)
        Me.tabConsulta1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsulta23.ResumeLayout(False)
        Me.tabConsulta23.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsulta4.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imghauling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEmpezar As Button
    Friend WithEvents ofdRuta As OpenFileDialog
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents tabTren As TabPage
    Friend WithEvents tabTipoTren As TabPage
    Friend WithEvents tabProductos As TabPage
    Friend WithEvents bntBorrarProducto As Button
    Friend WithEvents bntLimpiarProducto As Button
    Friend WithEvents bntModificarProducto As Button
    Friend WithEvents bntAnadirProducto As Button
    Friend WithEvents lblProductos As Label
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents tabCotizaciones As TabPage
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblTiposTrenes As Label
    Friend WithEvents lstTiposTrenes As ListBox
    Friend WithEvents bntModificarTT As Button
    Friend WithEvents bntBorrarTT As Button
    Friend WithEvents bntLimpiarTT As Button
    Friend WithEvents bntAnadirTT As Button
    Friend WithEvents lblCapacidadMax As Label
    Friend WithEvents lblIdTT As Label
    Friend WithEvents lblDescripcionTT As Label
    Friend WithEvents txtCapacidadMax As TextBox
    Friend WithEvents txtDescripcionTT As TextBox
    Friend WithEvents txtIdTipoTren As TextBox
    Friend WithEvents bntLimpiarTren As Button
    Friend WithEvents bntBorrarTren As Button
    Friend WithEvents bntModificarTren As Button
    Friend WithEvents bntAnadirTren As Button
    Friend WithEvents lblTrenes As Label
    Friend WithEvents lstTrenes As ListBox
    Friend WithEvents cbTipoTren As ComboBox
    Friend WithEvents lblTipoTren As Label
    Friend WithEvents lblMatricula As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents bntModificarCotizacion As Button
    Friend WithEvents bntLimpiarCotizacion As Button
    Friend WithEvents bntBorrarCotizacion As Button
    Friend WithEvents bntAnadirCotizacion As Button
    Friend WithEvents lblCotizaciones As Label
    Friend WithEvents lblEurosPorTonelada As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtEurosPorTonelada As TextBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents lblIdProducto As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lstCotizaciones As ListView
    Friend WithEvents idProducto As ColumnHeader
    Friend WithEvents Producto As ColumnHeader
    Friend WithEvents Fecha As ColumnHeader
    Friend WithEvents Euros As ColumnHeader
    Friend WithEvents tabViajes As TabPage
    Friend WithEvents lstViajes As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents fechaViaje As ColumnHeader
    Friend WithEvents matricula As ColumnHeader
    Friend WithEvents ProductoT As ColumnHeader
    Friend WithEvents Toneladas As ColumnHeader
    Friend WithEvents txtToneladasTransportadas As TextBox
    Friend WithEvents lblToneladasTransportadas As Label
    Friend WithEvents cbMatriculaTren As ComboBox
    Friend WithEvents dtpFechaViaje As DateTimePicker
    Friend WithEvents cbProductoTransportado As ComboBox
    Friend WithEvents lblMatriculaViaje As Label
    Friend WithEvents lblFechaViaje As Label
    Friend WithEvents lblProductoTransportado As Label
    Friend WithEvents bntModificarViaje As Button
    Friend WithEvents bntLimpiarViaje As Button
    Friend WithEvents bntBorrarViaje As Button
    Friend WithEvents bntAnadirViaje As Button
    Friend WithEvents tabConsulta1 As TabPage
    Friend WithEvents lstConsulta1 As ListBox
    Friend WithEvents dtpFechaInicioConsulta1 As DateTimePicker
    Friend WithEvents dtpFechaFinConsulta1 As DateTimePicker
    Friend WithEvents bntConsulta1 As Button
    Friend WithEvents cbConsulta1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents lblNumeroViajes As Label
    Friend WithEvents bntLimpiarConsulta1 As Button
    Friend WithEvents lblListaConsulta1 As Label
    Friend WithEvents tabConsulta23 As TabPage
    Friend WithEvents lblRankingConsulta2 As Label
    Friend WithEvents bntLimpiarConsulta2 As Button
    Friend WithEvents bntConsulta3 As Button
    Friend WithEvents dtpFechaFinConsulta23 As DateTimePicker
    Friend WithEvents lblFechaFinConsulta23 As Label
    Friend WithEvents bntConsulta2 As Button
    Friend WithEvents lblFechaInicioConsulta23 As Label
    Friend WithEvents dtpFechaInicioConsulta23 As DateTimePicker
    Friend WithEvents lblRankingConsulta3 As Label
    Friend WithEvents tabConsulta4 As TabPage
    Friend WithEvents lstConsulta4 As ListView
    Friend WithEvents bntConsulta4 As Button
    Friend WithEvents FechaConsulta4 As ColumnHeader
    Friend WithEvents MatriculaConsulta4 As ColumnHeader
    Friend WithEvents TipoConsulta4 As ColumnHeader
    Friend WithEvents ProductoConsulta4 As ColumnHeader
    Friend WithEvents EurosConsulta4 As ColumnHeader
    Friend WithEvents ToneladasConsulta4 As ColumnHeader
    Friend WithEvents BeneficioConsulta4 As ColumnHeader
    Friend WithEvents lblConsulta4 As Label
    Friend WithEvents lblproveedor As Label
    Friend WithEvents lblsubtitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblRoque As Label
    Friend WithEvents lblIsabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblcomponentes As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imghauling As PictureBox
    Friend WithEvents btnLimpiarConsulta4 As Button
    Friend WithEvents lstConsulta2 As ListView
    Friend WithEvents lstConsulta3 As ListView
    Friend WithEvents nProducto As ColumnHeader
    Friend WithEvents cantidad As ColumnHeader
    Friend WithEvents tipoTren As ColumnHeader
    Friend WithEvents viajes As ColumnHeader
    Friend WithEvents cotizacionConsulta4 As ColumnHeader
End Class
