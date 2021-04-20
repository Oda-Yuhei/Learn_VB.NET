Module Program
    Function Muitiplication(n As Integer, m As Integer)
        Return n * m
    End Function
    Function Muitiplication(n As Integer, m As Integer, l As Integer)
        Return n * m * l
    End Function

    Sub Main()
        Dim a As Integer = 10
        Dim b As Integer = 20
        Dim c As Integer = 30

        Dim ans1 As INteger = Muitiplication(10, 20)
        Console.WriteLine(a & "x" & b & "=" & ans1)

        Dim ans2 As Integer = Muitiplication(10, 20, 30)
        Console.WriteLine(a & "x" & b & "x" & c & "=" & ans2)
    End Sub
End Module