Imports Integration.BL.BL_Reportes
Imports System.IO

Public Class FormRptMasterColegiado

    Dim cStrNameReport As String = vbNullString

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim ColumnaCodigoProducto As New DataGridViewTextBoxColumn()
            With ColumnaCodigoProducto
                .DataPropertyName = "cPerCodigo"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColumnaCodigoProducto)

            Dim ColumnacPerIdeNumero As New DataGridViewTextBoxColumn()
            With ColumnacPerIdeNumero
                .DataPropertyName = "cPerIdeNumero"
                .HeaderText = "Código Cole"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColumnacPerIdeNumero)

            Dim ColumnaApeNomb_RSocial As New DataGridViewTextBoxColumn()
            With ColumnaApeNomb_RSocial
                .DataPropertyName = "ApeNomb_RSocial"
                .HeaderText = "Apellidos y Nombres o RSocial"
                .ReadOnly = True : .Visible = True
                .Width = 250
            End With
            .Columns.Add(ColumnaApeNomb_RSocial)

            Dim ColumnacPerDomDireccion As New DataGridViewTextBoxColumn()
            With ColumnacPerDomDireccion
                .DataPropertyName = "cPerDomDireccion"
                .HeaderText = "Dirección"
                .ReadOnly = True : .Visible = True
                .Width = 150
            End With
            .Columns.Add(ColumnacPerDomDireccion)

            'Dim ColumnanCtaCteSerCodigo As New DataGridViewTextBoxColumn()
            'With ColumnanCtaCteSerCodigo
            '    .DataPropertyName = "nCtaCteSerCodigo"
            '    .HeaderText = "Servicio"
            '    .ReadOnly = True : .Visible = False
            '    .Width = 60
            '    '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            'End With
            '.Columns.Add(ColumnanCtaCteSerCodigo)

            Dim ColumnaImporteCuota As New DataGridViewTextBoxColumn()
            With ColumnaImporteCuota
                .DataPropertyName = "ImporteCuota"
                .HeaderText = "Importe Cuota"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 50
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColumnaImporteCuota)

            Dim ColumnaImporteFM As New DataGridViewTextBoxColumn()
            With ColumnaImporteFM
                .DataPropertyName = "ImporteFM"
                .HeaderText = "Importe Fondo Mortario"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 50
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColumnaImporteFM)

            Dim ColumnanValor As New DataGridViewTextBoxColumn()
            With ColumnanValor
                .DataPropertyName = "nValor"
                .HeaderText = "Valor"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 40
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColumnanValor)

            Dim ColumnaEstado As New DataGridViewTextBoxColumn()
            With ColumnaEstado
                .DataPropertyName = "Estado"
                .HeaderText = "Estado"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 40
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColumnaEstado)

        End With

    End Sub

    Private Sub FormatoCumple_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim ColumnaCodigoProducto As New DataGridViewTextBoxColumn()
            With ColumnaCodigoProducto
                .DataPropertyName = "cPerCodigo"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColumnaCodigoProducto)

            Dim ColumnacPerIdeNumero As New DataGridViewTextBoxColumn()
            With ColumnacPerIdeNumero
                .DataPropertyName = "cPerIdeNumero"
                .HeaderText = "Código Cole"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColumnacPerIdeNumero)

            Dim ColumnaApeNomb_RSocial As New DataGridViewTextBoxColumn()
            With ColumnaApeNomb_RSocial
                .DataPropertyName = "cPerNombreCompleto"
                .HeaderText = "Apellidos y Nombres o RSocial"
                .ReadOnly = True : .Visible = True
                .Width = 250
            End With
            .Columns.Add(ColumnaApeNomb_RSocial)

            Dim ColumnacPerDomDireccion As New DataGridViewTextBoxColumn()
            With ColumnacPerDomDireccion
                .DataPropertyName = "cPerDomDireccion"
                .HeaderText = "Dirección"
                .ReadOnly = True : .Visible = True
                .Width = 150
            End With
            .Columns.Add(ColumnacPerDomDireccion)

            Dim ColumnanCtaCteSerCodigo As New DataGridViewTextBoxColumn()
            With ColumnanCtaCteSerCodigo
                .DataPropertyName = "dPerNacimiento"
                .HeaderText = "Fecha Nacimiento"
                .ReadOnly = True : .Visible = True
                .Width = 75
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColumnanCtaCteSerCodigo)

            Dim ColumnaImporteCuota As New DataGridViewTextBoxColumn()
            With ColumnaImporteCuota
                .DataPropertyName = "EDAD"
                .HeaderText = "Edad Cumple"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 50
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColumnaImporteCuota)

            Dim ColumnaImporteFM As New DataGridViewTextBoxColumn()
            With ColumnaImporteFM
                .DataPropertyName = "cPerMaiNombre"
                .HeaderText = "E-mail"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 100
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColumnaImporteFM)


        End With

    End Sub

    Private Sub FormRptMasterColegiado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        WindowState = FormWindowState.Maximized

        Formato01_DataGridView()
        FormatGrilla(Table1, Me)

        CboEstado.SelectedIndex = 0

    End Sub

    Private Sub BtnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnMostrar.Click

        Try
            Dim BL As New BL_RptconColegiado

            Cursor.Current = Cursors.WaitCursor

            cStrNameReport = vbNullString

            If RdBtnEstado.Checked Then
                Formato01_DataGridView()
                Select Case CboEstado.SelectedIndex
                    Case 0 'Habil
                        Table1.DataSource = BL.Get_RptVarios_for_Colegiado(cNameRpt:="COLEHABILIN", dFecIni:=Date.Now, dFecFin:=Date.Now, cPerCodigo:="", nCtaCteSerCodigo:=0, cEstado:="H")
                        cStrNameReport = "Listado Colegiado - Hábil"
                    Case 1 'Inhabil
                        Table1.DataSource = BL.Get_RptVarios_for_Colegiado(cNameRpt:="COLEHABILIN", dFecIni:=Date.Now, dFecFin:=Date.Now, cPerCodigo:="", nCtaCteSerCodigo:=0, cEstado:="I")
                        cStrNameReport = "Listado Colegiado - Inhábil"
                    Case 2 'todos
                        Table1.DataSource = BL.Get_RptVarios_for_Colegiado(cNameRpt:="COLEHABILIN", dFecIni:=Date.Now, dFecFin:=Date.Now, cPerCodigo:="", nCtaCteSerCodigo:=0, cEstado:="")
                        cStrNameReport = "Listado Colegiado - Hábil e Inhábil"
                End Select
            End If

            If RdBtnFecCumple.Checked Then
                FormatoCumple_DataGridView()
                Table1.DataSource = BL.Get_RptVarios_for_Colegiado(cNameRpt:="FECHACUMPLE", dFecIni:=DTPFecIni.Value, dFecFin:=DTPFecFin.Value, cPerCodigo:="", nCtaCteSerCodigo:=0, cEstado:="")
                cStrNameReport = "Listado de Colegiado - Cumpleaños. Desde: " & Format(DTPFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DTPFecFin.Value, "dd/MM/yyyy")
            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Se encontraron errores.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Default
        End Try


    End Sub

    Private Sub BtnExportPDF_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportPDF.Click

        If Table1.RowCount = 0 Then Exit Sub

        ExportarDatosPDF(Table1, "COLEGIO DE CONTADORES PUBLICOS DE LA LIBERTAD", cStrNameReport)

    End Sub

    Private Sub BtnExportTxt_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportTxt.Click

        If Table1.RowCount = 0 Then Exit Sub

        ExportTXT(Table1)

    End Sub

    Private Sub BtnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportExcel.Click

        If Table1.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table1, cStrNameReport)

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Close()
        Dispose()


    End Sub

    Private Sub FormRptMasterColegiado_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        Table1.Width = Width - 35
        Table1.Height = Height - 195

    End Sub

    Private Sub RdBtnFecCumple_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdBtnFecCumple.CheckedChanged

        If RdBtnFecCumple.Checked Then
            DTPFecIni.Value = "01/01/1970"
            DTPFecFin.Value = DTPFecIni.Value
        End If

    End Sub

    Private Sub DTPFecIni_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DTPFecIni.ValueChanged

        'DTPFecIni.Value = "01/01/1970"
        DTPFecFin.Value = DTPFecIni.Value

    End Sub
End Class