Option Explicit On
Imports Integration.BE
Imports Integration.BL

Public Class FormMaImpuestoPais

    Dim nFlag As Integer

    Dim Request As New BE.Sistema.BE_ReqSysConTasImpuesto
    Dim ObjImp As New BL.BL_Sistema

    Function ValidarCampos() As Boolean

        ValidarCampos = False
        If CboPais.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label4.Text, CboPais)
            Exit Function
        End If
        If TxtDesc.Text = vbNullString Or Len(Trim(TxtDesc.Text)) = 0 Then
            MsgInfoCampoObligatorio(Label3.Text, TxtDesc)
            Exit Function
        End If
        If TxtnIntClase.Text = vbNullString Or Len(Trim(TxtnIntClase.Text)) = 0 Then
            MsgInfoCampoObligatorio(Label1.Text, TxtnIntClase)
            Exit Function
        End If
        If Len(TxtTasaImp.Text) = 0 Then TxtTasaImp.Text = 0
        If CDbl(TxtTasaImp.Text) <= 0 Or Len(TxtTasaImp.Text) = 0 Then
            MsgInfoCampoObligatorio(Label2.Text, TxtTasaImp)
            Exit Function
        End If
        ValidarCampos = True

    End Function

    Private Sub FillGrilla()

        Request.nSysTasContry = CboPais.SelectedValue
        Table1.DataSource = ObjImp.Get_SysConTasImpuesto(Request)

    End Sub

    Private Sub FormMaImpuestoPais_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'llena cbo paises
        LlenaDataCombo(CboPais, ObjInterface.Get_Interface(CLng(TokenByKey(CboPais.Tag, "nIntClase")), CLng(TokenByKey(CboPais.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)

        FormatGrilla(Table1, Me, True, 32, False)
        CboPais.SelectedValue = 9256

        FillGrilla()

    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                CboPais.SelectedValue = .Item(0, .CurrentRow.Index).Value.ToString 'nSysTasContry
                DtpFecha.Value = FormatDateTime(.Item(3, .CurrentRow.Index).Value.ToString, DateFormat.ShortDate)
                TxtDesc.Text = .Item(4, .CurrentRow.Index).Value.ToString 'cSysTasDescripcion
                TxtnIntClase.Text = .Item(5, .CurrentRow.Index).Value.ToString 'cSysTasNombre(siglas)
                TxtTasaImp.Text = .Item(6, .CurrentRow.Index).Value.ToString 'fSysTasValor
            End If
        End With

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        nFlag = 0
        CboPais.SelectedIndex = -1 : TxtnIntClase.Text = vbNullString : TxtDesc.Text = vbNullString : Table1.Enabled = False
        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        CboPais.SelectedValue = 9256
        TxtDesc.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)
        FillGrilla()
        Table1.Enabled = True : TxtDesc.Enabled = True : TxtnIntClase.Enabled = True

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try
            If ValidarCampos() Then

                Dim Response As New BE_ResGenerico
                Dim Resultado As Long

                Request.nSysTasContry = CboPais.SelectedValue
                Request.nSysTasFecha = FormatDateTime(DtpFecha.Value, DateFormat.ShortDate).ToString
                Request.cSysTasDescripcion = Trim(TxtDesc.Text)
                Request.cSysTasNombre = Trim(TxtnIntClase.Text)
                Request.fSysTasValor = CDbl(TxtTasaImp.Text)

                If nFlag = 0 Then
                    REM insert
                    Request.nSysTasCodigo = 0
                    Response = ObjImp.Set_SysConTasImpuesto(Request)
                    Resultado = Response.Resultado

                ElseIf nFlag = 1 Then
                    'REM insert con fecha efectiva DE CAMBIO
                    Request.nSysTasCodigo = Table1.Item(2, Table1.CurrentRow.Index).Value
                    Response = ObjImp.Set_SysConTasImpuesto(Request)
                    Resultado = Response.Resultado
                End If

                If Resultado <> 0 Then
                    MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call c1CmdCancel_Click(c1CmdCancel, Nothing)
                    'Else
                    '    MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If TxtDesc.Text = vbNullString Then
            MessageBox.Show("Selecciona un Item de la grilla para modificar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        nFlag = 1
        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        TxtDesc.Enabled = False : TxtnIntClase.Enabled = False
        Table1.Enabled = False : TxtnIntClase.Focus()

    End Sub

    Private Sub TxtnIntClase_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtnIntClase.KeyPress, TxtDesc.KeyPress, TxtTasaImp.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboPais_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboPais.SelectionChangeCommitted

        FillGrilla()

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

End Class