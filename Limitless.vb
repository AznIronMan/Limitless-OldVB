Public Class MainWindow

    Dim WindowDrag As Boolean
    Dim WindowMouseX, WindowMouseY As Integer
    Dim Highlighted As Boolean = False

    Private Sub LimitlessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize.InitProcess()
        Appearance.AssignMode("Default")
        'Formats Title with App Name, Release Type, and Version Number
        Dim ApplicationName, ReleaseType, VersionNumber, AppTitleText As String
        ApplicationName = Application.ProductName
        ReleaseType = "ALPHA "
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & Converters.VersionConverter(VersionParts(2), 3) & "." & Converters.VersionConverter(VersionParts(3), 4)
        AppTitleText = ApplicationName & " [" & ReleaseType & "v" & VersionNumber & "]"
        Me.TitleLabel.Text = AppTitleText
        Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))

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

    Private Sub AboutButtonPressed()
        WelcomePanel.Visible = False
        AboutPanel.Visible = True
        DonatePanel.Visible = False
        OptionsPanel.Visible = False
        Dim AboutMessage As String = "This application was created by ClarkTribe Games." & Environment.NewLine & Environment.NewLine &
            "It was the development of basically a one man team with the advice, suggestions, and feedback from friends, family, and colleagues." & Environment.NewLine & Environment.NewLine &
            "Limitless is dedicate to the kids of the creator." & Environment.NewLine & Environment.NewLine &
            "Please consider supporting the cause with a donation via the Donate To The Cause button." & Environment.NewLine & Environment.NewLine &
            "The music was provided by BenSound.com.  Please visit their site for some awesome tracks!" & Environment.NewLine & Environment.NewLine &
            "Thank you for your continued support!" & Environment.NewLine & Environment.NewLine &
            "- Geoff Clark @ ClarkTribeGames"
        Tools.TypeWriter(AboutText, 15, AboutMessage)
    End Sub

    Private Sub DonateButtonPressed()
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = True
        OptionsPanel.Visible = False
        Dim DonateMessage As String = "Welcome to Limitless!" & Environment.NewLine & Environment.NewLine &
            "This title is still under development.  Please be patient." & Environment.NewLine & Environment.NewLine &
            "You can become a Patreon or Donate if you want to help support the cause." & Environment.NewLine & Environment.NewLine &
            "Thanks!" & Environment.NewLine & Environment.NewLine &
            "- Geoff Clark @ ClarkTribeGames"
        Tools.TypeWriter(DonateText, 15, DonateMessage)
    End Sub

    Private Sub OptionsButtonPressed()
        WelcomePanel.Visible = False
        AboutPanel.Visible = False
        DonatePanel.Visible = False
        OptionsPanel.Visible = True
    End Sub

    Private Sub ExitGame()
        Close()
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

    Private Sub Exit_Program(sender As Object, e As MouseEventArgs) Handles TitleBarIcon.DoubleClick, CloseButton.MouseDown, CloseText.MouseDown, ExitButton.MouseClick
        ExitGame()
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles StartButton.MouseHover, UpdateButton.MouseHover, OptionsButton.MouseHover, LoadButton.MouseHover, ExitButton.MouseHover, EditButton.MouseHover, DonateButton.MouseHover, AboutButton.MouseHover, StartButton.MouseUp, UpdateButton.MouseUp, OptionsButton.MouseUp, LoadButton.MouseUp, ExitButton.MouseUp, EditButton.MouseUp, AboutButton.MouseUp
        HoverOverEffect(sender)
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, UpdateButton.MouseLeave, OptionsButton.MouseLeave, LoadButton.MouseLeave, ExitButton.MouseLeave, EditButton.MouseLeave, AboutButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartButton.MouseDown, UpdateButton.MouseDown, OptionsButton.MouseDown, LoadButton.MouseDown, ExitButton.MouseDown, EditButton.MouseDown, DonateButton.MouseDown, AboutButton.MouseDown
        MouseDownEffect(sender)
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        AboutButtonPressed()
    End Sub
    Private Sub AboutFBImage_Click(sender As Object, e As EventArgs) Handles AboutFBButton.Click
        Tools.GoToWeb("https://www.facebook.com/clarktribe.games")
    End Sub

    Private Sub AboutDCImage_Click(sender As Object, e As EventArgs) Handles AboutDCButton.Click
        Tools.GoToWeb("https://discord.gg/6kW4der")
    End Sub

    Private Sub AboutYTImage_Click(sender As Object, e As EventArgs) Handles AboutYTButton.Click
        Tools.GoToWeb("https://www.youtube.com/channel/UCjcPw3ApuFduiETIdmAhFAQ")
    End Sub

    Private Sub AboutBSImage_Click(sender As Object, e As EventArgs) Handles AboutBSButton.Click
        Tools.GoToWeb("https://www.bensound.com/")
    End Sub

    Private Sub AboutText_Enter(sender As Object, e As EventArgs) Handles AboutText.Enter
        AboutTitle.Select()
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

    Private Sub DonatePTButton_Click(sender As Object, e As EventArgs) Handles DonatePTButton.Click
        Tools.GoToWeb("https://www.patreon.com/clarktribegames")
    End Sub

    Private Sub DonatePPButton_Click(sender As Object, e As EventArgs) Handles DonatePPButton.Click
        Tools.GoToWeb("https://www.paypal.com/paypalme/aznblusuazn")
    End Sub

    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        OptionsButtonPressed()
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp, TitleBarIcon.MouseUp
        WindowDrag = False
    End Sub

End Class
