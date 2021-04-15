Module LearnVariables09
	Sub Main()
		Console.Write("A:")
		Dim strA As String = Console.ReadLine()
		Console.Write("B:")
		Dim strB As String = Console.ReadLine()
		Dim a As Integer = val(strA)
		Dim b As Integer = CInt(strB)
		
		Dim ans = a + b
		Console.WriteLine(a & "+" & b & "=" & ans)
	End Sub
End Module