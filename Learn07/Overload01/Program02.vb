Module Program02
    Sub Display(str As String)
        Console.WriteLine(str)
        Console.WriteLine("----------")
    End Sub
    Sub Display(strArray As String())
        For Each str As String In strArray
            Display(str)
        Next
    End Sub
    Sub main()
        Dim language As String = "C"
        Dim languageArray As String() = {"Java", "C", "Visual Basic", "C#"}

        Display(language)
        Display(languageArray)
    End Sub
End Module