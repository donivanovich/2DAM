<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextboxNumerico
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(0, 0)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(110, 20)
        Me.TxtDato.TabIndex = 0
        '
        'TextboxNumerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtDato)
        Me.Name = "TextboxNumerico"
        Me.Size = New System.Drawing.Size(266, 65)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox

End Class
