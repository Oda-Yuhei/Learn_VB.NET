Module LearnArray02
	Sub Main()
		Dim numbers(3) As Integer
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