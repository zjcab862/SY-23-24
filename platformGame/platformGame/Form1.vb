﻿Public Class Form2dPlatformer
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Private Sub Form2dPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub

    Private Sub Form2dPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= moveSpeed
    End Sub

    Private Sub Form2dPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
        TextBox1.Select()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If

        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub
End Class
