<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntroducirNotas
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
        Me.TextBoxNota = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxAlumnos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxAsignatura = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBoxNota
        '
        Me.TextBoxNota.Location = New System.Drawing.Point(319, 81)
        Me.TextBoxNota.Name = "TextBoxNota"
        Me.TextBoxNota.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxNota.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Notas:"
        '
        'ComboBoxAlumnos
        '
        Me.ComboBoxAlumnos.FormattingEnabled = True
        Me.ComboBoxAlumnos.Location = New System.Drawing.Point(109, 80)
        Me.ComboBoxAlumnos.Name = "ComboBoxAlumnos"
        Me.ComboBoxAlumnos.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxAlumnos.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Asignatura:"
        '
        'ComboBoxAsignatura
        '
        Me.ComboBoxAsignatura.FormattingEnabled = True
        Me.ComboBoxAsignatura.Location = New System.Drawing.Point(109, 127)
        Me.ComboBoxAsignatura.Name = "ComboBoxAsignatura"
        Me.ComboBoxAsignatura.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxAsignatura.TabIndex = 5
        '
        'FrmIntroducirNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 241)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxAsignatura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxAlumnos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxNota)
        Me.Name = "FrmIntroducirNotas"
        Me.Text = "Introducir Notas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNota As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxAlumnos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxAsignatura As ComboBox
End Class
