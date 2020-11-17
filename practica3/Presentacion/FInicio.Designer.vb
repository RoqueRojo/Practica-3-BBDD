<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FInicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        Me.Logo = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnSeleccionar
        '
        resources.ApplyResources(Me.btnSeleccionar, "btnSeleccionar")
        Me.btnSeleccionar.BackColor = System.Drawing.Color.IndianRed
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'btnConectar
        '
        resources.ApplyResources(Me.btnConectar, "btnConectar")
        Me.btnConectar.BackColor = System.Drawing.Color.IndianRed
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'txtRuta
        '
        resources.ApplyResources(Me.txtRuta, "txtRuta")
        Me.txtRuta.Name = "txtRuta"
        '
        'ofdRuta
        '
        Me.ofdRuta.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.ofdRuta, "ofdRuta")
        '
        'Logo
        '
        resources.ApplyResources(Me.Logo, "Logo")
        Me.Logo.Image = Global.practica3.My.Resources.Resources.acme
        Me.Logo.Name = "Logo"
        Me.Logo.TabStop = False
        '
        'FInicio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FInicio"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnConectar As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents ofdRuta As OpenFileDialog
End Class
