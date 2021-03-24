Public Class frmLogin

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()

    End Sub
    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user, password As String
        user = txtUser.Text
        password = txtpassword.Text

        If user = "admin" And password = "key123" Then
            Me.Hide()
            frmMenu.Show()

        Else
            MessageBox.Show("Please verify User or password ")
            Me.Show()
            txtUser.Focus()
            txtUser.Clear()
            txtpassword.Clear()
        End If

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub
End Class