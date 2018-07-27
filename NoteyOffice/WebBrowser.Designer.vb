<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowser))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTools = New System.Windows.Forms.TableLayoutPanel()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.bGo = New System.Windows.Forms.Button()
        Me.wbMain = New System.Windows.Forms.WebBrowser()
        Me.tlpMain.SuspendLayout()
        Me.tlpTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpTools, 0, 0)
        Me.tlpMain.Controls.Add(Me.wbMain, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(361, 258)
        Me.tlpMain.TabIndex = 0
        '
        'tlpTools
        '
        Me.tlpTools.ColumnCount = 2
        Me.tlpTools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTools.Controls.Add(Me.tbAddress, 0, 0)
        Me.tlpTools.Controls.Add(Me.bGo, 1, 0)
        Me.tlpTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTools.Location = New System.Drawing.Point(3, 3)
        Me.tlpTools.Name = "tlpTools"
        Me.tlpTools.RowCount = 1
        Me.tlpTools.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTools.Size = New System.Drawing.Size(355, 29)
        Me.tlpTools.TabIndex = 0
        '
        'tbAddress
        '
        Me.tbAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAddress.Location = New System.Drawing.Point(3, 3)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(268, 20)
        Me.tbAddress.TabIndex = 0
        '
        'bGo
        '
        Me.bGo.Location = New System.Drawing.Point(277, 3)
        Me.bGo.Name = "bGo"
        Me.bGo.Size = New System.Drawing.Size(75, 23)
        Me.bGo.TabIndex = 1
        Me.bGo.Text = "Go!"
        Me.bGo.UseVisualStyleBackColor = True
        '
        'wbMain
        '
        Me.wbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbMain.IsWebBrowserContextMenuEnabled = False
        Me.wbMain.Location = New System.Drawing.Point(3, 38)
        Me.wbMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.ScriptErrorsSuppressed = True
        Me.wbMain.Size = New System.Drawing.Size(355, 217)
        Me.wbMain.TabIndex = 1
        Me.wbMain.Url = New System.Uri("https://www.duckduckgo.com/", System.UriKind.Absolute)
        '
        'WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 258)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WebBrowser"
        Me.Text = "Web Browser - NoteyWrite"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpTools.ResumeLayout(False)
        Me.tlpTools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpTools As TableLayoutPanel
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents bGo As Button
    Friend WithEvents wbMain As Windows.Forms.WebBrowser
End Class
