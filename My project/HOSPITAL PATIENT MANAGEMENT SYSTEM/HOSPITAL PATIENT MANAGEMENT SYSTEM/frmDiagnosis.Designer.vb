<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiagnosis
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
        PatientIDLabel = New Label()
        DoctorLabel = New Label()
        TestsLabel = New Label()
        DiagnosisLabel = New Label()
        NameLabel = New Label()
        PatientIDTextBox = New TextBox()
        DoctorTextBox = New TextBox()
        TestsTextBox = New TextBox()
        DiagnosisTextBox = New TextBox()
        NameTextBox = New TextBox()
        SaveButton = New Button()
        ClearButton = New Button()
        SuspendLayout()
        ' 
        ' PatientIDLabel
        ' 
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New Point(35, 36)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New Size(61, 15)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "Patient ID:"
        ' 
        ' DoctorLabel
        ' 
        DoctorLabel.AutoSize = True
        DoctorLabel.Location = New Point(35, 201)
        DoctorLabel.Name = "DoctorLabel"
        DoctorLabel.Size = New Size(46, 15)
        DoctorLabel.TabIndex = 1
        DoctorLabel.Text = "Doctor:"
        ' 
        ' TestsLabel
        ' 
        TestsLabel.AutoSize = True
        TestsLabel.Location = New Point(35, 159)
        TestsLabel.Name = "TestsLabel"
        TestsLabel.Size = New Size(35, 15)
        TestsLabel.TabIndex = 2
        TestsLabel.Text = "Tests:"
        ' 
        ' DiagnosisLabel
        ' 
        DiagnosisLabel.AutoSize = True
        DiagnosisLabel.Location = New Point(35, 116)
        DiagnosisLabel.Name = "DiagnosisLabel"
        DiagnosisLabel.Size = New Size(61, 15)
        DiagnosisLabel.TabIndex = 3
        DiagnosisLabel.Text = "Diagnosis:"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(35, 74)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(82, 15)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Patient Name:"
        ' 
        ' PatientIDTextBox
        ' 
        PatientIDTextBox.Location = New Point(102, 28)
        PatientIDTextBox.Name = "PatientIDTextBox"
        PatientIDTextBox.Size = New Size(164, 23)
        PatientIDTextBox.TabIndex = 5
        ' 
        ' DoctorTextBox
        ' 
        DoctorTextBox.Location = New Point(87, 198)
        DoctorTextBox.Name = "DoctorTextBox"
        DoctorTextBox.Size = New Size(164, 23)
        DoctorTextBox.TabIndex = 6
        ' 
        ' TestsTextBox
        ' 
        TestsTextBox.Location = New Point(76, 151)
        TestsTextBox.Multiline = True
        TestsTextBox.Name = "TestsTextBox"
        TestsTextBox.Size = New Size(164, 23)
        TestsTextBox.TabIndex = 7
        ' 
        ' DiagnosisTextBox
        ' 
        DiagnosisTextBox.Location = New Point(114, 113)
        DiagnosisTextBox.Multiline = True
        DiagnosisTextBox.Name = "DiagnosisTextBox"
        DiagnosisTextBox.Size = New Size(164, 23)
        DiagnosisTextBox.TabIndex = 8
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(114, 71)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(164, 23)
        NameTextBox.TabIndex = 9
        ' 
        ' SaveButton
        ' 
        SaveButton.BackColor = Color.IndianRed
        SaveButton.Location = New Point(130, 269)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(136, 54)
        SaveButton.TabIndex = 10
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.RosyBrown
        ClearButton.Location = New Point(384, 269)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(136, 54)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' frmDiagnosis
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(800, 450)
        Controls.Add(ClearButton)
        Controls.Add(SaveButton)
        Controls.Add(NameTextBox)
        Controls.Add(DiagnosisTextBox)
        Controls.Add(TestsTextBox)
        Controls.Add(DoctorTextBox)
        Controls.Add(PatientIDTextBox)
        Controls.Add(NameLabel)
        Controls.Add(DiagnosisLabel)
        Controls.Add(TestsLabel)
        Controls.Add(DoctorLabel)
        Controls.Add(PatientIDLabel)
        Name = "frmDiagnosis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PatientIDLabel As Label
    Friend WithEvents DoctorLabel As Label
    Friend WithEvents TestsLabel As Label
    Friend WithEvents DiagnosisLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents DoctorTextBox As TextBox
    Friend WithEvents TestsTextBox As TextBox
    Friend WithEvents DiagnosisTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button
End Class
