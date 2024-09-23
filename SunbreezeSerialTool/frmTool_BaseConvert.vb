Public Class frmTool_BaseConvert

    Private Sub frmTool_BaseConvert_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        tbOutput.Clear()
        tbOutput.Text = BaseConvert_AnyToAny(tbInput.Text, numInputBase.Value, numOutputBase.Value)
    End Sub

    Private Sub btnIB2_Click(sender As Object, e As EventArgs) Handles btnIB2.Click
        numInputBase.Value = 2
    End Sub

    Private Sub btnBI8_Click(sender As Object, e As EventArgs) Handles btnBI8.Click
        numInputBase.Value = 8
    End Sub

    Private Sub btnBI10_Click(sender As Object, e As EventArgs) Handles btnBI10.Click
        numInputBase.Value = 10
    End Sub

    Private Sub btnBI16_Click(sender As Object, e As EventArgs) Handles btnBI16.Click
        numInputBase.Value = 16
    End Sub

    Private Sub btnOB2_Click(sender As Object, e As EventArgs) Handles btnOB2.Click
        numOutputBase.Value = 2
    End Sub

    Private Sub btnOB8_Click(sender As Object, e As EventArgs) Handles btnOB8.Click
        numOutputBase.Value = 8
    End Sub

    Private Sub btnOB10_Click(sender As Object, e As EventArgs) Handles btnOB10.Click
        numOutputBase.Value = 10
    End Sub

    Private Sub btnOB16_Click(sender As Object, e As EventArgs) Handles btnOB16.Click
        numOutputBase.Value = 16
    End Sub

End Class