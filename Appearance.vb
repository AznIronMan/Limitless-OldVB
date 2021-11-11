Module Appearance
    Private Sub DarkModeColors()
        MemoryBank.TitleBarBackColor = Color.DarkBlue
        MemoryBank.TitleBarForeColor = Color.WhiteSmoke
        MemoryBank.TitleButtonBackColor = Color.DarkBlue
        MemoryBank.TitleButtonForeColor = Color.WhiteSmoke
        MemoryBank.BackgroundBackColor = Color.FromArgb(22, 22, 22)
        MemoryBank.BackgroundForeColor = Color.WhiteSmoke
        MemoryBank.PagesBackColor = Color.Black
        MemoryBank.PagesForeColor = Color.WhiteSmoke
        MemoryBank.ButtonBackColor = Color.Black
        MemoryBank.ButtonForeColor = Color.WhiteSmoke
        MemoryBank.DonateForeColor = Color.LightGreen
        MemoryBank.DonateHoverOver = Color.Green
        MemoryBank.ButtonMouseDownBack = Color.Black
        MemoryBank.ButtonDisabledColor = Color.Gray
        MemoryBank.HoverBackColor = Color.Black
        MemoryBank.HoverForeColor = Color.Blue
        MemoryBank.LeaveBackColor = Color.Black
        MemoryBank.LeaveForeColor = Color.WhiteSmoke
        MemoryBank.ClickBackColor = Color.Black
        MemoryBank.ClickForeColor = Color.Red
        MemoryBank.GroupBackColor = Color.FromArgb(5, 5, 5)
        MemoryBank.GroupForeColor = Color.WhiteSmoke
    End Sub
    Private Sub LiteModeColors()
        MemoryBank.TitleBarBackColor = SystemColors.Highlight
        MemoryBank.TitleBarForeColor = SystemColors.WindowText
        MemoryBank.TitleButtonBackColor = SystemColors.Highlight
        MemoryBank.TitleButtonForeColor = SystemColors.WindowText
        MemoryBank.BackgroundBackColor = SystemColors.Control
        MemoryBank.BackgroundForeColor = SystemColors.ControlText
        MemoryBank.PagesBackColor = SystemColors.Control
        MemoryBank.PagesForeColor = SystemColors.ControlText
        MemoryBank.ButtonBackColor = SystemColors.Control
        MemoryBank.ButtonForeColor = SystemColors.ControlText
        MemoryBank.DonateForeColor = Color.Green
        MemoryBank.DonateHoverOver = Color.DarkGreen
        MemoryBank.ButtonMouseDownBack = SystemColors.Control
        MemoryBank.ButtonDisabledColor = Color.Gray
        MemoryBank.HoverBackColor = SystemColors.Control
        MemoryBank.HoverForeColor = Color.Blue
        MemoryBank.LeaveBackColor = SystemColors.Control
        MemoryBank.LeaveForeColor = SystemColors.ControlText
        MemoryBank.ClickBackColor = SystemColors.Control
        MemoryBank.ClickForeColor = Color.Red
        MemoryBank.GroupBackColor = SystemColors.Control
        MemoryBank.GroupForeColor = SystemColors.ControlText
    End Sub
    Public Sub AssignMode(mode As String)
        If mode.ToLower = "ugly" Then
            LiteModeColors()
        Else
            DarkModeColors()
        End If
        AssignColor(MainWindow.TitleBarPanel, "TitleBar")
        AssignColor(MainWindow.TitleLabel, "TitleBar")
        AssignColor(MainWindow.BackgroundPanel, "Background")
        AssignColor(MainWindow.MinimizeButton, "TitleButton")
        AssignColor(MainWindow.CloseButton, "TitleButton")
        AssignColor(MainWindow.MinimizeText, "TitleButton")
        AssignColor(MainWindow.CloseText, "TitleButton")
        AssignColor(MainWindow.MainMenuPanel, "Pages")
        AssignColor(MainWindow.FooterPanel, "Pages")
        AssignColor(MainWindow.MainMenuBar, "Pages")
        AssignColor(MainWindow.WelcomePanel, "Pages")
        AssignColor(MainWindow.StartButton, "Button")
        AssignColor(MainWindow.LoadButton, "Button")
        AssignColor(MainWindow.EditButton, "Button")
        AssignColor(MainWindow.OptionsButton, "Button")
        AssignColor(MainWindow.AboutButton, "Button")
        AssignColor(MainWindow.AboutPanel, "Pages")
        AssignColor(MainWindow.AboutText, "Pages")
        AssignColor(MainWindow.AboutFBButton, "Button")
        AssignColor(MainWindow.AboutDCButton, "Button")
        AssignColor(MainWindow.AboutYTButton, "Button")
        AssignColor(MainWindow.AboutBSButton, "Button")
        AssignColor(MainWindow.DonateButton, "Donate")
        AssignColor(MainWindow.DonatePanel, "Pages")
        AssignColor(MainWindow.DonateText, "Pages")
        AssignColor(MainWindow.DonatePTButton, "Button")
        AssignColor(MainWindow.DonatePPButton, "Button")
        AssignColor(MainWindow.UpdateButton, "Button")
        'AssignColor(MainWindow.OptionsPanel, "Background")
        'AssignColor(MainWindow.OptionsColorGroup, "Group")
        'AssignColor(MainWindow.OptionsMusicGroup, "Group")
        'AssignColor(MainWindow.OptionsManageGroup, "Group")
        'AssignColor(MainWindow.OptionsAudioSelectBattle, "Button")
        'AssignColor(MainWindow.OptionsAudioSelectDefeat, "Button")
        'AssignColor(MainWindow.OptionsAudioSelectIntro, "Button")
        'AssignColor(MainWindow.OptionsAudioSelectVictory, "Button")
        'AssignColor(MainWindow.OptionsManageAvatars, "Button")
        'AssignColor(MainWindow.OptionsManageMusic, "Button")
        'AssignColor(MainWindow.OptionsManageSound, "Button")
        AssignColor(MainWindow.ExitButton, "Button")
        'AssignColor(MainWindow.CustomLibsPreviewAvatar, "Group")
        'AssignColor(MainWindow.CustomLibsPreviewMusic, "Group")
        'AssignColor(MainWindow.CustomLibsPreviewPlay, "Button")
        'AssignColor(MainWindow.CustomLibsPreviewStop, "Button")
        'AssignColor(MainWindow.CustomLibsImport, "Button")
        'AssignColor(MainWindow.CustomLibsDelete, "Button")
        'AssignColor(MainWindow.CustomLibsList, "Group")
        'AssignColor(MainWindow.CustomLibsOmega, "Group")
        'AssignColor(MainWindow.CustomLibsPath, "Pages")
        'AssignColor(MainWindow.CustomLibsSave, "Button")
        'AssignColor(MainWindow.CustomLibsGroup, "Group")
        'AssignColor(MainWindow.CustomLibsEdit, "Button")
        'AssignColor(MainWindow.CustomLibsMusicMsg, "Group")
        'AssignColor(MainWindow.CustomLibsMusicImage, "Group")
        AssignColor(MainWindow.SaveButton, "Button")
        AssignColor(MainWindow.NullButton, "Button")
        AssignColor(MainWindow.UpdatePanel, "Pages")
        AssignColor(MainWindow.UpdateTitleText, "Pages")
        AssignColor(MainWindow.UpdateSubText, "Pages")
        AssignColor(MainWindow.UpdateCurText, "Pages")
        AssignColor(MainWindow.UpdateAvaText, "Pages")
        AssignColor(MainWindow.UpdateInstallButton, "Button")
        AssignColor(MainWindow.UpdateCurBox, "Pages")
        AssignColor(MainWindow.UpdateAvaBox, "Pages")
        'AssignColor(MainWindow.EditorPanel, "Pages")
        'AssignColor(MainWindow.EditorTitleText, "Pages")
        'AssignColor(MainWindow.EditorDBText, "Pages")
        'AssignColor(MainWindow.EditorMenuPanel, "Background")
        'AssignColor(MainWindow.EditorImportButton, "Button")
        'AssignColor(MainWindow.EditorDBButton, "Button")
        'AssignColor(MainWindow.EditorExportButton, "Button")
        'AssignColor(MainWindow.EditorAblButton, "Button")
        'AssignColor(MainWindow.EditorLangButton, "Button")
        'AssignColor(MainWindow.EditorArenaButton, "Button")
        'AssignColor(MainWindow.EditorCharButton, "Button")
        'AssignColor(MainWindow.EditorCharmsButton, "Button")
        'AssignColor(MainWindow.EditorClassButton, "Button")
        'AssignColor(MainWindow.EditorDestinyButton, "Button")
        'AssignColor(MainWindow.EditorEffectsButton, "Button")
        'AssignColor(MainWindow.EditorHeldButton, "Button")
        'AssignColor(MainWindow.EditorItemButton, "Button")
        'AssignColor(MainWindow.EditorVerseButton, "Button")
        'AssignColor(MainWindow.EditorRelButton, "Button")
        'AssignColor(MainWindow.EditorStatusButton, "Button")
        'AssignColor(MainWindow.EditorTeamsButton, "Button")
        'AssignColor(MainWindow.EditorWearButton, "Button")
        'AssignColor(MainWindow.EditorSwitchPanel, "Background")
        'AssignColor(MainWindow.EditorSwitchCurText, "Pages")
        'AssignColor(MainWindow.EditorSwitchSDBText, "Pages")
        'AssignColor(MainWindow.EditorSwitchCurBox, "Pages")
        'AssignColor(MainWindow.EditorSwitchTarBox, "Pages")
        'AssignColor(MainWindow.EditorSwitchVerBox, "Pages")
        'AssignColor(MainWindow.EditorSwitchSDBDrop, "Pages")
        'AssignColor(MainWindow.EditorSwitchBackButton, "Button")
        'AssignColor(MainWindow.EditorSwitchNewButton, "Button")
        'AssignColor(MainWindow.EditorSwitchSDBButton, "Button")
        'AssignColor(MainWindow.EditorSwitchNewBox, "Pages")
        'AssignColor(MainWindow.EditorSwitchDupButton, "Button")
        'AssignColor(MainWindow.EditorSwitchDelButton, "Button")
        'AssignColor(MainWindow.EditorEditPanel, "Background")
        'AssignColor(MainWindow.EditorEditList, "Pages")
        'AssignColor(MainWindow.EditorEditCharPanel, "Pages")
        'AssignColor(MainWindow.EditorEditBackButton, "Button")
        'AssignColor(MainWindow.EditorEditAddButton, "Button")
        'AssignColor(MainWindow.EditorEditDelButton, "Button")
        'AssignColor(MainWindow.EditorEditAblPanel, "Pages")
        'AssignColor(MainWindow.EditorEditLangPanel, "Pages")
        'AssignColor(MainWindow.EditorEditArenaPanel, "Pages")
        'AssignColor(MainWindow.EditorEditCharmsPanel, "Pages")
        'AssignColor(MainWindow.EditorEditClassPanel, "Pages")
        'AssignColor(MainWindow.EditorEditDestinyPanel, "Pages")
        'AssignColor(MainWindow.EditorEditEffectsPanel, "Pages")
        'AssignColor(MainWindow.EditorEditHeldsPanel, "Pages")
        'AssignColor(MainWindow.EditorEditItemsPanel, "Pages")
        'AssignColor(MainWindow.EditorEditRelPanel, "Pages")
        'AssignColor(MainWindow.EditorEditStatusPanel, "Pages")
        'AssignColor(MainWindow.EditorEditTeamsPanel, "Pages")
        'AssignColor(MainWindow.EditorEditVersePanel, "Pages")
        'AssignColor(MainWindow.EditorEditWearsPanel, "Pages")
        'AssignColor(MainWindow.EditorCharNameText, "Pages")
        'AssignColor(MainWindow.EditorCharTypeText, "Pages")
        'AssignColor(MainWindow.EditorCharRaceText, "Pages")
        'AssignColor(MainWindow.EditorCharClassText, "Pages")
        'AssignColor(MainWindow.EditorCharAlignText, "Pages")
        'AssignColor(MainWindow.EditorCharGenderText, "Pages")
        'AssignColor(MainWindow.EditorCharAgeText, "Pages")
        'AssignColor(MainWindow.EditorCharLevelText, "Pages")
        'AssignColor(MainWindow.EditorCharDestinyText, "Pages")
        'AssignColor(MainWindow.EditorCharVerseText, "Pages")
        'AssignColor(MainWindow.EditorCharLangText, "Pages")
        'AssignColor(MainWindow.EditorCharForceText, "Pages")
        'AssignColor(MainWindow.EditorCharWebText, "Pages")
        'AssignColor(MainWindow.EditorCharAblText, "Pages")
        'AssignColor(MainWindow.EditorCharEffText, "Pages")
        'AssignColor(MainWindow.EditorCharEffInvText, "Pages")
        'AssignColor(MainWindow.EditorCharDebugText, "Pages")
        'AssignColor(MainWindow.EditorCharNameBox, "Pages")
        'AssignColor(MainWindow.EditorCharAgeBox, "Pages")
        'AssignColor(MainWindow.EditorCharLevelBox, "Pages")
        'AssignColor(MainWindow.EditorCharForceBox, "Pages")
        'AssignColor(MainWindow.EditorCharBioBox, "Pages")
        'AssignColor(MainWindow.EditorCharWebBox, "Pages")
        'AssignColor(MainWindow.EditorCharAvatarBox, "Pages")
        'AssignColor(MainWindow.EditorCharThemeBox, "Pages")
        'AssignColor(MainWindow.EditorCharImageBox, "Group")
        'AssignColor(MainWindow.EditorCharMusicBox, "Group")
        'AssignColor(MainWindow.EditorCharAliasCheck, "Pages")
        'AssignColor(MainWindow.EditorCharForceCheck, "Pages")
        'AssignColor(MainWindow.EditorCharAvatarCheck, "Pages")
        'AssignColor(MainWindow.EditorCharThemeCheck, "Pages")
        'AssignColor(MainWindow.EditorCharAliasList, "Group")
        'AssignColor(MainWindow.EditorCharLangCList, "Group")
        'AssignColor(MainWindow.EditorCharAblList, "Group")
        'AssignColor(MainWindow.EditorCharEffList, "Group")
        'AssignColor(MainWindow.EditorCharEffInvList, "Group")
        'AssignColor(MainWindow.EditorCharTypeDrop, "Pages")
        'AssignColor(MainWindow.EditorCharRaceDrop, "Pages")
        'AssignColor(MainWindow.EditorCharClassDrop, "Pages")
        'AssignColor(MainWindow.EditorCharAlignDrop, "Pages")
        'AssignColor(MainWindow.EditorCharDestinyDrop, "Pages")
        'AssignColor(MainWindow.EditorCharGenderDrop, "Pages")
        'AssignColor(MainWindow.EditorCharVerseDrop, "Pages")
        'AssignColor(MainWindow.EditorCharForceDrop, "Pages")
        'AssignColor(MainWindow.EditorCharTypeHelp, "Pages")
        'AssignColor(MainWindow.EditorCharRaceHelp, "Pages")
        'AssignColor(MainWindow.EditorCharClassHelp, "Pages")
        'AssignColor(MainWindow.EditorCharAlignHelp, "Pages")
        'AssignColor(MainWindow.EditorCharGenderHelp, "Pages")
        'AssignColor(MainWindow.EditorCharAgeHelp, "Pages")
        'AssignColor(MainWindow.EditorCharLevelHelp, "Pages")
        'AssignColor(MainWindow.EditorCharDestinyHelp, "Pages")
        'AssignColor(MainWindow.EditorCharVerseHelp, "Pages")
        'AssignColor(MainWindow.EditorCharAliasHelp, "Pages")
        'AssignColor(MainWindow.EditorCharLangHelp, "Pages")
        'AssignColor(MainWindow.EditorCharForceHelp, "Pages")
        'AssignColor(MainWindow.EditorCharForceHelp2, "Pages")
        'AssignColor(MainWindow.EditorCharWebHelp, "Pages")
        'AssignColor(MainWindow.EditorCharAblHelp, "Pages")
        'AssignColor(MainWindow.EditorCharEffHelp, "Pages")
        'AssignColor(MainWindow.EditorCharEffInvHelp, "Pages")
        'AssignColor(MainWindow.EditorCharEffInvHelp2, "Pages")
        'AssignColor(MainWindow.EditorCharAvatarHelp, "Pages")
        'AssignColor(MainWindow.EditorCharRaceQAdd, "Button")
        'AssignColor(MainWindow.EditorCharClassQAdd, "Button")
        'AssignColor(MainWindow.EditorCharDestinyQAdd, "Button")
        'AssignColor(MainWindow.EditorCharVerseQAdd, "Button")
        'AssignColor(MainWindow.EditorCharAliasNewB, "Button")
        'AssignColor(MainWindow.EditorCharAliasAddB, "Button")
        'AssignColor(MainWindow.EditorCharAliasRemB, "Button")
        'AssignColor(MainWindow.EditorCharLangQAdd, "Button")
        'AssignColor(MainWindow.EditorCharAblQAdd, "Button")
        'AssignColor(MainWindow.EditorCharAblAddB, "Button")
        'AssignColor(MainWindow.EditorCharAblRemB, "Button")
        'AssignColor(MainWindow.EditorCharEffQAdd, "Button")
        'AssignColor(MainWindow.EditorCharEffAddB, "Button")
        'AssignColor(MainWindow.EditorCharAvatarButton, "Button")
        'AssignColor(MainWindow.EditorCharEffRemB, "Button")
        'AssignColor(MainWindow.EditorCharEffInvButton, "Button")
        'AssignColor(MainWindow.EditorCharMusicPlay, "Button")
        'AssignColor(MainWindow.EditorCharMusicStop, "Button")
        'AssignColor(MainWindow.EditorCharThemeButton, "Button")
        'AssignColor(MainWindow.EditorCharSaveButton, "Button")
        'AssignColor(MainWindow.EditorCharCancelButton, "Button")
        'AssignColor(MainWindow.EditorCharQAddPanel, "Pages")
        'AssignColor(MainWindow.EditorCharQAddName, "Pages")
        'AssignColor(MainWindow.EditorCharQAddNewText, "Pages")
        'AssignColor(MainWindow.EditorCharQAddNewBox, "Pages")
        'AssignColor(MainWindow.EditorCharQAddLikeText, "Pages")
        'AssignColor(MainWindow.EditorCharQAddLikeDrop, "Pages")
        'AssignColor(MainWindow.EditorCharQAddButton, "Button")
        'AssignColor(MainWindow.EditorCharQAddCancel, "Button")
        'AssignColor(MainWindow.EditorCharQAddHelp, "Pages")
        'AssignColor(MainWindow.EditorCharQAddRemindText, "Pages")
        'AssignColor(MainWindow.EditorCharInvPanel, "Pages")
        'AssignColor(MainWindow.EditorCharInvText, "Pages")
        'AssignColor(MainWindow.EditorCharInvHelp, "Pages")
        'AssignColor(MainWindow.EditorCharInvList, "Pages")
        'AssignColor(MainWindow.EditorCharInvAddButton, "Button")
        'AssignColor(MainWindow.EditorCharInvEquipButton, "Button")
        'AssignColor(MainWindow.EditorCharInvNameText, "Pages")
        'AssignColor(MainWindow.EditorCharInvClassText, "Pages")
        'AssignColor(MainWindow.EditorCharInvTypeText, "Pages")
        'AssignColor(MainWindow.EditorCharInvResList, "Pages")
        'AssignColor(MainWindow.EditorCharInvAblList, "Pages")
        'AssignColor(MainWindow.EditorCharInvEffList, "Pages")
        'AssignColor(MainWindow.EditorCharInvElemText, "Pages")
        'AssignColor(MainWindow.EditorCharInvQtyText, "Pages")
        'AssignColor(MainWindow.EditorCharInvHeldText, "Pages")
        'AssignColor(MainWindow.EditorCharInvHeldList, "Pages")
        'AssignColor(MainWindow.EditorCharInvWearText, "Pages")
        'AssignColor(MainWindow.EditorCharInvWearList, "Pages")
        'AssignColor(MainWindow.EditorCharInvCharmText, "Pages")
        'AssignColor(MainWindow.EditorCharInvCharmList, "Pages")
        'AssignColor(MainWindow.EditorCharInvItemText, "Pages")
        'AssignColor(MainWindow.EditorCharInvItemList, "Pages")
        'AssignColor(MainWindow.EditorCharInvDoneButton, "Button")
        'AssignColor(MainWindow.EditorCharInvUnequipButton, "Button")
        'AssignColor(MainWindow.EditorCharInvRemoveButton, "Button")
        'AssignColor(MainWindow.EditorCharInvSwitchButton, "Button")
    End Sub
    Public Sub SetButtonStyle(button As Button)
        button.FlatAppearance.MouseDownBackColor = MemoryBank.ButtonMouseDownBack
    End Sub
    Public Sub AssignColor(obj As Control, type As String)
        Select Case type
            Case "TitleBar"
                obj.BackColor = MemoryBank.TitleBarBackColor
                obj.ForeColor = MemoryBank.TitleBarForeColor
            Case "TitleButton"
                obj.BackColor = MemoryBank.TitleButtonBackColor
                obj.ForeColor = MemoryBank.TitleButtonForeColor
            Case "Background"
                obj.BackColor = MemoryBank.BackgroundBackColor
                obj.ForeColor = MemoryBank.BackgroundForeColor
            Case "Pages"
                obj.BackColor = MemoryBank.PagesBackColor
                obj.ForeColor = MemoryBank.PagesForeColor
            Case "Button"
                If obj.Enabled Then
                    obj.BackColor = MemoryBank.ButtonBackColor
                    obj.ForeColor = MemoryBank.ButtonForeColor
                    SetButtonStyle(obj)
                Else
                    obj.BackColor = MemoryBank.ButtonDisabledColor
                    obj.ForeColor = MemoryBank.ButtonForeColor
                    SetButtonStyle(obj)
                End If
            Case "Donate"
                If obj.Enabled Then
                    obj.BackColor = MemoryBank.ButtonBackColor
                    obj.ForeColor = MemoryBank.DonateForeColor
                    SetButtonStyle(obj)
                Else
                    obj.BackColor = MemoryBank.ButtonDisabledColor
                    obj.ForeColor = MemoryBank.DonateForeColor
                    SetButtonStyle(obj)
                End If
            Case "Hover"
                obj.BackColor = MemoryBank.HoverBackColor
                obj.ForeColor = MemoryBank.HoverForeColor
            Case "Leave"
                obj.BackColor = MemoryBank.LeaveBackColor
                obj.ForeColor = MemoryBank.LeaveForeColor
            Case "Click"
                obj.BackColor = MemoryBank.ClickBackColor
                obj.ForeColor = MemoryBank.ClickForeColor
            Case "Group"
                obj.BackColor = MemoryBank.GroupBackColor
                obj.ForeColor = MemoryBank.GroupForeColor
            Case Else
                obj.BackColor = MemoryBank.PagesBackColor
                obj.ForeColor = MemoryBank.PagesForeColor
        End Select
    End Sub
    Public Sub RefreshColors()
        If Settings.SettingsMode = "Lite" Then
            Appearance.AssignMode("Ugly")
        Else
            Appearance.AssignMode("Default")
        End If
    End Sub

End Module
