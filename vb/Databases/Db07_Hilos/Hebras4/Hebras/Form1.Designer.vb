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
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.BtnParar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblContador = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Lblestado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnIniciar
        '
        Me.BtnIniciar.Location = New System.Drawing.Point(21, 92)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIniciar.TabIndex = 1
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(105, 38)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(93, 20)
        Me.TxtClave.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Introducir Clave:"
        '
        'BtnParar
        '
        Me.BtnParar.Location = New System.Drawing.Point(183, 92)
        Me.BtnParar.Name = "BtnParar"
        Me.BtnParar.Size = New System.Drawing.Size(75, 23)
        Me.BtnParar.TabIndex = 4
        Me.BtnParar.Text = "Parar"
        Me.BtnParar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contador de Pasos: "
        '
        'LblContador
        '
        Me.LblContador.AutoSize = True
        Me.LblContador.Location = New System.Drawing.Point(127, 151)
        Me.LblContador.Name = "LblContador"
        Me.LblContador.Size = New System.Drawing.Size(10, 13)
        Me.LblContador.TabIndex = 6
        Me.LblContador.Text = " "
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(18, 185)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(102, 13)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Estado de la Clave: "
        '
        'Lblestado
        '
        Me.Lblestado.AutoSize = True
        Me.Lblestado.Location = New System.Drawing.Point(127, 185)
        Me.Lblestado.Name = "Lblestado"
        Me.Lblestado.Size = New System.Drawing.Size(10, 13)
        Me.Lblestado.TabIndex = 8
        Me.Lblestado.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Lblestado)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.LblContador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnParar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnIniciar As System.Windows.Forms.Button
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents BtnParar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblContador As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents Lblestado As System.Windows.Forms.Label

End Class
