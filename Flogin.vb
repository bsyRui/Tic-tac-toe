Imports System.Data.SqlClient
Public Class Flogin
    Dim Connection As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Private Sub Flogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection = New SqlConnection("server=LAPTOP-NN9AH6U5\SQLEXPRESS;database=tictactoeLogin; Integrated Security=SSPI;")
        Connection.Open()
        'MessageBox.Show("connected")

    End Sub

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

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim Newusername = InputBox("create your username:")
        Dim NewPassword = InputBox("Input your  Password:")

        Dim createAccount As String = "Insert into logininformation (username,userPassword)" +
        "Values ('" & Newusername & "','" & NewPassword & "')"
        cmd = New SqlCommand(createAccount, Connection)
        reader = cmd.ExecuteReader()


    End Sub
End Class
