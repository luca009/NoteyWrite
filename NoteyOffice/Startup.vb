Imports System.Drawing.Text
Public NotInheritable Class Startup
    Private Sub Starup_Start() Handles Me.Load
        Dim installedFonts As New InstalledFontCollection
        Dim fontFamilies = installedFonts.Families()
        Array.ForEach(fontFamilies, Sub(fontFamily) Form1.cbFont.Items.Add(fontFamily.Name))
    End Sub
End Class
