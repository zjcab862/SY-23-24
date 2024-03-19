Public Class
Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl1.spin()
        label1.text = UserControl1.itemValue
    End Sub
End Class
