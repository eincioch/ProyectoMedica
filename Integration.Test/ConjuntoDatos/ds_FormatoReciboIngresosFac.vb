

Partial Public Class ds_FormatoReciboIngresosFac
    Partial Class FormatoReciboIngresoDataTable

        Private Sub FormatoReciboIngresoDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cImpPagDescColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
