﻿Imports System.IO

Public NotInheritable Class Help

    Private Structure FileName
        Public Const README As String = "readme"
        Public Const FACEBOOK As String = "facebook.url"
        Public Const DOWNLOAD As String = "download.url"
    End Structure

    Private Structure FolderName
        Public Const HELP As String = "..\help\"
    End Structure

    Private Structure LinkName
        Public Const FACEBOOK As String = "https://www.facebook.com/ShollymPatch"
        Public Const DOWNLOAD As String = "https://mega.nz/#F!ecQUzRJS!RH84LZpetnsjytxVRczNtw"
    End Structure


    Public Sub Readme()
        Dim name As String

        For Each name In Directory.GetFiles(FolderName.HELP)
            Dim info As New FileInfo(name)
            If info.Name.Contains(FileName.README) Then
                Process.Start(info.FullName)
                Exit Sub
            End If
        Next

        Dim msgText As String
        Dim msgTitle As New Title()

        msgText = "Readme file does not exist in the help directory." & Environment.NewLine
        msgText += "See the Facebook page for more information about the patch."

        MessageBox.Show(msgText, msgTitle.Mistake, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub Facebook()

        OpenLink(FileName.FACEBOOK, LinkName.FACEBOOK)
    End Sub

    Public Sub Download()

        OpenLink(FileName.DOWNLOAD, LinkName.DOWNLOAD)
    End Sub


    Private Sub OpenLink(ByVal name As String, ByVal link As String)
        Dim path As String = FolderName.HELP & name

        If File.Exists(path) Then
            Process.Start(path)
        Else
            Dim msgText As String
            Dim msgTitle As New Title()

            msgText = name.Substring(0, 1).ToUpper() + name.Substring(1).Replace(".url", "")
            msgText += " link does not exist in the help directory." & Environment.NewLine
            msgText += "Next open the link may not work if you were to change it."

            MessageBox.Show(msgText, msgTitle.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Process.Start(link)
        End If
    End Sub

End Class
