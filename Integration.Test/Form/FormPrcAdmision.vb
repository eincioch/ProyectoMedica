Option Explicit On
Imports System.IO
Imports Integration.BE
Imports Integration.BL

Public Class FormPrcAdmision

    Dim RequestUNI As New Persona.BE_ReqPerJurSecEconomico
    Dim ObjUNI As New BL_Persona

    Dim nFlag As Integer REM nglag = 0 , Agregando, 1 = modificando
    Dim ObjImage As New Integration.DataIntegration.ImageClass

    Private Sub InicializarForm()
        LblcPerCodigo.Text = vbNullString
        LblcNombre.Text = vbNullString
        LblNroSolicitud.Text = vbNullString
        LimpiarTextBox(Me)
    End Sub

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False
        If CboTipoPer.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label5.Text, CboTipoPer)
            Exit Function
        ElseIf CboTipoDocu.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label11.Text, CboTipoDocu)
            Exit Function
        ElseIf TxtNroFind.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label1.Text, TxtNroFind)
            Exit Function
        ElseIf LblcPerCodigo.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label2.Text, TxtNroFind)
            Exit Function
        ElseIf LblcNombre.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label3.Text, TxtNroFind)
            Exit Function
        ElseIf CboPrograma.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label6.Text, CboPrograma)
            Exit Function
        ElseIf CboModalidad.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label9.Text, CboModalidad)
            Exit Function
        ElseIf LblNroSolicitud.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label8.Text, TxtNroFind)
            Exit Function
        ElseIf CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
            If CboListaUNI.SelectedIndex = -1 Then
                MsgInfoCampoObligatorio(Label11.Text, CboListaUNI)
                Exit Function
            ElseIf CboEspecialidad.SelectedIndex = -1 Then
                MsgInfoCampoObligatorio(Label12.Text, CboEspecialidad)
                Exit Function
            End If
        End If
        ValidaCamposObligatorios = True

    End Function

    Public Sub BuscaPersona()

        Dim Request As New Persona.BE_ReqPersonaSearh
        Dim ObjPer As New BL_Persona

        Dim StrFilNroDocu As String = ""
        If TxtNroFind.Text = vbNullString Or Len(TxtNroFind.Text) <= 2 Then Exit Sub
        StrFilNroDocu = TxtNroFind.Text

        Request.cNombre = "Nulo"
        Request.cPerIdeNumero = StrFilNroDocu
        Request.nPerTipo = CboTipoPer.SelectedValue

        If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

        If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
            LblcPerCodigo.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
            LblcNombre.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")

            '//Validar si ya esta colegiado (no se puede colegiar 2 veces obvio)
            Dim BL As New BL_Sistema
            If Not BL.Get_ValidarCondicion("PerIdentifica", "cPerIdeNumero", "nPerIdeTipo = 29 AND cPerCodigo = " & LblcPerCodigo.Text) Then
                MessageBox.Show("Persona " & LblcNombre.Text & " ya se encuentra Colegiado(a), NO se puede volver a Colegiar.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LblcPerCodigo.Text = vbNullString : LblcNombre.Text = vbNullString
                c1CmdCancel_Click(c1CmdCancel, Nothing)
                Exit Sub
            End If
            '//

            'recupero la foto si tiene
            RequestImg.cPerCodigo = LblcPerCodigo.Text
            RequestImg.cUltimaPhoto = "A"

            If ObjImg.Get_PerImagen(RequestImg).Rows.Count > 0 Then
                PctrBoxFoto.BackgroundImage = ObtenerPhoto(ObjImg.Get_PerImagen(RequestImg).Rows(0)("iPerImaFoto"))
            End If
        Else
            If MessageBox.Show("Persona no se encuentra registrada en el sistema. ¿Desea registrar a la persona.?", "Buscando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call BtnAgregar_Click(BtnAgregar, Nothing)
            End If
        End If

    End Sub

    Private Function GetCorrelativo(ByVal sFiltro As String) As String

        Dim Request As New BE.Solicitud.BE_ReqSolCorrelativo
        Dim ObjBL As New BL_Solicitud

        Request.cPerCodigo = sFiltro
        Return ObjBL.Get_Correlativo_Sol(Request)

    End Function

    Private Sub ObtenerSolicitud()
        Try
            'Recuperar Solicitud en pantalla
            Dim Request As New Solicitud.BE_ReqSolRegistro
            Dim Obj As New BL_Solicitud

            Request.nSolAdmNumero = TokenByKey(StrPasaValores, "nSolAdmNumero")

            If Obj.Get_AdmSolicitudAcademica(Request).Rows.Count > 0 Then
                CboTipoPer.SelectedValue = Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("nPerTipo")
                CboTipoDocu.SelectedValue = Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("nPerIdeTipo")
                TxtNroFind.Text = Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("cPerIdeNumero")
                Call BuscaPersona()
                LblNroSolicitud.Text = Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("nSolAdmNumero")
                CboListaUNI.SelectedValue = Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("cPerJurCodigo")
                CboPrograma.SelectedValue = Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("nProCodigo")
                DtpFecCole.Value = FormatDateTime(Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("dAdmSolAcaFecEgreso"), DateFormat.ShortDate)
                CboEspecialidad.SelectedValue = Obj.Get_AdmSolicitudAcademica(Request).Rows(0)("nAdmSolEspCodigo")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub FormPrcAdmision_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")

        'Interface: 1002-1000
        LlenaDataCombo(CboPrograma, ObjInterface.Get_Interface(CLng(TokenByKey(CboPrograma.Tag, "nIntClase")), CLng(TokenByKey(CboPrograma.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")

        'modalidad
        LlenaDataCombo(CboModalidad, ObjInterface.Get_Interface(CLng(TokenByKey(CboModalidad.Tag, "nIntClase")), CLng(TokenByKey(CboModalidad.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")

        'LlenaCombo(CboListaUNI, "Select cPerCodigo, cPerNombre FROM PerJuridicaUniversidad ", "cPerCodigo", "cPerNombre")
        RequestUNI.cFlag = "UNI"
        LlenaDataCombo(CboListaUNI, ObjUNI.Get_PerJurTipInversion(RequestUNI), "cPerCodigo", "cPerNombre")

        LlenaDataCombo(CboEspecialidad, ObjConst.Get_Constante("C", CLng(CboEspecialidad.Tag)), "nConValor", "cConDescripcion")

        CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI
        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)

        If nOperacion = 2 Then 'Modificando
            ObtenerSolicitud()
            'Call C1CmdEdit_Click(C1CmdEdit, Nothing)
            'Se comento porque puede modificar o Generar cargo
        Else
            Call c1CmdNuevo_Click(c1CmdNuevo, Nothing)
        End If

    End Sub

    Private Sub CboTipoPer_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoPer.SelectionChangeCommitted

        If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
            REM 1013 natural
            LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")

            CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI
            Label3.Text = "Apellidos y Nombre(s):"
            GrpBoxDatoAcademico.Enabled = True
        ElseIf CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            REM 1012 juridica
            LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerJuridica)), "nConValor", "cConDescripcion")

            Label3.Text = "Razon Social:"
            GrpBoxDatoAcademico.Enabled = False
        End If
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        nOperacion = 0
        Close()
        Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)
        BtnGeneraCargo.Visible = True : CboPrograma.Enabled = True

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        nFlag = 0
        InicializarForm()

        'correlativo solicitud
        LblNroSolicitud.Text = GetCorrelativo(StrcPerJuridica)

        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True)
        BtnGeneraCargo.Visible = False : CboTipoPer.Focus()

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try
            Dim Request As New BE.Solicitud.BE_ReqSolRegistro
            Dim ObjBL As New BL_Solicitud

            Dim StrSQl As String = ""
            Dim ResultadOperacion As Boolean

            If ValidaCamposObligatorios() Then

                Request.cPerJuridica = StrcPerJuridica
                Request.nProCodigo = CboPrograma.SelectedValue
                Request.nSolAdmNumero = LblNroSolicitud.Text
                Request.cPerCodigo = LblcPerCodigo.Text
                Request.nPerAdmEstado = 0
                Request.dPerAdmRegistro = FormatDateTime(dFechaSistema, DateFormat.ShortDate)
                Request.nPrdCodigo = FormMDI.CboAnno.SelectedValue 'Periodo Actual AÑO
                Request.cPerJurCodigo = CboListaUNI.SelectedValue
                Request.dAdmSolAcaFecEgreso = FormatDateTime(DtpFecCole.Value, DateFormat.ShortDate)
                Request.nAdmSolEspCodigo = CboEspecialidad.SelectedValue
                Request.nSolAdmEstado = 0
                Request.nSolAdmTipo = CboModalidad.SelectedValue

                'Agregando
                If nFlag = 0 Then
                    If MessageBox.Show("¿Desea grabar nueva solicitud.?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        ResultadOperacion = ObjBL.RegistrarSolicitud(Request)
                    End If
                End If

                'Actualizando
                If nFlag = 1 Then
                    ResultadOperacion = ObjBL.Upd_AdmSolicitudAcademica(Request)
                End If

                If ResultadOperacion Then
                    MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Call c1CmdCancel_Click(c1CmdCancel, Nothing)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnSubirFoto_Click(sender As System.Object, e As System.EventArgs) Handles BtnSubirFoto.Click

        'Dim RequestImg As New Persona.BE_ReqPerPhoto
        'Dim ObjImg As New BL_Persona

        Dim Response As New BE_ResGenerico
        Dim Resultado As Long

        Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Title = "Buscando archivo - Foto"
                .Filter = "All Files|*.*|Tipos archivos (*)|*.bmp;*.gif;*.jpg;*.png"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    'PctrBoxFoto.ImageLocation = .FileName
                    PctrBoxFoto.BackgroundImage = Image.FromFile(.FileName)
                    PctrBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage

                    Dim ms As New MemoryStream()
                    PctrBoxFoto.BackgroundImage.Save(ms, PctrBoxFoto.BackgroundImage.RawFormat)
                    FieldFoto = ms.GetBuffer()

                    'validando si PctrBoxFoto esta VACIO
                    'If PctrBoxFoto.Image Is Nothing Then Exit Sub

                    'Resultado = ObjImage.Upd_InsertPerImagen(LblcPerCodigo.Text, 1, FieldFoto)
                    RequestImg.cPerCodigo = LblcPerCodigo.Text
                    RequestImg.nPerTipImagen = 1
                    RequestImg.iPerImaFoto = FieldFoto
                    Response = ObjImg.InsPerImagen(RequestImg)

                    Resultado = Response.Resultado

                    If Resultado <> 0 Then
                        MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Call c1CmdCancel_Click(c1CmdCancel, Nothing)
                    Else
                        MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If

            End With

        End Using

    End Sub

    Private Sub TxtNroFind_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFind.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaPersona()
        End If

    End Sub

    Private Sub BtnAgregarUNI_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregarUNI.Click

        nOperacion = 0
        nAccionBotones = nAccionButton.nAccionNuevo
        FormMaPersona.Width = 435
        nFormPerPredeterminado = nConTipoPersona.nPerJuridica
        FormMaPersona.ShowDialog()
        RequestUNI.cFlag = "UNI"
        LlenaDataCombo(CboListaUNI, ObjUNI.Get_PerJurTipInversion(RequestUNI), "cPerCodigo", "cPerNombre")
        CboListaUNI.Focus()

    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click

        nAccionBotones = nAccionButton.nAccionNuevo
        'nOperacion = 1
        FormMaPersona.Width = 435
        nFormPerPredeterminado = nConTipoPersona.nPerNatural
        FormMaPersona.TxtNroDocu.Text = TxtNroFind.Text
        FormMaPersona.ShowDialog()
        If StrPasaValores <> vbNullString Then
            LblcPerCodigo.Text = TokenByKey(StrPasaValores, "cPerCodigo")
            TxtNroFind.Text = TokenByKey(StrPasaValores, "cPerIdeNumero")
            LblcNombre.Text = TokenByKey(StrPasaValores, "cNombCompleto")
        End If
        TxtNroFind.Focus()

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        nFlag = 1

        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True)
        CboPrograma.Enabled = False : CboListaUNI.Focus()

    End Sub

    Private Sub BtnGeneraCargo_Click(sender As System.Object, e As System.EventArgs) Handles BtnGeneraCargo.Click

        Try
            Dim Resultado As Boolean
            Dim ObjGenCargo As New BL_CtaCtes.BL_CtaCteServicioFacturacion

            If TokenByKey(StrPasaValores, "cCtaCteRecibo") <> vbNullString Then
                MessageBox.Show("Ya se ha generado el cargo para la Solicitud Nro.: " & TokenByKey(StrPasaValores, "nSolAdmNumero"), "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Resultado = ObjGenCargo.Ins_GenerarCargoSolicitud(StrcPerJuridica, CboPrograma.SelectedValue, CboModalidad.SelectedValue, LblcPerCodigo.Text, FormMDI.CboAnno.SelectedValue, _
                                                  FormatDateTime(dFechaSistema.ToString & Space(1) & TimeOfDay, DateFormat.GeneralDate), LblNroSolicitud.Text)
            'correccion 28/01/2014
            'Resultado = ObjGenCargo.Ins_GenerarCargoSolicitud(StrcPerJuridica, CboPrograma.SelectedValue, LblcPerCodigo.Text, FormMDI.CboAnno.SelectedValue, _
            '                                      FormatDateTime(dFechaSistema.ToString & Space(1) & TimeOfDay, DateFormat.GeneralDate), LblNroSolicitud.Text)

            If Resultado Then
                MessageBox.Show("Se ha generado el cargo con éxito.", "Generando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'FormPrcAtenderSolicitudCole.BtnMostrar.PerformClick
                Close() : Dispose()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub


End Class