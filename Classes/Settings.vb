Public Class Settings

    Public Shared SettingsPath As String = ".\"
    Public Shared SettingsName As String = "Limitless" & MemoryBank.SettingsExtL
    Public Shared SettingsUID As String = Environment.MachineName
    Public Shared SettingsVersion As String = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
    Public Shared SettingsMode As String = "Dark Mode"
    Public Shared SettingsMusic As String = "on"
    Public Shared SettingsCustM As String = "off"
    Public Shared SettingsCustI As String = "off"
    Public Shared SettingsCustB As String = "off"
    Public Shared SettingsCustW As String = "off"
    Public Shared SettingsCustL As String = "off"
    Public Shared SettingsSound As String = "on"
    Public Shared SettingsMMM As String = "off"
    Public Shared SettingsDB As String = "default"
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
        "'", "'mmm', '" & SettingsMMM & "'", "'database', '" &
        SettingsDB & "'", "'autosave', '" & SettingsAutoSave & "'"})
        ClarkTribeGames.SQLite.RunSQL(SettingsPath, SettingsName, "INSERT INTO 'main'.'colorSettings'
        ('uid', 'colorname', 'coloract', 'colordesc', 'tbarb', 'tbarf', 'tbutb', 'tbutf', 'backb', 
        'backf', 'pageb', 'pagef', 'buttb', 'buttf', 'donaf', 'donah', 'buttmdb', 'buttdc', 'hoveb', 
        'hovef', 'leavb', 'leavf', 'clicb', 'clicf', 'groub', 'grouf') VALUES ('1', 'Dark Mode', '1', 
        'Easy on the eyes with a dark background and light letters theme.', 'dblue', 'white', 'dblue', 
        'white', 'dgrey', 'white', 'black', 'white', 'black', 'white', 'lgreen', 'green', 'black', 
        'grey', 'black', 'blue', 'black', 'white', 'black', 'red', 'ablack', 'white');")
        ClarkTribeGames.SQLite.RunSQL(SettingsPath, SettingsName, "INSERT INTO 'main'.'colorSettings'
        ('uid', 'colorname', 'coloract', 'colordesc', 'tbarb', 'tbarf', 'tbutb', 'tbutf', 'backb', 
        'backf', 'pageb', 'pagef', 'buttb', 'buttf', 'donaf', 'donah', 'buttmdb', 'buttdc', 'hoveb', 
        'hovef', 'leavb', 'leavf', 'clicb', 'clicf', 'groub', 'grouf') VALUES ('2', 'Lite Mode', '1', 
        'Traditional black text on white background.', 'sblue', 'black', 'sblue', 'black', 'white', 
        'black', 'white', 'black', 'white', 'black', 'green', 'dgreen', 'white', 'grey', 'white', 
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
        SettingsMMM = CurrentSettings(10)
        SettingsDB = CurrentSettings(11)
        SettingsAutoSave = CurrentSettings(12)
    End Sub

End Class