
Public NotInheritable Class Title

    Private _app As String

    Private _info As String
    Private _warn As String
    Private _error As String

    Public Sub New()
        _app = "Shollym Switcher | "

        _info = "Information"
        _warn = "Warning"
        _error = "Error"
    End Sub

    Public ReadOnly Property Info As String
        Get
            Return _app & _info
        End Get
    End Property

    Public ReadOnly Property Warn As String
        Get
            Return _app & _warn
        End Get
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The word 'mistake' is used because of the conflict of variable names with a reserved word.</remarks>
    Public ReadOnly Property Mistake As String 'or Error
        Get
            Return _app & _error
        End Get
    End Property

End Class
