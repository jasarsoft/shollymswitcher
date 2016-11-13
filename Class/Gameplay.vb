Imports System.IO

Public NotInheritable Class Gameplay
    Inherits Switcher

    Private _name As String
    Private _list As List(Of String)

    Public Sub New()
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


    Public Function Read(ByVal patchName As String, ByVal seasonName As String) As Boolean
        Dim dirPath As String

        _list.Clear()
        dirPath = Directory.GetCurrentDirectory() & ConstSlash
        dirPath += FolderPatch & ConstSlash
        dirPath += patchName & ConstSlash
        dirPath += seasonName & ConstSlash
        dirPath += FolderGameplay

        If Directory.Exists(dirPath) Then
            For Each dirName As String In Directory.GetDirectories(dirPath)
                Dim dirInfo As New DirectoryInfo(dirName)
                _list.Add(dirInfo.Name)
            Next

            Return True
        End If

        Return False
    End Function

    Public Function Save(ByVal patchName As String, ByVal seasonName As String, ByVal gameplayName As String) As Boolean
        Dim fileSource As String
        Dim fileDestionation As String

        fileSource = FolderApp & ConstSlash
        fileSource += FolderPatch & ConstSlash
        fileSource += patchName & ConstSlash
        fileSource += seasonName & ConstSlash
        fileSource += FolderGameplay & ConstSlash
        fileSource += gameplayName & ConstSlash
        fileSource += FileGameplay

        fileDestionation = FolderMyDoc & ConstSlash
        fileDestionation += FolderSave & ConstSlash
        fileDestionation += FileGameplay

        Try
            My.Computer.FileSystem.CopyFile(fileSource, fileDestionation, True)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Backup(ByVal patchName As String, ByVal seasonName As String, ByVal gameplayName As String) As Boolean
        Dim dirBackup As String
        Dim fileBackup As String

        fileBackup = FolderMyDoc & ConstSlash
        fileBackup &= FolderSave & ConstSlash
        fileBackup &= FileGameplay

        If patchName Is Nothing Or seasonName Is Nothing Or gameplayName Is Nothing Then
            If File.Exists(fileBackup) Then
                Dim dirTemp As String

                dirTemp = FolderBackup & ConstSlash
                dirTemp &= Date.Now().ToString().Replace(":", "-") & ConstSlash

                Try
                    My.Computer.FileSystem.CreateDirectory(dirTemp)
                    My.Computer.FileSystem.CopyFile(fileBackup, dirTemp & FileGameplay)
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End If

            Return True
        End If

        dirBackup = FolderApp & ConstSlash
        dirBackup &= FolderPatch & ConstSlash
        dirBackup &= patchName & ConstSlash
        dirBackup &= seasonName & ConstSlash
        dirBackup &= FolderGameplay & ConstSlash
        dirBackup &= gameplayName & ConstSlash

        If Directory.Exists(dirBackup) And File.Exists(fileBackup) Then
            Try
                My.Computer.FileSystem.CopyFile(fileBackup, dirBackup & FileGameplay, True)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If

        If File.Exists(fileBackup) Then
            Dim dirTemp As String

            dirTemp = FolderBackup & ConstSlash
            dirTemp &= Date.Now().ToString().Replace(":", "-") & ConstSlash

            Try
                My.Computer.FileSystem.CreateDirectory(dirTemp)
                My.Computer.FileSystem.CopyFile(fileBackup, dirTemp & FileGameplay)
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return True
        End If

    End Function

End Class
