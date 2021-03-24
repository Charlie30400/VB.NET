Public Class frm_Restaurant


    Private Sub btn_Compute_Click(sender As Object, e As EventArgs) Handles btn_Compute.Click

        inputSecction()



    End Sub

    Sub inputSecction()
        Dim Pizza, Fries, Drinks As Double

        Pizza = txt_result1.Text
        Fries = txt_result2.Text
        Drinks = txt_result3.Text
        outputSecction(Pizza, Fries, Drinks)



    End Sub

    Sub outputSecction(ByVal Pizza As Double, ByVal Fries As Double, ByVal Drinks As Double)
        Quantity.Items.Add(("The pizza well be " & Pizza))
        Quantity.Items.Add("$" & (FormatNumber(Calculation1(Pizza))))
        Quantity.Items.Add("The Fries well be " & Fries)
        Quantity.Items.Add("$" & (FormatNumber(Calculation2(Fries))))
        Quantity.Items.Add("The Drinks well be " & Drinks)
        Quantity.Items.Add("$" & (FormatNumber(Calculation3(Drinks))))
        Quantity.Items.Add("The SubTotal is $" & (Calculation1(Pizza) + Calculation2(Fries) + Calculation3(Drinks)))
        Quantity.Items.Add("The Local Tax is $" & (FormatNumber(Calculation1(Pizza) + Calculation2(Fries) + Calculation3(Drinks)) * 0.001))
        Quantity.Items.Add("The PR Tax is $" & (FormatNumber(Calculation1(Pizza) + Calculation2(Fries) + Calculation3(Drinks)) * 0.00105))
        Quantity.Items.Add("The Total is  $" & FormatNumber(Calculation1(Pizza) + Calculation2(Fries) + Calculation3(Drinks) * 0.001 + FormatNumber(Calculation1(Pizza) + Calculation2(Fries) + Calculation3(Drinks) * 0.00105)))


    End Sub

    Function Calculation1(ByVal Pizza As Double) As Double
        Dim TotalPizza As Double
        TotalPizza = CDbl(1.25 * Pizza)
        Return TotalPizza

    End Function

    Function Calculation2(ByVal Fries As Double) As Double
        Dim TotalFries

        TotalFries = CDbl(1.0 * Fries)
        Return TotalFries

    End Function

    Function Calculation3(ByVal Drinks As Double) As Decimal
        Dim TotalDrinks As Double

        TotalDrinks = TotalDrinks = CDbl(Drinks * 0.75)
        Return TotalDrinks


    End Function

    Private Sub btn_Quit_Click(sender As Object, e As EventArgs) Handles btn_Quit.Click
        End
    End Sub
End Class
