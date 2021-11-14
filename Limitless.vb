Public Class MainWindow

    'Main Form Code
    Private Sub LimitlessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.InitLoad()
        BuildTitle()
        MemoryBank.ColorModeAtStart = Settings.SettingsMode
        MemoryBank.StartupInProgress = False
    End Sub
    Private Sub BuildTitle()
        Dim ApplicationName, ReleaseType, AppTitleText As String
        ApplicationName = Application.ProductName
        ReleaseType = "ALPHA "
        AppTitleText = ApplicationName & " [" & ReleaseType & "v" & MemoryBank.VersionNumber & "]"
        Me.TitleLabel.Text = AppTitleText
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
        If MemoryBank.WindowDrag Then
            Me.Left = Cursor.Position.X - MemoryBank.WindowMouseX
            Me.Top = Cursor.Position.Y - MemoryBank.WindowMouseY
        End If
    End Sub
    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseDown, TitleLabel.MouseDown, TitleBarIcon.MouseDown
        MemoryBank.WindowDrag = True
        MemoryBank.WindowMouseX = Cursor.Position.X - Me.Left
        MemoryBank.WindowMouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub MinimizeWindow_MouseDown(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseDown, MinimizeText.MouseDown
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles StartButton.MouseHover, UpdateButton.MouseHover, OptionsButton.MouseHover,
        LoadButton.MouseHover, ExitButton.MouseHover, EditButton.MouseHover, DonateButton.MouseHover, AboutButton.MouseHover, UpdateInstallButton.MouseHover,
        StartButton.MouseUp, UpdateButton.MouseUp, OptionsButton.MouseUp, LoadButton.MouseUp, ExitButton.MouseUp, EditButton.MouseUp, AboutButton.MouseUp,
        UpdateInstallButton.MouseUp
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, UpdateButton.MouseLeave, OptionsButton.MouseLeave,
        LoadButton.MouseLeave, ExitButton.MouseLeave, EditButton.MouseLeave, AboutButton.MouseLeave, UpdateInstallButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartButton.MouseDown, UpdateButton.MouseDown, OptionsButton.MouseDown,
        LoadButton.MouseDown, ExitButton.MouseDown, EditButton.MouseDown, DonateButton.MouseDown, AboutButton.MouseDown, UpdateInstallButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp, TitleBarIcon.MouseUp
        MemoryBank.WindowDrag = False
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Tools.TestKeyPress(sender, e.KeyChar.ToString.ToLower)
    End Sub
    Private Sub MenuButtonPressed(activepanel As Panel)
        Tools.SwitchToIntro()
        'If activepanel.Name = "OptionsPanel" Then
        '    Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
        'End If
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = False
        'OptionsPanel.Visible = False
        'EditorPanel.Visible = False
        UpdatePanel.Visible = False
        activepanel.Visible = True
    End Sub
    Private Sub ListLostFocus(listname As Object)
        listname.ClearSelected()
    End Sub
    Private Sub MainMenuBar_Click(sender As Object, e As EventArgs) Handles MainMenuBar.Click
        If WelcomePanel.Visible = False Then
            Dim answer As Integer = MsgBox("Are you sure you want to return to the Main Menu?", vbYesNo)
            If answer = vbYes Then
                Initialize.InitPanels()
            Else
                MsgBox("Action Cancelled", vbOKOnly)
            End If
            'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
        End If
    End Sub

    'Start Game Menu Section
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        NewGame.PrepNewGame()
    End Sub

    'Load Game Menu Section
    'TO DO: Build Load Game Here

    'Options Menu Section
    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        OptionsButtonPressed()
    End Sub
    Private Sub OptionsButtonPressed()
        'MenuButtonPressed(OptionsPanel)
        Optioner.OptionsGroupMove("mid")
        Optioner.FlipOptionsGroups(True)
        Optioner.CheckAllCustomTracks()
    End Sub
    Private Sub OptionsManageAvatars_Click(sender As Object, e As EventArgs)
        Optioner.MoveGroup("avatars")
    End Sub
    Private Sub OptionsManageMusic_Click(sender As Object, e As EventArgs)
        Optioner.MoveGroup("music")
    End Sub
    Private Sub OptionsManageSound_Click(sender As Object, e As EventArgs)
        Optioner.MoveGroup("sound")
    End Sub
    Private Sub OptionsColorDark_CheckedChanged(sender As Object, e As EventArgs)
        Optioner.ColorModeChange("dark")
    End Sub
    Private Sub OptionsColorLite_CheckedChanged(sender As Object, e As EventArgs)
        Optioner.ColorModeChange("lite")
    End Sub
    Private Sub OptionsColorCustom_CheckedChanged(sender As Object, e As EventArgs)
        'TO DO:  Add Custom Color Feature in Optioner.vb
        Optioner.ColorModeChange("custom")
    End Sub
    Private Sub OptionsAudioCheckMusic_CheckedChanged(sender As Object, e As EventArgs)
        'Optioner.OptionsAudioCheckMusic("music", OptionsAudioCheckMusic, OptionsAudioCheckCustom)
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckCustom_CheckedChanged(sender As Object, e As EventArgs)
        'Optioner.OptionsAudioCheckMusic("custom", OptionsAudioCheckCustom, OptionsAudioCheckCustom)
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckIntro_CheckedChanged(sender As Object, e As EventArgs)
        'Optioner.OptionsAudioCheckMusic("intro", OptionsAudioCheckIntro, OptionsAudioCheckCustom)
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckBattle_CheckedChanged(sender As Object, e As EventArgs)
        'Optioner.OptionsAudioCheckMusic("battle", OptionsAudioCheckBattle, OptionsAudioCheckCustom)
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckVictory_CheckedChanged(sender As Object, e As EventArgs)
        'Optioner.OptionsAudioCheckMusic("victory", OptionsAudioCheckVictory, OptionsAudioCheckCustom)
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckDefeat_CheckedChanged(sender As Object, e As EventArgs)
        'Optioner.OptionsAudioCheckMusic("defeat", OptionsAudioCheckDefeat, OptionsAudioCheckCustom)
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckSound_CheckedChanged(sender As Object, e As EventArgs)
        'Optioner.OptionsAudioCheckMusic("sound", OptionsAudioCheckSound, OptionsAudioCheckCustom)
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsGroup_Updater(sender As Object, e As EventArgs)
        'CustomLibsGroup.Text = ("Custom " & Converters.UppercaseEachFirstLetter(MemoryBank.CustomLibsSelected))
    End Sub
    Private Sub CustomLibsAuto_CheckedChanged(sender As Object, e As EventArgs)
        'If CustomLibsActive.CheckState = CheckState.Checked Then
        '    ClarkTribeGames.SQLite.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"on"})
        '    Settings.SettingsAutoSave = "on"
        'Else
        '    ClarkTribeGames.SQLite.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"no"})
        '    Settings.SettingsAutoSave = "off"
        'End If
        'Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    'Private Sub CustomLibsList_Changed(sender As Object, e As EventArgs)
    '    Optioner.CustomLibsListChanged()
    '    Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    'End Sub
    'Private Sub CustomLibsActive_CheckedChanged(sender As Object, e As EventArgs)
    '    Optioner.CustomLibsActiveChanged(CustomLibsActive, CustomLibsList)
    '    Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    'End Sub
    'Private Sub CustomLibsPreviewPlay_Click(sender As Object, e As EventArgs)
    '    Optioner.CustomLibsPreviewPlay(CustomLibsList, CustomLibsPreviewPlay, OptionsAudioCheckMusic)
    '    Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    'End Sub
    'Private Sub CustomLibsPreviewStop_Click(sender As Object, e As EventArgs)
    '    Optioner.CustomLibsPreviewStop()
    '    Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    'End Sub
    'Private Sub CustomLibsEdit_Click(sender As Object, e As EventArgs)
    '    Optioner.CustomLibsEditButton(CustomLibsList, CustomLibsEdit, CustomLibsPath, CustomLibsPreviewImage)
    'End Sub
    'Private Sub CustomLibsDelete_Click(sender As Object, e As EventArgs)
    '    Optioner.CustomLibsDeleteButton(CustomLibsList, CustomLibsDelete, CustomLibsPreviewImage)
    '    Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    'End Sub
    'Private Sub CustomLibsImport_Click(sender As Object, e As EventArgs)
    '    Optioner.CustomLibsImportButton()
    '    Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    'End Sub
    Private Sub SelectTrack_Click(sender As Object, e As EventArgs)
        Optioner.SelectTrackChanges(sender)
    End Sub

    'Save Game Menu Section
    'TO DO:  Build Save Game Here.

    'Future Use Button Section
    'RESERVED FOR FUTURE USE.

    'Donate Menu Section
    Private Sub DonateButtonPressed()
        MenuButtonPressed(DonatePanel)
        Donater.TheDonater("Message", vbNull)
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
    Private Sub DonateImage_Click(sender As Object, e As EventArgs) Handles DonatePTButton.Click, DonatePPButton.Click
        Donater.TheDonater("Button", ClarkTribeGames.Converters.ControlToString(sender))
    End Sub

    'Update Menu Section
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateButtonPressed()
    End Sub
    Private Sub UpdateButtonPressed()
        MenuButtonPressed(UpdatePanel)
    End Sub
    Private Sub UpdateInstallButton_Click(sender As Object, e As EventArgs) Handles UpdateInstallButton.Click
        ClarkTribeGames.Updater.InstallUpdate(Application.ProductName, MemoryBank.UpdaterURL)
    End Sub

    'About Menu Section
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        AboutButtonPressed()
    End Sub
    Private Sub AboutImage_Click(sender As Object, e As EventArgs) Handles AboutFBButton.Click, AboutDCButton.Click, AboutYTButton.Click, AboutBSButton.Click
        Abouter.TheAbouter("Button", ClarkTribeGames.Converters.ControlToString(sender))
    End Sub
    Private Sub AboutText_Enter(sender As Object, e As EventArgs) Handles AboutText.Enter
        AboutTitle.Select()
    End Sub
    Private Sub AboutButtonPressed()
        MenuButtonPressed(AboutPanel)
        Abouter.TheAbouter("Message", vbNull)
    End Sub

    'Exit Menu Section
    Private Sub Exit_Program(sender As Object, e As MouseEventArgs) Handles TitleBarIcon.DoubleClick, CloseButton.MouseDown, CloseText.MouseDown, ExitButton.MouseClick
        Exiter.ExitTheGame()
    End Sub

    'Editor Menu Section
    'Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
    '    MenuButtonPressed(EditorPanel)
    '    Editor.FlipEditorPanels(EditorMenuPanel)
    'End Sub
    'Private Sub EditorBackButton_Click(sender As Object, e As EventArgs)
    '    Editor.FlipEditorPanels(EditorMenuPanel)
    '    MemoryBank.ActiveEditorWindow = ""
    'End Sub
    'Private Sub EditorDBButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorGenDBDrop(EditorSwitchSDBDrop, EditorSwitchDelButton)
    'End Sub
    'Private Sub EditorSwitchSDBDrop_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Editor.EditorSwitchSDBDrop(EditorSwitchSDBDrop, EditorSwitchTarBox, EditorSwitchVerBox, EditorSwitchCurBox, EditorSwitchSDBButton)
    'End Sub
    'Private Sub EditorSwitchNewCheck_CheckedChanged(sender As Object, e As EventArgs)
    '    Editor.EditorSwitchNewActions("check", EditorSwitchNewCheck, EditorSwitchNewBox, EditorSwitchNewButton)
    'End Sub
    'Private Sub EditorSwitchNewBox_KeyPress(sender As Object, e As EventArgs)
    '    Editor.EditorSwitchNewActions("key", EditorSwitchNewCheck, EditorSwitchNewBox, EditorSwitchNewButton)
    'End Sub
    'Private Sub EditorSwitchNewButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorSwitchNewActions("button", EditorSwitchNewCheck, EditorSwitchNewBox, EditorSwitchNewButton)
    'End Sub
    'Private Sub EditorSwitchSDBButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorSwitchButtonActions("switch", EditorSwitchSDBButton, EditorSwitchSDBDrop, EditorSwitchDelButton)
    'End Sub
    'Private Sub EditorSwitchDelButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorSwitchButtonActions("delete", EditorSwitchDelButton, EditorSwitchSDBDrop, EditorSwitchDelButton)
    'End Sub
    'Private Sub EditorSwitchDupButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorSwitchButtonActions("dupe", EditorSwitchDupButton, EditorSwitchSDBDrop, EditorSwitchDelButton)
    'End Sub
    'Private Sub EditorEditList_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Editor.EditorEditDelButtonUpdate(EditorEditList, EditorEditDelButton)
    'End Sub
    'Private Sub EditorCharButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Characters", EditorEditPanel, EditorEditCharPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorAblButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Abilities", EditorEditPanel, EditorEditAblPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorLangButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Languages", EditorEditPanel, EditorEditLangPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorArenaButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Arenas", EditorEditPanel, EditorEditArenaPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorCharmsButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Charms", EditorEditPanel, EditorEditCharmsPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorClassButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Classifications", EditorEditPanel, EditorEditClassPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorDestinyButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Destinies", EditorEditPanel, EditorEditDestinyPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorEffectsButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Effects", EditorEditPanel, EditorEditEffectsPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorHeldButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Handhelds", EditorEditPanel, EditorEditHeldsPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorItemButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Items", EditorEditPanel, EditorEditItemsPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorVerseButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Universes", EditorEditPanel, EditorEditVersePanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorRelButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Relationships", EditorEditPanel, EditorEditRelPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorStatusButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Statuses", EditorEditPanel, EditorEditStatusPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorTeamsButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Teams", EditorEditPanel, EditorEditTeamsPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorWearButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorButtonActions("Wearables", EditorEditPanel, EditorEditWearsPanel, EditorEditDelButton, EditorEditList)
    'End Sub
    'Private Sub EditorEditAddButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorEditAddButtonUpdate(EditorEditAddButton, EditorEditBackButton, EditorEditList)
    'End Sub
    'Private Sub EditorCharCancelButton_Click(sender As Object, e As EventArgs)
    '    Editor.EditorCharCancelButtonUpdate(EditorEditAddButton, EditorEditBackButton, EditorEditList)
    'End Sub
    'Private Sub EditorCharAliasCheck_CheckedChanged(sender As Object, e As EventArgs)
    '    Editor.EditorCharCheckBoxes("standard", EditorCharAliasCheck, EditorCharAliasList)
    'End Sub
    'Private Sub EditorCharForceCheck_CheckedChanged(sender As Object, e As EventArgs)
    '    Editor.EditorCharCheckBoxes("standard", EditorCharForceCheck, EditorCharForceDrop)
    'End Sub

    'Private Sub EditorCharAvatarCheck_CheckedChanged(sender As Object, e As EventArgs)
    '    Editor.EditorCharCheckBoxes("none", EditorCharAvatarCheck, EditorCharAvatarBox)
    'End Sub

    'Private Sub EditorCharThemeCheck_CheckedChanged(sender As Object, e As EventArgs)
    '    Editor.EditorCharCheckBoxes("none", EditorCharThemeCheck, EditorCharThemeBox)
    'End Sub
    'Private Sub EditorCharRaceDrop_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Editor.EditorCharRaceDropChange(EditorCharRaceDrop, EditorCharForceBox, EditorCharAblList, EditorCharEffList, EditorCharBioBox)

    'End Sub

End Class
