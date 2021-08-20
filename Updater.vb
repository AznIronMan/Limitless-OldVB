Public Class Updater
    Public Shared Sub CheckForUpdate(curver As String, avaver As String)
        Dim currentver, availver As Long
        currentver = CLng(Replace(curver, ".", ""))
        availver = CLng(Replace(avaver, ".", ""))
        If availver > currentver Then
            Dim updatetext = "Update " & avaver & " Available!"
            UpdateChanges(updatetext, MemoryBank.DonateForeColor, True, "Install Update")
            Jukebox.StopSong()
            MsgBox(updatetext & vbCrLf & vbCrLf & "Please Update via the Update Button!", vbOKOnly + vbExclamation)
        Else
            UpdateChanges("Your Game Is Current!", MemoryBank.DonateForeColor, False, "No Update Available")
        End If
    End Sub
    Private Shared Sub UpdateChanges(text As String, color As Color, enable As Boolean, buttontext As String)
        MainWindow.UpdateSubText.Text = text
        MainWindow.UpdateSubText.ForeColor = color
        MainWindow.UpdateInstallButton.Enabled = enable
        MainWindow.UpdateInstallButton.Text = buttontext
        Appearance.RefreshColors()
    End Sub
    Public Shared Sub InstallUpdate()
        Dim pHelp As New ProcessStartInfo With {
            .FileName = ".\" & MemoryBank.UpdaterName & MemoryBank.FileExtL,
            .Arguments = "-Path " & Application.ProductName & " -Dir " &
            (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).Substring(6),
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }
        Dim proc As Process = Process.Start(pHelp)
    End Sub
    'Public Shared Function VersionQuery(app As String) As String
    '    Dim cs As String = MemoryBank.VFields(0) & MemoryBank.Version(0) & MemoryBank.VFields(1) & MemoryBank.Version(1) &
    '        MemoryBank.VFields(2) & MemoryBank.Version(2) & MemoryBank.VFields(3) & MemoryBank.Version(3) & MemoryBank.VFieldL &
    '        MemoryBank.VChecker.Replace(" ", "") & Chr(35) & CStr(7 * 3)
    '    Dim stm As String = "SELECT itemver FROM tbversion WHERE itemname = '" & app & "'"
    '    Dim version As String
    '    Dim conn As MySqlConnector.MySqlConnection
    '    Try
    '        conn = New MySqlConnector.MySqlConnection(cs)
    '        conn.Open()
    '        Dim cmd As New MySqlConnector.MySqlCommand(stm, conn)
    '        version = Convert.ToString(cmd.ExecuteScalar())
    '        conn.Close()
    '        Return version
    '    Catch ex As MySqlConnector.MySqlException
    '        Return ""
    '    End Try
    'End Function


End Class