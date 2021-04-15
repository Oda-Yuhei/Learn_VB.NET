Module End_of_chapter04
    Sub main()

        Console.WriteLine(10 + 5)
        Console.WriteLine(10 - 3)
        Console.WriteLine(2 * 8)
        Console.WriteLine(10 \ 3)
        Console.WriteLine()

        Dim A As Integer = 2
        A ^= 3
        Console.WriteLine(A)
        
        Dim B As Integer = 2
        B *= 3
        Console.WriteLine(B)

        Dim C As Integer = 10
        C \= 3
        Console.WriteLine(C)
        COnsole.WriteLine()

        Dim x As Integer
        x = 8 << 2
        Console.WriteLine(x)

        x = 2 >> 3
        Console.WriteLine(x)
        Console.WriteLine()

        Console.WriteLine("3=5:{0}",3=5)
        Console.WriteLine("3<>5:{0}",3<>5)
        Console.WriteLine("3>5:{0}",3>5)
        Console.WriteLine("3>=5:{0}",3>=5)
        Console.WriteLine("3<5:{0}",3<5)
        Console.WriteLine("3<=5:{0}",3<=5)
        Console.WriteLine()

        Dim text1 As String = "Visual"
        Dim text2 As String = "Basic"
        Console.WriteLine(text1 + text2)
        Console.WriteLine()

        x = 3 < 5 And 2 > 4
        Console.WriteLine(x) 
        x = 3 < 5 Or 2 > 4
        Console.WriteLine(x) 
        x = 3 < 5 XOr 2 > 4
        Console.WriteLine(x) 
        x = Not 1 > 5
        Console.WriteLine(x) 
        x = 5 < 1 AndAlso 2 > 4
        Console.WriteLine(x) 
        x = 5 > 1 OrElse 2 > 4
        Console.WriteLine(x) 

    End Sub
End Module