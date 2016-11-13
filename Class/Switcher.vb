Imports System.IO

Public MustInherit Class Switcher

    Private Structure Constant
        Public Const SLASH As String = "\"
    End Structure

    Private Structure Files
        Public Const LOGO As String = "logo.png"
        Public Const GAMEPLAY As String = "KONAMI-WIN32PES6OPT"
    End Structure

    Private Structure Folders
        Public Const DATA As String = "data"
        Public Const PATCH As String = "patches"
        Public Const IMAGE As String = "image"
        Public Const GAMEPLAY As String = "gameplay"
        Public Const BACKUP As String = "backup"
        Public Const SAVE As String = "KONAMI\Shollym Multi-Patch OF\save\folder1"
    End Structure

    Private _folderApp As String
    Private _folderMyDoc As String

    Public Sub New()
        _folderApp = Directory.GetCurrentDirectory()
        _folderMyDoc = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    End Sub

    Protected ReadOnly Property ConstSlash As String
        Get
            Return Constant.SLASH
        End Get
    End Property

    Protected ReadOnly Property FolderApp As String
        Get
            Return _folderApp
        End Get
    End Property

    Protected ReadOnly Property FolderMyDoc As String
        Get
            Return _folderMyDoc
        End Get
    End Property

    Protected ReadOnly Property FolderSave As String
        Get
            Return Folders.SAVE
        End Get
    End Property

    Protected ReadOnly Property FolderBackup As String
        Get
            Return Folders.BACKUP
        End Get
    End Property

    Protected ReadOnly Property FolderPatch As String
        Get
            Return Folders.PATCH
        End Get
    End Property

    Protected ReadOnly Property FolderData As String
        Get
            Return Folders.DATA
        End Get
    End Property

    Protected ReadOnly Property FolderImage As String
        Get
            Return Folders.IMAGE
        End Get
    End Property

    Protected ReadOnly Property FolderGameplay As String
        Get
            Return Folders.GAMEPLAY
        End Get
    End Property

    Protected ReadOnly Property FileLogo As String
        Get
            Return Files.LOGO
        End Get
    End Property

    Protected ReadOnly Property FileGameplay As String
        Get
            Return Files.GAMEPLAY
        End Get
    End Property


End Class
