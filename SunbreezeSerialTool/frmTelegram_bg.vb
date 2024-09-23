Public Class frmTelegram_bg

    Private Sub frmTelegramTool_bg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Screen.PrimaryScreen.Bounds.Height - Me.Height - 60
        Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width
    End Sub

    Private Sub frmTelegramTool_bg_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmTelegram.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmTelegram.Show()
        frmTelegram.tmMonitor.Stop()
    End Sub

    Private Sub tmBlink_Tick(sender As Object, e As EventArgs) Handles tmBlink.Tick
        Me.BackColor = Color.LightGray
    End Sub

    Friend Sub Blink()
        Me.BackColor = Color.Red
        tmBlink.Start()
    End Sub

    Private Sub tbMsg_TextChanged(sender As TextBox, e As EventArgs) Handles tbMsg.Click
        Clipboard.SetText(sender.Text)
    End Sub

End Class