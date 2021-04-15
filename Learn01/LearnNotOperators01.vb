Module LearnNotOperators01
	Sub Main()
		Dim a As Integer = 100
		
		If a = 100 Then
			Console.WriteLine("ここが実行される")
		Else
			Console.WriteLine("ここが実行されない")
		End If
		
		If Not a = 100 Then
			Console.WriteLine("ここが実行されない")
		Else
			Console.WriteLine("ここが実行される")
		End If
		
	End Sub
End Module