Imports System.IO

Public Class Logo
    Inherits Switcher

    Private _path As String

    Public ReadOnly Property Path As String
        Get
            Return _path
        End Get
    End Property


    Public Function Read(ByVal patch As String, ByVal season As String) As Boolean
        Dim filePath As String

        filePath = FolderApp & Slash
        filePath &= FolderPatch & Slash
        filePath &= patch & Slash
        filePath &= season & Slash
        filePath &= FolderImage & Slash
        filePath &= FileLogo

        If File.Exists(filePath) Then
            _path = filePath
            Return True
        End If

        Return False
    End Function

End Class
