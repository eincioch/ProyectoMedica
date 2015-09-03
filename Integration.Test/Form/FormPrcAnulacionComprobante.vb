Option Explicit On
Imports Integration.BL
Imports Integration.BL.BL_CtaCtes

Public Class FormPrcAnulacionComprobante

    Dim cFlag As String

    Private Sub FormPrcAnulacionComprobante_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F5))
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                C1CmdAnular_Click(C1CmdAnular, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select
    End Sub

    Private Sub FormPrcAnulacionComprobante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim Obj As New BL_Interface

        LlenaDataCombo(CboTipoDocu, Obj.Get_Interface(CLng(TokenByKey(CboTipoDocu.Tag, "nIntClase")), CLng(TokenByKey(CboTipoDocu.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")

        FormatGrilla(Table1, Me, True, 30)
        'FormatGrilla(Table2, Me, True, 30)

        Me.WindowState = FormWindowState.Maximized

        CboFiltro.SelectedIndex = 0
        CboFiltro_SelectionChangeCommitted(CboFiltro, Nothing)

    End Sub

    Private Sub C1CmdBuscar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdBuscar.Click

        Dim BL As New BL_AnularComprobante

        Select Case CboFiltro.SelectedIndex
            Case 0
                cFlag = "C" 'por Comprobante
            Case 1
                cFlag = "F" 'por Rango de Fechas
        End Select

        Table1.DataSource = BL.Get_Comprobante_Venta_by_cPerJurCodigo_nCtaCteComCodigo_cCtaCteComNumero(StrcPerJuridica, CLng(CboTipoDocu.SelectedValue), TxtSerie.Text & TxtNumero.Text, FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate), cFlag)

    End Sub

    Private Sub Table1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Table1.SelectionChanged

        'Ver detalle del comprobante
        'If Table1.RowCount > 0 Then
        '    Dim BL As New BL_AnularComprobante
        '    Table2.DataSource = BL.Get_CtaCteItem_for_cCtaCteRecibo_by_range_fechas("PAGO", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), Table1.Item("cCtaCteRecibo", Table1.CurrentRow.Index).Value)
        'End If

    End Sub

    Private Sub Table1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles Table1.CellFormatting

        With Table1
            For i As Integer = 0 To .Rows.Count - 1

                'If (CDbl(.Item("nCtaCteImporte", i).Value) > 0 And CDbl(.Item("nCtaCteImpAplicado", i).Value) = 0) Then .Rows(i).Cells("nCtaCteEstado").Value = 3

                Dim columnHeaderStyle As New DataGridViewCellStyle()

                '.Rows(i).Cells("DescCtaCteEstado").Style.Font.Style = FontStyle.Bold.ToString
                ColumnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)

                '.ColumnHeadersDefaultCellStyle = columnHeaderStyle
                .RowHeadersDefaultCellStyle = columnHeaderStyle

                Select Case .Rows(i).Cells("nCtaCteEstado").Value
                    Case Is = 0 'Anulado
                        .Rows(i).Cells("cEstado").Style.ForeColor = Color.Red

                    Case Is = 1  'Cancelado
                        .Rows(i).Cells("cEstado").Style.ForeColor = Color.Blue
                End Select
            Next
        End With

    End Sub

    Private Sub FormPrcAnulacionComprobante_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        Table1.Width = Width - 30
        Table1.Height = Height - 170
        Label1.Width = Table1.Width

        'Table2.Width = Width - 30
        'Label2.Width = Table2.Width
        'Table2.Height = Height - 430

    End Sub

    Private Sub C1CmdAnular_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdAnular.Click

        Dim cFlag As String = ""

        With Table1

            If .RowCount = 0 Then Exit Sub

            '//Si estado es = ANULADO
            If .Item("nCtaCteEstado", .CurrentRow.Index).Value = 0 Then
                MessageBox.Show("Comprobante seleccionado esta en estado Anulado.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Esta seguro de Anular comprobante: " & Chr(13) & Chr(13) & .Item("cIntDescripcion", .CurrentRow.Index).Value & " Nº. " & .Item("Serie", .CurrentRow.Index).Value & "-" & .Item("Numero", .CurrentRow.Index).Value & Chr(13) & Chr(13) & "Importante: Si ANULA este Documento no podra Revertir la Operación." _
                                    , "Anular comprobante..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim BL As New BL_AnularComprobante

                'If BL.Set_AnularComprobante(cFlag, .Item("cPerJurCodigo", .CurrentRow.Index).Value, .Item("cPerCodigo", .CurrentRow.Index).Value, .Item("cCtaCteRecibo", .CurrentRow.Index).Value, .Item("cCtaCteRecAbono1", .CurrentRow.Index).Value, StrUser) Then
                MessageBox.Show("Comprobante ya ha sido Anulado.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If

            End If

        End With

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click

        Close()
        Dispose()

    End Sub

    Private Sub CboFiltro_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboFiltro.SelectionChangeCommitted

        Panel1.Visible = False : Panel2.Visible = False

        Select Case CboFiltro.SelectedIndex
            Case 0 'Nro. Recibo
                Panel2.Visible = True
                CboTipoDocu.Focus()
            Case 1 'Rango de fechas
                Panel1.Visible = True
                DtpFecIni.Focus()
        End Select

    End Sub

    'Private Sub InitializeContextMenu()

    '    ' Create the menu item. 
    '    Dim getRecipe As New ToolStripMenuItem( _
    '        "Search for recipe", Nothing, AddressOf ShortcutMenuClick)

    '    ' Add the menu item to the shortcut menu. 
    '    Dim recipeMenu As New ContextMenuStrip()
    '    recipeMenu.Items.Add(getRecipe)

    '    ' Set the shortcut menu for the first column.
    '    Table1.Columns(0).ContextMenuStrip = recipeMenu

    'End Sub

    'Private clickedCell As DataGridViewCell

    'Private Sub dataGridView1_MouseDown(ByVal sender As Object, _
    '                                        ByVal e As MouseEventArgs) Handles Table1.MouseDown

    '    ' If the user right-clicks a cell, store it for use by the  
    '    ' shortcut menu. 
    '    If e.Button = MouseButtons.Right Then
    '        Dim hit As DataGridView.HitTestInfo = _
    '            Table1.HitTest(e.X, e.Y)
    '        If hit.Type = DataGridViewHitTestType.Cell Then
    '            clickedCell = _
    '                Table1.Rows(hit.RowIndex).Cells(hit.ColumnIndex)
    '        End If
    '    End If

    'End Sub

    'Private Sub ShortcutMenuClick(ByVal sender As Object, _
    '                                            ByVal e As System.EventArgs)

    '    If (clickedCell IsNot Nothing) Then
    '        'Retrieve the recipe name. 
    '        Dim recipeName As String = CStr(clickedCell.Value)

    '        'Search for the recipe.
    '        System.Diagnostics.Process.Start( _
    '            "http://search.msn.com/results.aspx?q=" + recipeName)
    '    End If

    'End Sub

    Private Sub TxtSerie_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSerie.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtNumero_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumero.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboTipoDocu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDocu.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtNumero_LostFocus(sender As Object, e As System.EventArgs) Handles TxtNumero.LostFocus
        TxtNumero.Text = Microsoft.VisualBasic.Right("0000000" + Trim(TxtNumero.Text), 7)
    End Sub

    Private Sub TxtSerie_LostFocus(sender As Object, e As System.EventArgs) Handles TxtSerie.LostFocus
        TxtSerie.Text = Microsoft.VisualBasic.Right("0000" + Trim(TxtSerie.Text), 4)
    End Sub
End Class