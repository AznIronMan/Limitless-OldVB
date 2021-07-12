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
        If Settings.SettingsMusic.ToLower = "on" Then
            Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
            Jukebox.IntroInPlay = True
        End If
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
        SwitchToIntro()
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
        SwitchToIntro()
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
        SwitchToIntro()
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = False
        OptionsGroupToMid()
        OptionsPanel.Visible = True
        CustomLibsGroup.Visible = False
        OptionsManageGroup.Enabled = True
        OptionsMusicGroup.Enabled = True
        OptionsColorGroup.Enabled = True
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
        Select Case type
            Case "avatars"
                CustomLibsPreviewAvatar.Visible = True
                CustomLibsPreviewImage.Image = Nothing
                CustomLibsPreviewMusic.Visible = False
            Case Else
                If IntroInPlay = False Then Jukebox.StopSong()
                CustomLibsPreviewAvatar.Visible = False
                CustomLibsPreviewImage.Image = Nothing
                CustomLibsPreviewMusic.Visible = True
                CustomLibsPreviewPlay.Enabled = False
                CustomLibsPreviewStop.Enabled = False
        End Select
        CustomLibsListPop()
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
            Jukebox.IntroInPlay = True
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

    Private Sub CustomLibsGroup_Updater(sender As Object, e As EventArgs) Handles OptionsManageAvatars.ForeColorChanged,
        OptionsManageMusic.ForeColorChanged, OptionsManageSound.ForeColorChanged, CustomLibsGroup.VisibleChanged
        CustomLibsGroup.Text = ("Custom " & Converters.UppercaseFirstLetter(CustomLibsSelected))
    End Sub

    Private Sub CustomLibsListPop()
        Select Case LCase(CustomLibsSelected)
            Case "avatars"
                Tools.CustomLibsListBuilder(CustomLibsSelected, CustomLibsList, MemoryBank.AvatarsDir, CustomLibsActive,
                    "*.png", CustomLibsImport)
            Case "music"
                Tools.CustomLibsListBuilder(CustomLibsSelected, CustomLibsList, MemoryBank.MusicDir, CustomLibsActive,
                    "*.mp3", CustomLibsImport)
            Case "sounds"
                Tools.CustomLibsListBuilder(CustomLibsSelected, CustomLibsList, MemoryBank.SoundDir, CustomLibsActive,
                    "*.mp3", CustomLibsImport)
            Case Else
                '
        End Select
        CustomLibsPath.Text = ""
        CustomLibsActive.Enabled = False
        CustomLibsActive.CheckState = CheckState.Unchecked
        CustomLibsAuto.Enabled = False
        CustomLibsAuto.CheckState = CheckState.Unchecked
        CustomLibsEdit.Enabled = False
        CustomLibsDelete.Enabled = False
        CustomLibsSave.Enabled = False
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

    Private Sub CustomLibsList_Changed(sender As Object, e As EventArgs) Handles CustomLibsList.SelectedIndexChanged
        If CustomLibsList.Enabled = True And CustomLibsList.SelectedIndex >= 0 Then
            Dim SelectedName As String = CustomLibsList.SelectedItem.ToString
            Dim SelectedDir As String = ""
            Dim FoundIt As Boolean = False
            Select Case LCase(CustomLibsSelected)
                Case "avatars"
                    SelectedDir = MemoryBank.AvatarsDir
                Case "music"
                    SelectedDir = MemoryBank.MusicDir
                Case "sound"
                    SelectedDir = MemoryBank.SoundDir
                Case Else
                    '
            End Select
            For Each Filename In FilesFolders.GetFilesInFolder(SelectedDir)
                If FoundIt = False Then
                    Dim ShortFileName As String = Replace(Filename, SelectedDir & "\", "", 1)
                    Dim FoundName As String = ShortFileName.Trim().Substring(0, ShortFileName.Length - 4)
                    If FoundName = SelectedName Then
                        FoundIt = True
                        CustomLibsPath.Enabled = True
                        CustomLibsPath.Text = ShortFileName
                        CustomLibsDelete.Enabled = True
                        CustomLibsEdit.Enabled = True
                        CustomLibsActive.Enabled = True
                        CustomLibsActive.CheckState = CheckState.Checked
                        CustomLibsActive.ForeColor = MemoryBank.GroupForeColor
                    End If
                    If Replace(SelectedName, "Ω ", "Ω") = FoundName And FoundIt = False Then
                        FoundIt = True
                        CustomLibsPath.Enabled = True
                        CustomLibsPath.Text = ShortFileName
                        CustomLibsDelete.Enabled = True
                        CustomLibsEdit.Enabled = True
                        CustomLibsActive.Enabled = True
                        CustomLibsActive.CheckState = CheckState.Unchecked
                        CustomLibsActive.ForeColor = Color.Red
                    End If
                    If FoundIt = True Then
                        Select Case LCase(CustomLibsSelected)
                            Case "avatars"
                                CustomLibsPreviewMusic.Visible = False
                                CustomLibsPreviewAvatar.Visible = True
                                CustomLibsPreviewImage.Image = Image.FromFile(Filename)
                                CustomLibsPreviewImage.SizeMode = PictureBoxSizeMode.StretchImage
                            Case Else
                                CustomLibsPreviewAvatar.Visible = False
                                CustomLibsPreviewMusic.Visible = True
                                CustomLibsPreviewPlay.Enabled = True
                        End Select
                    End If
                    End If
            Next
        Else
            CustomLibsEdit.Enabled = False
            CustomLibsDelete.Enabled = False
            CustomLibsPath.Text = ""
        End If
    End Sub

    Private Sub CustomLibsActive_CheckedChanged(sender As Object, e As EventArgs) Handles CustomLibsActive.Click
        'Add AutoSave Check and verification for no autosave
        If CustomLibsActive.Enabled = True Then
            Dim SelectedDir As String = ""
            Dim Ext As String = ""
            Select Case LCase(CustomLibsSelected)
                Case "avatars"
                    SelectedDir = MemoryBank.AvatarsDir
                    Ext = ".png"
                Case "music"
                    SelectedDir = MemoryBank.MusicDir
                    Ext = ".mp3"
                Case "sound"
                    SelectedDir = MemoryBank.SoundDir
                    Ext = ".mp3"
                Case Else
                    '
            End Select
            Dim SelectedFile As String = CustomLibsList.SelectedItem.ToString
            Dim ItemActive As Boolean = True
            Dim ChangePhrase As String, ChangeAction As String
            Dim ChangeIt As Boolean = False
            If SelectedFile.StartsWith("Ω") = True Then ItemActive = False Else ItemActive = True
            Select Case ItemActive
                Case True
                    ChangePhrase = "active"
                    ChangeAction = "inactive"

                Case Else
                    ChangePhrase = "inactive"
                    ChangeAction = "active"
            End Select
            Dim answer As Integer
            Dim NewName = ""
            answer = MsgBox(("The File " & Chr(34) & SelectedFile & Chr(34) & " is currently " & ChangePhrase & "." &
                vbCrLf & vbCrLf & "Do you want to switch this file to " & ChangeAction & "?"), vbExclamation + vbYesNo)
            If answer = vbYes And ItemActive = False Then
                Dim OldName As String = Replace(SelectedFile, "Ω ", "Ω")
                NewName = Replace(SelectedFile, "Ω ", "")
                If LCase(CustomLibsSelected) = "avatars" Then Avatars.ReleaseAvatarFromBox(CustomLibsPreviewImage)
                If Not LCase(CustomLibsSelected) = "avatars" Then Jukebox.ReturnToIntro(CustomLibsPreviewStop,
                    CustomLibsPreviewPlay, CustomLibsList, CustomLibsActive, CustomLibsEdit, CustomLibsMusicMsg,
                    OptionsColorGroup, OptionsMusicGroup, OptionsManageGroup, CustomLibsImport, CustomLibsDelete)
                Try
                    My.Computer.FileSystem.RenameFile(SelectedDir & "/" & OldName & Ext, NewName & Ext)
                Catch ex As Exception
                    MsgBox(("Error:  File locked, please try again."), vbOKOnly)
                End Try
                CustomLibsActive.Enabled = True
                CustomLibsActive.CheckState = CheckState.Checked
                CustomLibsActive.ForeColor = MemoryBank.GroupForeColor

            End If
            If answer = vbYes And ItemActive = True Then
                NewName = "Ω" & SelectedFile
                If LCase(CustomLibsSelected) = "avatars" Then Avatars.ReleaseAvatarFromBox(CustomLibsPreviewImage)
                If Not LCase(CustomLibsSelected) = "avatars" Then Jukebox.ReturnToIntro(CustomLibsPreviewStop,
                    CustomLibsPreviewPlay, CustomLibsList, CustomLibsActive, CustomLibsEdit, CustomLibsMusicMsg,
                    OptionsColorGroup, OptionsMusicGroup, OptionsManageGroup, CustomLibsImport, CustomLibsDelete)
                Try
                    My.Computer.FileSystem.RenameFile(SelectedDir & "/" & SelectedFile & Ext, NewName & Ext)
                Catch ex As Exception
                    MsgBox(("Error:  File locked, please try again."), vbOKOnly)
                End Try
                CustomLibsActive.Enabled = True
                CustomLibsActive.CheckState = CheckState.Unchecked
                CustomLibsActive.ForeColor = Color.Red
            End If
            If answer = vbYes Then
                CustomLibsListPop()
                CustomLibsList.SelectedItem = Replace(NewName, "Ω", "Ω ")
            End If
            If Not answer = vbYes Then MsgBox("No Changes Made")
        End If
    End Sub

    Private Sub CustomLibsPreviewPlay_Click(sender As Object, e As EventArgs) Handles CustomLibsPreviewPlay.Click
        If CustomLibsPreviewPlay.Enabled = True And OptionsAudioCheckMusic.CheckState = CheckState.Checked Then
            Dim SongFile As String = MemoryBank.MusicDir & "/" & Replace(CustomLibsList.SelectedItem, "Ω ", "Ω") & ".mp3"
            Jukebox.StopSong()
            Do Until Jukebox.SongPlaying = False
                Jukebox.StopSong()
            Loop
            Jukebox.IntroInPlay = False
            Jukebox.PlayMp3(SongFile)
            CustomLibsPreviewPlay.Enabled = False
            CustomLibsList.Enabled = False
            CustomLibsPreviewStop.Enabled = True
            CustomLibsActive.Enabled = False
            CustomLibsEdit.Enabled = False
            CustomLibsMusicMsg.Visible = True
            OptionsColorGroup.Enabled = False
            OptionsMusicGroup.Enabled = False
            OptionsManageGroup.Enabled = False
            CustomLibsImport.Enabled = False
            CustomLibsDelete.Enabled = False
            'OptionsManageSound.Enabled = False
        End If
    End Sub

    Private Sub CustomLibsPreviewStop_Click(sender As Object, e As EventArgs) Handles CustomLibsPreviewStop.Click
        Jukebox.ReturnToIntro(CustomLibsPreviewStop, CustomLibsPreviewPlay, CustomLibsList, CustomLibsActive, CustomLibsEdit,
            CustomLibsMusicMsg, OptionsColorGroup, OptionsMusicGroup, OptionsManageGroup, CustomLibsImport, CustomLibsDelete)
    End Sub

    Private Sub CustomLibsEdit_Click(sender As Object, e As EventArgs) Handles CustomLibsEdit.Click
        'Add AutoSave Check and verification for no autosave
        If CustomLibsEdit.Enabled = True Then
            Dim SelectedDir = "", Ext = "", SelectedName = CustomLibsList.SelectedItem.ToString, OldFileName,
                NewFileName As String
            Dim FoundIt As Boolean = False
            Select Case LCase(CustomLibsSelected)
                Case "avatars"
                    SelectedDir = MemoryBank.AvatarsDir
                    Ext = ".png"
                Case "music"
                    SelectedDir = MemoryBank.MusicDir
                    Ext = ".mp3"
                Case "sound"
                    SelectedDir = MemoryBank.SoundDir
                    Ext = ".mp3"
                Case Else
                    '
            End Select
            OldFileName = SelectedDir & "/" & Replace(SelectedName, "Ω ", "Ω") & Ext
            If System.IO.File.Exists(OldFileName) Then
                Dim CompletedAnswer As Boolean = False
                While CompletedAnswer = False
                    Dim CheckName = "", answer As String
                    answer = InputBox("New File Name (alphanumeric and spaces only please)", "Rename" & SelectedName,
                        SelectedName)
                    'check if answer contains non alphanumeric characters with error, if all good continue
                    CheckName = SelectedDir & "/" & Replace(CheckName, "Ω ", "Ω") & Ext
                    If Not System.IO.File.Exists(CheckName) Then
                        CompletedAnswer = True
                    Else
                        MsgBox("Error:  Filename Exists, try again.", vbOKOnly)
                    End If
                End While
                'prompt user for new name with current populated
                'confirm new name doesn't exist - if so, offer alternative?
                My.Computer.FileSystem.RenameFile(OldFileName, NewFileName)
            Else
                MsgBox("Error: Could not verify file exists, please try again.", vbOKOnly)
            End If
        End If
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp, TitleBarIcon.MouseUp
        WindowDrag = False
    End Sub

End Class
