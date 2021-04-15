Module LearnOrOperators01
	Sub Main()
		Dim a As Integer = 100
		Dim b As Integer = 100
		
		If a = 100 Or b = 100 Then
			Console.WriteLine("ここが実行される")
		Else
			Console.WriteLine("ここが実行されない")
		End If
		
		If a = 100 Or b = 50 Then
			Console.WriteLine("ここが実行される")
		Else
			Console.WriteLine("ここが実行されない")
		End If
		
		If a = 50 OrElse b = 50 Then
			Console.WriteLine("ここがじっこうされない")
		Else
			Console.WriteLine("ここが実行される")
		End If
		
	End Sub
End Module
