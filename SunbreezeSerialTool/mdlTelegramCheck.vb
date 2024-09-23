Imports System.Security.Cryptography

Module mdlTelegramCheck

    ''' <summary>
    ''' 校验_CS（累加除256取余）
    ''' [Check Sum (校验和)]
    ''' </summary>
    ''' <param name="data">报文的字节数组（不包含前导字节0xFE和结束符0x16）</param>
    ''' <returns></returns>
    Public Function Check_CS(data As Byte()) As Byte
        Dim sum As Integer = 0
        For i = 0 To data.Length - 1
            sum += data(i)
        Next
        Dim chk As Byte = sum Mod 256
        Return chk
    End Function

    ''' <summary>
    ''' 校验_DLT645（即CS校验和）
    ''' </summary>
    ''' <param name="data">报文的字节数组（不包含前导字节0xFE和结束符0x16）</param>
    ''' <returns></returns>
    Public Function Check_DLT645(data As Byte()) As Byte
        Return Check_CS(data)
    End Function

    ''' <summary>
    ''' 校验_CJT188（即校验和）
    ''' </summary>
    ''' <param name="data">报文的字节数组（不包含前导字节0xFE和结束符0x16）</param>
    ''' <returns></returns>
    Public Function Check_CJT188(data As Byte()) As Byte
        Return Check_CS(data)
    End Function

    ''' <summary>
    ''' 校验_BCC
    ''' [Block Check Character (信息组校验码，即异或校验)]
    ''' </summary>
    ''' <param name="data">报文的字节数组</param>
    ''' <returns></returns>
    Public Function Check_BCC(data As Byte()) As Byte
        Dim chk As Byte = 0
        For i = 0 To data.Length - 1
            chk = chk Xor data(i)
        Next
        Return chk
    End Function

    ''' <summary>
    ''' 校验_LRC
    ''' [Longitudinal Redundancy Check (纵向冗余校验)]
    ''' </summary>
    ''' <param name="data">报文的字节数组</param>
    ''' <returns></returns>
    Public Function Check_LRC(data As Byte()) As Byte
        Dim sum As Integer = 0
        For i = 0 To data.Length - 1
            sum += data(i)
        Next
        Dim chk As Byte = 256 - (sum Mod 256)
        Return chk
    End Function

    ''' <summary>
    ''' 校验_C-Bus（即LRC）
    ''' </summary>
    ''' <param name="data">报文的字节数组</param>
    ''' <returns></returns>
    Public Function Check_Cbus(data As Byte()) As Byte
        Return Check_LRC(data)
    End Function

    ''' <summary>
    ''' 校验_垂直奇偶校验
    ''' [Vertical Parity Check]
    ''' </summary>
    ''' <param name="data">报文的字节数组</param>
    ''' <param name="oe">奇偶校验（0为偶校验，1为奇校验）</param>
    ''' <returns></returns>
    Public Function Check_VPC(data As Byte(), oe As Byte) As Byte
        If oe > 1 Then oe = 1
        Dim binstr As String = vbNullString
        Dim b(,) As Byte = BytesSplit(data)
        For j = 0 To 7
            Dim sum As Byte = 0
            For i = 0 To data.Length - 1
                sum += b(i, j)
            Next
            binstr &= Math.Abs(oe * 1 - (sum Mod 2)).ToString
        Next
        Return Convert.ToByte(binstr, 2)
    End Function

    Private Function BytesSplit(bytes As Byte()) As Byte(,)
        Dim b(bytes.Length - 1, 7) As Byte
        For i = 0 To bytes.Length - 1
            Dim s As String = Convert.ToString(bytes(i), 2).PadLeft(8, "0"c)
            For j = 0 To 7
                b(i, j) = Convert.ToByte(s(j), 10)
            Next
        Next
        Return b
    End Function

    ''' <summary>
    ''' 校验_KNX/TP1（即垂直奇校验）
    ''' </summary>
    ''' <param name="data">报文的字节数组</param>
    ''' <returns></returns>
    Public Function Check_KNX_TP1(data As Byte()) As Byte
        Return Check_VPC(data, 1)
    End Function

    ''' <summary>
    ''' 校验_CRC-16/Modbus
    ''' [Cyclic Redundancy Check (循环冗余校验)]
    ''' </summary>
    ''' <param name="data">报文的字节数组</param>
    ''' <param name="Reserve">True-高位在前，False-低位在前</param>
    ''' <returns></returns>
    Public Function Check_CRC16_Modbus(data As Byte(), Optional Reserve As Boolean = False) As Byte()
        Dim CRC16Lo As Byte, CRC16Hi As Byte 'CRC寄存器
        Dim CL As Byte, CH As Byte '多项式码&HA001
        Dim SaveHi As Byte, SaveLo As Byte
        Dim i As Integer
        Dim Flag As Integer
        CRC16Lo = &HFF
        CRC16Hi = &HFF
        CL = &H1
        CH = &HA0
        For i = 0 To UBound(data)
            CRC16Lo = CRC16Lo Xor data(i) '每一个数据与CRC寄存器进行异或
            For Flag = 0 To 7
                SaveHi = CRC16Hi
                SaveLo = CRC16Lo
                CRC16Hi \= 2 '高位右移一位
                CRC16Lo \= 2 '低位右移一位
                If (SaveHi And &H1) = &H1 Then '如果高位字节最后一位为1
                    CRC16Lo = CRC16Lo Or &H80 '则低位字节右移后前面补1
                End If '否则自动补0
                If (SaveLo And &H1) = &H1 Then '如果LSB为1，则与多项式码进行异或
                    CRC16Hi = CRC16Hi Xor CH
                    CRC16Lo = CRC16Lo Xor CL
                End If
            Next Flag
        Next i
        Return If(Reserve, {CRC16Hi, CRC16Lo}, {CRC16Lo, CRC16Hi})
    End Function

    ''' <summary>
    ''' 校验_CRC
    ''' [Cyclic Redundancy Check (循环冗余校验)]
    ''' </summary>
    ''' <param name="DataBytes">需要校验的数据</param>
    ''' <param name="Width">宽度</param>
    ''' <param name="PolyValue">多项式</param>
    ''' <param name="InitValue">初始值（小于等于宽度）</param>
    ''' <param name="XorOutValue">结果异或值（小于等于宽度）</param>
    ''' <param name="RevIn">输入数据反转（每个字节内部按位反转）</param>
    ''' <param name="RevOut">输出数据反转（整个数据按位反转）</param>
    ''' <returns>
    ''' 处理顺序：输入数据补0->输入数据反转->初始值->异或计算->输出数据反转->结果异或值
    ''' </returns>
    Public Function Check_CRC(DataBytes As Byte(), Width As UInteger, PolyValue As UInteger, InitValue As UInteger, XorOutValue As UInteger, RevIn As Boolean, RevOut As Boolean) As Byte()
        If IsNothing(DataBytes) OrElse DataBytes.Length <= 0 Then Return Nothing
        If Width <= 0 Then Return Nothing
        Dim data As List(Of Boolean) = ByteAry_BoolList(DataBytes, RevIn) '同时处理输入数据反转的情况
        For d = 0 To Width - 1
            data.Add(False) 'data最后补与宽度相同个数的0
        Next
        'Debug.Print($"Data+0 = {BoolList_BinStr(data)}")
        Dim poly As List(Of Boolean) = BinStr_BoolList(Convert.ToString(PolyValue, 2).PadLeft(Width, "0"c))
        poly.Insert(0, True) '多项式前加1
        'Debug.Print($"Poly = {BoolList_BinStr(poly)}")
        Dim crc As List(Of Boolean) = BinStr_BoolList("0".PadLeft(Width + 1, "0"c)) '初始化给CRC寄存器 
        'Debug.Print($"CRC = {BoolList_BinStr(crc)}")
        If InitValue <> 0 Then '有初始值，data前几位（与宽度相同）先和初始值异或
            Dim init = BinStr_BoolList(Convert.ToString(InitValue, 2).PadLeft(Width, "0"c))
            For n = 0 To Width - 1
                data(n) = data(n) Xor init(n) 'data前几位与初始值异或
            Next
        End If
        Do While data.Count >= 0
            'Debug.Print($"CRC = {BoolList_BinStr(crc)}")
            'Debug.Print($"data = {BoolList_BinStr(data)}")
            'Debug.Print($"CRC(0) = {crc(0)}")
            If crc(0) Then '寄存器首位为1，进行异或运算
                'Debug.Print($"XOR")
                For j = 0 To crc.Count - 1
                    crc(j) = crc(j) Xor poly(j) '逐位异或，之后第一位必然为0
                Next
                'Debug.Print($"AfterXOR crc = {BoolList_BinStr(crc)}")
            Else '寄存器首位为0，左移
                'Debug.Print($"move")
                If data.Count > 0 Then '剩余有data位未处理，左移继续
                    crc.RemoveAt(0) '移除CRC寄存器首位
                    crc.Add(data(0)) 'data现存首位移到crc寄存器末位
                    data.RemoveAt(0) 'data舍弃首位
                    'Debug.Print($"MoveLeft")
                Else '剩余数据过短，直接输出结果
                    'Debug.Print($"exitfor")
                    Exit Do
                End If
            End If
            'Debug.Print("=====")
        Loop
        crc.RemoveAt(0) '去掉CRC寄存器首位即为CRC校验和
        If RevOut Then crc = crc.ToArray.Reverse.ToList '输出反转的情况
        If XorOutValue <> 0 Then '有输出异或值的情况，在最后进行
            Dim xorout = BinStr_BoolList(Convert.ToString(XorOutValue, 2).PadLeft(Width, "0"c))
            For x = 0 To Width - 1
                crc(x) = crc(x) Xor xorout(x) 'CRC值与输出异或值进行异或
            Next
        End If
        Dim crcBytes As Byte() = BoolList_ByteAry(crc)
        'Debug.Print($"CRC Result = {BoolList_BinStr(crc)}")
        Return crcBytes
    End Function

    '字节数组转布尔List
    Private Function ByteAry_BoolList(bytes As Byte(), Optional InnerReverse As Boolean = False) As List(Of Boolean)
        If bytes.Length = 0 Then Return Nothing
        Dim l As New List(Of Boolean)
        For i = 0 To bytes.Length - 1
            Dim b As String = Convert.ToString(bytes(i), 2).PadLeft(8, "0")
            If InnerReverse Then b = b.Reverse.ToArray
            For j = 0 To 7
                l.Add(Convert.ToBoolean(Convert.ToInt32(b(j).ToString)))
            Next
        Next
        Return l
    End Function

    '二进制字符串转布尔List
    Private Function BinStr_BoolList(str As String) As List(Of Boolean)
        Dim lst As New List(Of Boolean)
        For i = 0 To str.Length - 1
            lst.Add(Convert.ToBoolean(Convert.ToInt32(str(i).ToString)))
        Next
        Return lst
    End Function

    '布尔List转字节数组
    Private Function BoolList_ByteAry(lst As List(Of Boolean)) As Byte()
        Dim s As String = vbNullString
        For i = 0 To lst.Count - 1
            s &= Convert.ToInt32(lst(i)).ToString
        Next
        Dim m As Integer = s.Length Mod 8
        If m <> 0 Then s = "0".PadLeft(8 - m, "0"c) & s
        Return BinStr_ByteAry(s)
    End Function

    Private Function BoolList_BinStr(lst As List(Of Boolean)) As String
        Dim str As String = vbNullString
        For i = 0 To lst.Count - 1
            str &= Convert.ToInt32(lst(i)).ToString
        Next
        Return str
    End Function

    '字节数组转布尔型数组
    Private Function ByteAry_BoolAry(bytes As Byte()) As Boolean()
        If bytes.Length = 0 Then Return Nothing
        Dim ary((bytes.Length * 8) - 1) As Boolean
        For i = 0 To bytes.Length - 1
            Dim b As String = Convert.ToString(bytes(i), 2).PadLeft(8, "0")
            For j = 0 To 7
                ary((i * 8) + j) = Convert.ToBoolean(b(j))
            Next
        Next
        Return ary
    End Function

    '字节数组转二进制字符串
    Private Function ByteAry_BinStr(bytes() As Byte) As String
        Dim s As String = vbNullString
        For i = 0 To bytes.Length - 1
            s &= Convert.ToString(bytes(i), 2).PadLeft(8, "0")
        Next
        Return s
    End Function

    '二进制字符串转字节数组
    Private Function BinStr_ByteAry(str As String) As Byte()
        If str.Length Mod 8 <> 0 Then str = 0.ToString($"B{8 - (str.Length Mod 8)}") & str
        Dim b((str.Length \ 8) - 1) As Byte
        For i = 0 To b.Length - 1
            b(i) = Convert.ToByte(str.Substring(i * 8, 8), 2)
        Next
        Return b
    End Function

End Module
