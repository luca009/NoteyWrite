Public Class about
    Private Sub pbbClose_Click(sender As Object, e As EventArgs) Handles pbbClose.Click
        Me.Close()
    End Sub

    Private Sub llMore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llMore.LinkClicked
        Process.Start("http://www.github.com/luca009")
    End Sub

    Private Sub llGPL3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llGPL3.LinkClicked
        Process.Start("https://www.gnu.org/licenses/gpl.txt")
    End Sub
End Class