Module DoLoop02
	Sub Main()
		Dim count As Integer
		
		count = 0
		Do
			Console.WriteLine(count)
			count = count + 1
		Loop While count < 3
		Console.WriteLine("ループが終わりました")
		
		count = 0
		Do
			Console.WriteLine(count)
			count = count + 1
		Loop Until count >= 3
		Console.WriteLine("ループが終わりました")
		
	End Sub
End Module