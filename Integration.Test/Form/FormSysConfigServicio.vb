Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCtes

Public Class FormSysConfigServicio

    Dim nFlag As Integer

    Private Sub FillGrilla()

        Dim RequestSysConfServ As New BE_ReqCtaCteSysConfigParamterServicio
        Dim DaSysConfParamServ As New BL_CtaCteSysConfigParamterServicio

        RequestSysConfServ.cPerJurCodigo = StrcPerJuridica
        RequestSysConfServ.nSisModulo = 7001 'por defecto
        RequestSysConfServ.nParCodigo_nProCodigo = CboPrograma.SelectedValue
        RequestSysConfServ.nParCodigo_nSolAdmTipo = CboModalidad.SelectedValue
        RequestSysConfServ.nParCodigo_nCtaCteSerCodigo = CboServ.SelectedValue

        Table1.DataSource = DaSysConfParamServ.Get_SysConfParametrosServ(RequestSysConfServ)

    End Sub

    Private Sub FormSysConfigServicio_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load

        'Interface: grupo /Programa
        LlenaDataCombo(CboPrograma, ObjInterface.Get_Interface(CLng(TokenByKey(CboPrograma.Tag, "nIntClase")), CLng(TokenByKey(CboPrograma.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")
        'modalidad
        LlenaDataCombo(CboModalidad, ObjInterface.Get_Interface(CLng(TokenByKey(CboModalidad.Tag, "nIntClase")), CLng(TokenByKey(CboModalidad.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")

        LlenaDataCombo(CboTipoCta, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoCta.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)
        '
        FormatGrilla(Table1, Me, False, 30, False, DataGridViewSelectionMode.FullRowSelect)

        FillGrilla()

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        nFlag = 0
        TxtImporte.Text = CDbl(0.0)
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        Table1.Enabled = False : CboPrograma.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancel.Click

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)
        FillGrilla()
        Table1.Enabled = True

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click

        Try
            Dim InsertRegistro As Boolean
            Dim RequestSysConfServ As New BE_ReqCtaCteSysConfigParamterServicio
            Dim DaSysConfParamServ As New BL_CtaCteSysConfigParamterServicio

            RequestSysConfServ.cPerJurCodigo = StrcPerJuridica
            RequestSysConfServ.nSisModulo = 7001 'por defecto
            RequestSysConfServ.nParCodigo_nProCodigo = CboPrograma.SelectedValue
            RequestSysConfServ.nParCodigo_nSolAdmTipo = CboModalidad.SelectedValue
            RequestSysConfServ.nParCodigo_nCtaCteSerCodigo = CboServ.SelectedValue
            RequestSysConfServ.nSysValor = CDbl(TxtImporte.Text)
            RequestSysConfServ.nSysEstado = IIf(ChBoxEstado.Checked, 1, 0) '1=Activo ; 0=Inaptivo

            REM insert
            If nFlag = 0 Then InsertRegistro = DaSysConfParamServ.Ins_SysConfParametrosServ(RequestSysConfServ)

            'If nFlag = 1 Then
            '    REM update
            '    RequestSysConfServ.nSequencia = Table1.Item(3, Table1.CurrentRow.Index).Value
            '    InsertRegistro = DaSysConfParamServ.Upd_SysConfParametrosServ(RequestSysConfServ)
            'End If

            If InsertRegistro Then
                MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call c1CmdCancel_Click(C1CmdCancel, Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If CboPrograma.Text = vbNullString Then
            MessageBox.Show("Selecciona un Item de la grilla para modificar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        nFlag = 1
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        Table1.Enabled = False : CboPrograma.Focus()

    End Sub

    Private Sub TxtDesc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImporte.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub


    Private Sub CboTMoneda_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                CboPrograma.SelectedValue = .Item("nParCodigo_nProCodigo", .CurrentRow.Index).Value.ToString
                CboModalidad.SelectedValue = .Item("nParCodigo_nSolAdmTipo", .CurrentRow.Index).Value.ToString
                CboModalidad.SelectedValue = .Item("nParCodigo_nSolAdmTipo", .CurrentRow.Index).Value.ToString
                CboTipoCta.SelectedValue = .Item("nCtaCteTipoCta", .CurrentRow.Index).Value.ToString
                CboServ.SelectedValue = .Item("nParCodigo_nCtaCteSerCodigo", .CurrentRow.Index).Value.ToString
                TxtImporte.Text = FormatNumber(.Item("nSysValor", .CurrentRow.Index).Value, True)
            End If
        End With

    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoCta.SelectionChangeCommitted

        Dim ReqCtaCteServBusca As New BE_ReqCtaCteServBusca
        Dim daCtaCteServBusca As New BL_CtaCtaServicio

        ReqCtaCteServBusca.cPerJurCodigo = StrcPerJuridica
        ReqCtaCteServBusca.nCtaCteSerCodigo = vbNullString
        ReqCtaCteServBusca.nFlag = "TCTA"
        ReqCtaCteServBusca.nCtaCteTipoCta = CLng(CboTipoCta.SelectedValue)

        LlenaDataCombo(CboServ, daCtaCteServBusca.Get_CtaCteServicio(ReqCtaCteServBusca), "nCtaCteSerCodigo", "cIntDescripcion")

        If daCtaCteServBusca.Get_CtaCteServicio(ReqCtaCteServBusca).Rows.Count > 0 Then
            CboServ_SelectionChangeCommitted(CboServ, Nothing)
        End If

    End Sub

    Private Sub CboServ_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboServ.SelectionChangeCommitted

        Dim BL As New BL_CtaCtaServicio
        TxtImporte.Text = FormatNumber(BL.Get_CtaCteServicio_nCtaCteSerImpDef(StrcPerJuridica, CLng(CboServ.SelectedValue)), True)

    End Sub

    Private Sub FormSysConfigServicio_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        Table1.Width = Width - 35
        Table1.Height = Height - 236

    End Sub

End Class