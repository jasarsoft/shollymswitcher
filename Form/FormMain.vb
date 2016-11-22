Public Class FormMain

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgText As String
        Dim msgTitle As New Title()
        Dim _settings As New Settings()

        Me.comboPatch.Enabled = False
        Me.comboSeason.Enabled = False
        Me.comboGameplay.Enabled = False

        'Read Patch
        If _patch.Read() Then
            Me.comboPatch.Items.Clear()
            Me.comboPatch.Enabled = True

            For Each name As String In _patch.List
                Me.comboPatch.Items.Add(name)
            Next
        Else
            Exit Sub
        End If

        'Read Settings
        If _settings.Read() Then
            _patch.Name = _settings.Patch
            _season.Name = _settings.Season
            _gameplay.Name = _settings.Gameplay
        Else
            msgText = "Shollym Switcher is not set, please select the patch" & Environment.NewLine
            msgText &= "and then select the season and gameplay this season."

            MessageBox.Show(msgText, msgTitle.Info, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        'Load Patch
        If Me.comboPatch.Items.Contains(_patch.Name) Then
            Me.comboPatch.SelectedIndex = Me.comboPatch.Items.IndexOf(_patch.Name)
        Else
            msgText = "Patch the stored settings do not exist in the swithcer." & Environment.NewLine
            msgText &= "The application will make a copy of those files when saving."

            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Load Season
        If Me.comboSeason.Items.Contains(_season.Name) Then
            Me.comboSeason.Enabled = True
            Me.comboSeason.SelectedIndex = Me.comboSeason.Items.IndexOf(_season.Name)
        Else
            msgText = "Season the stored settings do not exist in the swithcer." & Environment.NewLine
            msgText &= "The application will make a copy of those files when saving."

            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Load Gameplay
        If Me.comboGameplay.Items.Contains(_gameplay.Name) Then
            Me.comboGameplay.Enabled = True
            Me.comboGameplay.SelectedIndex = Me.comboGameplay.Items.IndexOf(_gameplay.Name)
        Else
            msgText = "Gameplay the stored settings do not exist in the swithcer." & Environment.NewLine
            msgText &= "The application will make a copy of those files when saving."

            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Me.buttonPlay.Focus()
    End Sub

    Private Sub ComboPatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPatch.SelectedIndexChanged
        _patch.Name = Me.comboPatch.Text

        If _edit.Patch Then
            Me.comboSeason.Refresh()
            Exit Sub
        End If

        If _patch.Check() Then
            Me.comboSeason.Items.Clear()
            Me.comboGameplay.Items.Clear()
            Me.comboGameplay.Enabled = False

            Me.pictureLogo.Image = My.Resources.logo

            If Not Me.comboSeason.Enabled Then
                Me.comboSeason.Enabled = True
            End If

            If _season.Read() Then
                For Each name As String In _season.List
                    Me.comboSeason.Items.Add(name)
                Next
            End If
        End If
    End Sub

    Private Sub ComboSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSeason.SelectedIndexChanged
        _season.Name = Me.comboSeason.Text

        If _edit.Season Then
            Me.comboGameplay.Refresh()
            Exit Sub
        End If

        If _season.Check() Then
            Me.comboGameplay.Items.Clear()

            If _logo.Read() Then
                Me.pictureLogo.Load(_logo.Path)
            End If

            If Not Me.comboGameplay.Enabled Then
                Me.comboGameplay.Enabled = True
            End If

            If _gameplay.Read() Then
                For Each name As String In _gameplay.List
                    Me.comboGameplay.Items.Add(name)
                Next
            End If
        End If
    End Sub

    Private Sub comboGameplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboGameplay.SelectedIndexChanged
        _gameplay.Name = Me.comboGameplay.Text

        If _edit.Gameplay Then
            Me.comboGameplay.Refresh()
            Exit Sub
        End If

        If Not _gameplay.Check() Then
            Me.comboGameplay.SelectedIndex = -1
        End If

    End Sub



    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim msgText As String
        Dim msgTitle As New Title()
        Dim _settings As New Settings()

        If Me.comboPatch.SelectedIndex < 0 Or Me.comboSeason.SelectedIndex < 0 Or Me.comboGameplay.SelectedIndex < 0 Then
            msgText = "You have not selected parameters." & Environment.NewLine
            msgText &= "Save the settings can not be done."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not _patch.Check() And Not _season.Check() Then
            Exit Sub
        End If

        If _settings.Read() Then
            If String.Compare(_settings.Patch, _patch.Name, True) <> 0 Or _
               String.Compare(_settings.Season, _season.Name, True) <> 0 Then

                If Not _season.Save() Then
                    Exit Sub
                End If
            End If

            If String.Compare(_settings.Patch, _patch.Name, True) <> 0 Or _
               String.Compare(_settings.Season, _season.Name, True) <> 0 Or _
               String.Compare(_settings.Gameplay, _gameplay.Name, True) <> 0 Then

                _gameplay.Backup(_settings.Patch, _settings.Season, _settings.Gameplay)
                If Not _gameplay.Save() Then
                    Exit Sub
                End If
            End If
        Else
            If _gameplay.CheckOld() Then
                _gameplay.Backup(_settings.Patch, _settings.Season, _settings.Gameplay)
            End If

            If Not _season.Save() Then
                Exit Sub
            End If

            If Not _gameplay.Save() Then
                Exit Sub
            End If

        End If

        _settings.Patch = _patch.Name
        _settings.Season = _season.Name
        _settings.Gameplay = _gameplay.Name

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


    Private Sub menuMain_Click(sender As Object, e As EventArgs) Handles menuMain.Click
        If Me.comboPatch.SelectedIndex >= 0 Then
            Me.menuEditItemPatch.Enabled = True
        Else
            Me.menuEditItemPatch.Enabled = False
        End If

        'Season
        If Me.comboSeason.SelectedIndex >= 0 Then
            Me.menuEditItemLogo.Enabled = True
            Me.menuEditItemSeason.Enabled = True
        Else
            Me.menuEditItemLogo.Enabled = False
            Me.menuEditItemSeason.Enabled = False
        End If

        'Gameplay
        If Me.comboGameplay.SelectedIndex >= 0 Then
            Me.menuEditItemGameplay.Enabled = True
        Else
            Me.menuEditItemGameplay.Enabled = False
        End If
    End Sub


    Private Sub MenuEditItemPatch_Click(sender As Object, e As EventArgs) Handles menuEditItemPatch.Click
        If menuEditItemPatch.Enabled Then
            Dim editForm As New FormEdit()

            Call _edit.Reset()
            _edit.Patch = True

            'Me.Hide()
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

            'Me.Hide()
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

            'Me.Hide()
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

        'Me.Hide()
        Me.Enabled = False

        _aboutForm.Show()
        _aboutForm.buttonClose.Focus()
    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub menuEditItemLogo_Click(sender As Object, e As EventArgs) Handles menuEditItemLogo.Click
        Dim _logoForm As New FormLogo()

        'Me.Hide()
        Me.Enabled = False

        If _logo.Read() Then
            _logoForm.textPath.Text = _logo.Path
        End If

        _logoForm.Show()
        _logoForm.buttonSelect.Focus()

    End Sub

   
End Class
