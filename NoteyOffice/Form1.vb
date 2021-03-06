﻿' Import all libraries
Imports System.IO.Path
Imports System.Drawing.Text

Public Class Form1
    ' Dim all the required variables
    Dim sMsg As String = ""
    Private isInitialized As Boolean
    Public alreadySaved As Boolean = False
    Public IsModified As Boolean = False
    Public currentlyOpen As String
    Private checkPrint As Integer
    Public isFullscreen As Boolean = False
    Dim plainTextModeEnabled As Boolean
    Dim isEncrypted As Boolean
    Private passw As String


    ' Create a function for toggling a checked state
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
        Dim fontFamilies = installedFonts.Families
        Array.ForEach(fontFamilies, Sub(fontFamily) cbFont.Items.Add(fontFamily.Name))

        ' Look for User Settings and apply them
        ' Apply Theme
        tsTools.BackColor = My.Settings.uiBackColor

        ' Fore some reason ddbFile's BackColor won't change with tsTools
        ddbFile.BackColor = My.Settings.uiBackColor

        ddbFile.ForeColor = My.Settings.uiForeColor
        ddbEdit.ForeColor = My.Settings.uiForeColor
        ddbView.ForeColor = My.Settings.uiForeColor
        ddbTools.ForeColor = My.Settings.uiForeColor
        bSettings.ForeColor = My.Settings.uiForeColor
        lZoomFactor.ForeColor = My.Settings.uiForeColor

        tsFormatting.BackColor = My.Settings.uiBackColor
        cbFont.BackColor = My.Settings.uiBackColor
        cbFontSize.BackColor = My.Settings.uiBackColor
        cbFont.ForeColor = My.Settings.uiForeColor
        cbFontSize.ForeColor = My.Settings.uiForeColor

        ssStatus.BackColor = My.Settings.uiBackColor
        ssStatus.ForeColor = My.Settings.uiForeColor

        If Not My.Settings.showEdit Then
            ddbEdit.Visible = False
        End If

        If Not My.Settings.showView Then
            ddbView.Visible = False
        End If

        If Not My.Settings.showTools Then
            ddbTools.Visible = False
        End If

        If Not My.Settings.showFormatting Then
            tsFormatting.Visible = False
        End If

        If Not My.Settings.showStatus Then
            ssStatus.Visible = False
        End If

        If Not My.Settings.showZoom Then
            tsbZoomOut.Visible = False
            lZoomFactor.Visible = False
            tsbZoomIn.Visible = False
            tssZoomSettings.Visible = False
        End If

        If My.Settings.higherCharacterLimit Then
            rtbMain.MaxLength = 2147483647
        End If

        If My.Settings.keepWindowChanges Then
            Me.Location = My.Settings.windowPosition
            Me.Size = My.Settings.windowSize
            If Not My.Settings.windowMaximized Then
                Me.WindowState = FormWindowState.Normal
            ElseIf My.Settings.windowMaximized Then
                Me.WindowState = FormWindowState.Maximized
            End If
        End If

        cbFont.Text = My.Settings.defaultFont
        cbFontSize.Text = My.Settings.defaultFontSize
        rtbMain.SelectionFont = New Font(My.Settings.defaultFont, My.Settings.defaultFontSize)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles pdPrint.BeginPrint
        checkPrint = 0
    End Sub

    Public Function open(ByVal file As String, ByVal rtb As RichTextBox)
        ' Check if file is encrypted by NW
        Dim fileattr = IO.File.GetAttributes(file)
        If (fileattr = 1052672) Then
            isEncrypted = True
        Else
            isEncrypted = False
        End If

        ' Check for a valid extension in the file being opened
        If GetExtension(file) = ".txt" Then
            Try
                If isEncrypted Then
                    If pass.ShowDialog = DialogResult.OK Then
                        rtbMain.Text = System.Text.Encoding.UTF8.GetString(Decrypt(pass.pass, IO.File.ReadAllBytes(file)))
                        passw = pass.pass
                        plainTextMode(True)
                    End If
                    Return True
                End If
                plainTextMode(True)
                rtb.LoadFile(file, RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf GetExtension(file) = ".rtf" Then
            Try
                If isEncrypted Then
                    If pass.ShowDialog = DialogResult.OK Then
                        rtbMain.Rtf = System.Text.Encoding.UTF8.GetString(Decrypt(pass.pass, IO.File.ReadAllBytes(file)))
                        passw = pass.pass
                        plainTextMode(False)
                    End If
                    Return True
                End If
                plainTextMode(False)
                rtb.LoadFile(file)
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                If isEncrypted Then
                    If pass.ShowDialog = DialogResult.OK Then
                        rtbMain.Text = System.Text.Encoding.UTF8.GetString(Decrypt(pass.pass, IO.File.ReadAllBytes(file)))
                        passw = pass.pass
                    End If
                    Return True
                End If
                rtb.LoadFile(file, RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        lStatus.Text = "Open file."
        Me.Text = "NoteyWrite - " & GetFileName(file)
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
        ' Make a new document in a new window.
        Dim ExePath As String = Application.ExecutablePath
        Process.Start(ExePath)
        lStatus.Text = "Create new document."
    End Sub

    Public Function save(ByVal file As String)
        ' Check if the file being saved has a valid extention, if so perform the steps for saving it in that file type.
        lStatus.Text = "Saving..."
        If GetExtension(file) = ".txt" Then
            Try
                If isEncrypted Then
                    System.IO.File.WriteAllBytes(file, Encrypt(passw, System.Text.Encoding.UTF8.GetBytes(rtbMain.Rtf)))
                    IO.File.SetAttributes(file, IO.FileAttributes.Archive & IO.FileAttributes.Encrypted)
                    currentlyOpen = file
                    alreadySaved = True
                    IsModified = False
                    Return True
                End If
                rtbMain.SaveFile(file, RichTextBoxStreamType.PlainText)
                currentlyOpen = file
                alreadySaved = True
                IsModified = False
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf GetExtension(file) = ".rtf" Then
            Try
                If isEncrypted Then
                    System.IO.File.WriteAllBytes(file, Encrypt(passw, System.Text.Encoding.UTF8.GetBytes(rtbMain.Rtf)))
                    IO.File.SetAttributes(file, IO.FileAttributes.Archive & IO.FileAttributes.Encrypted)
                    currentlyOpen = file
                    alreadySaved = True
                    IsModified = False
                    Return True
                End If
                rtbMain.SaveFile(file)
                currentlyOpen = file
                alreadySaved = True
                IsModified = False
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                If isEncrypted Then
                    System.IO.File.WriteAllBytes(file, Encrypt(passw, System.Text.Encoding.UTF8.GetBytes(rtbMain.Rtf)))
                    IO.File.SetAttributes(file, IO.FileAttributes.Archive & IO.FileAttributes.Encrypted)
                    currentlyOpen = file
                    alreadySaved = True
                    IsModified = False
                    Return True
                End If
                System.IO.File.WriteAllText(file, rtbMain.Text)
                currentlyOpen = file
                alreadySaved = True
                IsModified = False
            Catch ex As Exception
                MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        lStatus.Text = "Save document."
        Me.Text = "NoteyWrite - " & GetFileName(file)
    End Function

    Private Sub bOpen_Click(sender As Object, e As EventArgs) Handles bOpen.Click
        ' Openes the Open Dialog and then openes the document requested
        lStatus.Text = "Show Open Dialog."
        If ofdOpen.ShowDialog() = DialogResult.OK And ofdOpen.FileName.Length > 0 Then
            open(ofdOpen.FileName, rtbMain)
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        ' Show the save dialog and call the save function
        If alreadySaved Then
            save(currentlyOpen)
        Else
            lStatus.Text = "Show Save Dialog."
            If sfdSave.ShowDialog = DialogResult.OK Then
                save(sfdSave.FileName)
            End If
        End If
    End Sub

    Private Sub bSaveAs_Click(sender As Object, e As EventArgs) Handles bSaveAs.Click
        ' Openes the save dialog and call the save function
        lStatus.Text = "Show Save Dialog."
        If sfdSave.ShowDialog() = DialogResult.OK Then
            save(sfdSave.FileName)
        End If
    End Sub

    Private Sub bPageSetup_Click(sender As Object, e As EventArgs) Handles bPageSetup.Click
        ' Openes the page setup dialog
        psdPageSetup.PageSettings = pdPrint.DefaultPageSettings
        psdPageSetup.ShowDialog()
        lStatus.Text = "Show Page Setup Dialog."
        pdPrint.DefaultPageSettings = psdPageSetup.PageSettings
    End Sub

    Private Sub bPrint_Click(sender As Object, e As EventArgs) Handles bPrint.Click
        ' Print the document based on the settings from the page setup dialog
        lStatus.Text = "Show Print Dialog."
        If pdPrintD.ShowDialog() = DialogResult.OK Then
            pdPrint.PrinterSettings = pdPrintD.PrinterSettings
            pdPrint.Print()
        End If
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        ' Update the Location and Size of the window in the Settings.
        My.Settings.windowPosition = Me.Location
        My.Settings.windowSize = Me.Size

        ' Check if the current file has been modified, if so show a dialog asking if the user wants to save their work
        If IsModified Then
            If SaveDialog.ShowDialog() <> DialogResult.Cancel Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Update the Location and Size of the window in the Settings.
        My.Settings.windowPosition = Me.Location
        My.Settings.windowSize = Me.Size
        If Me.WindowState = FormWindowState.Normal Then
            My.Settings.windowMaximized = False
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            My.Settings.windowMaximized = True
        End If

        ' Check if the current file has been modified, if so show a dialog asking if the user wants to save thier work
        If IsModified Then
            If SaveDialog.ShowDialog() = DialogResult.Cancel Then
                e.Cancel = True
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click
        ' Create a new Document in a new Window
        Dim ExePath As String = Application.ExecutablePath
        Process.Start(ExePath)
        lStatus.Text = "Create new document."
    End Sub

    Private Sub rtbMain_TextChanged(sender As Object, e As EventArgs) Handles rtbMain.TextChanged
        ' If the text gets changed, the isModified variable sets to True
        If Not IsModified Then
            If alreadySaved Then
                Me.Text = "NoteyWrite - " & GetFileName(currentlyOpen) & "*"
            Else
                Me.Text = "NoteyWrite - Untitled*"
            End If
            IsModified = True
        End If
        lLength.Text = "Length: " & rtbMain.TextLength
    End Sub

    Private Sub tsbSaveAs_Click(sender As Object, e As EventArgs) Handles tsbSaveAs.Click
        ' Openes the Save Dialog, and then saves to the corresponding file
        lStatus.Text = "Show Save Dialog."
        If sfdSave.ShowDialog() = DialogResult.OK Then
            save(sfdSave.FileName)
        End If
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        ' Checks if the document has been Opened or already Saved, otherwise openes the Save Dialog
        If alreadySaved Then
            save(currentlyOpen)
        Else
            lStatus.Text = "Show Save Dialog."
            If sfdSave.ShowDialog = DialogResult.OK Then
                save(sfdSave.FileName)
            End If
        End If
    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click
        ' Openes the Open Dialog and openes the corresponding file
        lStatus.Text = "Show Open Dialog."
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
        lStatus.Text = "Change Font."
    End Sub

    Private Sub cbFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFontSize.SelectedIndexChanged
        ' Checks if the application is initialized, if it is change the font-size to the selected size
        If Not isInitialized Then
            Return
        End If
        rtbMain.SelectionFont = fontReturn()
        lStatus.Text = "Change Font-Size."
    End Sub

    Private Sub tsbAlignLeft_Click(sender As Object, e As EventArgs) Handles tsbAlignLeft.Click
        ' Unchecks every other Alignment button, and aligns the text left
        tsbAlignCenter.Checked = False
        tsbAlignRight.Checked = False
        tsbAlignLeft.Checked = True
        rtbMain.SelectionAlignment = HorizontalAlignment.Left
        lStatus.Text = "Align selection left."
    End Sub

    Private Sub tsbAlignCenter_Click(sender As Object, e As EventArgs) Handles tsbAlignCenter.Click
        ' Unchecks every other Alignment button, and aligns the text to the center
        tsbAlignCenter.Checked = True
        tsbAlignRight.Checked = False
        tsbAlignLeft.Checked = False
        rtbMain.SelectionAlignment = HorizontalAlignment.Center
        lStatus.Text = "Align selection centered."
    End Sub

    Private Sub tsbAlignRight_Click(sender As Object, e As EventArgs) Handles tsbAlignRight.Click
        ' Unchecks every other Alignment button, and aligns the text right
        tsbAlignCenter.Checked = False
        tsbAlignRight.Checked = True
        tsbAlignLeft.Checked = False
        rtbMain.SelectionAlignment = HorizontalAlignment.Right
        lStatus.Text = "Align selection right."
    End Sub

    Private Sub tsbBold_Click(sender As Object, e As EventArgs) Handles tsbBold.Click
        ' Checks if the application is initialized, if it is make the font bold 
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbBold)
        rtbMain.SelectionFont = fontReturn()
        lStatus.Text = "Make selection bold."
    End Sub

    Private Sub tsbItalic_Click(sender As Object, e As EventArgs) Handles tsbItalic.Click
        ' Checks if the application is initialized, if it is make the font italic
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbItalic)
        rtbMain.SelectionFont = fontReturn()
        lStatus.Text = "Make selection italic."
    End Sub

    Private Sub tsbUnderline_Click(sender As Object, e As EventArgs) Handles tsbUnderline.Click
        ' Checks if the application is initialized, if it is make the font underlined
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbUnderline)
        rtbMain.SelectionFont = fontReturn()
        lStatus.Text = "Make selection underlined."
    End Sub

    Private Sub tsbStrikethrough_Click(sender As Object, e As EventArgs) Handles tsbStrikethrough.Click
        ' Checks if the application is initialized, if it is make the font strikethrough
        If Not isInitialized Then
            Return
        End If
        toggleChecked(tsbStrikethrough)
        rtbMain.SelectionFont = fontReturn()
        lStatus.Text = "Make selection strikethrough."
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
        lStatus.Text = "Undo last action."
    End Sub

    Private Sub bRedo_Click(sender As Object, e As EventArgs) Handles bRedo.Click
        ' Redo the last action
        rtbMain.Redo()
        lStatus.Text = "Redo last action."
    End Sub

    Private Sub bCut_Click(sender As Object, e As EventArgs) Handles bCut.Click
        ' Cut the selected text
        My.Computer.Clipboard.SetText(rtbMain.SelectedText)
        rtbMain.SelectedText = ""
        lStatus.Text = "Cut selected text."
    End Sub

    Private Sub bCopy_Click(sender As Object, e As EventArgs) Handles bCopy.Click
        ' Copy the selected text
        My.Computer.Clipboard.SetText(rtbMain.SelectedText)
        lStatus.Text = "Copy to clipboard."
    End Sub

    Private Sub bPaste_Click(sender As Object, e As EventArgs) Handles bPaste.Click
        ' Paste the text from the clipboard
        rtbMain.Text = My.Computer.Clipboard.GetText()
        lStatus.Text = "Paste from clipboard."
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        ' Delete the selected text
        rtbMain.SelectedText = ""
        lStatus.Text = "Delete selection."
    End Sub

    Private Sub bSelectAll_Click(sender As Object, e As EventArgs) Handles bSelectAll.Click
        ' Select all text
        rtbMain.SelectAll()
        lStatus.Text = "Select all text."
    End Sub

    Private Sub bZoomOut_Click(sender As Object, e As EventArgs) Handles bZoomOut.Click
        ' Change the ZoomFactor to zoom out
        If Not rtbMain.ZoomFactor = 0.5F Then
            rtbMain.ZoomFactor -= 0.5F
            lStatus.Text = "Zoom out."
            lZoomFactor.Text = rtbMain.ZoomFactor
        End If
    End Sub

    Private Sub bZoomIn_Click(sender As Object, e As EventArgs) Handles bZoomIn.Click
        ' Change the ZoomFactor to zoom in
        If Not rtbMain.ZoomFactor = 10.0F Then
            rtbMain.ZoomFactor += 0.5F
            lStatus.Text = "Zoom in."
            lZoomFactor.Text = rtbMain.ZoomFactor
        End If
    End Sub

    Private Sub bResetZoom_Click(sender As Object, e As EventArgs) Handles bResetZoom.Click
        ' Resets the ZoomFactor
        rtbMain.ZoomFactor = 1.0F
        lStatus.Text = "Reset Zoom."
    End Sub

    Private Sub bAbout_Click(sender As Object, e As EventArgs) Handles bAbout.Click
        ' Show the about dialog
        about.Show()
        lStatus.Text = "Open About Dialog."
    End Sub

    Private Sub bFullscreen_Click(sender As Object, e As EventArgs) Handles bFullscreen.Click
        ' Checks if the window is fullscreen, if it isn't, make it fullscreen, otherwise, make it windowed
        If isFullscreen Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            isFullscreen = False
            bFullscreen.Checked = False
            lStatus.Text = "Exit Fullscreen."
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Normal
            Me.WindowState = FormWindowState.Maximized
            isFullscreen = True
            bFullscreen.Checked = True
            lStatus.Text = "Enter Fullscreen."
        End If
    End Sub

    Private Sub bChangelog_Click(sender As Object, e As EventArgs) Handles bChangelog.Click
        ' Open the changelog window
        changelog.Show()
        lStatus.Text = "Open Changelog."
    End Sub

    Private Sub bWebBrowser_Click(sender As Object, e As EventArgs) Handles bWebBrowser.Click
        ' Open the Embedded Web Browser
        WebBrowser.Show()
        lStatus.Text = "Open Web Browser."
    End Sub

    Private Sub bWordWrap_Click(sender As Object, e As EventArgs) Handles bWordWrap.Click
        ' Toggle the "Checked" state of the button, then turf on/off word wrap
        bWordWrap.Checked = Not bWordWrap.Checked
        rtbMain.WordWrap = bWordWrap.Checked
        lStatus.Text = "Toggle Word Wrap."
    End Sub

    Private Sub bFindReplace_Click(sender As Object, e As EventArgs) Handles bFindReplace.Click
        lStatus.Text = "Open Find/Replace Dialog."
        FindReplace.Show()
    End Sub

    Private Sub bTColor_Click(sender As Object, e As EventArgs) Handles bTColor.Click
        lStatus.Text = "Open Text Color Dialog."
        If cdColor.ShowDialog = DialogResult.OK Then
            lStatus.Text = "Change Text Color."
            rtbMain.SelectionColor = cdColor.Color
        End If
    End Sub

    Private Sub rtbMain_SelectionChanged(sender As Object, e As EventArgs) Handles rtbMain.SelectionChanged
        lStatus.Text = "Selection changed."
        If rtbMain.SelectionAlignment <> vbNull Then
            ' If statement for the Alignment of the text
            If rtbMain.SelectionAlignment = HorizontalAlignment.Left Then
                ' Activate Align to left button and disable all others
                tsbAlignCenter.Checked = False
                tsbAlignRight.Checked = False
                tsbAlignLeft.Checked = True
            Else
                ' Activate Align to center button and disable all others
                tsbAlignCenter.Checked = True
                tsbAlignRight.Checked = False
                tsbAlignLeft.Checked = False
            End If
        Else
            ' Activate Align to right button and disable all others
            tsbAlignCenter.Checked = False
            tsbAlignRight.Checked = True
            tsbAlignLeft.Checked = False
        End If

        '         Weird VB doesn't let me put <> here
        '                         vvv
        If rtbMain.SelectionFont IsNot Nothing Then
            ' Checks if the text is bold, italic, etc.
            tsbBold.Checked = False
            tsbItalic.Checked = False
            tsbUnderline.Checked = False
            tsbStrikethrough.Checked = False

            If rtbMain.SelectionFont.Bold Then
                tsbBold.Checked = True
            End If

            If rtbMain.SelectionFont.Italic Then
                tsbItalic.Checked = True
            End If

            If rtbMain.SelectionFont.Underline Then
                tsbUnderline.Checked = True
            End If

            If rtbMain.SelectionFont.Strikeout Then
                tsbStrikethrough.Checked = True
            End If

            If cbFont.Text <> rtbMain.SelectionFont.OriginalFontName Then
                cbFont.Text = rtbMain.SelectionFont.OriginalFontName
            End If

            cbFontSize.Text = rtbMain.SelectionFont.Size
        End If
    End Sub

    Private Sub bBackColor_Click(sender As Object, e As EventArgs) Handles bBackColor.Click
        ' Opens the Background Color dialog, and if possible, change the Background Color.
        lStatus.Text = "Open Background Color Dialog."
        If cdBackColor.ShowDialog = DialogResult.OK Then
            lStatus.Text = "Change Background Color."
            rtbMain.SelectionBackColor = cdBackColor.Color
        End If
    End Sub

    Private Sub bRawEdit_Click(sender As Object, e As EventArgs) Handles bRawEdit.Click
        RawEdit.Show()
        lStatus.Text = "Open RawEdit."
    End Sub

    Private Sub bSettings_Click(sender As Object, e As EventArgs) Handles bSettings.Click
        settings.Show()
        lStatus.Text = "Open Settings."
    End Sub

    Private Sub tsbZoomOut_Click(sender As Object, e As EventArgs) Handles tsbZoomOut.Click
        ' Change the ZoomFactor to zoom out
        If Not rtbMain.ZoomFactor = 0.5F Then
            rtbMain.ZoomFactor -= 0.5F
            lStatus.Text = "Zoom out."
            lZoomFactor.Text = rtbMain.ZoomFactor
        End If
    End Sub

    Private Sub tsbZoomIn_Click(sender As Object, e As EventArgs) Handles tsbZoomIn.Click
        ' Change the ZoomFactor to zoom in
        If Not rtbMain.ZoomFactor = 10.0F Then
            rtbMain.ZoomFactor += 0.5F
            lStatus.Text = "Zoom in."
            lZoomFactor.Text = rtbMain.ZoomFactor
        End If
    End Sub

    Private Sub lZoomFactor_Click(sender As Object, e As EventArgs) Handles lZoomFactor.Click
        rtbMain.ZoomFactor = 1
        lStatus.Text = "Reset Zoom."
        lZoomFactor.Text = rtbMain.ZoomFactor
    End Sub

    Private Sub bOpenEncrypted_Click(sender As Object, e As EventArgs) Handles bOpenEncrypted.Click
        lStatus.Text = "Open encrypted document dialog."
        ofdOpen.Title = "Open encrypted document - NoteyWrite"
        If ofdOpen.ShowDialog = DialogResult.OK Then
            If pass.ShowDialog = DialogResult.OK Then
                Try
                    lStatus.Text = "Decrypting..."
                    rtbMain.Rtf = System.Text.Encoding.UTF8.GetString(Decrypt(pass.pass, IO.File.ReadAllBytes(ofdOpen.FileName)))
                    isEncrypted = True
                    lStatus.Text = "Decrypted document."
                Catch ex As Exception
                    MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                pass.pass = ""
            End If
        End If
    End Sub

    Private Sub bSaveAsEncrypted_Click(sender As Object, e As EventArgs) Handles bSaveAsEncrypted.Click
        lStatus.Text = "Save as encrypted document."
        Dim str = rtbMain.Rtf
        If sfdSave.ShowDialog = DialogResult.OK Then
            If pass.ShowDialog = DialogResult.OK Then
                Try
                    lStatus.Text = "Encrypting..."
                    Dim rtf As String
                    rtf = rtbMain.Rtf
                    System.IO.File.WriteAllBytes(sfdSave.FileName, Encrypt(pass.pass, System.Text.Encoding.UTF8.GetBytes(rtf)))
                    IO.File.SetAttributes(sfdSave.FileName, IO.FileAttributes.Archive & IO.FileAttributes.Encrypted)
                    currentlyOpen = sfdSave.FileName
                    alreadySaved = True
                    IsModified = False
                    isEncrypted = True
                    lStatus.Text = "Saved encrypted document."
                Catch ex As Exception
                    MessageBox.Show("Unexpected Error! Description: " & ex.Message, "NoteyWrite - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                passw = pass.pass
                pass.pass = ""
            End If
        End If
        ' Dim strDecoded = System.Text.Encoding.UTF8.GetString(Decrypt("muh!", enc))
    End Sub

    Function Encrypt(password As String, input As Byte()) As Byte()
        Dim pdb = New System.Security.Cryptography.PasswordDeriveBytes(password, Nothing)
        Dim ms = New System.IO.MemoryStream()
        Dim aes = New System.Security.Cryptography.AesManaged()
        aes.Key = pdb.GetBytes(aes.KeySize / 8)
        aes.IV = pdb.GetBytes(aes.BlockSize / 8)
        Dim cs = New System.Security.Cryptography.CryptoStream(ms, aes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        cs.Write(input, 0, input.Length)
        cs.Close()
        Return ms.ToArray()
    End Function

    Function Decrypt(password As String, input As Byte()) As Byte()
        Dim pdb = New System.Security.Cryptography.PasswordDeriveBytes(password, Nothing)
        Dim ms = New System.IO.MemoryStream()
        Dim aes = New System.Security.Cryptography.AesManaged()
        aes.Key = pdb.GetBytes(aes.KeySize / 8)
        aes.IV = pdb.GetBytes(aes.BlockSize / 8)
        Dim cs = New System.Security.Cryptography.CryptoStream(ms, aes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        cs.Write(input, 0, input.Length)
        cs.Close()
        Return ms.ToArray()
    End Function

    Private Sub bPlainTextMode_Click(sender As Object, e As EventArgs) Handles bPlainTextMode.Click
        plainTextMode(bPlainTextMode.Checked)
    End Sub

    Function plainTextMode(enable As Boolean)
        bPlainTextMode.Checked = enable
        cbFont.Enabled = Not enable
        cbFontSize.Enabled = Not enable
        tsbAlignCenter.Enabled = Not enable
        tsbAlignLeft.Enabled = Not enable
        tsbAlignRight.Enabled = Not enable
        tsbBold.Enabled = Not enable
        tsbItalic.Enabled = Not enable
        tsbUnderline.Enabled = Not enable
        tsbStrikethrough.Enabled = Not enable
        bTColor.Enabled = Not enable
        bBackColor.Enabled = Not enable
        rtbMain.Text = rtbMain.Text.ToString
        rtbMain.SelectAll()
        rtbMain.SelectionFont = New Font(My.Settings.defaultFont, My.Settings.defaultFontSize)
        rtbMain.DeselectAll()
    End Function
End Class
