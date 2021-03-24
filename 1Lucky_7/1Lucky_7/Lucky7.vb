Public Class Lucky7
    Dim x = 0
    Private Sub bln_Win_Click(sender As Object, e As EventArgs) Handles bln_Win.Click

        pic_Picture.Visible = False

        lbl_number1.Text = CInt(Rnd() * 10)
        lbl_number2.Text = CInt(Rnd() * 10)
        lbl_number3.Text = CInt(Rnd() * 10)

        x = x + 1

        If (lbl_number1.Text = 7 And lbl_number2.Text = 7 And lbl_number3.Text = 7) Then
            pic_Picture.Visible = True
            bln_Win.Enabled = False
        End If

        lbl_LuckySeven.Text = x




    End Sub

    Private Sub lbl_number1_Click(sender As Object, e As EventArgs) Handles lbl_number1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

    End Sub

    Private Sub pic_Picture_Click(sender As Object, e As EventArgs) Handles pic_Picture.Click

    End Sub

    Private Sub lbl_Quit_Click(sender As Object, e As EventArgs) Handles lbl_Quit.Click
        End
    End Sub
End Class
