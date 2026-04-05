Imports MySql.Data.MySqlClient
Public Class frmPatientReg
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles AgeLabel.Click, GenderLabel.Click, AddressLabel.Click, PhoneLabel.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PatientIDTextBox.Clear()
        NameTextBox.Clear()
        AgeTextBox.Clear()
        PhoneTextBox.Clear()
        AddressTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Try
            If NameTextBox.Text = "" Then
                MessageBox.Show("Enter patient name")
                Exit Sub
            End If

            OpenConnection()

            Dim query As String = "INSERT INTO patient (PatientID, Name, Age, Gender, Phone, Address) VALUES (@id,@name,@age,@gender,@phone,@address)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", PatientIDTextBox.Text)
            cmd.Parameters.AddWithValue("@name", NameTextBox.Text)
            cmd.Parameters.AddWithValue("@age", AgeTextBox.Text)
            cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
            cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
            cmd.Parameters.AddWithValue("@address", AddressTextBox.Text)

            cmd.ExecuteNonQuery()
            CloseConnection()

            MessageBox.Show("Patient Saved Successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        MessageBox.Show("Patient updated")
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        MessageBox.Show("Patient deleted")

    End Sub

    Private Sub frmPatientReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class