Module DoLoop01
	Sub Main()
		Dim count As Integer
		
		count = 0
		Do While count < 3
			Console.WriteLine(count)
			count = count + 1
		Loop
		Console.WriteLine("ループが終わりました")
		
		count = 0
		Do Until count >= 3
			Console.WriteLine(count)
			count = count + 1
		Loop
		Console.WriteLine("ループが終わりました")
		
	End Sub
End Module
