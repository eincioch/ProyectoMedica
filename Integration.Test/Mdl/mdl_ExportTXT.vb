Imports System.IO

Module mdl_ExportTXT

    Public Sub ExportTXT(ByVal DataGridView As DataGridView, Optional ByVal CaracterCorteLinea As String = "¤")

        Dim sFile As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Exportar.txt"
        Dim _Line As String = Nothing

        Const DELIMITADOR As String = "|"

        Try
            If File.Exists(sFile) = True Then 'Si el archivo existe, lo elimina antes

                My.Computer.FileSystem.DeleteFile(sFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)

            End If

            'Nuevo objeto StreamWriter, para acceder al fichero y poder guardar las líneas  
            Using archivo As StreamWriter = New StreamWriter(sFile)

                ' variable para almacenar la línea actual del dataview  
                Dim linea As String = String.Empty

                With DataGridView
                    ' Recorrer las filas del dataGridView  
                    For fila As Integer = 0 To .RowCount - 1
                        ' vaciar la línea  
                        linea = String.Empty

                        ' Recorrer la cantidad de columnas que contiene el dataGridView  
                        For col As Integer = 1 To .Columns.Count - 1
                            ' Almacenar el valor de toda la fila , y cada campo separado por el delimitador  
                            linea = linea & .Item(col, fila).Value.ToString & DELIMITADOR
                        Next

                        ' Escribir una línea con el método WriteLine  
                        With archivo
                            ' eliminar el último caracter ";" de la cadena  
                            linea = linea.Remove(linea.Length - 1).ToString
                            linea = linea + CaracterCorteLinea '"¤"
                            ' escribir la fila  
                            .WriteLine(linea.ToString)
                        End With
                    Next
                End With
            End Using

            ' Abrir con Process.Start el archivo de texto  
            Process.Start(sFile)

            'error  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

End Module
