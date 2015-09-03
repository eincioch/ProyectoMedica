Option Explicit On
Imports Integration.BE
Imports Integration.BL

Public Class FormSunatTDocumento

    Dim nFlag As Integer

    Dim RequestInterface As New [Interface].BE_ReqInterface
    Dim ObjInterface As New BL_Interface

    Private Sub FillGrilla()
        Table1.DataSource = ObjInterface.Get_Interface(CLng(TokenByKey(TxtnIntClase.Tag, "nIntClase")), CLng(TokenByKey(TxtSiglas.Tag, "nIntTipo")), "T")
    End Sub

    Private Sub FormSunatTDocumento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        WindowState = FormWindowState.Maximized

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)

        FormatGrilla(Table1, Me, True, 25)
        FillGrilla()

    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                TxtnIntClase.Text = .Item(2, .CurrentRow.Index).Value.ToString
                TxtSiglas.Text = .Item(3, .CurrentRow.Index).Value.ToString
                TxtDesc.Text = .Item(4, .CurrentRow.Index).Value.ToString
            End If
        End With

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        nFlag = 0
        TxtnIntClase.Text = vbNullString : TxtSiglas.Text = vbNullString : TxtDesc.Text = vbNullString : Table1.Enabled = False
        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        TxtnIntClase.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)
        FillGrilla()
        Table1.Enabled = True

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try
            Dim Response As New BE_ResGenerico

            Dim Resultado As Long

            If Table1.RowCount > 0 Then RequestInterface.nIntCodigo = Table1.Item(0, Table1.CurrentRow.Index).Value.ToString Else RequestInterface.nIntCodigo = 0
            'RequestInterface.nIntCodigo = 0 ' IIf(Table1.RowCount = 0, 0, Table1.Item(0, Table1.CurrentRow.Index).Value.ToString)
            RequestInterface.nIntClase = TokenByKey(TxtnIntClase.Tag, "nIntClase")
            RequestInterface.cIntJerarquia = TxtnIntClase.Text
            RequestInterface.cIntNombre = TxtSiglas.Text
            RequestInterface.cIntDescripcion = TxtDesc.Text
            RequestInterface.nIntTipo = TokenByKey(TxtSiglas.Tag, "nIntTipo")

            If nFlag = 0 Then
                REM insert
                Response = ObjInterface.InsInterface(RequestInterface)
                Resultado = Response.Resultado

            ElseIf nFlag = 1 Then
                REM update
                Response = ObjInterface.UpdInterface(RequestInterface)
                Resultado = Response.Resultado
            End If

            If Resultado <> 0 Then
                MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call c1CmdCancel_Click(c1CmdCancel, Nothing)
                'Else
                '    MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If TxtnIntClase.Text = vbNullString Then
            MessageBox.Show("Selecciona un Item de la grilla para modificar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        nFlag = 1
        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)
        Table1.Enabled = False : TxtnIntClase.Focus()

    End Sub

    Private Sub TxtnIntClase_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtnIntClase.KeyPress, TxtSiglas.KeyPress, TxtDesc.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub FormSunatTDocumento_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        Table1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top _
            Or System.Windows.Forms.AnchorStyles.Bottom _
            Or System.Windows.Forms.AnchorStyles.Left _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

    End Sub
End Class