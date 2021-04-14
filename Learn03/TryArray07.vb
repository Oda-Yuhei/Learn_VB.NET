Module TryArray07
	Sub main()
		Dim numbers() As Integer
		numbers = New Integer(){50, 28, 27, 55, 12, 23, 99, 38, -5, 0}
        
        For i As Integer = 0 To UBound(numbers)
            Dim min As Integer = i
            For j As Integer = i + 1 To UBound(numbers)
                If numbers(min) > numbers(j) Then
                    min = j
                End If
                Dim x As Integer  = numbers(i)

                numbers(i) = numbers(min)
                numbers(min) = x
                
            Next j
        Next i

        For Each num As Integer In numbers
            Console.WriteLine(num)
        Next
        
	End Sub
End Module
