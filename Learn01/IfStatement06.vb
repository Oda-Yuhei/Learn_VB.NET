Module IfStatement06
	Sub Main()
		Dim answer As Integer = 2
		
		If answer >= 1 Then
			If answer < 2 Then
				Console.WriteLine("one")
			Else If answer < 3 Then
				Console.WriteLine("two")
			Else If answer < 4 Then
				Console.WriteLine("three")
			Else
				Console.WriteLine("over three")
			End If
		Else
			Console.WriteLine("zero or negative number")
		End If
		
	End Sub
End module