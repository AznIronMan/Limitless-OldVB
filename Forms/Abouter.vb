Public Class Abouter

    Private Sub Abouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildAbouter()
    End Sub
    Private Shared Sub BuildAbouter()
        TheAbouter("Message", vbNull)
    End Sub
    Private Sub AboutImage_Click(sender As Object, e As EventArgs) Handles AboutFBButton.Click, AboutDCButton.Click, AboutYTButton.Click, AboutBSButton.Click,
        AboutEMButton.Click, AboutRDButton.Click, AboutTWButton.Click, AboutWBButton.Click, AboutPTButton.Click, AboutPPButton.Click, AboutReadButton.Click,
        AboutLicButton.Click
        Abouter.TheAbouter("Button", ClarkTribeGames.Converters.ControlToString(sender))
    End Sub
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
            "Limitless is dedicated to the kids of the creator (Adrian, Micah, Cali, and Ari)." & vbCrLf & vbCrLf &
            "Please consider supporting the cause with a donation via the Donate To The Cause button." & vbCrLf & vbCrLf &
            "The music was provided by BenSound.com.  Please visit their site for some awesome tracks!" & vbCrLf & vbCrLf &
            "Thank you for your continued support!" & vbCrLf & vbCrLf &
            "- Geoff Clark @ ClarkTribeGames LLC"
        Abouter.AboutText.Text = AboutMessage
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
            Case "aboutembutton"
                Try
                    ClarkTribeGames.Web.EM()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutrdbutton"
                Try
                    ClarkTribeGames.Web.RD()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "abouttwbutton"
                Try
                    ClarkTribeGames.Web.TW()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutwbbutton"
                Try
                    ClarkTribeGames.Web.CTG()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutppbutton"
                Try
                    ClarkTribeGames.Web.PP()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutptbutton"
                Try
                    ClarkTribeGames.Web.PT()
                Catch ex As Exception
                    MsgBox("Error with Browser!" & vbCrLf & ex.ToString, vbExclamation)
                End Try
            Case "aboutlicbutton"
                MemoryBank.DocToRead = "license.txt"
                DocReader.ShowDialog()
            Case "aboutreadbutton"
                MemoryBank.DocToRead = "readme.txt"
                DocReader.ShowDialog()
        End Select
    End Sub
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

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover
        HoverOverEffect(sender)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave
        LeaveObjEffect(sender)
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown
        MouseDownEffect(sender)
    End Sub
    Private Sub CloseWindow(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, CloseText.MouseDown, CloseButton.Click, AboutBackButton.Click
        MemoryBank.DocToRead = ""
        Me.Close()
    End Sub

End Class
