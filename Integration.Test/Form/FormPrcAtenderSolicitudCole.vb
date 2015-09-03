Imports System.IO
Imports System.Reflection

Imports Integration.BE
Imports Integration.BL
Imports Helpers
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration

Public Class FormPrcAtenderSolicitudCole

    Private Sub BtnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnMostrar.Click

        Try
            Dim Request As New Solicitud.BE_ReqBuscaAdmSolicitud
            Dim Obj As New BL_Solicitud

            'MsgBox(FormatDateTime(DtpFecINI.Value, DateFormat.ShortDate))
            Select Case CboTipoFiltro.SelectedIndex
                Case 0 'Nro. Solicitud
                    Request.nSolAdmNumero = RTrim(TxtDato.Text)
                    Request.cPerIdeNumero = ""
                    Request.fec_ini = ""
                    Request.fec_fin = ""
                Case 1 'D.N.I.
                    Request.nSolAdmNumero = ""
                    Request.cPerIdeNumero = RTrim(TxtDato.Text)
                    Request.fec_ini = ""
                    Request.fec_fin = ""
                Case 2 'Rango de fechas
                    Request.nSolAdmNumero = ""
                    Request.cPerIdeNumero = ""
                    Request.fec_ini = FormatDateTime(DtpFecINI.Value, DateFormat.ShortDate)
                    Request.fec_fin = FormatDateTime(DtpFecFIN.Value, DateFormat.ShortDate)

            End Select
            Request.Condicion = CboCondicion.SelectedIndex
            'muestra resultado
            Table1.DataSource = Obj.Get_AdmSolicitud(Request)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub FormPrcAtenderSolicitudCole_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        FormatGrilla(Table1, Me, False, 30)

        CboTipoFiltro.SelectedIndex = 0
        CboCondicion.SelectedIndex = 0
        TxtDato.Focus()

    End Sub

    Private Sub Table1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellContentClick
        '
        ' Detecta si se ha seleccionado el header de la grilla
        '
        If e.RowIndex = -1 Then
            Return
        End If

        '//Validando si Ya cancelo en su totalidad el derecho de pago para colegiarse
        With Table1
            If .CurrentCell.ColumnIndex = 0 Then
                If (CDbl(.Item("nCtaCteImpAplicado", .CurrentRow.Index).Value) - CDbl(.Item("nCtaCteImporte", .CurrentRow.Index).Value)) <> 0 Or .Item("cCtaCteRecibo", .CurrentRow.Index).Value.ToString = "" Then
                    'Or CDbl(.Item("nCtaCteImpAplicado", .CurrentRow.Index).Value) = 0 Then
                    MessageBox.Show("Aun no ha cancelado en su totalidad el Pago por derecho a Colegiatura.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Item("nPerAdmEstado", .CurrentRow.Index).Value = 0
                    Table1.RefreshEdit()
                    Exit Sub
                End If
            End If
        End With

        If Table1.Columns(e.ColumnIndex).Name = "nPerAdmEstado" Then

            '
            ' Se toma la fila seleccionada
            '
            Dim row As DataGridViewRow = Table1.Rows(e.RowIndex)

            '
            ' Se selecciona la celda del checkbox
            '
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("nPerAdmEstado"), DataGridViewCheckBoxCell)

            'If Convert.ToBoolean(cellSelecion.Value) Then
            If Convert.ToInt16(cellSelecion.Value) Then
                row.DefaultCellStyle.BackColor = Color.LightCoral
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub Table1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellDoubleClick

        nOperacion = 2 'recuperar solicitud
        StrPasaValores = vbNullString
        StrPasaValores = "nSolAdmNumero=" & Table1.Item("nSolAdmNumero", Table1.CurrentRow.Index).Value.ToString & ";"
        StrPasaValores = StrPasaValores & "cCtaCteRecibo=" & IIf(Trim(Table1.Item("cCtaCteRecibo", Table1.CurrentRow.Index).Value.ToString) = "", vbNullString, Trim(Table1.Item("cCtaCteRecibo", Table1.CurrentRow.Index).Value.ToString))
        FormPrcAdmision.ShowDialog()

    End Sub

    Private Sub Table1_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles Table1.CurrentCellDirtyStateChanged

        If Table1.IsCurrentCellDirty Then
            Table1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub FormPrcAtenderSolicitudCole_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Table1.Width = Width - 35
        Table1.Height = Height - 90
    End Sub

    Private Sub C1CmdAtender_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdAtender.Click

        If Table1.RowCount = 0 Then Exit Sub

        Dim Request As New Solicitud.BE_ReqAtenderSolicitud
        Dim ObjAdmSol As New BL_Solicitud

        Dim Response As New BE_ResGenerico
        Dim Resultado As Long

        'NO se puede atender AdmAdmSol si ya estan Atendidas
        If CboCondicion.SelectedIndex = 1 Then Exit Sub

        For Each row As DataGridViewRow In Table1.Rows
            If Convert.ToInt16(row.Cells("nPerAdmEstado").Value) = 1 Then  'And CStr(row.Cells("cliente").Value) = txtcliente.Text Then
                'Grabar Atencion de solicitud

                Try
                    Request.cPerJuridica = row.Cells("cPerJuridica").Value.ToString
                    Request.cPerCodigo = row.Cells("cPerCodigo").Value.ToString
                    Request.nProCodigo = row.Cells("nProCodigo").Value
                    Request.nSolAdmNumero = row.Cells("nSolAdmNumero").Value.ToString
                    Request.nPerTipo = CLng(row.Cells("nPerTipo").Value)

                    Response = ObjAdmSol.InsAtenderSolicitud(Request)
                    Resultado = Response.Resultado
                    If Resultado <> 0 Then
                        MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

            End If
        Next

        'For Each row As DataGridViewRow In Table1.Rows
        '    For Each col As DataGridViewColumn In Table1.Columns
        '        'tus acciones
        '    Next
        'Next

        'For Each row As DataGridViewRow In Table1.Rows

        '    For Each cell As DataGridViewCell In row.Cells

        '        'aqui trabajas con el valor de la celda

        '    Next

        'Next

        ' PARA RECORRER TODOS LAS CELDAS DE UNA DATAGRIDVIEW
        'For Renglones As Integer = 0 To Table1.RowCount - 1

        '    For Columnas As Integer = 0 To Table1.ColumnCount - 1

        '        MsgBox(Me.Table1.Item(Columnas, Renglones).Value)

        '    Next

        'Next

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub C1CmdPrintDGV_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdPrintDGV.Click

        Dim CrReport As New ReportDocument

        Try
            ' Asigno el reporte 
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptSolicitudAtendia.rpt")

            'CrReport.DataDefinition.FormulaFields(0).Text = Chr(34) & "Desde: " & Format(C1Dtp_FecIni.Value, "dd/MM/yyyy") & " hasta " & Format(C1Dtp_FecFin.Value, "dd/MM/yyyy") & Chr(34)

            Dim Request As New Solicitud.BE_ReqBuscaAdmSolicitud
            Dim Obj As New BL_Solicitud

            'MsgBox(FormatDateTime(DtpFecINI.Value, DateFormat.ShortDate))

            Request.fec_ini = FormatDateTime(DtpFecINI.Value, DateFormat.ShortDate)
            Request.fec_fin = FormatDateTime(DtpFecFIN.Value, DateFormat.ShortDate)
            Request.Condicion = CboCondicion.SelectedIndex

            CrReport.SetDataSource(Obj.Get_AdmSolicitud(Request))

            FormCrystalReport.Text = "Reporte Solicitud atendida..."

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub C1CmdPrintFichaInd_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdPrintFichaInd.Click

        Dim CrReport As New ReportDocument

        Try
            If Table1.RowCount = 0 Then Exit Sub
            ' Asigno el reporte 
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptFichaIndividual.rpt")

            'CrReport.DataDefinition.FormulaFields(0).Text = Chr(34) & "Desde: " & Format(C1Dtp_FecIni.Value, "dd/MM/yyyy") & " hasta " & Format(C1Dtp_FecFin.Value, "dd/MM/yyyy") & Chr(34)

            Dim Request As New Solicitud.BE_ReqSolFichaIndividual
            Dim Obj As New BL_Solicitud

            'Dim cILogo As New ds_RptFichaIndividual  ' Empleados = EmpleadosDAL.ObtenerTodos()

            ''
            '' Se agrega el logo de la empresa a la informacion del listado
            ''
            'Dim row As ds_RptFichaIndividual.EmpresaRow = cILogo.Empresa.NewEmpresaRow()
            'row.ILogo = ImageHelper.ImageToByteArray(ImageHelper.ObtenerImagenLogoEmpresa())
            'cILogo.Empresa.Rows.Add(row)
            ''LogoEmpresa()

            Dim dtEmpresas As New ds_RptFichaIndividual.EmpresaDataTable() ' Empleados.EmpresaDataTable()
            Dim row As ds_RptFichaIndividual.EmpresaRow = dtEmpresas.NewEmpresaRow()

            row.ILogo = ImageHelper.ImageToByteArray(ImageHelper.ObtenerImagenLogoEmpresa())
            dtEmpresas.Rows.Add(row)

            Request.cPerCodigo = Table1.Item("cPerCodigo", Table1.CurrentRow.Index).Value.ToString
            CrReport.SetDataSource(Obj.Get_FichaIndividual(Request))

            FormCrystalReport.Text = "Ficha Individual..."

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            FormCrystalReport.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub C1CmdNuevaSol_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevaSol.Click

        nOperacion = 1 'nueva solicitud
        FormPrcAdmision.ShowDialog()

    End Sub

    Private Sub CboTipoFiltro_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoFiltro.SelectionChangeCommitted

        Select Case CboTipoFiltro.SelectedIndex
            Case 0 'Nro. Solicitud
                TxtDato.Text = vbNullString : TxtDato.Visible = True : Panel1.Visible = False
            Case 1 'D.N.I.
                TxtDato.Text = vbNullString : TxtDato.Visible = True : Panel1.Visible = False
            Case 2 'Rango de fechas
                TxtDato.Text = vbNullString : TxtDato.Visible = False : Panel1.Visible = True
        End Select

    End Sub

    Private Sub TxtDato_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDato.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            BtnMostrar_Click(BtnMostrar, Nothing)
            SendKeys.Send("{Tab}")
        End If


    End Sub

End Class