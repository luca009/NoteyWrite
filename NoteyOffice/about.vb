Public Class about
    Private Sub pbbClose_Click(sender As Object, e As EventArgs) Handles pbbClose.Click
        Me.Close()
    End Sub

    Private Sub llMore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llMore.LinkClicked
        Process.Start("http://www.github.com/luca009")
    End Sub
End Class