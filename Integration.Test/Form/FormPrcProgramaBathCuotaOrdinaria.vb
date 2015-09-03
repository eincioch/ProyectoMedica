Option Explicit On
Imports Integration.BE
Imports Integration.BE.Documento
Imports Integration.BE.CtasCtes
Imports Integration.BL
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.Documento

Public Class FormPrcProgramaBathCuotaOrdinaria

    Public Sub BuscaPersona()

        Dim Request As New Persona.BE_ReqPersonaSearh
        Dim ObjPer As New BL_Persona

        Dim StrFilNroDocu As String = ""
        If TxtNroFind.Text = vbNullString Or Len(TxtNroFind.Text) <= 2 Then Exit Sub
        StrFilNroDocu = TxtNroFind.Text

        Request.cNombre = "Nulo"
        Request.cPerIdeNumero = StrFilNroDocu
        Request.nPerTipo = 1 '//--CboTipoPer.SelectedValue

        If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

        If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
            LblcPerCodigo.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
            LblcNombre.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")
        Else
            MessageBox.Show("Persona no se encuentra registrada en el sistema.", "Buscando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function GetNewIdcDocCodigo(ByVal sFiltro As String) As String

        Dim Request As New BE.Documento.BE_GeneraNewIdcDocCodigo
        Dim ObjNewcDocCodigo As New BL_GeneraNewIdcDocCodigo

        Request.cPerJurCodigo = StrcPerJuridica
        Return ObjNewcDocCodigo.Get_NewIdcDocCodigo(Request)

    End Function

    Private Sub FormPrcProgramaBathCuotaOrdinaria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim Request As New Sistema.BE_ReqPeriodo
        Dim Obj As New BL_Sistema

        'Llena Año
        Request.cPerJurCodigo = StrcPerJuridica
        Request.cflag = "A" 'Año
        Request.cAnno = ""
        LlenaDataCombo(CboPeriodo, Obj.Get_Periodo(Request), "nPrdCodigo", "cPrdDescripcion")

        LlenaDataCombo(CboMes, ObjConst.Get_Constante("C", 1005), "nConValor", "cConDescripcion")

        LlenaDataCombo(CboTipoCta, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoCta.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        CboTipoCta_SelectionChangeCommitted(CboTipoCta, Nothing)

        CboTipoCta.SelectedValue = 1001 'x Default CUOTAS ORDINARIAS

        CboServicios_SelectionChangeCommitted(CboServicios, Nothing)

    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoCta.SelectionChangeCommitted

        Dim Request As New BE_ReqCtaCteServBusca
        Dim DaServ As New BL_CtaCtaServicio

        Request.cPerJurCodigo = StrcPerJuridica
        Request.nFlag = "TCTA"

        Request.nCtaCteTipoCta() = CboTipoCta.SelectedValue
        LlenaDataCombo(CboServicios, DaServ.Get_CtaCteServicio(Request), "nCtaCteSerCodigo", "cIntDescripcion")

    End Sub

    Private Sub BtnProgramar_Click(sender As System.Object, e As System.EventArgs) Handles BtnProgramar.Click

        Try

            If MessageBox.Show("Desea Generar " & CboServicios.Text & ".", "Confirmar..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                Dim BLProgBath As New BL_ProgramacionBath
                Dim Resultado As Boolean

                '//Cuota Ordinaria
                If CLng(CboServicios.SelectedValue) = CLng(BLInterfaceCFG.Get_Interface_CFG(1009, 1001)) Then _
                    Resultado = BLProgBath.Set_ProgramarCuotaOrdinaria(StrcPerJuridica, CLng(CboPeriodo.SelectedValue), _
                        CLng(CboServicios.SelectedValue), CLng(CboMes.SelectedValue), "", "", FormatDateTime(DtpFecFallecido.Value, DateFormat.ShortDate))

                '//Fondo Mortorio
                If CLng(CboServicios.SelectedValue) = CLng(BLInterfaceCFG.Get_Interface_CFG(1009, 1002)) Then _
                    Resultado = BLProgBath.Set_ProgramarCuotaOrdinaria(StrcPerJuridica, CLng(CboPeriodo.SelectedValue), _
                        CLng(CboServicios.SelectedValue), CLng(CboMes.SelectedValue), "", LblcPerCodigo.Text, DtpFecFallecido.Value)

                If Resultado Then MessageBox.Show("Programación se completo con éxito!.", "Procesando..", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Close()
        Dispose()

    End Sub

    Private Sub TxtNroFind_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFind.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaPersona()
        End If
    End Sub

    Private Sub CboServicios_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboServicios.SelectionChangeCommitted

        If CboServicios.SelectedValue = CLng(BLInterfaceCFG.Get_Interface_CFG(1009, 1001)) Then
            Height = 204
            Panel1.Location = New Point(312, 137)
            GrpBx2.Visible = False
        End If
        If CboServicios.SelectedValue = CLng(BLInterfaceCFG.Get_Interface_CFG(1009, 1002)) Then
            Height = 310
            Panel1.Location = New Point(309, 249)
            GrpBx2.Visible = True
            'genera cDocCodigo
            LblcDocCodigo.Text = GetNewIdcDocCodigo(StrcPerJuridica)
        End If
    End Sub

    'Private Sub ObtenerPrimerUltimoDia(Fecha As Date)

    '    Dim Primer As Date
    '    Dim Ultimo As Date

    '    'Usamos la funcion DAteSerial para obtener el primero y el ultimo dia
    '    Primer = DateSerial(Year(Fecha), Month(Fecha) + 0, 1)
    '    Ultimo = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)

    '    MsgBox(" Primer día : " & Primer & vbNewLine & _
    '           " Último día : " & Ultimo, vbInformation)

    '    For I = 1 To 12
    '        MsgBox(DateSerial(Year("01/01/" & CboPeriodo.Text), Month("01/" & Microsoft.VisualBasic.Right("00" & I.ToString, 2) & "/" & CboPeriodo.Text) + 1, 0))
    '    Next I

    '    'Call ObtenerPrimerUltimoDia("28/10/2013")

    'End Sub

End Class