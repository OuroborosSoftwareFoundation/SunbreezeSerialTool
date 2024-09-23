Public Class frmTool_Base_Simple

    Private Sub Base_Convert_Click(sender As Object, e As EventArgs) Handles Base_Convert.Click
        Dim bf As Integer = 0
        For Each c As Control In Base_grpFrom.Controls
            If (TypeOf c Is RadioButton) AndAlso DirectCast(c, RadioButton).Checked Then
                bf = Convert.ToInt32(c.Tag)
            End If
        Next
        Dim bt As Integer = 0
        For Each c As Control In Base_grpTo.Controls
            If (TypeOf c Is RadioButton) AndAlso DirectCast(c, RadioButton).Checked Then
                bt = Convert.ToInt32(c.Tag)
            End If
        Next
        If IsHexStr(Base_From.Text) Then
            Dim i As Integer = StrToInt(Base_From.Text, bf)
            Base_To.Text = IntToStr(i, bt)
        Else
            Base_To.Text = "输入错误"
        End If
    End Sub

    Private Function StrToInt(s As String, b As Integer) As Integer
        If s = vbNullString Then Return 0
        If b = 2 OrElse b = 8 OrElse b = 10 OrElse b = 16 Then
            Return Convert.ToInt32(s, b)
        Else
            Return 0
        End If
    End Function

    Private Function IntToStr(i As Integer, b As Integer) As String
        If b = 2 OrElse b = 8 OrElse b = 10 OrElse b = 16 Then
            Return Convert.ToString(i, b).ToUpper
        Else
            Return vbNullString
        End If
    End Function

End Class