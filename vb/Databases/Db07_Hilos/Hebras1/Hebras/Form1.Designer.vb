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
        Me.TxtPrueba = New System.Windows.Forms.TextBox()
        Me.BtnDetener = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lstproceso
        '
        Me.Lstproceso.FormattingEnabled = True
        Me.Lstproceso.Location = New System.Drawing.Point(55, 12)
        Me.Lstproceso.Name = "Lstproceso"
        Me.Lstproceso.Size = New System.Drawing.Size(169, 160)
        Me.Lstproceso.TabIndex = 0
        '
        'BtnIniciar
        '
        Me.BtnIniciar.Location = New System.Drawing.Point(55, 196)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIniciar.TabIndex = 1
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'TxtPrueba
        '
        Me.TxtPrueba.Location = New System.Drawing.Point(12, 234)
        Me.TxtPrueba.Name = "TxtPrueba"
        Me.TxtPrueba.Size = New System.Drawing.Size(268, 20)
        Me.TxtPrueba.TabIndex = 2
        '
        'BtnDetener
        '
        Me.BtnDetener.Location = New System.Drawing.Point(149, 196)
        Me.BtnDetener.Name = "BtnDetener"
        Me.BtnDetener.Size = New System.Drawing.Size(75, 23)
        Me.BtnDetener.TabIndex = 3
        Me.BtnDetener.Text = "Detener"
        Me.BtnDetener.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.BtnDetener)
        Me.Controls.Add(Me.TxtPrueba)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.Lstproceso)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lstproceso As System.Windows.Forms.ListBox
    Friend WithEvents BtnIniciar As System.Windows.Forms.Button
    Friend WithEvents TxtPrueba As System.Windows.Forms.TextBox
    Friend WithEvents BtnDetener As System.Windows.Forms.Button

End Class
