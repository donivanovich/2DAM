Module Module1
    Public FrmForm1 As Form1
    Public Frmform2 As Form2
    Sub Main()
        ' Configurar las propiedades visuales
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Frmform2 = New Form2
        FrmForm1 = New Form1
        ' Ejecutar el formulario principal
        Application.Run(FrmForm1)
    End Sub
End Module