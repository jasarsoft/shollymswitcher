Imports System.IO

Public Class Logo
    Inherits Switcher

    Private _path As String

    Public ReadOnly Property Path As String
        Get
            Return _path
        End Get
    End Property


    Public Function Read() As Boolean
        Dim filePath As String

        filePath = _patch.Path & Slash & _season.Name & Slash
        filePath &= FolderImage & Slash & FileLogo

        If File.Exists(filePath) Then
            _path = filePath
            Return True
        End If

        Return False
    End Function

    Public Function Copy(ByVal fileName As String) As Boolean
        
        If _patch.Check() And _season.Check() Then
            Dim filePath As String

            filePath = _patch.Path & Slash & _season.Name & Slash
            filePath &= FolderImage & Slash & FileLogo
            Try
                My.Computer.FileSystem.CopyFile(fileName, filePath, True)
                Return True
            Catch ex As Exception
                Dim msgText As String
                Dim msgTitle As New Title()

                msgText = "The selected image can not be added to the switcher." & Environment.NewLine
                msgText &= "Shollym Switcher does not have administrative privileges."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Return False
    End Function

End Class
