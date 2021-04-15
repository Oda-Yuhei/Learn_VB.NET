Module TryLoop05
	Sub main()
		Dim sizeStr As String = Console.ReadLine()
		Dim size As Integer = Val(sizeStr)
		
		For j As Integer = 0 To size
			Console.Write(" ")
		Next j
		Console.Write("*")
		Console.WriteLine()
		
		For i As Integer = 1 To size
			For j As Integer = 1 To size
				Console.Write(" ")
			Next j
			size -= 1
			
			For j As Integer = 1 To i
				Console.Write("**")
			Next j
			Console.Write("*")
			Console.WriteLine()
		Next i
	End Sub
End Module