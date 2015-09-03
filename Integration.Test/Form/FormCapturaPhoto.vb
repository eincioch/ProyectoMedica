Imports AForge.Video
Imports AForge.Video.DirectShow
REM Imports AForge.Video.FFMPEG


Public Class FormCapturaPhoto

    Dim CAMARA As VideoCaptureDevice 'CAMARA QUE ESTAMOS USANDO
    Dim BMP As Bitmap 'PARA GENERACION DE IMAGENES
    REM Dim ESCRITOR As New VideoFileWriter() 'GUARDA LAS IMAGENES EN MEMORIA

    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        If ButtonVIDEO.BackColor = Color.Black Then 'SI NO ESTA GRABANDO ......
            BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PONE LOS DATOS EN EL BITMAP
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
        Else ' SI ESTAS GRABANDO...
            Try
                BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PON LOS DATOS EN EL BITMAP
                PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
                REM ESCRITOR.WriteVideoFrame(BMP) 'LOS GUARDA EN LA MEMORIA
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub FormCapturaPhoto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom ' POR SI OLVIDAMOS AJUSTAR EL PICTUREBOX

        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm() 'DIALOGO CAMARAS DISPONIBLES
        If CAMARAS.ShowDialog() = DialogResult.OK Then
            CAMARA = CAMARAS.VideoDevice 'CAMARA ELEGIDA
            AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR) ' EJECUTARA CADA VEZ QUE SE GENERE UNA IMAGEN
            CAMARA.Start() 'INICIA LA PRESENTACION DE IMAGENES EN EL PICTUREBOX
            BtnFoto.Enabled = True
        End If

    End Sub

    Private Sub BtnFoto_Click(sender As System.Object, e As System.EventArgs) Handles BtnFoto.Click


        FormMaPerMasDetalle.PictureBox1.Image = PictureBox1.Image 'COPIA LA IMAGEN QUE HAY EN EL PICTUREBOX EN EL PICTUREBOX DEL FORMULARIO CAPTURA
        FormMaPerMasDetalle.Show() 'MUESTRA EL FORMULARIO CAPTURA
        StatusWebCam = 0

        Try
            CAMARA.Stop() 'CIERRA LA CAMARA
            REM ESCRITOR.Close() 'DEJA DE GUARDAR DATOS.
        Catch ex As Exception
        End Try

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

        StatusWebCam = 1
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

End Class