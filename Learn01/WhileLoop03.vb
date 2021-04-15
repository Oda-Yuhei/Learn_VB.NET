Module WhileLoop03
	Sub main()
		Dim count As Integer = 0
		
		While True
			Console.WriteLine(count)
			count += 1
			If count = 10 Then
				Exit While
			End If
			Console.WriteLine("!")
		End While
		Console.WriteLine("ƒ‹[ƒv‚ªI‚í‚è‚Ü‚µ‚½")
		
	End Sub
End Module