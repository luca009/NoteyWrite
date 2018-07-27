﻿' Import all libraries
Imports System.IO.Path
Imports System.Drawing.Text

Public Class Form1
    ' Dim all the required variables
    Dim extension As String
    Dim sMsg As String = ""
    Private isInitialized As Boolean
    Dim alreadySaved As Boolean = False
    Public IsModified As Boolean = False
    Public currentlyOpen As String
    Private checkPrint As Integer
    Public isFullscreen As Boolean = False

    ' Create a function for toggeling a checked state
    Function toggleChecked(ByVal tsb As ToolStripButton)
        tsb.Checked = Not tsb.Checked
    End Function

    ' Create a function that returns a font depending on the formatting buttons being checked
    Function fontReturn()
        Dim resultingFont As Font
        Dim fontStyle As FontStyle
        If tsbBold.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If
        If tsbItalic.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If
        If tsbUnderline.Checked Then
            fontStyle = fontStyle Or FontStyle.Underline
        End If
        If tsbStrikethrough.Checked Then
            fontStyle = fontStyle Or FontStyle.Strikeout
        End If
        resultingFont = New Font(New FontFamily(cbFont.Text), Convert.ToSingle(cbFontSize.Text), fontStyle)
        Return resultingFont
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if arguments are passed to the app. If so, open the file that correspondes to the argument
        For Each sArg As String In My.Application.CommandLineArgs
            sMsg &= sArg & ""
        Next
        If Not sMsg = Nothing Then
            extension = IO.Path.GetExtension(sMsg)
            open(sMsg, rtbMain)
            currentlyOpen = sMsg
            alreadySaved = True
            IsModified = False
        End If
    End Sub

    Private Sub Form_Load() Handles Me.Load
        isInitialized = True

        ' Check for installed fonts and add them to the list of fonts
        Dim installedFonts As New InstalledFontCollection
        Dim fontFamilies = installedFonts.Families()
        Array.ForEach(fontFamilies, Sub(fontFamily) cbFont.Items.Add(fontFamily.Name))
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles pdPrint.BeginPrint
        checkPrint = 0
    End Sub
    Public Function open(ByVal file As String, ByVal rtb As RichTextBox)
        ' Check for a valid extension in the file being opened
        If GetExtension(file) = ".txt" Then
            Try
                rtb.LoadFile(file, RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf GetExtension(file) = ".rtf" Then
            Try
                rtb.LoadFile(file)
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                rtb.LoadFile(file, RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Function

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        ' Print the content of the RichTextBox. Store the last character printed.
        checkPrint = rtbMain.Print(checkPrint, rtbMain.TextLength, e)

        ' Look for more pages
        If checkPrint < rtbMain.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub bNew_Click(sender As Object, e As EventArgs) Handles bNew.Click
        ' Duplicate the current form and clear the text on it
        Dim sDocument As New Form1
        sDocument.rtbMain.Clear()
        sDocument.Show()
    End Sub

    Public Function save(ByVal file As String)
        ' Check if the file being saved has a valid extention, if so perform the steps for saving it in that file type.
        If GetExtension(file) = ".txt" Then
            Try
                rtbMain.SaveFile(file, RichTextBoxStreamType.PlainText)
                currentlyOpen = file
                alreadySaved = True
                IsModified = False
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf GetExtension(file) = ".rtf" Then
            Try
                rtbMain.SaveFile(file)
                currentlyOpen = file
                alreadySaved = True
                IsModified = False
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                System.IO.File.WriteAllText(file, rtbMain.Text)
                currentlyOpen = file
                alreadySaved = True
                IsModified = False
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message & " Error Code: " & ex.GetHashCode(), "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Function

    Private Sub bOpen_Click(sender As Object, e As EventArgs) Handles bOpen.Click
        ' Openes the Open Dialog and then openes the document requested
        If ofdOpen.ShowDialog() = DialogResult.OK And ofdOpen.FileName.Length > 0 Then
            open(ofdOpen.FileName, rtbMain)
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        ' Show the save dialog and call the save function
        If alreadySaved Then
            save(currentlyOpen)
        Else
            If sfdSave.ShowDialog = DialogResult.OK Then
                save(sfdSave.FileName)
            End If
        End If
    End Sub

    Private Sub bSaveAs_Click(sender As Object, e As EventArgs) Handles bSaveAs.Click
        ' Openes the save dialog and call the save function
        If sfdSave.ShowDialog() = DialogResult.OK Then
            save(sfdSave.FileName)
        End If
    End Sub

    Private Sub bPageSetup_Click(sender As Object, e As EventArgs) Handles bPageSetup.Click
        ' Openes the page setup dialog
        psdPageSetup.PageSettings = pdPrint.DefaultPageSettings
        psdPageSetup.ShowDialog()
        pdPrint.DefaultPageSettings = psdPageSetup.PageSettings
    End Sub

    Private Sub bPrint_Click(sender As Object, e As EventArgs) Handles bPrint.Click
        ' Print the document based on the settings from the page setup dialog
        If pdPrintD.ShowDialog() = DialogResult.OK Then
            pdPrint.PrinterSettings = pdPrintD.PrinterSettings
            pdPrint.Print()
        End If
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Check if the current file has been modified, if so show a dialog asking if the user wants to save thier work
        If IsModified Then
            If SaveDialog.ShowDialog() = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click
        ' Create a new Document in a new Window
        Dim sDocument As New Form1
        sDocument.Show()
        sDocument.rtbMain.Text = ""
    End Sub

    Private Sub rtbMain_TextChanged(sender As Object, e As EventArgs)
        ' If the text gets changed, the isModified variable sets to True
        IsModified = True
    End Sub

    Private Sub tsbSaveAs_Click(sender As Object, e As EventArgs) Handles tsbSaveAs.Click
        ' Openes the Save Dialog, and then saves to the corresponding file
        If sfdSave.ShowDialog() = DialogResult.OK Then
            save(sfdSave.FileName)
        End If
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        ' Checks if the document has been Opened or already Saved, otherwise openes the Save Dialog
        If alreadySaved Then
            save(currentlyOpen)
        Else
            If sfdSave.ShowDialog = DialogResult.OK Then
                save(sfdSave.FileName)
            End If
        End If
    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click
        ' Openes the Open Dialog and openes the corresponding file
        If ofdOpen.ShowDialog() = DialogResult.OK And ofdOpen.FileName.Length > 0 Then
            open(ofdOpen.FileName, rtbMain)
        End If
    End Sub

    Private Sub cbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFont.SelectedIndexChanged
        ' Checks if the application is initialized, if it is change the font to the selected one
        If Not isInitialized Then
            Return
        End If
        rtbMain.SelectionFont = fontReturn()
    End Sub

    Private Sub cbFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFontSize.SelectedIndexChanged
        ' Checks if the application is initialized, if it is change the font-size to the selected size
        If Not isInitialized Then
            Return
        End If
        rtbMain.SelectionFont = fontReturn()
    End Sub

    Private Sub tsbAlignLeft_Click(sender As Object, e As EventArgs) Handles tsbAlignLeft.Click
        ' Unchecks every other Alignment button, and aligns the text left
        tsbAlignCenter.Checked = False
        tsbAlignRight.Checked = False
        tsbAlignLeft.Checked = True
        rtbMain.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub tsbAlignCenter_Click(sender As Object, e As EventArgs) Handles tsbAlignCenter.Click
        ' Unchecks every other Alignment button, and aligns the text to the center
        tsbAlignCenter.Checked = True
        tsbAlignRight.Checked = False
        tsbAlignLeft.Checked = False
        rtbMain.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub tsbAlignRight_Click(sender As Object, e As EventArgs) Handles tsbAlignRight.Click
        ' Unchecks every other Alignment button, and aligns the text right
        tsbAlignCenter.Checked = False
        tsbAlignRight.Checked = True
        tsbAlignLeft.Checked = False
        rtbMain.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub tsbBold_Click(sender As Object, e As EventArgs) Handles tsbBold.Click
        ' Checks if the application is initialized, if it is make the font bold 
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbBold)
        rtbMain.SelectionFont = fontReturn()
    End Sub

    Private Sub tsbItalic_Click(sender As Object, e As EventArgs) Handles tsbItalic.Click
        ' Checks if the application is initialized, if it is make the font italic
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbItalic)
        rtbMain.SelectionFont = fontReturn()
    End Sub

    Private Sub tsbUnderline_Click(sender As Object, e As EventArgs) Handles tsbUnderline.Click
        ' Checks if the application is initialized, if it is make the font underlined
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbUnderline)
        rtbMain.SelectionFont = fontReturn()
    End Sub

    Private Sub tsbStrikethrough_Click(sender As Object, e As EventArgs) Handles tsbStrikethrough.Click
        ' Checks if the application is initialized, if it is make the font strikethrough
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbStrikethrough)
        rtbMain.SelectionFont = fontReturn()
    End Sub

    Private Sub ddbEdit_Click(sender As Object, e As EventArgs) Handles ddbEdit.Click
        ' Checks if certain elements of the editing group can be used, if so activate them
        If rtbMain.CanUndo Then
            bUndo.Enabled = True
        Else
            bUndo.Enabled = False
        End If

        If rtbMain.CanRedo Then
            bRedo.Enabled = True
        Else
            bRedo.Enabled = False
        End If

        If rtbMain.SelectedText = Nothing Then
            bCut.Enabled = False
            bCopy.Enabled = False
            bDelete.Enabled = False
        Else
            bCut.Enabled = True
            bCopy.Enabled = True
            bDelete.Enabled = True
        End If

        If My.Computer.Clipboard.GetText = Nothing Then
            bPaste.Enabled = False
        Else
            bPaste.Enabled = True
        End If
    End Sub

    Private Sub bUndo_Click(sender As Object, e As EventArgs) Handles bUndo.Click
        ' Undo the last action
        rtbMain.Undo()
    End Sub

    Private Sub bRedo_Click(sender As Object, e As EventArgs) Handles bRedo.Click
        ' Redo the last action
        rtbMain.Redo()
    End Sub

    Private Sub bCut_Click(sender As Object, e As EventArgs) Handles bCut.Click
        ' Cut the selected text
        My.Computer.Clipboard.SetText(rtbMain.SelectedText)
        rtbMain.SelectedText = ""
    End Sub

    Private Sub bCopy_Click(sender As Object, e As EventArgs) Handles bCopy.Click
        ' Copy the selected text
        My.Computer.Clipboard.SetText(rtbMain.SelectedText)
    End Sub

    Private Sub bPaste_Click(sender As Object, e As EventArgs) Handles bPaste.Click
        ' Paste the text from the clipboard
        rtbMain.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        ' Delete the selected text
        rtbMain.SelectedText = ""
    End Sub

    Private Sub bSelectAll_Click(sender As Object, e As EventArgs) Handles bSelectAll.Click
        ' Select all text
        rtbMain.SelectAll()
    End Sub

    Private Sub bZoomOut_Click(sender As Object, e As EventArgs) Handles bZoomOut.Click
        ' Change the ZoomFactor to zoom out
        If Not rtbMain.ZoomFactor = 0.5F Then
            rtbMain.ZoomFactor -= 0.5F
        End If
    End Sub

    Private Sub bZoomIn_Click(sender As Object, e As EventArgs) Handles bZoomIn.Click
        ' Change the ZoomFactor to zoom in
        If Not rtbMain.ZoomFactor = 10.0F Then
            rtbMain.ZoomFactor += 0.5F
        End If
    End Sub

    Private Sub bResetZoom_Click(sender As Object, e As EventArgs) Handles bResetZoom.Click
        ' Resets the ZoomFactor
        rtbMain.ZoomFactor = 1.0F
    End Sub

    Private Sub bAbout_Click(sender As Object, e As EventArgs) Handles bAbout.Click
        ' Show the about dialog
        about.Show()
    End Sub

    Private Sub bFullscreen_Click(sender As Object, e As EventArgs) Handles bFullscreen.Click
        ' Checks if the window is fullscreen, if it isn't, make it fullscreen, otherwise, make it windowed
        If isFullscreen Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            isFullscreen = False
            bFullscreen.Checked = False
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            isFullscreen = True
            bFullscreen.Checked = True
        End If
    End Sub

    Private Sub bChangelog_Click(sender As Object, e As EventArgs) Handles bChangelog.Click
        ' Open the changelog window
        changelog.Show()
    End Sub

    Private Sub bWebBrowser_Click(sender As Object, e As EventArgs) Handles bWebBrowser.Click
        ' Open the Embedded Web Browser
        WebBrowser.Show()
    End Sub
End Class