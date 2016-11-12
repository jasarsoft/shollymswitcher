Public NotInheritable Class About

    Private Structure Info
        Public Const NAME As String = "switcher.exe"
        Public Const TYPE As String = "Windows .NET Application"
        Public Const TITLE As String = "Shollym Multi-Patch Switcher"
        Public Const VERSION As String = "1.0 Beta"
        Public Const LICENSE As String = "Apache License v2.0"
        Public Const WEBSITE As String = "https://github.com/jasarsoft/shollymswitcher"
        Public Const DEVELOPER As String = "Edin Jašarević"
        Public Const COPYRIGHT As String = "2016 November"
        Public Const DESCRIPTION As String = "Easy to change the desired patch to play."
    End Structure

    Public ReadOnly Property Name As String
        Get
            Return Info.NAME
        End Get
    End Property

    Public ReadOnly Property Type As String
        Get
            Return Info.TYPE
        End Get
    End Property

    Public ReadOnly Property Title As String
        Get
            Return Info.TITLE
        End Get
    End Property

    Public ReadOnly Property Version As String
        Get
            Return Info.VERSION
        End Get
    End Property

    Public ReadOnly Property License As String
        Get
            Return Info.LICENSE
        End Get
    End Property

    Public ReadOnly Property Website As String
        Get
            Return Info.WEBSITE
        End Get
    End Property

    Public ReadOnly Property Developer As String
        Get
            Return Info.DEVELOPER
        End Get
    End Property

    Public ReadOnly Property Copyright As String
        Get
            Return Info.COPYRIGHT
        End Get
    End Property

    Public ReadOnly Property Description As String
        Get
            Return Info.DESCRIPTION
        End Get
    End Property

End Class
