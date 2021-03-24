Public Class frmWeekendPayrollCalculater
    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtWork.Clear()
        txtPay.Clear()
        Result.Items.Clear()




    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim name As String
        Dim work, pay As Double
        name = txtName.Text
        work = CDbl(txtWork.Text)
        pay = CDbl(txtPay.Text)
        output(name, work, pay)

    End Sub

    Sub output(ByVal name As String, ByVal work As Double, ByVal pay As Double)
        Dim totalSalary, socialSecuritySecurity, taxPr, netPay, subNet As Double
        Dim normalSalary, normalSocialSecurity, normalTaxPr, normalNetPay, normalSubNet As Double

        'OverTime'
        totalSalary = (work * pay) * 1.5
        socialSecuritySecurity = totalSalary * 0.062
        taxPr = totalSalary * 0.07
        subNet = taxPr + socialSecuritySecurity
        netPay = totalSalary - subNet
        'No overtime'
        normalSalary = work * pay
        normalSocialSecurity = normalSalary * 0.062
        NormalPRTax = normalSalary * 0.07
        normalSubNet = NormalPRTax - SocialSecurity
        normalNetPay = normalSalary - subNet

        If (work >= 42) Then
            PayrollResult.Items.Add(name & "      The Total Salary is " & FormatCurrency(totalSalary))

            PayrollResult.Items.Add(name & "  Social Security" & FormatCurrency(SocialSecurity))

            PayrollResult.Items.Add(name & "  PR Tax is" & FormatCurrency(PRTax))

            PayrollResult.Items.Add(name & "  Net Pay is " & FormatCurrency(netPay))
        Else
            If (work <= 42) Then
                PayrollResult.Items.Add(name & "   you're salary is  " & FormatCurrency(normalSalary))

                PayrollResult.Items.Add(name & "  Social Security" & FormatCurrency(normalSocialSecurity))

                PayrollResult.Items.Add(name & "  PR Tax is" & FormatCurrency(NormalPRTax))

                PayrollResult.Items.Add(name & "  Net Pay is " & FormatCurrency(normalNetPay))

            End If


        End If


    End Sub

End Class
