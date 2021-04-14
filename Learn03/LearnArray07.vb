Module LearnArray07
	Sub Main()
		Dim drinks() As String
		
		drinks = New String(3) {}
		drinks(0) = "コーラ"
		drinks(1) = "水"
		drinks(2) = "コーヒー"
		drinks(3) = "スープカレー"
		
		For Each drink As String In drinks
			Console.WriteLine(drink)
		Next drink
	End Sub
End Module