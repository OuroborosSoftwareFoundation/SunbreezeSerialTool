<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTool_Base_Simple
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Base_Convert = New System.Windows.Forms.Button()
        Me.Base_grpFrom = New System.Windows.Forms.GroupBox()
        Me.Base_From16 = New System.Windows.Forms.RadioButton()
        Me.Base_From10 = New System.Windows.Forms.RadioButton()
        Me.Base_From = New System.Windows.Forms.TextBox()
        Me.Base_From8 = New System.Windows.Forms.RadioButton()
        Me.Base_From2 = New System.Windows.Forms.RadioButton()
        Me.Base_grpTo = New System.Windows.Forms.GroupBox()
        Me.Base_To16 = New System.Windows.Forms.RadioButton()
        Me.Base_To10 = New System.Windows.Forms.RadioButton()
        Me.Base_To = New System.Windows.Forms.TextBox()
        Me.Base_To8 = New System.Windows.Forms.RadioButton()
        Me.Base_To2 = New System.Windows.Forms.RadioButton()
        Me.Base_grpFrom.SuspendLayout()
        Me.Base_grpTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.Location = New System.Drawing.Point(33, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(350, 40)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "进制转换"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Base_Convert
        '
        Me.Base_Convert.Location = New System.Drawing.Point(33, 279)
        Me.Base_Convert.Name = "Base_Convert"
        Me.Base_Convert.Size = New System.Drawing.Size(350, 36)
        Me.Base_Convert.TabIndex = 60
        Me.Base_Convert.Text = "转换"
        Me.Base_Convert.UseVisualStyleBackColor = True
        '
        'Base_grpFrom
        '
        Me.Base_grpFrom.Controls.Add(Me.Base_From16)
        Me.Base_grpFrom.Controls.Add(Me.Base_From10)
        Me.Base_grpFrom.Controls.Add(Me.Base_From)
        Me.Base_grpFrom.Controls.Add(Me.Base_From8)
        Me.Base_grpFrom.Controls.Add(Me.Base_From2)
        Me.Base_grpFrom.Location = New System.Drawing.Point(21, 67)
        Me.Base_grpFrom.Name = "Base_grpFrom"
        Me.Base_grpFrom.Size = New System.Drawing.Size(350, 90)
        Me.Base_grpFrom.TabIndex = 63
        Me.Base_grpFrom.TabStop = False
        Me.Base_grpFrom.Text = "转换前"
        '
        'Base_From16
        '
        Me.Base_From16.AutoSize = True
        Me.Base_From16.Location = New System.Drawing.Point(249, 24)
        Me.Base_From16.Name = "Base_From16"
        Me.Base_From16.Size = New System.Drawing.Size(88, 19)
        Me.Base_From16.TabIndex = 62
        Me.Base_From16.Tag = "16"
        Me.Base_From16.Text = "十六进制"
        Me.Base_From16.UseVisualStyleBackColor = True
        '
        'Base_From10
        '
        Me.Base_From10.AutoSize = True
        Me.Base_From10.Checked = True
        Me.Base_From10.Location = New System.Drawing.Point(170, 24)
        Me.Base_From10.Name = "Base_From10"
        Me.Base_From10.Size = New System.Drawing.Size(73, 19)
        Me.Base_From10.TabIndex = 62
        Me.Base_From10.TabStop = True
        Me.Base_From10.Tag = "10"
        Me.Base_From10.Text = "十进制"
        Me.Base_From10.UseVisualStyleBackColor = True
        '
        'Base_From
        '
        Me.Base_From.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Base_From.Location = New System.Drawing.Point(12, 49)
        Me.Base_From.Name = "Base_From"
        Me.Base_From.Size = New System.Drawing.Size(320, 30)
        Me.Base_From.TabIndex = 62
        '
        'Base_From8
        '
        Me.Base_From8.AutoSize = True
        Me.Base_From8.Location = New System.Drawing.Point(91, 24)
        Me.Base_From8.Name = "Base_From8"
        Me.Base_From8.Size = New System.Drawing.Size(73, 19)
        Me.Base_From8.TabIndex = 62
        Me.Base_From8.Tag = "8"
        Me.Base_From8.Text = "八进制"
        Me.Base_From8.UseVisualStyleBackColor = True
        '
        'Base_From2
        '
        Me.Base_From2.AutoSize = True
        Me.Base_From2.Location = New System.Drawing.Point(12, 24)
        Me.Base_From2.Name = "Base_From2"
        Me.Base_From2.Size = New System.Drawing.Size(73, 19)
        Me.Base_From2.TabIndex = 62
        Me.Base_From2.Tag = "2"
        Me.Base_From2.Text = "二进制"
        Me.Base_From2.UseVisualStyleBackColor = True
        '
        'Base_grpTo
        '
        Me.Base_grpTo.Controls.Add(Me.Base_To16)
        Me.Base_grpTo.Controls.Add(Me.Base_To10)
        Me.Base_grpTo.Controls.Add(Me.Base_To)
        Me.Base_grpTo.Controls.Add(Me.Base_To8)
        Me.Base_grpTo.Controls.Add(Me.Base_To2)
        Me.Base_grpTo.Location = New System.Drawing.Point(33, 183)
        Me.Base_grpTo.Name = "Base_grpTo"
        Me.Base_grpTo.Size = New System.Drawing.Size(350, 90)
        Me.Base_grpTo.TabIndex = 64
        Me.Base_grpTo.TabStop = False
        Me.Base_grpTo.Text = "转换后"
        '
        'Base_To16
        '
        Me.Base_To16.AutoSize = True
        Me.Base_To16.Checked = True
        Me.Base_To16.Location = New System.Drawing.Point(249, 24)
        Me.Base_To16.Name = "Base_To16"
        Me.Base_To16.Size = New System.Drawing.Size(88, 19)
        Me.Base_To16.TabIndex = 62
        Me.Base_To16.TabStop = True
        Me.Base_To16.Tag = "16"
        Me.Base_To16.Text = "十六进制"
        Me.Base_To16.UseVisualStyleBackColor = True
        '
        'Base_To10
        '
        Me.Base_To10.AutoSize = True
        Me.Base_To10.Location = New System.Drawing.Point(170, 24)
        Me.Base_To10.Name = "Base_To10"
        Me.Base_To10.Size = New System.Drawing.Size(73, 19)
        Me.Base_To10.TabIndex = 62
        Me.Base_To10.Tag = "10"
        Me.Base_To10.Text = "十进制"
        Me.Base_To10.UseVisualStyleBackColor = True
        '
        'Base_To
        '
        Me.Base_To.BackColor = System.Drawing.SystemColors.Window
        Me.Base_To.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Base_To.Location = New System.Drawing.Point(12, 49)
        Me.Base_To.Name = "Base_To"
        Me.Base_To.ReadOnly = True
        Me.Base_To.Size = New System.Drawing.Size(320, 30)
        Me.Base_To.TabIndex = 62
        '
        'Base_To8
        '
        Me.Base_To8.AutoSize = True
        Me.Base_To8.Location = New System.Drawing.Point(91, 24)
        Me.Base_To8.Name = "Base_To8"
        Me.Base_To8.Size = New System.Drawing.Size(73, 19)
        Me.Base_To8.TabIndex = 62
        Me.Base_To8.Tag = "8"
        Me.Base_To8.Text = "八进制"
        Me.Base_To8.UseVisualStyleBackColor = True
        '
        'Base_To2
        '
        Me.Base_To2.AutoSize = True
        Me.Base_To2.Location = New System.Drawing.Point(12, 24)
        Me.Base_To2.Name = "Base_To2"
        Me.Base_To2.Size = New System.Drawing.Size(73, 19)
        Me.Base_To2.TabIndex = 62
        Me.Base_To2.Tag = "2"
        Me.Base_To2.Text = "二进制"
        Me.Base_To2.UseVisualStyleBackColor = True
        '
        'frmTool_Base_Simple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.Base_Convert)
        Me.Controls.Add(Me.Base_grpTo)
        Me.Controls.Add(Me.Base_grpFrom)
        Me.Controls.Add(Me.Label20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTool_Base_Simple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "工具"
        Me.Base_grpFrom.ResumeLayout(False)
        Me.Base_grpFrom.PerformLayout()
        Me.Base_grpTo.ResumeLayout(False)
        Me.Base_grpTo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label20 As Label
    Friend WithEvents Base_Convert As Button
    Friend WithEvents Base_grpFrom As GroupBox
    Friend WithEvents Base_From16 As RadioButton
    Friend WithEvents Base_From10 As RadioButton
    Friend WithEvents Base_From As TextBox
    Friend WithEvents Base_From8 As RadioButton
    Friend WithEvents Base_From2 As RadioButton
    Friend WithEvents Base_grpTo As GroupBox
    Friend WithEvents Base_To16 As RadioButton
    Friend WithEvents Base_To10 As RadioButton
    Friend WithEvents Base_To As TextBox
    Friend WithEvents Base_To8 As RadioButton
    Friend WithEvents Base_To2 As RadioButton
End Class
