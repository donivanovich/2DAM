Imports System.Threading
Module Module1
    Public Sub main()
        Dim ohebraUno As New Thread(AddressOf LanzarPrimero)
        Dim ohebraDos As New Thread(AddressOf LanzarSegundo)
        ohebraUno.Start()
        ohebraDos.Start()

    End Sub
    Public Sub Lanzarprimero()
        Application.Run(New Form1)

    End Sub
    Public Sub Lanzarsegundo()
        Application.Run(New Form2)
    End Sub
End Module
