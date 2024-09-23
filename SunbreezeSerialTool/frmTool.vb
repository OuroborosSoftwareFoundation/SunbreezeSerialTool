Public Class frmTool

    Private Sub frmTool_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = $"Sunbreeze Toolbox  v{My.Application.Info.Version}"
        ShowSubForm(frmTool_BaseConvert)
    End Sub

    Private Sub btnBaseConvert_Click(sender As Object, e As EventArgs) Handles btnBaseConvert.Click
        ShowSubForm(frmTool_BaseConvert)
    End Sub

    Private Sub btnFloat_Click(sender As Object, e As EventArgs) Handles btnFloat.Click
        ShowSubForm(frmTool_Float)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ShowSubForm(frmTool_Check)
    End Sub

    Private Sub ShowSubForm(f As Form)
        f.MdiParent = Me
        f.Parent = pnlMain
        f.BringToFront()
        f.Dock = DockStyle.Fill
        f.Show()
    End Sub

End Class