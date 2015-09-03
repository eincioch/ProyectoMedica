Option Explicit On
Imports Integration.BE
Imports Integration.BL

Public Class FormCtaCteNumeracionC

    Dim nFlag As Integer

    Dim Request As New [Interface].BE_ReqInterface
    Dim Obj As New BL_Interface

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False
        If CboCaja.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label1.Text, CboCaja)
            Exit Function
        ElseIf CboTDocu.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label2.Text, CboTDocu)
            Exit Function
        ElseIf TxtSerie.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label4.Text, TxtSerie)
            Exit Function
        ElseIf TxtCorrActual.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label3.Text, TxtCorrActual)
            Exit Function
        ElseIf TxtCorrIni.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label5.Text, TxtCorrIni)
            Exit Function
        ElseIf TxtCorrFin.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label6.Text, TxtCorrFin)
            Exit Function
        End If
        ValidaCamposObligatorios = True

    End Function

    Private Sub Inicializa()

        Dim RequestCtaCte As New CtasCtes.BE_ReqCtaCteNumeracion
        Dim ObjCtaCteNum As New BL_CtaCteNumeracion

        LlenaDataCombo(CboCaja, ObjConst.Get_Constante("C", CboCaja.Tag), "nConValor", "cConDescripcion")

        LlenaDataCombo(CboTDocu, Obj.Get_Interface(CLng(TokenByKey(CboTDocu.Tag, "nIntClase")), CLng(TokenByKey(CboTDocu.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")

        'Llena Grid
        RequestCtaCte.cPerJurCodigo = StrcPerJuridica
        Table1.DataSource = ObjCtaCteNum.Get_CtaCteNumeracion(RequestCtaCte)

    End Sub

    Private Sub FormCtaCteNumeracionC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, False, 30)
        Call Inicializa()
        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        nFlag = 0
        TxtSerie.Text = vbNullString : TxtCorrActual.Text = vbNullString : TxtCorrIni.Text = vbNullString : TxtCorrFin.Text = vbNullString
        Table1.Enabled = False : GrpBox.Visible = True
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        CboCaja.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancel.Click

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)
        Call Inicializa()
        Table1.Enabled = True : GrpBxKey.Enabled = True

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click

        Try
            Dim RequestCtaCte As New CtasCtes.BE_ReqCtaCteNumeracion
            Dim ObjCtaCteNum As New BL_CtaCteNumeracion
            Dim Response As New BE_ResGenerico

            Dim Resultado As Long

            If ValidaCamposObligatorios() Then

                RequestCtaCte.cPerJurCodigo = StrcPerJuridica
                RequestCtaCte.nCajCodigo = CboCaja.SelectedValue
                RequestCtaCte.nComCodigo = CboTDocu.SelectedValue
                RequestCtaCte.nCtaCteNumero = TxtCorrActual.Text
                RequestCtaCte.cCtaCteSerie = TxtSerie.Text
                RequestCtaCte.nCtaCteNumIni = TxtCorrIni.Text
                RequestCtaCte.nCtaCtaNumFin = TxtCorrFin.Text

                If nFlag = 0 Then
                    REM insert
                    Response = ObjCtaCteNum.InsCtaCteNumeracion(RequestCtaCte)
                    Resultado = Response.Resultado

                ElseIf nFlag = 1 Then
                    REM update
                    Response = ObjCtaCteNum.UpdCtaCteNumeracion(RequestCtaCte)
                    Resultado = Response.Resultado
                End If

                If Resultado <> 0 Then
                    MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call c1CmdCancel_Click(C1CmdCancel, Nothing)
                    'Else
                    '    MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Table1_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting

        '-----------------------
        '-- Combinando Column 3 
        '-----------------------
        If e.ColumnIndex = 3 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.Table1.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell   
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)   
                    'If next row cell has different content, only draw bottom border line of current cell   
                    If e.RowIndex < Table1.Rows.Count - 2 AndAlso Table1.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell   
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells   
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso Table1.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If

    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                CboCaja.SelectedValue = .Item(2, .CurrentRow.Index).Value.ToString
                CboTDocu.SelectedValue = .Item(4, .CurrentRow.Index).Value.ToString
                TxtSerie.Text = .Item(7, .CurrentRow.Index).Value.ToString
                TxtCorrActual.Text = .Item(6, .CurrentRow.Index).Value.ToString
                TxtCorrIni.Text = .Item(8, .CurrentRow.Index).Value.ToString
                TxtCorrFin.Text = .Item(9, .CurrentRow.Index).Value.ToString
            End If
        End With

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        'If LblnConValor.Text = vbNullString Then
        '    MessageBox.Show("Selecciona un item de la grilla para modificar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        nFlag = 1
        Table1.Enabled = False : GrpBxKey.Enabled = False

    End Sub

    Private Sub TxtSerie_LostFocus(sender As Object, e As System.EventArgs) Handles TxtSerie.LostFocus

        TxtSerie.Text = Microsoft.VisualBasic.Right("0000" & TxtSerie.Text, 4)

    End Sub

    Private Sub TxtCorrActual_LostFocus(sender As System.Object, e As System.EventArgs) Handles TxtCorrActual.LostFocus
        TxtCorrActual.Text = Microsoft.VisualBasic.Right("00000000" & TxtCorrActual.Text, 8)
    End Sub

    Private Sub TxtCorrIni_LostFocus(sender As System.Object, e As System.EventArgs) Handles TxtCorrIni.LostFocus
        TxtCorrIni.Text = Microsoft.VisualBasic.Right("00000000" & TxtCorrIni.Text, 8)
    End Sub

    Private Sub TxtCorrFin_LostFocus(sender As System.Object, e As System.EventArgs) Handles TxtCorrFin.LostFocus
        TxtCorrFin.Text = Microsoft.VisualBasic.Right("00000000" & TxtCorrFin.Text, 8)
    End Sub

End Class