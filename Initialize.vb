Imports System.IO

Public Module Initialize

    Public Sub InitProcess()
        InitFolders()
        InitMove()
        InitHide()
        InitSettings()
    End Sub

    Private Sub InitFolders()
        FilesFolders.CreateDirectory("avatars")
        FilesFolders.CreateDirectory("data")
        FilesFolders.CreateDirectory("saves")
    End Sub

    Private Sub InitMove()
        FilesFolders.MoveDirectory("en-US", "lib\en-US")
        FilesFolders.MoveDirectory("x64", "lib\x64")
        FilesFolders.MoveDirectory("x86", "lib\x86")
    End Sub

    Private Sub InitHide()
        FilesFolders.HideFolder("lib")
        FilesFolders.HideFile("limitless.exe.config")
    End Sub

    Private Sub InitSettings()
        If Not File.Exists("settings.db") Then
            Settings.CreateSettings()
            Settings.BuildDefault()
        End If
    End Sub

End Module
