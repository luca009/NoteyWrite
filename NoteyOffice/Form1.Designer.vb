<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.ddbFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.bNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.bOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.bSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.bSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.bPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.bAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.bChangelog = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbEdit = New System.Windows.Forms.ToolStripDropDownButton()
        Me.bUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.bRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.bFindReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.bCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.bCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.bPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.bDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.bSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbView = New System.Windows.Forms.ToolStripDropDownButton()
        Me.bZoomOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.bResetZoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.bZoomIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.bWordWrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.bFullscreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.bWebBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.bRawEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.psdPageSetup = New System.Windows.Forms.PageSetupDialog()
        Me.pdPrintD = New System.Windows.Forms.PrintDialog()
        Me.tsFormatting = New System.Windows.Forms.ToolStrip()
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbSaveAs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.cbFont = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAlignLeft = New System.Windows.Forms.ToolStripButton()
        Me.tsbAlignCenter = New System.Windows.Forms.ToolStripButton()
        Me.tsbAlignRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBold = New System.Windows.Forms.ToolStripButton()
        Me.tsbItalic = New System.Windows.Forms.ToolStripButton()
        Me.tsbUnderline = New System.Windows.Forms.ToolStripButton()
        Me.tsbStrikethrough = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.bTColor = New System.Windows.Forms.ToolStripButton()
        Me.bBackColor = New System.Windows.Forms.ToolStripButton()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lLength = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.cdBackColor = New System.Windows.Forms.ColorDialog()
        Me.rtbMain = New NoteyOffice.RichTextBoxPrint.RichTextBoxPrintCtrl()
        Me.tsTools.SuspendLayout()
        Me.tsFormatting.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsTools
        '
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddbFile, Me.ddbEdit, Me.ddbView, Me.ToolStripDropDownButton1})
        Me.tsTools.Location = New System.Drawing.Point(0, 0)
        Me.tsTools.Name = "tsTools"
        Me.tsTools.Size = New System.Drawing.Size(594, 25)
        Me.tsTools.TabIndex = 0
        Me.tsTools.Text = "ToolStrip1"
        '
        'ddbFile
        '
        Me.ddbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ddbFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bNew, Me.bOpen, Me.bSave, Me.bSaveAs, Me.ToolStripSeparator1, Me.bPageSetup, Me.bPrint, Me.ToolStripSeparator2, Me.bExit, Me.bAbout, Me.bChangelog})
        Me.ddbFile.Image = CType(resources.GetObject("ddbFile.Image"), System.Drawing.Image)
        Me.ddbFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbFile.Name = "ddbFile"
        Me.ddbFile.Size = New System.Drawing.Size(38, 22)
        Me.ddbFile.Text = "File"
        '
        'bNew
        '
        Me.bNew.Image = CType(resources.GetObject("bNew.Image"), System.Drawing.Image)
        Me.bNew.Name = "bNew"
        Me.bNew.Size = New System.Drawing.Size(142, 22)
        Me.bNew.Text = "New"
        '
        'bOpen
        '
        Me.bOpen.Image = CType(resources.GetObject("bOpen.Image"), System.Drawing.Image)
        Me.bOpen.Name = "bOpen"
        Me.bOpen.Size = New System.Drawing.Size(142, 22)
        Me.bOpen.Text = "Open..."
        '
        'bSave
        '
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(142, 22)
        Me.bSave.Text = "Save"
        '
        'bSaveAs
        '
        Me.bSaveAs.Image = CType(resources.GetObject("bSaveAs.Image"), System.Drawing.Image)
        Me.bSaveAs.Name = "bSaveAs"
        Me.bSaveAs.Size = New System.Drawing.Size(142, 22)
        Me.bSaveAs.Text = "Save As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'bPageSetup
        '
        Me.bPageSetup.Name = "bPageSetup"
        Me.bPageSetup.Size = New System.Drawing.Size(142, 22)
        Me.bPageSetup.Text = "Page Setup..."
        '
        'bPrint
        '
        Me.bPrint.Image = CType(resources.GetObject("bPrint.Image"), System.Drawing.Image)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(142, 22)
        Me.bPrint.Text = "Print... "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        'bExit
        '
        Me.bExit.Image = CType(resources.GetObject("bExit.Image"), System.Drawing.Image)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(142, 22)
        Me.bExit.Text = "Exit"
        '
        'bAbout
        '
        Me.bAbout.Image = CType(resources.GetObject("bAbout.Image"), System.Drawing.Image)
        Me.bAbout.Name = "bAbout"
        Me.bAbout.Size = New System.Drawing.Size(142, 22)
        Me.bAbout.Text = "About"
        '
        'bChangelog
        '
        Me.bChangelog.Image = CType(resources.GetObject("bChangelog.Image"), System.Drawing.Image)
        Me.bChangelog.Name = "bChangelog"
        Me.bChangelog.Size = New System.Drawing.Size(142, 22)
        Me.bChangelog.Text = "Changelog"
        '
        'ddbEdit
        '
        Me.ddbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ddbEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bUndo, Me.bRedo, Me.ToolStripSeparator3, Me.bFindReplace, Me.ToolStripSeparator10, Me.bCut, Me.bCopy, Me.bPaste, Me.bDelete, Me.bSelectAll})
        Me.ddbEdit.Image = CType(resources.GetObject("ddbEdit.Image"), System.Drawing.Image)
        Me.ddbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbEdit.Name = "ddbEdit"
        Me.ddbEdit.Size = New System.Drawing.Size(40, 22)
        Me.ddbEdit.Text = "Edit"
        '
        'bUndo
        '
        Me.bUndo.Image = CType(resources.GetObject("bUndo.Image"), System.Drawing.Image)
        Me.bUndo.Name = "bUndo"
        Me.bUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.bUndo.Size = New System.Drawing.Size(164, 22)
        Me.bUndo.Text = "Undo"
        '
        'bRedo
        '
        Me.bRedo.Image = CType(resources.GetObject("bRedo.Image"), System.Drawing.Image)
        Me.bRedo.Name = "bRedo"
        Me.bRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.bRedo.Size = New System.Drawing.Size(164, 22)
        Me.bRedo.Text = "Redo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'bFindReplace
        '
        Me.bFindReplace.Image = CType(resources.GetObject("bFindReplace.Image"), System.Drawing.Image)
        Me.bFindReplace.Name = "bFindReplace"
        Me.bFindReplace.Size = New System.Drawing.Size(164, 22)
        Me.bFindReplace.Text = "Find and Replace"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(161, 6)
        '
        'bCut
        '
        Me.bCut.Image = CType(resources.GetObject("bCut.Image"), System.Drawing.Image)
        Me.bCut.Name = "bCut"
        Me.bCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.bCut.Size = New System.Drawing.Size(164, 22)
        Me.bCut.Text = "Cut"
        '
        'bCopy
        '
        Me.bCopy.Image = CType(resources.GetObject("bCopy.Image"), System.Drawing.Image)
        Me.bCopy.Name = "bCopy"
        Me.bCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.bCopy.Size = New System.Drawing.Size(164, 22)
        Me.bCopy.Text = "Copy"
        '
        'bPaste
        '
        Me.bPaste.Image = CType(resources.GetObject("bPaste.Image"), System.Drawing.Image)
        Me.bPaste.Name = "bPaste"
        Me.bPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.bPaste.Size = New System.Drawing.Size(164, 22)
        Me.bPaste.Text = "Paste"
        '
        'bDelete
        '
        Me.bDelete.Image = CType(resources.GetObject("bDelete.Image"), System.Drawing.Image)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.bDelete.Size = New System.Drawing.Size(164, 22)
        Me.bDelete.Text = "Delete"
        '
        'bSelectAll
        '
        Me.bSelectAll.Image = CType(resources.GetObject("bSelectAll.Image"), System.Drawing.Image)
        Me.bSelectAll.Name = "bSelectAll"
        Me.bSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.bSelectAll.Size = New System.Drawing.Size(164, 22)
        Me.bSelectAll.Text = "Select all"
        '
        'ddbView
        '
        Me.ddbView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ddbView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bZoomOut, Me.bResetZoom, Me.bZoomIn, Me.ToolStripSeparator9, Me.bWordWrap, Me.ToolStripSeparator8, Me.bFullscreen})
        Me.ddbView.Image = CType(resources.GetObject("ddbView.Image"), System.Drawing.Image)
        Me.ddbView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbView.Name = "ddbView"
        Me.ddbView.Size = New System.Drawing.Size(45, 22)
        Me.ddbView.Text = "View"
        '
        'bZoomOut
        '
        Me.bZoomOut.Image = CType(resources.GetObject("bZoomOut.Image"), System.Drawing.Image)
        Me.bZoomOut.Name = "bZoomOut"
        Me.bZoomOut.Size = New System.Drawing.Size(137, 22)
        Me.bZoomOut.Text = "Zoom out"
        '
        'bResetZoom
        '
        Me.bResetZoom.Image = CType(resources.GetObject("bResetZoom.Image"), System.Drawing.Image)
        Me.bResetZoom.Name = "bResetZoom"
        Me.bResetZoom.Size = New System.Drawing.Size(137, 22)
        Me.bResetZoom.Text = "Reset Zoom"
        '
        'bZoomIn
        '
        Me.bZoomIn.Image = CType(resources.GetObject("bZoomIn.Image"), System.Drawing.Image)
        Me.bZoomIn.Name = "bZoomIn"
        Me.bZoomIn.Size = New System.Drawing.Size(137, 22)
        Me.bZoomIn.Text = "Zoom in"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(134, 6)
        '
        'bWordWrap
        '
        Me.bWordWrap.Checked = True
        Me.bWordWrap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.bWordWrap.Image = CType(resources.GetObject("bWordWrap.Image"), System.Drawing.Image)
        Me.bWordWrap.Name = "bWordWrap"
        Me.bWordWrap.Size = New System.Drawing.Size(137, 22)
        Me.bWordWrap.Text = "Word Wrap"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(134, 6)
        '
        'bFullscreen
        '
        Me.bFullscreen.Image = CType(resources.GetObject("bFullscreen.Image"), System.Drawing.Image)
        Me.bFullscreen.Name = "bFullscreen"
        Me.bFullscreen.Size = New System.Drawing.Size(137, 22)
        Me.bFullscreen.Text = "Fullscreen"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bWebBrowser, Me.bRawEdit})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripDropDownButton1.Text = "Tools"
        '
        'bWebBrowser
        '
        Me.bWebBrowser.Name = "bWebBrowser"
        Me.bWebBrowser.Size = New System.Drawing.Size(143, 22)
        Me.bWebBrowser.Text = "Web Browser"
        '
        'bRawEdit
        '
        Me.bRawEdit.Name = "bRawEdit"
        Me.bRawEdit.Size = New System.Drawing.Size(143, 22)
        Me.bRawEdit.Text = "RawEdit"
        '
        'ofdOpen
        '
        Me.ofdOpen.Filter = "Known text formats (*.txt, *.rtf)|*.txt; *.rtf|All files (*.*)|*.*"
        Me.ofdOpen.Title = "Open a document - NoteyWrite"
        '
        'sfdSave
        '
        Me.sfdSave.DefaultExt = "rtf"
        Me.sfdSave.Filter = "Plain text files (*.txt)|*.txt|Rich text files|*.rtf|All files (*.*)|*.*"
        Me.sfdSave.Title = "Save a document - NoteyWrite"
        '
        'pdPrintD
        '
        Me.pdPrintD.UseEXDialog = True
        '
        'tsFormatting
        '
        Me.tsFormatting.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsFormatting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbOpen, Me.tsbSave, Me.tsbSaveAs, Me.ToolStripSeparator4, Me.cbFontSize, Me.cbFont, Me.ToolStripSeparator5, Me.tsbAlignLeft, Me.tsbAlignCenter, Me.tsbAlignRight, Me.ToolStripSeparator6, Me.tsbBold, Me.tsbItalic, Me.tsbUnderline, Me.tsbStrikethrough, Me.ToolStripSeparator11, Me.bTColor, Me.bBackColor})
        Me.tsFormatting.Location = New System.Drawing.Point(0, 25)
        Me.tsFormatting.Name = "tsFormatting"
        Me.tsFormatting.Size = New System.Drawing.Size(594, 25)
        Me.tsFormatting.TabIndex = 2
        Me.tsFormatting.Text = "Formatting"
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Image = CType(resources.GetObject("tsbNew.Image"), System.Drawing.Image)
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 22)
        Me.tsbNew.Text = "New"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = CType(resources.GetObject("tsbOpen.Image"), System.Drawing.Image)
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbOpen.Text = "Open"
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "Save"
        '
        'tsbSaveAs
        '
        Me.tsbSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSaveAs.Image = CType(resources.GetObject("tsbSaveAs.Image"), System.Drawing.Image)
        Me.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSaveAs.Name = "tsbSaveAs"
        Me.tsbSaveAs.Size = New System.Drawing.Size(23, 22)
        Me.tsbSaveAs.Text = "Save As..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'cbFontSize
        '
        Me.cbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72", "94", "106"})
        Me.cbFontSize.Name = "cbFontSize"
        Me.cbFontSize.Size = New System.Drawing.Size(121, 25)
        Me.cbFontSize.Text = "9"
        '
        'cbFont
        '
        Me.cbFont.Name = "cbFont"
        Me.cbFont.Size = New System.Drawing.Size(140, 25)
        Me.cbFont.Text = "Microsoft Sans Serif"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAlignLeft
        '
        Me.tsbAlignLeft.Checked = True
        Me.tsbAlignLeft.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAlignLeft.Image = CType(resources.GetObject("tsbAlignLeft.Image"), System.Drawing.Image)
        Me.tsbAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlignLeft.Name = "tsbAlignLeft"
        Me.tsbAlignLeft.Size = New System.Drawing.Size(23, 22)
        Me.tsbAlignLeft.Text = "Align text to the left"
        '
        'tsbAlignCenter
        '
        Me.tsbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAlignCenter.Image = CType(resources.GetObject("tsbAlignCenter.Image"), System.Drawing.Image)
        Me.tsbAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlignCenter.Name = "tsbAlignCenter"
        Me.tsbAlignCenter.Size = New System.Drawing.Size(23, 22)
        Me.tsbAlignCenter.Text = "Align text to the center"
        '
        'tsbAlignRight
        '
        Me.tsbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAlignRight.Image = CType(resources.GetObject("tsbAlignRight.Image"), System.Drawing.Image)
        Me.tsbAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlignRight.Name = "tsbAlignRight"
        Me.tsbAlignRight.Size = New System.Drawing.Size(23, 22)
        Me.tsbAlignRight.Text = "Align text to the right"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBold
        '
        Me.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBold.Image = CType(resources.GetObject("tsbBold.Image"), System.Drawing.Image)
        Me.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBold.Name = "tsbBold"
        Me.tsbBold.Size = New System.Drawing.Size(23, 22)
        Me.tsbBold.Text = "Bold"
        '
        'tsbItalic
        '
        Me.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbItalic.Image = CType(resources.GetObject("tsbItalic.Image"), System.Drawing.Image)
        Me.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbItalic.Name = "tsbItalic"
        Me.tsbItalic.Size = New System.Drawing.Size(23, 22)
        Me.tsbItalic.Text = "Italic"
        '
        'tsbUnderline
        '
        Me.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbUnderline.Image = CType(resources.GetObject("tsbUnderline.Image"), System.Drawing.Image)
        Me.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUnderline.Name = "tsbUnderline"
        Me.tsbUnderline.Size = New System.Drawing.Size(23, 22)
        Me.tsbUnderline.Text = "Underline"
        '
        'tsbStrikethrough
        '
        Me.tsbStrikethrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbStrikethrough.Image = CType(resources.GetObject("tsbStrikethrough.Image"), System.Drawing.Image)
        Me.tsbStrikethrough.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStrikethrough.Name = "tsbStrikethrough"
        Me.tsbStrikethrough.Size = New System.Drawing.Size(23, 22)
        Me.tsbStrikethrough.Text = "Strikethrough"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'bTColor
        '
        Me.bTColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bTColor.Image = CType(resources.GetObject("bTColor.Image"), System.Drawing.Image)
        Me.bTColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bTColor.Name = "bTColor"
        Me.bTColor.Size = New System.Drawing.Size(23, 22)
        Me.bTColor.Text = "Text Color"
        Me.bTColor.ToolTipText = "Change the Color of the selected Text."
        '
        'bBackColor
        '
        Me.bBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bBackColor.Image = CType(resources.GetObject("bBackColor.Image"), System.Drawing.Image)
        Me.bBackColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bBackColor.Name = "bBackColor"
        Me.bBackColor.Size = New System.Drawing.Size(23, 22)
        Me.bBackColor.Text = "Background Color"
        '
        'pdPrint
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.lStatus, Me.lLength, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 378)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(594, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel2.Text = "Last Action:"
        '
        'lStatus
        '
        Me.lStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lStatus.Name = "lStatus"
        Me.lStatus.Size = New System.Drawing.Size(318, 17)
        Me.lStatus.Spring = True
        Me.lStatus.Text = "None"
        '
        'lLength
        '
        Me.lLength.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lLength.Name = "lLength"
        Me.lLength.Size = New System.Drawing.Size(56, 17)
        Me.lLength.Text = "Length: 0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(136, 17)
        Me.ToolStripStatusLabel1.Text = "Using NoteyWrite 1.0.2.2"
        '
        'rtbMain
        '
        Me.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMain.Location = New System.Drawing.Point(0, 50)
        Me.rtbMain.Name = "rtbMain"
        Me.rtbMain.Size = New System.Drawing.Size(594, 328)
        Me.rtbMain.TabIndex = 6
        Me.rtbMain.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 400)
        Me.Controls.Add(Me.rtbMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tsFormatting)
        Me.Controls.Add(Me.tsTools)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 160)
        Me.Name = "Form1"
        Me.Text = "NoteyWrite - Untitled"
        Me.tsTools.ResumeLayout(False)
        Me.tsTools.PerformLayout()
        Me.tsFormatting.ResumeLayout(False)
        Me.tsFormatting.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsTools As ToolStrip
    Friend WithEvents ddbFile As ToolStripDropDownButton
    Friend WithEvents bNew As ToolStripMenuItem
    Friend WithEvents bOpen As ToolStripMenuItem
    Friend WithEvents bSave As ToolStripMenuItem
    Friend WithEvents bSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents bPageSetup As ToolStripMenuItem
    Friend WithEvents bPrint As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents bExit As ToolStripMenuItem
    Friend WithEvents ddbEdit As ToolStripDropDownButton
    Friend WithEvents ddbView As ToolStripDropDownButton
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents psdPageSetup As PageSetupDialog
    Friend WithEvents pdPrintD As PrintDialog
    Friend WithEvents bUndo As ToolStripMenuItem
    Friend WithEvents bRedo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents bCut As ToolStripMenuItem
    Friend WithEvents bCopy As ToolStripMenuItem
    Friend WithEvents bPaste As ToolStripMenuItem
    Friend WithEvents bDelete As ToolStripMenuItem
    Friend WithEvents bSelectAll As ToolStripMenuItem
    Friend WithEvents tsFormatting As ToolStrip
    Friend WithEvents tsbNew As ToolStripButton
    Public WithEvents sfdSave As SaveFileDialog
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents tsbOpen As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbSaveAs As ToolStripButton
    Friend WithEvents cbFontSize As ToolStripComboBox
    Public WithEvents cbFont As ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbAlignLeft As ToolStripButton
    Friend WithEvents tsbAlignCenter As ToolStripButton
    Friend WithEvents tsbAlignRight As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbBold As ToolStripButton
    Friend WithEvents tsbItalic As ToolStripButton
    Friend WithEvents tsbUnderline As ToolStripButton
    Friend WithEvents tsbStrikethrough As ToolStripButton
    Friend WithEvents bZoomOut As ToolStripMenuItem
    Friend WithEvents bZoomIn As ToolStripMenuItem
    Friend WithEvents bResetZoom As ToolStripMenuItem
    Friend WithEvents bAbout As ToolStripMenuItem
    Friend WithEvents bFullscreen As ToolStripMenuItem
    Friend WithEvents bChangelog As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents bWordWrap As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents bFindReplace As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents bTColor As ToolStripButton
    Friend WithEvents cdColor As ColorDialog
    Friend WithEvents lLength As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents bBackColor As ToolStripButton
    Friend WithEvents cdBackColor As ColorDialog
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents bRawEdit As ToolStripMenuItem
    Friend WithEvents bWebBrowser As ToolStripMenuItem
    Public WithEvents rtbMain As RichTextBoxPrint.RichTextBoxPrintCtrl
End Class
