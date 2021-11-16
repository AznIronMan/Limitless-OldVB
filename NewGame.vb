Public Class NewGame
    Public Shared Sub PrepNewGame()
        Initialize.InitPanels()
        MainWindow.BackButton.Visible = False
        MsgBox("Yeah, we are excited about the game too, but it's not ready yet.  Be patient.  Thanks!" & vbCrLf & vbCrLf & "- Geoff", vbExclamation + vbOKOnly)
    End Sub

End Class
