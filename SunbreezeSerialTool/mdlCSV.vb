Imports System.IO

Module mdlCSV

    Public dicCodeList As New Dictionary(Of String, DataTable)
    Public Sub CodeListInit(fp As String)
        Dim sr As New StreamReader(fp, Text.Encoding.UTF8)
        sr.ReadLine() '读出标题行
        Dim dt As New DataTable
        Do Until sr.EndOfStream
            Dim l As String = sr.ReadLine
            If l = vbNullString Then Continue Do
            Dim c() As String = l.Split(","c)
            If c(0) = vbNullString Then
                If c(1) <> vbNullString Then
                    Dim dp = If(IsHexStr(c(1)), $"[{c(1)}H]{c(2)}", $"[{c(1)}]{c(2)}")
                    dt.Rows.Add({dp, c(1), c(2), csvGetVal(c(3)), csvGetVal(c(4)), csvGetVal(c(5))})
                End If
            Else
                dt = CodeListDtInit()
                dicCodeList.Add(c(0), dt)
            End If
        Loop
    End Sub

    Private Function CodeListDtInit() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("display", GetType(String))
        dt.Columns.Add("code", GetType(String))
        dt.Columns.Add("des", GetType(String))
        dt.Columns.Add("type", GetType(String))
        dt.Columns.Add("len", GetType(Integer))
        dt.Columns.Add("link", GetType(String))
        Return dt
    End Function

    Public Function getDicTable(key As String) As DataTable
        If dicCodeList.ContainsKey(key) Then
            Return dicCodeList(key)
        Else
            Return New DataTable
        End If
    End Function

    Private Function csvGetVal(s As String) As String
        If s.Replace(" ", vbNullString) = vbNullString Then
            Return Nothing
        Else
            Return s
        End If
    End Function

End Module