Public Class MemoryBank

    'Environmental
    Public Shared BasePath As String = System.IO.Path.Combine(My.Computer.FileSystem.CurrentDirectory)
    Public Shared VersionURL As String = "http://svr.clarktribegames.com:19763/limitless.txt"
    Public Shared UpdaterName As String = "CTGUpdater"
    Public Shared AvatarsDir As String = "avatars"
    Public Shared AvatarsExtF As String = "*.png"
    Public Shared AvatarsExtL As String = AvatarsExtF.Substring(1)
    Public Shared AvatarsExt As String = AvatarsExtF.Substring(2)
    Public Shared DataDir As String = "data"
    Public Shared SavesDir As String = "saves"
    Public Shared SavesExtF As String = "*.limit"
    Public Shared SavesExtL As String = SavesExtF.Substring(1)
    Public Shared SavesExt As String = SavesExtF.Substring(2)
    Public Shared SettingsFile As String = "limitless"
    Public Shared SettingsExtF As String = "*.settings"
    Public Shared SettingsExtL As String = SettingsExtF.Substring(1)
    'Public Shared SettingsExt As String = SettingsExtF.Substring(2)
    Public Shared LibDir As String = "lib"
    Public Shared MusicDir As String = "music"
    Public Shared MusicExtF As String = "*.mp3"
    Public Shared MusicExtL As String = MusicExtF.Substring(1)
    Public Shared MusicExt As String = MusicExtF.Substring(2)
    Public Shared SoundDir As String = "sound"
    Public Shared SoundExtF As String = "*.mp3"
    Public Shared SoundExtL As String = SoundExtF.Substring(1)
    Public Shared SoundExt As String = SoundExtF.Substring(2)
    Public Shared FileExtF As String = "*.exe"
    Public Shared FileExtL As String = FileExtF.Substring(1)
    Public Shared FileExt As String = FileExtF.Substring(2)
    Public Shared LogDir As String = "logs"
    Public Shared LogExtF As String = "*.log"
    Public Shared LogExtL As String = LogExtF.Substring(1)
    Public Shared LogExt As String = LogExtF.Substring(2)
    Public Shared VersionNumber As String = ""
    Public Shared WindowDrag As Boolean
    Public Shared WindowMouseX, WindowMouseY As Integer
    Public Shared StartupInProgress As Boolean = True

    'Editor
    Public Shared ActiveEditorWindow As String = ""

    'Options
    Public Shared OptionsGroupLoc As String = "mid"
    Public Shared SelectCustomTrack As String = ""
    Public Shared CustomLibsSelected As String = "avatars"
    Public Shared ColorModeAtStart As String = ""

    'URLs
    Public Shared PT As String = "https://www.patreon.com/clarktribegames"
    Public Shared PP As String = "https://www.paypal.com/paypalme/aznblusuazn"
    Public Shared FB As String = "https://www.facebook.com/clarktribe.games"
    Public Shared DC As String = "https://discord.gg/6kW4der"
    Public Shared YT As String = "https://www.youtube.com/channel/UCjcPw3ApuFduiETIdmAhFAQ"
    Public Shared BS As String = "https://www.bensound.com"
    Public Shared CW As String = "https://www.facebook.com/WimbleyDesignCo"

    'Colors
    Public Shared TitleBarBackColor As Color
    Public Shared TitleBarForeColor As Color
    Public Shared TitleButtonBackColor As Color
    Public Shared TitleButtonForeColor As Color
    Public Shared BackgroundBackColor As Color
    Public Shared BackgroundForeColor As Color
    Public Shared PagesBackColor As Color
    Public Shared PagesForeColor As Color
    Public Shared ButtonBackColor As Color
    Public Shared ButtonForeColor As Color
    Public Shared ButtonMouseDownBack As Color
    Public Shared ButtonDisabledColor As Color
    Public Shared DonateForeColor As Color
    Public Shared DonateHoverOver As Color
    Public Shared HoverBackColor As Color
    Public Shared HoverForeColor As Color
    Public Shared LeaveBackColor As Color
    Public Shared LeaveForeColor As Color
    Public Shared ClickBackColor As Color
    Public Shared ClickForeColor As Color
    Public Shared GroupBackColor As Color
    Public Shared GroupForeColor As Color

End Class
