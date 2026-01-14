<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoNotas
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
        Me.ListViewNotas = New System.Windows.Forms.ListView()
        Me.ColumnHeaderDni = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAsignatura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListViewNotas
        '
        Me.ListViewNotas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderDni, Me.ColumnHeaderAsignatura, Me.ColumnHeaderNota})
        Me.ListViewNotas.FullRowSelect = True
        Me.ListViewNotas.GridLines = True
        Me.ListViewNotas.HideSelection = False
        Me.ListViewNotas.Location = New System.Drawing.Point(12, 12)
        Me.ListViewNotas.Name = "ListViewNotas"
        Me.ListViewNotas.Size = New System.Drawing.Size(776, 426)
        Me.ListViewNotas.TabIndex = 0
        Me.ListViewNotas.UseCompatibleStateImageBehavior = False
        Me.ListViewNotas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderDni
        '
        Me.ColumnHeaderDni.Text = "DNI"
        Me.ColumnHeaderDni.Width = 100
        '
        'ColumnHeaderAsignatura
        '
        Me.ColumnHeaderAsignatura.Text = "Asignatura"
        Me.ColumnHeaderAsignatura.Width = 200
        '
        'ColumnHeaderNota
        '
        Me.ColumnHeaderNota.Text = "Nota"
        Me.ColumnHeaderNota.Width = 100
        '
        'FrmListadoNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListViewNotas)
        Me.Name = "FrmListadoNotas"
        Me.Text = "Listado Notas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewNotas As ListView
    Friend WithEvents ColumnHeaderDni As ColumnHeader
    Friend WithEvents ColumnHeaderAsignatura As ColumnHeader
    Friend WithEvents ColumnHeaderNota As ColumnHeader
End Class
