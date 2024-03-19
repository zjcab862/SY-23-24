Imports Microsoft.VisualBasic.ApplicationServices

Public Class mover
    Public Property speed As Integer
    Public Property interval As Integer = 500
    Public Property sprite As PictureBox
    Dim xdir As Integer = 1
    Dim ydir As Integer = 0

    Private Sub mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = interval
        sprite.Left = Me.Left
        sprite.Top = Me.Top
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sprite Is Nothing Then
            sprite.Left += xdir * speed
            sprite.Top += ydir * speed
        End If
    End Sub
End Class
