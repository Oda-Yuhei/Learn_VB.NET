Imports System.Collections.Generic
Module SortedList01
    Sub main()
        Dim fruit As New SortedList(Of Integer, String)

        fruit.Add(2, "リンゴ")
        fruit.Add(3, "ミカン")
        fruit.Add(1, "バナナ")

        Dim f As String = String.Empty
        fruit.TryGetValue(3,f)
        Console.WriteLine(f)

        For Each data As KeyValuePair(Of Integer, String) In fruit
            Console.WriteLine($"key = {data.Key}, value = {data.value}")
        Next

    End Sub
End Module