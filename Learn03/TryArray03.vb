Module TryArray03
	Sub main()
		Dim numbers() As Integer
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}
		Dim max As Integer = numbers(0)
		Dim min As Integer = numbers(0)
		
		For i As Integer = 1 To UBound(numbers)
			If numbers(i) > max
				max = numbers(i)
			Else if  numbers(i) < min
				min = numbers(i)
			End If
		Next
		Console.WriteLine(max)
		Console.WriteLine(min)
	End Sub
End Module