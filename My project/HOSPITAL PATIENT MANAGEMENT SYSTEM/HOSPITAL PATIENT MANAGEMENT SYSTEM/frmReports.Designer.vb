<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        TitleLabel = New Label()
        PatientIDLabel = New Label()
        SearchTextBox = New TextBox()
        SearchButton = New Button()
        ReportsDataGridView = New DataGridView()
        PrintButton = New Button()
        CloseButton = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(ReportsDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TitleLabel
        ' 
        TitleLabel.AutoSize = True
        TitleLabel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TitleLabel.Location = New Point(488, 34)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(138, 30)
        TitleLabel.TabIndex = 0
        TitleLabel.Text = "Title:Reports"
        ' 
        ' PatientIDLabel
        ' 
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New Point(12, 57)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New Size(61, 15)
        PatientIDLabel.TabIndex = 1
        PatientIDLabel.Text = "Patient ID:"
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Location = New Point(94, 54)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.Size = New Size(74, 23)
        SearchTextBox.TabIndex = 2
        ' 
        ' SearchButton
        ' 
        SearchButton.BackColor = Color.IndianRed
        SearchButton.Location = New Point(11, 170)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(77, 58)
        SearchButton.TabIndex = 3
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = False
        ' 
        ' ReportsDataGridView
        ' 
        ReportsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ReportsDataGridView.Location = New Point(94, 109)
        ReportsDataGridView.Name = "ReportsDataGridView"
        ReportsDataGridView.Size = New Size(882, 265)
        ReportsDataGridView.TabIndex = 4
        ' 
        ' PrintButton
        ' 
        PrintButton.BackColor = Color.RosyBrown
        PrintButton.Location = New Point(237, 380)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(123, 58)
        PrintButton.TabIndex = 5
        PrintButton.Text = "Print"
        PrintButton.UseVisualStyleBackColor = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.DarkRed
        CloseButton.Location = New Point(433, 380)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(123, 58)
        CloseButton.TabIndex = 6
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(954, 548)
        Controls.Add(CloseButton)
        Controls.Add(PrintButton)
        Controls.Add(ReportsDataGridView)
        Controls.Add(SearchButton)
        Controls.Add(SearchTextBox)
        Controls.Add(PatientIDLabel)
        Controls.Add(TitleLabel)
        Name = "frmReports"
        Text = "frmReports"
        CType(ReportsDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents PatientIDLabel As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ReportsDataGridView As DataGridView
    Friend WithEvents PrintButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
