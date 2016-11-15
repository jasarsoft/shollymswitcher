Imports System.IO

Public Class Patch
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

    Public ReadOnly Property List As List(Of String)
        Get
            Return _list
        End Get
    End Property

    Public ReadOnly Property Lenght As Integer
        Get
            Return _lenght
        End Get
    End Property

    Public ReadOnly Property Folder As String
        Get
            Return FolderApp & Slash & FolderPatch
        End Get
    End Property


    Public Function Read() As Boolean
        Dim msgText As String
        Dim msgTitle As New Title()

        _lenght = 0
        _list.Clear()

        If Directory.Exists(Folder) Then
            For Each dirName As String In Directory.GetDirectories(Folder)
                Dim dirInfo As New DirectoryInfo(dirName)

                _list.Add(dirInfo.Name)
                _lenght += 1 '_lenght = _lenght + 1; _lenght++; ++_lenght;
            Next

            If _lenght = 0 Then
                msgText = "In the main directory there is no patch." & Environment.NewLine
                msgText &= "Switcher is not installed properly or is damaged."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            'Success read
            Return True
        Else
            msgText = "The main patch directory does not exist." & Environment.NewLine
            msgText &= "Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return False
    End Function

    Public Function Save() As Boolean
        Dim dirPath As String

        dirPath = FolderApp & Slash & FolderPatch & Slash & _name

        If Directory.Exists(dirPath) Then
            Return True
        End If

        Dim msgText As String
        Dim msgTitle As New Title()

        msgText = "The selected patch does not exist." & Environment.NewLine
        msgText &= "Shollym Switcher is not installed properly or is damaged."

        MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Return False
    End Function

    Public Function Check() As Boolean
        Dim dirPath As String

        dirPath = FolderApp & Slash & FolderPatch & Slash & _name

        If Not Directory.Exists(dirPath) Then
            Dim msgText As String
            Dim msgTitle As New Title()

            msgText = "The selected patch form the list does not exist." & Environment.NewLine
            msgText &= "Shollym Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

End Class
