Imports System.IO

Public NotInheritable Class Tools

    Private Structure FileName
        Public Const KITSERVER As String = "kitsettings.exe"
        Public Const SETTINGS As String = "settings.exe"
    End Structure

    Private Structure FolderName
        Public Const PES6 As String = "..\"
        Public Const KITSERVER As String = PES6 & "kitserver\"
    End Structure

    Public Sub Kitserver()
        Dim path As String = FolderName.KITSERVER & FileName.KITSERVER

        If File.Exists(path) Then
            Dim proc As New ProcessStartInfo()

            proc.FileName = FileName.KITSERVER
            proc.WorkingDirectory = FolderName.KITSERVER

            Process.Start(proc)
        Else
            Dim msgText As String
            Dim msgTitle As New Title()
            Dim msgResult As DialogResult

            msgText = "Kitserver 6 Settings application does not exist in Kitserver directory." & Environment.NewLine
            msgText &= "Do you want to download this application for editing kitserver settings?"

            msgResult = MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/jasarsoft/kitsettings/releases")
            End If
        End If
    End Sub

    Public Sub Settings()
        Dim path As String = FolderName.PES6 & FileName.SETTINGS

        If File.Exists(path) Then
            Dim proc As New ProcessStartInfo()

            proc.FileName = FileName.SETTINGS
            proc.WorkingDirectory = FolderName.PES6

            Process.Start(proc)
        Else
            Dim pesPath As String
            Dim msgText As String
            Dim msgTitle As New Title()


            msgText = "PES6 Settings application does not exist in main directory." & Environment.NewLine
            pesPath = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\KONAMIPES6\PES6", "installdir", Nothing)

            If File.Exists(pesPath & "\" & FileName.SETTINGS) Then
                Dim msgResult As DialogResult

                msgText &= "Do you want to run the Settings application of the original game?"
                msgResult = MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If msgResult = DialogResult.Yes Then
                    Process.Start(pesPath & "\" & FileName.SETTINGS)
                End If
            Else
                msgText &= "Shollym Switcher can not find the Settings application."
                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class
