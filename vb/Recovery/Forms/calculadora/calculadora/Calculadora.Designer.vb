<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalculadora))
        Me.TxtNumeros = New System.Windows.Forms.TextBox
        Me.Btt1 = New System.Windows.Forms.Button
        Me.Btt2 = New System.Windows.Forms.Button
        Me.Btt3 = New System.Windows.Forms.Button
        Me.Btt4 = New System.Windows.Forms.Button
        Me.Btt5 = New System.Windows.Forms.Button
        Me.Btt6 = New System.Windows.Forms.Button
        Me.Btt7 = New System.Windows.Forms.Button
        Me.Btt8 = New System.Windows.Forms.Button
        Me.Btt9 = New System.Windows.Forms.Button
        Me.Btt0 = New System.Windows.Forms.Button
        Me.BttSuma = New System.Windows.Forms.Button
        Me.BttResta = New System.Windows.Forms.Button
        Me.BttPor = New System.Windows.Forms.Button
        Me.BttDiv = New System.Windows.Forms.Button
        Me.BttIgual = New System.Windows.Forms.Button
        Me.BttC = New System.Windows.Forms.Button
        Me.BttResto = New System.Windows.Forms.Button
        Me.BttCientifica = New System.Windows.Forms.Button
        Me.BttEstandar = New System.Windows.Forms.Button
        Me.BttPotencia = New System.Windows.Forms.Button
        Me.BttRaiz = New System.Windows.Forms.Button
        Me.MnuMenu = New System.Windows.Forms.MenuStrip
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuEstandar = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuCientifica = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuSalir = New System.Windows.Forms.ToolStripMenuItem
        Me.TxtUno = New System.Windows.Forms.TextBox
        Me.TxtDos = New System.Windows.Forms.TextBox
        Me.Txtresul = New System.Windows.Forms.TextBox
        Me.BttOperacion = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNumeros
        '
        Me.TxtNumeros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNumeros.Location = New System.Drawing.Point(7, 45)
        Me.TxtNumeros.MaxLength = 10
        Me.TxtNumeros.Name = "TxtNumeros"
        Me.TxtNumeros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNumeros.Size = New System.Drawing.Size(267, 20)
        Me.TxtNumeros.TabIndex = 0
        Me.TxtNumeros.Text = "0"
        '
        'Btt1
        '
        Me.Btt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt1.Location = New System.Drawing.Point(7, 71)
        Me.Btt1.Name = "Btt1"
        Me.Btt1.Size = New System.Drawing.Size(47, 45)
        Me.Btt1.TabIndex = 1
        Me.Btt1.Text = "1"
        Me.Btt1.UseVisualStyleBackColor = False
        '
        'Btt2
        '
        Me.Btt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt2.Location = New System.Drawing.Point(60, 71)
        Me.Btt2.Name = "Btt2"
        Me.Btt2.Size = New System.Drawing.Size(47, 45)
        Me.Btt2.TabIndex = 2
        Me.Btt2.Text = "2"
        Me.Btt2.UseVisualStyleBackColor = False
        '
        'Btt3
        '
        Me.Btt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt3.Location = New System.Drawing.Point(113, 71)
        Me.Btt3.Name = "Btt3"
        Me.Btt3.Size = New System.Drawing.Size(47, 45)
        Me.Btt3.TabIndex = 3
        Me.Btt3.Text = "3"
        Me.Btt3.UseVisualStyleBackColor = False
        '
        'Btt4
        '
        Me.Btt4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt4.Location = New System.Drawing.Point(7, 135)
        Me.Btt4.Name = "Btt4"
        Me.Btt4.Size = New System.Drawing.Size(47, 45)
        Me.Btt4.TabIndex = 4
        Me.Btt4.Text = "4"
        Me.Btt4.UseVisualStyleBackColor = False
        '
        'Btt5
        '
        Me.Btt5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt5.Location = New System.Drawing.Point(60, 135)
        Me.Btt5.Name = "Btt5"
        Me.Btt5.Size = New System.Drawing.Size(47, 45)
        Me.Btt5.TabIndex = 5
        Me.Btt5.Text = "5"
        Me.Btt5.UseVisualStyleBackColor = False
        '
        'Btt6
        '
        Me.Btt6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt6.Location = New System.Drawing.Point(113, 135)
        Me.Btt6.Name = "Btt6"
        Me.Btt6.Size = New System.Drawing.Size(47, 45)
        Me.Btt6.TabIndex = 6
        Me.Btt6.Text = "6"
        Me.Btt6.UseVisualStyleBackColor = False
        '
        'Btt7
        '
        Me.Btt7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt7.Location = New System.Drawing.Point(7, 198)
        Me.Btt7.Name = "Btt7"
        Me.Btt7.Size = New System.Drawing.Size(47, 45)
        Me.Btt7.TabIndex = 7
        Me.Btt7.Text = "7"
        Me.Btt7.UseVisualStyleBackColor = False
        '
        'Btt8
        '
        Me.Btt8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt8.Location = New System.Drawing.Point(60, 198)
        Me.Btt8.Name = "Btt8"
        Me.Btt8.Size = New System.Drawing.Size(47, 45)
        Me.Btt8.TabIndex = 8
        Me.Btt8.Text = "8"
        Me.Btt8.UseVisualStyleBackColor = False
        '
        'Btt9
        '
        Me.Btt9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt9.Location = New System.Drawing.Point(113, 198)
        Me.Btt9.Name = "Btt9"
        Me.Btt9.Size = New System.Drawing.Size(47, 45)
        Me.Btt9.TabIndex = 9
        Me.Btt9.Text = "9"
        Me.Btt9.UseVisualStyleBackColor = False
        '
        'Btt0
        '
        Me.Btt0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btt0.Location = New System.Drawing.Point(21, 259)
        Me.Btt0.Name = "Btt0"
        Me.Btt0.Size = New System.Drawing.Size(129, 45)
        Me.Btt0.TabIndex = 10
        Me.Btt0.Text = "0"
        Me.Btt0.UseVisualStyleBackColor = False
        '
        'BttSuma
        '
        Me.BttSuma.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSuma.Location = New System.Drawing.Point(174, 135)
        Me.BttSuma.Name = "BttSuma"
        Me.BttSuma.Size = New System.Drawing.Size(47, 45)
        Me.BttSuma.TabIndex = 11
        Me.BttSuma.Text = "+"
        Me.BttSuma.UseVisualStyleBackColor = False
        '
        'BttResta
        '
        Me.BttResta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttResta.Location = New System.Drawing.Point(227, 135)
        Me.BttResta.Name = "BttResta"
        Me.BttResta.Size = New System.Drawing.Size(47, 45)
        Me.BttResta.TabIndex = 12
        Me.BttResta.Text = "-"
        Me.BttResta.UseVisualStyleBackColor = False
        '
        'BttPor
        '
        Me.BttPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttPor.Location = New System.Drawing.Point(174, 198)
        Me.BttPor.Name = "BttPor"
        Me.BttPor.Size = New System.Drawing.Size(47, 45)
        Me.BttPor.TabIndex = 13
        Me.BttPor.Text = "*"
        Me.BttPor.UseVisualStyleBackColor = False
        '
        'BttDiv
        '
        Me.BttDiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttDiv.Location = New System.Drawing.Point(227, 198)
        Me.BttDiv.Name = "BttDiv"
        Me.BttDiv.Size = New System.Drawing.Size(47, 45)
        Me.BttDiv.TabIndex = 14
        Me.BttDiv.Text = "/"
        Me.BttDiv.UseVisualStyleBackColor = False
        '
        'BttIgual
        '
        Me.BttIgual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttIgual.Location = New System.Drawing.Point(174, 259)
        Me.BttIgual.Name = "BttIgual"
        Me.BttIgual.Size = New System.Drawing.Size(47, 45)
        Me.BttIgual.TabIndex = 15
        Me.BttIgual.Text = "="
        Me.BttIgual.UseVisualStyleBackColor = False
        '
        'BttC
        '
        Me.BttC.BackColor = System.Drawing.Color.Cyan
        Me.BttC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BttC.Location = New System.Drawing.Point(174, 71)
        Me.BttC.Name = "BttC"
        Me.BttC.Size = New System.Drawing.Size(100, 45)
        Me.BttC.TabIndex = 16
        Me.BttC.Text = "C"
        Me.BttC.UseVisualStyleBackColor = False
        '
        'BttResto
        '
        Me.BttResto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttResto.Location = New System.Drawing.Point(227, 259)
        Me.BttResto.Name = "BttResto"
        Me.BttResto.Size = New System.Drawing.Size(47, 45)
        Me.BttResto.TabIndex = 17
        Me.BttResto.Text = "Mod"
        Me.BttResto.UseVisualStyleBackColor = False
        '
        'BttCientifica
        '
        Me.BttCientifica.Location = New System.Drawing.Point(32, 328)
        Me.BttCientifica.Name = "BttCientifica"
        Me.BttCientifica.Size = New System.Drawing.Size(75, 23)
        Me.BttCientifica.TabIndex = 18
        Me.BttCientifica.Text = "Cientifica"
        Me.BttCientifica.UseVisualStyleBackColor = True
        '
        'BttEstandar
        '
        Me.BttEstandar.Enabled = False
        Me.BttEstandar.Location = New System.Drawing.Point(184, 328)
        Me.BttEstandar.Name = "BttEstandar"
        Me.BttEstandar.Size = New System.Drawing.Size(75, 23)
        Me.BttEstandar.TabIndex = 19
        Me.BttEstandar.Text = "Estandar"
        Me.BttEstandar.UseVisualStyleBackColor = True
        '
        'BttPotencia
        '
        Me.BttPotencia.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.BttPotencia.BackColor = System.Drawing.Color.DodgerBlue
        Me.BttPotencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttPotencia.Location = New System.Drawing.Point(285, 198)
        Me.BttPotencia.Name = "BttPotencia"
        Me.BttPotencia.Size = New System.Drawing.Size(75, 23)
        Me.BttPotencia.TabIndex = 21
        Me.BttPotencia.Text = "Potencia"
        Me.BttPotencia.UseVisualStyleBackColor = False
        '
        'BttRaiz
        '
        Me.BttRaiz.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.BttRaiz.BackColor = System.Drawing.Color.DodgerBlue
        Me.BttRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttRaiz.Location = New System.Drawing.Point(285, 135)
        Me.BttRaiz.Name = "BttRaiz"
        Me.BttRaiz.Size = New System.Drawing.Size(75, 23)
        Me.BttRaiz.TabIndex = 22
        Me.BttRaiz.Text = "Raiz"
        Me.BttRaiz.UseVisualStyleBackColor = False
        '
        'MnuMenu
        '
        Me.MnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.MnuSalir})
        Me.MnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.MnuMenu.Name = "MnuMenu"
        Me.MnuMenu.Size = New System.Drawing.Size(275, 24)
        Me.MnuMenu.TabIndex = 23
        Me.MnuMenu.Text = "MenuStrip1"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuEstandar, Me.MnuCientifica})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'MnuEstandar
        '
        Me.MnuEstandar.Enabled = False
        Me.MnuEstandar.Name = "MnuEstandar"
        Me.MnuEstandar.Size = New System.Drawing.Size(129, 22)
        Me.MnuEstandar.Text = "Estandar"
        '
        'MnuCientifica
        '
        Me.MnuCientifica.Name = "MnuCientifica"
        Me.MnuCientifica.Size = New System.Drawing.Size(129, 22)
        Me.MnuCientifica.Text = "Cientifica"
        '
        'MnuSalir
        '
        Me.MnuSalir.Name = "MnuSalir"
        Me.MnuSalir.Size = New System.Drawing.Size(39, 20)
        Me.MnuSalir.Text = "Salir"
        '
        'TxtUno
        '
        Me.TxtUno.Location = New System.Drawing.Point(129, 381)
        Me.TxtUno.Name = "TxtUno"
        Me.TxtUno.Size = New System.Drawing.Size(145, 20)
        Me.TxtUno.TabIndex = 24
        '
        'TxtDos
        '
        Me.TxtDos.Location = New System.Drawing.Point(129, 421)
        Me.TxtDos.Name = "TxtDos"
        Me.TxtDos.Size = New System.Drawing.Size(145, 20)
        Me.TxtDos.TabIndex = 25
        '
        'Txtresul
        '
        Me.Txtresul.Location = New System.Drawing.Point(130, 460)
        Me.Txtresul.Name = "Txtresul"
        Me.Txtresul.Size = New System.Drawing.Size(145, 20)
        Me.Txtresul.TabIndex = 26
        '
        'BttOperacion
        '
        Me.BttOperacion.BackColor = System.Drawing.Color.Silver
        Me.BttOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttOperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BttOperacion.Location = New System.Drawing.Point(130, 486)
        Me.BttOperacion.Name = "BttOperacion"
        Me.BttOperacion.Size = New System.Drawing.Size(145, 45)
        Me.BttOperacion.TabIndex = 27
        Me.BttOperacion.Text = "Operacion"
        Me.BttOperacion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Texto1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Texto2"
        '
        'FrmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BttOperacion)
        Me.Controls.Add(Me.Txtresul)
        Me.Controls.Add(Me.TxtDos)
        Me.Controls.Add(Me.TxtUno)
        Me.Controls.Add(Me.BttRaiz)
        Me.Controls.Add(Me.BttPotencia)
        Me.Controls.Add(Me.BttEstandar)
        Me.Controls.Add(Me.BttCientifica)
        Me.Controls.Add(Me.BttResto)
        Me.Controls.Add(Me.BttC)
        Me.Controls.Add(Me.BttIgual)
        Me.Controls.Add(Me.BttDiv)
        Me.Controls.Add(Me.BttPor)
        Me.Controls.Add(Me.BttResta)
        Me.Controls.Add(Me.BttSuma)
        Me.Controls.Add(Me.Btt0)
        Me.Controls.Add(Me.Btt9)
        Me.Controls.Add(Me.Btt8)
        Me.Controls.Add(Me.Btt7)
        Me.Controls.Add(Me.Btt6)
        Me.Controls.Add(Me.Btt5)
        Me.Controls.Add(Me.Btt4)
        Me.Controls.Add(Me.Btt3)
        Me.Controls.Add(Me.Btt2)
        Me.Controls.Add(Me.Btt1)
        Me.Controls.Add(Me.TxtNumeros)
        Me.Controls.Add(Me.MnuMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MnuMenu
        Me.Name = "FrmCalculadora"
        Me.Text = "Calculadora"
        Me.MnuMenu.ResumeLayout(False)
        Me.MnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeros As System.Windows.Forms.TextBox
    Friend WithEvents Btt1 As System.Windows.Forms.Button
    Friend WithEvents Btt2 As System.Windows.Forms.Button
    Friend WithEvents Btt3 As System.Windows.Forms.Button
    Friend WithEvents Btt4 As System.Windows.Forms.Button
    Friend WithEvents Btt5 As System.Windows.Forms.Button
    Friend WithEvents Btt6 As System.Windows.Forms.Button
    Friend WithEvents Btt7 As System.Windows.Forms.Button
    Friend WithEvents Btt8 As System.Windows.Forms.Button
    Friend WithEvents Btt9 As System.Windows.Forms.Button
    Friend WithEvents Btt0 As System.Windows.Forms.Button
    Friend WithEvents BttSuma As System.Windows.Forms.Button
    Friend WithEvents BttResta As System.Windows.Forms.Button
    Friend WithEvents BttPor As System.Windows.Forms.Button
    Friend WithEvents BttDiv As System.Windows.Forms.Button
    Friend WithEvents BttIgual As System.Windows.Forms.Button
    Friend WithEvents BttC As System.Windows.Forms.Button
    Friend WithEvents BttResto As System.Windows.Forms.Button
    Friend WithEvents BttCientifica As System.Windows.Forms.Button
    Friend WithEvents BttEstandar As System.Windows.Forms.Button
    Friend WithEvents BttPotencia As System.Windows.Forms.Button
    Friend WithEvents BttRaiz As System.Windows.Forms.Button
    Friend WithEvents MnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuEstandar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCientifica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtUno As System.Windows.Forms.TextBox
    Friend WithEvents TxtDos As System.Windows.Forms.TextBox
    Friend WithEvents Txtresul As System.Windows.Forms.TextBox
    Friend WithEvents BttOperacion As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
