Imports System.Data.SqlClient
Imports System.Globalization
'Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports system.Data.Common
Imports System.Data
Imports System.Xml
Imports System.IO.Compression
Imports System.IO
Imports System.Windows.Forms
'Imports DAL
Imports System.Collections.Generic


Public Module Helper
    Public nRecorrido As Integer = 0
    Dim nValRetorno As Integer = 0
    Dim nSalida As Integer = 0

#Region "Cadenas"

    'Concat multiple strings
    Public Function Concat(ByVal Separador As String, ByVal ParamArray Filtro() As String) As String
        Dim OutPut As String
        Dim i As Integer
        OutPut = ""
        For i = UBound(Filtro) To LBound(Filtro) Step -1
            OutPut = Trim(Filtro(i)) & IIf(Trim(OutPut) <> "", IIf(Trim(Filtro(i)) <> "", " " & Separador & " ", "") & OutPut, "")
        Next
        Concat = OutPut
    End Function

    ' Convert a string to a byte array 
    Public Function StrToByteArray(ByVal str As String) As Byte()
        Try
            Dim encoding As New System.Text.UTF8Encoding
            Return encoding.GetBytes(str)
        Catch
            Return New Byte() {}
        End Try
    End Function

    ' Convert a byte array to a string:
    Public Function ByteArrayToStr(ByVal dBytes() As Byte) As String
        Try
            Dim enc As New System.Text.UTF8Encoding()
            Return enc.GetString(dBytes)
        Catch
            Return String.Empty
        End Try
    End Function

    'Public Function AplicarCriterio(ByVal Criterio As Busqueda.Criterio, _
    '                                ByVal Expresion As String, _
    '                                Optional ByVal Tilde As Boolean = True, _
    '                                Optional ByVal DB As Boolean = True) As String
    '    Dim strOut As String = String.Empty
    '    strOut = PreventDuplicates(IIf(Criterio = Busqueda.Criterio.Empieza, String.Empty, "%") & Expresion & IIf(Criterio = Busqueda.Criterio.Finaliza, String.Empty, "%"), "%")
    '    If Tilde Then strOut = DBTilde(strOut)
    '    If DB Then strOut = DBStr(strOut)
    '    Return strOut
    'End Function

    Public Function PreventDuplicates(ByVal Expresion As String, ByVal CharacterToFind As String) As String
        Dim I As Integer, WordLength As Integer
        Dim Character As String = String.Empty
        Dim LastCharacter As String = String.Empty
        Dim NewWord As String = String.Empty

        Try
            WordLength = Expresion.Length
            For I = 1 To WordLength
                Character = Expresion.Chars(I - 1)
                If LastCharacter = CharacterToFind And Character = CharacterToFind Then
                Else
                    NewWord = NewWord & Character
                    LastCharacter = Character
                End If
            Next I


        Catch ex As Exception

        End Try
        Return NewWord.Trim
    End Function

    Public Function DBStr(ByVal Expresion As Object, Optional ByVal Nulo As Boolean = False) As String
        Dim strOut As String = String.Empty
        If Expresion Is Nothing OrElse String.IsNullOrEmpty(Expresion) Then
            If Nulo Then
                strOut = "Null"
            Else
                strOut = ""
                'strOut = "''"
            End If
        Else
            strOut = "'" & Replace(Expresion, "'", "''") & "'"
        End If
        Return strOut
    End Function

    Public Function DBTilde(ByVal Expresion As String) As String
        Dim nCount As Long
        Dim strOut As String = String.Empty
        Dim Letra As String = String.Empty
        Dim Comodin As String = String.Empty
        Dim Filtro As String = String.Empty
        Static letras(7) As String

        letras(1) = "AÁÀÂÄ"
        letras(2) = "EÉÈÊË"
        letras(3) = "IÍÌÎÏYÝŸ"
        letras(4) = "OÓÒÔÖ0"
        letras(5) = "UÚÙÛÜ"
        letras(6) = "SCZ"
        letras(7) = "JG"

        For nCount = 1 To Expresion.Length
            Letra = Expresion.Chars(nCount - 1)
            Filtro = vbNullString
            For Each Comodin In letras
                If InStr(Comodin, Letra, CompareMethod.Text) > 0 Then
                    Filtro = "[" & Comodin & "]"
                    Exit For
                End If
            Next
            If String.IsNullOrEmpty(Filtro) Then Filtro = Letra
            strOut = strOut & Filtro
        Next
        Return strOut.ToUpper
    End Function

    Public Function FormatoHora(ByVal Fecha As Date) As String
        Return Format(Fecha, "HH:mm").ToUpper
    End Function

    Public Function FormatoFechaMediana(ByVal Fecha As Date) As String
        Return Format(Fecha, "ddd dd/MMM/yyyy").ToUpper
    End Function

    Public Function FormatoFechaMedianaConHora(ByVal Fecha As Date) As String
        Return Format(Fecha, "ddd dd/MMM/yyyy hh:mm:ss").ToUpper
    End Function

#Region "Comprension/Descomprension"

    Public Function Compress(ByVal data() As Byte) As Byte()
        Try
            '---the ms is used for storing the compressed data---
            Dim ms As New MemoryStream()
            Dim zipStream As Stream = Nothing

            zipStream = New GZipStream(ms, _
                            CompressionMode.Compress, True)
            '---or---
            'zipStream = New DeflateStream(ms, _
            '                CompressionMode.Compress, True)

            '---compressing using the info stored in data---
            zipStream.Write(data, 0, data.Length)
            zipStream.Close()

            ms.Position = 0
            '---used to store the compressed data (byte array)---
            Dim compressed_data(ms.Length - 1) As Byte

            '---read the content of the memory stream into 
            '   the byte array---
            ms.Read(compressed_data, 0, ms.Length)
            Return compressed_data
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Decompress(ByVal data() As Byte) As Byte()
        Try
            '---copy the data (compressed) into ms---
            Dim ms As New MemoryStream(data)
            Dim zipStream As Stream = Nothing

            '---decompressing using data stored in ms---
            zipStream = New GZipStream(ms, CompressionMode.Decompress)
            '---or---
            'zipStream = New DeflateStream(ms, _
            '                CompressionMode.Decompress, True)

            '---used to store the decompressed data---
            Dim dc_data() As Byte

            '---the decompressed data is stored in zipStream; 
            ' extract them out into a byte array---
            dc_data = ExtractBytesFromStream(zipStream, data.Length)

            Return dc_data
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function StrCompress(ByVal Expresion As String) As String
        Dim Buffer() As Byte = StrToByteArray(Expresion)
        Dim ms As New MemoryStream
        Dim ZipStream As New DeflateStream(ms, CompressionMode.Compress, True)
        ZipStream.Write(Buffer, 0, Buffer.Length)
        ZipStream.Flush()
        ZipStream.Close()
        ms.Position = 0
        Return ByteArrayToStr(ms.ToArray)
    End Function

    Public Function StrDecompress(ByVal Expresion As String) As String
        Dim Buffer() As Byte = StrToByteArray(Expresion)
        Dim ms As New MemoryStream(Buffer)
        If ms.ToArray.Equals(Buffer) Then
            'Iguales
            Buffer = Nothing
        End If
        Dim ZipStream As New DeflateStream(ms, CompressionMode.Decompress)
        Dim BufferDecompress() As Byte = ExtractBytesFromStream(ZipStream, Buffer.Length)
        Return ByteArrayToStr(BufferDecompress)
    End Function

    Public Function ExtractBytesFromStream( _
       ByVal stream As Stream, _
       ByVal dataBlock As Integer) _
       As Byte()

        '---extract the bytes from a stream object---
        Dim data() As Byte
        Dim totalBytesRead As Integer = 0
        Try
            While True
                '---progressively increase the size 
                ' of the data byte array---
                ReDim Preserve data(totalBytesRead + dataBlock)
                Dim bytesRead As Integer = _
                   stream.Read(data, totalBytesRead, dataBlock)
                If bytesRead = 0 Then
                    Exit While
                End If
                totalBytesRead += bytesRead
            End While
            '---make sure the byte array contains exactly the number 
            ' of bytes extracted---
            ReDim Preserve data(totalBytesRead - 1)
            Return data
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#End Region

#Region "MenuHelper"

    Public Sub FillMenu(ByVal MenuControl As Menu, _
                        ByVal DataMenu As SqlDataReader, _
                        ByRef MenuItemPreviousValue As String, _
                        ByRef MenuItemUp As MenuItem)

        If Not DataMenu.HasRows Then Exit Sub

        Dim MenuItemPrevious As MenuItem = Nothing
        Dim MenuItemCurrentValue As String = String.Empty
        Dim MenuItemUpValue As String = String.Empty
        Dim MenuItemCurrent As MenuItem = Nothing
        Dim MenuItemTemp As MenuItem = Nothing

        Dim Lx, lProx, lSup As Integer
        Do
            MenuItemCurrentValue = DataMenu.GetString(DataMenu.GetOrdinal("cIntJerarquia")).Trim
            If MenuItemPrevious Is Nothing Then MenuItemPrevious = MenuItemCurrent
            If MenuItemPreviousValue = String.Empty Then MenuItemPreviousValue = MenuItemCurrentValue
            If MenuItemUp IsNot Nothing Then MenuItemUpValue = MenuItemUp.Text

            Lx = MenuItemPreviousValue.Length
            lProx = MenuItemCurrentValue.Length

            lSup = ((lProx \ 2) - 1) * 2
            If lSup < 0 Then lSup = 0

            If Left(MenuItemCurrentValue, lSup) = Left(MenuItemPreviousValue, lSup) And InStr(1, MenuItemCurrentValue, MenuItemUpValue) > 0 Then
                If Lx < lProx Then      'AUMENTAR NIVEL
                    MenuItemTemp = MenuItemPrevious
                    MenuItemPreviousValue = String.Empty
                    FillMenu(MenuControl, DataMenu, MenuItemPreviousValue, MenuItemTemp)
                    MenuItemCurrent = AgregarMenuItem(MenuControl, MenuItemUp, DataMenu)
                Else                    'DISMINUIR O MANTENER NIVEL
                    MenuItemCurrent = AgregarMenuItem(MenuControl, MenuItemUp, DataMenu)
                End If
                'MenuItemPreviousValue = MenuItemCurrent.Value
                If MenuItemCurrent IsNot Nothing Then MenuItemPreviousValue = MenuItemCurrent.Text
                MenuItemPrevious = MenuItemCurrent
            Else
                If Lx >= lProx Then Exit Sub
            End If
        Loop While DataMenu.Read()

    End Sub

    Private Function AgregarMenuItem(ByVal MenuControl As Menu, ByRef MenuItemParent As MenuItem, ByVal DataMenu As SqlDataReader)
        Dim MenuItemCurrent As New MenuItem
        Dim cIntDescripcion As String = String.Empty
        Try
            If DataMenu.IsDBNull(DataMenu.GetOrdinal("cIntDescripcion")) Then
                cIntDescripcion = String.Empty
            Else
                cIntDescripcion = DataMenu.GetString(DataMenu.GetOrdinal("cIntDescripcion")).Trim
            End If
            'MenuItemCurrent = New MenuItem(DataMenu.GetString(DataMenu.GetOrdinal("cIntNombre")).Trim, _
            '                               DataMenu.GetString(DataMenu.GetOrdinal("cIntJerarquia")).Trim, _
            '                               String.Empty, cIntDescripcion)


            MenuItemCurrent.MenuItems.Add(DataMenu.GetString(DataMenu.GetOrdinal("cIntNombre")).Trim _
                                              )


            'MenuItemCurrent.Selectable = Not String.IsNullOrEmpty(cIntDescripcion)
            If Not DataMenu.IsDBNull(DataMenu.GetOrdinal("cIntTarget")) Then
                MenuItemCurrent.MenuItems.Add(DataMenu.GetString(DataMenu.GetOrdinal("cIntTarget")).Trim)
            End If
            If MenuItemParent Is Nothing Then
                MenuControl.MenuItems.Add(MenuItemCurrent)
            Else
                MenuItemParent.MenuItems.Add(MenuItemCurrent)
            End If
        Catch
        End Try

        Return MenuItemCurrent
    End Function

#End Region

#Region "Treeview"

    Public Sub FillTreeview(ByVal TreeviewControl As TreeView, _
                            ByVal DataTreeview As SqlDataReader, _
                            Optional ByRef TreeviewItemPreviousValue As String = Nothing, _
                            Optional ByRef TreeviewItemUp As TreeNode = Nothing)

        If Not DataTreeview.HasRows Then Exit Sub

        Dim TreeviewItemPrevious As TreeNode = Nothing
        Dim TreeviewItemCurrentValue As String = String.Empty
        Dim TreeviewItemUpValue As String = String.Empty
        Dim TreeviewItemCurrent As TreeNode = Nothing
        Dim TreeviewItemTemp As TreeNode = Nothing

        Dim HierarchyField As String = "cIntJerarquia"

        Dim Lx, lProx, lSup As Integer

        Do
            TreeviewItemCurrentValue = GetTextValue(DataTreeview, HierarchyField).Trim
            If TreeviewItemPrevious Is Nothing Then TreeviewItemPrevious = TreeviewItemCurrent
            If TreeviewItemPreviousValue = String.Empty Then TreeviewItemPreviousValue = TreeviewItemCurrentValue
            'If TreeviewItemUp IsNot Nothing Then TreeviewItemUpValue = TreeviewItemUp.ImageToolTip

            Lx = TreeviewItemPreviousValue.Length
            lProx = TreeviewItemCurrentValue.Length

            lSup = TreeviewItemUpValue.Length ' ((lProx \ 2) - 1) * 2
            If lSup < 0 Then lSup = 0

            If Left(TreeviewItemCurrentValue, lSup) = Left(TreeviewItemPreviousValue, lSup) And InStr(1, TreeviewItemCurrentValue, TreeviewItemUpValue) > 0 Then
                If Lx < lProx Then      'AUMENTAR NIVEL
                    TreeviewItemTemp = TreeviewItemPrevious
                    TreeviewItemPreviousValue = String.Empty
                    FillTreeview(TreeviewControl, DataTreeview, TreeviewItemPreviousValue, TreeviewItemTemp)
                    TreeviewItemCurrent = AgregarTreeNode(TreeviewControl, TreeviewItemUp, DataTreeview)
                Else                    'DISMINUIR O MANTENER NIVEL
                    TreeviewItemCurrent = AgregarTreeNode(TreeviewControl, TreeviewItemUp, DataTreeview)
                End If
                'TreeviewItemPreviousValue = TreeviewItemCurrent.ImageToolTip
                TreeviewItemPrevious = TreeviewItemCurrent
            Else
                If Lx >= lProx Then Exit Sub
            End If
        Loop While DataTreeview.Read()

    End Sub

    Private Function AgregarTreeNode(ByVal TreeviewControl As TreeView, ByRef TreeviewItemParent As TreeNode, ByVal DataTreeview As SqlDataReader)
        Dim TreeviewItemCurrent As New TreeNode
        Try
            Dim Texto As String = String.Empty
            Dim nIntClase As Integer = CType(DataTreeview.GetValue(DataTreeview.GetOrdinal("nIntClase")), Integer)
            Select Case nIntClase
                Case "CAMBIE AQUI EINCIO" 'InterfaceClase.MenuWeb
                    Texto = DataTreeview.GetString(DataTreeview.GetOrdinal("cIntNombre")).Trim
                Case Else
                    Texto = DataTreeview.GetString(DataTreeview.GetOrdinal("cIntDescripcion")).Trim
            End Select
            'TreeviewItemCurrent = New TreeNode(Texto, Constante.KeyItem & DataTreeview.GetValue(DataTreeview.GetOrdinal("nIntCodigo")).ToString)
            'TreeviewItemCurrent.ImageToolTip = DataTreeview.GetString(DataTreeview.GetOrdinal("cIntJerarquia")).Trim
            'TreeviewItemCurrent.ShowCheckBox = True
            TreeviewItemCurrent.Tag = DataTreeview("cIntJerarquia").ToString
            TreeviewItemCurrent.ImageKey = DataTreeview("cIntNombre").ToString
            TreeviewItemCurrent.Name = DataTreeview("nIntCodigo").ToString
            If DataTreeview.GetValue(DataTreeview.GetOrdinal("allowed")) = 1 Then TreeviewItemCurrent.Checked = True
            'TreeviewItemCurrent.NavigateUrl = String.Empty
            'TreeviewItemCurrent.se = TreeNodeSelectAction.None
            TreeviewItemCurrent.Expand()
            If TreeviewItemParent Is Nothing Then
                TreeviewControl.Nodes.Add(TreeviewItemCurrent)
            Else
                TreeviewItemParent.Nodes.Add(TreeviewItemCurrent)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return TreeviewItemCurrent
    End Function



    Public Sub FillTv(ByVal tv As TreeView, _
                     ByVal DataNodo As SqlClient.SqlDataReader, _
                     ByRef NodoItemPreviousValue As String, _
                     ByRef NodoItemUp As TreeNode)

        Dim nodo As New TreeNode
        Dim NodoItemPrevious As TreeNode = Nothing
        Dim NodoItemCurrentValue As String = String.Empty
        Dim NodoItemUpValue As String = String.Empty
        Dim TreeNodeCurrent As TreeNode = Nothing
        Dim TreeNodeTemp As TreeNode = Nothing

        Dim Lx, lProx, lSup As Integer
        If Not DataNodo.HasRows Then Exit Sub

        Do
            NodoItemCurrentValue = DataNodo("cIntJerarquia").ToString 'Replace(DataNodo("cIntJerarquia").ToString, "SA", "09")
            If NodoItemPrevious Is Nothing Then NodoItemPrevious = TreeNodeCurrent
            If NodoItemPreviousValue = String.Empty Then NodoItemPreviousValue = NodoItemCurrentValue
            If NodoItemUp IsNot Nothing Then NodoItemUpValue = NodoItemUp.Tag

            nRecorrido = nRecorrido + 1

            Lx = NodoItemPreviousValue.Length
            lProx = NodoItemCurrentValue.Length
            lSup = NodoItemUpValue.Length
         
            '===========================================
            '=======    Lectuta de Variables    ========
            '===========================================

            'Lx         = Anterior
            'Lprox      = Actual
            'Lsup       = Superior
            'nRecorrido = Variable que verifica las veces
            '             que se recorreo la Data.
            'nSalida    = Validar si se ha salido del Sub
            'nValRetorno= Valor que recupera la longitud
            '             de caracteres cuando se sale.

            '===========================================
            '===========================================

            If Lx < lProx And lSup < lProx Then      'AUMENTAR UN NIVEL MÁS
                nSalida = 0
                TreeNodeTemp = NodoItemPrevious
                NodoItemPreviousValue = String.Empty
                FillTv(tv, DataNodo, NodoItemPreviousValue, TreeNodeTemp)

                '*****************************************************************
                '***********    Evaluamos los regresos de las salidas
                '*****************************************************************
                If IIf(nSalida <> 0, (nValRetorno <= lSup), (lProx < Lx)) Then
                    nSalida = 1
                    Exit Sub
                Else
                    nSalida = 0
                    TreeNodeCurrent = AgregarNodo(tv, NodoItemUp, DataNodo)
                    If nRecorrido > 1 Then
                        NodoItemPreviousValue = TreeNodeCurrent.Tag
                        NodoItemPrevious = TreeNodeCurrent
                    End If
                End If
                '*****************************************************************
                '*****************************************************************

            ElseIf (Lx = lProx And lProx >= lSup) Then  'MANTENER EL NIVEL 
                nSalida = 0
                TreeNodeCurrent = AgregarNodo(tv, NodoItemUp, DataNodo)

                NodoItemPreviousValue = TreeNodeCurrent.Tag
                NodoItemPrevious = TreeNodeCurrent

            ElseIf (lProx < Lx And nRecorrido > 1) Then
                nSalida = 1
                nValRetorno = lProx
                Exit Sub
            End If

        Loop While DataNodo.Read()
        tv.ExpandAll()
    End Sub


    Private Function AgregarNodo(ByVal tv As TreeView, ByRef TreeNodeParent As TreeNode, ByVal DataNodo As SqlClient.SqlDataReader)
        Dim TreeNodeCurrent As New TreeNode
        Try

            Select Case DataNodo("nIntClase").ToString
                Case "" 'InterfaceClase.MenuWeb
                    TreeNodeCurrent.Text = DataNodo("cIntNombre").ToString
                Case "" 'InterfaceClase.Comprobantes
                    TreeNodeCurrent.Text = DataNodo("cIntNombre").ToString + " ---> " + DataNodo("cIntDescripcion").ToString + " - " + DataNodo("cIntJerarquia").ToString
                Case Else
                    TreeNodeCurrent.Text = DataNodo("cIntDescripcion").ToString
            End Select

            'TreeNodeCurrent.Text = DataNodo("cIntDescripcion").ToString
            TreeNodeCurrent.Tag = DataNodo("cIntJerarquia").ToString 'Replace(DataNodo("cIntJerarquia").ToString, "SA", "09")
            TreeNodeCurrent.ImageKey = DataNodo("cIntNombre").ToString
            TreeNodeCurrent.Name = DataNodo("nIntCodigo").ToString
            TreeNodeCurrent.Checked = DataNodo("allowed").ToString = "1"
            If TreeNodeParent Is Nothing Then
                tv.Nodes.Add(TreeNodeCurrent)
            Else
                TreeNodeParent.Nodes.Add(TreeNodeCurrent)
            End If
        Catch ex As Exception

        End Try

        Return TreeNodeCurrent
    End Function

    Public Sub FillTvn(ByVal TreeviewControl As TreeView, _
                     ByVal DataTreeview As SqlDataReader, _
                     Optional ByVal TreeviewItemPrevious As TreeNode = Nothing, _
                     Optional ByVal TreeviewItemUp As TreeNode = Nothing, _
                     Optional ByVal Checkeable As Boolean = True, _
                     Optional ByVal Selectable As Boolean = False, _
                     Optional ByVal KeyField As String = "nIntCodigo", _
                     Optional ByVal HierarchyField As String = "cIntJerarquia", _
                     Optional ByVal TextField As String = "cIntDescripcion", _
                     Optional ByVal NavigateUrlField As String = "", _
                     Optional ByVal CheckedField As String = "allowed", _
                     Optional ByVal nRecordsDataTreeView As Integer = 0, _
                     Optional ByVal ImgTv As ImageList = Nothing)

        If Not DataTreeview.HasRows Then Exit Sub

        Dim TreeviewItemCurrent As TreeNode = Nothing
        Dim TreeviewItemTemp As TreeNode = Nothing

        Dim TreeviewItemPreviousValue As String = String.Empty
        Dim TreeviewItemCurrentValue As String = String.Empty
        Dim TreeviewItemUpValue As String = String.Empty

        Dim HasRecords As Boolean = False

        Dim LNodoAnterior As Integer = 0
        Dim lNodoActual As Integer = 0
        Dim lNodoSuperior As Integer = 0

        Do

            'HasRecords = True
            If TreeviewItemUp Is Nothing Then TreeviewItemUp = TreeviewItemPrevious
            If TreeviewItemPrevious IsNot Nothing Then TreeviewItemPreviousValue = TreeviewItemPrevious.Tag
            If TreeviewItemUp IsNot Nothing Then TreeviewItemUpValue = TreeviewItemUp.Tag
            TreeviewItemCurrentValue = GetTextValue(DataTreeview, HierarchyField).Trim

            LNodoAnterior = TreeviewItemPreviousValue.Length
            lNodoActual = TreeviewItemCurrentValue.Length
            lNodoSuperior = TreeviewItemUpValue.Length

            If lNodoSuperior < lNodoActual And (LNodoAnterior = lNodoActual Or lNodoSuperior = LNodoAnterior) Then '
                TreeviewItemCurrent = AgregarTreeNoden(TreeviewControl, TreeviewItemUp, DataTreeview, Checkeable, Selectable, KeyField, HierarchyField, TextField, NavigateUrlField, CheckedField, ImgTv)
                TreeviewItemPrevious = TreeviewItemCurrent
                'HasRecords = DataTreeview.Read()
                'nRecorrido = nRecorrido + 1
            ElseIf LNodoAnterior < lNodoActual And lNodoSuperior < lNodoActual Then
                FillTvn(TreeviewControl, DataTreeview, TreeviewItemPrevious, Nothing, _
                             Checkeable, Selectable, KeyField, HierarchyField, TextField, _
                             NavigateUrlField, CheckedField, 0, ImgTv)
            End If

            If LNodoAnterior > lNodoActual Then Exit Sub

            'If nRecorrido >= nRecordsDataTreeView Then Exit Sub

        Loop While DataTreeview.Read()
        TreeviewControl.ExpandAll()
    End Sub


    Private Function AgregarTreeNoden(ByVal TreeviewControl As TreeView, _
                                        ByRef TreeviewItemParent As TreeNode, _
                                        ByVal DataTreeview As SqlDataReader, _
                                        Optional ByVal Checkeable As Boolean = True, _
                                        Optional ByVal Selectable As Boolean = False, _
                                        Optional ByVal KeyField As String = "nIntCodigo", _
                                        Optional ByVal HierarchyField As String = "cIntJerarquia", _
                                        Optional ByVal TextField As String = "cIntDescripcion", _
                                        Optional ByVal NavigateUrlField As String = "", _
                                        Optional ByVal CheckedField As String = "allowed", _
                                         Optional ByVal ImgTv As ImageList = Nothing)
        Dim TreeviewItemCurrent As New TreeNode
        Try
            Dim Texto As String = String.Empty
            Dim Clave As String = String.Empty
            Dim Key As String = String.Empty
            Dim CanSelect As Boolean = False

            'Dim nIntClase As Integer = CType(DataTreeview.GetValue(DataTreeview.GetOrdinal("nIntClase")), Integer) 
            Clave = GetTextValue(DataTreeview, KeyField)
            Texto = GetTextValue(DataTreeview, TextField)

            If String.IsNullOrEmpty(Clave.Trim) Then
                Key = Guid.NewGuid.ToString
                CanSelect = False
            Else
                'Key = Constante.KeyItem & Clave
                Key = "K" & Clave
                CanSelect = True
            End If
            If String.IsNullOrEmpty(Clave.Trim) And String.IsNullOrEmpty(Texto.Trim) Then Return Nothing

            If GetTextValue(DataTreeview, HierarchyField).Length = 4 Then
                TreeviewItemCurrent.ImageIndex = 0
            ElseIf GetTextValue(DataTreeview, HierarchyField).Length = 8 Then
                TreeviewItemCurrent.ImageIndex = 1
            ElseIf GetTextValue(DataTreeview, HierarchyField).Length = 12 Then
                TreeviewItemCurrent.ImageIndex = 2
            ElseIf GetTextValue(DataTreeview, HierarchyField).Length = 16 Then
                TreeviewItemCurrent.ImageIndex = 6
            ElseIf GetTextValue(DataTreeview, HierarchyField).Length = 20 Then
                TreeviewItemCurrent.ImageIndex = 4
            ElseIf GetTextValue(DataTreeview, HierarchyField).Length = 24 Then
                TreeviewItemCurrent.ImageIndex = 5
            ElseIf GetTextValue(DataTreeview, HierarchyField).Length = 28 Then
                TreeviewItemCurrent.ImageIndex = 3
            ElseIf GetTextValue(DataTreeview, HierarchyField).Length = 32 Then
                TreeviewItemCurrent.ImageIndex = 7
            End If
            'TreeviewItemCurrent = New TreeNode( Texto, Key)
            TreeviewItemCurrent.Text = Texto
            TreeviewItemCurrent.ToolTipText = GetTextValue(DataTreeview, "cIntNombre") & "/" & Clave
            TreeviewItemCurrent.Tag = GetTextValue(DataTreeview, HierarchyField).Trim
            TreeviewItemCurrent.Name = GetTextValue(DataTreeview, KeyField).Trim
            'treeviewitemcurrent
            'TreeviewItemCurrent.ShowCheckBox = Checkeable
            If GetTextValue(DataTreeview, CheckedField) = "1" And Checkeable Then TreeviewItemCurrent.Checked = True
            'TreeviewItemCurrent.NavigateUrl = GetTextValue(DataTreeview, NavigateUrlField)
            'If Selectable And CanSelect Then
            '    TreeviewItemCurrent.SelectAction = TreeNodeSelectAction.SelectExpand
            'Else
            '    TreeviewItemCurrent.SelectAction = TreeNodeSelectAction.None
            'End If
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

#End Region

#Region "DatetimeHelper"

    Public Function ToDateTime(ByVal Expresion As String) As DateTime
        Dim Fecha As DateTime = Nothing
        Dim culture As CultureInfo = New CultureInfo("es-PE", True)
        Try
            Fecha = DateTime.Parse(Expresion, culture, DateTimeStyles.NoCurrentDateDefault)
        Catch ex As Exception

        End Try
        Return Fecha
    End Function

#End Region

#Region "DataHelper"

    'Public Function ExecuteDataReader(ByVal Db As Database, ByVal Transaccion As DbTransaction, ByVal Cmd As DbCommand) As IDataReader
    '    Try
    '        If Transaccion Is Nothing Then
    '            Return Db.ExecuteReader(Cmd)
    '        Else
    '            Return Db.ExecuteReader(Cmd, Transaccion)
    '        End If
    '    Catch ex As SqlException
    '        Throw ex
    '    End Try
    'End Function

    'Public Function ExecuteNonQuery(ByVal Db As Database, ByVal Transaccion As DbTransaction, ByVal Cmd As DbCommand, Optional ByVal RecordsAffected As Long = 0) As Boolean

    '    Try
    '        If Transaccion Is Nothing Then
    '            RecordsAffected = Db.ExecuteNonQuery(Cmd)
    '        Else
    '            RecordsAffected = Db.ExecuteNonQuery(Cmd, Transaccion)
    '        End If

    '        Return True

    '    Catch ex As SqlException
    '        Throw ex
    '    End Try

    'End Function

    Public Function LoadDataTable(ByVal dr As IDataReader) As DataTable
        Try
            Dim Dt As New DataTable
            Dt.Load(dr)
            Return Dt
        Catch ex As DbException
            Throw ex
        End Try
    End Function


#End Region

#Region "XML"

    Public Function XMLElementById(ByVal Xml As String, ByVal ElementId As String) As String

        Try
            Dim Doc As New XmlDocument
            Doc.LoadXml(Xml)
            Dim Nodes As XmlNodeList = Doc.GetElementsByTagName(ElementId)
            For Each Node As XmlNode In Nodes
                Return Node.InnerText
            Next
            Return String.Empty
        Catch
            Return String.Empty
        End Try

    End Function

    Public Function XmlAddElement(ByVal Xml As String, ByVal ElementId As String, ByVal InnerText As Object) As String

        Try
            Dim Doc As New XmlDocument
            Dim Element As XmlElement = Nothing
            Dim Nodes As XmlNodeList = Nothing
            If Not String.IsNullOrEmpty(Xml) Then
                Doc.LoadXml(Xml)
            End If
            If Doc.DocumentElement Is Nothing Then
                Dim RootElement As XmlElement = Doc.CreateElement("Root")
                Doc.AppendChild(RootElement)
            Else
                Nodes = Doc.GetElementsByTagName(ElementId)
            End If
            If Nodes IsNot Nothing AndAlso Nodes.Count > 0 Then
                For Each Node As XmlNode In Nodes
                    Node.InnerText = InnerText
                Next
            Else
                Element = Doc.CreateElement(ElementId)
                Element.InnerText = InnerText
                Doc.DocumentElement.AppendChild(Element)
            End If
            Return Doc.InnerXml
        Catch
            Return Xml
        End Try

    End Function

#End Region

#Region "Miscelanea"

    Public Function GetMyTheme() As String
        Return "USS"
    End Function

#End Region

#Region "Data"

    Public Function GetTextValue(ByVal dr As IDataReader, ByVal Expresion As String) As String

        Dim strOut As String = String.Empty
        Dim FieldIndex As Long = 0

        Dim Tokens() As String = Expresion.Split("-")

        For I As Integer = 0 To Tokens.Length - 1

            Dim FieldValue As String = String.Empty

            Try
                FieldIndex = dr.GetOrdinal(Tokens(I))
            Catch ex As Exception
                FieldIndex = -1
            End Try

            If FieldIndex >= 0 Then
                Try
                    FieldValue = dr.GetString(FieldIndex)
                Catch ex As Exception
                    FieldValue = dr.GetValue(FieldIndex).ToString
                End Try
            Else
                FieldValue = Tokens(I)
            End If

            strOut &= FieldValue

        Next

        Return strOut
    End Function

    Public Function GetKeyValue(ByVal dr As IDataReader, ByVal Expresion As String) As String
        Dim StrOut As String = String.Empty
        Dim FieldIndex As Long = 0

        Dim Tokens() As String = Expresion.Split("-")

        For I As Integer = 0 To Tokens.Length - 1

            Dim FieldValue As String = String.Empty

            Try
                FieldIndex = dr.GetOrdinal(Tokens(I))
            Catch ex As Exception
                FieldIndex = -1
            End Try

            If FieldIndex >= 0 Then
                Try
                    FieldValue = dr.GetString(FieldIndex)
                Catch ex As Exception
                    FieldValue = dr.GetValue(FieldIndex).ToString
                End Try
            Else
                FieldValue = Tokens(I)
            End If

            StrOut &= Tokens(I) & "=" & FieldValue

        Next

        Return StrOut
    End Function

#End Region


#Region "Status Bar"
    Public Function Status_Version()
        Dim Version As String = String.Empty
        Version = My.Application.Info.Version.ToString
        Return Version
    End Function
#End Region

#Region "DataControl"

    'Public Sub ddl_Fill(ByVal ddl As DropDownList, _
    '                    ByVal dr As SqlDataReader, _
    '                    ByVal DataValueField As String, _
    '                    ByVal DataTextField As String)
    '    If Not ddl.AppendDataBoundItems Then
    '        ddl.Items.Clear()
    '    End If
    '    Do While dr.Read
    '        ddl.Items.Add(New ListItem(GetTextValue(dr, DataTextField), KeyItem & GetKeyValue(dr, DataValueField)))
    '    Loop
    'End Sub

    'Public Sub ddl_Fill(ByVal ddl As DropDownList, ByVal dr As SqlDataReader)
    '    ddl.DataSource = dr
    '    ddl.DataBind()
    'End Sub

#End Region



End Module