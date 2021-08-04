Public Class Abouter
    Public Shared Sub TheAbouter(type As String, buttonname As String)
        Select Case type
            Case "Message"
                AboutMessage()
            Case "Button"
                AboutClick(buttonname)
        End Select
    End Sub
    Private Shared Sub AboutMessage()
        Dim AboutMessage As String = "This application was created by ClarkTribe Games LLC." & vbCrLf & vbCrLf &
            "It was the development of basically a one man team with the advice, suggestions, and feedback from friends, family, and colleagues." &
            vbCrLf & vbCrLf &
            "Limitless is dedicate to the kids of the creator." & vbCrLf & vbCrLf &
            "Please consider supporting the cause with a donation via the Donate To The Cause button." & vbCrLf & vbCrLf &
            "The music was provided by BenSound.com.  Please visit their site for some awesome tracks!" & vbCrLf & vbCrLf &
            "Thank you for your continued support!" & vbCrLf & vbCrLf &
            "- Geoff Clark @ ClarkTribeGames LLC"
        Tools.TypeWriter(MainWindow.AboutText, 15, AboutMessage)
    End Sub
    Private Shared Sub AboutClick(buttonname As String)
        Select Case (buttonname)
            Case "aboutfbbutton"
                Tools.GoToWeb(MemoryBank.FB)
            Case "aboutdcbutton"
                Tools.GoToWeb(MemoryBank.DC)
            Case "aboutytbutton"
                Tools.GoToWeb(MemoryBank.YT)
            Case "aboutbsbutton"
                Tools.GoToWeb(MemoryBank.BS)
            Case "aboutcwbutton"
                Tools.GoToWeb(MemoryBank.CW)
        End Select
    End Sub

End Class
