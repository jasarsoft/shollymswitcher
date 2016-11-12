Imports System.IO

Public NotInheritable Class Pes

    Private Const _path As String = "..\"

    Private Const _pes6 As String = "PES6.exe"


    Public ReadOnly Property PesApp As String
        Get
            Return _path & _pes6
        End Get
    End Property

    Public Sub PES6()

        If File.Exists(PesApp) Then
            Dim proc As New ProcessStartInfo()

            proc.FileName = _pes6
            proc.WorkingDirectory = _path

            Try
                Process.Start(proc)
            Catch ex As Exception
                Dim msgText As String
                Dim msgTitle As New Title()

                msgText = "PES 6 application is not running." & Environment.NewLine
                msgText &= "Stopped of the unknown, and try again."

                MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            Dim msgText As String
            Dim msgTitle As New Title()

            msgText = "PES 6 application does not exist in the root directory." & Environment.NewLine
            msgText &= "Path is not installed properly or is damaged by other parties."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class
