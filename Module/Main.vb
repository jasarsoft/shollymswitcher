Public Module Main

    Public _edit As Edit

    <STAThread()> _
    Public Function Main(ByVal cmdArgs() As String) As Integer

        If cmdArgs.Length > 0 Then
            Dim _about As New About()
            Dim msgTitle As New Title()

            MessageBox.Show(_about.Title & " does not accept arguments.", msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FormMain)

        Return 1
    End Function

    Sub New()
        _edit = New Edit()
    End Sub
End Module
