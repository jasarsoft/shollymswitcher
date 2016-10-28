Imports System.IO

Public Class Logo
    Inherits Switcher

    Private _path As String

    Public ReadOnly Property Path As String
        Get
            Return _path
        End Get
    End Property


    Public Function Read(ByVal patchName As String, ByVal seasonName As String) As Boolean
        Dim filePath As String

        filePath = Directory.GetCurrentDirectory() & ConstSlash
        filePath += FolderPatch & ConstSlash
        filePath += patchName & ConstSlash
        filePath += seasonName & ConstSlash
        filePath += FolderImage & ConstSlash
        filePath += FileLogo

        If File.Exists(filePath) Then
            _path = filePath
            Return True
        End If

        Return False
    End Function

End Class
