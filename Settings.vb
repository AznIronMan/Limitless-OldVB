Public Class Settings

    Public Shared SettingsPath As String = ".\"
    Public Shared SettingsName As String = "settings.db"
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

    Public Shared Sub CreateSettings()
        Database.CreateDB(SettingsPath, SettingsName, "CREATE TABLE 
            'mainSettings' ('settingName' TEXT NOT NULL, 'settingConfig'
            TEXT);")
        MsgBox("Created")
    End Sub

    Public Shared Sub BuildDefault()
        Database.InsertData(SettingsPath, SettingsName, "mainSettings",
        {"'uid', '" & SettingsUID & "'", "'version', '" & SettingsVersion & _
        "'", "'mode', '" & SettingsMode & "'", "'music', '" & SettingsMusic & _
        "'", "'custm', '" & SettingsCustM & "'", "'custi', '" & SettingsCustI & _
        "'", "'custb', '" & SettingsCustB & "'", "'custw', '" & SettingsCustW & _
        "'", "'custl', '" & SettingsCustL & "'", "'sound', '" & SettingsSound & _
        "'", "'samedb', '" & SettingsSameDB & "'", "'defaultdb', '" & _ 
        SettingsDefaultDB & "'", "'lastdb', '" & SettingsLastDB & "'"})
    End Sub

    Public Shared Sub GetSettings()
        Dim CurrentSettings() As String = (Database.GetCol(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingConfig").Split(","))
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
    End Sub

End Class