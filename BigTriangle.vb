Module BigTriangle
	Sub Main()
		Dim height As Integer = CInt(Console.ReadLine())
		Dim RealHeight As Integer = Height * 2 + 1
		
		For i As Integer = 1 To realHeight
			For j As Integer = 1 To realHeight - i
				Console.Write(" ")
			Next j
			For j As INteger = 0 To (i - 1) * 2
				If realHeight = j OrElse (i - height -1) * 2 - 1 = j Then
					Console.Write(" ")
				Else
					Console.Write("*")
				End If
			Next j
			Console.WriteLine()
		Next i
	End Sub
End Module