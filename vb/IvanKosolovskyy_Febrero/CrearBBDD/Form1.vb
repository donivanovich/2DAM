
Imports System.Data.OleDb
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq

Public Class Form1

    Dim cat As New ADOX.Catalog
    Dim Cn As ADODB.Connection

    ' DEFINICIÓN DE ESTRUCTURA DE COLUMNA
    Private Structure ColumnDefinition
        Public Name As String
        Public Type As ADOX.DataTypeEnum
        Public DataType As Type
    End Structure

    ' LISTA DE COLUMNAS CONFIGURABLE
    ' Agregue o quite lineas aqui para modificar las columnas de la BBDD y del archivo a importar
    Private columns As New List(Of ColumnDefinition) From {
        New ColumnDefinition With {.Name = "Nmat", .Type = ADOX.DataTypeEnum.adInteger, .DataType = GetType(Integer)},
        New ColumnDefinition With {.Name = "Nom", .Type = ADOX.DataTypeEnum.adWChar, .DataType = GetType(String)},
        New ColumnDefinition With {.Name = "Fecha", .Type = ADOX.DataTypeEnum.adDate, .DataType = GetType(DateTime)},
        New ColumnDefinition With {.Name = "Nota", .Type = ADOX.DataTypeEnum.adInteger, .DataType = GetType(Integer)}
    }
    Private Sub BtnCrearBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBBDD.Click


        Try
            ' Generamos una nueva base de datos Access 2000, 2002 ó 2003
            ' cat.Create("Provider = Microsoft.Jet.OLEDB.4.0;" & _
            '            "Data Source = C:\Mis documentos\Nuevo1.mdb")

            ' Generamos una nueva base de datos Access 2007-2013
            ' Nota: Para .accdb se suele usar Microsoft.ACE.OLEDB.12.0
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" &
                       "Data Source=Nuevo.accdb")

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

    End Sub

    Private Sub BtnCrearTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearTabla.Click
        'Se crea conexion y catalogo(la verdad no estoy seguro de que sirve) y la tabla nueva

        Dim tabla1 As ADOX.Table

        Cn = New ADODB.Connection
        '  cat = New ADOX.Catalog
        tabla1 = New ADOX.Table

        'Se abre la conexion
        Cn.Open("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Nuevo.accdb")
        cat.ActiveConnection = Cn
        tabla1.Name = "Datos"

        'Se agregan columnas con sus nombres y tipos de datos
        'Se agregan columnas dinamicamente segun la lista configurada
        For Each col As ColumnDefinition In columns
            tabla1.Columns.Append(col.Name, col.Type)
        Next

        'Se agrega la tabla a la base de datos
        cat.Tables.Append(tabla1)

        'Se limpian los objetos
        tabla1 = Nothing
        cat = Nothing
        Cn.Close()
        Cn = Nothing
    End Sub

    Private Sub BtnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportar.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de texto (*.txt;*.csv)|*.txt;*.csv|Todos los archivos (*.*)|*.*"
        openFileDialog.Title = "Seleccionar archivo para importar"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim lineas As String() = File.ReadAllLines(openFileDialog.FileName)
                Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Nuevo.accdb"
                
                Using conn As New OleDbConnection(connString)
                    conn.Open()
                    Dim count As Integer = 0
                    
                    For Each linea As String In lineas
                        If String.IsNullOrWhiteSpace(linea) Then Continue For
                        
                        ' Suponemos el formato delimitado por ;
                        Dim partes As String() = linea.Split(";"c)
                        
                        ' Verificamos si tenemos suficientes datos para las columnas definidas
                        If partes.Length >= columns.Count Then
                            
                            ' Generamos la consulta SQL dinamicamente
                            Dim colNames As String = String.Join(", ", columns.Select(Function(c) c.Name))
                            Dim paramPlaceholders As String = String.Join(", ", columns.Select(Function(c) "?"))
                            Dim query As String = String.Format("INSERT INTO Datos ({0}) VALUES ({1})", colNames, paramPlaceholders)
                            
                            Using cmd As New OleDbCommand(query, conn)
                                ' Agregamos los parametros iterando sobre las columnas
                                For i As Integer = 0 To columns.Count - 1
                                    Dim val As Object = partes(i)
                                    ' Conversion simple de tipos
                                    If columns(i).DataType = GetType(Integer) Then
                                        val = Convert.ToInt32(partes(i))
                                    ElseIf columns(i).DataType = GetType(DateTime) Then
                                        val = Convert.ToDateTime(partes(i))
                                    End If
                                    
                                    cmd.Parameters.AddWithValue("@" & columns(i).Name, val)
                                Next
                                
                                cmd.ExecuteNonQuery()
                                count += 1
                            End Using
                        End If
                    Next
                    
                    MessageBox.Show("Se han importado " & count & " registros correctamente.", "Importación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al importar: " & ex.Message, "Error de Importación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
