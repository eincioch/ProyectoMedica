Option Explicit On
Imports Integration.BE
Imports Integration.BL

Public Class FormTipodeCambio

    Sub VisitLink()
        ' True.
        LinkLabel1.LinkVisited = True
        ' URL:
        System.Diagnostics.Process.Start("http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias")
    End Sub

    Private Sub FillDGV(ByVal cFecha As String)

        Dim Request As New BE.Sistema.BE_ReqGetDias
        Dim Obj As New BL_Sistema

        Request.sMes = cFecha
        FormatGrilla(Table1, Me, False, 30, False, DataGridViewSelectionMode.CellSelect)
        Table1.DataSource = Obj.Get_DiasxMes(Request)

        '---------------------------------------
        'LLENA VALORES QUE YA FUERON REGISTRADOS
        '---------------------------------------
        'Dim ReqTC As New BE.Sistema.BE_ReqTipodeCambio
        Dim ObjetoTC As New BL_Sistema

        'ReqTC.nMonCodigo = CboMoneda.SelectedValue
        'ReqTC.nAnno = Year(DTpFecha.Value)
        'ReqTC.nMes = Month(DTpFecha.Value)

        If ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows.Count > 0 Then
            For x As Integer = 0 To ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows.Count - 1
                With Table1
                    If .RowCount > 0 Then
                        For I As Integer = 0 To .RowCount - 1
                            'recupero valor compra
                            If FormatDateTime(.Item(0, I).Value().ToString, DateFormat.ShortDate) = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("dTasFecha") And
                                     CboMoneda.SelectedValue = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("nMonCodigo") And
                                     .Item(1, I).Value() = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("nTipoCompra") Then

                                .Item(2, I).Value = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("nCompra")
                            End If
                            'recupero valor venta
                            If FormatDateTime(.Item(0, I).Value().ToString, DateFormat.ShortDate) = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("dTasFecha") And
                                     CboMoneda.SelectedValue = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("nMonCodigo") And
                                     .Item(3, I).Value() = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("nTipoVenta") Then

                                .Item(4, I).Value = ObjetoTC.Get_TipodeCambio(CboMoneda.SelectedValue, "GRD", DTpFecha.Value, Year(DTpFecha.Value), Month(DTpFecha.Value)).Rows(x)("nVenta")
                            End If
                        Next
                    End If
                End With
            Next
        End If

    End Sub

    Private Sub FormTipodeCambio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DTpFecha.Value = DateSerial(Year(DTpFecha.Value), Month(DTpFecha.Value), 1)

        'llena combo
        LlenaDataCombo(CboMoneda, ObjConst.Get_Constante("C", CLng(CboMoneda.Tag)), "nConValor", "cConDescripcion")

        CboMoneda.SelectedValue = 2

        FillDGV(Format(DTpFecha.Value, "yyyyMM01"))

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            VisitLink()
        Catch ex As Exception
            ' The error message
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                               ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        'With Table1
        '    Select Case .CurrentCell.ColumnIndex
        '        Case 1 Or 2
        '            If .Item(1, .CurrentRow.Index).Value >= 0 Or .Item(2, .CurrentRow.Index).Value >= 0 Then
        '                .DefaultCellStyle.fo()
        '            End If

        '    End Select
        'End With

    End Sub

    Private Sub Table1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Table1.CellFormatting

        'dando formato a Grid si tiene valores > 0 
        With Table1
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Cells("nCompra").Value > 0 Then .Rows(i).Cells("nCompra").Style.ForeColor = Color.Blue : .Rows(i).Cells("nCompra").Style.BackColor = Color.Bisque
                If .Rows(i).Cells("nVenta").Value > 0 Then .Rows(i).Cells("nVenta").Style.ForeColor = Color.Blue : .Rows(i).Cells("nVenta").Style.BackColor = Color.Bisque
            Next
        End With
    End Sub


    Private Sub Table1_EditingControlShowing(ByVal sender As Object, _
                    ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) _
                Handles Table1.EditingControlShowing

        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf validar_Keypress

    End Sub

    Private Sub validar_Keypress( _
                           ByVal sender As Object, _
                           ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna   
        Dim columna As Integer = Table1.CurrentCell.ColumnIndex

        ' comprobar si la celda en edición corresponde a la columna 1 o 3   
        If columna = 1 Or columna = 2 Then 'cantidad

            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' comprobar si es un número con isNumber, si es el backspace, si el caracter   
            ' es el separador decimal, y que no contiene ya el separador  
            If (Char.IsNumber(caracter)) Or _
                        (caracter = ChrW(Keys.Back)) Or _
                        (caracter = ".") And _
                        (Me.Text.Contains(".") = False) Then


                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

    Private Sub C1CmdCargar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCargar.Click

        FillDGV(Format(DTpFecha.Value, "yyyyMM01"))

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub C1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click

        Try
            Dim RequestTC As New BE.Sistema.BE_ReqInsTipodeCambio
            Dim ObjTC As New BL_Sistema

            Dim Response As New BE_ResGenerico
            Dim Resultado As Long

            With Table1
                If .RowCount > 0 Then
                    For i As Integer = 0 To .Rows.Count - 1
                        If .Item(2, i).Value() > 0 Or .Item(4, i).Value() > 0 Then
                            'valor compra
                            RequestTC.dTasFecha = DateSerial(Year(DTpFecha.Value), Month(DTpFecha.Value), Val(.Item(0, i).Value()))
                            RequestTC.nMonCodigo = CboMoneda.SelectedValue
                            RequestTC.nTasTipo = 1
                            RequestTC.fTasValor = .Item(2, i).Value()
                            Response = ObjTC.Ins_TipodeCambio(RequestTC)
                            Resultado = Response.Resultado

                            'valor venta
                            RequestTC.nTasTipo = 2
                            RequestTC.fTasValor = .Item(4, i).Value()
                            Response = ObjTC.Ins_TipodeCambio(RequestTC)
                            Resultado = Response.Resultado
                        End If
                    Next
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class