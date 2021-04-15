Module LearnAndOperators01
	Sub Main()
		Dim a As Integer = 100
		Dim b As Integer = 100
		
		If a = 100 And b = 100 Then
			Console.WriteLine("ここが実行される")
		Else
			Console.WriteLine("ここが実行されない")
		End If
		
		If a = 100 And b = 50 Then
			Console.WriteLine("ここが実行されない")
		Else
			Console.WriteLine("ここが実行される")
		End If
		
	End Sub
End Module