Module TryArray05
	Sub main()
		Dim numbers() As Integer
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}

		For Each num In numbers
			If num mod 2 = 0
				Console.WriteLine(num & "‚Í‹ô”")
			Else
				Console.WriteLine(num & "‚ÍŠï”")
			End If
		Next

	End Sub
End Module