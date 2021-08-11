Public Class Optioner

    'Universal Controls
    Public Shared Sub ResetEditPath(editbutton As Button, pathtext As TextBox)
        editbutton.Text = "Edit Name"
        pathtext.BackColor = MemoryBank.PagesBackColor
        pathtext.ReadOnly = True
    End Sub
    Private Shared Function WhichDir(type As String) As String
        Select Case type
            Case "avatars"
                Return MemoryBank.AvatarsDir
            Case "music"
                Return MemoryBank.MusicDir
            Case "sound"
                Return MemoryBank.SoundDir
            Case "tracks"
                Return MemoryBank.MusicDir
            Case Else
                Return vbNull
        End Select
    End Function
    Private Shared Function WhichExt(type As String)
        Select Case type
            Case "avatars"
                Return MemoryBank.AvatarsExtL
            Case "music"
                Return MemoryBank.MusicExtL
            Case "sound"
                Return MemoryBank.SoundExtL
            Case "tracks"
                Return MemoryBank.MusicExtL
            Case Else
                Return vbNull
        End Select
    End Function

    'Group/Custom Section
    Public Shared Sub MoveGroup(type As String)
        Select Case LCase(type)
            Case "avatars"
                ShiftGroup(MainWindow.OptionsManageAvatars, "avatars", MainWindow.OptionsManageMusic, MainWindow.OptionsManageSound)
            Case "music"
                ShiftGroup(MainWindow.OptionsManageMusic, "music", MainWindow.OptionsManageAvatars, MainWindow.OptionsManageSound)
            Case "sound"
                ShiftGroup(MainWindow.OptionsManageSound, "sound", MainWindow.OptionsManageAvatars, MainWindow.OptionsManageMusic)
        End Select
    End Sub
    Private Shared Sub ShiftGroup(button As Button, type As String, other1 As Button, other2 As Button)
        If (MainWindow.CustomLibsGroup.Visible = False And button.ForeColor = MemoryBank.ButtonForeColor) Or (MainWindow.CustomLibsGroup.Visible = True And
            (other1.ForeColor = MemoryBank.ClickForeColor Or other2.ForeColor = MemoryBank.ClickForeColor)) Then
            button.ForeColor = MemoryBank.ClickForeColor
            MemoryBank.CustomLibsSelected = type
            OptionsGroupToLeft()
            MainWindow.CustomLibsGroup.Visible = True
            other1.ForeColor = MemoryBank.ButtonForeColor
            other2.ForeColor = MemoryBank.ButtonForeColor
        Else
            button.ForeColor = MemoryBank.ButtonForeColor
            other1.ForeColor = MemoryBank.ButtonForeColor
            other2.ForeColor = MemoryBank.ButtonForeColor
            MemoryBank.CustomLibsSelected = vbNull
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
    Private Shared Sub OptionsGroupLocationMove(x As Integer, y As Integer, groupbox As GroupBox)
        groupbox.Location = New Point(x, y)
    End Sub
    Private Shared Sub OptionsGroupToLeft()
        OptionsGroupLocationMove(180, 180, MainWindow.OptionsColorGroup)
        OptionsGroupLocationMove(180, 250, MainWindow.OptionsMusicGroup)
        OptionsGroupLocationMove(180, 450, MainWindow.OptionsManageGroup)
        MemoryBank.OptionsGroupLoc = "left"
        ResetEditPath(MainWindow.CustomLibsEdit, MainWindow.CustomLibsPath)
    End Sub
    Private Shared Sub OptionsGroupToMid()
        OptionsGroupLocationMove(420, 180, MainWindow.OptionsColorGroup)
        OptionsGroupLocationMove(420, 250, MainWindow.OptionsMusicGroup)
        OptionsGroupLocationMove(420, 450, MainWindow.OptionsManageGroup)
        MemoryBank.OptionsGroupLoc = "mid"
        ResetEditPath(MainWindow.CustomLibsEdit, MainWindow.CustomLibsPath)
    End Sub
    Public Shared Sub FlipOptionsGroups(action As Boolean)
        Dim Reaction As Boolean
        If action = True Then Reaction = False Else Reaction = True
        MainWindow.CustomLibsGroup.Visible = Reaction
        MainWindow.OptionsManageGroup.Enabled = action
        MainWindow.OptionsMusicGroup.Enabled = action
        MainWindow.OptionsColorGroup.Enabled = action
        MainWindow.OptionsAudioSelectIntro.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectBattle.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectVictory.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectDefeat.ForeColor = MemoryBank.ButtonForeColor
        Appearance.RefreshColors()
    End Sub
    Public Shared Sub CustomLibsListChanged()
        CustomLibsListChangeProcess(MainWindow.CustomLibsList)
    End Sub
    Private Shared Sub CustomLibsListChangeProcess(listname As ListBox)
        If listname.Enabled = True And listname.SelectedIndex >= 0 Then
            Dim SelectedName As String = listname.SelectedItem.ToString
            Dim SelectedDir As String = WhichDir(LCase(MemoryBank.CustomLibsSelected))
            Dim FoundIt As Boolean = False
            For Each Filename In FilesFolders.GetFilesInFolder(SelectedDir)
                If FoundIt = False Then
                    Dim ShortFileName As String = Replace(Filename, SelectedDir & "\", "", 1)
                    Dim FoundName As String = ShortFileName.Trim().Substring(0, ShortFileName.Length - 4)
                    If FoundName = SelectedName Then
                        FoundIt = True
                        CustomLibsNameFound(True, ShortFileName, CheckState.Checked, MemoryBank.GroupForeColor)
                    End If
                    If Replace(SelectedName, "Ω ", "Ω") = FoundName And FoundIt = False Then
                        FoundIt = True
                        CustomLibsNameFound(True, ShortFileName, CheckState.Unchecked, Color.Red)
                    End If
                    If FoundIt = True Then
                        Select Case LCase(MemoryBank.CustomLibsSelected)
                            Case "avatars"
                                CustomLibsPrivatePick(False)
                                MainWindow.CustomLibsPreviewImage.Image = Image.FromFile(Filename)
                                MainWindow.CustomLibsPreviewImage.SizeMode = PictureBoxSizeMode.StretchImage
                            Case Else
                                CustomLibsPrivatePick(True)
                                MainWindow.CustomLibsPreviewPlay.Enabled = True
                                MainWindow.CustomLibsMusicImage.BackgroundImage =
                                    Global.Limitless.My.Resources.Resources.mp3sound
                        End Select
                    End If
                End If
            Next
        Else
            MainWindow.CustomLibsEdit.Enabled = False
            MainWindow.CustomLibsDelete.Enabled = False
            MainWindow.CustomLibsPath.Text = ""
        End If
        Appearance.RefreshColors()
    End Sub
    Private Shared Sub CustomLibsNameFound(action As Boolean, name As String, check As CheckState, color As Color)
        MainWindow.CustomLibsPath.Enabled = action
        MainWindow.CustomLibsPath.Text = name
        MainWindow.CustomLibsDelete.Enabled = action
        MainWindow.CustomLibsEdit.Enabled = action
        MainWindow.CustomLibsActive.Enabled = action
        MainWindow.CustomLibsActive.CheckState = check
        MainWindow.CustomLibsActive.ForeColor = color
    End Sub
    Private Shared Sub CustomLibsPrivatePick(action As Boolean)
        Dim Reaction As Boolean
        If action = True Then Reaction = False Else Reaction = True
        MainWindow.CustomLibsPreviewMusic.Visible = action
        MainWindow.CustomLibsPreviewAvatar.Visible = Reaction
    End Sub
    Public Shared Sub CustomLibsActiveChanged(check As CheckBox, list As ListBox)
        CustomLibsActiveChangeProcess(check, list)
    End Sub
    Private Shared Sub CustomLibsActiveChangeProcess(checkbox As CheckBox, list As ListBox)
        If checkbox.Enabled = True Then
            Dim SelectedDir As String = WhichDir(LCase(MemoryBank.CustomLibsSelected))
            Dim Ext As String = WhichExt(LCase(MemoryBank.CustomLibsSelected))
            Dim SelectedFile As String = list.SelectedItem.ToString
            Dim ItemActive As Boolean
            Dim ChangePhrase As String, ChangeAction As String
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
                    CustomLibsActiveChangeAction(checkbox, list, SelectedDir, Ext, ChangeAction, OldName, NewName, CheckState.Checked,
                        MemoryBank.GroupForeColor)
                End If
                If answer = vbYes And ItemActive = True Then
                    NewName = "Ω" & SelectedFile
                    CustomLibsActiveChangeAction(checkbox, list, SelectedDir, Ext, ChangeAction, SelectedFile, NewName, CheckState.Unchecked,
                        Color.Red)
                End If
                If answer = vbYes Then
                    Optioner.CustomLibsListPop(True)
                    list.SelectedItem = Replace(NewName, "Ω", "Ω ")
                End If
                If Not answer = vbYes Then MsgBox("No Changes Made")
            End If
        End If
    End Sub
    Private Shared Sub CustomLibsActiveChangeAction(checkbox As CheckBox, list As ListBox, dir As String, ext As String,
        action As String, oldname As String, newname As String, checkstate As CheckState, color As Color)
        If LCase(MemoryBank.CustomLibsSelected) = "avatars" Then Avatars.ReleaseAvatarFromBox(MainWindow.CustomLibsPreviewImage)
        If Not LCase(MemoryBank.CustomLibsSelected) = "avatars" Then JukeboxIntro()
        Try
            My.Computer.FileSystem.RenameFile(dir & "/" & oldname & ext, newname & ext)
        Catch ex As Exception
            Logger.WriteToLog("Custom " & MemoryBank.CustomLibsSelected & " " &
            Converters.UppercaseEachFirstLetter(action), "Rename Attempt", ex)
            MsgBox(("Logged Error:  File locked, please try again."), vbOKOnly)
        End Try
        checkbox.Enabled = True
        Appearance.RefreshColors()
        checkbox.CheckState = checkstate
        checkbox.ForeColor = color
    End Sub
    Public Shared Sub CustomLibsPreviewPlay(list As ListBox, button As Button, check As CheckBox)
        CustomLibsPreviewPlayAction(list, button, check)
    End Sub
    Private Shared Sub CustomLibsPreviewPlayAction(list As ListBox, button As Button, check As CheckBox)
        If button.Enabled = True And check.CheckState = CheckState.Checked Then
            Dim SongFile As String = MemoryBank.MusicDir & "/" & Replace(list.SelectedItem, "Ω ", "Ω") & MemoryBank.MusicExtL
            Jukebox.StopSong()
            Do Until Jukebox.SongPlaying = False
                Jukebox.StopSong()
            Loop
            Jukebox.IntroInPlay = False
            Jukebox.PlayMp3(SongFile)
            FlipCustomOptions(False)
        End If
        Appearance.RefreshColors()
    End Sub
    Private Shared Sub FlipCustomOptions(action As Boolean)
        Dim Reaction As Boolean
        If action = True Then Reaction = False Else Reaction = True
        MainWindow.CustomLibsPreviewPlay.Enabled = action
        MainWindow.CustomLibsList.Enabled = action
        MainWindow.CustomLibsPreviewStop.Enabled = Reaction
        MainWindow.CustomLibsActive.Enabled = action
        MainWindow.CustomLibsEdit.Enabled = action
        MainWindow.CustomLibsMusicMsg.Visible = Reaction
        MainWindow.OptionsColorGroup.Enabled = action
        MainWindow.OptionsMusicGroup.Enabled = action
        MainWindow.OptionsManageGroup.Enabled = action
        MainWindow.CustomLibsImport.Enabled = action
        MainWindow.CustomLibsDelete.Enabled = action
        'OptionsManageSound.Enabled = action
    End Sub
    Public Shared Sub CustomLibsPreviewStop()
        CustomLibsPreviewStopAction()
    End Sub
    Private Shared Sub CustomLibsPreviewStopAction()
        JukeboxIntro()
        Appearance.RefreshColors()
    End Sub
    Public Shared Sub CustomLibsEditButton(list As ListBox, button As Button, text As TextBox, avatar As PictureBox)
        CustomLibsEditProcess(list, button, text, avatar)
    End Sub
    Private Shared Sub CustomLibsEditProcess(list As ListBox, button As Button, text As TextBox, avatar As PictureBox)
        Dim SelectedDir As String = WhichDir(MemoryBank.CustomLibsSelected)
        Dim Ext As String = WhichExt(MemoryBank.CustomLibsSelected)
        Dim SelectedName As String = list.SelectedItem.ToString, OldFileName As String
        OldFileName = SelectedDir & "/" & Replace(SelectedName, "Ω ", "Ω") & Ext
        Select Case button.Text
            Case "Edit Name"
                If MainWindow.CustomLibsEdit.Enabled = True Then
                    If System.IO.File.Exists(OldFileName) Then
                        Dim TempValue As String = text.Text
                        text.BackColor = Color.Red
                        text.Text = TempValue.Substring(0, TempValue.Length - 4)
                        text.ReadOnly = False
                        button.Text = "Confirm"
                    Else
                        MsgBox("Error: Could not verify file exists, please try again.", vbOKOnly)
                    End If
                End If
            Case "Confirm"
                Dim ClearToGo As Boolean = True
                Dim CheckName = SelectedDir & "/" & Replace(text.Text, "Ω ", "Ω") & Ext
                If System.IO.File.Exists(CheckName) Then
                    ClearToGo = False
                    MsgBox("The File Name " & text.Text & " already exists." & vbCrLf &
                        vbCrLf & "Please try it again.", vbOKOnly + vbCritical)
                End If
                If ClearToGo = True Then
                    Dim answer As Integer
                    If LCase(Settings.SettingsAutoSave) = "on" Then
                        answer = vbYes
                    Else
                        answer = MsgBox("Confirm:  Are you sure you want to rename " & OldFileName & " to " &
                            Replace(text.Text, "Ω ", "Ω") & "?", vbYesNo)
                    End If
                    If answer = vbYes Then
                        If LCase(MemoryBank.CustomLibsSelected) = "avatars" Then Avatars.ReleaseAvatarFromBox(avatar)
                        If Not LCase(MemoryBank.CustomLibsSelected) = "avatars" Then JukeboxIntro()
                        Try
                            My.Computer.FileSystem.RenameFile(OldFileName, Replace(text.Text, "Ω ", "Ω") & Ext)
                            Optioner.ResetEditPath(button, text)
                            Optioner.CustomLibsListPop(True)
                        Catch ex As Exception
                            Logger.WriteToLog("Custom " & MemoryBank.CustomLibsSelected & " Rename", "Rename Attempt", ex)
                            MsgBox(("Logged Error:  File locked, please try again." & vbCrLf), vbOKOnly)
                        End Try
                    End If
                End If
            Case Else
                '
        End Select
    End Sub
    Public Shared Sub CustomLibsDeleteButton(list As ListBox, button As Button, avatar As PictureBox)
        CustomLibsDeleteProcess(list, button, avatar)
    End Sub
    Private Shared Sub CustomLibsDeleteProcess(list As ListBox, button As Button, avatar As PictureBox)
        If list.Visible = True And button.Enabled = True Then
            Dim SelectedDir = WhichDir(LCase(MemoryBank.CustomLibsSelected))
            Dim Ext = WhichExt(LCase(MemoryBank.CustomLibsSelected))
            Dim SelectedName As String = list.SelectedItem.ToString, FileToGo As String
            Select Case (button.Text)
                Case "Delete"
                    FileToGo = SelectedDir & "/" & Replace(SelectedName, "Ω ", "Ω") & Ext
                    If button.Enabled = True Then
                        If System.IO.File.Exists(FileToGo) Then
                            Dim answer As Integer
                            If LCase(Settings.SettingsAutoSave) = "on" Then
                                answer = vbYes
                            Else
                                answer = MsgBox("Confirm:  Do you want to delete " & Replace(SelectedName, "Ω ", "Ω") & "?", vbYesNo)
                            End If
                            If answer = vbYes Then
                                If LCase(MemoryBank.CustomLibsSelected) = "avatars" Then Avatars.ReleaseAvatarFromBox(avatar)
                                If Not LCase(MemoryBank.CustomLibsSelected) = "avatars" Then JukeboxIntro()
                                Try
                                    FilesFolders.DeleteFile(FileToGo)
                                    Optioner.CustomLibsListPop(True)
                                Catch ex As Exception
                                    Logger.WriteToLog("Custom " & MemoryBank.CustomLibsSelected & " Delete", "Delete Attempt", ex)
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
                        answer = MsgBox("Confirm:  Do you want to change the Custom " & MemoryBank.SelectCustomTrack.Replace("OptionsAudioSelect", "") _
                            & " with " & SelectedName & "?", vbYesNo)
                    End If
                    If answer = vbYes Then
                        Select Case MemoryBank.SelectCustomTrack
                            Case MainWindow.OptionsAudioSelectIntro.Name.ToString
                                SelectedType = "custi"
                                Settings.SettingsCustI = CustSetting
                                MainWindow.OptionsAudioTextIntro.Visible = True
                                MainWindow.OptionsAudioTextIntro.Text = SelectedName
                            Case MainWindow.OptionsAudioSelectBattle.Name.ToString
                                SelectedType = "custb"
                                Settings.SettingsCustB = CustSetting
                                MainWindow.OptionsAudioTextBattle.Visible = True
                                MainWindow.OptionsAudioTextBattle.Text = SelectedName
                            Case MainWindow.OptionsAudioSelectVictory.Name.ToString
                                SelectedType = "custw"
                                Settings.SettingsCustW = CustSetting
                                MainWindow.OptionsAudioTextVictory.Visible = True
                                MainWindow.OptionsAudioTextVictory.Text = SelectedName
                            Case MainWindow.OptionsAudioSelectDefeat.Name.ToString
                                SelectedType = "custl"
                                Settings.SettingsCustL = CustSetting
                                MainWindow.OptionsAudioTextDefeat.Visible = True
                                MainWindow.OptionsAudioTextDefeat.Text = SelectedName
                        End Select
                        DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", SelectedType, {"settingConfig"}, {CustSetting})
                        Optioner.CheckCustomTracks("all")
                        If SelectedType = "custi" Then
                            Jukebox.IntroInPlay = False
                            Jukebox.SwitchToIntro()
                        End If
                    End If
            End Select
        End If
    End Sub
    Public Shared Sub CustomLibsImportButton()
        CustomLibsImportProcess()
    End Sub
    Private Shared Sub CustomLibsImportProcess()
        Dim SelectedDir As String = WhichDir(LCase(MemoryBank.CustomLibsSelected))
        Dim Ext As String = WhichExt(LCase(MemoryBank.CustomLibsSelected))
        Dim SourceFiles() As String, NewFile As String
        Dim fd As New OpenFileDialog With {
            .Title = "Custom " & Converters.UppercaseEachFirstLetter(MemoryBank.CustomLibsSelected) & " File(s) To Import",
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
                    If Not LCase(MemoryBank.CustomLibsSelected) = "avatars" Then
                        Try
                            FileSystem.FileCopy(SourceFile, NewFile)
                        Catch ex As Exception
                            Logger.WriteToLog("Custom " & MemoryBank.CustomLibsSelected & " Import", "Import Attempt - " &
                                SourceName & Ext, ex)
                            MsgBox(("Logged Error:  Internal copy error, please try again." & vbCrLf), vbOKOnly)
                        End Try
                    Else
                        Try
                            NewFile = LCase(NewFile)
                            NewFile = NewFile.Replace(Ext & Ext, Ext)
                            NewFile = Converters.UppercaseEachFirstLetter(NewFile)
                            Converters.ResizeImage(SourceFile, NewFile, 200, 200)
                            'Converters.ResizeImage(SourceFile, NewFile.Substring(0, NewFile.Length - 4), 200, 200)
                        Catch ex As Exception
                            Logger.WriteToLog("Custom " & MemoryBank.CustomLibsSelected & " Import", "Import Attempt - " &
                                SourceName & Ext, ex)
                            MsgBox(("Logged Error:  Internal copy error, please try again." & vbCrLf), vbOKOnly)
                        End Try
                    End If
                    Optioner.CustomLibsListPop(True)
                Else
                    MsgBox("Invalid file extension.  Please be sure to select a " & Ext & " file.", vbOKOnly + vbCritical)
                End If
            Next
        End If
    End Sub
    'Audio Section
    Private Shared Sub JukeboxIntro()
        Jukebox.ReturnToIntro(MainWindow.CustomLibsPreviewStop, MainWindow.CustomLibsPreviewPlay, MainWindow.CustomLibsList,
            MainWindow.CustomLibsActive, MainWindow.CustomLibsEdit, MainWindow.CustomLibsMusicMsg, MainWindow.OptionsColorGroup,
            MainWindow.OptionsMusicGroup, MainWindow.OptionsManageGroup, MainWindow.CustomLibsImport, MainWindow.CustomLibsDelete)
    End Sub
    Private Shared Sub OptionsAudioCheckChange(checkbox As CheckBox, button As Button, setting As String)
        Dim SettingsVariable As String, CurrentSetting As String = DBTools.GetValue(Settings.SettingsPath,
            Settings.SettingsName, "mainSettings", "settingConfig", "settingName", setting).Substring(3)
        If MainWindow.OptionsAudioCheckCustom.Checked And MainWindow.OptionsAudioCheckCustom.Enabled Then
            If checkbox.Checked Then
                button.Enabled = True
                button.Visible = True
                SettingsVariable = "on" & "-" & CurrentSetting
            Else
                button.Enabled = False
                button.Visible = False
                SettingsVariable = "of" & "-" & CurrentSetting
            End If
            Appearance.RefreshColors()
            Select Case LCase(setting)
                Case "custi"
                    Settings.SettingsCustI = SettingsVariable
                Case "custb"
                    Settings.SettingsCustB = SettingsVariable
                Case "custw"
                    Settings.SettingsCustW = SettingsVariable
                Case "custl"
                    Settings.SettingsCustL = SettingsVariable
            End Select
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", setting, {"settingConfig"}, {SettingsVariable})
            DBTools.CloseSQL(Settings.SettingsPath, Settings.SettingsName)
        End If
    End Sub
    Public Shared Sub DisableMusicOptions()
        FlipMusicOptions("options", False)
    End Sub
    Private Shared Sub FlipMusicOptions(type As String, action As Boolean)
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
    Private Shared Sub CheckCustomMusicOptions()
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
    Public Shared Sub CheckAllCustomTracks()
        CheckCustomTracks("all")
    End Sub
    Private Shared Sub CheckCustomTracks(type As String)
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
    Public Shared Sub SelectTrackChanges(button As Button)
        MemoryBank.SelectCustomTrack = ""
        If (MainWindow.CustomLibsGroup.Visible = False) Or (MainWindow.CustomLibsGroup.Visible = True And
            Not button.ForeColor = MemoryBank.ClickForeColor) Then
            MemoryBank.SelectCustomTrack = button.Name.ToString
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
            MemoryBank.CustomLibsSelected = "tracks"
            CustomLibsListPop(False)
        Else
            OptionsGroupToMid()
            MainWindow.CustomLibsGroup.Visible = False
            FlipTracksChanges()
            SelectTrackButtonReverse()
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
    Private Shared Sub FlipTracksChanges()
        MainWindow.CustomLibsActive.Visible = True
        MainWindow.CustomLibsEdit.Visible = True
        MainWindow.CustomLibsOmega.Visible = True
        MainWindow.CustomLibsSave.Visible = True
        MainWindow.CustomLibsAuto.Visible = True
        MainWindow.CustomLibsImport.Visible = True
        MainWindow.CustomLibsDelete.Text = "Delete"
    End Sub
    Private Shared Sub SelectTrackButtonReverse()
        MainWindow.OptionsAudioSelectIntro.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectBattle.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectVictory.ForeColor = MemoryBank.ButtonForeColor
        MainWindow.OptionsAudioSelectDefeat.ForeColor = MemoryBank.ButtonForeColor
        MemoryBank.SelectCustomTrack = ""
    End Sub
    Private Shared Sub CustomLibsListPop(omega As Boolean)
        Select Case LCase(MemoryBank.CustomLibsSelected)
            Case "avatars"
                Tools.CustomLibsListBuilder(MainWindow.CustomLibsList, MemoryBank.AvatarsDir, MemoryBank.AvatarsExtF,
                    MainWindow.CustomLibsImport, omega)
            Case "music"
                Tools.CustomLibsListBuilder(MainWindow.CustomLibsList, MemoryBank.MusicDir, MemoryBank.MusicExtF,
                    MainWindow.CustomLibsImport, omega)
            Case "sounds"
                Tools.CustomLibsListBuilder(MainWindow.CustomLibsList, MemoryBank.SoundDir, MemoryBank.SoundExtF,
                    MainWindow.CustomLibsImport, omega)
            Case "tracks"
                Tools.CustomLibsListBuilder(MainWindow.CustomLibsList, MemoryBank.MusicDir, MemoryBank.MusicExtF,
                    MainWindow.CustomLibsDelete, omega)
            Case Else
                '
        End Select
        MainWindow.CustomLibsPath.Text = ""
        If Not LCase(MemoryBank.CustomLibsSelected) = "tracks" Then
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
    Public Shared Sub OptionsAudioCheckMusic(type As String, checkbox As CheckBox, custom As CheckBox)
        Select Case LCase(type)
            Case "music"
                If checkbox.CheckState = CheckState.Checked Then
                    custom.Enabled = True
                    Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
                    Jukebox.IntroInPlay = True
                    If custom.CheckState = CheckState.Checked Then
                        FlipMusicOptions("checkboxes", True)
                        CheckCustomMusicOptions()
                    End If
                    DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "music", {"settingConfig"}, {"on"})
                    Settings.SettingsMusic = "on"
                Else
                    FlipMusicOptions("options", False)
                    custom.Enabled = False
                    Jukebox.StopSong()
                    DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "music", {"settingConfig"}, {"no"})
                    Settings.SettingsMusic = "off"
                End If
                Appearance.RefreshColors()
            Case "custom"
                If custom.Enabled Then
                    If custom.Checked Then
                        FlipMusicOptions("checkboxes", True)
                        CheckCustomMusicOptions()
                        CheckCustomTracks("all")
                        DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custm", {"settingConfig"}, {"on"})
                        Settings.SettingsCustM = "on"
                    Else
                        FlipMusicOptions("options", False)
                        DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "custm", {"settingConfig"}, {"no"})
                        Settings.SettingsCustM = "off"
                        FlipMusicOptions("customtracks)", False)
                    End If
                End If
                Jukebox.IntroInPlay = False
                Jukebox.SwitchToIntro()
            Case "sound"
                If (checkbox.Enabled = True And checkbox.CheckState = CheckState.Checked) Or checkbox.Enabled = False Then
                    'Future process to turn on sound
                ElseIf checkbox.Enabled = True And checkbox.CheckState = CheckState.Unchecked Then
                    'Future process to turn off sound
                End If
            Case Else
                Dim cust As String = "", textbox As Label = MainWindow.OptionsAudioTextIntro, button As Button = MainWindow.OptionsAudioSelectIntro
                Select Case type
                    Case "intro"
                        cust = "custi"
                        textbox = MainWindow.OptionsAudioTextIntro
                        button = MainWindow.OptionsAudioSelectIntro
                    Case "battle"
                        cust = "custb"
                        textbox = MainWindow.OptionsAudioTextBattle
                        button = MainWindow.OptionsAudioSelectBattle
                    Case "victory"
                        cust = "custw"
                        textbox = MainWindow.OptionsAudioTextVictory
                        button = MainWindow.OptionsAudioSelectVictory
                    Case "defeat"
                        cust = "custl"
                        textbox = MainWindow.OptionsAudioTextDefeat
                        button = MainWindow.OptionsAudioSelectDefeat
                End Select
                If checkbox.Checked = CheckState.Unchecked Then
                    DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", cust, {"settingConfig"}, {"off"})
                    textbox.Visible = False
                    button.Visible = False
                Else
                    OptionsAudioCheckChange(checkbox, button, "custi")
                    CheckCustomTracks("intro")
                End If
                Jukebox.IntroInPlay = False
                Jukebox.SwitchToIntro()
        End Select
    End Sub

    'Color Section
    Public Shared Sub ColorModeChange(type As String)
        Select Case LCase(type)
            Case "dark"
                ColorModeCheckChange(MainWindow.OptionsColorDark, MainWindow.OptionsColorLite, MainWindow.OptionsColorCustom, "Dark")
            Case "lite"
                ColorModeCheckChange(MainWindow.OptionsColorLite, MainWindow.OptionsColorDark, MainWindow.OptionsColorCustom, "Lite")
            Case "custom"
                ColorModeCheckChange(MainWindow.OptionsColorCustom, MainWindow.OptionsColorLite, MainWindow.OptionsColorDark, "Custom")
        End Select
    End Sub
    Private Shared Sub ColorModeCheckChange(active As CheckBox, other1 As CheckBox, other2 As CheckBox, setting As String)
        If active.Checked Then
            other1.CheckState = CheckState.Unchecked
            other2.CheckState = CheckState.Unchecked
            DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "mode", {"settingConfig"}, {setting})
            Settings.SettingsMode = setting
            If Not LCase(MemoryBank.ColorModeAtStart) = LCase(setting) Then
                ColorModeChecks(Settings.SettingsMode)
            End If
        End If
        Appearance.RefreshColors()
        Optioner.ResetEditPath(MainWindow.CustomLibsEdit, MainWindow.CustomLibsPath)
    End Sub
    Private Shared Sub ColorModeChecks(type As String)
        Select Case LCase(type)
            Case "lite"
                MainWindow.OptionsColorLite.CheckState = CheckState.Checked
                MainWindow.OptionsColorDark.CheckState = CheckState.Unchecked
                MainWindow.OptionsColorLite.Enabled = False
                MainWindow.OptionsColorDark.Enabled = True
                MemoryBank.ColorModeAtStart = "lite"
            Case "dark"
                MainWindow.OptionsColorLite.CheckState = CheckState.Unchecked
                MainWindow.OptionsColorDark.CheckState = CheckState.Checked
                MainWindow.OptionsColorLite.Enabled = True
                MainWindow.OptionsColorDark.Enabled = False
                MemoryBank.ColorModeAtStart = "dark"
            Case Else
                'Future Custom Goes Here
        End Select
    End Sub

    'Sound Section

End Class
