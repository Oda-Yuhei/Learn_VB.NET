Module SelectStatement05
	Sub main()
		Dim answer As Integer = 6
		
		Select Case True
			Case answer >= 5
				Console.WriteLine("5ˆÈã‚Å‚·")
			Case answer >= 3
				Console.WriteLine("3ˆÈã‚Å‚·")
			Case Else
				Console.WriteLine("‚»‚êˆÈŠO")
		End Select
	End sub
End Module
