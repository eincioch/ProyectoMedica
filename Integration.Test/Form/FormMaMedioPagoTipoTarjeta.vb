Option Explicit On

Imports Integration.BE
Imports Integration.BE.Persona
Imports Integration.BL

Public Class FormMaMedioPagoTipoTarjeta

    Dim nFlag As Integer REM nglag = 0 , Agregando, 1 = modificando
    Dim StrFiltro As String

    Private Function ValidarCampos() As Boolean

        ValidarCampos = False
        If CboBanco.SelectedIndex = -1 Then MsgInfoCampoObligatorio(Label1.Text, CboBanco) : Exit Function
        If CboTipoTarjeta.SelectedIndex = -1 Then MsgInfoCampoObligatorio(Label2.Text, CboTipoTarjeta) : Exit Function
        If TxtSiglas.Text = vbNullString Then MsgInfoCampoObligatorio(Label3.Text, TxtSiglas) : Exit Function
        If TxtDesc.Text = vbNullString Then MsgInfoCampoObligatorio(Label4.Text, TxtDesc) : Exit Function
        ValidarCampos = True

    End Function


    Private Sub ListaEntidadFinanciera()
        Dim ReqPerJurSecEco As New BE_ReqPerJurSecEconomico
        Dim DAPerJurSecEco As New BL_Persona

        ReqPerJurSecEco.cFlag = "EFI"
        LlenaDataCombo(CboBanco, DAPerJurSecEco.Get_PerJurTipInversion(ReqPerJurSecEco), "cPerCodigo", "cPerNombre")
    End Sub

    Private Sub FillDgv()

        Dim DA As New BL_PerInterface
        Table1.DataSource = DA.Get_PerInterface()

    End Sub

    Private Sub FormMaMedioPagoTipoTarjeta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, False, 30)

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)

        ListaEntidadFinanciera()

        LlenaDataCombo(CboTipoTarjeta, ObjInterface.Get_Interface(CLng(TokenByKey(CboTipoTarjeta.Tag, "nIntClase")), CLng(TokenByKey(CboTipoTarjeta.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")

        FillDgv()

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        nFlag = 0
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True)
        Table1.Enabled = False : CboBanco.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancel.Click

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)

        CboBanco.Enabled = True : CboTipoTarjeta.Enabled = True : Table1.Enabled = True : FillDgv()

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click

        Try
            Dim DA As New BL_PerInterface
            Dim Resultado As Boolean

            If ValidarCampos() Then
                If nFlag = 0 Then Resultado = DA.Ins_PerInterface(CboBanco.SelectedValue, CboTipoTarjeta.SelectedValue, 1023, FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), (TxtSiglas.Text & " " & CboTipoTarjeta.Text), TxtDesc.Text, 1000)

                If nFlag = 1 Then Resultado = DA.Upd_PerInterface(CboBanco.SelectedValue, CboTipoTarjeta.SelectedValue, 1023, (TxtSiglas.Text & " " & CboTipoTarjeta.Text), TxtDesc.Text, 1000)

                If Resultado Then
                    MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call c1CmdCancel_Click(C1CmdCancel, Nothing)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If TxtDesc.Text = vbNullString Then
            MessageBox.Show("Selecciona un item de la grilla para modificar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True)
        nFlag = 1 : CboBanco.Enabled = False : CboTipoTarjeta.Enabled = False : Table1.Enabled = False

    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                CboBanco.SelectedValue = .Item("cPerCodigo", .CurrentRow.Index).Value
                CboTipoTarjeta.SelectedValue = .Item("nPerIntCodigo", .CurrentRow.Index).Value
                TxtSiglas.Text = .Item("cPerIntJerarquia", .CurrentRow.Index).Value.ToString
                TxtDesc.Text = .Item("cPerIntDescripcion", .CurrentRow.Index).Value.ToString
            End If
        End With

    End Sub

    Private Sub BtnAgregarUNI_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregarUNI.Click

        Dim ReqPerJurSecEco As New BE_ReqPerJurSecEconomico
        Dim DAPerJurSecEco As New BL_Persona

        nAccionBotones = nAccionButton.nAccionNuevo
        FormMaPersona.Width = 435
        nFormPerPredeterminado = nConTipoPersona.nPerJuridica
        FormMaPersona.ShowDialog()

        ListaEntidadFinanciera()
        CboBanco.Focus()

    End Sub


End Class