Module SelectStatement03
	Sub Main()
		Dim answer As Integer = 85
		
		Select Case answer
			Case 80 To 100
				Console.WriteLine("80�`100")
			Case 60 To 79
				Console.WriteLine("60�`79")
			Case 40 To 59
				Console.WriteLine("40�`59")
			Case Else
				Console.WriteLine("����ȊO")
		End Select
		
	End Sub
End Module