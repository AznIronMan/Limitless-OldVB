Module Appearance

    Public Function Colorer(colorname As String) As Color
        Select Case LCase(colorname)
            Case "dblue"
                Return Color.DarkBlue
            Case "white"
                Return Color.WhiteSmoke
            Case "dgrey"
                Return Color.FromArgb(22, 22, 22)
            Case "black"
                Return Color.Black
            Case "lgreen"
                Return Color.LightGreen
            Case "grey"
                Return Color.Gray
            Case "blue"
                Return Color.Blue
            Case "red"
                Return Color.Red
            Case "ablack"
                Return Color.FromArgb(5, 5, 5)
            Case "green"
                Return Color.Green
            Case "purple"
                Return Color.Violet
            Case "cyan"
                Return Color.Cyan
            Case "orange"
                Return Color.Orange
            Case "indigo"
                Return Color.Indigo
            Case "sblue"
                Return SystemColors.Highlight
            Case "dgreen"
                Return Color.DarkGreen
        End Select
    End Function
    Private Sub AssignTheme(theme As String)
        Dim found As Boolean = False
        Dim coloroptions As String() = ClarkTribeGames.SQLite.GetCol(Settings.SettingsPath, Settings.SettingsName, "colorSettings", "colorname").Split(",")
        For Each name In coloroptions
            If name = theme Then found = True
        Next
        If (found) Then
            Dim ColorSettings As String() = ClarkTribeGames.SQLite.GetRow(Settings.SettingsPath, Settings.SettingsName, "colorSettings",
            "colorname", theme).Split(",")
            MemoryBank.TitleBarBackColor = Colorer(ColorSettings(4))
            MemoryBank.TitleBarForeColor = Colorer(ColorSettings(5))
            MemoryBank.TitleButtonBackColor = Colorer(ColorSettings(6))
            MemoryBank.TitleButtonForeColor = Colorer(ColorSettings(7))
            MemoryBank.BackgroundBackColor = Colorer(ColorSettings(8))
            MemoryBank.BackgroundForeColor = Colorer(ColorSettings(9))
            MemoryBank.PagesBackColor = Colorer(ColorSettings(10))
            MemoryBank.PagesForeColor = Colorer(ColorSettings(11))
            MemoryBank.ButtonBackColor = Colorer(ColorSettings(12))
            MemoryBank.ButtonForeColor = Colorer(ColorSettings(13))
            MemoryBank.DonateForeColor = Colorer(ColorSettings(14))
            MemoryBank.DonateHoverOver = Colorer(ColorSettings(15))
            MemoryBank.ButtonMouseDownBack = Colorer(ColorSettings(16))
            MemoryBank.ButtonDisabledColor = Colorer(ColorSettings(17))
            MemoryBank.HoverBackColor = Colorer(ColorSettings(18))
            MemoryBank.HoverForeColor = Colorer(ColorSettings(19))
            MemoryBank.LeaveBackColor = Colorer(ColorSettings(20))
            MemoryBank.LeaveForeColor = Colorer(ColorSettings(21))
            MemoryBank.ClickBackColor = Colorer(ColorSettings(22))
            MemoryBank.ClickForeColor = Colorer(ColorSettings(23))
            MemoryBank.GroupBackColor = Colorer(ColorSettings(24))
            MemoryBank.GroupForeColor = Colorer(ColorSettings(25))
            Settings.SettingsMode = theme
        Else
            Settings.SettingsMode = "Dark Mode"
            ClarkTribeGames.SQLite.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName", "mode", {"settingConfig"}, {"Dark Mode"})
            If Not LCase(MemoryBank.ColorModeAtStart) = LCase("Dark Mode") Then
                MemoryBank.ColorModeAtStart = "Dark Mode"
            End If
        End If

    End Sub
    Public Sub AssignMode(mode As String)

        AssignTheme(mode)

        'MainWindow
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
        AssignColor(MainWindow.BackButton, "Button")
        AssignColor(MainWindow.UpdateButton, "Button")
        AssignColor(MainWindow.AboutButton, "Button")
        AssignColor(MainWindow.ExitButton, "Button")

        AssignColor(MainWindow.SaveButton, "Button")
        AssignColor(MainWindow.NullButton, "Button")

        'LoadWindow

        'Editor

        'DocReader
        AssignColor(DocReader.TitleBarPanel, "TitleBar")
        AssignColor(DocReader.TitleLabel, "TitleBar")
        AssignColor(DocReader.BackgroundPanel, "Background")
        AssignColor(DocReader.CloseButton, "TitleButton")
        AssignColor(DocReader.CloseText, "TitleButton")
        AssignColor(DocReader.DocPanel, "Pages")
        AssignColor(DocReader.CloseDocButton, "Button")
        AssignColor(DocReader.DocText, "Pages")

        'Abouter
        AssignColor(Abouter.TitleBarPanel, "TitleBar")
        AssignColor(Abouter.TitleLabel, "TitleBar")
        AssignColor(Abouter.BackgroundPanel, "Background")
        AssignColor(Abouter.CloseButton, "TitleButton")
        AssignColor(Abouter.CloseText, "TitleButton")
        AssignColor(Abouter.AboutPanel, "Pages")
        AssignColor(Abouter.AboutText, "Pages")
        AssignColor(Abouter.AboutBackButton, "Button")
        AssignColor(Abouter.AboutWBButton, "Button")
        AssignColor(Abouter.AboutFBButton, "Button")
        AssignColor(Abouter.AboutTWButton, "Button")
        AssignColor(Abouter.AboutDCButton, "Button")
        AssignColor(Abouter.AboutYTButton, "Button")
        AssignColor(Abouter.AboutRDButton, "Button")
        AssignColor(Abouter.AboutPTButton, "Button")
        AssignColor(Abouter.AboutPPButton, "Button")
        AssignColor(Abouter.AboutBSButton, "Button")
        AssignColor(Abouter.AboutEMButton, "Button")
        AssignColor(Abouter.AboutLicButton, "Button")
        AssignColor(Abouter.AboutReadButton, "Button")

        'Updater
        AssignColor(Updater.TitleBarPanel, "TitleBar")
        AssignColor(Updater.TitleLabel, "TitleBar")
        AssignColor(Updater.BackgroundPanel, "Background")
        AssignColor(Updater.CloseButton, "TitleButton")
        AssignColor(Updater.CloseText, "TitleButton")
        AssignColor(Updater.UpdatePanel, "Pages")
        AssignColor(Updater.GameStatusText, "Pages")
        AssignColor(Updater.InstallGameBox, "Pages")
        AssignColor(Updater.AvailGameText, "Pages")
        AssignColor(Updater.AvailGameBox, "Pages")
        AssignColor(Updater.GameUpdateButton, "Button")
        AssignColor(Updater.DBStatusText, "Pages")
        AssignColor(Updater.SelectDBText, "Pages")
        AssignColor(Updater.SelectDBDrop, "Pages")
        AssignColor(Updater.InstallDBBox, "Pages")
        AssignColor(Updater.InstallDBText, "Pages")
        AssignColor(Updater.OnlineDBText, "Pages")
        AssignColor(Updater.OnlineDBBox, "Pages")
        AssignColor(Updater.DBUpdateButton, "Button")
        AssignColor(Updater.UpdaterBackButton, "Button")

        'Optioner
        AssignColor(Optioner.TitleBarPanel, "TitleBar")
        AssignColor(Optioner.TitleLabel, "TitleBar")
        AssignColor(Optioner.BackgroundPanel, "Background")
        AssignColor(Optioner.CloseButton, "TitleButton")
        AssignColor(Optioner.CloseText, "TitleButton")
        AssignColor(Optioner.OptionsPanel, "Pages")
        AssignColor(Optioner.OptionSelectText, "Pages")
        AssignColor(Optioner.OptionsDrop, "Pages")
        AssignColor(Optioner.OptionsItemText, "Pages")
        AssignColor(Optioner.OptionsMainPanel, "Pages")
        AssignColor(Optioner.AvatarPanel, "Pages")
        AssignColor(Optioner.AvatarText, "Pages")
        AssignColor(Optioner.DimLabel, "Pages")
        AssignColor(Optioner.DimText, "Pages")
        AssignColor(Optioner.AvaRenameButton, "Button")
        AssignColor(Optioner.AvaDeleteButton, "Button")
        AssignColor(Optioner.ColorsPanel, "Pages")
        AssignColor(Optioner.DBPanel, "Pages")
        AssignColor(Optioner.MusicPanel, "Pages")
        AssignColor(Optioner.SoundsPanel, "Pages")
        AssignColor(Optioner.OptionList, "Pages")
        AssignColor(Optioner.OptionsFileText, "Pages")
        AssignColor(Optioner.OptionAddButton, "Button")
        AssignColor(Optioner.OptionRefreshButton, "Button")
        AssignColor(Optioner.OptionerBackButton, "Button")
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
    Public Sub RefreshColors()
        AssignTheme(Settings.SettingsMode)
    End Sub

End Module
