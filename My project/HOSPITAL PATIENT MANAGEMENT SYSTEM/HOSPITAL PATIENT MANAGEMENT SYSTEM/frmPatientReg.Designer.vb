<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientReg
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
        AgeLabel = New Label()
        NameLabel = New Label()
        GenderLabel = New Label()
        AddressLabel = New Label()
        PhoneLabel = New Label()
        PatientIDTextBox = New TextBox()
        PhoneTextBox = New TextBox()
        AgeTextBox = New TextBox()
        NameTextBox = New TextBox()
        AddressTextBox = New TextBox()
        GenderComboBox = New ComboBox()
        SaveButton = New Button()
        UpdateButton = New Button()
        DeleteButton = New Button()
        ClearButton = New Button()
        SuspendLayout()
        ' 
        ' PatientIDLabel
        ' 
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New Point(25, 33)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New Size(61, 15)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "Patient ID:"
        ' 
        ' AgeLabel
        ' 
        AgeLabel.AutoSize = True
        AgeLabel.Location = New Point(25, 139)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New Size(31, 15)
        AgeLabel.TabIndex = 0
        AgeLabel.Text = "Age:"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(25, 78)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(42, 15)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name:"
        ' 
        ' GenderLabel
        ' 
        GenderLabel.AutoSize = True
        GenderLabel.Location = New Point(25, 208)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New Size(48, 15)
        GenderLabel.TabIndex = 0
        GenderLabel.Text = "Gender:"
        ' 
        ' AddressLabel
        ' 
        AddressLabel.AutoSize = True
        AddressLabel.Location = New Point(25, 333)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New Size(52, 15)
        AddressLabel.TabIndex = 0
        AddressLabel.Text = "Address:"
        ' 
        ' PhoneLabel
        ' 
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New Point(25, 266)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New Size(44, 15)
        PhoneLabel.TabIndex = 0
        PhoneLabel.Text = "Phone:"
        ' 
        ' PatientIDTextBox
        ' 
        PatientIDTextBox.Location = New Point(92, 33)
        PatientIDTextBox.Name = "PatientIDTextBox"
        PatientIDTextBox.Size = New Size(156, 23)
        PatientIDTextBox.TabIndex = 1
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(92, 258)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(156, 23)
        PhoneTextBox.TabIndex = 2
        ' 
        ' AgeTextBox
        ' 
        AgeTextBox.Location = New Point(92, 136)
        AgeTextBox.Name = "AgeTextBox"
        AgeTextBox.Size = New Size(156, 23)
        AgeTextBox.TabIndex = 4
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(92, 75)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(156, 23)
        NameTextBox.TabIndex = 5
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(92, 330)
        AddressTextBox.Multiline = True
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(156, 23)
        AddressTextBox.TabIndex = 6
        ' 
        ' GenderComboBox
        ' 
        GenderComboBox.FormattingEnabled = True
        GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        GenderComboBox.Location = New Point(92, 205)
        GenderComboBox.Name = "GenderComboBox"
        GenderComboBox.Size = New Size(156, 23)
        GenderComboBox.TabIndex = 7
        ' 
        ' SaveButton
        ' 
        SaveButton.BackColor = Color.SlateGray
        SaveButton.Location = New Point(138, 398)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(96, 40)
        SaveButton.TabIndex = 8
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = False
        ' 
        ' UpdateButton
        ' 
        UpdateButton.BackColor = Color.YellowGreen
        UpdateButton.Location = New Point(275, 398)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(88, 40)
        UpdateButton.TabIndex = 8
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.Pink
        DeleteButton.Location = New Point(416, 398)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(87, 40)
        DeleteButton.TabIndex = 8
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Crimson
        ClearButton.Location = New Point(570, 398)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(100, 40)
        ClearButton.TabIndex = 8
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' frmPatientReg
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(800, 450)
        Controls.Add(DeleteButton)
        Controls.Add(ClearButton)
        Controls.Add(UpdateButton)
        Controls.Add(SaveButton)
        Controls.Add(GenderComboBox)
        Controls.Add(AddressTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(AgeTextBox)
        Controls.Add(PhoneTextBox)
        Controls.Add(PatientIDTextBox)
        Controls.Add(NameLabel)
        Controls.Add(PhoneLabel)
        Controls.Add(AddressLabel)
        Controls.Add(GenderLabel)
        Controls.Add(AgeLabel)
        Controls.Add(PatientIDLabel)
        Name = "frmPatientReg"
        Text = "frmPatientReg"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PatientIDLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ClearButton As Button
End Class
