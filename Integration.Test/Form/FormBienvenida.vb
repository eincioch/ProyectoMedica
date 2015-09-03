Public Class FormBienvenida

    Dim Contador As Byte = 0

    Sub Temporizador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Temporizador.Tick

        If progressbar1.value < 100 Then
            contador = contador + 25
            progressbar1.value = Contador
        Else
            Me.Hide()
            FormAcceso.Show()
            Temporizador.Enabled = False
        End If
    End Sub

    Private Sub FormBienvenida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Opacity = 0.9
    End Sub
End Class