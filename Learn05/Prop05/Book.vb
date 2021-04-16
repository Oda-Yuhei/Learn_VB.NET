Public Class Book
    Public ReadOnly Property Title() As String
    Public ReadOnly Property Price() As Integer

    Public Sub New(title As String, price As Integer)
        _Title = title
        _Price = price
    End Sub

    Public Sub disp()
        Console.WriteLine("{0} {1}", _Title, _Price)
    End Sub
End Class