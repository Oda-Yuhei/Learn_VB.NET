Module LearnArry01
	Sub Main()
		Dim numbers(3) As Integer
		numbers(0) = 10
		numbers(1) = 20
		numbers(2) = 30
		numbers(3) = 40
		
		Console.WriteLine("numbers‚Ì0”Ô–Ú‚Ì”š‚Í" & numbers(0))
		Console.WriteLine("numbers‚Ì1”Ô–Ú‚Ì”š‚Í" & numbers(1))
		Console.WriteLine("numbers‚Ì2”Ô–Ú‚Ì”š‚Í" & numbers(2))
		Console.WriteLine("numbers‚Ì3”Ô–Ú‚Ì”š‚Í" & numbers(3))
		
		Dim length As Integer = numbers.Length
		Console.WriteLine("numbers‚Ì—v‘f”‚Í" & length)
	End Sub
End Module