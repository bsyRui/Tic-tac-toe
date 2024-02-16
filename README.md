# Tic tac toe
O programa contém um login Default: admin com sua senha publica admin,
para caso a funcionalidade sql estiver indisponível.
Codigo apenas demonstrativo para uso profissional.

Imagens todas alteradas e não lincenciadas para uso individual, ou profissional.
com formataçoes 8:4 1920:1080 950: 750 entre outras

# FLOGIN ( form Login)

## Form_Load

![[Pasted image 20240213164352.png]]

Temos essas 3 variáveis que nos dão acesso a um banco de dados do nosso jogo.
**cmd** = é o comando do banco de dados
**connection** =  é a conexçao do banco de dados
**reader** = é a combinaçao entre a conexao (**connection**) e o comando (**cmd**)

a primeira linha do connection é pra conectar, nao alteres nada
a segunda é para iniciar a conexão ```connection.open()```

***AS VARIAVEIS SAO TODAS NECESSÁRIAS NAO MEXER NADA DISSO***
## btnLogin_click()

```vb
 Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim consult As String = "select * from logininformation where username= '" & TboxUsername.Text & "' and userPassword='" & TboxPassword.Text & "'"
        cmd = New SqlCommand(consult, Connection)

        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            MessageBox.Show("Sql connected!")
            FMainmenu.ShowDialog()
            reader.Close()
        Else
            MessageBox.Show("sql didnt found any user")
            reader.Close()
        End If
    End Sub
```
aqui é para identificar o login

2. Este codigo vai pegar os valores digitados na texbox e vai logar com eles
```vb
Dim consult As String = "select * from logininformation where username= '" & TboxUsername.Text & "' and userPassword='" & TboxPassword.Text & "'"
        cmd = New SqlCommand(consult, Connection)
     
 ```



3. Visualizaçao e exemplo de contas disponíveis
![[Pasted image 20240213165021.png]]



4. Botão de registro
```vb
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim Newusername = InputBox("create your username:")
        Dim NewPassword = InputBox("Input your  Password:")

        Dim createAccount As String = "Insert into logininformation (username,userPassword)" +
        "Values ('" & Newusername & "','" & NewPassword & "')"
        cmd = New SqlCommand(createAccount, Connection)
        reader = cmd.ExecuteReader()

    End Sub
```
 está com uns erros identificados no vb mas está funcional só usa uma vez e vais pro login

# F2players_load()

1. o codigo é mais que o mesmo para os botões
```vb
    Private Sub Btn00_Click(sender As Object, e As EventArgs) Handles Btn00.Click
        game(0, 0)
        If verify = True Then
            Btn00.Text = val
        End If

        winmechanism()
    End Sub
```
os botões vão ordenadamente de acordo com suas posiçoes no array

| btn00 | btn01 | btn02 |<br>
| btn10 | btn11 | btn12 |<br>
| btn20 | btn21 | btn22 |<br>

2. o if é para verificar sempre que vão tentar prencher um local ja preenchido
```vb
If verify = True Then
            Btn00.Text = val
        End If
```

3. leva a uma variável que comprova se j1 ou j2 ganharam
`winmechanism()`
# mainconfigs()

## Variables
1.
```vb
    Public jogadas = 0
    Public val As String
    Public verify As Boolean
    Public rooster As Integer(,) = New Integer(2, 2) {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
```
## Public Sub game()
1. função game() serve para dar os turnos e ir alternando de jogador de acordo com var `jogadas`
```vb
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
```

## Public sub winmechanism()
3. serve para mecanizar e ver as possiveis vitorias de cada jogada por isso localizada em cada btn
```vb
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
```
