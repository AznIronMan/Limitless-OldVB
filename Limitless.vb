Public Class LimitlessForm
    Private Sub LimitlessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Formats Title with App Name, Release Type, and Version Number
        Dim applicationName, releaseType, versionNumber, fullappName As String
        applicationName = Application.ProductName
        releaseType = "ALPHA "
        versionNumber = (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())
        fullappName = applicationName & " [" & releaseType & "v" & versionNumber & "]"
        Me.titleLabel.Text = fullappName
    End Sub

End Class
