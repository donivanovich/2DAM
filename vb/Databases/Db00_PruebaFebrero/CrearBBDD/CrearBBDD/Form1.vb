Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.Devices

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
            tabla.Columns.Append("Ciclo", ADOX.DataTypeEnum.adWChar, 3)
            tabla.Columns.Append("Curso", ADOX.DataTypeEnum.adWChar, 2)
            tabla.Columns.Append("Apellidos", ADOX.DataTypeEnum.adWChar, 50)
            tabla.Columns.Append("Nombre", ADOX.DataTypeEnum.adWChar, 50)
            tabla.Columns.Append("Nota1", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota2", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota3", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota4", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota5", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota6", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota7", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota8", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota9", ADOX.DataTypeEnum.adInteger)
            tabla.Columns.Append("Nota10", ADOX.DataTypeEnum.adInteger)
            cat.Tables.Append(tabla)

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

            Dim rawText As String = String.Join("", File.ReadAllLines(openFileDialog.FileName))
            Dim registros As New List(Of String)

            Dim pos As Integer = 0
            While pos < rawText.Length
                Dim inicioRegistro As Integer = rawText.ToUpper().IndexOf("DAM", pos)
                If inicioRegistro = -1 Then Exit While

                Dim separador As Integer = rawText.IndexOf("0D", inicioRegistro + 10)
                Dim finRegistro As Integer

                If separador = -1 Then
                    finRegistro = rawText.Length
                Else
                    finRegistro = separador + 1
                End If

                registros.Add(rawText.Substring(inicioRegistro, finRegistro - inicioRegistro))
                pos = finRegistro
            End While

            Dim contenido As String() = registros.ToArray()

            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Ruta & "\FP.accdb"

            Using conn As New OleDbConnection(connString)
                conn.Open()
                Dim count As Integer = 0

                For Each linea As String In contenido
                    Dim ciclo As String = "Dam"
                    Dim cursoPos As Integer = linea.IndexOf("-2")
                    Dim curso As String = If(cursoPos >= 0, linea.Substring(cursoPos + 1, 2), "")
                    Dim resto As String = linea.Substring(cursoPos + 3).Trim()
                    Dim comaPos As Integer = resto.IndexOf(",")
                    Dim apellidos As String = If(comaPos >= 0, resto.Substring(0, comaPos).Trim(), "")
                    Dim nombre As String = If(comaPos >= 0, resto.Substring(comaPos + 1).Trim().Split(" "c)(0).Replace("0"c, ""), "")
                    Dim partes As String() = {ciclo, curso, apellidos, nombre}

                    If partes.Length = 4 AndAlso Not String.IsNullOrEmpty(partes(1)) Then
                        Dim query As String = "insert into nota (Ciclo, Curso, Apellidos, Nombre, Nota1, Nota2, Nota3, Nota4, Nota5, Nota6, Nota7, Nota8, Nota9, Nota10) values (?, ?, ?, ?, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)"
                        Using cmd As New OleDbCommand(query, conn)
                            cmd.Parameters.AddWithValue("", partes(0))
                            cmd.Parameters.AddWithValue("", partes(1))
                            cmd.Parameters.AddWithValue("", partes(2))
                            cmd.Parameters.AddWithValue("", partes(3))
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
