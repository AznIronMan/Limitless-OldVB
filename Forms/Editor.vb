Public Class Editor

    Public Shared ReadOnly SaveDir As String = MemoryBank.DataDir & "\"
    Public Shared ReadOnly SaveFile As String = Settings.SettingsDB & MemoryBank.SavesExtL
    Public Shared ReadOnly SelectPhrase As String = "[Select a Category]"
    Public Shared DropSelect As String = ""
    Public Shared ListSelect As String = ""
    Public Shared SelectType As String = ""
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildEditor()
    End Sub
    Private Sub BuildEditor()
        If Settings.SettingsMMM = "on" Then mmmCheck.CheckState = CheckState.Checked Else mmmCheck.CheckState = CheckState.Unchecked
        EditorDrop.Items.Clear()
        EditorDrop.Items.Add(SelectPhrase)
        EditorDBText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsDB)
        For Each item In ClarkTribeGames.SQLite.QuerySQL(SaveDir, SaveFile,
            "SELECT idxName from all_Index where idxActive = '1'" & ModMakerMode() & ";", "col", {"idxName"}).Split(",")
            EditorDrop.Items.Add(item)
        Next
        EditorDrop.SelectedIndex = 0
        FlipButtons(True)
        SelectionActive(False)
        Appearance.RefreshColors()
    End Sub
    Private Sub FlipButtons(mode As Boolean)
        EditorAddButton.Enabled = mode
        EditorEditButton.Enabled = mode
        EditorCopyButton.Enabled = mode
        EditorDeleteButton.Enabled = mode
        EditorImportButton.Enabled = mode
        EditorSearchButton.Enabled = mode
        EditorMultiButton.Enabled = mode
        EditorSelectButton.Enabled = mode
        EditorClearButton.Enabled = mode
        DisabledButtons()
    End Sub
    Private Sub SelectionActive(mode As Boolean)
        If mode = False Then
            EditorCountText.Text = ""
            EditorDescText.Text = ""
            EditorList.Items.Clear()
        End If
        EditorFilterText.Enabled = mode
        EditorFilterButton.Enabled = mode
        EditorList.Enabled = mode
        EditorEditButton.Enabled = mode
        EditorCopyButton.Enabled = mode
        EditorDeleteButton.Enabled = mode
        Appearance.RefreshColors()
    End Sub
    Private Sub DisabledButtons()
        'This is a temporary measure until this future features are implemented.
        EditorImportButton.Enabled = False
        EditorSearchButton.Enabled = False
        EditorMultiButton.Enabled = False
        EditorSelectButton.Enabled = False
        EditorClearButton.Enabled = False
        EditorImportButton.Visible = False
        EditorSearchButton.Visible = False
        EditorMultiButton.Visible = False
        EditorSelectButton.Visible = False
        EditorClearButton.Visible = False
    End Sub
    Private Sub EditorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EditorDrop.SelectedIndexChanged
        ListSelection(EditorDrop.SelectedItem.ToString)
    End Sub
    Private Sub ListSelection(cat As String)
        EditorFilterText.Text = ""
        If Not LCase(cat) = LCase(SelectPhrase) Then EditorDescText.Text = ClarkTribeGames.SQLite.QuerySQL(SaveDir, SaveFile,
            "SELECT idxDesc from all_Index where idxActive = '1' and idxName = '" & cat & "';", "row", Enumerable.Empty(Of String).ToArray).Split(",")(0)
        Select Case LCase(cat)
            Case LCase(SelectPhrase)
                EditorDescText.Text = ""
                EditorCountText.Text = ""
                SelectionActive(False)
            Case "abilities"
                SetListItem(cat, "dbAbl", "ablName")
            Case "abilities types"
                SetListItem(cat, "dbAblType", "abltypeName")
            Case "ages"
                SetListItem(cat, "dbAge", "ageName")
            Case "aliases"
                SetListItem(cat, "dbAlias", "aliasName")
            Case "alignments"
                SetListItem(cat, "dbAlign", "alignName")
            Case "arenas"
                SetListItem(cat, "dbArenas", "arenaName")
            Case "characters"
                SetListItem(cat, "dbToons", "toonName")
            Case "classes"
                SetListItem(cat, "dbClass", "className")
            Case "destinies"
                SetListItem(cat, "dbDestiny", "destinyName")
            Case "editor categories"
                SetListItem(cat, "all_Index", "idxName")
            Case "effects"
                SetListItem(cat, "dbEff", "effName")
            Case "effect types"
                SetListItem(cat, "dbEffType", "efftypeName")
            Case "elements"
                SetListItem(cat, "dbElements", "elementName")
            Case "environments"
                SetListItem(cat, "dbEnviro", "enviroName")
            Case "existences"
                SetListItem(cat, "dbExistence", "existName")
            Case "genders"
                SetListItem(cat, "dbGender", "genderName")
            Case "items"
                SetListItem(cat, "dbItems", "itemName")
            Case "item classes"
                SetListItem(cat, "dbItemClass", "itemclassName")
            Case "items types"
                SetListItem(cat, "dbItemType", "itemtypeName")
            Case "jobs"
                SetListItem(cat, "dbJobs", "jobName")
            Case "languages"
                SetListItem(cat, "dbLang", "langName")
            Case "life forces"
                SetListItem(cat, "dbForce", "forceName")
            Case "life force obtains"
                SetListItem(cat, "dbForceObtain", "forceOName")
            Case "multiverse"
                SetListItem("Universes", "dbVerse", "verseName")
            Case "races"
                SetListItem(cat, "dbRace", "raceName")
            Case "relationships"
                SetListItem(cat, "dbRelation", "relationName")
            Case "sections"
                SetListItem(cat, "dbSections", "sectionName")
            Case "sizes"
                SetListItem(cat, "dbSize", "sizeName")
            Case "stats"
                SetListItem(cat, "dbStats", "statName")
            Case "statuses"
                SetListItem(cat, "dbStatus", "statusName")
            Case "teams"
                SetListItem(cat, "dbTeam", "teamName")
            Case Else
                'This is intentionally empty.
        End Select
        DropSelect = ClarkTribeGames.Converters.UppercaseEachFirstLetter(cat)
    End Sub
    Private Sub SetListItem(type As String, table As String, col As String)
        EditorList.Items.Clear()
        SelectionActive(True)
        Dim count As Integer = ClarkTribeGames.SQLite.GetRowCount(SaveDir, SaveFile, table)
        If Not count = 0 Then
            For Each item In ClarkTribeGames.SQLite.GetCol(SaveDir, SaveFile, table, col).Split(",")
                EditorList.Items.Add(item)
            Next
            EditorCountText.Text = ClarkTribeGames.Converters.UppercaseEachFirstLetter(type) & ": " & EditorList.Items.Count
        Else
            SelectionActive(False)
            EditorList.Enabled = True
            EditorList.Items.Add("<No " & ClarkTribeGames.Converters.UppercaseEachFirstLetter(type) & " Available>")
            EditorList.Enabled = False
            EditorCountText.Text = "No " & ClarkTribeGames.Converters.UppercaseEachFirstLetter(type)
        End If
    End Sub
    Private Sub EditorList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EditorList.SelectedIndexChanged
        ListSelect = ClarkTribeGames.Converters.UppercaseEachFirstLetter(EditorList.SelectedItem.ToString)
    End Sub

    Private Sub EditorList_DoubleClick(sender As Object, e As EventArgs) Handles EditorList.DoubleClick
        Dim cat As String = LCase(EditorDrop.SelectedItem.ToString)
        SelectType = "edit"
        Select Case cat
            Case "editor categories"
                Editor_Index.ShowDialog()
        End Select
    End Sub
    '
    Private Function ModMakerMode() As String
        If Not Settings.SettingsMMM = "on" Then Return " and idxHidden = '0'" Else Return ""
    End Function
    Private Sub MmmCheck_CheckedChanged(sender As Object, e As EventArgs) Handles mmmCheck.CheckedChanged
        MmmChange(mmmCheck)
    End Sub
    Private Sub MmmChange(checkbox As CheckBox)
        If checkbox.CheckState = CheckState.Checked Then
            Settings.SettingsMMM = "on"
        Else
            Settings.SettingsMMM = "off"
        End If
        ClarkTribeGames.SQLite.RunSQL(Settings.SettingsPath, Settings.SettingsName,
             "UPDATE mainSettings SET settingConfig = '" & Settings.SettingsMMM & "' WHERE settingName like 'mmm';")
        BuildEditor()
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

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover, EditorBackButton.MouseHover, EditorAddButton.MouseHover,
        EditorEditButton.MouseHover, EditorCopyButton.MouseHover, EditorDeleteButton.MouseHover, EditorImportButton.MouseHover, EditorSearchButton.MouseHover,
        EditorMultiButton.MouseHover, EditorSelectButton.MouseHover, EditorClearButton.MouseHover, EditorFilterButton.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave, EditorBackButton.MouseLeave, EditorAddButton.MouseLeave,
        EditorEditButton.MouseLeave, EditorCopyButton.MouseLeave, EditorDeleteButton.MouseLeave, EditorImportButton.MouseLeave, EditorSearchButton.MouseLeave,
        EditorMultiButton.MouseLeave, EditorSelectButton.MouseLeave, EditorClearButton.MouseLeave, EditorFilterButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, EditorBackButton.MouseDown, EditorAddButton.MouseDown,
        EditorEditButton.MouseDown, EditorCopyButton.MouseDown, EditorDeleteButton.MouseDown, EditorImportButton.MouseDown, EditorSearchButton.MouseDown,
        EditorMultiButton.MouseDown, EditorSelectButton.MouseDown, EditorClearButton.MouseDown, EditorFilterButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub CloseWindow(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, CloseText.MouseDown, CloseButton.Click, EditorBackButton.Click
        Me.Close()
    End Sub

End Class