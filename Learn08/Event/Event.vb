Public Class EventSmple1
    Public Event OnDataChanged()
    Public Sub TestMethod(ByRef x As Integer)
        x = x + 3
        Console.WriteLine(x)
        RaiseEvent OnDataChanged()
    End Sub
End Class