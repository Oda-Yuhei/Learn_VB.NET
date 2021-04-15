Module WhileLoop04
	Sub main()
		Dim count As Integer = 0
		
		While count < 10
			count += 1
			If count Mod 2 = 0 Then
				Continue While
			End If
			Console.WriteLine(count)
		End While
		Console.WriteLine("ƒ‹[ƒv‚ªI‚í‚è‚Ü‚µ‚½")
			
	End Sub
End Module