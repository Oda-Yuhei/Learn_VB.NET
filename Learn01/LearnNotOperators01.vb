Module LearnNotOperators01
	Sub Main()
		Dim a As Integer = 100
		
		If a = 100 Then
			Console.WriteLine("���������s�����")
		Else
			Console.WriteLine("���������s����Ȃ�")
		End If
		
		If Not a = 100 Then
			Console.WriteLine("���������s����Ȃ�")
		Else
			Console.WriteLine("���������s�����")
		End If
		
	End Sub
End Module