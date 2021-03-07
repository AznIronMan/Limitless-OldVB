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

End Class
