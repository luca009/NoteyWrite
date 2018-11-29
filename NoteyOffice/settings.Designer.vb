<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbFormattingBar = New System.Windows.Forms.CheckBox()
        Me.cbActionBar = New System.Windows.Forms.CheckBox()
        Me.cbStatusBar = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbSettings = New System.Windows.Forms.CheckBox()
        Me.cbTools = New System.Windows.Forms.CheckBox()
        Me.cbView = New System.Windows.Forms.CheckBox()
        Me.cbEdit = New System.Windows.Forms.CheckBox()
        Me.cbFile = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDarkTheme = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbFont = New System.Windows.Forms.ComboBox()
        Me.cbFontSize = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(378, 285)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.56989!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.43011!))
        Me.TableLayoutPanel2.Controls.Add(Me.bCancel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.bSave, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 253)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(372, 29)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'bCancel
        '
        Me.bCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bCancel.ForeColor = System.Drawing.Color.Red
        Me.bCancel.Location = New System.Drawing.Point(3, 3)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(103, 23)
        Me.bCancel.TabIndex = 0
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSave.Location = New System.Drawing.Point(112, 3)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(257, 23)
        Me.bSave.TabIndex = 1
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(372, 244)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(364, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personalization"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbFormattingBar)
        Me.GroupBox3.Controls.Add(Me.cbActionBar)
        Me.GroupBox3.Controls.Add(Me.cbStatusBar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(351, 61)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Toolbars"
        '
        'cbFormattingBar
        '
        Me.cbFormattingBar.AutoSize = True
        Me.cbFormattingBar.Checked = True
        Me.cbFormattingBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFormattingBar.Location = New System.Drawing.Point(88, 36)
        Me.cbFormattingBar.Name = "cbFormattingBar"
        Me.cbFormattingBar.Size = New System.Drawing.Size(94, 17)
        Me.cbFormattingBar.TabIndex = 1
        Me.cbFormattingBar.Text = "Formatting Bar"
        Me.cbFormattingBar.UseVisualStyleBackColor = True
        '
        'cbActionBar
        '
        Me.cbActionBar.AutoSize = True
        Me.cbActionBar.Checked = True
        Me.cbActionBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbActionBar.Enabled = False
        Me.cbActionBar.Location = New System.Drawing.Point(7, 36)
        Me.cbActionBar.Name = "cbActionBar"
        Me.cbActionBar.Size = New System.Drawing.Size(75, 17)
        Me.cbActionBar.TabIndex = 1
        Me.cbActionBar.Text = "Action Bar"
        Me.cbActionBar.UseVisualStyleBackColor = True
        '
        'cbStatusBar
        '
        Me.cbStatusBar.AutoSize = True
        Me.cbStatusBar.Checked = True
        Me.cbStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusBar.Location = New System.Drawing.Point(188, 36)
        Me.cbStatusBar.Name = "cbStatusBar"
        Me.cbStatusBar.Size = New System.Drawing.Size(75, 17)
        Me.cbStatusBar.TabIndex = 1
        Me.cbStatusBar.Text = "Status Bar"
        Me.cbStatusBar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Choose which Toolbars to show:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbSettings)
        Me.GroupBox2.Controls.Add(Me.cbTools)
        Me.GroupBox2.Controls.Add(Me.cbView)
        Me.GroupBox2.Controls.Add(Me.cbEdit)
        Me.GroupBox2.Controls.Add(Me.cbFile)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 66)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menus"
        '
        'cbSettings
        '
        Me.cbSettings.AutoSize = True
        Me.cbSettings.Checked = True
        Me.cbSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettings.Enabled = False
        Me.cbSettings.Location = New System.Drawing.Point(222, 37)
        Me.cbSettings.Name = "cbSettings"
        Me.cbSettings.Size = New System.Drawing.Size(64, 17)
        Me.cbSettings.TabIndex = 5
        Me.cbSettings.Text = "Settings"
        Me.cbSettings.UseVisualStyleBackColor = True
        '
        'cbTools
        '
        Me.cbTools.AutoSize = True
        Me.cbTools.Checked = True
        Me.cbTools.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTools.Location = New System.Drawing.Point(163, 37)
        Me.cbTools.Name = "cbTools"
        Me.cbTools.Size = New System.Drawing.Size(52, 17)
        Me.cbTools.TabIndex = 4
        Me.cbTools.Text = "Tools"
        Me.cbTools.UseVisualStyleBackColor = True
        '
        'cbView
        '
        Me.cbView.AutoSize = True
        Me.cbView.Checked = True
        Me.cbView.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbView.Location = New System.Drawing.Point(107, 37)
        Me.cbView.Name = "cbView"
        Me.cbView.Size = New System.Drawing.Size(49, 17)
        Me.cbView.TabIndex = 3
        Me.cbView.Text = "View"
        Me.cbView.UseVisualStyleBackColor = True
        '
        'cbEdit
        '
        Me.cbEdit.AutoSize = True
        Me.cbEdit.Checked = True
        Me.cbEdit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEdit.Location = New System.Drawing.Point(56, 37)
        Me.cbEdit.Name = "cbEdit"
        Me.cbEdit.Size = New System.Drawing.Size(44, 17)
        Me.cbEdit.TabIndex = 2
        Me.cbEdit.Text = "Edit"
        Me.cbEdit.UseVisualStyleBackColor = True
        '
        'cbFile
        '
        Me.cbFile.AutoSize = True
        Me.cbFile.Checked = True
        Me.cbFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFile.Enabled = False
        Me.cbFile.Location = New System.Drawing.Point(7, 37)
        Me.cbFile.Name = "cbFile"
        Me.cbFile.Size = New System.Drawing.Size(42, 17)
        Me.cbFile.TabIndex = 1
        Me.cbFile.Text = "File"
        Me.cbFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Choose which Menus to show:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbDarkTheme)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Theme"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "More coming soon..."
        '
        'cbDarkTheme
        '
        Me.cbDarkTheme.AutoSize = True
        Me.cbDarkTheme.Location = New System.Drawing.Point(7, 20)
        Me.cbDarkTheme.Name = "cbDarkTheme"
        Me.cbDarkTheme.Size = New System.Drawing.Size(121, 17)
        Me.cbDarkTheme.TabIndex = 0
        Me.cbDarkTheme.Text = "Enable Dark Theme"
        Me.cbDarkTheme.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(364, 218)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Defaults"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbFont)
        Me.GroupBox4.Controls.Add(Me.cbFontSize)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(351, 53)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Font"
        '
        'cbFont
        '
        Me.cbFont.FormattingEnabled = True
        Me.cbFont.Location = New System.Drawing.Point(172, 19)
        Me.cbFont.Name = "cbFont"
        Me.cbFont.Size = New System.Drawing.Size(173, 21)
        Me.cbFont.TabIndex = 2
        Me.cbFont.Text = "Microsoft Sans Serif"
        '
        'cbFontSize
        '
        Me.cbFontSize.FormattingEnabled = True
        Me.cbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72", "94", "106"})
        Me.cbFontSize.Location = New System.Drawing.Point(120, 19)
        Me.cbFontSize.Name = "cbFontSize"
        Me.cbFontSize.Size = New System.Drawing.Size(46, 21)
        Me.cbFontSize.TabIndex = 1
        Me.cbFontSize.Text = "8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Select a default Font:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(364, 218)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Coming soon..."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 39)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "But don't worry!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NoteyWrite is being actively developed by luca009, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and these " &
    "settings will come VERY soon." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(312, 51)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Coming soon..."
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 285)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.Text = "NoteyWrite Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents bCancel As Button
    Friend WithEvents bSave As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFile As CheckBox
    Friend WithEvents cbSettings As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbActionBar As CheckBox
    Friend WithEvents Label3 As Label
    Public WithEvents cbDarkTheme As CheckBox
    Public WithEvents cbView As CheckBox
    Public WithEvents cbEdit As CheckBox
    Public WithEvents cbTools As CheckBox
    Public WithEvents cbFormattingBar As CheckBox
    Public WithEvents cbStatusBar As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbFontSize As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbFont As ComboBox
End Class
