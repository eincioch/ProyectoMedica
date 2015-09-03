Imports System.IO
Imports Integration.BE.Campana
Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_Campana
Imports Integration.BL.BL_CtaCtes

Public Class FormFiltroServicios
    Dim mdtbColourMap As DataTable = Nothing

    Dim Req_Campana As New BE_ReqCampana
    Dim Obj_Campana As New BL_Campana

    Enum GrillaServicios
        ColnKey = 0
        ColcPerJurCodigo = 1
        ColnCtaCteSerCodigo = 2
        ColcIntJerarquia = 3
        ColcCtaCteSerJerarquia = 4
        ColcCtaCteSerKeyWord = 5
        ColnMonCodigo = 6
        ColnIntCodigo = 7
        ColnCtaCteSerCosto = 8
        ColnFlag = 9
    End Enum

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.F1
                TabControl1.SelectedIndex = 0
                Return True
            Case Keys.F2
                TabControl1.SelectedIndex = 1
                Return True
            Case Keys.F3
                TabControl1.SelectedIndex = 2
                Return True
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub FiltraServicio(ByVal Valor As String, Optional ByVal Flag As String = "C")
        Try
            Dim Req_ListServicio As New BE_ReqCtaCtePrecioServicio
            Dim Obj_ListServicio As New BL_CtaCtePrecioServicio

            Req_ListServicio.cPerJurCodigo = StrcPerJuridica
            Req_ListServicio.nIntCodigo = IIf(FormServicios = 1, CLng(TokenByKey(StrPasaValores, "nIntCodigo")), 1001) REM Recuperando tipo de atencion para obtener el precio de CtaCteServicios.
            Req_ListServicio.cCtaCteSerKeyWord = Valor 'Trim(TxtCaracter.Text)
            Req_ListServicio.cIntJerarquia = CboClase.SelectedValue.ToString '  Microsoft.VisualBasic.Left(CboClase.Text, 5)
            Req_ListServicio.Flag = Flag '"C"

            Table1.DataSource = Obj_ListServicio.Get_List_CtaCteServicio(Req_ListServicio)

            ''Define the search terms and color for each
            'mdtbColourMap = New DataTable
            'mdtbColourMap.Columns.Add(New DataColumn("SearchTerm", GetType(String)))
            'mdtbColourMap.Columns.Add(New DataColumn("TextColor", GetType(Brush)))
            'mdtbColourMap.Rows.Add("_", Drawing.Brushes.Red) 'Green)
            ''mdtbColourMap.Rows.Add("+", Drawing.Brushes.Red)
            ''mdtbColourMap.Rows.Add("-", Drawing.Brushes.Purple)
            'mdtbColourMap.Rows.Add("(", Drawing.Brushes.Red)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FormFiltroServicios_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Table1.Enabled = False
                Call BtnSeleccionar_Click(BtnSeleccionar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                Call BtnCancelar_Click(BtnCancelar, Nothing)
        End Select

    End Sub


    Private Sub FormFiltroServicios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Req_Campana.cPerJurCodigo = StrcPerJuridica

            Table1.Enabled = True
            FormatGrilla(Table1, Me, False, 25, False, DataGridViewSelectionMode.CellSelect)

            LstBoxCampana.Items.Clear()
            LlenaListBox(LstBoxCampana, Obj_Campana.Get_List_Campana(Req_Campana), "nIntCamp", "cNombreCamp")

            If LstBoxCampana.Items.Count > 0 Then
                LstBoxCampana.Enabled = True
                Me.Width = 901
            End If
            REM LlenaDataCombo(CboCampana, Obj_Campana.Get_List_Campana(Req_Campana), "nIntCamp", "cNombreCamp")

            Me.StartPosition = FormStartPosition.CenterScreen

            LlenaDataCombo(CboClase, ObjInterface.Get_Interface(CLng(TokenByKey(CboClase.Tag, "nIntClase")), CLng(TokenByKey(CboClase.Tag, "nIntTipo")), "F"), "nIntCodigo", "cIntDescripcion") REM "cIntJerarquia")
            'CboClase_SelectionChangeCommitted(CboClase, Nothing)

            'If TabControl1.SelectedTab.Name = "TabPage1" Then TxtCodigo.Focus()
            Me.ActiveControl = TxtCodigo
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles BtnSeleccionar.Click

        Try
            Dim Rows As Integer

            If Table1.RowCount = 0 Then Exit Sub

            With Table1
                If Not .CurrentCell Is Nothing Then
                    For Each row As DataGridViewRow In .Rows

                        REM Pasando solo los que tiene el Check 
                        If Convert.ToInt16(row.Cells("nKey").Value) = 1 Then

                            Select Case FormServicios
                                Case Is = 0 REM Form Campaña
                                    'Verificando si el servicio ya fue ingresado 
                                    If BuscaCadenaDgView("nCtaCteSerCodigo", row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString, FormMaCampana.Table1) Then
                                        MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " ya esta siendo ingresado, no podra utilizar el mismo Servicio.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        REM Si No Existe, aqui insertas el fila
                                        With FormMaCampana.Table1
                                            Rows = .RowCount()
                                            .Rows.Add()
                                            .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                            .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                            .Item("cIntJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcIntJerarquia).Value.ToString
                                            .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString
                                            .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                            .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                            .Item("nIntCodigo", Rows).Value = row.Cells(GrillaServicios.ColnIntCodigo).Value.ToString
                                            .Item("nCtaCteSerCosto", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value.ToString
                                        End With

                                    End If

                                Case Is = 1 REM Form Ficha Atencion
                                    'Verificando si el servicio ya fue ingresado
                                    If BuscaCadenaDgView("nCtaCteSerCodigo", row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString, FormPrcSolAtencion.Table1) Then
                                        MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " ya ha sido ingresado, no podra utilizar el mismo Servicio.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        If row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value <= 0 Then
                                            MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " , tiene Precio < Cero > por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Exit Sub
                                        Else
                                            REM Si No existe y el Precio no es CERO, agregamos los item(s).
                                            With FormPrcSolAtencion.Table1
                                                Rows = .RowCount()
                                                .Rows.Add()
                                                .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                                .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                                .Item("cIntJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcIntJerarquia).Value.ToString
                                                .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString
                                                .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                                .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                                .Item("nIntCodigo", Rows).Value = row.Cells(GrillaServicios.ColnIntCodigo).Value.ToString
                                                .Item("nCtaCteCantidad", Rows).Value = 1 'Default
                                                .Item("nCtaCteSerCosto", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value.ToString
                                                .Item("nCtaCteSubTotal", Rows).Value = FormatNumber(CLng(1) * CLng(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value), True)
                                                'Manejo de Bloqueo si agrega items de campaña
                                                .Item("nFlag", Rows).Value = row.Cells(GrillaServicios.ColnFlag).Value.ToString

                                            End With
                                        End If

                                    End If
                            End Select

                        End If
                    Next

                    Me.Close()
                    Me.Dispose()

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub LstBoxCampana_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LstBoxCampana.MouseDoubleClick
        Req_Campana.cPerJurCodigo = StrcPerJuridica
        Req_Campana.nIntCamp = CLng(LstBoxCampana.SelectedValue)

        Table1.DataSource = Obj_Campana.Get_Servicios_for_nIntCamp(Req_Campana)
    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        FiltraServicio(TxtCodigo.Text)
    End Sub

    Private Sub CboClase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboClase.SelectionChangeCommitted
        FiltraServicio("", "G")
    End Sub

    Private Sub TxtCaracter_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCaracter.TextChanged
        FiltraServicio(TxtCaracter.Text, "D")
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        EliminarRowsDgView(Table1)
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                TxtCodigo.Text = vbNullString : TxtCodigo.Focus()
            Case 2
                TxtCaracter.Text = vbNullString : TxtCaracter.Focus()
            Case 1
                CboClase_SelectionChangeCommitted(CboClase, Nothing)
                CboClase.Focus()
        End Select
    End Sub

    'Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting

    '    If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
    '        Dim newRect As New Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, _
    '            e.CellBounds.Width - 4, e.CellBounds.Height - 4)
    '        Dim backColorBrush As New SolidBrush(e.CellStyle.BackColor)
    '        Dim gridBrush As New SolidBrush(Me.Table1.GridColor)
    '        Dim gridLinePen As New Pen(gridBrush)
    '        Try
    '            ' Erase the cell.
    '            e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

    '            ' Draw the grid lines (only the right and bottom lines; 
    '            ' DataGridView takes care of the others).
    '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, _
    '                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, _
    '                e.CellBounds.Bottom - 1)
    '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, _
    '                e.CellBounds.Top, e.CellBounds.Right - 1, _
    '                e.CellBounds.Bottom)

    '            ' Draw the inset highlight box.
    '            'e.Graphics.DrawRectangle(Pens.Blue, newRect)

    '            ' Draw the text content of the cell, ignoring alignment. 
    '            If (e.Value IsNot Nothing) Then
    '                Dim strValue As String = CStr(e.Value)
    '                Dim strWords() As String = Split(strValue, " ")
    '                Dim strAlignment As String = "LEFT"
    '                If e.ColumnIndex = 0 Then strAlignment = "RIGHT"
    '                Dim sngX As Integer
    '                If strAlignment = "LEFT" Then
    '                    sngX = e.CellBounds.X + 2
    '                Else
    '                    sngX = e.CellBounds.Right - 4 - e.Graphics.MeasureString(strValue, e.CellStyle.Font).Width
    '                End If
    '                For i As Integer = 0 To strWords.GetUpperBound(0)
    '                    Dim brsTextColor As Drawing.Brush = Nothing
    '                    For j As Integer = 0 To mdtbColourMap.Rows.Count - 1
    '                        Dim strSearchTerm As String = mdtbColourMap.Rows(j).Item("SearchTerm").ToString
    '                        If InStr(strWords(i), strSearchTerm) > 0 Then
    '                            brsTextColor = DirectCast(mdtbColourMap.Rows(j).Item("TextColor"), Drawing.Brush) 'change the color
    '                            Exit For
    '                        End If
    '                    Next j
    '                    If brsTextColor Is Nothing Then
    '                        brsTextColor = Brushes.Blue  'Black 'default
    '                    End If
    '                    e.Graphics.DrawString(strWords(i), e.CellStyle.Font, brsTextColor, sngX, e.CellBounds.Y + 2, StringFormat.GenericDefault)
    '                    sngX += e.Graphics.MeasureString(strWords(i), e.CellStyle.Font).Width
    '                Next i
    '            End If
    '            e.Handled = True
    '        Finally
    '            gridLinePen.Dispose()
    '            gridBrush.Dispose()
    '            backColorBrush.Dispose()
    '        End Try

    '    End If

    'End Sub

End Class