Public Class Editor

    'Editor Panel
    Public Shared Sub FlipEditorPanels(activepanel As Panel)
        'MainWindow.EditorPanel.Visible = True
        'MainWindow.EditorMenuPanel.Visible = False
        'MainWindow.EditorSwitchPanel.Visible = False
        'MainWindow.EditorEditPanel.Visible = False
        activepanel.Visible = True
    End Sub
    Public Shared Sub FlipEditorEditPanel(activepanel As Panel)
        MemoryBank.ActiveEditorWindow = ""
        'MainWindow.EditorEditPanel.Visible = True
        'MainWindow.EditorEditCharPanel.Visible = False
        'MainWindow.EditorEditAblPanel.Visible = False
        'MainWindow.EditorEditLangPanel.Visible = False
        'MainWindow.EditorEditArenaPanel.Visible = False
        'MainWindow.EditorEditCharmsPanel.Visible = False
        'MainWindow.EditorEditClassPanel.Visible = False
        'MainWindow.EditorEditDestinyPanel.Visible = False
        'MainWindow.EditorEditEffectsPanel.Visible = False
        'MainWindow.EditorEditHeldsPanel.Visible = False
        'MainWindow.EditorEditItemsPanel.Visible = False
        'MainWindow.EditorEditRelPanel.Visible = False
        'MainWindow.EditorEditStatusPanel.Visible = False
        'MainWindow.EditorEditTeamsPanel.Visible = False
        'MainWindow.EditorEditVersePanel.Visible = False
        'MainWindow.EditorEditWearsPanel.Visible = False
        activepanel.Visible = True
    End Sub
    Public Shared Sub EditorEditDelButtonUpdate(list As ListBox, button As Button)
        If list.SelectedIndex > -1 Then Tools.ButtonChange(button, True) Else Tools.ButtonChange(button, False)
    End Sub

    Public Shared Sub EditorEditAddButtonUpdate(button As Button, backbutton As Button, list As ListBox)
        EditorEditAddButtonAction(button, backbutton, list)
    End Sub
    Private Shared Sub EditorEditAddButtonAction(button As Button, backbutton As Button, list As ListBox)
        FlipMenuButtons(False, button, backbutton)
        Select Case (MemoryBank.ActiveEditorWindow)
            Case "Characters"
                list.Enabled = False
                list.ClearSelected()
                EditorCharPanelChange("new")
        End Select
    End Sub
    Private Shared Sub FlipMenuButtons(action As Boolean, button As Button, backbutton As Button)
        MainWindow.StartButton.Enabled = action
        MainWindow.LoadButton.Enabled = action
        MainWindow.EditButton.Enabled = action
        MainWindow.OptionsButton.Enabled = action
        MainWindow.UpdateButton.Enabled = action
        MainWindow.BackButton.Enabled = action
        MainWindow.AboutButton.Enabled = action
        button.Enabled = action
        backbutton.Enabled = action
    End Sub

    'Editor Buttons
    Public Shared Sub EditorButtonActions(type As String, mainpanel As Panel, editpanel As Panel, delbutton As Button, list As ListBox)
        EditorButtonProcess(type, mainpanel, editpanel, delbutton, list)
    End Sub
    Private Shared Sub EditorButtonProcess(type As String, mainpanel As Panel, editpanel As Panel, delbutton As Button, list As ListBox)
        FlipEditorPanels(mainpanel)
        FlipEditorEditPanel(editpanel)
        Tools.ButtonChange(delbutton, False)
        MemoryBank.ActiveEditorWindow = type
        Select Case type
            Case "Characters"
                Tools.PopulateListFromDB(type, list, "dbToons", "toonID", "toonName")
                EditorCharPanelChange("load")
            Case "Abilities"
                Tools.PopulateListFromDB(type, list, "dbAbl", "ablID", "ablName")
            Case "Languages"
                Tools.PopulateListFromDB(type, list, "dbLang", "langID", "langName")
            Case "Arenas"
                Tools.PopulateListFromDB(type, list, "dbArenas", "arenaID", "arenaName")
            Case "Charms"
                Tools.PopulateListWithCustom(type, list, {"dbItems.itemID.itemName.itemClass = '2'."})
            Case "Classifications"
                Tools.PopulateListWithCustom(type, list, {"dbRace.raceID.raceName.raceName NOT NULL.R",
                    "dbClass.classID.className.className NOT NULL.C", "dbJobs.jobID.jobName.jobName NOT NULL.J"})
            Case "Destinies"
                Tools.PopulateListFromDB(type, list, "dbDestiny", "destinyID", "destinyName")
            Case "Effects"
                Tools.PopulateListFromDB(type, list, "dbEff", "effID", "effName")
            Case "Handhelds"
                Tools.PopulateListWithCustom(type, list, {"dbItems.itemID.itemName.itemClass = '0'."})
            Case "Items"
                Tools.PopulateListWithCustom(type, list, {"dbItems.itemID.itemName.itemClass = '3'.",
            "dbItems.itemID.itemName.itemClass = '4'.Relic"})
            Case "Universes"
                Tools.PopulateListFromDB(type, list, "dbVerse", "verseID", "verseName")
            Case "Relationships"
                Tools.PopulateListFromDB(type, list, "dbRelation", "relationID", "relationName")
            Case "Statuses"
                Tools.PopulateListFromDB(type, list, "dbStatus", "statusID", "statusName")
            Case "Teams"
                Tools.PopulateListFromDB(type, list, "dbTeam", "teamID", "teamName")
            Case "Wearables"
                Tools.PopulateListWithCustom(type, list, {"dbItems.itemID.itemName.itemClass = '1'."})
        End Select

    End Sub

    'Editor Manage Database
    Public Shared Sub EditorGenDBDrop(drop As ComboBox, delbutton As Button)
        EditorGenDBDropProcess(drop, delbutton)
    End Sub
    Private Shared Sub EditorGenDBDropProcess(drop As ComboBox, delbutton As Button)
        'FlipEditorPanels(MainWindow.EditorSwitchPanel)
        Dim LastDBFound As Boolean = False, DefaultDBFound As Boolean = False, NotFound As String = "<None Available>"
        drop.Items.Clear()
        If ClarkTribeGames.FilesFolders.CountFiles(MemoryBank.DataDir, MemoryBank.SavesExtF) > 0 Then
            For Each FileName In ClarkTribeGames.FilesFolders.GetFilesInFolder(MemoryBank.DataDir)
                EditorSDBEffects(True)
                If FileName.EndsWith(MemoryBank.SavesExt) Then
                    Dim DBName As String = Database.GetDBName(FileName.Replace(MemoryBank.DataDir & "\", ""))
                    Dim DropName As String = (FileName.Replace(MemoryBank.DataDir & "\", "")).Substring(0,
                        (FileName.Replace(MemoryBank.DataDir & "\", "")).Length - ((MemoryBank.SavesExt).Length + 1))
                    'If LastDBFound = False And (LCase(DBName) = LCase(Settings.SettingsLastDB)) Then LastDBFound = True
                    If DefaultDBFound = False And (LCase(DBName) = LCase(Settings.SettingsDB)) Then DefaultDBFound = True
                    drop.Items.Add(ClarkTribeGames.Converters.UppercaseEachFirstLetter(DropName))
                    drop.Sorted = True
                    ClarkTribeGames.SQLite.CloseSQL(MemoryBank.DataDir, FileName.Replace(MemoryBank.DataDir & "\", ""))
                End If
            Next
        End If
        If drop.Items.Count < 1 Then
            drop.Items.Add(NotFound)
            EditorSDBEffects(False)
        End If
        If Not drop.SelectedItem = NotFound And LastDBFound = True Then
            'drop.SelectedIndex = drop.FindString(Settings.SettingsLastDB)
        Else
            If Not drop.SelectedItem = NotFound And DefaultDBFound = True Then
                drop.SelectedIndex = drop.FindString(Settings.SettingsDB)
            Else
                drop.SelectedIndex = 0
            End If
        End If
        If drop.Items.Count < 2 Then
            delbutton.Enabled = False
        Else
            delbutton.Enabled = True
        End If
        Appearance.RefreshColors()
    End Sub
    Private Shared Sub EditorSDBEffects(changevalue As Boolean)
        'MainWindow.EditorSwitchSDBDrop.Enabled = changevalue
        'MainWindow.EditorSwitchSDBButton.Enabled = changevalue
        'MainWindow.EditorSwitchDupButton.Enabled = changevalue
        'MainWindow.EditorSwitchDelButton.Enabled = changevalue
        'MainWindow.EditorSwitchVerBox.Visible = changevalue
        'MainWindow.EditorSwitchTarBox.Visible = changevalue
    End Sub
    Public Shared Sub EditorSwitchSDBDrop(drop As ComboBox, target As Label, version As Label, current As Label, swbutton As Button)
        EditorSwitchSDBDropProcess(drop, target, version, current, swbutton)
    End Sub
    Private Shared Sub EditorSwitchSDBDropProcess(drop As ComboBox, target As Label, version As Label, current As Label, swbutton As Button)
        target.Text = Database.GetDBName(drop.SelectedItem & MemoryBank.SavesExtL)
        version.Text = ClarkTribeGames.SQLite.GetCol(MemoryBank.DataDir, drop.SelectedItem &
            MemoryBank.SavesExtL, "dbInfo", "dbVersion").Split(",")(0)
        ClarkTribeGames.SQLite.CloseSQL(MemoryBank.DataDir, drop.SelectedItem & MemoryBank.SavesExtL)
        If LCase(target.Text) = LCase(current.Text) Then
            swbutton.Enabled = False
        Else
            swbutton.Enabled = True
        End If
        Appearance.RefreshColors()
    End Sub
    Public Shared Sub EditorSwitchNewActions(type As String, checkbox As CheckBox, textbox As TextBox, button As Button)
        EditorSwitchNewCheckProcess(type, checkbox, textbox, button)
    End Sub
    Private Shared Sub EditorSwitchNewCheckProcess(type As String, checkbox As CheckBox, textbox As TextBox, button As Button)
        Select Case LCase(type)
            Case "check"
                If checkbox.CheckState = CheckState.Checked Then
                    textbox.Text = ""
                    textbox.Enabled = True
                Else
                    textbox.Text = ""
                    textbox.Enabled = False
                End If
            Case "key"
                If textbox.TextLength > 0 Then
                    button.Enabled = True
                Else
                    button.Enabled = False
                End If
            Case "button"
                If button.Enabled = True Then
                    Dim NewDBName As String = (ClarkTribeGames.Converters.UppercaseEachFirstLetter(textbox.Text))
                    If Not System.IO.File.Exists(MemoryBank.DataDir & "\" & NewDBName & MemoryBank.SavesExtL) Then
                        Database.CreateEmptyDB(NewDBName)
                        MsgBox("New Database " & NewDBName & " Created!", vbOKOnly)
                        checkbox.CheckState = CheckState.Unchecked
                        'EditorGenDBDrop(MainWindow.EditorSwitchSDBDrop, MainWindow.EditorSwitchDelButton)
                    Else
                        MsgBox("Filename of " & NewDBName & " already exists!  Please try a different name.", vbExclamation + vbOKOnly)
                    End If
                End If
        End Select
        Appearance.RefreshColors()
    End Sub
    Public Shared Sub EditorSwitchButtonActions(type As String, button As Button, drop As ComboBox, delbutton As Button)
        EditorSwitchButtonProcess(type, button, drop, delbutton)
        '
    End Sub
    Private Shared Sub EditorSwitchButtonProcess(type As String, button As Button, drop As ComboBox, delbutton As Button)
        Select Case LCase(type)
            Case "switch"
                If button.Enabled = True Then
                    Dim answer As Integer = MsgBox("Are you sure you want to switch to the " &
                        ClarkTribeGames.Converters.UppercaseEachFirstLetter(drop.Text) & " database file?", vbYesNo)
                    If answer = vbYes Then
                        Database.CheckForDB(drop.Text)
                        Editor.EditorGenDBDrop(drop, delbutton)
                    Else
                        MsgBox("Action Cancelled.", vbExclamation + vbOKOnly)
                    End If
                End If
            Case "delete"
                If button.Enabled = True Then
                    Dim answer As Integer = MsgBox("Are you sure you want to permanently delete the " &
                        ClarkTribeGames.Converters.UppercaseEachFirstLetter(drop.Text) & " database file?", vbYesNo)
                    Dim FileToGo As String = MemoryBank.DataDir & "\" & drop.Text & MemoryBank.SavesExtL
                    If answer = vbYes Then
                        Try
                            ClarkTribeGames.SQLite.CloseSQL(MemoryBank.DataDir, drop.SelectedItem & MemoryBank.SavesExtL)
                            If drop.SelectedIndex = 0 Then
                                drop.SelectedIndex = 1
                            Else
                                drop.SelectedIndex = 0
                            End If
                            ClarkTribeGames.FilesFolders.DeleteFile(FileToGo)
                            Editor.EditorGenDBDrop(drop, delbutton)
                            Database.CheckForDB(drop.SelectedItem.ToString)
                        Catch ex As Exception
                            ClarkTribeGames.Logger.WriteToLog("Database " & FileToGo & " Delete", "Delete Attempt", ex)
                            MsgBox("Logged Error:  File locked, please try again." & vbCrLf, vbOKOnly)
                        End Try
                    Else
                        MsgBox("Action Cancelled.", vbExclamation + vbOKOnly)
                    End If
                End If
            Case "dupe"
                If button.Enabled = True Then
                    Dim answer As Integer = MsgBox("Are you sure you want to clone the " &
                        ClarkTribeGames.Converters.UppercaseEachFirstLetter(drop.Text) & " database file?", vbYesNo)
                    Dim FileToClone As String = MemoryBank.DataDir & "\" & drop.Text & MemoryBank.SavesExtL
                    If answer = vbYes Then
                        Try
                            ClarkTribeGames.FilesFolders.CopyFile(MemoryBank.DataDir & "\" & drop.Text, MemoryBank.SavesExt)
                            Editor.EditorGenDBDrop(drop, delbutton)
                        Catch ex As Exception
                            ClarkTribeGames.Logger.WriteToLog("Database " & FileToClone & " Clone", "Clone Attempt", ex)
                            MsgBox("Logged Error:  File locked, please try again." & vbCrLf, vbOKOnly)
                        End Try
                    Else
                        MsgBox("Action Cancelled.", vbExclamation + vbOKOnly)
                    End If
                End If
        End Select
    End Sub

    'Character Editor
    Public Shared Sub FlipEditorCharPanel(type As String)
        Select Case LCase(type)
            Case "mainon"
                FlipEditorCharPanelAction(True, False, False)
            Case "mainoff"
                FlipEditorCharPanelAction(False, False, False)
            Case "qaddon"
                FlipEditorCharPanelAction(False, True, False)
            Case "inv"
                FlipEditorCharPanelAction(False, False, True)
        End Select
    End Sub
    Private Shared Sub EditorCharPanelClearFields()
        'MainWindow.EditorCharNameBox.Text = ""
        'MainWindow.EditorCharAgeBox.Text = ""
        'MainWindow.EditorCharLevelBox.Text = ""
        'MainWindow.EditorCharForceBox.Text = ""
        'MainWindow.EditorCharBioBox.Text = ""
        'MainWindow.EditorCharWebBox.Text = ""
        'MainWindow.EditorCharAvatarBox.Text = ""
        'MainWindow.EditorCharThemeBox.Text = ""
        'MainWindow.EditorCharImageBox.Text = ""
        'MainWindow.EditorCharMusicBox.Text = ""
        'MainWindow.EditorCharImageBox.Image = My.Resources._empty_
        'MainWindow.EditorCharMusicBox.Image = My.Resources.mp3sound
        'MainWindow.EditorCharAliasCheck.Checked = CheckState.Unchecked
        'MainWindow.EditorCharForceCheck.Checked = CheckState.Unchecked
        'MainWindow.EditorCharAvatarCheck.Checked = CheckState.Checked
        'MainWindow.EditorCharThemeCheck.Checked = CheckState.Checked
        'MainWindow.EditorCharAliasList.Items.Clear()
        ''MainWindow.EditorCharAliasList.Items.Add("<None>")
        'MainWindow.EditorCharLangCList.Items.Clear()
        'MainWindow.EditorCharAblList.Items.Clear()
        ''MainWindow.EditorCharAblList.Items.Add("<None>")
        'MainWindow.EditorCharEffList.Items.Clear()
        ''MainWindow.EditorCharEffList.Items.Add("<None>")
        'MainWindow.EditorCharEffInvList.Items.Clear()
        ''MainWindow.EditorCharEffInvList.Items.Add("<None")
        'MainWindow.EditorCharTypeDrop.Items.Clear()
        'MainWindow.EditorCharRaceDrop.Items.Clear()
        'MainWindow.EditorCharClassDrop.Items.Clear()
        'MainWindow.EditorCharDestinyDrop.Items.Clear()
        'MainWindow.EditorCharAlignDrop.Items.Clear()
        'MainWindow.EditorCharGenderDrop.Items.Clear()
        'MainWindow.EditorCharVerseDrop.Items.Clear()
        'MainWindow.EditorCharForceDrop.Items.Clear()
        'MainWindow.EditorCharQAddNewBox.Text = ""
        'MainWindow.EditorCharQAddLikeDrop.Items.Clear()
        'MainWindow.EditorCharInvList.Items.Clear()
        'MainWindow.EditorCharInvNameText.Text = ""
        'MainWindow.EditorCharInvClassText.Text = ""
        'MainWindow.EditorCharInvTypeText.Text = ""
        'MainWindow.EditorCharInvResList.Items.Clear()
        'MainWindow.EditorCharInvAblList.Items.Clear()
        'MainWindow.EditorCharInvEffList.Items.Clear()
        'MainWindow.EditorCharInvElemText.Text = ""
        'MainWindow.EditorCharInvQtyText.Text = ""
        'MainWindow.EditorCharInvHeldList.Items.Clear()
        'MainWindow.EditorCharInvWearList.Items.Clear()
        'MainWindow.EditorCharInvCharmList.Items.Clear()
        'MainWindow.EditorCharInvItemList.Items.Clear()
    End Sub
    Private Shared Sub FlipEditorCharPanelAction(charaction As Boolean, qaddaction As Boolean, invaction As Boolean)
        'MainWindow.EditorCharDebugText.Enabled = charaction
        'MainWindow.EditorCharNameBox.Enabled = charaction
        'MainWindow.EditorCharAgeBox.Enabled = charaction
        'MainWindow.EditorCharLevelBox.Enabled = charaction
        'MainWindow.EditorCharForceBox.Enabled = charaction
        'MainWindow.EditorCharBioBox.Enabled = charaction
        'MainWindow.EditorCharWebBox.Enabled = charaction
        'MainWindow.EditorCharAvatarBox.Enabled = charaction
        'MainWindow.EditorCharThemeBox.Enabled = charaction
        'MainWindow.EditorCharImageBox.Enabled = charaction
        'MainWindow.EditorCharMusicBox.Enabled = charaction
        'MainWindow.EditorCharAliasCheck.Enabled = charaction
        'MainWindow.EditorCharForceCheck.Enabled = charaction
        'MainWindow.EditorCharAvatarCheck.Enabled = charaction
        'MainWindow.EditorCharThemeCheck.Enabled = charaction
        'MainWindow.EditorCharAliasList.Enabled = charaction
        'MainWindow.EditorCharLangCList.Enabled = charaction
        'MainWindow.EditorCharAblList.Enabled = charaction
        'MainWindow.EditorCharEffList.Enabled = charaction
        'MainWindow.EditorCharEffInvList.Enabled = charaction
        'MainWindow.EditorCharTypeDrop.Enabled = charaction
        'MainWindow.EditorCharRaceDrop.Enabled = charaction
        'MainWindow.EditorCharClassDrop.Enabled = charaction
        'MainWindow.EditorCharAlignDrop.Enabled = charaction
        'MainWindow.EditorCharDestinyDrop.Enabled = charaction
        'MainWindow.EditorCharGenderDrop.Enabled = charaction
        'MainWindow.EditorCharVerseDrop.Enabled = charaction
        'MainWindow.EditorCharForceDrop.Enabled = charaction
        'MainWindow.EditorCharTypeHelp.Enabled = charaction
        'MainWindow.EditorCharRaceHelp.Enabled = charaction
        'MainWindow.EditorCharClassHelp.Enabled = charaction
        'MainWindow.EditorCharAlignHelp.Enabled = charaction
        'MainWindow.EditorCharGenderHelp.Enabled = charaction
        'MainWindow.EditorCharAgeHelp.Enabled = charaction
        'MainWindow.EditorCharLevelHelp.Enabled = charaction
        'MainWindow.EditorCharDestinyHelp.Enabled = charaction
        'MainWindow.EditorCharVerseHelp.Enabled = charaction
        'MainWindow.EditorCharAliasHelp.Enabled = charaction
        'MainWindow.EditorCharLangHelp.Enabled = charaction
        'MainWindow.EditorCharForceHelp.Enabled = charaction
        'MainWindow.EditorCharForceHelp2.Enabled = charaction
        'MainWindow.EditorCharWebHelp.Enabled = charaction
        'MainWindow.EditorCharAblHelp.Enabled = charaction
        'MainWindow.EditorCharEffHelp.Enabled = charaction
        'MainWindow.EditorCharEffInvHelp.Enabled = charaction
        'MainWindow.EditorCharEffInvHelp2.Enabled = charaction
        'MainWindow.EditorCharAvatarHelp.Enabled = charaction
        'MainWindow.EditorCharRaceQAdd.Enabled = charaction
        'MainWindow.EditorCharClassQAdd.Enabled = charaction
        'MainWindow.EditorCharDestinyQAdd.Enabled = charaction
        'MainWindow.EditorCharVerseQAdd.Enabled = charaction
        'MainWindow.EditorCharAliasNewB.Enabled = charaction
        'MainWindow.EditorCharAliasAddB.Enabled = charaction
        'MainWindow.EditorCharAliasRemB.Enabled = charaction
        'MainWindow.EditorCharLangQAdd.Enabled = charaction
        'MainWindow.EditorCharAblQAdd.Enabled = charaction
        'MainWindow.EditorCharAblAddB.Enabled = charaction
        'MainWindow.EditorCharAblRemB.Enabled = charaction
        'MainWindow.EditorCharEffQAdd.Enabled = charaction
        'MainWindow.EditorCharEffAddB.Enabled = charaction
        'MainWindow.EditorCharAvatarButton.Enabled = charaction
        'MainWindow.EditorCharEffRemB.Enabled = charaction
        'MainWindow.EditorCharEffInvButton.Enabled = charaction
        'MainWindow.EditorCharMusicPlay.Enabled = charaction
        'MainWindow.EditorCharMusicStop.Enabled = charaction
        'MainWindow.EditorCharThemeButton.Enabled = charaction
        'MainWindow.EditorCharSaveButton.Enabled = charaction
        'MainWindow.EditorCharCancelButton.Enabled = charaction
        'MainWindow.EditorCharQAddPanel.Visible = qaddaction
        'MainWindow.EditorCharQAddName.Visible = qaddaction
        'MainWindow.EditorCharQAddNewText.Visible = qaddaction
        'MainWindow.EditorCharQAddNewBox.Visible = qaddaction
        'MainWindow.EditorCharQAddLikeText.Visible = qaddaction
        'MainWindow.EditorCharQAddLikeDrop.Visible = qaddaction
        'MainWindow.EditorCharQAddButton.Visible = qaddaction
        'MainWindow.EditorCharQAddCancel.Visible = qaddaction
        'MainWindow.EditorCharQAddHelp.Visible = qaddaction
        'MainWindow.EditorCharQAddRemindText.Visible = qaddaction
        'MainWindow.EditorCharQAddPanel.Enabled = qaddaction
        'MainWindow.EditorCharQAddName.Enabled = qaddaction
        'MainWindow.EditorCharQAddNewText.Enabled = qaddaction
        'MainWindow.EditorCharQAddNewBox.Enabled = qaddaction
        'MainWindow.EditorCharQAddLikeText.Enabled = qaddaction
        'MainWindow.EditorCharQAddLikeDrop.Enabled = qaddaction
        'MainWindow.EditorCharQAddButton.Enabled = qaddaction
        'MainWindow.EditorCharQAddCancel.Enabled = qaddaction
        'MainWindow.EditorCharQAddHelp.Enabled = qaddaction
        'MainWindow.EditorCharQAddRemindText.Enabled = qaddaction
        'MainWindow.EditorCharInvPanel.Visible = invaction
        'MainWindow.EditorCharInvText.Visible = invaction
        'MainWindow.EditorCharInvHelp.Visible = invaction
        'MainWindow.EditorCharInvList.Visible = invaction
        'MainWindow.EditorCharInvAddButton.Visible = invaction
        'MainWindow.EditorCharInvEquipButton.Visible = invaction
        'MainWindow.EditorCharInvNameText.Visible = invaction
        'MainWindow.EditorCharInvClassText.Visible = invaction
        'MainWindow.EditorCharInvTypeText.Visible = invaction
        'MainWindow.EditorCharInvResList.Visible = invaction
        'MainWindow.EditorCharInvAblList.Visible = invaction
        'MainWindow.EditorCharInvEffList.Visible = invaction
        'MainWindow.EditorCharInvElemText.Visible = invaction
        'MainWindow.EditorCharInvQtyText.Visible = invaction
        'MainWindow.EditorCharInvHeldText.Visible = invaction
        'MainWindow.EditorCharInvHeldList.Visible = invaction
        'MainWindow.EditorCharInvWearText.Visible = invaction
        'MainWindow.EditorCharInvWearList.Visible = invaction
        'MainWindow.EditorCharInvCharmText.Visible = invaction
        'MainWindow.EditorCharInvCharmList.Visible = invaction
        'MainWindow.EditorCharInvItemText.Visible = invaction
        'MainWindow.EditorCharInvItemList.Visible = invaction
        'MainWindow.EditorCharInvDoneButton.Visible = invaction
        'MainWindow.EditorCharInvUnequipButton.Visible = invaction
        'MainWindow.EditorCharInvRemoveButton.Visible = invaction
        'MainWindow.EditorCharInvSwitchButton.Visible = invaction
        'MainWindow.EditorCharInvPanel.Enabled = invaction
        'MainWindow.EditorCharInvText.Enabled = invaction
        'MainWindow.EditorCharInvHelp.Enabled = invaction
        'MainWindow.EditorCharInvList.Enabled = invaction
        'MainWindow.EditorCharInvAddButton.Enabled = invaction
        'MainWindow.EditorCharInvEquipButton.Enabled = invaction
        'MainWindow.EditorCharInvNameText.Enabled = invaction
        'MainWindow.EditorCharInvClassText.Enabled = invaction
        'MainWindow.EditorCharInvTypeText.Enabled = invaction
        'MainWindow.EditorCharInvResList.Enabled = invaction
        'MainWindow.EditorCharInvAblList.Enabled = invaction
        'MainWindow.EditorCharInvEffList.Enabled = invaction
        'MainWindow.EditorCharInvElemText.Enabled = invaction
        'MainWindow.EditorCharInvQtyText.Enabled = invaction
        'MainWindow.EditorCharInvHeldText.Enabled = invaction
        'MainWindow.EditorCharInvHeldList.Enabled = invaction
        'MainWindow.EditorCharInvWearText.Enabled = invaction
        'MainWindow.EditorCharInvWearList.Enabled = invaction
        'MainWindow.EditorCharInvCharmText.Enabled = invaction
        'MainWindow.EditorCharInvCharmList.Enabled = invaction
        'MainWindow.EditorCharInvItemText.Enabled = invaction
        'MainWindow.EditorCharInvItemList.Enabled = invaction
        'MainWindow.EditorCharInvDoneButton.Enabled = invaction
        'MainWindow.EditorCharInvUnequipButton.Enabled = invaction
        'MainWindow.EditorCharInvRemoveButton.Enabled = invaction
        'MainWindow.EditorCharInvSwitchButton.Enabled = invaction
        'MainWindow.EditorCharAliasList.ClearSelected()
        'MainWindow.EditorCharLangCList.ClearSelected()
        'MainWindow.EditorCharAblList.ClearSelected()
        'MainWindow.EditorCharEffList.ClearSelected()
        'MainWindow.EditorCharEffInvList.ClearSelected()
        'MainWindow.EditorCharInvList.ClearSelected()
        'MainWindow.EditorCharInvResList.ClearSelected()
        'MainWindow.EditorCharInvAblList.ClearSelected()
        'MainWindow.EditorCharInvEffList.ClearSelected()
        'MainWindow.EditorCharInvHeldList.ClearSelected()
        'MainWindow.EditorCharInvWearList.ClearSelected()
        'MainWindow.EditorCharInvCharmList.ClearSelected()
        'MainWindow.EditorCharInvItemList.ClearSelected()
        Appearance.RefreshColors()
    End Sub
    Private Shared Sub EditorCharPanelChange(state As String)
        'MainWindow.EditorEditCharPanel.Visible = True
        Select Case LCase(state)
            Case "new"
                FlipEditorCharPanel("MainOn")
                EditorCharNewPop()
            Case "load"
                FlipEditorCharPanel("MainOff")
        End Select
    End Sub
    Private Shared Sub EditorCharNewPop()
        'Tools.PopulateDropFromDB("Existences", MainWindow.EditorCharTypeDrop, "dbExistence", "existID", "existName")
        'Tools.PopulateDropFromDB("Races", MainWindow.EditorCharRaceDrop, "dbRace", "raceID", "raceName")
        'Tools.PopulateDropFromDB("Classes", MainWindow.EditorCharClassDrop, "dbClass", "classID", "className")
        'Tools.PopulateDropFromDB("Alignments", MainWindow.EditorCharAlignDrop, "dbAlign", "alignID", "alignName")
        'Tools.PopulateDropFromDB("Genders", MainWindow.EditorCharGenderDrop, "dbGender", "genderID", "genderName")
        'Tools.PopulateDropFromDB("Destinies", MainWindow.EditorCharDestinyDrop, "dbDestiny", "destinyID", "destinyName")
        'Tools.PopulateDropFromDB("Universes", MainWindow.EditorCharVerseDrop, "dbVerse", "verseID", "verseName")
        'Tools.PopulateCListFromDB("Languages", MainWindow.EditorCharLangCList, "dbLang", "langID", "langName")
        'Tools.PopulateDropWithCustom("Relics", MainWindow.EditorCharForceDrop, {"dbItems.itemID.itemName.itemMax = '1'."})
    End Sub
    Public Shared Sub EditorCharCancelButtonUpdate(button As Button, backbutton As Button, list As ListBox)
        EditorCharCancelButtonAction(button, backbutton, list)
    End Sub
    Private Shared Sub EditorCharCancelButtonAction(button As Button, backbutton As Button, list As ListBox)
        FlipMenuButtons(True, button, backbutton)
        Select Case (MemoryBank.ActiveEditorWindow)
            Case "Characters"
                list.Enabled = False
                list.ClearSelected()
                EditorCharPanelClearFields()
                EditorCharPanelChange("load")
        End Select
    End Sub
    Public Shared Sub EditorCharCheckBoxes(type As String, checkbox As CheckBox, box As Object)
        Select Case LCase(type)
            Case "standard"
                If checkbox.CheckState = CheckState.Checked Then
                    box.Enabled = True
                Else
                    box.Enabled = False
                End If
            Case "none"
                If checkbox.CheckState = CheckState.Unchecked Then
                    box.Enabled = False
                    box.Text = "<Default>"
                Else
                    box.Enabled = True
                End If
        End Select
        Appearance.AssignColor(box, "Pages")
    End Sub
    Public Shared Sub EditorCharRaceDropChange(racedrop As ComboBox, forcebox As TextBox, abllist As ListBox, efflist As ListBox, bio As TextBox)
        'Dim RaceName As String = racedrop.Text
        ''Dim DBName As String = Settings.SettingsLastDB & MemoryBank.SavesExtL
        'Dim ForceID As String = ClarkTribeGames.SQLite.GetValue(MemoryBank.DataDir, DBName, "dbRace", "raceForce", "raceName", RaceName)
        'forcebox.Text = ClarkTribeGames.SQLite.GetValue(MemoryBank.DataDir, DBName, "dbForce", "forceName", "forceID", ForceID)
        'EditorCharBuildAblList(MemoryBank.DataDir, DBName, abllist, RaceName)
        'EditorCharBuildEffList(MemoryBank.DataDir, DBName, efflist, RaceName)
        'Dim EffIDString As String = ClarkTribeGames.SQLite.GetValue(MemoryBank.DataDir, DBName, "dbRace", "raceEff", "raceName", RaceName)
        'If EffIDString.Length > 0 Then
        '    Dim EffIDs() As String = EffIDString.Split("x")
        '    efflist.Items.Remove("<None>")
        '    For Each EffID In EffIDs
        '        efflist.Items.Add(ClarkTribeGames.SQLite.GetValue(MemoryBank.DataDir, DBName, "dbEff", "effName", "effID", EffID))
        '    Next
        'End If
        ''TO DO: Bio Builder Here
        'ClarkTribeGames.SQLite.CloseSQL(MemoryBank.DataDir, DBName)
    End Sub

    Private Shared Sub EditorCharBuildAblList(dir As String, db As String, abllist As ListBox, race As String)
        abllist.Items.Clear()
        abllist.Enabled = True
        Dim AblIDString As String = ClarkTribeGames.SQLite.GetValue(dir, db, "dbRace", "raceAbl", "raceName", race)
        If AblIDString.Length > 0 Then
            Dim AblIDs() As String = AblIDString.Split("x")
            For Each AblID In AblIDs
                abllist.Items.Add("[" & ClarkTribeGames.SQLite.GetValue(dir, db, "dbAbl", "ablName", "ablID", AblID & "]"))
            Next
        End If
        Tools.ClearDupes(abllist)
        If abllist.Items.Count = 0 Then
            abllist.Items.Add("<None>")
            abllist.Enabled = False
        End If
        Appearance.AssignColor(abllist, "Pages")
    End Sub
    Private Shared Sub EditorCharBuildEffList(dir As String, db As String, efflist As ListBox, race As String)
        efflist.Items.Clear()
        efflist.Enabled = True
        Dim EffIDString As String = ClarkTribeGames.SQLite.GetValue(dir, db, "dbRace", "raceEff", "raceName", race)
        If EffIDString.Length > 0 Then
            Dim EffIDs() As String = EffIDString.Split("x")
            For Each EffID In EffIDs
                efflist.Items.Add("[" & ClarkTribeGames.SQLite.GetValue(dir, db, "dbEff", "effName", "effID", EffID & "]"))
            Next
        End If
        Tools.ClearDupes(efflist)
        If efflist.Items.Count = 0 Then
            efflist.Items.Add("<None>")
            efflist.Enabled = False
        End If
        Appearance.AssignColor(efflist, "Pages")
    End Sub


End Class
