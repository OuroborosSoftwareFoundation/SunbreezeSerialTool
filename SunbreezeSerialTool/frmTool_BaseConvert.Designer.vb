<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTool_BaseConvert
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.numOutputBase = New System.Windows.Forms.NumericUpDown()
        Me.numInputBase = New System.Windows.Forms.NumericUpDown()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnIB2 = New System.Windows.Forms.Button()
        Me.btnBI8 = New System.Windows.Forms.Button()
        Me.btnBI10 = New System.Windows.Forms.Button()
        Me.btnBI16 = New System.Windows.Forms.Button()
        Me.btnOB2 = New System.Windows.Forms.Button()
        Me.btnOB8 = New System.Windows.Forms.Button()
        Me.btnOB10 = New System.Windows.Forms.Button()
        Me.btnOB16 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.numOutputBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInputBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 40)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "输入数值"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConvert
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnConvert, 8)
        Me.btnConvert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConvert.Location = New System.Drawing.Point(3, 93)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(666, 44)
        Me.btnConvert.TabIndex = 75
        Me.btnConvert.Text = "转换"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'numOutputBase
        '
        Me.numOutputBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numOutputBase.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.numOutputBase.Location = New System.Drawing.Point(415, 55)
        Me.numOutputBase.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.numOutputBase.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numOutputBase.Name = "numOutputBase"
        Me.numOutputBase.Size = New System.Drawing.Size(94, 30)
        Me.numOutputBase.TabIndex = 73
        Me.numOutputBase.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'numInputBase
        '
        Me.numInputBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numInputBase.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.numInputBase.Location = New System.Drawing.Point(415, 15)
        Me.numInputBase.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.numInputBase.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numInputBase.Name = "numInputBase"
        Me.numInputBase.Size = New System.Drawing.Size(94, 30)
        Me.numInputBase.TabIndex = 74
        Me.numInputBase.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'tbOutput
        '
        Me.tbOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbOutput.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbOutput.Location = New System.Drawing.Point(103, 55)
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ReadOnly = True
        Me.tbOutput.Size = New System.Drawing.Size(226, 30)
        Me.tbOutput.TabIndex = 72
        '
        'tbInput
        '
        Me.tbInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbInput.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tbInput.Location = New System.Drawing.Point(103, 15)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(226, 30)
        Me.tbInput.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 40)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "转换结果"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(335, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 40)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "进制"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(335, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 40)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "进制"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIB2
        '
        Me.btnIB2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIB2.Location = New System.Drawing.Point(515, 13)
        Me.btnIB2.Name = "btnIB2"
        Me.btnIB2.Size = New System.Drawing.Size(34, 34)
        Me.btnIB2.TabIndex = 77
        Me.btnIB2.Text = "2"
        Me.btnIB2.UseVisualStyleBackColor = True
        '
        'btnBI8
        '
        Me.btnBI8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBI8.Location = New System.Drawing.Point(555, 13)
        Me.btnBI8.Name = "btnBI8"
        Me.btnBI8.Size = New System.Drawing.Size(34, 34)
        Me.btnBI8.TabIndex = 77
        Me.btnBI8.Text = "8"
        Me.btnBI8.UseVisualStyleBackColor = True
        '
        'btnBI10
        '
        Me.btnBI10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBI10.Location = New System.Drawing.Point(595, 13)
        Me.btnBI10.Name = "btnBI10"
        Me.btnBI10.Size = New System.Drawing.Size(34, 34)
        Me.btnBI10.TabIndex = 77
        Me.btnBI10.Text = "10"
        Me.btnBI10.UseVisualStyleBackColor = True
        '
        'btnBI16
        '
        Me.btnBI16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBI16.Location = New System.Drawing.Point(635, 13)
        Me.btnBI16.Name = "btnBI16"
        Me.btnBI16.Size = New System.Drawing.Size(34, 34)
        Me.btnBI16.TabIndex = 77
        Me.btnBI16.Text = "16"
        Me.btnBI16.UseVisualStyleBackColor = True
        '
        'btnOB2
        '
        Me.btnOB2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOB2.Location = New System.Drawing.Point(515, 53)
        Me.btnOB2.Name = "btnOB2"
        Me.btnOB2.Size = New System.Drawing.Size(34, 34)
        Me.btnOB2.TabIndex = 77
        Me.btnOB2.Text = "2"
        Me.btnOB2.UseVisualStyleBackColor = True
        '
        'btnOB8
        '
        Me.btnOB8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOB8.Location = New System.Drawing.Point(555, 53)
        Me.btnOB8.Name = "btnOB8"
        Me.btnOB8.Size = New System.Drawing.Size(34, 34)
        Me.btnOB8.TabIndex = 77
        Me.btnOB8.Text = "8"
        Me.btnOB8.UseVisualStyleBackColor = True
        '
        'btnOB10
        '
        Me.btnOB10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOB10.Location = New System.Drawing.Point(595, 53)
        Me.btnOB10.Name = "btnOB10"
        Me.btnOB10.Size = New System.Drawing.Size(34, 34)
        Me.btnOB10.TabIndex = 77
        Me.btnOB10.Text = "10"
        Me.btnOB10.UseVisualStyleBackColor = True
        '
        'btnOB16
        '
        Me.btnOB16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOB16.Location = New System.Drawing.Point(635, 53)
        Me.btnOB16.Name = "btnOB16"
        Me.btnOB16.Size = New System.Drawing.Size(34, 34)
        Me.btnOB16.TabIndex = 77
        Me.btnOB16.Text = "16"
        Me.btnOB16.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnConvert, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOB16, 7, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbInput, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOB10, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOB8, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBI16, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOB2, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbOutput, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBI10, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numInputBase, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBI8, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.numOutputBase, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIB2, 4, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(682, 153)
        Me.TableLayoutPanel1.TabIndex = 78
        '
        'frmTool_BaseConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 153)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTool_BaseConvert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBaseConvert"
        CType(Me.numOutputBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInputBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents numOutputBase As NumericUpDown
    Friend WithEvents numInputBase As NumericUpDown
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents tbInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIB2 As Button
    Friend WithEvents btnBI8 As Button
    Friend WithEvents btnBI10 As Button
    Friend WithEvents btnBI16 As Button
    Friend WithEvents btnOB2 As Button
    Friend WithEvents btnOB8 As Button
    Friend WithEvents btnOB10 As Button
    Friend WithEvents btnOB16 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
