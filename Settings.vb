Public Class Settings

    Public Shared SettingsPath As String = ".\"
    Public Shared SettingsName As String = "settings.db"

    Public Shared Sub CreateSettings()
        Database.CreateDB(SettingsPath, SettingsName, "CREATE TABLE 
            'mainSettings' ('settingName' TEXT NOT NULL, 'settingConfig'
            TEXT);")
    End Sub

    Public Shared Sub BuildDefault()
        Database.InsertData(SettingsPath, SettingsName, "mainSettings",
        {"'uid', '" & Environment.MachineName & "'", "'version', '" &
        (System.Reflection.Assembly.GetExecutingAssembly().GetName().
        Version.ToString()) & "'", "'mode', 'Dark'", "'music', 'on'",
        "'custm', 'off'", "'custi', 'off'", "'custb', 'off'",
        "'custw', 'off'", "'custl', 'off'", "'sound', 'on'",
        "'samedb', 'on'", "'defaultdb', 'default'", "'lastdb', 'default'"})
    End Sub

End Class