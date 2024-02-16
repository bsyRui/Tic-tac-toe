Public Class Fwinner
    Private Sub Fwinner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If win = 1 Then
            LblWinner.Text = namep1
            PboxWinner.Image = F2pLobby.PboxP1.Image
        ElseIf win = 2 Then
            LblWinner.Text = namep2
            PboxWinner.Image = F2pLobby.PboxP2.Image
        Else
            Label1.Text = "empate"
        End If
    End Sub
End Class