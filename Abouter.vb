Public Class Abouter

    Public Shared FB As String = "https://www.facebook.com/clarktribe.games"
    Public Shared DC As String = "https://discord.gg/6kW4der"
    Public Shared YT As String = "https://www.youtube.com/channel/UCjcPw3ApuFduiETIdmAhFAQ"
    Public Shared BS As String = "https://www.bensound.com"
    Public Shared CW As String = "https://www.facebook.com/WimbleyDesignCo"

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
                Tools.GoToWeb(Abouter.FB)
            Case "aboutdcbutton"
                Tools.GoToWeb(Abouter.DC)
            Case "aboutytbutton"
                Tools.GoToWeb(Abouter.YT)
            Case "aboutbsbutton"
                Tools.GoToWeb(Abouter.BS)
            Case "aboutcwbutton"
                Tools.GoToWeb(Abouter.CW)
        End Select
    End Sub

End Class
