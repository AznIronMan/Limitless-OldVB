Public Class DocReader

    Private Sub DocReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildReader()
    End Sub
    Private Sub BuildReader()
        Select Case LCase(MemoryBank.DocToRead)
            Case "readme.txt"
                TitleLabel.Text = "ReadMe Document"
            Case "license.txt"
                TitleLabel.Text = "License Information"
        End Select
        Try
            ClarkTribeGames.Converters.DocToTextBox(DocText, MemoryBank.DocToRead)
        Catch ex As Exception
            MsgBox("Something went wrong with loading the " & MemoryBank.DocToRead & " file." & vbCrLf & ex.ToString)
            Me.Close()
        End Try
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

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles CloseDocButton.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseDocButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseDocButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub CloseWindow(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, CloseText.MouseDown, CloseDocButton.Click
        MemoryBank.DocToRead = ""
        Me.Close()
    End Sub

End Class