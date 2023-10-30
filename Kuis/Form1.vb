Public Class Form1
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim jumlah As Single

        jumlah = DateDiff("d", DateTimePicker1.Value, DateTimePicker2.Value)
        txtjumlahketerlambatan.Text = jumlah
        Select Case jumlah
            Case 1 To 7
                txtdenda.Text = "5000"
            Case 8 To 14
                txtdenda.Text = "10000"
            Case 15 To 30
                txtdenda.Text = "15000"
        End Select
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        txttotalbayar.Text = Val(txtdenda.Text) + Val(txthargapeminjaman.Text)
    End Sub

    Private Sub txtuang_TextChanged(sender As Object, e As EventArgs) Handles txtuang.TextChanged
        txtkembalian.Text = Val(txttotalbayar.Text) - Val(txtuang.Text)
    End Sub

    Private Sub txtkembalian_TextChanged(sender As Object, e As EventArgs) Handles txtkembalian.TextChanged
        txtkembalian.Text = Val(txtuang.Text) - Val(txttotalbayar.Text)
    End Sub
End Class
