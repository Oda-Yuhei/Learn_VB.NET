Module Program
    Sub main()
        Dim gdate As New GDate()

        COnsole.WriteLine(gdate.IsLeapYear(2000))
        COnsole.WriteLine(gdate.IsLeapYear(2020))
        COnsole.WriteLine(gdate.IsLeapYear(2019))
        COnsole.WriteLine(gdate.IsLeapYear(2100))
        Console.WriteLine()
        Console.WriteLine("-------------------------")

        Console.WriteLine(gdate.IsValidDate(2000, 2, 29))'うるう年
        Console.WriteLine(gdate.IsValidDate(2019, 2, 29))
        Console.WriteLine(gdate.IsValidDate(2020, 2, 29))'うるう年
        Console.WriteLine(gdate.IsValidDate(2020, 6, 31))
        Console.WriteLine()
        Console.WriteLine("-------------------------")

        Console.WriteLine(gdate.ElapsedDay(2000,2,29))
        Console.WriteLine(gdate.ElapsedDay(2019,2,29))
        Console.WriteLine(gdate.ElapsedDay(2020,2,29))
        Console.WriteLine(gdate.ElapsedDay(2020,6,31))
        Console.WriteLine(gdate.ElapsedDay(2020,4,23))
        Console.WriteLine()
        Console.WriteLine("-------------------------")

        Dim gdate As New GDate(1970, 1, 1)

        Console.WriteLine(gdate.ElapsedDay(New GDate(2019,4,23)))


    End Sub
End Module