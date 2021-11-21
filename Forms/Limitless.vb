Public Class MainWindow

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
        LoadButton.MouseHover, ExitButton.MouseHover, EditButton.MouseHover, BackButton.MouseHover, AboutButton.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, UpdateButton.MouseLeave, OptionsButton.MouseLeave,
        LoadButton.MouseLeave, ExitButton.MouseLeave, EditButton.MouseLeave, BackButton.MouseHover, AboutButton.MouseLeave,
        StartButton.MouseClick, UpdateButton.MouseClick, OptionsButton.MouseClick, LoadButton.MouseClick, ExitButton.MouseClick, EditButton.MouseClick,
        BackButton.MouseClick, AboutButton.MouseClick
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartButton.MouseDown, UpdateButton.MouseDown, OptionsButton.MouseDown,
        LoadButton.MouseDown, ExitButton.MouseDown, EditButton.MouseDown, BackButton.MouseDown, AboutButton.MouseDown
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
        WelcomePanel.Visible = False
        activepanel.Visible = True
        activepanel.Focus()
        If Not WelcomePanel.Visible = True Then BackButton.Visible = True Else BackButton.Visible = False
    End Sub
    Private Sub ListLostFocus(listname As Object)
        listname.ClearSelected()
    End Sub

    'StartGame
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        NewGame.PrepNewGame()
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'TO DO:  Save check here
        MenuButtonPressed(WelcomePanel)
    End Sub

    'LoadGame
    'TO DO: Build Load Game Here

    'Editor

    'Optioner
    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        Optioner.ShowDialog()
    End Sub

    'SaveGame
    'TO DO:  Build Save Game Here.

    'Updater
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Updater.ShowDialog()
    End Sub
    Private Sub UpdateInstallButton_Click(sender As Object, e As EventArgs)
        ClarkTribeGames.Updater.InstallUpdate(Application.ProductName, MemoryBank.UpdaterURL)
    End Sub
    'Abouter
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        Abouter.ShowDialog()
    End Sub
    'Exiter
    Private Sub Exit_Program(sender As Object, e As MouseEventArgs) Handles TitleBarIcon.DoubleClick, CloseButton.MouseDown, CloseText.MouseDown, ExitButton.MouseClick
        Exiter.ExitTheGame()
    End Sub

End Class
