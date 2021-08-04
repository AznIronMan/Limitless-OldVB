Public Class DBTools
    Public Shared Sub CreateDB(path As String, filename As String, sql As String)
        If Not DupeDB(System.IO.Path.Combine(path, filename)) Then
            RunSQL(path, filename, sql)
        End If
    End Sub
    Public Shared Function DupeDB(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function
    Public Shared Sub RunSQL(path As String, filename As String, sql As String)
        Using SqlConn As New System.Data.SQLite.SQLiteConnection(String.Format(
            "Data Source = {0}", (System.IO.Path.Combine(path, filename))))
            Dim cmd As New System.Data.SQLite.SQLiteCommand(sql, SqlConn)
            SqlConn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Shared Sub CloseSQL(path As String, filename As String)
        Using SqlConn As New System.Data.SQLite.SQLiteConnection(String.Format(
            "Data Source = {0}", (System.IO.Path.Combine(path, filename))))
            SqlConn.Close()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Using
    End Sub
    Public Shared Function QuerySQL(path As String, filename As String, sql As String, querytype As String, colvalues() As String) As String
        Dim ValuesToAdd As String = ""
        Using SqlConn As New System.Data.SQLite.SQLiteConnection(String.Format(
            "Data Source = {0}", (System.IO.Path.Combine(path, filename))))
            Dim cmd As New System.Data.SQLite.SQLiteCommand(sql, SqlConn)
            SqlConn.Open()
            Dim i As Integer = 0
            'Field is GetRow / 'Step is GetCol
            Using reader As System.Data.SQLite.SQLiteDataReader = cmd.ExecuteReader()
                While reader.Read()
                    If querytype = "row" Then
                        Do While (i < reader.FieldCount)
                            ValuesToAdd += String.Format(reader(i).ToString) & ","
                            i += 1
                        Loop
                    ElseIf querytype = "col" Then
                        For Each colname As String In colvalues
                            Do While (i < reader.StepCount)

                                ValuesToAdd += String.Format(reader(colname).ToString) & ","
                                i += 1
                            Loop
                        Next
                    ElseIf querytype = "table" Then
                        MsgBox("This is not here yet")
                        ValuesToAdd = "MISSING_CODE,"
                    Else
                        ValuesToAdd = String.Format(reader(0).ToString) & ","
                    End If
                End While
            End Using
        End Using
        QuerySQL = ValuesToAdd.Substring(0, Len(ValuesToAdd) - 1)
    End Function
    Public Shared Sub InsertData(path As String, filename As String, table As String,
                                 values() As String)
        Dim ValuesToAdd As String = ""
        For Each value In values
            ValuesToAdd += "(" & value & "),"
        Next
        ValuesToAdd = ValuesToAdd.Substring(0, Len(ValuesToAdd) - 1)
        RunSQL(path, filename, "INSERT INTO " & table & " VALUES " & ValuesToAdd & ";")
    End Sub
    Public Shared Sub UpdateData(path As String, filename As String, table As String,
                                 findcol As String, findval As String,
                                 destcols() As String, values() As String)
        Dim ValuesToAdd As String = ""
        Dim i As Integer = 0
        Do While (i < values.Length)
            ValuesToAdd += destcols(i) & " = '" & values(i) & "', "
            i += 1
        Loop
        ValuesToAdd = ValuesToAdd.Substring(0, Len(ValuesToAdd) - 2)
        RunSQL(path, filename, "UPDATE " & table & " SET " & ValuesToAdd & " WHERE " &
               findcol & " = '" & findval & "';")
    End Sub
    Public Shared Sub DeleteData(path As String, filename As String, table As String,
                                 findcol As String, findval As String)
        RunSQL(path, filename, "DELETE FROM " & table & " WHERE " & findcol & " = '" &
               findval & "';")
    End Sub
    Public Shared Function GetTable(path As String, filename As String, table As String,
                                  cols() As String) As String
        Dim ValuesToAdd As String = ""
        For Each col In cols
            ValuesToAdd += col & ","
        Next
        ValuesToAdd = ValuesToAdd.Substring(0, Len(ValuesToAdd) - 1)
        Dim ColumnValues() As String = ValuesToAdd.Split(",")
        GetTable = QuerySQL(path, filename, "SELECT " & ValuesToAdd & " FROM " & table & ";", "table", ColumnValues)
    End Function
    Public Shared Function GetRow(path As String, filename As String, table As String,
                                  findcol As String, findval As String) As String
        GetRow = QuerySQL(path, filename, "SELECT * FROM " & table & " WHERE " & findcol &
                          " = '" & findval & "';", "row", Enumerable.Empty(Of String).ToArray)
    End Function
    Public Shared Function GetCol(path As String, filename As String, table As String,
                                  column As String) As String
        Dim ColumnValues() As String = (column & ",").Split(",")
        GetCol = QuerySQL(path, filename, "SELECT " & column & " FROM " & table & ";", "col", ColumnValues)
    End Function
    Public Shared Function GetValue(path As String, filename As String, table As String,
                                  column As String, findcol As String, findval As String) _
                                  As String
        GetValue = QuerySQL(path, filename, "SELECT " & column & " FROM " & table & " WHERE " &
            findcol & " = '" & findval & "';", "value", Enumerable.Empty(Of String).ToArray)
    End Function
    Public Shared Function GetMulti(path As String, filename As String, table As String,
                                    column As String, findstring As String) As String
        GetMulti = QuerySQL(path, filename, "SELECT " & column & " FROM " & table & " WHERE " &
            findstring & ";", "multi", Enumerable.Empty(Of String).ToArray)
    End Function

End Class
