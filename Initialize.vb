Imports System.IO

Public Module Initialize

    Public Sub InitLoad()
        InitProcess()
        Settings.UpdateSettings()
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        MainWindow.VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & Converters.VersionConverter(VersionParts(2), 3) & "." & Converters.VersionConverter(VersionParts(3), 4)
        MainWindow.UpdateCurBox.Text = MainWindow.VersionNumber
        Database.CheckForDB(Settings.SettingsLastDB)
        Try
            MainWindow.UpdateAvaBox.Text = Tools.GetWebText(MemoryBank.VersionURL)
            MainWindow.UpdateSubText.ForeColor = MemoryBank.PagesForeColor
            Updater.CheckForUpdate(MainWindow.UpdateCurBox.Text, MainWindow.UpdateAvaBox.Text)
        Catch ex As Exception
            MainWindow.UpdateAvaBox.Text = "Not Available"
            MainWindow.UpdateSubText.Text = "Error Checking Update Server - Please Check Your Internet Settings"
            MainWindow.UpdateSubText.ForeColor = MemoryBank.DonateForeColor
            MainWindow.UpdateInstallButton.Text = "Not Available"
            Logger.WriteToLog("UpdateCheck", "Could not find update server.", ex)
        End Try
        If Settings.SettingsMusic.ToLower = "on" Then
            If Settings.SettingsCustM = "on" And Settings.SettingsCustI.StartsWith("on") Then
                Dim customintro As String = MemoryBank.MusicDir & "/" & Settings.SettingsCustI.Substring(3) & ".mp3"
                If System.IO.File.Exists(customintro) Then Jukebox.PlayMp3(customintro) Else Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
            Else
                Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
            End If
            Jukebox.IntroInPlay = True
        End If

    End Sub

    Public Sub InitProcess()
        InitFolders()
        InitUpdater()
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

    Private Sub InitUpdater()
        If Not File.Exists(MemoryBank.UpdaterName & ".exe") Then System.IO.File.WriteAllBytes(MemoryBank.UpdaterName & ".exe",
            My.Resources.CTGUpdater)
    End Sub

    Private Sub InitHide()
        FilesFolders.HideFolder(MemoryBank.LibDir)
        FilesFolders.HideFile(LCase(Application.ProductName) & ".exe.config")
        FilesFolders.HideFile(MemoryBank.UpdaterName & ".exe")
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
