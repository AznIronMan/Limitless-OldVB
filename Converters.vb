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
    Private Shared Function UppercaseFirstLetter(ByVal val As String) As String
        If String.IsNullOrEmpty(val) Then Return val
        Dim array() As Char = val.ToCharArray
        array(0) = Char.ToUpper(array(0))
        Return New String(array)
    End Function
    Public Shared Function UppercaseEachFirstLetter(ByVal val As String) As String
        If String.IsNullOrEmpty(val) Then Return val
        Dim FinalName As String = ""
        Dim split() As String = val.Split(" ")
        For Each name In split
            FinalName = FinalName & UppercaseFirstLetter(name) & " "
        Next
        FinalName = FinalName.Substring(0, FinalName.Length - 1)
        Return FinalName
    End Function
    Public Shared Function DateTimeConverter(ByVal val As String) As String
        If String.IsNullOrEmpty(val) Then Return val
        Dim dateTime As String = val
        Dim dt As DateTime = Convert.ToDateTime(dateTime)
        Dim format As String = "yyyyMMdd"
        Dim str As String = dt.ToString(format)
        Return str
    End Function
    Public Shared Sub ResizeImage(ByVal sourceimage As String, ByVal newimage As String, ByVal x As Integer, ByVal y As Integer)
        Dim ImageToConvert = New System.Windows.Media.Imaging.BitmapImage()
        Using ImageStream = New System.IO.FileStream(sourceimage, System.IO.FileMode.Open)
            ImageToConvert.BeginInit()
            ImageToConvert.DecodePixelWidth = x
            ImageToConvert.DecodePixelHeight = y
            ImageToConvert.CacheOption = System.Windows.Media.Imaging.BitmapCacheOption.OnLoad
            ImageToConvert.StreamSource = ImageStream
            ImageToConvert.EndInit()
        End Using
        Dim ImageEncoder = New System.Windows.Media.Imaging.PngBitmapEncoder()
        ImageEncoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(ImageToConvert))
        Using ImageStream = New System.IO.FileStream(newimage, System.IO.FileMode.Create)
            ImageEncoder.Save(ImageStream)
        End Using
    End Sub
    Public Shared Function ControlToString(sender As Object) As String
        Return DirectCast(sender, Object).Name.ToLower.Replace("clear", "")
    End Function

End Class
