Public Class FAjuda
    Private Sub FAjuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += vbCrLf + "Podes jogar sozinho ou com um amigo. Cada jogador joga alternadamente" +
        vbCrLf + "O teu objetivo é conseguires três círculos o ou três X em linha, na horizontal, na vertical ou na diagonal." + vbCrLf +
        "Ao mesmo tempo, quando possível, tenta impedir o adversário de ganhar na próxima jogada."
    End Sub
End Class