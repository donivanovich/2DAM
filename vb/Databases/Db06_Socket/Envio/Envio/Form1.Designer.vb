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
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.BtnEnviarMensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Location = New System.Drawing.Point(12, 25)
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(268, 20)
        Me.TxtMensaje.TabIndex = 0
        '
        'BtnEnviarMensaje
        '
        Me.BtnEnviarMensaje.Location = New System.Drawing.Point(12, 69)
        Me.BtnEnviarMensaje.Name = "BtnEnviarMensaje"
        Me.BtnEnviarMensaje.Size = New System.Drawing.Size(268, 23)
        Me.BtnEnviarMensaje.TabIndex = 1
        Me.BtnEnviarMensaje.Text = "Enviar"
        Me.BtnEnviarMensaje.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.BtnEnviarMensaje)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents BtnEnviarMensaje As System.Windows.Forms.Button

End Class
