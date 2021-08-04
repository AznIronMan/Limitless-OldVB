Public Class MainWindow

    'Limitless Window Variables
    Dim WindowDrag As Boolean
    Dim WindowMouseX, WindowMouseY As Integer
    Dim StartupInProgress As Boolean = True
    Dim ActiveEditWindow As String = ""
    Private Sub LimitlessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.InitLoad()
        BuildTitle()
        MemoryBank.ColorModeAtStart = Settings.SettingsMode
        StartupInProgress = False
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
        EditorImportButton.MouseHover, EditorExportButton.MouseHover, EditorLangButton.MouseHover, EditorTeamsButton.MouseHover,
        EditorSwitchNewButton.MouseHover, EditorSwitchBackButton.MouseHover, EditorSwitchSDBButton.MouseHover, EditorSwitchDupButton.MouseHover,
        EditorSwitchDelButton.MouseHover, EditorEditBackButton.MouseHover, EditorEditAddButton.MouseHover, EditorEditDelButton.MouseHover,
        EditorCharRaceQAdd.MouseHover, EditorCharClassQAdd.MouseHover, EditorCharDestinyQAdd.MouseHover, EditorCharVerseQAdd.MouseHover,
        EditorCharAliasNewB.MouseHover, EditorCharAliasAddB.MouseHover, EditorCharAliasRemB.MouseHover, EditorCharEffQAdd.MouseHover,
        EditorCharEffAddB.MouseHover, EditorCharAvatarButton.MouseHover, EditorCharEffRemB.MouseHover, EditorCharEffInvButton.MouseHover,
        EditorCharMusicPlay.MouseHover, EditorCharMusicStop.MouseHover, EditorCharThemeButton.MouseHover, EditorCharSaveButton.MouseHover,
        EditorCharCancelButton.MouseHover, EditorCharAblQAdd.MouseHover, EditorCharLangQAdd.MouseHover, EditorCharQAddButton.MouseHover,
        EditorCharQAddCancel.MouseHover, EditorCharInvAddButton.MouseHover, EditorCharInvEquipButton.MouseHover, EditorCharInvUnequipButton.MouseHover,
        EditorCharInvRemoveButton.MouseHover, EditorCharInvDoneButton.MouseHover, EditorCharInvSwitchButton.MouseHover,
        StartButton.MouseUp, UpdateButton.MouseUp, OptionsButton.MouseUp, LoadButton.MouseUp, ExitButton.MouseUp, EditButton.MouseUp, AboutButton.MouseUp,
        UpdateInstallButton.MouseUp, EditorAblButton.MouseUp, EditorArenaButton.MouseUp, EditorCharmsButton.MouseUp, EditorCharButton.MouseUp,
        EditorClassButton.MouseUp, EditorDestinyButton.MouseUp, EditorItemButton.MouseUp, EditorRelButton.MouseUp,
        EditorStatusButton.MouseUp, EditorVerseButton.MouseUp, EditorHeldButton.MouseUp, EditorWearButton.MouseUp, EditorDBButton.MouseUp,
        EditorImportButton.MouseUp, EditorExportButton.MouseUp, EditorLangButton.MouseUp, EditorTeamsButton.MouseUp,
        EditorSwitchNewButton.MouseUp, EditorSwitchBackButton.MouseUp, EditorSwitchSDBButton.MouseUp, EditorSwitchDupButton.MouseUp,
        EditorSwitchDelButton.MouseUp, EditorEditBackButton.MouseUp, EditorEditAddButton.MouseUp, EditorEditDelButton.MouseUp,
        EditorCharRaceQAdd.MouseUp, EditorCharClassQAdd.MouseUp, EditorCharDestinyQAdd.MouseUp, EditorCharVerseQAdd.MouseUp,
        EditorCharAliasNewB.MouseUp, EditorCharAliasAddB.MouseUp, EditorCharAliasRemB.MouseUp, EditorCharEffQAdd.MouseUp,
        EditorCharEffAddB.MouseUp, EditorCharAvatarButton.MouseUp, EditorCharEffRemB.MouseUp, EditorCharEffInvButton.MouseUp,
        EditorCharMusicPlay.MouseUp, EditorCharMusicStop.MouseUp, EditorCharThemeButton.MouseUp, EditorCharSaveButton.MouseUp,
        EditorCharCancelButton.MouseUp, EditorCharAblQAdd.MouseUp, EditorCharLangQAdd.MouseUp, EditorCharQAddButton.MouseUp, EditorCharQAddCancel.MouseUp,
        EditorCharInvAddButton.MouseUp, EditorCharInvEquipButton.MouseUp, EditorCharInvUnequipButton.MouseUp, EditorCharInvRemoveButton.MouseUp,
        EditorCharInvDoneButton.MouseUp, EditorCharInvSwitchButton.MouseUp
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, UpdateButton.MouseLeave, OptionsButton.MouseLeave,
        LoadButton.MouseLeave, ExitButton.MouseLeave, EditButton.MouseLeave, AboutButton.MouseLeave, UpdateInstallButton.MouseLeave,
        EditorAblButton.MouseLeave, EditorArenaButton.MouseLeave, EditorCharmsButton.MouseLeave, EditorCharButton.MouseLeave, EditorClassButton.MouseLeave,
        EditorDestinyButton.MouseLeave, EditorItemButton.MouseLeave, EditorRelButton.MouseLeave, EditorStatusButton.MouseLeave,
        EditorVerseButton.MouseLeave, EditorHeldButton.MouseLeave, EditorWearButton.MouseLeave, EditorDBButton.MouseLeave,
        EditorImportButton.MouseLeave, EditorExportButton.MouseLeave, EditorLangButton.MouseLeave, EditorTeamsButton.MouseLeave,
        EditorSwitchNewButton.MouseLeave, EditorSwitchBackButton.MouseLeave, EditorSwitchSDBButton.MouseLeave, EditorSwitchDupButton.MouseLeave,
        EditorSwitchDelButton.MouseLeave, EditorEditBackButton.MouseLeave, EditorEditAddButton.MouseLeave, EditorEditDelButton.MouseLeave,
        EditorCharRaceQAdd.MouseLeave, EditorCharClassQAdd.MouseLeave, EditorCharDestinyQAdd.MouseLeave, EditorCharVerseQAdd.MouseLeave,
        EditorCharAliasNewB.MouseLeave, EditorCharAliasAddB.MouseLeave, EditorCharAliasRemB.MouseLeave, EditorCharEffQAdd.MouseLeave,
        EditorCharEffAddB.MouseLeave, EditorCharAvatarButton.MouseLeave, EditorCharEffRemB.MouseLeave, EditorCharEffInvButton.MouseLeave,
        EditorCharMusicPlay.MouseLeave, EditorCharMusicStop.MouseLeave, EditorCharThemeButton.MouseLeave, EditorCharSaveButton.MouseLeave,
        EditorCharCancelButton.MouseLeave, EditorCharAblQAdd.MouseLeave, EditorCharLangQAdd.MouseLeave, EditorCharQAddButton.MouseLeave,
        EditorCharQAddCancel.MouseLeave, EditorCharInvAddButton.MouseLeave, EditorCharInvEquipButton.MouseLeave, EditorCharInvUnequipButton.MouseLeave,
        EditorCharInvRemoveButton.MouseLeave, EditorCharInvDoneButton.MouseLeave, EditorCharInvSwitchButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartButton.MouseDown, UpdateButton.MouseDown, OptionsButton.MouseDown,
        LoadButton.MouseDown, ExitButton.MouseDown, EditButton.MouseDown, DonateButton.MouseDown, AboutButton.MouseDown, UpdateInstallButton.MouseDown,
        EditorAblButton.MouseDown, EditorArenaButton.MouseDown, EditorCharmsButton.MouseDown, EditorCharButton.MouseDown, EditorClassButton.MouseDown,
        EditorDestinyButton.MouseDown, EditorItemButton.MouseDown, EditorRelButton.MouseDown, EditorStatusButton.MouseDown,
        EditorVerseButton.MouseDown, EditorHeldButton.MouseDown, EditorWearButton.MouseDown, EditorDBButton.MouseDown,
        EditorImportButton.MouseDown, EditorExportButton.MouseDown, EditorLangButton.MouseDown, EditorTeamsButton.MouseDown,
        EditorSwitchNewButton.MouseDown, EditorSwitchBackButton.MouseDown, EditorSwitchSDBButton.MouseDown, EditorSwitchDupButton.MouseDown,
        EditorSwitchDelButton.MouseDown, EditorEditBackButton.MouseDown, EditorEditAddButton.MouseDown, EditorEditDelButton.MouseDown,
        EditorCharRaceQAdd.MouseDown, EditorCharClassQAdd.MouseDown, EditorCharDestinyQAdd.MouseDown, EditorCharVerseQAdd.MouseDown,
        EditorCharAliasNewB.MouseDown, EditorCharAliasAddB.MouseDown, EditorCharAliasRemB.MouseDown, EditorCharEffQAdd.MouseDown,
        EditorCharEffAddB.MouseDown, EditorCharAvatarButton.MouseDown, EditorCharEffRemB.MouseDown, EditorCharEffInvButton.MouseDown,
        EditorCharMusicPlay.MouseDown, EditorCharMusicStop.MouseDown, EditorCharThemeButton.MouseDown, EditorCharSaveButton.MouseDown,
        EditorCharCancelButton.MouseDown, EditorCharAblQAdd.MouseDown, EditorCharLangQAdd.MouseDown, EditorCharQAddButton.MouseDown,
        EditorCharQAddCancel.MouseDown, EditorCharInvAddButton.MouseDown, EditorCharInvEquipButton.MouseDown, EditorCharInvUnequipButton.MouseDown,
        EditorCharInvRemoveButton.MouseDown, EditorCharInvDoneButton.MouseDown, EditorCharInvSwitchButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp, TitleBarIcon.MouseUp
        WindowDrag = False
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustomLibsPath.KeyPress, EditorSwitchNewBox.KeyPress
        e.Handled = Tools.TestKeyPress(sender, e.KeyChar.ToString.ToLower)
    End Sub
    Private Sub MenuButtonPressed(activepanel As Panel)
        SwitchToIntro()
        If activepanel.Name = "OptionsPanel" Then
            Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
        End If
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = False
        OptionsPanel.Visible = False
        EditorPanel.Visible = False
        UpdatePanel.Visible = False
        activepanel.Visible = True
    End Sub
    Private Sub ListLostFocus(listname As Object)
        listname.ClearSelected()
    End Sub
    Private Sub Exit_Program(sender As Object, e As MouseEventArgs) Handles TitleBarIcon.DoubleClick, CloseButton.MouseDown, CloseText.MouseDown, ExitButton.MouseClick
        Exiter.ExitTheGame()
    End Sub

    'Update Section
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateButtonPressed()
    End Sub
    Private Sub UpdateButtonPressed()
        MenuButtonPressed(UpdatePanel)
    End Sub
    Private Sub UpdateInstallButton_Click(sender As Object, e As EventArgs) Handles UpdateInstallButton.Click
        Updater.InstallUpdate()
    End Sub
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        AboutButtonPressed()
    End Sub
    Private Sub AboutImage_Click(sender As Object, e As EventArgs) Handles AboutFBButton.Click, AboutDCButton.Click, AboutYTButton.Click, AboutBSButton.Click
        Abouter.TheAbouter("Button", Converters.ControlToString(sender))
    End Sub
    Private Sub AboutText_Enter(sender As Object, e As EventArgs) Handles AboutText.Enter
        AboutTitle.Select()
    End Sub
    Private Sub AboutButtonPressed()
        MenuButtonPressed(AboutPanel)
        Abouter.TheAbouter("Message", vbNull)
    End Sub
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
        Donater.TheDonater("Button", Converters.ControlToString(sender))
    End Sub

    'Options Section
    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        OptionsButtonPressed()
    End Sub
    Private Sub OptionsButtonPressed()
        MenuButtonPressed(OptionsPanel)
        Optioner.OptionsGroupMove("mid")
        Optioner.FlipOptionsGroups(True)
        Optioner.CheckCustomTracks("all")
    End Sub
    Private Sub OptionsManageAvatars_Click(sender As Object, e As EventArgs) Handles OptionsManageAvatars.Click
        Optioner.MoveGroup("avatars")
    End Sub
    Private Sub OptionsManageMusic_Click(sender As Object, e As EventArgs) Handles OptionsManageMusic.Click
        Optioner.MoveGroup("music")
    End Sub
    Private Sub OptionsManageSound_Click(sender As Object, e As EventArgs) Handles OptionsManageSound.Click
        Optioner.MoveGroup("sound")
    End Sub
    Private Sub OptionsColorDark_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsColorDark.CheckStateChanged
        Optioner.ColorModeChange("dark")
    End Sub
    Private Sub OptionsColorLite_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsColorLite.CheckStateChanged
        Optioner.ColorModeChange("lite")
    End Sub
    Private Sub OptionsColorCustom_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsColorCustom.CheckedChanged
        'TO DO:  Add Custom Color Feature in Optioner.vb
        Optioner.ColorModeChange("custom")
    End Sub
    Private Sub OptionsAudioCheckMusic_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckMusic.CheckedChanged
        Optioner.OptionsAudioCheckMusic("music", OptionsAudioCheckMusic, OptionsAudioCheckCustom)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckCustom_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckCustom.CheckedChanged
        Optioner.OptionsAudioCheckMusic("custom", OptionsAudioCheckCustom, OptionsAudioCheckCustom)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckIntro_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckIntro.CheckedChanged
        Optioner.OptionsAudioCheckMusic("intro", OptionsAudioCheckIntro, OptionsAudioCheckCustom)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckBattle_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckBattle.CheckedChanged
        Optioner.OptionsAudioCheckMusic("battle", OptionsAudioCheckBattle, OptionsAudioCheckCustom)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckVictory_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckVictory.CheckedChanged
        Optioner.OptionsAudioCheckMusic("victory", OptionsAudioCheckVictory, OptionsAudioCheckCustom)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckDefeat_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckDefeat.CheckedChanged
        Optioner.OptionsAudioCheckMusic("defeat", OptionsAudioCheckDefeat, OptionsAudioCheckCustom)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub OptionsAudioCheckSound_CheckedChanged(sender As Object, e As EventArgs) Handles OptionsAudioCheckSound.CheckedChanged
        Optioner.OptionsAudioCheckMusic("sound", OptionsAudioCheckSound, OptionsAudioCheckCustom)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsGroup_Updater(sender As Object, e As EventArgs) Handles OptionsManageAvatars.ForeColorChanged,
        OptionsManageMusic.ForeColorChanged, OptionsManageSound.ForeColorChanged, CustomLibsGroup.VisibleChanged
        CustomLibsGroup.Text = ("Custom " & Converters.UppercaseFirstLetter(MemoryBank.CustomLibsSelected))
    End Sub
    Private Sub CustomLibsAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CustomLibsAuto.CheckedChanged
        If CustomLibsActive.CheckState = CheckState.Checked Then
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"on"})
            Settings.SettingsAutoSave = "on"
        Else
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "autosave", {"settingConfig"}, {"no"})
            Settings.SettingsAutoSave = "off"
        End If
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsList_Changed(sender As Object, e As EventArgs) Handles CustomLibsList.SelectedIndexChanged
        Optioner.CustomLibsListChanged()
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsActive_CheckedChanged(sender As Object, e As EventArgs) Handles CustomLibsActive.Click
        Optioner.CustomLibsActiveChanged(CustomLibsActive, CustomLibsList)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsPreviewPlay_Click(sender As Object, e As EventArgs) Handles CustomLibsPreviewPlay.Click
        Optioner.CustomLibsPreviewPlay(CustomLibsList, CustomLibsPreviewPlay, OptionsAudioCheckMusic)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsPreviewStop_Click(sender As Object, e As EventArgs) Handles CustomLibsPreviewStop.Click
        Optioner.CustomLibsPreviewStop()
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsEdit_Click(sender As Object, e As EventArgs) Handles CustomLibsEdit.Click
        Optioner.CustomLibsEditButton(CustomLibsList, CustomLibsEdit, CustomLibsPath, CustomLibsPreviewImage)
    End Sub
    Private Sub CustomLibsDelete_Click(sender As Object, e As EventArgs) Handles CustomLibsDelete.Click
        Optioner.CustomLibsDeleteButton(CustomLibsList, CustomLibsDelete, CustomLibsPreviewImage)
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub CustomLibsImport_Click(sender As Object, e As EventArgs) Handles CustomLibsImport.Click
        Optioner.CustomLibsImportButton()
        Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
    End Sub
    Private Sub SelectTrack_Click(sender As Object, e As EventArgs) Handles OptionsAudioSelectIntro.Click, OptionsAudioSelectBattle.Click,
        OptionsAudioSelectVictory.Click, OptionsAudioSelectDefeat.Click
        Optioner.SelectTrackChanges(sender)
    End Sub

    'Editor Menu Section
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        MenuButtonPressed(EditorPanel)
        EditorPanelChange(EditorMenuPanel)
    End Sub
    Private Sub EditorPanelChange(activepanel As Panel)
        EditorPanel.Visible = True
        EditorMenuPanel.Visible = False
        EditorSwitchPanel.Visible = False
        EditorEditPanel.Visible = False
        activepanel.Visible = True
    End Sub
    Private Sub EditorBackButton_Click(sender As Object, e As EventArgs) Handles EditorSwitchBackButton.Click, EditorEditBackButton.Click
        EditorPanelChange(EditorMenuPanel)
        ActiveEditWindow = ""
    End Sub
    Private Sub EditorDBButton_Click(sender As Object, e As EventArgs) Handles EditorDBButton.Click
        EditorGenerateDBDrop()
    End Sub
    Private Sub EditorGenerateDBDrop()
        EditorPanelChange(EditorSwitchPanel)
        Dim LastDBFound As Boolean = False, DefaultDBFound As Boolean = False, NotFound As String = "<None Available>"
        EditorSwitchSDBDrop.Items.Clear()
        If FilesFolders.CountFiles(MemoryBank.DataDir, MemoryBank.SavesExtF) > 0 Then
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
        Else
            EditorSwitchDelButton.Enabled = True
        End If
        Appearance.RefreshColors()
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
        EditorSwitchTarBox.Text = Database.GetDBName(EditorSwitchSDBDrop.SelectedItem & MemoryBank.SavesExtL)
        EditorSwitchVerBox.Text = DBTools.GetCol(MemoryBank.DataDir, EditorSwitchSDBDrop.SelectedItem &
            MemoryBank.SavesExtL, "dbInfo", "dbVersion").Split(",")(0)
        DBTools.CloseSQL(MemoryBank.DataDir, EditorSwitchSDBDrop.SelectedItem & MemoryBank.SavesExtL)
        If LCase(EditorSwitchTarBox.Text) = LCase(EditorSwitchCurBox.Text) Then
            EditorSwitchSDBButton.Enabled = False
        Else
            EditorSwitchSDBButton.Enabled = True
        End If
        Appearance.RefreshColors()
    End Sub
    Private Sub EditorSwitchNewCheck_CheckedChanged(sender As Object, e As EventArgs) Handles EditorSwitchNewCheck.CheckedChanged
        If EditorSwitchNewCheck.CheckState = CheckState.Checked Then
            EditorSwitchNewBox.Text = ""
            EditorSwitchNewBox.Enabled = True
        Else
            EditorSwitchNewBox.Text = ""
            EditorSwitchNewBox.Enabled = False
        End If
        Appearance.RefreshColors()
    End Sub
    Private Sub EditorSwitchNewBox_KeyPress(sender As Object, e As EventArgs) Handles EditorSwitchNewBox.TextChanged
        If EditorSwitchNewBox.TextLength > 0 Then
            EditorSwitchNewButton.Enabled = True
        Else
            EditorSwitchNewButton.Enabled = False
        End If
        Appearance.RefreshColors()
    End Sub
    Private Sub EditorSwitchNewButton_Click(sender As Object, e As EventArgs) Handles EditorSwitchNewButton.Click
        If EditorSwitchNewButton.Enabled = True Then
            Dim NewDBName As String = (Converters.UppercaseEachFirstLetter(EditorSwitchNewBox.Text))
            If Not System.IO.File.Exists(MemoryBank.DataDir & "\" & NewDBName & MemoryBank.SavesExtL) Then
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
            Dim FileToGo As String = MemoryBank.DataDir & "\" & EditorSwitchSDBDrop.Text & MemoryBank.SavesExtL
            If answer = vbYes Then
                Try
                    DBTools.CloseSQL(MemoryBank.DataDir, EditorSwitchSDBDrop.SelectedItem & MemoryBank.SavesExtL)
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
            Dim FileToClone As String = MemoryBank.DataDir & "\" & EditorSwitchSDBDrop.Text & MemoryBank.SavesExtL
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
    Private Sub EditorEditPanelChange(activepanel As Panel)
        ActiveEditWindow = ""
        EditorEditPanel.Visible = True
        EditorEditCharPanel.Visible = False
        EditorEditAblPanel.Visible = False
        EditorEditLangPanel.Visible = False
        EditorEditArenaPanel.Visible = False
        EditorEditCharmsPanel.Visible = False
        EditorEditClassPanel.Visible = False
        EditorEditDestinyPanel.Visible = False
        EditorEditEffectsPanel.Visible = False
        EditorEditHeldsPanel.Visible = False
        EditorEditItemsPanel.Visible = False
        EditorEditRelPanel.Visible = False
        EditorEditStatusPanel.Visible = False
        EditorEditTeamsPanel.Visible = False
        EditorEditVersePanel.Visible = False
        EditorEditWearsPanel.Visible = False
        activepanel.Visible = True
    End Sub
    Private Sub EditorCharButton_Click(sender As Object, e As EventArgs) Handles EditorCharButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditCharPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Characters"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbToons", "toonID", "toonName")
        EditorCharPanelLoad()
    End Sub
    Private Sub EditorEditDelButtonChange(action As Boolean)
        EditorEditDelButton.Enabled = action
        Appearance.RefreshColors()
    End Sub
    Private Sub EditorEditList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EditorEditList.SelectedIndexChanged
        If EditorEditList.SelectedIndex > -1 Then EditorEditDelButtonChange(True) Else EditorEditDelButtonChange(False)
    End Sub
    Private Sub EditorAblButton_Click(sender As Object, e As EventArgs) Handles EditorAblButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditAblPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Abilities"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbAbl", "ablID", "ablName")
    End Sub
    Private Sub EditorLangButton_Click(sender As Object, e As EventArgs) Handles EditorLangButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditLangPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Languages"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbLang", "langID", "langName")
    End Sub
    Private Sub EditorArenaButton_Click(sender As Object, e As EventArgs) Handles EditorArenaButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditArenaPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Arenas"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbArenas", "arenaID", "arenaName")
    End Sub
    Private Sub EditorCharmsButton_Click(sender As Object, e As EventArgs) Handles EditorCharmsButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditCharmsPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Charms"
        Tools.PopulateListWithCustom(ActiveEditWindow, EditorEditList, {"dbItems.itemID.itemName.itemClass = '2'."})
    End Sub
    Private Sub EditorClassButton_Click(sender As Object, e As EventArgs) Handles EditorClassButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditClassPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Classifications"
        Tools.PopulateListWithCustom(ActiveEditWindow, EditorEditList, {"dbRace.raceID.raceName.raceName NOT NULL.R",
            "dbClass.classID.className.className NOT NULL.C", "dbJobs.jobID.jobName.jobName NOT NULL.J"})
    End Sub
    Private Sub EditorDestinyButton_Click(sender As Object, e As EventArgs) Handles EditorDestinyButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditDestinyPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Destinies"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbDestiny", "destinyID", "destinyName")
    End Sub
    Private Sub EditorEffectsButton_Click(sender As Object, e As EventArgs) Handles EditorEffectsButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditEffectsPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Effects"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbEff", "effID", "effName")
    End Sub
    Private Sub EditorHeldButton_Click(sender As Object, e As EventArgs) Handles EditorHeldButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditHeldsPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Handhelds"
        Tools.PopulateListWithCustom(ActiveEditWindow, EditorEditList, {"dbItems.itemID.itemName.itemClass = '0'."})
    End Sub
    Private Sub EditorItemButton_Click(sender As Object, e As EventArgs) Handles EditorItemButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditItemsPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Items"
        Tools.PopulateListWithCustom(ActiveEditWindow, EditorEditList, {"dbItems.itemID.itemName.itemClass = '3'.",
            "dbItems.itemID.itemName.itemClass = '4'.Relic"})
    End Sub
    Private Sub EditorVerseButton_Click(sender As Object, e As EventArgs) Handles EditorVerseButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditVersePanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Universes"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbVerse", "verseID", "verseName")
    End Sub
    Private Sub EditorRelButton_Click(sender As Object, e As EventArgs) Handles EditorRelButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditRelPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Relationships"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbRelation", "relationID", "relationName")
    End Sub
    Private Sub EditorStatusButton_Click(sender As Object, e As EventArgs) Handles EditorStatusButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditStatusPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Statuses"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbStatus", "statusID", "statusName")
    End Sub
    Private Sub EditorTeamsButton_Click(sender As Object, e As EventArgs) Handles EditorTeamsButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditTeamsPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Teams"
        Tools.PopulateListFromDB(ActiveEditWindow, EditorEditList, "dbTeam", "teamID", "teamName")
    End Sub
    Private Sub EditorWearButton_Click(sender As Object, e As EventArgs) Handles EditorWearButton.Click
        EditorPanelChange(EditorEditPanel)
        EditorEditPanelChange(EditorEditWearsPanel)
        EditorEditDelButtonChange(False)
        ActiveEditWindow = "Wearables"
        Tools.PopulateListWithCustom(ActiveEditWindow, EditorEditList, {"dbItems.itemID.itemName.itemClass = '1'."})
    End Sub
    Private Sub MainMenuBar_Click(sender As Object, e As EventArgs) Handles MainMenuBar.Click
        If WelcomePanel.Visible = False Then
            Dim answer As Integer = MsgBox("Are you sure you want to return to the Main Menu?", vbYesNo)
            If answer = vbYes Then
                Initialize.InitPanels()
            Else
                MsgBox("Action Cancelled", vbOKOnly)
            End If
            Optioner.ResetEditPath(CustomLibsEdit, CustomLibsPath)
        End If
    End Sub
    Private Sub EditorEditAddButton_Click(sender As Object, e As EventArgs) Handles EditorEditAddButton.Click
        StartButton.Enabled = False
        LoadButton.Enabled = False
        EditButton.Enabled = False
        OptionsButton.Enabled = False
        UpdateButton.Enabled = False
        DonateButton.Enabled = False
        AboutButton.Enabled = False
        EditorEditAddButton.Enabled = False
        EditorEditBackButton.Enabled = False
        Select Case (ActiveEditWindow)
            Case "Characters"
                EditorEditList.Enabled = False
                EditorEditList.ClearSelected()
                EditorCharPanelNew()
        End Select
    End Sub

    'Character Editor Section
    Private Sub EditorCharPanelClearFields()
        EditorCharNameBox.Text = ""
        EditorCharAgeBox.Text = ""
        EditorCharLevelBox.Text = ""
        EditorCharForceBox.Text = ""
        EditorCharBioBox.Text = ""
        EditorCharWebBox.Text = ""
        EditorCharAvatarBox.Text = ""
        EditorCharThemeBox.Text = ""
        EditorCharImageBox.Text = ""
        EditorCharMusicBox.Text = ""
        EditorCharImageBox.Image = My.Resources._empty_
        EditorCharMusicBox.Image = My.Resources.mp3sound
        EditorCharAliasCheck.Checked = CheckState.Unchecked
        EditorCharForceCheck.Checked = CheckState.Unchecked
        EditorCharAvatarCheck.Checked = CheckState.Unchecked
        EditorCharThemeCheck.Checked = CheckState.Unchecked
        EditorCharAliasList.Items.Clear()
        EditorCharLangCList.Items.Clear()
        EditorCharAblList.Items.Clear()
        EditorCharEffList.Items.Clear()
        EditorCharEffInvList.Items.Clear()
        EditorCharTypeDrop.Items.Clear()
        EditorCharRaceDrop.Items.Clear()
        EditorCharClassDrop.Items.Clear()
        EditorCharDestinyDrop.Items.Clear()
        EditorCharAlignDrop.Items.Clear()
        EditorCharGenderDrop.Items.Clear()
        EditorCharVerseDrop.Items.Clear()
        EditorCharForceDrop.Items.Clear()
        EditorCharQAddNewBox.Text = ""
        EditorCharQAddLikeDrop.Items.Clear()
        EditorCharInvList.Items.Clear()
        EditorCharInvNameText.Text = ""
        EditorCharInvClassText.Text = ""
        EditorCharInvTypeText.Text = ""
        EditorCharInvResList.Items.Clear()
        EditorCharInvAblList.Items.Clear()
        EditorCharInvEffList.Items.Clear()
        EditorCharInvElemText.Text = ""
        EditorCharInvQtyText.Text = ""
        EditorCharInvHeldList.Items.Clear()
        EditorCharInvWearList.Items.Clear()
        EditorCharInvCharmList.Items.Clear()
        EditorCharInvItemList.Items.Clear()
    End Sub
    Private Sub EditorCharPanelActivate(action As Boolean)
        EditorCharEffInvText.Enabled = action
        EditorCharDebugText.Enabled = action
        EditorCharNameBox.Enabled = action
        EditorCharAgeBox.Enabled = action
        EditorCharLevelBox.Enabled = action
        EditorCharForceBox.Enabled = action
        EditorCharBioBox.Enabled = action
        EditorCharWebBox.Enabled = action
        EditorCharAvatarBox.Enabled = action
        EditorCharThemeBox.Enabled = action
        EditorCharImageBox.Enabled = action
        EditorCharMusicBox.Enabled = action
        EditorCharAliasCheck.Enabled = action
        EditorCharForceCheck.Enabled = action
        EditorCharAvatarCheck.Enabled = action
        EditorCharThemeCheck.Enabled = action
        EditorCharAliasList.Enabled = action
        EditorCharLangCList.Enabled = action
        EditorCharAblList.Enabled = action
        EditorCharEffList.Enabled = action
        EditorCharEffInvList.Enabled = action
        EditorCharTypeDrop.Enabled = action
        EditorCharRaceDrop.Enabled = action
        EditorCharClassDrop.Enabled = action
        EditorCharAlignDrop.Enabled = action
        EditorCharDestinyDrop.Enabled = action
        EditorCharGenderDrop.Enabled = action
        EditorCharVerseDrop.Enabled = action
        EditorCharForceDrop.Enabled = action
        EditorCharTypeHelp.Enabled = action
        EditorCharRaceHelp.Enabled = action
        EditorCharClassHelp.Enabled = action
        EditorCharAlignHelp.Enabled = action
        EditorCharGenderHelp.Enabled = action
        EditorCharAgeHelp.Enabled = action
        EditorCharLevelHelp.Enabled = action
        EditorCharDestinyHelp.Enabled = action
        EditorCharVerseHelp.Enabled = action
        EditorCharAliasHelp.Enabled = action
        EditorCharLangHelp.Enabled = action
        EditorCharForceHelp.Enabled = action
        EditorCharForceHelp2.Enabled = action
        EditorCharWebHelp.Enabled = action
        EditorCharAblHelp.Enabled = action
        EditorCharEffHelp.Enabled = action
        EditorCharEffInvHelp.Enabled = action
        EditorCharEffInvHelp2.Enabled = action
        EditorCharAvatarHelp.Enabled = action
        EditorCharRaceQAdd.Enabled = action
        EditorCharClassQAdd.Enabled = action
        EditorCharDestinyQAdd.Enabled = action
        EditorCharVerseQAdd.Enabled = action
        EditorCharAliasNewB.Enabled = action
        EditorCharAliasAddB.Enabled = action
        EditorCharAliasRemB.Enabled = action
        EditorCharLangQAdd.Enabled = action
        EditorCharAblQAdd.Enabled = action
        EditorCharAblAddB.Enabled = action
        EditorCharAblRemB.Enabled = action
        EditorCharEffQAdd.Enabled = action
        EditorCharEffAddB.Enabled = action
        EditorCharAvatarButton.Enabled = action
        EditorCharEffRemB.Enabled = action
        EditorCharEffInvButton.Enabled = action
        EditorCharMusicPlay.Enabled = action
        EditorCharMusicStop.Enabled = action
        EditorCharThemeButton.Enabled = action
        EditorCharSaveButton.Enabled = action
        EditorCharCancelButton.Enabled = action
        EditorCharQAddPanel.Visible = False
        EditorCharQAddName.Visible = False
        EditorCharQAddNewText.Visible = False
        EditorCharQAddNewBox.Visible = False
        EditorCharQAddLikeText.Visible = False
        EditorCharQAddLikeDrop.Visible = False
        EditorCharQAddButton.Visible = False
        EditorCharQAddCancel.Visible = False
        EditorCharQAddHelp.Visible = False
        EditorCharQAddRemindText.Visible = False
        EditorCharQAddPanel.Enabled = False
        EditorCharQAddName.Enabled = False
        EditorCharQAddNewText.Enabled = False
        EditorCharQAddNewBox.Enabled = False
        EditorCharQAddLikeText.Enabled = False
        EditorCharQAddLikeDrop.Enabled = False
        EditorCharQAddButton.Enabled = False
        EditorCharQAddCancel.Enabled = False
        EditorCharQAddHelp.Enabled = False
        EditorCharQAddRemindText.Enabled = False
        EditorCharInvPanel.Visible = False
        EditorCharInvText.Visible = False
        EditorCharInvHelp.Visible = False
        EditorCharInvList.Visible = False
        EditorCharInvAddButton.Visible = False
        EditorCharInvEquipButton.Visible = False
        EditorCharInvNameText.Visible = False
        EditorCharInvClassText.Visible = False
        EditorCharInvTypeText.Visible = False
        EditorCharInvResList.Visible = False
        EditorCharInvAblList.Visible = False
        EditorCharInvEffList.Visible = False
        EditorCharInvElemText.Visible = False
        EditorCharInvQtyText.Visible = False
        EditorCharInvHeldText.Visible = False
        EditorCharInvHeldList.Visible = False
        EditorCharInvWearText.Visible = False
        EditorCharInvWearList.Visible = False
        EditorCharInvCharmText.Visible = False
        EditorCharInvCharmList.Visible = False
        EditorCharInvItemText.Visible = False
        EditorCharInvItemList.Visible = False
        EditorCharInvDoneButton.Visible = False
        EditorCharInvUnequipButton.Visible = False
        EditorCharInvRemoveButton.Visible = False
        EditorCharInvSwitchButton.Visible = False
        EditorCharInvPanel.Enabled = False
        EditorCharInvText.Enabled = False
        EditorCharInvHelp.Enabled = False
        EditorCharInvList.Enabled = False
        EditorCharInvAddButton.Enabled = False
        EditorCharInvEquipButton.Enabled = False
        EditorCharInvNameText.Enabled = False
        EditorCharInvClassText.Enabled = False
        EditorCharInvTypeText.Enabled = False
        EditorCharInvResList.Enabled = False
        EditorCharInvAblList.Enabled = False
        EditorCharInvEffList.Enabled = False
        EditorCharInvElemText.Enabled = False
        EditorCharInvQtyText.Enabled = False
        EditorCharInvHeldText.Enabled = False
        EditorCharInvHeldList.Enabled = False
        EditorCharInvWearText.Enabled = False
        EditorCharInvWearList.Enabled = False
        EditorCharInvCharmText.Enabled = False
        EditorCharInvCharmList.Enabled = False
        EditorCharInvItemText.Enabled = False
        EditorCharInvItemList.Enabled = False
        EditorCharInvDoneButton.Enabled = False
        EditorCharInvUnequipButton.Enabled = False
        EditorCharInvRemoveButton.Enabled = False
        EditorCharInvSwitchButton.Enabled = False
        Appearance.RefreshColors()
    End Sub
    Private Sub EditorCharQAddPanelActivate(action As Boolean)
        Dim Reaction As Boolean
        If action = True Then Reaction = False Else Reaction = True
        EditorCharDebugText.Enabled = Reaction
        EditorCharNameBox.Enabled = Reaction
        EditorCharAgeBox.Enabled = Reaction
        EditorCharLevelBox.Enabled = Reaction
        EditorCharForceBox.Enabled = Reaction
        EditorCharBioBox.Enabled = Reaction
        EditorCharWebBox.Enabled = Reaction
        EditorCharAvatarBox.Enabled = Reaction
        EditorCharThemeBox.Enabled = Reaction
        EditorCharImageBox.Enabled = Reaction
        EditorCharMusicBox.Enabled = Reaction
        EditorCharAliasCheck.Enabled = Reaction
        EditorCharForceCheck.Enabled = Reaction
        EditorCharAvatarCheck.Enabled = Reaction
        EditorCharThemeCheck.Enabled = Reaction
        EditorCharAliasList.Enabled = Reaction
        EditorCharLangCList.Enabled = Reaction
        EditorCharAblList.Enabled = Reaction
        EditorCharEffList.Enabled = Reaction
        EditorCharEffInvList.Enabled = Reaction
        EditorCharTypeDrop.Enabled = Reaction
        EditorCharRaceDrop.Enabled = Reaction
        EditorCharClassDrop.Enabled = Reaction
        EditorCharDestinyDrop.Enabled = Reaction
        EditorCharAlignDrop.Enabled = Reaction
        EditorCharGenderDrop.Enabled = Reaction
        EditorCharVerseDrop.Enabled = Reaction
        EditorCharForceDrop.Enabled = Reaction
        EditorCharTypeHelp.Enabled = Reaction
        EditorCharRaceHelp.Enabled = Reaction
        EditorCharClassHelp.Enabled = Reaction
        EditorCharAlignHelp.Enabled = Reaction
        EditorCharGenderHelp.Enabled = Reaction
        EditorCharAgeHelp.Enabled = Reaction
        EditorCharLevelHelp.Enabled = Reaction
        EditorCharDestinyHelp.Enabled = Reaction
        EditorCharVerseHelp.Enabled = Reaction
        EditorCharAliasHelp.Enabled = Reaction
        EditorCharLangHelp.Enabled = Reaction
        EditorCharForceHelp.Enabled = Reaction
        EditorCharForceHelp2.Enabled = Reaction
        EditorCharWebHelp.Enabled = Reaction
        EditorCharAblHelp.Enabled = Reaction
        EditorCharEffHelp.Enabled = Reaction
        EditorCharEffInvHelp.Enabled = Reaction
        EditorCharEffInvHelp2.Enabled = Reaction
        EditorCharAvatarHelp.Enabled = Reaction
        EditorCharRaceQAdd.Enabled = Reaction
        EditorCharClassQAdd.Enabled = Reaction
        EditorCharDestinyQAdd.Enabled = Reaction
        EditorCharVerseQAdd.Enabled = Reaction
        EditorCharAliasNewB.Enabled = Reaction
        EditorCharAliasAddB.Enabled = Reaction
        EditorCharAliasRemB.Enabled = Reaction
        EditorCharLangQAdd.Enabled = Reaction
        EditorCharAblQAdd.Enabled = Reaction
        EditorCharAblAddB.Enabled = Reaction
        EditorCharAblRemB.Enabled = Reaction
        EditorCharEffQAdd.Enabled = Reaction
        EditorCharEffAddB.Enabled = Reaction
        EditorCharAvatarButton.Enabled = Reaction
        EditorCharEffRemB.Enabled = Reaction
        EditorCharEffInvButton.Enabled = Reaction
        EditorCharMusicPlay.Enabled = Reaction
        EditorCharMusicStop.Enabled = Reaction
        EditorCharThemeButton.Enabled = Reaction
        EditorCharSaveButton.Enabled = Reaction
        EditorCharCancelButton.Enabled = Reaction
        EditorCharQAddPanel.Visible = action
        EditorCharQAddName.Visible = action
        EditorCharQAddNewText.Visible = action
        EditorCharQAddNewBox.Visible = action
        EditorCharQAddLikeText.Visible = action
        EditorCharQAddLikeDrop.Visible = action
        EditorCharQAddButton.Visible = action
        EditorCharQAddCancel.Visible = action
        EditorCharQAddHelp.Visible = action
        EditorCharQAddRemindText.Visible = action
        EditorCharQAddPanel.Enabled = action
        EditorCharQAddName.Enabled = action
        EditorCharQAddNewText.Enabled = action
        EditorCharQAddNewBox.Enabled = action
        EditorCharQAddLikeText.Enabled = action
        EditorCharQAddLikeDrop.Enabled = action
        EditorCharQAddButton.Enabled = action
        EditorCharQAddCancel.Enabled = action
        EditorCharQAddHelp.Enabled = action
        EditorCharQAddRemindText.Enabled = action
        EditorCharInvPanel.Visible = False
        EditorCharInvText.Visible = False
        EditorCharInvHelp.Visible = False
        EditorCharInvList.Visible = False
        EditorCharInvAddButton.Visible = False
        EditorCharInvEquipButton.Visible = False
        EditorCharInvNameText.Visible = False
        EditorCharInvClassText.Visible = False
        EditorCharInvTypeText.Visible = False
        EditorCharInvResList.Visible = False
        EditorCharInvAblList.Visible = False
        EditorCharInvEffList.Visible = False
        EditorCharInvElemText.Visible = False
        EditorCharInvQtyText.Visible = False
        EditorCharInvHeldText.Visible = False
        EditorCharInvHeldList.Visible = False
        EditorCharInvWearText.Visible = False
        EditorCharInvWearList.Visible = False
        EditorCharInvCharmText.Visible = False
        EditorCharInvCharmList.Visible = False
        EditorCharInvItemText.Visible = False
        EditorCharInvItemList.Visible = False
        EditorCharInvDoneButton.Visible = False
        EditorCharInvUnequipButton.Visible = False
        EditorCharInvRemoveButton.Visible = False
        EditorCharInvSwitchButton.Visible = False
        EditorCharInvPanel.Enabled = False
        EditorCharInvText.Enabled = False
        EditorCharInvHelp.Enabled = False
        EditorCharInvList.Enabled = False
        EditorCharInvAddButton.Enabled = False
        EditorCharInvEquipButton.Enabled = False
        EditorCharInvNameText.Enabled = False
        EditorCharInvClassText.Enabled = False
        EditorCharInvTypeText.Enabled = False
        EditorCharInvResList.Enabled = False
        EditorCharInvAblList.Enabled = False
        EditorCharInvEffList.Enabled = False
        EditorCharInvElemText.Enabled = False
        EditorCharInvQtyText.Enabled = False
        EditorCharInvHeldText.Enabled = False
        EditorCharInvHeldList.Enabled = False
        EditorCharInvWearText.Enabled = False
        EditorCharInvWearList.Enabled = False
        EditorCharInvCharmText.Enabled = False
        EditorCharInvCharmList.Enabled = False
        EditorCharInvItemText.Enabled = False
        EditorCharInvItemList.Enabled = False
        EditorCharInvDoneButton.Enabled = False
        EditorCharInvUnequipButton.Enabled = False
        EditorCharInvRemoveButton.Enabled = False
        EditorCharInvSwitchButton.Enabled = False
        Appearance.RefreshColors()
    End Sub
    Private Sub EditorCharInvPanelActivate(action As Boolean)
        Dim Reaction As Boolean
        If action = True Then Reaction = False Else Reaction = True
        EditorCharDebugText.Enabled = Reaction
        EditorCharNameBox.Enabled = Reaction
        EditorCharAgeBox.Enabled = Reaction
        EditorCharLevelBox.Enabled = Reaction
        EditorCharForceBox.Enabled = Reaction
        EditorCharBioBox.Enabled = Reaction
        EditorCharWebBox.Enabled = Reaction
        EditorCharAvatarBox.Enabled = Reaction
        EditorCharThemeBox.Enabled = Reaction
        EditorCharImageBox.Enabled = Reaction
        EditorCharMusicBox.Enabled = Reaction
        EditorCharAliasCheck.Enabled = Reaction
        EditorCharForceCheck.Enabled = Reaction
        EditorCharAvatarCheck.Enabled = Reaction
        EditorCharThemeCheck.Enabled = Reaction
        EditorCharAliasList.Enabled = Reaction
        EditorCharLangCList.Enabled = Reaction
        EditorCharAblList.Enabled = Reaction
        EditorCharEffList.Enabled = Reaction
        EditorCharEffInvList.Enabled = Reaction
        EditorCharTypeDrop.Enabled = Reaction
        EditorCharRaceDrop.Enabled = Reaction
        EditorCharDestinyDrop.Enabled = Reaction
        EditorCharClassDrop.Enabled = Reaction
        EditorCharAlignDrop.Enabled = Reaction
        EditorCharGenderDrop.Enabled = Reaction
        EditorCharVerseDrop.Enabled = Reaction
        EditorCharForceDrop.Enabled = Reaction
        EditorCharTypeHelp.Enabled = Reaction
        EditorCharRaceHelp.Enabled = Reaction
        EditorCharClassHelp.Enabled = Reaction
        EditorCharAlignHelp.Enabled = Reaction
        EditorCharGenderHelp.Enabled = Reaction
        EditorCharAgeHelp.Enabled = Reaction
        EditorCharLevelHelp.Enabled = Reaction
        EditorCharDestinyHelp.Enabled = Reaction
        EditorCharVerseHelp.Enabled = Reaction
        EditorCharAliasHelp.Enabled = Reaction
        EditorCharLangHelp.Enabled = Reaction
        EditorCharForceHelp.Enabled = Reaction
        EditorCharForceHelp2.Enabled = Reaction
        EditorCharWebHelp.Enabled = Reaction
        EditorCharAblHelp.Enabled = Reaction
        EditorCharEffHelp.Enabled = Reaction
        EditorCharEffInvHelp.Enabled = Reaction
        EditorCharEffInvHelp2.Enabled = Reaction
        EditorCharAvatarHelp.Enabled = Reaction
        EditorCharRaceQAdd.Enabled = Reaction
        EditorCharClassQAdd.Enabled = Reaction
        EditorCharDestinyQAdd.Enabled = Reaction
        EditorCharVerseQAdd.Enabled = Reaction
        EditorCharAliasNewB.Enabled = Reaction
        EditorCharAliasAddB.Enabled = Reaction
        EditorCharAliasRemB.Enabled = Reaction
        EditorCharLangQAdd.Enabled = Reaction
        EditorCharAblQAdd.Enabled = Reaction
        EditorCharAblAddB.Enabled = Reaction
        EditorCharAblRemB.Enabled = Reaction
        EditorCharEffQAdd.Enabled = Reaction
        EditorCharEffAddB.Enabled = Reaction
        EditorCharAvatarButton.Enabled = Reaction
        EditorCharEffRemB.Enabled = Reaction
        EditorCharEffInvButton.Enabled = Reaction
        EditorCharMusicPlay.Enabled = Reaction
        EditorCharMusicStop.Enabled = Reaction
        EditorCharThemeButton.Enabled = Reaction
        EditorCharSaveButton.Enabled = Reaction
        EditorCharCancelButton.Enabled = Reaction
        EditorCharQAddPanel.Visible = False
        EditorCharQAddName.Visible = False
        EditorCharQAddNewText.Visible = False
        EditorCharQAddNewBox.Visible = False
        EditorCharQAddLikeText.Visible = False
        EditorCharQAddLikeDrop.Visible = False
        EditorCharQAddButton.Visible = False
        EditorCharQAddCancel.Visible = False
        EditorCharQAddHelp.Visible = False
        EditorCharQAddRemindText.Visible = False
        EditorCharQAddPanel.Enabled = False
        EditorCharQAddName.Enabled = False
        EditorCharQAddNewText.Enabled = False
        EditorCharQAddNewBox.Enabled = False
        EditorCharQAddLikeText.Enabled = False
        EditorCharQAddLikeDrop.Enabled = False
        EditorCharQAddButton.Enabled = False
        EditorCharQAddCancel.Enabled = False
        EditorCharQAddHelp.Enabled = False
        EditorCharQAddRemindText.Enabled = False
        EditorCharInvPanel.Visible = action
        EditorCharInvText.Visible = action
        EditorCharInvHelp.Visible = action
        EditorCharInvList.Visible = action
        EditorCharInvAddButton.Visible = action
        EditorCharInvEquipButton.Visible = action
        EditorCharInvNameText.Visible = action
        EditorCharInvClassText.Visible = action
        EditorCharInvTypeText.Visible = action
        EditorCharInvResList.Visible = action
        EditorCharInvAblList.Visible = action
        EditorCharInvEffList.Visible = action
        EditorCharInvElemText.Visible = action
        EditorCharInvQtyText.Visible = action
        EditorCharInvHeldText.Visible = action
        EditorCharInvHeldList.Visible = action
        EditorCharInvWearText.Visible = action
        EditorCharInvWearList.Visible = action
        EditorCharInvCharmText.Visible = action
        EditorCharInvCharmList.Visible = action
        EditorCharInvItemText.Visible = action
        EditorCharInvItemList.Visible = action
        EditorCharInvDoneButton.Visible = action
        EditorCharInvUnequipButton.Visible = action
        EditorCharInvRemoveButton.Visible = action
        EditorCharInvSwitchButton.Visible = action
        EditorCharInvPanel.Enabled = action
        EditorCharInvText.Enabled = action
        EditorCharInvHelp.Enabled = action
        EditorCharInvList.Enabled = action
        EditorCharInvAddButton.Enabled = action
        EditorCharInvEquipButton.Enabled = action
        EditorCharInvNameText.Enabled = action
        EditorCharInvClassText.Enabled = action
        EditorCharInvTypeText.Enabled = action
        EditorCharInvResList.Enabled = action
        EditorCharInvAblList.Enabled = action
        EditorCharInvEffList.Enabled = action
        EditorCharInvElemText.Enabled = action
        EditorCharInvQtyText.Enabled = action
        EditorCharInvHeldText.Enabled = action
        EditorCharInvHeldList.Enabled = action
        EditorCharInvWearText.Enabled = action
        EditorCharInvWearList.Enabled = action
        EditorCharInvCharmText.Enabled = action
        EditorCharInvCharmList.Enabled = action
        EditorCharInvItemText.Enabled = action
        EditorCharInvItemList.Enabled = action
        EditorCharInvDoneButton.Enabled = action
        EditorCharInvUnequipButton.Enabled = action
        EditorCharInvRemoveButton.Enabled = action
        EditorCharInvSwitchButton.Enabled = action
        Appearance.RefreshColors()
    End Sub
    Private Sub EditorCharPanelLoad()
        EditorEditCharPanel.Visible = True
        EditorCharPanelActivate(False)
        EditorCharPanelClearFields()
    End Sub
    Private Sub EditorCharPanelNew()
        EditorEditCharPanel.Visible = True
        EditorCharPanelActivate(True)
        EditorCharPanelClearFields()
        EditorCharNewPop()
    End Sub
    Private Sub EditorCharNewPop()
        Tools.PopulateDropFromDB("Existences", EditorCharTypeDrop, "dbExistence", "existID", "existName")
        Tools.PopulateDropFromDB("Races", EditorCharRaceDrop, "dbRace", "raceID", "raceName")
        Tools.PopulateDropFromDB("Classes", EditorCharClassDrop, "dbClass", "classID", "className")
        Tools.PopulateDropFromDB("Alignments", EditorCharAlignDrop, "dbAlign", "alignID", "alignName")
        Tools.PopulateDropFromDB("Genders", EditorCharGenderDrop, "dbGender", "genderID", "genderName")
        Tools.PopulateDropFromDB("Destinies", EditorCharDestinyDrop, "dbDestiny", "destinyID", "destinyName")
        Tools.PopulateDropFromDB("Universes", EditorCharVerseDrop, "dbVerse", "verseID", "verseName")
        Tools.PopulateCListFromDB("Languages", EditorCharLangCList, "dbLang", "langID", "langName")
        Tools.PopulateDropWithCustom("Relics", EditorCharForceDrop, {"dbItems.itemID.itemName.itemMax = '1'."})
    End Sub

    Private Sub EditorCharCancelButton_Click(sender As Object, e As EventArgs) Handles EditorCharCancelButton.Click
        StartButton.Enabled = True
        LoadButton.Enabled = True
        EditButton.Enabled = True
        OptionsButton.Enabled = True
        UpdateButton.Enabled = True
        DonateButton.Enabled = True
        AboutButton.Enabled = True
        EditorEditAddButton.Enabled = True
        EditorEditBackButton.Enabled = True
        Select Case (ActiveEditWindow)
            Case "Characters"
                EditorEditList.Enabled = True
                EditorEditList.ClearSelected()
                EditorCharPanelLoad()
        End Select
    End Sub

    'Start Game Section
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Initialize.InitPanels()
        MsgBox("Yeah, we are excited about the game too, but it's not ready yet.  Be patient.  Thanks!" & vbCrLf & vbCrLf & "- Geoff", vbExclamation + vbOKOnly)
    End Sub

End Class
