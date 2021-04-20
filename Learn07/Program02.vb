Module Program02
    Sub main()
        Dim gdate As New GDate(1970, 1, 1)

        Console.WriteLine(gdate.ElapsedDay(New GDate(2019,4,23)))
    End Sub
End Module