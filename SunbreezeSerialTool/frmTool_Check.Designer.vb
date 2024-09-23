<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTool_Check
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
        Me.tlpCheck = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbData = New System.Windows.Forms.TextBox()
        Me.tbCrcResult = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCRC = New System.Windows.Forms.Button()
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.chkOrder_LF = New System.Windows.Forms.RadioButton()
        Me.chkOrder_HF = New System.Windows.Forms.RadioButton()
        Me.TabCheck = New System.Windows.Forms.TabControl()
        Me.tpCRC = New System.Windows.Forms.TabPage()
        Me.tlpCRC = New System.Windows.Forms.TableLayoutPanel()
        Me.cbCrcType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkRevOut = New System.Windows.Forms.CheckBox()
        Me.tbXorOut = New System.Windows.Forms.TextBox()
        Me.tbInit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkRevIn = New System.Windows.Forms.CheckBox()
        Me.tbPoly = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tpOther = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbOtherType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tlpCheck.SuspendLayout()
        Me.grpOrder.SuspendLayout()
        Me.TabCheck.SuspendLayout()
        Me.tpCRC.SuspendLayout()
        Me.tlpCRC.SuspendLayout()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOther.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpCheck
        '
        Me.tlpCheck.ColumnCount = 4
        Me.tlpCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCheck.Controls.Add(Me.Label1, 0, 0)
        Me.tlpCheck.Controls.Add(Me.tbData, 1, 0)
        Me.tlpCheck.Controls.Add(Me.tbCrcResult, 1, 2)
        Me.tlpCheck.Controls.Add(Me.Label7, 0, 2)
        Me.tlpCheck.Controls.Add(Me.btnCRC, 3, 3)
        Me.tlpCheck.Controls.Add(Me.grpOrder, 0, 3)
        Me.tlpCheck.Controls.Add(Me.TabCheck, 0, 1)
        Me.tlpCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCheck.Location = New System.Drawing.Point(0, 0)
        Me.tlpCheck.Name = "tlpCheck"
        Me.tlpCheck.RowCount = 4
        Me.tlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpCheck.Size = New System.Drawing.Size(682, 353)
        Me.tlpCheck.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 63)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "原始数据"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbData
        '
        Me.tlpCheck.SetColumnSpan(Me.tbData, 3)
        Me.tbData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbData.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbData.Location = New System.Drawing.Point(103, 3)
        Me.tbData.Multiline = True
        Me.tbData.Name = "tbData"
        Me.tbData.Size = New System.Drawing.Size(576, 57)
        Me.tbData.TabIndex = 0
        '
        'tbCrcResult
        '
        Me.tbCrcResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpCheck.SetColumnSpan(Me.tbCrcResult, 3)
        Me.tbCrcResult.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbCrcResult.Location = New System.Drawing.Point(103, 268)
        Me.tbCrcResult.Name = "tbCrcResult"
        Me.tbCrcResult.ReadOnly = True
        Me.tbCrcResult.Size = New System.Drawing.Size(576, 30)
        Me.tbCrcResult.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 40)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "校验结果"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCRC
        '
        Me.btnCRC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCRC.Location = New System.Drawing.Point(449, 306)
        Me.btnCRC.Name = "btnCRC"
        Me.btnCRC.Size = New System.Drawing.Size(230, 44)
        Me.btnCRC.TabIndex = 8
        Me.btnCRC.Text = "生成"
        Me.btnCRC.UseVisualStyleBackColor = True
        '
        'grpOrder
        '
        Me.tlpCheck.SetColumnSpan(Me.grpOrder, 2)
        Me.grpOrder.Controls.Add(Me.chkOrder_LF)
        Me.grpOrder.Controls.Add(Me.chkOrder_HF)
        Me.grpOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOrder.Location = New System.Drawing.Point(3, 306)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(330, 44)
        Me.grpOrder.TabIndex = 20
        Me.grpOrder.TabStop = False
        Me.grpOrder.Text = "字节顺序"
        '
        'chkOrder_LF
        '
        Me.chkOrder_LF.AutoSize = True
        Me.chkOrder_LF.Location = New System.Drawing.Point(164, 19)
        Me.chkOrder_LF.Name = "chkOrder_LF"
        Me.chkOrder_LF.Size = New System.Drawing.Size(103, 19)
        Me.chkOrder_LF.TabIndex = 1
        Me.chkOrder_LF.Text = "低字节在前"
        Me.chkOrder_LF.UseVisualStyleBackColor = True
        '
        'chkOrder_HF
        '
        Me.chkOrder_HF.AutoSize = True
        Me.chkOrder_HF.Checked = True
        Me.chkOrder_HF.Location = New System.Drawing.Point(32, 19)
        Me.chkOrder_HF.Name = "chkOrder_HF"
        Me.chkOrder_HF.Size = New System.Drawing.Size(103, 19)
        Me.chkOrder_HF.TabIndex = 0
        Me.chkOrder_HF.TabStop = True
        Me.chkOrder_HF.Text = "高字节在前"
        Me.chkOrder_HF.UseVisualStyleBackColor = True
        '
        'TabCheck
        '
        Me.tlpCheck.SetColumnSpan(Me.TabCheck, 4)
        Me.TabCheck.Controls.Add(Me.tpCRC)
        Me.TabCheck.Controls.Add(Me.tpOther)
        Me.TabCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCheck.Location = New System.Drawing.Point(3, 66)
        Me.TabCheck.Name = "TabCheck"
        Me.TabCheck.SelectedIndex = 0
        Me.TabCheck.Size = New System.Drawing.Size(676, 194)
        Me.TabCheck.TabIndex = 21
        '
        'tpCRC
        '
        Me.tpCRC.Controls.Add(Me.tlpCRC)
        Me.tpCRC.Location = New System.Drawing.Point(4, 25)
        Me.tpCRC.Name = "tpCRC"
        Me.tpCRC.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCRC.Size = New System.Drawing.Size(668, 165)
        Me.tpCRC.TabIndex = 0
        Me.tpCRC.Text = "CRC校验"
        Me.tpCRC.UseVisualStyleBackColor = True
        '
        'tlpCRC
        '
        Me.tlpCRC.ColumnCount = 4
        Me.tlpCRC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpCRC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCRC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpCRC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCRC.Controls.Add(Me.cbCrcType, 1, 0)
        Me.tlpCRC.Controls.Add(Me.Label3, 0, 1)
        Me.tlpCRC.Controls.Add(Me.chkRevOut, 3, 3)
        Me.tlpCRC.Controls.Add(Me.tbXorOut, 3, 2)
        Me.tlpCRC.Controls.Add(Me.tbInit, 1, 2)
        Me.tlpCRC.Controls.Add(Me.Label6, 2, 2)
        Me.tlpCRC.Controls.Add(Me.Label5, 0, 2)
        Me.tlpCRC.Controls.Add(Me.Label9, 2, 3)
        Me.tlpCRC.Controls.Add(Me.chkRevIn, 1, 3)
        Me.tlpCRC.Controls.Add(Me.tbPoly, 3, 1)
        Me.tlpCRC.Controls.Add(Me.Label8, 0, 3)
        Me.tlpCRC.Controls.Add(Me.numWidth, 1, 1)
        Me.tlpCRC.Controls.Add(Me.Label4, 2, 1)
        Me.tlpCRC.Controls.Add(Me.Label2, 0, 0)
        Me.tlpCRC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCRC.Location = New System.Drawing.Point(3, 3)
        Me.tlpCRC.Name = "tlpCRC"
        Me.tlpCRC.RowCount = 4
        Me.tlpCRC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCRC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCRC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCRC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCRC.Size = New System.Drawing.Size(662, 159)
        Me.tlpCRC.TabIndex = 0
        '
        'cbCrcType
        '
        Me.cbCrcType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpCRC.SetColumnSpan(Me.cbCrcType, 3)
        Me.cbCrcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCrcType.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.cbCrcType.FormattingEnabled = True
        Me.cbCrcType.Location = New System.Drawing.Point(103, 5)
        Me.cbCrcType.Name = "cbCrcType"
        Me.cbCrcType.Size = New System.Drawing.Size(556, 28)
        Me.cbCrcType.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 39)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "宽度"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkRevOut
        '
        Me.chkRevOut.AutoSize = True
        Me.chkRevOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkRevOut.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.chkRevOut.Location = New System.Drawing.Point(439, 120)
        Me.chkRevOut.Name = "chkRevOut"
        Me.chkRevOut.Size = New System.Drawing.Size(220, 36)
        Me.chkRevOut.TabIndex = 7
        Me.chkRevOut.UseVisualStyleBackColor = True
        '
        'tbXorOut
        '
        Me.tbXorOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbXorOut.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbXorOut.Location = New System.Drawing.Point(439, 82)
        Me.tbXorOut.Name = "tbXorOut"
        Me.tbXorOut.Size = New System.Drawing.Size(220, 30)
        Me.tbXorOut.TabIndex = 5
        '
        'tbInit
        '
        Me.tbInit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbInit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbInit.Location = New System.Drawing.Point(103, 82)
        Me.tbInit.Name = "tbInit"
        Me.tbInit.Size = New System.Drawing.Size(220, 30)
        Me.tbInit.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(329, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 39)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "输出异或值"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 39)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "初始值"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(329, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 42)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "输出反转"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkRevIn
        '
        Me.chkRevIn.AutoSize = True
        Me.chkRevIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkRevIn.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.chkRevIn.Location = New System.Drawing.Point(103, 120)
        Me.chkRevIn.Name = "chkRevIn"
        Me.chkRevIn.Size = New System.Drawing.Size(220, 36)
        Me.chkRevIn.TabIndex = 6
        Me.chkRevIn.UseVisualStyleBackColor = True
        '
        'tbPoly
        '
        Me.tbPoly.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPoly.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbPoly.Location = New System.Drawing.Point(439, 43)
        Me.tbPoly.Name = "tbPoly"
        Me.tbPoly.Size = New System.Drawing.Size(220, 30)
        Me.tbPoly.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(3, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 42)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "输入反转"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'numWidth
        '
        Me.numWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numWidth.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.numWidth.Location = New System.Drawing.Point(103, 43)
        Me.numWidth.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(220, 30)
        Me.numWidth.TabIndex = 2
        Me.numWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(329, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 39)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "多项式"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 39)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CRC类型"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tpOther
        '
        Me.tpOther.Controls.Add(Me.TableLayoutPanel1)
        Me.tpOther.Location = New System.Drawing.Point(4, 25)
        Me.tpOther.Name = "tpOther"
        Me.tpOther.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOther.Size = New System.Drawing.Size(668, 165)
        Me.tpOther.TabIndex = 1
        Me.tpOther.Text = "其他校验"
        Me.tpOther.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbOtherType, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(662, 159)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'cbOtherType
        '
        Me.cbOtherType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOtherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOtherType.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.cbOtherType.FormattingEnabled = True
        Me.cbOtherType.Location = New System.Drawing.Point(143, 65)
        Me.cbOtherType.Name = "cbOtherType"
        Me.cbOtherType.Size = New System.Drawing.Size(496, 28)
        Me.cbOtherType.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(23, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 40)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "校验类型"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmTool_Check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 353)
        Me.Controls.Add(Me.tlpCheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTool_Check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sunbreeze Telegram Tool"
        Me.tlpCheck.ResumeLayout(False)
        Me.tlpCheck.PerformLayout()
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        Me.TabCheck.ResumeLayout(False)
        Me.tpCRC.ResumeLayout(False)
        Me.tlpCRC.ResumeLayout(False)
        Me.tlpCRC.PerformLayout()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOther.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkRevOut As CheckBox
    Friend WithEvents chkRevIn As CheckBox
    Friend WithEvents tbXorOut As TextBox
    Friend WithEvents tbInit As TextBox
    Friend WithEvents tbPoly As TextBox
    Friend WithEvents numWidth As NumericUpDown
    Friend WithEvents cbCrcType As ComboBox
    Friend WithEvents tbData As TextBox
    Friend WithEvents tbCrcResult As TextBox
    Friend WithEvents btnCRC As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tlpCheck As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents chkOrder_LF As RadioButton
    Friend WithEvents chkOrder_HF As RadioButton
    Friend WithEvents TabCheck As TabControl
    Friend WithEvents tpCRC As TabPage
    Friend WithEvents tpOther As TabPage
    Friend WithEvents tlpCRC As TableLayoutPanel
    Friend WithEvents cbOtherType As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label10 As Label
End Class
