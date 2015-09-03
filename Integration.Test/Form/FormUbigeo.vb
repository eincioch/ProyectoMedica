Public Class FormUbigeo

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False
        If CboDpto.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label1.Text, CboDpto)
            Exit Function
        ElseIf CboPrv.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label2.Text, CboPrv)
            Exit Function
        ElseIf CboDst.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label3.Text, CboDst)
            Exit Function
        End If
        ValidaCamposObligatorios = True

    End Function

    Private Sub FormUbigeo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LlenaCombo(CboDpto, "select distinct cDptCodigo, cDptDescripcion  from ubigeo_2007 order by 2 ", "cDptCodigo", "cDptDescripcion")
        LlenaCombo(CboDst, "select distinct Codigo,cDptCodigo, cPrvCodigo ,cDisCodigo , cDisDescripcion  from ubigeo_2007 where cPrvCodigo  = '" & CboPrv.SelectedValue & "'order by 2", "Codigo", "cDisDescripcion")
        LlenaCombo(CboDst, "select distinct Codigo,cDptCodigo, cPrvCodigo ,cDisCodigo , cDisDescripcion  from ubigeo_2007 where cPrvCodigo  = '" & CboPrv.SelectedValue & "' order by 2", "Codigo", "cDisDescripcion")
        CboDpto.Focus()

    End Sub

    Private Sub CboDpto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboDpto.KeyPress, CboPrv.KeyPress, CboDst.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboDpto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboDpto.SelectedIndexChanged

        LlenaCombo(CboPrv, "select distinct cDptCodigo, cPrvCodigo ,cPrvDescripcion  from ubigeo_2007 where cDptCodigo = '" & CboDpto.SelectedValue & "'  order by 2", "cPrvCodigo", "cPrvDescripcion")

    End Sub

    Private Sub CboPrv_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboPrv.SelectedIndexChanged

        LlenaCombo(CboDst, "select distinct Codigo,cDptCodigo, cPrvCodigo ,cDisCodigo , cDisDescripcion  from ubigeo_2007 where cPrvCodigo  = '" & CboPrv.SelectedValue & "'  order by 2", "Codigo", "cDisDescripcion")

    End Sub

    Private Sub BtnSelecciona_Click(sender As System.Object, e As System.EventArgs) Handles BtnSelecciona.Click

        If ValidaCamposObligatorios() Then
            If nOperacion <> 0 Then
                FormMaPerMasDetalle.LblUbigeo.Text = CboDst.SelectedValue
            Else
                'MsgBox("aqui")
                FormMaPersona.LblUbigeo.Text = CboDst.SelectedValue
            End If

            If nAccionBotones = nAccionButton.nAccionNuevo Then
                FormMaPersona.LblUbigeo.Text = CboDst.SelectedValue
            End If


            Call BtnCancel_Click(BtnCancel, Nothing)
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class