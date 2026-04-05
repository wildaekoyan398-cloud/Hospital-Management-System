Public Class frmDischarge
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles SummaryLabel.Click

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PatientIDTextBox.Clear()
        NameTextBox.Clear()
        SummaryTextBox.Clear()
    End Sub

    Private Sub DischargeButton_Click(sender As Object, e As EventArgs) Handles DischargeButton.Click
        If PatientIDTextBox.Text = "" Then
            MessageBox.Show("Enter Patient ID")
        Else
            MessageBox.Show("Patient discharged successfully")
        End If
    End Sub
End Class