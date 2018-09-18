Public Class FindReplace
    Dim rtbText As String
    Dim index As Integer
    Dim nextIndex As Integer = 0
    Private Sub bFind_Click(sender As Object, e As EventArgs) Handles bFind.Click
        rtbText = Form1.rtbMain.Text
        index = rtbText.IndexOf(tbFindQuery.Text, nextIndex, StringComparison.OrdinalIgnoreCase)
        If index < 0 Then
            MessageBox.Show("No (more) results.", "NoteyWrite", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Form1.rtbMain.Select(index, tbFindQuery.Text.Length)
            Form1.rtbMain.Focus()
            nextIndex = index + tbFindQuery.Text.Length
        End If
    End Sub

    Private Sub bReplace_Click(sender As Object, e As EventArgs) Handles bReplace.Click
        Form1.rtbMain.Rtf = Form1.rtbMain.Rtf.Replace(tbFindQuery.Text, tbReplaceQuery.Text)
    End Sub
End Class