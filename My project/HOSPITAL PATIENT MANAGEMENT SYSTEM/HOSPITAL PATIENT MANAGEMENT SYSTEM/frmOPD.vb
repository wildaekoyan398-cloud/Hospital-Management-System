Public Class frmOPD
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles DoctorLabel.Click

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PatientIDTextBox.Clear()
        NameTextBox.Clear()
        SymptomsTextBox.Clear()
        DoctorTextBox.Clear()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If PatientIDTextBox.Text = "" Then
            MessageBox.Show("Enter Patient ID")
        Else
            MessageBox.Show("Visit saved successfully")
        End If
    End Sub

    Private Sub frmOPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class