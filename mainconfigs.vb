Module mainconfigs
    Public jogadas = 0
    Public val As String
    Public namep1, namep2 As String
    Public verify As Boolean
    Public rooster As Integer(,) = New Integer(2, 2) {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
    Public win As Integer
    Public Sub game(i As Integer, j As Integer)
        If rooster(i, j) = 0 Then
            verify = True
            rooster(i, j) = 1
            If jogadas Mod 2 = 0 Then
                val = "x"
                F2players.LblPTurns.Text = namep2
            Else
                val = "o"
                F2players.LblPTurns.Text = namep1
            End If
            jogadas += 1
            'Return val
        Else
            MessageBox.Show("no")
            verify = False
        End If
    End Sub

    Public Sub winmechanism()
        If jogadas = 9 Then
            MessageBox.Show("empate")
        End If
        'horizontal x
        If F2players.Btn00.Text.Equals("x") And F2players.Btn01.Text.Equals("x") And F2players.Btn02.Text.Equals("x") = True Or
           F2players.Btn10.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn12.Text.Equals("x") = True Or
           F2players.Btn20.Text.Equals("x") And F2players.Btn21.Text.Equals("x") And F2players.Btn22.Text.Equals("x") = True Then
            MessageBox.Show(namep1 + " win")
            win = 1

            'vertical x
        ElseIf F2players.Btn00.Text.Equals("x") And F2players.Btn10.Text.Equals("x") And F2players.Btn20.Text.Equals("x") = True Or
           F2players.Btn01.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn21.Text.Equals("x") = True Or
           F2players.Btn02.Text.Equals("x") And F2players.Btn12.Text.Equals("x") And F2players.Btn22.Text.Equals("x") = True Then
            MessageBox.Show(namep1 + " win")
            win = 1
            'diagonal x
        ElseIf F2players.Btn00.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn22.Text.Equals("x") = True Or
           F2players.Btn02.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn20.Text.Equals("x") = True Then
            MessageBox.Show(namep1 + " win")
            win = 1

            '  win mechanism for O

        ElseIf F2players.Btn00.Text.Equals("o") And F2players.Btn01.Text.Equals("o") And F2players.Btn02.Text.Equals("o") = True Or
           F2players.Btn10.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn12.Text.Equals("o") = True Or
           F2players.Btn20.Text.Equals("o") And F2players.Btn21.Text.Equals("o") And F2players.Btn22.Text.Equals("o") = True Then
            MessageBox.Show(namep2 + " win")
            win = 2
            'vertical o
        ElseIf F2players.Btn00.Text.Equals("o") And F2players.Btn10.Text.Equals("o") And F2players.Btn20.Text.Equals("o") = True Or
           F2players.Btn01.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn21.Text.Equals("o") = True Or
           F2players.Btn02.Text.Equals("o") And F2players.Btn12.Text.Equals("o") And F2players.Btn22.Text.Equals("o") = True Then
            MessageBox.Show(namep2 + " win")
            win = 2
            'diagonal o
        ElseIf F2players.Btn00.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn22.Text.Equals("o") = True Or
           F2players.Btn02.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn20.Text.Equals("o") = True Then
            MessageBox.Show(namep2 + " win")
            win = 2

        End If
        If win = 1 Or win = 2 Then
            Fwinner.ShowDialog()
        End If

    End Sub

    Public Sub paths()

    End Sub
End Module
