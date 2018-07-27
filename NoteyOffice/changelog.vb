Public Class changelog
    Private Sub changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tbMain.Text = My.Resources.res.changelog
        Catch ex As Exception
            MessageBox.Show("The Changelog couldn't be loaded! Error Description: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class