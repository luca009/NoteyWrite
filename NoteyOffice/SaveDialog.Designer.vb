<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaveDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveDialog))
        Me.lPrompt = New System.Windows.Forms.Label()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bDSave = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lPrompt
        '
        Me.lPrompt.AutoSize = True
        Me.lPrompt.Location = New System.Drawing.Point(1, 9)
        Me.lPrompt.Name = "lPrompt"
        Me.lPrompt.Size = New System.Drawing.Size(253, 13)
        Me.lPrompt.TabIndex = 0
        Me.lPrompt.Text = "Do you want to save your document before closing?"
        '
        'bSave
        '
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bSave.Location = New System.Drawing.Point(12, 25)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(124, 31)
        Me.bSave.TabIndex = 1
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bDSave
        '
        Me.bDSave.Image = CType(resources.GetObject("bDSave.Image"), System.Drawing.Image)
        Me.bDSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bDSave.Location = New System.Drawing.Point(143, 25)
        Me.bDSave.Name = "bDSave"
        Me.bDSave.Size = New System.Drawing.Size(101, 31)
        Me.bDSave.TabIndex = 2
        Me.bDSave.Text = "Don't save"
        Me.bDSave.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Image = CType(resources.GetObject("bCancel.Image"), System.Drawing.Image)
        Me.bCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCancel.Location = New System.Drawing.Point(94, 62)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(150, 28)
        Me.bCancel.TabIndex = 3
        Me.bCancel.Text = "Continue working"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'SaveDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 99)
        Me.ControlBox = False
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bDSave)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.lPrompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaveDialog"
        Me.Text = "Save before closing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lPrompt As Label
    Friend WithEvents bSave As Button
    Friend WithEvents bDSave As Button
    Friend WithEvents bCancel As Button
End Class
