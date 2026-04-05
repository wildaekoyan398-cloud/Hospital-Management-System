<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PatientButton = New Button()
        OPDButton = New Button()
        ReportsButton = New Button()
        DischargeButton = New Button()
        DiagnosisButton = New Button()
        WardButton = New Button()
        LogOutButton = New Button()
        SuspendLayout()
        ' 
        ' PatientButton
        ' 
        PatientButton.BackColor = Color.Salmon
        PatientButton.Location = New Point(12, 12)
        PatientButton.Name = "PatientButton"
        PatientButton.Size = New Size(146, 48)
        PatientButton.TabIndex = 0
        PatientButton.Text = "PatientRegistration"
        PatientButton.UseVisualStyleBackColor = False
        ' 
        ' OPDButton
        ' 
        OPDButton.BackColor = Color.LightSeaGreen
        OPDButton.Location = New Point(12, 66)
        OPDButton.Name = "OPDButton"
        OPDButton.Size = New Size(146, 51)
        OPDButton.TabIndex = 0
        OPDButton.Text = "OPD"
        OPDButton.UseVisualStyleBackColor = False
        ' 
        ' ReportsButton
        ' 
        ReportsButton.BackColor = Color.DarkOrange
        ReportsButton.Location = New Point(12, 371)
        ReportsButton.Name = "ReportsButton"
        ReportsButton.Size = New Size(146, 67)
        ReportsButton.TabIndex = 0
        ReportsButton.Text = "Reports"
        ReportsButton.UseVisualStyleBackColor = False
        ' 
        ' DischargeButton
        ' 
        DischargeButton.BackColor = Color.BlanchedAlmond
        DischargeButton.Location = New Point(12, 192)
        DischargeButton.Name = "DischargeButton"
        DischargeButton.Size = New Size(146, 67)
        DischargeButton.TabIndex = 0
        DischargeButton.Text = "Discharge"
        DischargeButton.UseVisualStyleBackColor = False
        ' 
        ' DiagnosisButton
        ' 
        DiagnosisButton.BackColor = Color.BurlyWood
        DiagnosisButton.Location = New Point(12, 282)
        DiagnosisButton.Name = "DiagnosisButton"
        DiagnosisButton.Size = New Size(146, 66)
        DiagnosisButton.TabIndex = 0
        DiagnosisButton.Text = "Diagnosis"
        DiagnosisButton.UseVisualStyleBackColor = False
        ' 
        ' WardButton
        ' 
        WardButton.BackColor = Color.Firebrick
        WardButton.Location = New Point(12, 131)
        WardButton.Name = "WardButton"
        WardButton.Size = New Size(146, 55)
        WardButton.TabIndex = 0
        WardButton.Text = "Ward"
        WardButton.UseVisualStyleBackColor = False
        ' 
        ' LogOutButton
        ' 
        LogOutButton.BackColor = Color.Plum
        LogOutButton.Location = New Point(335, 242)
        LogOutButton.Name = "LogOutButton"
        LogOutButton.Size = New Size(170, 63)
        LogOutButton.TabIndex = 1
        LogOutButton.Text = "LogOut"
        LogOutButton.UseVisualStyleBackColor = False
        ' 
        ' frmmain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(800, 450)
        Controls.Add(LogOutButton)
        Controls.Add(WardButton)
        Controls.Add(DischargeButton)
        Controls.Add(DiagnosisButton)
        Controls.Add(ReportsButton)
        Controls.Add(OPDButton)
        Controls.Add(PatientButton)
        Name = "frmmain"
        Text = "frmmain"
        ResumeLayout(False)
    End Sub

    Friend WithEvents PatientButton As Button
    Friend WithEvents OPDButton As Button
    Friend WithEvents ReportsButton As Button
    Friend WithEvents DischargeButton As Button
    Friend WithEvents DiagnosisButton As Button
    Friend WithEvents WardButton As Button
    Friend WithEvents LogOutButton As Button
End Class
