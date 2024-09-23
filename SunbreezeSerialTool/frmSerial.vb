Imports System.IO

Public Class frmSerial

    Delegate Sub RecieveRefreshMethodDelegate([text] As String) '声明委托
    Dim RecieveRefresh As New RecieveRefreshMethodDelegate(AddressOf RecieveRefreshMethod) '定义一个委托实例

    Sub RecieveRefreshMethod(str As String) '定义一个实例方法
        ShowRecieveData(str)
    End Sub

    Private Sub ShowRecieveData(str As String)
        Try
            tbDisplay.Text &= str
        Catch ex As Exception
            MessageBox.Show($"数据接收或显示错误{vbCrLf}{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SerialPortInit()
        cbPortBaud.SelectedIndex = 6
        cbPortParity.SelectedIndex = 0
        cbPortData.SelectedIndex = 3
        cbPortStop.SelectedIndex = 0
        sPort.Encoding = System.Text.Encoding.ASCII '.Default
        PortsSearch(0)
    End Sub

    Private Sub PortsSearch(Optional SelIndex As Integer = -1)
        Dim gpns() As String = Ports.SerialPort.GetPortNames
        cbPortName.Items.Clear()
        If gpns.Length > 0 Then
            cbPortName.Items.AddRange(gpns)
            If SelIndex >= 0 Then cbPortName.SelectedIndex = SelIndex
        Else
            If MessageBox.Show("未检测到串口", "错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) = DialogResult.Retry Then
                SerialPortInit()
            Else
                'Application.Exit()
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"Sunbreeze Serial Tool  v{My.Application.Info.Version}"
        SerialPortInit()
        lblStatus.Text = "准备就绪"
        KeyPreview = True
        'sPort.DtrEnable = False
        'sPort.RtsEnable = False
        tlpTop.ColumnStyles(1).Width = 0
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        If sPort.IsOpen Then
            sPort.Close()
            sPort.Dispose()
        End If
    End Sub

    Private Sub cbPortName_Click(sender As Object, e As EventArgs) Handles cbPortName.Click
        PortsSearch()
    End Sub

    Private Sub cbPortName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPortName.SelectedIndexChanged
        If sPort.IsOpen Then
            sPort.Close()
            btnPortOpen_Click(Nothing, Nothing)
        Else
            sPort.PortName = cbPortName.Text
        End If
    End Sub

    Private Sub cbPortBaud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPortBaud.SelectedIndexChanged
        sPort.BaudRate = Convert.ToInt32(cbPortBaud.Text)
    End Sub

    Private Sub cbPortParity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPortParity.SelectedIndexChanged
        sPort.Parity = cbPortParity.SelectedIndex
    End Sub

    Private Sub cbPortData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPortData.SelectedIndexChanged
        sPort.DataBits = Convert.ToInt32(cbPortData.Text)
    End Sub

    Private Sub cbPortStop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPortStop.SelectedIndexChanged
        sPort.StopBits = cbPortStop.SelectedIndex + 1
    End Sub

    '打开串口
    Private Sub btnPortOpen_Click(sender As Button, e As EventArgs) Handles btnPortOpen.Click
        Try
            If sPort.IsOpen Then
                If chkAutoSend.Checked Then
                    MessageBox.Show("请先关闭自动发送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                sPort.Close()
                sender.Text = "打开串口"
                sender.BackColor = btnSend.BackColor
                lblStatus.Text = "准备就绪"
            Else
                sPort.Open()
                sender.Text = "关闭串口"
                sender.BackColor = Color.Red
                lblStatus.Text = $"{sPort.PortName}已打开，{sPort.BaudRate},{sPort.Parity},{sPort.DataBits},{sPort.StopBits}"
            End If
            cbPortName.Enabled = Not sPort.IsOpen
            cbPortBaud.Enabled = Not sPort.IsOpen
            cbPortParity.Enabled = Not sPort.IsOpen
            cbPortData.Enabled = Not sPort.IsOpen
            cbPortStop.Enabled = Not sPort.IsOpen
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Dim bufferRX(100) As Byte
        'Dim fMSGRICEVUTO As Boolean = False
        'Try
        '    For index = 0 To SerialPort1.ReceivedBytesThreshold - 1
        '        bufferRX(index) = SerialPort1.ReadByte()
        '        'Debug.Print("(" + index.ToString + ") => " + (bufferRX(index).ToString))
        '    Next
        '    fMSGRICEVUTO = True
        'Catch ex As Exception
        'End Try
    End Sub

    '发送报文
    Friend Sub BtnSend_Click(sender As Button, e As EventArgs) Handles btnSend.Click
        If tbSend.Text.Trim = vbNullString Then Exit Sub
        'chkAutoSend.Checked = False
        'tmAutoSend.Stop()
        Dim SendStr As String = tbSend.Text
        Dim SendMsg As String = vbNullString
        Dim SendLen As Integer = 0
        Try
            If Not sPort.IsOpen Then
                If MessageBox.Show($"串口尚未打开，是否打开{cbPortName.Text}({cbPortBaud.Text}, {cbPortParity.Text}, {cbPortStop.Text})并发送？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Call btnPortOpen_Click(btnPortOpen, Nothing)
                Else
                    Exit Sub
                End If
            End If
            If chkHexS.Checked Then '十六进制发送
                SendStr = SendStr.Replace(" ", vbNullString).Replace(vbCrLf, vbNullString)
                Dim SendBytes As Byte() = String_to_Bytes(SendStr)
                sPort.Write(SendBytes, 0, SendBytes.Length)
                SendMsg = Bytes_to_String(SendBytes)
                SendLen = SendBytes.Length
            Else '文本发送
                sPort.Write(SendStr)
                SendMsg = SendStr
                SendLen = SendStr.Length
            End If
            tbDisplay.AppendText($"Tx: {SendMsg}{vbCrLf}")
            lblTxC.Text = (Convert.ToInt32(lblTxC.Text) + SendLen).ToString
        Catch ex As Exception
            MessageBox.Show($"数据输入或发送错误{vbCrLf}{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TimerAutoSend_Tick(sender As Object, e As EventArgs) Handles tmAutoSend.Tick
        BtnSend_Click(Nothing, Nothing)
    End Sub

    '接收报文
    Private Sub SerialPort_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles sPort.DataReceived
        If chkReadDelay.Checked Then Threading.Thread.Sleep(numReadDelay.Value) '延时等待缓冲
        Try
            Dim ReadMsg As String = vbNullString
            Dim ReadLen As Integer = 0
            If chkHexR.Checked Then '十六进制显示
                ReadLen = sPort.BytesToRead()
                If ReadLen > 0 Then
                    Dim ReadBytes(ReadLen - 1) As Byte
                    sPort.Read(ReadBytes, 0, ReadLen)
                    ReadMsg = Bytes_to_String(ReadBytes)
                    'ReadMsg = "#Receive Error#" '【temp】
                End If
            Else '文本显示
                Dim ReadStr As String = sPort.ReadExisting
                ReadMsg = ReadStr
                ReadLen = ReadStr.Length
            End If
            tbDisplay.Invoke(RecieveRefresh, $"Rx: {ReadMsg}{vbCrLf}")
            lblRxC.Text = (Convert.ToInt32(lblRxC.Text) + ReadLen).ToString '接收字节计数
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sPort_ErrorReceived(sender As Object, e As Ports.SerialErrorReceivedEventArgs) Handles sPort.ErrorReceived
        'MsgBox("")
    End Sub

    Private Sub tbMsg_TextChanged(sender As Object, e As EventArgs) Handles tbDisplay.TextChanged
        tbDisplay.SelectionStart = tbDisplay.Text.Length
        tbDisplay.ScrollToCaret()
    End Sub

    Private Sub chkAutoSend_CheckedChanged(sender As CheckBox, e As EventArgs) Handles chkAutoSend.CheckedChanged
        If sender.Checked Then
            numAutoDT.Enabled = False
            tmAutoSend.Interval = numAutoDT.Value
            tmAutoSend.Start()
        Else
            numAutoDT.Enabled = True
            tmAutoSend.Stop()
        End If
    End Sub

    Private Sub btnMsgClear_Click(sender As Object, e As EventArgs) Handles btnMsgClear.Click
        tbDisplay.Clear()
    End Sub

    Private Sub btnCountClear_Click(sender As Object, e As EventArgs) Handles btnCountClear.Click
        lblTxC.Text = "0"
        lblRxC.Text = "0"
    End Sub

    '发送文件
    Private Sub ButtonSendFile_Click(sender As Object, e As EventArgs)
        Dim DialogOpen As New OpenFileDialog
        DialogOpen.Multiselect = True '允许选择多文件
        DialogOpen.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"

        If DialogOpen.ShowDialog() = DialogResult.OK Then
            Dim fileName As String
            For Each fileName In DialogOpen.FileNames '将每一个打开的文件发送出去
                lblStatus.Text = $"正在发送 {fileName}"
                Dim outBytes() As Byte
                outBytes = My.Computer.FileSystem.ReadAllBytes(fileName) '读取文件
                sPort.Write(outBytes, 0, outBytes.Length)
                lblTxC.Text = Val(lblTxC.Text) + outBytes.Length
            Next
            lblStatus.Text = $"文件发送完毕，共发送{DialogOpen.FileNames.Length}个文件。"
        End If
    End Sub

    Private Sub btnMsgSave_Check(sender As Object, e As EventArgs) Handles btnMsgSave.Click
        Dim DialogSave As New SaveFileDialog
        DialogSave.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        If DialogSave.ShowDialog() = DialogResult.OK Then
            Dim outBytes() As Byte
            outBytes = System.Text.Encoding.Default.GetBytes(tbDisplay.Text)
            My.Computer.FileSystem.WriteAllBytes(DialogSave.FileName, outBytes, False)
        End If
        lblStatus.Text = $"数据保存到 {DialogSave.FileName}"
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub frmSerial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = vbCr Then
            BtnSend_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnTelTool_Click(sender As Object, e As EventArgs) Handles btnTelTool.Click
        frmTelegram.Show()
    End Sub

    Private Sub btnMbTool_Click(sender As Object, e As EventArgs) Handles btnMbTool.Click
        frmModbusTool.Show()
    End Sub

    '【temp】
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Try
        'Dim p As Process() = Process.GetProcessesByName("Commix")
        '    If p.Length > 0 Then
        '        For i = 0 To p.Length - 1
        '        p(i).Kill()
        '        File.Delete(p(i).MainModule.FileName) Then
        '        Next
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

End Class