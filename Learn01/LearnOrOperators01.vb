Module LearnOrOperators01
	Sub Main()
		Dim a As Integer = 100
		Dim b As Integer = 100
		
		If a = 100 Or b = 100 Then
			Console.WriteLine("���������s�����")
		Else
			Console.WriteLine("���������s����Ȃ�")
		End If
		
		If a = 100 Or b = 50 Then
			Console.WriteLine("���������s�����")
		Else
			Console.WriteLine("���������s����Ȃ�")
		End If
		
		If a = 50 OrElse b = 50 Then
			Console.WriteLine("������������������Ȃ�")
		Else
			Console.WriteLine("���������s�����")
		End If
		
	End Sub
End Module
