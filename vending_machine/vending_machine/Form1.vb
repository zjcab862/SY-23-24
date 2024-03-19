Public Class Form1
    Dim WithEvents CS As New Coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.instertQuarter()
        Label5.Text = CS.total.ToString("C2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertNickle()
        Label5.Text = CS.total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDime()
        Label5.Text = CS.total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertDollar()
        Label5.Text = CS.total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.coinReturn()
        Label5.Text = CS.total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer) Handles CS.CoinReturnEvent
        BackColor = Color.Red
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDtextbox.Text
            Case ProductControl1.ProductID
                ProductControl1.Buy()
            Case 2

            Case Else

        End Select
        ProductControl1.Buy()
    End Sub
End Class
