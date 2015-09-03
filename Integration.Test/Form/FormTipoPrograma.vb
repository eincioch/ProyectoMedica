Option Explicit On
Imports Integration.BE
Imports Integration.BL

Public Class FormTipoPrograma

    'Private m_comboBox As ComboBox
    Dim nFlag As Integer

    Private Sub FillGrilla()

        Select Case CboInterface.SelectedValue
            Case "6001"
                TxtnIntClase.Tag = "nIntClase=1002"
            Case "6002"
                TxtnIntClase.Tag = "nIntClase=1022"
            Case "6003"
                TxtnIntClase.Tag = "nIntClase=1023"
            Case "6004"
                TxtnIntClase.Tag = "nIntClase=1024"
        End Select

        Table1.DataSource = ObjInterface.Get_Interface(CLng(TokenByKey(TxtnIntClase.Tag, "nIntClase")), CLng(CboInterface.SelectedValue), "T")
    End Sub

    Private Sub FormTipoPrograma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LlenaDataCombo(CboInterface, ObjConst.Get_Constante("C", CLng(TokenByKey(CboInterface.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)
        FillGrilla()
        FormatGrilla(Table1, Me, False, 30)

        ''Llenando Cell tipo ComboBox de un DataGridView
        'Dim ReqServTC As New BE.CtasCtes.BE_ReqServicioporTipoCta
        'Dim ObjServTC As New BL_CtaCtes.BL_CtaCtaServicio

        'Dim comboboxColumn As DataGridViewComboBoxColumn = TryCast(Table1.Columns("nServCod"), DataGridViewComboBoxColumn)

        'ReqServTC.nCtaCteTipoCta = 1003 '-- INSCRIPCION COLEGATURA

        'comboboxColumn.DataSource = ObjServTC.Get_ServicioporTipoCta(ReqServTC)
        'comboboxColumn.DisplayMember = "cCtaCteSerKeyWord"
        'comboboxColumn.ValueMember = "nIntTipo" '"nCtaCteSerCodigo"

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
            RequestInterface.nIntClase = TokenByKey(TxtnIntClase.Tag, "nIntClase")
            RequestInterface.cIntJerarquia = TxtnIntClase.Text
            RequestInterface.cIntNombre = TxtSiglas.Text
            RequestInterface.cIntDescripcion = TxtDesc.Text
            RequestInterface.nIntTipo = CLng(CboInterface.SelectedValue)  'TokenByKey(TxtSiglas.Tag, "nIntTipo")

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
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub CboInterface_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboInterface.SelectionChangeCommitted
        FillGrilla()
    End Sub

    'Private Sub C1CmdConfigServ_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdConfigServ.Click

    '    Try
    '        Dim Response As New BE_ResGenerico
    '        Dim Resultado As Long

    '        'Validar si el Serv. esta en otro Programa y no repetir.
    '        If ExisteDatoEnGrid(Table1, "nServCod", "Algún Servicio se esta duplicando en otro programa, verifique por favor; Cada programa debe tener un Servicio diferente") Then
    '            Exit Sub
    '        Else
    '            With Table1
    '                If .RowCount = 0 Then Exit Sub
    '                'Update Interface (Programas)
    '                For I As Integer = 0 To .RowCount - 1
    '                    RequestInterface.nIntCodigo = .Item("nIntCodigo", I).Value()
    '                    RequestInterface.nIntClase = .Item("nIntClase", I).Value()
    '                    RequestInterface.cIntJerarquia = .Item("cIntJerarquia", I).Value().ToString
    '                    RequestInterface.cIntNombre = .Item("cIntNombre", I).Value().ToString
    '                    RequestInterface.cIntDescripcion = .Item("cIntDescripcion", I).Value().ToString
    '                    RequestInterface.nIntTipo = .Item("nServCod", I).Value()

    '                    Response = ObjInterface.UpdInterface(RequestInterface)
    '                    Resultado = Response.Resultado
    '                Next
    '            End With
    '            MessageBox.Show("Operación se realizo con éxito.", "Config. Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try

    'End Sub

    'Private Sub DataGridView1_EditingControlShowing( _
    '     ByVal sender As Object, _
    '     ByVal e As DataGridViewEditingControlShowingEventArgs) _
    '     Handles Table1.EditingControlShowing


    '    If e.Control.GetType Is GetType(DataGridViewComboBoxEditingControl) Then

    '        m_comboBox = DirectCast(e.Control, ComboBox)

    '        ' Instalamos el controlador para el evento SelectedValueChanged
    '        AddHandler m_comboBox.SelectedValueChanged, _
    '            AddressOf ComboBoxOnSelectedValueChanged

    '    End If

    'End Sub

    'Private Sub ComboBoxOnSelectedValueChanged( _
    '     ByVal sender As Object, ByVal e As EventArgs)

    '    ' Referenciamos el control ComboBox que ha 
    '    ' desencadenado el evento.
    '    '
    '    Dim cb As ComboBox = DirectCast(sender, ComboBox)

    '    ' Obtenemos el valor de su propiedad ValueMember
    '    '
    '    Dim value As Object = cb.SelectedValue

    '    If value IsNot DBNull.Value Then
    '        'Pasando el valor seleccionado el ComboBox al Cells del DGV
    '        Table1.Item("nServCod", Table1.CurrentRow.Index).Value = CStr(value)
    '    Else
    '            MessageBox.Show("El valor es NULL.")
    '        End If

    'End Sub

    'Private Sub DataGridView1_RowValidating( _
    '     ByVal sender As Object, _
    '     ByVal e As DataGridViewCellCancelEventArgs) _
    '     Handles Table1.RowValidating

    '    If m_comboBox IsNot Nothing Then
    '        ' Desinstalamos el controlador de eventos
    '        RemoveHandler m_comboBox.SelectedValueChanged, _
    '            AddressOf ComboBoxOnSelectedValueChanged
    '    End If
    'End Sub



End Class