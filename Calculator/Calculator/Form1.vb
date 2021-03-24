Public Class frm_cal
    Private Sub num2_TextChanged(sender As Object, e As EventArgs) Handles txt_num2.TextChanged

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        txt_num1.Clear()
        txt_num2.Clear()
        txt_result.Clear()

    End Sub

    Private Sub btn_cal_Click(sender As Object, e As EventArgs) Handles btn_cal.Click
        Dim input1, input2 As Double
        input1 = CDbl(txt_num1.Text)
        input2 = CDbl(txt_num2.Text)
        Calculation(input1, input2)

    End Sub
    Sub Calculation(ByVal input1 As Double, ByVal input2 As Double)

        If rdo_add.Checked Then
            txt_result.ForeColor = Color.Red
            txt_result.Text = input1 + input2


        End If


        If rdo_sub.Checked Then
            txt_result.ForeColor = Color.Blue
            txt_result.Text = input1 - input2



        End If

        If rdo_multi.Checked Then
            txt_result.ForeColor = Color.Green
            txt_result.Text = input1 * input2

        End If

        If rdo_divi.Checked Then
            txt_result.ForeColor = Color.Purple
            txt_result.Text = input1 / input2
        End If

    End Sub

    Private Sub rdo_add_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_add.CheckedChanged

    End Sub
End Class
