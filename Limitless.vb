Public Class MainWindow

    Dim WindowDrag As Boolean
    Dim WindowMouseX, WindowMouseY As Integer
    Dim Highlighted As Boolean = False
    Dim StartupInProgress As Boolean = True
    Dim OptionsGroupLoc As String = "mid"
    Dim CustomLibsSelected As String = "avatars"

    Private Sub LimitlessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.InitProcess()
        UpdateSettings()
        'Formats Title with App Name, Release Type, and Version Number
        Dim ApplicationName, ReleaseType, VersionNumber, AppTitleText As String
        ApplicationName = Application.ProductName
        ReleaseType = "ALPHA "
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & Converters.VersionConverter(VersionParts(2), 3) & "." & Converters.VersionConverter(VersionParts(3), 4)
        AppTitleText = ApplicationName & " [" & ReleaseType & "v" & VersionNumber & "]"
        Me.TitleLabel.Text = AppTitleText
        If Settings.SettingsMusic.ToLower = "on" Then Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
        StartupInProgress = False
    End Sub

    Private Sub HoverOverEffect(obj As Object)
        If obj.Enabled Then
            Appearance.AssignColor(obj, "Hover")
        End If
    End Sub

    Private Sub LeaveObjEffect(obj As Object)
        If obj.Enabled Then
            Appearance.AssignColor(obj, "Leave")
        End If
    End Sub
    Private Sub MouseDownEffect(obj As Object)
        If obj.Enabled Then
            Appearance.AssignColor(obj, "Click")
        End If
    End Sub

    Private Sub AboutButtonPressed()
        WelcomePanel.Visible = False
        AboutPanel.Visible = True
        DonatePanel.Visible = False
        OptionsPanel.Visible = False
        Dim AboutMessage As String = "This application was created by ClarkTribe Games." & Environment.NewLine & Environment.NewLine &
            "It was the development of basically a one man team with the advice, suggestions, and feedback from friends, family, and colleagues." & Environment.NewLine & Environment.NewLine &
            "Limitless is dedicate to the kids of the creator." & Environment.NewLine & Environment.NewLine &
            "Please consider supporting the cause with a donation via the Donate To The Cause button." & Environment.NewLine & Environment.NewLine &
            "The music was provided by BenSound.com.  Please visit their site for some awesome tracks!" & Environment.NewLine & Environment.NewLine &
            "Thank you for your continued support!" & Environment.NewLine & Environment.NewLine &
            "- Geoff Clark @ ClarkTribeGames"
        Tools.TypeWriter(AboutText, 15, AboutMessage)
    End Sub

    Private Sub DonateButtonPressed()
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = True
        OptionsPanel.Visible = False
        Dim DonateMessage As String = "Welcome to Limitless!" & Environment.NewLine & Environment.NewLine &
            "This title is still under development.  Please be patient." & Environment.NewLine & Environment.NewLine &
            "You can become a Patreon or Donate if you want to help support the cause." & Environment.NewLine & Environment.NewLine &
            "Thanks!" & Environment.NewLine & Environment.NewLine &
            "- Geoff Clark @ ClarkTribeGames"
        Tools.TypeWriter(DonateText, 15, DonateMessage)
    End Sub

    Private Sub OptionsButtonPressed()
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = False
        OptionsGroupToMid()
        OptionsPanel.Visible = True
    End Sub

    Private Sub UpdateSettings()
        If Settings.SettingsMode.ToLower = "lite" Then
            OptionsColorLite.CheckState = CheckState.Checked
            OptionsColorDark.CheckState = CheckState.Unchecked
            OptionsColorCustom.CheckState = CheckState.Unchecked
        Else
            OptionsColorDark.CheckState = CheckState.Checked
            OptionsColorLite.CheckState = CheckState.Unchecked
            OptionsColorCustom.CheckState = CheckState.Unchecked
        End If
        If Settings.SettingsMusic.ToLower.StartsWith("on") Then
            OptionsAudioCheckMusic.CheckState = CheckState.Checked
            OptionsAudioCheckCustom.Enabled = True
        Else
            DisableMusicOptions()
            OptionsAudioCheckCustom.Enabled = False
            OptionsAudioCheckMusic.CheckState = CheckState.Unchecked
        End If
        OptionsCheckUncheck(Settings.SettingsCustM, OptionsAudioCheckCustom)
        OptionsCheckUncheck(Settings.SettingsCustI, OptionsAudioCheckIntro)
        OptionsCheckUncheck(Settings.SettingsCustB, OptionsAudioCheckBattle)
        OptionsCheckUncheck(Settings.SettingsCustW, OptionsAudioCheckVictory)
        OptionsCheckUncheck(Settings.SettingsCustL, OptionsAudioCheckDefeat)
        OptionsCheckUncheck(Settings.SettingsSound, OptionsAudioCheckSound)
        OptionsCheckUncheck(Settings.SettingsAutoSave, CustomLibsAuto)
        Dim ReleaseType As String = "ALPHA "
        Dim VersionParts() As String = Strings.Split(Settings.SettingsVersion, ".", 4)
        Dim VersionNumber As String = VersionParts(0) & "." & VersionParts(1) & "." & Converters.VersionConverter(VersionParts(2), 3) & "." & Converters.VersionConverter(VersionParts(3), 4)
        OptionsHost.Text = Settings.SettingsUID & " • " & ReleaseType & "VERSION " & VersionNumber
    End Sub

    Private Sub OptionsCheckUncheck(setting As String, checkbox As CheckBox)
        If setting.ToLower.StartsWith("on") Then
            checkbox.CheckState = CheckState.Checked
        Else
            checkbox.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub OptionsAudioCheckChange(checkbox As CheckBox, button As Button, setting As String, settingvar As String)
        Dim CurrentSetting As String = Database.GetValue(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingConfig", "settingName", setting).Substring(2)
        If OptionsAudioCheckCustom.Checked And OptionsAudioCheckCustom.Enabled Then
            If checkbox.Checked Then
                button.Enabled = True
                button.Visible = True
                Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", setting, {"settingConfig"}, {"on" + CurrentSetting})
                settingvar = "on"
            Else
                button.Enabled = False
                button.Visible = False
                Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", setting, {"settingConfig"}, {"no" + CurrentSetting})
                settingvar = "off"
            End If
        End If
    End Sub

    Private Sub DisableMusicOptions()
        OptionsAudioCheckIntro.Enabled = False
        OptionsAudioCheckBattle.Enabled = False
        OptionsAudioCheckVictory.Enabled = False
        OptionsAudioCheckDefeat.Enabled = False
        OptionsAudioSelectIntro.Enabled = False
        OptionsAudioSelectBattle.Enabled = False
        OptionsAudioSelectVictory.Enabled = False
        OptionsAudioSelectDefeat.Enabled = False
        OptionsAudioSelectIntro.Visible = False
        OptionsAudioSelectBattle.Visible = False
        OptionsAudioSelectVictory.Visible = False
        OptionsAudioSelectDefeat.Visible = False
    End Sub

    Private Sub EnableMusicCheckBoxes()
        OptionsAudioCheckIntro.Enabled = True
        OptionsAudioCheckBattle.Enabled = True
        OptionsAudioCheckVictory.Enabled = True
        OptionsAudioCheckDefeat.Enabled = True
    End Sub

    Private Sub CheckCustomMusicOptions()
        If OptionsAudioCheckIntro.Enabled And OptionsAudioCheckIntro.CheckState = CheckState.Checked Then
            OptionsAudioSelectIntro.Enabled = True
            OptionsAudioSelectIntro.Visible = True
        End If
        If OptionsAudioCheckBattle.Enabled And OptionsAudioCheckBattle.CheckState = CheckState.Checked Then
            OptionsAudioSelectBattle.Enabled = True
            OptionsAudioSelectBattle.Visible = True
        End If
        If OptionsAudioCheckVictory.Enabled And OptionsAudioCheckVictory.CheckState = CheckState.Checked Then
            OptionsAudioSelectVictory.Enabled = True
            OptionsAudioSelectVictory.Visible = True
        End If
        If OptionsAudioCheckDefeat.Enabled And OptionsAudioCheckDefeat.CheckState = CheckState.Checked Then
            OptionsAudioSelectDefeat.Enabled = True
            OptionsAudioSelectDefeat.Visible = True
        End If
    End Sub

    Private Sub ColorModeCheckChange(active As CheckBox, other1 As CheckBox, other2 As CheckBox, setting As String)
        If active.Checked Then
            other1.CheckState = CheckState.Unchecked
            other2.CheckState = CheckState.Unchecked
            Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "mode", {"settingConfig"}, {setting})
            Settings.SettingsMode = setting
            If StartupInProgress = False Then
                Dim answer As Integer
                answer = MsgBox(("Restart of Game Require to Apply Color Mode Change." & vbCrLf & vbCrLf & "Do you want to exit the game now to apply the changes?"), vbExclamation + vbYesNo)
                If answer = vbYes Then ExitGame()
            End If
        End If
    End Sub

    Private Sub ChangeAvatarGroup(button As Button, type As String, other1 As Button, other2 As Button)
        If (CustomLibsGroup.Visible = False And button.ForeColor = MemoryBank.ButtonForeColor) Or (CustomLibsGroup.Visible = True And
            (other1.ForeColor = MemoryBank.ClickForeColor Or other2.ForeColor = MemoryBank.ClickForeColor)) Then
            button.ForeColor = MemoryBank.ClickForeColor
            CustomLibsSelected = type
            OptionsGroupToLeft()
            CustomLibsGroup.Visible = True
            other1.ForeColor = MemoryBank.ButtonForeColor
            other2.ForeColor = MemoryBank.ButtonForeColor
        Else
            button.ForeColor = MemoryBank.ButtonForeColor
            other1.ForeColor = MemoryBank.ButtonForeColor
            other2.ForeColor = MemoryBank.ButtonForeColor
            CustomLibsSelected = vbNull
            OptionsGroupToMid()
            CustomLibsGroup.Visible = False
        End If
    End Sub

    Private Sub ExitGame()
        Close()
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseMove, TitleLabel.MouseMove, TitleBarIcon.MouseMove
        If WindowDrag Then
            Me.Left = Cursor.Position.X - WindowMouseX
            Me.Top = Cursor.Position.Y - WindowMouseY
        End If
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseDown, TitleLabel.MouseDown, TitleBarIcon.MouseDown
        WindowDrag = True
        WindowMouseX = Cursor.Position.X - Me.Left
        WindowMouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub MinimizeWindow_MouseDown(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseDown, MinimizeText.MouseDown
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Exit_Program(sender As Object, e As MouseEventArgs) Handles TitleBarIcon.DoubleClick, CloseButton.MouseDown, CloseText.MouseDown, ExitButton.MouseClick
        ExitGame()
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles StartButton.MouseHover, UpdateButton.MouseHover, OptionsButton.MouseHover, LoadButton.MouseHover, ExitButton.MouseHover, EditButton.MouseHover, DonateButton.MouseHover, AboutButton.MouseHover, StartButton.MouseUp, UpdateButton.MouseUp, OptionsButton.MouseUp, LoadButton.MouseUp, ExitButton.MouseUp, EditButton.MouseUp, AboutButton.MouseUp
        HoverOverEffect(sender)
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, UpdateButton.MouseLeave, OptionsButton.MouseLeave, LoadButton.MouseLeave, ExitButton.MouseLeave, EditButton.MouseLeave, AboutButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartButton.MouseDown, UpdateButton.MouseDown, OptionsButton.MouseDown, LoadButton.MouseDown, ExitButton.MouseDown, EditButton.MouseDown, DonateButton.MouseDown, AboutButton.MouseDown
        MouseDownEffect(sender)
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        AboutButtonPressed()
    End Sub
    Private Sub AboutFBImage_Click(sender As Object, e As EventArgs) Handles AboutFBButton.Click
        Tools.GoToWeb("https://www.facebook.com/clarktribe.games")
    End Sub

    Private Sub AboutDCImage_Click(sender As Object, e As EventArgs) Handles AboutDCButton.Click
        Tools.GoToWeb("https://discord.gg/6kW4der")
    End Sub

    Private Sub AboutYTImage_Click(sender As Object, e As EventArgs) Handles AboutYTButton.Click
        Tools.GoToWeb("https://www.youtube.com/channel/UCjcPw3ApuFduiETIdmAhFAQ")
    End Sub

    Private Sub AboutBSImage_Click(sender As Object, e As EventArgs) Handles AboutBSButton.Click
        Tools.GoToWeb("https://www.bensound.com/")
    End Sub

    Private Sub AboutText_Enter(sender As Object, e As EventArgs) Handles AboutText.Enter
        AboutTitle.Select()
    End Sub

    Private Sub DonateText_Enter(sender As Object, e As EventArgs) Handles DonateText.Enter
        DonateTitle.Select()
    End Sub

    Private Sub DonateButton_MouseLeave(sender As Object, e As EventArgs) Handles DonateButton.MouseLeave
        AssignColor(sender, "Donate")
    End Sub

    Private Sub DonateButton_MouseHover(sender As Object, e As EventArgs) Handles DonateButton.MouseHover, DonateButton.MouseUp
        sender.BackColor = MemoryBank.HoverBackColor
        sender.ForeColor = MemoryBank.DonateHoverOver
    End Sub

    Private Sub DonateButton_Click(sender As Object, e As EventArgs) Handles DonateButton.Click
        DonateButtonPressed()
    End Sub

    Private Sub DonatePTButton_Click(sender As Object, e As EventArgs) Handles DonatePTButton.Click
        Tools.GoToWeb("https://www.patreon.com/clarktribegames")
    End Sub

    Private Sub DonatePPButton_Click(sender As Object, e As EventArgs) Handles DonatePPButton.Click
        Tools.GoToWeb("https://www.paypal.com/paypalme/aznblusuazn")
    End Sub

    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        OptionsButtonPressed()
    End Sub

    Private Sub OptionsManageAvatars_Click(sender As Object, e As EventArgs) Handles OptionsManageAvatars.Click
        ChangeAvatarGroup(OptionsManageAvatars, "avatars", OptionsManageMusic, OptionsManageSound)
    End Sub

    Private Sub OptionsManageMusic_Click(sender As Object, e As EventArgs) Handles OptionsManageMusic.Click
        ChangeAvatarGroup(OptionsManageMusic, "music", OptionsManageAvatars, OptionsManageSound)
    End Sub

    Private Sub OptionsManageSound_Click(sender As Object, e As EventArgs) Handles OptionsManageSound.Click
        ChangeAvatarGroup(OptionsManageSound, "sound", OptionsManageAvatars, OptionsManageMusic)
    End Sub

    Private Sub OptionsColorDark_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsColorDark.CheckStateChanged
        ColorModeCheckChange(OptionsColorDark, OptionsColorLite, OptionsColorCustom, "Dark")
    End Sub

    Private Sub OptionsColorLite_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsColorLite.CheckStateChanged
        ColorModeCheckChange(OptionsColorLite, OptionsColorDark, OptionsColorCustom, "Lite")
    End Sub

    Private Sub OptionsColorCustom_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsColorCustom.CheckedChanged
        ColorModeCheckChange(OptionsColorCustom, OptionsColorLite, OptionsColorDark, "Custom")
        'Need to add custom color option at some point -- right now it is disable, place holder for button
    End Sub

    Private Sub OptionsGroupLocationMove(x As Integer, y As Integer, groupbox As GroupBox)
        groupbox.Location = New Point(x, y)
    End Sub

    Private Sub OptionsGroupToLeft()
        OptionsGroupLocationMove(10, 80, OptionsColorGroup)
        OptionsGroupLocationMove(10, 150, OptionsMusicGroup)
        OptionsGroupLocationMove(10, 350, OptionsManageGroup)
        OptionsGroupLoc = "left"
    End Sub
    Private Sub OptionsGroupToMid()
        OptionsGroupLocationMove(240, 80, OptionsColorGroup)
        OptionsGroupLocationMove(240, 150, OptionsMusicGroup)
        OptionsGroupLocationMove(240, 350, OptionsManageGroup)
        OptionsGroupLoc = "mid"
    End Sub

    Private Sub OptionsAudioCheckMusic_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckMusic.CheckedChanged
        If OptionsAudioCheckMusic.Checked Then
            OptionsAudioCheckCustom.Enabled = True
            Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
            If OptionsAudioCheckCustom.CheckState = CheckState.Checked Then
                EnableMusicCheckBoxes()
                CheckCustomMusicOptions()
            End If
            Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "music", {"settingConfig"}, {"on"})
            Settings.SettingsMusic = "on"
        Else
            DisableMusicOptions()
            OptionsAudioCheckCustom.Enabled = False
            Jukebox.StopSong()
            Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "music", {"settingConfig"}, {"no"})
            Settings.SettingsMusic = "off"
        End If
    End Sub

    Private Sub OptionsAudioCheckCustom_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckCustom.CheckedChanged
        If OptionsAudioCheckCustom.Enabled Then
            If OptionsAudioCheckCustom.Checked Then
                EnableMusicCheckBoxes()
                CheckCustomMusicOptions()
                Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custm", {"settingConfig"}, {"on"})
                Settings.SettingsCustM = "on"
            Else
                DisableMusicOptions()
                Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custm", {"settingConfig"}, {"no"})
                Settings.SettingsCustM = "off"
            End If
        End If
    End Sub

    Private Sub OptionsAudioCheckIntro_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckIntro.CheckedChanged
        OptionsAudioCheckChange(OptionsAudioCheckIntro, OptionsAudioSelectIntro, "custi", Settings.SettingsCustI)
    End Sub

    Private Sub OptionsAudioCheckBattle_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckBattle.CheckedChanged
        OptionsAudioCheckChange(OptionsAudioCheckBattle, OptionsAudioSelectBattle, "custb", Settings.SettingsCustB)
    End Sub

    Private Sub OptionsAudioCheckVictory_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckVictory.CheckedChanged
        OptionsAudioCheckChange(OptionsAudioCheckVictory, OptionsAudioSelectVictory, "custw", Settings.SettingsCustW)
    End Sub

    Private Sub OptionsAudioCheckDefeat_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckDefeat.CheckedChanged
        OptionsAudioCheckChange(OptionsAudioCheckDefeat, OptionsAudioSelectDefeat, "custl", Settings.SettingsCustL)
    End Sub

    Private Sub OptionsAudioCheckSound_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckSound.CheckedChanged
        If (OptionsAudioCheckSound.Enabled And OptionsAudioCheckSound.Checked) Or OptionsAudioCheckSound.Enabled = False Then
            'Insert future method to "turn on sound" here
        ElseIf OptionsAudioCheckSound.Enabled And OptionsAudioCheckSound.CheckState = False Then
            'Insert future method to "turn off sound" here
        End If
    End Sub

    Private Sub OptionsAudioSelectIntro_Click(sender As Object, e As EventArgs) Handles OptionsAudioSelectIntro.Click

    End Sub

    Private Sub CustomLibsGroup_Updater(sender As Object, e As EventArgs) Handles OptionsManageAvatars.ForeColorChanged,
        OptionsManageMusic.ForeColorChanged, OptionsManageSound.ForeColorChanged, CustomLibsGroup.VisibleChanged
        CustomLibsGroup.Text = ("Custom " & Converters.UppercaseFirstLetter(CustomLibsSelected))
    End Sub

    Private Sub CustomLibsAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CustomLibsAuto.CheckedChanged
        If CustomLibsActive.CheckState = CheckState.Checked Then
            Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"on"})
            Settings.SettingsAutoSave = "on"
        Else
            Database.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"no"})
            Settings.SettingsAutoSave = "off"
        End If
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp, TitleBarIcon.MouseUp
        WindowDrag = False
    End Sub

End Class
