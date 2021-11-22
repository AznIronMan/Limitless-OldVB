Public Module Initialize

    Private Sub Debugging()

    End Sub
    Public Sub InitLoad()
        Debugging()
        If (ClarkTribeGames.Web.CheckWeb()) Then
            MemoryBank.UpdaterDate = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName), "d")
            MemoryBank.UpdaterURL = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName), "u")
        End If
        MemoryBank.VersionNumber = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        InitProcess()
        Appearance.RefreshColors()
        Database.CheckForDB(Settings.SettingsDB)
        Database.VersionChecker()
        Updater.CheckUpdate()
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
            Try
                If System.IO.File.GetLastWriteTime(MemoryBank.UpdaterName & MemoryBank.FileExtL) < Convert.ToDateTime(MemoryBank.UpdaterDate) Then
                    System.IO.File.Delete(MemoryBank.UpdaterName & MemoryBank.FileExtL)
                    ClarkTribeGames.Updater.GetUpdater()
                End If
            Catch ex As Exception
                'This means there's no internet.
            End Try
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
        Appearance.AssignTheme(Settings.SettingsMode)
    End Sub
    Public Sub InitIntro()
        If Settings.SettingsMusic.ToLower = "on" Then
            If Settings.SettingsCustI.StartsWith("on") Then
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
    End Sub

End Module
