Imports System.Drawing.Text

Public Class settings
    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        ' Check what settings are enabled/disabled and enable/disable them in the settings cofiguration.
        If cbDarkTheme.Checked Then
            My.Settings.DarkTheme = True
        Else
            My.Settings.DarkTheme = False
        End If

        If cbEdit.Checked Then
            My.Settings.showEdit = True
        Else
            My.Settings.showEdit = False
        End If

        If cbView.Checked Then
            My.Settings.showView = True
        Else
            My.Settings.showView = False
        End If

        If cbTools.Checked Then
            My.Settings.showTools = True
        Else
            My.Settings.showTools = False
        End If

        If cbFormattingBar.Checked Then
            My.Settings.showFormatting = True
        Else
            My.Settings.showFormatting = False
        End If

        If cbStatusBar.Checked Then
            My.Settings.showStatus = True
        Else
            My.Settings.showStatus = False
        End If

        My.Settings.defaultFont = cbFont.Text
        My.Settings.defaultFontSize = cbFontSize.Text

        My.Settings.Save()
        Form1.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add all installed fonts to the list of selectable fonts in the "Default Font" ComboBox.
        Dim installedFonts As New InstalledFontCollection
        Dim fontFamilies = installedFonts.Families
        Array.ForEach(fontFamilies, Sub(fontFamily) cbFont.Items.Add(fontFamily.Name))

        ' Check which settings are enabled/disabled in the settings configuration and change the UI elements to fit the configuration.
        If My.Settings.DarkTheme Then
            cbDarkTheme.Checked = True
        End If

        If Not My.Settings.showEdit Then
            cbEdit.Checked = False
        End If

        If Not My.Settings.showView Then
            cbView.Checked = False
        End If

        If Not My.Settings.showTools Then
            cbTools.Checked = False
        End If

        If Not My.Settings.showFormatting Then
            cbFormattingBar.Checked = False
        End If

        If Not My.Settings.showStatus Then
            cbStatusBar.Checked = False
        End If

        cbFont.Text = My.Settings.defaultFont
        cbFontSize.Text = My.Settings.defaultFontSize
    End Sub
End Class