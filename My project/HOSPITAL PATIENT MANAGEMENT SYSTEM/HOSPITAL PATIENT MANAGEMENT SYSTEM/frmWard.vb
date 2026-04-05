Imports MySql.Data.MySqlClient
Public Class frmWard
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles BedLabel.Click

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PatientIDTextBox.Clear()
        NameTextBox.Clear()
        WardTextBox.Clear()
        BedTextBox.Clear()
    End Sub

    Private Sub Admitbutton_Click(sender As Object, e As EventArgs) Handles Admitbutton.Click
        If PatientIDTextBox.Text = "" Then
            MessageBox.Show("Enter Patient ID")
        Else
            MessageBox.Show("Patient admitted successfully")
        End If
    End Sub
End Class