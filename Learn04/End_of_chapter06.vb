Module End_of_chapter06
    Sub main()
        For i As Integer = 1 To 10
            If i Mod 2 = 0 Then
                Console.WriteLine("数字" & i & "は偶数")
            Else
                Console.WriteLine("数字" & i & "は奇数")
            End If
        Next i
        Console.WriteLine()

        Dim x As Integer = 0
        Do While x < 5
            Console.WriteLine(x)
            x += 1
        Loop
    End Sub
End Module