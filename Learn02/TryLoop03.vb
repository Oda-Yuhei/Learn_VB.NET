Module TryLoop03
	Sub Main()
		Dim sizeStr As String = Console.ReadLine()
		Dim size As Integer = Val(sizeStr)
		Dim count As Integer = 1
		
		For x As Integer = 1 To Size
			For i As Integer = 1 To count
				Console.Write("*")
				
			Next i
			
			Console.WriteLine()
			
			count += 1
		Next x
		
	End Sub
End Module