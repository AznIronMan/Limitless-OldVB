Public Class Settings

    Public Shared SettingsPath As String = ".\"
    Public Shared SettingsName As String = "Limitless.Settings"
    Public Shared SettingsUID As String = Environment.MachineName
    Public Shared SettingsVersion As String = (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())
    Public Shared SettingsMode As String = "Dark"
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
        DBTools.CreateDB(SettingsPath, SettingsName,
            "CREATE TABLE 'mainSettings' ('settingName' TEXT NOT NULL, 'settingConfig' TEXT);")
    End Sub

    Public Shared Sub BuildDefault()
        DBTools.InsertData(SettingsPath, SettingsName, "mainSettings",
        {"'uid', '" & SettingsUID & "'", "'version', '" & SettingsVersion &
        "'", "'mode', '" & SettingsMode & "'", "'music', '" & SettingsMusic &
        "'", "'custm', '" & SettingsCustM & "'", "'custi', '" & SettingsCustI &
        "'", "'custb', '" & SettingsCustB & "'", "'custw', '" & SettingsCustW &
        "'", "'custl', '" & SettingsCustL & "'", "'sound', '" & SettingsSound &
        "'", "'samedb', '" & SettingsSameDB & "'", "'defaultdb', '" &
        SettingsDefaultDB & "'", "'lastdb', '" & SettingsLastDB & "'",
        "'autosave', '" & SettingsAutoSave & "'"})
    End Sub

    Public Shared Sub GetSettings()
        Dim CurrentSettings() As String = (DBTools.GetCol(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingConfig").Split(","))
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

End Class