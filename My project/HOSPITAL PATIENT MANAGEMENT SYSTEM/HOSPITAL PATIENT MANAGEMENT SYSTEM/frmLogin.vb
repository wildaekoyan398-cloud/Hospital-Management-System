Imports MySql.Data.MySqlClient
Public Class frmLogin

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please enter Username and Password")

        ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "1234" Then
            MessageBox.Show("Login Successful")

            frmmain.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password")
        End If

    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub


    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginButton.PerformClick()
        End If
    End Sub

End Class