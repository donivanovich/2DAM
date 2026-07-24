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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnConectar = New System.Windows.Forms.Button()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.TxtPuerto = New System.Windows.Forms.TextBox()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.BtnEnviarMensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Puerto:"
        '
        'BtnConectar
        '
        Me.BtnConectar.Location = New System.Drawing.Point(12, 94)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConectar.TabIndex = 2
        Me.BtnConectar.Text = "Conectar"
        Me.BtnConectar.UseVisualStyleBackColor = True
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(51, 25)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(64, 20)
        Me.TxtIP.TabIndex = 3
        '
        'TxtPuerto
        '
        Me.TxtPuerto.Location = New System.Drawing.Point(59, 61)
        Me.TxtPuerto.Name = "TxtPuerto"
        Me.TxtPuerto.Size = New System.Drawing.Size(56, 20)
        Me.TxtPuerto.TabIndex = 4
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Location = New System.Drawing.Point(183, 25)
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(191, 20)
        Me.TxtMensaje.TabIndex = 5
        '
        'BtnEnviarMensaje
        '
        Me.BtnEnviarMensaje.Location = New System.Drawing.Point(183, 61)
        Me.BtnEnviarMensaje.Name = "BtnEnviarMensaje"
        Me.BtnEnviarMensaje.Size = New System.Drawing.Size(191, 23)
        Me.BtnEnviarMensaje.TabIndex = 6
        Me.BtnEnviarMensaje.Text = "Enviar"
        Me.BtnEnviarMensaje.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 132)
        Me.Controls.Add(Me.BtnEnviarMensaje)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Controls.Add(Me.TxtPuerto)
        Me.Controls.Add(Me.TxtIP)
        Me.Controls.Add(Me.BtnConectar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnConectar As System.Windows.Forms.Button
    Friend WithEvents TxtIP As System.Windows.Forms.TextBox
    Friend WithEvents TxtPuerto As System.Windows.Forms.TextBox
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents BtnEnviarMensaje As System.Windows.Forms.Button

End Class
