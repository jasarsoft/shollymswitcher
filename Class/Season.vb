Imports System.IO

Public Class Season
    Inherits Switcher

    Private _name As String
    Private _path As String
    Private _lenght As Integer
    Private _list As List(Of String)

    Public Sub New()
        _lenght = 0
        _name = Nothing
        _path = Nothing
        _list = New List(Of String)
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
            _path = _patch.Path & Slash & _name & Slash & FolderData
        End Set
    End Property

    Public ReadOnly Property Path As String
        Get
            Return _path
        End Get
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

    Public Function Read() As Boolean
        Dim msgText As String
        Dim msgTitle As New Title()

        _lenght = 0
        _list.Clear()

        If _patch.Check() Then
            Dim dirList As String()
            dirList = Directory.GetDirectories(_patch.Path)

            For Each dirName As String In dirList
                Dim dirInfo As New DirectoryInfo(dirName)

                _lenght += 1
                _list.Add(dirInfo.Name)
            Next

            If _lenght = 0 Then
                msgText = "The selected patch does not contain any sesaon." & Environment.NewLine
                msgText &= "Shollym Switcher is not installed properly or is damaged."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            'Success read
            Return True
        End If

        Return False
    End Function

    Public Function Save() As Boolean
        
        If _patch.Check() And _season.Check() Then
            Try
                My.Computer.FileSystem.CopyDirectory(_path, "..\", True)
                Return True
            Catch ex As Exception
                Dim msgText As String
                Dim msgTitle As New Title()

                msgText = "Data on the selected patch and season is not saved." & Environment.NewLine
                msgText &= "Shollym Switcher does not have administrative privileges."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If

        Return False
    End Function

    Public Function Check() As Boolean
        
        If Not Directory.Exists(_path) Then
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
