Imports System.IO

Public Class Season
    Inherits Switcher

    Private _name As String
    Private _lenght As Integer
    Private _list As List(Of String)

    Public Sub New()
        _lenght = 0
        _name = Nothing
        _list = New List(Of String)
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public ReadOnly Property Lenght As Integer
        Get
            Return _lenght
        End Get
    End Property

    Public ReadOnly Property List As List(Of String)
        Get
            Return _list
        End Get
    End Property

    Public Function Read(ByVal patch As String) As Boolean
        Dim dirPath As String
        Dim msgText As String
        Dim msgTitle As New Title()

        _lenght = 0
        _list.Clear()
        dirPath = FolderApp & Slash & FolderPatch & Slash & patch
        
        If Directory.Exists(dirPath) Then
            For Each dirName As String In Directory.GetDirectories(dirPath)
                Dim dirInfo As New DirectoryInfo(dirName)

                _lenght += 1
                _list.Add(dirInfo.Name)
            Next

            If _lenght = 0 Then
                msgText = "For the selected patch there is not a season." & Environment.NewLine
                msgText &= "Shollym Switcher is not installed properly or is damaged."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            'Success read
            Return True
        Else
            msgText = "The selected patch does not exist." & Environment.NewLine
            msgText &= "Shollym Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return False
    End Function

    Public Function Save(ByVal patch As String)
        Dim dirPath As String
        Dim msgText As String
        Dim msgTitle As New Title()

        dirPath = FolderApp & Slash & FolderPatch & Slash
        dirPath &= patch & Slash & _name & Slash & FolderData

        If Not Directory.Exists(dirPath) Then
            msgText = "No data is available on the selected patch and season."
            msgText &= "Shollym Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Try
            My.Computer.FileSystem.CopyDirectory(dirPath, "..\", True)
            Return True
        Catch ex As Exception
            msgText = "Data on the selected patch and season is not saved." & Environment.NewLine
            msgText &= "Shollym Switcher does not have administrative privileges."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function Check(ByVal patch As String)
        Dim dirPath As String

        dirPath = FolderApp & Slash & FolderPatch & Slash
        dirPath &= patch & Slash & _name & Slash & FolderData

        If Not Directory.Exists(dirPath) Then
            Dim msgText As String
            Dim msgTitle As New Title()

            msgText = "The selected season form the list does not exist." & Environment.NewLine
            msgText &= "Shollym Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

End Class
