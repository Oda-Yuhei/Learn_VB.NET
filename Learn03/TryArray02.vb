Module TryArray02
	Sub main()
		Dim numbers() As Integer
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}
		Dim sum As Integer
		
		For Each num In numbers
			sum += num
		Next
		Console.WriteLine(sum)
		console.WriteLine(sum / numbers.Length)
	End Sub
End Module