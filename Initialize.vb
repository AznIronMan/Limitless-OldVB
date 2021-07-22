Imports System.IO

Public Module Initialize

    Public Sub InitProcess()
        InitFolders()
        InitHide()
        InitSettings()
        InitPanels()
        Avatars.TitleScreen()

    End Sub

    Private Sub InitFolders()
        FilesFolders.CreateDirectory(MemoryBank.AvatarsDir)
        FilesFolders.CreateDirectory(MemoryBank.DataDir)
        FilesFolders.CreateDirectory(MemoryBank.SavesDir)
        FilesFolders.CreateDirectory(MemoryBank.MusicDir)
        FilesFolders.CreateDirectory(MemoryBank.SoundDir)
        FilesFolders.CreateDirectory(MemoryBank.LogDir)
    End Sub

    Private Sub InitHide()
        FilesFolders.HideFolder(MemoryBank.LibDir)
        FilesFolders.HideFile(LCase(Application.ProductName) & ".exe.config")
        FilesFolders.HideFile(MemoryBank.UpdaterName & ".exe")
        FilesFolders.HideFile(MemoryBank.UpdaterName & ".exe.config")
    End Sub

    Private Sub InitSettings()

        If Not File.Exists(MemoryBank.SettingsFile & "." &
                           MemoryBank.SettingsExt) Then
            Settings.CreateSettings()
            Settings.BuildDefault()
        Else
            Settings.GetSettings()
        End If
        If Settings.SettingsMode = "Lite" Then
            Appearance.AssignMode("Ugly")
        Else
            Appearance.AssignMode("Default")
        End If

    End Sub

    Public Sub InitPanels()
        MainWindow.WelcomePanel.Visible = True
        MainWindow.AboutPanel.Visible = False
        MainWindow.DonatePanel.Visible = False
        MainWindow.OptionsPanel.Visible = False
        MainWindow.UpdatePanel.Visible = False
        MainWindow.EditorPanel.Visible = False
    End Sub

End Module
