<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowInformation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPositionX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSizeX = New System.Windows.Forms.TextBox()
        Me.bOK = New System.Windows.Forms.Button()
        Me.tbPositionY = New System.Windows.Forms.TextBox()
        Me.tbSizeY = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Position:"
        '
        'tbPositionX
        '
        Me.tbPositionX.Location = New System.Drawing.Point(65, 13)
        Me.tbPositionX.Name = "tbPositionX"
        Me.tbPositionX.Size = New System.Drawing.Size(70, 20)
        Me.tbPositionX.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Size:"
        '
        'tbSizeX
        '
        Me.tbSizeX.Location = New System.Drawing.Point(65, 39)
        Me.tbSizeX.Name = "tbSizeX"
        Me.tbSizeX.Size = New System.Drawing.Size(70, 20)
        Me.tbSizeX.TabIndex = 3
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(12, 66)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(200, 23)
        Me.bOK.TabIndex = 5
        Me.bOK.Text = "Save"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'tbPositionY
        '
        Me.tbPositionY.Location = New System.Drawing.Point(141, 13)
        Me.tbPositionY.Name = "tbPositionY"
        Me.tbPositionY.Size = New System.Drawing.Size(70, 20)
        Me.tbPositionY.TabIndex = 2
        '
        'tbSizeY
        '
        Me.tbSizeY.Location = New System.Drawing.Point(141, 39)
        Me.tbSizeY.Name = "tbSizeY"
        Me.tbSizeY.Size = New System.Drawing.Size(70, 20)
        Me.tbSizeY.TabIndex = 4
        '
        'WindowInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 101)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tbSizeY)
        Me.Controls.Add(Me.tbSizeX)
        Me.Controls.Add(Me.tbPositionY)
        Me.Controls.Add(Me.tbPositionX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WindowInformation"
        Me.Text = "Window Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbPositionX As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSizeX As TextBox
    Friend WithEvents bOK As Button
    Friend WithEvents tbPositionY As TextBox
    Friend WithEvents tbSizeY As TextBox
End Class
