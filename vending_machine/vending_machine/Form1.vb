Public Class Form1
    Dim CS As New Coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.instertQuarter()
        Label5.Text = CS.total
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertNickle()
        Label5.Text = CS.total
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDime()
        Label5.Text = CS.total
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertDollar()
        Label5.Text = CS.total
    End Sub
End Class
