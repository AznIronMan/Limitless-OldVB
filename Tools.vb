Imports System.Threading

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
            MessageBox.Show("Something went wrong with launching system your browser." & Environment.NewLine & Environment.NewLine &
                            "Please try going to " & url & " manually." & Environment.NewLine & Environment.NewLine & "Thank you.")
        End Try
    End Sub

    Public Shared Sub CustomLibsListBuilder(type As String, list As ListBox, dir As String, activecheck As CheckBox,
        ext As String, importbutton As Button)
        If FilesFolders.CountFiles(dir, ext) > 0 Then
            list.Items.Clear()
            list.Enabled = True
            For Each Filename In FilesFolders.GetFilesInFolder(dir)
                Dim FoundName As String = Replace(Filename, dir & "\", "", 1)
                Dim NameToAdd = FoundName.Trim().Substring(0, FoundName.Length - 4)
                If NameToAdd.StartsWith("Ω") = True Then _
                    list.Items.Add("Ω " & NameToAdd.Trim().Substring(1)) _
                    Else list.Items.Add(NameToAdd)
            Next
        Else
            list.Items.Clear()
            list.Items.Add("<No Files Available>")
            list.Enabled = False
        End If
        importbutton.Enabled = True
    End Sub



End Class
