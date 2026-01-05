<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoDatosBancarios
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
        Me.ListViewDatosBancarios = New System.Windows.Forms.ListView()
        Me.ColumnHeaderDni = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderIban = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListViewDatosBancarios
        '
        Me.ListViewDatosBancarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderDni, Me.ColumnHeaderIban})
        Me.ListViewDatosBancarios.FullRowSelect = True
        Me.ListViewDatosBancarios.GridLines = True
        Me.ListViewDatosBancarios.HideSelection = False
        Me.ListViewDatosBancarios.Location = New System.Drawing.Point(12, 12)
        Me.ListViewDatosBancarios.Name = "ListViewDatosBancarios"
        Me.ListViewDatosBancarios.Size = New System.Drawing.Size(776, 426)
        Me.ListViewDatosBancarios.TabIndex = 0
        Me.ListViewDatosBancarios.UseCompatibleStateImageBehavior = False
        Me.ListViewDatosBancarios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderDni
        '
        Me.ColumnHeaderDni.Text = "DNI"
        Me.ColumnHeaderDni.Width = 100
        '
        'ColumnHeaderIban
        '
        Me.ColumnHeaderIban.Text = "IBAN"
        Me.ColumnHeaderIban.Width = 200
        '
        'FrmListadoDatosBancarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListViewDatosBancarios)
        Me.Name = "FrmListadoDatosBancarios"
        Me.Text = "Listado Datos Bancarios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewDatosBancarios As ListView
    Friend WithEvents ColumnHeaderDni As ColumnHeader
    Friend WithEvents ColumnHeaderIban As ColumnHeader
End Class
