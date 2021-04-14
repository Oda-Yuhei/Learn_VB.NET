Module TryArray06
	Sub main()
		Dim numbers() As Integer
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}
		Dim x As Integer

		
		For j As Integer = 0 To numbers.Length
			For i As Integer = 0 To numbers.Length - 2 -j
				If numbers(i) > numbers(i+1)
					x = numbers(i+1)
					numbers(i+1) = numbers(i)
					numbers(i) = x
				End If
			Next i
		Next j
		For Each number As Integer In numbers
			Console.WriteLine(number)
		Next
		Console.WriteLine()
		
	End Sub
End Module