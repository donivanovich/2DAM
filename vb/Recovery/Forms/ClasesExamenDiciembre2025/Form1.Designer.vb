<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.CreacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirDatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirAsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirDatosBancariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarDatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarAsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListasDatosBancariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversorDeNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 48)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreacionToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip3.TabIndex = 2
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'CreacionToolStripMenuItem
        '
        Me.CreacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearAlumnoToolStripMenuItem, Me.IntroducirDatosPersonalesToolStripMenuItem, Me.IntroducirAsignaturasToolStripMenuItem, Me.IntroducirDatosBancariosToolStripMenuItem, Me.IntroducirNotasToolStripMenuItem})
        Me.CreacionToolStripMenuItem.Name = "CreacionToolStripMenuItem"
        Me.CreacionToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CreacionToolStripMenuItem.Text = "Creacion"
        '
        'CrearAlumnoToolStripMenuItem1
        '
        Me.CrearAlumnoToolStripMenuItem.Name = "CrearAlumnoToolStripMenuItem1"
        Me.CrearAlumnoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CrearAlumnoToolStripMenuItem.Text = "Crear Alumno"
        '
        'IntroducirDatosPersonalesToolStripMenuItem
        '
        Me.IntroducirDatosPersonalesToolStripMenuItem.Name = "IntroducirDatosPersonalesToolStripMenuItem"
        Me.IntroducirDatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirDatosPersonalesToolStripMenuItem.Text = "Introducir Datos Personales"
        '
        'IntroducirAsignaturasToolStripMenuItem
        '
        Me.IntroducirAsignaturasToolStripMenuItem.Name = "IntroducirAsignaturasToolStripMenuItem"
        Me.IntroducirAsignaturasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirAsignaturasToolStripMenuItem.Text = "Introducir Asignaturas"
        '
        'IntroducirDatosBancariosToolStripMenuItem
        '
        Me.IntroducirDatosBancariosToolStripMenuItem.Name = "IntroducirDatosBancariosToolStripMenuItem"
        Me.IntroducirDatosBancariosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirDatosBancariosToolStripMenuItem.Text = "Introducir Datos Bancarios"
        '
        'IntroducirNotasToolStripMenuItem
        '
        Me.IntroducirNotasToolStripMenuItem.Name = "IntroducirNotasToolStripMenuItem"
        Me.IntroducirNotasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirNotasToolStripMenuItem.Text = "Introducir Notas"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarDatosPersonalesToolStripMenuItem, Me.ListarAsignaturasToolStripMenuItem, Me.ListasDatosBancariosToolStripMenuItem, Me.ListarNotasToolStripMenuItem})
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'ListarDatosPersonalesToolStripMenuItem
        '
        Me.ListarDatosPersonalesToolStripMenuItem.Name = "ListarDatosPersonalesToolStripMenuItem"
        Me.ListarDatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListarDatosPersonalesToolStripMenuItem.Text = "Listar Datos Personales"
        '
        'ListarAsignaturasToolStripMenuItem
        '
        Me.ListarAsignaturasToolStripMenuItem.Name = "ListarAsignaturasToolStripMenuItem"
        Me.ListarAsignaturasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListarAsignaturasToolStripMenuItem.Text = "Listar Asignaturas"
        '
        'ListasDatosBancariosToolStripMenuItem
        '
        Me.ListasDatosBancariosToolStripMenuItem.Name = "ListasDatosBancariosToolStripMenuItem"
        Me.ListasDatosBancariosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListasDatosBancariosToolStripMenuItem.Text = "Listas Datos Bancarios"
        '
        'ListarNotasToolStripMenuItem
        '
        Me.ListarNotasToolStripMenuItem.Name = "ListarNotasToolStripMenuItem"
        Me.ListarNotasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListarNotasToolStripMenuItem.Text = "Listar Notas"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.ConversorDeNotaToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'ConversorDeNotaToolStripMenuItem
        '
        Me.ConversorDeNotaToolStripMenuItem.Name = "ConversorDeNotaToolStripMenuItem"
        Me.ConversorDeNotaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ConversorDeNotaToolStripMenuItem.Text = "Conversor de Notas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip3)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu Principal"
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents CreacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirDatosPersonalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConversorDeNotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirAsignaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirDatosBancariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarDatosPersonalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarAsignaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListasDatosBancariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarNotasToolStripMenuItem As ToolStripMenuItem
End Class
