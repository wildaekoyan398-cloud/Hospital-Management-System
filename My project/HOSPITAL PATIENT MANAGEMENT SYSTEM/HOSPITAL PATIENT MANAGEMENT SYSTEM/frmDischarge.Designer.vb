<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDischarge
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
        SummaryLabel = New Label()
        DischargeLabel = New Label()
        AddmissionDateLabel = New Label()
        NameLabel = New Label()
        PatientIDTextBox = New TextBox()
        NameTextBox = New TextBox()
        AddmissionDatePicker = New DateTimePicker()
        SummaryTextBox = New TextBox()
        DischargeDatePicker = New DateTimePicker()
        DischargeButton = New Button()
        ClearButton = New Button()
        SuspendLayout()
        ' 
        ' PatientIDLabel
        ' 
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New Point(32, 40)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New Size(61, 15)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "Patient ID:"
        ' 
        ' SummaryLabel
        ' 
        SummaryLabel.AutoSize = True
        SummaryLabel.Location = New Point(32, 233)
        SummaryLabel.Name = "SummaryLabel"
        SummaryLabel.Size = New Size(61, 15)
        SummaryLabel.TabIndex = 1
        SummaryLabel.Text = "Summary:"
        ' 
        ' DischargeLabel
        ' 
        DischargeLabel.AutoSize = True
        DischargeLabel.Location = New Point(32, 182)
        DischargeLabel.Name = "DischargeLabel"
        DischargeLabel.Size = New Size(89, 15)
        DischargeLabel.TabIndex = 2
        DischargeLabel.Text = "Discharge Date:"
        ' 
        ' AddmissionDateLabel
        ' 
        AddmissionDateLabel.AutoSize = True
        AddmissionDateLabel.Location = New Point(32, 127)
        AddmissionDateLabel.Name = "AddmissionDateLabel"
        AddmissionDateLabel.Size = New Size(100, 15)
        AddmissionDateLabel.TabIndex = 3
        AddmissionDateLabel.Text = "Addmission Date:"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(32, 81)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(82, 15)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Patient Name:"
        ' 
        ' PatientIDTextBox
        ' 
        PatientIDTextBox.Location = New Point(99, 37)
        PatientIDTextBox.Name = "PatientIDTextBox"
        PatientIDTextBox.Size = New Size(158, 23)
        PatientIDTextBox.TabIndex = 5
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(120, 73)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(158, 23)
        NameTextBox.TabIndex = 6
        ' 
        ' AddmissionDatePicker
        ' 
        AddmissionDatePicker.Location = New Point(138, 121)
        AddmissionDatePicker.Name = "AddmissionDatePicker"
        AddmissionDatePicker.Size = New Size(200, 23)
        AddmissionDatePicker.TabIndex = 7
        ' 
        ' SummaryTextBox
        ' 
        SummaryTextBox.Location = New Point(99, 233)
        SummaryTextBox.Multiline = True
        SummaryTextBox.Name = "SummaryTextBox"
        SummaryTextBox.Size = New Size(158, 23)
        SummaryTextBox.TabIndex = 8
        ' 
        ' DischargeDatePicker
        ' 
        DischargeDatePicker.Location = New Point(127, 176)
        DischargeDatePicker.Name = "DischargeDatePicker"
        DischargeDatePicker.Size = New Size(200, 23)
        DischargeDatePicker.TabIndex = 9
        ' 
        ' DischargeButton
        ' 
        DischargeButton.BackColor = Color.Pink
        DischargeButton.Location = New Point(127, 320)
        DischargeButton.Name = "DischargeButton"
        DischargeButton.Size = New Size(138, 59)
        DischargeButton.TabIndex = 10
        DischargeButton.Text = "Discharge"
        DischargeButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Crimson
        ClearButton.Location = New Point(367, 320)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(138, 59)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' frmDischarge
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(ClearButton)
        Controls.Add(DischargeButton)
        Controls.Add(DischargeDatePicker)
        Controls.Add(SummaryTextBox)
        Controls.Add(AddmissionDatePicker)
        Controls.Add(NameTextBox)
        Controls.Add(PatientIDTextBox)
        Controls.Add(NameLabel)
        Controls.Add(AddmissionDateLabel)
        Controls.Add(DischargeLabel)
        Controls.Add(SummaryLabel)
        Controls.Add(PatientIDLabel)
        Name = "frmDischarge"
        Text = "frmDischarge"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PatientIDLabel As Label
    Friend WithEvents SummaryLabel As Label
    Friend WithEvents DischargeLabel As Label
    Friend WithEvents AddmissionDateLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddmissionDatePicker As DateTimePicker
    Friend WithEvents SummaryTextBox As TextBox
    Friend WithEvents DischargeDatePicker As DateTimePicker
    Friend WithEvents DischargeButton As Button
    Friend WithEvents ClearButton As Button
End Class
