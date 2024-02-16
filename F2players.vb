﻿Public Class F2players

    Public btns As Control(,) = {{Btn00, Btn01, Btn02}, {Btn10, Btn11, Btn12}, {Btn20, Btn21, Btn22}}
    Public Sub F2players_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblP1.Text = namep1
        LblP2.Text = namep2
    End Sub

    Private Sub Btn00_Click(sender As Object, e As EventArgs) Handles Btn00.Click
        game(0, 0)
        If verify = True Then
            Btn00.Text = val
        End If

        winmechanism()
    End Sub
    Private Sub Btn01_Click(sender As Object, e As EventArgs) Handles Btn01.Click
        game(0, 1)
        If verify = True Then
            Btn01.Text = val
        End If
        winmechanism()
    End Sub
    Private Sub Btn02_Click(sender As Object, e As EventArgs) Handles Btn02.Click
        game(0, 2)
        If verify = True Then
            Btn02.Text = val
        End If
        winmechanism()
    End Sub
    Private Sub Btn10_Click(sender As Object, e As EventArgs) Handles Btn10.Click
        game(1, 0)
        If verify = True Then
            Btn10.Text = val
        End If
        winmechanism()
    End Sub
    Private Sub Btn11_Click(sender As Object, e As EventArgs) Handles Btn11.Click
        game(1, 1)
        If verify = True Then
            Btn11.Text = val
        End If
        winmechanism()
    End Sub
    Private Sub Btn12_Click(sender As Object, e As EventArgs) Handles Btn12.Click
        game(1, 2)
        If verify = True Then
            Btn12.Text = val
        End If
        winmechanism()
    End Sub
    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles Btn20.Click
        game(2, 0)
        If verify = True Then
            Btn20.Text = val
        End If
        winmechanism()
    End Sub
    Private Sub Btn21_Click(sender As Object, e As EventArgs) Handles Btn21.Click
        game(2, 1)
        If verify = True Then
            Btn21.Text = val
        End If
        winmechanism()
    End Sub
    Private Sub Btn22_Click(sender As Object, e As EventArgs) Handles Btn22.Click
        game(2, 2)
        If verify = True Then
            Btn22.Text = val
        End If
        winmechanism()
    End Sub

    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click

        rooster = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
        Btn00.Text = ""
        Btn01.Text = ""
        Btn02.Text = ""
        Btn10.Text = ""
        Btn11.Text = ""
        Btn12.Text = ""
        Btn20.Text = ""
        Btn21.Text = ""
        Btn22.Text = ""
        jogadas = 0
    End Sub

End Class