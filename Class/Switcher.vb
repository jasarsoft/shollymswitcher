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
    End Structure

    Protected ReadOnly Property ConstSlash As String
        Get
            Return Constant.SLASH
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
