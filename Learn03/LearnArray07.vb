Module LearnArray07
	Sub Main()
		Dim drinks() As String
		
		drinks = New String(3) {}
		drinks(0) = "�R�[��"
		drinks(1) = "��"
		drinks(2) = "�R�[�q�["
		drinks(3) = "�X�[�v�J���["
		
		For Each drink As String In drinks
			Console.WriteLine(drink)
		Next drink
	End Sub
End Module