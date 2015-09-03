Option Explicit On
Imports Integration.BE.FichaAtencion
Imports Integration.BL.BL_FichaAtencion

Imports CrystalDecisions.CrystalReports.Engine

Public Class FormGridFichaAtencion

    Enum GrillaAdmSolicitud
        'ColnKey = 0
        ColcPerJuridica = 2
        ColnIntCodigo = 3
        ColcIntDescripcion = 4
        ColcPerCodigoTerceros = 5
        ColnSolAdmNumero = 6
        ColcPerCodigo = 7
        ColcPerIdeNumero = 8
        ColcPerApellidos = 9
        ColcPerNombreCompleto = 10
        ColdPerNacimiento = 11
        ColdFecRegistro = 12
        ColdFecExamen = 13
        ColdFecEntResultado = 14
        'ColnKey1 = 14
        ColnAdmSolEstado = 15
        ColcConDescripcion = 16
        ColnImpTotal = 17
        ColcCtaCteRecibo = 18
        ColcPerUseCodigo = 19
        ColnPerTipo = 20
        ColnCtaCteComCodigo = 21
        ColnDescTipoDocu = 22
        ColncCtaCteComNumero = 23
    End Enum

    Private Sub CargaIconGrilla()
        With Table1
            For i As Integer = 0 To .Rows.Count - 1

                'If (CDbl(.Item("nCtaCteImporte", i).Value) > 0 And CDbl(.Item("nCtaCteImpAplicado", i).Value) = 0) Then .Rows(i).Cells("nCtaCteEstado").Value = 3

                Dim columnHeaderStyle As New DataGridViewCellStyle()

                '.Rows(i).Cells("DescCtaCteEstado").Style.Font.Style = FontStyle.Bold.ToString
                columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)

                '.ColumnHeadersDefaultCellStyle = columnHeaderStyle
                .RowHeadersDefaultCellStyle = columnHeaderStyle

                Select Case .Rows(i).Cells("nAdmSolEstado").Value
                    Case Is = 1 'Pendiente de apgo
                        .Rows(i).Cells("cConDescripcion").Style.ForeColor = Color.Red
                    Case Is = 2  'cancelado
                        .Rows(i).Cells("cConDescripcion").Style.ForeColor = Color.Blue

                    Case Is = 3 'toma de examen 
                        .Rows(i).Cells("cConDescripcion").Style.ForeColor = Color.Green

                    Case Is = 3 'finalizado
                        .Rows(i).Cells("cConDescripcion").Style.ForeColor = Color.AliceBlue
                End Select

                If CDate(.Rows(i).Cells("dFecEntResultado").Value) = CDate("1900-01-01") Then
                    .Rows(i).Cells("dFecEntResultado").Style.Format = "d"
                    .Rows(i).Cells("dFecEntResultado").Style.ForeColor = Color.White
                    .Rows(i).Cells("dFecEntResultado").Style.SelectionForeColor = Color.CornflowerBlue
                End If

                'Carga png "nIntCodigo"
                Select Case .Rows(i).Cells("nIntCodigo").Value
                    Case Is = 1001 'Particular
                        .Rows(i).Cells("Imagen").Value = My.Resources.aol_messenger
                    Case Is = 1002 'Lab. Externo
                        .Rows(i).Cells("Imagen").Value = My.Resources.resources1
                    Case Is = 1003 'Convenio
                        .Rows(i).Cells("Imagen").Value = My.Resources.house_two
                End Select

                'Carga png "nAdmSolEstado"
                Select Case .Rows(i).Cells("nAdmSolEstado").Value
                    Case Is = 1 'pendiente de pago
                        .Rows(i).Cells("ImgStatus").Value = My.Resources.price_alert
                    Case Is = 2 'Pago programado (Recibo) 
                        .Rows(i).Cells("ImgStatus").Value = My.Resources.company_generosity
                    Case Is = 3 'cancelado  (Pago realizado)
                        .Rows(i).Cells("ImgStatus").Value = My.Resources.total_plan_cost
                    Case Is = 4 'toma de muestra
                        .Rows(i).Cells("ImgStatus").Value = My.Resources.injection
                    Case Is = 5 'Finalizzado
                        .Rows(i).Cells("ImgStatus").Value = My.Resources.client_account_template
                    Case Is = 6 'resultado Entregado
                        .Rows(i).Cells("ImgStatus").Value = My.Resources.license_management
                End Select

            Next
        End With
    End Sub

    Private Sub FormGridFichaAtencion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F5))
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6))
                c1CmdNuevo_Click(c1CmdNuevo, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7))
                C1CmdEdit_Click(C1CmdEdit, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F9))
                c1CmdPago_Click(c1CmdPago, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select

    End Sub

    Private Sub FormGridPersona_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        'Table1.Width = Width - 35
        'Table1.Height = Height - 155
        Table1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top _
            Or System.Windows.Forms.AnchorStyles.Bottom _
            Or System.Windows.Forms.AnchorStyles.Left _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    End Sub

    Private Sub FormGridFichaAtencion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CboFiltro.SelectedIndex = 0
        Me.WindowState = FormWindowState.Maximized

        FormatGrilla(Table1, Me, True)


    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        nFlagAdmision = 1 'nuevo registro 

        'cNewCodigoPer = Get_Valor("Exec usp_Persona_Get_NewId", "NewCodigo")
        FormPrcSolAtencion.ShowDialog()

        CboFiltro.SelectedIndex = 0
        C1CmdBuscar_Click(C1CmdBuscar, Nothing)

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        Try
            If Table1.RowCount = 0 Then Exit Sub

            With Table1
                If Not .CurrentCell Is Nothing Then
                    If .Item(GrillaAdmSolicitud.ColnAdmSolEstado, .CurrentRow.Index).Value = 1 Then
                        StrPasaAdmFicha = vbNullString
                        'StrPasaAdmFicha = "cPerJuridica=" & .Item(GrillaAdmSolicitud.ColcPerJuridica, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nIntCodigo=" & .Item(GrillaAdmSolicitud.ColnIntCodigo, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cIntDescripcion=" & .Item(GrillaAdmSolicitud.ColcIntDescripcion, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerCodigoTerceros=" & .Item(GrillaAdmSolicitud.ColcPerCodigoTerceros, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nSolAdmNumero=" & .Item(GrillaAdmSolicitud.ColnSolAdmNumero, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerCodigo=" & .Item(GrillaAdmSolicitud.ColcPerCodigo, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerIdeNumero=" & .Item(GrillaAdmSolicitud.ColcPerIdeNumero, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cPerApellidos=" & .Item(GrillaAdmSolicitud.ColcPerApellidos, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cPerNombreCompleto=" & .Item(GrillaAdmSolicitud.ColcPerNombreCompleto, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "dPerNacimiento=" & .Item(GrillaAdmSolicitud.ColdPerNacimiento, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "dFecRegistro=" & .Item(GrillaAdmSolicitud.ColdFecRegistro, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "dFecExamen=" & .Item(GrillaAdmSolicitud.ColdFecExamen, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "dFecEntResultado=" & .Item(GrillaAdmSolicitud.ColdFecEntResultado, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nAdmSolEstado=" & .Item(GrillaAdmSolicitud.ColnAdmSolEstado, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cConDescripcion=" & .Item(GrillaAdmSolicitud.ColcConDescripcion, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "nImpTotal=" & .Item(GrillaAdmSolicitud.ColnImpTotal, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerUseCodigo=" & .Item(GrillaAdmSolicitud.ColcPerUseCodigo, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nPerTipo=" & .Item(GrillaAdmSolicitud.ColnPerTipo, .CurrentRow.Index).Value.ToString

                        'determinando acccion
                        nFlagAdmision = 2 'modificando

                        FormPrcSolAtencion.Text = "Actualizando Registro Ficha de Atención..."
                        FormPrcSolAtencion.ShowDialog()
                        C1CmdBuscar_Click(C1CmdBuscar, Nothing)
                    End If

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub C1CmdBuscar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdBuscar.Click

        Dim StrFiltro As String = ""
        Dim StrFilNroDocu As String = ""

        Dim ObjBL As New BL_FichaAtencion

        Select Case CboFiltro.SelectedIndex
            Case 0 'Nro.Ficha(Atención)
                Table1.DataSource = ObjBL.Get_List_AdmSolAtencion("S", TxtBuscar.Text, "", "", "", "")
            Case 1 'D.N.I.
                Table1.DataSource = ObjBL.Get_List_AdmSolAtencion("D", "", TxtBuscar.Text, "", "", "")
            Case 2 'Apellidos
                Table1.DataSource = ObjBL.Get_List_AdmSolAtencion("A", "", "", TxtBuscar.Text, "", "")
            Case 3 'Rango(Fechas)
                'codigo Old
                'If Date.Parse(DtpFecIni.Value.Date) > Date.Parse(DtpFecFin.Value.Date) Then
                '    MessageBox.Show("Rango de Fechas no son coherentes.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    DtpFecIni.Value = DtpFecFin.Value
                '    Exit Sub
                'End If
                If Not ValidaRangoFechas(DtpFecIni.Value.Date, DtpFecFin.Value.Date) Then
                    DtpFecIni.Value = DtpFecFin.Value
                    Exit Sub
                End If
                Table1.DataSource = ObjBL.Get_List_AdmSolAtencion("R", "", "", "", DtpFecIni.Value.ToString, DtpFecFin.Value.ToString)

        End Select

        CargaIconGrilla()

        LblMsg.Text = "Se encontraron " & Table1.RowCount & " registros, como resultado de la busqueda."

    End Sub

    Private Sub CboFiltro_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboFiltro.SelectionChangeCommitted

        Select Case CboFiltro.SelectedIndex
            Case 0, 1, 2
                TxtBuscar.Visible = True : TxtBuscar.Text = vbNullString: TxtBuscar.Focus() : Panel1.Visible = False
            Case 3
                TxtBuscar.Visible = False : Panel1.Visible = True
        End Select
    End Sub

    Private Sub Table1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellDoubleClick
        Call C1CmdEdit_Click(C1CmdEdit, Nothing)
    End Sub

    Private Sub TxtBuscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then Call C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then Call C1CmdBuscar_Click(C1CmdBuscar, Nothing)

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdPago_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdPago.Click

        With Table1
            If .Rows.Count > 0 Then
                Select Case .Item(GrillaAdmSolicitud.ColnAdmSolEstado, .CurrentRow.Index).Value
                    Case EstadoFichaAtencion.nPendientePago
                        MessageBox.Show("Recibo de pago <No> ha sido programado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nProgramado
                        StrPasaValores = vbNullString
                        REM pasando valores
                        StrPasaValores = "cNroRecibo=" & .Item(GrillaAdmSolicitud.ColcCtaCteRecibo, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "nSolAdmNumero=" & .Item(GrillaAdmSolicitud.ColnSolAdmNumero, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "nImpRecibo=" & .Item(GrillaAdmSolicitud.ColnImpTotal, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "cPerCodigo=" & .Item(GrillaAdmSolicitud.ColcPerCodigo, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "nPerTipo=" & .Item(GrillaAdmSolicitud.ColnPerTipo, .CurrentRow.Index).Value.ToString()
                        FormPrcFormaPago.ShowDialog()
                        'actualiza Grilla
                        C1CmdBuscar_Click(C1CmdBuscar, Nothing)

                    Case EstadoFichaAtencion.nPagoRealizado
                        MessageBox.Show("Recibo de pago, <Ya> ha sido cancelado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nTomaExamen
                        MessageBox.Show("Paciente esta pasando sus Exámenes en este momento.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nFinalizado
                        MessageBox.Show("La Toma de Exámen ya terminado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nEntregado
                        MessageBox.Show("Ficha de Atención ya ha sido Entregado al Paciente.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Select
            End If
        End With

    End Sub

    Private Sub Table1_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Table1.ColumnHeaderMouseClick
        'evento cuando ordena por columnas 
        CargaIconGrilla()
    End Sub

    Private Sub ImprimirFichaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirFichaToolStripMenuItem.Click

        If Table1.RowCount = 0 Then Exit Sub

        Dim CrReport As New ReportDocument

        Try
            Dim BL As New BL_FichaAtencion

            ' Asigno el reporte 
            'If BL.Get_ReportCuadraCaja("RES", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptFichaSolicitudporPaciente.rpt")

            'CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

            CrReport.SetDataSource(BL.Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(StrcPerJuridica, Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value.ToString(), Table1.Item(GrillaAdmSolicitud.ColcPerCodigo, Table1.CurrentRow.Index).Value.ToString()))

            FormCrystalReport.Text = "Ficha de Atención - Admisión"

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class

