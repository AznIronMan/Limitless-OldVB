Public Class FilesFolders
    Public Shared Sub CreateDirectory(ByVal newdir As String)
        If (Not System.IO.Directory.Exists(newdir)) Then
            System.IO.Directory.CreateDirectory(newdir)
        End If
    End Sub
    Public Shared Sub MoveDirectory(ByVal source As String, ByVal target As String)
        Dim sourcePath = source.TrimEnd("\"c, " "c)
        Dim targetPath = target.TrimEnd("\"c, " "c)
        Dim files = System.IO.Directory.EnumerateFiles(sourcePath, "*", System.IO.SearchOption.AllDirectories).GroupBy(Function(s) System.IO.Path.GetDirectoryName(s))
        For Each folder In files
            Dim targetFolder = folder.Key.Replace(sourcePath, targetPath)
            System.IO.Directory.CreateDirectory(targetFolder)

            For Each file In folder
                Dim targetFile = System.IO.Path.Combine(targetFolder, System.IO.Path.GetFileName(file))
                If System.IO.File.Exists(targetFile) Then System.IO.File.Delete(targetFile)
                System.IO.File.Move(file, targetFile)
            Next
        Next
        System.IO.Directory.Delete(source, True)
    End Sub
    Public Shared Sub HideFolder(hidedir As String)
        If System.IO.Directory.Exists(hidedir) Then
            Dim ToHideDir As New System.IO.DirectoryInfo(hidedir) With {
            .Attributes = IO.FileAttributes.Hidden
        }
        End If
    End Sub
    Public Shared Sub HideFile(hidefile As String)
        If System.IO.File.Exists(hidefile) Then
            Dim ToHideFile As New System.IO.FileInfo(hidefile) With {
                .Attributes = IO.FileAttributes.Hidden}
        End If
    End Sub
    Public Shared Function CountFiles(dir As String, ext As String) As Integer
        CountFiles = System.IO.Directory.GetFiles(dir, ext).Count
    End Function
    Public Shared Function GetFilesInFolder(dir As String) As String()
        GetFilesInFolder = System.IO.Directory.GetFiles(dir)
    End Function
    Public Shared Sub DeleteFile(filename As String)
        My.Computer.FileSystem.DeleteFile(filename, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
    End Sub
    Public Shared Sub CopyFile(sourcefile As String, ext As String)
        Dim count As Integer = 1, NewFile As String = sourcefile & "(" & count.ToString & ")." & ext
        While FileIO.FileSystem.FileExists(NewFile)
            count += 1
            NewFile = sourcefile & "(" & count.ToString & ")." & ext
        End While
        IO.File.Copy(sourcefile & "." & ext, NewFile)
    End Sub

End Class
