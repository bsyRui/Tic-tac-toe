Public Class FMainmenu
    Private Sub FMainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Btn2Player_Click(sender As Object, e As EventArgs) Handles Btn2Player.Click
        F2pLobby.ShowDialog()
    End Sub

    Private Sub Btn1player_Click(sender As Object, e As EventArgs) Handles Btn1player.Click
        Dim r = MsgBox("Indisponivel de momento", MsgBoxStyle.Information, "Sair")

    End Sub

    Private Sub BtnAjuda_Click(sender As Object, e As EventArgs) Handles BtnAjuda.Click
        FAjuda.ShowDialog()
    End Sub
End Class