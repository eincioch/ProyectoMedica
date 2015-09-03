Option Explicit On

Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Imports Integration.BL.BL_Sistema
Imports System
Imports System.Net
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
'Imports System.Data.SqlServerCe
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Reflection


Module mdl_Functiones

    Public Function ValidaRangoFechas(ByVal FecIni As Date, ByVal FecFin As Date) As Boolean
        ValidaRangoFechas = False
        If Date.Parse(FecIni) > Date.Parse(FecFin) Then
            MessageBox.Show("Rango de Fechas no son coherentes.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Function
        End If
        ValidaRangoFechas = True
    End Function

    'Function para buscar cadenas
    Public Function Buscar_Cadena(ByVal Cadena As String, ByVal Posicion As Integer, _
                                  ByRef TextBox As TextBox) As Boolean

        Dim m_Pos As Integer
        Dim p As Integer, Frase As String

        Frase = Cadena
        p = Posicion

        p = InStr(Posicion, UCase(Trim(TextBox.Text)), UCase(Trim(Frase)))

        If p > 0 Then
            m_Pos = p

            'With TextBox
            '    .SelectionStart = m_Pos - 1
            '    .SelectionLength = Len(Frase)
            '    .Focus()
            'End With

            Return True
        Else
            'MsgBox("No se encontró la frase", vbInformation)
            'Text1.SetFocus()
            Return False
        End If

    End Function


    Public Function TextBoxImporte(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef cajasTexto As TextBox)

        Dim isDecimal, isMinus, isValidChar As Boolean
        Dim separadorDecimal As String = Nothing

        Select Case e.KeyChar
            Case "."c, ","c

                ' Si es el primer carácter del control, abandonamos
                ' el procecimiento.
                '
                If (cajasTexto.TextLength = 0) Then
                    e.Handled = True
                    Return True
                End If

                ' Obtenemos el carácter separador decimal existente
                ' actualmente en la configuración regional de Windows. 
                ' 
                separadorDecimal = _
                    Threading.Thread.CurrentThread. _
                    CurrentCulture.NumberFormat.NumberDecimalSeparator

                ' Hacemos que el carácter tecleado coincida con el
                ' carácter separador existentente en la configuración
                ' regional.
                '
                e.KeyChar = separadorDecimal.Chars(0)

                ' Es un carácter válido.
                '
                isDecimal = True
                isValidChar = True

            Case "-"c
                ' Es un carácter válido.
                '
                isMinus = True
                isValidChar = True

            Case Else
                ' Sólo se admitirán números y la tecla de retroceso.
                '
                Dim isDigit As Boolean = Char.IsDigit(e.KeyChar)
                Dim isControl As Boolean = Char.IsControl(e.KeyChar)

                If ((isDigit) OrElse (isControl)) Then
                    isValidChar = True

                Else
                    e.Handled = True
                    Return True

                End If

        End Select

        If UCase(e.KeyChar) Like "[.]" Then
            If InStr(cajasTexto.Text, ".") > 0 Then
                Return True
            Else
                Return False
            End If
        End If

        '//original
        'Dim isDecimal, isMinus, isValidChar As Boolean
        'Dim separadorDecimal As String = Nothing

        'Select Case e.KeyChar
        '    Case "."c, ","c

        '        ' Si es el primer carácter del control, abandonamos
        '        ' el procecimiento.
        '        '
        '        If (TxtImpPago.TextLength = 0) Then
        '            e.Handled = True
        '            Return
        '        End If

        '        ' Obtenemos el carácter separador decimal existente
        '        ' actualmente en la configuración regional de Windows. 
        '        ' 
        '        separadorDecimal = _
        '            Threading.Thread.CurrentThread. _
        '            CurrentCulture.NumberFormat.NumberDecimalSeparator

        '        ' Hacemos que el carácter tecleado coincida con el
        '        ' carácter separador existentente en la configuración
        '        ' regional.
        '        '
        '        e.KeyChar = separadorDecimal.Chars(0)

        '        ' Es un carácter válido.
        '        '
        '        isDecimal = True
        '        isValidChar = True

        '    Case "-"c
        '        ' Es un carácter válido.
        '        '
        '        isMinus = True
        '        isValidChar = True

        '    Case Else
        '        ' Sólo se admitirán números y la tecla de retroceso.
        '        '
        '        Dim isDigit As Boolean = Char.IsDigit(e.KeyChar)
        '        Dim isControl As Boolean = Char.IsControl(e.KeyChar)

        '        If ((isDigit) OrElse (isControl)) Then
        '            isValidChar = True

        '        Else
        '            e.Handled = True
        '            Return

        '        End If

        'End Select

        '' Referenciamos el control TextBox subyacente.
        ''
        'Dim tb As TextBox = TryCast(sender, TextBox)

        '' Si la conversión ha fallado, abandonamos el procedimiento.
        ''
        'If (tb Is Nothing) Then
        '    e.Handled = True
        '    Return
        'End If

        '' Si es un carácter válido, y el texto del control
        '' se encuentra totalmente seleccionado, elimino
        '' el valor actual del control.
        ''
        'If ((isValidChar) And (tb.SelectionLength = tb.TextLength)) Then
        '    tb.Text = String.Empty
        'End If

        'If (isMinus) Then
        '    ' Admitimos el carácter negativo, siempre y cuando
        '    ' sea el primer carácter del texto, y no exista ya
        '    ' ningún otro signo negativo.
        '    '
        '    If ((tb.Text.Length <> 0) OrElse (tb.Text.IndexOf("-"c) >= 0)) Then
        '        e.Handled = True
        '        Return
        '    End If
        'End If

        'If (isDecimal) Then
        '    ' Si en el control hay ya escrito un separador decimal, 
        '    ' deshechamos insertar otro separador más. 
        '    ' 
        '    If (tb.Text.IndexOf(separadorDecimal) >= 0) Then
        '        e.Handled = True
        '        Return
        '    End If
        'End If

    End Function

    Public Function Numero(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef cajasTexto As TextBox) As Boolean

        If UCase(e.KeyChar) Like "[!0-9.-]" Then
            Return True
        End If

        If UCase(e.KeyChar) Like "[.]" Then
            If InStr(cajasTexto.Text, ".") > 0 Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    'Function para validar solo numeros
    Public Function SoloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs) 'ByVal Keyascii As Short) As Short
        'If InStr("1234567890.", Chr(Keyascii)) = 0 Then
        '    SoloNumeros = 0
        'Else
        '    SoloNumeros = Keyascii
        'End If
        'Select Case Keyascii
        '    Case 8
        '        SoloNumeros = Keyascii
        '    Case 13
        '        SoloNumeros = Keyascii
        'End Select

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Function

    'Function extrae la parte entera
    Public Function ExtraeEntero(ByVal strcadena As String) As Long

        Dim i As Integer
        ExtraeEntero = 0

        For i = 1 To Len(strcadena)
            If Mid$(strcadena, i, 1) Like "#" Then _
                ExtraeEntero = ExtraeEntero & Mid$(strcadena, i, 1)
        Next i

    End Function

    'Funcion para Encriptar /Desencriptar
    Public Function fEncripta_Key(ByVal cKey As String, _
                                ByVal lKey As Boolean) As String

        Dim nLen As Integer
        Dim R As Integer
        Dim cOld, cNew, cPas As String

        'Inicializar varables
        cOld = "" : cPas = ""

        nLen = Len(cKey)
        For R = 1 To Len(cKey)
            cNew = Chr(Asc(Mid(cKey, R, 1)) + IIf(lKey, nLen, nLen * -1))
            cPas = cPas + cNew
        Next R
        fEncripta_Key = cPas

    End Function

    'Function Convierte de Numero a Texto
    Public Function Num2Text(ByVal value As Double) As String

        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

    End Function

    'Function para validar Contraseñas y sean mas complejas
    Public Function ValidatePassword(ByVal pwd As String,
                                Optional ByVal minLength As Integer = 8,
                                Optional ByVal numUpper As Integer = 2,
                                Optional ByVal numLower As Integer = 2,
                                Optional ByVal numNumbers As Integer = 2,
                                Optional ByVal numSpecial As Integer = 2) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New Regex("[A-Z]")
        Dim lower As New Regex("[a-z]")
        Dim number As New Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Public Function IsValidEmail(ByVal Email As String) As Boolean


        'If email = String.Empty Then Return False
        '' Compruebo si el formato de la dirección es correcto.
        'Dim re As Regex = New Regex("^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]{2,4}$") '"^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        ''Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        'Dim m As Match = re.Match(email)
        'Return (m.Captures.Count <> 0)

        Return Regex.IsMatch(Email, "^([\w-]+\.)*?[/w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

    End Function

    Public Function IsBounded(vntArray As Object) As Boolean
        On Error Resume Next
        IsBounded = (UBound(vntArray) >= LBound(vntArray))
    End Function

    Public Function TokenByKey(Expresion As String, Key As String, _
                Optional Delimiter As String = ";", Optional Separator As String = "=") As String
        On Error Resume Next

        Dim Tokens() As String
        Dim Valor() As String
        Dim nCount As Long

        Tokens = Split(Expresion, Delimiter, , vbTextCompare)
        For nCount = LBound(Tokens) To UBound(Tokens)
            Valor = Split(Tokens(nCount), Separator, , vbTextCompare)
            If IsBounded(Valor) Then
                If UBound(Valor) >= 0 Then
                    If Valor(0) = Key Then
                        If UBound(Valor) >= 1 Then TokenByKey = Valor(1)
                        'TokenByKey = vbNullString
                        Exit Function
                    End If
                End If
            End If
        Next

    End Function

    Public Function ItemLBound(Expresion As String, Optional Delimiter As String = "-") As Long
        Dim Variable() As String
        Variable = Split(Expresion, Delimiter, , vbTextCompare)
        ItemLBound = LBound(Variable)
    End Function

    Public Function ItemUBound(Expresion As String, Optional Delimiter As String = "-") As Long
        Dim Variable() As String
        Variable = Split(Expresion, Delimiter, , vbTextCompare)
        ItemUBound = UBound(Variable)
    End Function

    Public Function ObtenerPhoto(ByVal ArchivoImg As Byte()) As System.Drawing.Bitmap

        Dim arrImg() As Byte = ArchivoImg 'ObjImg.Get_PerImagen(RequestImg).Rows(0)("iPerImaFoto")
        Dim ms As New MemoryStream(arrImg)
        Dim img As Image = Image.FromStream(ms)

        REM muestro imagen en control PictureBox
        Dim SizeImage As Bitmap
        SizeImage = New Bitmap(img, New Size(166, 190))

        Return SizeImage
    End Function


    Public Function EsMail(ByVal Expresion As String) As Boolean

        Dim PosArroba As Integer
        Dim PosPunto As Integer
        PosArroba = InStr(1, Expresion, "@", vbTextCompare)
        PosPunto = InStrRev(Expresion, ".", , vbTextCompare)
        EsMail = (PosArroba > 0) And (PosPunto > PosArroba)

    End Function

    Function RemoveFirst(Expresion As String) As String

        RemoveFirst = ""
        If Len(Expresion) > 0 Then RemoveFirst = Right(Expresion, Len(Expresion) - 1)

    End Function

    Public Function ReadBinaryFile(ByVal fileName As String) As Byte()

        ' Si no existe el archivo, abandono la función.
        '
        If (Not (File.Exists(fileName))) Then Return Nothing

        Try
            ' Creamos un objeto Stream para poder leer el archivo especificado.
            '
            Using fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)

                ' Creamos un array de bytes, cuyo límite superior se corresponderá
                ' con la longitud en bytes de la secuencia menos una unidad.
                '
                Dim length As Int32 = Convert.ToInt32(fs.Length - 1)

                Dim data() As Byte = New Byte(length) {}

                ' Al leer la secuencia, se rellenará la matriz.
                '
                fs.Read(data, 0, length)

                ' Devolvemos el array de bytes.
                '
                Return data

            End Using

        Catch ex As Exception
            ' Devolvemos la excepción al procedimiento llamador.
            '
            Throw

        End Try

    End Function

    '//Function Obtiene Tamaña de Archivo - Img
    Public Function GetTamFile(ByVal path As String) As String

        Dim fi As New FileInfo(path)

        If fi.Exists Then
            If (fi.Length / 1024) > 1024 Then
                Return Math.Round(((fi.Length / 1024) / 1024), 2).ToString() '& " Mb"
            Else
                Return Math.Round((fi.Length / 1024), 2).ToString() '& " Kb"
            End If
        Else
            Return String.Empty
        End If
    End Function

    '//Function Valida RUC
    Public Function LenT(ByVal Cadena As String) As Long
        LenT = Len(Trim(Cadena))
    End Function

    Public Function Valida_RUT(ByVal NumeroRUT As String) As Boolean
        Dim Numero As String, dig_ver As String
        Dim Var_Sumatoria As Long
        Dim Var_LargoNumero As Long
        Dim i As Integer
        Dim Var_NumeroDigitos As String
        Dim Var_DigitoVerificador As String
        Dim Var_Resto As Integer
        If LenT(NumeroRUT) > 0 Then
            Numero = Left(NumeroRUT, Len(NumeroRUT) - 1)
            dig_ver = Right(NumeroRUT, 1)
        Else
            Valida_RUT = False
            Exit Function
        End If
        Var_Sumatoria = 0
        Var_NumeroDigitos = "765432765432"
        Var_LargoNumero = Len(Trim$(Numero))
        Var_NumeroDigitos = Right$(Var_NumeroDigitos, Var_LargoNumero)
        For i = 1 To Var_LargoNumero
            Var_Sumatoria = Var_Sumatoria + CInt(Mid$(Var_NumeroDigitos, i, 1)) * CInt(Mid$(Numero, i, 1))
        Next i
        Var_Resto = 11 - Var_Sumatoria + Int(Var_Sumatoria / 11) * 11
        Select Case Var_Resto
            Case 10
                Var_DigitoVerificador = "0"
            Case 11
                Var_DigitoVerificador = "1"
            Case Else
                Var_DigitoVerificador = CStr(Var_Resto)
        End Select
        If UCase$(dig_ver) = Var_DigitoVerificador Then
            Valida_RUT = True
        Else
            Valida_RUT = False
        End If
    End Function

    Public Function FindRUCPageSUNAT(ByVal cIdNumero As String) As String

        Dim xDat As String
        Dim xRazSoc As String, xEst As String, xCon As String, xDir As String
        Dim xRazSocX As Long, xEstX As Long, xConX As Long, xDirX As Long
        Dim xRazSocY As Long, xEstY As Long, xConY As Long, xDirY As Long

        Try
            REM DNI https://cel.reniec.gob.pe/valreg/valreg.do?accion=ini
            REM RUC http://www.sunat.gob.pe/w/wapS01Alias?ruc=
            Dim url As String = "http://www.sunat.gob.pe/w/wapS01Alias?ruc=" & cIdNumero
            Dim xml As New MSXML2.XMLHTTP

            xml.open("POST", url, False)

            'Realizo el envio de los datos 
            xml.send()

            If xml.status = 200 Then
                ' Limpiar()
                xDat = xml.responseText
                If Len(xDat) <= 635 Then
                    'Habilitar(False)
                    MessageBox.Show("El numero RUC ingresado No existe en la Base de datos de la SUNAT." & Chr(13) & _
                                        "¿Desea buscar por Razon Social en la pagina de la SUNAT.gob.pe.?; seleccione Ayuda.", "Consulta de RUC (http://www.sunat.gob.pe/w/wapS01Alias?ruc=)", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias")
                    xml = Nothing
                    'TextBox1.Focus()
                    Exit Function
                End If

                xDat = Replace(xDat, "N&#xFA;mero Ruc. </b> " & cIdNumero & " - ", "RazonSocial:")
                xDat = Replace(xDat, "Estado.</b>", "Estado:")
                xDat = Replace(xDat, "Agente Retenci&#xF3;n IGV.", "ARIGV:")
                xDat = Replace(xDat, "Situaci&#xF3;n.<b> ", "Situacion:")
                xDat = Replace(xDat, "Direcci&#xF3;n.</b><br/>", "Direccion:")
                xDat = Replace(xDat, "     ", " ")
                xDat = Replace(xDat, "    ", " ")
                xDat = Replace(xDat, "   ", " ")
                xDat = Replace(xDat, "  ", " ")
                xDat = Replace(xDat, "( ", "(")
                xDat = Replace(xDat, " )", ")")

                xRazSocX = InStr(1, xDat, "RazonSocial:", vbTextCompare)
                xRazSocY = InStr(1, xDat, " <br/></small>", vbTextCompare)
                xRazSocX = xRazSocX + 12
                xRazSoc = Mid(xDat, xRazSocX, (xRazSocY - xRazSocX))

                xEstX = InStr(1, xDat, "Estado:", vbTextCompare)
                xEstY = InStr(1, xDat, "ARIGV:", vbTextCompare)
                xEstX = xEstX + 7
                xEst = Mid(xDat, xEstX, ((xEstY - 34) - xEstX))

                xConX = InStr(1, xDat, "Situacion:", vbTextCompare)
                xConY = InStr(1, xDat, "</b></small><br/>", vbTextCompare)
                xDirY = xConX - 23
                xConX = xConX + 10
                xCon = Mid(xDat, xConX, (xConY - xConX))

                xDirX = InStr(1, xDat, "Direccion:", vbTextCompare)
                xDirX = xDirX + 10
                xDir = Mid(xDat, xDirX, (xDirY - xDirX))

                xRazSoc = Replace(xRazSoc, "&#209;", "Ñ")
                xRazSoc = Replace(xRazSoc, "&#xD1;", "Ñ")
                xRazSoc = Replace(xRazSoc, "&#193;", "Á")
                xRazSoc = Replace(xRazSoc, "&#201;", "É")
                xRazSoc = Replace(xRazSoc, "&#205;", "Í")
                xRazSoc = Replace(xRazSoc, "&#211;", "Ó")
                xRazSoc = Replace(xRazSoc, "&#218;", "Ú")
                xRazSoc = Replace(xRazSoc, "&#xC1;", "Á")
                xRazSoc = Replace(xRazSoc, "&#xC9;", "É")
                xRazSoc = Replace(xRazSoc, "&#xCD;", "Í")
                xRazSoc = Replace(xRazSoc, "&#xD3;", "Ó")
                xRazSoc = Replace(xRazSoc, "&#xDA;", "Ú")

                xDir = Replace(xDir, "&#209;", "Ñ")
                xDir = Replace(xDir, "&#xD1;", "Ñ")
                xDir = Replace(xDir, "&#193;", "Á")
                xDir = Replace(xDir, "&#201;", "É")
                xDir = Replace(xDir, "&#205;", "Í")
                xDir = Replace(xDir, "&#211;", "Ó")
                xDir = Replace(xDir, "&#218;", "Ú")
                xDir = Replace(xDir, "&#xC1;", "Á")
                xDir = Replace(xDir, "&#xC9;", "É")
                xDir = Replace(xDir, "&#xCD;", "Í")
                xDir = Replace(xDir, "&#xD3;", "Ó")
                xDir = Replace(xDir, "&#xDA;", "Ú")

                'TextBox2.Text = xRazSoc
                'TextBox3.Text = xEst
                'TextBox4.Text = xCon
                'TextBox5.Text = xDir
                FindRUCPageSUNAT = "RazonSocial=" & xRazSoc & ";Estado=" & xEst & ";Condicion=" & xCon & ";Direccion=" & xDir
            Else
                MessageBox.Show("No responde el servicio de la SUNAT", "Servidor..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            xml = Nothing

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error el protocolo puede no estar habilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function LoadAutoComplete(ByRef Data As DataTable, ByVal Campo As String) As AutoCompleteStringCollection

        Dim dt As DataTable = Data

        Dim stringCol As New AutoCompleteStringCollection()

        For Each row As DataRow In dt.Rows
            stringCol.Add(Convert.ToString(row(Campo)))
        Next

        Return stringCol
    End Function

    ' función que retorna el total   
    Public Function Suma_Columna( _
        ByVal nombre_Columna As String, _
        ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"   
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                If CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value) > 0.0 Then
                    total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
                End If
            Next
            'CDbl
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor   
        Return total

    End Function

    Public Function Suma_Columna_for_condicion( _
        ByVal nombre_Columna As String, _
        ByVal nombre_Columna_condicion As String, _
        ByVal condicion As String, _
        ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"   
        Try
            For I As Integer = 0 To Dgv.RowCount - 1
                If Dgv.Item(nombre_Columna_condicion, I).Value = condicion Then
                    If CDbl(Dgv.Item(nombre_Columna.ToLower, I).Value) > 0.0 Then
                        total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, I).Value)
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor   
        Return total

    End Function

    Public Function BuscaCadenaDgView(ByVal NameColumn As String, ByVal StraBuscar As String, ByRef ControlDgView As DataGridView) As Boolean

        'REM verifica si cPerCodigo ya ha existe en la Grilla
        BuscaCadenaDgView = False
        For Each row As DataGridViewRow In ControlDgView.Rows
            If CStr(row.Cells(NameColumn).Value) = StraBuscar Then
                BuscaCadenaDgView = True
                Exit For
            End If
        Next

    End Function

    Public Function RecorreCellDgView(ByRef ControlDgView As DataGridView) As Boolean

        RecorreCellDgView = False
        ' PARA RECORRER TODOS LAS CELDAS DE UNA DATAGRIDVIEW
        With ControlDgView
            For Renglones As Integer = 0 To .RowCount - 1
                For Columnas As Integer = 0 To .ColumnCount - 1
                    If Len(.Item(Columnas, Renglones).Value) = 0 Then
                        RecorreCellDgView = True
                        MsgBox(.Item(Columnas, Renglones).Value)
                    End If
                Next
            Next
        End With

    End Function

    Public Function ExisteDatoEnGrid(ByVal ControlDGV As DataGridView, ByVal NameColumn As String, ByVal MsgInfo As String) As Boolean

        Dim UltimaFila As Integer
        Dim cVal As String

        'Obtengo la ultima fila para que no se procese hasta el final
        UltimaFila = ControlDGV.Rows.Count - 1
        'Obtengo el valor de la primera columna ingresado por el usuario
        cVal = ControlDGV.Rows(UltimaFila).Cells(NameColumn).Value

        'Para cada fila del grid
        For Each row As DataGridViewRow In ControlDGV.Rows
            'Si es la última fila, se termina la funcion
            If row.Index = UltimaFila Then
                Exit Function
            End If

            'Pregunto si el dato de la primera columna es igual a lo ingresado en
            'la ultima fila por el cliente
            If System.Convert.ToString(row.Cells(NameColumn).Value) = cVal Then
                'MsgBox("Este dato ya exite", MsgBoxStyle.Critical)
                MessageBox.Show(MsgInfo, "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ExisteDatoEnGrid = True
                Exit Function
            Else
                ExisteDatoEnGrid = False
            End If
        Next

    End Function

    'Private Sub cargar_DataCombo(ByVal ControlDGV As DataGridView)
    '    Dim adapter As New SqlDataAdapter

    '    'La variable args contiene la cadena de conexión, llenada anteriormente.
    '    'No lo explico aquí porque es otro problema aparte
    '    Using connection As SqlConnection = New SqlConnection(args)
    '            adapter = New SqlDataAdapter(select campo_codigo, campo_descripcion from tabla, connection)

    '        'Lleno el DataTable
    '        Dim dt As New DataTable()
    '        adapter.Fill(dt)

    '        'Indico la columna combo
    '        Dim column As DataGridViewComboBoxColumn = _
    '        DirectCast(dv.Columns(0), DataGridViewComboBoxColumn)

    '        'Configuro la columna.
    '        With column
    '            'Origen de datos
    '            .DataSource = dt
    '            'Nombre del campo cuyos datos se mostraran en la columna
    '            .DisplayMember = "campo_descripcion"
    '            'Nombre del campo cuyo valor se devolvera cuando se seleccione un elemento.
    '            .ValueMember = "campo_codigo"
    '        End With
    '    End Using
    'End Sub


    'Public Function LogoEmpresa() As ds_RptFichaIndividual.EmpresaDataTable '  Empleados.EmpresaDataTable

    '    Dim dtEmpresas As New ds_RptFichaIndividual.EmpresaDataTable() '  Empleados.EmpresaDataTable()
    '    'Dim row As Empleados.EmpresaRow = dtEmpresas.NewEmpresaRow()
    '    Dim row As ds_RptFichaIndividual.EmpresaRow = dtEmpresas.NewEmpresaRow()

    '    row.ILogo = ImageToByteArray(ObtenerImagenLogoEmpresa())

    '    dtEmpresas.Rows.Add(row)

    '    Return dtEmpresas

    'End Function

    'Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()

    '    Dim ms As New MemoryStream()
    '    imageIn.Save(ms, ImageFormat.Jpeg)
    '    Return ms.ToArray()

    'End Function

    'Public Function ObtenerImagenLogoEmpresa() As Image

    '    Dim assembly As Assembly = System.Reflection.Assembly.GetExecutingAssembly()

    '    Dim file As Stream = assembly.GetManifestResourceStream("Helpers.Logo.jpg")
    '    Return Image.FromStream(file)

    'End Function

    Public Sub FillTreeview(ByVal TreeviewControl As TreeView, _
                            ByVal DataTreeview As IDataReader, _
                            Optional ByVal TreeviewItemPrevious As TreeNode = Nothing, _
                            Optional ByVal TreeviewItemUp As TreeNode = Nothing, _
                            Optional ByVal Checkeable As Boolean = True, _
                            Optional ByVal Selectable As Boolean = False, _
                            Optional ByVal KeyField As String = "nIntCodigo", _
                            Optional ByVal HierarchyField As String = "cIntJerarquia", _
                            Optional ByVal TextField As String = "cIntDescripcion", _
                            Optional ByVal NavigateUrlField As String = "", _
                            Optional ByVal CheckedField As String = "allowed")

        If Not DataTreeview.Read Then Exit Sub

        Dim TreeviewItemCurrent As TreeNode = Nothing
        Dim TreeviewItemTemp As TreeNode = Nothing

        Dim TreeviewItemPreviousValue As String = String.Empty
        Dim TreeviewItemCurrentValue As String = String.Empty
        Dim TreeviewItemUpValue As String = String.Empty

        Dim HasRecords As Boolean = False

        Dim Lx As Integer = 0
        Dim lProx As Integer = 0
        Dim lSup As Integer = 0

        Do
            HasRecords = True
            If TreeviewItemUp Is Nothing Then TreeviewItemUp = TreeviewItemPrevious
            If TreeviewItemPrevious IsNot Nothing Then TreeviewItemPreviousValue = TreeviewItemPrevious.ToolTipText
            If TreeviewItemUp IsNot Nothing Then TreeviewItemUpValue = TreeviewItemUp.ToolTipText
            TreeviewItemCurrentValue = GetTextValue(DataTreeview, HierarchyField).Trim

            Lx = TreeviewItemPreviousValue.Length
            lProx = TreeviewItemCurrentValue.Length
            lSup = TreeviewItemUpValue.Length

            If lSup < lProx And (Lx = lProx Or lSup = Lx) Then
                TreeviewItemCurrent = AgregarTreeNode(TreeviewControl, TreeviewItemUp, DataTreeview, _
                                                      Checkeable, Selectable, KeyField, HierarchyField, _
                                                      TextField, NavigateUrlField, CheckedField)
                TreeviewItemPrevious = TreeviewItemCurrent
                HasRecords = DataTreeview.Read()
            ElseIf Lx < lProx And lSup < lProx And Lx < lProx Then
                FillTreeview(TreeviewControl, DataTreeview, TreeviewItemPrevious, Nothing, _
                             Checkeable, Selectable, KeyField, HierarchyField, TextField, _
                             NavigateUrlField, CheckedField)
            Else
                Exit Sub
            End If
        Loop While HasRecords

    End Sub


    Public Sub FillTreeview2(ByVal TreeviewControl As TreeView, _
                                ByVal DataTreeview As IDataReader, _
                                Optional ByVal TreeviewItemPrevious As TreeNode = Nothing, _
                                Optional ByVal TreeviewItemUp As TreeNode = Nothing, _
                                Optional ByVal Checkeable As Boolean = True, _
                                Optional ByVal Selectable As Boolean = False, _
                                Optional ByVal KeyField As String = "nIntCodigo", _
                                Optional ByVal HierarchyField As String = "cIntJerarquia", _
                                Optional ByVal TextField As String = "cIntNombre", _
                                Optional ByVal NavigateUrlField As String = "", _
                                Optional ByVal CheckedField As String = "allowed")

        If Not DataTreeview.Read Then Exit Sub

        Dim TreeviewItemCurrent As TreeNode = Nothing
        Dim TreeviewItemTemp As TreeNode = Nothing

        Dim TreeviewItemPreviousValue As String = String.Empty
        Dim TreeviewItemCurrentValue As String = String.Empty
        Dim TreeviewItemUpValue As String = String.Empty

        Dim HasRecords As Boolean = False

        Dim Lx As Integer = 0
        Dim lProx As Integer = 0
        Dim lSup As Integer = 0

        Do
            HasRecords = True
            If TreeviewItemUp Is Nothing Then TreeviewItemUp = TreeviewItemPrevious
            If TreeviewItemPrevious IsNot Nothing Then TreeviewItemPreviousValue = TreeviewItemPrevious.ToolTipText
            If TreeviewItemUp IsNot Nothing Then TreeviewItemUpValue = TreeviewItemUp.ToolTipText
            TreeviewItemCurrentValue = GetTextValue(DataTreeview, HierarchyField).Trim

            'MsgBox(GetTextValue(DataTreeview, HierarchyField).Trim)

            Lx = TreeviewItemPreviousValue.Length
            lProx = TreeviewItemCurrentValue.Length
            lSup = TreeviewItemUpValue.Length

            If lSup < lProx And (Lx = lProx Or lSup = Lx) Then
                TreeviewItemCurrent = AgregarTreeNode(TreeviewControl, TreeviewItemUp, DataTreeview, _
                                                      Checkeable, Selectable, KeyField, HierarchyField, _
                                                      TextField, NavigateUrlField, CheckedField)
                TreeviewItemPrevious = TreeviewItemCurrent
                HasRecords = DataTreeview.Read()
            ElseIf Lx < lProx And lSup < lProx And Lx < lProx Then
                FillTreeview2(TreeviewControl, DataTreeview, TreeviewItemPrevious, Nothing, _
                             Checkeable, Selectable, KeyField, HierarchyField, TextField, _
                             NavigateUrlField, CheckedField)
            Else
                Exit Sub
            End If
        Loop While HasRecords

    End Sub

    Private Function AgregarTreeNode(ByVal TreeviewControl As TreeView, ByRef TreeviewItemParent As TreeNode, ByVal DataTreeview As IDataReader, _
                                     Optional ByVal Checkeable As Boolean = True, Optional ByVal Selectable As Boolean = False, _
                                     Optional ByVal KeyField As String = "nIntCodigo", Optional ByVal HierarchyField As String = "cIntJerarquia", _
                                     Optional ByVal TextField As String = "cIntDescripcion", Optional ByVal NavigateUrlField As String = "", _
                                     Optional ByVal CheckedField As String = "allowed") As TreeNode
        Dim TreeviewItemCurrent As New TreeNode
        Try
            Dim Texto As String = String.Empty
            Dim Clave As String = String.Empty
            Dim Key As String = String.Empty
            Dim CanSelect As Boolean = False

            'Dim nIntClase As Integer = CType(DataTreeview.GetValue(DataTreeview.GetOrdinal("nIntClase")), Integer)
            Clave = GetTextValue(DataTreeview, KeyField)
            'MsgBox(Clave)
            Texto = GetTextValue(DataTreeview, TextField)
            'MsgBox(Texto)
            If String.IsNullOrEmpty(Clave.Trim) Then
                Key = Guid.NewGuid.ToString
                CanSelect = False
            Else
                Key = mdlConstante.KeyItem & Clave
                'MsgBox(Key)
                CanSelect = True
            End If
            If String.IsNullOrEmpty(Clave.Trim) And String.IsNullOrEmpty(Texto.Trim) Then Return Nothing

            TreeviewItemCurrent = New TreeNode(Texto)
            'TreeviewItemCurrent = New TreeNode(Texto, Key)
            TreeviewItemCurrent.Text = GetTextValue(DataTreeview, HierarchyField).Trim
            TreeviewItemCurrent.Checked = Checkeable
            If GetTextValue(DataTreeview, CheckedField) = "1" And Checkeable Then TreeviewItemCurrent.Checked = True
            'TreeviewItemCurrent.NavigateUrl = GetTextValue(DataTreeview, NavigateUrlField)

            If Selectable And CanSelect Then
                'TreeviewItemCurrent.SelectAction = TreeNodeSelectAction.SelectExpand
                TreeviewItemCurrent.SelectedImageKey = SelectionMode.MultiExtended
            Else
                TreeviewItemCurrent.SelectedImageKey = SelectionMode.None
            End If
            TreeviewItemCurrent.Expand()
            If TreeviewItemParent Is Nothing Then
                TreeviewControl.Nodes.Add(TreeviewItemCurrent)
            Else
                TreeviewItemParent.Nodes.Add(TreeviewItemCurrent)
            End If
        Catch Ex As Exception
            Throw Ex
        End Try

        Return TreeviewItemCurrent

    End Function

    Public Function AppPathExe() As String

        Return System.Windows.Forms.Application.StartupPath

    End Function

    Public Function ObtenerParametroAppConfig(ByVal NameKey As String) As String

        Dim configurationAppSettings As New AppSettingsReader

        ObtenerParametroAppConfig = vbNullString
        Return CType(configurationAppSettings.GetValue(NameKey, GetType(System.String)), String)

    End Function

    Public Function TipoCambio(ByVal nMonCodigo As Long, ByVal nFlag As String, ByVal dFechaSys As String, Optional ByVal anno As Long = 0, Optional ByVal mes As Long = 0, Optional ByVal TipoC As String = "nCompra") As Double

        Dim daTC As New BL.BL_Sistema

        If daTC.Get_TipodeCambio(nMonCodigo, nFlag, dFechaSys, anno, mes).Rows.Count > 0 Then
            If TipoC = "nCompra" Then
                TipoCambio = CDbl(daTC.Get_TipodeCambio(nMonCodigo, nFlag, dFechaSys, anno, mes).Rows(0)("nCompra"))
            Else
                TipoCambio = CDbl(daTC.Get_TipodeCambio(nMonCodigo, nFlag, dFechaSys, anno, mes).Rows(0)("nVenta"))
            End If
        Else
            TipoCambio = 0
        End If

    End Function


    Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal titulo As String)

        Try
            Dim m_Excel As New Excel.Application

            m_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True

            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                'Encabezado   
                .Range("A1:L1").Merge()
                .Range("A1:L1").Value = "COLEGIO DE CONTADORES PUBLICOS DE LA LIBERTAD"
                .Range("A1:L1").Font.Bold = True
                .Range("A1:L1").Font.Size = 14
                'Copete   
                .Range("A2:L2").Merge()
                .Range("A2:L2").Value = titulo
                .Range("A2:L2").Font.Bold = True
                .Range("A2:L2").Font.Size = 12

                Const primeraLetra As Char = "A"
                Const primerNumero As Short = 3

                Dim Letra As Char, UltimaLetra As Char
                Dim Numero As Integer, UltimoNumero As Integer

                Dim cod_letra As Byte = Asc(primeraLetra) - 1
                Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator

                'Establecer formatos de las columnas de la hija de cálculo   
                Dim strColumna As String = ""
                Dim LetraIzq As String = ""
                Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
                Letra = primeraLetra
                Numero = primerNumero
                Dim objCelda As Excel.Range
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra + Numero.ToString
                        objCelda = .Range(strColumna, Type.Missing)
                        objCelda.Value = c.HeaderText
                        objCelda.EntireColumn.Font.Size = 8

                        'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format   

                        'If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        '    objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                        'End If
                    End If
                Next

                Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
                objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
                UltimaLetra = Letra
                Dim UltimaLetraIzq As String = LetraIzq

                'CARGA DE DATOS   
                Dim i As Integer = Numero + 1

                For Each reg As DataGridViewRow In DataGridView1.Rows
                    LetraIzq = ""
                    cod_LetraIzq = Asc(primeraLetra) - 1
                    Letra = primeraLetra
                    cod_letra = Asc(primeraLetra) - 1
                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        If c.Visible Then
                            If Letra = "Z" Then
                                Letra = primeraLetra
                                cod_letra = Asc(primeraLetra)
                                cod_LetraIzq += 1
                                LetraIzq = Chr(cod_LetraIzq)
                            Else
                                cod_letra += 1
                                Letra = Chr(cod_letra)
                            End If
                            strColumna = LetraIzq + Letra
                            ' acá debería realizarse la carga   
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", Chr(39) & Convert.ToString(reg.Cells(c.Index).Value))
                            '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))   
                            '.Range(strColumna + i, strColumna + i).In()   

                        End If
                    Next
                    Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                    objRangoReg.Rows.BorderAround()
                    objRangoReg.Select()
                    i += 1
                Next
                UltimoNumero = i

                'Dibujar las líneas de las columnas   
                LetraIzq = ""
                cod_LetraIzq = Asc("A")
                cod_letra = Asc(primeraLetra)
                Letra = primeraLetra
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                        objCelda.BorderAround()
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            LetraIzq = Chr(cod_LetraIzq)
                            cod_LetraIzq += 1
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                    End If
                Next

                'Dibujar el border exterior grueso   
                Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
                objRango.Select()
                objRango.Columns.AutoFit()
                objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            End With

            m_Excel.Cursor = Excel.XlMousePointer.xlDefault
        Catch ex As Exception
            MessageBox.Show(ex.Message & Space(1) & ex.Source & Space(1) & "; Exportando archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Module
