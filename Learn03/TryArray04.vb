Module TryArray02
	Sub main()
		Dim numbers() As Integer
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}

		For Each num In numbers
			Console.WriteLine(num * 2)
		Next

	End Sub
End Module