<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RawEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RawEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.bImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.bExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bMainRaw = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.bRawMain = New System.Windows.Forms.ToolStripButton()
        Me.tbRaw = New System.Windows.Forms.TextBox()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.bMainRaw, Me.ToolStripLabel1, Me.bRawMain})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(484, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "Tools"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bImport, Me.bExport, Me.ToolStripSeparator2, Me.bClose})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'bImport
        '
        Me.bImport.Name = "bImport"
        Me.bImport.Size = New System.Drawing.Size(170, 22)
        Me.bImport.Text = "Import from TXT..."
        '
        'bExport
        '
        Me.bExport.Name = "bExport"
        Me.bExport.Size = New System.Drawing.Size(170, 22)
        Me.bExport.Text = "Export as TXT..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'bClose
        '
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(170, 22)
        Me.bClose.Text = "Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bMainRaw
        '
        Me.bMainRaw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.bMainRaw.Image = CType(resources.GetObject("bMainRaw.Image"), System.Drawing.Image)
        Me.bMainRaw.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bMainRaw.Name = "bMainRaw"
        Me.bMainRaw.Size = New System.Drawing.Size(142, 22)
        Me.bMainRaw.Text = "Sync from Main Window"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "RawEdit"
        '
        'bRawMain
        '
        Me.bRawMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.bRawMain.Image = CType(resources.GetObject("bRawMain.Image"), System.Drawing.Image)
        Me.bRawMain.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bRawMain.Name = "bRawMain"
        Me.bRawMain.Size = New System.Drawing.Size(127, 22)
        Me.bRawMain.Text = "Sync to Main Window"
        '
        'tbRaw
        '
        Me.tbRaw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbRaw.Location = New System.Drawing.Point(0, 25)
        Me.tbRaw.Multiline = True
        Me.tbRaw.Name = "tbRaw"
        Me.tbRaw.Size = New System.Drawing.Size(484, 336)
        Me.tbRaw.TabIndex = 1
        '
        'ofdOpen
        '
        Me.ofdOpen.Filter = "TXT Files (*.txt)|*.txt|All files (*.*)|*.*"
        Me.ofdOpen.Title = "Import a TXT file... - RawEdit"
        '
        'sfdSave
        '
        Me.sfdSave.Filter = "TXT Files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'RawEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.tbRaw)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 180)
        Me.Name = "RawEdit"
        Me.Text = "NoteyWrite RawEdit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bMainRaw As ToolStripButton
    Friend WithEvents tbRaw As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents bRawMain As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents bImport As ToolStripMenuItem
    Friend WithEvents bExport As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents bClose As ToolStripMenuItem
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents sfdSave As SaveFileDialog
End Class
