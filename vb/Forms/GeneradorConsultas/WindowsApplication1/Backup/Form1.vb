Imports System.Data.OleDb
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents CmbTablas As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents OptIgual As System.Windows.Forms.RadioButton
    Friend WithEvents OptMayor As System.Windows.Forms.RadioButton
    Friend WithEvents OptMenor As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSelect As System.Windows.Forms.TextBox
    Friend WithEvents LblSelect As System.Windows.Forms.Label
    Friend WithEvents TxtDatoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LblDatoBuscar As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents DtgDatos As System.Windows.Forms.DataGrid
    Friend WithEvents LblNoDatos As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CmbTablas = New System.Windows.Forms.ComboBox
        Me.CmbCampos = New System.Windows.Forms.ComboBox
        Me.OptIgual = New System.Windows.Forms.RadioButton
        Me.OptMayor = New System.Windows.Forms.RadioButton
        Me.OptMenor = New System.Windows.Forms.RadioButton
        Me.TxtDatoBuscar = New System.Windows.Forms.TextBox
        Me.TxtSelect = New System.Windows.Forms.TextBox
        Me.LblSelect = New System.Windows.Forms.Label
        Me.LblDatoBuscar = New System.Windows.Forms.Label
        Me.DtgDatos = New System.Windows.Forms.DataGrid
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.LblNoDatos = New System.Windows.Forms.Label
        CType(Me.DtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbTablas
        '
        Me.CmbTablas.Location = New System.Drawing.Point(8, 16)
        Me.CmbTablas.Name = "CmbTablas"
        Me.CmbTablas.Size = New System.Drawing.Size(136, 21)
        Me.CmbTablas.TabIndex = 0
        Me.CmbTablas.Text = "Seleccione una tabla"
        '
        'CmbCampos
        '
        Me.CmbCampos.Location = New System.Drawing.Point(168, 16)
        Me.CmbCampos.Name = "CmbCampos"
        Me.CmbCampos.Size = New System.Drawing.Size(152, 21)
        Me.CmbCampos.TabIndex = 1
        Me.CmbCampos.Text = "Seleccione un Campo"
        '
        'OptIgual
        '
        Me.OptIgual.Enabled = False
        Me.OptIgual.Location = New System.Drawing.Point(360, 16)
        Me.OptIgual.Name = "OptIgual"
        Me.OptIgual.Size = New System.Drawing.Size(40, 24)
        Me.OptIgual.TabIndex = 2
        Me.OptIgual.Text = "="
        '
        'OptMayor
        '
        Me.OptMayor.Enabled = False
        Me.OptMayor.Location = New System.Drawing.Point(360, 48)
        Me.OptMayor.Name = "OptMayor"
        Me.OptMayor.Size = New System.Drawing.Size(40, 24)
        Me.OptMayor.TabIndex = 3
        Me.OptMayor.Text = ">"
        '
        'OptMenor
        '
        Me.OptMenor.Enabled = False
        Me.OptMenor.Location = New System.Drawing.Point(360, 80)
        Me.OptMenor.Name = "OptMenor"
        Me.OptMenor.Size = New System.Drawing.Size(40, 24)
        Me.OptMenor.TabIndex = 4
        Me.OptMenor.Text = "<"
        '
        'TxtDatoBuscar
        '
        Me.TxtDatoBuscar.Enabled = False
        Me.TxtDatoBuscar.Location = New System.Drawing.Point(432, 48)
        Me.TxtDatoBuscar.Name = "TxtDatoBuscar"
        Me.TxtDatoBuscar.Size = New System.Drawing.Size(168, 20)
        Me.TxtDatoBuscar.TabIndex = 5
        Me.TxtDatoBuscar.Text = ""
        '
        'TxtSelect
        '
        Me.TxtSelect.Location = New System.Drawing.Point(24, 112)
        Me.TxtSelect.Name = "TxtSelect"
        Me.TxtSelect.Size = New System.Drawing.Size(576, 20)
        Me.TxtSelect.TabIndex = 6
        Me.TxtSelect.Text = ""
        '
        'LblSelect
        '
        Me.LblSelect.Location = New System.Drawing.Point(24, 80)
        Me.LblSelect.Name = "LblSelect"
        Me.LblSelect.Size = New System.Drawing.Size(56, 23)
        Me.LblSelect.TabIndex = 7
        Me.LblSelect.Text = "Consulta:"
        '
        'LblDatoBuscar
        '
        Me.LblDatoBuscar.Enabled = False
        Me.LblDatoBuscar.Location = New System.Drawing.Point(432, 16)
        Me.LblDatoBuscar.Name = "LblDatoBuscar"
        Me.LblDatoBuscar.Size = New System.Drawing.Size(88, 23)
        Me.LblDatoBuscar.TabIndex = 8
        Me.LblDatoBuscar.Text = "Dato a Buscar:"
        '
        'DtgDatos
        '
        Me.DtgDatos.DataMember = ""
        Me.DtgDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgDatos.Location = New System.Drawing.Point(24, 152)
        Me.DtgDatos.Name = "DtgDatos"
        Me.DtgDatos.Size = New System.Drawing.Size(584, 216)
        Me.DtgDatos.TabIndex = 9
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(464, 72)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(104, 24)
        Me.BtnAceptar.TabIndex = 10
        Me.BtnAceptar.Text = "Aceptar"
        '
        'LblNoDatos
        '
        Me.LblNoDatos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNoDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoDatos.Location = New System.Drawing.Point(184, 232)
        Me.LblNoDatos.Name = "LblNoDatos"
        Me.LblNoDatos.Size = New System.Drawing.Size(256, 32)
        Me.LblNoDatos.TabIndex = 11
        Me.LblNoDatos.Text = "No Existen Datos"
        Me.LblNoDatos.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 374)
        Me.Controls.Add(Me.LblNoDatos)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DtgDatos)
        Me.Controls.Add(Me.LblDatoBuscar)
        Me.Controls.Add(Me.LblSelect)
        Me.Controls.Add(Me.TxtSelect)
        Me.Controls.Add(Me.TxtDatoBuscar)
        Me.Controls.Add(Me.OptMenor)
        Me.Controls.Add(Me.OptMayor)
        Me.Controls.Add(Me.OptIgual)
        Me.Controls.Add(Me.CmbCampos)
        Me.Controls.Add(Me.CmbTablas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim oDataAdapter As OleDbDataAdapter
    Dim oDataSet As New DataSet
    Dim oConexion As New OleDbConnection
    Dim oCommandBuilder As OleDbCommandBuilder
    Dim i As Integer
    Dim MiTablas As DataTable
    Dim DatosCol As DataColumn
    Dim CadenaSelect As String
    Dim cadenaSelect1 As String
    Dim cadenaselect2 As String
    Dim Sw As Byte


    'oCommandBuilder = New OleDbCommandBuilder(oDataAdapter)

    'oDataAdapter = New OleDbDataAdapter("select * from datos order by dni", oConexion)


    '

    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oConexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\vbnet\DatosPer.mdb"
        oConexion.Open()
        oDataAdapter = New OleDbDataAdapter("select * from Emple", oConexion)
        oCommandBuilder = New OleDbCommandBuilder(oDataAdapter)
        oDataAdapter.Fill(oDataSet, "Emple")
        oConexion.Close()
        For i = 0 To oDataSet.Tables.Count - 1
            CmbTablas.Items.Add(oDataSet.Tables.Item(i))
        Next
    End Sub

    Private Sub CmbTablas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTablas.SelectedIndexChanged
        CmbCampos.Items.Clear()
        Dim oDataRow As DataRow
        oDataRow = oDataSet.Tables(CmbTablas.Text).Rows(0)
        'Dim MiTablas As DataTable
        MiTablas = oDataRow.Table


        For Each DatosCol In MiTablas.Columns
            CmbCampos.Items.Add(DatosCol.ColumnName)
        Next
        CadenaSelect = "select * from " + CmbTablas.Text
        TxtSelect.Text = CadenaSelect
    End Sub

    Private Sub CmbCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCampos.SelectedIndexChanged
        TxtSelect.Text = CadenaSelect + " Where " + CmbCampos.Text
        cadenaSelect1 = TxtSelect.Text
        Dim TypoDatoString As String = "System.String"
        Dim TypoDatoInt As String = "System.Int32"
        For Each DatosCol In MiTablas.Columns
            If DatosCol.ColumnName = CmbCampos.Text Then

                Select Case DatosCol.DataType.FullName
                    Case TypoDatoString
                        OptIgual.Enabled = True
                        OptMayor.Enabled = False
                        OptMenor.Enabled = False
                        Sw = 0
                        Exit For
                    Case TypoDatoInt
                        OptIgual.Enabled = True
                        OptMayor.Enabled = True
                        OptMenor.Enabled = True
                        Sw = 1
                        Exit For
                End Select

            End If


        Next
       

    End Sub

    Private Sub OptIgual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptIgual.Click
        If OptIgual.Checked = True Then
            ActivarDato(OptIgual.Text)
        End If
    End Sub
    Private Sub ActivarDato(ByVal Operador As String)
        CambiarEstado(True)
        cadenaselect2 = cadenaSelect1 + " " + Operador
        TxtSelect.Text = cadenaselect2
    End Sub

    Private Sub OptMayor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptMayor.Click
        If OptMayor.Checked = True Then
            ActivarDato(OptMayor.Text)
        End If
    End Sub

    Private Sub OptMenor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptMenor.Click
        If OptMenor.Checked = True Then
            ActivarDato(OptMenor.Text)
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        BtnAceptar.Enabled = False
        Select Case Sw
            Case 0
                TxtSelect.Text = TxtSelect.Text + " '"
                TxtSelect.Text = TxtSelect.Text + TxtDatoBuscar.Text
                TxtSelect.Text = TxtSelect.Text + "'"
            Case 1
                TxtSelect.Text = TxtSelect.Text + " " + TxtDatoBuscar.Text

        End Select
        oConexion.Open()
        oDataAdapter = Nothing
        oDataAdapter = New OleDbDataAdapter(TxtSelect.Text, oConexion)
        oDataSet.Tables("Emple").Clear()
        oDataAdapter.Fill(oDataSet, "Emple")
        oConexion.Close()
        If oDataSet.Tables("Emple").Rows.Count > 0 Then
            LblNoDatos.Visible = False
            DtgDatos.DataSource = oDataSet
            DtgDatos.DataMember = "Emple"
        Else
            LblNoDatos.Visible = True
        End If
        CambiarEstado(False)
    End Sub
    Private Sub CambiarEstado(ByVal Valor As Boolean)
        LblDatoBuscar.Enabled = Valor
        TxtDatoBuscar.Enabled = Valor
        BtnAceptar.Enabled = Valor
    End Sub
End Class
