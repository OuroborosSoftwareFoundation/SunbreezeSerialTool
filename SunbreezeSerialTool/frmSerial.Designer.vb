<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSerial
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerial))
        Me.tbDisplay = New System.Windows.Forms.TextBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tlpSR = New System.Windows.Forms.TableLayoutPanel()
        Me.numAutoDT = New System.Windows.Forms.NumericUpDown()
        Me.chkHexS = New System.Windows.Forms.CheckBox()
        Me.chkAutoSend = New System.Windows.Forms.CheckBox()
        Me.chkHexR = New System.Windows.Forms.CheckBox()
        Me.chkReadDelay = New System.Windows.Forms.CheckBox()
        Me.numReadDelay = New System.Windows.Forms.NumericUpDown()
        Me.chkReflect = New System.Windows.Forms.CheckBox()
        Me.tbSend = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tlpPort = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbPortName = New System.Windows.Forms.ComboBox()
        Me.cbPortBaud = New System.Windows.Forms.ComboBox()
        Me.cbPortParity = New System.Windows.Forms.ComboBox()
        Me.cbPortData = New System.Windows.Forms.ComboBox()
        Me.cbPortStop = New System.Windows.Forms.ComboBox()
        Me.btnPortOpen = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMsgClear = New System.Windows.Forms.Button()
        Me.btnMsgSave = New System.Windows.Forms.Button()
        Me.btnMbTool = New System.Windows.Forms.Button()
        Me.btnTelTool = New System.Windows.Forms.Button()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.tabTlg = New System.Windows.Forms.TabControl()
        Me.tmAutoSend = New System.Windows.Forms.Timer(Me.components)
        Me.sPort = New System.IO.Ports.SerialPort(Me.components)
        Me.btnCountClear = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTxC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblRxC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnAbout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StS = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tlpMain.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tlpSR.SuspendLayout()
        CType(Me.numAutoDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numReadDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tlpPort.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        Me.StS.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbDisplay
        '
        Me.tbDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDisplay.Location = New System.Drawing.Point(4, 4)
        Me.tbDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDisplay.Multiline = True
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDisplay.Size = New System.Drawing.Size(629, 276)
        Me.tbDisplay.TabIndex = 0
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpBottom, 0, 1)
        Me.tlpMain.Controls.Add(Me.tlpTop, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1043, 540)
        Me.tlpMain.TabIndex = 1
        '
        'tlpBottom
        '
        Me.tlpBottom.ColumnCount = 4
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpBottom.Controls.Add(Me.GroupBox2, 1, 0)
        Me.tlpBottom.Controls.Add(Me.tbSend, 1, 1)
        Me.tlpBottom.Controls.Add(Me.btnSend, 3, 1)
        Me.tlpBottom.Controls.Add(Me.GroupBox1, 0, 0)
        Me.tlpBottom.Controls.Add(Me.btnPortOpen, 0, 1)
        Me.tlpBottom.Controls.Add(Me.Panel2, 2, 0)
        Me.tlpBottom.Controls.Add(Me.TableLayoutPanel1, 3, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Location = New System.Drawing.Point(4, 294)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 2
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(1035, 242)
        Me.tlpBottom.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tlpSR)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(204, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(492, 194)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "发送/接受设置"
        '
        'tlpSR
        '
        Me.tlpSR.ColumnCount = 5
        Me.tlpSR.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlpSR.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSR.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlpSR.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSR.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSR.Controls.Add(Me.numAutoDT, 3, 1)
        Me.tlpSR.Controls.Add(Me.chkHexS, 0, 0)
        Me.tlpSR.Controls.Add(Me.chkAutoSend, 2, 1)
        Me.tlpSR.Controls.Add(Me.chkHexR, 0, 1)
        Me.tlpSR.Controls.Add(Me.chkReadDelay, 2, 0)
        Me.tlpSR.Controls.Add(Me.numReadDelay, 3, 0)
        Me.tlpSR.Controls.Add(Me.chkReflect, 0, 3)
        Me.tlpSR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSR.Location = New System.Drawing.Point(4, 22)
        Me.tlpSR.Name = "tlpSR"
        Me.tlpSR.RowCount = 4
        Me.tlpSR.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSR.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSR.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSR.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSR.Size = New System.Drawing.Size(484, 168)
        Me.tlpSR.TabIndex = 7
        '
        'numAutoDT
        '
        Me.numAutoDT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAutoDT.Increment = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numAutoDT.Location = New System.Drawing.Point(384, 50)
        Me.numAutoDT.Margin = New System.Windows.Forms.Padding(4)
        Me.numAutoDT.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numAutoDT.Name = "numAutoDT"
        Me.numAutoDT.Size = New System.Drawing.Size(92, 25)
        Me.numAutoDT.TabIndex = 3
        Me.numAutoDT.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'chkHexS
        '
        Me.chkHexS.AutoSize = True
        Me.chkHexS.Checked = True
        Me.chkHexS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHexS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkHexS.Location = New System.Drawing.Point(4, 4)
        Me.chkHexS.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHexS.Name = "chkHexS"
        Me.chkHexS.Size = New System.Drawing.Size(172, 34)
        Me.chkHexS.TabIndex = 0
        Me.chkHexS.Text = "十六进制发送"
        Me.chkHexS.UseVisualStyleBackColor = True
        '
        'chkAutoSend
        '
        Me.chkAutoSend.AutoSize = True
        Me.chkAutoSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkAutoSend.Location = New System.Drawing.Point(204, 46)
        Me.chkAutoSend.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAutoSend.Name = "chkAutoSend"
        Me.chkAutoSend.Size = New System.Drawing.Size(172, 34)
        Me.chkAutoSend.TabIndex = 2
        Me.chkAutoSend.Text = "循环发送间隔（ms）"
        Me.chkAutoSend.UseVisualStyleBackColor = True
        '
        'chkHexR
        '
        Me.chkHexR.AutoSize = True
        Me.chkHexR.Checked = True
        Me.chkHexR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHexR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkHexR.Location = New System.Drawing.Point(4, 46)
        Me.chkHexR.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHexR.Name = "chkHexR"
        Me.chkHexR.Size = New System.Drawing.Size(172, 34)
        Me.chkHexR.TabIndex = 6
        Me.chkHexR.Text = "十六进制接收"
        Me.chkHexR.UseVisualStyleBackColor = True
        '
        'chkReadDelay
        '
        Me.chkReadDelay.AutoSize = True
        Me.chkReadDelay.Checked = True
        Me.chkReadDelay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReadDelay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkReadDelay.Location = New System.Drawing.Point(204, 4)
        Me.chkReadDelay.Margin = New System.Windows.Forms.Padding(4)
        Me.chkReadDelay.Name = "chkReadDelay"
        Me.chkReadDelay.Size = New System.Drawing.Size(172, 34)
        Me.chkReadDelay.TabIndex = 7
        Me.chkReadDelay.Text = "接收延迟等待（ms）"
        Me.chkReadDelay.UseVisualStyleBackColor = True
        '
        'numReadDelay
        '
        Me.numReadDelay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numReadDelay.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numReadDelay.Location = New System.Drawing.Point(384, 8)
        Me.numReadDelay.Margin = New System.Windows.Forms.Padding(4)
        Me.numReadDelay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numReadDelay.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numReadDelay.Name = "numReadDelay"
        Me.numReadDelay.Size = New System.Drawing.Size(92, 25)
        Me.numReadDelay.TabIndex = 8
        Me.numReadDelay.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'chkReflect
        '
        Me.chkReflect.AutoSize = True
        Me.chkReflect.Checked = True
        Me.chkReflect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReflect.Location = New System.Drawing.Point(4, 130)
        Me.chkReflect.Margin = New System.Windows.Forms.Padding(4)
        Me.chkReflect.Name = "chkReflect"
        Me.chkReflect.Size = New System.Drawing.Size(89, 19)
        Me.chkReflect.TabIndex = 1
        Me.chkReflect.Text = "反射模式"
        Me.chkReflect.UseVisualStyleBackColor = True
        Me.chkReflect.Visible = False
        '
        'tbSend
        '
        Me.tlpBottom.SetColumnSpan(Me.tbSend, 2)
        Me.tbSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSend.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbSend.Location = New System.Drawing.Point(204, 206)
        Me.tbSend.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSend.Name = "tbSend"
        Me.tbSend.Size = New System.Drawing.Size(727, 30)
        Me.tbSend.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSend.Location = New System.Drawing.Point(939, 206)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(92, 32)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "发送"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tlpPort)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(192, 194)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "串口设置"
        '
        'tlpPort
        '
        Me.tlpPort.ColumnCount = 2
        Me.tlpPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPort.Controls.Add(Me.Label1, 0, 0)
        Me.tlpPort.Controls.Add(Me.Label2, 0, 1)
        Me.tlpPort.Controls.Add(Me.Label3, 0, 2)
        Me.tlpPort.Controls.Add(Me.Label4, 0, 3)
        Me.tlpPort.Controls.Add(Me.Label5, 0, 4)
        Me.tlpPort.Controls.Add(Me.cbPortName, 1, 0)
        Me.tlpPort.Controls.Add(Me.cbPortBaud, 1, 1)
        Me.tlpPort.Controls.Add(Me.cbPortParity, 1, 2)
        Me.tlpPort.Controls.Add(Me.cbPortData, 1, 3)
        Me.tlpPort.Controls.Add(Me.cbPortStop, 1, 4)
        Me.tlpPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPort.Location = New System.Drawing.Point(4, 22)
        Me.tlpPort.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpPort.Name = "tlpPort"
        Me.tlpPort.RowCount = 5
        Me.tlpPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPort.Size = New System.Drawing.Size(184, 168)
        Me.tlpPort.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "串口号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "波特率"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "校验位"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "数据位"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "停止位"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPortName
        '
        Me.cbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortName.FormattingEnabled = True
        Me.cbPortName.Location = New System.Drawing.Point(74, 4)
        Me.cbPortName.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPortName.Name = "cbPortName"
        Me.cbPortName.Size = New System.Drawing.Size(96, 23)
        Me.cbPortName.TabIndex = 1
        '
        'cbPortBaud
        '
        Me.cbPortBaud.FormattingEnabled = True
        Me.cbPortBaud.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "76800", "115200", "128000", "153600", "230400", "256000", "307200", "460800", "614400", "921600", "1382400"})
        Me.cbPortBaud.Location = New System.Drawing.Point(74, 37)
        Me.cbPortBaud.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPortBaud.Name = "cbPortBaud"
        Me.cbPortBaud.Size = New System.Drawing.Size(96, 23)
        Me.cbPortBaud.TabIndex = 1
        '
        'cbPortParity
        '
        Me.cbPortParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortParity.FormattingEnabled = True
        Me.cbPortParity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.cbPortParity.Location = New System.Drawing.Point(74, 70)
        Me.cbPortParity.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPortParity.Name = "cbPortParity"
        Me.cbPortParity.Size = New System.Drawing.Size(96, 23)
        Me.cbPortParity.TabIndex = 1
        '
        'cbPortData
        '
        Me.cbPortData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortData.FormattingEnabled = True
        Me.cbPortData.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cbPortData.Location = New System.Drawing.Point(74, 103)
        Me.cbPortData.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPortData.Name = "cbPortData"
        Me.cbPortData.Size = New System.Drawing.Size(96, 23)
        Me.cbPortData.TabIndex = 1
        '
        'cbPortStop
        '
        Me.cbPortStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortStop.FormattingEnabled = True
        Me.cbPortStop.Items.AddRange(New Object() {"1", "2", "1.5"})
        Me.cbPortStop.Location = New System.Drawing.Point(74, 136)
        Me.cbPortStop.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPortStop.Name = "cbPortStop"
        Me.cbPortStop.Size = New System.Drawing.Size(96, 23)
        Me.cbPortStop.TabIndex = 1
        '
        'btnPortOpen
        '
        Me.btnPortOpen.Location = New System.Drawing.Point(4, 206)
        Me.btnPortOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPortOpen.Name = "btnPortOpen"
        Me.btnPortOpen.Size = New System.Drawing.Size(192, 32)
        Me.btnPortOpen.TabIndex = 2
        Me.btnPortOpen.Text = "打开串口"
        Me.btnPortOpen.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(703, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 196)
        Me.Panel2.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnMsgClear, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMsgSave, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMbTool, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTelTool, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(935, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(100, 202)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'btnMsgClear
        '
        Me.btnMsgClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMsgClear.Location = New System.Drawing.Point(4, 4)
        Me.btnMsgClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMsgClear.Name = "btnMsgClear"
        Me.btnMsgClear.Size = New System.Drawing.Size(92, 37)
        Me.btnMsgClear.TabIndex = 4
        Me.btnMsgClear.Text = "清空显示区"
        Me.btnMsgClear.UseVisualStyleBackColor = True
        '
        'btnMsgSave
        '
        Me.btnMsgSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMsgSave.Location = New System.Drawing.Point(4, 49)
        Me.btnMsgSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMsgSave.Name = "btnMsgSave"
        Me.btnMsgSave.Size = New System.Drawing.Size(92, 37)
        Me.btnMsgSave.TabIndex = 5
        Me.btnMsgSave.Text = "保存文件"
        Me.btnMsgSave.UseVisualStyleBackColor = True
        '
        'btnMbTool
        '
        Me.btnMbTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMbTool.Enabled = False
        Me.btnMbTool.Location = New System.Drawing.Point(4, 114)
        Me.btnMbTool.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMbTool.Name = "btnMbTool"
        Me.btnMbTool.Size = New System.Drawing.Size(92, 37)
        Me.btnMbTool.TabIndex = 7
        Me.btnMbTool.Text = "暂不可用"
        Me.btnMbTool.UseVisualStyleBackColor = True
        '
        'btnTelTool
        '
        Me.btnTelTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTelTool.Location = New System.Drawing.Point(4, 159)
        Me.btnTelTool.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTelTool.Name = "btnTelTool"
        Me.btnTelTool.Size = New System.Drawing.Size(92, 39)
        Me.btnTelTool.TabIndex = 7
        Me.btnTelTool.Text = "报文助手"
        Me.btnTelTool.UseVisualStyleBackColor = True
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 2
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tlpTop.Controls.Add(Me.tabTlg, 1, 0)
        Me.tlpTop.Controls.Add(Me.tbDisplay, 0, 0)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(3, 3)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 1
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 284.0!))
        Me.tlpTop.Size = New System.Drawing.Size(1037, 284)
        Me.tlpTop.TabIndex = 6
        '
        'tabTlg
        '
        Me.tabTlg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabTlg.Location = New System.Drawing.Point(640, 3)
        Me.tabTlg.Name = "tabTlg"
        Me.tabTlg.SelectedIndex = 0
        Me.tabTlg.Size = New System.Drawing.Size(394, 278)
        Me.tabTlg.TabIndex = 0
        '
        'tmAutoSend
        '
        '
        'sPort
        '
        Me.sPort.ParityReplace = CType(0, Byte)
        '
        'btnCountClear
        '
        Me.btnCountClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCountClear.IsLink = True
        Me.btnCountClear.Name = "btnCountClear"
        Me.btnCountClear.Size = New System.Drawing.Size(69, 20)
        Me.btnCountClear.Text = "清空计数"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel1.Text = "发送："
        '
        'lblTxC
        '
        Me.lblTxC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblTxC.Name = "lblTxC"
        Me.lblTxC.Size = New System.Drawing.Size(18, 20)
        Me.lblTxC.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel2.Text = "接收："
        '
        'lblRxC
        '
        Me.lblRxC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblRxC.Name = "lblRxC"
        Me.lblRxC.Size = New System.Drawing.Size(18, 20)
        Me.lblRxC.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripStatusLabel3.Text = "     "
        '
        'lblStatus
        '
        Me.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(781, 20)
        Me.lblStatus.Spring = True
        Me.lblStatus.Text = "工作状态"
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAbout.IsLink = True
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(39, 20)
        Me.btnAbout.Text = "关于"
        Me.btnAbout.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.btnAbout.Visible = False
        '
        'StS
        '
        Me.StS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCountClear, Me.ToolStripStatusLabel1, Me.lblTxC, Me.ToolStripStatusLabel2, Me.lblRxC, Me.ToolStripStatusLabel3, Me.lblStatus, Me.btnAbout})
        Me.StS.Location = New System.Drawing.Point(0, 540)
        Me.StS.Name = "StS"
        Me.StS.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StS.Size = New System.Drawing.Size(1043, 26)
        Me.StS.TabIndex = 6
        Me.StS.Text = "StatusStrip"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'frmSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 566)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.StS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1061, 613)
        Me.Name = "frmSerial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sunbreeze Serial Tool"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.tlpBottom.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.tlpSR.ResumeLayout(False)
        Me.tlpSR.PerformLayout()
        CType(Me.numAutoDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numReadDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.tlpPort.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpTop.PerformLayout()
        Me.StS.ResumeLayout(False)
        Me.StS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbDisplay As TextBox
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpPort As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbPortName As ComboBox
    Friend WithEvents cbPortBaud As ComboBox
    Friend WithEvents cbPortParity As ComboBox
    Friend WithEvents cbPortData As ComboBox
    Friend WithEvents cbPortStop As ComboBox
    Friend WithEvents btnPortOpen As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkAutoSend As CheckBox
    Friend WithEvents chkReflect As CheckBox
    Friend WithEvents chkHexS As CheckBox
    Friend WithEvents tlpBottom As TableLayoutPanel
    Friend WithEvents tbSend As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents numAutoDT As NumericUpDown
    Friend WithEvents btnMsgClear As Button
    Friend WithEvents tmAutoSend As Timer
    Friend WithEvents btnMsgSave As Button
    Friend WithEvents chkHexR As CheckBox
    Friend WithEvents btnTelTool As Button
    Friend WithEvents sPort As IO.Ports.SerialPort
    Friend WithEvents btnMbTool As Button
    Friend WithEvents StS As StatusStrip
    Friend WithEvents btnCountClear As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblTxC As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblRxC As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents btnAbout As ToolStripStatusLabel
    Friend WithEvents tlpSR As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tabTlg As TabControl
    Friend WithEvents tlpTop As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkReadDelay As CheckBox
    Friend WithEvents numReadDelay As NumericUpDown
    Friend WithEvents Timer1 As Timer
End Class
