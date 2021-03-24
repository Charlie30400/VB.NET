Public Class frmMenu
    Private Sub MenuSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub btnCustomerSection_Click(sender As Object, e As EventArgs) Handles btnCustomerSection.Click
        frmCompanyDataEntry.Show()


    End Sub

    Private Sub btnEmployeeSection_Click(sender As Object, e As EventArgs) Handles btnEmployeeSection.Click
        frmEmployee.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        Me.Hide()
        frmLogin.Show()


    End Sub
End Class