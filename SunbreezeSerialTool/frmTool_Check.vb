Public Class frmTool_Check

    Dim IsBusy As Boolean = True
    Dim dtCRC As New DataTable
    Dim dtOther As New DataTable

    Private Sub frmCheckTool_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = $"Sunbreeze Check Tool  v{My.Application.Info.Version}"
        CrcTableInit()
        With cbCrcType
            .Items.Clear()
            .ValueMember = "id"
            .DisplayMember = "CrcName"
            .DataSource = dtCRC
            If .Items.Count > 0 Then .SelectedIndex = 0
        End With
        OtherTableInit()
        With cbOtherType
            .Items.Clear()
            .ValueMember = "id"
            .DisplayMember = "des"
            .DataSource = dtOther
            If .Items.Count > 0 Then .SelectedIndex = 0
        End With
        IsBusy = False
    End Sub

    Private Sub cbCrcType_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbCrcType.SelectedIndexChanged
        If sender.SelectedIndex < 0 Then Exit Sub
        IsBusy = True
        Dim dr As DataRow = dtCRC(sender.SelectedIndex)
        numWidth.Text = dr("Width")
        tbPoly.Text = Convert.ToString(dr("PolyValue"), 16).ToString.ToUpper
        tbInit.Text = Convert.ToString(dr("InitValue"), 16).ToString.ToUpper
        tbXorOut.Text = Convert.ToString(dr("XorOutValue"), 16).ToString.ToUpper
        chkRevIn.Checked = dr("RevIn")
        chkRevOut.Checked = dr("RevOut")
        IsBusy = False
    End Sub

    Private Sub tb_ValueChanged(sender As Object, e As EventArgs) Handles numWidth.ValueChanged, tbPoly.TextChanged, tbInit.TextChanged, tbXorOut.TextChanged, chkRevIn.CheckedChanged, chkRevOut.CheckedChanged
        If IsBusy Then Exit Sub
        cbCrcType.SelectedIndex = -1
    End Sub

    Private Sub btnCRC_Click(sender As Object, e As EventArgs) Handles btnCRC.Click
        '有效性检查暂略
        Dim data As Byte() = String_to_Bytes(tbData.Text)
        Dim Result As Byte()
        Select Case TabCheck.SelectedTab.Name
            Case "tpCRC"
                Result = Check_CRC(data, numWidth.Value, Convert.ToUInt32(tbPoly.Text, 16), Convert.ToUInt32(tbInit.Text, 16), Convert.ToUInt32(tbXorOut.Text, 16), chkRevIn.Checked, chkRevOut.Checked)
            Case Else
                Select Case cbOtherType.SelectedValue
                    Case "CS"
                        Result = {Check_CS(data)}
                    Case "BCC"
                        Result = {Check_BCC(data)}
                    Case "LRC"
                        Result = {Check_LRC(data)}
                    Case "VPCO"
                        Result = {Check_VPC(data, 1)}
                    Case "VPCE"
                        Result = {Check_VPC(data, 0)}
                    Case Else
                        Exit Sub
                End Select
        End Select
        If chkOrder_LF.Checked Then Result = Result.Reverse.ToArray
        tbCrcResult.Text = Bytes_to_String(Result)
    End Sub

    Private Sub CrcTableInit()
        dtCRC = New DataTable
        dtCRC.Columns.Add("id", GetType(Integer))
        dtCRC.Columns.Add("CrcName", GetType(String))
        dtCRC.Columns.Add("PolyDes", GetType(String))
        dtCRC.Columns.Add("Width", GetType(UInteger))
        dtCRC.Columns.Add("PolyValue", GetType(UInteger))
        dtCRC.Columns.Add("InitValue", GetType(UInteger))
        dtCRC.Columns.Add("XorOutValue", GetType(UInteger))
        dtCRC.Columns.Add("RevIn", GetType(Boolean))
        dtCRC.Columns.Add("RevOut", GetType(Boolean))
        If Not IO.File.Exists("crctable.csv") Then
            Dim csv As String = My.Resources.crctable
            Using sw As New IO.StreamWriter("crctable.csv", False, System.Text.Encoding.UTF8)
                sw.Write(csv)
            End Using
        End If
        Dim sr As New IO.StreamReader("crctable.csv", System.Text.Encoding.UTF8)
        sr.ReadLine() '读出标题行
        Do Until sr.EndOfStream
            Dim l As String = sr.ReadLine
            If l = vbNullString Then Continue Do
            Dim c() As String = l.Split(","c)
            Dim crcname As String = c(0)
            Dim polydes As String = c(1)
            Dim width As UInteger = Convert.ToUInt32(c(2), 10)
            Dim poly As UInteger = Convert.ToUInt32(c(3), 16)
            Dim init As UInteger = Convert.ToUInt32(c(4), 16)
            Dim xorout As UInteger = Convert.ToUInt32(c(5), 16)
            Dim revin As Boolean = Convert.ToBoolean(c(6))
            Dim revout As Boolean = Convert.ToBoolean(c(7))
            dtCRC.Rows.Add(dtCRC.Rows.Count, crcname, polydes, width, poly, init, xorout, revin, revout)
        Loop
    End Sub

    Private Sub OtherTableInit()
        dtOther.Columns.Add("id", GetType(String))
        dtOther.Columns.Add("des", GetType(String))
        dtOther.Rows.Add("CS", "[CS]校验和")
        dtOther.Rows.Add("BCC", "[BCC]信息组校验码/异或校验")
        dtOther.Rows.Add("LRC", "[LRC]纵向冗余校验")
        dtOther.Rows.Add("VPCO", "垂直奇校验")
        dtOther.Rows.Add("VPCE", "垂直偶校验")
    End Sub

End Class