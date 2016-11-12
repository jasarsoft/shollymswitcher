Public Class FormAbout

    Dim _about As About

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _about = New About()
    End Sub

    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.textTitle.Text = _about.Title
        Me.textVersion.Text = _about.Version
        Me.textDeveloper.Text = _about.Developer
        Me.textLicense.Text = _about.License
        Me.textWebsite.Text = _about.Website.Replace("https://", "www.")
        Me.textDescription.Text = _about.Description
    End Sub

    Private Sub TextWebsite_Click(sender As Object, e As EventArgs) Handles textWebsite.Click
        Try
            Process.Start(_about.Website)
        Catch ex As Exception
            Dim msgText As String
            Dim msgTitle As New Title()

            msgText = "The offical website is not open!" & Environment.NewLine
            msgText &= "Link webiste copied to your clipboard."

            My.Computer.Clipboard.SetText(_about.Website)
            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Me.Close()
    End Sub

    Private Sub FormAbout_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMain.Enabled = True
        FormMain.Refresh()
        FormMain.buttonPlay.Focus()
    End Sub
End Class