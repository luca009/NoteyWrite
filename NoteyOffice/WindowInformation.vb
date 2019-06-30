Public Class WindowInformation
    Private Sub WindowInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPositionX.Text = My.Settings.windowPosition.X
        tbPositionY.Text = My.Settings.windowPosition.Y
        tbSizeX.Text = My.Settings.windowSize.Width
        tbSizeY.Text = My.Settings.windowSize.Height
    End Sub

    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        My.Settings.windowPosition = New Point(Convert.ToInt32(tbPositionX.Text), Convert.ToInt32(tbPositionY.Text))
        My.Settings.windowSize = New Size(Convert.ToInt32(tbSizeX.Text), Convert.ToInt32(tbSizeY.Text))
        My.Settings.Save()
        Me.Close()
    End Sub
End Class