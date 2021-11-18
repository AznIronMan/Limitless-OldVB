Public Class Settings

    Public Shared SettingsPath As String = ".\"
    Public Shared SettingsName As String = "Limitless" & MemoryBank.SettingsExtL
    Public Shared SettingsUID As String = Environment.MachineName
    Public Shared SettingsVersion As String = (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())
    Public Shared SettingsMode As String = "Dark Mode"
    Public Shared SettingsMusic As String = "on"
    Public Shared SettingsCustM As String = "off"
    Public Shared SettingsCustI As String = "off"
    Public Shared SettingsCustB As String = "off"
    Public Shared SettingsCustW As String = "off"
    Public Shared SettingsCustL As String = "off"
    Public Shared SettingsSound As String = "on"
    Public Shared SettingsSameDB As String = "on"
    Public Shared SettingsDefaultDB As String = "default"
    Public Shared SettingsLastDB As String = "default"
    Public Shared SettingsAutoSave As String = "on"
    Public Shared Sub CreateSettings()
        ClarkTribeGames.SQLite.CreateDB(SettingsPath, SettingsName,
            "CREATE TABLE 'mainSettings' ('settingName' TEXT NOT NULL, 'settingConfig' TEXT);
            CREATE TABLE 'colorSettings' ('uid' TEXT NOT NULL, 'colorname' TEXT NOT NULL,
            'coloract' TEXT NOT NULL,'colordesc' TEXT NOT NULL,'tbarb' TEXT NOT NULL,
            'tbarf' TEXT NOT NULL,'tbutb' TEXT NOT NULL,'tbutf' TEXT NOT NULL, 'backb' TEXT NOT NULL,
            'backf' TEXT NOT NULL,'pageb' TEXT NOT NULL,'pagef' TEXT NOT NULL,'buttb' TEXT NOT NULL,
            'buttf' TEXT NOT NULL,'donaf' TEXT NOT NULL,'donah' TEXT NOT NULL,'buttmdb' TEXT NOT NULL,
            'buttdc' TEXT NOT NULL,'hoveb' TEXT NOT NULL,'hovef' TEXT NOT NULL,'leavb' TEXT NOT NULL,
            'leavf' TEXT NOT NULL,'clicb' TEXT NOT NULL,'clicf' TEXT NOT NULL,'groub' TEXT NOT NULL,
            'grouf' TEXT NOT NULL,PRIMARY KEY('uid'));")
    End Sub
    Public Shared Sub BuildDefault()
        ClarkTribeGames.SQLite.InsertData(SettingsPath, SettingsName, "mainSettings",
        {"'uid', '" & SettingsUID & "'", "'version', '" & SettingsVersion &
        "'", "'mode', '" & SettingsMode & "'", "'music', '" & SettingsMusic &
        "'", "'custm', '" & SettingsCustM & "'", "'custi', '" & SettingsCustI &
        "'", "'custb', '" & SettingsCustB & "'", "'custw', '" & SettingsCustW &
        "'", "'custl', '" & SettingsCustL & "'", "'sound', '" & SettingsSound &
        "'", "'samedb', '" & SettingsSameDB & "'", "'defaultdb', '" &
        SettingsDefaultDB & "'", "'lastdb', '" & SettingsLastDB & "'",
        "'autosave', '" & SettingsAutoSave & "'"})
        ClarkTribeGames.SQLite.RunSQL(SettingsPath, SettingsName, "INSERT INTO 'main'.'colorSettings'
        ('uid', 'colorname', 'coloract', 'colordesc', 'tbarb', 'tbarf', 'tbutb', 'tbutf', 'backb', 
        'backf', 'pageb', 'pagef', 'buttb', 'buttf', 'donaf', 'donah', 'buttmdb', 'buttdc', 'hoveb', 
        'hovef', 'leavb', 'leavf', 'clicb', 'clicf', 'groub', 'grouf') VALUES ('1', 'Dark Mode', '1', 
        'Easy on the eyes with a dark background and light letters theme.', 'dblue', 'white', 'dblue', 
        'white', 'dgrey', 'white', 'black', 'white', 'black', 'white', 'lgreen', 'green', 'black', 
        'gray', 'black', 'blue', 'black', 'white', 'black', 'red', 'ablack', 'white');")
        ClarkTribeGames.SQLite.RunSQL(SettingsPath, SettingsName, "INSERT INTO 'main'.'colorSettings'
        ('uid', 'colorname', 'coloract', 'colordesc', 'tbarb', 'tbarf', 'tbutb', 'tbutf', 'backb', 
        'backf', 'pageb', 'pagef', 'buttb', 'buttf', 'donaf', 'donah', 'buttmdb', 'buttdc', 'hoveb', 
        'hovef', 'leavb', 'leavf', 'clicb', 'clicf', 'groub', 'grouf') VALUES ('2', 'Lite Mode', '1', 
        'Traditional black text on white background.', 'sblue', 'lack', 'sblue', 'black', 'white', 
        'black', 'white', 'black', 'white', 'black', 'green', 'dgreen', 'white', 'gray', 'white', 
        'blue', 'white', 'black', 'white', 'red', 'white', 'black');")
    End Sub
    Public Shared Sub GetSettings()
        Dim CurrentSettings() As String = (ClarkTribeGames.SQLite.GetCol(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingConfig").Split(","))
        SettingsUID = CurrentSettings(0)
        SettingsVersion = CurrentSettings(1)
        SettingsMode = CurrentSettings(2)
        SettingsMusic = CurrentSettings(3)
        SettingsCustM = CurrentSettings(4)
        SettingsCustI = CurrentSettings(5)
        SettingsCustB = CurrentSettings(6)
        SettingsCustW = CurrentSettings(7)
        SettingsCustL = CurrentSettings(8)
        SettingsSound = CurrentSettings(9)
        SettingsSameDB = CurrentSettings(10)
        SettingsDefaultDB = CurrentSettings(11)
        SettingsLastDB = CurrentSettings(12)
        SettingsAutoSave = CurrentSettings(13)
    End Sub

    Public Shared Sub UpdateSettings()
        If Settings.SettingsMode.ToLower = "lite" Then
            'MainWindow.OptionsColorLite.CheckState = CheckState.Checked
            'MainWindow.OptionsColorLite.Enabled = False
            'MainWindow.OptionsColorDark.CheckState = CheckState.Unchecked
            'MainWindow.OptionsColorDark.Enabled = True
            'MainWindow.OptionsColorCustom.CheckState = CheckState.Unchecked
            'MainWindow.OptionsColorCustom.Enabled = True
        Else
            'MainWindow.OptionsColorDark.CheckState = CheckState.Checked
            'MainWindow.OptionsColorDark.Enabled = False
            'MainWindow.OptionsColorLite.CheckState = CheckState.Unchecked
            'MainWindow.OptionsColorLite.Enabled = True
            'MainWindow.OptionsColorCustom.CheckState = CheckState.Unchecked
            'MainWindow.OptionsColorCustom.Enabled = True
        End If
        If Settings.SettingsMusic.ToLower.StartsWith("on") Then
            'MainWindow.OptionsAudioCheckMusic.CheckState = CheckState.Checked
            'MainWindow.OptionsAudioCheckCustom.Enabled = True
        Else
            Optioner.DisableMusicOptions()
            'MainWindow.OptionsAudioCheckCustom.Enabled = False
            'MainWindow.OptionsAudioCheckMusic.CheckState = CheckState.Unchecked
        End If
        Appearance.RefreshColors()
        'OptionsCheckUncheck(Settings.SettingsCustM, MainWindow.OptionsAudioCheckCustom)
        'OptionsCheckUncheck(Settings.SettingsCustI, MainWindow.OptionsAudioCheckIntro)
        'OptionsCheckUncheck(Settings.SettingsCustB, MainWindow.OptionsAudioCheckBattle)
        'OptionsCheckUncheck(Settings.SettingsCustW, MainWindow.OptionsAudioCheckVictory)
        'OptionsCheckUncheck(Settings.SettingsCustL, MainWindow.OptionsAudioCheckDefeat)
        'OptionsCheckUncheck(Settings.SettingsSound, MainWindow.OptionsAudioCheckSound)
        'OptionsCheckUncheck(Settings.SettingsAutoSave, MainWindow.CustomLibsAuto)
        Dim ReleaseType As String = "ALPHA "
        Dim VersionParts() As String = Strings.Split(Settings.SettingsVersion, ".", 4)
        Dim VersionNumber As String = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        'MainWindow.OptionsHost.Text = Settings.SettingsUID & " • " & ReleaseType & "VERSION " & VersionNumber
    End Sub
    Private Shared Sub OptionsCheckUncheck(setting As String, checkbox As CheckBox)
        If setting.ToLower.StartsWith("on") Then
            checkbox.CheckState = CheckState.Checked
        Else
            checkbox.CheckState = CheckState.Unchecked
        End If
    End Sub

End Class