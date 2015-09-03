Option Explicit On
Imports Integration.BL.CIE

Public Class FormDiagnosticoCIE10

    Dim ObjCIE As New BL_CIE

    Private Sub FormDiagnosticoCIE10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Table1.Enabled = False
                Call BtnSeleccionar_Click(BtnSeleccionar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                Call BtnCancelar_Click(BtnCancelar, Nothing)
        End Select
    End Sub

    Private Sub FormDiagnosticoCIE10_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Table1.Enabled = True
        FormatGrilla(Table1, Me, False, 30)

        LlenaDataCombo(CboTitulo, ObjCIE.Get_Diagnostico_CIE10(1), "cDiagCodigo", "cDiagDescripcion")

        Call CboTitulo_SelectionChangeCommitted(CboTitulo, Nothing)

    End Sub

    Private Sub CboTitulo_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTitulo.SelectionChangeCommitted
        LlenaDataCombo(CboClase, ObjCIE.Get_Diagnostico_CIE10(2, CboTitulo.SelectedValue), "cDiagCodigo", "cDiagDescripcion")
        Call CboClase_SelectionChangeCommitted(CboClase, Nothing)

    End Sub

    Private Sub CboClase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboClase.SelectionChangeCommitted
        LlenaDataCombo(CboSubClase, ObjCIE.Get_Diagnostico_CIE10(3, CboClase.SelectedValue), "cDiagCodigo", "cDiagDescripcion")
        Call CboSubClase_SelectionChangeCommitted(CboSubClase, Nothing)
    End Sub

    Private Sub CboSubClase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboSubClase.SelectionChangeCommitted
        'Table1.DataSource = Nothing
        If CboSubClase.SelectedValue Is Nothing Then
            Exit Sub
        Else
            'MessageBox.Show(CboSubClase.SelectedValue.ToString)
            Table1.DataSource = ObjCIE.Get_Diagnostico_CIE10(4, CboSubClase.SelectedValue)
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Close()
        Dispose()
    End Sub

    Private Sub TxtcDiagDescripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtcDiagDescripcion.TextChanged
        Table1.DataSource = ObjCIE.Get_Diagnostico_CIE10(0, , , DBTilde(Trim(TxtcDiagDescripcion.Text)))
    End Sub

    Private Sub TxtcDiagCodigo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtcDiagCodigo.TextChanged
        Table1.DataSource = ObjCIE.Get_Diagnostico_CIE10(5, Trim(TxtcDiagCodigo.Text))
    End Sub

    Private Sub BtnSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles BtnSeleccionar.Click

        Dim Rows As Integer

        If Table1.RowCount = 0 Then Exit Sub

        With Table1
            If Not .CurrentCell Is Nothing Then
                For Each row As DataGridViewRow In .Rows

                    REM Pasando solo los que tiene el Check.
                    If Convert.ToInt16(row.Cells("nKey").Value) = 1 Then
                        If BuscaCadenaDgView("cDiagCodigo", row.Cells("cDiagCodigo").Value.ToString, FormPrcSolAtencion.Table2) Then
                            MessageBox.Show("Diagnostico " & row.Cells("cDiagCodigo").Value.ToString & " - " & row.Cells("cDiagDescripcion").Value.ToString & " ya esta siendo ingresado, no podra duplicar; Verifique por favor.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        Else
                            REM Si No Existe, aqui inserta fila
                            With FormPrcSolAtencion.Table2
                                Rows = .RowCount()
                                .Rows.Add()
                                .Item("cDiagCodigo", Rows).Value = row.Cells("cDiagCodigo").Value.ToString
                                .Item("cDiagDescripcion", Rows).Value = row.Cells("cDiagDescripcion").Value.ToString
                            End With

                        End If

                    End If
                Next

                Call BtnCancelar_Click(BtnCancelar, Nothing)

            End If
        End With
    End Sub

End Class