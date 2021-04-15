Module SellectStatement01
	Sub Main()
		Dim answer As Integer = 2
		
		Select Case answer
			Case 1
				Console.WriteLine("one")
			Case 2
				Console.WriteLine("two")
			Case 3
				Console.WriteLine("three")
			Case Else
				Console.WriteLine("other")
		End Select
		
	End Sub
End Module