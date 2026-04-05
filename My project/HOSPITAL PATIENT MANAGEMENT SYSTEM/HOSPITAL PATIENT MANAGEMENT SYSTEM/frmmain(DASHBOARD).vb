Imports MySql.Data.MySqlClient
Public Class frmmain
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ReportsButton.Click, DischargeButton.Click, DiagnosisButton.Click, WardButton.Click

    End Sub

    Private Sub PatientButton_Click(sender As Object, e As EventArgs) Handles PatientButton.Click
        frmPatientReg.Show()
    End Sub

    Private Sub OPDButton_Click(sender As Object, e As EventArgs) Handles OPDButton.Click
        frmOPD.Show()
    End Sub
    Private Sub WardButton_Click(sender As Object, e As EventArgs) Handles WardButton.Click
        frmWard.Show()
    End Sub
    Private Sub DischargeButton_Click(sender As Object, e As EventArgs) Handles DischargeButton.Click
        frmDischarge.Show()
    End Sub
    Private Sub DiagnosisButton_Click(sender As Object, e As EventArgs) Handles DiagnosisButton.Click
        frmDiagnosis.Show()
    End Sub
    Private Sub ReportsButton_Click(sender As Object, e As EventArgs) Handles ReportsButton.Click
        frmReports.Show()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click

    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
