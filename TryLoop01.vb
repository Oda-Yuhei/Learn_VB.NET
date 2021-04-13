Module TryLoop01
    Sub main()

        Dim count As Integer = Val(Console.ReadLIne())
        Dim topCount As Integer = count
        Dim secCount As Integer = count
        Dim thrCount As Integer = count
        Dim forCount As Integer = count

        For i As Integer = 0 to topCount + count
            Console.Write(" ")
        Next i
        Console.WriteLine("*")

        For i As Integer = 1 To topCount
            For j As Integer = topCount + count To 1 step -1
                Console.Write(" ")
            Next j
            topCount -= 1
            Console.Write("*")
            For j As Integer = 1 To i
                Console.Write("**")
            Next
            Console.WriteLine()
            
        Next i
'top left-----------------------------------------------------
        For i As Integer = 1 To secCount
            Console.Write(" ")
        Next i
        Console.Write("*")
        Console.Write(" ")

        For i As Integer = thrCount + count-1 To 1 step -1
            Console.Write("*")
        Next i

        Console.Write(" ")
        Console.WriteLine("*")

        For i As Integer = 1 To secCount -1
            For j As Integer = secCount - 1 To 1 step -1
                Console.Write(" ")
            Next j
            secCount -= 1
            Console.Write("*")
            For j As Integer = 1 To i
                Console.Write("**")

            Next j
            Console.Write(" ")
'center--------------------------------------------------
            thrCount -= 1
            Console.Write("*")
            For j As Integer = thrCount -1 To 1 step -1  
                Console.Write("**")
            Next j
'right---------------------------------------------------

            Console.Write(" ")
            forCount -= 1
            Console.Write("*")
            For j As Integer = 1 To i
                Console.Write("**")

            Next j
            Console.WriteLine()
            
        Next i
'--------------------------------------------------------


        

    End Sub
End Module
