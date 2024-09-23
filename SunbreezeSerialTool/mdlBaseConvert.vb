''' <summary>
''' 进制转换
''' </summary>
Module mdlBaseConvert

    Private ReadOnly Chars() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Private ReadOnly dicCharVal As New Dictionary(Of Char, UInt16)
    Private ReadOnly dicValChar As New Dictionary(Of UInt16, Char)

    ''' <summary>
    ''' 初始化进制转换
    ''' </summary>
    Public Sub InitBaseConvert()
        dicCharVal.Clear()
        dicValChar.Clear()
        For i = 0 To Chars.Length - 1
            dicCharVal.Add(Chars(i), i)
            dicValChar.Add(i, Chars(i))
        Next
    End Sub

    ''' <summary>
    ''' 任意进制(暂为2~36进制)转十进制
    ''' </summary>
    ''' <param name="InputVal">输入的数值</param>
    ''' <param name="InputBase">输入数值的进制</param>
    ''' <returns></returns>
    Public Function BaseConvert_AnyToDec(InputVal As String, InputBase As UInt16) As Decimal
        If dicCharVal.Count = 0 Then InitBaseConvert()
        If IsNothing(InputVal) Then Return Nothing
        InputVal = InputVal.Replace(" ", vbNullString).ToUpper '去掉全部空格并转大写
        Dim Sign As Integer = 1 '符号
        '----------有效性检测开始----------
        For c = 0 To InputVal.Length - 1
            If Not dicCharVal.ContainsKey(InputVal(c)) Then '判断输入数据是否含有无效字符
                Select Case InputVal(c)
                    Case "-" '检测到负号
                        If c = 0 Then
                            Sign = -1
                        Else
                            MessageBox.Show("检测到位置不当的负号", "转换失败", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return Nothing
                        End If
                    Case "." '检测到小数点
                        '不需要进行操作
                    Case Else
                        MessageBox.Show($"检测到无效字符：{InputVal(c)}", "转换失败", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return Nothing
                End Select
            ElseIf dicCharVal(InputVal(c)) >= InputBase Then
                MessageBox.Show($"检测到对于{InputBase}进制过大的字符：{InputVal(c)}", "转换失败", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return Nothing
            End If
        Next
        '----------有效性检测结束----------
        If InputVal(0) = "-"c Then InputVal = InputVal.Remove(0, 1)
        Dim iVal() As String = InputVal.Split("."c) '分离整数和小数
        If iVal.Length > 2 Then
            MessageBox.Show($"检测到多个小数点", "转换失败", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If
        Dim oInt As Decimal = 0 '输出的整数部分
        Dim len0 As UInt16 = iVal(0).Length '整数部分长度
        For i = 0 To len0 - 1 '处理整数部分
            oInt += dicCharVal(iVal(0)(i)) * (InputBase ^ (len0 - 1 - i)) '整数加权展开
        Next
        Dim oDec As Decimal = 0 '输出的小数部分
        If iVal.Length > 1 Then
            Dim len1 As UInt16 = iVal(1).Length '小数部分长度
            For d = 0 To len1 - 1 '处理小数部分
                oDec += dicCharVal(iVal(1)(d)) * (InputBase ^ (-1 - d)) '小数加权展开
            Next
        End If
        Dim OutputVal As Decimal = Sign * (oInt + oDec)
        Return OutputVal
    End Function

    ''' <summary>
    ''' 十进制转任意进制(暂为2~36进制)
    ''' </summary>
    ''' <param name="InputVal">输入的数值</param>
    ''' <param name="InputBase">输入数值的进制</param>
    ''' <returns></returns>
    Public Function BaseConvert_DecToAny(InputVal As Decimal, InputBase As UInt16) As String
        If dicValChar.Count = 0 Then InitBaseConvert()
        Dim Sign As String = vbNullString '符号
        If InputVal < 0 Then
            Sign = "-"
            InputVal = Math.Abs(InputVal) '去除输入数据的符号
        End If
        Dim iValInt As UInt32 = Math.Truncate(InputVal) '整数部分 
        Dim oIntChars As New List(Of Char) '整数部分的字符
        Dim div As Integer = iValInt '将整数部分作为被除数，开始进行短除法
        Do
            Dim rmd As Integer '余数
            div = Math.DivRem(div, InputBase, rmd) '商作为新的被除数
            oIntChars.Add(dicValChar(rmd)) '余数转为对应字符
        Loop Until div = 0
        oIntChars.Reverse() '短除结果需要反转
        Dim iValDec As Decimal = InputVal - iValInt '小数部分
        Dim oDecChars As New List(Of Char) '小数部分的字符
        Dim mul As Decimal = iValDec '被乘数
        Dim mulRec As New List(Of Decimal) '被乘数记录
        Dim LoopCount As Integer = 0 '循环计数，每循环一次就产生一位小数
        Do
            If mulRec.Contains(mul) Then Exit Do '被乘数出现第二次说明开始无限循环，跳出
            mulRec.Add(mul)
            Dim prod As Decimal = mul * InputBase '被乘数 * 进制
            Dim prodInt = Math.Truncate(prod) '乘积的整数部分
            oDecChars.Add(dicValChar(prodInt)) '乘积的整数部分转为对应字符
            mul = prod - prodInt '小数部分作为新的被乘数
            LoopCount += 1
            If LoopCount >= 64 Then Exit Do '循环次数过多时跳出循环
        Loop Until mul = 0 '被乘数为0时停止循环
        Dim OutputVal As String = Sign & oIntChars.ToArray
        If oDecChars.ToArray <> "0" Then
            OutputVal &= "." & oDecChars.ToArray
        End If
        Return OutputVal
    End Function

    ''' <summary>
    ''' 任意进制转换(暂为2~36进制)
    ''' </summary>
    ''' <param name="InputVal">输入的数值</param>
    ''' <param name="InputBase">输入数值的进制</param>
    ''' <param name="OutputBase">输出数值的进制</param>
    ''' <returns></returns>
    Public Function BaseConvert_AnyToAny(InputVal As String, InputBase As UInt16, OutputBase As UInt16) As String
        If InputBase = OutputBase Then
            Return InputVal
        Else
            Dim dec As Decimal = BaseConvert_AnyToDec(InputVal, InputBase)
            Dim OutputVal As String = BaseConvert_DecToAny(dec, OutputBase)
            Return OutputVal
        End If
    End Function

End Module
