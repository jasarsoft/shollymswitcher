Public Class FormMain

    Private _patch As Patch
    Private _season As Season
    Private _gameplay As Gameplay
    Private _settings As Settings

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _patch = New Patch()
        _season = New Season()
        _gameplay = New Gameplay()
        _settings = New Settings()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgText As String
        Dim msgTitle As New Title()

        Me.comboPatch.Enabled = False
        Me.comboSeason.Enabled = False
        Me.comboGameplay.Enabled = False

        If _patch.Read() Then
            Me.comboPatch.Enabled = True
            Me.comboPatch.Items.Clear()
            For Each name As String In _patch.List
                Me.comboPatch.Items.Add(name)
            Next
        Else
            msgText = "The main folder does not exist for placing patches." & Environment.NewLine
            msgText &= "Please reinstall the correct Shollym Patch and try again."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not _settings.Read() Then
            msgText = "Shollym Switcher is not set, please select the patch" & Environment.NewLine
            msgText &= "and then select the season and gameplay this season."

            MessageBox.Show(msgText, msgTitle.Info, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Load Patch
        If Me.comboPatch.Items.Contains(_settings.Patch) Then
            _patch.Name = _settings.Patch
            Me.comboPatch.SelectedIndex = Me.comboPatch.Items.IndexOf(_settings.Patch)
        Else
            Call MsgContain()
            Exit Sub
        End If

        'Load Season
        If Me.comboSeason.Items.Contains(_settings.Season) Then
            Me.comboSeason.Enabled = True
            _season.Name = _settings.Season
            Me.comboSeason.SelectedIndex = Me.comboSeason.Items.IndexOf(_settings.Season)
        Else
            Call MsgContain()
            Exit Sub
        End If

        'Load Gameplay
        If Me.comboGameplay.Items.Contains(_settings.Gameplay) Then
            Me.comboGameplay.Enabled = True
            _gameplay.Name = _settings.Gameplay
            Me.comboGameplay.SelectedIndex = Me.comboGameplay.Items.IndexOf(_settings.Gameplay)
        Else
            Call MsgContain()
            Exit Sub
        End If



        'If _settings.Read() Then
        '    If Me.comboPatch.Items.Contains(_settings.Patch) Then
        '        _patch.Name = _settings.Patch
        '        Me.comboPatch.SelectedIndex = Me.comboPatch.Items.IndexOf(_settings.Patch)

        '        'Season
        '        _season.Read(Me.comboPatch.Text)
        '        If Me.comboSeason.Items.Contains(_settings.Season) Then
        '            Me.comboSeason.Enabled = True
        '            Me.comboSeason.SelectedIndex = Me.comboSeason.Items.IndexOf(_settings.Season)
        '            _season.Name = Me.comboSeason.Text

        '            _gameplay.Read(Me.comboPatch.Text, Me.comboSeason.Text)
        '            If Me.comboGameplay.Items.Contains(_settings.Gameplay) Then
        '                Me.comboGameplay.Enabled = True
        '                Me.comboGameplay.SelectedIndex = Me.comboGameplay.Items.IndexOf(_settings.Gameplay)
        '                _gameplay.Name = Me.comboGameplay.Text
        '            End If
        '        Else
        '            msgText = ""
        '        End If
        '    Else
        '        msgText = "Your currently settings does not contain a patch from the list available." & Environment.NewLine
        '        msgText &= "Currently installed the patch will be replaced by a new, if you save settings."

        '        MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    End If
        'Else
        '    msgText = "Shollym Switcher is not set, please select the patch" & Environment.NewLine
        '    msgText &= "and then select the season and gameplay this season."

        '    MessageBox.Show(msgText, msgTitle.Info, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

    End Sub

    Private Sub MsgContain()
        Dim msgText As String
        Dim msgTitle As New Title()

        msgText = "Your currently settings are not compatibile." & Environment.NewLine
        msgText &= "Old patch settings will be replaced with a new."

        MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub


    Private Sub ComboPatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPatch.SelectedIndexChanged

        If _edit.Patch Then Exit Sub
        Me.comboSeason.Items.Clear()
        _season.Read(Me.comboPatch.Text)
        For Each name As String In _season.List
            Me.comboSeason.Items.Add(name)
        Next

        If Not Me.comboSeason.Enabled Then
            Me.comboSeason.Enabled = True
        End If

        Me.comboSeason.Refresh()

    End Sub

    Private Sub ComboSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSeason.SelectedIndexChanged

        If _edit.Season Then Exit Sub
        Me.comboGameplay.Items.Clear()
        _gameplay.Read(Me.comboPatch.Text, Me.comboSeason.Text)
        For Each name As String In _gameplay.List
            Me.comboGameplay.Items.Add(name)
        Next

        If Not Me.comboGameplay.Enabled Then
            Me.comboGameplay.Enabled = True
        End If

        Me.comboGameplay.Refresh()

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim msgText As String
        Dim msgTitle As New Title()

        If Me.comboPatch.SelectedIndex < 0 Or Me.comboSeason.SelectedIndex < 0 Or Me.comboGameplay.SelectedIndex < 0 Then
            msgText = "You have not selected parameters."
            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Save Patch
        If String.Compare(_settings.Patch, Me.comboPatch.Text, True) <> 0 Or _
           String.Compare(_settings.Season, Me.comboSeason.Text, True) <> 0 Then

            If Not _patch.Save(Me.comboPatch.Text, Me.comboSeason.Text) Then
                msgText = "The old patch files can not be changed." & Environment.NewLine
                msgText &= "Switcher does not have administrative privileges" & Environment.NewLine
                msgText &= "or its files are used by a third party software."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            _patch.Name = Me.comboPatch.Text
            _season.Name = Me.comboSeason.Text
            _settings.Patch = Me.comboPatch.Text
            _settings.Season = Me.comboSeason.Text
        End If

        'Save Gameplay
        If String.Compare(_settings.Patch, Me.comboPatch.Text, True) <> 0 Or _
           String.Compare(_settings.Season, Me.comboSeason.Text, True) <> 0 Or _
           String.Compare(_settings.Gameplay, Me.comboGameplay.Text, True) <> 0 Then

            If Not _gameplay.Backup(_patch.Name, _season.Name, _gameplay.Name) Then
                Dim msgResult As DialogResult

                msgText = "Backup old option file can not be created." & Environment.NewLine
                msgText &= "If you continue, the old gameplay will be lost?"

                msgResult = MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If msgResult = DialogResult.No Then
                    Exit Sub
                End If
            End If

            If Not _gameplay.Save(Me.comboPatch.Text, Me.comboSeason.Text, Me.comboGameplay.Text) Then
                msgText = "The old gameplay file can not be changed." & Environment.NewLine
                msgText &= "Switcher does not have administrative privileges" & Environment.NewLine
                msgText &= "or its file using a third party software."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            _gameplay.Name = Me.comboGameplay.Text
            _settings.Gameplay = Me.comboGameplay.Text
        End If

        'Save Settings
        If Not _settings.Write() Then
            msgText = "Settings can not be stored on your HDD!" & Environment.NewLine
            msgText &= "Switcher does not have administrative privileges" & Environment.NewLine
            msgText &= "or settings used by other software, check this out."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        msgText = "The new settings have been successfully saved!"
        MessageBox.Show(msgText, msgTitle.Info, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles buttonPlay.Click
        Dim pes As New Pes()

        Call pes.PES6()
    End Sub


    Private Sub MenuHelpItemReadme_Click(sender As Object, e As EventArgs) Handles menuHelpItemReadme.Click
        Dim help As New Help()

        Call help.Readme()
    End Sub

    Private Sub MenuHelpItemFacebook_Click(sender As Object, e As EventArgs) Handles menuHelpItemFacebook.Click
        Dim help As New Help()

        Call help.Facebook()
    End Sub

    Private Sub MenuHelpItemDownload_Click(sender As Object, e As EventArgs) Handles menuHelpItemDownload.Click
        Dim help As New Help()

        Call help.Download()
    End Sub


    Private Sub MenuToolsItemKitserver_Click(sender As Object, e As EventArgs) Handles menuToolsItemKitserver.Click
        Dim tools As New Tools()

        Call tools.Kitserver()
    End Sub

    Private Sub MenuToolsItemSettings_Click(sender As Object, e As EventArgs) Handles menuToolsItemSettings.Click
        Dim tools As New Tools()

        Call tools.Settings()
    End Sub


    Private Sub MenuItemEdit_Click(sender As Object, e As EventArgs) Handles menuItemEdit.Click
        If Me.comboPatch.Text.Length > 0 Then
            menuEditItemPatch.Enabled = True
            menuEditItemLogo.Enabled = True
        Else
            menuEditItemPatch.Enabled = False
            menuEditItemLogo.Enabled = False
        End If
        If Me.comboSeason.Text.Length > 0 Then
            menuEditItemSeason.Enabled = True
        Else
            menuEditItemSeason.Enabled = False
        End If
        If Me.comboGameplay.Text.Length > 0 Then
            menuEditItemGameplay.Enabled = True
        Else
            menuEditItemGameplay.Enabled = False
        End If
    End Sub

    Private Sub MenuEditItemPatch_Click(sender As Object, e As EventArgs) Handles menuEditItemPatch.Click
        If menuEditItemPatch.Enabled Then
            Dim editForm As New FormEdit()

            Call _edit.Reset()
            _edit.Patch = True
            Me.Enabled = False

            'editForm.Text &= Me.labelPatch.Text.Replace("Select ", "").Replace(":", "")
            editForm.Text &= "Patch"
            editForm.textOld.Text = Me.comboPatch.Text
            editForm.textNew.Text = Me.comboPatch.Text

            editForm.Show()
            editForm.textNew.Focus()
        End If
    End Sub

    Private Sub MenuEditItemSeason_Click(sender As Object, e As EventArgs) Handles menuEditItemSeason.Click
        If menuEditItemSeason.Enabled Then
            Dim editForm As New FormEdit()

            Call _edit.Reset()
            _edit.Season = True
            Me.Enabled = False

            editForm.Text &= "Season"
            editForm.textOld.Text = Me.comboSeason.Text
            editForm.textNew.Text = Me.comboSeason.Text

            editForm.Show()
            editForm.textNew.Focus()
        End If
    End Sub

    Private Sub MenuEditItemGameplay_Click(sender As Object, e As EventArgs) Handles menuEditItemGameplay.Click
        If menuEditItemGameplay.Enabled Then
            Dim editForm As New FormEdit()

            Call _edit.Reset()
            _edit.Gameplay = True
            Me.Enabled = False

            editForm.Text &= "Gameplay"
            editForm.textOld.Text = Me.comboGameplay.Text
            editForm.textNew.Text = Me.comboGameplay.Text

            editForm.Show()
            editForm.textNew.Focus()
        End If
    End Sub

   
    
    Private Sub MenuFileItemPlay_Click(sender As Object, e As EventArgs) Handles menuFileItemPlay.Click
        Call ButtonPlay_Click(sender, e)
    End Sub

    Private Sub MenuFileItemSave_Click(sender As Object, e As EventArgs) Handles menuFileItemSave.Click
        Call ButtonSave_Click(sender, e)
    End Sub

    Private Sub MenuFileItemRestart_Click(sender As Object, e As EventArgs) Handles menuFileItemRestart.Click
        Call FormMain_Load(sender, e)
    End Sub

    Private Sub MenuFileItemExit_Click(sender As Object, e As EventArgs) Handles menuFileItemExit.Click
        Me.Close()
    End Sub

    Private Sub menuHelpItemAbout_Click(sender As Object, e As EventArgs) Handles menuHelpItemAbout.Click
        Dim _aboutForm As New FormAbout()

        Me.Enabled = False
        _aboutForm.Show()
        _aboutForm.buttonClose.Focus()
    End Sub

    
    
End Class
