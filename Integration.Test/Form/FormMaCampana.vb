Option Explicit On
Imports Integration.BE
Imports Integration.BE.Campana
Imports Integration.BL.BL_Campana

Imports System.Transactions

Public Class FormMaCampana

    Dim nFlag As Integer REM nglag = 0 , Agregando, 1 = modificando

    Dim dateValue As Date

    Dim Req_Campana As New BE_ReqCampana
    Dim Obj_Campana As New BL_Campana
    Dim Response As New BE_ResGenerico

    Enum GrillaServicios
        ColcPerJurCodigo = 0
        ColnCtaCteSerCodigo = 1
        ColcIntJerarquia = 2
        ColcCtaCteSerJerarquia = 3
        ColcCtaCteSerKeyWord = 4
        ColnMonCodigo = 5
        ColnIntCodigo = 6
        ColnCtaCteSerCosto = 7
    End Enum

    Private Sub GeneraNewIdCampana()
        'Genera nIntCamp nuevo "[usp_Get_NewId_nIntCampana]"
        LblnIntCamp.Text = Obj_Campana.Get_NewId_nIntCampana(Req_Campana)

    End Sub

    Private Sub DtpFechaInicio()
        Dim DFecha As String = CboDia.Text + "/" + CboMes.SelectedValue.ToString + "/" + CboAnio.Text


        If DateTime.TryParse(DFecha, dateValue) Then
            DtpFecIni.Value = CDate(DFecha)
        Else
            MsgInfoCampoObligatorio(Label4.Text & " no valida", CboDia)
        End If

    End Sub

    Private Sub DtpFechaFin()
        Dim DFecha As String = CboDia1.Text + "/" + CboMes1.SelectedValue.ToString + "/" + CboAnio1.Text

        If DateTime.TryParse(DFecha, dateValue) Then
            DtpFecFin.Value = CDate(DFecha)
        Else
            MsgInfoCampoObligatorio(Label4.Text & " no valida", CboDia)
        End If

    End Sub

    Private Sub FormMaCampana_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        REM Utilizando teclado 
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert)) 'agrega nueva persona
                Call BtnAdd_Click(BtnAdd, Nothing)
                'nAccionBotones = nAccionButton.nAccionNuevo
                'FormMaPersona.Width = 435
                'FormMaPersona.ShowDialog()
                'If StrPasaValores <> vbNullString Then
                '    TxtBuscar.Text = TokenByKey(StrPasaValores, "cPerIdeNumero")
                'End If
                'Call BtnBuscar_Click(BtnBuscar, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F3)) 'Buscar
                'TxtBuscar.Focus()

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4)) 'Agrega Item al mismo recibo seleccionado
                'If Table3.Focused AndAlso Table3.RowCount > 0 AndAlso LblNroRecibo.Text <> vbNullString AndAlso CDbl(LblTCancel.Text) = 0 Then
                '    nOperacion = 2 'Nuevo item
                '    FormPrcProgramarServicio.ShowDialog()
                '    RefreshFind()
                'End If

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6)) 'Agrega nuevo recibo
                'BtnAddServicio_Click(BtnAddServicio, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7)) 'realiza pago
                'BtnRegPago_Click(BtnRegPago, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8)) 'imprimit
                'BtnImprimir_Click(BtnImprimir, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F9)) 'Eliminar linea seleccionada

                'If Table3.Focused AndAlso Table3.RowCount > 0 AndAlso LblNroRecibo.Text <> vbNullString Then
                '    With Table3
                '        If (CDbl(LblTCancel.Text)) = 0 Or LblTCancel.Text = vbNullString Then

                '            Dim Condicion As String
                '            Dim BL As New BL_Sistema

                '            Condicion = "cPerJurCodigo = " & .Item("cPerJurCodigo", .CurrentRow.Index).Value & " AND cPerCodigo = " & .Item("cPerCodigo3", .CurrentRow.Index).Value & "  AND cCtaCteRecibo =" & .Item("cCtaCteRecibo", .CurrentRow.Index).Value

                '            If BL.Get_CountFila("CtaCteIteLine", "nCtaCteRecLine", Condicion) = 1 Then
                '                MessageBox.Show("Recibo debe tener un Item y/o Servicio como minimo.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '                Exit Sub
                '            End If
                '            '//

                '            Dim BLD As New BL_CtaCteIteLine

                '            If BLD.Del_CtaCteIteLine(.Item("cPerJurCodigo", .CurrentRow.Index).Value, .Item("cPerCodigo3", .CurrentRow.Index).Value, .Item("cCtaCteRecibo", .CurrentRow.Index).Value, .Item("nCtaCteRecLine", .CurrentRow.Index).Value, .Item("nCtaCteSerCodigo", .CurrentRow.Index).Value) Then
                '                RefreshFind()
                '            End If
                '        End If
                '    End With
                'End If
        End Select
    End Sub

    Private Sub FormMaCampana_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, True)
        REM estado de los botones
        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)

        'Meses
        LlenaDataCombo(CboMes, ObjConst.Get_Constante("C", CLng(CboMes.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboMes1, ObjConst.Get_Constante("C", CLng(CboMes1.Tag)), "nConValor", "cConDescripcion")
        'Años
        LlenaDataCombo(CboAnio, ObjConst.Get_Constante("C", CLng(CboAnio.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboAnio1, ObjConst.Get_Constante("C", CLng(CboAnio1.Tag)), "nConValor", "cConDescripcion")

        CboDia.SelectedIndex = 0
        CboDia1.SelectedIndex = 0

    End Sub

    Private Sub CboMes_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboMes.SelectionChangeCommitted
        DtpFechaInicio()
    End Sub

    Private Sub CboAnio_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboAnio.SelectionChangeCommitted
        DtpFechaInicio()
    End Sub

    Private Sub CboDia_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboDia.SelectionChangeCommitted
        DtpFechaInicio()
    End Sub

    Private Sub CboMes1_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboMes1.SelectionChangeCommitted
        DtpFechaFin()
    End Sub

    Private Sub CboAnio1_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboAnio1.SelectionChangeCommitted
        DtpFechaFin()
    End Sub

    Private Sub CboDia1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboDia1.SelectionChangeCommitted
        DtpFechaFin()
    End Sub

    Private Sub C1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        nFlag = 0  'Agregando
        GeneraNewIdCampana()

        CboDia.Text = Date.Now.Day.ToString
        CboDia1.Text = Date.Now.Day.ToString

        CboAnio.Text = Year(CDate(dFechaSistema))
        CboAnio1.Text = Year(CDate(dFechaSistema))

        CboMes.SelectedValue = Date.Now.Month
        CboMes1.SelectedValue = Date.Now.Month

        TxtDescrp.Text = vbNullString

        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True)

        TxtDescrp.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancel.Click

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)

    End Sub

    Private Sub Combobox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboDia.KeyPress, CboDia1.KeyPress, CboMes.KeyPress, CboMes1.KeyPress, CboAnio.KeyPress, CboAnio1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtDescrp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescrp.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click

        FormServicios = 0
        FormFiltroServicios.ShowDialog()

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

        Table1.Refresh()

    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellEndEdit

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

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

    Private Sub validar_Keypress( _
                           ByVal sender As Object, _
                           ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna   
        Dim columna As Integer = Table1.CurrentCell.ColumnIndex

        ' comprobar si la celda en edición corresponde a la columna 1 o 3   
        If columna = 7 Then ' costo

            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' comprobar si es un número con isNumber, si es el backspace, si el caracter   
            ' es el separador decimal, y que no contiene ya el separador  
            If (Char.IsNumber(caracter)) Or _
                        (caracter = ChrW(Keys.Back)) Or _
                        (caracter = ".") And _
                        (Me.Text.Contains(".") = False) Then


                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub C1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click


        Try
            Dim Resultado As Boolean
            Dim ResultadoDet As Boolean

            Using scope As New TransactionScope

                Req_Campana.nIntCamp = CLng(LblnIntCamp.Text)
                Req_Campana.cPerJurCodigo = StrcPerJuridica
                Req_Campana.cNombreCamp = Trim(TxtDescrp.Text)
                Req_Campana.dFecIniCamp = DtpFecIni.Value
                Req_Campana.dFecFinCamp = DtpFecFin.Value
                Req_Campana.nTCostoCamp = FormatNumber(LblTotalPago.Text, True)
                Req_Campana.cPerUseCodigo = StrUser

                If nFlag = 0 Then
                    REM Insert CAB
                    Resultado = Obj_Campana.Ins_Campana(Req_Campana)

                    With Table1
                        For Each row As DataGridViewRow In .Rows
                            Req_Campana.nCtaCteSerCodigo = CLng(row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                            Req_Campana.nCtaCteCosto = CLng(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value)
                            REM Insert DET
                            ResultadoDet = Obj_Campana.Ins_DetalleCampana(Req_Campana)
                        Next
                    End With

                ElseIf nFlag = 1 Then
                    REM update

                    Resultado = Obj_Campana.Upd_Campana(Req_Campana)

                End If

                If Resultado And ResultadoDet Then
                    'termina todo OK
                    scope.Complete()
                    MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call c1CmdCancel_Click(C1CmdCancel, Nothing)
                    'Else
                    '    MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

End Class