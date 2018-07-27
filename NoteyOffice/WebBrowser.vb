Public Class WebBrowser
    Private Sub bGo_Click(sender As Object, e As EventArgs) Handles bGo.Click
        If tbAddress.Text <> Nothing Then
            Try
                wbMain.Navigate(tbAddress.Text)
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class