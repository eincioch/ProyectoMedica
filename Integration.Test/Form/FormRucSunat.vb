Public Class FormRucSunat

    Dim xDat As String
    Dim xRazSoc As String, xEst As String, xCon As String, xDir As String
    Dim xRazSocX As Long, xEstX As Long, xConX As Long, xDirX As Long
    Dim xRazSocY As Long, xEstY As Long, xConY As Long, xDirY As Long

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            Dim url As String = "http://www.sunat.gob.pe/w/wapS01Alias?ruc=" & TextBox1.Text
            Dim xml As New MSXML2.XMLHTTP

            xml.open("POST", url, False)

            'Realizo el envio de los datos 
            xml.send()

            If xml.status = 200 Then
                ' Limpiar()
                xDat = xml.responseText
                If Len(xDat) <= 635 Then
                    'Habilitar(False)
                    MessageBox.Show("El numero Ruc ingresado no existe en la Base de datos de la SUNAT", "Buscando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    xml = Nothing
                    TextBox1.Focus()
                    Exit Sub
                End If
                'Habilitar(True)
                xDat = Replace(xDat, "N&#xFA;mero Ruc. </b> " & TextBox1.Text & " - ", "RazonSocial:")
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

                TextBox2.Text = xRazSoc
                TextBox3.Text = xEst
                TextBox4.Text = xCon
                TextBox5.Text = xDir
            Else
                'Habilitar(False)
                'Limpiar()
                MsgBox("No responde el servicio de la SUNAT")
            End If
            xml = Nothing

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error el protocolo puede no estar habilitado")
        End Try

    End Sub
End Class