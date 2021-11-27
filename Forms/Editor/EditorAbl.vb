Public Class EditorAbl

    Dim ID As String
    Private ReadOnly Blank As String = "[None]"
    Private ReadOnly NoEff As String = "[No Effects Available]"
    Private Sub Editor_Abl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildAblForm()
    End Sub

    Private Sub BuildAblForm()
        BuildDrops()
        Dim Grab As String() = ClarkTribeGames.SQLite.GetRow(Editor.SaveDir, Editor.SaveFile, "dbAbl", "ablName", Editor.ListSelect).Split(",")
        If Editor.SelectType = "edit" Then
            ID = Grab(0)
            AblText.Text = Grab(1)
            DescText.Text = Grab(2)
            TypeDrop.SelectedIndex = TypeDrop.FindStringExact(Grab(3))
            Dim CostArray As String() = Grab(4).Split("x")
            'format should be like (statID).(#)
            Select Case CostArray.Length
                Case 1
                    Dim CostArray1 As String() = CostArray(0).Split(".")
                    Cost1Drop.SelectedIndex = Cost1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", CostArray1(0)))
                    Cost1Text.Text = CostArray1(1)
                Case 2
                    Dim CostArray1 As String() = CostArray(0).Split(".")
                    Cost1Drop.SelectedIndex = Cost1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", CostArray1(0)))
                    Cost1Text.Text = CostArray1(1)
                    Dim CostArray2 As String() = CostArray(1).Split(".")
                    Cost2Drop.SelectedIndex = Cost2Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", CostArray2(0)))
                    Cost2Text.Text = CostArray2(1)
                Case 3
                    Dim CostArray1 As String() = CostArray(0).Split(".")
                    Cost1Drop.SelectedIndex = Cost1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", CostArray1(0)))
                    Cost1Text.Text = CostArray1(1)
                    Dim CostArray2 As String() = CostArray(1).Split(".")
                    Cost2Drop.SelectedIndex = Cost2Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", CostArray2(0)))
                    Cost2Text.Text = CostArray2(1)
                    Dim CostArray3 As String() = CostArray(2).Split(".")
                    Cost2Drop.SelectedIndex = Cost3Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", CostArray3(0)))
                    Cost2Text.Text = CostArray3(1)
                Case Else
                    Cost1Text.Text = ""
                    Cost1Drop.SelectedIndex = 0
            End Select
            If Grab(5).Contains("S") Then SelfCheck.CheckState = CheckState.Checked Else SelfCheck.CheckState = CheckState.Unchecked
            If Grab(5).Contains("A") Then AllyCheck.CheckState = CheckState.Checked Else AllyCheck.CheckState = CheckState.Unchecked
            If Grab(5).Contains("T") Then EnemyCheck.CheckState = CheckState.Checked Else EnemyCheck.CheckState = CheckState.Unchecked
            If Grab(5).Contains("M") Then MultiCheck.CheckState = CheckState.Checked Else MultiCheck.CheckState = CheckState.Unchecked
            If Grab(5).Contains("E") Then AllCheck.CheckState = CheckState.Checked Else AllCheck.CheckState = CheckState.Unchecked
            Dim ImpactArray As String() = Grab(6).Split("x")
            'format should be like (statID).(#)
            Select Case ImpactArray.Length
                Case 1
                    Dim ImpactArray1 As String() = ImpactArray(0).Split(".")
                    Impact1Drop.SelectedIndex = Impact1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ImpactArray1(0)))
                    Impact1Text.Text = ImpactArray1(1)
                Case 2
                    Dim ImpactArray1 As String() = ImpactArray(0).Split(".")
                    Impact1Drop.SelectedIndex = Impact1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ImpactArray1(0)))
                    Impact1Text.Text = ImpactArray1(1)
                    Dim ImpactArray2 As String() = ImpactArray(1).Split(".")
                    Impact2Drop.SelectedIndex = Impact2Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ImpactArray2(0)))
                    Impact2Text.Text = ImpactArray2(1)
                Case 3
                    Dim ImpactArray1 As String() = ImpactArray(0).Split(".")
                    Impact1Drop.SelectedIndex = Impact1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ImpactArray1(0)))
                    Impact1Text.Text = ImpactArray1(1)
                    Dim ImpactArray2 As String() = ImpactArray(1).Split(".")
                    Impact2Drop.SelectedIndex = Impact2Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ImpactArray2(0)))
                    Impact2Text.Text = ImpactArray2(1)
                    Dim ImpactArray3 As String() = ImpactArray(2).Split(".")
                    Impact3Drop.SelectedIndex = Impact3Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ImpactArray3(0)))
                    Impact3Text.Text = ImpactArray3(1)
                Case Else
                    Impact1Text.Text = ""
                    Impact1Drop.SelectedIndex = 0
            End Select
            Dim ElementExist As Integer
            ElementExist = ElemDrop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbElements", "elementName", "elementID", Grab(7)))
            If ElementExist > -1 Then ElemDrop.SelectedIndex = ElementExist Else ElemDrop.SelectedIndex = 0
            Dim EffArray As String() = Grab(8).Split("x")
            For Each effid In EffArray
                Dim effname As String = ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbEff", "effName", "effID", effid)
                Dim itemindex As Integer = EffList.FindStringExact(effname)
                EffList.SetSelected(itemindex, True)
            Next
            Dim ProfArray As String() = Grab(9).Split("x")
            'format should be like (statID).(#)
            Select Case ProfArray.Length
                Case 1
                    Dim ProfArray1 As String() = ProfArray(0).Split(".")
                    Prof1Drop.SelectedIndex = Prof1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ProfArray1(0)))
                    Prof1Text.Text = ProfArray1(1)
                Case 2
                    Dim ProfArray1 As String() = ProfArray(0).Split(".")
                    Prof1Drop.SelectedIndex = Prof1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ProfArray1(0)))
                    Prof1Text.Text = ProfArray1(1)
                    Dim ProfArray2 As String() = ProfArray(1).Split(".")
                    Prof2Drop.SelectedIndex = Prof2Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ProfArray2(0)))
                    Prof2Text.Text = ProfArray2(1)
                Case 3
                    Dim ProfArray1 As String() = ProfArray(0).Split(".")
                    Prof1Drop.SelectedIndex = Prof1Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ProfArray1(0)))
                    Prof1Text.Text = ProfArray1(1)
                    Dim ProfArray2 As String() = ProfArray(1).Split(".")
                    Prof2Drop.SelectedIndex = Prof2Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ProfArray2(0)))
                    Prof2Text.Text = ProfArray2(1)
                    Dim ProfArray3 As String() = ProfArray(2).Split(".")
                    Prof3Drop.SelectedIndex = Prof3Drop.FindStringExact(ClarkTribeGames.SQLite.GetValue(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName", "statID", ProfArray3(0)))
                    Prof3Text.Text = ProfArray3(1)
                Case Else
                    Prof1Text.Text = ""
                    Prof1Drop.SelectedIndex = 0
            End Select
        End If
    End Sub

    Private Sub ClearDrops()
        TypeDrop.Items.Clear()
        Cost1Drop.Items.Clear()
        Cost2Drop.Items.Clear()
        Cost3Drop.Items.Clear()
        Impact1Drop.Items.Clear()
        Impact2Drop.Items.Clear()
        Impact3Drop.Items.Clear()
        ElemDrop.Items.Clear()
        Prof1Drop.Items.Clear()
        Prof2Drop.Items.Clear()
        Prof3Drop.Items.Clear()
        EffList.Items.Clear()
    End Sub

    Private Sub BuildDrops()
        For Each item In ClarkTribeGames.SQLite.GetCol(Editor.SaveDir, Editor.SaveFile, "dbAblType", "abltypeName").Split(",")
            TypeDrop.Items.Add(item)
        Next
        TypeDrop.SelectedIndex = 0
        Cost1Drop.Items.Add(Blank)
        Cost2Drop.Items.Add(Blank)
        Cost3Drop.Items.Add(Blank)
        Impact1Drop.Items.Add(Blank)
        Impact2Drop.Items.Add(Blank)
        Impact3Drop.Items.Add(Blank)
        For Each item In ClarkTribeGames.SQLite.GetCol(Editor.SaveDir, Editor.SaveFile, "dbStats", "statName").Split(",")
            Cost1Drop.Items.Add(item)
            Cost2Drop.Items.Add(item)
            Cost3Drop.Items.Add(item)
            Impact1Drop.Items.Add(item)
            Impact2Drop.Items.Add(item)
            Impact3Drop.Items.Add(item)
        Next
        Cost1Drop.SelectedIndex = 0
        Cost2Drop.SelectedIndex = 0
        Cost3Drop.SelectedIndex = 0
        Impact1Drop.SelectedIndex = 0
        Impact2Drop.SelectedIndex = 0
        Impact3Drop.SelectedIndex = 0
        Cost1Text.Enabled = False
        Cost2Text.Enabled = False
        Cost3Text.Enabled = False
        Cost2Text.Visible = False
        Cost3Text.Visible = False
        Cost2Drop.Enabled = False
        Cost3Drop.Enabled = False
        Cost2Drop.Visible = False
        Cost3Drop.Visible = False
        Impact1Text.Enabled = False
        Impact2Text.Enabled = False
        Impact3Text.Enabled = False
        Impact2Text.Visible = False
        Impact3Text.Visible = False
        Impact2Drop.Enabled = False
        Impact3Drop.Enabled = False
        Impact2Drop.Visible = False
        Impact3Drop.Visible = False
        ElemDrop.Items.Add(Blank)
        For Each item In ClarkTribeGames.SQLite.GetCol(Editor.SaveDir, Editor.SaveFile, "dbElements", "elementName").Split(",")
            ElemDrop.Items.Add(item)
        Next
        ElemDrop.SelectedIndex = 0
        If ClarkTribeGames.SQLite.GetRowCount(Editor.SaveDir, Editor.SaveFile, "dbEff") > 0 Then
            For Each item In ClarkTribeGames.SQLite.GetCol(Editor.SaveDir, Editor.SaveFile, "dbEff", "effName").Split(",")
                EffList.Items.Add(item)
            Next
        Else
            EffList.Items.Add(NoEff)
            EffList.SelectedIndex = -1
            EffList.Enabled = False
        End If
        Prof1Drop.Items.Add(Blank)
        Prof2Drop.Items.Add(Blank)
        Prof3Drop.Items.Add(Blank)
        For Each item In ClarkTribeGames.SQLite.GetCol(Editor.SaveDir, Editor.SaveFile, "dbProf", "profName").Split(",")
            Prof1Drop.Items.Add(item)
            Prof2Drop.Items.Add(item)
            Prof3Drop.Items.Add(item)
        Next
        Prof1Drop.SelectedIndex = 0
        Prof2Drop.SelectedIndex = 0
        Prof3Drop.SelectedIndex = 0
        Prof1Text.Enabled = False
        Prof2Text.Enabled = False
        Prof3Text.Enabled = False
        Prof2Text.Visible = False
        Prof3Text.Visible = False
        Prof2Drop.Enabled = False
        Prof3Drop.Enabled = False
        Prof2Drop.Visible = False
        Prof3Drop.Visible = False
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles AblSaveButton.Click
        Dim Hidden As String
        'If AvailCheck.CheckState = CheckState.Checked Then Hidden = "1" Else Hidden = "0"
        'ClarkTribeGames.SQLite.RunSQL(Editor.SaveDir, Editor.SaveFile, "UPDATE all_Index SET idxName = '" & CatText.Text & "', idxDesc = '" &
        '    DescText.Text & "', idxHidden = '" & Hidden & "', idxActive = '1' WHERE idxID = '" & ID & "';")
        MsgBox("Save Successful")
        Me.Close()
    End Sub

    'Private Sub EditorFilterText_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CatText.KeyPress
    '    e.Handled = Tools.LimitKeys("ans", e.KeyChar)
    'End Sub

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
    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover, AblSaveButton.MouseHover, AblCancelButton.MouseHover,
        Cost2Button.MouseHover, Cost3Button.MouseHover, Impact2Button.MouseHover, Impact3Button.MouseHover, Prof2Button.MouseHover, Prof3Button.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave, AblSaveButton.MouseLeave, AblCancelButton.MouseLeave,
        Cost2Button.MouseLeave, Cost3Button.MouseLeave, Impact2Button.MouseLeave, Impact3Button.MouseLeave, Prof2Button.MouseLeave, Prof3Button.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, AblSaveButton.MouseDown, AblCancelButton.MouseDown,
        Cost2Button.MouseDown, Cost3Button.MouseDown, Impact2Button.MouseDown, Impact3Button.MouseDown, Prof2Button.MouseDown, Prof3Button.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub CloseWindow(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, CloseText.MouseDown, CloseButton.Click, AblCancelButton.Click
        Me.Close()
    End Sub
End Class