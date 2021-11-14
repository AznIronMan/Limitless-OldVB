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
                Try
                    ClarkTribeGames.Web.FB()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutdcbutton"
                Try
                    ClarkTribeGames.Web.DS()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutytbutton"
                Try
                    ClarkTribeGames.Web.YT()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutbsbutton"
                Try
                    ClarkTribeGames.Web.BS()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutcwbutton"
                Try
                    ClarkTribeGames.Web.CW()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
        End Select
    End Sub

End Class
