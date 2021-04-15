Module TryLoop02
	Sub Main()
		Dim x As Integer = 1
		Dim y As Integer = 1
		Dim ans As Integer
		
		Do While True
			Do While True
				ans = x*y
				Console.Write("{0,3:d}", ans & ",")
				x += 1
				If x = 10 Then
					x = 1
					Exit Do
				End If
			Loop
			y += 1
			Console.WriteLine()
			If y = 10 Then
				Exit Do
			End If
		Loop
	End Sub
End Module