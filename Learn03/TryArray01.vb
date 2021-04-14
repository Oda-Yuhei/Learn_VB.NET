Module TryArray01
	Sub Main()
		Dim numbers() As Integer
		
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}
		
		For i As Integer = UBound(numbers) To 1 step -1
			console.WriteLine(numbers(i))
		Next i
	End Sub
End Module