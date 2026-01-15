
Imports System.Data.OleDb

Public Class Form1

    Dim cat As New ADOX.Catalog
    Dim Cn As ADODB.Connection
    Dim DlgRuta As FolderBrowserDialog
    Dim Ruta As String
    Private Sub BtnCrearBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBBDD.Click
        DlgRuta = New FolderBrowserDialog
        DlgRuta.ShowDialog()
        Ruta = DlgRuta.SelectedPath

        Try
            ' Generamos una nueva base de datos Access 2000, 2002 ó 2003
            ' cat.Create("Provider = Microsoft.Jet.OLEDB.4.0;" & _
            '            "Data Source = C:\Mis documentos\Nuevo1.mdb")

            ' Generamos una nueva base de datos Access 2007-2013
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source" & Ruta & "\Nuevo.accdb")

            ' Cerramos el objeto ADODB.Connection que ímplicitamente
            ' se ha originado al crear el archivo de información.
            CType(cat.ActiveConnection, ADODB.Connection).Close()

            MessageBox.Show("Se ha creado con éxito la base de datos.", _
                            "Crear base de datos", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, _
                            "Crear base de datos", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            ' Quitamos las referencias a las instancias de los objetos creados.
            '  cat.ActiveConnection = Nothing
            '  cat = Nothing

        End Try
        BtnCrearBBDD.Enabled = False
        DlgRuta = Nothing

    End Sub

    Private Sub BtnCrearTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearTabla.Click
        'Se crea conexion y catalogo(la verdad no estoy seguro de que sirve) y la tabla nueva

        Dim tabla1 As ADOX.Table

        Cn = New ADODB.Connection
        '  cat = New ADOX.Catalog
        tabla1 = New ADOX.Table

        'Se abre la conexion
        Cn.Open("Provider=Microsoft.Jet.OLEDB.4.0; Data Source" & Ruta & "\Nuevo.accdb")
        cat.ActiveConnection = Cn
        tabla1.Name = "Datos"

        'Se agregan columnas con sus nombres y tipos de datos
        tabla1.Columns.Append("Nmat", ADOX.DataTypeEnum.adInteger)
        'tabla1.Columns.Append("NomApel", ADOX.DataTypeEnum.adChar)
        tabla1.Columns.Append("Nom", ADOX.DataTypeEnum.adWChar)
        tabla1.Columns.Append("Fecha", ADOX.DataTypeEnum.adDate)

        'Se agrega la tabla a la base de datos
        cat.Tables.Append(tabla1)

        'Se limpian los objetos
        tabla1 = Nothing
        cat = Nothing
        Cn.Close()
        Cn = Nothing
    End Sub
End Class
