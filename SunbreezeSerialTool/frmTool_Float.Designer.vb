<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTool_Float
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbDEC = New System.Windows.Forms.TextBox()
        Me.tbHEX = New System.Windows.Forms.TextBox()
        Me.cbFpType = New System.Windows.Forms.ComboBox()
        Me.numLen = New System.Windows.Forms.NumericUpDown()
        Me.numExp = New System.Windows.Forms.NumericUpDown()
        Me.btnHexToDec = New System.Windows.Forms.Button()
        Me.tbFra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkSign = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDecToHex = New System.Windows.Forms.Button()
        CType(Me.numLen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numExp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(13, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 40)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "十进制"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(13, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 40)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "十六进制"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbDEC
        '
        Me.tbDEC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbDEC, 3)
        Me.tbDEC.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbDEC.Location = New System.Drawing.Point(113, 175)
        Me.tbDEC.Name = "tbDEC"
        Me.tbDEC.Size = New System.Drawing.Size(374, 30)
        Me.tbDEC.TabIndex = 72
        '
        'tbHEX
        '
        Me.tbHEX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbHEX, 3)
        Me.tbHEX.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbHEX.Location = New System.Drawing.Point(113, 135)
        Me.tbHEX.Name = "tbHEX"
        Me.tbHEX.Size = New System.Drawing.Size(374, 30)
        Me.tbHEX.TabIndex = 71
        '
        'cbFpType
        '
        Me.cbFpType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbFpType, 3)
        Me.cbFpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFpType.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.cbFpType.FormattingEnabled = True
        Me.cbFpType.Location = New System.Drawing.Point(113, 16)
        Me.cbFpType.Name = "cbFpType"
        Me.cbFpType.Size = New System.Drawing.Size(374, 28)
        Me.cbFpType.TabIndex = 74
        '
        'numLen
        '
        Me.numLen.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numLen.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.numLen.Location = New System.Drawing.Point(113, 55)
        Me.numLen.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
        Me.numLen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numLen.Name = "numLen"
        Me.numLen.Size = New System.Drawing.Size(134, 30)
        Me.numLen.TabIndex = 75
        Me.numLen.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numExp
        '
        Me.numExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numExp.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.numExp.Location = New System.Drawing.Point(113, 95)
        Me.numExp.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        Me.numExp.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numExp.Name = "numExp"
        Me.numExp.Size = New System.Drawing.Size(134, 30)
        Me.numExp.TabIndex = 76
        Me.numExp.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnHexToDec
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnHexToDec, 2)
        Me.btnHexToDec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHexToDec.Location = New System.Drawing.Point(13, 213)
        Me.btnHexToDec.Name = "btnHexToDec"
        Me.btnHexToDec.Size = New System.Drawing.Size(234, 44)
        Me.btnHexToDec.TabIndex = 78
        Me.btnHexToDec.Text = "转换" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "十六进制 -> 十进制"
        Me.btnHexToDec.UseVisualStyleBackColor = True
        '
        'tbFra
        '
        Me.tbFra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFra.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbFra.Location = New System.Drawing.Point(353, 95)
        Me.tbFra.Name = "tbFra"
        Me.tbFra.ReadOnly = True
        Me.tbFra.Size = New System.Drawing.Size(134, 30)
        Me.tbFra.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 40)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "浮点类型"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 40)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "长度"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 40)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "阶码位"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(253, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 40)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "有效数位"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSign
        '
        Me.chkSign.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSign.AutoSize = True
        Me.chkSign.Checked = True
        Me.chkSign.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSign.Enabled = False
        Me.chkSign.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.chkSign.Location = New System.Drawing.Point(353, 61)
        Me.chkSign.Name = "chkSign"
        Me.chkSign.Size = New System.Drawing.Size(134, 17)
        Me.chkSign.TabIndex = 81
        Me.chkSign.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(253, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 40)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "符号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbFpType, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnHexToDec, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDEC, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbHEX, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chkSign, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numExp, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFra, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numLen, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDecToHex, 3, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(500, 270)
        Me.TableLayoutPanel1.TabIndex = 83
        '
        'btnDecToHex
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnDecToHex, 2)
        Me.btnDecToHex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDecToHex.Location = New System.Drawing.Point(253, 213)
        Me.btnDecToHex.Name = "btnDecToHex"
        Me.btnDecToHex.Size = New System.Drawing.Size(234, 44)
        Me.btnDecToHex.TabIndex = 83
        Me.btnDecToHex.Text = "转换" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "十进制 -> 十六进制"
        Me.btnDecToHex.UseVisualStyleBackColor = True
        '
        'frmTool_Float
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 270)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTool_Float"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmTool_Float"
        CType(Me.numLen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numExp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbDEC As TextBox
    Friend WithEvents tbHEX As TextBox
    Friend WithEvents cbFpType As ComboBox
    Friend WithEvents numLen As NumericUpDown
    Friend WithEvents numExp As NumericUpDown
    Friend WithEvents btnHexToDec As Button
    Friend WithEvents tbFra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkSign As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDecToHex As Button
End Class
