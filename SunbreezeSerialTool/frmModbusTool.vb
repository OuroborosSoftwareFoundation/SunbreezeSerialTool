Imports System.IO

Public Class frmModbusTool
    Dim fn As String = vbNullString
    Dim dt As New DataTable

    Private Sub AdvFnc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chk As New CheckBox
        Dim h As New ToolStripControlHost(chk)
        dt.Columns.Add("msg")
        dt.Columns.Add("fc")
        dt.Columns.Add("d1")
        dt.Columns.Add("d2")
        Me.Left = frmSerial.Left + frmSerial.Width - Me.Width
        Me.Top = frmSerial.Top
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "打开协议文件"
            .Filter = "协议文件(*.csv)|*.csv"
            .Multiselect = False
            If .ShowDialog() = DialogResult.OK Then
                dt.Clear()
                fn = .FileName
                Dim sr As New StreamReader(.FileName)
                Do Until sr.EndOfStream
                    Dim rl As String = sr.ReadLine
                    Dim ad() As String = rl.Split(","c)
                    dt.Rows.Add(ad)
                Loop
            End If
        End With
        dgv.DataSource = dt
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dts As New DataTable
        dts = dgv.DataSource
        Dim sfd As New SaveFileDialog
        With sfd
            .Title = "保存协议文件"
            .Filter = "协议文件(*.csv)|*.csv"
            If .ShowDialog() = DialogResult.OK Then
                Dim sw As New StreamWriter(.FileName)
                For i = 0 To dts.Rows.Count - 1
                    sw.WriteLine(Join(dt.Rows(i).ItemArray, ","))
                Next
                sw.Close()
            End If
        End With
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not frmSerial.sPort.IsOpen Then frmSerial.sPort.Open()
        Try
            For i = numL.Value To numH.Value
                For Each r As DataGridViewRow In dgv.Rows
                    If r.Selected Then
                        Dim adr As String = DEC_to_HEX(i).PadLeft(2, "0"c)
                        Dim fnc As String = DEC_to_HEX(Convert.ToInt32(r.Cells(1).Value.ToString)).PadLeft(2, "0"c)
                        Dim d1 As String = DEC_to_HEX(Convert.ToInt32(r.Cells(2).Value.ToString)).PadLeft(4, "0"c)
                        Dim d2 As String = DEC_to_HEX(Convert.ToInt32(r.Cells(3).Value.ToString)).PadLeft(4, "0"c)
                        frmSerial.tbSend.Text = $"{adr} {fnc} {d1} {d2}"
                        frmSerial.chkReflect.Checked = True
                        frmSerial.BtnSend_Click(Nothing, Nothing)
                    End If
                    Threading.Thread.Sleep(100)
                    Application.DoEvents()
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class