'OuroborosPingTool

'   Copyright © 2020 Ouroboros Software Foundation. All rights reserved.
'   版权所有 © 2020 Ouroboros Software Foundation。保留所有权利。
'
'   本文件是OuroborosPingTool的一部分。

'   This program Is free software: you can redistribute it And/Or modify
'   it under the terms Of the GNU General Public License As published by
'   the Free Software Foundation, either version 3 Of the License, Or
'   (at your option) any later version.
'   本程序为自由软件， 在自由软件联盟发布的GNU通用公共许可协议的约束下，
'   你可以对其进行再发布及修改。协议版本为第三版或（随你）更新的版本。

'   This program Is distributed In the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty Of
'   MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE. See the
'   GNU General Public License For more details.
'   我们希望发布的这款程序有用，但不保证，甚至不保证它有经济价值和适合特定用途。
'   详情参见GNU通用公共许可协议。

'   You should have received a copy Of the GNU General Public License
'   along with this program.
'   If Not, see <https://www.gnu.org/licenses/>.
'   你理当已收到一份GNU通用公共许可协议的副本。
'   如果没有，请查阅 <http://www.gnu.org/licenses/> 

Imports System.IO

Public NotInheritable Class frmAbout

    Dim dtLic As New DataTable
    Dim isbusy As Boolean = True

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isbusy = True
        Me.Text = $"关于 {Application.ProductName}"
        lblProdName.Text = Application.ProductName
        lblVersion.Text = $"版本 {Application.ProductVersion}"
        lblCopyright.Text = $"{My.Application.Info.Copyright}{vbCrLf}All rights reserved."
        If Not File.Exists("gpl-3.0.txt") Then
            Dim sw As New StreamWriter("gpl-3.0.txt")
            sw.Write(My.Resources.gpl_3_0) '从资源文件恢复原版gpl
        End If
        dtLic = New DataTable
        dtLic.Columns.Add("Lang")
        dtLic.Columns.Add("File")
        dtLic.Rows.Add("English", "gpl-3.0.txt")
        If File.Exists("gpl-3.0_zh-CN.txt") Then
            dtLic.Rows.Add("简体中文", "gpl-3.0_zh-CN.txt")
        End If

        cbLang.ValueMember = "File"
        cbLang.DisplayMember = "Lang"
        cbLang.DataSource = dtLic
        isbusy = False
        cbLang.SelectedIndex = cbLang.Items.Count - 1
    End Sub

    Private Sub lblWebsite_LinkClicked(sender As LinkLabel, e As LinkLabelLinkClickedEventArgs) Handles lblWebsite.LinkClicked
        Process.Start(sender.Text)
    End Sub

    Private Sub cbLang_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbLang.SelectedIndexChanged
        If isbusy Then Exit Sub
        Dim sr As New StreamReader(sender.SelectedValue.ToString)
        tbLicense.Text = sr.ReadToEnd
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

End Class
