Imports System.Drawing.Text

Public Class settings
    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click

        bSave.Text = "Please Wait..."
        Application.DoEvents()

        ' Check what settings are enabled/disabled and enable/disable them in the settings cofiguration.

        My.Settings.showEdit = cbEdit.Checked

        My.Settings.showView = cbView.Checked

        My.Settings.showTools = cbTools.Checked

        My.Settings.showStatus = cbStatusBar.Checked

        My.Settings.showFormatting = cbFormattingBar.Checked

        My.Settings.higherCharacterLimit = cbHCharacterLimit.Checked

        If rbStandard.Checked Then
            My.Settings.theme = 0
            My.Settings.uiBackColor = Color.White
            My.Settings.uiForeColor = Color.Black
        ElseIf rbDarkTheme.Checked Then
            My.Settings.theme = 1
            My.Settings.uiBackColor = Color.Black
            My.Settings.uiForeColor = Color.White
        Else
            My.Settings.theme = 2
            My.Settings.uiBackColor = cdBackColor.Color
            My.Settings.uiForeColor = cdForeColor.Color
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
        If My.Settings.theme = 0 Then
            rbStandard.Checked = True
        ElseIf My.Settings.theme = 1 Then
            rbDarkTheme.Checked = True
        Else
            rbCustom.Checked = True
        End If

        cbEdit.Checked = My.Settings.showEdit

        cbView.Checked = My.Settings.showView

        cbTools.Checked = My.Settings.showTools

        cbFormattingBar.Checked = My.Settings.showFormatting

        cbStatusBar.Checked = My.Settings.showStatus

        cbHCharacterLimit.Checked = My.Settings.higherCharacterLimit

        cbFont.Text = My.Settings.defaultFont
        cbFontSize.Text = My.Settings.defaultFontSize

        bBG.BackColor = My.Settings.uiBackColor
        bFG.BackColor = My.Settings.uiForeColor

        cdBackColor.Color = My.Settings.uiBackColor
        cdForeColor.Color = My.Settings.uiForeColor
    End Sub

    Private Sub rbCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rbCustom.CheckedChanged
        If rbCustom.Checked Then
            bBG.Enabled = True
            bFG.Enabled = True
        Else
            bBG.Enabled = False
            bFG.Enabled = False
        End If
    End Sub

    Private Sub bFG_Click(sender As Object, e As EventArgs) Handles bFG.Click
        cdForeColor.ShowDialog()
        bFG.BackColor = cdForeColor.Color
    End Sub

    Private Sub bBG_Click(sender As Object, e As EventArgs) Handles bBG.Click
        cdBackColor.ShowDialog()
        bBG.BackColor = cdBackColor.Color
    End Sub
End Class