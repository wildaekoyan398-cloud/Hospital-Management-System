<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        LoginButton = New Button()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New Point(133, 63)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(63, 15)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Username:"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New Point(133, 111)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(60, 15)
        PasswordLabel.TabIndex = 1
        PasswordLabel.Text = "Password:"
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.DarkSlateGray
        LoginButton.Location = New Point(199, 191)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(157, 65)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(199, 63)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(157, 23)
        UsernameTextBox.TabIndex = 3
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(199, 108)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(137, 23)
        PasswordTextBox.TabIndex = 4
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.DarkOrange
        ExitButton.Location = New Point(480, 191)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(124, 65)
        ExitButton.TabIndex = 5
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(800, 484)
        Controls.Add(ExitButton)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(LoginButton)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Name = "frmLogin"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ExitButton As Button

End Class
