Imports System.IO

Public NotInheritable Class Patch
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

    Public Function Read() As Boolean
        Dim dirPath As String

        _list.Clear()
        dirPath = FolderApp & ConstSlash & FolderPatch

        If Directory.Exists(dirPath) Then
            For Each dirName As String In Directory.GetDirectories(dirPath)
                Dim dirInfo As New DirectoryInfo(dirName)
                _list.Add(dirInfo.Name)
            Next
            Return True
        End If

        Return False
    End Function

    Public Function Save(ByVal patch As String, ByVal season As String) As Boolean
        Dim dirPath As String

        dirPath = FolderApp & ConstSlash
        dirPath += FolderPatch & ConstSlash
        dirPath += patch & ConstSlash
        dirPath += season & ConstSlash
        dirPath += FolderData

        Try
            My.Computer.FileSystem.CopyDirectory(dirPath, "..\", True)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
