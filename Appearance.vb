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
        MemoryBank.DonateForeColor = Color.DarkRed
        MemoryBank.DonateHoverOver = Color.DarkGreen
        MemoryBank.ButtonMouseDownBack = Color.Black
        MemoryBank.ButtonDisabledColor = Color.FromArgb(5, 5, 5)
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
        MemoryBank.DonateForeColor = Color.DarkRed
        MemoryBank.DonateHoverOver = Color.DarkGreen
        MemoryBank.ButtonMouseDownBack = SystemColors.Control
        MemoryBank.ButtonDisabledColor = Color.FromArgb(RGB(5, 5, 5))
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
        AssignColor(MainWindow.OptionsPanel, "Pages")
        AssignColor(MainWindow.OptionsColorGroup, "Group")
        AssignColor(MainWindow.OptionsMusicGroup, "Group")
        AssignColor(MainWindow.OptionsManageGroup, "Group")
        AssignColor(MainWindow.OptionsAudioSelectBattle, "Button")
        AssignColor(MainWindow.OptionsAudioSelectDefeat, "Button")
        AssignColor(MainWindow.OptionsAudioSelectIntro, "Button")
        AssignColor(MainWindow.OptionsAudioSelectVictory, "Button")
        AssignColor(MainWindow.OptionsManageAvatars, "Button")
        AssignColor(MainWindow.OptionsManageMusic, "Button")
        AssignColor(MainWindow.OptionsManageSound, "Button")
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


End Module
