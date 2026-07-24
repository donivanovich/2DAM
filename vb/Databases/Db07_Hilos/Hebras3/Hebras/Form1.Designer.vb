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
        Me.Lstproceso = New System.Windows.Forms.ListBox()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lstproceso
        '
        Me.Lstproceso.FormattingEnabled = True
        Me.Lstproceso.Location = New System.Drawing.Point(12, 21)
        Me.Lstproceso.Name = "Lstproceso"
        Me.Lstproceso.Size = New System.Drawing.Size(355, 199)
        Me.Lstproceso.TabIndex = 0
        '
        'BtnIniciar
        '
        Me.BtnIniciar.Location = New System.Drawing.Point(100, 247)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIniciar.TabIndex = 1
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(52, 275)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(47, 13)
        Me.LblMensaje.TabIndex = 2
        Me.LblMensaje.Text = "Mensaje"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 306)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.Lstproceso)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lstproceso As System.Windows.Forms.ListBox
    Friend WithEvents BtnIniciar As System.Windows.Forms.Button
    Friend WithEvents LblMensaje As System.Windows.Forms.Label

End Class
