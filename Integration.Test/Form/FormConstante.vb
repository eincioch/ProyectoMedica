Option Explicit On

Imports Integration.BE
Imports Integration.BL

Public Class FormConstante

    Dim nFlag As Integer REM nglag = 0 , Agregando, 1 = modificando
    Dim StrFiltro As String

    Private Sub FormConstante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, True)
        REM llena el combo con las Tablas
        LlenaDataCombo(CboTabla, ObjConst.Get_Constante("T", 0), "nConCodigo", "cConDescripcion")

        REM llena Grilla con el valor por default
        Table1.DataSource = ObjConst.Get_Constante("C", CLng(CboTabla.SelectedValue))

        REM estado de los botones
        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, True)

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        nFlag = 0
        TxtDescrp.Text = vbNullString : LblnConValor.Text = vbNullString
        Table1.Enabled = False : GrpBox.Visible = True
        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, False)
        TxtDescrp.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, True)

        REM llena Grilla con el valor por default
        Table1.DataSource = ObjConst.Get_Constante("C", CLng(CboTabla.SelectedValue))

        Table1.Enabled = True : GrpBox.Visible = False

    End Sub

    Private Sub CboTabla_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboTabla.SelectedIndexChanged

        Table1.DataSource = ObjConst.Get_Constante("C", CLng(CboTabla.SelectedValue))

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try
            Dim Request As New Constante.BE_ReqInsUpdConstante
            Dim ObjIUConst As New BL_Constante
            Dim Response As New BE_ResGenerico

            Dim Resultado As Long

            If nFlag = 0 Then
                REM insert
                Request.flag = "I"
                Request.nConCodigo = CboTabla.SelectedValue
                Request.cConDescripcion = TxtDescrp.Text
                Request.nConValor = 0
                Response = ObjIUConst.ExecInsUpdConstante(Request)
                Resultado = Response.Resultado


            ElseIf nFlag = 1 Then
                REM update
                Request.flag = "U"
                Request.nConCodigo = CboTabla.SelectedValue
                Request.cConDescripcion = TxtDescrp.Text
                Request.nConValor = CDbl(LblnConValor.Text)
                Response = ObjIUConst.ExecInsUpdConstante(Request)
                Resultado = Response.Resultado
            End If

            If Resultado <> 0 Then
                MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call c1CmdCancel_Click(c1CmdCancel, Nothing)
                'Else
                '    MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            GrpBox.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                LblnConValor.Text = .Item(1, .CurrentRow.Index).Value.ToString
                TxtDescrp.Text = .Item(2, .CurrentRow.Index).Value.ToString
            End If
        End With

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If LblnConValor.Text = vbNullString Then
            MessageBox.Show("Selecciona un item de la grilla para modificar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, False)
        nFlag = 1
        Table1.Enabled = False : GrpBox.Visible = True

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

End Class