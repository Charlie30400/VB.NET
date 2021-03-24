Public Class frmCompanyDataEntry
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyName.TextChanged

    End Sub

    Private Sub frmCompanyDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientDataSet.Information' table. You can move, or remove it, as needed.
        Me.InformationTableAdapter.Fill(Me.ClientDataSet.Information)

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        InformationBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        InformationBindingSource.MoveNext()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        InformationBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo SaveErr
        InformationBindingSource.EndEdit()
        InformationTableAdapter.Update(ClientDataSet.Information)
        MessageBox.Show("well done ")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        InformationBindingSource.RemoveCurrent()
    End Sub
End Class