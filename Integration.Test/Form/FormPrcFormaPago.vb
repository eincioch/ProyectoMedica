Option Explicit On

Imports Integration.BE.Persona
Imports Integration.BE.CtasCtes
Imports Integration.BE.CtasCtesMedica

Imports Integration.BL
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BL.BL_FichaAtencion

Imports System.Transactions

Public Class FormPrcFormaPago

    Private Sub InicilizarCampos()

        'Obteniendo Valores
        LblNroRecibo.Text = TokenByKey(StrPasaValores, "cNroRecibo")
        LblnSolAdmNumero.Text = TokenByKey(StrPasaValores, "nSolAdmNumero")
        LblImpRecibo.Text = TokenByKey(StrPasaValores, "nImpRecibo")
        LblcPerCodigo.Text = TokenByKey(StrPasaValores, "cPerCodigo")
        LblnPerTipo.Text = TokenByKey(StrPasaValores, "nPerTipo") 'tipo de persona

        'Obteniendo PerCuenta de la Persona
        Dim objPerCta As New BL.BL_CtasCtesMedica.BL_PerCuenta
        Dim dtPerCta As New DataTable
        dtPerCta = objPerCta.Get_PerCuenta(TokenByKey(StrPasaValores, "cPerCodigo"), StrcPerJuridica)

        If dtPerCta.Rows.Count > 0 Then
            LblnPerCtaCodigo.Text = dtPerCta.Rows(0).Item("nPerCtaCodigo").ToString
        Else
            LblnPerCtaCodigo.Text = 0
        End If
        '--

        If CDbl(LblTotalPago.Text) = 0 Then
            TxtImpPago.Text = TokenByKey(StrPasaValores, "nImpRecibo")
        End If

        'If TokenByKey(StrPasaValores, "nTipoDocu") = 3007 Then '//CONDONACION
        '    CboFormaPago.SelectedValue = 4 'Condonacion
        '    CboFormaPago.Enabled = False
        'Else
        CboFormaPago.SelectedValue = 1 'Defualt Nuevos Soles
        CboFormaPago.Enabled = True
        'End If

        CboMoneda_SelectionChangeCommitted(CboMoneda, Nothing)
        'TxtImpPago.Text = CDbl(0.0)

        CboBanco.SelectedValue = -1
        CboTipoTarj.SelectedValue = -1
        'CboNroCta_TarjetaDC.SelectedValue = -1
        TxtNroTarjeta.Text = vbNullString

        TxtVoucher.Text = vbNullString

        GrpBoxBco.Visible = False

    End Sub

    Function ValidarCampos() As Boolean
        ValidarCampos = False
        If LblImpRecibo.Text <> LblTotalPago.Text Then
            MessageBox.Show("Importe a Total a Pagar no es coherente..! por favor de revisar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text) - CDbl(LblTotalPago.Text), True)
            'MsgInfoCampoObligatorio("", TxtImpPago.Text)
            Exit Function
        End If
        ValidarCampos = True
    End Function

    Function ValidarCamposForAddItemGrd() As Boolean

        ValidarCamposForAddItemGrd = False

        If LblNroRecibo.Text = vbNullString Or LblNroRecibo.Text = "" Then MsgInfoCampoObligatorio(Label5.Text, BtnCancel) : Exit Function
        If CDbl(LblImpRecibo.Text) <= 0 Then MsgInfoCampoObligatorio(Label2.Text, BtnCancel) : Exit Function
        If CboFormaPago.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label1.Text, CboFormaPago) : Exit Function
        If CboMoneda.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label4.Text, CboMoneda) : Exit Function
        If CDbl(TxtImpPago.Text) <= 0 Or TxtImpPago.Text = vbNullString Then MsgInfoCampoObligatorio(Label17.Text, TxtImpPago) : Exit Function

        If CLng(LblnPerCtaCodigo.Text) = 0 Or LblnPerCtaCodigo.Text = vbNullString Then MessageBox.Show("Persona NO tiene Codigo de Cuenta. [PerCuenta]", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Function

        'If Table2.RowCount = 0 Then MsgInfoCampoObligatorio("No existe ningun medio de pago en el Detalle de Pago.", BtnAdd) : Exit Function

        'If FormPrcFacturacion.CboTipoDocu.SelectedValue <> 3007 And CboFormaPago.SelectedValue = 4 Then '//recibo condonacion - forma pago: condonacion
        '    MessageBox.Show("No puede utilizar este medio de pago, para este tipo de comprobante de venta.", Label1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Function
        'End If

        If CboMoneda.SelectedValue <> nTipoMoneda.nSoles Then
            If CDbl(LblTC.Text) <= 0 Then MsgInfoCampoObligatorio(Label20.Text, BtnCancel) : Exit Function
        End If

        Select Case CboFormaPago.SelectedValue
            Case nFomaPago.nCheque

            Case nFomaPago.nDepositoBco
                If CboBanco.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label13.Text, CboBanco) : Exit Function
                'If CboNroCta_TarjetaDC.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label10.Text, CboNroCta_TarjetaDC) : Exit Function
                If TxtNroTarjeta.Text = vbNullString Or Len(TxtNroTarjeta.Text) = 0 Then MsgInfoCampoObligatorio(Label10.Text, TxtNroTarjeta) : Exit Function
                If TxtVoucher.Text = vbNullString Then MsgInfoCampoObligatorio(Label15.Text, TxtVoucher) : Exit Function

            Case nFomaPago.nTarjetaCred
                If CboBanco.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label13.Text, CboBanco) : Exit Function
                If CboTipoTarj.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label12.Text, CboTipoTarj) : Exit Function
                'If CboNroCta_TarjetaDC.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label10.Text, CboNroCta_TarjetaDC) : Exit Function
                If TxtNroTarjeta.Text = vbNullString Or Len(TxtNroTarjeta.Text) = 0 Then MsgInfoCampoObligatorio(Label10.Text, TxtNroTarjeta) : Exit Function
                If TxtVoucher.Text = vbNullString Then MsgInfoCampoObligatorio(Label15.Text, TxtVoucher) : Exit Function
        End Select

        If CDbl(CDbl(Suma_Columna("nCtaCtePagImporte", Table2)) + CDbl(TxtImpPago.Text)) > CDbl(LblImpRecibo.Text) Then
            TxtImpPago.Text = 0
            MessageBox.Show("Importe a Pagar exede el importe.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        ValidarCamposForAddItemGrd = True

    End Function

    Private Sub FormPrcFormaPago_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                BtnAdd_Click(BtnAdd, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Delete))
                BtnQuitar_Click(BtnQuitar, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                BtnRegPago_Click(BtnRegPago, Nothing)

                'Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8))
                '    BtnPagoDet_Click(BtnPagoDet, Nothing)

        End Select

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

        StrPasaValores = vbNullString
        FormGridFichaAtencion.CboFiltro.SelectedIndex = 0
        FormGridFichaAtencion.TxtBuscar.Text = LblnSolAdmNumero.Text
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub FormPrcFormaPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LblNroCaja.Text = Microsoft.VisualBasic.Right("00" & ObtenerParametroAppConfig("NroCaja"), 2)

        'Llena CboTipoDocu segun caja asignada
        Dim ReqTDocu As New BE_TipoDocporNroCaja
        Dim ObjTDocu As New BL_CtaCteServicioFacturacion

        ReqTDocu.cPerJurCodigo = StrcPerJuridica
        ReqTDocu.nCajCodigo = CLng(ObtenerParametroAppConfig("NroCaja"))

        LlenaDataCombo(CboTipoDocu, ObjTDocu.Get_TipoDocporNroCaja(ReqTDocu), "nIntCodigo", "cIntDescripcion")
        'Activa tipo docu parametrizado por default
        CboTipoDocu.SelectedValue = CLng(ObtenerParametroAppConfig("nTipoDocuDefault"))

        Call CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)

        FormatGrilla(Table2, Me, False, 35)

        LlenaDataCombo(CboMoneda, ObjConst.Get_Constante("C", CLng(TokenByKey(CboMoneda.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboFormaPago, ObjConst.Get_Constante("C", CLng(TokenByKey(CboFormaPago.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text), True)

        DtpFecPago.Value = dFechaSistema
        DtpFecDeposito.Value = DtpFecPago.Value

        InicilizarCampos()

        Me.ActiveControl = CboFormaPago
        'CboFormaPago.Focus()

    End Sub

    Private Sub CboTipoDocu_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoDocu.SelectionChangeCommitted

        Dim ObjSerieCorre As New BL_CtaCteNumeracion

        LblSerie.Text = Microsoft.VisualBasic.Left(ObjSerieCorre.Get_CtaCteNumCorrelativo(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), CLng(CboTipoDocu.SelectedValue)), 4)
        LblCorrelativo.Text = Microsoft.VisualBasic.Right(ObjSerieCorre.Get_CtaCteNumCorrelativo(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), CLng(CboTipoDocu.SelectedValue)), 7)

    End Sub

    Private Sub ImprimeTicket(ByVal cPerJurCodigo As String, ByVal nTipoPer As Integer, ByVal cPerCodigo As String, ByVal nTipoDocu As Integer, ByVal NroComprobante As String, ByVal nCaja As Integer)

        Static impresora As String

        Dim Objdt As New DataTable
        Dim ObjSis As New BL_Sistema

        Dim a As Imprimir = New Imprimir
        a.MargenIzquierdo = 1
        a.MargenSuperior = 1

        Dim cHeader As New DataTable
        cHeader = ObjSistema.Get_Fiscal_Header(cPerJurCodigo)
        If cHeader.Rows.Count = 0 Then Exit Sub

        a.HeaderImage = System.Drawing.Image.FromFile(Application.StartupPath & "\logo-medica.jpg")

        Dim sCadena As String = vbNullString
        ''Nombre Empresa y/o Sucursal
        'Objdt = ObjSis.Get_Value_Table("cPerNombre", "Persona", "cPerCodigo", 1, cPerJurCodigo)
        sCadena = cHeader.Rows(0).Item("cPerNombre")
        a.AnadirLineaCabeza(sCadena.PadLeft(41 - Len(sCadena)))

        sCadena = cHeader.Rows(0).Item("cPerNombre2")
        a.AnadirLineaCabeza(sCadena.PadLeft(41 - Len(sCadena)))
        'RUC Empresa
        a.AnadirLineaCabeza("R.U.C. " & cHeader.Rows(0).Item("cPerIdeNumero"))
        a.AnadirLineaCabeza(cHeader.Rows(0).Item("cPerDomAbrev")) 'direccion
        a.AnadirLineaCabeza("Telef. " & cHeader.Rows(0).Item("cPerTelNumero"))

        a.AnadirLineaCabeza(cHeader.Rows(0).Item("UbiGeo"))
        a.AnadirLineaCabeza("")

        'El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia 
        'de que al final de cada linea agrega una linea punteada "==========" 
        a.AnadirLineaSubcabeza("Caja Nº. " & cNroCaja)

        Dim cDescDocu As String = ""

        Select Case nTipoDocu
            Case TipoDocuVta.Factura
                cDescDocu = "Factura Nº. "
            Case TipoDocuVta.BoletaVta
                cDescDocu = "Boleta Nº. "
            Case TipoDocuVta.Ticket
                cDescDocu = "Ticket Nº. "
        End Select

        a.AnadirLineaSubcabeza(cDescDocu & Microsoft.VisualBasic.Left(NroComprobante, 4) & "-" & Microsoft.VisualBasic.Right(NroComprobante, 7))

        Objdt = ObjSis.Get_Value_Table("cSerie,cNombreImpresora", "Medica.CtaCteDatosImpresora", "", 2, "cPerJurCodigo = '" & cPerJurCodigo & "' AND nCajCodigo = " & nCaja & " ")
        If Objdt.Rows.Count > 0 Then
            a.AnadirLineaCabeza("Serie Maquina: " & Objdt.Rows(0).Item("cSerie"))
            impresora = Objdt.Rows(0).Item("cNombreImpresora").ToString  ' "Star SP700 Cutter (SP742)" ' "\\192.168.1.65\EPSON L350 Series" '"PDF" 
        End If

        'Fecha y hora
        a.AnadirLineaSubcabeza("Fecha y hora: " & DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())

        'Cliente
        If nTipoPer = nConTipoPersona.nPerJuridica Then 'Factura
            Objdt = ObjSis.Get_Value_Table("cPerIdeNumero,nombre", "vw_Get_DatosPersona", "", 2, "cPerCodigo = '" & cPerCodigo & "' AND nPerIdeTipo =11")
            If Objdt.Rows.Count > 0 Then
                a.AnadirLineaSubcabeza("R.U.C.: " & Objdt.Rows(0).Item("cPerIdeNumero"))
                a.AnadirLineaSubcabeza("Razon Social: " & Objdt.Rows(0).Item("nombre"))
            End If

        Else
            Objdt = ObjSis.Get_Value_Table("cPerIdeNumero,nombre", "vw_Get_DatosPersona", "", 2, "cPerCodigo = '" & cPerCodigo & "' AND nPerIdeTipo =25")
            If Objdt.Rows.Count > 0 Then
                a.AnadirLineaSubcabeza("DNI: " & Objdt.Rows(0).Item("cPerIdeNumero"))
                a.AnadirLineaSubcabeza("Cliente: " & Objdt.Rows(0).Item("nombre"))
            End If
        End If

        a.EncabezadoElementos = "Cant.   Descripción           Precio"
        '--------------
        'Carga detalle
        '--------------
        'Dim nPos As Integer
        Dim Obj_DetAdmSol As New BL_FichaAtencion
        Dim dtDetAdmSol As New DataTable

        dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(cPerJurCodigo, Trim(LblnSolAdmNumero.Text))

        'Leyendo un DataTable
        If dtDetAdmSol.Rows.Count > 0 Then
            Dim row As DataRow

            For Each row In dtDetAdmSol.Rows
                'El metodo AddItem requeire 3 parametros, el primero es cantidad, el segundo es la descripcion 
                'del producto y el tercero es el precio 
                a.AnadirElemento(CStr(row("nCtaCteCantidad").ToString), Microsoft.VisualBasic.Left(CStr(row("cCtaCteSerKeyWord").ToString), 20), FormatNumber(row("nCtaCteSubTotal").ToString, True))
            Next
        End If

        'Get porcentaje IGV(18%)
        Dim nPorc As Double
        Objdt = ObjSis.Get_Value_Table("cIntNombre", "vw_Get_PorcIGV", "cPerCodigo", 1, cPerJurCodigo)
        If Objdt.Rows.Count > 0 Then nPorc = Convert.ToDouble(Objdt.Rows(0).Item("cIntNombre"))

        'El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio 
        Dim nGravada As Double, nIgv As Double
        nGravada = CLng(LblTotalPago.Text) / (1 + nPorc)
        nIgv = (CLng(LblTotalPago.Text) / (1 + nPorc)) * nPorc

        a.AnadirTotal("OP. GRAVADA", FormatNumber(nGravada, True))
        a.AnadirTotal("IGV.", FormatNumber(nIgv, True))
        a.AnadirTotal("IMP. TOTAL S/.", FormatNumber(LblTotalPago.Text, True))
        a.AnadirTotal("", "") ' //Ponemos un total en blanco que sirve de espacio 
        'a.AnadirTotal("RECIBIDO", "50.00")
        'a.AnadirTotal("CAMBIO", "15.00")
        'a.AnadirTotal("", "") '/Ponemos un total en blanco que sirve de espacio 
        'a.AnadirTotal("USTED AHORRO", "0.00")

        'Usuario Cajero (quien hace la atencion)
        Objdt = ObjSis.Get_Value_Table("cPerUsuCodigo", "PerUsuario", "cPerCodigo", 1, StrUser)
        If Objdt.Rows.Count > 0 Then a.AnadeLineaAlPie("Atendido por: " & Objdt.Rows(0).Item("cPerUsuCodigo"))
        a.AnadeLineaAlPie("")
        '//El metodo AddFooterLine funciona igual que la cabecera 
        a.AnadeLineaAlPie("...GRACIAS POR TU VISITA...")
        a.AnadeLineaAlPie("")
        'a.AnadeLineaAlPie("VIVE LA EXPERIENCIA EN STARBUCKS")
        a.AnadeLineaAlPie("Toda devolución se efectuara con cheque o transferencia bancaria, en un plazo no mayor a 7 días.")

        '//Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
        '//parametro de tipo string que debe de ser el nombre de la impresora. 
        a.ImprimeTicket(impresora)

    End Sub

    Private Sub BtnRegPago_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegPago.Click

        Try
            If ValidarCampos() Then
                Dim BLCorrelativo As New BL_CtaCteNumeracion
                Dim ObjCompPago As New BL_CtaCteComprobante_Pago

                Dim ResultadoPago As Boolean
                Dim ResultadoComp As Boolean
                'Dim ResultadoAsiento As Boolean
                'Dim ReqCCDet As New BE_ReqCtaCteDetalle

                'Dim List As New List(Of BE_ReqCtaCteDetalle)
                'Dim Item As BE_ReqCtaCteDetalle = Nothing '//Declara variable

                'Dim ListRec As New Dictionary(Of String, Double)

                Dim cPerCodigo As String = Trim(LblcPerCodigo.Text)
                Dim nCajCodigo As Long = CLng(LblNroCaja.Text)

                Dim nCtaCteComCodigo As Long = CLng(CboTipoDocu.SelectedValue)
                Dim cCtaCteComNumero As String = BLCorrelativo.Get_CtaCteNumCorrelativo(StrcPerJuridica, nCajCodigo, nCtaCteComCodigo)

                If MessageBox.Show("¿Desea registrar Comprobante de Venta.?", "Confirmar operación..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Using scope As New TransactionScope()

                        '-----------
                        'CtaCtePago
                        '-----------
                        With Table2
                            If .RowCount > 0 Then
                                For i As Integer = 0 To .Rows.Count - 1
                                    ResultadoPago = ObjCompPago.Ins_CtaCtePago_PagDatos(cPerCodigo,
                                                                                    StrcPerJuridica,
                                                                                    LblNroRecibo.Text,
                                                                                    nCajCodigo,
                                                                                    CLng(.Item("nCtaCteForPago", i).Value),
                                                                                    "",
                                                                                    FormatDateTime(.Item("dCtaCteFecTransacion", i).Value & Space(1) & TimeOfDay, DateFormat.GeneralDate),
                                                                                    "Pago por derecho Ficha de Atención",
                                                                                    CDbl(.Item("nCtaCtePagImporte", i).Value),
                                                                                    .Item("cPerCodigoBanco", i).Value,
                                                                                    .Item("cDescrBanco", i).Value,
                                                                                    .Item("cNroTarjCta", i).Value,
                                                                                    .Item("NroTrasacVoucher", i).Value)

                                Next
                            Else
                                MsgInfoCampoObligatorio("No existe ningún medio de Pago, por favor verifique.", BtnAdd)
                                Exit Sub
                            End If

                        End With

                        '-----------------
                        'CtaCteComprobante
                        '-----------------
                        '1=Contado
                        ResultadoComp = ObjCompPago.Ins_CtaCteComprobante_Upd_AdmSolAtencion_Upd_CtaCteNumeracion(LblNroRecibo.Text,
                                                                                                                  nCtaCteComCodigo,
                                                                                                                  cCtaCteComNumero,
                                                                                                                  1,
                                                                                                                  FormatDateTime(dFechaSistema & Space(1) & TimeOfDay),
                                                                                                                  StrcPerJuridica,
                                                                                                                  LblnSolAdmNumero.Text,
                                                                                                                  EstadoFichaAtencion.nPagoRealizado,
                                                                                                                  StrUser,
                                                                                                                  nCajCodigo)

                        '--------------------
                        'GenerandoAsientoVta
                        '--------------------
                        'Dim ObjAsiento As New BL_Asiento.BL_ConAsiento
                        'ResultadoAsiento = ObjAsiento.Ins_GenerandoAsientoVta(StrcPerJuridica,
                        '                                                      cPerCodigo,
                        '                                                      FormatDateTime(dFechaSistema & Space(1) & TimeOfDay),
                        '                                                      "Venta maquina registradora.",
                        '                                                      "1212101", "4011101", "7041001", "1091013",
                        '                                                      cCtaCteComNumero, nCtaCteComCodigo, 3003,
                        '                                                      LblNroRecibo.Text, cCtaCteComNumero,
                        '                                                      TipoMoneda.nSoles, 0.0, CLng(LblTotalPago.Text))

                        If ResultadoComp Then 'And ResultadoAsiento Then
                            'Imprimir comprobante
                            ImprimeTicket(StrcPerJuridica, CLng(LblnPerTipo.Text), cPerCodigo, CLng(CboTipoDocu.SelectedValue), cCtaCteComNumero, nCajCodigo)
                            scope.Complete()
                            'MessageBox.Show("Comprobante de Venta se registro con exitó.", "Imprimiendo..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'BtnCancel_Click(BtnCancel, Nothing)
                        Else
                            MessageBox.Show("Se encontraron errores..!", "Grabando..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End Using

                    StrPasaValores = vbNullString
                    Close()
                    Dispose()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click

        Dim Rows As Integer

        If ValidarCamposForAddItemGrd() Then

            'Validando si el medio de pago ya es utilizado
            If BuscaCadenaDgView("nCtaCteForPago", CboFormaPago.SelectedValue.ToString, Table2) Then 'AndAlso BuscaCadenaDgView("cPerCodigoBanco", CboBanco.ToString, Table2) Then
                MessageBox.Show("Medio de Pago <YA> ha sido utilizado, no podra utilizar el mismo medio de pago para el pago, verifique por favor.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                REM si no existe, aqui insertas el fila
                With Table2
                    Rows = .RowCount()
                    .Rows.Add()
                    .Item("nCtaCteForPago", Rows).Value = CLng(CboFormaPago.SelectedValue)
                    .Item("cDescForPago", Rows).Value = UCase(CboFormaPago.Text) '**Desc Tipo de Moneda
                    .Item("cPerCodigoBanco", Rows).Value = CboBanco.SelectedValue
                    .Item("cDescrBanco", Rows).Value = CboBanco.Text
                    .Item("dCtaCteFecTransacion", Rows).Value = IIf(CboFormaPago.SelectedValue = nFomaPago.nEfectivo, FormatDateTime(DtpFecPago.Value, DateFormat.GeneralDate), FormatDateTime(DtpFecDeposito.Value, DateFormat.GeneralDate))
                    .Item("cNroTarjCta", Rows).Value = Trim(TxtNroTarjeta.Text)
                    .Item("NroTrasacVoucher", Rows).Value = Trim(TxtVoucher.Text)
                    .Item("nMonCodigo", Rows).Value = CLng(CboMoneda.SelectedValue)
                    .Item("cDescMoneda", Rows).Value = UCase(CboMoneda.Text)
                    .Item("nCtaCtePagImpMon", Rows).Value = CDbl(TxtImpPago.Text)
                    .Item("nTC", Rows).Value = IIf(CboMoneda.SelectedValue = nTipoMoneda.nSoles, 1, CDbl(LblTC.Text))
                    .Item("nCtaCtePagImporte", Rows).Value = IIf(CboMoneda.SelectedValue = nTipoMoneda.nSoles, CDbl(TxtImpPago.Text), CDbl(TxtImpPago.Text) * CDbl(LblTC.Text))
                End With

                REM limpio para seguir agregando mas
                'InicilizarCampos()
                LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCtePagImporte", Table2), True)

                'Cuanto le falta para completar el total del recibo
                TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text) - Suma_Columna("nCtaCtePagImporte", Table2), True)
                If LblImpRecibo.Text <> LblTotalPago.Text Then CboFormaPago.Focus()
            End If
        End If

    End Sub

    Private Sub BtnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitar.Click

        Call EliminaRowSeleccionada(Table2)
        LblTotalPago.Text = Suma_Columna("nCtaCtePagImporte", Table2)

        TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text) - CDbl(LblTotalPago.Text), True)

    End Sub

    Private Sub CboFormaPago_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboFormaPago.KeyPress, CboTipoDocu.KeyPress, CboMoneda.KeyPress, CboBanco.KeyPress, CboTipoTarj.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboFormaPago_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboFormaPago.SelectionChangeCommitted

        Select Case CLng(CboFormaPago.SelectedValue)

            Case nFomaPago.nEfectivo
                GrpBoxBco.Visible = False
                CboBanco.SelectedValue = -1
                CboTipoTarj.SelectedValue = -1
                'CboNroCta_TarjetaDC.SelectedValue = -1
                TxtNroTarjeta.Text = vbNullString

            Case nFomaPago.nCheque

            Case nFomaPago.nDepositoBco

                Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
                Dim daBco As New BL_CtaCteServicioFacturacion

                GrpBoxBco.Visible = True

                Label13.Text = "Entidad Financiera:"
                CboBanco.SelectedValue = -1

                ReqBco.cFlag = "EBS" '"EBE"
                ReqBco.cPerJurCodigo = StrcPerJuridica '// CboBanco.SelectedValue

                LlenaDataCombo(CboBanco, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "cPerCodigo", "cPerApellido")

                CboTipoTarj.Enabled = False : CboTipoTarj.SelectedValue = -1
                Label12.Text = ""

                Label10.Text = "Nro. Cuenta:" 'Equipo se puden definir nro de cuenta de la empresa (agregar Combo)
                CboBanco_SelectionChangeCommitted(CboBanco, Nothing)
                Label15.Text = "Nro. Voucher:"

            Case nFomaPago.nTarjetaCred

                Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
                Dim daBco As New BL_CtaCteServicioFacturacion

                Label13.Text = "Entidad Financiera:"
                CboBanco.SelectedValue = -1
                ReqBco.cFlag = "EBS" '--TODAS LAS ENTIDADES BANCARIAS DEL SISTEMA
                LlenaDataCombo(CboBanco, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "cPerCodigo", "cPerApellido")

                Label12.Text = "Tipo Tarjeta:"
                CboTipoTarj.Enabled = True
                'LlenaDataCombo(CboTipoTarj, ObjInterface.Get_Interface(CLng(TokenByKey(CboTipoTarj.Tag, "nIntClase")), CLng(TokenByKey(CboTipoTarj.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")
                LlenaDataCombo(CboTipoTarj, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoTarj.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

                Label10.Text = "Nro. de Tarjeta:"
                Call CboTipoTarj_SelectionChangeCommitted(CboTipoTarj, Nothing)

                Label15.Text = "Nº Ope./Transac.:"
                GrpBoxBco.Visible = True

        End Select

    End Sub

    Private Sub CboTipoTarj_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoTarj.SelectionChangeCommitted

        'Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
        'Dim daBco As New BL_CtaCteServicioFacturacion

        'CboNroCta_TarjetaDC.SelectedValue = -1
        'CboNroCta_TarjetaDC.DataSource = Nothing
        'ReqBco.cFlag = "TDC"
        'ReqBco.cPerCodigo = CboBanco.SelectedValue.ToString
        'ReqBco.nPerIntCodigo = CboTipoTarj.SelectedValue
        'LlenaDataCombo(CboNroCta_TarjetaDC, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "cPerCodigo", "cPerIntDescripcion")

        TxtNroTarjeta.Text = vbNullString
        TxtVoucher.Text = vbNullString

    End Sub

    Private Sub CboBanco_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboBanco.SelectionChangeCommitted

        'If CboFormaPago.SelectedValue = nFomaPago.nDepositoBco Then
        '    'MsgBox("Pasando por Aqui")
        '    Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
        '    Dim daBco As New BL_CtaCteServicioFacturacion

        '    CboNroCta_TarjetaDC.SelectedValue = -1
        '    CboNroCta_TarjetaDC.DataSource = Nothing
        '    ReqBco.cFlag = "MCB"
        '    ReqBco.cPerJurCodigo = StrcPerJuridica
        '    ReqBco.cPerCodigo = CboBanco.SelectedValue
        '    LlenaDataCombo(CboNroCta_TarjetaDC, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "nPerCtaCodigo", "cNroCuentaOpera")
        'End If

    End Sub

    Private Sub CboMoneda_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboMoneda.SelectionChangeCommitted

        LblTC.Text = TipoCambio(CboMoneda.SelectedValue, "TCD", dFechaSistema)

    End Sub

    Private Sub BtnPagoDet_Click(sender As System.Object, e As System.EventArgs) Handles BtnPagoDet.Click

        'If TxtStrDetalle.Enabled Then
        '    BtnPagoDet.Text = " Más detalles (F8) »"
        '    TxtStrDetalle.Enabled = False
        '    TxtStrDetalle.Text = vbNullString
        '    Me.Height = 444
        'Else
        '    BtnPagoDet.Text = " Quitar detalles (F8) «"
        '    Me.Height = 553
        '    TxtStrDetalle.Enabled = True
        '    TxtStrDetalle.Focus()

        'End If

    End Sub

    Private Sub TxtImpPago_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImpPago.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        'e.Handled = Numero(e, TxtImpPago) ' TxtImpPago, caja de texto a validar
        e.Handled = TextBoxImporte(e, TxtImpPago)


    End Sub

    Private Sub PictureBox2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox3.Visible = False
    End Sub

    Private Sub TxtNroTarjeta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroTarjeta.KeyPress, TxtVoucher.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtImpPago_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImpPago.Enter
        If (Not String.IsNullOrEmpty(TxtImpPago.Text)) Then
            TxtImpPago.SelectionStart = 0
            TxtImpPago.SelectionLength = TxtImpPago.Text.Length
        End If
    End Sub
End Class