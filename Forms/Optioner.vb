Public Class Optioner

    Dim ActivePanel As String
    Dim SelectedThemeInfo As String()
    Dim CopyThemeName As String
    Private Sub Optioner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildOptioner()
    End Sub
    Private Sub BuildOptioner()
        OptionsDrop.Items.Clear()
        SystemText.Text = Settings.SettingsUID
        VersionText.Text = MemoryBank.VersionNumber
        ColorText.Text = Settings.SettingsMode
        DBText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsDB)
        MusicText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsMusic)
        SoundsText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsSound)
        For Each item In MemoryBank.OptionsDrop
            OptionsDrop.Items.Add(item)
        Next
        ActivePanel = ""
        OptionsDrop.SelectedIndex = 0
    End Sub
    Private Sub OptionsDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OptionsDrop.SelectedIndexChanged
        OptionDropUpdate()
    End Sub
    Private Sub OptionDropUpdate()
        ActivePanel = OptionsDrop.Text
        OptionsList.Enabled = True
        OptionsList.Items.Clear()
        Select Case LCase(ActivePanel)
            Case "avatars"
                ResetAvatar()
                For Each item In ListOfFiles(MemoryBank.AvatarsDir, MemoryBank.AvatarsExtL)
                    OptionsList.Items.Add(item)
                Next
                EmptyListCheck("<No " & LCase(ActivePanel) & " available>")
                OptionsItemText.Text = ActivePanel & " In \" & MemoryBank.AvatarsDir & "\"
                SwitchPanel(AvatarPanel, 0)
            Case "colors"
                For Each item In ClarkTribeGames.SQLite.QuerySQL(Settings.SettingsPath, Settings.SettingsName,
                    "SELECT colorname From colorSettings where coloract LIKE '1';", "col", {"colorname"}).Split(",")
                    OptionsList.Items.Add(item)
                Next
                CDescBox.Text = ""
                CDescBox.BorderStyle = BorderStyle.None
                CDescBox.Cursor = Cursors.Arrow
                EmptyListCheck("<No " & LCase(ActivePanel) & " available>")
                OptionsItemText.Text = ActivePanel & " Options"
                SwitchPanel(ColorsPanel, 0)
                FlipCDrops(False)
                OptionsAddButton.Enabled = True
                SetColors()
            Case "databases"
                For Each item In ListOfFiles(MemoryBank.DataDir, MemoryBank.SavesExtL)
                    OptionsList.Items.Add(Replace(item, MemoryBank.SavesExtL, ""))
                Next
                EmptyListCheck("<No " & LCase(ActivePanel) & " available>")
                OptionsItemText.Text = ActivePanel & " In \" & MemoryBank.DataDir & "\"
                CDBText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsDB)
                SwitchPanel(DBPanel, 0)
                SetDatabases()
            Case "music"
                For Each item In ListOfFiles(MemoryBank.MusicDir, MemoryBank.MusicExtL)
                    OptionsList.Items.Add(item)
                Next
                EmptyListCheck("<No " & LCase(ActivePanel) & " available>")
                OptionsItemText.Text = ActivePanel & " In \" & MemoryBank.MusicDir & "\"
                SwitchPanel(MusicPanel, 0)
            Case "sounds"
                For Each item In ListOfFiles(MemoryBank.SoundDir, MemoryBank.SoundExtL)
                    OptionsList.Items.Add(item)
                Next
                EmptyListCheck("<No " & LCase(ActivePanel) & " available>")
                OptionsItemText.Text = ActivePanel & " In \" & MemoryBank.SoundDir & "\"
                SwitchPanel(SoundsPanel, 0)
            Case Else
                ActivePanel = ""
                EmptyListCheck("<No option selected>")
                OptionsItemText.Text = ""
                SwitchPanel(OptionsMainPanel, 1)
        End Select
        Appearance.RefreshColors()
    End Sub
    Private Sub SwitchPanel(active As Panel, none As Integer)
        AvatarPanel.Visible = False
        ColorsPanel.Visible = False
        DBPanel.Visible = False
        MusicPanel.Visible = False
        SoundsPanel.Visible = False
        If Not none > 0 Then
            active.Visible = True
        End If
        OptionsDeleteButton.Enabled = False
        OptionsRenameButton.Enabled = False
    End Sub
    Private Function ListOfFiles(path As String, ext As String) As List(Of String)
        Dim list As New List(Of String)
        For Each item In ClarkTribeGames.FilesFolders.GetFilesInFolder(path)
            If item.Contains(ext) Then
                list.Add(Replace(item, path & "\", ""))
            End If
        Next
        Return list
    End Function
    Private Sub EmptyListCheck(phrase As String)
        If Not OptionsList.Items.Count > 0 Then
            OptionsList.Items.Add(phrase)
            OptionsList.Enabled = False
        End If
    End Sub

    Private Sub OptionsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OptionsList.SelectedIndexChanged
        Select Case LCase(ActivePanel)
            Case "avatars"
                If OptionsList.Enabled = True And OptionsList.SelectedIndex > -1 Then
                    DimText.Text = ClarkTribeGames.FilesFolders.GetDims(MemoryBank.AvatarsDir & "\" & OptionsList.SelectedItem.ToString).Replace("x", " x ") & " pixels"
                    Avatars.SetAvatar(OptionsList.SelectedItem.ToString, AvatarImage)
                    AvatarText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(OptionsList.SelectedItem.ToString).Replace(MemoryBank.AvatarsExtL, "")
                    DimLabel.Visible = True
                    DimText.Visible = True
                    OptionsRenameButton.Enabled = True
                    OptionsDeleteButton.Enabled = True
                Else
                    ResetAvatar()
                End If
            Case "colors"
                If OptionsList.Enabled = True And OptionsList.SelectedIndex > -1 Then
                    CThemeText.Text = Settings.SettingsMode
                    SThemeLabel.Visible = True
                    SThemeText.Visible = True
                    SThemeText.Text = OptionsList.SelectedItem.ToString
                    SetCDrops(ClarkTribeGames.SQLite.GetRow(Settings.SettingsPath, Settings.SettingsName, "colorSettings", "colorname", OptionsList.SelectedItem.ToString).Split(","))
                    ResetThemeButton.Visible = False
                    CopyThemeButton.Enabled = True
                    SaveThemeButton.Enabled = False
                    RandomThemeButton.Visible = False
                    FlipCDrops(False)
                    If Not SThemeText.Text = "Dark Mode" And Not SThemeText.Text = "Lite Mode" Then
                        EditThemeButton.Enabled = True
                        OptionsRenameButton.Enabled = True
                        OptionsDeleteButton.Enabled = True
                    Else
                        EditThemeButton.Enabled = False
                        OptionsRenameButton.Enabled = False
                        OptionsDeleteButton.Enabled = False
                    End If
                    If CThemeText.Text = SThemeText.Text Then SetActiveButton.Enabled = False Else SetActiveButton.Enabled = True
                Else
                    SThemeLabel.Visible = False
                    SThemeText.Visible = False
                    SaveThemeButton.Enabled = False
                    EditThemeButton.Enabled = False
                    OptionsRenameButton.Enabled = False
                    OptionsDeleteButton.Enabled = False
                    SetActiveButton.Enabled = False
                End If
            Case "databases"
                If OptionsList.Enabled = True And OptionsList.SelectedIndex > -1 Then
                    CDBText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsDB)
                    SDBLabel.Visible = True
                    SDBText.Visible = True
                    SDBText.Text = OptionsList.SelectedItem.ToString
                    If OptionsList.Items.Count > 0 Then
                        OptionsRenameButton.Enabled = True
                    Else
                        OptionsRenameButton.Enabled = False
                    End If
                    CopyDBButton.Enabled = True
                    If Not LCase(CDBText.Text) = LCase(SDBText.Text) Then
                        SetActiveDBButton.Enabled = True
                        OptionsDeleteButton.Enabled = True
                    Else
                        SetActiveDBButton.Enabled = False
                        OptionsDeleteButton.Enabled = False
                    End If
                    If OptionsList.Items.Count < 2 Then
                        OptionsDeleteButton.Enabled = False
                    End If
                Else
                    SetDatabases()
                    OptionsDeleteButton.Enabled = False
                    OptionsRenameButton.Enabled = False
                End If
            Case "music"
                '
            Case "sounds"
                '
            Case Else
                '
        End Select
        Appearance.RefreshColors()
    End Sub
    Private Sub ResetAvatar()
        AvatarImage.Image = My.Resources._empty_
        AvatarText.Text = "Select an Avatar"
        DimLabel.Visible = False
        DimText.Visible = False
        OptionsRenameButton.Enabled = False
        OptionsDeleteButton.Enabled = False
    End Sub
    Private Sub SetColors()
        CThemeText.Text = Settings.SettingsMode
        SThemeLabel.Visible = False
        SThemeText.Visible = False
        SThemeText.Text = ""
        ResetThemeButton.Visible = False
        CopyThemeButton.Enabled = True
        EditThemeButton.Enabled = False
        SaveThemeButton.Enabled = False
        SetActiveButton.Enabled = False
        FillSpecDrop(TBarODrop)
        FillSpecDrop(TBarIDrop)
        FillSpecDrop(TButODrop)
        FillSpecDrop(TButIDrop)
        FillSpecDrop(BGODrop)
        FillSpecDrop(BGIDrop)
        FillSpecDrop(TXODrop)
        FillSpecDrop(TXIDrop)
        FillSpecDrop(ButODrop)
        FillSpecDrop(ButIDrop)
        FillSpecDrop(DisDrop)
        FillSpecDrop(HOODrop)
        FillSpecDrop(HOIDrop)
        FillSpecDrop(ClickODrop)
        FillSpecDrop(ClickIDrop)
    End Sub
    Private Sub FillSpecDrop(drop As Object)
        drop.Items.Clear()
        For Each colorname As String In MemoryBank.CSpectrum
            drop.Items.Add(colorname)
        Next
    End Sub
    Private Sub SpecDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TBarODrop.SelectedIndexChanged, TBarIDrop.SelectedIndexChanged, TButODrop.SelectedIndexChanged,
        TButIDrop.SelectedIndexChanged, BGODrop.SelectedIndexChanged, BGIDrop.SelectedIndexChanged, TXODrop.SelectedIndexChanged, TXIDrop.SelectedIndexChanged, ButODrop.SelectedIndexChanged,
        ButIDrop.SelectedIndexChanged, DisDrop.SelectedIndexChanged, HOODrop.SelectedIndexChanged, HOIDrop.SelectedIndexChanged,
        ClickODrop.SelectedIndexChanged, ClickIDrop.SelectedIndexChanged
        Dim dropname As String = ClarkTribeGames.Converters.ControlToString(sender)
        FindColorBox(dropname).BackColor = FindColor(sender.text)
    End Sub
    Private Function FindColorBox(dropname As String) As Object
        Select Case LCase(dropname)
            Case "tbarodrop"
                Return TBarOColor
            Case "tbaridrop"
                Return TBarIColor
            Case "tbutodrop"
                Return TButOColor
            Case "tbutidrop"
                Return TButIColor
            Case "bgodrop"
                Return BGOColor
            Case "bgidrop"
                Return BGIColor
            Case "txodrop"
                Return TXOColor
            Case "txidrop"
                Return TXIColor
            Case "butodrop"
                Return ButOColor
            Case "butidrop"
                Return ButIColor
            Case "disdrop"
                Return DisColor
            Case "hoodrop"
                Return HOOColor
            Case "hoidrop"
                Return HOIColor
            Case "clickodrop"
                Return ClickOColor
            Case "clickidrop"
                Return ClickIColor
            Case Else
                Return vbNull
        End Select
    End Function
    Private Function FindColor(colorname As String) As Color
        Select Case colorname
            Case "Dark Red"
                Return Appearance.Colorer("dred")
            Case "Red"
                Return Appearance.Colorer("red")
            Case "Pink"
                Return Appearance.Colorer("pink")
            Case "Orange"
                Return Appearance.Colorer("orange")
            Case "Brown"
                Return Appearance.Colorer("brown")
            Case "Dark Gold"
                Return Appearance.Colorer("dgold")
            Case "Yellow"
                Return Appearance.Colorer("yellow")
            Case "Yellow Green"
                Return Appearance.Colorer("ygreen")
            Case "Light Green"
                Return Appearance.Colorer("lgreen")
            Case "Green"
                Return Appearance.Colorer("green")
            Case "Dark Green"
                Return Appearance.Colorer("dgreen")
            Case "Cyan"
                Return Appearance.Colorer("cyan")
            Case "Light Blue"
                Return Appearance.Colorer("lblue")
            Case "Blue"
                Return Appearance.Colorer("blue")
            Case "Dark Blue"
                Return Appearance.Colorer("dblue")
            Case "Sky Blue"
                Return Appearance.Colorer("sblue")
            Case "Indigo"
                Return Appearance.Colorer("indigo")
            Case "Purple"
                Return Appearance.Colorer("purple")
            Case "Antique White"
                Return Appearance.Colorer("awhite")
            Case "White"
                Return Appearance.Colorer("white")
            Case "Light Grey"
                Return Appearance.Colorer("lgrey")
            Case "Grey"
                Return Appearance.Colorer("grey")
            Case "Dark Grey"
                Return Appearance.Colorer("dgrey")
            Case "Black"
                Return Appearance.Colorer("ablack")
            Case "True Black"
                Return Appearance.Colorer("black")
            Case Else
                Return Color.Transparent
        End Select
    End Function
    Private Function FindColorText(colorname As String) As String
        Select Case colorname
            Case "dred"
                Return "Dark Red"
            Case "red"
                Return "Red"
            Case "pink"
                Return "Pink"
            Case "orange"
                Return "Orange"
            Case "brown"
                Return "Brown"
            Case "dgold"
                Return "Dark Gold"
            Case "yellow"
                Return "Yellow"
            Case "ygreen"
                Return "Yellow Green"
            Case "lgreen"
                Return "Light Green"
            Case "green"
                Return "Green"
            Case "dgreen"
                Return "Dark Green"
            Case "cyan"
                Return "Cyan"
            Case "lblue"
                Return "Light Blue"
            Case "blue"
                Return "Blue"
            Case "dblue"
                Return "Dark Blue"
            Case "sblue"
                Return "Sky Blue"
            Case "indigo"
                Return "Indigo"
            Case "purple"
                Return "Purple"
            Case "awhite"
                Return "Antique White"
            Case "white"
                Return "White"
            Case "lgrey"
                Return "Light Grey"
            Case "grey"
                Return "Grey"
            Case "dgrey"
                Return "Dark Grey"
            Case "ablack"
                Return "Black"
            Case "black"
                Return "True Black"
            Case Else
                Return vbNull
        End Select
    End Function
    Private Function FindColorCode(colorname As String) As String
        Select Case colorname
            Case "Dark Red"
                Return "dred"
            Case "Red"
                Return "red"
            Case "Pink"
                Return "pink"
            Case "Orange"
                Return "orange"
            Case "Brown"
                Return "brown"
            Case "Dark Gold"
                Return "dgold"
            Case "Yellow"
                Return "yellow"
            Case "Yellow Green"
                Return "ygreen"
            Case "Light Green"
                Return "lgreen"
            Case "Green"
                Return "green"
            Case "Dark Green"
                Return "dgreen"
            Case "Cyan"
                Return "cyan"
            Case "Light Blue"
                Return "lblue"
            Case "Blue"
                Return "blue"
            Case "Dark Blue"
                Return "dblue"
            Case "Sky Blue"
                Return "sblue"
            Case "Indigo"
                Return "indigo"
            Case "Purple"
                Return "purple"
            Case "Antique White"
                Return "awhite"
            Case "White"
                Return "white"
            Case "Light Grey"
                Return "lgrey"
            Case "Grey"
                Return "grey"
            Case "Dark Grey"
                Return "dgrey"
            Case "Black"
                Return "ablack"
            Case "True Black"
                Return "black"
            Case Else
                Return vbNull
        End Select
    End Function
    Private Sub SetCDrops(colorset As String())
        CDescBox.Text = colorset(3)
        CDescBox.BorderStyle = BorderStyle.None
        CDescBox.Cursor = Cursors.Arrow
        TBarODrop.SelectedIndex = TBarODrop.FindStringExact(FindColorText(colorset(4)))
        TBarIDrop.SelectedIndex = TBarIDrop.FindStringExact(FindColorText(colorset(5)))
        TButODrop.SelectedIndex = TButODrop.FindStringExact(FindColorText(colorset(6)))
        TButIDrop.SelectedIndex = TButIDrop.FindStringExact(FindColorText(colorset(7)))
        BGODrop.SelectedIndex = BGODrop.FindStringExact(FindColorText(colorset(8)))
        BGIDrop.SelectedIndex = BGIDrop.FindStringExact(FindColorText(colorset(9)))
        TXODrop.SelectedIndex = TXODrop.FindStringExact(FindColorText(colorset(10)))
        TXIDrop.SelectedIndex = TXIDrop.FindStringExact(FindColorText(colorset(11)))
        ButODrop.SelectedIndex = ButODrop.FindStringExact(FindColorText(colorset(12)))
        ButIDrop.SelectedIndex = ButIDrop.FindStringExact(FindColorText(colorset(13)))
        DisDrop.SelectedIndex = DisDrop.FindStringExact(FindColorText(colorset(17)))
        HOODrop.SelectedIndex = HOODrop.FindStringExact(FindColorText(colorset(18)))
        HOIDrop.SelectedIndex = HOIDrop.FindStringExact(FindColorText(colorset(19)))
        ClickODrop.SelectedIndex = ClickODrop.FindStringExact(FindColorText(colorset(22)))
        ClickIDrop.SelectedIndex = ClickIDrop.FindStringExact(FindColorText(colorset(23)))
    End Sub
    Private Sub RandCDrops()
        Dim max As Integer = TBarODrop.Items.Count - 1
        TBarODrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        TBarIDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        TButODrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        TButIDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        BGODrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        BGIDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        TXODrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        TXIDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        ButODrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        ButIDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        DisDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        HOODrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        HOIDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        ClickODrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
        ClickIDrop.SelectedIndex = ClarkTribeGames.Calculator.Randomizer(0, max)
    End Sub
    Private Sub FlipCDrops(status As Boolean)
        TBarODrop.Enabled = status
        TBarIDrop.Enabled = status
        TButODrop.Enabled = status
        TButIDrop.Enabled = status
        BGODrop.Enabled = status
        BGIDrop.Enabled = status
        TXODrop.Enabled = status
        TXIDrop.Enabled = status
        ButODrop.Enabled = status
        ButIDrop.Enabled = status
        DisDrop.Enabled = status
        HOODrop.Enabled = status
        HOIDrop.Enabled = status
        ClickODrop.Enabled = status
        ClickIDrop.Enabled = status
    End Sub
    Private Sub RandomThemeButton_Click(sender As Object, e As EventArgs) Handles RandomThemeButton.Click
        'TO DO:  Make pretty form dialog box
        Dim answer As Integer = MsgBox("This will randomize each color which could result in an unbearable theme.  Proceed?", vbYesNo)
        If answer = vbYes Then
            RandCDrops()
        Else
            MsgBox("Action Cancelled.")
        End If
    End Sub
    Private Sub ResetThemeButton_Click(sender As Object, e As EventArgs) Handles ResetThemeButton.Click
        'TO DO:  Make pretty form dialog box
        Dim answer As Integer = MsgBox("Doing this sets this theme back to previous settings before editing.  Proceed?", vbYesNo)
        If answer = vbYes Then
            SetCDrops(SelectedThemeInfo)
        Else
            MsgBox("Action Cancelled.")
        End If
    End Sub
    Private Sub CopyThemeButton_Click(sender As Object, e As EventArgs) Handles CopyThemeButton.Click
        SelectedThemeInfo = ClarkTribeGames.SQLite.QuerySQL(Settings.SettingsPath, Settings.SettingsName,
            "SELECT * FROM colorSettings where colorname = '" & ClarkTribeGames.Converters.UppercaseEachFirstLetter(
            OptionsList.SelectedItem.ToString) & "' and coloract = '1';", "row", Enumerable.Empty(Of String).ToArray).Split(",")
        ThemePrompt("add")
        SetCDrops(SelectedThemeInfo)
        SaveTheme(CopyThemeName)
    End Sub
    Private Sub EditThemeButton_Click(sender As Object, e As EventArgs) Handles EditThemeButton.Click
        If Not SThemeText.Text = "Dark Mode" And Not SThemeText.Text = "Lite Mode" Then
            FlipCDrops(True)
            CDescBox.ReadOnly = False
            CDescBox.BorderStyle = BorderStyle.FixedSingle
            CDescBox.Cursor = Cursors.IBeam
            EditThemeButton.Enabled = False
            SaveThemeButton.Enabled = True
            ResetThemeButton.Visible = True
            ResetThemeButton.Enabled = True
            RandomThemeButton.Visible = True
            RandomThemeButton.Enabled = True
            SetActiveButton.Enabled = False
            CopyThemeButton.Enabled = False
            OptionsAddButton.Enabled = False
            OptionsDeleteButton.Enabled = False
            OptionsRenameButton.Enabled = False
            OptionsList.Enabled = False
        End If
        SelectedThemeInfo = ClarkTribeGames.SQLite.QuerySQL(Settings.SettingsPath, Settings.SettingsName,
            "SELECT * FROM colorSettings where colorname = '" & ClarkTribeGames.Converters.UppercaseEachFirstLetter(
            OptionsList.SelectedItem.ToString) & "' and coloract = '1';", "row", Enumerable.Empty(Of String).ToArray).Split(",")
        Appearance.RefreshColors()
    End Sub
    Private Sub SaveThemeButton_Click(sender As Object, e As EventArgs) Handles SaveThemeButton.Click
        SaveTheme(ClarkTribeGames.Converters.UppercaseEachFirstLetter(OptionsList.SelectedItem.ToString))
    End Sub
    Private Sub SaveTheme(colorname As String)
        'TO DO: Create a pretty dialog box for this in a form.
        Dim Collect As String() = {(FindColorCode(TBarODrop.SelectedItem.ToString)), (FindColorCode(TBarIDrop.SelectedItem.ToString)),
            (FindColorCode(TButODrop.SelectedItem.ToString)), (FindColorCode(TButIDrop.SelectedItem.ToString)), (FindColorCode(BGODrop.SelectedItem.ToString)),
            (FindColorCode(BGIDrop.SelectedItem.ToString)), (FindColorCode(TXODrop.SelectedItem.ToString)), (FindColorCode(TXIDrop.SelectedItem.ToString)),
            (FindColorCode(ButODrop.SelectedItem.ToString)), (FindColorCode(ButIDrop.SelectedItem.ToString)), "green", "dgreen",
            (FindColorCode(DisDrop.SelectedItem.ToString)), (FindColorCode(HOODrop.SelectedItem.ToString)), (FindColorCode(HOIDrop.SelectedItem.ToString)),
            (FindColorCode(ClickODrop.SelectedItem.ToString)), (FindColorCode(ClickIDrop.SelectedItem.ToString))}
        Try
            ClarkTribeGames.SQLite.RunSQL(Settings.SettingsPath, Settings.SettingsName, "UPDATE colorSettings SET colordesc = '" & CDescBox.Text & "', tbarb = '" &
                Collect(0) & "', tbarf = '" & Collect(1) & "', tbutb = '" & Collect(2) & "', tbutf = '" & Collect(3) & "', backb = '" & Collect(4) & "', 
                backf = '" & Collect(5) & "', pageb = '" & Collect(6) & "', pagef = '" & Collect(7) & "', buttb = '" & Collect(8) & "', buttf = '" & Collect(9) & "', 
                donaf = '" & Collect(10) & "', donah = '" & Collect(11) & "', buttmdb = '" & Collect(14) & "', buttdc = '" & Collect(12) & "', hoveb = '" & Collect(13) & "', 
                hovef = '" & Collect(14) & "', leavb = '" & Collect(8) & "', leavf = '" & Collect(9) & "', clicb = '" & Collect(15) & "', clicf = '" & Collect(16) & "', 
                groub = '" & Collect(6) & "', grouf = '" & Collect(7) & "' WHERE colorname = '" & ClarkTribeGames.Converters.UppercaseEachFirstLetter(colorname) & "';")
            MsgBox("Save Successful!", vbOKOnly)
            EditThemeButton.Enabled = True
            SaveThemeButton.Enabled = False
            ResetThemeButton.Visible = False
            ResetThemeButton.Enabled = False
            RandomThemeButton.Visible = False
            RandomThemeButton.Enabled = False
            SetActiveButton.Enabled = True
            CopyThemeButton.Enabled = True
            OptionsAddButton.Enabled = True
            OptionsDeleteButton.Enabled = True
            OptionsRenameButton.Enabled = True
            OptionsList.Enabled = True
            CDescBox.ReadOnly = True
            CDescBox.BorderStyle = BorderStyle.None
            CDescBox.Cursor = Cursors.Arrow
            OptionDropUpdate()
        Catch ex As Exception
            MsgBox("Something went wrong... " & vbCrLf & vbCrLf & ex.ToString())
        End Try
    End Sub
    Private Sub SetActiveButton_Click(sender As Object, e As EventArgs) Handles SetActiveButton.Click
        'TO DO: Create a pretty dialog box for this in a form.
        Dim check As Integer
        Dim newtheme As String = SThemeText.Text
        Try
            check = OptionsList.FindStringExact(newtheme)
        Catch ex As Exception
            check = -1
        End Try
        If check = -1 Then
            MsgBox("Please Save The New Theme First!")
            Exit Sub
        End If
        Dim answer As Integer = MsgBox("Are you sure you want to change the theme to " & newtheme & "?", vbYesNo)
        If answer = vbYes Then
            Appearance.AssignTheme(newtheme)
        Else
            MsgBox("Operation Cancelled.")
            Exit Sub
        End If
        OptionsList.SelectedIndex = OptionsList.FindStringExact(newtheme)
    End Sub
    Private Sub SetDatabases()
        CDBText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsDB)
        SDBLabel.Visible = False
        SDBText.Visible = False
        CopyDBButton.Enabled = False
        SetActiveDBButton.Enabled = False
        Appearance.RefreshColors()
    End Sub
    Private Sub BlankDBButton_Click(sender As Object, e As EventArgs) Handles BlankDBButton.Click
        DBPrompt("blank")
        OptionDropUpdate()
    End Sub

    Private Sub CopyDBButton_Click(sender As Object, e As EventArgs) Handles CopyDBButton.Click
        DBPrompt("dupe")
        OptionDropUpdate()
    End Sub
    Private Sub SetActiveDBButton_Click(sender As Object, e As EventArgs) Handles SetActiveDBButton.Click
        If SetActiveDBButton.Enabled = True Then
            Dim dbname = ClarkTribeGames.Converters.UppercaseEachFirstLetter(OptionsList.SelectedItem.ToString)
            ClarkTribeGames.SQLite.RunSQL(Settings.SettingsPath, Settings.SettingsName,
                "UPDATE mainSettings SET settingConfig = '" & LCase(dbname) & "' WHERE settingName like 'defaultdb';")
            Settings.SettingsDB = LCase(dbname)
            MsgBox(ClarkTribeGames.Converters.UppercaseEachFirstLetter(dbname) & "has been set as the Active Database!", vbOKOnly)
            OptionsList.SelectedIndex = -1
            OptionsList.SelectedIndex = OptionsList.FindStringExact(dbname)
        End If
    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles OptionsAddButton.Click
        AddProcess()
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles OptionsDeleteButton.Click
        DeleteProcess()
    End Sub
    Private Sub RenameButton_Click(sender As Object, e As EventArgs) Handles OptionsRenameButton.Click
        RenamePrompt()
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles OptionsRefreshButton.Click
        OptionDropUpdate()
    End Sub
    Private Sub AddProcess()
        If Not ActivePanel = "Colors" Then
            Dim SelectedDir As String = WhichDir(LCase(ActivePanel))
            Dim Ext As String = WhichExt(LCase(ActivePanel))
            Dim SourceFiles() As String, NewFile As String
            Dim FileType As String = ClarkTribeGames.Converters.UppercaseEachFirstLetter(ActivePanel)
            If FileType.EndsWith("s") Then FileType.Substring(0, FileType.Length - 1)
            Dim fd As New OpenFileDialog With {
            .Title = "Custom " & FileType & " File(s) To Import",
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
                        If Not LCase(ActivePanel) = "avatars" Then
                            Try
                                FileSystem.FileCopy(SourceFile, NewFile)
                            Catch ex As Exception
                                ClarkTribeGames.Logger.WriteToLog("Custom " & FileType & " Import", "Import Attempt - " &
                                SourceName & Ext, ex)
                                MsgBox(("Logged Error:  Internal copy error, please try again." & vbCrLf), vbOKOnly)
                            End Try
                        Else
                            Try
                                NewFile = LCase(NewFile)
                                NewFile = NewFile.Replace(Ext & Ext, Ext)
                                NewFile = ClarkTribeGames.Converters.UppercaseEachFirstLetter(NewFile)
                                ClarkTribeGames.Converters.ResizeImage(SourceFile, NewFile, 200, 200)
                            Catch ex As Exception
                                ClarkTribeGames.Logger.WriteToLog("Custom " & FileType & " Import", "Import Attempt - " &
                                SourceName & Ext, ex)
                                MsgBox(("Logged Error:  Internal copy error, please try again." & vbCrLf), vbOKOnly)
                            End Try
                        End If
                    Else
                        MsgBox("Invalid file extension.  Please be sure to select a " & Ext & " file.", vbOKOnly + vbCritical)
                    End If
                Next
            End If
            OptionDropUpdate()
        Else
            ThemePrompt("add")
        End If
    End Sub
    Private Sub AddTheme(newname As String)
        Dim count As String = CStr(ClarkTribeGames.SQLite.GetRowCount(Settings.SettingsPath, Settings.SettingsName, "colorSettings") + 1)
        ClarkTribeGames.SQLite.RunSQL(Settings.SettingsPath, Settings.SettingsName, "INSERT INTO 'main'.'colorSettings' VALUES ('" & count & "', '" &
            ClarkTribeGames.Converters.UppercaseEachFirstLetter(newname) & "', '1', 'New Theme','white', 'white', 'white', 'white', 'white', 'white', 'white', 'white',
            'white', 'white', 'white', 'white', 'white', 'white', 'white', 'white', 'white', 'white', 'white', 'white', 'white', 'white');")
        MsgBox("The theme " & newname & " has been added.  Please be sure to edit the colors before applying!", vbOKOnly)
        OptionDropUpdate()
        OptionsList.SelectedIndex = OptionsList.FindStringExact(ClarkTribeGames.Converters.UppercaseEachFirstLetter(newname))
        CopyThemeName = ClarkTribeGames.Converters.UppercaseEachFirstLetter(newname)
    End Sub
    Private Sub ThemePrompt(type As String)
        Dim themename As String
        If LCase(type) = "rename" Then
            themename = OptionsList.SelectedItem.ToString
        Else
            themename = "New Theme"
        End If
        Dim newname As String = ClarkTribeGames.Converters.UppercaseEachFirstLetter(InputBox("Please enter a new name for the theme:",
            ClarkTribeGames.Converters.UppercaseEachFirstLetter(type) & " Theme", themename))
        If newname.Length = 0 Then
            MsgBox("File name length Cannot be zero.")
            RenamePrompt()
        Else
            If LCase(type) = "rename" Then
                If LCase(newname) = LCase(OptionsList.SelectedItem.ToString) Then
                    MsgBox("Same File Name, No Change.")
                    Exit Sub
                End If
            End If
            Dim found As Integer = -1
            found = OptionsList.FindStringExact(newname)
            If Not found = -1 Then
                MsgBox("Theme name already exists!")
                ThemePrompt(type)
            Else
                If LCase(type) = "rename" Then
                    RenameTheme(themename, newname)
                Else
                    AddTheme(newname)
                End If
            End If
        End If
    End Sub
    Private Sub DBPrompt(type As String)
        Dim dbname As String = "", typeext As String
        If LCase(type) = "dupe" Then dbname = OptionsList.SelectedItem.ToString
        If LCase(type) = "dupe" Then
            typeext = "Duplicate DB to New DB"
        Else
            typeext = "Create Blank New DB"
        End If
        Dim newname As String = ClarkTribeGames.Converters.UppercaseEachFirstLetter(InputBox("Please enter a name new database:",
            typeext, "New Database"))
        If newname.Length = 0 Then
            MsgBox("File name length Cannot be zero.")
            DBPrompt(type)
        Else
            Dim found As Integer = -1
            found = OptionsList.FindStringExact(newname)
            If Not found = -1 Then
                MsgBox("DB name already exists!")
                DBPrompt(type)
            Else
                If LCase(type) = "dupe" Then
                    System.IO.File.Copy(MemoryBank.DataDir & "\" & dbname & MemoryBank.SavesExtL, MemoryBank.DataDir & "\" & LCase(newname) & MemoryBank.SavesExtL)
                    MsgBox(ClarkTribeGames.Converters.UppercaseEachFirstLetter(newname) & " Database created as duplicate of " & ClarkTribeGames.Converters.UppercaseEachFirstLetter(dbname) & ".", vbOKOnly)
                Else
                    Database.CreateEmptyDB(LCase(newname))
                    MsgBox(ClarkTribeGames.Converters.UppercaseEachFirstLetter(newname) & " Database created as a new blank database.", vbOKOnly)
                End If
            End If
        End If
    End Sub
    Private Sub RenamePrompt()
        If Not LCase(ActivePanel) = "colors" Then
            Dim SelectedDir As String = WhichDir(LCase(ActivePanel))
            Dim Ext As String = WhichExt(LCase(ActivePanel))
            Dim FileName As String = OptionsList.SelectedItem.ToString.Replace(Ext, "")
            'TO DO:  Improve this with a separate form window
            Dim newname As String = InputBox("Please enter a new name for the file:", "Rename File", FileName)
            If newname.Length = 0 Then
                MsgBox("File name length Cannot be zero.")
                RenamePrompt()
            Else
                If LCase(newname) = LCase(OptionsList.SelectedItem.ToString.Replace(Ext, "")) Then
                    MsgBox("Same File Name, No Change.")
                    Exit Sub
                Else
                    If System.IO.File.Exists(SelectedDir & "\" & newname & Ext) Then
                        MsgBox("File name already exists!")
                        RenamePrompt()
                    Else
                        RenameProcess(FileName, newname)
                    End If
                End If
            End If
        Else
            ThemePrompt("rename")
        End If
    End Sub
    Private Sub RenameProcess(oldname As String, newname As String)
        Dim SelectedDir As String = WhichDir(LCase(ActivePanel))
        Dim Ext As String = WhichExt(LCase(ActivePanel))
        If LCase(ActivePanel) = "avatars" Then
            Avatars.ReleaseAvatarFromBox(AvatarImage)
        End If
        Try
            My.Computer.FileSystem.RenameFile(SelectedDir & "\" & oldname & Ext, newname & Ext)
            If LCase(ActivePanel) = "databases" Then
                ClarkTribeGames.SQLite.RunSQL(Settings.SettingsPath, Settings.SettingsName,
                "UPDATE mainSettings SET settingConfig = '" & LCase(newname) & "' WHERE settingName like 'defaultdb';")
                Settings.SettingsDB = LCase(newname)
            End If
        Catch ex As Exception
            ClarkTribeGames.Logger.WriteToLog("Rename Process", "Rename Attempt", ex)
            MsgBox(("Logged Error:  File locked, please try again."), vbOKOnly)
        End Try
        OptionDropUpdate()
        OptionsList.SelectedIndex = OptionsList.FindStringExact(newname & Ext)
    End Sub
    Private Sub RenameTheme(old As String, newname As String)
        Dim UID As String = ClarkTribeGames.SQLite.GetValue(Settings.SettingsPath, Settings.SettingsName, "colorSettings", "uid", "colorname", old)
        ClarkTribeGames.SQLite.UpdateData(Settings.SettingsPath, Settings.SettingsName, "colorSettings", "uid", UID, {"colorname"}, {newname})
        OptionDropUpdate()
        OptionsList.SelectedIndex = OptionsList.FindStringExact(newname)
    End Sub
    Private Sub DeleteProcess()
        'TO DO:  Make into a pretty form dialog
        Dim answer As Integer = MsgBox("Are you sure you want to delete " & ClarkTribeGames.Converters.UppercaseEachFirstLetter(OptionsList.SelectedItem.ToString) & "?", vbYesNo)
        If answer = vbYes Then
            If Not LCase(ActivePanel) = "colors" Then
                Dim SelectedDir As String = WhichDir(LCase(ActivePanel))
                Dim Ext As String = WhichExt(LCase(ActivePanel))
                Dim FileName As String = OptionsList.SelectedItem.ToString.Replace(Ext, "")
                If LCase(ActivePanel) = "avatars" Then
                    Avatars.ReleaseAvatarFromBox(AvatarImage)
                End If
                Try
                    ClarkTribeGames.FilesFolders.DeleteFile(SelectedDir & "\" & FileName & Ext)
                Catch ex As Exception
                    ClarkTribeGames.Logger.WriteToLog("Delete Process", "Delete Attempt", ex)
                    MsgBox(("Logged Error:  File locked, please try again."), vbOKOnly)
                End Try
            Else
                ClarkTribeGames.SQLite.RunSQL(Settings.SettingsPath, Settings.SettingsName, "UPDATE colorSettings SET coloract = '0' WHERE colorname like '" &
                ClarkTribeGames.Converters.UppercaseEachFirstLetter(OptionsList.SelectedItem.ToString) & "';")
            End If
            OptionDropUpdate()
            OptionsList.SelectedIndex = -1
        Else
            MsgBox("Action Cancelled.")
        End If
    End Sub
    Private Shared Function WhichDir(type As String) As String
        Select Case type
            Case "avatars"
                Return MemoryBank.AvatarsDir
            Case "databases"
                Return MemoryBank.DataDir
            Case "music"
                Return MemoryBank.MusicDir
            Case "sounds"
                Return MemoryBank.SoundDir
            Case Else
                Return vbNull
        End Select
    End Function
    Private Shared Function WhichExt(type As String)
        Select Case type
            Case "avatars"
                Return MemoryBank.AvatarsExtL
            Case "databases"
                Return MemoryBank.SavesExtL
            Case "music"
                Return MemoryBank.MusicExtL
            Case "sound"
                Return MemoryBank.SoundExtL
            Case Else
                Return vbNull
        End Select
    End Function


    'Music Section
    Private Shared Sub JukeboxIntro()
        'Jukebox.ReturnToIntro(MainWindow.CustomLibsPreviewStop, MainWindow.CustomLibsPreviewPlay, MainWindow.CustomLibsList,
        '    MainWindow.CustomLibsActive, MainWindow.CustomLibsEdit, MainWindow.CustomLibsMusicMsg, MainWindow.OptionsColorGroup,
        '    MainWindow.OptionsMusicGroup, MainWindow.OptionsManageGroup, MainWindow.CustomLibsImport, MainWindow.CustomLibsDelete)
    End Sub

    'Sound Section

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
    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseMove, TitleLabel.MouseMove
        If MemoryBank.WindowDrag Then
            Me.Left = Cursor.Position.X - MemoryBank.WindowMouseX
            Me.Top = Cursor.Position.Y - MemoryBank.WindowMouseY
        End If
    End Sub
    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseDown, TitleLabel.MouseDown
        MemoryBank.WindowDrag = True
        MemoryBank.WindowMouseX = Cursor.Position.X - Me.Left
        MemoryBank.WindowMouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp
        MemoryBank.WindowDrag = False
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover,
            OptionerBackButton.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave,
            OptionerBackButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown,
            OptionerBackButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub CloseWindow(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, CloseText.MouseDown, CloseButton.Click, OptionerBackButton.Click
        Me.Close()
    End Sub
End Class