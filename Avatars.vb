Public Class Avatars

    Public Shared Sub TitleScreen()

        Dim AvatarCount As Integer = FilesFolders.CountFiles(MemoryBank.AvatarsDir, "*.png")
        Dim AvatarsNeeded As Integer
        Dim picks As New List(Of Int32)
        Dim pick As Int32
        If Not AvatarCount = 0 Then
            If AvatarCount < 5 Then
                AvatarsNeeded = AvatarCount
            Else
                AvatarsNeeded = 5
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
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage0)
            Case 2
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage0)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage1)

            Case 3
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage0)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage1)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage2)
            Case 4
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage0)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage1)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage2)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage3)
            Case Else
                SetAvatar(GetAvatarFile(Files, picks, 0), MainWindow.WelcomeImage0)
                SetAvatar(GetAvatarFile(Files, picks, 1), MainWindow.WelcomeImage1)
                SetAvatar(GetAvatarFile(Files, picks, 2), MainWindow.WelcomeImage2)
                SetAvatar(GetAvatarFile(Files, picks, 3), MainWindow.WelcomeImage3)
                SetAvatar(GetAvatarFile(Files, picks, 4), MainWindow.WelcomeImage4)
        End Select

    End Sub

    Public Shared Function GetAvatarFile(files As IO.FileInfo(), picks As List(Of Int32), whichone As Integer) As String
        GetAvatarFile = (From f In files Order By f.LastWriteTime Select f).Skip(picks(whichone)).First().ToString
    End Function

    Public Shared Sub SetAvatar(file As String, box As Object)
        box.ImageLocation = (MemoryBank.AvatarsDir & "\" & file)
    End Sub

End Class
