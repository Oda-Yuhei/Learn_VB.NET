Module TryArray07
	Sub main()
		Dim numbers() As Integer
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}
		Dim sort() As Integer
		sort = New Integer(UBound(numbers)){}
		
		
		For j As Integer = UBound(numbers) To 0 step -1
			Dim max As Integer = numbers(j)
			For i As Integer = 0 To UBound(numbers) - j
				If numbers(i) > max
					max = numbers(i)
				End If
				sort(j) = max
			Next
		Next
		
		For Each sor As Integer In sort
			Console.WriteLine(sor)
		Next
		
		
	End Sub
End Module