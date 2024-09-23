<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.tbLicense = New System.Windows.Forms.TextBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picGPL = New System.Windows.Forms.PictureBox()
        Me.cbLang = New System.Windows.Forms.ComboBox()
        Me.lblWebsite = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tlpTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCopyRight = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpTitle.SuspendLayout()
        Me.tlpCopyRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(281, 596)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 44)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "确定"
        '
        'tbLicense
        '
        Me.tbLicense.BackColor = System.Drawing.SystemColors.Window
        Me.tbLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLicense.Location = New System.Drawing.Point(8, 233)
        Me.tbLicense.Margin = New System.Windows.Forms.Padding(8, 3, 4, 3)
        Me.tbLicense.Multiline = True
        Me.tbLicense.Name = "tbLicense"
        Me.tbLicense.ReadOnly = True
        Me.tbLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLicense.Size = New System.Drawing.Size(650, 307)
        Me.tbLicense.TabIndex = 0
        Me.tbLicense.TabStop = False
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tbLicense, 0, 3)
        Me.tlpMain.Controls.Add(Me.btnOK, 0, 5)
        Me.tlpMain.Controls.Add(Me.lblWebsite, 0, 1)
        Me.tlpMain.Controls.Add(Me.Label2, 0, 4)
        Me.tlpMain.Controls.Add(Me.tlpCopyRight, 0, 2)
        Me.tlpMain.Controls.Add(Me.tlpTitle, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(10, 5)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 6
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpMain.Size = New System.Drawing.Size(662, 643)
        Me.tlpMain.TabIndex = 0
        '
        'lblProdName
        '
        Me.lblProdName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProdName.Font = New System.Drawing.Font("微软雅黑", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblProdName.Location = New System.Drawing.Point(153, 0)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(500, 74)
        Me.lblProdName.TabIndex = 1
        Me.lblProdName.Text = "SunbreezeSerialTool"
        Me.lblProdName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblVersion
        '
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Location = New System.Drawing.Point(153, 74)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(500, 30)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopyright
        '
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCopyright.Location = New System.Drawing.Point(3, 0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(500, 54)
        Me.lblCopyright.TabIndex = 3
        Me.lblCopyright.Text = "Copyright © 2019-2024 Ouroboros Software Foundation. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved."
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picLogo.Image = Global.SunbreezeSerialTool.My.Resources.Resources.OSF_logo_256
        Me.picLogo.Location = New System.Drawing.Point(3, 3)
        Me.picLogo.Name = "picLogo"
        Me.tlpTitle.SetRowSpan(Me.picLogo, 2)
        Me.picLogo.Size = New System.Drawing.Size(144, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "软件许可证："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picGPL
        '
        Me.picGPL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picGPL.Image = Global.SunbreezeSerialTool.My.Resources.Resources.gplv3_or_later
        Me.picGPL.Location = New System.Drawing.Point(509, 3)
        Me.picGPL.Name = "picGPL"
        Me.picGPL.Size = New System.Drawing.Size(144, 48)
        Me.picGPL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGPL.TabIndex = 6
        Me.picGPL.TabStop = False
        '
        'cbLang
        '
        Me.cbLang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLang.FormattingEnabled = True
        Me.cbLang.Items.AddRange(New Object() {"English", "简体中文"})
        Me.cbLang.Location = New System.Drawing.Point(509, 57)
        Me.cbLang.Name = "cbLang"
        Me.cbLang.Size = New System.Drawing.Size(144, 23)
        Me.cbLang.TabIndex = 7
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWebsite.Location = New System.Drawing.Point(3, 110)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(656, 30)
        Me.lblWebsite.TabIndex = 8
        Me.lblWebsite.TabStop = True
        Me.lblWebsite.Text = "https://github.com/OuroborosSoftwareFoundation/SunbreezeSerialTool"
        Me.lblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 543)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(656, 50)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "This software is only released on GitHub." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "该软件仅在GitHub上发布。"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTitle
        '
        Me.tlpTitle.ColumnCount = 2
        Me.tlpTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTitle.Controls.Add(Me.picLogo, 0, 0)
        Me.tlpTitle.Controls.Add(Me.lblProdName, 1, 0)
        Me.tlpTitle.Controls.Add(Me.lblVersion, 1, 1)
        Me.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTitle.Location = New System.Drawing.Point(3, 3)
        Me.tlpTitle.Name = "tlpTitle"
        Me.tlpTitle.RowCount = 2
        Me.tlpTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTitle.Size = New System.Drawing.Size(656, 104)
        Me.tlpTitle.TabIndex = 10
        '
        'tlpCopyRight
        '
        Me.tlpCopyRight.ColumnCount = 2
        Me.tlpCopyRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCopyRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpCopyRight.Controls.Add(Me.picGPL, 1, 0)
        Me.tlpCopyRight.Controls.Add(Me.cbLang, 1, 1)
        Me.tlpCopyRight.Controls.Add(Me.lblCopyright, 0, 0)
        Me.tlpCopyRight.Controls.Add(Me.Label1, 0, 1)
        Me.tlpCopyRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCopyRight.Location = New System.Drawing.Point(3, 143)
        Me.tlpCopyRight.Name = "tlpCopyRight"
        Me.tlpCopyRight.RowCount = 2
        Me.tlpCopyRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCopyRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCopyRight.Size = New System.Drawing.Size(656, 84)
        Me.tlpCopyRight.TabIndex = 11
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(682, 653)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "关于"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpTitle.ResumeLayout(False)
        Me.tlpCopyRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents tbLicense As TextBox
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents lblProdName As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picGPL As PictureBox
    Friend WithEvents cbLang As ComboBox
    Friend WithEvents lblWebsite As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents tlpTitle As TableLayoutPanel
    Friend WithEvents tlpCopyRight As TableLayoutPanel
End Class
