Public Module Initialize
    Public Sub InitLoad()
        MemoryBank.UpdaterDate = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName), "d")
        InitProcess()
        Settings.UpdateSettings()
        MemoryBank.VersionNumber = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        MemoryBank.UpdaterURL = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName), "u")
        MainWindow.UpdateCurBox.Text = MemoryBank.VersionNumber
        Database.CheckForDB(Settings.SettingsLastDB)
        Database.VersionChecker()
        Tools.CheckUpdate()
        InitIntro()
    End Sub
    Private Sub InitProcess()
        InitFolders()
        InitFiles()
        InitHide()
        InitSettings()
        InitPanels()
        Avatars.TitleScreen()
    End Sub
    Private Sub InitFolders()
        ClarkTribeGames.FilesFolders.CreateDirectory(MemoryBank.AvatarsDir)
        ClarkTribeGames.FilesFolders.CreateDirectory(MemoryBank.DataDir)
        ClarkTribeGames.FilesFolders.CreateDirectory(MemoryBank.SavesDir)
        ClarkTribeGames.FilesFolders.CreateDirectory(MemoryBank.MusicDir)
        ClarkTribeGames.FilesFolders.CreateDirectory(MemoryBank.SoundDir)
    End Sub
    Private Sub InitFiles()
        If Not System.IO.File.Exists(MemoryBank.SQLiteFile & MemoryBank.LibExtL) Then System.IO.File.WriteAllBytes(MemoryBank.SQLiteFile &
            MemoryBank.LibExtL, My.Resources.System_Data_SQLite)
        If System.IO.File.Exists(MemoryBank.UpdaterName & MemoryBank.FileExtL) Then
            If System.IO.File.GetLastWriteTime(MemoryBank.UpdaterName & MemoryBank.FileExtL) < Convert.ToDateTime(MemoryBank.UpdaterDate) Then
                System.IO.File.Delete(MemoryBank.UpdaterName & MemoryBank.FileExtL)
                ClarkTribeGames.Updater.GetUpdater()
            End If
        Else
            ClarkTribeGames.Updater.GetUpdater()
        End If
    End Sub
    Private Sub InitHide()
        ClarkTribeGames.FilesFolders.HideFile(MemoryBank.UpdaterName & MemoryBank.FileExtL)
        ClarkTribeGames.FilesFolders.HideFile((Application.ProductName.ToString()) &
            MemoryBank.FileExtL & MemoryBank.ConfigExtL)
        ClarkTribeGames.FilesFolders.HideFile(MemoryBank.SQLiteFile & MemoryBank.LibExtL)
    End Sub
    Private Sub InitSettings()
        If Not System.IO.File.Exists(MemoryBank.SettingsFile & MemoryBank.SettingsExtL) Then
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
    Private Sub InitIntro()
        If Settings.SettingsMusic.ToLower = "on" Then
            If Settings.SettingsCustM = "on" And Settings.SettingsCustI.StartsWith("on") Then
                Dim customintro As String = MemoryBank.MusicDir & "/" & Settings.SettingsCustI.Substring(3) & MemoryBank.MusicExtL
                If System.IO.File.Exists(customintro) Then ClarkTribeGames.Jukebox.PlayMp3(customintro) Else ClarkTribeGames.Jukebox.
                    PlaySong(ClarkTribeGames.Jukebox.NewSong(My.Resources.intro))
            Else
                ClarkTribeGames.Jukebox.PlaySong(ClarkTribeGames.Jukebox.NewSong(My.Resources.intro))
            End If
            ClarkTribeGames.Jukebox.IntroInPlay = True
        End If
    End Sub

    Public Sub InitPanels()
        MainWindow.WelcomePanel.Visible = True
        MainWindow.UpdatePanel.Visible = False
    End Sub

End Module
