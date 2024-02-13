Module mainconfigs
    Public jogadas = 0
    Public val As String
    Public verify As Boolean
    Public rooster As Integer(,) = New Integer(2, 2) {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
    Public Sub game(i As Integer, j As Integer)
        If rooster(i, j) = 0 Then
            verify = True
            rooster(i, j) = 1
            If jogadas Mod 2 = 0 Then
                val = "x"
            Else
                val = "o"
            End If
            jogadas += 1
            'Return val
        Else
            MessageBox.Show("no")
            verify = False
        End If
    End Sub

    Public Sub winmechanism()
        'horizontal x
        If F2players.Btn00.Text.Equals("x") And F2players.Btn01.Text.Equals("x") And F2players.Btn02.Text.Equals("x") = True Or
           F2players.Btn10.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn12.Text.Equals("x") = True Or
           F2players.Btn20.Text.Equals("x") And F2players.Btn21.Text.Equals("x") And F2players.Btn22.Text.Equals("x") = True Then
            MessageBox.Show("p1 win")
            'vertical x
        ElseIf F2players.Btn00.Text.Equals("x") And F2players.Btn10.Text.Equals("x") And F2players.Btn20.Text.Equals("x") = True Or
           F2players.Btn01.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn21.Text.Equals("x") = True Or
           F2players.Btn02.Text.Equals("x") And F2players.Btn12.Text.Equals("x") And F2players.Btn22.Text.Equals("x") = True Then
            MessageBox.Show("p1 win")
            'diagonal x
        ElseIf F2players.Btn00.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn22.Text.Equals("x") = True Or
           F2players.Btn02.Text.Equals("x") And F2players.Btn11.Text.Equals("x") And F2players.Btn20.Text.Equals("x") = True Then
            MessageBox.Show("p1 win")


            '  win mechanism for O

        ElseIf F2players.Btn00.Text.Equals("o") And F2players.Btn01.Text.Equals("o") And F2players.Btn02.Text.Equals("o") = True Or
           F2players.Btn10.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn12.Text.Equals("o") = True Or
           F2players.Btn20.Text.Equals("o") And F2players.Btn21.Text.Equals("o") And F2players.Btn22.Text.Equals("o") = True Then
            MessageBox.Show("p2 win")
            'vertical o
        ElseIf F2players.Btn00.Text.Equals("o") And F2players.Btn10.Text.Equals("o") And F2players.Btn20.Text.Equals("o") = True Or
           F2players.Btn01.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn21.Text.Equals("o") = True Or
           F2players.Btn02.Text.Equals("o") And F2players.Btn12.Text.Equals("o") And F2players.Btn22.Text.Equals("o") = True Then
            MessageBox.Show("p2 win")
            'diagonal o
        ElseIf F2players.Btn00.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn22.Text.Equals("o") = True Or
           F2players.Btn02.Text.Equals("o") And F2players.Btn11.Text.Equals("o") And F2players.Btn20.Text.Equals("o") = True Then
            MessageBox.Show("p2 win")
        ElseIf F2players.jogadas = 9 Then
            MessageBox.Show("empate")
        End If
    End Sub

    Public Sub paths()

    End Sub
End Module
