Public Class SaveDialog
    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        ' Show the save dialog and call the save function
        If Form1.alreadySaved Then
            Form1.save(Form1.currentlyOpen)
        Else
            If Form1.sfdSave.ShowDialog = DialogResult.OK Then
                Form1.save(Form1.sfdSave.FileName)
            End If
        End If
        Application.Exit()
    End Sub

    Private Sub bDSave_Click(sender As Object, e As EventArgs) Handles bDSave.Click
        Application.Exit()
    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class