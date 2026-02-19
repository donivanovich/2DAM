Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1
    Dim cat As New ADOX.Catalog
    Dim Cn As ADODB.Connection
    Dim DlgRuta As FolderBrowserDialog
    Dim Ruta As String

    Private Sub BtnCrearBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBBDD.Click
        DlgRuta = New FolderBrowserDialog
        If DlgRuta.ShowDialog() = DialogResult.OK Then
            Ruta = DlgRuta.SelectedPath
            Try
                cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Ruta & "\FP.accdb")

                CType(cat.ActiveConnection, ADODB.Connection).Close()

                MessageBox.Show("Se ha creado con éxito la base de datos.",
                                "Crear base de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            Catch ex As COMException
                MessageBox.Show("El archivo ya existe. Se utilizará el archivo existente.",
                                "Crear base de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message,
                                "Crear base de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)

            End Try
        End If
        BtnCrearBBDD.Enabled = False
        DlgRuta = Nothing

        ' CREAR TABLA
        Dim tabla As ADOX.Table

        Try
            Cn = New ADODB.Connection
            tabla = New ADOX.Table

            Cn.Open("Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Ruta & "\FP.accdb")

            cat.ActiveConnection = Cn
            tabla.Name = "nota"

            tabla.Columns.Append("Ciclo", ADOX.DataTypeEnum.adWChar)
            tabla.Columns.Append("Curso", ADOX.DataTypeEnum.adWChar)
            tabla.Columns.Append("Apellidos", ADOX.DataTypeEnum.adWChar)
            tabla.Columns.Append("Nombre", ADOX.DataTypeEnum.adWChar)
            'tabla.Columns.Append("Nota1", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota2", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota3", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota4", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota5", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota6", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota7", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota8", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota9", ADOX.DataTypeEnum.adInteger)
            'tabla.Columns.Append("Nota10", ADOX.DataTypeEnum.adInteger)

            cat.Tables.Append(tabla)

            MessageBox.Show("Tabla creada correctamente.")

        Catch ex As System.Runtime.InteropServices.COMException

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try

        'Leer Archivo .dat
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de texto (*.txt;*.dat)|*.txt;*.dat|Todos los archivos (*.*)|*.*"
        openFileDialog.Title = "Seleccionar archivo para importar"

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            If String.IsNullOrEmpty(Ruta) Then
                    MessageBox.Show("Primero debes crear o seleccionar la ruta de la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim lineas As String() = File.ReadAllLines(openFileDialog.FileName)
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Ruta & "\FP.accdb"

            Using conn As New OleDbConnection(connString)
                conn.Open()
                Dim count As Integer = 0

                For Each linea As String In lineas
                    Dim partes As String() = linea.Split(" ")

                    If partes.Length >= 14 Then
                        Dim query As String = "INSERT INTO nota (Ciclo, Curso, Apellidos, Nombre) VALUES (?, ?, ?, ?)"
                        Using cmd As New OleDbCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Ciclo", partes(0))
                            cmd.Parameters.AddWithValue("@Curso", partes(1))
                            cmd.Parameters.AddWithValue("@Apellidos", partes(2))
                            cmd.Parameters.AddWithValue("@Nombre", partes(3))
                            'cmd.Parameters.AddWithValue("@Nota1", Convert.ToInt32(partes(4)))
                            'cmd.Parameters.AddWithValue("@Nota2", Convert.ToInt32(partes(5)))
                            'cmd.Parameters.AddWithValue("@Nota3", Convert.ToInt32(partes(6)))
                            'cmd.Parameters.AddWithValue("@Nota4", Convert.ToInt32(partes(7)))
                            'cmd.Parameters.AddWithValue("@Nota5", Convert.ToInt32(partes(8)))
                            'cmd.Parameters.AddWithValue("@Nota6", Convert.ToInt32(partes(9)))
                            'cmd.Parameters.AddWithValue("@Nota7", Convert.ToInt32(partes(10)))
                            'cmd.Parameters.AddWithValue("@Nota8", Convert.ToInt32(partes(11)))
                            'cmd.Parameters.AddWithValue("@Nota9", Convert.ToInt32(partes(12)))
                            'cmd.Parameters.AddWithValue("@Nota10", Convert.ToInt32(partes(13)))
                            cmd.ExecuteNonQuery()
                            count += 1
                        End Using
                    End If
                Next

                MessageBox.Show("Se han importado " & count & " registros correctamente.", "Importación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End If
    End Sub

End Class
