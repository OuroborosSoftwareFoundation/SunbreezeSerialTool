Public Class frmTelegram

    Private Sub frmTelegramTool_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = $"Sunbreeze Telegram Tool  v{My.Application.Info.Version}"

        'Dim data() As Byte = {&HBC, &HFF, &HFF, &H14, &H1, &HE1, &H0, &H81} '{&H1, &H3, &H0, &H0, &H0, &H2}
        ''Check_CRC(data, 16, &H8005, &HFFFF, &H0, True, True)
        'Check_VPC(data, 0)

        If Not IO.File.Exists("codelist.csv") Then
            Dim csv As String = My.Resources.codelist
            Using sw As New IO.StreamWriter("codelist.csv", False, System.Text.Encoding.UTF8)
                sw.Write(csv)
            End Using
        End If
        CodeListInit("codelist.csv")
        cbBind(MbRTU_Fun, "ModbusRTU_Fun", 2)
        DLT645_V1997.Checked = True
        cbBind(CJT188_Typ, "CJT188-2004_TYPE")
        CJT188_V2004.Checked = True
        For Each i As KeyValuePair(Of String, DataTable) In dicCodeList
            lb.Items.Add(i.Key)
        Next
        tpCodeList.Parent = Nothing '隐藏数据表的标签页
    End Sub

    Private Sub tabMain_SelectedIndexChanged(sender As TabControl, e As EventArgs) Handles tabMain.SelectedIndexChanged
        Select Case sender.SelectedTab.Name
            Case "tpModbusRTU"

            Case "tpDLT645"

            Case "tpCJT188"

            Case "tpCodeList"

        End Select
    End Sub

    Private Sub chkTop_CheckedChanged(sender As CheckBox, e As EventArgs) Handles chkTop.CheckedChanged
        Me.TopMost = sender.Checked
    End Sub

    Private Sub MbRTU_btnCreat_Click(sender As Object, e As EventArgs)
        '地址处理
        Dim adr0 As String = MbRTU_Adr.Text.Replace(" ", vbNullString)
        Dim adr As Byte = 0
        If MbRTU_chkDEC.Checked Then
            If IsNumeric(adr0) Then
                Dim a As Integer = Convert.ToInt32(adr0)
                If (a > -1) And (a < 256) Then
                    adr = Convert.ToByte(adr0)
                Else
                    MessageBox.Show("请输入0~255的数字")
                    Exit Sub
                End If
            Else
                MessageBox.Show("请输入0~255的数字")
                Exit Sub
            End If
        ElseIf MbRTU_chkHEX.Checked Then
            If IsHexStr(adr0, 2) Then
                adr = Convert.ToByte(adr0, 16)
            Else
                MessageBox.Show("请输入0x00~0xFF的十六进制字符串")
                Exit Sub
            End If
        End If

        Dim msg As String = Msg_ModbusRTU_String(adr, getCbValue(MbRTU_Fun)(0), MbRTU_Dat.Text)
        tbTelegram.Text = msg
        If chkClip.Checked Then Clipboard.SetText(msg)
    End Sub

    Private Sub DLT645_V1997_CheckedChanged(sender As RadioButton, e As EventArgs) Handles DLT645_V1997.CheckedChanged
        If sender.Checked Then
            cbBind(DLT645_Ctl, "DLT645-1997_CTL")
            cbBind(DLT645_Di, "DLT645-1997_DI")
        End If
    End Sub

    Private Sub DLT645_V2007_CheckedChanged(sender As RadioButton, e As EventArgs) Handles DLT645_V2007.CheckedChanged
        If sender.Checked Then
            cbBind(DLT645_Ctl, "DLT645-2007_CTL", 1)
            cbBind(DLT645_Di, "DLT645-2007_DI")
        End If
    End Sub

    Private Sub DLT645_Ctl_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles DLT645_Ctl.SelectedIndexChanged
        If sender.SelectedValue = vbNullString Then
            DLT645_Dat.Enabled = True
        Else
            Dim ver As String = IIf(DLT645_V1997.Checked, "DLT645-1997_CTL", "DLT645-2007_CTL")
            Dim dr As DataRow = dicCodeList(ver).Select($"code='{sender.SelectedValue}'")(0)
            If Not IsDBNull(dr("link")) Then '控制字和数据标识的关联
                If dr("link") = "NULL" Then
                    DLT645_Di.SelectedIndex = -1
                Else
                    DLT645_Di.SelectedValue = dr("link")
                End If
            End If
            DLT645_Dat.Enabled = (dr("type") = "W")
            If DLT645_Ctl.SelectedValue = "08" Then
                '校时自动填充系统时间
            End If
        End If
    End Sub

    Private Sub DLT645_btnCreat_Click(sender As Object, e As EventArgs)
        Dim adr As Byte() = AdrBytes_DLT645(DLT645_Adr.Text, DLT645_ReverseAdr.Checked)
        Dim di As Byte() = getCbValue(DLT645_Di)
        If DLT645_ReverseDi.Checked Then di = di.Reverse.ToArray
        Dim msg As String = Msg_DLT645_String(adr, getCbValue(DLT645_Ctl)(0), di, String_to_Bytes(DLT645_Dat.Text))
        tbTelegram.Text = msg
        If chkClip.Checked Then Clipboard.SetText(msg)
    End Sub

    Private Sub CJT188_V2004_CheckedChanged(sender As Object, e As EventArgs) Handles CJT188_V2004.CheckedChanged
        If sender.Checked Then
            cbBind(CJT188_Ctl, "CJT188-2004_CTL")
            cbBind(CJT188_Di, "CJT188-2004_DI")
        End If
    End Sub

    Private Sub CJT188_V2018_CheckedChanged(sender As Object, e As EventArgs) Handles CJT188_V2018.CheckedChanged
        If sender.Checked Then
            cbBind(CJT188_Ctl, "CJT188-2018_CTL")
            cbBind(CJT188_Di, "CJT188-2018_DI")
        End If
    End Sub

    Private Sub CJT188_Ctl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CJT188_Ctl.SelectedIndexChanged
        If sender.SelectedValue = vbNullString Then
            CJT188_Dat.Enabled = True
        Else
            Dim ver As String = IIf(CJT188_V2004.Checked, "CJT188-2004_CTL", "CJT188-2018_CTL")
            Dim dr As DataRow = dicCodeList(ver).Select($"code='{sender.SelectedValue}'")(0)
            If Not IsDBNull(dr("link")) Then '控制字和数据标识的关联
                If dr("link") = "NULL" Then
                    CJT188_Di.SelectedIndex = -1
                Else
                    CJT188_Di.SelectedValue = dr("link")
                End If
            End If
            CJT188_Dat.Enabled = (dr("type") = "W") '数据框是否可用
        End If
    End Sub

    Private Sub CJT188_btnCreat_Click(sender As Object, e As EventArgs)
        Dim adr As Byte() = AdrBytes_CJT188(CJT188_Adr.Text, CJT188_ReverseAdr.Checked)
        Dim di As Byte() = getCbValue(CJT188_Di)
        If CJT188_ReverseDi.Checked Then di = di.Reverse.ToArray
        Dim msg As String = Msg_CJT188_String(adr, getCbValue(CJT188_Typ)(0), getCbValue(CJT188_Ctl)(0), di, String_to_Bytes(CJT188_Ser.Text)(0), String_to_Bytes(CJT188_Dat.Text))
        tbTelegram.Text = msg
        If chkClip.Checked Then Clipboard.SetText(msg)
    End Sub

    Private Sub btnCreat_Click(sender As Button, e As EventArgs) Handles btnCreat.Click
        Select Case tabMain.SelectedTab.Name
            Case "tpModbusRTU"
                Call MbRTU_btnCreat_Click(Nothing, Nothing)
            Case "tpDLT645"
                Call DLT645_btnCreat_Click(Nothing, Nothing)
            Case "tpCJT188"
                Call CJT188_btnCreat_Click(Nothing, Nothing)
            Case Else
        End Select
    End Sub

    Private Sub btnSend_Click(sender As Button, e As EventArgs) Handles btnSend.Click
        Call btnCreat_Click(Nothing, Nothing)
        If My.Application.OpenForms.Item("frmSerial") Is Nothing Then
            frmSerial.Show()
        End If
        frmSerial.tbSend.Text = tbTelegram.Text
        Call frmSerial.BtnSend_Click(Nothing, Nothing)
    End Sub

    Private Sub lb_SelectedIndexChanged(sender As ListBox, e As EventArgs) Handles lb.SelectedIndexChanged
        dgvCodeList.DataSource = dicCodeList(sender.SelectedItems(0).ToString)
    End Sub

    Private Sub TextBox_EnabledChanged(sender As TextBox, e As EventArgs) Handles DLT645_Dat.EnabledChanged, CJT188_Dat.EnabledChanged
        If sender.Enabled Then
            sender.Clear()
        Else
            sender.Text = "不可用"
        End If
    End Sub

    Private Sub cbBind(cb As ComboBox, tname As String, Optional idx As Integer = 0)
        With cb
            .ValueMember = "code"
            .DisplayMember = "display"
            .DataSource = getDicTable(tname)
            If .Items.Count > idx Then .SelectedIndex = idx
        End With
    End Sub

    ''' <summary>
    ''' 将ComboBox当前值转化为Byte()
    ''' </summary>
    ''' <param name="cb"></param>
    ''' <returns></returns>
    Private Function getCbValue(cb As ComboBox) As Byte()
        Dim s As String = vbNullString
        If cb.SelectedValue = vbNullString Then
            s = cb.Text
        Else
            s = cb.SelectedValue
        End If
        Return String_to_Bytes(s)
    End Function

    Private Sub btnBgMode_Click(sender As Button, e As EventArgs) Handles btnBgMode.Click
        chkClip.Checked = True
        Me.Hide()
        Clipboard.Clear()
        tmMonitor.Start()
        frmTelegram_bg.Show()
    End Sub

    Dim ClipText0 As String = vbNullString
    Private Sub tmMonitor_Tick(sender As Object, e As EventArgs) Handles tmMonitor.Tick
        Dim ClipText As String = Clipboard.GetText.Replace(" ", "").Split(vbCrLf)(0)
        If ClipText.Length > 0 AndAlso ClipText.Length < 15 Then
            If ClipText = ClipText0 Then Exit Sub
            ClipText0 = ClipText
            If IsHexStr(ClipText) Then
                Dim msg As String = vbNullString
                Select Case tabMain.SelectedTab.Name
                    Case "tpModbusRTU"
                        Try
                            Dim base As Integer = 10 '进制
                            If Not IsNumeric(ClipText) Then '是16进制字符串但不是十进制字符串说明是16进制地址
                                base = 16
                            End If
                            Dim adr As Byte = Convert.ToByte(ClipText, base)
                            MbRTU_Adr.Text = adr
                            frmTelegram_bg.tbAdr.Text = adr
                            msg = Msg_ModbusRTU_String(adr, getCbValue(MbRTU_Fun)(0), MbRTU_Dat.Text)
                            tbTelegram.Text = msg
                            frmTelegram_bg.tbMsg.Text = msg
                        Catch ex As Exception
                            Exit Sub
                        End Try
                    Case "tpDLT645"
                        DLT645_Adr.Text = ClipText
                        frmTelegram_bg.tbAdr.Text = ClipText
                        msg = Msg_DLT645_String(AdrBytes_DLT645(ClipText, DLT645_ReverseAdr.Checked), getCbValue(DLT645_Ctl)(0), getCbValue(DLT645_Di), String_to_Bytes(DLT645_Dat.Text))
                        tbTelegram.Text = msg
                        frmTelegram_bg.tbMsg.Text = msg
                    Case "tpCJT188"
                        CJT188_Adr.Text = ClipText
                        frmTelegram_bg.tbAdr.Text = ClipText
                        msg = Msg_CJT188_String(AdrBytes_CJT188(ClipText), getCbValue(CJT188_Typ)(0), getCbValue(CJT188_Ctl)(0), getCbValue(CJT188_Di), String_to_Bytes(CJT188_Ser.Text)(0), String_to_Bytes(CJT188_Dat.Text))
                        tbTelegram.Text = msg
                        frmTelegram_bg.tbMsg.Text = msg
                    Case Else
                        Exit Sub
                End Select
                frmTelegram_bg.Blink()
                Clipboard.SetText(msg)
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmAbout.ShowDialog()
        'If IO.File.Exists("ReadMe.txt") Then
        '    Using sr As New IO.StreamReader("ReadMe.txt")
        '        MessageBox.Show(sr.ReadToEnd, "说明", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End Using
        'Else
        '    MessageBox.Show("说明文件丢失", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        MbRTU_chkDEC.Checked = True
        For i = 1 To 247
            MbRTU_Adr.Text = i.ToString
            Call btnSend_Click(Nothing, Nothing)
            Threading.Thread.Sleep(200)
        Next
    End Sub

    Private Sub btnSerialTool_Click(sender As Button, e As EventArgs) Handles btnSerialTool.Click
        frmSerial.Show()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        frmTool.Show()
    End Sub

    Private Sub btnBgMode_MouseEnter(sender As Object, e As EventArgs) Handles btnBgMode.MouseEnter

    End Sub
End Class