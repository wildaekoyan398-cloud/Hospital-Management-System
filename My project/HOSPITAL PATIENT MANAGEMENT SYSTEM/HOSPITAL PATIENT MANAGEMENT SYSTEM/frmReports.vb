Imports MySql.Data.MySqlClient

Public Class frmReports

    ' --- MySQL Connection ---
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    ' --- Form Load or Button Click can call this ---
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            ' Initialize connection
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=HospitalDB")
            conn.Open()

            ' --- Correct SQL using exact columns ---
            Dim query As String = "
                SELECT 
                    patient.PatientID,
                    opd.VisitDate, opd.Symptoms, opd.Doctor,
                    ward.WardNo, ward.BedNo, ward.AdmDate,
                    discharge.AdmNo, discharge.DischargeDate, discharge.Summary,
                    diagnosis.Diagnosis, diagnosis.Test, diagnosis.Doctor AS DiagnosisDoctor
                FROM patient
                LEFT JOIN opd ON patient.PatientID = opd.PatientID
                LEFT JOIN ward ON patient.PatientID = ward.PatientID
                LEFT JOIN discharge ON patient.PatientID = discharge.PatientID
                LEFT JOIN diagnosis ON patient.PatientID = diagnosis.PatientID
            "

            ' Fill DataTable
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Bind to DataGridView
            ReportsDataGridView.DataSource = dt

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' --- Print functionality ---
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim y As Integer = 20
        Dim x As Integer = 20

        ' Print headers
        For Each col As DataGridViewColumn In ReportsDataGridView.Columns
            e.Graphics.DrawString(col.HeaderText, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, x, y)
            x += 120
        Next

        y += 30
        x = 20

        ' Print rows
        For Each row As DataGridViewRow In ReportsDataGridView.Rows
            If Not row.IsNewRow Then
                For Each cell As DataGridViewCell In row.Cells
                    e.Graphics.DrawString(cell.Value?.ToString(), New Font("Arial", 10), Brushes.Black, x, y)
                    x += 120
                Next
                y += 30
                x = 20
            End If
        Next
    End Sub

End Class