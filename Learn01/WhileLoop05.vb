Module WhileLoop05
	Sub Main()
		Dim count As Integer = 1
		Dim random As New System.Random()
		
		While random.Next(6) + 1 <> 6
			count += 1
		End While
		Console.WriteLine(count & "��ڂ�6���o�܂���")
	End Sub
End Module