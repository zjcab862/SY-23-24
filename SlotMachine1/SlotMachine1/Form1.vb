Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl11.spin()
        UserControl12.spin()
        UserControl13.spin()
        Timer1.Enabled = True
        'Label1.Text = UserControl11.itemValue
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UserControl11
    End Sub
End Class
