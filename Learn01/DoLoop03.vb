Module DoLoop03
	Sub Main()
		Dim count As Integer
		
		count = 0
		Do While True
			Console.WriteLine(count)
			count += 1
			If count = 10 Then
				Exit Do
			End If
		Loop
		Console.WriteLine("ƒ‹[ƒv‚ªI‚í‚è‚Ü‚µ‚½")
	End Sub
End Module
