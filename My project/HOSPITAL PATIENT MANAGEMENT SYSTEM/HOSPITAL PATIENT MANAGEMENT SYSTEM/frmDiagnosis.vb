Imports MySql.Data.MySqlClient

Public Class frmDiagnosis
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PatientIDTextBox.Clear()
        NameTextBox.Clear()
        DiagnosisTextBox.Clear()
        TestsTextBox.Clear()
        DoctorTextBox.Clear()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Try
            If PatientIDTextBox.Text = "" Or DiagnosisTextBox.Text = "" Then
                MessageBox.Show("Please fill all required fields")
                Exit Sub
            End If

            OpenConnection()

            Dim query As String = "INSERT INTO diagnosis (PatientID, Diagnosis, Treatment, Doctor) VALUES (@id, @diagnosis, @treatment, @doctor)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(PatientIDTextBox.Text))
            cmd.Parameters.AddWithValue("@diagnosis", DiagnosisTextBox.Text)
            cmd.Parameters.AddWithValue("@Tests", TestsTextBox.Text)
            cmd.Parameters.AddWithValue("@doctor", DoctorTextBox.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Diagnosis saved successfully")
            Else
                MessageBox.Show("Save failed")
            End If

            CloseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class