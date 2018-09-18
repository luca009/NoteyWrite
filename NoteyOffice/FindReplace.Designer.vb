<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindReplace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindReplace))
        Me.tbFindQuery = New System.Windows.Forms.TextBox()
        Me.bFind = New System.Windows.Forms.Button()
        Me.tbReplaceQuery = New System.Windows.Forms.TextBox()
        Me.bReplace = New System.Windows.Forms.Button()
        Me.lFindWhat = New System.Windows.Forms.Label()
        Me.lReplaceWith = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbFindQuery
        '
        Me.tbFindQuery.Location = New System.Drawing.Point(80, 14)
        Me.tbFindQuery.Name = "tbFindQuery"
        Me.tbFindQuery.Size = New System.Drawing.Size(201, 20)
        Me.tbFindQuery.TabIndex = 1
        '
        'bFind
        '
        Me.bFind.Location = New System.Drawing.Point(287, 12)
        Me.bFind.Name = "bFind"
        Me.bFind.Size = New System.Drawing.Size(75, 23)
        Me.bFind.TabIndex = 3
        Me.bFind.Text = "Find Next"
        Me.bFind.UseVisualStyleBackColor = True
        '
        'tbReplaceQuery
        '
        Me.tbReplaceQuery.Location = New System.Drawing.Point(80, 43)
        Me.tbReplaceQuery.Name = "tbReplaceQuery"
        Me.tbReplaceQuery.Size = New System.Drawing.Size(201, 20)
        Me.tbReplaceQuery.TabIndex = 2
        '
        'bReplace
        '
        Me.bReplace.Location = New System.Drawing.Point(287, 41)
        Me.bReplace.Name = "bReplace"
        Me.bReplace.Size = New System.Drawing.Size(75, 23)
        Me.bReplace.TabIndex = 4
        Me.bReplace.Text = "Replace"
        Me.bReplace.UseVisualStyleBackColor = True
        '
        'lFindWhat
        '
        Me.lFindWhat.AutoSize = True
        Me.lFindWhat.Location = New System.Drawing.Point(18, 17)
        Me.lFindWhat.Name = "lFindWhat"
        Me.lFindWhat.Size = New System.Drawing.Size(56, 13)
        Me.lFindWhat.TabIndex = 0
        Me.lFindWhat.Text = "Find what:"
        '
        'lReplaceWith
        '
        Me.lReplaceWith.AutoSize = True
        Me.lReplaceWith.Location = New System.Drawing.Point(2, 46)
        Me.lReplaceWith.Name = "lReplaceWith"
        Me.lReplaceWith.Size = New System.Drawing.Size(72, 13)
        Me.lReplaceWith.TabIndex = 0
        Me.lReplaceWith.Text = "Replace with:"
        '
        'FindReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 75)
        Me.Controls.Add(Me.lReplaceWith)
        Me.Controls.Add(Me.lFindWhat)
        Me.Controls.Add(Me.bReplace)
        Me.Controls.Add(Me.bFind)
        Me.Controls.Add(Me.tbReplaceQuery)
        Me.Controls.Add(Me.tbFindQuery)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindReplace"
        Me.Text = "Find & Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbFindQuery As TextBox
    Friend WithEvents bFind As Button
    Friend WithEvents tbReplaceQuery As TextBox
    Friend WithEvents bReplace As Button
    Friend WithEvents lFindWhat As Label
    Friend WithEvents lReplaceWith As Label
End Class
