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
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.LbPass = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnLeer = New System.Windows.Forms.Button()
        Me.ChkAdmin = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Location = New System.Drawing.Point(13, 38)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LbUsuario.TabIndex = 0
        Me.LbUsuario.Text = "Usuario"
        '
        'LbPass
        '
        Me.LbPass.AutoSize = True
        Me.LbPass.Location = New System.Drawing.Point(13, 78)
        Me.LbPass.Name = "LbPass"
        Me.LbPass.Size = New System.Drawing.Size(61, 13)
        Me.LbPass.TabIndex = 1
        Me.LbPass.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(94, 38)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(152, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(94, 78)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(152, 20)
        Me.TxtPass.TabIndex = 3
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(16, 149)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 4
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnLeer
        '
        Me.BtnLeer.Location = New System.Drawing.Point(171, 149)
        Me.BtnLeer.Name = "BtnLeer"
        Me.BtnLeer.Size = New System.Drawing.Size(75, 23)
        Me.BtnLeer.TabIndex = 5
        Me.BtnLeer.Text = "Leer"
        Me.BtnLeer.UseVisualStyleBackColor = True
        '
        'ChkAdmin
        '
        Me.ChkAdmin.AutoSize = True
        Me.ChkAdmin.Location = New System.Drawing.Point(95, 120)
        Me.ChkAdmin.Name = "ChkAdmin"
        Me.ChkAdmin.Size = New System.Drawing.Size(89, 17)
        Me.ChkAdmin.TabIndex = 6
        Me.ChkAdmin.Text = "Administrador"
        Me.ChkAdmin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 213)
        Me.Controls.Add(Me.ChkAdmin)
        Me.Controls.Add(Me.BtnLeer)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LbPass)
        Me.Controls.Add(Me.LbUsuario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbUsuario As Label
    Friend WithEvents LbPass As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnLeer As Button
    Friend WithEvents ChkAdmin As CheckBox
End Class
