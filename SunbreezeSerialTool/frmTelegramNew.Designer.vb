<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTelegramNew
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tbTelegram = New System.Windows.Forms.TextBox()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tpModbusRTU = New System.Windows.Forms.TabPage()
        Me.MbRTU_lbAdr = New System.Windows.Forms.Label()
        Me.MbRTU_lbDat = New System.Windows.Forms.Label()
        Me.MbRTU_Dat = New System.Windows.Forms.TextBox()
        Me.MbRTU_grpAdr = New System.Windows.Forms.GroupBox()
        Me.MbRTU_chkHEX = New System.Windows.Forms.RadioButton()
        Me.MbRTU_chkDEC = New System.Windows.Forms.RadioButton()
        Me.MbRTU_Adr = New System.Windows.Forms.TextBox()
        Me.MbRTU_Fun = New System.Windows.Forms.ComboBox()
        Me.tpModbusTCP = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tpDLT645 = New System.Windows.Forms.TabPage()
        Me.DLT645_ReverseDi = New System.Windows.Forms.CheckBox()
        Me.DLT645_ReverseAdr = New System.Windows.Forms.CheckBox()
        Me.DLT645_Dat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DLT645_Len = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DLT645_Di = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DLT645_Ctl = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DLT645_grpVer = New System.Windows.Forms.GroupBox()
        Me.DLT645_V2007 = New System.Windows.Forms.RadioButton()
        Me.DLT645_V1997 = New System.Windows.Forms.RadioButton()
        Me.DLT645_Adr = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tpCJT188 = New System.Windows.Forms.TabPage()
        Me.CJT188_ReverseAdr = New System.Windows.Forms.CheckBox()
        Me.CJT188_ReverseDi = New System.Windows.Forms.CheckBox()
        Me.CJT188_Len = New System.Windows.Forms.TextBox()
        Me.CJT188_grpVer = New System.Windows.Forms.GroupBox()
        Me.CJT188_V2018 = New System.Windows.Forms.RadioButton()
        Me.CJT188_V2004 = New System.Windows.Forms.RadioButton()
        Me.CJT188_Adr = New System.Windows.Forms.TextBox()
        Me.CJT188_Dat = New System.Windows.Forms.TextBox()
        Me.CJT188_Ser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CJT188_Di = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CJT188_Ctl = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CJT188_Typ = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpIEC104 = New System.Windows.Forms.TabPage()
        Me.tpBACnet = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tpCan = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbKNX = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tpCbus = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tpCheck = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tpCodeList = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lb = New System.Windows.Forms.ListBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.chkTop = New System.Windows.Forms.CheckBox()
        Me.chkClip = New System.Windows.Forms.CheckBox()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnSerialTool = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCreat = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tlpMain.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tpModbusRTU.SuspendLayout()
        Me.MbRTU_grpAdr.SuspendLayout()
        Me.tpModbusTCP.SuspendLayout()
        Me.tpDLT645.SuspendLayout()
        Me.DLT645_grpVer.SuspendLayout()
        Me.tpCJT188.SuspendLayout()
        Me.CJT188_grpVer.SuspendLayout()
        Me.tpBACnet.SuspendLayout()
        Me.tpCan.SuspendLayout()
        Me.tbKNX.SuspendLayout()
        Me.tpCbus.SuspendLayout()
        Me.tpCheck.SuspendLayout()
        Me.tpCodeList.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tbTelegram, 0, 1)
        Me.tlpMain.Controls.Add(Me.tabMain, 0, 0)
        Me.tlpMain.Controls.Add(Me.Panel1, 0, 3)
        Me.tlpMain.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(873, 479)
        Me.tlpMain.TabIndex = 2
        '
        'tbTelegram
        '
        Me.tbTelegram.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTelegram.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbTelegram.Location = New System.Drawing.Point(4, 344)
        Me.tbTelegram.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelegram.Name = "tbTelegram"
        Me.tbTelegram.Size = New System.Drawing.Size(865, 30)
        Me.tbTelegram.TabIndex = 20
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tpModbusRTU)
        Me.tabMain.Controls.Add(Me.tpModbusTCP)
        Me.tabMain.Controls.Add(Me.tpDLT645)
        Me.tabMain.Controls.Add(Me.tpCJT188)
        Me.tabMain.Controls.Add(Me.tpIEC104)
        Me.tabMain.Controls.Add(Me.tpBACnet)
        Me.tabMain.Controls.Add(Me.tpCan)
        Me.tabMain.Controls.Add(Me.tbKNX)
        Me.tabMain.Controls.Add(Me.tpCbus)
        Me.tabMain.Controls.Add(Me.tpCheck)
        Me.tabMain.Controls.Add(Me.tpCodeList)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(4, 4)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(865, 331)
        Me.tabMain.TabIndex = 0
        '
        'tpModbusRTU
        '
        Me.tpModbusRTU.Controls.Add(Me.MbRTU_lbAdr)
        Me.tpModbusRTU.Controls.Add(Me.MbRTU_lbDat)
        Me.tpModbusRTU.Controls.Add(Me.MbRTU_Dat)
        Me.tpModbusRTU.Controls.Add(Me.MbRTU_grpAdr)
        Me.tpModbusRTU.Controls.Add(Me.MbRTU_Fun)
        Me.tpModbusRTU.Location = New System.Drawing.Point(4, 25)
        Me.tpModbusRTU.Margin = New System.Windows.Forms.Padding(4)
        Me.tpModbusRTU.Name = "tpModbusRTU"
        Me.tpModbusRTU.Padding = New System.Windows.Forms.Padding(4)
        Me.tpModbusRTU.Size = New System.Drawing.Size(857, 302)
        Me.tpModbusRTU.TabIndex = 0
        Me.tpModbusRTU.Text = "ModbusRTU"
        Me.tpModbusRTU.UseVisualStyleBackColor = True
        '
        'MbRTU_lbAdr
        '
        Me.MbRTU_lbAdr.AutoSize = True
        Me.MbRTU_lbAdr.Location = New System.Drawing.Point(214, 56)
        Me.MbRTU_lbAdr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MbRTU_lbAdr.Name = "MbRTU_lbAdr"
        Me.MbRTU_lbAdr.Size = New System.Drawing.Size(52, 15)
        Me.MbRTU_lbAdr.TabIndex = 19
        Me.MbRTU_lbAdr.Text = "功能码"
        Me.MbRTU_lbAdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MbRTU_lbDat
        '
        Me.MbRTU_lbDat.AutoSize = True
        Me.MbRTU_lbDat.Location = New System.Drawing.Point(474, 54)
        Me.MbRTU_lbDat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MbRTU_lbDat.Name = "MbRTU_lbDat"
        Me.MbRTU_lbDat.Size = New System.Drawing.Size(37, 15)
        Me.MbRTU_lbDat.TabIndex = 19
        Me.MbRTU_lbDat.Text = "数据"
        Me.MbRTU_lbDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MbRTU_Dat
        '
        Me.MbRTU_Dat.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MbRTU_Dat.Location = New System.Drawing.Point(477, 73)
        Me.MbRTU_Dat.Margin = New System.Windows.Forms.Padding(4)
        Me.MbRTU_Dat.Name = "MbRTU_Dat"
        Me.MbRTU_Dat.Size = New System.Drawing.Size(220, 30)
        Me.MbRTU_Dat.TabIndex = 14
        Me.MbRTU_Dat.Text = "00 00 00 02"
        '
        'MbRTU_grpAdr
        '
        Me.MbRTU_grpAdr.Controls.Add(Me.MbRTU_chkHEX)
        Me.MbRTU_grpAdr.Controls.Add(Me.MbRTU_chkDEC)
        Me.MbRTU_grpAdr.Controls.Add(Me.MbRTU_Adr)
        Me.MbRTU_grpAdr.Location = New System.Drawing.Point(17, 41)
        Me.MbRTU_grpAdr.Name = "MbRTU_grpAdr"
        Me.MbRTU_grpAdr.Size = New System.Drawing.Size(190, 82)
        Me.MbRTU_grpAdr.TabIndex = 10
        Me.MbRTU_grpAdr.TabStop = False
        Me.MbRTU_grpAdr.Text = "仪表地址"
        '
        'MbRTU_chkHEX
        '
        Me.MbRTU_chkHEX.AutoSize = True
        Me.MbRTU_chkHEX.Location = New System.Drawing.Point(6, 49)
        Me.MbRTU_chkHEX.Name = "MbRTU_chkHEX"
        Me.MbRTU_chkHEX.Size = New System.Drawing.Size(88, 19)
        Me.MbRTU_chkHEX.TabIndex = 11
        Me.MbRTU_chkHEX.Text = "十六进制"
        Me.MbRTU_chkHEX.UseVisualStyleBackColor = True
        '
        'MbRTU_chkDEC
        '
        Me.MbRTU_chkDEC.AutoSize = True
        Me.MbRTU_chkDEC.Checked = True
        Me.MbRTU_chkDEC.Location = New System.Drawing.Point(6, 24)
        Me.MbRTU_chkDEC.Name = "MbRTU_chkDEC"
        Me.MbRTU_chkDEC.Size = New System.Drawing.Size(73, 19)
        Me.MbRTU_chkDEC.TabIndex = 11
        Me.MbRTU_chkDEC.TabStop = True
        Me.MbRTU_chkDEC.Text = "十进制"
        Me.MbRTU_chkDEC.UseVisualStyleBackColor = True
        '
        'MbRTU_Adr
        '
        Me.MbRTU_Adr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MbRTU_Adr.Location = New System.Drawing.Point(101, 33)
        Me.MbRTU_Adr.Margin = New System.Windows.Forms.Padding(4)
        Me.MbRTU_Adr.Name = "MbRTU_Adr"
        Me.MbRTU_Adr.Size = New System.Drawing.Size(82, 30)
        Me.MbRTU_Adr.TabIndex = 12
        Me.MbRTU_Adr.Text = "1"
        '
        'MbRTU_Fun
        '
        Me.MbRTU_Fun.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.MbRTU_Fun.FormattingEnabled = True
        Me.MbRTU_Fun.Items.AddRange(New Object() {"03H_读多个寄存器", "04H_读输入寄存器", "06H_写单个寄存器", "10H_写多个寄存器", "01H_读线圈", "02H_读输入离散量", "05H_写单个线圈", "0FH_写多个线圈", "17H_读写多个寄存器", "16H_屏蔽写寄存器", "14H_读文件记录", "15H_写文件记录", "2BH_读设备识别码"})
        Me.MbRTU_Fun.Location = New System.Drawing.Point(217, 75)
        Me.MbRTU_Fun.Margin = New System.Windows.Forms.Padding(4)
        Me.MbRTU_Fun.Name = "MbRTU_Fun"
        Me.MbRTU_Fun.Size = New System.Drawing.Size(242, 28)
        Me.MbRTU_Fun.TabIndex = 13
        '
        'tpModbusTCP
        '
        Me.tpModbusTCP.Controls.Add(Me.Label5)
        Me.tpModbusTCP.Location = New System.Drawing.Point(4, 25)
        Me.tpModbusTCP.Name = "tpModbusTCP"
        Me.tpModbusTCP.Size = New System.Drawing.Size(766, 176)
        Me.tpModbusTCP.TabIndex = 11
        Me.tpModbusTCP.Text = "ModbusTCP"
        Me.tpModbusTCP.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "暂无此功能"
        '
        'tpDLT645
        '
        Me.tpDLT645.Controls.Add(Me.DLT645_ReverseDi)
        Me.tpDLT645.Controls.Add(Me.DLT645_ReverseAdr)
        Me.tpDLT645.Controls.Add(Me.DLT645_Dat)
        Me.tpDLT645.Controls.Add(Me.Label9)
        Me.tpDLT645.Controls.Add(Me.DLT645_Len)
        Me.tpDLT645.Controls.Add(Me.Label17)
        Me.tpDLT645.Controls.Add(Me.DLT645_Di)
        Me.tpDLT645.Controls.Add(Me.Label18)
        Me.tpDLT645.Controls.Add(Me.DLT645_Ctl)
        Me.tpDLT645.Controls.Add(Me.Label16)
        Me.tpDLT645.Controls.Add(Me.DLT645_grpVer)
        Me.tpDLT645.Controls.Add(Me.DLT645_Adr)
        Me.tpDLT645.Controls.Add(Me.Label15)
        Me.tpDLT645.Location = New System.Drawing.Point(4, 25)
        Me.tpDLT645.Margin = New System.Windows.Forms.Padding(4)
        Me.tpDLT645.Name = "tpDLT645"
        Me.tpDLT645.Padding = New System.Windows.Forms.Padding(4)
        Me.tpDLT645.Size = New System.Drawing.Size(766, 176)
        Me.tpDLT645.TabIndex = 1
        Me.tpDLT645.Text = "DL/T 645"
        Me.tpDLT645.UseVisualStyleBackColor = True
        '
        'DLT645_ReverseDi
        '
        Me.DLT645_ReverseDi.AutoSize = True
        Me.DLT645_ReverseDi.Location = New System.Drawing.Point(417, 99)
        Me.DLT645_ReverseDi.Name = "DLT645_ReverseDi"
        Me.DLT645_ReverseDi.Size = New System.Drawing.Size(119, 19)
        Me.DLT645_ReverseDi.TabIndex = 37
        Me.DLT645_ReverseDi.Text = "反转字节顺序"
        Me.DLT645_ReverseDi.UseVisualStyleBackColor = True
        '
        'DLT645_ReverseAdr
        '
        Me.DLT645_ReverseAdr.AutoSize = True
        Me.DLT645_ReverseAdr.Location = New System.Drawing.Point(222, 34)
        Me.DLT645_ReverseAdr.Name = "DLT645_ReverseAdr"
        Me.DLT645_ReverseAdr.Size = New System.Drawing.Size(119, 19)
        Me.DLT645_ReverseAdr.TabIndex = 37
        Me.DLT645_ReverseAdr.Text = "反转字节顺序"
        Me.DLT645_ReverseAdr.UseVisualStyleBackColor = True
        '
        'DLT645_Dat
        '
        Me.DLT645_Dat.Location = New System.Drawing.Point(544, 119)
        Me.DLT645_Dat.Margin = New System.Windows.Forms.Padding(4)
        Me.DLT645_Dat.Name = "DLT645_Dat"
        Me.DLT645_Dat.Size = New System.Drawing.Size(180, 25)
        Me.DLT645_Dat.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(544, 100)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "数据"
        '
        'DLT645_Len
        '
        Me.DLT645_Len.Enabled = False
        Me.DLT645_Len.Location = New System.Drawing.Point(198, 119)
        Me.DLT645_Len.Margin = New System.Windows.Forms.Padding(4)
        Me.DLT645_Len.Name = "DLT645_Len"
        Me.DLT645_Len.Size = New System.Drawing.Size(80, 25)
        Me.DLT645_Len.TabIndex = 23
        Me.DLT645_Len.Text = "自动"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(195, 100)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 15)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "数据长度"
        '
        'DLT645_Di
        '
        Me.DLT645_Di.FormattingEnabled = True
        Me.DLT645_Di.Location = New System.Drawing.Point(286, 119)
        Me.DLT645_Di.Margin = New System.Windows.Forms.Padding(4)
        Me.DLT645_Di.Name = "DLT645_Di"
        Me.DLT645_Di.Size = New System.Drawing.Size(250, 23)
        Me.DLT645_Di.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(283, 100)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 15)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "数据标识"
        '
        'DLT645_Ctl
        '
        Me.DLT645_Ctl.FormattingEnabled = True
        Me.DLT645_Ctl.Location = New System.Drawing.Point(10, 119)
        Me.DLT645_Ctl.Margin = New System.Windows.Forms.Padding(4)
        Me.DLT645_Ctl.Name = "DLT645_Ctl"
        Me.DLT645_Ctl.Size = New System.Drawing.Size(180, 23)
        Me.DLT645_Ctl.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 100)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "控制码"
        '
        'DLT645_grpVer
        '
        Me.DLT645_grpVer.Controls.Add(Me.DLT645_V2007)
        Me.DLT645_grpVer.Controls.Add(Me.DLT645_V1997)
        Me.DLT645_grpVer.Location = New System.Drawing.Point(10, 10)
        Me.DLT645_grpVer.Name = "DLT645_grpVer"
        Me.DLT645_grpVer.Size = New System.Drawing.Size(93, 77)
        Me.DLT645_grpVer.TabIndex = 20
        Me.DLT645_grpVer.TabStop = False
        Me.DLT645_grpVer.Text = "协议版本"
        '
        'DLT645_V2007
        '
        Me.DLT645_V2007.AutoSize = True
        Me.DLT645_V2007.Location = New System.Drawing.Point(6, 49)
        Me.DLT645_V2007.Name = "DLT645_V2007"
        Me.DLT645_V2007.Size = New System.Drawing.Size(60, 19)
        Me.DLT645_V2007.TabIndex = 20
        Me.DLT645_V2007.Text = "2007"
        Me.DLT645_V2007.UseVisualStyleBackColor = True
        '
        'DLT645_V1997
        '
        Me.DLT645_V1997.AutoSize = True
        Me.DLT645_V1997.Location = New System.Drawing.Point(6, 24)
        Me.DLT645_V1997.Name = "DLT645_V1997"
        Me.DLT645_V1997.Size = New System.Drawing.Size(60, 19)
        Me.DLT645_V1997.TabIndex = 20
        Me.DLT645_V1997.Text = "1997"
        Me.DLT645_V1997.UseVisualStyleBackColor = True
        '
        'DLT645_Adr
        '
        Me.DLT645_Adr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DLT645_Adr.Location = New System.Drawing.Point(121, 54)
        Me.DLT645_Adr.Margin = New System.Windows.Forms.Padding(4)
        Me.DLT645_Adr.Name = "DLT645_Adr"
        Me.DLT645_Adr.Size = New System.Drawing.Size(220, 30)
        Me.DLT645_Adr.TabIndex = 21
        Me.DLT645_Adr.Text = "AA AA AA AA AA AA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(118, 35)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 15)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "仪表地址"
        '
        'tpCJT188
        '
        Me.tpCJT188.Controls.Add(Me.CJT188_ReverseAdr)
        Me.tpCJT188.Controls.Add(Me.CJT188_ReverseDi)
        Me.tpCJT188.Controls.Add(Me.CJT188_Len)
        Me.tpCJT188.Controls.Add(Me.CJT188_grpVer)
        Me.tpCJT188.Controls.Add(Me.CJT188_Adr)
        Me.tpCJT188.Controls.Add(Me.CJT188_Dat)
        Me.tpCJT188.Controls.Add(Me.CJT188_Ser)
        Me.tpCJT188.Controls.Add(Me.Label6)
        Me.tpCJT188.Controls.Add(Me.Label7)
        Me.tpCJT188.Controls.Add(Me.Label4)
        Me.tpCJT188.Controls.Add(Me.Label3)
        Me.tpCJT188.Controls.Add(Me.CJT188_Di)
        Me.tpCJT188.Controls.Add(Me.Label8)
        Me.tpCJT188.Controls.Add(Me.CJT188_Ctl)
        Me.tpCJT188.Controls.Add(Me.Label2)
        Me.tpCJT188.Controls.Add(Me.CJT188_Typ)
        Me.tpCJT188.Controls.Add(Me.Label1)
        Me.tpCJT188.Location = New System.Drawing.Point(4, 25)
        Me.tpCJT188.Margin = New System.Windows.Forms.Padding(4)
        Me.tpCJT188.Name = "tpCJT188"
        Me.tpCJT188.Size = New System.Drawing.Size(766, 176)
        Me.tpCJT188.TabIndex = 2
        Me.tpCJT188.Text = "CJ/T 188"
        Me.tpCJT188.UseVisualStyleBackColor = True
        '
        'CJT188_ReverseAdr
        '
        Me.CJT188_ReverseAdr.AutoSize = True
        Me.CJT188_ReverseAdr.Location = New System.Drawing.Point(437, 34)
        Me.CJT188_ReverseAdr.Name = "CJT188_ReverseAdr"
        Me.CJT188_ReverseAdr.Size = New System.Drawing.Size(119, 19)
        Me.CJT188_ReverseAdr.TabIndex = 42
        Me.CJT188_ReverseAdr.Text = "反转字节顺序"
        Me.CJT188_ReverseAdr.UseVisualStyleBackColor = True
        '
        'CJT188_ReverseDi
        '
        Me.CJT188_ReverseDi.AutoSize = True
        Me.CJT188_ReverseDi.Location = New System.Drawing.Point(381, 105)
        Me.CJT188_ReverseDi.Name = "CJT188_ReverseDi"
        Me.CJT188_ReverseDi.Size = New System.Drawing.Size(119, 19)
        Me.CJT188_ReverseDi.TabIndex = 42
        Me.CJT188_ReverseDi.Text = "反转字节顺序"
        Me.CJT188_ReverseDi.UseVisualStyleBackColor = True
        '
        'CJT188_Len
        '
        Me.CJT188_Len.Enabled = False
        Me.CJT188_Len.Location = New System.Drawing.Point(184, 125)
        Me.CJT188_Len.Margin = New System.Windows.Forms.Padding(4)
        Me.CJT188_Len.Name = "CJT188_Len"
        Me.CJT188_Len.Size = New System.Drawing.Size(80, 25)
        Me.CJT188_Len.TabIndex = 41
        Me.CJT188_Len.Text = "自动"
        '
        'CJT188_grpVer
        '
        Me.CJT188_grpVer.Controls.Add(Me.CJT188_V2018)
        Me.CJT188_grpVer.Controls.Add(Me.CJT188_V2004)
        Me.CJT188_grpVer.Location = New System.Drawing.Point(10, 10)
        Me.CJT188_grpVer.Name = "CJT188_grpVer"
        Me.CJT188_grpVer.Size = New System.Drawing.Size(90, 80)
        Me.CJT188_grpVer.TabIndex = 40
        Me.CJT188_grpVer.TabStop = False
        Me.CJT188_grpVer.Text = "协议版本"
        '
        'CJT188_V2018
        '
        Me.CJT188_V2018.AutoSize = True
        Me.CJT188_V2018.Location = New System.Drawing.Point(6, 49)
        Me.CJT188_V2018.Name = "CJT188_V2018"
        Me.CJT188_V2018.Size = New System.Drawing.Size(60, 19)
        Me.CJT188_V2018.TabIndex = 1
        Me.CJT188_V2018.Text = "2018"
        Me.CJT188_V2018.UseVisualStyleBackColor = True
        '
        'CJT188_V2004
        '
        Me.CJT188_V2004.AutoSize = True
        Me.CJT188_V2004.Location = New System.Drawing.Point(6, 24)
        Me.CJT188_V2004.Name = "CJT188_V2004"
        Me.CJT188_V2004.Size = New System.Drawing.Size(60, 19)
        Me.CJT188_V2004.TabIndex = 0
        Me.CJT188_V2004.Text = "2004"
        Me.CJT188_V2004.UseVisualStyleBackColor = True
        '
        'CJT188_Adr
        '
        Me.CJT188_Adr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CJT188_Adr.Location = New System.Drawing.Point(295, 54)
        Me.CJT188_Adr.Margin = New System.Windows.Forms.Padding(4)
        Me.CJT188_Adr.Name = "CJT188_Adr"
        Me.CJT188_Adr.Size = New System.Drawing.Size(261, 30)
        Me.CJT188_Adr.TabIndex = 31
        Me.CJT188_Adr.Text = "AA AA AA AA AA AA AA"
        '
        'CJT188_Dat
        '
        Me.CJT188_Dat.Location = New System.Drawing.Point(598, 125)
        Me.CJT188_Dat.Margin = New System.Windows.Forms.Padding(4)
        Me.CJT188_Dat.Name = "CJT188_Dat"
        Me.CJT188_Dat.Size = New System.Drawing.Size(160, 25)
        Me.CJT188_Dat.TabIndex = 34
        '
        'CJT188_Ser
        '
        Me.CJT188_Ser.Location = New System.Drawing.Point(510, 125)
        Me.CJT188_Ser.Margin = New System.Windows.Forms.Padding(4)
        Me.CJT188_Ser.Name = "CJT188_Ser"
        Me.CJT188_Ser.Size = New System.Drawing.Size(80, 25)
        Me.CJT188_Ser.TabIndex = 34
        Me.CJT188_Ser.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(292, 35)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "仪表地址"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(595, 106)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "数据"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "序列号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "数据标识"
        '
        'CJT188_Di
        '
        Me.CJT188_Di.FormattingEnabled = True
        Me.CJT188_Di.Location = New System.Drawing.Point(272, 125)
        Me.CJT188_Di.Margin = New System.Windows.Forms.Padding(4)
        Me.CJT188_Di.Name = "CJT188_Di"
        Me.CJT188_Di.Size = New System.Drawing.Size(230, 23)
        Me.CJT188_Di.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(181, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "数据长度"
        '
        'CJT188_Ctl
        '
        Me.CJT188_Ctl.FormattingEnabled = True
        Me.CJT188_Ctl.Location = New System.Drawing.Point(16, 125)
        Me.CJT188_Ctl.Margin = New System.Windows.Forms.Padding(4)
        Me.CJT188_Ctl.Name = "CJT188_Ctl"
        Me.CJT188_Ctl.Size = New System.Drawing.Size(160, 23)
        Me.CJT188_Ctl.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "控制码"
        '
        'CJT188_Typ
        '
        Me.CJT188_Typ.FormattingEnabled = True
        Me.CJT188_Typ.Location = New System.Drawing.Point(127, 55)
        Me.CJT188_Typ.Margin = New System.Windows.Forms.Padding(4)
        Me.CJT188_Typ.Name = "CJT188_Typ"
        Me.CJT188_Typ.Size = New System.Drawing.Size(160, 23)
        Me.CJT188_Typ.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "仪表类型"
        '
        'tpIEC104
        '
        Me.tpIEC104.Location = New System.Drawing.Point(4, 25)
        Me.tpIEC104.Name = "tpIEC104"
        Me.tpIEC104.Size = New System.Drawing.Size(766, 176)
        Me.tpIEC104.TabIndex = 5
        Me.tpIEC104.Text = "IEC 104"
        Me.tpIEC104.UseVisualStyleBackColor = True
        '
        'tpBACnet
        '
        Me.tpBACnet.Controls.Add(Me.Label10)
        Me.tpBACnet.Location = New System.Drawing.Point(4, 25)
        Me.tpBACnet.Name = "tpBACnet"
        Me.tpBACnet.Size = New System.Drawing.Size(766, 176)
        Me.tpBACnet.TabIndex = 10
        Me.tpBACnet.Text = "BACnet"
        Me.tpBACnet.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(342, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "暂无此功能"
        '
        'tpCan
        '
        Me.tpCan.Controls.Add(Me.Label11)
        Me.tpCan.Location = New System.Drawing.Point(4, 25)
        Me.tpCan.Name = "tpCan"
        Me.tpCan.Size = New System.Drawing.Size(766, 176)
        Me.tpCan.TabIndex = 8
        Me.tpCan.Text = "CAN"
        Me.tpCan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(342, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "暂无此功能"
        '
        'tbKNX
        '
        Me.tbKNX.Controls.Add(Me.Label12)
        Me.tbKNX.Location = New System.Drawing.Point(4, 25)
        Me.tbKNX.Name = "tbKNX"
        Me.tbKNX.Size = New System.Drawing.Size(766, 176)
        Me.tbKNX.TabIndex = 9
        Me.tbKNX.Text = "KNX"
        Me.tbKNX.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(342, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "暂无此功能"
        '
        'tpCbus
        '
        Me.tpCbus.Controls.Add(Me.Label13)
        Me.tpCbus.Location = New System.Drawing.Point(4, 25)
        Me.tpCbus.Name = "tpCbus"
        Me.tpCbus.Size = New System.Drawing.Size(766, 176)
        Me.tpCbus.TabIndex = 7
        Me.tpCbus.Text = "C-Bus"
        Me.tpCbus.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(342, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "暂无此功能"
        '
        'tpCheck
        '
        Me.tpCheck.Controls.Add(Me.Button1)
        Me.tpCheck.Controls.Add(Me.ComboBox1)
        Me.tpCheck.Controls.Add(Me.TextBox1)
        Me.tpCheck.Location = New System.Drawing.Point(4, 25)
        Me.tpCheck.Name = "tpCheck"
        Me.tpCheck.Size = New System.Drawing.Size(766, 176)
        Me.tpCheck.TabIndex = 6
        Me.tpCheck.Text = "报文校验"
        Me.tpCheck.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 34)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(86, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(5, 4)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(756, 111)
        Me.TextBox1.TabIndex = 21
        '
        'tpCodeList
        '
        Me.tpCodeList.Controls.Add(Me.SplitContainer1)
        Me.tpCodeList.Location = New System.Drawing.Point(4, 25)
        Me.tpCodeList.Name = "tpCodeList"
        Me.tpCodeList.Size = New System.Drawing.Size(857, 302)
        Me.tpCodeList.TabIndex = 4
        Me.tpCodeList.Text = "CodeList"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lb)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(857, 302)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 2
        '
        'lb
        '
        Me.lb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb.FormattingEnabled = True
        Me.lb.ItemHeight = 15
        Me.lb.Location = New System.Drawing.Point(0, 0)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(175, 302)
        Me.lb.TabIndex = 801
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 27
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(678, 302)
        Me.dgv.TabIndex = 802
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tlpBottom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 34)
        Me.Panel1.TabIndex = 1
        '
        'tlpBottom
        '
        Me.tlpBottom.ColumnCount = 6
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpBottom.Controls.Add(Me.chkTop, 0, 0)
        Me.tlpBottom.Controls.Add(Me.chkClip, 1, 0)
        Me.tlpBottom.Controls.Add(Me.btnMode, 4, 0)
        Me.tlpBottom.Controls.Add(Me.btnHelp, 5, 0)
        Me.tlpBottom.Controls.Add(Me.btnSerialTool, 3, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Location = New System.Drawing.Point(0, 0)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 1
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(867, 34)
        Me.tlpBottom.TabIndex = 0
        '
        'chkTop
        '
        Me.chkTop.Location = New System.Drawing.Point(3, 3)
        Me.chkTop.Name = "chkTop"
        Me.chkTop.Size = New System.Drawing.Size(114, 28)
        Me.chkTop.TabIndex = 999
        Me.chkTop.Text = "窗口置顶"
        Me.chkTop.UseVisualStyleBackColor = True
        '
        'chkClip
        '
        Me.chkClip.Checked = True
        Me.chkClip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClip.Location = New System.Drawing.Point(123, 3)
        Me.chkClip.Name = "chkClip"
        Me.chkClip.Size = New System.Drawing.Size(174, 28)
        Me.chkClip.TabIndex = 999
        Me.chkClip.Text = "报文复制到剪切板"
        Me.chkClip.UseVisualStyleBackColor = True
        '
        'btnMode
        '
        Me.btnMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMode.Location = New System.Drawing.Point(670, 3)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(114, 28)
        Me.btnMode.TabIndex = 1000
        Me.btnMode.Text = "后台模式"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHelp.Location = New System.Drawing.Point(790, 3)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(74, 28)
        Me.btnHelp.TabIndex = 1001
        Me.btnHelp.Text = "说明"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnSerialTool
        '
        Me.btnSerialTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSerialTool.Location = New System.Drawing.Point(550, 3)
        Me.btnSerialTool.Name = "btnSerialTool"
        Me.btnSerialTool.Size = New System.Drawing.Size(114, 28)
        Me.btnSerialTool.TabIndex = 1002
        Me.btnSerialTool.Text = "串口工具"
        Me.btnSerialTool.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCreat, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSend, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 382)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(867, 54)
        Me.TableLayoutPanel1.TabIndex = 1003
        '
        'btnCreat
        '
        Me.btnCreat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreat.Location = New System.Drawing.Point(4, 4)
        Me.btnCreat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreat.Name = "btnCreat"
        Me.btnCreat.Size = New System.Drawing.Size(598, 46)
        Me.btnCreat.TabIndex = 20
        Me.btnCreat.Text = "生成报文" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCreat.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSend.Location = New System.Drawing.Point(609, 3)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(255, 48)
        Me.btnSend.TabIndex = 21
        Me.btnSend.Text = "生成并发送"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmTelegramNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 479)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "frmTelegramNew"
        Me.Text = "frmTelegramNew"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tpModbusRTU.ResumeLayout(False)
        Me.tpModbusRTU.PerformLayout()
        Me.MbRTU_grpAdr.ResumeLayout(False)
        Me.MbRTU_grpAdr.PerformLayout()
        Me.tpModbusTCP.ResumeLayout(False)
        Me.tpModbusTCP.PerformLayout()
        Me.tpDLT645.ResumeLayout(False)
        Me.tpDLT645.PerformLayout()
        Me.DLT645_grpVer.ResumeLayout(False)
        Me.DLT645_grpVer.PerformLayout()
        Me.tpCJT188.ResumeLayout(False)
        Me.tpCJT188.PerformLayout()
        Me.CJT188_grpVer.ResumeLayout(False)
        Me.CJT188_grpVer.PerformLayout()
        Me.tpBACnet.ResumeLayout(False)
        Me.tpBACnet.PerformLayout()
        Me.tpCan.ResumeLayout(False)
        Me.tpCan.PerformLayout()
        Me.tbKNX.ResumeLayout(False)
        Me.tbKNX.PerformLayout()
        Me.tpCbus.ResumeLayout(False)
        Me.tpCbus.PerformLayout()
        Me.tpCheck.ResumeLayout(False)
        Me.tpCheck.PerformLayout()
        Me.tpCodeList.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tbTelegram As TextBox
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tpModbusRTU As TabPage
    Friend WithEvents MbRTU_lbAdr As Label
    Friend WithEvents MbRTU_lbDat As Label
    Friend WithEvents MbRTU_Dat As TextBox
    Friend WithEvents MbRTU_grpAdr As GroupBox
    Friend WithEvents MbRTU_chkHEX As RadioButton
    Friend WithEvents MbRTU_chkDEC As RadioButton
    Friend WithEvents MbRTU_Adr As TextBox
    Friend WithEvents MbRTU_Fun As ComboBox
    Friend WithEvents tpModbusTCP As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents tpDLT645 As TabPage
    Friend WithEvents DLT645_ReverseDi As CheckBox
    Friend WithEvents DLT645_ReverseAdr As CheckBox
    Friend WithEvents DLT645_Dat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DLT645_Len As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DLT645_Di As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents DLT645_Ctl As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DLT645_grpVer As GroupBox
    Friend WithEvents DLT645_V2007 As RadioButton
    Friend WithEvents DLT645_V1997 As RadioButton
    Friend WithEvents DLT645_Adr As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tpCJT188 As TabPage
    Friend WithEvents CJT188_ReverseAdr As CheckBox
    Friend WithEvents CJT188_ReverseDi As CheckBox
    Friend WithEvents CJT188_Len As TextBox
    Friend WithEvents CJT188_grpVer As GroupBox
    Friend WithEvents CJT188_V2018 As RadioButton
    Friend WithEvents CJT188_V2004 As RadioButton
    Friend WithEvents CJT188_Adr As TextBox
    Friend WithEvents CJT188_Dat As TextBox
    Friend WithEvents CJT188_Ser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CJT188_Di As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CJT188_Ctl As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CJT188_Typ As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tpIEC104 As TabPage
    Friend WithEvents tpBACnet As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents tpCan As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents tbKNX As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents tpCbus As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents tpCheck As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tpCodeList As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lb As ListBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tlpBottom As TableLayoutPanel
    Friend WithEvents chkTop As CheckBox
    Friend WithEvents chkClip As CheckBox
    Friend WithEvents btnMode As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnSerialTool As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCreat As Button
    Friend WithEvents btnSend As Button
End Class
