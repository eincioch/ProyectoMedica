Option Explicit On

Imports Integration.BE
Imports Integration.BE.CtasCtes
Imports Integration.BL
Imports Integration.BL.BL_CtaCtes

Public Class FormPrcProgramarServicio

    Function ValidarCampos() As Boolean
        ValidarCampos = False
        If CboTipoCta.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label6.Text, CboTipoCta) : Exit Function
        If CboServicios.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label1.Text, CboServicios) : Exit Function
        If CboMoneda.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label7.Text, CboServicios) : Exit Function
        If CboMoneda.SelectedValue <> nTipoMoneda.nSoles Then
            If CDbl(LblTC.Text) <= 0 Then
                MsgInfoCampoObligatorio(Label8.Text, CboServicios) : Exit Function
            End If
        End If
        If CDbl(LblCostoServ.Text) <= 0 Then MsgInfoCampoObligatorio(Label3.Text, CboServicios) : Exit Function
        If CLng(TxtCantidad.Text) <= 0 Then MsgInfoCampoObligatorio(Label4.Text, CboServicios) : Exit Function
        If CDbl(LblTPagar.Text) <= 0 Then MsgInfoCampoObligatorio(Label5.Text, CboServicios) : Exit Function
        ValidarCampos = True
    End Function

    Private Sub FormPrcProgramarServicio_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F2))
                BtnProgServ_Click(BtnProgServ, Nothing)
        End Select

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        nOperacion = 0
        Close()
        Dispose()
    End Sub

    Private Sub FormPrcProgramarServicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If nOperacion = 1 Then LblTitulo.Text = "Generando nuevo recibo..." Else LblTitulo.Text = "Agregando Item (Servicio) al recibo actual seleccionado..."

        LlenaDataCombo(CboMoneda, ObjConst.Get_Constante("C", CLng(TokenByKey(CboMoneda.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")
        CboMoneda.SelectedValue = -1

        LlenaDataCombo(CboTipoCta, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoCta.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        CboTipoCta.SelectedValue = 1002 'Default Servicios

        CboTipoCta_SelectionChangeCommitted(CboTipoCta, Nothing)

        CboTipoCta.Focus()

    End Sub

    Private Sub CboTipoCta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoCta.KeyPress, CboServicios.KeyPress, CboMoneda.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")

    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoCta.SelectionChangeCommitted

        Dim Request As New BE_ReqCtaCteServBusca
        Dim DaServ As New BL_CtaCtaServicio

        Request.cPerJurCodigo = StrcPerJuridica
        Request.nFlag = "TCTA"

        Request.nCtaCteTipoCta() = CboTipoCta.SelectedValue
        LlenaDataCombo(CboServicios, DaServ.Get_CtaCteServicio(Request), "nCtaCteSerCodigo", "cIntDescripcion")

    End Sub

    Private Sub CboServicios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboServicios.SelectedIndexChanged

        Dim Request As New BE_ReqCtaCteServBusca
        Dim DaServ As New BL_CtaCtaServicio

        Request.cPerJurCodigo = StrcPerJuridica
        Request.nCtaCteSerCodigo = CLng(CboServicios.SelectedValue)
        Request.nFlag = "SERV"

        If DaServ.Get_CtaCteServicio(Request).Rows.Count > 0 Then
            CboMoneda.SelectedValue = CLng(DaServ.Get_CtaCteServicio(Request).Rows(0)("nMonCodigo"))
            LblCostoServ.Text = FormatNumber(CDbl(DaServ.Get_CtaCteServicio(Request).Rows(0)("nCtaCteSerImpDef")), True)
            If CboMoneda.SelectedValue <> nTipoMoneda.nSoles Then 'Dolar
                LblTC.Text = FormatNumber(CDbl(TipoCambio(CLng(CboMoneda.SelectedValue), "TCD", dFechaSistema)), True)
                LblTPagar.Text = FormatNumber((CDbl(DaServ.Get_CtaCteServicio(Request).Rows(0)("nCtaCteSerImpDef")) * TipoCambio(CLng(CboMoneda.SelectedValue), "TCD", dFechaSistema)), True)
            Else
                LblTPagar.Text = FormatNumber(CDbl(DaServ.Get_CtaCteServicio(Request).Rows(0)("nCtaCteSerImpDef")), True)
            End If
        End If

    End Sub

    Private Sub BtnProgServ_Click(sender As System.Object, e As System.EventArgs) Handles BtnProgServ.Click

        Dim Resultado As Boolean
        Dim DaCCItem As New BL_CtaCteServicioFacturacion
        Try
            If ValidarCampos() Then

                If nOperacion = 1 Then 'nuevo servicio
                    Resultado = DaCCItem.Ins_AgregarNuevoServicio(StrcPerJuridica, FormPrcFacturacion.LblcPerCodigo.Text, _
                                                      CLng(FormMDI.CboAnno.SelectedValue), FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), _
                                                      CLng(CboServicios.SelectedValue), CLng(TxtCantidad.Text), CDbl(LblCostoServ.Text), CDbl(LblTPagar.Text))
                End If

                If nOperacion = 2 Then 'nuevo Item
                    If BuscaCadenaDgView("nCtaCteSerCodigo", CboServicios.SelectedValue, FormPrcFacturacion.Table3) Then
                        MessageBox.Show("Servicio ya ha sido ingresado.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Resultado = DaCCItem.Ins_AgregarItemRecibo(StrcPerJuridica, FormPrcFacturacion.LblcPerCodigo.Text, _
                                                                        FormPrcFacturacion.LblNroRecibo.Text, CLng(CboServicios.SelectedValue), _
                                                                        FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), _
                                                                         CLng(TxtCantidad.Text), CDbl(LblCostoServ.Text), CDbl(LblTPagar.Text))
                    End If
                End If

                If Resultado Then
                    MessageBox.Show("Se Agrego nuevo servicio con éxito,", "Grabando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                    Dispose()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        e.Handled = TextBoxImporte(e, LblCostoServ)

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If CboMoneda.SelectedValue <> nTipoMoneda.nSoles Then
                LblTPagar.Text = FormatNumber((CDbl(TxtCantidad.Text) * CDbl(LblCostoServ.Text)) * CDbl(LblTC.Text), True)
            Else
                LblTPagar.Text = FormatNumber(CDbl(TxtCantidad.Text) * CDbl(LblCostoServ.Text), True)
            End If
        End If

    End Sub

    Private Sub TxtCantidad_LostFocus(sender As Object, e As System.EventArgs) Handles TxtCantidad.LostFocus
        If CboMoneda.SelectedValue <> nTipoMoneda.nSoles Then
            LblTPagar.Text = FormatNumber((CDbl(TxtCantidad.Text) * CDbl(LblCostoServ.Text)) * CDbl(LblTC.Text), True)
        Else
            LblTPagar.Text = FormatNumber(CDbl(TxtCantidad.Text) * CDbl(LblCostoServ.Text), True)
        End If
    End Sub

    Private Sub LblCostoServ_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles LblCostoServ.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        e.Handled = TextBoxImporte(e, LblCostoServ)

    End Sub

    Private Sub LblCostoServ_LostFocus(sender As Object, e As System.EventArgs) Handles LblCostoServ.LostFocus

        LblCostoServ.Text = FormatNumber(CDbl(LblCostoServ.Text), True)
        If CboMoneda.SelectedValue <> nTipoMoneda.nSoles Then
            LblTPagar.Text = FormatNumber((CDbl(TxtCantidad.Text) * CDbl(LblCostoServ.Text)) * CDbl(LblTC.Text), True)
        Else
            LblTPagar.Text = FormatNumber(CDbl(TxtCantidad.Text) * CDbl(LblCostoServ.Text), True)
        End If
    End Sub


End Class