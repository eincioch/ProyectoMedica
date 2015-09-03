Option Explicit On
Imports Integration.DataIntegration
Imports Integration.BE
Imports Integration.BE.Persona
Imports Integration.BL
Imports Integration.BL.BL_Persona

Imports System.Transactions

Public Class FormMaParentesco

    Dim Obj_PerEdad As New BL_Persona

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False
        If LblcPerCodigo.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label1.Text, CboTipoPer)
            Exit Function
        End If
        If CboTipoPer.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label5.Text, CboTipoPer)
            Exit Function
        End If
        If CboTipoDocu.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label11.Text, CboTipoDocu)
            Exit Function
        End If
        If Trim(TxtNroDocu.Text) = vbNullString Then
            MsgInfoCampoObligatorio(LblNroDocu.Text, TxtNroDocu)
            Exit Function
        End If
        If CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            If CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC Then
                If Not Valida_RUT(TxtNroDocu.Text) Then
                    MsgInfoCampoObligatorio("RUC no es valido, por favor de verificar.", TxtNroDocu)
                    Exit Function
                End If
            End If
        End If
        If Trim(TxtApePat.Text) = vbNullString Then
            MsgInfoCampoObligatorio(Label2.Text, TxtApePat)
            Exit Function
        End If
        If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
            If TxtApeMat.Text = vbNullString Then
                MsgInfoCampoObligatorio(Label3.Text, TxtApeMat)
                Exit Function
            End If
        End If
        If Txt1Nombre.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label6.Text, Txt1Nombre)
            Exit Function
            'ElseIf DateTime.TryParse(DtpFecNacCrea.Value, DtpFecNacCrea.Value) Then
            '    MsgInfoCampoObligatorio(Label4.Text, Txt1Nombre)
            '    Exit Function
            'ElseIf CboNacionalidad.SelectedValue = -1 Then
            '    MsgInfoCampoObligatorio(Label12.Text, CboNacionalidad)
            '    Exit Function
        End If
        If CboSexoTEmp.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label13.Text, CboSexoTEmp)
            Exit Function
            'ElseIf CboEstadoCivil.SelectedIndex = -1 Then
            '    MsgInfoCampoObligatorio(Label8.Text, CboEstadoCivil)
            '    Exit Function
        End If
        If LblnEdad.Text < 18 And FormMaPersona.CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
            MessageBox.Show("Para ser Apoderado debe ser mayor de edad.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If
        ValidaCamposObligatorios = True

    End Function

    Private Sub GeneraNewIdcPerCodigo()

        Dim ObjNewId As New BL_Persona
        LblcPerCodigo.Text = ObjNewId.Get_NewIdcPerCodigo_Out(StrcPerJuridica)

    End Sub

    Private Sub DtpFechaNacimiento()
        Dim DFecha As String = CboDia.Text + "/" + CboMes.SelectedValue.ToString + "/" + CboAnio.Text
        Dim dateValue As Date

        If DateTime.TryParse(DFecha, dateValue) Then
            DtpFecNacCrea.Value = CDate(DFecha)
        Else
            MsgInfoCampoObligatorio(Label4.Text & " no valida", CboDia)
        End If

    End Sub

    Private Sub EstablecerFormPredeterminado()

        CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural

        CboTratoPer.Enabled = True : TxtApePat.Enabled = True : TxtApeMat.Enabled = True ': Txt2Nombre.Enabled = True : Txt3Nombre.Enabled = True
        Label4.Text = "Fecha Nacimiento:" : Label6.Text = "Primer nombre:" : Label13.Text = "Sexo:" ': Label8.Text = "Estado civil:"

        LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboSexoTEmp, ObjConst.Get_Constante("C", CLng(CboSexoTEmp.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboParentesco, ObjConst.Get_Constante("C", CLng(CboParentesco.Tag)), "nConValor", "cConDescripcion")

        CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

        If FormMaPersona.CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            Me.BackColor = Color.SeaShell : GroupBox1.Text = " Datos Contacto "
            CboParentesco.SelectedValue = 1014
            CboParentesco.Enabled = False
        Else
            Me.BackColor = Color.FloralWhite : GroupBox1.Text = " Datos Familiar "
            CboParentesco.Enabled = True
        End If

        TxtNroDocu.Focus()

    End Sub

    Private Sub FormMaParentesco_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Tipo de persona
        LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")

        'Trato de persona
        LlenaDataCombo(CboTratoPer, ObjConst.Get_Constante("C", CLng(CboTratoPer.Tag)), "nConValor", "cConDescripcion")

        CboDia.SelectedIndex = 0
        'Meses
        LlenaDataCombo(CboMes, ObjConst.Get_Constante("C", CLng(CboMes.Tag)), "nConValor", "cConDescripcion")
        'Años
        LlenaDataCombo(CboAnio, ObjConst.Get_Constante("C", CLng(CboAnio.Tag)), "nConValor", "cConDescripcion")

        EstablecerFormPredeterminado()
        BtnCancel.Enabled = True

        If nAccionBotones = nAccionButton.nAccionNuevo Then

            'LimpiarTextBox(Me)
            'nuevo codigo 
            LblcPerCodigo.Text = "Nuevo"

            'BtnCancel.Enabled = False

        ElseIf nAccionBotones = nAccionButton.nAccionEdit Then

            'BtnCancel.Enabled = True

            Dim Req_PerParentesco As New BE_ReqPerParentesco
            Dim Obj_PerParentesco As New BL_PerParentesco

            Req_PerParentesco.cPerCodigo = TokenByKey(StrPasaValores, "cPercodigo") 'FormMaPersona.LblcPerCodigo.Text

            REM Llenando un DataTable y recorriendo sus registros
            Dim dt As New DataTable

            With Obj_PerParentesco
                If .Get_PerParentesco(Req_PerParentesco) Is Nothing Then Exit Sub

                dt = .Get_PerParentesco(Req_PerParentesco)

                For Each row As DataRow In dt.Rows
                    LblcPerCodigo.Text = CStr(row("cPerCodigo"))
                    CboParentesco.SelectedValue = CLng(row("nPerParTipo"))
                    CboTipoDocu.SelectedValue = CLng(row("nPerIdeTipo"))
                    TxtNroDocu.Text = CStr(row("cPerIdeNumero"))
                    CboTratoPer.SelectedValue = CLng(row("nPerTratamiento"))
                    TxtApePat.Text = CStr(row("cPerApellPaterno"))
                    TxtApeMat.Text = CStr(row("cPerApellMaterno"))
                    Txt1Nombre.Text = CStr(row("cPerPriNombre"))
                    DtpFecNacCrea.Value = CDate(row("dPerNacimiento"))
                    CboSexoTEmp.SelectedValue = CLng(row("nPerNatSexo"))
                Next
                'Llenando Combox Dia, Mes, Año
                CboDia.Text = DtpFecNacCrea.Value.Day
                CboMes.SelectedValue = DtpFecNacCrea.Value.Month
                CboAnio.Text = DtpFecNacCrea.Value.Year.ToString

            End With

            Me.ActiveControl = CboParentesco

        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim Request As New BE_ReqPersona
            Dim ObjPer As New BL_Persona

            Dim Req_PerParentesco As New BE_ReqPerParentesco
            Dim Obj_PerParentesco As New BL_PerParentesco

            Dim StrSQl As String = ""
            Dim Resultado As Boolean
            Dim ResultadoP As Boolean

            If ValidaCamposObligatorios() Then

                Using scope As New TransactionScope

                    If nAccionBotones = nAccionButton.nAccionNuevo Then
                        'Genera Nuevo IdPersona
                        GeneraNewIdcPerCodigo()
                    End If

                    Request.cPerCodigo = LblcPerCodigo.Text
                    'Request.cPerJurCodigo = StrcPerJuridica
                    Request.nPerIdeTipo = CboTipoDocu.SelectedValue
                    Request.cPerIdeNumero = Trim(TxtNroDocu.Text)
                    Request.cPerApellPaterno = Replace(TxtApePat.Text, "'", "{")
                    Request.cPerApellMaterno = Replace(TxtApeMat.Text, "'", "{")
                    Request.cPerPriNombre = Replace(Txt1Nombre.Text, "'", "{")
                    Request.cPerSegNombre = ""
                    Request.cPerTerNombre = ""
                    Request.dPerNacimiento = FormatDateTime(DtpFecNacCrea.Value, DateFormat.ShortDate)
                    Request.nPerTipo = CboTipoPer.SelectedValue
                    Request.cUbiGeoCodigo = ""
                    Request.nPerTratamiento = CboTratoPer.SelectedValue
                    Request.nPerNatSexo = CboSexoTEmp.SelectedValue
                    Request.nPerNatEstCivil = 1 ' CboEstadoCivil.SelectedValue
                    Request.nPerNatTipResidencia = 0 'Tipo de residencia?
                    Request.nPerNatSitLaboral = 0 'Situacion laboral?
                    Request.nPerNatOcupacion = 0 'Ocupacion?
                    Request.nPerNatCondicion = 0 'condicion?
                    Request.cPerJurRepCodigo = vbNullString 'representante legal de la empresa
                    Request.nPerJurTipInversion = CboSexoTEmp.SelectedValue
                    Request.nPerJurSecEconomico = 1 'CboEstadoCivil.SelectedValue
                    Request.nCarCodigo = 9256 'CboNacionalidad.SelectedValue
                    Request.cCarValor = "PERÚ" 'CboNacionalidad.Text
                    Request.dFecha = FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate)

                    'Parentesco
                    Req_PerParentesco.cPerCodigo = TokenByKey(StrPasaValores, "cPerCodigo") 'FormPrcSolAtencion.LblcPerCodigo.Text
                    Req_PerParentesco.cPerParCodigo = LblcPerCodigo.Text
                    Req_PerParentesco.nPerParTipo = CLng(CboParentesco.SelectedValue)
                    Req_PerParentesco.bPerApo = 0
                    Req_PerParentesco.bPerCarta = 0
                    Req_PerParentesco.nPerParEstado = 1

                    If MsgGrabar() = System.Windows.Forms.DialogResult.Yes Then

                        Select Case nAccionBotones
                            Case nAccionButton.nAccionNuevo
                                Resultado = ObjPer.Ins_Persona(Request)
                                ResultadoP = Obj_PerParentesco.Ins_PerParentesco(Req_PerParentesco)
                            Case nAccionButton.nAccionEdit
                                Resultado = ObjPer.Upd_Persona(Request)
                                ResultadoP = Obj_PerParentesco.Upd_PerParentesco(Req_PerParentesco)
                        End Select

                        If Resultado And ResultadoP Then
                            'StrPasaValores = vbNullString 'seteo la variable 
                            'StrPasaValores = "cPerCodigo=" & LblcPerCodigo.Text & ";"
                            'StrPasaValores = StrPasaValores & "cPerIdeNumero=" & TxtNroDocu.Text & ";"
                            'StrPasaValores = StrPasaValores & "cNombCompleto=" & TxtApePat.Text & " " & TxtApeMat.Text & ", " & Txt1Nombre.Text & ";" '& Txt2Nombre.Text & " " & Txt3Nombre.Text & ";"
                            'StrPasaValores = StrPasaValores & "nPerJurTipInversion=" & CboSexoTEmp.SelectedValue & ";"
                            'StrPasaValores = StrPasaValores & "nPerJurSecEconomico=1" ' & CboEstadoCivil.SelectedValue

                            MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Si No hay error en la Transaction se completa
                            scope.Complete()
                            Call BtnCancel_Click(BtnCancel, Nothing)

                        End If

                    End If
                End Using

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CboMes_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboMes.SelectionChangeCommitted
        DtpFechaNacimiento()
    End Sub

    Private Sub CboAnio_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboAnio.SelectionChangeCommitted
        DtpFechaNacimiento()
    End Sub

    Private Sub CboDia_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboDia.SelectionChangeCommitted
        DtpFechaNacimiento()
    End Sub

    Private Sub DtpFecNacCrea_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DtpFecNacCrea.ValueChanged

        LblnEdad.Text = Obj_PerEdad.Get_ObtenerEdad(DtpFecNacCrea.Value)

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
            Me.Close()
            Me.Dispose()
    End Sub

    Private Sub CboTipoPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoPer.KeyPress, CboTipoDocu.KeyPress, CboParentesco.KeyPress, CboTratoPer.KeyPress, CboDia.KeyPress, CboMes.KeyPress, CboAnio.KeyPress, CboSexoTEmp.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtNroDocu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroDocu.KeyPress, TxtApePat .KeyPress ,TxtApeMat .KeyPress ,Txt1Nombre .KeyPress 
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

End Class