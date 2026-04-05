<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWard
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
        AddmissionDateLabel = New Label()
        BedLabel = New Label()
        WardLabel = New Label()
        NameLabel = New Label()
        AddmissionDatePicker = New DateTimePicker()
        PatientIDTextBox = New TextBox()
        NameTextBox = New TextBox()
        WardTextBox = New TextBox()
        BedTextBox = New TextBox()
        Admitbutton = New Button()
        ClearButton = New Button()
        SuspendLayout()
        ' 
        ' PatientIDLabel
        ' 
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New Point(32, 33)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New Size(61, 15)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "Patient ID:"
        ' 
        ' AddmissionDateLabel
        ' 
        AddmissionDateLabel.AutoSize = True
        AddmissionDateLabel.Location = New Point(32, 233)
        AddmissionDateLabel.Name = "AddmissionDateLabel"
        AddmissionDateLabel.Size = New Size(100, 15)
        AddmissionDateLabel.TabIndex = 1
        AddmissionDateLabel.Text = "Addmission Date:"
        ' 
        ' BedLabel
        ' 
        BedLabel.AutoSize = True
        BedLabel.Location = New Point(32, 176)
        BedLabel.Name = "BedLabel"
        BedLabel.Size = New Size(77, 15)
        BedLabel.TabIndex = 2
        BedLabel.Text = "Bed Number:"
        ' 
        ' WardLabel
        ' 
        WardLabel.AutoSize = True
        WardLabel.Location = New Point(32, 125)
        WardLabel.Name = "WardLabel"
        WardLabel.Size = New Size(85, 15)
        WardLabel.TabIndex = 3
        WardLabel.Text = "Ward Number:"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(32, 74)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(82, 15)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Patient Name:"
        ' 
        ' AddmissionDatePicker
        ' 
        AddmissionDatePicker.Location = New Point(129, 233)
        AddmissionDatePicker.Name = "AddmissionDatePicker"
        AddmissionDatePicker.Size = New Size(200, 23)
        AddmissionDatePicker.TabIndex = 5
        AddmissionDatePicker.Value = New Date(2026, 4, 1, 1, 6, 13, 0)
        ' 
        ' PatientIDTextBox
        ' 
        PatientIDTextBox.Location = New Point(99, 30)
        PatientIDTextBox.Name = "PatientIDTextBox"
        PatientIDTextBox.Size = New Size(149, 23)
        PatientIDTextBox.TabIndex = 6
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(111, 71)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(149, 23)
        NameTextBox.TabIndex = 7
        ' 
        ' WardTextBox
        ' 
        WardTextBox.Location = New Point(123, 122)
        WardTextBox.Name = "WardTextBox"
        WardTextBox.Size = New Size(149, 23)
        WardTextBox.TabIndex = 8
        ' 
        ' BedTextBox
        ' 
        BedTextBox.Location = New Point(111, 168)
        BedTextBox.Name = "BedTextBox"
        BedTextBox.Size = New Size(149, 23)
        BedTextBox.TabIndex = 9
        ' 
        ' Admitbutton
        ' 
        Admitbutton.BackColor = Color.Olive
        Admitbutton.Location = New Point(61, 297)
        Admitbutton.Name = "Admitbutton"
        Admitbutton.Size = New Size(154, 61)
        Admitbutton.TabIndex = 10
        Admitbutton.Text = "Admit"
        Admitbutton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Crimson
        ClearButton.Location = New Point(265, 297)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(164, 61)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' frmWard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(842, 450)
        Controls.Add(ClearButton)
        Controls.Add(Admitbutton)
        Controls.Add(BedTextBox)
        Controls.Add(WardTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(PatientIDTextBox)
        Controls.Add(AddmissionDatePicker)
        Controls.Add(NameLabel)
        Controls.Add(WardLabel)
        Controls.Add(BedLabel)
        Controls.Add(AddmissionDateLabel)
        Controls.Add(PatientIDLabel)
        Name = "frmWard"
        Text = "frmWard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PatientIDLabel As Label
    Friend WithEvents AddmissionDateLabel As Label
    Friend WithEvents BedLabel As Label
    Friend WithEvents WardLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddmissionDatePicker As DateTimePicker
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents WardTextBox As TextBox
    Friend WithEvents BedTextBox As TextBox
    Friend WithEvents Admitbutton As Button
    Friend WithEvents ClearButton As Button
End Class
