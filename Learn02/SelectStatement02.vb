Module SelectStatement02
	Sub Main()
		Dim answer as Integer =85
		
		Select Case answer
			Case Is >= 80
				Console.WriteLine("80à»è„")
			Case Is >= 60
				Console.WriteLine("60à»è„")
			Case Is >= 40
				Console.WriteLine("40à»è„")
			Case Else
				Console.WriteLine("40ñ¢ñû")
		End Select
		
	End Sub
End Module