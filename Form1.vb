Public Class Form1

    Private Sub bt_calcular_Click(sender As Object, e As EventArgs) Handles bt_calcular.Click
        Dim v As Double = Val(tx_y.Text) + (Val(tx_q.Text) * Val(tx_q.Text) / (2 * Val(tx_g.Text) * (Val(tx_y.Text) * Val(tx_y.Text))))
        tx_resultado.Text = v

    End Sub
End Class
