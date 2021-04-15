Module SelectStatement04
	Sub Main()
		Dim answer As Integer =6
		
		Select Case answer
			Case 1,2
				Console.WriteLine("1‚©2")
			Case 3
				Console.WriteLine("3")
			Case 4,5,6
				Console.WriteLine("4‚©5‚©6")
			Case Else
				Console.WriteLine("‚»‚êˆÈŠO")
		End Select
		
	End Sub
End Module