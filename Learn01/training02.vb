Module training02
	Sub Main()
		Dim random As New System.Random()
		Dim a As Integer
		a = random.Next(9)
		
		If a = 0 or a = 1
			Console.WriteLine("��g")
		Else If a >= 3
			Console.WriteLine("���g")
		Else If a >= 5
			Console.WriteLine("���g")
		Else If a >= 7
			Console.WriteLine("��")
		Else
			Console.WriteLine("�勥")
		End If
	End Sub
End Module