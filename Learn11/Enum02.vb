Enum Month
    ' 初期値を代入すると下のメンバにも影響します(Februaryが2)
    January = 1
    February
    March
    April
    May
    June
    July
    August
    September
    October
    November
    December
End Enum

Module Program
    Sub main()
        For Each month As Month In [Enum].GetValues(GetType(Month))
            Console.WriteLine($"{month} = {month:d}")
        Next
    End Sub
End Module