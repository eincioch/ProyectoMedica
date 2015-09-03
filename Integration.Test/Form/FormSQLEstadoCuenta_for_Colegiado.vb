Option Explicit On
Imports Integration.BL.BL_CtaCtes


Public Class FormSQLEstadoCuenta_for_Colegiado

    Dim cStrNameReport As String = vbNullString

    Public Sub BuscaforColegiado()

        Dim Obj As New BL_CtaCteEstadoCuentaCole

        Dim StrFilNroDocu As String = ""
        If TxtNroFind.Text = vbNullString Or Len(TxtNroFind.Text) <= 2 Then Exit Sub
        StrFilNroDocu = TxtNroFind.Text

        If Obj.Get_CtaCteEstadoCole(StrcPerJuridica, vbNullString, StrFilNroDocu) Is Nothing Then Exit Sub

        If Obj.Get_CtaCteEstadoCole(StrcPerJuridica, vbNullString, StrFilNroDocu).Rows.Count > 0 Then
            LblcPerCodigo.Text = Obj.Get_CtaCteEstadoCole(StrcPerJuridica, vbNullString, StrFilNroDocu).Rows(0)("cPerCodigo")
            LblcNombre.Text = Obj.Get_CtaCteEstadoCole(StrcPerJuridica, vbNullString, StrFilNroDocu).Rows(0)("ApeNomb_RSocial")

            Table1.DataSource = Obj.Get_CtaCteEstadoCole(StrcPerJuridica, vbNullString, Trim(StrFilNroDocu))
            Table2.DataSource = Obj.Get_CtaCteEstadoCuentaCole(StrcPerJuridica, LblcPerCodigo.Text, 5007)

            ''//Validar si ya esta colegiado (no se puede colegiar 2 veces obvio)
            'Dim BL As New BL_Sistema
            'If Not BL.Get_ValidarCondicion("PerIdentifica", "cPerIdeNumero", "nPerIdeTipo = 29 AND cPerCodigo = " & LblcPerCodigo.Text) Then
            '    MessageBox.Show("Persona " & LblcNombre.Text & " ya se encuentra Colegiado(a), NO se puede volver a Colegiar.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    LblcPerCodigo.Text = vbNullString : LblcNombre.Text = vbNullString
            '    c1CmdCancel_Click(c1CmdCancel, Nothing)
            '    Exit Sub
            'End If
            ''//

            ''recupero la foto si tiene
            'RequestImg.cPerCodigo = LblcPerCodigo.Text
            'RequestImg.cUltimaPhoto = "A"

            'If ObjImg.Get_PerImagen(RequestImg).Rows.Count > 0 Then
            '    PctrBoxFoto.BackgroundImage = ObtenerPhoto(ObjImg.Get_PerImagen(RequestImg).Rows(0)("iPerImaFoto"))
            'End If
        Else
            MessageBox.Show("Persona no se encuentra registrada en el sistema. ", "Buscando..", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub TxtNroFind_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFind.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaforColegiado()
        End If
    End Sub


    Private Sub FormSQLEstadoCuenta_for_Colegiado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        WindowState = FormWindowState.Maximized

        FormatGrilla(Table1, Me, False, 30)
        FormatGrilla(Table2, Me, False, 30)

    End Sub

    Private Sub FormSQLEstadoCuenta_for_Colegiado_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        Table1.Width = Width - 30
        Table2.Width = Width - 30
        LblCaptionGrd.Width = Width - 30
        Table2.Height = Height - 300

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Close()
        Dispose()

    End Sub

    Private Sub BtnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportExcel.Click

        If Table2.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table2, cStrNameReport)

    End Sub

    Private Sub BtnExportPDF_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportPDF.Click

        If Table2.RowCount = 0 Then Exit Sub

        ExportarDatosPDF(Table2, "COLEGIO DE CONTADORES PUBLICOS DE LA LIBERTAD", cStrNameReport)

    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        Dim nCtaCteSerCodigo As Long

        With Table1
            If .RowCount > 0 Then
                nCtaCteSerCodigo = .Item("nCtaCteSerCodigo", .CurrentRow.Index).Value.ToString
                LblEstado.Text = .Item("Estado", .CurrentRow.Index).Value.ToString
                LblServicio.Text = .Item("cIntDescripcion", .CurrentRow.Index).Value.ToString
            End If
        End With

        If Microsoft.VisualBasic.Left(LblEstado.Text, 1) = "H" Then LblEstado.ForeColor = Color.Blue Else LblEstado.ForeColor = Color.Red

        If nCtaCteSerCodigo = 5007 Then LblServicio.ForeColor = Color.Peru Else LblServicio.ForeColor = Color.OrangeRed

        cStrNameReport = "Colegiado: " & LblcNombre.Text & " [" & LblServicio.Text & "] - Fecha Impresión: " & Date.Now.ToString

        Dim Obj As New BL_CtaCteEstadoCuentaCole

        If nCtaCteSerCodigo = 5007 Then
            Table2.DataSource = Obj.Get_CtaCteEstadoCuentaCole(StrcPerJuridica, LblcPerCodigo.Text, 5007)
        Else
            Table2.DataSource = Obj.Get_CtaCteEstadoCuentaCole(StrcPerJuridica, LblcPerCodigo.Text, 5072)
        End If

    End Sub


End Class