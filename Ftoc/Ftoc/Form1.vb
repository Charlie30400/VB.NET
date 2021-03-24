Public Class frm_Convert

    Private Sub btn_Convert_Click_1(sender As Object, e As EventArgs) Handles btn_Convert.Click
        inputSecction()

    End Sub

    Sub inputSecction()
        Dim Temp1, Temp2 As Double
        Temp1 = txt_Temp1.Text
        Temp2 = txt_Temp2.Text

        outputSecction(Temp1, Temp2)




    End Sub

    Sub outputSecction(ByVal Temp1 As Double, ByVal Temp2 As Double)
        Result.Items.Add(FormatNumber(calculation(Temp1)))
        Result.Items.Add(FormatNumber(calculation2(Temp2)))

    End Sub

    Function calculation(ByVal Temp1 As Double) As Double
        Dim Total As Double
        Total = (5 / 9) * (Temp1 - 32)

        Return Total

    End Function
    Function calculation2(ByVal Temp2 As Double) As Double
        Dim Total2 As Double
        Total2 = Temp2 - 273.15
        Return Total2
    End Function

End Class
