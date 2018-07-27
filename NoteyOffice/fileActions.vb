Imports System.IO.Path
Namespace text
    Public Class fileActions
        Public Function open(ByVal file As String, ByVal rtb As RichTextBox)
            If GetExtension(file) = ".txt" Then
                Try
                    rtb.Text = String.Join((Keys.Enter).ToString, System.IO.File.ReadAllLines(file))
                Catch ex As Exception
                    MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyOffice - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf GetExtension(file) = ".rtf" Then
                Try
                    rtb.LoadFile(file)
                Catch ex As Exception
                    MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyOffice - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Try
                    rtb.Text = String.Join((Keys.Enter).ToString, System.IO.File.ReadAllLines(file))
                Catch ex As Exception
                    MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyOffice - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Function
    End Class
End Namespace

