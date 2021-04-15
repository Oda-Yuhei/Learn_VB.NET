Module WhileLoop05
	Sub Main()
		Dim count As Integer = 1
		Dim random As New System.Random()
		
		While random.Next(6) + 1 <> 6
			count += 1
		End While
		Console.WriteLine(count & "‰ñ–Ú‚Å6‚ªo‚Ü‚µ‚½")
	End Sub
End Module