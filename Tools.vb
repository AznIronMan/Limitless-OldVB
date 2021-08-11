Public Class Tools

    Public Shared TypeWriterIsTyping As Boolean
    Public Shared Sub TypeWriter(box As Object, time As Single, text As String)
        If TypeWriterIsTyping = False Then
            Task.Run(Sub()
                         TypeWriterIsTyping = True
                         For i As Integer = 0 To Len(text)
                             Dim j As Integer = i
                             box.Invoke(CType(Sub()
                                                  box.Text = text.Substring(0, j)
                                              End Sub, MethodInvoker))
                             System.Threading.Thread.Sleep(time)
                         Next
                         TypeWriterIsTyping = False
                     End Sub)
        End If
    End Sub
    Public Shared Sub GoToWeb(url As String)
        Try
            Process.Start(url)
        Catch ex As Exception
            Logger.WriteToLog("GoToWeb", "Failed URL : " & url, ex)
            MessageBox.Show("Logged Error:  Something went wrong with launching system your browser." & vbCrLf _
                & vbCrLf & "Please try going to " & url & " manually." & vbCrLf & vbCrLf & "Thank you.")
        End Try
    End Sub
    Public Shared Function GetWebText(url As String) As String
        Dim client As New System.Net.WebClient()
        Dim reader As New System.IO.StreamReader(client.OpenRead(url))
        Return reader.ReadToEnd
    End Function
    Public Shared Sub CustomLibsListBuilder(list As ListBox, dir As String, ext As String, importbutton As Button, omega As Boolean)
        If FilesFolders.CountFiles(dir, ext) > 0 Then
            list.Items.Clear()
            list.Enabled = True
            For Each Filename In FilesFolders.GetFilesInFolder(dir)
                Dim FoundName As String = Replace(Filename, dir & "\", "", 1)
                Dim NameToAdd = FoundName.Trim().Substring(0, FoundName.Length - 4)
                If NameToAdd.StartsWith("Ω") = True Then
                    If omega = True Then
                        list.Items.Add("Ω " & NameToAdd.Trim().Substring(1))
                    End If
                Else
                    list.Items.Add(NameToAdd)
                End If
            Next
        Else
            list.Items.Clear()
            list.Items.Add("<No Files Available>")
            list.Enabled = False
        End If
        importbutton.Enabled = True
    End Sub
    Public Shared Sub PopulateListFromDB(type As String, list As ListBox, table As String, idcol As String, namecol As String)
        list.Items.Clear()
        list.Enabled = True
        Dim NoneAvailable As String = "<No " & Converters.UppercaseEachFirstLetter(type) & " Available>"
        Dim DBName As String = Settings.SettingsLastDB & MemoryBank.SavesExtL
        Dim IDsFromDB() As String
        Try
            IDsFromDB = DBTools.GetCol(MemoryBank.DataDir, DBName, table, idcol).Split(",")
        Catch
            IDsFromDB = Nothing
        End Try
        If IDsFromDB IsNot Nothing Then
            For Each ID In IDsFromDB
                Dim ItemName As String = DBTools.GetValue(MemoryBank.DataDir, DBName, table, namecol, idcol, ID)
                list.Items.Add(ItemName)
            Next
        Else
            list.Items.Add(NoneAvailable)
            list.Enabled = False
        End If
        DBTools.CloseSQL(MemoryBank.DataDir, DBName)
    End Sub
    Public Shared Sub PopulateListWithCustom(type As String, list As ListBox, criteria() As String)
        'criteria format:  table.idcol.namecol.findstring.modifier, etc.
        list.Items.Clear()
        list.Enabled = True
        Dim NoneAvailable As String = "<No " & Converters.UppercaseEachFirstLetter(type) & " Available>"
        Dim DBName As String = Settings.SettingsLastDB & MemoryBank.SavesExtL
        For Each Request In criteria
            Dim RequestSplit() As String = Request.Split(".")
            Dim ReqTable As String = RequestSplit(0), ReqID As String = RequestSplit(1),
                ReqName As String = RequestSplit(2), ReqStr As String = RequestSplit(3),
                ReqMod As String = RequestSplit(4)
            Dim Results() As String
            Try
                Results = DBTools.GetMulti(MemoryBank.DataDir, DBName, ReqTable, ReqID, ReqStr).Split(",")
            Catch
                Results = Nothing
            End Try
            If Results IsNot Nothing Then
                For Each ID In Results
                    Dim ItemName As String = DBTools.GetValue(MemoryBank.DataDir, DBName, ReqTable, ReqName, ReqID, ID)
                    If ReqMod.Length > 0 Then ItemName = "[" & ReqMod & "] " & ItemName
                    list.Items.Add(ItemName)
                Next
            End If
        Next
        If list.Items.Count = 0 Then
            list.Items.Add(NoneAvailable)
            list.Enabled = False
        End If
        ClearDupes(list)
        DBTools.CloseSQL(MemoryBank.DataDir, DBName)
    End Sub
    Public Shared Sub PopulateCListFromDB(type As String, list As CheckedListBox, table As String, idcol As String, namecol As String)
        list.Items.Clear()
        list.Enabled = True
        Dim NoneAvailable As String = "<No " & Converters.UppercaseEachFirstLetter(type) & " Available>"
        Dim DBName As String = Settings.SettingsLastDB & MemoryBank.SavesExtL
        Dim IDsFromDB() As String
        Try
            IDsFromDB = DBTools.GetCol(MemoryBank.DataDir, DBName, table, idcol).Split(",")
        Catch
            IDsFromDB = Nothing
        End Try
        If IDsFromDB IsNot Nothing Then
            For Each ID In IDsFromDB
                Dim ItemName As String = DBTools.GetValue(MemoryBank.DataDir, DBName, table, namecol, idcol, ID)
                list.Items.Add(ItemName)
            Next
        Else
            list.Items.Add(NoneAvailable)
            list.Enabled = False
        End If
        ClearDupes(list)
        DBTools.CloseSQL(MemoryBank.DataDir, DBName)
    End Sub
    Public Shared Sub PopulateCListWithCustom(type As String, list As CheckedListBox, criteria() As String)
        'criteria format:  table.idcol.namecol.findstring.modifier, etc.
        list.Items.Clear()
        list.Enabled = True
        Dim NoneAvailable As String = "<No " & Converters.UppercaseEachFirstLetter(type) & " Available>"
        Dim DBName As String = Settings.SettingsLastDB & MemoryBank.SavesExtL
        For Each Request In criteria
            Dim RequestSplit() As String = Request.Split(".")
            Dim ReqTable As String = RequestSplit(0), ReqID As String = RequestSplit(1),
                ReqName As String = RequestSplit(2), ReqStr As String = RequestSplit(3),
                ReqMod As String = RequestSplit(4)
            Dim Results() As String
            Try
                Results = DBTools.GetMulti(MemoryBank.DataDir, DBName, ReqTable, ReqID, ReqStr).Split(",")
            Catch
                Results = Nothing
            End Try
            If Results IsNot Nothing Then
                For Each ID In Results
                    Dim ItemName As String = DBTools.GetValue(MemoryBank.DataDir, DBName, ReqTable, ReqName, ReqID, ID)
                    If ReqMod.Length > 0 Then ItemName = "[" & ReqMod & "] " & ItemName
                    list.Items.Add(ItemName)
                Next
            End If
        Next
        If list.Items.Count = 0 Then
            list.Items.Add(NoneAvailable)
            list.Enabled = False
        End If
        ClearDupes(list)
        DBTools.CloseSQL(MemoryBank.DataDir, DBName)
    End Sub
    Public Shared Sub PopulateDropFromDB(type As String, drop As ComboBox, table As String, idcol As String, namecol As String)
        drop.Items.Clear()
        drop.Enabled = True
        Dim NoneAvailable As String = "<No " & Converters.UppercaseEachFirstLetter(type) & " Available>"
        Dim DBName As String = Settings.SettingsLastDB & MemoryBank.SavesExtL
        Dim IDsFromDB() As String
        Try
            IDsFromDB = DBTools.GetCol(MemoryBank.DataDir, DBName, table, idcol).Split(",")
        Catch
            IDsFromDB = Nothing
        End Try
        If IDsFromDB IsNot Nothing Then
            For Each ID In IDsFromDB
                Dim ItemName As String = DBTools.GetValue(MemoryBank.DataDir, DBName, table, namecol, idcol, ID)
                drop.Items.Add(ItemName)
            Next
        Else
            drop.Items.Add(NoneAvailable)
            drop.Enabled = False
        End If
        ClearDupes(drop)
        drop.SelectedIndex = 0
        DBTools.CloseSQL(MemoryBank.DataDir, DBName)
    End Sub
    Public Shared Sub PopulateDropWithCustom(type As String, drop As ComboBox, criteria() As String)
        'criteria format:  table.idcol.namecol.findstring.modifier, etc.
        drop.Items.Clear()
        drop.Enabled = True
        Dim NoneAvailable As String = "<No " & Converters.UppercaseEachFirstLetter(type) & " Available>"
        Dim DBName As String = Settings.SettingsLastDB & MemoryBank.SavesExtL
        For Each Request In criteria
            Dim RequestSplit() As String = Request.Split(".")
            Dim ReqTable As String = RequestSplit(0), ReqID As String = RequestSplit(1),
                ReqName As String = RequestSplit(2), ReqStr As String = RequestSplit(3),
                ReqMod As String = RequestSplit(4)
            Dim Results() As String
            Try
                Results = DBTools.GetMulti(MemoryBank.DataDir, DBName, ReqTable, ReqID, ReqStr).Split(",")
            Catch
                Results = Nothing
            End Try
            If Results IsNot Nothing Then
                For Each ID In Results
                    Dim ItemName As String = DBTools.GetValue(MemoryBank.DataDir, DBName, ReqTable, ReqName, ReqID, ID)
                    If ReqMod.Length > 0 Then ItemName = "[" & ReqMod & "] " & ItemName
                    drop.Items.Add(ItemName)
                Next
            End If
        Next
        If drop.Items.Count = 0 Then
            drop.Items.Add(NoneAvailable)
            drop.Enabled = False
        End If
        ClearDupes(drop)
        drop.SelectedIndex = 0
        DBTools.CloseSQL(MemoryBank.DataDir, DBName)
    End Sub
    Public Shared Function TestKeyPress(sender As Object, key As String) As Boolean
        Dim AllowedKeys As String = ""
        Select Case Converters.ControlToString(sender)
            Case "customlibspath"
                AllowedKeys = "abcdefghijklmnopqrstuvwxyz -.0123456789"
            Case "editorswitchnewbox"
                AllowedKeys = "abcdefghijklmnopqrstuvwxyz-0123456789"
        End Select
        If Not AllowedKeys.Contains(key) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub ButtonChange(button As Button, action As Boolean)
        button.Enabled = action
        Appearance.RefreshColors()
    End Sub

    Public Shared Sub ClearDupes(list As Object)
        Dim items(list.Items.Count - 1) As Object
        list.Items.CopyTo(items, 0)
        list.Items.Clear()
        list.Items.AddRange(items.AsEnumerable().Distinct().ToArray())
    End Sub

End Class
