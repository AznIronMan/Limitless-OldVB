Public Class MainWindow

    'Limitless Window Variables
    Dim WindowDrag As Boolean
    Dim WindowMouseX, WindowMouseY As Integer
    Dim Highlighted As Boolean = False
    Dim StartupInProgress As Boolean = True
    Dim ColorModeAtStart As String = ""
    Dim OptionsGroupLoc As String = "mid"
    Dim CustomLibsSelected As String = "avatars"
    Dim SelectCustomTrack As String = ""

    'Limitless Form Functions

    Private Sub LimitlessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.InitProcess()
        ColorModeAtStart = Settings.SettingsMode
        UpdateSettings()
        'Formats Title with App Name, Release Type, and Version Number
        Dim ApplicationName, ReleaseType, VersionNumber, AppTitleText As String
        ApplicationName = Application.ProductName
        ReleaseType = "ALPHA "
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & Converters.VersionConverter(VersionParts(2), 3) & "." & Converters.VersionConverter(VersionParts(3), 4)
        UpdateCurBox.Text = VersionNumber
        Database.CheckForDB(Settings.SettingsLastDB)
        Try
            UpdateAvaBox.Text = Tools.GetWebText(MemoryBank.VersionURL)
            UpdateSubText.ForeColor = MemoryBank.PagesForeColor
            CheckForUpdate(UpdateCurBox.Text, UpdateAvaBox.Text)
        Catch ex As Exception
            UpdateAvaBox.Text = "Not Available"
            UpdateSubText.Text = "Error Checking Update Server - Please Check Your Internet Settings"
            UpdateSubText.ForeColor = MemoryBank.DonateForeColor
            UpdateInstallButton.Text = "Not Available"
            Logger.WriteToLog("UpdateCheck", "Could not find update server.", ex)
        End Try
        AppTitleText = ApplicationName & " [" & ReleaseType & "v" & VersionNumber & "]"
        Me.TitleLabel.Text = AppTitleText
        If Settings.SettingsMusic.ToLower = "on" Then
            If Settings.SettingsCustM = "on" And Settings.SettingsCustI.StartsWith("on") Then
                Dim customintro As String = MemoryBank.MusicDir & "/" & Settings.SettingsCustI.Substring(3) & ".mp3"
                If System.IO.File.Exists(customintro) Then Jukebox.PlayMp3(customintro) Else Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
            Else
                Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
            End If
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


    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles StartButton.MouseHover, UpdateButton.MouseHover, OptionsButton.MouseHover,
        LoadButton.MouseHover, ExitButton.MouseHover, EditButton.MouseHover, DonateButton.MouseHover, AboutButton.MouseHover, UpdateInstallButton.MouseHover,
        EditorAblButton.MouseHover, EditorArenaButton.MouseHover, EditorCharmsButton.MouseHover, EditorCharButton.MouseHover, EditorClassButton.MouseHover,
        EditorDestinyButton.MouseHover, EditorItemButton.MouseHover, EditorRelButton.MouseHover, EditorStatusButton.MouseHover,
        EditorVerseButton.MouseHover, EditorHeldButton.MouseHover, EditorWearButton.MouseHover, EditorDBButton.MouseHover,
        EditorImportButton.MouseHover, EditorExportButton.MouseHover, EditorAliasButton.MouseHover, EditorTeamsButton.MouseHover,
        EditorSwitchNewButton.MouseHover, EditorSwitchBackButton.MouseHover, EditorSwitchSDBButton.MouseHover, EditorSwitchDupButton.MouseHover,
        EditorSwitchDelButton.MouseHover,
        StartButton.MouseUp, UpdateButton.MouseUp, OptionsButton.MouseUp, LoadButton.MouseUp, ExitButton.MouseUp, EditButton.MouseUp, AboutButton.MouseUp,
        UpdateInstallButton.MouseUp, EditorAblButton.MouseUp, EditorArenaButton.MouseUp, EditorCharmsButton.MouseUp, EditorCharButton.MouseUp,
        EditorClassButton.MouseUp, EditorDestinyButton.MouseUp, EditorItemButton.MouseUp, EditorRelButton.MouseUp,
        EditorStatusButton.MouseUp, EditorVerseButton.MouseUp, EditorHeldButton.MouseUp, EditorWearButton.MouseUp, EditorDBButton.MouseUp,
        EditorImportButton.MouseUp, EditorExportButton.MouseUp, EditorAliasButton.MouseUp, EditorTeamsButton.MouseUp,
        EditorSwitchNewButton.MouseUp, EditorSwitchBackButton.MouseUp, EditorSwitchSDBButton.MouseUp, EditorSwitchDupButton.MouseUp, EditorSwitchDelButton.MouseUp
        HoverOverEffect(sender)
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, UpdateButton.MouseLeave, OptionsButton.MouseLeave,
        LoadButton.MouseLeave, ExitButton.MouseLeave, EditButton.MouseLeave, AboutButton.MouseLeave, UpdateInstallButton.MouseLeave,
        EditorAblButton.MouseLeave, EditorArenaButton.MouseLeave, EditorCharmsButton.MouseLeave, EditorCharButton.MouseLeave, EditorClassButton.MouseLeave,
        EditorDestinyButton.MouseLeave, EditorItemButton.MouseLeave, EditorRelButton.MouseLeave, EditorStatusButton.MouseLeave,
        EditorVerseButton.MouseLeave, EditorHeldButton.MouseLeave, EditorWearButton.MouseLeave, EditorDBButton.MouseLeave,
        EditorImportButton.MouseLeave, EditorExportButton.MouseLeave, EditorAliasButton.MouseLeave, EditorTeamsButton.MouseLeave,
        EditorSwitchNewButton.MouseLeave, EditorSwitchBackButton.MouseLeave, EditorSwitchSDBButton.MouseLeave, EditorSwitchDupButton.MouseLeave,
        EditorSwitchDelButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartButton.MouseDown, UpdateButton.MouseDown, OptionsButton.MouseDown,
        LoadButton.MouseDown, ExitButton.MouseDown, EditButton.MouseDown, DonateButton.MouseDown, AboutButton.MouseDown, UpdateInstallButton.MouseDown,
        EditorAblButton.MouseDown, EditorArenaButton.MouseDown, EditorCharmsButton.MouseDown, EditorCharButton.MouseDown, EditorClassButton.MouseDown,
        EditorDestinyButton.MouseDown, EditorItemButton.MouseDown, EditorRelButton.MouseDown, EditorStatusButton.MouseDown,
        EditorVerseButton.MouseDown, EditorHeldButton.MouseDown, EditorWearButton.MouseDown, EditorDBButton.MouseDown,
        EditorImportButton.MouseDown, EditorExportButton.MouseDown, EditorAliasButton.MouseDown, EditorTeamsButton.MouseDown,
        EditorSwitchNewButton.MouseDown, EditorSwitchBackButton.MouseDown, EditorSwitchSDBButton.MouseDown, EditorSwitchDupButton.MouseDown,
        EditorSwitchDelButton.MouseDown
        MouseDownEffect(sender)
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp, TitleBarIcon.MouseUp
        WindowDrag = False
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustomLibsPath.KeyPress, EditorSwitchNewBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz -.0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MenuButtonPressed(activepanel As Panel)
        SwitchToIntro()
        ResetEditPath()
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = False
        OptionsPanel.Visible = False
        EditorPanel.Visible = False
        UpdatePanel.Visible = False
        activepanel.Visible = True
    End Sub

    'Exit Button

    Private Sub Exit_Program(sender As Object, e As MouseEventArgs) Handles TitleBarIcon.DoubleClick, CloseButton.MouseDown, CloseText.MouseDown, ExitButton.MouseClick
        Dim answer As Integer
        answer = MsgBox("Are you sure you want to Exit Limitless?", vbYesNo + vbExclamation)
        If answer = vbYes Then ExitGame()
    End Sub

    Private Sub ExitGame()
        Close()
    End Sub

    'Update Section
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateButtonPressed()
    End Sub

    Private Sub UpdateButtonPressed()
        MenuButtonPressed(UpdatePanel)
    End Sub

    Private Sub CheckForUpdate(curver As String, avaver As String)
        Dim currentver, availver As Long
        currentver = CLng(Replace(curver, ".", ""))
        availver = CLng(Replace(avaver, ".", ""))
        If availver > currentver Then
            Dim updatetext = "Update " & avaver & " Available!"
            UpdateChanges(updatetext, MemoryBank.DonateForeColor, True, "Install Update")
            Jukebox.StopSong()
            MsgBox(updatetext & vbCrLf & vbCrLf & "Please Update via the Update Button!", vbOKOnly + vbExclamation)
        Else
            UpdateChanges("Your Game Is Current!", MemoryBank.DonateForeColor, False, "No Update Available")
        End If
    End Sub

    Private Sub UpdateChanges(text As String, color As Color, enable As Boolean, buttontext As String)
        UpdateSubText.Text = text
        UpdateSubText.ForeColor = color
        UpdateInstallButton.Enabled = enable
        UpdateInstallButton.Text = buttontext
        AssignColor(UpdateInstallButton, "Button")
    End Sub

    Private Sub UpdateInstallButton_Click(sender As Object, e As EventArgs) Handles UpdateInstallButton.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = ".\" & MemoryBank.UpdaterName & ".exe"
        pHelp.Arguments = "-Path " & Application.ProductName & " -Dir " &
            (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).Substring(6)
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    'About Section
    Private Sub AboutButtonPressed()
        MenuButtonPressed(AboutPanel)
        Dim AboutMessage As String = "This application was created by ClarkTribe Games." & Environment.NewLine & Environment.NewLine &
            "It was the development of basically a one man team with the advice, suggestions, and feedback from friends, family, and colleagues." & Environment.NewLine & Environment.NewLine &
            "Limitless is dedicate to the kids of the creator." & Environment.NewLine & Environment.NewLine &
            "Please consider supporting the cause with a donation via the Donate To The Cause button." & Environment.NewLine & Environment.NewLine &
            "The music was provided by BenSound.com.  Please visit their site for some awesome tracks!" & Environment.NewLine & Environment.NewLine &
            "Thank you for your continued support!" & Environment.NewLine & Environment.NewLine &
            "- Geoff Clark @ ClarkTribeGames"
        Tools.TypeWriter(AboutText, 15, AboutMessage)
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

    'Donate Section
    Private Sub DonateButtonPressed()
        MenuButtonPressed(DonatePanel)
        Dim DonateMessage As String = "Welcome to Limitless!" & Environment.NewLine & Environment.NewLine &
            "This title is still under development.  Please be patient." & Environment.NewLine & Environment.NewLine &
            "You can become a Patreon or Donate if you want to help support the cause." & Environment.NewLine & Environment.NewLine &
            "Thanks!" & Environment.NewLine & Environment.NewLine &
            "- Geoff Clark @ ClarkTribeGames"
        Tools.TypeWriter(DonateText, 15, DonateMessage)
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

    'Options Section
    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        OptionsButtonPressed()
    End Sub

    Private Sub OptionsButtonPressed()
        MenuButtonPressed(OptionsPanel)
        OptionsGroupToMid()
        CustomLibsGroup.Visible = False
        OptionsManageGroup.Enabled = True
        OptionsMusicGroup.Enabled = True
        OptionsColorGroup.Enabled = True
        OptionsAudioSelectIntro.ForeColor = MemoryBank.ButtonForeColor
        OptionsAudioSelectBattle.ForeColor = MemoryBank.ButtonForeColor
        OptionsAudioSelectVictory.ForeColor = MemoryBank.ButtonForeColor
        OptionsAudioSelectDefeat.ForeColor = MemoryBank.ButtonForeColor
        CheckCustomTracks()
    End Sub

    Private Sub UpdateSettings()
        If Settings.SettingsMode.ToLower = "lite" Then
            OptionsColorLite.CheckState = CheckState.Checked
            OptionsColorLite.Enabled = False
            OptionsColorDark.CheckState = CheckState.Unchecked
            OptionsColorDark.Enabled = True
            OptionsColorCustom.CheckState = CheckState.Unchecked
            'OptionsColorCustom.Enabled = True
        Else
            OptionsColorDark.CheckState = CheckState.Checked
            OptionsColorDark.Enabled = False
            OptionsColorLite.CheckState = CheckState.Unchecked
            OptionsColorLite.Enabled = True
            OptionsColorCustom.CheckState = CheckState.Unchecked
            'OptionsColorCustom.Enabled = True
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
        Dim VersionNumber As String = VersionParts(0) & "." & VersionParts(1) & "." & Converters.VersionConverter(VersionParts(2), 3) &
            "." & Converters.VersionConverter(VersionParts(3), 4)
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
        Dim CurrentSetting As String = DBTools.GetValue(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingConfig", "settingName", setting).Substring(3)
        If OptionsAudioCheckCustom.Checked And OptionsAudioCheckCustom.Enabled Then
            If checkbox.Checked Then
                button.Enabled = True
                button.Visible = True
                settingvar = "on" & "-" & CurrentSetting
            Else
                button.Enabled = False
                button.Visible = False
                settingvar = "of" & "-" & CurrentSetting
            End If
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
        OptionsAudioTextIntro.Visible = False
        OptionsAudioTextBattle.Visible = False
        OptionsAudioTextVictory.Visible = False
        OptionsAudioTextDefeat.Visible = False
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
            OptionsAudioTextIntro.Visible = True
        End If
        If OptionsAudioCheckBattle.Enabled And OptionsAudioCheckBattle.CheckState = CheckState.Checked Then
            OptionsAudioSelectBattle.Enabled = True
            OptionsAudioSelectBattle.Visible = True
            OptionsAudioTextBattle.Visible = True
        End If
        If OptionsAudioCheckVictory.Enabled And OptionsAudioCheckVictory.CheckState = CheckState.Checked Then
            OptionsAudioSelectVictory.Enabled = True
            OptionsAudioSelectVictory.Visible = True
            OptionsAudioTextVictory.Visible = True
        End If
        If OptionsAudioCheckDefeat.Enabled And OptionsAudioCheckDefeat.CheckState = CheckState.Checked Then
            OptionsAudioSelectDefeat.Enabled = True
            OptionsAudioSelectDefeat.Visible = True
            OptionsAudioTextDefeat.Visible = True
        End If
    End Sub

    Private Sub CheckCustomTracks()
        CheckCustomTracksProcess(Settings.SettingsCustI, OptionsAudioSelectIntro, OptionsAudioTextIntro, OptionsAudioCheckIntro)
        CheckCustomTracksProcess(Settings.SettingsCustB, OptionsAudioSelectBattle, OptionsAudioTextBattle, OptionsAudioCheckBattle)
        CheckCustomTracksProcess(Settings.SettingsCustW, OptionsAudioSelectVictory, OptionsAudioTextVictory, OptionsAudioCheckVictory)
        CheckCustomTracksProcess(Settings.SettingsCustL, OptionsAudioSelectDefeat, OptionsAudioTextDefeat, OptionsAudioCheckDefeat)
    End Sub

    Private Sub HideCustomTracks()
        OptionsAudioTextIntro.Visible = False
        OptionsAudioTextBattle.Visible = False
        OptionsAudioTextVictory.Visible = False
        OptionsAudioTextDefeat.Visible = False
        OptionsAudioSelectIntro.Visible = False
        OptionsAudioSelectBattle.Visible = False
        OptionsAudioSelectVictory.Visible = False
        OptionsAudioSelectDefeat.Visible = False
    End Sub
    Private Sub ResetEditPath()
        CustomLibsEdit.Text = "Edit Name"
        CustomLibsPath.BackColor = MemoryBank.PagesBackColor
        CustomLibsPath.ReadOnly = True
    End Sub

    Private Sub CheckCustomTracksProcess(custsetting As String, custbutton As Button, custbox As Label, custcheck As CheckBox)
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
        End If
    End Sub

    Private Sub ColorModeCheckChange(active As CheckBox, other1 As CheckBox, other2 As CheckBox, setting As String)
        If active.Checked Then
            other1.CheckState = CheckState.Unchecked
            other2.CheckState = CheckState.Unchecked
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "mode", {"settingConfig"}, {setting})
            Settings.SettingsMode = setting
            If Not LCase(ColorModeAtStart) = LCase(setting) Then
                Dim choice As Integer = MsgBox(("Changing the Color Mode will Require a Restart of the Game." & vbCrLf & vbCrLf & "Are you sure you want to continue?"),
                    vbExclamation + vbYesNo)
                If choice = vbYes Then
                    ExitGame()
                Else
                    setting = ColorModeAtStart
                    DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "mode", {"settingConfig"}, {setting})
                    Settings.SettingsMode = setting
                    MsgBox("Action Cancelled!", vbOKOnly)
                    Select Case (LCase(Settings.SettingsMode))
                        Case "dark"
                            OptionsColorDark.CheckState = CheckState.Checked
                            OptionsColorLite.CheckState = CheckState.Unchecked
                            OptionsColorCustom.CheckState = CheckState.Unchecked
                        Case "lite"
                            OptionsColorDark.CheckState = CheckState.Unchecked
                            OptionsColorLite.CheckState = CheckState.Checked
                            OptionsColorCustom.CheckState = CheckState.Unchecked
                        Case Else
                            OptionsColorDark.CheckState = CheckState.Unchecked
                            OptionsColorLite.CheckState = CheckState.Unchecked
                            OptionsColorCustom.CheckState = CheckState.Checked
                    End Select
                End If
            End If
        End If
        ResetEditPath()
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
                FlipTracksChanges()
                CustomLibsPreviewAvatar.Visible = True
                CustomLibsPreviewImage.Image = Nothing
                CustomLibsPreviewMusic.Visible = False
                CustomLibsListPop(True)
            Case Else
                If IntroInPlay = False Then Jukebox.StopSong()
                FlipTracksChanges()
                CustomLibsPreviewAvatar.Visible = False
                CustomLibsPreviewImage.Image = Nothing
                CustomLibsPreviewMusic.Visible = True
                CustomLibsPreviewPlay.Enabled = False
                CustomLibsPreviewStop.Enabled = False
                CustomLibsListPop(True)
        End Select
        ResetEditPath()
    End Sub

    Private Sub SelectTrackChanges(button As Button)
        SelectCustomTrack = ""
        If (CustomLibsGroup.Visible = False) Or (CustomLibsGroup.Visible = True And
            Not button.ForeColor = MemoryBank.ClickForeColor) Then
            SelectCustomTrack = button.Name.ToString
            OptionsGroupToLeft()
            OptionsAudioSelectIntro.ForeColor = MemoryBank.ButtonForeColor
            OptionsAudioSelectBattle.ForeColor = MemoryBank.ButtonForeColor
            OptionsAudioSelectVictory.ForeColor = MemoryBank.ButtonForeColor
            OptionsAudioSelectDefeat.ForeColor = MemoryBank.ButtonForeColor
            button.ForeColor = MemoryBank.ClickForeColor
            If IntroInPlay = False Then Jukebox.StopSong()
            OptionsGroupToLeft()
            CustomLibsGroup.Visible = True
            CustomLibsPreviewAvatar.Visible = False
            CustomLibsPreviewImage.Image = Nothing
            CustomLibsPreviewMusic.Visible = True
            CustomLibsPreviewPlay.Enabled = False
            CustomLibsPreviewStop.Enabled = False
            CustomLibsActive.Visible = False
            CustomLibsEdit.Visible = False
            CustomLibsOmega.Visible = False
            CustomLibsSave.Visible = False
            CustomLibsAuto.Visible = False
            CustomLibsImport.Visible = False
            CustomLibsDelete.Text = "Select"
            CustomLibsSelected = "tracks"
            CustomLibsListPop(False)
        Else
            OptionsGroupToMid()
            CustomLibsGroup.Visible = False
            FlipTracksChanges()
            SelectTrackButtonReverse(button)
        End If
    End Sub

    Private Sub FlipTracksChanges()
        CustomLibsActive.Visible = True
        CustomLibsEdit.Visible = True
        CustomLibsOmega.Visible = True
        CustomLibsSave.Visible = True
        CustomLibsAuto.Visible = True
        CustomLibsImport.Visible = True
        CustomLibsDelete.Text = "Delete"
    End Sub

    Private Sub SelectTrackButtonReverse(button As Button)
        OptionsAudioSelectIntro.ForeColor = MemoryBank.ButtonForeColor
        OptionsAudioSelectBattle.ForeColor = MemoryBank.ButtonForeColor
        OptionsAudioSelectVictory.ForeColor = MemoryBank.ButtonForeColor
        OptionsAudioSelectDefeat.ForeColor = MemoryBank.ButtonForeColor
        SelectCustomTrack = ""
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
        OptionsGroupLocationMove(180, 180, OptionsColorGroup)
        OptionsGroupLocationMove(180, 250, OptionsMusicGroup)
        OptionsGroupLocationMove(180, 450, OptionsManageGroup)
        OptionsGroupLoc = "left"
        ResetEditPath()
    End Sub
    Private Sub OptionsGroupToMid()
        OptionsGroupLocationMove(420, 180, OptionsColorGroup)
        OptionsGroupLocationMove(420, 250, OptionsMusicGroup)
        OptionsGroupLocationMove(420, 450, OptionsManageGroup)
        OptionsGroupLoc = "mid"
        ResetEditPath()
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
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "music", {"settingConfig"}, {"on"})
            Settings.SettingsMusic = "on"
        Else
            DisableMusicOptions()
            OptionsAudioCheckCustom.Enabled = False
            Jukebox.StopSong()
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "music", {"settingConfig"}, {"no"})
            Settings.SettingsMusic = "off"
        End If
        ResetEditPath()
    End Sub

    Private Sub OptionsAudioCheckCustom_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckCustom.CheckedChanged
        If OptionsAudioCheckCustom.Enabled Then
            If OptionsAudioCheckCustom.Checked Then
                EnableMusicCheckBoxes()
                CheckCustomMusicOptions()
                CheckCustomTracks()
                DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custm", {"settingConfig"}, {"on"})
                Settings.SettingsCustM = "on"
            Else
                DisableMusicOptions()
                DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custm", {"settingConfig"}, {"no"})
                Settings.SettingsCustM = "off"
                HideCustomTracks()
            End If
        End If
        Jukebox.IntroInPlay = False
        Jukebox.SwitchToIntro()
        ResetEditPath()
    End Sub

    Private Sub OptionsAudioCheckIntro_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckIntro.CheckedChanged
        If OptionsAudioCheckIntro.Checked = CheckState.Unchecked Then
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custi", {"settingConfig"}, {"off"})
            OptionsAudioTextIntro.Visible = False
            OptionsAudioSelectIntro.Visible = False
        Else
            OptionsAudioCheckChange(OptionsAudioCheckIntro, OptionsAudioSelectIntro, "custi", Settings.SettingsCustI)
            CheckCustomTracksProcess(Settings.SettingsCustI, OptionsAudioSelectIntro, OptionsAudioTextIntro, OptionsAudioCheckIntro)
        End If
        Jukebox.IntroInPlay = False
        Jukebox.SwitchToIntro()
        ResetEditPath()
    End Sub

    Private Sub OptionsAudioCheckBattle_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckBattle.CheckedChanged
        If OptionsAudioCheckBattle.Checked = CheckState.Unchecked Then
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custb", {"settingConfig"}, {"off"})
            OptionsAudioTextBattle.Visible = False
            OptionsAudioSelectBattle.Visible = False
        Else
            OptionsAudioCheckChange(OptionsAudioCheckBattle, OptionsAudioSelectBattle, "custb", Settings.SettingsCustB)
            CheckCustomTracksProcess(Settings.SettingsCustB, OptionsAudioSelectBattle, OptionsAudioTextBattle, OptionsAudioCheckBattle)
        End If
        ResetEditPath()
    End Sub

    Private Sub OptionsAudioCheckVictory_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckVictory.CheckedChanged
        If OptionsAudioCheckVictory.Checked = CheckState.Unchecked Then
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custw", {"settingConfig"}, {"off"})
            OptionsAudioTextVictory.Visible = False
            OptionsAudioSelectVictory.Visible = False
        Else
            OptionsAudioCheckChange(OptionsAudioCheckVictory, OptionsAudioSelectVictory, "custw", Settings.SettingsCustW)
            CheckCustomTracksProcess(Settings.SettingsCustW, OptionsAudioSelectVictory, OptionsAudioTextVictory, OptionsAudioCheckVictory)
        End If
        ResetEditPath()
    End Sub

    Private Sub OptionsAudioCheckDefeat_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckDefeat.CheckedChanged
        If OptionsAudioCheckDefeat.Checked = CheckState.Unchecked Then
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custl", {"settingConfig"}, {"off"})
            OptionsAudioTextDefeat.Visible = False
            OptionsAudioSelectDefeat.Visible = False
        Else
            OptionsAudioCheckChange(OptionsAudioCheckDefeat, OptionsAudioSelectDefeat, "custl", Settings.SettingsCustL)
            CheckCustomTracksProcess(Settings.SettingsCustL, OptionsAudioSelectDefeat, OptionsAudioTextDefeat, OptionsAudioCheckDefeat)
        End If
        ResetEditPath()
    End Sub

    Private Sub OptionsAudioCheckSound_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckSound.CheckedChanged
        If (OptionsAudioCheckSound.Enabled And OptionsAudioCheckSound.Checked) Or OptionsAudioCheckSound.Enabled = False Then
            'Insert future method to "turn on sound" here
        ElseIf OptionsAudioCheckSound.Enabled And OptionsAudioCheckSound.CheckState = False Then
            'Insert future method to "turn off sound" here
        End If
        ResetEditPath()
    End Sub

    Private Sub CustomLibsGroup_Updater(sender As Object, e As EventArgs) Handles OptionsManageAvatars.ForeColorChanged,
        OptionsManageMusic.ForeColorChanged, OptionsManageSound.ForeColorChanged, CustomLibsGroup.VisibleChanged
        CustomLibsGroup.Text = ("Custom " & Converters.UppercaseFirstLetter(CustomLibsSelected))
    End Sub

    Private Sub CustomLibsListPop(omega As Boolean)
        Select Case LCase(CustomLibsSelected)
            Case "avatars"
                Tools.CustomLibsListBuilder(CustomLibsSelected, CustomLibsList, MemoryBank.AvatarsDir, CustomLibsActive,
                    "*.png", CustomLibsImport, omega)
            Case "music"
                Tools.CustomLibsListBuilder(CustomLibsSelected, CustomLibsList, MemoryBank.MusicDir, CustomLibsActive,
                    "*.mp3", CustomLibsImport, omega)
            Case "sounds"
                Tools.CustomLibsListBuilder(CustomLibsSelected, CustomLibsList, MemoryBank.SoundDir, CustomLibsActive,
                    "*.mp3", CustomLibsImport, omega)
            Case "tracks"
                Tools.CustomLibsListBuilder(CustomLibsSelected, CustomLibsList, MemoryBank.MusicDir, CustomLibsActive,
                    "*.mp3", CustomLibsDelete, omega)
            Case Else
                '
        End Select
        CustomLibsPath.Text = ""
        If Not LCase(CustomLibsSelected) = "tracks" Then
            CustomLibsActive.Enabled = False
            CustomLibsActive.CheckState = CheckState.Unchecked
            CustomLibsEdit.Enabled = False
            CustomLibsDelete.Enabled = False
            CustomLibsSave.Visible = False
        Else
            CustomLibsSave.Visible = True
        End If
        ResetEditPath()
    End Sub

    Private Sub CustomLibsAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CustomLibsAuto.CheckedChanged
        If CustomLibsActive.CheckState = CheckState.Checked Then
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"on"})
            Settings.SettingsAutoSave = "on"
        Else
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"no"})
            Settings.SettingsAutoSave = "off"
        End If
        ResetEditPath()
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
                Case "tracks"
                    SelectedDir = MemoryBank.MusicDir
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
                                CustomLibsMusicImage.BackgroundImage = Global.Limitless.My.Resources.Resources.mp3sound
                        End Select
                    End If
                End If
            Next
        Else
            CustomLibsEdit.Enabled = False
            CustomLibsDelete.Enabled = False
            CustomLibsPath.Text = ""
        End If
        ResetEditPath()
    End Sub

    Private Sub CustomLibsActive_CheckedChanged(sender As Object, e As EventArgs) Handles CustomLibsActive.Click
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
            If LCase(Settings.SettingsAutoSave) = "on" Then
                answer = vbYes
            Else
                answer = MsgBox(("The File " & Chr(34) & SelectedFile & Chr(34) & " is currently " & ChangePhrase & "." &
                    vbCrLf & vbCrLf & "Do you want to switch this file to " & ChangeAction & "?"), vbExclamation + vbYesNo)
            End If
            If answer = vbYes Then
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
                        Logger.WriteToLog("Custom " & CustomLibsSelected & " " &
                        Converters.UppercaseFirstLetter(ChangeAction), "Rename Attempt", ex)
                        MsgBox(("Logged Error:  File locked, please try again."), vbOKOnly)
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
                        Logger.WriteToLog("Custom " & CustomLibsSelected & " " &
                        Converters.UppercaseFirstLetter(ChangeAction), "Rename Attempt", ex)
                        MsgBox(("Logged Error:  File locked, please try again."), vbOKOnly)
                    End Try
                    CustomLibsActive.Enabled = True
                    CustomLibsActive.CheckState = CheckState.Unchecked
                    CustomLibsActive.ForeColor = Color.Red
                End If
                If answer = vbYes Then
                    CustomLibsListPop(True)
                    CustomLibsList.SelectedItem = Replace(NewName, "Ω", "Ω ")
                End If
                If Not answer = vbYes Then MsgBox("No Changes Made")
            End If
        End If
        ResetEditPath()
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
        ResetEditPath()
    End Sub

    Private Sub CustomLibsPreviewStop_Click(sender As Object, e As EventArgs) Handles CustomLibsPreviewStop.Click
        Jukebox.ReturnToIntro(CustomLibsPreviewStop, CustomLibsPreviewPlay, CustomLibsList, CustomLibsActive, CustomLibsEdit,
            CustomLibsMusicMsg, OptionsColorGroup, OptionsMusicGroup, OptionsManageGroup, CustomLibsImport, CustomLibsDelete)
        ResetEditPath()
    End Sub

    Private Sub CustomLibsEdit_Click(sender As Object, e As EventArgs) Handles CustomLibsEdit.Click
        Dim SelectedDir = "", Ext = "", SelectedName = CustomLibsList.SelectedItem.ToString, OldFileName
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
        Select Case CustomLibsEdit.Text
            Case "Edit Name"
                If CustomLibsEdit.Enabled = True Then
                    If System.IO.File.Exists(OldFileName) Then
                        Dim TempValue As String = CustomLibsPath.Text
                        CustomLibsPath.BackColor = Color.Red
                        CustomLibsPath.ReadOnly = False
                        CustomLibsPath.Text = TempValue.Substring(0, TempValue.Length - 4)
                        CustomLibsEdit.Text = "Confirm"
                    Else
                        MsgBox("Error: Could not verify file exists, please try again.", vbOKOnly)
                    End If
                End If
            Case "Confirm"
                Dim ClearToGo As Boolean = True
                Dim CheckName = SelectedDir & "/" & Replace(CustomLibsPath.Text, "Ω ", "Ω") & Ext
                If System.IO.File.Exists(CheckName) Then
                    ClearToGo = False
                    MsgBox("The File Name " & CustomLibsPath.Text & " already exists." & vbCrLf &
                        vbCrLf & "Please try it again.", vbOKOnly + vbCritical)
                End If
                If ClearToGo = True Then
                    Dim answer As Integer
                    If LCase(Settings.SettingsAutoSave) = "on" Then
                        answer = vbYes
                    Else
                        answer = MsgBox("Confirm:  Are you sure you want to rename " & OldFileName & " to " &
                            Replace(CustomLibsPath.Text, "Ω ", "Ω") & "?", vbYesNo)
                    End If
                    If answer = vbYes Then
                        If LCase(CustomLibsSelected) = "avatars" Then Avatars.ReleaseAvatarFromBox(CustomLibsPreviewImage)
                        If Not LCase(CustomLibsSelected) = "avatars" Then Jukebox.ReturnToIntro(CustomLibsPreviewStop,
                            CustomLibsPreviewPlay, CustomLibsList, CustomLibsActive, CustomLibsEdit, CustomLibsMusicMsg,
                            OptionsColorGroup, OptionsMusicGroup, OptionsManageGroup, CustomLibsImport, CustomLibsDelete)
                        Try
                            My.Computer.FileSystem.RenameFile(OldFileName, Replace(CustomLibsPath.Text, "Ω ", "Ω") & Ext)
                            ResetEditPath()
                            CustomLibsListPop(True)
                        Catch ex As Exception
                            Logger.WriteToLog("Custom " & CustomLibsSelected & " Rename", "Rename Attempt", ex)
                            MsgBox(("Logged Error:  File locked, please try again." & vbCrLf), vbOKOnly)
                        End Try
                    End If
                End If
            Case Else
                '
        End Select
    End Sub

    Private Sub CustomLibsDelete_Click(sender As Object, e As EventArgs) Handles CustomLibsDelete.Click
        If CustomLibsList.Visible = True And CustomLibsDelete.Enabled = True Then
            Dim SelectedDir = "", Ext = "", SelectedName = CustomLibsList.SelectedItem.ToString, FileToGo As String
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
            Select Case (CustomLibsDelete.Text)
                Case "Delete"
                    FileToGo = SelectedDir & "/" & Replace(SelectedName, "Ω ", "Ω") & Ext
                    If CustomLibsDelete.Enabled = True Then
                        If System.IO.File.Exists(FileToGo) Then
                            Dim answer As Integer
                            If LCase(Settings.SettingsAutoSave) = "on" Then
                                answer = vbYes
                            Else
                                answer = MsgBox("Confirm:  Do you want to delete " & Replace(SelectedName, "Ω ", "Ω") & "?", vbYesNo)
                            End If
                            If answer = vbYes Then
                                If LCase(CustomLibsSelected) = "avatars" Then Avatars.ReleaseAvatarFromBox(CustomLibsPreviewImage)
                                If Not LCase(CustomLibsSelected) = "avatars" Then Jukebox.ReturnToIntro(CustomLibsPreviewStop,
                            CustomLibsPreviewPlay, CustomLibsList, CustomLibsActive, CustomLibsEdit, CustomLibsMusicMsg,
                            OptionsColorGroup, OptionsMusicGroup, OptionsManageGroup, CustomLibsImport, CustomLibsDelete)
                                Try
                                    FilesFolders.DeleteFile(FileToGo)
                                    CustomLibsListPop(True)
                                Catch ex As Exception
                                    Logger.WriteToLog("Custom " & CustomLibsSelected & " Delete", "Delete Attempt", ex)
                                    MsgBox("Logged Error:  File locked, please try again." & vbCrLf, vbOKOnly)
                                End Try

                            Else
                                MsgBox("Operation Cancelled.", vbOKOnly)
                            End If
                        Else
                            MsgBox("Error: Could not verify file exists, please try again.", vbOKOnly)
                        End If
                    End If
                Case "Select"
                    Dim SelectedType As String = ""
                    Dim CustSetting As String = "on-" & SelectedName
                    Dim answer As Integer
                    If LCase(Settings.SettingsAutoSave) = "on" Then
                        answer = vbYes
                    Else
                        answer = MsgBox("Confirm:  Do you want to change the Custom " & SelectCustomTrack.Replace("OptionsAudioSelect", "") _
                            & " with " & SelectedName & "?", vbYesNo)
                    End If
                    If answer = vbYes Then
                        Select Case SelectCustomTrack
                            Case OptionsAudioSelectIntro.Name.ToString
                                SelectedType = "custi"
                                Settings.SettingsCustI = CustSetting
                                OptionsAudioTextIntro.Visible = True
                                OptionsAudioTextIntro.Text = SelectedName
                            Case OptionsAudioSelectBattle.Name.ToString
                                SelectedType = "custb"
                                Settings.SettingsCustB = CustSetting
                                OptionsAudioTextBattle.Visible = True
                                OptionsAudioTextBattle.Text = SelectedName
                            Case OptionsAudioSelectVictory.Name.ToString
                                SelectedType = "custw"
                                Settings.SettingsCustW = CustSetting
                                OptionsAudioTextVictory.Visible = True
                                OptionsAudioTextVictory.Text = SelectedName
                            Case OptionsAudioSelectDefeat.Name.ToString
                                SelectedType = "custl"
                                Settings.SettingsCustL = CustSetting
                                OptionsAudioTextDefeat.Visible = True
                                OptionsAudioTextDefeat.Text = SelectedName
                        End Select
                        DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", SelectedType, {"settingConfig"}, {CustSetting})
                        CheckCustomTracks()
                        If SelectedType = "custi" Then
                            Jukebox.IntroInPlay = False
                            Jukebox.SwitchToIntro()
                        End If
                    End If
            End Select
        End If
        ResetEditPath()
    End Sub

    Private Sub CustomLibsImport_Click(sender As Object, e As EventArgs) Handles CustomLibsImport.Click
        Dim SelectedDir = "", Ext = "", SourceFiles() As String, NewFile As String
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
        Dim fd As OpenFileDialog = New OpenFileDialog With {
            .Title = "Custom " & Converters.UppercaseFirstLetter(CustomLibsSelected) & " File(s) To Import",
            .InitialDirectory = SelectedDir,
            .Filter = Replace(Ext, ".", "") & " Files (*" & Ext & ")|*" & Ext,
            .FilterIndex = 1,
            .RestoreDirectory = True,
            .Multiselect = True
        }
        If fd.ShowDialog() = DialogResult.OK Then
            SourceFiles = fd.FileNames
            For Each SourceFile In SourceFiles
                Dim ConfirmExt As String = SourceFile.Substring(SourceFile.Length - 4, 4)
                If LCase(ConfirmExt) = Ext Then
                    Dim SourceName As String = Replace(SourceFile.Split("\").Last(), Ext, "")
                    NewFile = SelectedDir & "/" & Replace(SourceName, "Ω ", "Ω") & Ext
                    If Not LCase(CustomLibsSelected) = "avatars" Then
                        Try
                            FileSystem.FileCopy(SourceFile, NewFile)
                        Catch ex As Exception
                            Logger.WriteToLog("Custom " & CustomLibsSelected & " Import", "Import Attempt - " &
                                SourceName & Ext, ex)
                            MsgBox(("Logged Error:  Internal copy error, please try again." & vbCrLf), vbOKOnly)
                        End Try
                    Else
                        Try
                            Converters.ResizeImage(SourceFile, NewFile.Substring(0, NewFile.Length - 4), 200, 200)
                        Catch ex As Exception
                            Logger.WriteToLog("Custom " & CustomLibsSelected & " Import", "Import Attempt - " &
                                SourceName & Ext, ex)
                            MsgBox(("Logged Error:  Internal copy error, please try again." & vbCrLf), vbOKOnly)
                        End Try
                    End If
                    CustomLibsListPop(True)
                    Else
                        MsgBox("Invalid file extension.  Please be sure to select a " & Ext & " file.", vbOKOnly + vbCritical)
                End If
            Next
        End If
        ResetEditPath()
    End Sub

    Private Sub SelectTrack_Click(sender As Object, e As EventArgs) Handles OptionsAudioSelectIntro.Click, OptionsAudioSelectBattle.Click,
        OptionsAudioSelectVictory.Click, OptionsAudioSelectDefeat.Click
        SelectTrackChanges(sender)
    End Sub

    'Editor Section

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        MenuButtonPressed(EditorPanel)
        EditorPanelChange(EditorMenuPanel)
    End Sub

    Private Sub EditorPanelChange(activepanel As Panel)
        EditorPanel.Visible = True
        EditorMenuPanel.Visible = False
        EditorSwitchPanel.Visible = False
        activepanel.Visible = True
    End Sub

    Private Sub EditorBackButton_Click(sender As Object, e As EventArgs) Handles EditorSwitchBackButton.Click
        EditorPanelChange(EditorMenuPanel)
    End Sub

    Private Sub EditorDBButton_Click(sender As Object, e As EventArgs) Handles EditorDBButton.Click
        EditorGenerateDBDrop()
    End Sub

    Private Sub EditorGenerateDBDrop()
        EditorPanelChange(EditorSwitchPanel)
        Dim LastDBFound As Boolean = False, DefaultDBFound As Boolean = False, NotFound As String = "<None Available>"
        EditorSwitchSDBDrop.Items.Clear()
        If FilesFolders.CountFiles(MemoryBank.DataDir, "*." & MemoryBank.SavesExt) > 0 Then
            For Each FileName In FilesFolders.GetFilesInFolder(MemoryBank.DataDir)
                EditorSDBEffects(True)
                If FileName.EndsWith(MemoryBank.SavesExt) Then
                    Dim DBName As String = Database.GetDBName(FileName.Replace(MemoryBank.DataDir & "\", ""))
                    Dim DropName As String = (FileName.Replace(MemoryBank.DataDir & "\", "")).Substring(0,
                        (FileName.Replace(MemoryBank.DataDir & "\", "")).Length - ((MemoryBank.SavesExt).Length + 1))
                    If LastDBFound = False And (LCase(DBName) = LCase(Settings.SettingsLastDB)) Then LastDBFound = True
                    If DefaultDBFound = False And (LCase(DBName) = LCase(Settings.SettingsDefaultDB)) Then DefaultDBFound = True
                    EditorSwitchSDBDrop.Items.Add(Converters.UppercaseEachFirstLetter(DropName))
                    EditorSwitchSDBDrop.Sorted = True
                    DBTools.CloseSQL(MemoryBank.DataDir, FileName.Replace(MemoryBank.DataDir & "\", ""))
                End If
            Next
        End If
        If EditorSwitchSDBDrop.Items.Count < 1 Then
            EditorSwitchSDBDrop.Items.Add(NotFound)
            EditorSDBEffects(False)
        End If
        If Not EditorSwitchSDBDrop.SelectedItem = NotFound And LastDBFound = True Then
            EditorSwitchSDBDrop.SelectedIndex = EditorSwitchSDBDrop.FindString(Settings.SettingsLastDB)
        Else
            If Not EditorSwitchSDBDrop.SelectedItem = NotFound And DefaultDBFound = True Then
                EditorSwitchSDBDrop.SelectedIndex = EditorSwitchSDBDrop.FindString(Settings.SettingsDefaultDB)
            Else
                EditorSwitchSDBDrop.SelectedIndex = 0
            End If
        End If
        If EditorSwitchSDBDrop.Items.Count < 2 Then
            EditorSwitchDelButton.Enabled = False
            Appearance.AssignColor(EditorSwitchDelButton, "Button")
        Else
            EditorSwitchDelButton.Enabled = True
            Appearance.AssignColor(EditorSwitchDelButton, "Button")
        End If
    End Sub

    Private Sub EditorSDBEffects(changevalue As Boolean)
        EditorSwitchSDBDrop.Enabled = changevalue
        EditorSwitchSDBButton.Enabled = changevalue
        EditorSwitchDupButton.Enabled = changevalue
        EditorSwitchDelButton.Enabled = changevalue
        EditorSwitchVerBox.Visible = changevalue
        EditorSwitchTarBox.Visible = changevalue
    End Sub

    Private Sub EditorSwitchSDBDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EditorSwitchSDBDrop.SelectedIndexChanged
        EditorSwitchTarBox.Text = Database.GetDBName(EditorSwitchSDBDrop.SelectedItem & "." & MemoryBank.SavesExt)
        EditorSwitchVerBox.Text = DBTools.GetCol(MemoryBank.DataDir, EditorSwitchSDBDrop.SelectedItem &
            "." & MemoryBank.SavesExt, "dbInfo", "dbVersion").Split(",")(0)
        DBTools.CloseSQL(MemoryBank.DataDir, EditorSwitchSDBDrop.SelectedItem & "." & MemoryBank.SavesExt)
        If LCase(EditorSwitchTarBox.Text) = LCase(EditorSwitchCurBox.Text) Then
            EditorSwitchSDBButton.Enabled = False
            Appearance.AssignColor(EditorSwitchSDBButton, "Button")
        Else
            EditorSwitchSDBButton.Enabled = True
            Appearance.AssignColor(EditorSwitchSDBButton, "Button")
        End If
    End Sub

    Private Sub EditorSwitchNewCheck_CheckedChanged(sender As Object, e As EventArgs) Handles EditorSwitchNewCheck.CheckedChanged
        If EditorSwitchNewCheck.CheckState = CheckState.Checked Then
            EditorSwitchNewBox.Text = ""
            EditorSwitchNewBox.Enabled = True
        Else
            EditorSwitchNewBox.Text = ""
            EditorSwitchNewBox.Enabled = False
        End If
    End Sub

    Private Sub EditorSwitchNewBox_KeyPress(sender As Object, e As EventArgs) Handles EditorSwitchNewBox.TextChanged
        If EditorSwitchNewBox.TextLength > 0 Then
            EditorSwitchNewButton.Enabled = True
            Appearance.AssignColor(EditorSwitchNewButton, "Button")
        Else
            EditorSwitchNewButton.Enabled = False
            Appearance.AssignColor(EditorSwitchNewButton, "Button")
        End If
    End Sub

    Private Sub EditorSwitchNewButton_Click(sender As Object, e As EventArgs) Handles EditorSwitchNewButton.Click
        If EditorSwitchNewButton.Enabled = True Then
            Dim NewDBName As String = (Converters.UppercaseEachFirstLetter(EditorSwitchNewBox.Text))
            If Not System.IO.File.Exists(MemoryBank.DataDir & "\" & NewDBName & "." & MemoryBank.SavesExt) Then
                Database.CreateEmptyDB(NewDBName)
                MsgBox("New Database " & NewDBName & " Created!", vbOKOnly)
                EditorSwitchNewCheck.CheckState = CheckState.Unchecked
                EditorGenerateDBDrop()
            Else
                MsgBox("Filename of " & NewDBName & " already exists!  Please try a different name.", vbExclamation + vbOKOnly)
            End If
        End If
    End Sub

    Private Sub EditorSwitchSDBButton_Click(sender As Object, e As EventArgs) Handles EditorSwitchSDBButton.Click
        If EditorSwitchSDBButton.Enabled = True Then
            Dim answer As Integer = MsgBox("Are you sure you want to switch to the " &
                Converters.UppercaseEachFirstLetter(EditorSwitchSDBDrop.Text) & " database file?", vbYesNo)
            If answer = vbYes Then
                Database.CheckForDB(EditorSwitchSDBDrop.Text)
                EditorGenerateDBDrop()
            Else
                MsgBox("Action Cancelled.", vbExclamation + vbOKOnly)
            End If
        End If
    End Sub

    Private Sub EditorSwitchDelButton_Click(sender As Object, e As EventArgs) Handles EditorSwitchDelButton.Click
        If EditorSwitchDelButton.Enabled = True Then
            Dim answer As Integer = MsgBox("Are you sure you want to permanently delete the " &
                Converters.UppercaseEachFirstLetter(EditorSwitchSDBDrop.Text) & " database file?", vbYesNo)
            Dim FileToGo As String = MemoryBank.DataDir & "\" & EditorSwitchSDBDrop.Text & "." & MemoryBank.SavesExt
            If answer = vbYes Then
                Try
                    DBTools.CloseSQL(MemoryBank.DataDir, EditorSwitchSDBDrop.SelectedItem & "." & MemoryBank.SavesExt)
                    If EditorSwitchSDBDrop.SelectedIndex = 0 Then
                        EditorSwitchSDBDrop.SelectedIndex = 1
                    Else
                        EditorSwitchSDBDrop.SelectedIndex = 0
                    End If
                    FilesFolders.DeleteFile(FileToGo)
                    EditorGenerateDBDrop()
                    Database.CheckForDB(EditorSwitchSDBDrop.SelectedItem.ToString)
                Catch ex As Exception
                    Logger.WriteToLog("Database " & FileToGo & " Delete", "Delete Attempt", ex)
                    MsgBox("Logged Error:  File locked, please try again." & vbCrLf, vbOKOnly)
                End Try
            Else
                MsgBox("Action Cancelled.", vbExclamation + vbOKOnly)
            End If
        End If
    End Sub

    Private Sub EditorSwitchDupButton_Click(sender As Object, e As EventArgs) Handles EditorSwitchDupButton.Click
        If EditorSwitchDupButton.Enabled = True Then
            Dim answer As Integer = MsgBox("Are you sure you want to clone the " &
                Converters.UppercaseEachFirstLetter(EditorSwitchSDBDrop.Text) & " database file?", vbYesNo)
            Dim FileToClone As String = MemoryBank.DataDir & "\" & EditorSwitchSDBDrop.Text & "." & MemoryBank.SavesExt
            If answer = vbYes Then
                Try
                    FilesFolders.CopyFile(MemoryBank.DataDir & "\" & EditorSwitchSDBDrop.Text, MemoryBank.SavesExt)
                    EditorGenerateDBDrop()
                Catch ex As Exception
                    Logger.WriteToLog("Database " & FileToClone & " Clone", "Clone Attempt", ex)
                    MsgBox("Logged Error:  File locked, please try again." & vbCrLf, vbOKOnly)
                End Try
            Else
                MsgBox("Action Cancelled.", vbExclamation + vbOKOnly)
            End If
        End If
    End Sub

    'Start Game Section

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        MsgBox("Yeah, we are excited about the game too, but it's not ready yet.  Be patient.  Thanks!" & vbCrLf & vbCrLf & "- Geoff", vbExclamation + vbOKOnly)
        Initialize.InitPanels()
        ResetEditPath()
    End Sub

End Class
