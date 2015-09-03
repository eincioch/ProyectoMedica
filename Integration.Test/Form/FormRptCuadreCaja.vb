Imports Integration.BL.BL_Reportes
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormRptCuadreCaja

    Private Sub BtnResumen_Click(sender As System.Object, e As System.EventArgs) Handles BtnResumen.Click

        Dim CrReport As New ReportDocument

        Try
            Dim BL As New BL_RptCuadreCaja

            ' Asigno el reporte 
            'If BL.Get_ReportCuadraCaja("RES", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptCuadreCajaResumen.rpt")

            CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

            CrReport.SetDataSource(BL.Get_ReportCuadraCaja(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))

            FormCrystalReport.Text = "Reporte Venta Resumen..."

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BtnDetalle_Click(sender As System.Object, e As System.EventArgs) Handles BtnDetalle.Click

        Cursor.Current = Cursors.WaitCursor

        Dim CrReport As New ReportDocument

        Try
            Dim BL As New BL_RptCuadreCaja

            'If BL.Get_ReportCuadraCaja("DET", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub
            ' Asigno el reporte 
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptCuadreCajaDetalle.rpt")

            CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

            'CrReport.SetDataSource(BL.Get_ReportCuadraCaja("DET", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))

            FormCrystalReport.Text = "Reporte Venta Detallado..."

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Cursor.Current = Cursors.Default

    End Sub

End Class