Public Class Converters
    Public Shared Function VersionConverter(versionpart As String, digits As Integer) As String
        Dim PartLength As Integer = Len(versionpart)
        Select Case PartLength
            Case digits - 1
                VersionConverter = "0" + versionpart
            Case digits - 2
                VersionConverter = "00" + versionpart
            Case digits - 3
                VersionConverter = "000" + versionpart
            Case digits - 4
                VersionConverter = "0000" + versionpart
            Case Else
                VersionConverter = versionpart
        End Select
    End Function

    Public Shared Function UppercaseFirstLetter(ByVal val As String) As String
        If String.IsNullOrEmpty(val) Then Return val
        Dim array() As Char = val.ToCharArray
        array(0) = Char.ToUpper(array(0))
        Return New String(array)
    End Function

End Class
