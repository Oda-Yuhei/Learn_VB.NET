Module IfStatement01
	Sub Main()
		Dim answer As Integer
		answer = 32 * 2
		
		Dim isLarge As Boolean = answer >= 256
		
		If isLarge Then
			Console.WriteLine("256�ȏ�")
		Else
			Console.WriteLine("256����")
		End If
	End Sub
End Module