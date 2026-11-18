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
        Me.BtnCrearBBDD = New System.Windows.Forms.Button()
        Me.BtnCrearTabla = New System.Windows.Forms.Button()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.CmbTablas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnCrearBBDD
        '
        Me.BtnCrearBBDD.Location = New System.Drawing.Point(30, 57)
        Me.BtnCrearBBDD.Name = "BtnCrearBBDD"
        Me.BtnCrearBBDD.Size = New System.Drawing.Size(75, 23)
        Me.BtnCrearBBDD.TabIndex = 0
        Me.BtnCrearBBDD.Text = "Crear BBDD"
        Me.BtnCrearBBDD.UseVisualStyleBackColor = True
        '
        'BtnCrearTabla
        '
        Me.BtnCrearTabla.Location = New System.Drawing.Point(139, 57)
        Me.BtnCrearTabla.Name = "BtnCrearTabla"
        Me.BtnCrearTabla.Size = New System.Drawing.Size(75, 23)
        Me.BtnCrearTabla.TabIndex = 1
        Me.BtnCrearTabla.Text = "Crear Tabla"
        Me.BtnCrearTabla.UseVisualStyleBackColor = True
        '
        'BtnImportar
        '
        Me.BtnImportar.Location = New System.Drawing.Point(30, 131)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(74, 23)
        Me.BtnImportar.TabIndex = 2
        Me.BtnImportar.Text = "Importar desde Fichero"
        Me.BtnImportar.UseVisualStyleBackColor = True
        '
        'CmbTablas
        '
        Me.CmbTablas.FormattingEnabled = True
        Me.CmbTablas.Location = New System.Drawing.Point(126, 131)
        Me.CmbTablas.Name = "CmbTablas"
        Me.CmbTablas.Size = New System.Drawing.Size(121, 21)
        Me.CmbTablas.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.CmbTablas)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.BtnCrearTabla)
        Me.Controls.Add(Me.BtnCrearBBDD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCrearBBDD As System.Windows.Forms.Button
    Friend WithEvents BtnCrearTabla As System.Windows.Forms.Button
    Friend WithEvents BtnImportar As Button
    Friend WithEvents CmbTablas As ComboBox
End Class
