Imports Integration.BE
Imports Integration.BL
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormGridAfiliacion

    Enum GrillaAfiliacion
        ColnEstado = 0
        ColcDocCodigo = 1
        ColdDocFecRegistro = 2
        Colnropoliza = 3
        ColnDocTipo = 4
        ColcDocTipo = 5
        ColCodColegio = 6
        Colcdni = 7
        ColcTitular = 8
        ColdFechaFin = 9
        ColtDocConContenido = 10
        ColnNroBeneficiarios = 11

    End Enum

    Private Sub FormGridAfiliacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")

        CboFiltro.SelectedIndex = 0
        Me.WindowState = FormWindowState.Maximized
        FormatGrilla(Table1, Me, True)

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        nAccionBotones = nAccionButton.nAccionNuevo
        FormPrcAfiliacion.Text = "Agregando nueva afiliación.."
        FormPrcAfiliacion.ShowDialog()

    End Sub

    Private Sub C1CmdBuscar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdBuscar.Click

        Dim StrFiltro As String = ""
        Dim StrFilNroDocu As String = ""
        Dim StrFilNroDocuDNI As String = ""

        Dim Request As New Persona.BE_ReqAfilicacion
        Dim ObjBL As New BL_Persona

        If CboFiltro.SelectedIndex = 0 Then StrFilNroDocu = TxtBuscar.Text Else StrFilNroDocu = vbNullString
        If CboFiltro.SelectedIndex = 1 Then StrFilNroDocuDNI = TxtBuscar.Text Else StrFilNroDocuDNI = vbNullString

        If TxtBuscar.Text = vbNullString Or Len(TxtBuscar.Text) <= 2 Then Exit Sub
        'mando los parametros al Request
        Request.nFlag = "DGV"
        Request.cPerIdeNumero = StrFilNroDocu
        Request.cPerIdeNumeroDNI = StrFilNroDocuDNI
        'recuperando registros en la DataGridView
        Table1.DataSource = ObjBL.Get_AfiliacionFondo(Request)

    End Sub

    Private Sub FormGridPersona_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        'Table1.Width = Width - 35
        'Table1.Height = Height - 155
        Table1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top _
            Or System.Windows.Forms.AnchorStyles.Bottom _
            Or System.Windows.Forms.AnchorStyles.Left _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TxtBuscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then Call C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then Call C1CmdBuscar_Click(C1CmdBuscar, Nothing)

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If Table1.RowCount = 0 Then Exit Sub

        'determinando acccion
        nAccionBotones = nAccionButton.nAccionEdit

        'formulario predeterminado
        'If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then nFormPerPredeterminado = nConTipoPersona.nPerNatural Else nFormPerPredeterminado = nConTipoPersona.nPerJuridica

        With Table1
            If .RowCount > 0 Then
                StrPasaValores = vbNullString
                StrPasaValores = "cDocCodigo=" & .Item(GrillaAfiliacion.ColcDocCodigo, .CurrentRow.Index).Value.ToString
                FormPrcAfiliacion.Text = "Actualizando afiliación.."
                FormPrcAfiliacion.ShowDialog()
            End If
        End With

    End Sub

    Private Sub C1CmdPrint_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdPrint.Click

        Dim CrReport As New ReportDocument

        Try
            ' Asigno el reporte 
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptFichaAfiliacionFondo.rpt")

            'CrReport.DataDefinition.FormulaFields(0).Text = Chr(34) & "Desde: " & Format(C1Dtp_FecIni.Value, "dd/MM/yyyy") & " hasta " & Format(C1Dtp_FecFin.Value, "dd/MM/yyyy") & Chr(34)

            Dim Request As New Persona.BE_ReqAfilicacion
            Dim ObjBL As New BL_Persona

            'MsgBox(FormatDateTime(DtpFecINI.Value, DateFormat.ShortDate))

            Request.nFlag = "RPT"
            Request.cPerIdeNumero = vbNullString
            Request.cDocCodigo = Table1.Item(1, Table1.CurrentRow.Index).Value

            CrReport.SetDataSource(ObjBL.Get_AfiliacionFondo(Request))

            FormCrystalReport.Text = "Ficha Afiliacion Fondo"

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub Table1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellDoubleClick
        Call C1CmdEdit_Click(C1CmdEdit, Nothing)
    End Sub

End Class