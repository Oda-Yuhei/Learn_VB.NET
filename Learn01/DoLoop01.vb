Module DoLoop01
	Sub Main()
		Dim count As Integer
		
		count = 0
		Do While count < 3
			Console.WriteLine(count)
			count = count + 1
		Loop
		Console.WriteLine("���[�v���I���܂���")
		
		count = 0
		Do Until count >= 3
			Console.WriteLine(count)
			count = count + 1
		Loop
		Console.WriteLine("���[�v���I���܂���")
		
	End Sub
End Module
