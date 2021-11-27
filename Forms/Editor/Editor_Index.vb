Public Class Editor_Index

    Dim ID As String

    Private Sub Editor_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildIndexForm()
    End Sub

    Private Sub BuildIndexForm()
        Dim Grab As String() = ClarkTribeGames.SQLite.GetRow(Editor.SaveDir, Editor.SaveFile, "all_Index", "idxName", Editor.ListSelect).Split(",")
        If Editor.SelectType = "edit" Then
            ID = Grab(0)
            CatText.Text = Grab(1)
            DescText.Text = Grab(2)
            If Grab(3) = "1" Then AvailCheck.CheckState = CheckState.Checked Else AvailCheck.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles IndexSaveButton.Click
        Dim Hidden As String
        If AvailCheck.CheckState = CheckState.Checked Then Hidden = "1" Else Hidden = "0"
        ClarkTribeGames.SQLite.RunSQL(Editor.SaveDir, Editor.SaveFile, "UPDATE all_Index SET idxName = '" & CatText.Text & "', idxDesc = '" &
            DescText.Text & "', idxHidden = '" & Hidden & "', idxActive = '1' WHERE idxID = '" & ID & "';")
        MsgBox("Save Successful")
        Me.Close()
    End Sub

    Private Sub EditorFilterText_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CatText.KeyPress
        e.Handled = Tools.LimitKeys("ans", e.KeyChar)
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
    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover, IndexSaveButton.MouseHover, IndexCancelButton.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave, IndexSaveButton.MouseLeave, IndexCancelButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, IndexSaveButton.MouseDown, IndexCancelButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub CloseWindow(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, CloseText.MouseDown, CloseButton.Click, IndexCancelButton.Click
        Me.Close()
    End Sub

End Class