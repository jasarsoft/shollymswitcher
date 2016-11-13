Imports System.IO
Imports System.Xml

Public Class Settings

    Private Structure Constant
        Public Const SLASH As String = "\"
    End Structure

    Private Structure Tags
        Public Const COMMENT As String = "Shollym Switcher Settings File"
        Public Const SETTINGS As String = "settings"
        Public Const SWITCHER As String = "switcher"
        Public Const PATCH As String = "patch"
        Public Const SEASON As String = "season"
        Public Const GAMEPLAY As String = "gameplay"
    End Structure

    Private Structure Files
        Public Const SETTINGS As String = "settings.xml"
    End Structure

    Private Structure Folders
        Public Const JASARSOFT As String = "Jasarsoft"
        Public Const SHOLLYMSWITCHER As String = "Shollym Switcher"
    End Structure

    Private _path As String
    Private _patch As String
    Private _season As String
    Private _gameplay As String


    Public Sub New()
        _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & Constant.SLASH
        _path += Folders.JASARSOFT & Constant.SLASH & Folders.SHOLLYMSWITCHER & Constant.SLASH & Files.SETTINGS
    End Sub

    Public ReadOnly Property Path As String
        Get
            Return _path
        End Get
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

    Private Sub Reset()
        _patch = Nothing
        _season = Nothing
        _gameplay = Nothing
    End Sub

    Public Function Check() As Boolean

        If File.Exists(_path) Then
            Return True
        End If

        Return False
    End Function

    Public Function Write() As Boolean
        Dim dirPath As String

        dirPath = _path.Replace(Files.SETTINGS, "")

        If Not Directory.Exists(dirPath) Then
            Directory.CreateDirectory(dirPath)
        End If

        Dim xws As New XmlWriterSettings()
        xws.Indent = True
        xws.NewLineOnAttributes = True

        Using _xmlReader As XmlWriter = XmlWriter.Create(_path, xws)
            _xmlReader.WriteStartDocument()
            _xmlReader.WriteComment(Tags.COMMENT)
            _xmlReader.WriteStartElement(Tags.SETTINGS)
            _xmlReader.WriteStartElement(Tags.SWITCHER)
            _xmlReader.WriteElementString(Tags.PATCH, _patch)
            _xmlReader.WriteElementString(Tags.SEASON, _season)
            _xmlReader.WriteElementString(Tags.GAMEPLAY, _gameplay)
            _xmlReader.WriteEndElement()
            _xmlReader.WriteEndElement()
            _xmlReader.WriteEndDocument()
            Return True
        End Using

        Return False
    End Function

    Public Function Read() As Boolean

        Call Reset()

        If File.Exists(_path) Then
            Using _xmlReader As XmlReader = XmlReader.Create(_path)
                Do While _xmlReader.Read()
                    If _xmlReader.NodeType = XmlNodeType.Element And _xmlReader.Name = Tags.PATCH Then
                        _patch = _xmlReader.ReadElementString()
                    ElseIf _xmlReader.NodeType = XmlNodeType.Element And _xmlReader.Name = Tags.SEASON Then
                        _season = _xmlReader.ReadElementString()
                    ElseIf _xmlReader.NodeType = XmlNodeType.Element And _xmlReader.Name = Tags.GAMEPLAY Then
                        _gameplay = _xmlReader.ReadElementString()
                    End If
                Loop

                If _patch Is Nothing Or _season Is Nothing Or _gameplay Is Nothing Then
                    Return False
                Else
                    Return True
                End If
            End Using
        End If

        Return False
    End Function

End Class
