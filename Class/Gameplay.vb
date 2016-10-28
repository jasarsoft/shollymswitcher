Imports System.IO

Public NotInheritable Class Gameplay
    Inherits Switcher

    Private _name As String
    Private _list As List(Of String)

    Public Sub New()
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

End Class
