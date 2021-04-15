Module TryLoop06
	Sub Main()
		Dim border As Integer = 2
		Dim count As Integer = CInt(Console.ReadLine())
		Dim spaceO As Integer = 2 + count
		Dim spaceT As Integer = 1 * count + 1
		
	'top-------------------------------------------------
		
		For i As Integer = 1 To count
			For j As Integer = 1 To count -i + spaceO
				Console.Write(" ")
			Next j
			For j As Integer = 1 To (i - 1) * 2 + 1
				Console.Write("*")
			Next j
			Console.WriteLine()
		Next i
		
	'border----------------------------------------------
		Dim x As Integer = count - 1
		For i As Integer = 1 To spaceT
			Console.Write(" ")
		Next i
		
		For i As Integer = 0 To border + x * 2
			Console.Write("*")
		Next i
		Console.WriteLine()
	'----------------------------------------------------
		
		For i As Integer = 1 To count
			'left----------------------------------------
			For j As Integer = 0 To count -i
				Console.Write(" ")
			Next j
			For j As Integer = 1 To (i - 1) * 2 + 1
				Console.Write("*")
			Next j
			'center--------------------------------------
			Console.Write(" ")
			
			For j As Integer = 1 To count - i
				Console.Write("**")				
			Next j
			Console.Write("*")
			'right---------------------------------------
			Console.Write(" ")
			
			For j As Integer = 1 To (i - 1) * 2 + 1
				Console.Write("*")
			Next j
			
			Console.WriteLine()
			
		Next i
	'----------------------------------------------------

	End Sub
End Module