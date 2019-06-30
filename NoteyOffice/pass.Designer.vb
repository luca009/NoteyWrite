<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pass))
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.bGo = New System.Windows.Forms.Button()
        Me.cbShowPassword = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbPass
        '
        Me.tbPass.Location = New System.Drawing.Point(12, 13)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(224, 20)
        Me.tbPass.TabIndex = 0
        Me.tbPass.UseSystemPasswordChar = True
        Me.tbPass.WordWrap = False
        '
        'bGo
        '
        Me.bGo.Location = New System.Drawing.Point(120, 39)
        Me.bGo.Name = "bGo"
        Me.bGo.Size = New System.Drawing.Size(116, 23)
        Me.bGo.TabIndex = 1
        Me.bGo.Text = "Go!"
        Me.bGo.UseVisualStyleBackColor = True
        '
        'cbShowPassword
        '
        Me.cbShowPassword.AutoSize = True
        Me.cbShowPassword.Location = New System.Drawing.Point(12, 43)
        Me.cbShowPassword.Name = "cbShowPassword"
        Me.cbShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.cbShowPassword.TabIndex = 2
        Me.cbShowPassword.Text = "Show Password"
        Me.cbShowPassword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Note: Formatting is not yet supported!"
        '
        'pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 86)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbShowPassword)
        Me.Controls.Add(Me.bGo)
        Me.Controls.Add(Me.tbPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pass"
        Me.Text = "Enter En/Decryption Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPass As TextBox
    Friend WithEvents bGo As Button
    Friend WithEvents cbShowPassword As CheckBox
    Friend WithEvents Label1 As Label
End Class
