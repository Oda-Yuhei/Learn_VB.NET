Module SelectStatement05
	Sub main()
		Dim answer As Integer = 6
		
		Select Case True
			Case answer >= 5
				Console.WriteLine("5�ȏ�ł�")
			Case answer >= 3
				Console.WriteLine("3�ȏ�ł�")
			Case Else
				Console.WriteLine("����ȊO")
		End Select
	End sub
End Module
