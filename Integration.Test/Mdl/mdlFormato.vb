Imports System.Windows.Forms
Imports C1.Win.C1Command


Module mdlFormato

    Public Sub FormatGrilla(ByRef Grid As DataGridView, _
                                ByRef Formulario As Form, _
                                Optional ByVal ColumnOrder As Boolean = False, _
                                Optional ByVal HeaderHeight As Integer = 30, _
                                Optional ByVal PermitirAddRows As Boolean = False, _
                                Optional ByVal ModoSeleccion As DataGridViewSelectionMode = DataGridViewSelectionMode.FullRowSelect)

        With Grid
            'bloquear agregar Rows
            .AllowUserToAddRows = PermitirAddRows

            'Stylo de borde
            .BorderStyle = BorderStyle.FixedSingle

            'Accion de order Columns    
            .AllowUserToOrderColumns = ColumnOrder
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken

            .DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue     '.White fondo fila
            .DefaultCellStyle.SelectionForeColor = Color.White   '.Black letra fila
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.Red

            '.BackgroundColor = Color.LightGray
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True

            'Altura de cabecera
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = HeaderHeight

            '.Dock = DockStyle.Bottom
            .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.OutsetDouble
            .GridColor = Color.AliceBlue

            ' alternar color de filas   
            .SelectionMode = ModoSeleccion 'DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            .DefaultCellStyle.BackColor = Color.Beige

            'Deshabilita para poder cambiar el color a cabezera de la grilla
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue        'CadetBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White

            'stylo y borde de las Grillas
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single

            .AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)

            'no permitir seleccion mutiple
            .MultiSelect = False
            .RowHeadersVisible = False
            '.Dock = DockStyle.Fill 

        End With
    End Sub

    Public Sub EstadoCmdLink(ByRef BtnNuevo As C1Command, ByVal StateNuevo As Boolean, _
                              ByRef BtnGrabar As C1Command, ByVal StateGrabar As Boolean, _
                              ByRef BtnCancelar As C1Command, ByVal StateCancelar As Boolean, _
                              ByRef BtnModificar As C1Command, ByVal StateModificar As Boolean, _
                              ByRef BtnSalir As C1Command, ByVal StateSalir As Boolean, _
                              ByRef Frame As GroupBox, Optional ByVal StateFrame As Boolean = False, _
                              Optional ByRef ControlExtra As C1Command = Nothing, Optional ByVal StateExtra As Boolean = False)

        BtnNuevo.Enabled = StateNuevo
        BtnGrabar.Enabled = StateGrabar
        BtnCancelar.Enabled = StateCancelar
        BtnModificar.Enabled = StateModificar
        BtnSalir.Enabled = StateSalir
        Frame.Enabled = StateFrame
        If ControlExtra Is Nothing Then
        Else
            ControlExtra.Enabled = StateExtra
        End If


    End Sub

    Public Sub MsgInfoCampoObligatorio(ByVal StrMensaje As String, ByRef CajaTexto As Object)
        MessageBox.Show(Replace(StrMensaje, ":", "") & "; es campo obligatorio y debe ser llenado y/o seleccionado.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CajaTexto.Focus()
    End Sub

    Public Function MsgGrabar()
        Return MessageBox.Show("¿Desea grabar datos en el sistema.?", "Grabando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
    End Function

    '//como agregar un Icono a una columna DataGridView
    'Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) _
    '                                                                                    Handles DataGridView1.CellPainting
    '    If e.ColumnIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "icono" _
    '    AndAlso e.RowIndex >= 0 Then
    '        e.Paint(e.CellBounds, DataGridViewPaintParts.All)
    '        Dim celBoton As DataGridViewButtonCell = _
    '        TryCast(DataGridView1.Rows(e.RowIndex).Cells("icono"), DataGridViewButtonCell)
    '        Dim icoAtomico As New Icon(Environment.CurrentDirectory + "\icono.ico")
    '        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3)
    '        DataGridView1.Rows(e.RowIndex).Height = icoAtomico.Height + 10
    '        DataGridView1.Columns(e.ColumnIndex).Width = icoAtomico.Width + 10
    '        e.Handled = True
    '    End If
    'End Sub

End Module
