Public Class pass
    Public pass As String
    Private Sub bGo_Click(sender As Object, e As EventArgs) Handles bGo.Click
        pass = tbPass.Text
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked Then
            tbPass.UseSystemPasswordChar = False
        Else
            tbPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class