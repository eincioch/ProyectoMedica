Imports Integration.BE
Imports Integration.BE.Documento
Imports Integration.BL
Imports Integration.BL.Documento
Imports System.Data.SqlClient
Imports Integration.Conection

Imports System.Transactions

Public Class FormPrcAfiliacion

    Dim ParamcDocCodigo As String
    Dim nFlag As Integer = 0

    Private Function ValidarCampos() As Boolean

        ValidarCampos = False
        If CDbl(LblTPorc.Text) > 100 Or CDbl(LblTPorc.Text) <= 0 Then
            MessageBox.Show("Porcenteja total no es correcto debe ser 100%", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Table1.Focus()
            Exit Function
        End If
        ValidarCampos = True

    End Function

    Private Function GetNewIdcDocCodigo(ByVal sFiltro As String) As String

        Dim Request As New BE.Documento.BE_GeneraNewIdcDocCodigo
        Dim ObjNewcDocCodigo As New BL_GeneraNewIdcDocCodigo

        Request.cPerJurCodigo = StrcPerJuridica
        Return ObjNewcDocCodigo.Get_NewIdcDocCodigo(Request)

    End Function

    Private Sub ModificandoAfiliacion()

        ParamcDocCodigo = vbNullString

        If nAccionBotones = nAccionButton.nAccionEdit Then
            '//relleno datos en pantalla
            Dim BL As New BL_FondoMortorio

            If BL.Get_Doc_Afiliacion_for_cDocCodigo(TokenByKey(StrPasaValores, "cDocCodigo")).Rows.Count > 0 Then

                Dim Reglon As Integer

                EliminarRowsDgView(Table1)

                For Each Row As DataRow In BL.Get_Doc_Afiliacion_for_cDocCodigo(TokenByKey(StrPasaValores, "cDocCodigo")).Rows
                    TxtNroPer.Text = Row("cPerIdeNumero").ToString
                    LblcPerCodPer.Text = Row("cPerCodigo").ToString
                    LblcNomRepre.Text = Row("cPerNombreCompleto").ToString
                    TxtNroPoliza.Text = Row("NroPoliza").ToString
                    LblFecReg.Text = Row("dDocFecha").ToString

                    ParamcDocCodigo = Row("cDocCodigo").ToString

                    '//lleno grilla
                    With Table1
                        Reglon = .RowCount()
                        .Rows.Add()
                        .Item("cPerCodigo", Reglon).Value = Row("cPerCodigo").ToString
                        .Item("nDocPerTipo", Reglon).Value = Convert.ToInt32(Row("nDocPerTipo")) 'Row("nDocPerTipo").ToString
                        .Item("nPerRelacion", Reglon).Value = Convert.ToInt32(Row("nPerRelacion")) 'Row("cDesParentesco").ToString
                        .Item("cNombreCompleto", Reglon).Value = Row("cPerNombreCompleto").ToString
                        .Item("nPorc", Reglon).Value = Row("nPorcBenef").ToString
                    End With

                Next

            End If
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click

        Dim Rows As Integer
        'Dim Exite As Boolean = False

        If LblcPerCodPer.Text = vbNullString Then MessageBox.Show("No hay ningun Colegiado seleccionado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub

        If CboPerAutoFill.SelectedValue = -1 Or CboPerAutoFill.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label3.Text, CboPerAutoFill)
            Exit Sub
        End If

        'Verificando "cPerCodigo" ya esta en la grilla y no repetir
        If BuscaCadenaDgView("cPerCodigo", CboPerAutoFill.SelectedValue, Table1) Then
            MessageBox.Show("Beneficiario ya ha sido ingresado.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            REM si no existe, aqui insertas el fila
            With Table1
                Rows = .RowCount()
                .Rows.Add()
                .Item("cPerCodigo", Rows).Value = CboPerAutoFill.SelectedValue 'cPerCodigo
                .Item("nDocPerTipo", Rows).Value = 1 '1=beneficiarios
                .Item("nPerRelacion", Rows).Value = DBNull.Value  '1001
                .Item("cNombreCompleto", Rows).Value = CboPerAutoFill.Text
                .Item("nPorc", Rows).Value = 0
            End With
        End If

    End Sub

    Private Sub FormPrcAfiliacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBoxRepre, False)

        GrpBox.Enabled = False
        FormatGrilla(Table1, Me, False, 30)

        'Llenando Cell tipo ComboBox de un DataGridView
        Dim comboboxColumn As DataGridViewComboBoxColumn = TryCast(Table1.Columns("nPerRelacion"), DataGridViewComboBoxColumn)

        'RequestConst.nConCodigo = 1006 '--PARENTESCO DE PERSONAS

        comboboxColumn.DataSource = ObjConst.Get_Constante("C", CLng(1006))
        comboboxColumn.DisplayMember = "cConDescripcion"
        comboboxColumn.ValueMember = "nConValor"

        'data
        Dim objPerAutoCompletar As New BL_Persona

        'llena datacombo
        LlenaDataCombo(CboPerAutoFill, objPerAutoCompletar.Get_PersonaAutocompletar(), "cPerCodigo", "cPerNombreCompleto")

        'autocompleto text1
        '
        ' cargo la lista de items para el autocomplete
        '
        CboPerAutoFill.AutoCompleteCustomSource = LoadAutoComplete(objPerAutoCompletar.Get_PersonaAutocompletar(), "cPerNombreCompleto")
        CboPerAutoFill.AutoCompleteMode = AutoCompleteMode.Suggest
        CboPerAutoFill.AutoCompleteSource = AutoCompleteSource.CustomSource

        ModificandoAfiliacion()

    End Sub

    Private Sub BtnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitar.Click

        If nAccionBotones = nAccionButton.nAccionEdit Then
            '//Aqui voy ha cambiar el estado a 2 → indica que estuvo antes como benefiaciario
            Dim BL As New BL_FondoMortorio

            If BL.Del_Beneficiario_for_cDocCodigo_and_cPerCodigo(ParamcDocCodigo, Table1.Item("cPerCodigo", Table1.CurrentRow.Index).Value) Then
                ModificandoAfiliacion()
            End If

        Else
            Call EliminaRowSeleccionada(Table1)
        End If


    End Sub

    Private Sub Table1_EditingControlShowing(ByVal sender As Object, _
                   ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) _
               Handles Table1.EditingControlShowing

        On Error Resume Next

        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf validar_Keypress

    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellEndEdit

        With Table1
            If .CurrentCell.ColumnIndex = 4 Then
                If .Item(1, .CurrentRow.Index).Value = 0 Then
                    .Item(4, .CurrentRow.Index).Value = 0 'Titular no puede tener porcentaje
                    .Item(4, .CurrentRow.Index).ReadOnly = False
                    Exit Sub
                End If
            End If
        End With

        LblTPorc.Text = Format(Suma_Columna("nPorc", Table1), "###")

    End Sub

    Private Sub validar_Keypress( _
                            ByVal sender As Object, _
                            ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' Obtener indice de la columna   
        Dim columna As Integer = Table1.CurrentCell.ColumnIndex

        ' Comprobar si la celda en edición corresponde a la columna 4   
        If columna = 4 Then  'nPorc

            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' Comprobar si el caracter es un número o el retroceso   
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar
                e.KeyChar = Chr(0)
            End If
        End If

    End Sub

    Private Sub C1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        'Genera cDocCodigo
        LblNewIdcDocCodigo.Text = GetNewIdcDocCodigo(StrcPerJuridica)

        'limpio grilla
        'Call EliminarRowsDgView(Table1)

        nFlag = 0
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBoxRepre, True)
        LblFecReg.Text = FormatDateTime(dFechaSistema, DateFormat.ShortDate)
        GrpBox.Enabled = True
        TxtNroPer.Focus()

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click

        Try
            Dim Request As New BE.Documento.BE_FondoMortorio
            Dim ObjFondo As New BL.Documento.BL_FondoMortorio

            If Not ValidarCampos() Then Exit Sub
            If RecorreCellDgView(Table1) Then Exit Sub

            Dim Resultado As Boolean = False

            If nAccionBotones = nAccionButton.nAccionNuevo Then
                REM insert
                'Insert Persona quien es el afectado
                Using scope As New TransactionScope()
                    With Table1
                        If .RowCount > 0 Then
                            For i As Integer = 0 To .Rows.Count - 1

                                'Agrego(Titular)
                                '-- DocPersona
                                Request.cDocCodigo = LblNewIdcDocCodigo.Text
                                Request.nDocPerTipo = .Item(1, i).Value() ' .Item("n_cant_prod".ToLower, i).Value
                                Request.cPerCodigo = .Item(0, i).Value() 'cPerCodigo
                                Request.nPerRelacion = .Item(2, i).Value()
                                Request.nDocTipo = .Item(4, i).Value()
                                '-- DocIdentifica
                                Request.nDocTipoNum = 3004 'Seguro mutual
                                Request.cDocNDoc = TxtNroPoliza.Text
                                '-- DocFecTramite
                                Request.dFecInicial = FormatDateTime(dFechaSistema, DateFormat.ShortDate)
                                Request.dFecFinal = vbNullString
                                Request.nMvoCodigo = 0
                                '-- DocContenido
                                Request.nDocConTipo = 3004
                                Request.tDocConContenido = TxtObser.Text
                                '-- DocVigencia
                                Request.dFechaIni = FormatDateTime(dFechaSistema, DateFormat.ShortDate)
                                Request.dFechaFin = vbNullString
                                '--
                                If ObjFondo.InsFondoMortorio(Request) Then
                                    Resultado = True
                                Else
                                    Resultado = False
                                    Exit Sub
                                End If

                            Next
                        Else
                            MessageBox.Show("No hay ningun beneficiario asignado, favor revisar....", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End With
                    scope.Complete()
                End Using

            ElseIf nAccionBotones = nAccionButton.nAccionEdit Then

                Dim BLIns As New BL_FondoMortorio

                Dim List As New List(Of BE_Ins_Beneficiario_for_cDocCodigo)
                Dim Item As BE_Ins_Beneficiario_for_cDocCodigo = Nothing

                With Table1
                    If .RowCount > 0 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            Item = New BE_Ins_Beneficiario_for_cDocCodigo 'Crear Nueva Instancia de clase(objeto) memoria
                            Item.cDocCodigo = ParamcDocCodigo
                            Item.nDocPerTipo = CLng(.Item("nDocPerTipo", i).Value) '1=benefiaciarios
                            Item.cPerCodigo = .Item("cPerCodigo", i).Value
                            Item.nPerRelacion = CLng(.Item("nPerRelacion", i).Value)
                            Item.nDocTipo = CLng(.Item("nPorc", i).Value)
                            List.Add(Item)
                        Next
                    End If
                End With

                Resultado = BLIns.Ins_Beneficiario_for_cDocCodigo(List)

            End If

            If Resultado Then
                MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call c1CmdCancel_Click(C1CmdCancel, Nothing)
            Else
                MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            GrpBox.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If LblcNomRepre.Text = vbNullString Then
            MessageBox.Show("Realize una busqueda de colegiado.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNroPer.Focus()
            Exit Sub
        End If

        nFlag = 1
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBoxRepre, False)
        GrpBox.Enabled = True

    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancel.Click

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBoxRepre, False)

        REM llena Grilla con el valor por default
        'StrFiltro = CboTabla.SelectedValue
        'RequestConst.flag = "C"
        'RequestConst.nConCodigo = StrFiltro
        'Table1.DataSource = ObjConst.Get_Constante(RequestConst)

        LblcPerCodPer.Text = vbNullString : LblcNomRepre.Text = vbNullString
        GrpBox.Enabled = False

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TxtNroPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroPer.KeyPress

        Dim Rows As Integer
        Dim Request As New Persona.BE_ReqPersonaSearh
        Dim ObjPer As New BL_Persona

        Dim StrFilNroDocu As String = ""
        If TxtNroPer.Text = vbNullString Or Len(TxtNroPer.Text) <= 2 Then Exit Sub
        StrFilNroDocu = TxtNroPer.Text

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            'limpio grilla
            Call EliminarRowsDgView(Table1)

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = 1 'Natural
            Request.cCodColegio = "N" 'Default codigo de colegiado

            If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

            If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
                LblcPerCodPer.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
                LblcNomRepre.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")

                'verifica si ya existe en al grilla
                If Not BuscaCadenaDgView("cPerCodigo", LblcPerCodPer.Text, Table1) Then
                    'Agrego a Titular a la Grilla
                    With Table1
                        Rows = .RowCount()
                        .Rows.Add()
                        .Item(0, Rows).Value = LblcPerCodPer.Text  'cPerCodigo
                        .Item(1, Rows).Value = 0 '0=Titular
                        .Item(2, Rows).Value = 1012 'Titular
                        .Item(3, Rows).Value = LblcNomRepre.Text
                        .Item(4, Rows).Value = 0
                        'Bloqueo fila para que no se pueda editar
                        .Item(2, Rows).ReadOnly = True 'Titular
                        .Item(4, Rows).ReadOnly = True '%
                    End With
                End If
            Else
                MessageBox.Show("Persona no se encuentra Colegiada.", "Aviso..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LblcPerCodPer.Text = vbNullString : LblcNomRepre.Text = vbNullString
            End If
        End If

    End Sub

    Private Sub BtnAddPer_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddPer.Click

        StrPasaValores = vbNullString
        nAccionBotones = nAccionButton.nAccionNuevo
        FormMaPersona.Width = 435
        nFormPerPredeterminado = nConTipoPersona.nPerNatural
        FormMaPersona.ShowDialog()

        Dim objPerAutoCompletar As New BL_Persona
        'llena datacombo
        LlenaDataCombo(CboPerAutoFill, objPerAutoCompletar.Get_PersonaAutocompletar(), "cPerCodigo", "cPerNombreCompleto")

        CboPerAutoFill.Focus()

        If StrPasaValores <> vbNullString Then
            CboPerAutoFill.SelectedValue = TokenByKey(StrPasaValores, "cPerCodigo")
           
        End If

    End Sub


    Private Sub Table1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellContentClick

    End Sub
End Class