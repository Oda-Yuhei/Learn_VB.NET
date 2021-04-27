
' As句で型（整数型に限る）を指定できるデフォルトはInteger
Public Enum Season
    Spring
    Summer
    Autumn
    Winter
End Enum
Module Program
    Sub main()
        ' 列挙型は列挙型のメンバーの値が保証される
        Dim season1 As Season = Season.Summer
        Console.WriteLine($"{season1}")
        Console.WriteLine()

        ' 列挙型メンバーの走査
        For Each season As Season In [Enum].GetValues(GetType(Season))
            Console.WriteLine($"{season} = {season:d}")
        Next
    End Sub
End Module