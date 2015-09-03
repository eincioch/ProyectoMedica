Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Module mdl_ExportPDF

    Public Function Getcolumnassize(dg As DataGridView) As Single()

        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values

    End Function

    Public Sub ExportarDatosPDF(ByVal DataGridView As DataGridView, ByVal NameEmpresa As String, ByVal NameReporte As String)

        'Importar las siguientes librerias:

        'Imports iTextSharp.text
        'Imports iTextSharp.text.pdf

        Try
            Dim DataGrid As New DataGridView
            DataGrid = DataGridView

            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Exportar.pdf"

            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)

            doc.Open()
            doc.PageSize.Rotation = HorizontalAlignment.Center

            'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
            Dim datatable As New PdfPTable(DataGridView.ColumnCount)
            'Se asignan algunas propiedades para el diseño del PDF.
            datatable.DefaultCell.Padding = 3

            Dim headerwidths As Single() = Getcolumnassize(DataGrid)
            datatable.SetWidths(headerwidths)
            datatable.WidthPercentage = 100
            datatable.DefaultCell.BorderWidth = 2
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

            'Se crea el encabezado en el PDF.
            'Dim encabezado As New Paragraph("TryCodeNet", New Font(Font.NORMAL = "Tahoma", 14, Font.BOLD))
            Dim encabezado As New Paragraph(NameEmpresa, New Font(Font.NORMAL, 13, Font.BOLD))

            'Se crea el texto abajo del encabezado.
            'Dim texto As New Phrase("LoboGriz" + Now.Date(), New Font(Font.NORMAL = "Tahoma", 10, Font.BOLD))
            Dim texto As New Phrase(NameReporte & " - Fecha Impresión: " & dFechaSistema & Space(1) & TimeOfDay, New Font(Font.NORMAL, 9, Font.BOLD))

            'Se capturan los nombres de las columnas del DataGrid .
            For i As Integer = 0 To DataGrid.ColumnCount - 1
                datatable.AddCell(DataGrid.Columns(i).HeaderText)
            Next
            datatable.HeaderRows = 1
            datatable.DefaultCell.BorderWidth = 1

            'Se generan las columnas del DataGrid .
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
            For i As Integer = 0 To DataGrid.RowCount - 1
                For j As Integer = 0 To DataGrid.ColumnCount - 1
                    datatable.AddCell(DataGrid(j, i).Value.ToString)
                Next
                datatable.CompleteRow()
            Next
            'Se agrega el PDFTable al documento.
            doc.Add(encabezado)
            doc.Add(texto)
            doc.Add(datatable)
            doc.Close()

            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Generando PDF...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Invoke(New MethodInvoker(AddressOf ErrorVisorPDF))
        End Try

    End Sub

    'Public Sub BtnGenerarPDF_Click(ByVal sender As System.Object, _
    '                     ByVal e As System.EventArgs) Handles BtnGenerarPDF.Click

    '    'creamos el documento
    '    '...ahora configuramos para que el tamaño de hoja sea A4
    '    Dim document As Document = New Document(iTextSharp.text.PageSize.A4)
    '    document.PageSize.BackgroundColor = New iTextSharp.text.BaseColor(255, 255, 255)
    '    document.PageSize.Rotate()

    '    '...definimos el autor del documento.
    '    document.AddAuthor("Arbis Percy Reyes Paredes") '

    '    '//...el creador, que será el mismo eh!
    '    document.AddCreator("Arbis Percy Reyes Paredes")

    '    'hacemos que se inserte la fecha de creación para el documento
    '    document.AddCreationDate()

    '    '...título
    '    document.AddTitle("Generación de un pdf con itextSharp")

    '    '... el asunto
    '    document.AddSubject("Este es un paso muy important")

    '    '... palabras claves
    '    document.AddKeywords("pdf, PdfWriter; Documento; iTextSharp")

    '    'creamos un instancia del objeto escritor de documento
    '    Dim writer As PdfWriter = PdfWriter.GetInstance(document, New System.IO.FileStream _
    '                                              ("Code.pdf", System.IO.FileMode.Create))


    '    'encriptamos el pdf, dándole como clave de usuario "key" y la clave del dueño será "owner"
    '    'si quitas los comentarios (en writer.SetEncryption...), entonces el documento generado
    '    'no mostrarà tanto la información de autor, titulo, fecha de creacion... 
    '    'que habiamos establecio más arriba. y sólo podrás abrirlo con una clave

    '    'writer.SetEncryption(PdfWriter.STRENGTH40BITS,"key","owner", PdfWriter.CenterWindow);

    '    'definimos la manera de inicialización de abierto del documento.
    '    'esto, hará que veamos al inicio, todas la páginas del documento
    '    'en la parte izquierda
    '    writer.ViewerPreferences = PdfWriter.PageModeUseThumbs


    '    'con esto conseguiremos que el documento sea presentada de dos en dos 
    '    writer.ViewerPreferences = PdfWriter.PageLayoutTwoColumnLeft

    '    'con esto podemos oculta las barras de herramienta y de menú respectivamente.
    '    '(quite las dos barras de comentario de la siguiente línea para ver los efectos)
    '    'PdfWriter.HideToolbar | PdfWriter.HideMenubar

    '    'abrimos el documento para agregarle contenido
    '    document.Open()

    '    'este stream es para jalar el código
    '    Dim TemPath As String = Application.StartupPath.ToString()
    '    TemPath = TemPath.Substring(0, TemPath.Length - 4)
    '    Dim pathFileForm1cs As String = TemPath + "\Form1.vb"
    '    Dim reader As System.IO.StreamReader = New System.IO.StreamReader(pathFileForm1cs)

    '    'leemos primera línea
    '    Dim linea As String = reader.ReadLine()
    '    'creamos la fuente
    '    Dim myfont As iTextSharp.text.Font = New iTextSharp.text.Font( _
    '    FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.ITALIC))

    '    'creamos un objeto párrafo, donde insertamos cada una de las líneas que 
    '    'se vaya leyendo mediante el reader 
    '    Dim myParagraph As Paragraph = New Paragraph("Código fuente en Visual C# \n\n", myfont)

    '    Do
    '        'leyendo linea de texto
    '        linea = reader.ReadLine()
    '        'concatenando cada parrafo que estará formado por una línea
    '        myParagraph.Add(New Paragraph(linea, myfont))
    '    Loop While Not (linea Is Nothing) 'mientras no llegue al final de documento, sigue leyendo


    '    'agregar todo el paquete de texto
    '    document.Add(myParagraph)

    '    'esto es importante, pues si no cerramos el document entonces no se creara el pdf.
    '    document.Close()

    '    'esto es para abrir el documento y verlo inmediatamente después de su creación
    '    System.Diagnostics.Process.Start("AcroRd32.exe", "Code.pdf")
    'End Sub
End Module
