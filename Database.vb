Imports System.Data.SQLite

Public Class Database

    Public Shared Sub CreateDB(path As String, filename As String, sql As String)
        If Not DupeDB(System.IO.Path.Combine(path, filename)) Then
            RunSQL(path, filename, sql)
        End If
    End Sub

    Public Shared Function DupeDB(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Public Shared Sub RunSQL(path As String, filename As String, sql As String)
        Using SqlConn As New SQLiteConnection(String.Format(
            "Data Source = {0}", (System.IO.Path.Combine(path, filename))))
            Dim cmd As New SQLiteCommand(sql, SqlConn)
            SqlConn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub InsertData(path As String, filename As String, table As String,
                                 values() As String)
        Dim ValuesToAdd As String = ""
        For Each value In values
            ValuesToAdd += "(" & value & "),"
        Next
        ValuesToAdd = ValuesToAdd.Substring(0, Len(ValuesToAdd) - 1)
        RunSQL(path, filename, "INSERT INTO " & table & " VALUES " & ValuesToAdd & ";")
    End Sub

End Class
