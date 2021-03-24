Public Class frmEmployee
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblType.Click

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.ClientDataSet.Employee)

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        EmployeeBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        EmployeeBindingSource.MoveNext()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        EmployeeBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo SaveErr
        EmployeeBindingSource.EndEdit()
        EmployeeTableAdapter.Update(ClientDataSet.Employee)
        MessageBox.Show("File succesfully saved ")

SaveErr:
        Exit Sub


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        EmployeeBindingSource.RemoveCurrent()
    End Sub
End Class