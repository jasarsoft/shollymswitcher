Public NotInheritable Class Edit

    Private _name As String

    Private _patch As String
    Private _season As String
    Private _gameplay As String


    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Patch As String
        Get
            Return _patch
        End Get
        Set(value As String)
            _patch = value
        End Set
    End Property

    Public Property Season As String
        Get
            Return _season
        End Get
        Set(value As String)
            _season = value
        End Set
    End Property

    Public Property Gameplay As String
        Get
            Return _gameplay
        End Get
        Set(value As String)
            _gameplay = value
        End Set
    End Property

End Class
