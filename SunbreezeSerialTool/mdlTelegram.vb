Module mdlTelegram

    ''' <summary>
    ''' 生成ModbusRTU报文（字节数组）
    ''' </summary>
    ''' <param name="Address">地址（十进制）</param>
    ''' <param name="FunCode">功能码</param>
    ''' <param name="Data">数据域</param>
    ''' <returns></returns>
    Public Function Msg_ModbusRTU(Address As Byte, FunCode As Byte, Data As String) As Byte()
        Dim b() As Byte = {Address, FunCode}.Concat(String_to_Bytes(Data)).ToArray '组合报文
        b = b.Concat(Check_CRC16_Modbus(b)).ToArray '添加校验
        Return b
    End Function

    ''' <summary>
    ''' 生成ModbusRTU报文（字符串）
    ''' </summary>
    ''' <param name="Address">地址（十进制）</param>
    ''' <param name="FunCode">功能码</param>
    ''' <param name="Data">数据域</param>
    ''' <returns></returns>
    Public Function Msg_ModbusRTU_String(Address As Byte, FunCode As Byte, Data As String) As String
        Return Bytes_to_String(Msg_ModbusRTU(Address, FunCode, Data))
    End Function

    ''' <summary>
    ''' DLT645报文（字节数组）
    ''' </summary>
    ''' <param name="Address">地址</param>
    ''' <param name="CtlCode">控制码</param>
    ''' <param name="DataId">数据标识</param>
    ''' <param name="DataBlock">数据</param>
    ''' <returns></returns>
    Public Function Msg_DLT645(Address As Byte(), CtlCode As Byte, DataId As Byte(), Optional DataBlock As Byte() = Nothing) As Byte()
        Dim Data As Byte() = DataId.Reverse.Concat(DataBlock).ToArray
        For i = 0 To Data.Length - 1 '数据域加0x33进行传输
            Dim tmp As Integer = Data(i) + 51
            If tmp > 255 Then tmp -= 255
            Data(i) = tmp
        Next
        Dim bytes As Byte() = {104}
        bytes = bytes.Concat(Address).Concat({104, CtlCode, Data.Length}).Concat(Data).ToArray
        Dim cs As Byte = Check_DLT645(bytes) '校验从帧起始符68开始
        Dim header As Byte() = {254, 254, 254, 254}
        Return header.Concat(bytes).Concat({cs, 22}).ToArray
    End Function

    ''' <summary>
    ''' DLT645报文（字符串）
    ''' </summary>
    ''' <param name="Address">地址</param>
    ''' <param name="CtlCode">控制码</param>
    ''' <param name="DataId">数据标识</param>
    ''' <param name="DataBlock">数据</param>
    ''' <returns></returns>
    Public Function Msg_DLT645_String(Address As Byte(), CtlCode As Byte, DataId As Byte(), Optional DataBlock As Byte() = Nothing) As String
        Return Bytes_to_String(Msg_DLT645(Address, CtlCode, DataId, DataBlock))
    End Function

    ''' <summary>
    ''' CJT188报文（字节数组）
    ''' </summary>
    ''' <param name="Address">地址</param>
    ''' <param name="CtlCode">控制码</param>
    ''' <param name="DataId">数据标识</param>
    ''' <param name="SerNo">序列号</param>
    ''' <param name="DataBlock">数据</param>
    ''' <returns></returns>
    Public Function Msg_CJT188(Address As Byte(), MeterType As Byte, CtlCode As Byte, DataId As Byte(), SerNo As Byte, Optional DataBlock As Byte() = Nothing) As Byte()
        Dim Data As Byte() = DataId.Reverse.Concat({SerNo}).Concat(DataBlock).ToArray
        Dim bytes As Byte() = {104, MeterType}
        bytes = bytes.Concat(Address).Concat({CtlCode, Data.Length}).Concat(Data).ToArray
        Dim cs As Byte = Check_CJT188(bytes) '校验从帧起始符68开始
        Dim header As Byte() = {254, 254, 254, 254, 254}
        Return header.Concat(bytes).Concat({cs, 22}).ToArray
    End Function

    ''' <summary>
    ''' CJT188报文（字符串）
    ''' </summary>
    ''' <param name="Address">地址</param>
    ''' <param name="CtlCode">控制码</param>
    ''' <param name="DataId">数据标识</param>
    ''' <param name="SerNo">序列号</param>
    ''' <param name="DataBlock">数据</param>
    ''' <returns></returns>
    Public Function Msg_CJT188_String(Address As Byte(), MeterType As Byte, CtlCode As Byte, DataId As Byte(), SerNo As Byte, Optional DataBlock As Byte() = Nothing) As String
        Return Bytes_to_String(Msg_CJT188(Address, MeterType, CtlCode, DataId, SerNo, DataBlock))
    End Function

    Private ReadOnly hexstr As String = "0123456789ABCDEF"
    ''' <summary>
    ''' 判断是否为有效的十六进制字符串
    ''' </summary>
    ''' <param name="str">输入的字符串</param>
    ''' <param name="maxlen">最大位数，默认0不判断</param>
    ''' <returns></returns>
    Public Function IsHexStr(str As String, Optional maxlen As Integer = 0) As Boolean
        str = str.Replace(" ", vbNullString).ToUpper
        If (maxlen > 0) AndAlso (str.Length > maxlen) Then Return False
        For i = 0 To str.Length - 1
            If Not hexstr.Contains(str(i)) Then Return False
        Next
        Return True
    End Function

    ''' <summary>
    ''' 获取DLT645地址数组
    ''' </summary>
    ''' <param name="Address">地址字符串</param>
    ''' <param name="Reverse">是否反转，False-低字节在前（标注），True-高字节在前（非标准）</param>
    ''' <returns></returns>
    Public Function AdrBytes_DLT645(Address As String, Optional Reverse As Boolean = False) As Byte()
        Return String_to_Bytes(Address.PadLeft(12, "0"c), Not Reverse)
    End Function

    ''' <summary>
    ''' 获取CJT188地址数组
    ''' </summary>
    ''' <param name="Address">地址字符串</param>
    ''' <param name="Reverse">是否反转，False-低字节在前（标准），True-高字节在前（非标准）</param>
    ''' <returns></returns>
    Public Function AdrBytes_CJT188(Address As String, Optional Reverse As Boolean = False) As Byte()
        Return String_to_Bytes(Address.PadLeft(14, "0"c), Not Reverse)
    End Function

    ''' <summary>
    ''' 字节数组转字符串
    ''' </summary>
    ''' <param name="bytes"></param>
    ''' <returns></returns>
    Public Function Bytes_to_String(bytes() As Byte) As String
        If IsNothing(bytes) OrElse bytes.Length <= 0 Then Return vbNullString
        Dim s As String = vbNullString
        For i = 0 To bytes.Length - 1
            s &= $" {Convert.ToString(bytes(i), 16).ToUpper.PadLeft(2, "0"c)}"
        Next
        Return s.Substring(1)
    End Function

    ''' <summary>
    ''' 字符串转字节数组
    ''' </summary>
    ''' <param name="str"></param>
    ''' <param name="reverse">是否反转字节顺序</param>
    ''' <returns></returns>
    Public Function String_to_Bytes(str As String, Optional reverse As Boolean = False) As Byte()
        If str.ToUpper = "NULL" Then Return {}
        str = str.Replace("0x", vbNullString).Replace("H", vbNullString)
        If Not IsHexStr(str) Then Return {}
        str = str.Replace(" ", vbNullString)
        If str.Length Mod 2 <> 0 Then str = "0" & str '字符串长度为奇数，前面加0成偶数
        Dim b(str.Length \ 2 - 1) As Byte
        For i = 0 To b.Length - 1
            b(i) = Convert.ToByte(str.Substring(i * 2, 2), 16)
        Next
        If reverse Then Array.Reverse(b)
        Return b
    End Function

    ''' <summary>
    ''' 简易进制转换
    ''' </summary>
    ''' <param name="s">要转换的字符串</param>
    ''' <param name="fromBase">原进制</param>
    ''' <param name="toBase">转换后进制</param>
    ''' <returns></returns>
    Public Function BaseConvert_Lite(s As String, fromBase As Integer, toBase As Integer) As String
        Try
            Dim int10 As Integer = Convert.ToInt32(s, fromBase)
            Return Convert.ToString(int10, toBase)
        Catch ex As Exception
            MessageBox.Show("转换失败")
            Return vbNullString
        End Try
    End Function

    ''' <summary>
    ''' 十进制数字转十六进制字符串
    ''' </summary>
    ''' <param name="Dec">十进制数字</param>
    ''' <returns></returns>
    Public Function DEC_to_HEX(Dec As Int32) As String
        Return Convert.ToString(Dec, 16)
    End Function

    ''' <summary>
    ''' 十六进制字符串转十进制数字
    ''' </summary>
    ''' <param name="Hex">十六进制字符串</param>
    ''' <returns></returns>
    Function HEX_to_DEC(Hex As String) As Int32
        Return Convert.ToInt32(Hex, 16)
    End Function

End Module