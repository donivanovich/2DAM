<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntroducirDatosPersonales
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxDni = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextApellido1 = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido2 = New System.Windows.Forms.TextBox()
        Me.TextBoxDomicilio = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxAlumnos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxDni
        '
        Me.TextBoxDni.Location = New System.Drawing.Point(92, 74)
        Me.TextBoxDni.Name = "TextBoxDni"
        Me.TextBoxDni.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxDni.TabIndex = 1
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(410, 27)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(200, 20)
        Me.TextNombre.TabIndex = 2
        '
        'TextApellido1
        '
        Me.TextApellido1.Location = New System.Drawing.Point(410, 78)
        Me.TextApellido1.Name = "TextApellido1"
        Me.TextApellido1.Size = New System.Drawing.Size(200, 20)
        Me.TextApellido1.TabIndex = 3
        '
        'TextBoxApellido2
        '
        Me.TextBoxApellido2.Location = New System.Drawing.Point(410, 127)
        Me.TextBoxApellido2.Name = "TextBoxApellido2"
        Me.TextBoxApellido2.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxApellido2.TabIndex = 4
        '
        'TextBoxDomicilio
        '
        Me.TextBoxDomicilio.Location = New System.Drawing.Point(92, 127)
        Me.TextBoxDomicilio.Name = "TextBoxDomicilio"
        Me.TextBoxDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxDomicilio.TabIndex = 5
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(92, 174)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxTelefono.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(410, 168)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DNI: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido 1: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nacimiento: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Apellido 2: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telefono: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Domicilio: "
        '
        'ComboBoxAlumnos
        '
        Me.ComboBoxAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAlumnos.FormattingEnabled = True
        Me.ComboBoxAlumnos.Location = New System.Drawing.Point(92, 27)
        Me.ComboBoxAlumnos.Name = "ComboBoxAlumnos"
        Me.ComboBoxAlumnos.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxAlumnos.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ID: "
        '
        'FrmCrearAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 258)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxAlumnos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.TextBoxDomicilio)
        Me.Controls.Add(Me.TextBoxApellido2)
        Me.Controls.Add(Me.TextApellido1)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.TextBoxDni)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmCrearAlumno"
        Me.Text = "Introducir Datos Personales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxDni As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextApellido1 As TextBox
    Friend WithEvents TextBoxApellido2 As TextBox
    Friend WithEvents TextBoxDomicilio As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxAlumnos As ComboBox
    Friend WithEvents Label8 As Label
End Class
