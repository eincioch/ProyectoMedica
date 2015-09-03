
Imports Integration.BE
Imports Integration.BL
Imports Integration.BL.BL_Reportes


Public Class FormPrcLibroVta

    Private Sub FormPrcLibroVta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        FormatGrilla(Table1, Me, True, 30)

        Dim Request As New Sistema.BE_ReqPeriodo
        Dim Obj As New BL_Sistema

        'Llena Año
        Request.cPerJurCodigo = StrcPerJuridica
        Request.cflag = "A" 'Año
        Request.cAnno = ""
        LlenaDataCombo(CboAnno, Obj.Get_Periodo(Request), "nPrdCodigo", "cPrdDescripcion")
        CboMes.SelectedIndex = 0

    End Sub

    Private Sub FormPrcLibroVta_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Table1.Width = Width - 30
        Table1.Height = Height - 125
    End Sub

    Private Sub BtnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnMostrar.Click

        Dim BL As New BL_BookElectronicoVta
        Table1.DataSource = BL.Get_CtasCtes_Get_LibroVentas_Electronico(CLng(CboAnno.Text), CLng(CboMes.SelectedIndex) + 1, StrcPerJuridica)

    End Sub

    Private Sub BtnExport_Click(sender As System.Object, e As System.EventArgs) Handles BtnExport.Click
        'ExportarDatosPDF(Table1)
        ExportarDatosExcel(Table1, "Libro Electronico Ventas")

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub BtnExportTxt_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportTxt.Click

        If Table1.RowCount = 0 Then Exit Sub

        ExportTXT(Table1, "|")

    End Sub
End Class