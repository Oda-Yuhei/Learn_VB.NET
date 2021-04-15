Module LearnConditionalOperators01
	Sub Main()
		Dim number As Integer = 101
		'or later Visual Basic 2008
		Dim msg As String = If(number Mod 2 =0,"偶数","奇数")
		Console.WriteLine(msg)
		
		'before Visual Basic 2008
		Dim msg2 As String = IIf(number Mod 2 = 0, "偶数","奇数")
		Console.WriteLine(msg2)
	End Sub
End Module