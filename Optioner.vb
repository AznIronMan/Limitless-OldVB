Public Class Optioner

    Public Shared OptionsGroupLoc As String = "mid"
    Public Shared SelectCustomTrack As String = ""
    Public Shared CustomLibsSelected As String = "avatars"

    'Universal Controls

    Public Shared Sub ResetEditPath(editbutton As Button, pathtext As TextBox)
        editbutton.Text = "Edit Name"
        pathtext.BackColor = MemoryBank.PagesBackColor
        pathtext.ReadOnly = True
    End Sub

    'Audio Section

    Public Shared Sub OptionsAudioCheckChange(checkbox As CheckBox, button As Button, setting As String, settingvar As String)
        Dim CurrentSetting As String = DBTools.GetValue(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingConfig", "settingName", setting).Substring(3)
        If MainWindow.OptionsAudioCheckCustom.Checked And MainWindow.OptionsAudioCheckCustom.Enabled Then
            If checkbox.Checked Then
                button.Enabled = True
                button.Visible = True
                settingvar = "on" & "-" & CurrentSetting
            Else
                button.Enabled = False
                button.Visible = False
                settingvar = "of" & "-" & CurrentSetting
            End If
            Appearance.RefreshColors()
            Select Case LCase(setting)
                Case "custi"
                    Settings.SettingsCustI = settingvar
                Case "custb"
                    Settings.SettingsCustB = settingvar
                Case "custw"
                    Settings.SettingsCustW = settingvar
                Case "custl"
                    Settings.SettingsCustL = settingvar
            End Select
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", setting, {"settingConfig"}, {settingvar})
            DBTools.CloseSQL(Settings.SettingsPath, Settings.SettingsName)
        End If
    End Sub
    Public Shared Sub FlipMusicOptions(type As String, action As Boolean)
        Select Case LCase(type)
            Case "options"
                MainWindow.OptionsAudioCheckIntro.Enabled = action
                MainWindow.OptionsAudioCheckBattle.Enabled = action
                MainWindow.OptionsAudioCheckVictory.Enabled = action
                MainWindow.OptionsAudioCheckDefeat.Enabled = action
                MainWindow.OptionsAudioSelectIntro.Enabled = action
                MainWindow.OptionsAudioSelectBattle.Enabled = action
                MainWindow.OptionsAudioSelectVictory.Enabled = action
                MainWindow.OptionsAudioSelectDefeat.Enabled = action
                MainWindow.OptionsAudioSelectIntro.Visible = action
                MainWindow.OptionsAudioSelectBattle.Visible = action
                MainWindow.OptionsAudioSelectVictory.Visible = action
                MainWindow.OptionsAudioSelectDefeat.Visible = action
                MainWindow.OptionsAudioTextIntro.Visible = action
                MainWindow.OptionsAudioTextBattle.Visible = action
                MainWindow.OptionsAudioTextVictory.Visible = action
                MainWindow.OptionsAudioTextDefeat.Visible = action
            Case "checkboxes"
                MainWindow.OptionsAudioCheckIntro.Enabled = action
                MainWindow.OptionsAudioCheckBattle.Enabled = action
                MainWindow.OptionsAudioCheckVictory.Enabled = action
                MainWindow.OptionsAudioCheckDefeat.Enabled = action
            Case "custommusicintro"
                MainWindow.OptionsAudioSelectIntro.Enabled = action
                MainWindow.OptionsAudioSelectIntro.Visible = action
                MainWindow.OptionsAudioTextIntro.Visible = action
            Case "custommusicbattle"
                MainWindow.OptionsAudioSelectBattle.Enabled = action
                MainWindow.OptionsAudioSelectBattle.Visible = action
                MainWindow.OptionsAudioTextBattle.Visible = action
            Case "custommusicvictory"
                MainWindow.OptionsAudioSelectVictory.Enabled = action
                MainWindow.OptionsAudioSelectVictory.Visible = action
                MainWindow.OptionsAudioTextVictory.Visible = action
            Case "custommusicdefeat"
                MainWindow.OptionsAudioSelectDefeat.Enabled = action
                MainWindow.OptionsAudioSelectDefeat.Visible = action
                MainWindow.OptionsAudioTextDefeat.Visible = action
            Case "customtracks"
                MainWindow.OptionsAudioTextIntro.Visible = action
                MainWindow.OptionsAudioTextBattle.Visible = action
                MainWindow.OptionsAudioTextVictory.Visible = action
                MainWindow.OptionsAudioTextDefeat.Visible = action
                MainWindow.OptionsAudioSelectIntro.Visible = action
                MainWindow.OptionsAudioSelectBattle.Visible = action
                MainWindow.OptionsAudioSelectVictory.Visible = action
                MainWindow.OptionsAudioSelectDefeat.Visible = action
        End Select
        Appearance.RefreshColors()
    End Sub

    Public Shared Sub CheckCustomMusicOptions()
        If MainWindow.OptionsAudioCheckIntro.Enabled And MainWindow.OptionsAudioCheckIntro.CheckState = CheckState.Checked Then
            FlipMusicOptions("custommusicintro", True)
        End If
        If MainWindow.OptionsAudioCheckBattle.Enabled And MainWindow.OptionsAudioCheckBattle.CheckState = CheckState.Checked Then
            FlipMusicOptions("custommusicbattle", True)
        End If
        If MainWindow.OptionsAudioCheckVictory.Enabled And MainWindow.OptionsAudioCheckVictory.CheckState = CheckState.Checked Then
            FlipMusicOptions("custommusicvictory", True)
        End If
        If MainWindow.OptionsAudioCheckDefeat.Enabled And MainWindow.OptionsAudioCheckIntro.CheckState = CheckState.Checked Then
            FlipMusicOptions("custommusicdefeat", True)
        End If
    End Sub

    Public Shared Sub CheckCustomTracks(type As String)
        Select Case LCase(type)
            Case "intro"
                CheckCustomTracksProcess(Settings.SettingsCustI, MainWindow.OptionsAudioSelectIntro, MainWindow.OptionsAudioTextIntro, MainWindow.OptionsAudioCheckIntro)
            Case "battle"
                CheckCustomTracksProcess(Settings.SettingsCustB, MainWindow.OptionsAudioSelectBattle, MainWindow.OptionsAudioTextBattle, MainWindow.OptionsAudioCheckBattle)
            Case "victory"
                CheckCustomTracksProcess(Settings.SettingsCustW, MainWindow.OptionsAudioSelectVictory, MainWindow.OptionsAudioTextVictory, MainWindow.OptionsAudioCheckVictory)
            Case "defeat"
                CheckCustomTracksProcess(Settings.SettingsCustL, MainWindow.OptionsAudioSelectDefeat, MainWindow.OptionsAudioTextDefeat, MainWindow.OptionsAudioCheckDefeat)
            Case "all"
                CheckCustomTracks("intro")
                CheckCustomTracks("battle")
                CheckCustomTracks("victory")
                CheckCustomTracks("defeat")
        End Select
    End Sub

    Private Shared Sub CheckCustomTracksProcess(custsetting As String, custbutton As Button, custbox As Label, custcheck As CheckBox)
        If custcheck.CheckState = CheckState.Checked Then
            If LCase(custsetting).StartsWith("on") Then
                Dim tempcustname As String = custsetting.Substring(3)
                custbox.Visible = True
                custbutton.Enabled = True
                custbutton.Visible = True
                If Len(tempcustname) > 0 Then
                    custbox.Text = custsetting.Substring(3)
                Else
                    custbox.Text = "<Empty>"
                End If
            Else
                custbox.Visible = False
                custbutton.Visible = False
            End If
            Appearance.RefreshColors()
        End If
    End Sub

    'Group Section

    Public Shared Sub MoveGroup(manage1 As Button, type As String, manage2 As Button, manage3 As Button)
        ShiftGroup(manage1, type, manage2, manage3)
    End Sub

    Private Shared Sub ShiftGroup(button As Button, type As String, other1 As Button, other2 As Button)
        If (MainWindow.CustomLibsGroup.Visible = False And button.ForeColor = MemoryBank.ButtonForeColor) Or (MainWindow.CustomLibsGroup.Visible = True And
            (other1.ForeColor = MemoryBank.ClickForeColor Or other2.ForeColor = MemoryBank.ClickForeColor)) Then
            button.ForeColor = MemoryBank.ClickForeColor
            CustomLibsSelected = type
            OptionsGroupToLeft()
            MainWindow.CustomLibsGroup.Visible = True
            other1.ForeColor = MemoryBank.ButtonForeColor
            other2.ForeColor = MemoryBank.ButtonForeColor
        Else
            button.ForeColor = MemoryBank.ButtonForeColor
            other1.ForeColor = MemoryBank.ButtonForeColor
            other2.ForeColor = MemoryBank.ButtonForeColor
            CustomLibsSelected = vbNull
            OptionsGroupToMid()
            MainWindow.CustomLibsGroup.Visible = False
        End If
        Select Case type
            Case "avatars"
                FlipTracksChanges()
                MainWindow.CustomLibsPreviewAvatar.Visible = True
                MainWindow.CustomLibsPreviewImage.Image = Nothing
                MainWindow.CustomLibsPreviewMusic.Visible = False
                CustomLibsListPop(True)
            Case Else
                If IntroInPlay = False Then Jukebox.StopSong()
                FlipTracksChanges()
                MainWindow.CustomLibsPreviewAvatar.Visible = False
                MainWindow.CustomLibsPreviewImage.Image = Nothing
                MainWindow.CustomLibsPreviewMusic.Visible = True
                MainWindow.CustomLibsPreviewPlay.Enabled = False
                MainWindow.CustomLibsPreviewStop.Enabled = False
                Appearance.RefreshColors()
                CustomLibsListPop(True)
        End Select
        ResetEditPath(MainWindow.CustomLibsEdit, MainWindow.CustomLibsPath)
    End Sub

    Public Shared Sub SelectTrackChanges(button As Button)
        SelectCustomTrack = ""
        If (MainWindow.CustomLibsGroup.Visible = False) Or (MainWindow.CustomLibsGroup.Visible = True And
            Not button.ForeColor = MemoryBank.ClickForeColor) Then
            SelectCustomTrack = button.Name.ToString
            OptionsGroupToLeft()
            MainWindow.OptionsAudioSelectIntro.ForeColor = MemoryBank.ButtonForeColor
            MainWindow.OptionsAudioSelectBattle.ForeColor = MemoryBank.ButtonForeColor
            MainWindow.OptionsAudioSelectVictory.ForeColor = MemoryBank.ButtonForeColor
            MainWindow.OptionsAudioSelectDefeat.ForeColor = MemoryBank.ButtonForeColor
            button.ForeColor = MemoryBank.ClickForeColor
            If IntroInPlay = False Then Jukebox.StopSong()
            OptionsGroupToLeft()
            MainWindow.CustomLibsGroup.Visible = True
            MainWindow.CustomLibsPreviewAvatar.Visible = False
            MainWindow.CustomLibsPreviewImage.Image = Nothing
            MainWindow.CustomLibsPreviewMusic.Visible = True
            MainWindow.CustomLibsPreviewPlay.Enabled = False
            MainWindow.CustomLibsPreviewStop.Enabled = False
            Appearance.RefreshColors()
            MainWindow.CustomLibsActive.Visible = False
            MainWindow.CustomLibsEdit.Visible = False
            MainWindow.CustomLibsOmega.Visible = False
            MainWindow.CustomLibsSave.Visible = False
            MainWindow.CustomLibsAuto.Visible = False
            MainWindow.CustomLibsImport.Visible = False
            MainWindow.CustomLibsDelete.Text = "Select"
            CustomLibsSelected = "tracks"
            CustomLibsListPop(False)
        Else
            OptionsGroupToMid()
            MainWindow.CustomLibsGroup.Visible = False
            FlipTracksChanges()
            SelectTrackButtonReverse(button)
        End If
    End Sub

    Public Shared Sub OptionsGroupMove(direction As String)
        Select Case LCase(direction)
            Case "mid"
                OptionsGroupToMid()
            Case "left"
                OptionsGroupToLeft()
        End Select
    End Sub

    Private Shared Sub OptionsGroupLocationMove(x As Integer, y As Integer, groupbox As GroupBox)
        groupbox.Location = New Point(x, y)
    End Sub

    Private Shared Sub OptionsGroupToLeft()
        OptionsGroupLocationMove(180, 180, MainWindow.OptionsColorGroup)
        OptionsGroupLocationMove(180, 250, MainWindow.OptionsMusicGroup)
        OptionsGroupLocationMove(180, 450, MainWindow.OptionsManageGroup)
        OptionsGroupLoc = "left"
        ResetEditPath(MainWindow.CustomLibsEdit, MainWindow.CustomLibsPath)
    End Sub
    Private Shared Sub OptionsGroupToMid()
        OptionsGroupLocationMove(420, 180, MainWindow.OptionsColorGroup)
        OptionsGroupLocationMove(420, 250, MainWindow.OptionsMusicGroup)
        OptionsGroupLocationMove(420, 450, MainWindow.OptionsManageGroup)
        OptionsGroupLoc = "mid"
        ResetEditPath(MainWindow.CustomLibsEdit, MainWindow.CustomLibsPath)
    End Sub

    Private Shared Sub FlipTracksChanges()
        MainWindow.CustomLibsActive.Visible = True
        MainWindow.CustomLibsEdit.Visible = True
        MainWindow.CustomLibsOmega.Visible = True
        MainWindow.CustomLibsSave.Visible = True
        MainWindow.CustomLibsAuto.Visible = True
        MainWindow.CustomLibsImport.Visible = True
        MainWindow.CustomLibsDelete.Text = "Delete"
    End Sub

    Public Shared Sub SelectTrackButtonReverse(button As Button)
        MainWindow.OptionsAudioSelectIntro.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectBattle.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectVictory.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectDefeat.ForeColor = MemoryBank.ButtonForeColor
        SelectCustomTrack = ""
    End Sub

    Public Shared Sub CustomLibsListPop(omega As Boolean)
        Select Case LCase(CustomLibsSelected)
            Case "avatars"
                Tools.CustomLibsListBuilder(CustomLibsSelected, MainWindow.CustomLibsList, MemoryBank.AvatarsDir, MainWindow.CustomLibsActive,
                    "*.png", MainWindow.CustomLibsImport, omega)
            Case "music"
                Tools.CustomLibsListBuilder(CustomLibsSelected, MainWindow.CustomLibsList, MemoryBank.MusicDir, MainWindow.CustomLibsActive,
                    "*.mp3", MainWindow.CustomLibsImport, omega)
            Case "sounds"
                Tools.CustomLibsListBuilder(CustomLibsSelected, MainWindow.CustomLibsList, MemoryBank.SoundDir, MainWindow.CustomLibsActive,
                    "*.mp3", MainWindow.CustomLibsImport, omega)
            Case "tracks"
                Tools.CustomLibsListBuilder(CustomLibsSelected, MainWindow.CustomLibsList, MemoryBank.MusicDir, MainWindow.CustomLibsActive,
                    "*.mp3", MainWindow.CustomLibsDelete, omega)
            Case Else
                '
        End Select
        MainWindow.CustomLibsPath.Text = ""
        If Not LCase(CustomLibsSelected) = "tracks" Then
            MainWindow.CustomLibsActive.Enabled = False
            MainWindow.CustomLibsActive.CheckState = CheckState.Unchecked
            MainWindow.CustomLibsEdit.Enabled = False
            MainWindow.CustomLibsDelete.Enabled = False
            MainWindow.CustomLibsSave.Visible = False
        Else
            MainWindow.CustomLibsSave.Visible = True
        End If
        Appearance.RefreshColors()
        Optioner.ResetEditPath(MainWindow.CustomLibsEdit, MainWindow.CustomLibsPath)
    End Sub

    'Color Section

    'Avatar Section

    'Sound Section


End Class
