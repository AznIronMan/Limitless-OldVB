Public Class Avatars
    Public Shared Sub TitleScreen()
        Dim AvatarCount As Integer = FilesFolders.CountFiles(MemoryBank.AvatarsDir, MemoryBank.AvatarsExtF)
        Dim AvatarsNeeded As Integer
        Dim picks As New List(Of Int32)
        Dim pick As Int32
        If Not AvatarCount = 0 Then
            If AvatarCount < 12 Then
                AvatarsNeeded = AvatarCount
            Else
                AvatarsNeeded = 12
            End If
            Do
                pick = (New Random).Next(0, AvatarCount)
                If picks.Contains(pick) = False Then
                    picks.Add(pick)
                End If
            Loop Until picks.Count = AvatarsNeeded
        End If
        Dim Files = New IO.DirectoryInfo(MemoryBank.AvatarsDir).GetFiles
        Select Case picks.Count
            Case 0
                '
            Case 1
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
            Case 2
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)

            Case 3
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
            Case 4
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
            Case 5
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
            Case 6
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
                SetAvatar(GetAvatarFile(Files, picks, 5), MainWindow.WelcomeImage05)
            Case 7
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
                SetAvatar(GetAvatarFile(Files, picks, 5), MainWindow.WelcomeImage05)
                SetAvatar(GetAvatarFile(Files, picks, 6), MainWindow.WelcomeImage06)
            Case 8
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
                SetAvatar(GetAvatarFile(Files, picks, 5), MainWindow.WelcomeImage05)
                SetAvatar(GetAvatarFile(Files, picks, 6), MainWindow.WelcomeImage06)
                SetAvatar(GetAvatarFile(Files, picks, 7), MainWindow.WelcomeImage07)
            Case 9
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
                SetAvatar(GetAvatarFile(Files, picks, 5), MainWindow.WelcomeImage05)
                SetAvatar(GetAvatarFile(Files, picks, 6), MainWindow.WelcomeImage06)
                SetAvatar(GetAvatarFile(Files, picks, 7), MainWindow.WelcomeImage07)
                SetAvatar(GetAvatarFile(Files, picks, 8), MainWindow.WelcomeImage08)
            Case 10
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
                SetAvatar(GetAvatarFile(Files, picks, 5), MainWindow.WelcomeImage05)
                SetAvatar(GetAvatarFile(Files, picks, 6), MainWindow.WelcomeImage06)
                SetAvatar(GetAvatarFile(Files, picks, 7), MainWindow.WelcomeImage07)
                SetAvatar(GetAvatarFile(Files, picks, 8), MainWindow.WelcomeImage08)
                SetAvatar(GetAvatarFile(Files, picks, 9), MainWindow.WelcomeImage09)
            Case 11
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
                SetAvatar(GetAvatarFile(Files, picks, 5), MainWindow.WelcomeImage05)
                SetAvatar(GetAvatarFile(Files, picks, 6), MainWindow.WelcomeImage06)
                SetAvatar(GetAvatarFile(Files, picks, 7), MainWindow.WelcomeImage07)
                SetAvatar(GetAvatarFile(Files, picks, 8), MainWindow.WelcomeImage08)
                SetAvatar(GetAvatarFile(Files, picks, 9), MainWindow.WelcomeImage09)
                SetAvatar(GetAvatarFile(Files, picks, 10), MainWindow.WelcomeImage10)
            Case Else
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage00)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage01)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage02)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage03)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage04)
                SetAvatar(GetAvatarFile(Files, picks, 5), MainWindow.WelcomeImage05)
                SetAvatar(GetAvatarFile(Files, picks, 6), MainWindow.WelcomeImage06)
                SetAvatar(GetAvatarFile(Files, picks, 7), MainWindow.WelcomeImage07)
                SetAvatar(GetAvatarFile(Files, picks, 8), MainWindow.WelcomeImage08)
                SetAvatar(GetAvatarFile(Files, picks, 9), MainWindow.WelcomeImage09)
                SetAvatar(GetAvatarFile(Files, picks, 10), MainWindow.WelcomeImage10)
                SetAvatar(GetAvatarFile(Files, picks, 10), MainWindow.WelcomeImage11)
        End Select
    End Sub
    Public Shared Function GetAvatarFile(files As IO.FileInfo(), picks As List(Of Int32), whichone As Integer) As String
        GetAvatarFile = (From f In files Order By f.LastWriteTime Select f).Skip(picks(whichone)).First().ToString
    End Function
    Public Shared Sub SetAvatar(file As String, box As Object)
        box.Visible = True
        box.ImageLocation = (MemoryBank.AvatarsDir & "\" & file)
    End Sub
    Public Shared Sub ReleaseAvatarFromBox(pbox As PictureBox)
        Dim tmpImg = pbox.Image
        pbox.Image = Nothing
        tmpImg.Dispose()
#Disable Warning IDE0059
        tmpImg = Nothing
#Enable Warning IDE0059
    End Sub

End Class
