Public NotInheritable Class Edit

    Private _name As String

    Private _patch As Boolean
    Private _season As Boolean
    Private _gameplay As Boolean


    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Patch As Boolean
        Get
            Return _patch
        End Get
        Set(value As Boolean)
            _patch = value
        End Set
    End Property

    Public Property Season As Boolean
        Get
            Return _season
        End Get
        Set(value As Boolean)
            _season = value
        End Set
    End Property

    Public Property Gameplay As Boolean
        Get
            Return _gameplay
        End Get
        Set(value As Boolean)
            _gameplay = value
        End Set
    End Property


    Public Sub Reset()
        _patch = False
        _season = False
        _gameplay = False
    End Sub

End Class
