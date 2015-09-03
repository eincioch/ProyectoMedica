Option Explicit On

Imports Integration.BE
Imports Integration.BL

Public Class FormMaSysJuridica

    Dim ObjADO As New Integration.DataIntegration.ClsADONET
    Dim StrSQl As String = ""
    Dim Resultado As Long

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False
        If CboTipoPer.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label5.Text, CboTipoPer)
            Exit Function
        ElseIf CboTipoDocu.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label7.Text, CboTipoDocu)
            Exit Function
        ElseIf TxtNroFind.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label1.Text, TxtNroFind)
            Exit Function
        ElseIf LblcPerCodigo.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label3.Text, TxtNroFind)
            Exit Function
        ElseIf LblcNombre.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label3.Text, TxtNroFind)
            Exit Function
        ElseIf LblcPerCodPer.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label2.Text, BtnAgregarPersona)
            Exit Function
        End If
        ValidaCamposObligatorios = True

    End Function

    Private Sub FormMaSysJuridica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")
        CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica

        LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerJuridica)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboTEmp, ObjConst.Get_Constante("C", CLng(CboTEmp.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboSectorE, ObjConst.Get_Constante("C", CLng(CboSectorE.Tag)), "nConValor", "cConDescripcion")

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)
        CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC
    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try
            Dim Request As New Sistema.BE_ReqSistema
            Dim ObjSys As New BL_Sistema
            Dim Response As New BE_ResGenerico

            If ValidaCamposObligatorios() Then

                Request.cPerCodigo = LblcPerCodigo.Text
                Request.cPerJurRepCodigo = LblcPerCodPer.Text
                Request.nPerJurTipInversion = CboTEmp.SelectedValue
                Request.nPerJurSecEconomico = CboSectorE.SelectedValue
                Response = ObjSys.Set_EmpresaSys(Request)
                Resultado = Response.Resultado

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

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True)
        CboTipoPer.Focus()

    End Sub

    Private Sub TxtNroFind_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFind.KeyPress

        Dim Request As New Persona.BE_ReqPersonaSearh
        Dim ObjPer As New BL_Persona

        Dim StrFilNroDocu As String = ""
        If TxtNroFind.Text = vbNullString Or Len(TxtNroFind.Text) <= 2 Then Exit Sub
        StrFilNroDocu = TxtNroFind.Text

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = CboTipoPer.SelectedValue

            If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

            If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
                LblcPerCodigo.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
                LblcNombre.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")

                CboTEmp.SelectedValue = ObjPer.Get_SearhPersona(Request).Rows(0)("nPerJurTipInversion")
                CboSectorE.SelectedValue = ObjPer.Get_SearhPersona(Request).Rows(0)("nPerJurSecEconomico")

            Else
                MessageBox.Show("Empresa No Existe.", "Buscando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        StrSQl = "DELETE FROM pi " &
                    "FROM PERSONA P " & _
                     "INNER JOIN PerIdentIFica Pi " & _
                      "on p.cPerCodigo = pi.cPerCodigo " & _
                       "and pi.nPerIdeTipo = 9000 and pi.cPerCodigo = '" & Trim(LblcPerCodigo.Text) & "'"

        If ValidaCamposObligatorios() Then
            Resultado = ObjADO.ExecutaSQLIUD(StrSQl)
            If Resultado <> 0 Then
                MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call c1CmdCancel_Click(c1CmdCancel, Nothing)
            Else
                MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click

        nAccionBotones = nAccionButton.nAccionNuevo
        FormMaPersona.Width = 435
        nFormPerPredeterminado = nConTipoPersona.nPerJuridica
        FormMaPersona.ShowDialog()
        If StrPasaValores <> vbNullString Then
            LblcPerCodigo.Text = TokenByKey(StrPasaValores, "cPerCodigo")
            TxtNroFind.Text = TokenByKey(StrPasaValores, "cPerIdeNumero")
            LblcNombre.Text = TokenByKey(StrPasaValores, "cNombCompleto")
            CboTEmp.SelectedValue = TokenByKey(StrPasaValores, "nPerJurTipInversion")
            CboSectorE.SelectedValue = TokenByKey(StrPasaValores, "nPerJurSecEconomico")
        End If
        TxtNroFind.Focus()

    End Sub

    Private Sub BtnAgregarPersona_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregarPersona.Click

        nAccionBotones = nAccionButton.nAccionNuevo
        FormMaPersona.Width = 435
        nFormPerPredeterminado = nConTipoPersona.nPerNatural
        FormMaPersona.ShowDialog()
        If StrPasaValores <> vbNullString Then
            LblcPerCodPer.Text = TokenByKey(StrPasaValores, "cPerCodigo")
            LblcNomRepre.Text = TokenByKey(StrPasaValores, "cNombCompleto")
        End If
        TxtNroPer.Focus()

    End Sub

    Private Sub TxtNroPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroPer.KeyPress

        Dim Request As New Persona.BE_ReqPersonaSearh
        Dim ObjPer As New BL_Persona

        Dim StrFilNroDocu As String = ""
        If TxtNroPer.Text = vbNullString Or Len(TxtNroPer.Text) <= 2 Then Exit Sub
        StrFilNroDocu = TxtNroPer.Text

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = nConTipoPersona.nPerNatural

            If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

            If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
                LblcPerCodPer.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
                LblcNomRepre.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")
            Else
                MessageBox.Show("Persona No Existe.", "Buscando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

End Class