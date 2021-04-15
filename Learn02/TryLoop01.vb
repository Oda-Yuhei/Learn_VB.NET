Module TryLoop01
	Sub main()
		Dim count As Integer = 0
		
		Do While True
			Console.WriteLine("VB.net")
			count += 1
			If count = 10 Then
				Exit Do
			End If
		Loop
	End Sub
End Module