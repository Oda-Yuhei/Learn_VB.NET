Module SelectStatement02
	Sub Main()
		Dim answer as Integer =85
		
		Select Case answer
			Case Is >= 80
				Console.WriteLine("80�ȏ�")
			Case Is >= 60
				Console.WriteLine("60�ȏ�")
			Case Is >= 40
				Console.WriteLine("40�ȏ�")
			Case Else
				Console.WriteLine("40����")
		End Select
		
	End Sub
End Module