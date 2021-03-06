Module Appearance

    Dim AppearanceMode As String = "Dark"

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
        MemoryBank.ButtonMouseDownBack = Color.Black
        MemoryBank.ButtonDisabledColor = Color.FromArgb(22, 22, 22)
        MemoryBank.HoverBackColor = Color.Black
        MemoryBank.HoverForeColor = Color.Blue
        MemoryBank.LeaveBackColor = Color.Black
        MemoryBank.LeaveForeColor = Color.WhiteSmoke
        MemoryBank.ClickBackColor = Color.Black
        MemoryBank.ClickForeColor = Color.Red
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
        MemoryBank.ButtonMouseDownBack = SystemColors.Control
        MemoryBank.ButtonDisabledColor = Color.FromArgb(RGB(22, 22, 22))
        MemoryBank.HoverBackColor = SystemColors.Control
        MemoryBank.HoverForeColor = Color.Blue
        MemoryBank.LeaveBackColor = SystemColors.Control
        MemoryBank.LeaveForeColor = SystemColors.ControlText
        MemoryBank.ClickBackColor = SystemColors.Control
        MemoryBank.ClickForeColor = Color.Red
    End Sub

    Public Sub AssignMode(mode As String)
        If mode = "Ugly" Then
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
        AssignColor(MainWindow.DonateButton, "Button")
        AssignColor(MainWindow.UpdateButton, "Button")
        AssignColor(MainWindow.ExitButton, "Button")

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
            Case "Hover"
                obj.BackColor = MemoryBank.HoverBackColor
                obj.ForeColor = MemoryBank.HoverForeColor
            Case "Leave"
                obj.BackColor = MemoryBank.LeaveBackColor
                obj.ForeColor = MemoryBank.LeaveForeColor
            Case "Click"
                obj.BackColor = MemoryBank.ClickBackColor
                obj.ForeColor = MemoryBank.ClickForeColor
            Case Else
                obj.BackColor = MemoryBank.PagesBackColor
                obj.ForeColor = MemoryBank.PagesForeColor
        End Select
    End Sub


End Module
