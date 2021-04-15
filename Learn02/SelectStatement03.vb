Module SelectStatement03
	Sub Main()
		Dim answer As Integer = 85
		
		Select Case answer
			Case 80 To 100
				Console.WriteLine("80Å`100")
			Case 60 To 79
				Console.WriteLine("60Å`79")
			Case 40 To 59
				Console.WriteLine("40Å`59")
			Case Else
				Console.WriteLine("ÇªÇÍà»äO")
		End Select
		
	End Sub
End Module