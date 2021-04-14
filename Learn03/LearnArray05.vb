Module LearnArray05
	Sub Main()
		Dim numbers As Integer()
		
		numbers = New Integer(3) {}
		numbers(0) = 10
		numbers(1) = 20
		numbers(2) = 30
		numbers(3) = 40
		
		For i As Integer = 0 To numbers.Length - 1
			Console.WriteLine(i)
		Next i
		Console.WriteLine()
		
		'UBoundŠÖ”‚Í”z—ñ‚Ì“Y‚¦š‚ÌÅ‘å’l‚ğ‹‚ß‚Ü‚·
		For i As Integer = 0 To UBound(numbers)
			Console.WriteLine(numbers(i))
		Next i
	End Sub
End Module