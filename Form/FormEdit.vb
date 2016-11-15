Imports System.IO
Imports System.Text.RegularExpressions

Public Class FormEdit

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMain.Enabled = True
        FormMain.Refresh()
        FormMain.buttonPlay.Focus()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Me.Close()
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim index As Integer
        Dim msgText As String
        Dim msgTitle As New Title()
        Dim _settings As New Settings()

        _settings.Read()
        _edit.Name = Me.textNew.Text

        If _edit.Name.Length < 5 Then
            msgText = "The name is to short, can not be less than 5 characters."
            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim regexMatch As Match

            regexMatch = Regex.Match(_edit.Name, "^[a-zA-Z0-9-.\s]+$", RegexOptions.IgnoreCase)
            If Not regexMatch.Success Then
                msgText = "Name can only contain numbers and uppercase and lowercase letters."
                MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If String.Compare(Me.textOld.Text, _edit.Name, True) = 0 Then
                msgText = "The new name is the same as the old name."
                MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        If _edit.Patch Then
            index = FormMain.comboPatch.SelectedIndex

            Try
                My.Computer.FileSystem.RenameDirectory("patches\" & Me.textOld.Text, _edit.Name)
            Catch ex As Exception
                msgText = "The name patch can not be renamed." & Environment.NewLine
                msgText &= "Switcher or no administrative privileges" & Environment.NewLine
                msgText &= "or the main folder used by a third party."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If String.Compare(_settings.Patch, Me.textOld.Text, True) = 0 Then
                _settings.Patch = _edit.Name
                _settings.Write()
            End If

            Me.textOld.Text = _edit.Name
            FormMain.comboPatch.Items.Insert(index, _edit.Name)
            FormMain.comboPatch.SelectedItem = FormMain.comboPatch.Items.Item(index)
            FormMain.comboPatch.Items.Remove(FormMain.comboPatch.Items.Item(index + 1))
        ElseIf _edit.Season Then
            index = FormMain.comboSeason.SelectedIndex

            Try
                My.Computer.FileSystem.RenameDirectory("patches\" & FormMain.comboPatch.Text & "\" & Me.textOld.Text, _edit.Name)
            Catch ex As Exception
                msgText = "The name season can not be renamed." & Environment.NewLine
                msgText &= "Switcher or no administrative privileges" & Environment.NewLine
                msgText &= "or the main folder used by a third party."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If String.Compare(_settings.Season, Me.textOld.Text, True) = 0 Then
                _settings.Season = _edit.Name
                _settings.Write()
            End If

            Me.textOld.Text = _edit.Name
            FormMain.comboSeason.Items.Insert(index, _edit.Name)
            FormMain.comboSeason.SelectedItem = FormMain.comboSeason.Items.Item(index)
            FormMain.comboSeason.Items.Remove(FormMain.comboSeason.Items.Item(index + 1))
        ElseIf _edit.Gameplay Then
            index = FormMain.comboGameplay.SelectedIndex

            Try
                My.Computer.FileSystem.RenameDirectory("patches\" & FormMain.comboPatch.Text & "\" & FormMain.comboSeason.Text & "\gameplay\" & Me.textOld.Text, _edit.Name)
            Catch ex As Exception
                msgText = "The name gameplay can not be renamed." & Environment.NewLine
                msgText &= "Switcher or no administrative privileges" & Environment.NewLine
                msgText &= "or the main folder used by a third party."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If String.Compare(_settings.Gameplay, Me.textOld.Text) = 0 Then
                _settings.Gameplay = _edit.Name
                _settings.Write()
            End If

            Me.textOld.Text = _edit.Name
            FormMain.comboGameplay.Items.Insert(index, _edit.Name)
            FormMain.comboGameplay.SelectedItem = FormMain.comboGameplay.Items.Item(index)
            FormMain.comboGameplay.Items.Remove(FormMain.comboGameplay.Items.Item(index + 1))
        End If

        msgText = "Edit the name is complete."
        MessageBox.Show(msgText, msgTitle.Info, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub FormEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class