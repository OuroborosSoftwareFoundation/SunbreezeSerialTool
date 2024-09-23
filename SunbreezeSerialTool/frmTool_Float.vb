Public Class frmTool_Float

    Dim IsBusy As Boolean = True
    Dim dtFP As New DataTable

    Private Sub frmTool_Float_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = $"Sunbreeze Float Tool  v{My.Application.Info.Version}"
        FpTableInit()
        With cbFpType
            .Items.Clear()
            .ValueMember = "id"
            .DisplayMember = "FpName"
            .DataSource = dtFP
            If .Items.Count > 3 Then .SelectedIndex = 0
        End With
        isBusy = False
    End Sub

    Private Sub cbFpType_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbFpType.SelectedIndexChanged
        If sender.SelectedIndex < 0 Then Exit Sub
        IsBusy = True
        Dim dr As DataRow = dtFP(sender.SelectedIndex)
        numLen.Value = dr("Length")
        numExp.Value = dr("Exponent")
        IsBusy = False
    End Sub

    Private Sub num_ValueChanged(sender As Object, e As EventArgs) Handles numLen.ValueChanged, numExp.ValueChanged
        tbFra.Text = (numLen.Value - 1 - numExp.Value).ToString
        If IsBusy Then Exit Sub
        cbFpType.SelectedIndex = -1
    End Sub

    Private Sub btnHexToDec_Click(sender As Object, e As EventArgs) Handles btnHexToDec.Click
        tbDEC.Clear()
        Try
            tbDEC.Text = FloatP_HexToDec(tbHEX.Text, numLen.Value, numExp.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbDEC.Clear()
        End Try
    End Sub

    Private Sub btnDecToHex_Click(sender As Object, e As EventArgs) Handles btnDecToHex.Click
        tbHEX.Clear()
        Try
            tbHEX.Text = FloatP_DecToHex(tbDEC.Text, numLen.Value, numExp.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHEX.Clear()
        End Try
    End Sub

    Private Sub Float_Convert_Click(sender As Object, e As EventArgs)
        'If tbHEX.Text.Trim = "" Then Exit Sub
        'If Float_32P.Checked Then
        '    tbDEC.Text = IEEE754_Dec(tbHEX.Text)
        'Else
        '    tbDEC.Text = IEEE754_Dec(tbHEX.Text, 64)
        'End If
    End Sub

    Private Sub FpTableInit()
        dtFP = New DataTable
        dtFP.Columns.Add("id", GetType(Integer))
        dtFP.Columns.Add("FpName", GetType(String))
        dtFP.Columns.Add("Length", GetType(UInteger))
        dtFP.Columns.Add("Exponent", GetType(UInteger))
        If Not IO.File.Exists("floatpoint.csv") Then
            Dim csv As String = My.Resources.floatpoint
            Using sw As New IO.StreamWriter("floatpoint.csv", False, System.Text.Encoding.UTF8)
                sw.Write(csv)
            End Using
        End If
        Dim sr As New IO.StreamReader("floatpoint.csv", System.Text.Encoding.UTF8)
        sr.ReadLine() '读出标题行
        Do Until sr.EndOfStream
            Dim l As String = sr.ReadLine
            If l = vbNullString Then Continue Do
            Dim c() As String = l.Split(","c)
            Dim fpname As String = c(0)
            Dim len As String = Convert.ToUInt32(c(1), 10)
            Dim exp As UInteger = Convert.ToUInt32(c(2), 10)
            dtFP.Rows.Add(dtFP.Rows.Count, fpname, len, exp)
        Loop
    End Sub

End Class