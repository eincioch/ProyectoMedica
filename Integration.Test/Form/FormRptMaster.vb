Imports Integration.BE
Imports Integration.BE.CtasCtes
Imports Integration.BL
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_Reportes
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormRptMaster

    Dim CampoFormula As New Dictionary(Of String, String)

    Private Sub LlenaCboServicio()
        LlenaDataCombo(CboTipoCta, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoCta.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        CboTipoCta.SelectedValue = 1001 'Default CUOTAS ORDINARIAS

        CboTipoCta_SelectionChangeCommitted(CboTipoCta, Nothing)
    End Sub

    Private Sub FormRptMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        TreeViewList.ExpandAll()

    End Sub

    Private Sub TreeViewList_NodeMouseClick(sender As Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewList.NodeMouseClick

        Cursor.Current = Cursors.WaitCursor
        ' MsgBox(e.Node.Name)
        Select Case e.Node.Name
            Case "Nodo2", "Nodo3", "Nodo4", "Nodo6", "Nodo7"
                LblMsg.Visible = False
                GrpBxEstadoCta.Visible = False
                GrpBxRangoFec.Visible = True

            Case "Nodo9"
                LblMsg.Visible = False
                GrpBxRangoFec.Visible = False
                DtpFecCorte.Visible = False
                Label7.Visible = False

                GrpBxEstadoCta.Visible = True

                LlenaCboServicio()

            Case "Nodo10"
                LblMsg.Visible = False
                GrpBxRangoFec.Visible = False
                DtpFecCorte.Visible = True
                Label7.Visible = True

                GrpBxEstadoCta.Visible = True

                LlenaCboServicio()

            Case Else
                GrpBxEstadoCta.Visible = False
                GrpBxRangoFec.Visible = False
                LblMsg.Visible = True

                LblMsg.Text = "Seleccione una Opcion del panel de la Izquierda..."

        End Select

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoCta.SelectionChangeCommitted

        Dim Request As New BE_ReqCtaCteServBusca
        Dim DaServ As New BL_CtaCtaServicio

        Request.cPerJurCodigo = StrcPerJuridica
        Request.nFlag = "TCTA"

        Request.nCtaCteTipoCta() = CboTipoCta.SelectedValue
        LlenaDataCombo(CboServicios, DaServ.Get_CtaCteServicio(Request), "nCtaCteSerCodigo", "cIntDescripcion")

    End Sub

    Private Sub BtnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnMostrar.Click

        Try
            Cursor.Current = Cursors.WaitCursor

            Dim BL As New BL_RptCuadreCaja

            Dim CrReport As New ReportDocument

            Select Case TreeViewList.SelectedNode.Name
                Case "Nodo2"
                    '//Por Comprobante - Resumido

                    ' If BL.Get_ReportCuadraCaja("RES", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

                    CampoFormula.Add("rangofec", "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy"))

                    'CargaReporte((cPathRPT & "rptCuadreCajaResumen.rpt"), CrystalRptVwr, CampoFormula, BL.Get_ReportCuadraCaja("RES", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))

                Case "Nodo3"
                    '//Por Comprobante - Detallado

                    'If BL.Get_ReportCuadraCaja("DET", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

                    CampoFormula.Add("rangofec", "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy"))

                    'CargaReporte((cPathRPT & "rptCuadreCajaDetalle.rpt"), CrystalRptVwr, CampoFormula, BL.Get_ReportCuadraCaja("DET", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))

                Case "Nodo4"
                    '//Forma de pago

                    'If BL.Get_ReportCuadraCaja("PGO", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

                    CampoFormula.Add("rangofec", "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy"))

                    'CargaReporte((cPathRPT & "rptCuadreCajaFormaPago.rpt"), CrystalRptVwr, CampoFormula, BL.Get_ReportCuadraCaja("PGO", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))

                Case "Nodo6"
                    '//Ingresos por servicios

                    'If BL.Get_ReportCuadraCaja("SRV", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

                    CampoFormula.Add("rangofec", "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy"))

                    'CargaReporte((cPathRPT & "rptAcumuladoXServicios.rpt"), CrystalRptVwr, CampoFormula, BL.Get_ReportCuadraCaja("SRV", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))

                Case "Nodo7"
                    '//Ingresos por servicios

                    'If BL.Get_ReportCuadraCaja("PER", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

                    CampoFormula.Add("rangofec", "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy"))

                    ' CargaReporte((cPathRPT & "RptIngresoPercibidoDetaforServCliente.rpt"), CrystalRptVwr, CampoFormula, BL.Get_ReportCuadraCaja("PER", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))


            End Select

            CampoFormula.Clear()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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
            Request.nPerTipo = 1 'Natural
            Request.cCodColegio = "S" 'Default codigo de colegiado

            If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

            If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
                LblcPerCodPer.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
                LblcNomRepre.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")
            End If
        End If
    End Sub

 
    Private Sub BtnMostarEstado_Click(sender As System.Object, e As System.EventArgs) Handles BtnMostarEstado.Click

        '//Ingresos por servicios

        Try
            Cursor.Current = Cursors.WaitCursor

            Select Case TreeViewList.SelectedNode.Name
                Case "Nodo9"

                    Dim BLEst As New BL_EstadoCuentaCole

                    'If BLEst.Get_EstadoCuentaCole("", TxtNroPer.Text, CLng(CboServicios.SelectedValue)).Rows.Count = 0 Then Exit Sub

                    CampoFormula.Add("rangofec", "Servicio: " & CboServicios.Text)

                    CargaReporte((cPathRPT & "rptEstadoCuentaCole.rpt"), CrystalRptVwr, CampoFormula, BLEst.Get_EstadoCuentaCole("", TxtNroPer.Text, CLng(CboServicios.SelectedValue)))

                Case "Nodo10"
                    'CtaCte_Get_Colegiadohabil_By_Servicio

                    Dim BLEst As New BL_CtaCte_Get_Colegiadohabil_By_Servicio

                    'If BLEst.Get_EstadoCuentaCole("", TxtNroPer.Text, CLng(CboServicios.SelectedValue)).Rows.Count = 0 Then Exit Sub

                    CampoFormula.Add("rangofec", "Servicio: " & CboServicios.Text)

                    CargaReporte((cPathRPT & "RptColegiadohabil_By_Servicio.rpt"), CrystalRptVwr, CampoFormula, BLEst.CtaCte_Get_Colegiadohabil_By_Servicio("", TxtNroPer.Text, Format(DtpFecCorte.Value, "dd/MM/yyyy"), CLng(CboServicios.SelectedValue)))

            End Select

            CampoFormula.Clear()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CampoFormula.Clear()
        End Try

    End Sub
End Class