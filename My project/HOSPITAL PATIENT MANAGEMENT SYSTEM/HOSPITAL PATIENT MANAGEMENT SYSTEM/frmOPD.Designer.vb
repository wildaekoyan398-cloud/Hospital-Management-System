<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOPD
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
        PatientLabel = New Label()
        DoctorLabel = New Label()
        SymptomsLabel = New Label()
        VisitDateLabel = New Label()
        NameLabel = New Label()
        PatientIDTextBox = New TextBox()
        NameTextBox = New TextBox()
        VisitDatePicker = New DateTimePicker()
        SymptomsTextBox = New TextBox()
        DoctorTextBox = New TextBox()
        SaveButton = New Button()
        ClearButton = New Button()
        SuspendLayout()
        ' 
        ' PatientLabel
        ' 
        PatientLabel.AutoSize = True
        PatientLabel.Location = New Point(37, 40)
        PatientLabel.Name = "PatientLabel"
        PatientLabel.Size = New Size(61, 15)
        PatientLabel.TabIndex = 0
        PatientLabel.Text = "Patient ID:"
        ' 
        ' DoctorLabel
        ' 
        DoctorLabel.AutoSize = True
        DoctorLabel.Location = New Point(37, 237)
        DoctorLabel.Name = "DoctorLabel"
        DoctorLabel.Size = New Size(46, 15)
        DoctorLabel.TabIndex = 0
        DoctorLabel.Text = "Doctor:"
        ' 
        ' SymptomsLabel
        ' 
        SymptomsLabel.AutoSize = True
        SymptomsLabel.Location = New Point(37, 186)
        SymptomsLabel.Name = "SymptomsLabel"
        SymptomsLabel.Size = New Size(67, 15)
        SymptomsLabel.TabIndex = 1
        SymptomsLabel.Text = "Symptoms:"
        ' 
        ' VisitDateLabel
        ' 
        VisitDateLabel.AutoSize = True
        VisitDateLabel.Location = New Point(37, 134)
        VisitDateLabel.Name = "VisitDateLabel"
        VisitDateLabel.Size = New Size(59, 15)
        VisitDateLabel.TabIndex = 2
        VisitDateLabel.Text = "Visit Date:"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(37, 82)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(82, 15)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Patient Name:"
        ' 
        ' PatientIDTextBox
        ' 
        PatientIDTextBox.Location = New Point(128, 32)
        PatientIDTextBox.Name = "PatientIDTextBox"
        PatientIDTextBox.Size = New Size(158, 23)
        PatientIDTextBox.TabIndex = 4
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(125, 82)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(158, 23)
        NameTextBox.TabIndex = 5
        ' 
        ' VisitDatePicker
        ' 
        VisitDatePicker.Location = New Point(115, 134)
        VisitDatePicker.Name = "VisitDatePicker"
        VisitDatePicker.Size = New Size(200, 23)
        VisitDatePicker.TabIndex = 6
        ' 
        ' SymptomsTextBox
        ' 
        SymptomsTextBox.Location = New Point(115, 186)
        SymptomsTextBox.Multiline = True
        SymptomsTextBox.Name = "SymptomsTextBox"
        SymptomsTextBox.Size = New Size(190, 23)
        SymptomsTextBox.TabIndex = 7
        ' 
        ' DoctorTextBox
        ' 
        DoctorTextBox.Location = New Point(115, 237)
        DoctorTextBox.Name = "DoctorTextBox"
        DoctorTextBox.Size = New Size(190, 23)
        DoctorTextBox.TabIndex = 8
        ' 
        ' SaveButton
        ' 
        SaveButton.BackColor = Color.DarkKhaki
        SaveButton.Location = New Point(115, 303)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(138, 61)
        SaveButton.TabIndex = 9
        SaveButton.Text = "Save Visit"
        SaveButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.SaddleBrown
        ClearButton.Location = New Point(362, 303)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(138, 61)
        ClearButton.TabIndex = 10
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' frmOPD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(800, 450)
        Controls.Add(ClearButton)
        Controls.Add(SaveButton)
        Controls.Add(DoctorTextBox)
        Controls.Add(SymptomsTextBox)
        Controls.Add(VisitDatePicker)
        Controls.Add(NameTextBox)
        Controls.Add(PatientIDTextBox)
        Controls.Add(NameLabel)
        Controls.Add(VisitDateLabel)
        Controls.Add(SymptomsLabel)
        Controls.Add(DoctorLabel)
        Controls.Add(PatientLabel)
        Name = "frmOPD"
        Text = "frmOPD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PatientLabel As Label
    Friend WithEvents DoctorLabel As Label
    Friend WithEvents SymptomsLabel As Label
    Friend WithEvents VisitDateLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents VisitDatePicker As DateTimePicker
    Friend WithEvents SymptomsTextBox As TextBox
    Friend WithEvents DoctorTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button
End Class
