<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbbClose = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.llMore = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.llGPL3 = New System.Windows.Forms.LinkLabel()
        CType(Me.pbbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About NoteyWrite"
        '
        'pbbClose
        '
        Me.pbbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbbClose.Image = CType(resources.GetObject("pbbClose.Image"), System.Drawing.Image)
        Me.pbbClose.Location = New System.Drawing.Point(244, 9)
        Me.pbbClose.Name = "pbbClose"
        Me.pbbClose.Size = New System.Drawing.Size(35, 33)
        Me.pbbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbbClose.TabIndex = 1
        Me.pbbClose.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Featurefull and Lightweight."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Coded with ♥ in Austria by luca009."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Version 1.1.0.0, 30th August 2019"
        '
        'llMore
        '
        Me.llMore.AutoSize = True
        Me.llMore.Location = New System.Drawing.Point(198, 143)
        Me.llMore.Name = "llMore"
        Me.llMore.Size = New System.Drawing.Size(76, 13)
        Me.llMore.TabIndex = 6
        Me.llMore.TabStop = True
        Me.llMore.Text = "More by me :D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NoteyWrite is free and open-source software licensed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "under the GNU Public Licens" &
    "e v3."
        '
        'llGPL3
        '
        Me.llGPL3.AutoSize = True
        Me.llGPL3.Location = New System.Drawing.Point(13, 107)
        Me.llGPL3.Name = "llGPL3"
        Me.llGPL3.Size = New System.Drawing.Size(62, 13)
        Me.llGPL3.TabIndex = 8
        Me.llGPL3.TabStop = True
        Me.llGPL3.Text = "The GPLv3"
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 170)
        Me.Controls.Add(Me.llGPL3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.llMore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbbClose)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About NoteyWrite"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.pbbClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pbbClose As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents llMore As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents llGPL3 As LinkLabel
End Class
