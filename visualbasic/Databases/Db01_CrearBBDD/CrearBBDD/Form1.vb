Imports System.Data.OleDb

Public Class Form1

    ' Para crear y manejar la base de datos (tablas, columnas...)
    Dim cat As New ADOX.Catalog
    ' Para conectar con la base de datos
    Dim Cn As ADODB.Connection

    Private Sub BtnCrearBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBBDD.Click
        Try
            ' **PASO 1**: Crea el archivo de la base de datos vacía (.accdb)
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=C:\Users\kosoi\Documents\GitHub\2DAM\vb\Databases\Db01_CrearBBDD\Nuevo.accdb")

            ' **PASO 2**: Cierra la conexión automática que se creó sola
            CType(cat.ActiveConnection, ADODB.Connection).Close()

            ' **PASO 3**: Muestra mensaje "¡Todo bien!"
            MessageBox.Show("Se ha creado con éxito la base de datos.",
                            "Crear base de datos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As Exception
            ' Si algo sale mal, muestra el error
            MessageBox.Show(ex.Message,
                            "Crear base de datos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try
        ' Desactiva el botón para no crear otra base de datos por error
        BtnCrearBBDD.Enabled = False

    End Sub

    Private Sub BtnCrearTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearTabla.Click

        ' Creamos los objetos que necesitamos
        Dim tabla1 As ADOX.Table
        Cn = New ADODB.Connection
        tabla1 = New ADOX.Table

        ' **PASO 1**: Conectamos a la base de datos que ya creamos antes
        Cn.Open("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\kosoi\Documents\GitHub\2DAM\vb\Databases\Db01_CrearBBDD\Nuevo.accdb")

        ' **PASO 2**: Decimos "voy a trabajar con esta conexión"
        cat.ActiveConnection = Cn

        ' **PASO 3**: La tabla se llamará "Datos"
        tabla1.Name = "Datos"

        ' **PASO 4**: AÑADIMOS LAS COLUMNAS (campos) de la tabla:
        ' Columna 1: Nmat (número entero)
        tabla1.Columns.Append("Nmat", ADOX.DataTypeEnum.adInteger)
        ' Columna 2: Nom (texto para nombres)
        tabla1.Columns.Append("Nom", ADOX.DataTypeEnum.adWChar)
        ' Columna 3: Fecha (para guardar fechas)
        tabla1.Columns.Append("Fecha", ADOX.DataTypeEnum.adDate)

        ' **PASO 5**: ¡GUARDAMOS la tabla en la base de datos!
        cat.Tables.Append(tabla1)

        ' **LIMPIEZA**: Se limpian los objetos
        tabla1 = Nothing
        cat = Nothing
        Cn.Close()
        Cn = Nothing
    End Sub
End Class
