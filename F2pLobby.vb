Public Class F2pLobby
    Dim p1, p2 As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblP1.Click

    End Sub

    Private Sub F2pLobby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namep1 = InputBox("Digitte o nome do jogqador 1:")
        namep2 = InputBox("Digitte o nome do jogqador 2:")
        LblP1.Text = namep1
        LblP2.Text = namep2
        p1 = 0
        p2 = 0
    End Sub
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If p1 = 0 Then
            p1 = 1
        End If
        If p1 = 1 And p2 = 0 Then
            p2 = 1
        End If

    End Sub
    Private Sub BtnVegeta_Click(sender As Object, e As EventArgs) Handles BtnVegeta.Click
        If p1 = 0 Then
            PboxP1.Image = My.Resources.vegeta
        Else
            PboxP2.Image = My.Resources.vegeta
        End If
    End Sub

    Private Sub BtnshunLi_Click(sender As Object, e As EventArgs) Handles BtnshunLi.Click
        If p1 = 0 Then
            PboxP1.Image = My.Resources.shunliP1
        Else
            PboxP2.Image = My.Resources.shunliP1
        End If
    End Sub

    Private Sub BtnVenom_Click(sender As Object, e As EventArgs) Handles BtnVenom.Click
        If p1 = 0 Then
            PboxP1.Image = My.Resources.venomP1
        Else
            PboxP2.Image = My.Resources.venomP1
        End If
    End Sub

    Private Sub BtnTwelve_Click(sender As Object, e As EventArgs) Handles BtnTwelve.Click
        If p1 = 0 Then
            PboxP1.Image = My.Resources.twelveP1
        Else
            PboxP2.Image = My.Resources.twelveP1
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        F2players.ShowDialog()
    End Sub

    Private Sub BtnRyu_Click(sender As Object, e As EventArgs) Handles BtnRyu.Click
        If p1 = 0 Then
            PboxP1.Image = My.Resources.ryuSkinp2
        Else
            PboxP2.Image = My.Resources.ryuSkinp2
        End If
    End Sub
End Class