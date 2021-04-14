Module LearnArry06
	Sub Main()
		Dim drinks() As String
		
		drinks = New String(3) {}
		drinks(0) = "コーラ"
		drinks(1) = "水"
		drinks(2) = "コーヒー"
		drinks(3) = "スープカレー"
		
		For i As Integer = 0 To Ubound(drinks)
			Console.WriteLine(drinks(i))
		Next i
		
	End Sub
End Module