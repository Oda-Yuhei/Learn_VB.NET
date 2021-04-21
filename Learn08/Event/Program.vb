Module Program
    WithEvents EventSmpleClass As New EventSmple1

    Sub DataChanged() Handles EventSmpleClass.OnDataChanged
        Console.WriteLine("データが変更されました")
        
    End Sub
    Sub main()
        EventSmpleClass.TestMethod(5)
    End Sub
End Module