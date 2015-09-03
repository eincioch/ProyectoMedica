Option Explicit On
Imports System.IO
Imports Integration.BE.Persona
Imports Integration.BE.CtasCtes
Imports Integration.BE.CtasCtesMedica
Imports Integration.BE.FichaAtencion
Imports Integration.BL
Imports Integration.BL.BL_Persona
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BL.BL_FichaAtencion

Imports System.Transactions

Public Class FormPrcSolAtencion

    Dim nEstado As Integer
    Dim dateValue As Date

    Enum GrillaServicios
        ColcPerJurCodigo = 0
        ColnCtaCteSerCodigo = 1
        ColcIntJerarquia = 2
        ColcCtaCteSerJerarquia = 3
        ColcCtaCteSerKeyWord = 4
        ColnMonCodigo = 5
        ColnIntCodigo = 6
        ColnCtaCteCantidad = 7
        ColnCtaCteSerCosto = 8
        ColnCtaCteSubTotal = 9
        ColnFlag = 10
    End Enum

    Private Sub Inicializar()
        TxtNroFind.Text = vbNullString
        LblcPerCodigo.Text = vbNullString
        LblcNombre.Text = vbNullString
        LblEdad.Text = vbNullString
        TxtNroFindAutoriza.Text = vbNullString
        LblcPerCodigoAut.Text = vbNullString
        LblcAutoriza.Text = vbNullString
        TxtFindEmpl.Text = vbNullString
        LblcPerCodEmpl.Text = vbNullString
        LblcNombEmpl.Text = vbNullString
    End Sub

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False

        If CboDia.Text = "" Then
            MsgInfoCampoObligatorio(Label18.Text, CboDia)
            Exit Function
        End If

        If CboMes.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label12.Text, CboMes)
            Exit Function
        End If

        If CboAnio.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label17.Text, CboAnio)
            Exit Function
        End If

        If CboTipoPer.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label15.Text, CboTipoPer)
            Exit Function
        End If

        If CboTipoDocu.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label14.Text, CboTipoDocu)
            Exit Function
        End If

        If TxtNroFind.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label16.Text, TxtNroFind)
            Exit Function
        End If

        If LblcPerCodigo.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label16.Text, TxtNroFind)
            Exit Function
        End If

        If LblcNombre.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label16.Text, TxtNroFind)
            Exit Function
        End If

        If CboTipoCta.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label6.Text, CboTipoCta)
            Exit Function
        End If

        Select Case CboTipoCta.SelectedValue
            Case TipoAtencion.LabExterno Or TipoAtencion.Convenio
                'CboEmpresa.SelectedIndex.Equals(-1)
                If CboEmpresa.SelectedIndex = -1 Or CboEmpresa.Text = vbNullString Then
                    MsgInfoCampoObligatorio(Label10.Text, CboEmpresa)
                    Exit Function
                End If
        End Select

        If CLng(LblEdad.Text) < 18 And CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural And Len(TxtNroFindAutoriza.Text) = 0 Then
            GrpBoxAutoriza.Enabled = True
            MessageBox.Show("Persona es un Menor de Edad, por tal motivo se debe registrar y/o indicar quien Autoriza el Exámen al menor.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TxtNroFindAutoriza.Focus()
            Exit Function
        End If

        If Table1.RowCount = 0 Then
            MessageBox.Show("No hay ningún detalle (Análisis) para la atención.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Function
        End If

        If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            If Table3.RowCount = 0 Then
                MessageBox.Show("Debe agregar la lista de personas que participan en el Convenio.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Function
            End If
        End If

        If ChkDeriv.CheckState = CheckState.Checked And ChkDeriv.Checked Then
            If CboDerivMedico.SelectedIndex = -1 Or CboDerivMedico.SelectedValue = Nothing Then
                MsgInfoCampoObligatorio(Label9.Text, CboDerivMedico)
                Exit Function
            End If
        End If

        ValidaCamposObligatorios = True

    End Function

    Private Sub InicializarForm()
        LblcPerCodigo.Text = vbNullString
        LblcNombre.Text = vbNullString
        LblNroSolicitud.Text = vbNullString
        LimpiarTextBox(Me)
    End Sub

    Private Sub DtpFechaExamen()
        Dim DFecha As String = CboDia.Text + "/" + CboMes.SelectedValue.ToString + "/" + CboAnio.Text

        If DateTime.TryParse(DFecha, dateValue) Then
            DTPFecExamen.Value = CDate(DFecha)
        Else
            MsgInfoCampoObligatorio(Label4.Text & " no valida", CboDia)
        End If

    End Sub

    Public Sub BuscaPersona()

        Try

            Dim Request As New BE_ReqPersonaSearh
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
                If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then LblEdad.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("nEdad") Else LblEdad.Text = 0

                If CLng(LblEdad.Text) < 18 And CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
                    GrpBoxAutoriza.Enabled = True : TxtNroFindAutoriza.Focus()
                Else
                    GrpBoxAutoriza.Enabled = False
                    'Pasa
                    BtnCIE.Focus()
                End If
            Else
                If MessageBox.Show("Persona No registra en el sistema. ¿Desea registrar a la persona.?", "Buscando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call BtnAgregar_Click(BtnAgregar, Nothing)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub BuscaPersonaAutoriza()
        Try
            Dim Request As New BE_ReqPersonaSearh
            Dim ObjPer As New BL_Persona

            Dim StrFilNroDocu As String = ""
            If TxtNroFindAutoriza.Text = vbNullString Or Len(TxtNroFindAutoriza.Text) <= 2 Then Exit Sub
            StrFilNroDocu = TxtNroFindAutoriza.Text

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = CboTipoPer.SelectedValue

            If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

            If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
                LblcPerCodigoAut.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
                LblcAutoriza.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")
                'pasa
                BtnCIE.Focus()
            Else
                If MessageBox.Show("Persona no se encuentra registrada en el sistema. ¿Desea registrar a la persona.?", "Buscando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    StrPasaValores = vbNullString 'seteo la variable 
                    StrPasaValores = "cPerCodigo=" & LblcPerCodigo.Text
                    Call BtnAutoriza_Click(BtnAutoriza, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub BuscaEmpleado()
        Try
            Dim Request As New BE_ReqPersonaSearh
            Dim ObjPer As New BL_Persona
            Dim dtEmpl As New DataTable

            Dim StrFilNroDocu As String = ""
            If TxtFindEmpl.Text = vbNullString Or Len(TxtFindEmpl.Text) <= 2 Then Exit Sub
            StrFilNroDocu = TxtFindEmpl.Text

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = nConTipoPersona.nPerNatural

            dtEmpl = ObjPer.Get_SearhPersona(Request)

            If dtEmpl.Rows.Count > 0 Then
                LblcPerCodEmpl.Text = dtEmpl.Rows(0)("cPerCodigo")
                LblcNombEmpl.Text = dtEmpl.Rows(0)("cpernombre")
            Else
                If MessageBox.Show("Persona no se encuentra registrada en el sistema. ¿Desea registrar a la persona.?", "Buscando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call BtnAddEmpl_Click(BtnAddEmpl, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub validar_Keypress( _
                            ByVal sender As Object, _
                            ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' Obtener indice de la columna   
        Dim columna As Integer = Table1.CurrentCell.ColumnIndex

        ' Comprobar si la celda en edición corresponde a la columna 7   
        If columna = GrillaServicios.ColnCtaCteCantidad Then  'Cantidad

            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' Comprobar si el caracter es un número o el retroceso   
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar
                e.KeyChar = Chr(0)
            End If
        End If

    End Sub

    Private Sub Table1_EditingControlShowing(ByVal sender As Object, _
                   ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) _
               Handles Table1.EditingControlShowing

        On Error Resume Next

        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf validar_Keypress

    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellEndEdit
        Try
            With Table1
                If .Item(GrillaServicios.ColnCtaCteCantidad, .CurrentRow.Index).Value <= 0 Then
                    .Item(GrillaServicios.ColnCtaCteCantidad, .CurrentRow.Index).Value = 1 'default
                End If

                Dim Dt_Valor1, Dt_Valor2, Dt_Resultado As Double

                If .Columns(e.ColumnIndex).Name = "nCtaCteCantidad" Then 'Or .Columns(e.ColumnIndex).Name = "nCtaCteSerCosto" Then

                    Dt_Valor1 = Convert.ToDouble(.Rows(e.RowIndex).Cells("nCtaCteCantidad").EditedFormattedValue)
                    Dt_Valor2 = Convert.ToDouble(.Rows(e.RowIndex).Cells("nCtaCteSerCosto").EditedFormattedValue)

                    Dt_Resultado = (Dt_Valor1 * Dt_Valor2)
                    .Rows(e.RowIndex).Cells("nCtaCteSubTotal").Value = (Dt_Resultado)

                End If
            End With

            LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Function ValidarCamposForAddItemGrd() As Boolean

    '    ValidarCamposForAddItemGrd = False

    '    REM If CDbl(CDbl(Suma_Columna("nCtaCtePagImporte", Table1)) + CDbl(TxtImpPago.Text)) > CDbl(LblImpRecibo.Text) Then MessageBox.Show("Importe a Pagar exede el importe.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Function

    '    ValidarCamposForAddItemGrd = True

    'End Function

    Private Sub FormPrcFichaAtencion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                Call c1CmdGrabar_Click(c1CmdGrabar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Call BtnAdd_Click(BtnAdd, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Delete))
                BtnQuitar_Click(BtnQuitar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                Call c1CmdCancel_Click(c1CmdCancel, Nothing)
                Call C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select

    End Sub

    Private Sub FormPrcSolAtencion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim Req_ListServicios As New BE_ReqCtaCtePrecioServicio
            Dim Obj_ListServicios As New BL_CtaCtePrecioServicio

            'Meses
            LlenaDataCombo(CboMes, ObjConst.Get_Constante("C", CLng(CboMes.Tag)), "nConValor", "cConDescripcion")
            'Años
            LlenaDataCombo(CboAnio, ObjConst.Get_Constante("C", CLng(CboAnio.Tag)), "nConValor", "cConDescripcion")

            CboDia.SelectedIndex = 0

            LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")
            LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")

            'Interface: 1133
            LlenaDataCombo(CboTipoCta, ObjInterface.Get_Interface(CLng(TokenByKey(CboTipoCta.Tag, "nIntClase")), CLng(TokenByKey(CboTipoCta.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")
            CboTipoCta.Enabled = True 'Inicializamos

            'PerRelacion
            'Dim Obj_Doctor As New BL_Persona
            'LlenaDataCombo(CboDerivMedico, Obj_Doctor.Get_List_Persona_PerRelacion_for_nPerRelTipo(CLng(CboDerivMedico.Tag)), "cPerCodigo", "cPerName")
            LlenaDataCombo(CboDerivMedico, ObjSistema.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoMedico), "cPerCodigo", "cPerNombre")

            CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

            EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False, C1CmdProgramar, False)

            FormatGrilla(Table1, Me, False, 30)
            FormatGrilla(Table2, Me, False, 25)
            FormatGrilla(Table3, Me, False, 25)

            GrpBoxListEmpl.Enabled = True

            If nFlagAdmision = 1 Then
                Call c1CmdNuevo_Click(c1CmdNuevo, Nothing)
                CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)
            ElseIf nFlagAdmision = 2 Then
                Call C1CmdEdit_Click(C1CmdEdit, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub TxtNroFind_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFind.KeyPress

        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaPersona()
        End If

    End Sub

    Private Sub CboTipoPer_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoPer.SelectionChangeCommitted

        Select Case CboTipoPer.SelectedValue
            Case nConTipoPersona.nPerNatural
                EliminarRowsDgView(Table3) 'vacio grilla para asegurar que no alla errores
                LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
                CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI
                Me.Width = 982
                GrpBoxListEmpl.Visible = False
            Case nConTipoPersona.nPerJuridica
                LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerJuridica)), "nConValor", "cConDescripcion")
                CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC
                Me.Width = 1396
                GrpBoxListEmpl.Visible = True
        End Select
        Me.StartPosition = FormStartPosition.CenterParent
        Inicializar()
    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click

        nAccionBotones = nAccionButton.nAccionNuevo

        'nOperacion = 1
        FormMaPersona.Width = 503 '435
        nFormPerPredeterminado = CboTipoPer.SelectedValue 'nConTipoPersona.nPerNatural
        FormMaPersona.TxtNroDocu.Text = TxtNroFind.Text
        Me.Opacity = 1.83
        FormMaPersona.ShowDialog()

        BuscaPersona()

        BtnCIE.Focus()

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        InicializarForm()

        Dim Obj_NewId As New BL_FichaAtencion
        'correlativo solicitud
        LblNroSolicitud.Text = "Nueva Ficha" 'Obj_NewId.Get_NewId_AdmSolAtencion()  REM GetCorrelativo(StrcPerJuridica)

        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True, C1CmdProgramar, False)
        GrpBoxPersona.Enabled = True : CboTipoCta.Enabled = True

        CboDia.Text = Date.Now.Day.ToString
        CboAnio.Text = Year(CDate(dFechaSistema))
        CboMes.SelectedValue = Date.Now.Month

        REM BtnGeneraCargo.Visible = False : 
        CboTipoCta.Focus()

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        Try

            CboTipoCta.SelectedValue = CLng(TokenByKey(StrPasaAdmFicha, "nIntCodigo"))
            CboTipoCta_SelectionChangeCommitted(CboTipoCta, Nothing)

            If CboEmpresa.Enabled Then CboEmpresa.SelectedValue = CLng(TokenByKey(StrPasaAdmFicha, "cPerCodigoTerceros"))

            CboTipoPer.SelectedValue = Convert.ToInt32(TokenByKey(StrPasaAdmFicha, "nPerTipo"))
            CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)
            TxtNroFind.Text = TokenByKey(StrPasaAdmFicha, "cPerIdeNumero")
            BuscaPersona()

            LblNroSolicitud.Text = TokenByKey(StrPasaAdmFicha, "nSolAdmNumero")
            DTPFecRegistro.Value = CDate(TokenByKey(StrPasaAdmFicha, "dFecRegistro"))
            DTPFecExamen.Value = CDate(TokenByKey(StrPasaAdmFicha, "dFecExamen"))

            'Llenando Combox Dia, Mes, Año
            CboDia.Text = DTPFecExamen.Value.Day
            CboMes.SelectedValue = DTPFecExamen.Value.Month
            CboAnio.Text = DTPFecExamen.Value.Year.ToString

            nEstado = CLng(TokenByKey(StrPasaAdmFicha, "nAdmSolEstado"))

            '-----------------
            'Carga Diagnostico
            '-----------------
            Dim nPos As Integer = 0
            Dim Obj_AdmSolDiag As New BL_FichaAtencion
            Dim dtAdmSolDiag As New DataTable

            dtAdmSolDiag = Obj_AdmSolDiag.Get_AdmSolDiagnostico_for_cPerJuridica_nIntCodigo_nSolAdmNumero(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), Trim(LblNroSolicitud.Text))
            'Datos enlazados no es factible para despues agregar mas items
            'Table1.DataSource = dtDetAdmSol

            'Leyendo un DataTable
            If dtAdmSolDiag.Rows.Count > 0 Then
                Dim row As DataRow

                EliminarRowsDgView(Table2)
                Table2.DataSource = Nothing

                For Each row In dtAdmSolDiag.Rows
                    With Table2
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("cDiagCodigo", nPos).Value = CStr(row("cDiagCodigo").ToString)
                        .Item("cDiagDescripcion", nPos).Value = CStr(row("cDiagDescripcion").ToString)
                    End With

                Next
            End If

            Table2.PerformLayout()
            '--------------
            'Carga detalle
            '--------------
            'Dim nPos As Integer
            Dim Obj_DetAdmSol As New BL_FichaAtencion
            Dim dtDetAdmSol As New DataTable

            dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(StrcPerJuridica, Trim(LblNroSolicitud.Text))
            'Datos enlazados no es factible para despues agregar mas items
            'Table1.DataSource = dtDetAdmSol

            'Leyendo un DataTable
            If dtDetAdmSol.Rows.Count > 0 Then
                Dim row As DataRow

                EliminarRowsDgView(Table1)
                Table1.DataSource = Nothing

                For Each row In dtDetAdmSol.Rows
                    With Table1
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                        .Item("nCtaCteSerCodigo", nPos).Value = CStr(row("nCtaCteSerCodigo").ToString)
                        .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
                        .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                        .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                        .Item("nMonCodigo", nPos).Value = CLng(row("nMonCodigo").ToString)
                        .Item("nIntCodigo", nPos).Value = CLng(row("nIntCodigo").ToString)
                        .Item("nCtaCteCantidad", nPos).Value = row("nCtaCteCantidad").ToString 'Precio
                        .Item("nCtaCteSerCosto", nPos).Value = FormatNumber(row("nCtaCteSerCosto").ToString, True) 'Precio
                        .Item("nCtaCteSubTotal", nPos).Value = FormatNumber(row("nCtaCteSubTotal").ToString, True) 'SubTotal
                        .Item("nFlag", nPos).Value = CLng(row("nFlag").ToString)
                    End With

                Next
            End If

            Table1.PerformLayout()

            '------------------------------
            'Carga detalle Lista Empleados
            '------------------------------
            If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
                Dim Obj_DetAdmSolListEmpl As New BL_FichaAtencion
                Dim dtDetAdmSolListEmpl As New DataTable

                dtDetAdmSolListEmpl = Obj_DetAdmSolListEmpl.Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), CboEmpresa.SelectedValue.ToString, Trim(LblNroSolicitud.Text))

                'Leyendo un DataTable
                If dtDetAdmSolListEmpl.Rows.Count > 0 Then
                    Dim row As DataRow

                    EliminarRowsDgView(Table3)
                    Table3.DataSource = Nothing

                    For Each row In dtDetAdmSolListEmpl.Rows
                        With Table3
                            nPos = .RowCount()
                            .Rows.Add()
                            .Item("cPerCodigo", nPos).Value = CStr(row("cPerCodigo").ToString)
                            .Item("cEmpleado", nPos).Value = CStr(row("cNombEmpl").ToString)
                        End With
                    Next
                End If

                Table3.PerformLayout()
                LblnEmpl.Text = Table3.RowCount.ToString
            End If

            LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)

            EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True, C1CmdProgramar, True)
            GrpBoxPersona.Enabled = False : CboTipoCta.Enabled = False : If CboEmpresa.Visible Then CboEmpresa.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False, C1CmdProgramar, False)
        REM BtnGeneraCargo.Visible = True : CboPrograma.Enabled = True

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click

        nFlagAdmision = 0
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click

        FormServicios = 1 'Seteo que sera para SolAtencion

        StrPasaValores = vbNullString
        StrPasaValores = "nIntCodigo=" & CboTipoCta.SelectedValue.ToString 'pasando qur tipo de precio va a utilizar

        FormFiltroServicios.ShowDialog()

        If Table1.RowCount > 0 Then CboTipoCta.Enabled = False 'Inhabilitamos ya que tenemos items agregados y el tipo de atencion ya tiene un precio preferencial

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)

    End Sub

    Private Sub ChkDeriv_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkDeriv.CheckedChanged
        If ChkDeriv.Checked = True And ChkDeriv.CheckState = CheckState.Checked Then
            CboDerivMedico.Visible = True : Label9.Visible = True
        Else
            CboDerivMedico.Visible = False : Label9.Visible = False
        End If

    End Sub

    Private Sub CboMes_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboMes.SelectionChangeCommitted
        DtpFechaExamen()
    End Sub

    Private Sub CboAnio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboAnio.KeyPress, CboDia.KeyPress, CboMes.KeyPress, CboDerivMedico.KeyPress, CboEmpresa.KeyPress, CboTipoCta.KeyPress, CboTipoDocu.KeyPress, CboTipoPer.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboAnio_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboAnio.SelectionChangeCommitted
        DtpFechaExamen()
    End Sub

    Private Sub CboDia_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboDia.SelectionChangeCommitted
        DtpFechaExamen()
    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoCta.SelectionChangeCommitted

        Dim Obj_Empresa As New BL_Persona

        Select Case CboTipoCta.SelectedValue
            Case TipoAtencion.Particular
                CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural
                CboEmpresa.Visible = False : Label10.Visible = False

            Case TipoAtencion.LabExterno
                CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural
                CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Laboratorio"
                LlenaDataCombo(CboEmpresa, ObjSistema.Get_Value_Table("p.cPerCodigo, p.cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoLabExterno), "cPerCodigo", "cPerNombre")
                'LlenaDataCombo(CboEmpresa, Obj_Empresa.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(1, 2), "cPerCodigo", "cPerNombre")

            Case TipoAtencion.Convenio
                CboTipoPer.Enabled = True : CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica
                CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Empresa"
                LlenaDataCombo(CboEmpresa, ObjSistema.Get_Value_Table("p.cPerCodigo, p.cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoEmpConvenio), "cPerCodigo", "cPerNombre")
                'LlenaDataCombo(CboEmpresa, Obj_Empresa.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(3, 131), "cPerCodigo", "cPerNombre")
        End Select

        CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try
            If ValidaCamposObligatorios() Then

                Me.Refresh()

                Using scope As New TransactionScope()

                    Dim Obj_NewId As New BL_FichaAtencion

                    Dim Req_CabAdmSolAtencion As New BE_ReqSolAtencion
                    Dim Obj_CabAdmSolAtencion As New BL_FichaAtencion

                    Dim ResultadoCab As Boolean
                    Dim ResultadoDet As Boolean
                    Dim ResultadoDerv As Boolean
                    Dim ResultadoAut As Boolean

                    If nFlagAdmision = 1 Then LblNroSolicitud.Text = Obj_NewId.Get_NewId_AdmSolAtencion()

                    With Req_CabAdmSolAtencion
                        .cPerJuridica = StrcPerJuridica
                        .nIntCodigo = CLng(CboTipoCta.SelectedValue)
                        .cPerCodigoTerceros = IIf(CboEmpresa.Enabled, CboEmpresa.SelectedValue, "")
                        .nSolAdmNumero = LblNroSolicitud.Text
                        .cPerCodigo = Trim(LblcPerCodigo.Text)
                        .dFecExamen = FormatDateTime(DTPFecExamen.Value, DateFormat.GeneralDate)
                        .nImpTotal = FormatNumber(LblTotalPago.Text, True)
                        .cPerUseCodigo = StrUser
                    End With

                    REM Grabando Cabecera
                    If nFlagAdmision = 1 Then 'Agregando
                        ResultadoCab = Obj_CabAdmSolAtencion.Ins_AdmSolAtencion(Req_CabAdmSolAtencion)
                    ElseIf nFlagAdmision = 2 Then
                        ResultadoCab = Obj_CabAdmSolAtencion.Upd_AdmSolAtencion(Req_CabAdmSolAtencion)
                    End If

                    REM Diagnostico Clinico
                    With Table2
                        If .RowCount > 0 Then
                            For Each row As DataGridViewRow In .Rows
                                If Not Obj_CabAdmSolAtencion.Ins_AdmSolDiagnostico(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), LblNroSolicitud.Text, CStr(row.Cells("cDiagCodigo").Value)) Then
                                    Throw New System.Exception("Error grabando Diagnostico Clinico, verifique por favor.!.")
                                End If
                            Next
                        End If
                    End With

                    REM Grabando DetAdmSolAtencion 
                    With Table1
                        REM Recorriendo la Grilla
                        For Each row As DataGridViewRow In .Rows
                            Req_CabAdmSolAtencion.nCtaCteSerCodigo = CLng(row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                            Req_CabAdmSolAtencion.nCtaCteCantidad = 1 'Defautl
                            Req_CabAdmSolAtencion.nCtaCteCosto = FormatNumber(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, True)
                            Req_CabAdmSolAtencion.nFlag = CLng(row.Cells(GrillaServicios.ColnFlag).Value)
                            REM Insert DET
                            ResultadoDet = Obj_CabAdmSolAtencion.Ins_DetAdmSolAtencion(Req_CabAdmSolAtencion)
                        Next
                    End With

                    REM Grabando si es un Convenio con Empresas y con lista de Empleados
                    If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica And Table3.RowCount > 0 Then
                        With Table3
                            If .RowCount > 0 Then
                                For Each row As DataGridViewRow In .Rows
                                    If Not Obj_CabAdmSolAtencion.Ins_Upd_AdmSolListaEmpleado(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), CboEmpresa.SelectedValue, LblNroSolicitud.Text, CStr(row.Cells("cPerCodigo").Value)) Then
                                        Throw New System.Exception("Error grabando Lista de Empleados, verifique por favor.!.")
                                    End If
                                Next
                            End If
                        End With
                    End If

                    'Grabando persona quien Autoriza examen si es un menor de edad
                    If GrpBoxAutoriza.Enabled And LblcPerCodigoAut.Text <> vbNullString Then
                        ResultadoAut = Obj_CabAdmSolAtencion.Ins_AdmSolAtenAutoriza(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), LblNroSolicitud.Text, LblcPerCodigoAut.Text)
                    End If

                    If nFlagAdmision = 1 And ChkDeriv.CheckState = CheckState.Checked And ChkDeriv.Checked Then
                        Req_CabAdmSolAtencion.cPerCodigoDoctor = CboDerivMedico.SelectedValue.ToString
                        ResultadoDerv = Obj_CabAdmSolAtencion.Ins_AdmSolDerivacion(Req_CabAdmSolAtencion)
                    End If

                    If (ResultadoCab And ResultadoDet) Or ResultadoDerv Or ResultadoAut Then
                        GrpBoxListEmpl.Enabled = False
                        scope.Complete()
                        'MessageBox.Show("Ficha de Atención se registro con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End Using

                'OJO aqui con esto.
                If MessageBox.Show("¿Desea Programar el Pago a la Ficha de Atención.?", "Programar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    C1CmdProgramar_Click(C1CmdProgramar, Nothing)
                End If
                Call c1CmdCancel_Click(c1CmdCancel, Nothing)

            End If

        Catch ex As TransactionAbortedException 'Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub BtnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitar.Click

        If Table1.RowCount = 0 Then Exit Sub

        Try
            With Table1
                Dim Obj_DelDetAdmSolAtencion As New BL_FichaAtencion

                'Eliminar de BD
                If .Item(GrillaServicios.ColnFlag, .CurrentRow.Index).Value = 1 Then

                    MsgBox("No Puede eliminar un Item de campaña.", vbInformation, "Validando..")

                    If MsgBox("¿Desea quitar todos los Items de la campaña.?", vbQuestion + vbYesNo, "Validando") = MsgBoxResult.Yes Then

                        Dim nFila As Integer
                        '1 es la condicion que indica Items de campaña.
                        For nFila = .Rows.Count - 1 To 0 Step -1
                            If .Rows(nFila).Cells(GrillaServicios.ColnFlag).Value = 1 Then
                                If Not (Table1.Rows(nFila).IsNewRow) Then
                                    'Call EliminarRowsDg_for_Condicion(Table1, "nFlag", 1)
                                    Obj_DelDetAdmSolAtencion.Del_DetAdmSolAtencion(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(nFila).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                                    .Rows.Remove(.Rows(nFila))
                                End If
                            End If
                        Next

                    End If
                Else
                    Obj_DelDetAdmSolAtencion.Del_DetAdmSolAtencion(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(.CurrentRow.Index).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                    Call EliminaRowSeleccionada(Table1)
                End If
            End With

            LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)

            If Table1.RowCount = 0 Then CboTipoCta.Enabled = True 'habilitamos y podemos cambiar el tipo de atencion

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnAutoriza_Click(sender As System.Object, e As System.EventArgs) Handles BtnAutoriza.Click

        nAccionBotones = nAccionButton.nAccionNuevo

        nFormPerPredeterminado = nConTipoPersona.nPerNatural
        FormMaParentesco.TxtNroDocu.Text = TxtNroFindAutoriza.Text
        FormMaParentesco.ShowDialog()

        BuscaPersonaAutoriza()

        BtnCIE.Focus()

    End Sub

    Private Sub TxtNroFindAutoriza_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFindAutoriza.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaPersonaAutoriza()
        End If

    End Sub

    Private Sub C1CmdProgramar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdProgramar.Click

        Try
            Dim nPrdCodigo As Integer
            Dim Resultado As Boolean

            Dim List As New List(Of BE.CtasCtesMedica.BE_ReqCtaCteDetalle) REM Variable de tipo "List"
            Dim ReqCtaCteDet As BE.CtasCtesMedica.BE_ReqCtaCteDetalle = Nothing REM Declaro variable "Item"

            Dim Obj_InsProgPago As New BL_CuentaCorriente

            If ValidaCamposObligatorios() Then
                'Obtengo periodo actual (nPrdCodigo)
                nPrdCodigo = ObjSistema.Get_Periodo_by_cPerJurCodigo(StrcPerJuridica)

                '--------------------------------
                'Llenando List para CtaCteDetalle
                '--------------------------------
                With Table1
                    For i As Integer = 0 To .Rows.Count - 1
                        ReqCtaCteDet = New BE.CtasCtesMedica.BE_ReqCtaCteDetalle 'Crear Nueva Instancia de clase(objeto) memoria
                        ReqCtaCteDet.nSerCodigo = CLng(.Item("nCtaCteSerCodigo", i).Value) REM Codigo de CtaCteServicio
                        ReqCtaCteDet.nCtaCteCantidad = CLng(1) REM Default cantidad 1
                        ReqCtaCteDet.nMoneda = CLng(TipoMoneda.nSoles)
                        ReqCtaCteDet.fCtaCteTC = 0
                        ReqCtaCteDet.fCtaCteIGV = 0 '
                        ReqCtaCteDet.fCtaCteDetimporte = CLng(.Item("nCtaCteSerCosto", i).Value) REM Precio de Analisis
                        ReqCtaCteDet.dCtaCteDetRegistro = FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate)
                        ReqCtaCteDet.nCtaCtedetEstado = CLng(1) REM 1=Activo
                        List.Add(ReqCtaCteDet)
                    Next
                End With

                REM Registrando Programacion
                Resultado = Obj_InsProgPago.Ins_CuentaCorriente_ProgracionPago(LblcPerCodigo.Text, StrcPerJuridica, LblNroSolicitud.Text, EstadoFichaAtencion.nProgramado, TipoActividad.nPerTipoCliente, FormatNumber(LblTotalPago.Text, True), FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), sGlosaCtaCteCorriente, nPrdCodigo, TipoMoneda.nSoles, List, StrUser)

                If Resultado Then
                    MessageBox.Show("Programación de Pago se realizo con éxito.", "Programando Pago..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormGridFichaAtencion.TxtBuscar.Text = LblNroSolicitud.Text
                End If

                Close()
                Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Se encontraron errores. " & ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub BtnCIE_Click(sender As System.Object, e As System.EventArgs) Handles BtnCIE.Click

        FormDiagnosticoCIE10.ShowDialog()

    End Sub

    Private Sub BtnDel_Click(sender As System.Object, e As System.EventArgs) Handles BtnDel.Click

        If Table2.RowCount = 0 Then Exit Sub

        Try
            With Table2
                Dim Obj_DelDiag As New BL_FichaAtencion

                If MsgBox("¿Desea eliminar Diagnostico seleccionado..?", vbQuestion + vbYesNo, "Validando") = MsgBoxResult.Yes Then
                    Obj_DelDiag.Del_AdmSolDiagnostico(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(.CurrentRow.Index).Cells("cDiagCodigo").Value)
                    Call EliminaRowSeleccionada(Table2)
                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnAddEmpl_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddEmpl.Click

        'nOperacion = 1
        FormMaPersona.Width = 503
        nFormPerPredeterminado = nConTipoPersona.nPerNatural
        FormMaPersona.TxtNroDocu.Text = TxtNroFind.Text
        FormMaPersona.ShowDialog()


        BuscaEmpleado()

    End Sub

    Private Sub TxtFindEmpl_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFindEmpl.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaEmpleado()
        End If
    End Sub

    Private Sub BtnAddEmplGrd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddEmplGrd.Click
        Try
            Dim Rows As Integer

            If LblcPerCodEmpl.Text = vbNullString Then Exit Sub 'no permitir agregar si no hay dato

            If BuscaCadenaDgView("cPerCodigo", Trim(LblcPerCodEmpl.Text), Table3) Then
                MessageBox.Show("Empleado ya ha sido ingresado en la lista, verifique por favor.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                With Table3
                    Rows = .RowCount()
                    .Rows.Add()
                    .Item("cPerCodigo", Rows).Value = LblcPerCodEmpl.Text
                    .Item("cEmpleado", Rows).Value = LblcNombEmpl.Text
                End With
                TxtFindEmpl.Text = vbNullString : LblcPerCodEmpl.Text = vbNullString : LblcNombEmpl.Text = vbNullString
                LblnEmpl.Text = Table3.RowCount.ToString
            End If

            TxtFindEmpl.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnQuitarEmpl_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitarEmpl.Click

        Try
            With Table3
                Dim Obj_DelDetListEmpl As New BL_FichaAtencion
                'Eliminar de BD
                Obj_DelDetListEmpl.Del_AdmSolListaEmpleado(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), CboEmpresa.SelectedValue, Trim(LblNroSolicitud.Text), .Rows(.CurrentRow.Index).Cells("cPerCodigo").Value)
                Call EliminaRowSeleccionada(Table3)
                LblnEmpl.Text = Table3.RowCount.ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CboEmpresa_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboEmpresa.SelectionChangeCommitted

        If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            Dim dt As New DataTable
            dt = ObjSistema.Get_Value_Table("cPerIdeNumero", "PerIdentifica", "", 2, "cPerCodigo = '" & Trim(CboEmpresa.SelectedValue.ToString) & "' AND nPerIdeTipo = 11")
            If dt.Rows.Count > 0 Then
                TxtNroFind.Text = dt.Rows(0).Item("cPerIdeNumero").ToString
                BuscaPersona()
            End If
        End If

    End Sub

End Class