<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoAsignaturas
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
        Me.ListViewAsignaturas = New System.Windows.Forms.ListView()
        Me.ColumnHeaderDni = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAsignaturas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListViewAsignaturas
        '
        Me.ListViewAsignaturas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderDni, Me.ColumnHeaderAsignaturas})
        Me.ListViewAsignaturas.FullRowSelect = True
        Me.ListViewAsignaturas.GridLines = True
        Me.ListViewAsignaturas.HideSelection = False
        Me.ListViewAsignaturas.Location = New System.Drawing.Point(12, 12)
        Me.ListViewAsignaturas.Name = "ListViewAsignaturas"
        Me.ListViewAsignaturas.Size = New System.Drawing.Size(776, 426)
        Me.ListViewAsignaturas.TabIndex = 0
        Me.ListViewAsignaturas.UseCompatibleStateImageBehavior = False
        Me.ListViewAsignaturas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderDni
        '
        Me.ColumnHeaderDni.Text = "DNI"
        Me.ColumnHeaderDni.Width = 100
        '
        'ColumnHeaderAsignaturas
        '
        Me.ColumnHeaderAsignaturas.Text = "Asignaturas"
        Me.ColumnHeaderAsignaturas.Width = 400
        '
        'FrmListadoAsignaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListViewAsignaturas)
        Me.Name = "FrmListadoAsignaturas"
        Me.Text = "Listado Asignaturas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewAsignaturas As ListView
    Friend WithEvents ColumnHeaderDni As ColumnHeader
    Friend WithEvents ColumnHeaderAsignaturas As ColumnHeader
End Class
