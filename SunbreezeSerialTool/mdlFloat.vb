Imports System.Management.Instrumentation
Imports System.Security

Module mdlFloat

    ''' <summary>
    ''' 浮点数转十进制
    ''' </summary>
    ''' <param name="InputHex">IEEE754浮点数的十六进制字符串</param>
    ''' <param name="LenFP">浮点数的位数</param>
    ''' <param name="LenExp">阶码位数</param>
    ''' <returns>
    ''' 指数=阶码-偏移量，exp - (2 ^ (LenE - 1) - 1)
    ''' 尾数Mantissa = $"1.{Fraction}"
    ''' 名称            长度    阶码     有效数
    '''                 length exponent fraction
    ''' FP8             8       3       4
    ''' CFloat8_1_4_3   8       4       3
    ''' CFloat8_1_5_2   8       5       2
    ''' IEEE-FP16       16      5       10
    ''' bfloat16-BF16   16      8       7
    ''' NVIDIA-TF32     19      8       10
    ''' Enflame-EF32    20      8       11
    ''' AMD-FP24        24      7       16
    ''' Pixar-PXR24     24      8       15
    ''' IEEE-FP32       32      8       23
    ''' IEEE-FP64       64      11      52
    ''' </returns>
    Public Function FloatP_HexToDec(InputHex As String, LenFP As Integer, LenExp As Integer) As Decimal
        If Not IsHexStr(InputHex) OrElse InputHex.Length = 0 Then
            MessageBox.Show($"请输入数据", "转换失败", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If
        InputHex = InputHex.Replace(" ", vbNullString) '去除空格
        For i = 0 To InputHex.Length - 1
            If InputHex(i) <> "0"c Then '忽略前面的0
                If (InputHex.Length - i - 1) * 4 > LenFP Then '判断数据输入是否过长
                    MessageBox.Show($"输入数据超过浮点数长度", "转换失败", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return Nothing
                End If
            End If
        Next

        Dim LenFra As Integer = LenFP - LenExp - 1 '有效数位
        Dim hex As Long = Convert.ToInt64(InputHex.Replace(" ", vbNullString), 16)
        Dim fBinStr As String = Convert.ToString(hex, 2).PadLeft(LenFP, "0"c) '浮点数的二进制字符串
        Dim Sign As Integer = (-1) ^ Convert.ToInt32(fBinStr.Substring(0, 1), 2) '符号位
        Dim ExpBin As Integer = Convert.ToInt32(fBinStr.Substring(1, LenExp), 2) '阶码
        Dim ExpDec As Integer = ExpBin - ((2 ^ (LenExp - 1)) - 1) '阶码转十进制指数
        Dim FraBin As String = fBinStr.Substring(LenExp + 1) '有效数
        Dim FraDec As Decimal = 0
        For i = 0 To LenFra - 1
            FraDec += FraBin(i).ToString * (1 / (2 ^ (i + 1))) '有效数转十进制
        Next
        Dim dec As Decimal = Sign * (1 + FraDec) * (2 ^ ExpDec)
        Return dec
    End Function

    ''' <summary>
    ''' 十进制转浮点数
    ''' </summary>
    ''' <param name="InputDec">十进制数字</param>
    ''' <param name="LenFP">浮点数的位数</param>
    ''' <param name="LenExp">阶码位数</param>
    ''' <returns></returns>
    Public Function FloatP_DecToHex(InputDec As Decimal, LenFP As Integer, LenExp As Integer) As String
        Dim LenFra As Integer = LenFP - LenExp - 1 '有效数位
        Dim Sign As String = "0" '符号位
        If InputDec < 0 Then Sign = "1" '小于零的情况，符号位为1
        InputDec = Math.Abs(InputDec) '舍掉符号
        Dim iBinStr As String = BaseConvert_DecToAny(InputDec, 2)
        Dim BinAry() As String = iBinStr.Split(".")
        Dim ExpDec As Integer = iBinStr.Split(".")(0).Length - 1 '指数
        Dim tmp As Integer = ExpDec + ((2 ^ (LenExp - 1)) - 1)
        Dim ExpBin As String = Convert.ToString(tmp, 2) '阶码=指数+偏移量
        ExpBin = ExpBin.PadLeft(LenExp, "0"c)
        Dim FraBin As String = iBinStr.Replace(".", vbNullString).Substring(1) '尾数
        If FraBin.Length > LenFra Then
            FraBin = FraBin.Substring(0, LenFra) '舍去多余的尾数
        End If
        Dim oBin As String = (Sign & ExpBin & FraBin).PadLeft(LenFP, "0"c) '二进制形式的浮点
        Return BaseConvert_AnyToAny(oBin, 2, 16)
    End Function

End Module