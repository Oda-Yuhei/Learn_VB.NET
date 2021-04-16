Public Class Book
    Private title As String
    Private price As Integer

    Public Sub New(title As String, price As Integer)
        MyClass.title = title
        MyClass.price = price
    End Sub

    Public Sub disp()
        Console.WriteLine(MyClass.title & vbTab & MyClass.price)
    End Sub
End Class