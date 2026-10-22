<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoAlumnos
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
        Me.ListViewAlumnos = New System.Windows.Forms.ListView()
        Me.ColumnHeaderDni = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderApellido1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderApellido2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDomicilio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListViewAlumnos
        '
        Me.ListViewAlumnos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderDni, Me.ColumnHeaderNombre, Me.ColumnHeaderApellido1, Me.ColumnHeaderApellido2, Me.ColumnHeaderNacimiento, Me.ColumnHeaderDomicilio, Me.ColumnHeaderTelefono})
        Me.ListViewAlumnos.FullRowSelect = True
        Me.ListViewAlumnos.GridLines = True
        Me.ListViewAlumnos.HideSelection = False
        Me.ListViewAlumnos.Location = New System.Drawing.Point(12, 12)
        Me.ListViewAlumnos.Name = "ListViewAlumnos"
        Me.ListViewAlumnos.Size = New System.Drawing.Size(776, 426)
        Me.ListViewAlumnos.TabIndex = 0
        Me.ListViewAlumnos.UseCompatibleStateImageBehavior = False
        Me.ListViewAlumnos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderDni
        '
        Me.ColumnHeaderDni.Text = "DNI"
        Me.ColumnHeaderDni.Width = 100
        '
        'ColumnHeaderNombre
        '
        Me.ColumnHeaderNombre.Text = "Nombre"
        Me.ColumnHeaderNombre.Width = 100
        '
        'ColumnHeaderApellido1
        '
        Me.ColumnHeaderApellido1.Text = "Apellido1"
        Me.ColumnHeaderApellido1.Width = 100
        '
        'ColumnHeaderApellido2
        '
        Me.ColumnHeaderApellido2.Text = "Apellido2"
        Me.ColumnHeaderApellido2.Width = 100
        '
        'ColumnHeaderNacimiento
        '
        Me.ColumnHeaderNacimiento.Text = "Nacimiento"
        Me.ColumnHeaderNacimiento.Width = 100
        '
        'ColumnHeaderDomicilio
        '
        Me.ColumnHeaderDomicilio.Text = "Domicilio"
        Me.ColumnHeaderDomicilio.Width = 100
        '
        'ColumnHeaderTelefono
        '
        Me.ColumnHeaderTelefono.Text = "Telefono"
        Me.ColumnHeaderTelefono.Width = 100
        '
        'FrmListadoAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListViewAlumnos)
        Me.Name = "FrmListadoAlumnos"
        Me.Text = "Listado Alumnos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewAlumnos As ListView
    Friend WithEvents ColumnHeaderDni As ColumnHeader
    Friend WithEvents ColumnHeaderNombre As ColumnHeader
    Friend WithEvents ColumnHeaderApellido1 As ColumnHeader
    Friend WithEvents ColumnHeaderApellido2 As ColumnHeader
    Friend WithEvents ColumnHeaderNacimiento As ColumnHeader
    Friend WithEvents ColumnHeaderDomicilio As ColumnHeader
    Friend WithEvents ColumnHeaderTelefono As ColumnHeader
End Class
