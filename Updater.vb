Public Class Updater
    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildUpdater()
    End Sub
    Private Sub BuildUpdater()
        InstallGameBox.Text = MemoryBank.VersionNumber
        SelectDBDrop.Items.Clear()
        For Each item In Database.DBFolderQuery()
            SelectDBDrop.Items.Add(ClarkTribeGames.Converters.UppercaseEachFirstLetter(item.Replace(MemoryBank.SavesExtL, "")))
        Next
        If SelectDBDrop.Items.Count > 0 Then
            DBUpdateButton.Enabled = True
            SelectDBDrop.Enabled = True
            Dim lastdb As String = ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsLastDB)
            If SelectDBDrop.Items.Contains(lastdb) Then
                SelectDBDrop.SelectedIndex = SelectDBDrop.FindStringExact(lastdb)
            Else
                SelectDBDrop.SelectedIndex = SelectDBDrop.FindStringExact(ClarkTribeGames.Converters.UppercaseEachFirstLetter(Settings.SettingsDefaultDB))
            End If
        Else
            SelectDBDrop.Items.Add("<No Database Files Available>")
            SelectDBDrop.Enabled = False
            DBUpdateButton.Text = "No Database File"
            DBUpdateButton.Enabled = False
        End If
        If ClarkTribeGames.Web.CheckWeb() Then
            MemoryBank.AvailableVer = ClarkTribeGames.MySQLReader.Query(LCase(Application.ProductName.ToString()), "v")
            MemoryBank.OnlineDBVer = ClarkTribeGames.MySQLReader.Query(LCase(Application.ProductName.ToString() & "db"), "v")
            AvailGameBox.Text = MemoryBank.AvailableVer
            OnlineDBBox.Text = MemoryBank.OnlineDBVer
            If (ClarkTribeGames.Updater.Checker(MemoryBank.VersionNumber, MemoryBank.AvailableVer)) Then
                UpdateChanges(GameUpdateButton, True, "Install Game Update")
                ClarkTribeGames.Jukebox.StopSong()
            Else
                UpdateChanges(GameUpdateButton, False, "Game Is Current")
            End If
        Else
            AvailGameBox.Text = "Not Available"
            GameUpdateButton.Text = "Not Available"
            OnlineDBText.Text = "Not Available"
            DBUpdateButton.Text = "Not Available"
            GameUpdateButton.Enabled = False
            DBUpdateButton.Enabled = False
        End If
    End Sub
    Private Sub SelectDBDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectDBDrop.SelectedIndexChanged
        UpdateDBInfo(SelectDBDrop.Text)
    End Sub

    Private Sub UpdateDBInfo(database As String)
        MemoryBank.CurrentDBVer = ClarkTribeGames.SQLite.GetValue(MemoryBank.DataDir, database & MemoryBank.SavesExtL, "dbinfo", "dbVersion", "dbName", database)
        InstallDBBox.Text = MemoryBank.CurrentDBVer
        If OnlineDBText.Text.Length > 0 Or OnlineDBText.Text.Contains("Not Available") Then CompareDBVersions()
    End Sub

    Public Sub CompareDBVersions()
        If CLng(Replace(MemoryBank.OnlineDBVer, ".", "")) > CLng(Replace(MemoryBank.CurrentDBVer, ".", "")) Then
            DBUpdateButton.Text = "Update Database Now"
            'TO DO:  Add DB updater sub here and change two lines below this one
            DBUpdateButton.Text = "Feature Unavailable"
            DBUpdateButton.Enabled = False
        Else
            DBUpdateButton.Enabled = False
            DBUpdateButton.Text = "Database Is Current"
        End If
    End Sub

    Public Shared Sub CheckUpdate()
        If ClarkTribeGames.Web.CheckWeb() Then
            MemoryBank.AvailableVer = ClarkTribeGames.MySQLReader.Query(LCase(Application.ProductName.ToString()), "v")
            If (ClarkTribeGames.Updater.Checker(MemoryBank.VersionNumber, MemoryBank.AvailableVer)) Then
                MsgBox("Game Update Available!" & vbCrLf & vbCrLf & "Please Update via the Update Button!", vbOKOnly + vbExclamation)
            End If
        End If
    End Sub
    Private Shared Sub UpdateChanges(button As Object, enable As Boolean, buttontext As String)
        button.Enabled = enable
        button.Text = buttontext
        Appearance.RefreshColors()
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

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover, GameUpdateButton.MouseHover, DBUpdateButton.MouseHover,
            UpdaterBackButton.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave, GameUpdateButton.MouseLeave, DBUpdateButton.MouseLeave,
            UpdaterBackButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, GameUpdateButton.MouseDown, DBUpdateButton.MouseDown,
            UpdaterBackButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub CloseWindow(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, CloseText.MouseDown, CloseButton.Click, UpdaterBackButton.Click
        MemoryBank.DocToRead = ""
        Me.Close()
    End Sub

End Class