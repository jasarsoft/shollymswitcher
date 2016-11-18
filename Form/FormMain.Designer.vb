<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.menuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileItemPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileItemSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFileItemRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFileItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditItemPatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditItemSeason = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditItemGameplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEditItemLogo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuToolsItemKitserver = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuToolsItemSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpItemReadme = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpItemFacebook = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpItemDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpItemSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.menuHelpItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelPatch = New System.Windows.Forms.Label()
        Me.comboPatch = New System.Windows.Forms.ComboBox()
        Me.comboSeason = New System.Windows.Forms.ComboBox()
        Me.comboGameplay = New System.Windows.Forms.ComboBox()
        Me.labelSeason = New System.Windows.Forms.Label()
        Me.labelGameplay = New System.Windows.Forms.Label()
        Me.labelHorizontalLine = New System.Windows.Forms.Label()
        Me.buttonPlay = New System.Windows.Forms.Button()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.pictureLogo = New System.Windows.Forms.PictureBox()
        Me.menuMain.SuspendLayout()
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemFile, Me.menuItemEdit, Me.menuItemTools, Me.menuItemHelp})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(344, 24)
        Me.menuMain.TabIndex = 2
        Me.menuMain.Text = "MenuMain"
        '
        'menuItemFile
        '
        Me.menuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileItemPlay, Me.menuFileItemSave, Me.menuFileSeparator1, Me.menuFileItemRestart, Me.menuFileSeparator2, Me.menuFileItemExit})
        Me.menuItemFile.Name = "menuItemFile"
        Me.menuItemFile.Size = New System.Drawing.Size(37, 20)
        Me.menuItemFile.Text = "File"
        '
        'menuFileItemPlay
        '
        Me.menuFileItemPlay.Name = "menuFileItemPlay"
        Me.menuFileItemPlay.Size = New System.Drawing.Size(110, 22)
        Me.menuFileItemPlay.Text = "&Play"
        '
        'menuFileItemSave
        '
        Me.menuFileItemSave.Name = "menuFileItemSave"
        Me.menuFileItemSave.Size = New System.Drawing.Size(110, 22)
        Me.menuFileItemSave.Text = "&Save"
        '
        'menuFileSeparator1
        '
        Me.menuFileSeparator1.Name = "menuFileSeparator1"
        Me.menuFileSeparator1.Size = New System.Drawing.Size(107, 6)
        '
        'menuFileItemRestart
        '
        Me.menuFileItemRestart.Name = "menuFileItemRestart"
        Me.menuFileItemRestart.Size = New System.Drawing.Size(110, 22)
        Me.menuFileItemRestart.Text = "&Restart"
        '
        'menuFileSeparator2
        '
        Me.menuFileSeparator2.Name = "menuFileSeparator2"
        Me.menuFileSeparator2.Size = New System.Drawing.Size(107, 6)
        '
        'menuFileItemExit
        '
        Me.menuFileItemExit.Name = "menuFileItemExit"
        Me.menuFileItemExit.Size = New System.Drawing.Size(110, 22)
        Me.menuFileItemExit.Text = "E&xit"
        '
        'menuItemEdit
        '
        Me.menuItemEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditItemPatch, Me.menuEditItemSeason, Me.menuEditItemGameplay, Me.menuEditSeparator1, Me.menuEditItemLogo})
        Me.menuItemEdit.Name = "menuItemEdit"
        Me.menuItemEdit.Size = New System.Drawing.Size(39, 20)
        Me.menuItemEdit.Text = "&Edit"
        '
        'menuEditItemPatch
        '
        Me.menuEditItemPatch.Name = "menuEditItemPatch"
        Me.menuEditItemPatch.Size = New System.Drawing.Size(137, 22)
        Me.menuEditItemPatch.Text = "&Patch"
        '
        'menuEditItemSeason
        '
        Me.menuEditItemSeason.Name = "menuEditItemSeason"
        Me.menuEditItemSeason.Size = New System.Drawing.Size(137, 22)
        Me.menuEditItemSeason.Text = "&Season"
        '
        'menuEditItemGameplay
        '
        Me.menuEditItemGameplay.Name = "menuEditItemGameplay"
        Me.menuEditItemGameplay.Size = New System.Drawing.Size(137, 22)
        Me.menuEditItemGameplay.Text = "&Gameplay"
        '
        'menuEditSeparator1
        '
        Me.menuEditSeparator1.Name = "menuEditSeparator1"
        Me.menuEditSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'menuEditItemLogo
        '
        Me.menuEditItemLogo.Name = "menuEditItemLogo"
        Me.menuEditItemLogo.Size = New System.Drawing.Size(137, 22)
        Me.menuEditItemLogo.Text = "&Logo Image"
        '
        'menuItemTools
        '
        Me.menuItemTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuToolsItemKitserver, Me.menuToolsItemSettings})
        Me.menuItemTools.Name = "menuItemTools"
        Me.menuItemTools.Size = New System.Drawing.Size(48, 20)
        Me.menuItemTools.Text = "&Tools"
        '
        'menuToolsItemKitserver
        '
        Me.menuToolsItemKitserver.Name = "menuToolsItemKitserver"
        Me.menuToolsItemKitserver.Size = New System.Drawing.Size(119, 22)
        Me.menuToolsItemKitserver.Text = "&Kitserver"
        '
        'menuToolsItemSettings
        '
        Me.menuToolsItemSettings.Name = "menuToolsItemSettings"
        Me.menuToolsItemSettings.Size = New System.Drawing.Size(119, 22)
        Me.menuToolsItemSettings.Text = "&Settings"
        '
        'menuItemHelp
        '
        Me.menuItemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpItemReadme, Me.menuHelpItemFacebook, Me.menuHelpItemDownload, Me.menuHelpItemSeparator, Me.menuHelpItemAbout})
        Me.menuItemHelp.Name = "menuItemHelp"
        Me.menuItemHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuItemHelp.Text = "&Help"
        '
        'menuHelpItemReadme
        '
        Me.menuHelpItemReadme.Name = "menuHelpItemReadme"
        Me.menuHelpItemReadme.Size = New System.Drawing.Size(128, 22)
        Me.menuHelpItemReadme.Text = "&Readme"
        '
        'menuHelpItemFacebook
        '
        Me.menuHelpItemFacebook.Name = "menuHelpItemFacebook"
        Me.menuHelpItemFacebook.Size = New System.Drawing.Size(128, 22)
        Me.menuHelpItemFacebook.Text = "&Facebook"
        '
        'menuHelpItemDownload
        '
        Me.menuHelpItemDownload.Name = "menuHelpItemDownload"
        Me.menuHelpItemDownload.Size = New System.Drawing.Size(128, 22)
        Me.menuHelpItemDownload.Text = "&Download"
        '
        'menuHelpItemSeparator
        '
        Me.menuHelpItemSeparator.Name = "menuHelpItemSeparator"
        Me.menuHelpItemSeparator.Size = New System.Drawing.Size(125, 6)
        '
        'menuHelpItemAbout
        '
        Me.menuHelpItemAbout.Name = "menuHelpItemAbout"
        Me.menuHelpItemAbout.Size = New System.Drawing.Size(128, 22)
        Me.menuHelpItemAbout.Text = "&About"
        '
        'labelPatch
        '
        Me.labelPatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelPatch.Location = New System.Drawing.Point(12, 151)
        Me.labelPatch.Name = "labelPatch"
        Me.labelPatch.Size = New System.Drawing.Size(95, 21)
        Me.labelPatch.TabIndex = 3
        Me.labelPatch.Text = "Select Patch:"
        Me.labelPatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboPatch
        '
        Me.comboPatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.comboPatch.FormattingEnabled = True
        Me.comboPatch.Location = New System.Drawing.Point(112, 151)
        Me.comboPatch.Name = "comboPatch"
        Me.comboPatch.Size = New System.Drawing.Size(220, 21)
        Me.comboPatch.TabIndex = 6
        '
        'comboSeason
        '
        Me.comboSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSeason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.comboSeason.FormattingEnabled = True
        Me.comboSeason.Location = New System.Drawing.Point(112, 178)
        Me.comboSeason.Name = "comboSeason"
        Me.comboSeason.Size = New System.Drawing.Size(220, 21)
        Me.comboSeason.TabIndex = 7
        '
        'comboGameplay
        '
        Me.comboGameplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboGameplay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.comboGameplay.FormattingEnabled = True
        Me.comboGameplay.Location = New System.Drawing.Point(112, 205)
        Me.comboGameplay.Name = "comboGameplay"
        Me.comboGameplay.Size = New System.Drawing.Size(220, 21)
        Me.comboGameplay.TabIndex = 8
        '
        'labelSeason
        '
        Me.labelSeason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelSeason.Location = New System.Drawing.Point(12, 178)
        Me.labelSeason.Name = "labelSeason"
        Me.labelSeason.Size = New System.Drawing.Size(95, 21)
        Me.labelSeason.TabIndex = 4
        Me.labelSeason.Text = "Select Season:"
        Me.labelSeason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelGameplay
        '
        Me.labelGameplay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelGameplay.Location = New System.Drawing.Point(12, 205)
        Me.labelGameplay.Name = "labelGameplay"
        Me.labelGameplay.Size = New System.Drawing.Size(94, 21)
        Me.labelGameplay.TabIndex = 5
        Me.labelGameplay.Text = "Select Gameplay:"
        Me.labelGameplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelHorizontalLine
        '
        Me.labelHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelHorizontalLine.Location = New System.Drawing.Point(12, 238)
        Me.labelHorizontalLine.Name = "labelHorizontalLine"
        Me.labelHorizontalLine.Size = New System.Drawing.Size(320, 2)
        Me.labelHorizontalLine.TabIndex = 9
        '
        'buttonPlay
        '
        Me.buttonPlay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.buttonPlay.Location = New System.Drawing.Point(113, 243)
        Me.buttonPlay.Name = "buttonPlay"
        Me.buttonPlay.Size = New System.Drawing.Size(219, 40)
        Me.buttonPlay.TabIndex = 1
        Me.buttonPlay.Text = "PLAY PATCH"
        Me.buttonPlay.UseVisualStyleBackColor = True
        '
        'buttonSave
        '
        Me.buttonSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.buttonSave.Location = New System.Drawing.Point(12, 243)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(95, 40)
        Me.buttonSave.TabIndex = 10
        Me.buttonSave.Text = "SAVE"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'pictureLogo
        '
        Me.pictureLogo.Image = Global.Jasarsoft.ShollymSwitcher.My.Resources.Resources.logo
        Me.pictureLogo.Location = New System.Drawing.Point(12, 36)
        Me.pictureLogo.Name = "pictureLogo"
        Me.pictureLogo.Size = New System.Drawing.Size(320, 100)
        Me.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureLogo.TabIndex = 1
        Me.pictureLogo.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 295)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.buttonPlay)
        Me.Controls.Add(Me.labelHorizontalLine)
        Me.Controls.Add(Me.labelGameplay)
        Me.Controls.Add(Me.labelSeason)
        Me.Controls.Add(Me.comboGameplay)
        Me.Controls.Add(Me.comboSeason)
        Me.Controls.Add(Me.comboPatch)
        Me.Controls.Add(Me.labelPatch)
        Me.Controls.Add(Me.pictureLogo)
        Me.Controls.Add(Me.menuMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.menuMain
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shollym Multi-Patch Switcher"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents labelPatch As System.Windows.Forms.Label
    Friend WithEvents comboPatch As System.Windows.Forms.ComboBox
    Friend WithEvents comboSeason As System.Windows.Forms.ComboBox
    Friend WithEvents comboGameplay As System.Windows.Forms.ComboBox
    Friend WithEvents labelSeason As System.Windows.Forms.Label
    Friend WithEvents labelGameplay As System.Windows.Forms.Label
    Friend WithEvents labelHorizontalLine As System.Windows.Forms.Label
    Friend WithEvents buttonPlay As System.Windows.Forms.Button
    Friend WithEvents buttonSave As System.Windows.Forms.Button
    Friend WithEvents menuItemEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileItemPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileItemSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuFileItemRestart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuFileItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditItemPatch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditItemSeason As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditItemGameplay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuEditItemLogo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuToolsItemKitserver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuToolsItemSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpItemReadme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpItemFacebook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpItemDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpItemSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuHelpItemAbout As System.Windows.Forms.ToolStripMenuItem

End Class
