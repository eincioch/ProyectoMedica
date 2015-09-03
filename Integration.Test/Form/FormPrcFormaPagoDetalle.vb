Public Class FormPrcFormaPagoDetalle

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click

        StrPasaValores = "cDetallePago=" & UCase(Trim(TxtStrDetalle.Text))
        BtnCancel_Click(BtnCancel, Nothing)

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

        'If Not frm Is Nothing Then
        '    frm.Close()
        'End If

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub FormPrcFormaPagoDetalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        TxtStrDetalle.Focus()

    End Sub

End Class