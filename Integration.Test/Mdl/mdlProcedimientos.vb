Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Imports Integration.BE
Imports Integration.BL

Module mdlProcedimientos

    Public Sub CargarPeriodoActual()

        Dim Request As New Sistema.BE_ReqPeriodo
        Dim Obj As New BL_Sistema

        'Llena Año
        Request.cPerJurCodigo = StrcPerJuridica
        Request.cflag = "A" 'Año
        Request.cAnno = ""
        LlenaDataCombo(FormMDI.CboAnno, Obj.Get_Periodo(Request), "nPrdCodigo", "cPrdDescripcion")

        'Llena Periodos
        'Request.cflag = "P" 'Periodo
        'Request.cAnno = FormMDI.CboAnno.Text
        'LlenaDataCombo(FormMDI.CboPeriodo, Obj.Get_Periodo(Request), "nPrdCodigo", "cPrdDescripcion")

        '--------------------------------
        'Selecciona: Periodo por default
        '--------------------------------
        Request.cPerJurCodigo = StrcPerJuridica
        Request.cAnno = FormMDI.CboAnno.Text

        If Obj.Get_PeriodoContDefault(Request).Rows.Count > 0 Then
            'FormMDI.CboPeriodo.SelectedValue = Obj.Get_PeriodoContDefault(Request).Rows(0)("nPrdCodigo")
            FormMDI.CboAnno.SelectedValue = Obj.Get_PeriodoContDefault(Request).Rows(0)("nPrdCodigo")
        Else
            If Obj.Get_PeriodoContDefault(Request).Rows.Count = 0 Then
                'FormMDI.CboPeriodo.SelectedIndex = -1 '--nada vacio
                FormMDI.CboAnno.SelectedIndex = -1 '--nada vacio
                MessageBox.Show("No hay ningun Periodo Contable creado.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'FormMDI.CboPeriodo.SelectedIndex = 0 '--Apertura
                FormMDI.CboAnno.SelectedIndex = 0 '--Apertura
                MessageBox.Show("No se ha establecido nigun Period Contable por defecto.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub


    Public Sub LimpiarTextBox(ByVal Form As Form)
        For Each Control In Form.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = "" 'vbNullString
            End If
        Next
    End Sub

    Public Sub LimpiarTextBoxGroup(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                miControl.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

    Public Sub LimpiarTextBoxTabs(ByVal Grupo As Windows.Forms.TabPage)
        Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                miControl.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

    'Function para abrir formularios 
    Public Sub llamarform(ByVal formulario As Form, _
                    ByVal mdi As Form) ', ByVal tipo As Integer)

        Dim frmllamado As Form
        Dim escargado As Boolean = False

        Try
            'Chequea si el formulario ha sido cargado
            For Each frmllamado In mdi.MdiChildren
                'Compara si es igual y retorna verdadero si lo es.
                If frmllamado.Text = formulario.Text Then
                    escargado = True   'Marca la bandera
                    Exit For      'Sale del loop si es verdadero
                End If
            Next

            If Not escargado Then
                'Carga el formulario si no esta llamado
                formulario.MdiParent = mdi
                formulario.Show()
            ElseIf escargado Then
                formulario.Focus()   'Enfoca el objeto
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        'formulario.WindowState = FormWindowState.Maximized
        formulario = Nothing  'Limpiar todo
        frmllamado = Nothing

    End Sub

    Public Sub EliminarRowsDgView(ByRef ControlDgView As DataGridView)

        With ControlDgView
            If .RowCount > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows.Remove(.CurrentRow)
                Next
            End If
        End With

    End Sub


    Public Sub EliminaRowSeleccionada(ByRef ControlDgView As DataGridView)

        With ControlDgView
            If .RowCount > 0 Then
                .Rows.Remove(.CurrentRow)
            Else
                MessageBox.Show("No existe ningúna fila (items) para quitar..!", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With

    End Sub

    Public Sub EliminarRowsDg_for_Condicion(ByRef ControlDgView As DataGridView, ByRef NameColumn As String, Optional ByRef nCondicion As Integer = 1)

        REM Create: EIncio
        REM Metodo Elimina Rows de un DataGridView segun condicion y lo comienza desde la ultima fila hace la 1ra fila. 
        Dim nFila As Integer

        With ControlDgView
            For nFila = .Rows.Count - 1 To 0 Step -1
                If .Rows(nFila).Cells(NameColumn).Value = nCondicion Then
                    If Not (.Rows(nFila).IsNewRow) Then
                        .Rows.Remove(.Rows(nFila))
                    End If
                End If
            Next
        End With
    End Sub


    Public Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode, _
                                        ByRef ControlTreeView As TreeView, ByRef DataSetArbol As DataSet)
        Dim dataViewHijos As DataView

        ' Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
        dataViewHijos = New DataView(DataSetArbol.Tables(0))

        dataViewHijos.RowFilter = DataSetArbol.Tables("Interface").Columns("cIntNombre").ColumnName + " = " + indicePadre.ToString()

        ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
        For Each dataRowCurrent As DataRowView In dataViewHijos

            Dim nuevoNodo As New TreeNode
            nuevoNodo.Text = dataRowCurrent("cIntDescripcion").ToString().Trim()
            nuevoNodo.Name = dataRowCurrent("nIntCodigo").ToString().Trim()
            ' nuevoNodo.ToolTipText = dataRowCurrent("nIntCodigo").ToString().Trim()

            nuevoNodo.Tag = dataRowCurrent("cIntNombre").ToString().Trim()
            nuevoNodo.ToolTipText = dataRowCurrent("cIntJerarquia").ToString().Trim()

            If nuevoNodo.Tag <> 0 Then
                nuevoNodo.ImageIndex = 2
                nuevoNodo.SelectedImageIndex = 3
            Else
                nuevoNodo.ImageIndex = 0
                nuevoNodo.SelectedImageIndex = 1
            End If

            ' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
            ' del primer nivel que no dependen de otro nodo.
            If nodePadre Is Nothing Then
                ControlTreeView.Nodes.Add(nuevoNodo)
            Else
                ' se añade el nuevo nodo al nodo padre.
                nodePadre.Nodes.Add(nuevoNodo)
            End If

            ' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            REM CrearNodosDelPadre(Int32.Parse(dataRowCurrent("cIntJerarquia").ToString()), nuevoNodo, ControlTreeView, DataSetArbol)
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("nIntCodigo").ToString()), nuevoNodo, ControlTreeView, DataSetArbol)
        Next dataRowCurrent

    End Sub

    Public Sub CargaReporte(ByVal cPathRPT As String, ByVal CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer, _
                            ByVal FormulaFields As Dictionary(Of String, String), ByVal Data As DataTable)

        Dim CrReport As New ReportDocument

        Try
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT)

            For Each Campo As KeyValuePair(Of String, String) In FormulaFields
                CrReport.DataDefinition.FormulaFields(Campo.Key).Text = Chr(34) & Campo.Value & Chr(34)
            Next

            CrReport.SetDataSource(Data)

            CRV.ReportSource = CrReport

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error A:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CrReport.Close()
        End Try

    End Sub


    ''    Paso 1:
    ''******
    ''Configuramos el nuevo tamaño de las columna al momento de cargar el formulario.
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ' Habilitar el cambio de tamaño en los encabezados de columna
    '    DataGridView1.ColumnHeadersHeightSizeMode = _
    '        DataGridViewColumnHeadersHeightSizeMode.EnableResizing
    '    'Ajustamos el alto para la columna cabecera 
    '    DataGridView1.ColumnHeadersHeight = _
    '        DataGridView1.ColumnHeadersHeight * 2
    '    ' Ajuste la alineación del texto en los encabezados de las  
    '    ' columnas para que la visualización de texto en el centro de la parte inferior
    '    DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = _
    '        DataGridViewContentAlignment.BottomCenter
    'End Sub


    ''    Paso 2:
    ''******
    ''Dibujamos las columnas
    'Private Sub DataGridView1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
    '    ' Datos para las celdas de cabezera 
    '    Dim Grupos As String() = {"GRUPO 1", "GRUPO 2"}
    '    For j As Integer = 0 To DataGridView1.ColumnCount - 1 Step 2
    '        ' Obtener los límites de encabezado de columna 
    '        Dim r1 As Rectangle = DataGridView1.GetCellDisplayRectangle(j, -1, True)
    '        r1.X += 1
    '        r1.Y += 1
    '        r1.Width = r1.Width * 2 - 2
    '        r1.Height = r1.Height / 2 - 2

    '        Using br As SolidBrush = _
    '          New SolidBrush(DataGridView1.ColumnHeadersDefaultCellStyle.BackColor)
    '            e.Graphics.FillRectangle(br, r1)
    '        End Using
    '        Using p As Pen = New Pen(SystemColors.InactiveBorder)
    '            e.Graphics.DrawLine(p, r1.X, r1.Bottom, r1.Right, r1.Bottom)
    '        End Using
    '        Using format As StringFormat = New StringFormat()
    '            Using br As SolidBrush = New SolidBrush(DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor)
    '                format.Alignment = StringAlignment.Center
    '                format.LineAlignment = StringAlignment.Center

    '                e.Graphics.DrawString(Grupos(j / 2), DataGridView1.ColumnHeadersDefaultCellStyle.Font, _
    '                            br, r1, format)
    '            End Using
    '        End Using
    '    Next
    'End Sub

    ''Paso 3:
    ''******
    ''Dibujamos las celdas
    'Private Sub DataGridView1_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
    '    If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
    '        e.PaintBackground(e.CellBounds, False)
    '        Dim r2 As Rectangle = e.CellBounds
    '        r2.Y += e.CellBounds.Height / 2
    '        r2.Height = e.CellBounds.Height / 2
    '        e.PaintContent(r2)
    '        e.Handled = True
    '    End If
    'End Sub


End Module
