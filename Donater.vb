Public Class Donater

    Public Shared PT As String = "https://www.patreon.com/clarktribegames"
    Public Shared PP As String = "https://www.paypal.com/paypalme/aznblusuazn"

    Public Shared Sub TheDonater(type As String, buttonname As String)
        Select Case type
            Case "Message"
                DonateMessage()
            Case "Button"
                DonateClick(buttonname)
        End Select
    End Sub

    Private Shared Sub DonateMessage()
        Dim DonateMessage As String = "Welcome to Limitless!" & vbCrLf & vbCrLf &
            "This title is still under development.  Please be patient." & vbCrLf & vbCrLf &
            "You can become a Patreon or Donate if you want to help support the cause." & vbCrLf & vbCrLf &
            "Thanks!" & vbCrLf & vbCrLf &
            "- Geoff Clark @ ClarkTribeGames LLC"
        Tools.TypeWriter(MainWindow.DonateText, 15, DonateMessage)
    End Sub

    Private Shared Sub DonateClick(buttonname As String)
        Select Case (buttonname)
            Case "donateptbutton"
                Tools.GoToWeb(Donater.PT)
            Case "donateppbutton"
                Tools.GoToWeb(Donater.PP)
        End Select
    End Sub

End Class
