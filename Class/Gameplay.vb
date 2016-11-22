Imports System.IO

Public NotInheritable Class Gameplay
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
            _path = _patch.Path & Slash & _season.Name & Slash
            _path &= FolderGameplay & Slash & _name & Slash & FileGameplay
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
        _lenght = 0
        _list.Clear()

        If CheckFolder() Then
            Dim dirPath As String
            Dim dirList As String()

            dirPath = _patch.Path & Slash & _season.Name & Slash & FolderGameplay
            dirList = Directory.GetDirectories(dirPath)

            For Each dirName As String In dirList
                Dim dirInfo As New DirectoryInfo(dirName)

                _lenght += 1
                _list.Add(dirInfo.Name)
            Next

            If CheckLenght() Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function Save() As Boolean
        Dim msgText As String
        Dim msgTitle As New Title()
        
        If Check() Then
            If Not Directory.Exists(FolderMyDoc & Slash & FolderSave) Then
                Try
                    Directory.CreateDirectory(FolderMyDoc & Slash & FolderSave)
                Catch ex As Exception
                    msgText = "The save directory could not be created." & Environment.NewLine
                    msgText &= "Shollym Switcher does not have administrative privileges."

                    MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End If

            Try
                My.Computer.FileSystem.CopyFile(_path, FolderMyDoc & Slash & FolderSave & Slash & FileGameplay, True)
                Return True
            Catch ex As Exception
                msgText = "The gameplay can not be saved." & Environment.NewLine
                msgText &= "Shollym Switcher does not have administrative privileges."

                MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If

        Return False
    End Function

    Public Function Backup(ByVal patch As String, ByVal season As String, ByVal gameplay As String) As Boolean
        Dim msgText As String
        Dim msgTitle As New Title()
        Dim dirBackup As String
        Dim fileBackup As String

        fileBackup = FolderMyDoc & Slash & FolderSave & Slash & FileGameplay

        If Not File.Exists(fileBackup) Then
            msgText = "Option file for backup does not exist." & Environment.NewLine
            msgText &= "Shollym Switcher can not do backup previous gameplay."

            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        dirBackup = FolderApp & Slash & FolderPatch & Slash
        dirBackup &= patch & Slash & season & Slash
        dirBackup &= FolderGameplay & Slash & gameplay & Slash

        If Not Directory.Exists(dirBackup) Then
            msgText = "Previously selected gameplay does not exist in Switcher." & Environment.NewLine
            msgText &= "Switcher will keep the gameplay as the current date and time."

            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Dim dirTemp As String

            dirTemp = FolderBackup & Slash & FolderGameplay & Slash
            dirTemp &= Date.Now().ToString().Replace(":", "-") & Slash

            Try
                My.Computer.FileSystem.CreateDirectory(dirTemp)
                My.Computer.FileSystem.CopyFile(fileBackup, dirTemp & FileGameplay)
                Return True
            Catch ex As Exception
                msgText = "Backup previous gameplay can not be done." & Environment.NewLine
                msgText &= "You do it manually before you close this message."

                MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If

        If Directory.Exists(dirBackup) And File.Exists(fileBackup) Then
            Try
                My.Computer.FileSystem.CopyFile(fileBackup, dirBackup & FileGameplay, True)
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If



        'If patch Is Nothing Or season Is Nothing Or gameplay Is Nothing Then
        '    If File.Exists(fileBackup) Then
        '        Dim dirTemp As String

        '        dirTemp = FolderBackup & Slash
        '        dirTemp &= Date.Now().ToString().Replace(":", "-") & Slash

        '        Try
        '            My.Computer.FileSystem.CreateDirectory(dirTemp)
        '            My.Computer.FileSystem.CopyFile(fileBackup, dirTemp & FileGameplay)
        '            Return True
        '        Catch ex As Exception
        '            Return False
        '        End Try
        '    End If

        '    Return True
        'End If

        'dirBackup = FolderApp & Slash
        'dirBackup &= FolderPatch & Slash
        'dirBackup &= patch & Slash
        'dirBackup &= season & Slash
        'dirBackup &= FolderGameplay & Slash
        'dirBackup &= gameplay & Slash

        'If Directory.Exists(dirBackup) And File.Exists(fileBackup) Then
        '    Try
        '        My.Computer.FileSystem.CopyFile(fileBackup, dirBackup & FileGameplay, True)
        '        Return True
        '    Catch ex As Exception
        '        Return False
        '    End Try
        'End If

        'If File.Exists(fileBackup) Then
        '    Dim dirTemp As String

        '    dirTemp = FolderBackup & Slash
        '    dirTemp &= Date.Now().ToString().Replace(":", "-") & Slash

        '    Try
        '        My.Computer.FileSystem.CreateDirectory(dirTemp)
        '        My.Computer.FileSystem.CopyFile(fileBackup, dirTemp & FileGameplay)
        '        Return True
        '    Catch ex As Exception
        '        Return False
        '    End Try
        'Else
        '    Return True
        'End If

    End Function


    Public Function Check() As Boolean
        
        If Not File.Exists(_path) Then
            Dim msgText As String
            Dim msgTItle As New Title()

            msgText = "The selected gameplay form the list does not exist." & Environment.NewLine
            msgText &= "Shollym Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTItle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function CheckFolder() As Boolean
        Dim dirPath As String

        dirPath = _patch.Path & Slash & _season.Name & Slash & FolderGameplay

        If Not Directory.Exists(dirPath) Then
            Dim msgText As String
            Dim msgTitle As New Title()

            msgText = "The selected season does not contain any gameplay." & Environment.NewLine
            msgText &= "Shollym Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function CheckLenght() As Boolean
        If _lenght = 0 Then
            Dim msgText As String
            Dim msgTitle As New Title()

            msgText = "The selected season does not contain any gameplay." & Environment.NewLine
            msgText &= "Shollym Switcher is not installed properly or is damaged."

            MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Public Function CheckOld() As Boolean
        Dim path As String

        path = MyBase.FolderMyDoc & MyBase.Slash
        path &= MyBase.FolderSave & MyBase.Slash & MyBase.FileGameplay

        If File.Exists(path) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
