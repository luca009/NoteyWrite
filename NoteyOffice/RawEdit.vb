Imports System.IO

Public Class RawEdit
    Private Sub RawEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbRaw.Text = Form1.rtbMain.Rtf
    End Sub

    Private Sub bMainRaw_Click(sender As Object, e As EventArgs) Handles bMainRaw.Click
        tbRaw.Text = Form1.rtbMain.Rtf
    End Sub

    Private Sub bRawMain_Click(sender As Object, e As EventArgs) Handles bRawMain.Click
        Try
            Form1.rtbMain.Rtf = tbRaw.Text
        Catch ex As Exception
            MessageBox.Show("Conversion Error! Document may be corrupt now!" & vbNewLine & "Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bImport_Click(sender As Object, e As EventArgs) Handles bImport.Click
        If ofdOpen.ShowDialog = DialogResult.OK Then
            If MessageBox.Show("Importing this TXT file will OVERWRITE existing Rtf data. Still continue?", "RawEdit - Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                tbRaw.Text = File.ReadAllText(ofdOpen.FileName)
            End If
        End If
    End Sub

    Private Sub bExport_Click(sender As Object, e As EventArgs) Handles bExport.Click
        If sfdSave.ShowDialog = DialogResult.OK Then
            File.WriteAllText(sfdSave.FileName, tbRaw.Text)
        End If
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub
End Class