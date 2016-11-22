Public Module Main

    Public _edit As Edit
    Public _logo As Logo
    Public _form As FormMain
    Public _patch As Patch
    Public _season As Season
    Public _gameplay As Gameplay

    <STAThread()> _
    Public Function Main(ByVal cmdArgs() As String) As Integer

        If cmdArgs.Length > 0 Then
            Dim _about As New About()
            Dim msgTitle As New Title()

            MessageBox.Show(_about.Title & " does not accept arguments.", msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Application.EnableVisualStyles()
        'Application.SetCompatibleTextRenderingDefault(False)
        'Application.Run(New FormMain)
        Application.Run(_form)

        Return 1
    End Function

    Sub New()
        _edit = New Edit()
        _logo = New Logo()
        _form = New FormMain()
        _patch = New Patch()
        _season = New Season()
        _gameplay = New Gameplay()
    End Sub
End Module
