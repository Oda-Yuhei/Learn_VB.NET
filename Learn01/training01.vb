Module Training01
	Sub main()
		Dim strMoth As String = Console.ReadLine()
		Dim m As Integer = val(strMoth)
		
		If m = 1 or m =3 or m = 5 or m = 7 or m =8 or m = 10 or m = 12 Then
			Console.WriteLine("31“ú")
		Else If m = 4 or m = 6 or m = 9 or m = 11
			Console.WriteLine("30“ú")
		Else If m = 2
			Console.WriteLine("28“ú")
		Else
			Console.WriteLine("“ü—Í‚ªŠÔˆá‚Á‚Ä‚¢‚Ü‚·")
		End If
	End Sub
End Module