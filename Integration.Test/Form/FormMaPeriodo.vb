Option Explicit On

Imports Integration.BE
Imports Integration.BL

Public Class FormMaPeriodo

    Dim Request As New BE.Sistema.BE_ReqPeriodo
    Dim Obj As New BL_Sistema

    Private Sub FormMaPeriodo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, False, 30, False, DataGridViewSelectionMode.CellSelect)
        Call C1CmdMostrarPrd_Click(C1CmdMostrarPrd, Nothing)

        'Llenando Cell tipo ComboBox de un DataGridView
        Dim comboboxColumn As DataGridViewComboBoxColumn = TryCast(Table1.Columns("nprdestado"), DataGridViewComboBoxColumn)

        comboboxColumn.DataSource = ObjConst.Get_Constante("C", 1073) '--ESTADO PERIODO CONTABLE 
        comboboxColumn.DisplayMember = "cConDescripcion"
        comboboxColumn.ValueMember = "nConValor"

    End Sub

    Private Sub C1CmdMostrarPrd_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdMostrarPrd.Click

        Request.cAnno = Year(DtpAnno.Value).ToString
        Request.cPerJurCodigo = StrcPerJuridica
        Request.cflag = "M"

        Table1.DataSource = Obj.Ins_Get_Periodo(Request)

    End Sub

    Private Sub C1CmdCrearPrd_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCrearPrd.Click

        If Table1.RowCount > 0 Then Exit Sub

        Request.cAnno = Year(DtpAnno.Value).ToString
        Request.cPerJurCodigo = StrcPerJuridica
        Request.cflag = "C"

        Table1.DataSource = Obj.Ins_Get_Periodo(Request)

    End Sub

    Private Sub C1CmdUpdEstado_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdUpdEstado.Click

        Try
            Dim ReqUpd As New Sistema.BE_ReqPeriodoUpd
            Dim ObjUpd As New BL_Sistema

            Dim Response As New BE_ResGenerico
            Dim Resultado As Long

            With Table1
                If .RowCount > 0 Then
                    For i As Integer = 0 To .Rows.Count - 1
                        ReqUpd.nPrdCodigo = .Rows(i).Cells("nprdcodigo").Value
                        ReqUpd.nPrdEstado = .Rows(i).Cells("nprdestado").Value
                        Response = ObjUpd.Upd_Periodo(ReqUpd)
                        Resultado = Response.Resultado
                    Next
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DtpAnno_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DtpAnno.ValueChanged

        Call C1CmdMostrarPrd_Click(C1CmdMostrarPrd, Nothing)

    End Sub

    Private Sub TlStrpMnuItemPrdDefault_Click(sender As System.Object, e As System.EventArgs) Handles TlStrpMnuItemPrdDefault.Click

        Try
            Dim ReqDefault As New Sistema.BE_ReqPeriodoDefault
            Dim ObjDefault As New BL_Sistema

            Dim Response As New BE_ResGenerico
            Dim Resultado As Long

            With Table1
                If .RowCount > 0 And .Item(6, .CurrentRow.Index).Value() = 1 Then
                    ReqDefault.nPrdCodigo = .Item(0, .CurrentRow.Index).Value()
                    ReqDefault.cAnno = Year(DtpAnno.Value).ToString
                    Response = ObjDefault.Set_PeriodoDefault(ReqDefault)
                    Resultado = Response.Resultado
                End If
            End With

            '--actualizo MDI
            Call CargarPeriodoActual()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

End Class