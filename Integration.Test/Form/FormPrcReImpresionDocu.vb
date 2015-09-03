Option Explicit On
Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCtes
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormPrcReImpresionDocu

    Private Sub CboTipoDocu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboTipoDocu.SelectedIndexChanged

    End Sub

    Private Sub FormPrcReImpresionDocu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'llena CboTipoDocu segun caja asignada
        Dim ReqTDocu As New BE_TipoDocporNroCaja
        Dim ObjTDocu As New BL_CtaCteServicioFacturacion

        ReqTDocu.cPerJurCodigo = StrcPerJuridica
        ReqTDocu.nCajCodigo = CLng(ObtenerParametroAppConfig("NroCaja"))

        LlenaDataCombo(CboTipoDocu, ObjTDocu.Get_TipoDocporNroCaja(ReqTDocu), "nIntCodigo", "cIntDescripcion")
        'activa tipo docu parametrizado por default
        CboTipoDocu.SelectedValue = CLng(ObtenerParametroAppConfig("nTipoDocuDefault"))

    End Sub

    Private Sub BtnReImprimir_Click(sender As System.Object, e As System.EventArgs) Handles BtnReImprimir.Click

        Try

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

            Dim BL As New BL_CtaCteComprobante

            CrReport.SetDataSource(BL.Get_CtaCteComprobante(StrcPerJuridica, "", CLng(CboTipoDocu.SelectedValue), (TxtSerie.Text & "-" & TxtCorrelativo.Text)))
            CrReport.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
            'CrReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait

            FormCrystalReport.Text = "envio a la impresora..."
            FormCrystalReport.CrystalRptVwr.ShowGroupTreeButton = False
            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora

            FormCrystalReport.CrystalRptVwr.PrintReport()
            'FormCrystalReport.Show()

            '//Despues de mostrar el recibo para actuliza correlativo en pantalla
            'CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)

            'RefreshFind()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Close()
        Dispose()

    End Sub


    Private Sub TxtCorrelativo_LostFocus(sender As Object, e As System.EventArgs) Handles TxtCorrelativo.LostFocus
        TxtCorrelativo.Text = Microsoft.VisualBasic.Right("00000000" & TxtCorrelativo.Text, 8)
    End Sub


End Class