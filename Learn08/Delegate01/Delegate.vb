Delegate Sub Calculate(ByVal x As Integer, ByVal y As Integer)
Public Class ShisokuEnzan
    Public Sub Tashizan(ByVal x As Integer, ByVal y As Integer)
        Console.WriteLine($"{x} + {y} = {x + y}")
    End Sub
    Public Sub Hikizan(ByVal x As Integer, ByVal y As Integer)
        Console.WriteLine($"{x} - {y} = {x - y}")
    End Sub
    Public Sub Kakezan(ByVal x As Integer, ByVal y As Integer)
        Console.WriteLine($"{x} x {y} = {x * y}")
    End Sub
    Public Sub Warizan(ByVal x As Integer, ByVal y As Integer)
        Console.WriteLine($"{x} / {y} = {x / y}")
    End Sub
End Class

