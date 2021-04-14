Module LearnArray04
	Sub Main()
		Dim numbers() As Integer
		
		numbers = New Integer(3) {}
		numbers(0) = 10
		numbers(1) = 20
		numbers(2) = 30
		numbers(3) = 40
		
		Dim index As Integer = 0
		Console.WriteLine(numbers(index))
		index += 1
		Console.WriteLine(numbers(index))
		index += 1
		Console.WriteLine(numbers(index))
		index += 1
		Console.WriteLine(numbers(index))
	End Sub
End Module