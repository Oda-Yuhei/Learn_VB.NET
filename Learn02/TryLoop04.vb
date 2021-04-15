Module TryLoop04
	Sub Main()
		Dim sizeStr As String = Console.ReadLine()
		Dim size As Integer = Val(sizeStr)
		
		For i As Integer = 1 To size
			For j As Integer = 1 To i - 1
				Console.Write(" ")
				
			Next j
			For j As Integer = 0 To size - i
				Console.Write("*")
				
			Next j
			Console.WriteLine()
		Next i
	End Sub
End Module