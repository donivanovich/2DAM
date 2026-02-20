<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.BtnCrearBBDD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCrearBBDD
        '
        Me.BtnCrearBBDD.Location = New System.Drawing.Point(284, 185)
        Me.BtnCrearBBDD.Name = "BtnCrearBBDD"
        Me.BtnCrearBBDD.Size = New System.Drawing.Size(75, 23)
        Me.BtnCrearBBDD.TabIndex = 0
        Me.BtnCrearBBDD.Text = "Comenzar"
        Me.BtnCrearBBDD.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(576, 391)
        Me.Controls.Add(Me.BtnCrearBBDD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCrearBBDD As System.Windows.Forms.Button
End Class
