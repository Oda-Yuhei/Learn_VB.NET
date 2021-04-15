Module End_of_chapter07
    Sub main()
        Dim fruit() As String
        fruit = New String() {"リンゴ", "バナナ", "ミカン"}

        For i As Integer = 0 To fruit.Length - 1
            Console.WriteLine(fruit(i))
        Next i
        Console.WriteLine()

        Dim aluphabet(,) As String = {{"A","B"}, {"C","D"}, {"E","F"}, {"G","H"}, {"I","J"}, {"K","L"}, {"M","N"}, {"O","P"}, {"Q","R"}, {"S","T"}, {"U","V"}, {"W","X"}, {"Y","Z"}}

        For i As Integer = 0 To aluphabet.getLength(0) - 1
            For j As Integer = 0 To 1
                Console.WriteLine(aluphabet(i,j))
            Next j
            
        Next i
    End Sub
End Module
