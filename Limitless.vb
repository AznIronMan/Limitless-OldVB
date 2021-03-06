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
        VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & VersionConverter(VersionParts(2), 3) & "." & VersionConverter(VersionParts(3), 4)
        AppTitleText = ApplicationName & " [" & ReleaseType & "v" & VersionNumber & "]"
        Me.TitleLabel.Text = AppTitleText
        Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))

    End Sub

    Private Function VersionConverter(versionpart As String, digits As Integer) As String
        Dim PartLength As Integer = Len(versionpart)
        Select Case PartLength
            Case digits - 1
                VersionConverter = "0" + versionpart
            Case digits - 2
                VersionConverter = "00" + versionpart
            Case digits - 3
                VersionConverter = "000" + versionpart
            Case digits - 4
                VersionConverter = "0000" + versionpart
            Case Else
                VersionConverter = versionpart
        End Select
    End Function

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

    Private Sub MouseUpEffect(obj As Object)
        If obj.Enabled Then
            Appearance.AssignColor(obj, "Hover")
        End If
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

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles StartButton.MouseHover, UpdateButton.MouseHover, OptionsButton.MouseHover, LoadButton.MouseHover, ExitButton.MouseHover, EditButton.MouseHover, DonateButton.MouseHover, AboutButton.MouseHover
        HoverOverEffect(sender)
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave, UpdateButton.MouseLeave, OptionsButton.MouseLeave, LoadButton.MouseLeave, ExitButton.MouseLeave, EditButton.MouseLeave, DonateButton.MouseLeave, AboutButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartButton.MouseDown, UpdateButton.MouseDown, OptionsButton.MouseDown, LoadButton.MouseDown, ExitButton.MouseDown, EditButton.MouseDown, DonateButton.MouseDown, AboutButton.MouseDown
        MouseDownEffect(sender)
    End Sub

    Private Sub Button_MouseUp(sender As Object, e As MouseEventArgs) Handles StartButton.MouseUp, UpdateButton.MouseUp, OptionsButton.MouseUp, LoadButton.MouseUp, ExitButton.MouseUp, EditButton.MouseUp, DonateButton.MouseUp, AboutButton.MouseUp
        MouseUpEffect(sender)
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleLabel.MouseUp, TitleBarIcon.MouseUp
        WindowDrag = False
    End Sub

End Class
