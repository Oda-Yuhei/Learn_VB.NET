Module LearnArry06
	Sub Main()
		Dim drinks() As String
		
		drinks = New String(3) {}
		drinks(0) = "�R�[��"
		drinks(1) = "��"
		drinks(2) = "�R�[�q�["
		drinks(3) = "�X�[�v�J���["
		
		For i As Integer = 0 To Ubound(drinks)
			Console.WriteLine(drinks(i))
		Next i
		
	End Sub
End Module