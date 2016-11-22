Imports System.IO

Public Class FormLogo

    Private Sub FormLogo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'For Each _form As Form In Application.OpenForms
        '    If _form.Name = FormMain.Name Then
        '        '_form.Show()
        '        _form.Enabled = True
        '    End If
        'Next
        _form.Enabled = True
    End Sub

    Private Sub buttonSelect_Click(sender As Object, e As EventArgs) Handles buttonSelect.Click
        Dim fileDialog As New OpenFileDialog()

        fileDialog.Title = "Select logo image"
        fileDialog.Filter = "Portable Network Graphics (PNG)|*.png"
        fileDialog.CheckFileExists = True
        fileDialog.CheckPathExists = True
        fileDialog.RestoreDirectory = True
        fileDialog.SupportMultiDottedExtensions = False

        If fileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.textPath.Text = fileDialog.FileName
        End If
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim msgText As String
        Dim msgTitle As New Title()

        If Not File.Exists(Me.textPath.Text) Then
            msgText = "The selected image does not exist, select the logo agin!"
            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If _logo.Copy(Me.textPath.Text) Then
            If _logo.Read() Then
                _form.pictureLogo.Load(_logo.Path)
            End If
            msgText = "The new logo for the selected patch and the sesaon is set."
            MessageBox.Show(msgText, msgTitle.Info, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class