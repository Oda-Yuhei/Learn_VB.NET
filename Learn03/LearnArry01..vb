Module LearnArry01
	Sub Main()
		Dim numbers(3) As Integer
		numbers(0) = 10
		numbers(1) = 20
		numbers(2) = 30
		numbers(3) = 40
		
		Console.WriteLine("numbers��0�Ԗڂ̐�����" & numbers(0))
		Console.WriteLine("numbers��1�Ԗڂ̐�����" & numbers(1))
		Console.WriteLine("numbers��2�Ԗڂ̐�����" & numbers(2))
		Console.WriteLine("numbers��3�Ԗڂ̐�����" & numbers(3))
		
		Dim length As Integer = numbers.Length
		Console.WriteLine("numbers�̗v�f����" & length)
	End Sub
End Module