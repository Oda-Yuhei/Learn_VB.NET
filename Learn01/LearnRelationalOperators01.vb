Module LearnRelationalOperators01
	Sub Main()
		Dim a As Integer = 10
		Dim b As Integer = 20
		
		'equal to
		Dim bool1 As Boolean = a = b
		Console.WriteLine(bool1)
		
		'not equal to
		Dim bool2 As Boolean = a<>b
		Console.WriteLine(bool2)
		
		'greater than
		Dim bool3 As Boolean = a > b
		Console.WriteLine(bool3)
		
		'less than
		Dim bool4 As Boolean = a<b
		Console.WriteLine(bool4)
		
		'greater than or equal to
		Dim bool5 As Boolean = a >= b
		Console.WriteLine(bool5)
		
		'less than or equal to
		Dim bool6 As Boolean = a <= b 
		Console.WriteLine(bool6)
	End Sub
End Module