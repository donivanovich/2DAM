<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MnuMenu = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        MnuAbrir = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        GuardaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ConfiguraciónDeCuentaToolStripMenuItem = New ToolStripMenuItem()
        MnuEditar = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        MnuActivae = New ToolStripMenuItem()
        MnuSalir = New ToolStripMenuItem()
        OtraToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        MnuMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' MnuMenu
        ' 
        MnuMenu.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, MnuEditar, VerToolStripMenuItem, MnuSalir})
        MnuMenu.Location = New Point(0, 0)
        MnuMenu.Name = "MnuMenu"
        MnuMenu.Size = New Size(800, 24)
        MnuMenu.TabIndex = 0
        MnuMenu.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MnuAbrir, GuardarToolStripMenuItem, GuardaToolStripMenuItem, ToolStripMenuItem1, ConfiguraciónDeCuentaToolStripMenuItem, OtraToolStripMenuItem, ToolStripMenuItem2})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' MnuAbrir
        ' 
        MnuAbrir.Name = "MnuAbrir"
        MnuAbrir.Size = New Size(205, 22)
        MnuAbrir.Text = "Abrir"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(205, 22)
        GuardarToolStripMenuItem.Text = "Guardar"
        ' 
        ' GuardaToolStripMenuItem
        ' 
        GuardaToolStripMenuItem.Name = "GuardaToolStripMenuItem"
        GuardaToolStripMenuItem.Size = New Size(205, 22)
        GuardaToolStripMenuItem.Text = "Guardar Como"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(202, 6)
        ' 
        ' ConfiguraciónDeCuentaToolStripMenuItem
        ' 
        ConfiguraciónDeCuentaToolStripMenuItem.Name = "ConfiguraciónDeCuentaToolStripMenuItem"
        ConfiguraciónDeCuentaToolStripMenuItem.Size = New Size(205, 22)
        ConfiguraciónDeCuentaToolStripMenuItem.Text = "Configuración de cuenta"
        ' 
        ' MnuEditar
        ' 
        MnuEditar.Name = "MnuEditar"
        MnuEditar.Size = New Size(49, 20)
        MnuEditar.Text = "Editar"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MnuActivae})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(35, 20)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' MnuActivae
        ' 
        MnuActivae.Name = "MnuActivae"
        MnuActivae.Size = New Size(144, 22)
        MnuActivae.Text = "Activar Editar"
        ' 
        ' MnuSalir
        ' 
        MnuSalir.Name = "MnuSalir"
        MnuSalir.Size = New Size(41, 20)
        MnuSalir.Text = "Salir"
        ' 
        ' OtraToolStripMenuItem
        ' 
        OtraToolStripMenuItem.Name = "OtraToolStripMenuItem"
        OtraToolStripMenuItem.Size = New Size(205, 22)
        OtraToolStripMenuItem.Text = "Otra"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(202, 6)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MnuMenu)
        MainMenuStrip = MnuMenu
        Name = "Form1"
        Text = "Form1"
        MnuMenu.ResumeLayout(False)
        MnuMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MnuMenu As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuAbrir As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuEditar As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuSalir As ToolStripMenuItem
    Friend WithEvents GuardaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ConfiguraciónDeCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuActivae As ToolStripMenuItem
    Friend WithEvents OtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
End Class
