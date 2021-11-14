Public Module Initialize
    Public Sub InitLoad()
        MemoryBank.UpdaterDate = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName), "d")

        InitProcess()
        Settings.UpdateSettings()
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        MemoryBank.VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & ClarkTribeGames.Converters.
            VersionConverter(VersionParts(2), 3) & "." & ClarkTribeGames.Converters.VersionConverter(VersionParts(3), 4)
        MemoryBank.UpdaterURL = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName), "u")
        MainWindow.UpdateCurBox.Text = MemoryBank.VersionNumber
        Database.CheckForDB(Settings.SettingsLastDB)
        'TO DO: Add Database Version Check Here
        Try
            MainWindow.UpdateAvaBox.Text = ClarkTribeGames.MySQLReader.Query(LCase(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()), "v")
            MainWindow.UpdateSubText.ForeColor = MemoryBank.PagesForeColor
            If (ClarkTribeGames.Updater.Checker(MainWindow.UpdateCurBox.Text, MainWindow.UpdateAvaBox.Text)) Then
                Dim updatetext = "Update " & MainWindow.UpdateAvaBox.Text & " Available!"
                UpdateChanges(updatetext, MemoryBank.DonateForeColor, True, "Install Update")
                ClarkTribeGames.Jukebox.StopSong()
                MsgBox(updatetext & vbCrLf & vbCrLf & "Please Update via the Update Button!", vbOKOnly + vbExclamation)
            Else
                UpdateChanges("Your Game Is Current!", MemoryBank.DonateForeColor, False, "No Update Available")
            End If
        Catch ex As Exception
            MainWindow.UpdateAvaBox.Text = "Not Available"
            MainWindow.UpdateSubText.Text = "Error Checking Update Server - Please Check Your Internet Settings"
            MainWindow.UpdateSubText.ForeColor = MemoryBank.DonateForeColor
            MainWindow.UpdateInstallButton.Text = "Not Available"
            Logger.WriteToLog("UpdateCheck", "Could not find update server.", ex)
        End Try
        If Settings.SettingsMusic.ToLower = "on" Then
            If Settings.SettingsCustM = "on" And Settings.SettingsCustI.StartsWith("on") Then
                Dim customintro As String = MemoryBank.MusicDir & "/" & Settings.SettingsCustI.Substring(3) & MemoryBank.MusicExtL
                If System.IO.File.Exists(customintro) Then ClarkTribeGames.Jukebox.PlayMp3(customintro) Else ClarkTribeGames.Jukebox.PlaySong(ClarkTribeGames.Jukebox.NewSong(My.Resources.intro))
            Else
                ClarkTribeGames.Jukebox.PlaySong(ClarkTribeGames.Jukebox.NewSong(My.Resources.intro))
            End If
            ClarkTribeGames.Jukebox.IntroInPlay = True
        End If
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
        ClarkTribeGames.FilesFolders.CreateDirectory(MemoryBank.LogDir)
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
        ClarkTribeGames.FilesFolders.HideFile((System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()) &
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
    Public Sub InitPanels()
        MainWindow.WelcomePanel.Visible = True
        MainWindow.AboutPanel.Visible = False
        MainWindow.DonatePanel.Visible = False
        'MainWindow.OptionsPanel.Visible = False
        MainWindow.UpdatePanel.Visible = False
        'MainWindow.EditorPanel.Visible = False
    End Sub
    Private Sub UpdateChanges(text As String, color As Color, enable As Boolean, buttontext As String)
        MainWindow.UpdateSubText.Text = text
        MainWindow.UpdateSubText.ForeColor = color
        MainWindow.UpdateInstallButton.Enabled = enable
        MainWindow.UpdateInstallButton.Text = buttontext
        Appearance.RefreshColors()
    End Sub

End Module
