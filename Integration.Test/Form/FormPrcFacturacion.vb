Option Explicit On
Imports Integration.BE
Imports Integration.BL
Imports Integration.BL.BL_CtaCtes

Imports CrystalDecisions.CrystalReports.Engine

Public Class FormPrcFacturacion

    Private Sub RefreshFind()

        Dim Request As New BE.Persona.BE_ReqPersonaSearh
        Dim ObjBL As New BL_Persona

        'Mando los parametros al Request
        Request.cNombre = vbNullString
        Request.cPerIdeNumero = vbNullString
        Request.nPerTipo = CboTipoPer.SelectedValue
        Request.cPerCodigo = LblcPerCodigo.Text

        'lena DataGridView
        Table1.DataSource = ObjBL.Get_SearhPersona(Request)

        Table3.Select()
        Table3_SelectionChanged(Table3, Nothing)
    End Sub

    Private Sub FormPrcFacturacion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F2)) 'agrega nueva persona
                nAccionBotones = nAccionButton.nAccionNuevo
                FormMaPersona.Width = 435
                FormMaPersona.ShowDialog()
                If StrPasaValores <> vbNullString Then
                    TxtBuscar.Text = TokenByKey(StrPasaValores, "cPerIdeNumero")
                End If
                Call BtnBuscar_Click(BtnBuscar, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F3)) 'Buscar
                TxtBuscar.Focus()

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4)) 'Agrega Item al mismo recibo seleccionado
                If Table3.Focused AndAlso Table3.RowCount > 0 AndAlso LblNroRecibo.Text <> vbNullString AndAlso CDbl(LblTCancel.Text) = 0 Then
                    nOperacion = 2 'Nuevo item
                    FormPrcProgramarServicio.ShowDialog()
                    RefreshFind()
                End If

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6)) 'Agrega nuevo recibo
                BtnAddServicio_Click(BtnAddServicio, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7)) 'realiza pago
                BtnRegPago_Click(BtnRegPago, Nothing)
  
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8)) 'imprimit
                BtnImprimir_Click(BtnImprimir, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F9)) 'Eliminar linea seleccionada

                If Table3.Focused AndAlso Table3.RowCount > 0 AndAlso LblNroRecibo.Text <> vbNullString Then
                    With Table3
                        If (CDbl(LblTCancel.Text)) = 0 Or LblTCancel.Text = vbNullString Then

                            Dim Condicion As String
                            Dim BL As New BL_Sistema

                            Condicion = "cPerJurCodigo = " & .Item("cPerJurCodigo", .CurrentRow.Index).Value & " AND cPerCodigo = " & .Item("cPerCodigo3", .CurrentRow.Index).Value & "  AND cCtaCteRecibo =" & .Item("cCtaCteRecibo", .CurrentRow.Index).Value

                            If BL.Get_CountFila("CtaCteIteLine", "nCtaCteRecLine", Condicion) = 1 Then
                                MessageBox.Show("Recibo debe tener un Item y/o Servicio como minimo.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            '//

                            Dim BLD As New BL_CtaCteIteLine

                            If BLD.Del_CtaCteIteLine(.Item("cPerJurCodigo", .CurrentRow.Index).Value, .Item("cPerCodigo3", .CurrentRow.Index).Value, .Item("cCtaCteRecibo", .CurrentRow.Index).Value, .Item("nCtaCteRecLine", .CurrentRow.Index).Value, .Item("nCtaCteSerCodigo", .CurrentRow.Index).Value) Then
                                RefreshFind()
                            End If
                        End If
                    End With
                End If
        End Select

    End Sub

    Private Sub FormPrcFacturacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        CboFiltro.Items.Clear()
        CboFiltro.Items.Add("D.N.I.")
        CboFiltro.Items.Add("Apellido(s)")
        CboFiltro.Items.Add("Código Colegiado")

        '//Obtiene numero de caja configurada en la pc

        Label6.Text = Label6.Text & " - Caja Nro.: " & Microsoft.VisualBasic.Right("00" & ObtenerParametroAppConfig("NroCaja"), 2)
        LblNroCaja.Text = Microsoft.VisualBasic.Right("00" & ObtenerParametroAppConfig("NroCaja"), 2)

        LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoPer.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        CboFiltro.SelectedIndex = 0

        FormatGrilla(Table1, Me, False, 25)
        FormatGrilla(Table2, Me, False, 25)
        FormatGrilla(Table3, Me, False, 30)
        FormatGrilla(Table4, Me, False, 30)
        FormatGrilla(Table5, Me, False, 30)

        'llena CboTipoDocu segun caja asignada
        Dim ReqTDocu As New BE.CtasCtes.BE_TipoDocporNroCaja
        Dim ObjTDocu As New BL_CtaCtes.BL_CtaCteServicioFacturacion

        ReqTDocu.cPerJurCodigo = StrcPerJuridica
        ReqTDocu.nCajCodigo = CLng(ObtenerParametroAppConfig("NroCaja"))

        LlenaDataCombo(CboTipoDocu, ObjTDocu.Get_TipoDocporNroCaja(ReqTDocu), "nIntCodigo", "cIntDescripcion")
        'activa tipo docu parametrizado por default
        CboTipoDocu.SelectedValue = CLng(ObtenerParametroAppConfig("nTipoDocuDefault"))

        Call CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)
        '
        TxtBuscar.Focus()

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Close()
        Dispose()

    End Sub

    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click

        Dim StrFiltro As String = ""
        Dim StrFilNroDocu As String = ""

        Dim Request As New BE.Persona.BE_ReqPersonaSearh
        Dim ObjBL As New BL_Persona

        Select Case CboFiltro.SelectedIndex
            Case 0 ' DNI/RUC
                StrFilNroDocu = TxtBuscar.Text
                Request.cCodColegio = "N"
            Case 1 ' Apellidos
                StrFiltro = DBTilde(TxtBuscar.Text) & "%"
                Request.cCodColegio = "N"
            Case 2 ' Cod. Colegio
                StrFilNroDocu = TxtBuscar.Text
                Request.cCodColegio = "S"
                'Case 3 ' Termina
                '    StrFiltro = "%" & DBTilde(TxtBuscar.Text)
        End Select

        If TxtBuscar.Text = vbNullString Or Len(TxtBuscar.Text) <= 2 Then Exit Sub
        'Mando los parametros al Request
        Request.cNombre = StrFiltro
        Request.cPerIdeNumero = StrFilNroDocu
        Request.nPerTipo = CboTipoPer.SelectedValue
        'Recuperando registros en la DataGridView
        Table1.DataSource = ObjBL.Get_SearhPersona(Request)

        Table3.Select()
        Table3_SelectionChanged(Table3, Nothing)

    End Sub

    Private Sub TxtBuscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then Call BtnBuscar_Click(BtnBuscar, Nothing)

    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                LblcPerCodigo.Text = .Item("cPerCodigo", .CurrentRow.Index).Value.ToString
                LblApePer.Text = .Item("cPerApellPaterno", .CurrentRow.Index).Value.ToString & " " & .Item("cPerApellMaterno", .CurrentRow.Index).Value.ToString
                LblNombPer.Text = .Item("cPerPriNombre", .CurrentRow.Index).Value.ToString & " " & .Item("cPerSegNombre", .CurrentRow.Index).Value.ToString & " " & .Item("cPerTerNombre", .CurrentRow.Index).Value.ToString

                'recuperando tipos de Docu. (Peridentifica)
                Dim ReqIdPer As New BE.Persona.BE_ReqPerIdentifica
                Dim ObjIdPer As New BL_Persona

                ReqIdPer.cPerCodigo = .Item("cPerCodigo", .CurrentRow.Index).Value.ToString
                Table2.DataSource = ObjIdPer.Get_PerIdentifica(ReqIdPer)

                'recuperar servicios pendientes por pagar
                Dim RepSerFac As New BE.CtasCtes.BE_CtaCteServicioFacturacion
                Dim ObjSerFac As New BL_CtaCtes.BL_CtaCteServicioFacturacion

                RepSerFac.cPerCodigo = .Item("cPerCodigo", .CurrentRow.Index).Value.ToString
                Table3.DataSource = ObjSerFac.Get_CtaCteServicioFacturacion(RepSerFac)

                Dim ObtenerLastFecPago As New BL_LastFecPago_for_Servicio

                Table5.DataSource = ObtenerLastFecPago.Get_LastPago_for_Servicio(LblcPerCodigo.Text)

            End If
        End With

    End Sub

    Private Sub FormPrcFacturacion_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        'Table3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top _
        '                            Or System.Windows.Forms.AnchorStyles.Bottom _
        '                            Or System.Windows.Forms.AnchorStyles.Left _
        '                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        Table3.Width = Me.Width - 308
        Table3.Height = Me.Height - 355

        LblCaptionGrd.Width = Table3.Width
        LblMsgItem.Location = New Point(8, SplitContainer3.Panel1.Height - 15)

        LblMsgItemDel.Location = New Point(448, SplitContainer3.Panel1.Height - 15)

        Table4.Width = LblCaptionGrd.Width - 309
        Label7.Width = LblCaptionGrd.Width

    End Sub

    Private Sub CboTipoDocu_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoDocu.SelectionChangeCommitted

        Dim ObjSerieCorre As New BL_CtaCteNumeracion

        LblSerie.Text = Microsoft.VisualBasic.Left(ObjSerieCorre.Get_CtaCteNumCorrelativo(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), CLng(CboTipoDocu.SelectedValue)), 4)
        LblCorrelativo.Text = Microsoft.VisualBasic.Right(ObjSerieCorre.Get_CtaCteNumCorrelativo(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), CLng(CboTipoDocu.SelectedValue)), 8)

    End Sub

    Private Sub BtnRegPago_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegPago.Click

        If Table2.RowCount = 0 Then Exit Sub

        '//Validar si tiene DNI y/o RUC segun tipo de documento
        If CboTipoDocu.SelectedValue = 3001 Then 'Factura
            If Not BuscaCadenaDgView("nPerIdeTipo2", "11", Table2) Then
                MessageBox.Show("Cliente NO registra R.U.C.,  por favor de registrar el tipo documento.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            If Not BuscaCadenaDgView("nPerIdeTipo2", "25", Table2) Then
                MessageBox.Show("Cliente NO registra D.N.I., por favor de registrar el tipo documento.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        '// Validando SI Recibo a cancelar tiene ya una parte de pago
        '// no puede generar Factura o Boleta
        If CDbl(LblTCancel.Text) > 0 And (CboTipoDocu.SelectedValue = 3001 Or CboTipoDocu.SelectedValue = 3003) Then
            MessageBox.Show("Recibo " & LblNroRecibo.Text & "; esta siendo Cancelado por partes/credito, No podra generar documentos de Ventas (Factura y/o Boleta)", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Table3.RowCount = 0 Or LblNroRecibo.Text = vbNullString Then MessageBox.Show("No hay ningun Recibo seleccionado para realizar pago; Verifique por facvor.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information) : TxtBuscar.Focus() : Exit Sub

        'Recalcula si hay Check seleccionados
        RecalcularPagoMulti()

        OperacionPago = 0

        StrPasaValores = "cNroRecibo=" & LblNroRecibo.Text & ";"
        StrPasaValores = StrPasaValores & "nImpRecibo=" & FormatNumber(LblPendPago.Text, True) & ";"
        StrPasaValores = StrPasaValores & "nTipoDocu=" & CboTipoDocu.SelectedValue

        FormPrcFormaPago.ShowDialog()

        'Using frmPago As New FormPrcFormaPago()
        '    Dim dr As DialogResult = frmPago.ShowDialog(Me)

        '    If (dr = Windows.Forms.DialogResult.Cancel) Then
        '        MessageBox.Show("Se ha cancelado el cuadro de diálogo.", "Forma Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Return
        '    End If

        'End Using

        '//si OperacionPago -> sea ha registrado el pago.
        If OperacionPago = 1 Then
            If MessageBox.Show("Verifique Impresora, porque se procedera a imprimir Documento de venta. ¿Desea continuar.?", "Imprimiendo..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                BtnImprimir_Click(BtnImprimir, Nothing)
            End If
            RefreshFind()
        End If

        StrPasaValores = vbNullString

    End Sub

    Private Sub BtnAddServicio_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddServicio.Click

        If LblcPerCodigo.Text = vbNullString Then MessageBox.Show("No hay ningun Cliente seleccionado; Verifique por favor.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information) : TxtBuscar.Focus() : Exit Sub
        nOperacion = 1
        FormPrcProgramarServicio.ShowDialog()
        'Call BtnBuscar_Click(BtnBuscar, Nothing)
        RefreshFind()
    End Sub

    Private Sub BtnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles BtnImprimir.Click

        Try
            If Table3.RowCount = 0 Then Exit Sub

            Dim NameFileRpt As String = vbNullString

            Select Case CboTipoDocu.SelectedValue
                Case 3001
                    NameFileRpt = "rptFormatoFactura.rpt"
                Case 3003
                    NameFileRpt = "rptFormatoBoleta.rpt"
                Case 3005
                    NameFileRpt = "rptFormatoRecIng.rpt"
                Case 3008
                    NameFileRpt = "rptFormatoRecIng.rpt"
            End Select

            '//Imprimir
            Dim CrReport As New ReportDocument

            '//Asigno el reporte 
            CrReport = New ReportDocument()
            'CrReport.Load(cPathRPT & "rptFormatoReciboIngresoFac.rpt")
            CrReport.Load(cPathRPT & NameFileRpt) '"rptFormatoRecIng.rpt")

            'CrReport.DataDefinition.FormulaFields(0).Text = Chr(34) & "Desde: " & Format(C1Dtp_FecIni.Value, "dd/MM/yyyy") & " hasta " & Format(C1Dtp_FecFin.Value, "dd/MM/yyyy") & Chr(34)

            Dim BL As New BL_CtaCtes.BL_CtaCteComprobante

            CrReport.SetDataSource(BL.Get_CtaCteComprobante(StrcPerJuridica, LblcPerCodigo.Text, CLng(CboTipoDocu.SelectedValue), (LblSerie.Text & "-" & LblCorrelativo.Text)))
            CrReport.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

            FormCrystalReport.Text = "envio a la impresora..."

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            FormCrystalReport.CrystalRptVwr.PrintReport()
            'FormCrystalReport.Show()

            '//Despues de mostrar el recibo para actuliza correlativo en pantalla
            CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)

            RefreshFind()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Table3_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table3.SelectionChanged

        Dim BL As New BL_ImpuestoServicio

        With Table3
            If .RowCount > 0 Then
                Table3.Select()
                LblNroRecibo.Text = .Item("cCtaCteRecibo", .CurrentRow.Index).Value
                LblTCancel.Text = CDbl(.Item("nCtaCteImpAplicado", .CurrentRow.Index).Value)
                LblImpRecibo.Text = Suma_Columna_for_condicion("nCtaCteLinImporte", "cCtaCteRecibo", .Item("cCtaCteRecibo", .CurrentRow.Index).Value, Table3)
                LblPendPago.Text = CDbl(LblImpRecibo.Text) - CDbl(LblTCancel.Text)

                '//carga Impuestos Aplicados por Nro. Recibo (CtaCteIteLinRetencion)
                Table4.DataSource = BL.Get_Calc_Impuesto_for_cCtaCteRecibo(StrcPerJuridica, LblcPerCodigo.Text, LblNroRecibo.Text)
            End If
        End With

    End Sub

    Private Sub Table3_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Table3.CurrentCellDirtyStateChanged
        'Obligatorio para columnas tipo check
        If Table3.IsCurrentCellDirty Then
            Table3.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Function EstadoCheck(ByVal filaposicion As Integer) As Boolean

        Return Me.Table3.Rows(filaposicion).Cells("nCtaCtePedCodigo").Value

    End Function

    Private Sub Table3_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table3.CellContentClick
        'El evento CellContentClick indica que el usuario ha hecho clic en un campo y su valor ha cambiado

        If e.RowIndex = -1 Then
            Return
        End If

        '//Validando Col(nCtaCteImpAplicado) es CERO
        With Table3
            '//verficando el recibo no tenga pagos parciales
            If .CurrentCell.ColumnIndex = 0 Then
                If CDbl(.Rows(e.RowIndex).Cells("nCtaCteImpAplicado").Value) > 0 Then
                    MessageBox.Show("No puede agrupar Recibo ►" & .Rows(e.RowIndex).Cells("cCtaCteRecibo").Value & "◄, porque tiene pagos parciales.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Item("nCtaCtePedCodigo", e.RowIndex).Value = 0 'Desmarcando
                    .RefreshEdit()
                    RecalcularPagoMulti()
                    Exit Sub
                End If
            End If

            '//verficando que el agrupamiento sea un solo tipo de "Servicio"
            For Each row As DataGridViewRow In Table3.Rows
                If .Item("nCtaCtePedCodigo", row.Index).Value = 1 Then
                    If CStr(row.Cells("nCtaCteSerCodigo").Value) <> CStr(.Rows(e.RowIndex).Cells("nCtaCteSerCodigo").Value) Then
                        MessageBox.Show("Agrupación de recibo No válida; solo puede agrupar recibos por el mismo servicio ►" & CStr(row.Cells("cIntDescripcion").Value) & "◄.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        .Item("nCtaCtePedCodigo", e.RowIndex).Value = 0 'Desmarcando
                        .RefreshEdit()
                        RecalcularPagoMulti()
                        Exit For
                    End If
                End If
            Next

            Dim valorCheck As Integer

            'Pregunto si el campo que se hizo clic es el del check       
            If e.ColumnIndex = Convert.ToInt32(.Columns("nCtaCtePedCodigo").Index) Then
                valorCheck = .Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                'ValorCheck obtiene 0 o 1
                '
                RecalcularPagoMulti()
                '
            End If

        End With
    End Sub

    Private Sub RecalcularPagoMulti()

        With Table3
            If .RowCount = 0 Then Exit Sub 'MsgBox("Estado: " & EstadoCheck(e.RowIndex))
            'seteo el campo
            LblImpRecibo.Text = 0

            For I As Integer = 0 To .RowCount - 1
                If EstadoCheck(I) Then
                    LblImpRecibo.Text = FormatNumber(CDbl(LblImpRecibo.Text) + CDbl(.Rows(I).Cells("nCtaCteLinImporte").Value), True)
                    LblTCancel.Text = 0
                    LblPendPago.Text = LblImpRecibo.Text
                End If
            Next
        End With

    End Sub

    Private Sub Table3_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table3.CellValueChanged

        'With Table3
        '    If .RowCount = 0 Then Exit Sub 'MsgBox("Estado: " & EstadoCheck(e.RowIndex))
        '    'seteo el campo
        '    LblImpRecibo.Text = 0

        '    For I As Integer = 0 To .RowCount - 1
        '        If EstadoCheck(I) Then
        '            LblImpRecibo.Text = FormatNumber(CDbl(LblImpRecibo.Text) + CDbl(.Rows(I).Cells("nCtaCteLinImporte").Value), True)
        '            LblTCancel.Text = 0
        '            LblPendPago.Text = LblImpRecibo.Text
        '        End If
        '    Next
        'End With

    End Sub

    'Private Sub Table3_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table3.CellContentClick
    '    '
    '    ' Detecta si se ha seleccionado el header de la grilla
    '    '
    '    If e.RowIndex = -1 Then
    '        Return
    '    End If

    '    '//Validando si Ya cancelo en su totalidad el derecho de pago para colegiarse
    '    'With Table1
    '    '    If .CurrentCell.ColumnIndex = 0 Then
    '    '        If (CDbl(.Item("nCtaCteImpAplicado", .CurrentRow.Index).Value) - CDbl(.Item("nCtaCteImporte", .CurrentRow.Index).Value)) = 0 Or CDbl(.Item("nCtaCteImpAplicado", .CurrentRow.Index).Value) = 0 Then
    '    '            MessageBox.Show("Aun no ha cancelado en su totalidad el Pago por derecho a Colegiatura.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '            .Item("nPerAdmEstado", .CurrentRow.Index).Value = 0
    '    '            Table1.RefreshEdit()
    '    '            Exit Sub
    '    '        End If
    '    '    End If
    '    'End With

    '    If Table3.Columns(e.ColumnIndex).Name = "nSeleccion" Then

    '        '
    '        ' Se toma la fila seleccionada
    '        '
    '        Dim row As DataGridViewRow = Table3.Rows(e.RowIndex)

    '        '
    '        ' Se selecciona la celda del checkbox
    '        '
    '        Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("nSeleccion"), DataGridViewCheckBoxCell)

    '        'If Convert.ToBoolean(cellSelecion.Value) Then
    '        MsgBox(cellSelecion.Value)
    '        If Convert.ToInt32(cellSelecion.Value) Then
    '            row.DefaultCellStyle.BackColor = Color.LightCoral
    '        Else
    '            row.DefaultCellStyle.BackColor = Color.White
    '        End If

    '    End If
    'End Sub


    'Private Sub Table3_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table3.CellContentClick
    '    'El evento CellContentClick indica que el usuario ha hecho clic en un campo y su valor ha cambiado

    '    Dim valorCheck As Integer

    '    'Pregunto si el campo que se hizo clic es el del check       
    '    If e.ColumnIndex = Table3.Columns("nSeleccion").Index Then
    '        valorCheck = Table3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '        'valorCheck obtiene 0 o 1
    '    End If
    'End Sub

    Private Sub Table1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellContentClick

    End Sub

    Private Sub CboTipoPer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboTipoPer.SelectedIndexChanged

        CboFiltro.Items.Clear()
        If CboTipoPer.SelectedValue = 1 Then
            CboFiltro.Items.Add("D.N.I.")
            CboFiltro.Items.Add("Apellido(s)")
            CboFiltro.Items.Add("Código Colegiado")
        Else
            CboFiltro.Items.Clear()
            CboFiltro.Items.Add("R.U.C.")
            CboFiltro.Items.Add("Razon Social")
            CboFiltro.Items.Add("Código Colegiado")
        End If

        CboFiltro.SelectedIndex = 0

    End Sub
End Class